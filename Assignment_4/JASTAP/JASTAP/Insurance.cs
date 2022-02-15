using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JASTAP
{
    public class Insurance
    {
        public int Age { get; set; }
        public string ConsumerName { get; set; }

        public int CreditHistory { get; set; }
        public string[] Documents { get; set; }
        public string InsuranceId { get; set; }

        private static int counter;

        static Insurance()
        {
            counter = 1000;
        }

        public Insurance()
        {
            this.InsuranceId = $"I{counter++}";
            this.Age = 18;
            this.CreditHistory = 45000;
        }

        public Insurance(string p_consumerName) :this()
        {
            this.ConsumerName = p_consumerName;
        }

        public Insurance(string p_consumerName, string[] p_documents) :this(p_consumerName)
        {
            this.Documents = p_documents;       
        }

        public Insurance(string p_consumerName, int p_creditHistory, int p_age, string[] p_documents) : this(p_consumerName, p_documents)
        {
            this.CreditHistory = p_creditHistory;
            this.Age = p_age;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool CheckEligibility()
        {
            return false;
        }

        public bool CheckDocuments(string[] p_acceptableDocuments)
        {
            return false;
        }
    }
}
