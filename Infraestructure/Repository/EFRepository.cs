using ApplicationCore.Interfaces.Repository;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infraestructure.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {

        private readonly ClienteContext _context;

        public EFRepository(ClienteContext context)
        {
            _context = context;
        } //constructor

        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        } //Add

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        } //GetAll

        public T GetById(long id)
        {
            return _context.Set<T>().Find(id);
        } //GetById

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        } //Remove

        public IEnumerable<T> Search(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate);
        } //Search

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        } //Update

    } //class
} //namespace
