using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.BLL.Repositories;
using Demo.DAL.Entities;
using Demo.PL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    public class EmployeeController : Controller
    { 
        public IUnitOfWork UnitOfWork { get; }
        public IMapper Mapper { get; }

        public EmployeeController(IUnitOfWork unitOfWork ,IMapper mapper )
        { 
            UnitOfWork = unitOfWork;
            Mapper = mapper;
        }
        public async Task<IActionResult> Index(string SearchValue)
        {
            if (string.IsNullOrEmpty(SearchValue))
            {

            var mappedEmp = Mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel> >(await UnitOfWork.EmployeeRepository.GetAll());
            return View(mappedEmp);
            }else {
                var mappedEmp = Mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(await UnitOfWork.EmployeeRepository.SearchEmployee(SearchValue));
                return View(mappedEmp);
            }

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(EmployeeViewModel employee)
        {
            if (ModelState.IsValid)
            {
                var mappedEmp = Mapper.Map<EmployeeViewModel,Employee>(employee);
               await UnitOfWork.EmployeeRepository.Add(mappedEmp);
                return RedirectToAction(nameof(Index));

            }
            ViewBag.Departments = UnitOfWork.DepartmentRepository.GetAll();
            return View(employee);
        }


        public async Task<IActionResult> Details(int? id, string ViewName = "Details")
        {
            if (id == null)
            {
                return NotFound();
            }

            var dept =await UnitOfWork.EmployeeRepository.Get(id);
            if (dept == null)
            {
                return NotFound();
            }

            return View(ViewName, dept);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            return await Details(id, "Edit");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int? id, EmployeeViewModel employee)
        {
            if (id != employee.Id)
            {

                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var mappedEmp = Mapper.Map<EmployeeViewModel, Employee>(employee);

                   await UnitOfWork.EmployeeRepository.Update(mappedEmp);

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(employee);
                }

            }
            return View(employee);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        public async Task<IActionResult> Delete([FromRoute] int? id, EmployeeViewModel  employee)
        {

            if (id != employee.Id)
            {

                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var mappedEmp = Mapper.Map<EmployeeViewModel, Employee>(employee);

                   await UnitOfWork.EmployeeRepository.Delete(mappedEmp);

                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View(employee);
                }

            }
            return View(employee);
        }

    }
}
