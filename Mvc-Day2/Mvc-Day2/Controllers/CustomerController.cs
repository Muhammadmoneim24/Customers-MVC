using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mvc_Day2.Context;
using Mvc_Day2.Models;
using Mvc_Day2.ViewModels;

namespace Mvc_Day2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CinemaContext _context;
        private readonly IMapper _mapper;

        public CustomerController(CinemaContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }
        public IActionResult Details(int id)
        {
            var customers2 = _context.Customers.Include(m => m.MembershipType).FirstOrDefault(m=>m.Id == id);

            return View(customers2);
        }
        public IActionResult New()
        {
            var newcustomer = new NewCustomerViewModel
            {
                Customer = new Customer(),
                MembershipTypes = _context.MembershipTypes.ToList(),
            };

            return View("CustomerForm", newcustomer);
        }

        public IActionResult Edit(int id)
        {
            var customer = _context.Customers.Find(id);
            var customerform = new NewCustomerViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList(),
            };

            return View("CustomerForm", customerform);

        }
        public IActionResult Delete(int id)
        {
            var customer = _context.Customers.Find(id);
            
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            
            return RedirectToAction("Index", "Customer");


        }

        [HttpPost]
        public IActionResult Save(Customer customer)
        {
            if(customer.Id==0) 
            {
                _context.Customers.Add(customer);
            }
            else 
            {
                var customerInDb = _context.Customers.Single(c => c.Id ==customer.Id );
                _mapper.Map(customer, customerInDb);
            }
           
            _context.SaveChanges();
            return RedirectToAction("Index","Customer");
        }
        
    }
}
