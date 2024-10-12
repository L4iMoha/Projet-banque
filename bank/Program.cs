// Créer une classe "personne" implémentant : Les propriétés publiques - String firstname, string lastname, datetime birthdate

class Personne {
    public string firstName;
    public string lastName;
    private string birthdate;

    public Personne(string firstName, string lastName, string birthdate) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthdate = birthdate;
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

    
    
}