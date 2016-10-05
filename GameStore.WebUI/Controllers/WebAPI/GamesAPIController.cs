using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using GameStore.Domain.Entitys;

namespace GameStore.WebUI.Controllers.WebAPI
{
    public class GamesAPIController : ApiController
    {
        public IEnumerable<GamesDataModel> Get()
        {
            return Data.GamesList;
        }

        public GamesDataModel Get(int id)
        {
            try
            {
                return Data.GamesList[id];
            }
            catch
            {
                return null;
            }
        }

        //[Autorize(Roles = "Administrator"]
        public void Post([FromBody]GamesDataModel value)
        {
            Data.GamesList.Add(value);
        }

        //[Autorize(Roles = "Administrator"]
        public int Put(int id, [FromBody]GamesDataModel value)
        {
            try
            {
                Data.GamesList[id] = value;
                return 200;
            }

            catch
            {
                return 400;
            }
        }

        //[Autorize(Roles = "Administrator"]
        public void Delete(int id)
        {
        }
    }
}