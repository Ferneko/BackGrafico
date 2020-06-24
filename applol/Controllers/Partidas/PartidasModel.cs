using Api;
using Api.Model.ApiLoL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace applol.Controllers.Partidas
{
    public class PartidasModel : ModelAbstract
    {
        public PartidasModel(MatchlistDto ListaPartidas, string invocadorId)
        {
           

            if (ListaPartidas.matches.Count > 0)
            {
                listaPartidas = new List<Partida>();
                foreach (var item in ListaPartidas.matches)
                {
                    Partida partida = new Partida(item, invocadorId);
                    listaPartidas.Add(partida);
                }

                championId = ListaPartidas.matches.FirstOrDefault().champion;
            }
            else
            {
                this.tipoMensagem = "Erro";
                mensagem = "Nenhuma partida encontrada";
            }
        }

        public PartidasModel()
        {

        }
        
        public string invocadorId { get; set; }
        public long championId { get; set; }
        public string dataInicio { get; set; }
        public string dataFim { get; set; }
        public List<Partida> listaPartidas { get; set; }
    }

    public class Partida
    {
        public Partida(MatchReferenceDto partida, string invocadorId)
        {
            partidaId = partida.gameId;
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dataPartida = dtDateTime.AddMilliseconds(partida.timestamp).ToShortDateString();
            lane = partida.lane;
            temporada = partida.season;
            this.invocadorId = invocadorId;
            detalhes = getDetalhesAsync(partida.gameId, invocadorId).Result;
        }
        private string invocadorId { get; set; }
        public long partidaId { get; set; }
        public string     dataPartida { get; set; }
        public string       lane { get; set; }
        public int          temporada { get; set; }
        public DetalhesPartida detalhes { get; set; }

        private async Task<DetalhesPartida> getDetalhesAsync (long partidaId, string invocadorId)
        {
            Consulta consulta = new Consulta();
            return new DetalhesPartida(await consulta.matchInformation(partidaId.ToString()),invocadorId);
            
        }


    }

    public class DetalhesPartida
    {
        public DetalhesPartida(MatchDto matchDto, string invocadorId)
        {
            ParticipantIdentityDto participantIdentity = matchDto.participantIdentities.Where(a => a.player.accountId == invocadorId).FirstOrDefault();
            jogador = participantIdentity.participantId;
            participantDto = matchDto.participants.Where(a => a.participantId == jogador).FirstOrDefault();

            vitoria = participantDto.stats.win;
            abates = participantDto.stats.kills;
            mortes = participantDto.stats.deaths;
            assistencias = participantDto.stats.assists;

            feitico1 = participantDto.spell1Id;
            feitico2 = participantDto.spell2Id;

            doubleKills = participantDto.stats.doubleKills;
            tripleKills = participantDto.stats.tripleKills;
            quadraKills = participantDto.stats.quadraKills;
            pentaKills = participantDto.stats.pentaKills;

            ouroObtido = participantDto.stats.goldEarned;
            totalMinionsFarmados = participantDto.stats.totalMinionsKilled;
            totalDanoToChampions = participantDto.stats.totalDamageDealtToChampions;
            totalWards = participantDto.stats.wardsPlaced;

            item0 = participantDto.stats.item0;
            item1 = participantDto.stats.item1;
            item2 = participantDto.stats.item2;
            item3 = participantDto.stats.item3;
            item4 = participantDto.stats.item4;
            item5 = participantDto.stats.item5;
            item6 = participantDto.stats.item6;


            
        }
        /// <summary>
        /// id do jogador na partida
        /// </summary>
        private int jogador { get; set; }

        /// <summary>
        /// detalhes do participante na partida em questão
        /// </summary>
        private ParticipantDto participantDto { get; set; }


        public bool vitoria { get; set; }
        public int abates { get; set; }
        public int mortes { get; set; }
        public int assistencias { get; set; }
        public int feitico1 { get; set; }
        public int feitico2 { get; set; }

        public int doubleKills { get; set; }
        public int tripleKills { get; set; }
        public int quadraKills { get; set; }
        public int pentaKills { get; set; }

        public long ouroObtido { get; set; }
        public long totalMinionsFarmados { get; set; }
        public long totalDanoToChampions { get; set; }
        public int totalWards { get; set; }

        public int item0 {get; set;}
        public int item1 {get; set;}
        public int item2 {get; set;}
        public int item3 {get; set;}
        public int item4 {get; set;}
        public int item5 {get; set;}
        public int item6 {get; set;}
    }
}
