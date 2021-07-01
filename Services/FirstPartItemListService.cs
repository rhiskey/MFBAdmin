using MFBAdminMBlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFBAdminMBlazorServer.Services
{
  public class FirstPartItemListService: IFirstPartItemListService
  {
    private readonly web_nprtsContext _dbContext;
    public FirstPartItemListService(web_nprtsContext context)
    {
      _dbContext = context;
    }

    public void DeleteFirstPartItemList(long id)
    {
      var fpi = _dbContext.MfbDisclosureFirstPartItemLists.FirstOrDefault(x => x.Id == id);
      if (fpi != null)
      {
        _dbContext.MfbDisclosureFirstPartItemLists.Remove(fpi);
        _dbContext.SaveChanges();
      }
    }

    public void SaveFirstPartItemList(MfbDisclosureFirstPartItemList fpi)
    {
      if (fpi.Id == 0) _dbContext.MfbDisclosureFirstPartItemLists.Add(fpi);
      else _dbContext.MfbDisclosureFirstPartItemLists.Update(fpi);
      _dbContext.SaveChanges();
    }

    MfbDisclosureFirstPartItemList IFirstPartItemListService.GetFirstPartItemListById(long id)
    {
      var fpi = _dbContext.MfbDisclosureFirstPartItemLists.SingleOrDefault(x => x.Id == id);
      return fpi;
    }

    List<MfbDisclosureFirstPartItemList> IFirstPartItemListService.GetFirstPartItemLists()
    {
      return _dbContext.MfbDisclosureFirstPartItemLists.ToList();
    }
  }
}
