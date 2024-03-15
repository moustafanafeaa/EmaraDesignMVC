using EmaraDesign1.Models;
using EmaraDesign1.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmaraDesign1.Controllers
{
    public class ProjectController : Controller
    {
        public readonly IClientProjectsService _clientProjectsService;
        public readonly IManagerProjectsService _managerProjectsService;

        public ProjectController(IClientProjectsService clientService, IManagerProjectsService managerProjectsService)
        {
            _clientProjectsService = clientService;
            _managerProjectsService = managerProjectsService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var projects = _clientProjectsService.GetAll();
            return View(projects);
        }
        
        public IActionResult GetByClientId(int id)
        {
            var project =_clientProjectsService.GetAllByClientId(id);
            return View(project);
        }
        public IActionResult GetByName(string name)
        {
            var project = _clientProjectsService.GetByName(name);
            return View(project);
        }
        public IActionResult GetDetails(string name)
        {
            var project = _managerProjectsService.GetByName(name);
            return View(project);
        }
        
        public IActionResult New()
        {
           return View(new Project());
        }
        [HttpPost]
        public IActionResult SaveNew(Project project) 
        {
            if(project.Name!=null)
            {
                _managerProjectsService.Create(project);
                return RedirectToAction("Index");
            }
            else
            {
                return View("New", project);
            }
        }
        public IActionResult Delete(string name)
        {
            var project = _managerProjectsService.GetByName(name);
            _managerProjectsService.Delete(project);
            return RedirectToAction("Index");
        }
        public IActionResult Update(string name)
        {
            var project = _managerProjectsService.GetByName(name);
            return View("Update",project);
        }
        [HttpPost]
        public IActionResult Update(Project project) 
        {
            if (project.Name != null)
            {
                _managerProjectsService.Update(project);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Update", project);
            }
        }

    }
}
