using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory;
using ClassLib;

namespace Runner2 {
  class Program {
    static void Main(string[] args) {
      var factory = new AbstractFactory();

      Console.WriteLine(factory.CreateMessenger().GiveMessage());
      Console.WriteLine(factory.GetAnimal().SpawnBeast());

      Console.WriteLine(factory.BuildAnimal("boar").Speak());
      Console.WriteLine(factory.BuildAnimal("lion").Speak());
      Console.WriteLine(factory.BuildAnimal("mouse").Speak());

      Console.WriteLine(factory.BuildAnimal("whale").Speak());

      if(args.Any())
      Console.WriteLine(factory.BuildAnimal(args[0]).Speak());
    }
  }
}
