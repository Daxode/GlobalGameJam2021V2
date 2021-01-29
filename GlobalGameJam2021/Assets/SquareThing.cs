using System;
using UnityEngine;

namespace DefaultNamespace {
	public class SquareThing : Enemy {
		private Vector3 offset;
		private float   shield = 100;

		protected override void Start() {
			offset = transform.position;
			base.Start();
		}

		private void Update() {
			transform.position = offset + new Vector3(0, 0, Mathf.Sin(Time.time*1f) * 2);
		}
	}
}