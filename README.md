# ArithmeticLibrary

`ArithmeticLibrary` is a lightweight, versatile .NET library for performing basic arithmetic operations such as addition, subtraction, multiplication, division, modulus, and unary operations across multiple numeric types including integers, decimals, floats, and doubles.

## Installation

To use `ArithmeticLibrary` in your project, follow these steps:

1. Clone this repository to your machine using `git clone https://github.com/HippieMagic/ArithmeticLibrary.git`.
2. Include the `ArithmeticLibrary` project in your solution.
3. Add a reference to the `ArithmeticLibrary` project from your own project.

## Usage

To perform arithmetic operations with `ArithmeticLibrary`, instantiate an `Arithmetic` object and call the required method:

```csharp
using ArithmeticLibrary;

var calculator = new Arithmetic();

// Addition
int sumInt = calculator.Add(5, 3);
decimal sumDecimal = calculator.Add(5.5m, 3.3m);

// Subtraction
float differenceFloat = calculator.Subtract(5.5f, 3.3f);

// Multiplication
double productDouble = calculator.Multiply(5.0, 3.0);

// Division
try
{
    decimal quotientDecimal = calculator.Divide(10m, 2m);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}

// Modulus
int remainderInt = calculator.Modulus(5, 3);

// Unary Operations
int incrementedValue = calculator.Increment(5);
