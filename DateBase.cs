using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateBase
{
    public int index;
    public string path;
    public Vector3 StartPos;
    public DateBase(string path)
    {
        this.path = path;
    }
    public void SetIndex(int num)
    {
        index = num;
    }
    public int GetIndex()
    {
        return index;
    }
}
