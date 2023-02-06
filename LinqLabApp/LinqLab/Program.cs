// Linq Lab

int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };

var min = nums.Select(x => x).Min();
var max = nums.Select(y => y).Max();
var Maxvallt10k  = nums.Where(x => x < 10000).Max();
var ValBt10to100 = nums.Where(x => x > 10 && x < 100);
var ValBt100kto1mil = nums.Where(x => x >= 100000 && x <= 999999);

Console.WriteLine("Minimum Val: " + min);
Console.WriteLine("Maximum val: " + max);
Console.WriteLine("Maximum Value less than 10000: " + Maxvallt10k);
Console.WriteLine();
Console.WriteLine("Values between 10 and 100: ");
foreach ( int values in ValBt10to100)
{
    Console.WriteLine($"{values} ");  


}
Console.WriteLine();
Console.WriteLine("Values between 100000 and 999999 inclusive: ");
foreach(int n in ValBt100kto1mil)
{
    Console.WriteLine(n);
}
Console.WriteLine();

var EvenNumbers = nums.Where(x => x % 2 == 0).Count();
Console.WriteLine( "Count of Even numbers: " + EvenNumbers);