Console.WriteLine("Веедите ваше имя ");
string username = Console.ReadLine();
if (username == "") {
    username = "Анонимус";
}
Console.Write("Привет, ");
Console.Write(username + "!");
