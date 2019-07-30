using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vision2.Api.Enum;

namespace Vision2.Api.Model {

    public class DataSubscriptionPayload<T> where T : new() {
        public string SystemName { get; set; }
        public object Key { get; set; }
        public T Data { get; set; }
        public string User { get; set; }
        public string Application { get; set; }
        public int Attempt { get; set; }
    }

    public class Payment {
        public Payment() {
            AppliedTo = new List<Appliedto>(); 
        }
        public int BatchId { get; set; }
        public object BatchNumber { get; set; }
        public object BatchDate { get; set; }
        public PaymentMethodType PaymentMethodType { get; set; }
        public string PaymentMethodTypeName { get; set; }
        public object CreditCardTypeCode { get; set; }
        public object CreditCardTypeName { get; set; }
        public int PaymentStatusType { get; set; }
        public float AmountDouble { get; set; }
        public decimal Amount { get; set; }
        public string NetAmount { get; set; }
        public float NetAmountDouble { get; set; }
        public Individual Individual { get; set; }
        public object Organization { get; set; }
        public List<Appliedto> AppliedTo { get; set; }
        public DateTime PaymentDateDate { get; set; }
        public DateTime? RefundRequestedDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime DepositDate { get; set; }
        public int CurrencyType { get; set; }
        public string CurrencyTypeName { get; set; }
        public float SourceCurrencyAmount { get; set; }
        public int PaymentType { get; set; }
        public bool IsArchived { get; set; }
        public int PaymentSiteId { get; set; }
        public float SettledAmount { get; set; }
        public bool IsIndividual { get; set; }
        public int BankAccountId { get; set; }
        public string PaymentMethodDisplayLine { get; set; }
        public object DepositTicketId { get; set; }
        public int PaymentChannelType { get; set; }
        public float QuidProQuoAmount { get; set; }
        public int OrganizationId { get; set; }
        public bool IsHistorical { get; set; }
        public object CheckNumber { get; set; }
        public List<ExternalKey> ExternalKeys { get; set; }
        public int Id { get; set; }
    }

    public class Display {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public object BirthDate { get; set; }
    }

    public class Primaryaddress {
        public string Address1 { get; set; }
        public object Address2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string PostalCodeSummary { get; set; }
        public string Country { get; set; }
        public string StandardizedAddress { get; set; }
        public string StandardizedAddressTerm { get; set; }
        public object Pins { get; set; }
        public bool IsPrimary { get; set; }
        public object[] AddressExternalKeys { get; set; }
        public string AddressType { get; set; }
        public object InactiveAsOf { get; set; }
        public DateTime DateUpdated { get; set; }
        public int VersionNumber { get; set; }
        public int CountryType { get; set; }
    }

    public class Primaryname {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string[] FirstNamePhonetic { get; set; }
        public string[] LastNamePhonetic { get; set; }
        public object[] NameExternalKeys { get; set; }
        public object Suffix { get; set; }
        public bool IsPrimary { get; set; }
        public DateTime DateUpdated { get; set; }
        public int VersionNumber { get; set; }
    }
    
    public class Appliedto {
        public Appliedto() {
            Details = new List<Detail>();
        }

        public int Id { get; set; }
        public int CommitmentId { get; set; }
        public int CommitmentItemId { get; set; }
        public Commitment Commitment { get; set; }
        public Commitmentitem CommitmentItem { get; set; }
        public int CommitmentItemType { get; set; }
        public decimal AppliedAmountDouble { get; set; }
        public decimal NetAppliedAmountDouble { get; set; }
        public string NetAppliedAmount { get; set; }
        public string AppliedAmount { get; set; }
        public DateTime OriginalTransactionDate { get; set; }
        public List<Detail> Details { get; set; }
    }

    public class Commitment {
        public int Id { get; set; }
        public int CommitmentType { get; set; }
        public string CommitmentTypeName { get; set; }
        public int OrganizationId { get; set; }
        public int CalendarId { get; set; }
        public string TotalAmount { get; set; }
        public float TotalAmountDouble { get; set; }
        public object PaymentToken { get; set; }
        public bool HasSchedule { get; set; }
        public int FundingMethodType { get; set; }
        public string FundingMethodTypeName { get; set; }
        public int CommitmentStatusType { get; set; }
        public string CommitmentStatusTypeName { get; set; }
        public int ChannelType { get; set; }
        public string ChannelTypeName { get; set; }
    }

    public class Commitmentitem {
        public int CommitmentId { get; set; }
        public int OrganizationId { get; set; }
        public object IndividualId { get; set; }
        public string CommitmentDate { get; set; }
        public DateTime CommitmentDateDate { get; set; }
        public float Amount { get; set; }
        public int CommitmentItemType { get; set; }
        public string CommitmentItemTypeName { get; set; }
        public bool HasSchedule { get; set; }
        public int EventCalendarId { get; set; }
        public int LastUpdatedByUserAccountId { get; set; }
        public int CommitmentStatusType { get; set; }
        public string CommitmentStatusTypeName { get; set; }
        public object RevenueBatchItemId { get; set; }
        public object OrganizationFundId { get; set; }
        public bool IsArchived { get; set; }
        public int CommitmentSiteId { get; set; }
        public int GiftType { get; set; }
        public string GiftTypeName { get; set; }
        public int Id { get; set; }
    }

    public class Detail {
        public int Id { get; set; }
        public int CommitmentLineItemId { get; set; }
        public int CommitmentLineItemType { get; set; }
        public double AppliedDetailAmountDouble { get; set; }
        public string AppliedDetailAmount { get; set; }
        public float NetAppliedDetailAmountDouble { get; set; }
        public string NetAppliedDetailAmount { get; set; }
        public Designation Designation { get; set; }
        public string SourceCode { get; set; }
        public int MarketingCommunciationId { get; set; }
        public DateTime StartDate { get; set; }
        public float ExpectedAmountDouble { get; set; }
        public float TotalFundedAmountDouble { get; set; }
        public float RemainingAmountDouble { get; set; }
        public int Frequency { get; set; }
        public object EndDate { get; set; }
        public object Package { get; set; }
        public object Quantity { get; set; }
        public float QuidProQuoAmount { get; set; }
    }
}
