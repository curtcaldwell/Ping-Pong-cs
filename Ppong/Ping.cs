using System;
using System.Collections.Generic;

// namespace PingPong;

public class Ping
{
  static void Main()
  {
    Console.WriteLine("Enter a number: ");
    string UserNumber = Console.ReadLine();
    int IntUserNumber = int.Parse(UserNumber);

    if (IntUserNumber > 0 && IntUserNumber < 100)
    {
      for (int i = 1; i <= IntUserNumber; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("Ping-Pong");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("Pong");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("Ping");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
    }
    else if (IntUserNumber > 100)
    {
      Console.WriteLine("Please enter a number 1-100");
    }
  }
}
