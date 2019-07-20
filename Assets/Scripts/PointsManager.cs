using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : MonoBehaviour
{
    private UIManager uiManager;
    private float currentPoints;
    private ICoroutineRunner coroutineRunner;
    private ArrayList mineArray;
    
    [SerializeField]
    private float pointsToEarn;

    [SerializeField] private float buttonClickedPoints;
    public void Initialize(int pointsToEarn, UIManager uiManager, ICoroutineRunner coroutineRunner)
    {
        this.pointsToEarn = pointsToEarn;
        this.uiManager = uiManager;
        this.coroutineRunner = coroutineRunner;
    }
    

    void Start()
    {
        pointsToEarn = 0;
        currentPoints = 0;
        buttonClickedPoints = 1;
        coroutineRunner.StartCoroutine(UpdatePoints());
    }

    private void OnDestroy()
    {

    }
    

    void Update()
    {
        uiManager.UpdatePoints(currentPoints);
    }


    IEnumerator UpdatePoints()
    {
        while (true)
        {
            currentPoints += pointsToEarn/10;
            yield return new WaitForSecondsRealtime(0.1f);
        }
        
    }

    public void AddPointsToEarn(float addedPoints)
    {
        pointsToEarn += addedPoints;
    }

    public void SubtractPointsToEarn()
    {
        
    }

    public void SubtractPoints(float subtractedPoints)
    {
        currentPoints -= subtractedPoints;
    }

    public float GetPoints()
    {
        return currentPoints;
    }

    public void AddOneButtonClickedPoints()
    {
        currentPoints += buttonClickedPoints;
    }
}
