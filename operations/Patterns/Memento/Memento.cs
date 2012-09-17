using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MementoPattern {
  public class Memento {
    public Memento(string[] state) {
      mState = state;
    }

    public string[] GetSaved() {
      return mState;
    }

    private string[] mState;
  }
}