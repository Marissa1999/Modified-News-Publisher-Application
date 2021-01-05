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
    public interface IBasePublisher1
    {
        void SetNewsArticle(string s);
        void NotifyReaders();
        void Register(Reader reader);
        void Unregister(Reader reader);
    }

    public interface IBasePublisher2
    {
        void SetNewsArticle(string s);
        void NotifyReaders();
        void Register(Reader reader);
        void Unregister(Reader reader);
    }

    public interface IDerivedPublisher : IBasePublisher1, IBasePublisher2
    {
        new void SetNewsArticle(string s);
        new void NotifyReaders();
        new void Register(Reader reader);
        new void Unregister(Reader reader);
    }

    public class Publisher :IDerivedPublisher
    {
        List<Reader> readers = new List<Reader>();

        string article;

        public void SetNewsArticle(string s)
        {
            article = s;
            NotifyReaders();
            Console.WriteLine("Publisher - Published a NewsArticle");
        }

        public void NotifyReaders()
        {
            foreach (Reader r in readers)
            {
                r.ReadNews(article);
            }
        }

        public void Register(Reader r)
        {
            readers.Add(r);
        }

        public void Unregister(Reader r)
        {
            readers.Remove(r);
        }
    }
}
