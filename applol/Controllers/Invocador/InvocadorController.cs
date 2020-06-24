using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Model.ApiLoL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Invocador
{
    [Route("[controller]")]
    [ApiController]
    public class InvocadorController : Controller
    {
        [Route("{nomeInvocador}")]
        [HttpGet]
        public async Task<InvocadorModel> GetAsync(string nomeInvocador)
        {
            Consulta consulta = new Consulta();
            SummonerDTO summoner = await consulta.summonerDtoAsync(nomeInvocador);
            List<LeagueEntryDTO> leagueEntryDTOs = await consulta.leagueEntryDTO(summoner.id);
            List<ChampionMasteryDTO> championMasteryDTOs = await consulta.championMasteryAsync(summoner.id);
            return new InvocadorModel(summoner, leagueEntryDTOs, championMasteryDTOs);
        }
    }
}