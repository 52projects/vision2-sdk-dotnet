using System.ComponentModel;

namespace Vision2.Api.Enum {
    public enum PaymentMethodType {
        None = 0,
        [Description("Credit Card")]
        CreditCard = 1,
        [Description("Bank Account")]
        BankAccount = 2,
        [Description("Stock")]
        Stock = 5,
        [Description("Cash")]
        Cash = 6,
        [Description("Check")]
        Check = 7,
        [Description("Electronic Deposit")]
        ElectronicDeposit = 9,
        [Description("Payroll")]
        Payroll = 10
    }
}
