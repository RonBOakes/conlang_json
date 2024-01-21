// See https://aka.ms/new-console-template for more information

using ConlangJson;
using System.Text.Json;
using System.Text.Json.Serialization;

if (args.Length < 1)
{
    System.Console.WriteLine("Please provide a file to parse");
    return 1;
}

string jsonString = File.ReadAllText(args[0]);

LanguageDescription? language = JsonSerializer.Deserialize<LanguageDescription>(jsonString);

if(language != null)
{
    System.Console.WriteLine("The language's English Name is: " + language.english_name);
    System.Console.WriteLine("The language's Native Name is:" + language.native_name_english);
}

System.Console.WriteLine("Press Enter to Continue/Exit");
System.Console.ReadLine();

return 0;