// Написать программу, которая из имеющегося массива строк формирует новый 
// массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный
//  массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//   При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
//   исключительно массивами.





string[] InArray = new string[8] { "home", "or", "yes",  "peace", "color", "no", "on", "off" };
string[] OutArray = new string[InArray.Length];
int count = 0;
    for (int i = 0; i < InArray.Length; i++)
    { 
        if (InArray[i].Length <= 3)
        {
            OutArray[count] = InArray[i];
            count++;
            
        }
       
    }
    if (count==0)
    {
        Console.WriteLine("Все слова больше трех знаков ");
    }
    Console.Write(String.Join(" ", OutArray)); 
    Console.WriteLine();
