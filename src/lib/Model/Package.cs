using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vision2.Api.Model {
    public class Package {
        public int PhotoId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public DateTime AvailableStart { get; set; }
        public DateTime AvailableEnd { get; set; }
        public bool IsActive { get; set; }
        public object MinimumAmount { get; set; }
        public object MaximumAmount { get; set; }
        public float TargetAmount { get; set; }
        public int FundableId { get; set; }
        public int FundableReferenceType { get; set; }
        public float TotalFunded { get; set; }
        public int PackageType { get; set; }
        public bool IsFixedAmount { get; set; }
        public bool UseAskLadder { get; set; }
        public int AskLadderId { get; set; }
        public object BasketCategory { get; set; }
        public bool IsGoalMet { get; set; }
        public bool IsOptionsRequired { get; set; }
        public bool IsArchived { get; set; }
        public int Id { get; set; }
    }
}
