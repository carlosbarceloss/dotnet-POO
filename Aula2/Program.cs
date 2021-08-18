using System;

namespace Aula2 {

    class Program {

        static void Main(string[] args) {

            Book myBook =  new Book(
                1234
                , new Author(23, "Martin","515651651")
                , "Clean code - uncle bob",150);
                    
            //Listar autor do livro
            Console.WriteLine(myBook.author.name + meuLivro.author.phone);
        }
    }
}
