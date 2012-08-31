using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonClass {
  public interface ILog {
    void Info(string msg);
  }

  public static class Logger {
    private class Log: ILog {
      public void Info(string msg) {
        Console.WriteLine(msg);
      }
    }

    public static ILog Instance {
      get {
        return _Log;
      }
    }

    public static ILog GetInstance() {
      return _Log;
    }

    public static void Info(string msg) {
      _Log.Info(msg);
    }

    private static readonly Log _Log = new Log();
  }
}
