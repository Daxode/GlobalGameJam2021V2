using UnityEngine;

namespace DefaultNamespace {
	[CreateAssetMenu(fileName = "Unnamed EnemyData", menuName = "Qode/Entities/EnemyData", order = 0)]
	public class EnemyData : ScriptableObject {
		public float   MaxHealth = 200f;
		public Texture kage;
	}
}