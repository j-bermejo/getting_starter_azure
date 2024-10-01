
bool stop = false;
while (stop == false)
{
    main();
}
void main()
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(" ___________________");
    Console.WriteLine("¦ Calculadora       ¦");
    Console.WriteLine("¦-------------------¦");
    Console.WriteLine("¦ 1. Suma           ¦\n¦ 2. Resta          ¦\n¦ 3. Multiplicación ¦\n¦ 4. División       ¦");

    Console.WriteLine("¦___________________¦");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nEliga la operación que desea realizar");

    var option = Console.ReadLine();
    chooseOption(option);
    
    

}

void chooseOption(string option)
{
    switch (option)
    {
        case "1":
            suma();
        break;
        case "2":
            resta();
        break;
        case "3":
            multip();
        break;
        case "4":
            division();
        break;
        default:
            stop = true;
        break;
    }
}

void suma()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("SUMA");
    Console.WriteLine("Ingrese el primer valor ");
    var sum1 = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo valor ");
    var sum2 = Console.ReadLine();
    var result = double.Parse(sum1) + double.Parse(sum2);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("El resultado de "+ sum1 +" + "+ sum2 +" es = " + Math.Round(result, 4) + "\n");
}
void resta()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("RESTA");
    Console.WriteLine("Ingrese el primer valor ");
    var sum1 = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo valor ");
    var sum2 = Console.ReadLine();
    var result = double.Parse(sum1) - double.Parse(sum2);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("El resultado de "+ sum1 +" - "+ sum2 +" es = " + Math.Round(result, 4) + "\n");
}
void multip()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("MULTIPLICACION");
    Console.WriteLine("Ingrese el primer valor ");
    var sum1 = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo valor ");
    var sum2 = Console.ReadLine();
    var result = double.Parse(sum1) * double.Parse(sum2);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("El resultado de "+ sum1 +" x "+ sum2 +" es = " + Math.Round(result, 4) + "\n");
}
void division()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("DIVISION");
    Console.WriteLine("Ingrese el primer valor ");
    var sum1 = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo valor ");
    var sum2 = Console.ReadLine();
    var result = double.Parse(sum1) / double.Parse(sum2);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("El resultado de "+ sum1 +" / "+ sum2 +" es = " + Math.Round(result, 4) + "\n");
}