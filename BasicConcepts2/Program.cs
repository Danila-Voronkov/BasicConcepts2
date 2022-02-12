/*****************************************
* Автор:    Воронков Д.А.                *
* Название: Базовые понятия языка С# №2  *
* Дата:     07.02.2022                   *
*****************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Введите число n : ");

      string NumberN = Console.ReadLine();
      char SecondSign = NumberN[1];

      Console.WriteLine("Число x = " + NumberN.Remove(1, 1) + SecondSign);
      Console.ReadKey();
    }
  }
}