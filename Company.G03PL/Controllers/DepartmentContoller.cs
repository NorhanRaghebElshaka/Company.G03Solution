using Company.G03.BLL.Reposters;
using Microsoft.AspNetCore.Mvc;

namespace Company.G03PL.Controllers
{
    public class DepartmentContoller : Controller
    {
        private readonly DepartmentRepostery _DepartmentRepostery;  //null
        private DepartmentRepository _departmentRepository;

        public DepartmentContoller(DepartmentRepository departmentRepository)//ask to create object 
        {
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
