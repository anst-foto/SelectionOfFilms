using SelectionOfFilms.Lib;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using File = System.IO.File;


var apiToken = File.ReadAllText("telegram_api.key");
var botClient = new TelegramBotClient(apiToken);

using CancellationTokenSource cts = new ();

// StartReceiving does not block the caller thread. Receiving is done on the ThreadPool.
ReceiverOptions receiverOptions = new ()
{
    AllowedUpdates = Array.Empty<UpdateType>() // receive all update types except ChatMember related updates
};

botClient.StartReceiving(
    updateHandler: HandleUpdateAsync,
    pollingErrorHandler: HandlePollingErrorAsync,
    receiverOptions: receiverOptions,
    cancellationToken: cts.Token
);

var me = await botClient.GetMeAsync();

Console.ReadLine();
cts.Cancel();
return;

async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
{
    if (update.Message is not { } message)
        return;
    if (message.Text is not { } messageText)
        return;
    var chatId = message.Chat.Id;
    
    var genre = messageText.Trim('/');
    var film = KinopoiskApi.GetRandomFilm(genre);
    if (film.PosterUrl is null)
    {
        await botClient.SendTextMessageAsync(
            chatId: chatId,
            text: "**!!!** Ничего не нашли **!!!**",
            parseMode: ParseMode.Markdown,
            disableNotification: true,
            replyToMessageId: update.Message.MessageId,
            replyMarkup: new InlineKeyboardMarkup(
                InlineKeyboardButton.WithUrl(
                    text: "Кинопоиск",
                    url: "https://www.kinopoisk.ru/")),
            cancellationToken: cancellationToken);

    }
    else
    {
        await botClient.SendPhotoAsync(
            chatId: chatId,
            photo: InputFile.FromUri(film.PosterUrl),
            caption: $"**{film.Name}**",
            parseMode: ParseMode.Markdown,
            replyToMessageId: update.Message.MessageId,
            cancellationToken: cancellationToken);
    }
}

Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
{
    var ErrorMessage = exception switch
    {
        ApiRequestException apiRequestException
            => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
        _ => exception.ToString()
    };

    Console.WriteLine(ErrorMessage);
    return Task.CompletedTask;
}