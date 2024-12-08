using PropertyStop.Dtos.MessagesDtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PropertyStop.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        Task<List<ResultInboxMessageDto>> GetInboxLast3MessageByReceiver(int id);
    }
}
