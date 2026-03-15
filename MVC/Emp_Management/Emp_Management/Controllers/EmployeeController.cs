using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Emp_Management.Models;

namespace Emp_Management.Controllers
{
    public class EmployeeController : Controller
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> employees = new List<Employee>();

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("GetEmployees", con);
                cmd.CommandType = CommandType.StoredProcedure;

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    employees.Add(new Employee
                    {
                        EmployeeId = Convert.ToInt32(dr["EmployeeId"]),
                        Name = dr["Name"].ToString(),
                        Email = dr["Email"].ToString(),
                        Phone = dr["Phone"].ToString(),
                        Department = dr["Department"].ToString(),
                        Designation = dr["Designation"].ToString(),
                        Salary = Convert.ToDecimal(dr["Salary"]),
                        JoinDate = Convert.ToDateTime(dr["JoinDate"])
                    });
                }
            }

            return View(employees);


        }
    

            // CREATE
            public ActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Create(Employee emp)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("InsertEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                    cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                    cmd.Parameters.AddWithValue("@Department", emp.Department);
                    cmd.Parameters.AddWithValue("@Designation", emp.Designation);
                    cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                    cmd.Parameters.AddWithValue("@JoinDate", emp.JoinDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return RedirectToAction("Index");
            }

            // EDIT
            public ActionResult Edit(int id)
            {
                Employee emp = new Employee();

                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("GetEmployeeById", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmployeeId", id);

                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        emp.EmployeeId = Convert.ToInt32(dr["EmployeeId"]);
                        emp.Name = dr["Name"].ToString();
                        emp.Email = dr["Email"].ToString();
                        emp.Phone = dr["Phone"].ToString();
                        emp.Department = dr["Department"].ToString();
                        emp.Designation = dr["Designation"].ToString();
                        emp.Salary = Convert.ToDecimal(dr["Salary"]);
                        emp.JoinDate = Convert.ToDateTime(dr["JoinDate"]);
                    }
                }

                return View(emp);
            }

            [HttpPost]
            public ActionResult Edit(Employee emp)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("UpdateEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EmployeeId", emp.EmployeeId);
                    cmd.Parameters.AddWithValue("@Name", emp.Name);
                    cmd.Parameters.AddWithValue("@Email", emp.Email);
                    cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                    cmd.Parameters.AddWithValue("@Department", emp.Department);
                    cmd.Parameters.AddWithValue("@Designation", emp.Designation);
                    cmd.Parameters.AddWithValue("@Salary", emp.Salary);
                    cmd.Parameters.AddWithValue("@JoinDate", emp.JoinDate);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return RedirectToAction("Index");
            }

            // DELETE
            public ActionResult Delete(int id)
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    SqlCommand cmd = new SqlCommand("DeleteEmployee", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@EmployeeId", id);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                return RedirectToAction("Index");
            }
        }
    }