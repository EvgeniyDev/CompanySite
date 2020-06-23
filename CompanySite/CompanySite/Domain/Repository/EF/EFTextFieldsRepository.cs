using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CompanySite.Domain.Entities;
using CompanySite.Domain.Repository.Abstract;

namespace CompanySite.Domain.Repository.EF
{
    public class EFTextFieldsRepository : ITextFieldsRepository
    {
        private readonly AppDBContext dBContext;
        public EFTextFieldsRepository(AppDBContext appDBContext)
        {
            dBContext = appDBContext;
        }

        public void DeleteTextField(Guid id)
        {
            dBContext.TextFields.Remove(new TextField() 
            { 
                Id = id 
            });
            dBContext.SaveChanges();
        }

        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return dBContext.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }

        public TextField GetTextFieldByID(Guid id)
        {
            return dBContext.TextFields.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<TextField> GetTextFields()
        {
            return dBContext.TextFields;
        }

        public void SaveTextField(TextField entity)
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
