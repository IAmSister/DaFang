using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoop : MonoBehaviour
{
    SceneStateController m_SceneStateController = new SceneStateController();
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        m_SceneStateController.SetState( new StartState(m_SceneStateController), "");
        
    }

    void Update()
    {
        m_SceneStateController.StateUpdate();
    }
}
