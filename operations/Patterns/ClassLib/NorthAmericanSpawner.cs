using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib {
  public class NorthAmericanSpawner {
    public string SpawnBeast(int iterations) {
      var animals = new string[] { "Boar", "Bear", "Bison", "Caribou", "Wolf" };
      var random = new Random();
      var result = new string[iterations];

      for (var x = 0; x < iterations; x++) {
        result[x] = animals[random.Next(5)];
      }

      return String.Join(" ", result);
    }
  }
}
