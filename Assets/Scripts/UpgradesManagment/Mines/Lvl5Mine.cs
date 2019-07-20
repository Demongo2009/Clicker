using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl5Mine : Mine
{
    private void Start()
    {
        lvl = 5;
        minesAmount = 0;
        pointsPerSecond = 10000;
        cost = 100000;
        costMultiplier = 1.1f;
    }
}
