Console.Write ("Insert first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Insert second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2)
{
    Console.WriteLine ("First number = second number");
}

else if (number1 > number2)
{
    Console.WriteLine ("max = " + number1);
    Console.WriteLine ("min = " + number2);
}
else 
{
    Console.WriteLine ("max = " + number2);
    Console.WriteLine ("min = " + number1);
}