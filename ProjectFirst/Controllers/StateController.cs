using Microsoft.AspNetCore.Mvc;
using ProjectFirstEmployeeSystem.Repository.Concerete;
using ProjectFirstEmployeeSystem.Repository.Interface;




namespace ProjectFirstEmployeeSystem.Controllers
{
    public class StateController : Controller
    {
      private readonly IStateRepository stateRepository;

        public StateController() 
        {
            stateRepository= new StateRepository();
        }

        public IActionResult Index()
        {
            return View(stateRepository.Stateslist());
        }
    }
}
