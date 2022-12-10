using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IGameSystem 
{
    protected PBDG m_PBDG = null;
    public  IGameSystem(PBDG pBDG)
    {
        m_PBDG = pBDG;
    }

    public virtual void Initialize() { }
    public virtual void Release() { }
    public virtual void Update() { }
}
