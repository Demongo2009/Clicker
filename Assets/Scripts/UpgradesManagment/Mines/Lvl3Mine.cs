using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl3Mine : Mine
{

    private void Start()
    {
        lvl = 3;
        minesAmount = 0;
        pointsPerSecond = 100;
        cost = 1000;
        costMultiplier = 1.1f;
    }

}
