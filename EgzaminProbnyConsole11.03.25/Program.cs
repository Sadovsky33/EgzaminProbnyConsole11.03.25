Console.WriteLine("wprowadz a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("podaj b");
int b = int.Parse(Console.ReadLine());
//if (a != b)
//{
//    if (a > b)
 //   {
 //       if (a%2 == a - b )

       // {




     //   }



   // }


//}
//else
//{
   // Console.WriteLine(a);
//}


while (a != b)
{
    if (a > b)
    {
        if (a % 2 == a - b)

        {


            return;

        }

    }
    else
    {
     //  b % 2 == b - a

    }

}
if (a == b)
{
    Console.WriteLine(a);
}