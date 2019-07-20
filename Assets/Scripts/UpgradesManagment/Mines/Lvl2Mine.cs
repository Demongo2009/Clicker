using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl2Mine : Mine
{


    private void Start()
    {
        lvl = 2;
        minesAmount = 0;
        pointsPerSecond = 10;
        cost = 100;
        costMultiplier = 1.1f;
    }

}
