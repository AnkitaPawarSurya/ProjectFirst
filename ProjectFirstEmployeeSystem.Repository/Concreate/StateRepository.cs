using ProjectFirstEmployeeSystem.DataEntity;
using ProjectFirstEmployeeSystem.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectFirstEmployeeSystem.Repository.Concerete
{
  public class StateRepository : IStateRepository
    {
        private readonly EmployeeManagementContext context;

        public StateRepository()
        {
            context = new();
        }
        public List<State> Stateslist()
        {
           return context.States.ToList();
        }

        public State Stateslist(int id)
        {
            return context.States.Find(id);        
        }



    }
}
