using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orange : Fruits
{
    public override float GetEaten()
    {
        SquirtJuice();
        TasteBitter();
        return base.GetEaten();
    }
    public void SquirtJuice()
    {
        Debug.Log("What a mess");
    }
}
