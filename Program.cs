/*Программа которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.*/

int rnd = new Random().Next(3, 10);//Генерация нового массива
string[] array = new string[rnd];
for (int i = 0; i < array.Length; i++)
{
  int rndLength = new Random().Next(1, 5);
  string temp = "";

  for (int j = 0; j <= rndLength; j++)
  {
    temp += i + j;
  }

  array[i] = temp;
}
Console.WriteLine("Первоначальный массив:");
for (int i = 0; i < array.Length; i++) //Вывод в консоль нового массива
{
  Console.Write(array[i] + " ");
}

Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)//Определение длинны нового массива
{
  if (array[i].Length <= 3) count++;
}
if (count == 0)//Проверка равна ли длинна массива 0
{
  Console.WriteLine("В массиве нет строк с длинной меньше или равно 3 символам.");
}
else
{

  string[] arrayNew = new string[count]; //Объявление нового массива
  int countNewArray = 0;

  for (int i = 0; i < array.Length; i++) // Заполнение нового массива
  {
    if (array[i].Length <= 3)
    {
      arrayNew[countNewArray] = array[i];
      countNewArray++;
    }
  }

  Console.WriteLine("Новый массив:"); //Вывод в консоль нового массива
  for (int i = 0; i < arrayNew.Length; i++)
  {
    Console.Write(arrayNew[i] + " ");
  }
}