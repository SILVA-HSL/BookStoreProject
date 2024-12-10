using BookStore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Application.Services
{
    public interface IBookService
    {
        public List<BookModel> getAllBooks();
        public List<BookModel> getBookById(Guid id);
        public BookModel addBook(BookModel book);
        public BookModel updateBook(BookModel book);

        public void deleteBook(Guid id);
    }
}
