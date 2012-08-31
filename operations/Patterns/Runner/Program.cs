using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory;
using ClassLib;
using Builder;

namespace Runner2 {
  class Program {
    static void Main(string[] args) {

      switch (args[0]) {
        case "factory":
          var factory = new AbstractFactory();

          Console.WriteLine(factory.CreateMessenger().GiveMessage());
          Console.WriteLine(factory.BuildAnimal("boar").Speak());
          Console.WriteLine(factory.BuildAnimal("lion").Speak());
          Console.WriteLine(factory.BuildAnimal("mouse").Speak());
          Console.WriteLine(factory.BuildAnimal("whale").Speak());
          break;

        case "builder":
          var builder = new BuilderClass();
          var spawner = new AnimalSpawner();
          var flag = "";
          var delimiters = new char[] {' '};

          while (flag != "done") {
            Console.WriteLine();
            Console.Write("Enter Animals (done to exit)");
            flag = Console.ReadLine();

            if (flag == "done") {
              break;
            }

            var iterations = int.Parse(Console.ReadLine());
          
            spawner.GetSelection(flag.Split(delimiters));
            Console.WriteLine(spawner.SpawnBeast(iterations));
          }

          break;

        case "single":
          Console.WriteLine("Yo Yo");
          //var single = new SingletonClass();
          Console.WriteLine("yo");

          break;

        default:
          Console.WriteLine("Beep Boop");
          break;
      }
    }
  }
}
