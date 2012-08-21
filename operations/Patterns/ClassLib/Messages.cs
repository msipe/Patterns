using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ClassLib {
  public class Messages {
    public Messages(string message) {
      mMessage = message;
    }

    public string ToCaps() {
      return mMessage.ToUpper();
    }

    public string GiveMessage() {
      return mMessage;
    }

    private string mMessage;
  }
}
