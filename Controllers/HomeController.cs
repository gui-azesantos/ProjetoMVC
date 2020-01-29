﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjetoMVC.Database;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
    public class HomeController : Controller
    {
         private readonly ApplicationDBContext database;
         public HomeController(ApplicationDBContext database){
            this.database = database;
        }

       

     
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
           /* public IActionResult Teste(){
         
            Categoria c1 = new Categoria();
            c1.Nome = "Victor";
            Categoria c2 = new Categoria();
            c2.Nome = "Victor";
            Categoria c3 = new Categoria();
            c3.Nome = "Erick";
            Categoria c4 = new Categoria();
            c4.Nome = "Wesley";

            List<Categoria> catList = new List<Categoria>();
            catList.Add(c1);
            catList.Add(c2);
            catList.Add(c3);
            catList.Add(c4);

            database.AddRange(catList);

            database.SaveChanges();

            Console.Write("");

            return Content("Dados salvos");
        }
 */
        public IActionResult Relacionamento(){
     /*        Produto p = new Produto();
            p.Nome = "Doritos";
            p.Categoria = database.Categorias.First(c => c.Id == 1);

            Produto p2 = new Produto();
            p2.Nome = "Frango";
            p2.Categoria = database.Categorias.First(c=> c.Id == 1);

            Produto p3 = new Produto();
            p3.Nome = "Bolo";
            p3.Categoria = database.Categorias.First(c=> c.Id == 2);

            database.Add(p);
            database.Add(p2);
            database.Add(p3);

                database.SaveChanges();

            return Content("Relacionamento"); */
            //Consultando 1 para 1
            /* var ListaDeProdutos = database.Produtos.Include(p => p.Categoria).ToList();
            ListaDeProdutos.ForEach(produto =>
             Console.WriteLine(produto.ToString()));

             
 */
            //Consultando 1 para Muitos
                var ListaDeProdutosDeUmaCategoria = database.Produtos.Include(p=> p.Categoria).Where(p => p.Categoria.Id== 1).ToList();
                    ListaDeProdutosDeUmaCategoria.ForEach(produto =>
             Console.WriteLine(produto.ToString()));
                return Content ("Relacionemto");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
