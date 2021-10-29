namespace proj{
    public class User{
        public string Name {get; set;}
        public string Surname {get; set;}
        public string Login {get; set;}
        public string Password {get; set;}
        public int Age {get; set;}

        public User(){
            this.Name = this.Surname = this.Login = this.Password = "\0";
            this.Age = 0;
        }
        public User(string name, string surname, string login, string password, int age){
            this.Name = name;
            this.Surname = surname;
            this.Login = login;
            this.Password = password;
            this.Age = age;
        }
        public override string ToString(){
            return $"Name of cardholder: {this.Name} {this.Surname},  login:{this.Login}, password:{this.Password},   age: {this.Age}\n";
        }
    }
}