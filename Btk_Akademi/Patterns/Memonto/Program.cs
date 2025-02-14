﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Memonto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book  = new Book();

            book.Title = "Sefiller";
            book.Isbn = "12345";
            book.Author = "Victor Hugo";

            book.ShowBook();
            CareTaker history = new CareTaker();
            history.Memento = book.CreateUndo();

            book.Isbn = "54321";
            book.Title = "SEFİLLER";
            book.ShowBook();

            book.RestoreFromUndo(history.Memento);

            book.ShowBook();

            Console.ReadLine();

        }
    }

    class Book
    {
        private string _title;
        private string _author;
        private string _isbn;
        private DateTime _lastEdited;
      
        public string Title { 
            get 
            {
                return _title;
            } 
            set 
            {
                _title= value;
                SetLastEdited();
            } 
        }
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
                SetLastEdited();
            }
        }
        public string Isbn
        {
            get
            {
                return _isbn;
            }
            set
            {
                _isbn = value;
                SetLastEdited();
            }
        }
        private void SetLastEdited() 
        {
            _lastEdited= DateTime.UtcNow;
        }
        public Memento CreateUndo() 
        {
            return new Memento(_title, _author, _isbn, _lastEdited);
        }

        public void RestoreFromUndo(Memento memento)
        {
            _title = memento.Title;
            _author = memento.Author;
            _isbn = memento.Isbn;
            _lastEdited= memento.LastEdited;
        }
        public void ShowBook() 
        {
            Console.WriteLine("{0},{1},{2},Düzenleme :{3}",_title,_author,_isbn,_lastEdited);
        }

    }

    class Memento
    {
        public string Title;
        public string Author;
        public string Isbn;
        public DateTime LastEdited;

        public Memento(string title, string author, string ısbn, DateTime lastEdited)
        {
            Title = title;
            Author = author;
            Isbn = ısbn;
            LastEdited = lastEdited;
        }
    }
    class CareTaker
    {
        public Memento Memento { get; set; } 
    }
}
