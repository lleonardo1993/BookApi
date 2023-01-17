using BookApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApi.Repositories
{
    public class BookRepository : IBookRepository
    {
        public readonly BookContext _context;
        public BookRepository(BookContext context)
        {
            _context = context;
        }

        public async Task<Book> Create(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task Delete(int id)
        {
            var BookToDelete = await _context.Books.FindAsync(id);
            _context.Books.Remove(BookToDelete);
        }

        public async Task<IEnumerable<Book>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<Book> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task Update(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
