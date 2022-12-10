using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSystem : IGameSystem
{
    public List<TrapBase> list = new List<TrapBase>();
    public int num = 0;
    public TrapSystem(PBDG pBDG) : base(pBDG)
    {
        Initialize();
    }

    public override void Initialize()
    {
        
    }

    public override void Release()
    {
        
    }

    public override void Update()
    {
        if (list.Count<=0)
        {
            return;
        }
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].falg==true)
            {
                list[i].Update();
            }
        }
    }

    public void InitTrap(Vector3 pos)
    {
        num++;
        list.Add(new Trapone("ÏÝÚå"+num, pos));
    }

    public void SetTrapFalg(Vector3 player,Vector3 otherplayer)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].pos==player)
            {
                m_PBDG.OnTratResetPos(true);
            }
            if (list[i].pos == otherplayer)
            {
                m_PBDG.OnTratResetPos(false);
            }
            list[i].falg = true;
        }
    }
}
