namespace proj{
    using System.Collections.Generic;
    using System.IO;
    using System.Xml.Serialization;
    class Administrator{
        public void MyAdd(List<BankCard> users, BankCard user){
            users.Add(user);
        }
        public List<BankCard> MyDelete(List<BankCard> users, BankCard user){
            users.Remove(user);
            return users;
        }
        public void Watch(List<BankCard> users){
            users.ForEach(System.Console.WriteLine);
        }

        public void PushToXml(List<BankCard> cardholders){
            XmlSerializer formatter = new XmlSerializer(typeof(List<BankCard>));
            using (FileStream filestream = new FileStream("Cardholders base.xml", FileMode.OpenOrCreate)){
                formatter.Serialize(filestream, cardholders);
                System.Console.WriteLine("All cardholders serialized in base.");
            }
        }
        public List<BankCard> PullFromXml(){
            XmlSerializer formatter = new XmlSerializer(typeof(List<BankCard>));
            using (FileStream filestream = new FileStream("Cardholders base.xml", FileMode.OpenOrCreate)){
                List<BankCard> cardholders = (List<BankCard>)formatter.Deserialize(filestream);
                System.Console.WriteLine("Cardholder base deserialized.");
                return cardholders;
            }
        }
    }
}