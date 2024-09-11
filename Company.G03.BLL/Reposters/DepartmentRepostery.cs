using Company.G03.BLL.Interface;
using Company.G03.DAL.Date.Contexts;
using Company.G03.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.G03.BLL.Reposters
{

    //CLR
    public class DepartmentRepostery : IDepartmentRepostry
    {
        private readonly object _context;  //null

        public DepartmentRepostery(AppDbContext context) // ASK CLR Create Object From AppDbContext
        {
            _context = context;
        }

        public IEnumerable<Department> GetAll()
        {
            return _context.Department.ToList();
        }

        public Department Get(int? id)
        {
            return _context.Department.Find(id);
        }
        public int Add(Department entity)
        {
            return _context.Department.Add(entity);
        }

        public int Delete(Department entity)
        {
            _context.Department.Remove(entity);
            return _context.SaveChanges();
        }

        int IDepartmentRepostry.Update(Department entity)
        {
            throw new NotImplementedException();
        }



        private readonly DepartmentRepostry _departmentRepository;

        public IActionResult Index()
        {
            var departments = _departmentRepository.GetAll();
            return View(departments);
        }
    }
}
