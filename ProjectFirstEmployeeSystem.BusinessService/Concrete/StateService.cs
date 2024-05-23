using ProjectFirstEmployeeSystem.BusinessEntity;
using ProjectFirstEmployeeSystem.BusinessService.Interface;
using ProjectFirstEmployeeSystem.Repository.Concerete;
using ProjectFirstEmployeeSystem.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectFirstEmployeeSystem.Common;

namespace ProjectFirstEmployeeSystem.BusinessService.Concrete
{
public class StateService:IStateService
	{
		private readonly IStateRepository _stateService;

		public StateService()
		{
			_stateService = new StateRepository();
		}

		public List<StateViewModel> Stateslist()
		{
			var a= _stateService.Stateslist();
			return a.ToViewModel();
		}

		public StateViewModel Stateslist(int id)
		{
			var a = _stateService.Stateslist(id);
			return a.ToViewModel();
		}
	}
}
