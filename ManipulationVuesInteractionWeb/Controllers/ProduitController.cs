using ManipulationVuesInteractionWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManipulationVuesInteractionWeb.Controllers
{
    public class ProduitController : Controller
    {
        // GET: Produit
        public ActionResult Index()
        {
            ViewBag.Message = "Hello to the home page of TP3";
            return View();
        }




        public ActionResult DisplayOneProduct()
        {
           
            Produit produit = new Produit()
            {
                id = 1,
                name = "Produit 1",
                prix = 9.99
            };


            return View(produit);
        }

        public ActionResult DisplayManyProducts()
        {
           
            List<Produit> produits = new List<Produit>
    {
        new Produit { id = 1, name = "Produit 1", prix = 9.99 },
        new Produit { id = 2, name = "Produit 2", prix = 19.99 },
        new Produit { id = 3, name = "Produit 3", prix = 29.99 }
    };

          
            ViewData["Produits"] = produits;

            return View();
        }






    }
}