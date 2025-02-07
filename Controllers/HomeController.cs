using HelloWorldMVCApplication.Models;
using System.Web.Mvc;

namespace HelloWorldMVCApplication.Controllers
{
    public class HomeController : Controller
    {

        private ContactRepository _contactRepository;

        public HomeController()
        {
            _contactRepository = new ContactRepository();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Little bit about myself.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public ActionResult Contact(int id)
        //{
        //    // Call the method to retrieve first and last name from the database
        //    //conn.Open();
        //    //SqlCommand cmd = new SqlCommand("SELECT * FROM Contacts WHERE ContactId = @ContactId", conn);
        //    //cmd.Parameters.AddWithValue("@ContactId", contactId);

        //    // using (SqlDataReader reader = cmd.ExecuteReader())
        //    //{
        //    //    //if (reader.Read())
        //    //    {
        //    //        return new ContactModel
        //    //        {
        //    //            ContactId = (int)reader["ContactId"],
        //    //            FirstName = reader["FirstName"].ToString(),
        //    //            LastName = reader["LastName"].ToString(),
        //    //            Email = reader["Email"].ToString(),
        //    //            PhoneNumber = reader["PhoneNumber"].ToString()
        //    //        };
        //    //    }


        //    var contact = _contactRepository.GetContactById(id);

        //    if (contact != null)
        //    {
        //        ViewBag.FirstName = contact.FirstName;
        //        ViewBag.LastName = contact.LastName;
        //    }
        //    else
        //    {
        //        ViewBag.Message = "Contact not found.";
        //    }

        //    //controller picks up user input, command, calls the appropriate method, 
        //    //directs the traffic to model to retrieve info from the db
        //    //hands over the data to the view
        //    //the view displays the data

        //    //ways to pass data from controlller to the view
        //    //VieBag
        //    //ViewData
        //    //Model

        //    return View();


        //}
    }
}