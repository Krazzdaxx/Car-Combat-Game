﻿using UnityEngine;
using System.Collections;

public class BeamProjectile : BaseProjectile {
	public float beamLength = 5.0f;
	GameObject m_launcher;
	
	
	void Update () {
		if(m_launcher)
		{
			GetComponent<LineRenderer>().SetPosition(0,m_launcher.transform.position);
			GetComponent<LineRenderer>().SetPosition(1,m_launcher.transform.position + (m_launcher.transform.forward *beamLength));
		}
	}
	
	
	public override void FireProjectile(GameObject launcher, GameObject target, int damage)
	{
		if(target)
		{
			m_launcher = launcher;
			transform.SetParent(m_launcher.transform);
		}
	}
}