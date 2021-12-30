//Написать программу, которая из имеющегося массива
// целых чисел формирует массив из четных чисел.

int [] numbers = {2, 3, 4, 5, 7, 1, 8};//объявляем массив
int k = 0;
int j = 0;

//считаем количество четных чисел
for (int i = 0; i < numbers.Length; i++)
{
  if (numbers[i] % 2 == 0)
  {
    k++;
  }
}

int [] array = new int [k]; //создаем массив

//наполняем массив
for (int i = 0; i < numbers.Length; i++)
{
  if (numbers[i] % 2 == 0)
  {
    array [j] = numbers [i];
    j++;
  } 
}

//выводим в консоль
for (int i = 0; i < array.Length; i++)
{
  Console.WriteLine (array [i]);
}

