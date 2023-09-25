// Ext
// BankAccount Struct
//  - Date Struct
//  - balance
//  - account name
//  - account id

public readonly struct BankAccount  {

    public double Balance { get; init; }
    public string AccountName { get; init; }
    public long AccountId { get; init; }
    public Date DateCreated { get; init; }

    public BankAccount(double Balance, string AccountName, long AccountId, Date DateCreated)
    {
        this.Balance = Balance;
        this.AccountName = AccountName;
        this.AccountId = AccountId;
        this.DateCreated = DateCreated;
    }

}

