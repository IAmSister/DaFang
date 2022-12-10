using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartState : ISceneState
{
    public StartState(SceneStateController Controller) : base(Controller)
    {
        this.StateName = "StartState";
    }
    // 開始
    public override void StateBegin()
    {
        // 可在此進行遊戲資料載入及初始...等
        Button tmpBtn = GameObject.Find("StartGameBtn").GetComponent<Button>();
        if (tmpBtn != null)
            tmpBtn.onClick.AddListener(() => OnStartGameBtnClick(tmpBtn));
    }

    public override void StateUpdate()
    {
        
    }
    private void OnStartGameBtnClick(Button theButton)
    {
        m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuScene");
    }
}
