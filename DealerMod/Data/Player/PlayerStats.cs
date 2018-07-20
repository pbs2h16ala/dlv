using DealerMod.Data.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealerMod.Data.Player
{
    class PlayerStats
    { 
      // Class definition, class is singleton.

    private static PlayerStats playerStats = new PlayerStats();

    public enum DealerRank : int { None = 0, StreetWalker = 1, Runner = 2, Allocator = 3, Wannabe = 4, Prooved = 5, Respected = 6, Influencer = 7, RightHand = 8, Leader = 9, Owner = 10, Legend = 11 }
    public enum CustomerReputation : int { None = 0, Best = 1, Great = 2, Liked = 3, Statisfied = 4, Unlucky = 5, Hatefull = 6, Endangered = 7 }

    // Computed properties.
    private double currentMoney;
    private int rankProgress;
    private int reputationProgress;

    private Backpack backpack;

    public double CurrentMoney { get => currentMoney; set => currentMoney = value; }
    public int RankProgress { get => rankProgress; set => rankProgress = value; }
    public int ReputationProgress { get => reputationProgress; set => reputationProgress = value; }
    internal Backpack Backpack { get => backpack; set => backpack = value; }

    // Object data Methods
    public PlayerStats()
    {

    }

    public static PlayerStats Get()
    {
        return playerStats;
    }

    public DealerRank GetDealerRank()
    {
        return (DealerRank)this.StatToValue(this.rankProgress, 11);
    }
    public CustomerReputation GetCustomerReputation()
    {
        return (CustomerReputation)this.StatToValue(this.reputationProgress, 7);
    }

    public int StatToValue(int stat, int countOfValues)
    {
        return stat % countOfValues;
    }



    // Dealer mod methods


    // Handles the interaction with the street dealer you`ll by your stuff from.
    public void ApproachSrteetTrader()
    {

    }


}
}
