﻿using MvcAss_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MvcAss_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        [HttpGet]
        public ActionResult FeverCheck()
        {
            Models.FeverCheck feverCheck = new Models.FeverCheck();

            return View(feverCheck);
        }

        [HttpPost]
        public ActionResult FeverCheck(int tem)
        {
            Models.FeverCheck feverCheck = new Models.FeverCheck();
            feverCheck.Temperature = tem;

            if (tem > 98)
            {

                //Use Viewbag to display message instead of using model class
                //ViewBag.message = "you have Fever";

                feverCheck.st = "You have fever";
             

            }
            else
            {
                //ViewBag.message = "no fever";
                feverCheck.st = "You don't have fever";
               
            }
            return View(feverCheck);

        }

        [HttpGet]
        public ActionResult GuessingGame()
        {
            Models.GuessGame guess = new Models.GuessGame();
            Session["test"] = guess.generate();
            return View(guess);
        }

        [HttpPost]
        public ActionResult GuessingGame(int a)
        {
            Models.GuessGame guess = new Models.GuessGame();
           // guess.num = a;

            int  test = (int)(Session["test"]);

            if (test == a)
            {

                guess.st1 = "you guessed the right number....";
            }
            else
            {
                guess.st1 = "Guess the right number....";

            }
            
            
                       
            return View(guess);
        }

        public ActionResult PeopleList()
        {
            return View(People.DbPeople);
        }

        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(People people)
        {
            if (ModelState.IsValid)
            {

                People.DbPeople.Add(people);
                return RedirectToAction("Index");

            }
            else
            {
                return View(people);
            }
        }
            
        
        [HttpPost]
        public ActionResult Search(string nam, string cnam )
        {
            if ()
            {

            }
            

            return View();
        }

    }

   

}