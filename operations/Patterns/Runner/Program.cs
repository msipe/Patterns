using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory;
using ClassLib;
using Builder;
using SingletonClass;

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
          var spawner = new AnimalSpawner();
          var flag = "";
          var d = new DialogueExpiditor("done");

          while (flag != "done") {
            flag = d.RetrieveAnimals();

            if (flag == "done") {
              break;
            }

            d.RetrieveIterations();
            d.SaveSelection();
            d.DisplayAnimals();
          }

          break;

        case "single":
          var msg = Console.ReadLine();

          ILog log = Logger.GetInstance();
          log.Info("hello world");

          Logger.GetInstance().Info("here");
          Logger.Instance.Info("here");
          Logger.Info("here"); 
          break;

        default:
          Console.WriteLine("Beep Boop");
          break;
      }

    }
  }
}
