// MIS 3033 HW1
// Trotter Stewart
// 113499495

int cogs;
int gears;
double totalCost;
const double cogPrice = 79.99;
const double gearPrice = 250.00;
const double standardMarkup = 0.15;
const double specialMarkup = 0.125;
const double salesTax = 0.089;

Console.WriteLine("Please input the number of cogs: ");
cogs = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input the number of gears: ");
gears = Convert.ToInt32(Console.ReadLine());

totalCost = (cogs * cogPrice) + (gears * gearPrice);
double wMarkup = totalCost * standardMarkup;
double woMarkup = totalCost * specialMarkup;
double discountAmount = wMarkup - woMarkup;

Console.WriteLine("Receipt");


if (cogs > 10 || gears > 10 || gears + cogs >= 16)
{
    Console.WriteLine($"Total cost: {(totalCost + woMarkup + discountAmount).ToString("C2")}");
    Console.WriteLine($"Discount amount: {(discountAmount).ToString("C2")}");
    Console.WriteLine($"Sales tax: {((totalCost + woMarkup) * salesTax).ToString("C2")}");
    Console.WriteLine($"Grand total: {((totalCost + woMarkup) + ((totalCost + woMarkup) * salesTax)).ToString("C2")}");
}
else
{
    Console.WriteLine($"Total cost: {(totalCost + wMarkup).ToString("C2")}");
    Console.WriteLine("Discount amount: $" + 0.00);
    Console.WriteLine($"Sales tax: {((totalCost + wMarkup) * salesTax).ToString("C2")}");
    Console.WriteLine($"Grand total: {((totalCost + wMarkup) + ((totalCost + wMarkup) * salesTax)).ToString("C2")}");
}

Console.ReadKey();


