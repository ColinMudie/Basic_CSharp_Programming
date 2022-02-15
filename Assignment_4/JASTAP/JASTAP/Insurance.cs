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
        /// This method checks if the consumer is eligible to apply for 
        /// insurance based on the following conditions:
        ///     
        ///     - If 'age' is less than 18, then the consumer is not eligible
        ///     
        ///     - If 'age' is greater than 18 and less than or equal to 30 and 'creditHistory' 
        ///         is less than or equal to 60000, then the consumer is eligible
        ///       
        ///     - If 'age' is greater than 30 and 'creditHistory' less than or equal 45000, 
        ///         then the consumer is eligible
        /// </summary>
        /// <returns>should return 'True' if the consumer is eligible and 'False' otherwise.</returns>
        public bool CheckEligibility()
        {
            if (this.Age < 18)
            {
                return false;
            }
            else if ((this.Age >= 18 && this.Age <= 30) && this.CreditHistory <= 60000)
            {
                return true;
            }
            else if (this.Age > 30 && this.CreditHistory <= 45000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method checks the documents submitted by the consumer against the set of 
        /// 'acceptabledocuments' based on the following conditions:
        /// 
        ///     - ‘CheckEligibility’ method should be called to check if the 
        ///         consumer is eligible for applying for insurance
        ///         
        ///     - If he is eligible, then the ‘documents’ submitted by the 
        ///         consumer should match with the ‘acceptabledocuments’. 
        ///         Even if one of the documents matches with the acceptable documents, 
        ///         then the consumer is eligible
        ///         
        ///     - ‘InsuranceId’ for eligible consumer should be auto-generated inside 
        ///         this method with the help of the variable ‘counter’. 
        ///         The ‘InsuranceId’ should start with “I1000” and auto-incremented each time
        /// </summary>
        /// <param name="p_acceptableDocuments">array of documents to check</param>
        /// <returns>should return 'True' if the consumer is eligible and 'False' otherwise.</returns>
        public bool CheckDocuments(string[] p_acceptableDocuments)
        {
            if (this.CheckEligibility())
            {
                foreach (string acceptableDoc in p_acceptableDocuments)
                {
                    foreach (string doc in this.Documents)
                    {
                        if (doc == acceptableDoc)
                        {
                            this.InsuranceId = $"I{counter++}";
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
