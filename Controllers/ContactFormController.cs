using ContactFormApp2.Data; 
using ContactFormApp2.Models;
using System.Web.Mvc;

namespace ContactFormApp2.Controllers
{
    public class ContactFormController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactFormController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public ActionResult SubmitForm(ContactForm form)
        {
            if (ModelState.IsValid)
            {
                _context.ContactForms.Add(form);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Index");
        }
    }
}
