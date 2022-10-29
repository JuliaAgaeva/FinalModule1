string[] array1 = new string[5] {"456", "45", "hello", "world", "-2"};
string[] array2 = new string[array1.Length];

    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
         Console.Write($"{array2[count]} ");
        count++;
        }   
        Console.WriteLine(); 
    







    