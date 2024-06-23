// See https://aka.ms/new-console-template for more information
using ConsoleApp4;

Console.WriteLine("Hello, World!");

//secondlast number
//int[] firtarrya = { 5, 8, 3, 1, 9, 7, 2, 4, 6,15 };
//int[] sortedarray = firtarrya.OrderByDescending(x => x).ToArray();
//int maxnum = sortedarray[1];
//Console.WriteLine("Max number is " + maxnum);

//combie and sort array
//int[] firtarrya = {1, 3, 5, 7, 9};
//int[] secondarray = { 2, 4, 6, 8, 10 };
//int[] finalarray = firtarrya.Concat(secondarray).ToArray();
// Array.Sort(finalarray);
//Console.WriteLine("Sorted Combined array");
//foreach (int item in finalarray)
//{
//    Console.Write(item + " ");
//}

//output of below code is 90
//int a, b, c, x;
//a = 90;
//b = 15;
//c = 3;
//x = a - b / 3 + c * 2 - 1;
//Console.WriteLine(x);
//Console.ReadLine();

//Outputter is odd number
//    int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//    func(ref a);
//    Console.ReadLine();

//static void func(ref int[] x)
//{
//    Console.Write(" numbers are : ");
//    for (int i = 0; i < x.Length; i++)
//    {
//        if (x[i] % 2 == 0)
//        {
//            x[i] = x[i] + 1;
//            Console.Write(x[i] + " ");
//        }
//    }//}

//maths obj = new maths();
//int i;
//int b = 90;
//int c = 100;
//int d = 12;
//float l = 14.78f;
//i = obj.fun(b, c);
//Console.WriteLine(i);
//int j = (obj.fun1(d, l));
//Console.WriteLine(j);
//Console.ReadLine();

//fibonacci series
//int num = 0, num1 = 1, num2,c;

//Console.WriteLine("Enter the number to get fibonacci series");
//num2=Convert.ToInt32( Console.ReadLine());
//if (num2 >= 1)
//{ Console.Write(num + " "); }

//if (num2 >= 2)
//{ Console.Write(num1 + " "); }

//for (int i = 3; i <= num2; i++)
//{
//    c = num + num1;
//    Console.Write(c + " ");
//    num = num1;
//    num1 = c;
//}

//Stringpalindromes obj= new Stringpalindromes();
//Console.WriteLine("Enter a string:");
//string input = Console.ReadLine();

////string output = new string(input.Reverse().ToArray());
////if (input == input)
////{
////    Console.WriteLine("The string is a palindrome R.");
////}

//if (obj.IsPalindrome(input))
//{
//    Console.WriteLine("The string is a palindrome.");
//}
//else
//{
//    Console.WriteLine("The string is not a palindrome.");
//}

Console.WriteLine("Enter a string:");
string input = Console.ReadLine();
NonRepetingFirstCharacter obj= new NonRepetingFirstCharacter();
char result = obj.GetnonrepetingFirstCharacter(input);
if (result != '\0')
{
    Console.WriteLine("The first non- repeting character is " + result);
}
else {
    Console.WriteLine("There are no non-repeting characters");
}

