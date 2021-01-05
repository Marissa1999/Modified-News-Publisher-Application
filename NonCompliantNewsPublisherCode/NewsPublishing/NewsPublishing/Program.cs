/*
  Student Name: Marissa Gonçalves
  Student Name: Yulia Bakaleinik  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsPublishing
{
    class Program
    {
        static void Main(string[] args)
        {
            Reader reader1 = new Reader(1);
            ((IBaseReader1)reader1).ReadNews("Publisher - Published a NewsArticle");
            ((IBaseReader2)reader1).ReadNews("Publisher - Published a NewsArticle");
            //Error: Ambiguity Between Both Base Reader Interfaces 
            //((IDerivedPublisher)reader1).ReadNews("Publisher - Published a NewsArticle");
            Console.WriteLine();

            Reader reader2 = new Reader(2);
            ((IBaseReader1)reader2).ReadNews("Publisher - Published a NewsArticle");
            ((IBaseReader2)reader2).ReadNews("Publisher - Published a NewsArticle");
            //Error: Ambiguity Between Both Base Reader Interfaces 
            //((IDerivedPublisher)reader2).ReadNews("Publisher - Published a NewsArticle");
            Console.WriteLine();

            Publisher publisher = new Publisher();     

            publisher.Register(reader1);
            ((IBasePublisher1) publisher).Register(reader1);
            ((IBasePublisher2)publisher).Register(reader1);
            //Error: Ambiguity Between Both Base Publisher Interfaces 
            //((IDerivedPublisher)publisher).Register(reader1); 
            Console.WriteLine();

            publisher.Register(reader2);
            ((IBasePublisher1)publisher).Register(reader2);
            ((IBasePublisher2)publisher).Register(reader2);
            //Error: Ambiguity Between Both Base Publisher Interfaces 
            //((IDerivedPublisher)publisher).Register(reader2); 
            Console.WriteLine();

            publisher.SetNewsArticle("Article-1: This is a News Article!");
            ((IBasePublisher1)publisher).SetNewsArticle("Article-1: This is a News Article!");
            ((IBasePublisher2)publisher).SetNewsArticle("Article-1: This is a News Article!");
            //Error: Ambiguity Between Both Base Publisher Interfaces 
            //((IDerivedPublisher)publisher).SetNewsArticle("Article-1: This is a News Article!");
            Console.WriteLine();

            publisher.Unregister(reader1);
            ((IBasePublisher1)publisher).Unregister(reader1);
            ((IBasePublisher2)publisher).Unregister(reader1);
            //Error: Ambiguity Between Both Base Publisher Interfaces 
            //((IDerivedPublisher)publisher).Unregister(reader1);
            Console.WriteLine();

            publisher.SetNewsArticle("Article-2: This is a News Article!");
            ((IBasePublisher1)publisher).SetNewsArticle("Article-2: This is a News Article!");
            ((IBasePublisher2)publisher).SetNewsArticle("Article-2: This is a News Article!");
            //Error: Ambiguity Between Both Base Publisher Interfaces 
            //((IDerivedPublisher)publisher).SetNewsArticle("Article-2: This is a News Article!");
            Console.WriteLine();
        }
    }
}
