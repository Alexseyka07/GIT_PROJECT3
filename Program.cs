﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Я меня");
    }

    private static void Welcome(string name){
        System.Console.WriteLine($"Hi, {name}");
    }

    private static int Sum(int a, int b){
        return a + b;
    } 

    private static int Mult(int a, int b) {
        return a * b;
    }
}