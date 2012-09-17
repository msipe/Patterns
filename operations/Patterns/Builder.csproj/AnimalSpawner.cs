using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MementoPattern;


namespace Builder {
  public class AnimalSpawner {

    public AnimalSpawner() {
      NaAnimalsPreset = new string[] { "Boar", "Bear", "Bison", "Caribou", "Wolf" };
      SaAnimalsPreset = new string[] { "Python", "Jaguar", "Gecko", "Iguana", "Condor" };
    }

    public string SpawnBeast() {
      var random = new Random();
      var result = new string[mIterations];

      for (var x = 0; x < mIterations; x++) {
        result[x] = mAnimals[random.Next(mAnimals.Length)];
      }

      return String.Join(" ", result);
    }

    public void SetSelection(string[] Selection) {
      mAnimals = Selection;
    }

    public void SaveSelection() {
      mSavedAnimals = new Memento(mAnimals).GetSaved();
    }

    public void GetSaved() {
        mAnimals = mSavedAnimals;
    }

    public void GetIterations(int iterations) {
      mIterations = iterations;
    }
    private int mIterations;
    private string[] mSavedAnimals;
    private string[] mAnimals;
    private string[] SaAnimalsPreset;
    private string[] NaAnimalsPreset;
  }
}
