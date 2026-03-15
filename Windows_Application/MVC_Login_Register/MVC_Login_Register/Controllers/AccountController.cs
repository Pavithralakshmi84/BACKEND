using MVC_Login_Register.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Login_Register.Controllers
{
    public class AccountController : Controller
    {
        string cs = ConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        //Register(GET)
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
                    //string query = "INSERT INTO Users VALUES(@FullName,@Email,@Password,GETDATE())";
                    //SqlCommand cmd = new SqlCommand(query, con);

                    SqlCommand cmd = new SqlCommand("InsUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;

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
                //  string query = @"SELECT UserId, FullName FROM Users WHERE Email=@Email AND Password=@Password";
                // SqlCommand cmd = new SqlCommand(query, con);

                SqlCommand cmd = new SqlCommand("Login", con);
                cmd.CommandType = CommandType.StoredProcedure;


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
                // string query = "SELECT UserId, FullName, Email FROM Users";
                //SqlCommand cmd = new SqlCommand(query, con);

                SqlCommand cmd = new SqlCommand("Listusers", con);
                cmd.CommandType = CommandType.StoredProcedure;



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

        // GET: Edit User - Shows form with existing data
        public ActionResult Edit(UserModel user)
        {
            if (ModelState.IsValid)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("UpdateUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserId", user.UserId);
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery(); 

                    Debug.WriteLine($"Rows affected: {rowsAffected}, UserId: {user.UserId}"); 

            if (rowsAffected > 0)
                    {
                        TempData["Success"] = $"User {user.UserId} updated! Rows: {rowsAffected}";
                        return RedirectToAction("UserList");
                    }
                    else
                    {
                        TempData["Error"] = $"No rows updated! Check UserId: {user.UserId}";
                    }
                }
            }
            return View(user);


        }
    } 
}


