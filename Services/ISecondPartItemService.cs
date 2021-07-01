using MFBAdminMBlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFBAdminMBlazorServer.Services
{
  public interface ISecondPartItemService
  {
    List<MfbDisclosureSecondPartItem> GetSecondPartItems();
    MfbDisclosureSecondPartItem GetSecondPartItemById(long id);
    void SaveSecondPartItem(MfbDisclosureSecondPartItem fpi);
    void DeleteSecondPartItem(long id);
  }
}
