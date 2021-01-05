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
    public interface IBaseReader1
    {
        void ReadNews(string article);
    }

    public interface IBaseReader2
    {
        void ReadNews(string article);
    }

    public interface IDerivedReader : IBaseReader1, IBaseReader2
    {
        new void ReadNews(string article);
    }

    public class Reader : IDerivedReader
    {
        int number;

        public Reader(int n)
        {
            number = n;
        }

        public void ReadNews(string article)
        {
            Console.WriteLine("Reader -" + number + " has read the news: " + article);
        }
    }
}
