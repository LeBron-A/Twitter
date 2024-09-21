using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Message");
    string message = Console.ReadLine();
    if (message. Length <= 140) {
      Console.WriteLine("posted");
    }
    else {
      Console.WriteLine("rejected");
    }
  }
}