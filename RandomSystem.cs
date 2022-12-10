using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSystem : IGameSystem
{
    public int length;
    public RandomSystem(PBDG pBDG) : base(pBDG)
    {

    }

    public void GetLength(int len)
    {
        this.length = len;
    }

    public int GetRandomNum()
    {
        return Random.Range(0,length);
    }

    public int LuckDraw()
    {
        return Random.Range(0, 4);
    }
}
