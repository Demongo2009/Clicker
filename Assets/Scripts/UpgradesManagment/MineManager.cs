using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MineManager : MonoBehaviour
{
    [SerializeField] private GameObject mineLvl1;
    [SerializeField] private GameObject mineLvl2;
    [SerializeField] private GameObject mineLvl3;
    [SerializeField] private GameObject mineLvl4;
    [SerializeField] private GameObject mineLvl5;
    [SerializeField] private GameObject mineLvl6;
    [SerializeField] private GameObject mineLvl7;

    private PointsManager pointsManager;
    private Queue<IMine> minesQueue = new Queue<IMine>();

    private float pointsToEarn;

    public void Initialize(PointsManager pointsManager)
    {
        this.pointsManager = pointsManager;
    }

    private void Start()
    {
        Mine.OnBought += MineBought;
        
        minesQueue.Enqueue(mineLvl1.GetComponent<IMine>() );
        minesQueue.Enqueue(mineLvl2.GetComponent<IMine>() );
        minesQueue.Enqueue(mineLvl3.GetComponent<IMine>() );
        minesQueue.Enqueue(mineLvl4.GetComponent<IMine>() );
        minesQueue.Enqueue(mineLvl5.GetComponent<IMine>() );
        minesQueue.Enqueue(mineLvl6.GetComponent<IMine>() );
        minesQueue.Enqueue(mineLvl7.GetComponent<IMine>() );
    }

    private void OnDestroy()
    {
        Mine.OnBought -= MineBought;
        
    }

    private void Update()
    {
        CheckIfEveryMineCanBeBought();
    }

    private void CheckIfEveryMineCanBeBought()
    {
        foreach (var mine in minesQueue)
        {
            if (pointsManager.GetPoints() >= mine.GetCost())
            {
                mine.SetCanBeBought(true);
            }
            else
            {
                mine.SetCanBeBought(false);
                
            }

        }
    }

    private void MineBought(float pointsPerSecond,ref int amount, int lvl,ref float cost, float costMultiplier)
    {

        pointsManager.AddPointsToEarn(pointsPerSecond);
        pointsManager.SubtractPoints(cost);
        cost *= costMultiplier;
        cost = Mathf.Floor(cost);

    }
    
    
    
    
}
