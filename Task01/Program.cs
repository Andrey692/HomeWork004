// Задача 1: Задайте двумерный массив 
// символов (тип char [,]). Создать строку из символов этого массива.


char[,] chars = new char[,]
{
    {'M', 'y', 'm', 'y'},
    { 'r', 'y' ,'r', 'y'}
};

for (int i = 0; i < chars.GetLength(0); i++)    
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            System.Console.Write(chars[i,j]);
        }      
    }


