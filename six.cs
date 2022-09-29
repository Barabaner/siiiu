Console.WriteLine($"Задача 41. Cколько чисел больше 0 ввёл пользователь \n");
Console.Write($"Введи число М(количество чисел): ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m){
for (int i = 0; i < m; i++)
  {
 Console.Write($"Введи {i+1} число: ");
 massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
 int count = 0;
 for (int i = 0; i < massiveNumbers.Length; i++)
  {
 if(massiveNumbers[i] > 0 ) count += 1; 
  }
 return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");
// Задача 43
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");