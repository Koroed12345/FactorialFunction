using FactorialFunction;

int lessZeroNumber = -5;
int zero = 0;
int greaterZeroNumber = 5;

int result1 = FactorialNumber.Calculate(lessZeroNumber);
int result2 = FactorialNumber.Calculate(zero);
int result3 = FactorialNumber.Calculate(greaterZeroNumber);


Console.WriteLine($"Result for {lessZeroNumber}!: {result1}");
Console.WriteLine($"Result for {zero}!: {result2}");
Console.WriteLine($"Result for {greaterZeroNumber}!: {result3}");