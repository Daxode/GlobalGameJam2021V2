using System;
using UnityEngine;

namespace DefaultNamespace {
	public abstract class Enemy : MonoBehaviour, IDestructible {
		[SerializeField] protected EnemyData data;
		private                    float     maxHealth;
		private                    float     health;

		protected virtual void Start() {
			MAXHealth = data.MaxHealth;
			Health = MAXHealth;
			
			GetComponent<MeshRenderer>().material.SetTexture("_MainTex", data.kage);
		}

		public float MAXHealth {
			get => maxHealth;
			set => maxHealth = value;
		}

		public float Health {
			get => health;
			set => health = Mathf.Clamp(value, 0, maxHealth);
		}
		
		public virtual void DoDamage(float dmg) {
			Health -= dmg;

			if (Health == 0) {
				DestroyObject();
			}
		}

		public void DestroyObject() {
			Destroy(gameObject);
		}
	}
}