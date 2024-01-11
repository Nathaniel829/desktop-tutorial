var names = new List<string> { "<name>", "Ana", "Nathaniel" };
names.Add("Maria");
names.Add("Bill");
names.Remove("Ana");
names.Sort();
foreach (var name in names)
{
    Console.WriteLine(name);
}
var index = names.IndexOf("Ana");
if (index == 1)
{
    Console.WriteLine($"The name {names[index]} is on the right place");
}
else if (index == -1)
{
 Console.WriteLine($"The name is not found");
}
else 
{
    Console.WriteLine($"The name {names[index]} is not on the right place");
}
