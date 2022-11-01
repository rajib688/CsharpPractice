// See https://aka.ms/new-console-template for more information
using SwitchStatement;

Console.WriteLine("Hello, World!");

static bool CheckIfCanWalkIntoBankSwitch(Bank bank, bool isVip)
{
    switch(bank.Status)
    {
        case BankBranchStatus.Open:
            return true;
        case BankBranchStatus.Closed:
            return false;
        case BankBranchStatus.VIPCustomersOnly:
            return isVip;
        default:
            return false;
    }
}


static bool CheckIfCanWalkIntoBank(Bank bank, bool isVip) => bank.Status switch
{ 
    BankBranchStatus.Open=>true,
    BankBranchStatus.Closed=>false,
    BankBranchStatus.VIPCustomersOnly=> isVip,
    _ => false

};

static bool CheckIfCanWalkIntoBank4(Bank bank, bool isVip)
{
    return bank.Status switch
    {
        BankBranchStatus.Open => true,
        BankBranchStatus.Closed => false,
        BankBranchStatus.VIPCustomersOnly when isVip => true,
        BankBranchStatus.VIPCustomersOnly when !isVip => false,
        _ => false
    };
}
static bool CheckIfCanWalkIntoBank5(Bank bank, bool isVip)
{
    return (bank.Status, isVip) switch
    {
        (BankBranchStatus.Open, _) => true,
        (BankBranchStatus.Closed, _) => true,
        (BankBranchStatus.VIPCustomersOnly, true) => true,
        (BankBranchStatus.VIPCustomersOnly, false) => false,
        (_, _) => false
    };
}

static bool CheckIfCanWalkIntoBank6(Bank bank, bool isVip)
{
    return bank switch
    {
        { Status: BankBranchStatus.Open, Name: "ABC" } => true,
        { Status: BankBranchStatus.Closed, Name: "ABC" } => false,
        { Status: BankBranchStatus.VIPCustomersOnly} => isVip,
        { Status: _ } => false
    };
}