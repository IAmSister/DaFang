using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapone : TrapBase
{
    public Trapone(string path, Vector3 pos) : base(path, pos)
    {
        time = 3;
    }
    public override void Update()
    {
        if (falg==false)
        {
            return;
        }
        time -= Time.deltaTime;
        if (time>=0)
        {
            obj.transform.Rotate(Vector3.right * Time.deltaTime * 45);
        }
        else
        {
            time = 3;
            falg = false;
            base.BornPos();
        }
    }
}
