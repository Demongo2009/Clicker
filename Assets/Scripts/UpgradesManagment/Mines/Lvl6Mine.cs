using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl6Mine : Mine
{

    private void Start()
    {
        lvl = 6;
        minesAmount = 0;
        pointsPerSecond = 100000;
        cost = 1000000;
        costMultiplier = 1.1f;
    }
}
