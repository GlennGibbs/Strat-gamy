using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Territory : MonoBehaviour
{
    //Gen Info
    public string terName;
    public string terCountry;
    public string terState;

    //Development stats
    public int devUpCost;
    public int tax;
    public int prod;
    public int army;

    //Income stats
    public float totalIncome;
    public float taxIncome;
    public float prodIncome;

    //Demographcis
    public Culture culture;
    public List<Core> cores;
    public List<Claim> claims;

    //Military
    public int manpower;
    public int supLimit;

    //Buildings
    public List<Building> buildings;

    //Trade
    public float tradePower;
    public float tradeValue;
    public float goodsProduced;
    public List<TradeGood> tradeGoods;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
