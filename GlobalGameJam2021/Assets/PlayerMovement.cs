using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour {
	private NavMeshAgent nva;
	Camera cam;
	
	// Start is called before the first frame update
	void Start() {
		nva = GetComponent<NavMeshAgent>();
		cam = Camera.main;
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetMouseButtonUp(1)) {
			var        pointToWalkTo = cam.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(pointToWalkTo, out hit)) {
				var enemy = hit.transform.gameObject.GetComponent<IDamageable>();
				if (enemy != null) {
					enemy.DoDamage(5);
					print(enemy.Health.ToString());
				}

				nva.SetDestination(hit.point);
				// Do something with the object that was hit by the raycast.
			}
		}
	}
}