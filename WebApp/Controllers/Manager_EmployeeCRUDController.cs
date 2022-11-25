using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Domain;

namespace Bumbo.Controllers
{
    public class Manager_EmployeeCRUD : Controller
    {
        public ActionResult Index()
        {
            using (var context = new BumboDbContext())
            {
                return View(context.Employees.ToList());
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var context = new BumboDbContext())
                    {
                        context.Employees.Add(employee);
                        context.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            try
            {
                using (var context = new BumboDbContext())
                {
                    return View(context.Employees.FirstOrDefault(b => b.Id == id));
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var context = new BumboDbContext())
                    {
                        context.Attach(employee);
                        context.Employees.Update(employee);
                        context.Employees.Add(employee);
                        context.SaveChanges();
                    }
                    return RedirectToAction(nameof(Index));
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Manager_EmployeeCRUD/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Manager_EmployeeCRUD/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
