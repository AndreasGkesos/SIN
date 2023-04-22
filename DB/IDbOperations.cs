using DB.Models;

namespace DB
{
    public interface IDbOperations
    {
        List<Sin> GetAllSins();
        List<Sin> GetSinsPerPlan(string planNumber);
        void AddSinPerPlan(string planNumber, string code, string certificate);
        void RemoveSinsPerPlan(string planNumber);
    }
}
