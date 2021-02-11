using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EncoraTestBLL.Models
{
    public class Property
    {

        #region class properties

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public int? Id { get; set; }

        public int? AccountId { get; set; }

        public int? BuyerAccountId { get; set; }

        public int? ExternalId { get; set; }

        public int? ProgramId { get; set; }

        public bool? IsDwellCertified { get; set; }

        public bool? IsAllowOffer { get; set; }

        public bool? IsAllowPreview { get; set; }

        public bool? IsFeature { get; set; }

        public bool? IsRentGuaranteed { get; set; }

        public bool? AllowRentGuaranteedOptout { get; set; }

        public bool? IsSecuritized { get; set; }

        public bool? IsHot { get; set; }

        public bool? IsNew { get; set; }

        public bool? IsBargain { get; set; }

        public bool? IsDiligenceVaultUnlocked { get; set; }

        public bool? IsPropertyManagerOfferRetain { get; set; }

        public bool? IsHoa { get; set; }

        public bool? HasAudio { get; set; }

        public bool? HasDiligenceVaultDocuments { get; set; }

        public int? MarketId { get; set; }

        public int? DaysOnMarket { get; set; }

        public long? Latitude { get; set; }

        public long? Longitude { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Highlights { get; set; }

        public string MainImageUrl { get; set; }

        public string PersonalProperties { get; set; }

        public string DiligenceVaultSummary { get; set; }

        public string FeaturedReason { get; set; }

        public string Status { get; set; }

        public string AllowedFundingTypes { get; set; }

        public string AllowableSaleTypes { get; set; }

        public string Visibility { get; set; }

        public string PriceVisibility { get; set; }

        public string Type { get; set; }

        public string CertificationLevel { get; set; }

        public DateTime? EscrowClosingDate { get; set; }

        public Address Address { get; set; }

        public Financial Financial { get; set; }

        public Physical Physical { get; set; }

        public Score Score { get; set; }

        public Valuation Valuation { get; set; }

        public Resource Resource { get; set; }

        public string Manager { get; set; }

        public string Seller { get; set; }

        public string SellerBroker { get; set; }

        public string Hoa { get; set; }

        public Lease Lease { get; set; }

        public List<Diligence> Diligences { get; set; }

        public GoogleMapOption GoogleMapOption { get; set; }

        public string InspectionType { get; set; }

     

        #endregion



        public Property()
        {
        }
    }
}
