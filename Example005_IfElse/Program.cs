Console.WriteLine("Веедите ваше имя ");
string username = Console.ReadLine();

if (username.ToLower() == "вася") {
    Console.Write("Здорово, Васян, дружище!");
} else {
    if (username == "") {
        username = "Анонимус";
    }
    Console.Write("Привет, " + username + "!");
}