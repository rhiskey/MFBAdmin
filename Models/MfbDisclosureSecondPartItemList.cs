using System;
using System.Collections.Generic;

#nullable disable

namespace MFBAdminMBlazorServer.Models
{
    public partial class MfbDisclosureSecondPartItemList
    {
        public long Id { get; set; }
        public long Idp { get; set; }
        public int? Seq { get; set; }
        public string ItemListCategory { get; set; }
        public string ItemListDesc { get; set; }
        public string ItemListValue { get; set; }
        public int? ItemListType { get; set; }

        public virtual MfbDisclosureSecondPartItem IdpNavigation { get; set; }
    }
}
