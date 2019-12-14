using Core.Entities;
using MVC_Blog_Bountry_BLL.IServices.IBaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Core.DataAccess.IBaseRepository;

namespace MVC_Blog_Bountry_BLL.Services
{
    public class ServiceBase<TEntity, TKey> : IServices<TEntity, TKey> where TEntity : class, IEntity, new()
    {
        IRepository<TEntity, TKey> _repository;
        public ServiceBase(IRepository<TEntity, TKey> repository)
        {
            _repository = repository;
        }
        public string Ekle(TEntity entity)
        {
            try
            {
                _repository.Add(entity);
                return "Kayıt işlemi başarılı ile tamamlanmıştır.";
            }
            catch (Exception)
            {
                return "Bir hata oluştu kayıt yapılırken";
            }

        }

        public List<TEntity> Getir(Expression<Func<TEntity, bool>> exp = null)
        {
            return _repository.Get(exp);
        }

        public TEntity Getir(TKey id)
        {
            return _repository.GetById(id);
        }

        public string Guncelle(TEntity entity)
        {
            try
            {
                _repository.Update(entity);
                return "Güncellendi";
            }
            catch (Exception e)
            {
                return "Güncellenmedi hata:" + e.Message;
            }
        }

        public string Sil(TEntity entity)
        {
            try
            {
                _repository.Delete(entity);
                return "Silindi";
            }
            catch (Exception e)
            {
                return "Silinmede başarısız hata:" + e.Message;
            }
        }
    }
}
