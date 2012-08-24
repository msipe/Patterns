using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder {
  public class Director {
    public BuilderClass Construct() {
      return new BuilderClass();
    }
  }
}
