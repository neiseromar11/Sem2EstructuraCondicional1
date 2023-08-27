// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese los 3 numeros\n");
int num1=int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

if (num1 > num2 && num1 > num3)
{
    Console.WriteLine(num1 + " es mayor ");
}
else if (num2 > num1 && num2 > num3)
{
    Console.WriteLine(num2 + " es mayor");

}
else {

    Console.WriteLine(num3 + " es mayor");
}