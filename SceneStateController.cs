using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController 
{
	private ISceneState m_State;
	private bool m_bRunBegin = false;

	public SceneStateController()
	{ }

	// 设定状态
	public void SetState(ISceneState State, string LoadSceneName)
	{
		m_bRunBegin = false;


		LoadScene(LoadSceneName);

		if (m_State != null)
			m_State.StateEnd();


		m_State = State;
	}
	// 载入场景
	private void LoadScene(string LoadSceneName)
	{
		if (LoadSceneName == null || LoadSceneName.Length == 0)
			return;
		Application.LoadLevel(LoadSceneName);
	}

	// 更新
	public void StateUpdate()
	{
        if (Application.isLoadingLevel)
        {
			return;
        }

		// 通知新的State開始
		if (m_State != null && m_bRunBegin == false)
		{
			m_State.StateBegin();
			m_bRunBegin = true;
		}

		if (m_State != null)
			m_State.StateUpdate();
	}
}
