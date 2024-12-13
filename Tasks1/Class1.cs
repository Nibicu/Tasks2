namespace Tasks1
{
    public class Class1
    {
        static void Main(string[] args)
        {
            var class1 = new Class1();
            Console.Write("Введите ваше ФИО: ");
            var firstName = Console.ReadLine();
            Console.Write("Введите вашу дату рождения (дд.мм.гггг): ");
            var dateOfBirth = Console.ReadLine();
            Console.WriteLine($"\nВаши данные!\n ФИО - {firstName}\n Дата рождения - {dateOfBirth}");
            Console.ReadKey();
        }
    }
}
