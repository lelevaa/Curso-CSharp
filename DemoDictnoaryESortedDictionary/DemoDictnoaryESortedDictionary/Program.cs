using System.Collections.Generic;
Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "Maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "940028922";
cookies["phone"] = "837326555";

Console.WriteLine(cookies["phone"]);

cookies.Remove("email");

if (cookies.ContainsKey("email")) {
    Console.WriteLine(cookies["email"]);
}
else
{
    Console.WriteLine("Ther is no email key");
}

Console.WriteLine("size: " + cookies.Count());
Console.WriteLine("All cookies: ");
//percorre cada par
//foreach (var item in cookies) => também funciona
foreach (KeyValuePair<string,string> item in cookies) //forma verbosa 
{
    Console.WriteLine(item.Key + ":" + item.Value);
}
