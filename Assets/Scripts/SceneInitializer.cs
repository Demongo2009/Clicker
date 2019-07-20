using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;

public class SceneInitializer : MonoBehaviour
{
    [SerializeField] private int pointsToEarn;
    [SerializeField] private GameObject pointsManager;
    [SerializeField] private GameObject uiManager;
    [SerializeField] private GameObject coroutineRunnerPrefab;
    [SerializeField] private GameObject gameManager;
    [SerializeField] private GameObject mineManager;

    private PointsManager pointsManagerScript;
    private UIManager uiManagerScript;
    private ICoroutineRunner coroutineRunner;
    private GameManager gameManagerScript;
    private MineManager mineManagerScript;
    
    private void Awake()
    {
        coroutineRunner = Instantiate(coroutineRunnerPrefab).GetComponent<ICoroutineRunner>();
        pointsManagerScript = pointsManager.GetComponent<PointsManager>();
        uiManagerScript = uiManager.GetComponent<UIManager>();
        gameManagerScript = gameManager.GetComponent<GameManager>();
        mineManagerScript = mineManager.GetComponent<MineManager>();
        
        pointsManagerScript.Initialize(pointsToEarn, uiManagerScript, coroutineRunner);
        gameManagerScript.Initialize(pointsManagerScript);
        mineManagerScript.Initialize(pointsManagerScript);
    }
}
