using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib {
  public class AnimalSpawner {

    public AnimalSpawner() {
      NaAnimalsPreset = new string[] { "Boar", "Bear", "Bison", "Caribou", "Wolf" };
      SaAnimalsPreset = new string[] { "Python", "Jaguar", "Gecko", "Iguana", "Condor" };
    }

    public string SpawnBeast(int iterations) {
      var random = new Random();
      var result = new string[iterations];

      for (var x = 0; x < iterations; x++) {
        result[x] = mAnimals[random.Next(mAnimals.Length)];
      }

      return String.Join(" ", result);
    }

    public void GetSelection(string[] Selection) {
      mAnimals = Selection;
    }

    private string[] mAnimals;
    private string[] SaAnimalsPreset;
    private string[] NaAnimalsPreset;
  }
}
