using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CompanySite.Domain.Entities;
using CompanySite.Domain.Repository.Abstract;

namespace CompanySite.Domain.Repository.EF
{
    public class EFServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDBContext dBContext;
        public EFServiceItemsRepository(AppDBContext appDBContext)
        {
            dBContext = appDBContext;
        }

        public void DeleteServiceItem(Guid id)
        {
            dBContext.ServiceItems.Remove(new ServiceItem()
            {
                Id = id
            });
            dBContext.SaveChanges();
        }

        public ServiceItem GetServiceItem(Guid id)
        {
            return dBContext.ServiceItems.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return dBContext.ServiceItems;
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
            {
                dBContext.Entry(entity).State = EntityState.Added;
            }
            else
            {
                dBContext.Entry(entity).State = EntityState.Modified;
            }

            dBContext.SaveChanges();
        }
    }
}
