using System;
using System.Collections.Generic;

#nullable disable

namespace MFBAdminMBlazorServer.Models
{
  public partial class MfbDisclosureFirstPartItem
  {
    public MfbDisclosureFirstPartItem()
    {
      MfbDisclosureFirstPartItemLists = new HashSet<MfbDisclosureFirstPartItemList>();
    }

    public long Id { get; set; }
    public string RegulationCode { get; set; }
    public int? Seq { get; set; } // номер для сортировки показателей на странице (	кратно 10)
    public string ItemCode { get; set; }
    public string ItemDescription { get; set; }
    public int ItemShowFlags { get; set; } // Битовая маска для отображения списка: 1 – Не показывать publish_moment, 2 – Не показывать диапазон действия, 4 – Не показывать архивные данные. 0 - выводить все. 7 -ничего/Можно переделать на набор bool параметров
    public int Status { get; set; } // 0 - действующий показатель,1 - архивный показатель,2 - удаленный пункт/ по умолчанию 0
    public string Username { get; set; } //Лицо, внесшее изменение
    public DateTime? Now { get; set; } // Дата и время создания записи

    public virtual ICollection<MfbDisclosureFirstPartItemList> MfbDisclosureFirstPartItemLists { get; set; }
  }
}
