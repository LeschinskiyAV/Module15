var phoneBook = new List<Contact>
{
    new Contact("Игорь", 79990000001, "igor@example.com"),
    new Contact("Сергей", 79990000010, "serge@example.com"),
    new Contact("Анатолий", 79990000011, "anatoly@example.com"),
    new Contact("Валерий", 79990000012, "valera@example.com"),
    new Contact("Сергей", 799900000013, "serg@gmail.com"),
    new Contact("Иннокентий", 799900000013, "innokentii@example.com")
};
var grouped = phoneBook.GroupBy(c=>c.email.Split("@").Last());
public class Contact
{
    public string name { get; set; }
    public long phone { get; set; }
    public string email { get; set; }
    public Contact(string _name, long _phone, string _email)
    {
        name = _name;
        phone = _phone; 
        email = _email;
    }
}