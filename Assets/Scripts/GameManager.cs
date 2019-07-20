using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private PointsManager pointsManager;
    
    
    public void Initialize(PointsManager pointsManager)
    {
        this.pointsManager = pointsManager;
    }
   

    public void OnButtonClicked()
    {
        pointsManager.AddOneButtonClickedPoints();
    }

}
