using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWE_Game
{
    public class Player
    {
        public int Height { get; set; }
        public string PlayerId { get; set; }
        public string PlayerName { get; set; }
        public string Role { get; set; }
        public int Score { get; set; }
        public float Weight { get; set; }

        public Player()
        {

        }

        public Player(string p_playerId, string p_name, int p_height, float p_weight, string p_role = "Defender")
        {
            this.PlayerId = p_playerId;
            this.PlayerName = p_name;
            this.Height = p_height;
            this.Weight = p_weight;
            this.Role = p_role;
        }

        public string DetermineReward()
        {
            if ( this.Score >= 50 && this.Score < 1000 )
            {
                return "Coupons";
            }
            else if ( this.Score >= 1000 && this.Score < 2500 )
            {
                return "Extra_Chance";
            }
            else if ( this.Score >= 2500 )
            {
                return "Cash_Coupon";
            }
            else
            {
                return "No_Reward";
            }
        }

        public void CalculateScore(out string p_reward, int p_noOfHits, int p_noOfMisses, int p_noOfRetries = 3, bool p_complete = true)
        {
            this.Score = (p_noOfHits * 100) - (p_noOfMisses * 25) - (p_noOfRetries * 50);
            if (p_complete)
            {
                p_reward = this.DetermineReward();
            }
            else
            {
                p_reward = "NA";
            }
        }
    }
}
