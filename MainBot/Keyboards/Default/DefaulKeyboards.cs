using Telegram.Bot.Types.ReplyMarkups;

namespace MainBot.Keyboards.Default
{
    class DefaultKeyboards
    {
        private readonly static ReplyKeyboardMarkup _mainMenu = new[]
        {
            new[] { "Создать заказ", "Мои заказы(Разработка)"},
            new[] { "Баланс(Разработка)", "Рейтинг(Разработка)"},
        };
        public static ReplyKeyboardMarkup MainMenu {
            get {
                _mainMenu.ResizeKeyboard = true;
                return _mainMenu;
            }
        }
    }
}
