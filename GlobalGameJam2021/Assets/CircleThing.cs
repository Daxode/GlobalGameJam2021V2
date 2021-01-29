using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class CircleThing : Enemy {
	[Range(0, 1000)] [SerializeField] private float speed;
	void Update() {
		transform.RotateAround(Vector3.zero,Vector3.up, Time.deltaTime*speed);
	}
}