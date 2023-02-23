using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ecommerceG3.Models;
using ecommerceG3.Controllers;

namespace ecommerceG3.Connections
{
    public class CreateUser
    {
        public static List<userdb> ShowRecord()
        {
            ecomEntities db = new ecomEntities();
            var query = from p in db.userdbs
                        select p;
            var products = query.ToList();
            return products;
        }
        public static List<Billingdb> historyview()
        {
            ecomEntities db = new ecomEntities();
            var query = from p in db.Billingdbs
                        select p;
            var products = query.ToList();
            return products;
        }
        public static List<product_db> ProductsView(string cat)
        {
            ecomEntities db = new ecomEntities();
            var query = from p in db.product_db where p.Product_Cat==cat                       
                        select p;
            var products = query.ToList();
            return products;
        }
        public static List<cart> ShowCart()
        {
            ecomEntities db = new ecomEntities();
            var query = from p in db.carts
                        select p;
            var rec = query.ToList();
            return rec;
        }
        public static List<inventory> showproduct()
        {
            ecomEntities db = new ecomEntities();
            var query = from p in db.inventories
                        select p;
            var products = query.ToList();
            return products;
        }


        public static void CU(userdb udb)
        {
            ecomEntities db = new ecomEntities();
            userdb User = new userdb();
            User.User_Name = udb.User_Name;
            User.Phone_Number = udb.Phone_Number;
            User.Address_line1 = udb.Address_line1;
            User.Address_line2 = udb.Address_line2;
            User.Email = udb.Email;
            User.Pincode = udb.Pincode;
            User.State = udb.State;
            User.u_pass = udb.u_pass;
            User.Gender = udb.Gender;
            db.userdbs.Add(User);
            db.SaveChanges();

        }
        public static void addP(product_db p)
        {
            ecomEntities db = new ecomEntities();
            product_db pr = new product_db();
            pr.Product_Cat=p.Product_Cat;
            pr.Product_name=p.Product_name;
            pr.Product_ID=p.Product_ID;
            pr.Price=  p.Price;
            pr.Description=p.Description;
            pr.qty=p.qty;
            db.product_db.Add(pr);
            db.SaveChanges();
        }
        public static void EditRecord(String Phone_Number, userdb udb)
        {
            ecomEntities db = new ecomEntities();
            var User = db.userdbs.FirstOrDefault(x => x.Phone_Number == Phone_Number);

            User.User_Name = udb.User_Name;
            //User.Phone_Number = udb.Phone_Number;
            User.Address_line1 = udb.Address_line1;
            User.Address_line2 = udb.Address_line2;
            User.Email = udb.Email;
            User.Pincode = udb.Pincode;
            User.State = udb.State;
            User.u_pass = udb.u_pass;
            User.Gender = udb.Gender;
            db.SaveChanges();
        }
        public static void checku(userlog u)
        {
            ecomEntities db = new ecomEntities();
            var query = from p in db.userdbs
                        where p.Phone_Number == u.Phone_No && p.u_pass == u.password
                        select p;
            HomeController hd = new HomeController();
            hd.Index();
            
        }
    }
        



    
}