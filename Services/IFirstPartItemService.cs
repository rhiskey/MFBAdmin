using MFBAdminMBlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFBAdminMBlazorServer.Services
{
  public interface IFirstPartItemService
  {
    List<MfbDisclosureFirstPartItem> GetFirstPartItems();
    MfbDisclosureFirstPartItem GetFirstPartItemById(long id);
    void SaveFirstPartItem(MfbDisclosureFirstPartItem fpi);
    void DeleteFirstPartItem(long id);
  }
}
