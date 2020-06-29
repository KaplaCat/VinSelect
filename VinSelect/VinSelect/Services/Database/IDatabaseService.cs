using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VinSelect.Services.Database
{
    public interface IDatabaseService
    {
        IRestResponse GetAllUsers();
        void PostNewUser(string json);
        void UpdateUser(string id, string field);
        void DeleteUser(string id);

        void DeleteWine(string id);
        IRestResponse GetAllWine();
        void PostNewWine(string json);
        void UpdateWine(string id, string field);
    }
}
