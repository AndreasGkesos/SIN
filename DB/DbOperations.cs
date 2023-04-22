using DB.Models;
using LiteDB;
using Microsoft.Extensions.Configuration;

namespace DB
{
    public class DbOperations : IDbOperations
    {
        private readonly IConfiguration _configuration;
        public DbOperations(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Sin> GetSinsPerPlan(string planNumber)
        {
            var connectionString = _configuration.GetConnectionString("LiteDB");
            using var db = new LiteDatabase(connectionString);

            var codeCollection = db.GetCollection<Sin>();
            var sins = codeCollection.Find(x => x.PlanNumber == planNumber).ToList();

            return sins;
        }

        public void AddSinPerPlan(string planNumber, string code, string certificate)
        {
            var connectionString = _configuration.GetConnectionString("LiteDB");
            using var db = new LiteDatabase(connectionString);

            var codeCollection = db.GetCollection<Sin>();
            var sin = new Sin { Code = code, PlanNumber = planNumber, Certificate = certificate, Created = DateTime.Now };
            codeCollection.Insert(sin);
        }

        public List<Sin> GetAllSins()
        {
            var connectionString = _configuration.GetConnectionString("LiteDB");
            using var db = new LiteDatabase(connectionString);

            var codeCollection = db.GetCollection<Sin>();
            var sins = codeCollection.FindAll().OrderBy(x => x.PlanNumber).ThenByDescending(x => x.Created).ToList();

            return sins;
        }

        public void RemoveSinsPerPlan(string planNumber)
        {
            var connectionString = _configuration.GetConnectionString("LiteDB");
            using var db = new LiteDatabase(connectionString);

            var codeCollection = db.GetCollection<Sin>();
            var sins = codeCollection.DeleteMany(x => x.PlanNumber == planNumber);
        }
    }
}