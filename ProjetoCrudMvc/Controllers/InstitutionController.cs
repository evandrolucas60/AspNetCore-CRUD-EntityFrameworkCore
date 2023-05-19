using Microsoft.AspNetCore.Mvc;
using ProjetoCrudMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoCrudMvc.Controllers
{
    public class InstitutionController : Controller
    {
        public IActionResult Index()
        {
            return View(Institutions);
        }

        //GET: Create
        public ActionResult Create()
        {
            return View();
        }

        //Post: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Institution institution)
        {
            Institutions.Add(institution);
            institution.InstitutionID = Institutions.Select(i => i.InstitutionID).Max() + 1;
            return RedirectToAction("Index");
        }

        public ActionResult Edit(long id)
        {
            return View(Institutions.Where(i => i.InstitutionID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit (Institution institution)
        {
            Institutions.Remove(Institutions.Where(i => i.InstitutionID == institution.InstitutionID).First());
            Institutions.Add(institution);
            return RedirectToAction("Index");
        }

        public ActionResult Details(long id)
        {
            return View(Institutions.Where(i => i.InstitutionID == id).First());
        }


        public ActionResult Delete(long id)
        {
            return View(Institutions.Where(i => i.InstitutionID == id).First());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Institution institution)
        {
            Institutions.Remove(Institutions.Where(i => i.InstitutionID == institution.InstitutionID).First());
            return RedirectToAction("Index");
        }


        //Em um projeto real, neste momento teríamos o acesso a dados
        //(via um banco de dados), no qual as instituições registradas seriam
        //devolvidas para o cliente.Entretanto, por ser nosso primeiro
        //projeto, trabalharemos com uma coleção de dados, usando um
        //List.
        private static IList<Models.Institution> Institutions = new List<Institution>()
        {
            new Institution() {
            InstitutionID = 1,
            Name = "UniParaná",
            Address = "Paraná"
            },
            new Institution() {
            InstitutionID = 2,
            Name = "UniSanta",
            Address = "Santa Catarina"
            },
            new Institution() {
            InstitutionID = 3,
            Name = "UniSãoPaulo",
            Address = "São Paulo"
            },
            new Institution() {
            InstitutionID = 4,
            Name = "UniSulgrandense",
            Address = "Rio Grande do Sul"
            },
            new Institution() {
            InstitutionID = 5,
            Name = "UniCarioca",
            Address = "Rio de Janeiro"
            }
        };
    }
}
