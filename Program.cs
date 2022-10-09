using System;
using System.IO;
using System.Xml;

internal class Program
{
    private static void Main(string[] args)
    {
        string arquivo =
        @"E:\ale\projetoXML\AMS22_XML_FUT\Program.cs";
        int contador = 0;

        Console.Write("Digite os nomes dos times: ");
        string time = Console.ReadLine();

        Console.Write("Digite a quantidade de times: ");
        int quant = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        XmlTextWriter writer = new XmlTextWriter(arquivo, null);

        writer.WriteStartDocument();

        writer.Formatting = Formatting.Indented;

        writer.WriteStartElement(time.ToUpper().Replace(" ", " "));

        while (contador = quant)
        {
            contador++;

            Console.WriteLine($"Time {contador} ");

            Console.Write("Digite o nome do time: ");
            string id = Console.ReadLine();

            writer.WriterElementString(id, time.ToUpper());
        }

        writer.WriterEndElement();

        writer.Close();

        Console.WriteLine();

        Console.WriteLine("Itens inseridos com sucesso!");
    }
}