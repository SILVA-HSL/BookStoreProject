using BookStore.Domain.Models;
using BookStore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    
   
    public class BookService:IBookService
    {
        private readonly BookDbContext _context;
        public BookService(BookDbContext context)
        {
            _context = context;
        }
        public List<BookModel> getAllBooks()
        {
            return _context.Books.ToList();

        }
        public List<BookModel> getBookById(Guid id)
        {
            return _context.Books.Where(x => x.Id == id).ToList();
        }

        public BookModel addBook(BookModel book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }
        public BookModel removeBook(Guid id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
            return book;
        }
        public BookModel updateBook(BookModel book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
            return book;
        }
        public void deleteBook(Guid id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == id);
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
}
