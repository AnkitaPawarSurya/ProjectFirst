using ProjectFirstEmployeeSystem.BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirstEmployeeSystem.BusinessService.Interface
{
	public interface IStateService
	{
		List<StateViewModel> Stateslist();

		StateViewModel Stateslist(int id);


	}
}
