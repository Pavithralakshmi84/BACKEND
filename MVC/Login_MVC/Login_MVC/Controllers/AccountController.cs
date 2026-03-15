using Login_MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Login_MVC.Controllers
{
    public class AccountController : Controller
    {
        string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        //Register (GET)
        public ActionResult Register()
        {
            return View();
        }

        // Register (POST)
        [HttpPost]
        public ActionResult Register(UserModel user)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    string query = "INSERT INTO Users VALUES(@FullName,@Email,@Password,GETDATE())";
                    SqlCommand cmd = new SqlCommand(query, con);

                    //SqlCommand cmd = new SqlCommand("InsUser", con);
                    //cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Login");
            }
            return View();
        }
        // Login (GET)
        public ActionResult Login()
        {
            return View();
        }

        // Login (POST)
        [HttpPost]
        public ActionResult Login(UserModel user)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = @"SELECT UserId, FullName FROM Users WHERE Email=@Email AND Password=@Password";
                SqlCommand cmd = new SqlCommand(query, con);

               // SqlCommand cmd = new SqlCommand("Login", con);
                //cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    Session["UserId"] = dr["UserId"];
                    Session["UserName"] = dr["FullName"];
                    return RedirectToAction("Dashboard");
                }
            }
            ViewBag.Error = "Invalid Email or Password";
            return View();
        }

        //  Dashboard
        public ActionResult Dashboard()
        {
            if (Session["UserId"] == null)
                return RedirectToAction("Login");

            return View();
        }

        //  Logout
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

        //  UserList 
        public ActionResult UserList()
        {
            List<UserModel> users = new List<UserModel>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT UserId, FullName, Email FROM Users";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    users.Add(new UserModel
                    {
                        UserId = Convert.ToInt32(dr["UserId"]),
                        FullName = dr["FullName"].ToString(),
                        Email = dr["Email"].ToString()
                    });
                }
            }
            return View(users);
        }

    }
    }

