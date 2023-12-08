// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Welcome to the restocking tool.");
Console.WriteLine("How many Sodas have been sold today? 100 are in stock.");
int soda = Convert.ToInt32(Console.ReadLine());
int sodaLeft = 100 - soda;
if (soda > 100)
{
    Console.WriteLine("That value is too high. Stock not adjusted.\n");
}
else 
{ 
    Console.WriteLine($"There are {sodaLeft} Sodas left.\n");
}


Console.WriteLine("How many Chips have been sold today? 40 are in stock.");
int chips = Convert.ToInt32(Console.ReadLine());
int chipsLeft = 40 - chips;
if (chips > 40)
{
    Console.WriteLine("That value is too high. Stock not adjusted.\n");
}
else 
{

    Console.WriteLine($"There are {chipsLeft} Chips left.\n");
}
Console.WriteLine("How many Candy have been sold today? 60 are in stock.");
int candy = Convert.ToInt32(Console.ReadLine());
int candyLeft = 60 - candy;
if (candy > 60)
{
    Console.WriteLine("That value is too high. Stock not adjusted.\n");
}
else
{

    Console.WriteLine($"There are {candyLeft} Candy left.\n");
}
Console.WriteLine("---------------------------------------------------------------------------------");
Console.WriteLine("Thank you for filling out the values.Here is what needs to be restocked:\n");
if (sodaLeft >=0 && sodaLeft <= 40)
{
    Console.WriteLine("Soda needs to be restocked");
    
}
if (chipsLeft <= 20 && chipsLeft >=0)
{
    Console.WriteLine("Chips need to be restocked");
}
if (candyLeft <= 40 && candyLeft >=0)
{
    Console.WriteLine("Candy needs to be restocked");

}
if (sodaLeft >40 && chipsLeft >20 && candyLeft >40) { Console.WriteLine("No need to restock."); }
Console.WriteLine("\nGoodbye!");
Console.ReadKey();