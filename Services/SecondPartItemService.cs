using MFBAdminMBlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MFBAdminMBlazorServer.Services
{
  public class SecondPartItemService : ISecondPartItemService
  {
    private readonly web_nprtsContext _dbContext;
    public SecondPartItemService(web_nprtsContext context)
    {
      _dbContext = context;
    }

    public void DeleteSecondPartItem(long id)
    {
      var spi = _dbContext.MfbDisclosureSecondPartItems.FirstOrDefault(x => x.Id == id);
      if (spi != null)
      {
        _dbContext.MfbDisclosureSecondPartItems.Remove(spi);
        _dbContext.SaveChanges();
      }
    }

    public void SaveSecondPartItem(MfbDisclosureSecondPartItem spi)
    {
      if (spi.Id == 0) _dbContext.MfbDisclosureSecondPartItems.Add(spi);
      else _dbContext.MfbDisclosureSecondPartItems.Update(spi);
      _dbContext.SaveChanges();
    }

    MfbDisclosureSecondPartItem ISecondPartItemService.GetSecondPartItemById(long id)
    {
      var spi = _dbContext.MfbDisclosureSecondPartItems.SingleOrDefault(x => x.Id == id);
      return spi;
    }

    List<MfbDisclosureSecondPartItem> ISecondPartItemService.GetSecondPartItems()
    {
      return _dbContext.MfbDisclosureSecondPartItems.ToList();
    }
  }
}
