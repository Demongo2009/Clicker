using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMine
{
    float GetPointsPerSecond();

    void BuyMine();

    float GetCost();

    void SetCanBeBought(bool value);
}
