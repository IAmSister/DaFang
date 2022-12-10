using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traptwo : TrapBase
{
    public Traptwo(string path, Vector3 pos) : base(path, pos)
    {
        time = 3;
    }
    public override void Update()
    {
        if (falg == false)
        {
            return;
        }
        time -= Time.deltaTime;
        if (time >= 0)
        {
            obj.transform.Rotate(new Vector3(0,0,10*Time.deltaTime));
        }
        else
        {
            time = 3;
            falg = false;
            base.BornPos();
        }
    }
}
