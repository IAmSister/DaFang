using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuState : ISceneState
{
	public bool falg = false;
	public MainMenuState(SceneStateController Controller) : base(Controller)
	{
		this.StateName = "MainMenuState";
	}

	public override void StateBegin()
	{
		PBDG.Instance.Initinal();
		Button cj = GameObject.Find("Btn_cj").GetComponent<Button>();
		Text text= cj.transform.GetChild(0).GetComponent<Text>();
		cj.onClick.AddListener(() =>
		{
			text.text = PBDG.Instance.LuckDraw(falg).ToString();
			falg = !falg;
			
		});
	}
    public override void StateUpdate()
    {
		PBDG.Instance.Update();

	}
    public override void StateEnd()
    {
		PBDG.Instance.Release();
	}
}
