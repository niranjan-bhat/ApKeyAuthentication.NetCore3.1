using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApKeyAuthentication.Database
{
    public interface IApiKeyService
    {
        List<ApiKey> LoadAllApiKeys();
        ApiKey GenerateNewApiKey(List<Roles> roles);

        ApiKey IsValidApiKey(string keyToBeValidated);
    }
}
