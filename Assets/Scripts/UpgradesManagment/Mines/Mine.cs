
using System;
using UnityEngine;

public class Mine: MonoBehaviour, IMine
{
    public static event OnBoughtAction OnBought;

    public delegate void OnBoughtAction(float points, ref int amount, int lvl, ref float cost,float costMultiplier);

    protected bool canBeBought;
    protected int lvl;
    protected int minesAmount;
    protected float pointsPerSecond;
    protected float cost;
    protected float costMultiplier;

    private void Start()
    {
        lvl = 1;
        minesAmount = 0;
        pointsPerSecond = 1;
        cost = 10;
        costMultiplier = 1.1f;
    }

    public float GetPointsPerSecond()
    {
        return pointsPerSecond;
    }

    public void SetCanBeBought(bool boolValue)
    {
        canBeBought = boolValue;
    }

    public float GetCost()
    {
        return cost;
    }

    public void BuyMine()
    {
        if (OnBought != null && canBeBought)
        {
            minesAmount++;
            OnBought(pointsPerSecond,ref minesAmount, lvl,ref cost, costMultiplier);
        }
    
    }
}
