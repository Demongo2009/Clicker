using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1Mine : Mine
{

    private void Start()
    {
        lvl = 1;
        minesAmount = 0;
        pointsPerSecond = 1;
        cost = 10;
        costMultiplier = 1.1f;
    }

    
}
