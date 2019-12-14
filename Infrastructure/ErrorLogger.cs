using System;
using Commons;
using Microsoft.AspNetCore.Http;

namespace Infrastructure
{
  public class ErrorLogger : IErrorLogger
  {
    private HttpContext contextBase { get; }

    public void Log(Exception exception)
    {
      if (contextBase != null)
      {
      }
    }

    public void Log(string message)
    {
      throw new NotImplementedException();
    }
  }
}
