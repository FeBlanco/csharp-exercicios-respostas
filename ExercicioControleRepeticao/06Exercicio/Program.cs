Console.WriteLine("Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 maneiras diferentes:");


//for (int i = 10; i <= 20; i++)
//{
//    if (i % 2 == 0)
//    {
//        if (i == 16)
//            continue;

//        if (i == 21)
//            break;

//        Console.WriteLine(i);
//    }
//}



//int i = 10;
//while(i <= 20)
//{
//    if (i % 2 == 0)
//    {
//        if (i == 16)
//        {
//            i++;
//            continue;
//        }

//        if (i == 22)
//            break;

//    Console.WriteLine(i);
//    }
//    i++;
//}

int i = 10;
do
{
    if (i % 2 == 0)
    {
        if (i == 16)
        {
            i++;
            continue;
        }

        if (i == 22)
            break;

        Console.WriteLine(i);
    }
    i++;
} while (i <= 20);

Console.ReadKey();
