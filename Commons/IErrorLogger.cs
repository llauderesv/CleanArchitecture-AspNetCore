using System;

namespace Commons
{
  public interface IErrorLogger
  {
    void Log(Exception exception);

    void Log(string message);
  }
}