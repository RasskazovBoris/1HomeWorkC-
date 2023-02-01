Console.Write ("Instert the number: ");
int number = Convert.ToInt32 (Console.ReadLine());

int i = 1;

while (i <= number)
{
    if (i % 2 == 0)
    {
        if (i == number | i == number - 1){
        Console.Write (i + ".");
    }
    else{
        Console.Write(i + ", ");
    }
    }
    i++;
};
if (number < 2){
    Console.WriteLine ("Please, insert a number greater than 1.");
}