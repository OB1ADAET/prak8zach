namespace prak8
{
    internal class table
    {
        public static void Table()
        {
            Console.WriteLine("Введите имя для таблицы рекордов: ");
            string name = Console.ReadLine();
            Console.Clear();

            int index = Tipe.TypingTest("");

            List<Users> users = Users.Serializing(name, index);

            Console.WriteLine("Таблица рекордов: ");
            Console.WriteLine(new string('=', 18));

            foreach (Users item in users)
            {
                Console.WriteLine($"{item.name}\t{item.charsPerMinute} символов в минуту\t{item.charsPerSecond} символ в секунду");
            }

            Console.WriteLine("чтобы пройти тест заново - нажмите Enter");
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Enter)
            {
                Table();
            }
        }
    }
}
