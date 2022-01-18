//Написать программу, которая из имеющегося массива
// целых чисел формирует массив из четных чисел.


//Однако блок-схемы у Вас вообще не соответствуют указанной задаче. 
//Код присутствует и работает, однако необходимо было разбивать его на методы,
 //так же не использовать Console.Write внутри методов, кроме метода печати.

//создаем массив
int [] numbers = new int [7]; //исходный массив
int k = 0; //количество четных чисел в исходном массиве
//int j = 0;

//метод наполнения массива
int[] napolnim(int [] arnapolnim)
{
  for (int i = 0; i < arnapolnim.Length; i++)
  {
     arnapolnim[i] = new Random().Next(1, 10); 
  }
    return arnapolnim;
}

//метод вывода на печать
void pechat(int [] arpechat)
{
  for (int i = 0; i < arpechat.Length; i++)
  {
    Console.WriteLine (arpechat[i]);
  } 
}

//считаем количество четных чисел
int chetnix(int [] archetnix)
{ 
  int ark = 0;
  for (int i = 0; i < archetnix.Length; i++)
  {
    if (archetnix[i] % 2 == 0)
      {
         ark++;
      }
  }
  return ark;
}

//метод возвращает массив четных чисел
int [] napolnimchetn(int [] arnapolnimchetn)
{
  int [] archetn = new int [k];
  int j = 0;
   for (int i = 0; i < arnapolnimchetn.Length; i++)
  {
     if (arnapolnimchetn[i] % 2 == 0)
     {
       archetn[j] = arnapolnimchetn[i];
       j++;
     } 
  }
  return archetn;
}

numbers = napolnim(numbers);//наполняем исходный массив

Console.WriteLine($"Выводим массив исходных чисел ");

pechat(numbers); //выводим на печать исходный массив

k = chetnix(numbers);//считаем количество четных чисел в массиве и кладет в переменную "к"

Console.WriteLine($"Выводим массив четных чисел ");

pechat(napolnimchetn(numbers));

