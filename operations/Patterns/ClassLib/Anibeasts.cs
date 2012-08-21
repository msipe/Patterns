using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLib {
  public class Anibeasts {
    public string SpawnBeast() {
      var animals = new string[] { "Boar", "Bear", "Bison", "Wildebeest" };
      var random = new Random().Next(4);
      return animals[random];
    }
  }
}
