using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PracticeConsoleApp
{
    public class Books
    {
        public string Book { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public int Pagecount { get; set; }

       
    }
    public class Program
    {
        static void Main(string[] args)
        {
            IList<Books> bookList = new List<Books>() {
                    new Books() { ISBN = "1-a", Book = "Book1",Author = "karan", Pagecount = 100} ,
                    new Books() { ISBN = "2-b", Book = "Book2",Author = "Amit",Pagecount = 250} ,
                    new Books() { ISBN = "3-c", Book = "Book3",Author = "John",Pagecount = 300} ,
                    new Books() { ISBN = "4-d", Book = "Book4",Author = "Sam",Pagecount = 350} ,
                    new Books() { ISBN = "5-e", Book = "Book5" ,Author = "karan",Pagecount = 500} ,
                    new Books() { ISBN = "6-e", Book = "Book6" ,Author = "karan",Pagecount = 850},
                    new Books() { ISBN = "7-f", Book = "Book7" ,Author = "Atin",Pagecount = 950},
                    new Books() { ISBN = "8-g", Book = "Book8" ,Author = "Atin",Pagecount = 150},
                    new Books() { ISBN = "9-h", Book = "Book9" ,Author = "Sam",Pagecount = 600},
                };
            
            //1) Find a book by ISBN number
            //2) Find all books of a author
            //3) Find all books of all authors in Dictionary < string author, list<book>()>
            //4) Find the longest book having page size max first and then in desc order


            var r1=bookList.FirstOrDefault(bookList => bookList.ISBN == "1-a");
            var r2 = bookList.Where(x => x.Author == "karan").ToList();
            foreach(var r in r2)
            {
                var tt=r.ISBN;
            }
            var r3 = bookList.GroupBy(x => x.Author).Select(x => new {key= x.Key, count=x.ToList() });
            foreach (var r in r3)
            {
                var tt = r.key;
                var tt2=r.count;
            }
            var r4 = bookList.GroupBy(x => x.Author).Select(x => new { auther = x.Key, books = x.ToList() }).ToDictionary(x => x.auther, y => y.books);

            var r5 = bookList.OrderByDescending(x => x.Pagecount).Select(x=>new {pagecount=x.Pagecount,book=x.Book}).ToList();

            //Count Duplicates in List with LINQ

            var r6=bookList.GroupBy(x=>x.Author).Select(x=>new { auther = x.Key, count = x.Count() }));

            Console.ReadLine();
        }
    }



}
