using CarInsuranceMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsuranceMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Quote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
            short carYear, string carMake, string carModel, bool dui, short speedingTickets, string insuranceType)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) ||
                string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(insuranceType))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                decimal monthly = 50;

                // calculating the monthly quote
                var today = DateTime.Today;
                int age = today.Year - dateOfBirth.Year;
                if (today.Month < dateOfBirth.Month || (today.Month == dateOfBirth.Month && today.Day < dateOfBirth.Day))
                    age--;
                if (age < 18) monthly += 100;
                else if (age < 25 || age >= 100) monthly += 25;

                if (carYear < 2000 || carYear > 2015) monthly += 25;
                if (carMake.ToLower() == "porsche") monthly += 25;
                if (carMake.ToLower() == "porsche" && carModel.ToLower() == "911 carrera") monthly += 25;

                monthly += (speedingTickets * 10);
                if (dui == true) monthly *= (decimal)1.25;
                if (insuranceType == "full") monthly *= (decimal)1.5;

                decimal monthlyFinal = Math.Round(monthly, 2);

                // entering information into database
                using (CarInsuranceEntities db = new CarInsuranceEntities())
                {
                    var quote = new Quote();
                    quote.FirstName = firstName;
                    quote.LastName = lastName;
                    quote.EmailAddress = emailAddress;
                    quote.DateOfBirth = dateOfBirth;
                    quote.CarYear = carYear;
                    quote.CarMake = carMake;
                    quote.CarModel = carModel;
                    quote.Dui = dui;
                    quote.SpeedingTickets = speedingTickets;
                    quote.InsuranceType = insuranceType;
                    quote.InsuranceQuote = monthlyFinal;

                    db.Quotes.Add(quote);
                    db.SaveChanges();
                }

                // displaying the quote
                ViewBag.MonthlyQuote = "Your monthly car insurance quote is: " + monthlyFinal.ToString();

                return View();
            }
        }

        public ActionResult Admin()
        {
            using (CarInsuranceEntities db = new CarInsuranceEntities())
            {
                var quotes = db.Quotes;
                var quoteVms = new List<QuoteVm>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quoteVm.InsuranceQuote = quote.InsuranceQuote;
                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }    
        }
    }
}