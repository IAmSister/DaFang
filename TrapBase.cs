using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TrapBase
{
    public bool falg;
    public GameObject obj;
    public string path;
    public Vector3 pos;
    public float time = 0;
    public Vector3 born;
    public TrapBase(string path,Vector3 pos)
    {
        this.path = path;
        this.pos = pos;
        InitTrap();
    }
    public void InitTrap()
    {
        obj = GameObject.Instantiate(Resources.Load<GameObject>(path));
        obj.transform.position=pos;
        born = obj.transform.eulerAngles;

    }
    public virtual void Update()
    {

    }

    public virtual void BornPos()
    {
        obj.transform.eulerAngles = born;
    }
}
