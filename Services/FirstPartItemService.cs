using MFBAdminMBlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFBAdminMBlazorServer.Services
{
  public class FirstPartItemService: IFirstPartItemService
  {
    private readonly web_nprtsContext _dbContext;
    public FirstPartItemService(web_nprtsContext context)
    {
      _dbContext = context;
    }

    public void DeleteFirstPartItem(long id)
    {
      var fpi = _dbContext.MfbDisclosureFirstPartItems.FirstOrDefault(x => x.Id == id);
      if (fpi != null)
      {
        _dbContext.MfbDisclosureFirstPartItems.Remove(fpi);
        _dbContext.SaveChanges();
      }
    }

    public void SaveFirstPartItem(MfbDisclosureFirstPartItem fpi)
    {
      if (fpi.Id == 0) _dbContext.MfbDisclosureFirstPartItems.Add(fpi);
      else _dbContext.MfbDisclosureFirstPartItems.Update(fpi);
      _dbContext.SaveChanges();
    }

    MfbDisclosureFirstPartItem IFirstPartItemService.GetFirstPartItemById(long id)
    {
      var fpi = _dbContext.MfbDisclosureFirstPartItems.SingleOrDefault(x => x.Id == id);
      return fpi;
    }

    List<MfbDisclosureFirstPartItem> IFirstPartItemService.GetFirstPartItems()
    {
      return _dbContext.MfbDisclosureFirstPartItems.ToList();
    }
  }
}
