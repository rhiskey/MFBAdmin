using System;
using System.Collections.Generic;

#nullable disable

namespace MFBAdminMBlazorServer.Models
{
  public partial class MfbDisclosureSecondPartItem
  {
    public MfbDisclosureSecondPartItem()
    {
      MfbDisclosureSecondPartItemLists = new HashSet<MfbDisclosureSecondPartItemList>();
    }

    public long Id { get; set; }
    public string RegulationCode { get; set; }
    public DateTime? PublishMoment { get; set; } //Дата и время опубликования записи
    public DateTime DateFrom { get; set; }// Начало отчетного периода 01.01.2021
    public DateTime? DateTo { get; set; }// Конец отчетного периода 31.03.2021
    public int Frequency { get; set; }// Период расчета показателя:   ежедневно, ежеквартально, ежегодно, на нерегулярной основе
    public int? Seq { get; set; }// с шагом 10 для удобства сортировки
    public string ItemCode { get; set; }// Код строки (по 5452-У) 4.4
    public string ItemNumber { get; set; }// Номер строки (по 5452-У) 2.20
    public string ItemDescription { get; set; }// Описание пункта указания, которое будет выводится на сайт.

    public int ItemType { get; set; }  // тип значения показателя - единичный или множественный. 0 - статическое значение или ссылка на внешний источник,  1 - дочерняя таблица в этом же окне, 2 - дочерняя динамическая таблица в отдельном окне, в URI передаются параметры показателя

    public string ItemValue { get; set; }//numeric(22,2) Значение пункта указания - 149908661,33
    public string ExtraDetails { get; set; }//название дочерней таблицы с расширенной детализацией (если есть): Список таблиц расширяется по мере добавления механизмов заполнения
    public int Status { get; set; } //0 - действующий пункт, 1 - архивный пункт, 2 - удаленный пункт/ по умолчанию 0
    public string Username { get; set; }// ) Лицо, внесшее изменение
    public DateTime? Now { get; set; }// Дата и время создания записи

    public virtual ICollection<MfbDisclosureSecondPartItemList> MfbDisclosureSecondPartItemLists { get; set; }
  }
}
