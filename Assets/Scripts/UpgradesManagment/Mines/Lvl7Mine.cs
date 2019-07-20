using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl7Mine : Mine
{
    private void Start()
    {
        lvl = 7;
        minesAmount = 0;
        pointsPerSecond = 1000000;
        cost = 10000000;
        costMultiplier = 1.1f;
    }
}
