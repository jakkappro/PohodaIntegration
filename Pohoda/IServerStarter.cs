using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PohodaIntegration.Pohoda
{
    public interface IServerStarter
    {
        void StartServer();

        Task<bool> IsConnectionAvailable();
    }
}
