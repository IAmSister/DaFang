using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MapSystem : IGameSystem
{
    public Transform[] arr;
    public MapSystem(PBDG pBDG) : base(pBDG)
    {
        Initialize();
    }

    public override void Initialize()
    {
        arr = GameObject.Find("Plane").transform.GetComponentsInChildren<Transform>();
        Debug.Log(arr.Length);
    }

    public Vector3 GetPos(int index)
    {
        return arr[index].position;
    }
    public int GetMaparrlen()
    {
        return arr.Length-1;
    }

    public void Cricle()
    {
        arr[arr.Length - 1].DORotate(new Vector3(0, Random.Range(1,360), 0),3);
    }
}
