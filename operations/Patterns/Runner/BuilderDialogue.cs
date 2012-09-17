using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Builder;

namespace Runner2 {
  public class BuilderDialogue {
    public BuilderDialogue(string endPhrase) {
      mEndPhrase = endPhrase;
      mSpawner = new AnimalSpawner();
      mEnd = false;
    }

    public void RetrieveAnimals() {
      var delimiters = new char[] {' '};
      Console.WriteLine();
      Console.WriteLine("Enter Animals (Type " + mEndPhrase  + " to exit)");
      mDisplay = Console.ReadLine();
      
      if (mDisplay == mEndPhrase) {
        mEnd = true;
      }

      mSpawner.SetSelection(mDisplay.Split(delimiters));
    }

    public void RetrieveIterations() {
      var delimiters = new char[] { ' ' };
      Console.WriteLine();
      Console.WriteLine("Number of times?");
      mSpawner.GetIterations(int.Parse(Console.ReadLine()));
    }

    public void SaveSelection() {
      if (mDisplay != "get") {
        Console.WriteLine();
        Console.WriteLine("Save this selection?");
        mSaved = Console.ReadLine();

        if (mSaved == "yes" || mSaved == "y") {
          mSpawner.SaveSelection();
        }
      }
    }

    public void DisplayAnimals() {
      if (mDisplay == "get") {
        mSpawner.GetSaved();
      }

      Console.WriteLine();
      Console.WriteLine(mSpawner.SpawnBeast());
    }

    public bool IsEnd() {
      if (mEnd == true) {
        return true;
      }
      return false;
    }

    private bool mEnd;
    private string mDisplay;
    private string mSaved;
    private string mEndPhrase;
    private AnimalSpawner mSpawner;
  }
}
