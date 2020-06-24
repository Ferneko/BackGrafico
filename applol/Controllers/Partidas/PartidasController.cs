using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api;
using Api.Model.ApiLoL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace applol.Controllers.Partidas
{
    [Route("[controller]")]
    [ApiController]
    public class PartidasController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public PartidasController(IHttpContextAccessor httpContextAccessor)
        {
            
            _httpContextAccessor = httpContextAccessor;
            //var ok = context;
        }

        [HttpPost]
        public async Task<PartidasModel> Post([FromBody]PartidasModel model)
        {
           
            Consulta consulta = new Consulta();
            MatchlistDto ListaPartidas = await consulta.listMatchByChampion(model.invocadorId, model.championId, null, null);

            return new PartidasModel(ListaPartidas, model.invocadorId);

        }
    }
}