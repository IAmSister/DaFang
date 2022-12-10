using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public abstract   class RoleBase 
{
    public GameObject go;
    public DateBase date;
    public RoleBase(string path)
    {
        go = GameObject.Instantiate(Resources.Load<GameObject>(path));
        Debug.Log(path);
    }
    public void SetPosintion(RoleBase role,Vector3 pos)
    {
        role.go.transform.position = pos;
    }
    public void SetPos(Vector3 pos,int index)
    {
        if (index==0)
        {
            date.StartPos = pos;
        }
        go.transform.DOMove(pos,(index+1)*0.1f);
        date.SetIndex(index);

    }
    public abstract Vector3 GetRolesPos();

    public virtual void Reset()
    {
        SetPos(date.StartPos, 0);
    }
}
