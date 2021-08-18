using System.Linq;
namespace Aula2 {
        
    public class Book {

        public Author author { get; set; }
        public int id { get; set; }        
        public string title { get; private set; }
        public string description { get; set; }
        public decimal value { get; set; }
        public string isbn { get; set; }

        public Book(int id, Author author, string name, decimal value) {
            this.id = id;
            this.name = name;
            this.value = value;
            this.author = author;
        }
    }
}