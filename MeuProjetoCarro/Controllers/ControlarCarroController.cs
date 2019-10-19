using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeuProjetoCarro.Data;
using MeuProjetoCarro.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeuProjetoCarro.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ControlarCarroController : ControllerBase
    {
        ApplicationDbContext Context;

        public ControlarCarroController(ApplicationDbContext context)
        {

            Context = context;

        }

        [HttpGet]

        public List<Carro> Listar()
        {

            List<Carro> listcarro = this.Context.Carros.ToList();
            return listcarro;
        }

        [HttpPost]
        public void SaveChanges(Carro carro)
        {
            this.Context.Carros.Add(carro);
            this.Context.SaveChanges();

       }

/*        [HttpPut]

        public Carro Update(Carro carro)
        {
            var PegarCarro = this.Context.carro
            this.Context.Update();
            this.Context.SaveChanges();
            return PegarCarro;
        }

        [HttpDelete]

        public void delete(long id)



    */
    }

}