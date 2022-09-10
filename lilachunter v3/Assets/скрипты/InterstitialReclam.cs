using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterstitialReclam : MonoBehaviour
{
    private InterstitialAd interstitial;
    private const string adUnitId = "ca-app-pub-7808462584495137/3976500347";

    private void OnEnable()
    {
        this.interstitial = new InterstitialAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
    }

    public void Show()
    {
        if (this.interstitial.IsLoaded())
        {
            this.interstitial.Show();
        }
    }
}
