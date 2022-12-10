using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBDG 
{
    private static PBDG instance;
    public static PBDG Instance
    {
        get
        {
            if (instance==null)
            {
                instance = new PBDG();
            }
            return instance;
        }
    }
    private CharacterSystem m_CharacterSystem = null;
    private TrapSystem m_TrapSystem = null;
    private MapSystem m_MapSystem = null; 
    private RandomSystem m_RandomSystem = null;
    int currentindex;
    Vector3 end = Vector3.zero;
    //初始化
    public void Initinal()
    {
        m_TrapSystem = new TrapSystem(this);
        m_MapSystem = new MapSystem(this);
        m_RandomSystem = new RandomSystem(this);
        m_CharacterSystem = new CharacterSystem(this);
        m_RandomSystem.GetLength(m_MapSystem.arr.Length);
        for (int i = 0; i < 3; i++)
        {
            m_TrapSystem.InitTrap(m_MapSystem.GetPos(m_RandomSystem.GetRandomNum()));
        }
        m_CharacterSystem.SetPos(m_MapSystem.arr[1].position,0);
        
    }
    //更新
    public void Update()
    {
        m_TrapSystem.Update();
    }
    //释放游戏系统
    public void Release()
    {

    }

    public int LuckDraw(bool falg)
    {
        m_CharacterSystem.SetCurrnetState(falg);
        int n= m_RandomSystem.LuckDraw();
        if (n==0)
        {
            Debug.Log("转萝卜");
            m_MapSystem.Cricle();
            m_TrapSystem.SetTrapFalg(m_CharacterSystem.player.GetRolesPos(),m_CharacterSystem.otherplayer.GetRolesPos());

        }
        else
        {
            currentindex = m_CharacterSystem.GetCurrentPlayerDateIndex()+n;
            if (currentindex>m_MapSystem.GetMaparrlen())
            {
                Debug.Log(m_CharacterSystem.current.go.name + "Win");
                currentindex = m_MapSystem.GetMaparrlen();
                end = new Vector3(0, 2, 0);
            }
            Debug.Log(m_CharacterSystem.current.go.name + "移动" + currentindex);
            m_CharacterSystem.SetPos(m_MapSystem.GetPos(currentindex)+end, currentindex);
        }
        return n;
    }
    public void OnTratResetPos(bool falg)
    {
        if (falg)
        {
            m_CharacterSystem.player.Reset();
        }
        else
        {
            m_CharacterSystem.otherplayer.Reset();
        }
    }
}
