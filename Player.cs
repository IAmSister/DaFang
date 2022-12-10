using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : RoleBase
{
    public Player(string path) : base(path)
    {
        date = new PlayerDate(path);
    }
    public override Vector3 GetRolesPos()
    {
        return go.transform.position;
    }
    public override void Reset()
    {
        base.Reset();
    }
}
