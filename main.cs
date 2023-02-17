using System;

class Program {
  public static void Main () {
  Console.BackgroundColor = ConsoleColor.Black;
  Console.ForegroundColor = ConsoleColor.DarkGreen;
  Console.Clear();
  Console.WriteLine ("This is a calculator. This is designed for use with simple math equations.");
    for(var t = 0; t < t+1; t++){
    string num1;
    string num2;
    float num1t;
    float num2t;
    string symbol;
    float altanswer;
    //Placeholder number
    altanswer = 1;
    Console.WriteLine("Enter your first number:");
   num1 = Console.ReadLine();
    num1t = float.Parse(num1);
      Console.Clear();
    Console.WriteLine("Enter your symbol:");
    Console.WriteLine(num1);
    Console.SetCursorPosition((num1.Length + 1), 1);
    symbol = Console.ReadLine();
      Console.Clear();
    Console.WriteLine("Enter your second number:");
      Console.WriteLine(num1 + " " + symbol);
      Console.SetCursorPosition((symbol.Length + num1.Length + 2), 1);
    num2 = Console.ReadLine();
    num2t = float.Parse(num2);
    switch (symbol){
    case "*":
      altanswer = num1t * num2t;
      break;
    case "/":
      altanswer = num1t / num2t;
      break;
    case "+":
      altanswer = num1t + num2t;
      break;
    case "-":
      altanswer = num1t - num2t;
      break;
    case "%":
      altanswer = num1t % num2t;
      break;
    default: 
      Console.WriteLine("Operator is not able to be operated on.");
      break;
      }
        Console.Clear();
        Console.WriteLine(num1t + " " + symbol + " " + num2t + " = " + altanswer);
    for(var i = 0; i < Console.WindowWidth; i++){
      Console.SetCursorPosition(i, 1);
      Console.WriteLine("-");
    }
  }
}
  }