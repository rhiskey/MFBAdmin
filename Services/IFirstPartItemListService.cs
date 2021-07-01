using MFBAdminMBlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFBAdminMBlazorServer.Services
{
  public interface IFirstPartItemListService
  {
    List<MfbDisclosureFirstPartItemList> GetFirstPartItemLists();
    MfbDisclosureFirstPartItemList GetFirstPartItemListById(long id);
    void SaveFirstPartItemList(MfbDisclosureFirstPartItemList fpi);
    void DeleteFirstPartItemList(long id);
  }
}
