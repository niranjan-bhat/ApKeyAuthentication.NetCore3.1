using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApKeyAuthentication.Database
{
    public class ApiKeyService : IApiKeyService
    {
        private List<ApiKey> dbApiKeys;
        //This function saves the api key in the database and sends back the api key generated.

        public ApiKeyService()
        {
            LoadAllApiKeys();
        }
        public ApiKey GenerateNewApiKey(List<Roles> roles)
        {
            var key = Guid.NewGuid().ToString();
            return new ApiKey()
            {
                ApiKeyValue = key,
                IssuedOn = DateTime.Now,
                AssignedRoles = roles
            };
        }

        //This funtion will validate a given Api key
        public ApiKey IsValidApiKey(string keyToBeValidated)
        {
            return dbApiKeys.FirstOrDefault(x=> string.Equals(keyToBeValidated,x.ApiKeyValue,StringComparison.InvariantCultureIgnoreCase));
        }

        //This function will retrieve the api keys from the database.
        public List<ApiKey> LoadAllApiKeys()
        {
            dbApiKeys = new List<ApiKey>()
           {
                    new ApiKey()
                     {
                         ApiKeyValue = "659be45f-7b04-465c-85f6-2fb49f0226a8",
                         AssignedRoles = new List<Roles>()
                            {
                                 Roles.Manager
                            },
                         IssuedOn = DateTime.Now
                    },

                    new ApiKey()
                     {
                         ApiKeyValue = "659be45f-7b04-405c-85f6-2fb49f0226a8",
                         AssignedRoles = new List<Roles>()
                            {
                                 Roles.Teamlead
                            },
                         IssuedOn = DateTime.Now.AddDays(-1) //Just to say this api key is generated yesterday
                    },

                    new ApiKey()
                     {
                         ApiKeyValue = "659be45f-7b04-465c-85f6-2fb49f0226aa",
                         AssignedRoles = new List<Roles>()
                            {
                                 Roles.Manager,Roles.Teamlead
                            },
                         IssuedOn = DateTime.Now.AddDays(-2)
                    },
                     new ApiKey()
                     {
                         ApiKeyValue = "659be4qf-7b04-465c-85f6-2fb49f0226aa",
                         AssignedRoles = new List<Roles>()
                            {
                                 Roles.Employee
                            },
                         IssuedOn = DateTime.Now.AddDays(-2)
                    },

           };
            return dbApiKeys;
        }
    }
}
