﻿using System;
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
          var director = new Director();
          var builder = director.Construct();
          var locale = "";

          while (locale != "done") {
            locale = Console.ReadLine();
            Console.WriteLine(locale);
            if (locale == "done") {
              break;
            }
            var amount = Console.ReadLine();
            builder.BuildPart(locale, int.Parse(amount));
          }
          Console.WriteLine(builder.AssembleParts());
          break;

        default:
          Console.WriteLine("Beep Boop");
          break;
      }
    }
  }
}
