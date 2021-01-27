using GameStudio.Abstract;
using GameStudio.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStudio.Adapters
{
    class MernisServiceAdapters : IPlayerCheckService
    {
        public bool CheckIfRealPlayer(Player player)
        {
            KPSPublicSoap client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                Convert.ToInt64(player.NationalityId),
                player.FirstName.ToUpper(),
                player.LastName.ToUpper(),
                Convert.ToInt32(player.DateOfBirth.Year)
                ))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
