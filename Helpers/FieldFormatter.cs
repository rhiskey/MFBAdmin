using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MFBAdminMBlazorServer.Helpers
{
  public class FieldFormatter
  {
    public static string FormatDateTime(DateTime? dt)
    {
      string formattedDate = "";
      try
      {
        DateTime dtNew = (DateTime)dt;
        formattedDate = dtNew.ToString("dd.MM.yyyy HH:mm");
      }
      catch (Exception ex)
      {
        formattedDate = "";
      }
      return formattedDate;
    }

  }
}
