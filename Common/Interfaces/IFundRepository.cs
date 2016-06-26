using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IFundRepository
    {
        IList<Fund> FindAll();

        Fund GetbyId(int id);

    }
}
