using ProjectFirstEmployeeSystem.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirstEmployeeSystem.Repository.Interface
{
    public interface IStateRepository
    {
        List<State> Stateslist();

        State Stateslist(int id);
    }
}
