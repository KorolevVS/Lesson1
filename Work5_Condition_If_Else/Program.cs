// программа приветствия пользователя (обычная/ особенная)
// If
// Else

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "vlad")
{
    Console.WriteLine("Здарова - неужели ты пришел!");
}
else
{
    Console.Write("Привет пользователь, ");
    Console.WriteLine(username);
}


