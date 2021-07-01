using System;
using System.Collections.Generic;

#nullable disable

namespace MFBAdminMBlazorServer.Models
{
  public partial class MfbDisclosureFirstPartItemList
  {
    public long Id { get; set; }
    public long Idp { get; set; } //Ссылка на пункт раскрытия
    public int? Seq { get; set; } // Для сортировки однородных пунктов
    public DateTime? PublishMoment { get; set; } //Дата и время опубликования записи
    public DateTime? DateFrom { get; set; }// Дата начала действия записи
    public DateTime? DateTo { get; set; }//Дата окончания действия записи
    public string ItemListDesc { get; set; }//Описание ссылки/документа
    public string ItemListValue { get; set; }//Ссылка/статик
    public int? ItemListType { get; set; }// 0-прямая ссылка,  1 - ссылка с текстом,   2 - статический текст
    public int Status { get; set; }//0 - действующий пункт,   1 - архивный пункт,2 - удаленный пункт.по умолчанию 0 
    public string Username { get; set; }// Лицо, внесшее изменение
    public DateTime? Now { get; set; }//Дата и время создания записи
    public string ItemListCategory { get; set; }//Категория параметра
    public string Memo { get; set; }//Комментарий в свободной форме

    public virtual MfbDisclosureFirstPartItem IdpNavigation { get; set; }
  }
}
