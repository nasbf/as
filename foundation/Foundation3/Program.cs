using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Swimming swim1 = new Swimming (new DateTime (2022,9,2), 15, 80);
        swim1.GetSumary();
        Run run1 = new Run(new DateTime(2024, 10, 15),30,20);
        run1.GetSumary();
        Cicling cic1 = new Cicling(new DateTime(2023, 1, 15),30,25);
        cic1.GetSumary();

    }
}