﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Я меня main в другой ветке!!!");
    }

    private static void Welcome(){
        System.Console.WriteLine("Hi");
    }

    private static int Sum(int a, int b){
        return a + b;
    } 
}