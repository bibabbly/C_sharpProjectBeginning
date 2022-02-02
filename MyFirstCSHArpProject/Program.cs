// See https://aka.ms/new-console-template for more information

//SayHi("Theo");
///SayHi("Icyeza");
//SayHi("Amandine");
//Console.WriteLine(cubedNumber(7));
Console.WriteLine(getMaxValeur(10, 10));
Console.ReadLine();

static void SayHi(String name)
{
    Console.WriteLine("Hello "+ name);
}

static int cubedNumber(int number) {

    return (number * number * number);
}

static int getMaxValeur(int num1, int num2) {

    if (num1 > num2)
    {
        return num1;
    }
    else if (num1 < num2)
    {
        return num2;
    }
    else return 0;


}



//Console.WriteLine("Hello, World!");

//Console.WriteLine(Math.Pow(4, 4));

///Console.Write("Enter Your Name: ");
//String name=Console.ReadLine();
//Console.Write("Enter Your Age :");
//String age = Console.ReadLine();

//Console.WriteLine("Hello "+name+ " You are "+age);

//Console.Write("Enter First Number ");
//double num1= Convert.ToDouble(Console.ReadLine());

//Console.Write("Enter First Number ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("The additional of two numbers is " + (num1 + num2));

//int[] numbers = {10,22,24,50 };
//Console.WriteLine(numbers[3]);

//String[] friends = new String[6];
//friends[0] = "Theo";
//friends[1] = "Bizimungu";
//friends[2] = "Mupenzi";
//friends[3] = "Romeo";
//friends[4] = "Icyeza";
//friends[5] = "Amandine";

//for (int i = 0; i < friends.Length; i++) { 
//    Console.WriteLine(friends[i]);
//}




