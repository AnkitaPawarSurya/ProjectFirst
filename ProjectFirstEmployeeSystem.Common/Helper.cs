using ProjectFirstEmployeeSystem.BusinessEntity;
using ProjectFirstEmployeeSystem.DataEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFirstEmployeeSystem.Common
{
 static public class Helper
	{
		public static StateViewModel ToViewModel(this State state)
		{
			return new StateViewModel
			{
				StateId = state.StateId,
				StateName = state.StateName
			};
		}

		public static List<StateViewModel> ToViewModel(this List<State> state)
		{
			return state.Select(x => ToViewModel(x)).ToList();



		}

	}
}
