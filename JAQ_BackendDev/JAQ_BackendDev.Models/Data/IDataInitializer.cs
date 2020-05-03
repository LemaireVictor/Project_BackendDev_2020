using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JAQ_BackendDev.Models.Data
{
    public interface IDataInitializer
    {
        Task InitQuizzes();
    }
}
