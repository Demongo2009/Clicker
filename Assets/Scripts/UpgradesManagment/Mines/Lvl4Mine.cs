using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl4Mine : Mine
{


    private void Start()
    {
        lvl = 4;
        minesAmount = 0;
        pointsPerSecond = 1000;
        cost = 10000;
        costMultiplier = 1.1f;
    }
}
