using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLib;

namespace Factory {
  public interface Animal {
    string Speak();
  }

  public class Boar: Animal {
    public string Speak() {
      return "oink";
    }
  }

  public class Lion: Animal {
    public string Speak() {
      return "roar";
    }
  }

  public class SpeakingAnimal: Animal {
    public SpeakingAnimal(string voice) {
      mVoice = voice;
    }
    public string Speak() {
      return mVoice;
    }

    private readonly string mVoice;
  }

  public class AbstractFactory {
    public AbstractFactory() {
    }

    public Messages CreateMessenger() {
      return new Messages("hi");
    }

    public NorthAmericanSpawner GetAnimal() {
      return new NorthAmericanSpawner();
    }

    public Animal BuildAnimal(string type) {
      if (type == "boar")
        return new Boar();
      else if (type == "lion")
        return new Lion();
      else if (type == "mouse")
        return mMouse;

      return new SpeakingAnimal("I do not know how to say: " + type);
    }

    private Animal mBoar = new Boar();
    private Animal mLion = new Lion();
    private Animal mMouse = new SpeakingAnimal("squeak");
  }
}
