using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonReclama : MonoBehaviour
{
    private RewardedAd rewardedAd;
    private const string adUnitId = "ca-app-pub-3940256099942544/5224354917";

    private void OnEnable()
    {
        this.rewardedAd = new RewardedAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        PlayerPrefs.GetInt("coin, +10");
    }

    public void Show()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }
}
