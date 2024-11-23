using Dapper;
using PropertyStop.Dtos.ContactDtos;
using PropertyStop.Models.DapperContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.ContactRepositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly Context _context;

        public ContactRepository(Context context)
        {
            _context = context;
        }

        public void CreateContact(CreateContactDto ContactDto)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteContact(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ResultContactDto>> GetAllContactAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<GetByIDContactDto> GetContact(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Last4ContactsResultDto>> GetLast4Contacts()
        {
            string query = "select top(4)* from Contact order by ContactID desc";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<Last4ContactsResultDto>(query);
                return values.ToList();
            }
        }
    }
}
