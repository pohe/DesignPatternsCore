// See https://aka.ms/new-console-template for more information
using OpenClosedV3;

Console.WriteLine("Hello, OpenClosedV3!");


ICalculator cal = new CalculatorV11();
Client c = new Client(cal);