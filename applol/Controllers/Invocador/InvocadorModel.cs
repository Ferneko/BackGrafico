using Api.Model.ApiLoL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers.Invocador
{
    public class InvocadorModel : ModelAbstract
    {
        public InvocadorModel(SummonerDTO summonerDTO, List<LeagueEntryDTO> leagueEntryDTO, List<ChampionMasteryDTO> championMasteryDTOs)
        {
            nomeInvocador = summonerDTO.name;
            level = summonerDTO.summonerLevel;
            accountId = summonerDTO.accountId;
            icone = summonerDTO.profileIconId;
            filas = new List<Fila>();
            foreach (var item in leagueEntryDTO)
            {
                filas.Add(new Fila(item));
            }

            melhoresCampeoes = new List<MelhoresCampeoes>();
            foreach (var item in championMasteryDTOs)
            {
                melhoresCampeoes.Add(new MelhoresCampeoes(item));
            }
        }

        public string nomeInvocador { get; set; }
        public string accountId { get; set; }
        public long level { get; set; }
        public int icone { get; set; }
        public List<Fila> filas { get; set; }
        public List<MelhoresCampeoes> melhoresCampeoes { get; set;}
    }

    public class MelhoresCampeoes
    {
        public long idCampeao { get; set; }
        public long levelMaestria { get; set; }
        public long pontosMaestria { get; set; }

        public MelhoresCampeoes(ChampionMasteryDTO championMasteryDTO)
        {
            idCampeao = championMasteryDTO.championId;
            levelMaestria = championMasteryDTO.championLevel;
            pontosMaestria = championMasteryDTO.championPoints;
        }
    }

    public class Fila
    {
        public Fila(LeagueEntryDTO leagueEntryDTO )
        {
            if(leagueEntryDTO.queueType == "RANKED_SOLO_5x5")
            {
                nomeFila = "Ranqueado Solo/Duo";
            }
            else if(leagueEntryDTO.queueType == "RANKED_FLEX_SR")
            {
                nomeFila = "Ranqueado Flexível";
            }
            else
            {
                nomeFila = "Erro no Api League of legends";
            }

            vitorias = leagueEntryDTO.wins;
            derrotas = leagueEntryDTO.losses;
            pontos = leagueEntryDTO.leaguePoints;
            rank = leagueEntryDTO.rank;
            tier = leagueEntryDTO.tier;
        }
        
        public string nomeFila { get; private set; }
        public int vitorias { get; private set; }
        public int derrotas { get; private set; }
        public int pontos { get; private set; }
        public string rank { get; private set; }
        public string tier { get; private set; }
    }
}
