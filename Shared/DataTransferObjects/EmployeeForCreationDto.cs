
namespace Shared.DataTransferObjects
{
    public record CompanyForCreationDto(string Name, string Address, string Country);
    {
        public void CreateCompany(Company company) => Create(company);
    }

}
