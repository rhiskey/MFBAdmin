using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MFBAdminMBlazorServer.Helpers
{
  public class FieldValidation
  {
    public static IEnumerable<string> SeqFpiCheck(int? seq)
    {
      int Seq = 0;
      try
      {
         Seq = (int)seq;
      } catch (Exception ex) { }
      if (Seq % 10 != 0)
      {
        yield return "Значение должно быть кратным 10!";
      }

      //try
      //{

      //}
      //catch( Exception ex) { }

    }
  }
}
