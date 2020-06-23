using CompanySite.Domain.Repository.Abstract;

namespace CompanySite.Domain.Repository
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(IServiceItemsRepository serviceItemsRepository, ITextFieldsRepository textFieldsRepository)
        {
            ServiceItems = serviceItemsRepository;
            TextFields = textFieldsRepository;
        }
    }
}
