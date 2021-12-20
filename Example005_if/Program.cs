System.Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "лена")
{
    System.Console.WriteLine("Ура, это же ЛЕНА!");
}
else 
{
    System.Console.Write("Привет,  ");
    System.Console.WriteLine(username);
}