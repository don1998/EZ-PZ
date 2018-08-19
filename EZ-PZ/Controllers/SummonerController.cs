using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EZ_PZ.Models;
using System.Net.Http;
using System.Web.Helpers;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

namespace EZ_PZ.Controllers
{
    public class SummonerController : Controller
    {
        // GET: Summoner
        public ActionResult Index()
        {
            return View();
        }

        // GET: Summoner/Details/5
        public ActionResult Details(String name)
        {
            Summoner summ;
            using (var client = new HttpClient())
            {
                String test = "https://na1.api.riotgames.com/lol/summoner/v3/summoners/by-name/" + name + "?api_key=RGAPI-c9657255-754a-4b35-b382-56d6635d7083";
                var uri = new Uri(test);

                var response = client.GetAsync(uri).Result;
                var temp= response.Content.ReadAsStreamAsync().Result;
                var result = response.Content.ReadAsStringAsync().Result;
                var content = JObject.Parse(result);

                String img = "http://ddragon.leagueoflegends.com/cdn/8.14.1/img/profileicon/"+content["profileIconId"]+".png";
                summ = new Summoner(img, content["name"].ToString(),(long)content["summonerLevel"]);

            }
            return View(summ);
        }

        // GET: Summoner/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Summoner/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Summoner/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Summoner/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Summoner/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Summoner/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
