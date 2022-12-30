// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

System.Console.WriteLine("Введите элементы массива через точку с запятой\n Пример => sdf;12;sinple;gotolag;-2");
string[] arrayString = Array.ConvertAll<string,string>(Console.ReadLine().Split(';'), elem => { return System.Convert.ToString (elem);});
System.Console.WriteLine(string.Join(";",arrayString));