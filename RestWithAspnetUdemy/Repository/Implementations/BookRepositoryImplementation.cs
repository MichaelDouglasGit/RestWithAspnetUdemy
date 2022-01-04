using RestWithAspnetUdemy.Model;
using RestWithAspnetUdemy.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspnetUdemy.Repository.Implementations
{
    public class BookRepositoryImplementation : IBookRepository
    {
        private DataContext _context;
        
        public BookRepositoryImplementation(DataContext context)
        {
            _context = context;
        }
        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }

        public Book FindById(long id)
        {
            return _context.Books.SingleOrDefault(p => p.Id.Equals(id));
        }
        public Book Create(Book book)
        {
            try
            {
                _context.Books.Add(book);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return book;
        }
        public Book Update(Book book)
        {
            try
            {
                if (!Exists(book.Id)) return null;

                var result = _context.Persons.SingleOrDefault(p => p.Id.Equals(book.Id));
                if (result != null)
                {                
                    _context.Entry(result).CurrentValues.SetValues(book);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return book;
        }
        public void Delete(long id)
        {
            try
            {
                var result = _context.Books.SingleOrDefault(p => p.Id.Equals(id));

                if (result != null) {
                    _context.Books.Remove(result);
                    _context.SaveChanges();
                }          
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Exists(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }       
    }
}
