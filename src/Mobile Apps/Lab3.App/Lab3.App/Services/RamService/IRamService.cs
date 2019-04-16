using Lab3.Service.Computer.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.App.Services.RamService
{
    public interface IRamService
    {
        Task<IEnumerable<RAM>> GetRAMs();
    }
}
