namespace Aula2 {
    
    public class Author {

        public int id { get; private set; }
        public string name { get; private set; }
        public string phone { get; private set; }

        public Autor(int id, string name, string phone) {

            this.id = id;
            this.name = name;
            this.phone = phone;
        }
    }
}
