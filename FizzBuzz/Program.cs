using FizzBuzzService;

List<int> input = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
FizzBuzz service = new FizzBuzz();
List<string> outputFB = service.FuncFizzBuzz(input);
List<string> outputMB = service.FuncMuzzGuzz(input);
List<string> outputDC = service.FuncDogCat(input);
//Console.WriteLine(string.Join(",", outputFB));
//Console.WriteLine(string.Join(",", outputDC));
Console.WriteLine(string.Join(",", outputMB));