using Microsoft.AspNetCore.Mvc;
using ProjectFirstEmployeeSystem.BusinessService.Concrete;
using ProjectFirstEmployeeSystem.BusinessService.Interface;
using ProjectFirstEmployeeSystem.Repository.Concerete;
using ProjectFirstEmployeeSystem.Repository.Interface;




namespace ProjectFirstEmployeeSystem.Controllers
{
    public class StateController : Controller
    {
      private readonly IStateService stateservice;

        public StateController() 
        {
			stateservice = new StateService();
        }

        public IActionResult Index()
        {
            return View(stateservice.Stateslist());
        }
    }
}
