namespace Tasks2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();        // Хотел сделать задание "квест" потом вспомнил, что говорили про Random. В итоге получилась игра.
            string[] maps = { "красный", "синий" };
            int balls = 100;

            Console.WriteLine("Добро пожаловать в игру 'Угадай Карту'\n        Правила!!!");
            Console.WriteLine("У вас есть 100 баллов. Вы загадываете цвет: красный или синий. После чего мы поднимаем карту.\nУгадали: +100 баллов, если нет -100. Игра закончится если вы потеряете все баллы");

            while (balls >= 0)
            {
                string randomCart = maps[random.Next(maps.Length)];

                Console.Write("\nКарта на столе! Введите ваш ответ (красный/синий): ");
                var userGuess = Console.ReadLine();

                if (userGuess != "красный" && userGuess != "синий")
                {
                    Console.WriteLine("Ошибка, введите 'красный' или 'синий'.");
                    continue;
                }

                if (userGuess == randomCart)
                {
                    balls += 100;
                    Console.WriteLine($"Вы угадали! Цвет был {randomCart}. Ваши баллы: {balls}");
                }
                else
                {
                    balls -= 100;
                    Console.WriteLine($"Вы не угадали. Цвет был {randomCart}. Ваши баллы: {balls}");
                }

                if (balls == 0)
                {
                    Console.WriteLine("Вы проиграли! У вас закончались баллы.");
                    break;
                }
            }
        }
    }
}
