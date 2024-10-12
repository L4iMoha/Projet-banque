// Créer une classe "personne" implémentant : Les propriétés publiques - String firstname, string lastname, datetime birthdate

class Personne {
    public string FirstName;
    public string LastName;
    private DateTime Birthdate;

    public Personne(string firstName, string lastName, DateTime birthdate) {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Birthdate = birthdate;
    }
}

// Créer une classe "CurrentAccount" qui permet la gestion d'un compte courant implémentant :
// Les propriétés publiques 
    // string number, 
    // double balance (lecture seule)
    // double CreditLine, 
    // Person Owner
// Les méthodes publiques 
    // void Withdraw (double amount)
    // void Deposit(double amount)

class CurrentAccount {
    public string Number;
    public double Balance;
    public double CreditLine;
    public Personne personne;

    public CurrentAccount(string number, double balance, double creditLine, Personne personne) {
        this.Number = number;
        this.Balance = balance;
        this.CreditLine = creditLine;
        this.personne = personne; 
    }
    
    public void withdraw() {
        Console.Write("Combien souhaitez-vous retirer ? : ");
        var wdraw = Console.ReadLine();
        
        if(Convert.ToDouble(wdraw) < Balance) {
            Balance -= Convert.ToDouble(wdraw);
        }
        else
        Console.WriteLine("Erreur ! Solde insuffisant");
    }

    public void deposit() {
        Console.Write("");
    }
}

// Créer une classe "Bank" pour gérer les comptes de la banque implémentant : 
    //Les propriétés
        // Dictionary<string, 
        // Current> Accounts (lecture seule), 
        // string Name
    // Les méthodes :
        // void AddAccount(Current account),
        // void DeleteAccount(String number)