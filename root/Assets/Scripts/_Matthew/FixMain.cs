﻿using UnityEngine;
using System.Collections;

public class FixMain : MonoBehaviour {

	// Use this for initialization
	void Start () 
    {
        HUDManager.instance.SetState("start",  false);
        HUDManager.instance.SetState("panel",  true);
        HUDManager.instance.SetState("menu",   false);
        HUDManager.instance.SetState("finish", false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
