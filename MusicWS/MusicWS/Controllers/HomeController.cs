using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MusicWS.Models;

namespace MusicWS.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Update()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Update(FormCollection fc,string btn)
        {
            string newFirst = fc["newfirstname"].ToString();
            string newLast = fc["newlastname"].ToString();
            string oldFirst = fc["firstname"].ToString();
            string oldLast = fc["lastname"].ToString();
            if (btn == "update Artist")
            {
               if (newFirst != "" && newLast != "" && oldLast != "" && oldFirst != "")
                {
                    UpdateModels update = new UpdateModels();
                update.UpdateArtist(newFirst,newLast,oldFirst,oldLast);
                    ViewBag.fc = "Add Succesfull";
                    return View();
                }
                else
                {
                    ViewBag.fc = "Insert data";
                    return View();
                }
            }
            return View();
        }

       [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(FormCollection fc, string btn)
        {
            string first = fc["firstname"].ToString();
            string last = fc["lastname"].ToString();

            if (btn == "delete Artist")
            {
                if (first != "" && last != "")
                {
                   
                    DeleteModels del = new DeleteModels();
                    del.DeleteArtist(first, last);
                    ViewBag.fc = "Delete Succesfull";
                    return View();
                }
                else
                {
                    ViewBag.fc = "Insert data";
                    return View();
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(DataSet ds)
        {
            SearchModels search = new SearchModels();
            List<string> list = search.search();
            string str = search.ListToString(list);
            ds = new DataSet();
            ViewBag.ds = str;
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection fc,string btn)
        {
            string genre = fc["genre"].ToString();
            if(btn == "add genre")
            {
                if (genre != "") { 
                    CreateModels create = new CreateModels();
                    create.AddGenre(genre);
                    ViewBag.fc = "Add Succesfull";
                    return View();
                }else
                {
                    ViewBag.fc = "Insert data";
                    return View();
                }
            }
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}