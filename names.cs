var names = new List<string> { "<name>", "Ana", "Felipe" };
names.Add("Nathaniel");
names.Remove(names[2]);
foreach (var name in names)
{
    Console.WriteLine(name);
}
