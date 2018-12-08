using UnityEngine;
using UnityEngine.AI;
using System.Collections;

public class ClickToMove : MonoBehaviour {
	private NavMeshAgent navMesh;
	private Animator anim;

	public Vector3 targetPos;
	public LayerMask groundLayer;

	private void Awake() {
		navMesh = GetComponent<NavMeshAgent> ();
		anim = GetComponent<Animator> ();
	}

	private void Update(){
		anim.SetFloat ("velocity", navMesh.velocity.sqrMagnitude);
		if (Input.GetButton ("Fire1")) {
			MoveTowardsClick ();
		}
	}

	private void MoveTowardsClick(){
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, Mathf.Infinity, groundLayer)) {
			if (targetPos != hit.point) {
				targetPos = hit.point;
			}
			navMesh.SetDestination (targetPos);
		}
	}
}