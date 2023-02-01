Console.Write ("Insert first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Insert second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Insert third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int maxNumber = number1;
if (maxNumber < number2) maxNumber = number2;
if (maxNumber < number3) maxNumber = number3;

Console.WriteLine ("max = " + maxNumber);