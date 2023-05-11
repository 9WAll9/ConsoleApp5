using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;

using Telegram.Bot.Types;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using System.IO;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TelegramBotExperiments
{

    class Program
    {
        static InlineKeyboardMarkup myInlineKeyboard;
        static ITelegramBotClient bot = new TelegramBotClient("6140804330:AAF93QK29VcxlXueKexW5EZRsMhqVzZgjEE");

        public static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(update));
            if (update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                var message = update.Message;
                if (message.Text.ToLower() == "/start")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "Добро пожаловать, для получения списка доступных команд отправьте (команды)");
                    return;
                }
                if (message.Text.ToLower() == "команды")
                {
                    await botClient.SendTextMessageAsync(message.Chat, "1 - для того, чтобы ознакомиться с профессиональным стандартом технолога, воспользуйтесь командой (стандарт)" +
                        "\n 2 - для получения справки об организации информации в базах данных CAPP-систем, PDM-систем, MDM-систем воспользуйтесь (системы)" +
                        "\n 3 - повторить правила оформления технических отчетов (отчеты) " +
                        "\n 4 - обучение основам психологии общения и конфликтологии (психология) " +
                        "");
                    return;
                }
                if (message.Text.ToLower() == "системы")
                {
                    
                    await botClient.SendTextMessageAsync(message.Chat, " Выберите необходимую ситсему:CAPP-система(1), PDM-система(2), MDM-система(3)");
                       return;
             

                }
                if (message.Text.ToLower() == "1")
                {
                    Message newmessage1 = await botClient.SendPhotoAsync(
  message.Chat,
  photo: InputFile.FromUri("https://www.tadviser.ru/images/1/10/CAPP.png"),
  caption: "<b></b>. <i>Source</i>: <a href=\"https://static.tildacdn.com/tild3161-3762-4439-b839-666663356437/__.jpeg\">Pixabay</a>",
  parseMode: ParseMode.Html,
  cancellationToken: cancellationToken);
                    await botClient.SendTextMessageAsync(message.Chat, " Computer-Aided Process Planning (CAPP), автоматизированная технологическая подготовка производства — это программные продукты, помогающие автоматизировать процесс подготовки производства, а именно планирование (проектирование) технологических процессов. Задача CAPP следующая: по заданной модели изделия, выполненной в CAD-системе, составить план его производства — маршрут изготовления. В этот маршрут входят сведения о последовательности технологических операций изготовления детали, а также сборочных операциях (при необходимости); оборудование, используемое на каждой операции, приспособление и инструмент, при помощи которого на операциях выполняется обработка. Обычно технологическая подготовка производства заключается в проектировании технологических процессов на новые изделия, или адаптация технологических процессов по уже имеющейся базе типовых технологических процессов. Если говорить об автоматизации проектирования технологических процессов, то существует два подхода: вариативный и генеративный. Более подробная информация доступна по ссылке: https://www.tadviser.ru/index.php/Статья:CAPP ");
                    return;


                }
                if (message.Text.ToLower() == "2")
                {
                    Message newmessage1 = await botClient.SendPhotoAsync(
  message.Chat,
  photo: InputFile.FromUri("https://www.tadviser.ru/images/thumb/b/b2/Pdm2.jpg/300px-Pdm2.jpg"),
  caption: "<b></b>. <i>Source</i>: <a href=\"https://static.tildacdn.com/tild3161-3762-4439-b839-666663356437/__.jpeg\">Pixabay</a>",
  parseMode: ParseMode.Html,
  cancellationToken: cancellationToken);
                    await botClient.SendTextMessageAsync(message.Chat, " С помощью PDM-систем осуществляется отслеживание больших массивов данных и инженерно-технической информации, необходимых на этапах проектирования, производства или строительства, а также поддержка эксплуатации, сопровождения и утилизации технических изделий. Такие данные, относящиеся к одному изделию и организованные PDM-системой, называются цифровым макетом. PDM-системы интегрируют информацию любых форматов и типов, предоставляя её пользователям уже в структурированном виде (при этом структуризация привязана к особенностям современного промышленного производства). PDM-системы работают не только с текстовыми документами, но и с геометрическими моделями и данными, необходимыми для функционирования автоматических линий, станков с ЧПУ и др, причём доступ к таким данным осуществляется непосредственно из PDM-системы.\r\n\r\nС помощью PDM-систем можно создавать отчеты о конфигурации выпускаемых систем, маршрутах прохождения изделий, частях или деталях, а также составлять списки материалов. Все эти документы при необходимости могут отображаться на экране монитора производственной или конструкторской системы из одной и той же БД. Одной из целей PDM-систем и является обеспечение возможности групповой работы над проектом, то есть, просмотра в реальном времени и совместного использования фрагментов общих информационных ресурсов предприятия. https://www.tadviser.ru/index.php/Статья:PDM_(Product_Data_Management)_-_Управление_данными_об_изделии");
                    return;


                }
                if (message.Text.ToLower() == "3")
                {
                    Message newmessage1 = await botClient.SendPhotoAsync(
  message.Chat,
  photo: InputFile.FromUri("https://www.tadviser.ru/images/thumb/f/f8/Данные_-_алмазный_фонд_предприятия.png/680px-Данные_-_алмазный_фонд_предприятия.png"),
  caption: "<b></b>. <i>Source</i>: <a href=\"https://static.tildacdn.com/tild3161-3762-4439-b839-666663356437/__.jpeg\">Pixabay</a>",
  parseMode: ParseMode.Html,
  cancellationToken: cancellationToken);
                    await botClient.SendTextMessageAsync(message.Chat, " Управление основными данными (управление мастер-данными[1], англ. Master Data Management, MDM) — совокупность процессов и инструментов для постоянного определения и управления основными данными организации (в том числе справочными). Можно встретить и другое название — управление справочными данными (англ. Reference Data Management, RDM)[1], к этому варианту примыкает используемое на постсоветском пространстве фактически как синоним MDM понятие управления нормативно-справочной информацией (НСИ; хотя изначально в его рамках подразумевались только фиксированные, исходно наполняемые и изменяемые только в редких случаях справочники, что ближе по первоначальному смыслу к конфигурационным данным).\r\n\r\nМастер-данные — это данные с важнейшей для ведения бизнеса информацией: о клиентах, продуктах, услугах, персонале, технологиях, материалах и так далее. Они относительно редко изменяются и не являются транзакционными[1].\r\n\r\nПодходом к управлению основными данными предусматриваются такие процессы как сбор, накопление, очистка данных, их сопоставление, консолидация, проверка качества и распространение данных в организации, обеспечение их последующей согласованности и контроль использования в различных операционных и аналитических приложениях.\r\n\r\nЦель управления основными данными — удостовериться в отсутствии повторяющихся, неполных, противоречивых данных в различных областях деятельности организации. Например, данные о клиентах, возникающие и изменяющиеся в CRM-системе, должны соответствовать данным о контрагентах в ERP-системе и образовывать измерение в хранилище данных, доступное в BI-системе, — согласование этой информации и составляет одну из задач управления основными данными организации. Пример некачественного управления основными данными — это работа банка с клиентом, который уже использует кредитный продукт, однако по-прежнему получает предложения взять такой кредит. Причина неправильного поведения — отсутствие актуальных данных из автоматизированной банковской системы в CRM. https://www.tadviser.ru/index.php/MDM_-_Master_Data_Management_-_Управление_основными_мастер-данными");
                    return;
                }
                if (message.Text.ToLower() == "отчеты")
                    {
                        Message newmessage2 = await botClient.SendDocumentAsync(
    message.Chat,
    document: InputFile.FromUri("https://www.rea.ru/ru/org/managements/orgnirupr/Documents/gost_7.32-2017.pdf"),
    caption: "<b></b>. <i>Source</i>: <a href=\"https://pixabay.com\">Pixabay</a>",
    parseMode: ParseMode.Html,
    cancellationToken: cancellationToken);
                       


                    }
                if (message.Text.ToLower() == "психология")
                {
                    Message newmessage = await botClient.SendAudioAsync(
   message.Chat,
   audio: InputFile.FromStream("\\1.mp3"),
   
   cancellationToken: cancellationToken);



                }


                if (message.Text.ToLower() == "стандарт")
                {
                    Message newmessage = await botClient.SendAudioAsync(
    message.Chat,
    audio: InputFile.FromUri("https://github.com/TelegramBots/book/raw/master/src/docs/audio-guitar.mp3"),
    /*
    performer: "Joel Thomas Hunger",
    title: "Fun Guitar and Ukulele",
    duration: 91, // in seconds
    */
    cancellationToken: cancellationToken);
                    Message newmessage1 = await botClient.SendPhotoAsync(
   message.Chat,
   photo: InputFile.FromUri("https://static.tildacdn.com/tild3161-3762-4439-b839-666663356437/__.jpeg"),
   caption: "<b></b>. <i>Source</i>: <a href=\"https://static.tildacdn.com/tild3161-3762-4439-b839-666663356437/__.jpeg\">Pixabay</a>",
   parseMode: ParseMode.Html,
   cancellationToken: cancellationToken);
                    await botClient.SendTextMessageAsync(message.Chat, " https://classinform.ru/profstandarty/40.058-inzhener-tekhnolog-po-proizvodstvu-izdelii-mikroelektroniki.html по данной ссылке Вы можете ознакомиться с необходимой информацией.");
                    return;
                }

                await botClient.SendTextMessageAsync(message.Chat, "Отправьте другую команду");
            }
        }

        public static async Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            // Некоторые действия
            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(exception));
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Запущен бот " + bot.GetMeAsync().Result.FirstName);

            var cts = new CancellationTokenSource();
            var cancellationToken = cts.Token;
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }, // receive all update types
            };
            bot.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                receiverOptions,
                cancellationToken
            );
            Console.ReadLine();
        }
    }
}