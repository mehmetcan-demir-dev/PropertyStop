using Dapper;
using PropertyStop.Dtos.MessagesDtos;
using PropertyStop.Models.DapperContext;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.MessageRepositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;
        public MessageRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultInboxMessageDto>> GetInboxLast3MessageByReceiver(int id)
        {
            string query = "select top (3) MessageID,Name,Subject,Detail,SendDate,IsRead,UserImageURL from Message inner join AppUser on Message.Sender=AppUser.UserID where Receiver =@receiverID  order by MessageID desc";
            var parameters = new DynamicParameters();
            parameters.Add("@receiverID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultInboxMessageDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
