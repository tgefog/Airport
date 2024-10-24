using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library :IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = books.ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LibraryIterator(books);
        }

        private class LibraryIterator:IEnumerator<Book>
        {
            private int index = -1;
            private List<Book> books;
            public LibraryIterator(List<Book> books)
            {
                this.books = books;
            }
            public Book Current => books[index];
            object IEnumerator.Current => Current;
            public bool MoveNext()
            {
                index++;
                return index < books.Count;
            }
            public void Reset()
            {

            }
            public void Dispose() 
            { 

            }
        }
    }
}
