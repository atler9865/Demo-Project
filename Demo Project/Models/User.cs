using Microsoft.AspNetCore.Identity;

namespace Demo_Project.Models
{
    public class User : IdentityUser<string>
    {
        public Name Name;
        public Email Email;
        public Adress Adress;
        public Phone Phone;
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

    }

    public class Adress
    {
        public string CountryCode { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string PostCode { get; set; }

    }

    public class Phone
    {
        public PhoneInfo Mobile { get; set; }
        public PhoneInfo Home { get; set; }
    }

    public class PhoneInfo
    {
        public string Number { get; set; }
        public string BodyNumber { get; set; }
    }

    public class Email
    {
        public EmailAdress Personal { get; set; }
    }

    public class EmailAdress
    {
        public string Adress { get; set; }
    }
}
