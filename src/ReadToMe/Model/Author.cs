namespace readtome.Model
{
    public class Author
    {
        public string Salutation;
        public string FirstName;
        public string LastName;

        public Author()
        {
            this.Salutation = "";
            this.FirstName = "";
            this.LastName = "";
        }

        public Author(string salutation, string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salutation = salutation;
        }
    }
}