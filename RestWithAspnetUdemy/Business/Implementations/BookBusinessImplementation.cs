using RestWithAspnetUdemy.Data.Converter.Implementations;
using RestWithAspnetUdemy.Data.VO;
using RestWithAspnetUdemy.Model;
using RestWithAspnetUdemy.Model.Context;
using RestWithAspnetUdemy.Repository;
using RestWithAspnetUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAspnetUdemy.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private IRepository<Book> _repository;
        private readonly BookConverter _bookConverter;
        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _repository = repository;
            _bookConverter = new BookConverter();
        }

        public List<BookVO> FindAll()
        {
            return _bookConverter.Parse(_repository.FindAll());
        }
        public BookVO FindById(long id)
        {
            return _bookConverter.Parse(_repository.FindById(id));
        }
        public BookVO Create(BookVO book)
        {
            var bookEntity = _bookConverter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _bookConverter.Parse(bookEntity);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
        public BookVO Update(BookVO book)
        {
            var bookEntity = _bookConverter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _bookConverter.Parse(bookEntity);
        }
    }
}
