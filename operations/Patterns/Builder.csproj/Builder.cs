using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLib;

namespace Builder {
  public class BuilderClass {
    public BuilderClass() {
      NaSpawner = new NorthAmericanSpawner();
      SaSpawner = new SouthAmericanSpawner();
    }
    public void BuildPart(string locale, int amount) {
      if (locale == "NA") {
        animals = animals + " " + NaSpawner.SpawnBeast(amount);
      }

      else if (locale == "SA") {
        animals = animals + " " + SaSpawner.SpawnBeast(amount);
      }

      else {
        throw new Exception("No idea where " + locale + " is");
      }
    }

    public string AssembleParts() {
      return animals;
    }

    private string animals;
    private NorthAmericanSpawner NaSpawner;
    private SouthAmericanSpawner SaSpawner;
  }
}
