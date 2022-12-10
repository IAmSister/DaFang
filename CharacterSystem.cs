using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSystem : IGameSystem
{
    public RoleBase player, otherplayer;//´¢´æ
    public RoleBase current=null;//µ±Ç°Íæ¼Ò
    public CharacterSystem(PBDG pBDG):base(pBDG)
    {
        player = new Player("player1");

        otherplayer = new OtherPlayer("player2");

    }

    public override void Initialize()
    {
        
    }

    public override void Release()
    {
        base.Release();
    }

    public override void Update()
    {
        base.Update();
    }

    public void SetPos(Vector3 pos,int index)
    {
        if (current==null)
        {
            player.SetPos(pos, index);
            otherplayer.SetPos(pos, index);
        }
        else
        {
            current.SetPos(pos, index);
        }
        
    }

    public void SetCurrnetState(bool falg)
    {
        if (falg==false)
        {
            current = player;
        }
        else
        {
            current = otherplayer;
        }
    }

    public int GetCurrentPlayerDateIndex()
    {
        return current.date.GetIndex();
    }


}
