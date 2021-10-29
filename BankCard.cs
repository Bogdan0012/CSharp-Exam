namespace proj{
    using System;
    [Serializable]
    public class BankCard : User{
        public string BankName {get; set;}
        public Date CardExpiryDate {get; set;}
        public long CardNumber {get; set;}
        public int AuthenticationCode {get; set;}

        public BankCard() : base(){
            this.BankName = "\0";
            this.CardExpiryDate = new Date();
            this.CardNumber = this.AuthenticationCode = 0;
        }
        public BankCard(string bankName, Date cardExpiryDate, long cardNumber, int authenticationCode, string name, string surname, string login, 
                 string password, int age) : base(name, surname, login, password, age){
            this.BankName = bankName;
            this.CardExpiryDate = cardExpiryDate;
            this.CardNumber = cardNumber;
            this.AuthenticationCode = authenticationCode;
        }

        public override string ToString(){
            return base.ToString() + $"Name of bank: {this.BankName},\tcard number: {this.CardNumber},\tauthentication code: {this.AuthenticationCode},\tcard expiry: {this.CardExpiryDate.Day}.{this.CardExpiryDate.Month}.{this.CardExpiryDate.Year}\n";
        }
    }
}