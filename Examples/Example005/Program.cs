Console.WriteLine("Ведите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "натали")
{ 
    Console.WriteLine("Это же Натали!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
    }