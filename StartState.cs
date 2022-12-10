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
    // �_ʼ
    public override void StateBegin()
    {
        // ���ڴ��M���[���Y���d�뼰��ʼ...��
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
