// See https://aka.ms/new-console-template for more information
using ConsoleApp;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Net;
using System.Numerics;

Run();


 static void Run()
{
    int[] array = { 64, 34, 25, 12, 22, 11, 90 };
    Console.WriteLine("Unsorted array:");
    Console.WriteLine(string.Join(", ", array));

    int[] sortedArray =CsharpTwelveDemo.BubbleSort(array);

    Console.WriteLine("Sorted array:");
    Console.WriteLine(string.Join(", ", sortedArray));
    Console.ReadKey();
}


