// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Создайте класс магазин.
// Необходимо хранить в приватных полях класса:
// название магазина, адрес, опсание профиля магазина
// контактный телефон, email
// Реализуйте метод класса для ввода данных, вывода данных
// Реализуйте доступ к отдельным полям через методы класса
class Magazin
{
    private string _MagazinName; // Название магазина
    private string _AddressName; // Адрес магазина
    public product ios; // структура
    static string tel_num = "8 901 245 33 22";
    static string email_num = "magazin@yandex.ru";

    public Magazin() //Конструктор по
                     //умолчанию
    {
        _MagazinName = "Нежда";
        _AddressName = "Кирова 15";
    }
    public void PrintState() //Распечатка текущих
                             //данных
    {
        Console.WriteLine($"{_MagazinName} продаёт {ios} товары по адресу {_AddressName}");
    }
}
enum product // класс магазина
{
    пиво,
    рыба,
    игрушки
}
class Program
{
    static void Main(string[] args)
    {
        Magazin myMagazin = new Magazin();
        myMagazin.PrintState();

    }
}