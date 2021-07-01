using System;
using System.Collections.Generic;

#nullable disable

namespace MFBAdminMBlazorServer.Models
{
    public partial class MfbFineRate
    {
        public long Id { get; set; }
        public DateTime? ReportDate { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string AssetIsin { get; set; }
        public decimal? FineShortVictim { get; set; }
        public decimal? FineLongVictim { get; set; }
        public decimal? FineShortGuilty { get; set; }
        public decimal? FineLongGuilty { get; set; }
        public decimal? FineShortDonor { get; set; }
        public decimal? FineLongDonor { get; set; }
        public decimal? BaseLimit { get; set; }
        public decimal? BaseLimitSurprise { get; set; }
        public decimal? MrStress { get; set; }
        public string GroupName { get; set; }
    }
}
