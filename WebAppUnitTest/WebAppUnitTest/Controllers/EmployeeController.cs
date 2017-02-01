using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppUnitTest.Models;

namespace WebAppUnitTest.Controllers
{
	public class EmployeeController : Controller
	{

		private EmpDBContext db = new EmpDBContext();
		// GET: Employee

		public ActionResult Index()
		{
			var employees = from e in db.Employees
							orderby e.ID
							select e;
			return View(employees);
		}

		// GET: Employee/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Employee/Create
		[HttpPost]
		public ActionResult Create(EmployeeModel emp)
		{
			try
			{
				db.Employees.Add(emp);
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Employee/Edit/5
		public ActionResult Edit(int id)
		{
			var employee = db.Employees.Single(m => m.ID == id);
			return View(employee);
		}

		// POST: Employee/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				var employee = db.Employees.Single(m => m.ID == id);
				if (TryUpdateModel(employee))
				{
					//To Do:- database code
					db.SaveChanges();
					return RedirectToAction("Index");
				}
				return View(employee);
			}
			catch
			{
				return View();
			}
		}

		//[NonAction]

		//public List<EmployeeModel> GetEmployeeList()
		//{
		//	return new List<EmployeeModel>{
		//	new EmployeeModel{
		//	   ID = 1,
		//	   Name = "Allan",
		//	   JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
		//	   Age = 23
		//	},

		//	new EmployeeModel{
		//	   ID = 2,
		//	   Name = "Carson",
		//	   JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
		//	   Age = 45
		//	},

		//	new EmployeeModel{
		//	   ID = 3,
		//	   Name = "Carson",
		//	   JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
		//	   Age = 37
		//	},

		//	new EmployeeModel{
		//	   ID = 4,
		//	   Name = "Laura",
		//	   JoiningDate = DateTime.Parse(DateTime.Today.ToString()),
		//	   Age = 26
		//	},
		// };
		//}

		//// GET: Employee
		//public ActionResult Index()
		//{
		//	//List<EmployeeModel> emlist = GetEmployeeList();
		//	var employees = from e in GetEmployeeList()
		//					orderby e.ID
		//					select e;
		//	return View(employees);
		//}

		//public ActionResult Edit(int id)
		//{
		//	List<EmployeeModel> emlist = GetEmployeeList();
		//	var employee = emlist.Single(m => m.ID == id);

		//	return View(employee);
		//}

		//[HttpPost]
		//public ActionResult Edit(int id, FormCollection collection)
		//{
		//	try
		//	{
		//		List<EmployeeModel> emlist = GetEmployeeList();
		//		var employee = emlist.Single(m => m.ID == id);
		//		if (TryUpdateModel(employee))
		//		{
		//			//To Do:- database code
		//			return RedirectToAction("Index");
		//		}
		//		return View(employee);
		//	}
		//	catch
		//	{
		//		return View();
		//	}
		//}

		//public ActionResult Create()
		//{
		//	return View();
		//}

		//[HttpPost]
		//public ActionResult Create(EmployeeModel emp)
		//{
		//	try
		//	{
		//		List<EmployeeModel> emlist = GetEmployeeList();
		//		emlist.Add(emp);
		//		return RedirectToAction("Index");
		//	}
		//	catch
		//	{
		//		return View();
		//	}
		//}
	}
}