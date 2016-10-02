using System.Collections.Generic;

namespace readtome.Model
{
    public class Book
    {

        public IEnumerable<Author> Authors;

        public int Id;

        public string Title;


        public Book()
        {
            this.Title = "";
            this.Authors = new Author[0];
        }

        public Book(int IdIn, string TitleIn, Author[] AuthorsIn)
        {
            this.Id = IdIn;
            this.Title = TitleIn;
            this.Authors = AuthorsIn;
        }
    }
}