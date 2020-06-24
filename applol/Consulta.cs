using Api.Model.ApiLoL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Api
{
    public class Consulta
    {
        private HttpClient cliente;

        public Consulta()
        {
            cliente = new HttpClient();
            cliente.BaseAddress =  new Uri("https://br1.api.riotgames.com");
            cliente.DefaultRequestHeaders.Add("X-Riot-Token", "RGAPI-8feff84c-0bd8-4e12-8956-de3774c8cb82");
        }
        /// <summary>
        /// Get a summoner by summoner name
        /// </summary>
        public async Task<SummonerDTO> summonerDtoAsync(string summonerName)
        {
            var content = await cliente.GetStringAsync("/lol/summoner/v4/summoners/by-name/"+summonerName);

            return JsonConvert.DeserializeObject<SummonerDTO>(content);
        }


        public async Task<List<LeagueEntryDTO>> leagueEntryDTO(string encryptedSummonerId) 
        {
            var content = await cliente.GetStringAsync("/lol/league/v4/entries/by-summoner/" + encryptedSummonerId);

            return JsonConvert.DeserializeObject<List<LeagueEntryDTO>>(content);
        }


        /// <summary>
        /// /lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}
        /// /lol/champion-mastery/v4/champion-masteries/by-summoner/{encryptedSummonerId}
        /// </summary>
        /// <returns></returns>
        public async Task<List<ChampionMasteryDTO>> championMasteryAsync(string encryptedSummonerId)
        {
            var content = await cliente.GetStringAsync("/lol/champion-mastery/v4/champion-masteries/by-summoner/"+ encryptedSummonerId);

            return JsonConvert.DeserializeObject<List<ChampionMasteryDTO>>(content);
        }

        /// <summary>
        /// lol/match/v4/matchlists/by-account/BHhl7DQpvTkvKkT3lE-cKzFDtzaWxjgdT7ThkTiyJgFvm70?champion=45
        /// </summary>
        /// <param name="championId"></param>
        /// <returns></returns>
        public async Task<MatchlistDto> listMatchByChampion(string encryptedAccountId, long championId, string timeStampInicio, string timeStampFim)
        {
            string query = "lol/match/v4/matchlists/by-account/"+encryptedAccountId+"?champion=" + championId+ "&queue=420&season=13&endIndex=10";

            if(timeStampInicio != null && timeStampFim != null)
            {
                query += "&beginTime=" + timeStampInicio + "&endTime=" + timeStampFim;
            }else if(timeStampInicio != null)
            {
                query += "&beginTime=" + timeStampInicio;
            }else if(timeStampFim != null)
            {
                query += "&endTime=" + timeStampFim;
            }
           

            try
            {
                var content = await cliente.GetStringAsync(query);
                return JsonConvert.DeserializeObject<MatchlistDto>(content);
            }
            catch 
            {
                MatchlistDto retorno = new MatchlistDto();
                retorno.matches = new List<MatchReferenceDto>();
                retorno.totalGames = 0;
                return retorno;
            }
           
        }

        /// <summary>
        /// lol/match/v4/matches/
        /// </summary>
        /// <param name="matchId"></param>
        /// <returns></returns>
        public async Task<MatchDto> matchInformation(string matchId)
        {
            var content = await cliente.GetStringAsync(" lol/match/v4/matches/" + matchId);

            return JsonConvert.DeserializeObject<MatchDto>(content);
        }
    }
}

