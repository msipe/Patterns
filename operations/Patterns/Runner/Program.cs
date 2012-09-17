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
      if (args.Length > 0) {
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
            var d = new BuilderDialogue("done");

            while (d.IsEnd() != true) {
              d.RetrieveAnimals();

              if (d.IsEnd()) {
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
      if (args.Length < 1) {
        Console.WriteLine("I am a robot. I am here to take American jobs");
      }
    }
  }
}
