using DB;
using DB.Models;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace SinHandler
{
    public class SinHandler : ISinHandler
    {
        private readonly string _validChars = "1234567890";
        private readonly int _codeLength = 9;

        public IDbOperations _dbOperations { get; set; }
        public SinHandler(IDbOperations dbOperations)
        {
            _dbOperations = dbOperations;
        }

        public string Generate(string planNumber)
        {
            var sins = _dbOperations.GetSinsPerPlan(planNumber);

            var code = GetCode();

            while (!IsValid(code) || sins.Any(x => x.Code == code))
            {
                code = GetCode();
            }

        _dbOperations.AddSinPerPlan(planNumber, code);

            return code;
        }

        private string GetCode()
        {
            var sb = new StringBuilder();
            using var rng = RandomNumberGenerator.Create();

            while (sb.Length < _codeLength)
            {
                var oneByte = new byte[1];
                rng.GetBytes(oneByte);
                var character = (char)oneByte[0];
                if (_validChars.Contains(character))
                {
                    sb.Append(character);
                }
            }

            return sb.ToString();
        }

        private bool IsValid(string code)
        {
            var array = Regex.Split(code, string.Empty).Where(x => x.Length > 0).ToList();
            var result = new List<string>();
           
            for (int i = 0; i < array.Count; i = i + 2)
            {
                var r = (int.Parse(array[i]) * 2).ToString();
                if (r.Length == 1) result.Add(r);
                else result.AddRange(Regex.Split(r, string.Empty).Where(x => x.Length > 0).ToList());
            }

            var count = 0;
            foreach (var c in result) {
                count = count + int.Parse(c);
            }


            return count % 10 == 0;
        }

        public List<Sin> GetAll()
        {
            return _dbOperations.GetAllSins();
        }

        public void RemovePerPlan(string planNumber)
        {
            _dbOperations.RemoveSinsPerPlan(planNumber);
        }
    }
}