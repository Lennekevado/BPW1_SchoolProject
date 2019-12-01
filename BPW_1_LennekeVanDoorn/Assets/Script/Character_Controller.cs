using UnityEngine;
using System.Collections;

public class Character_Controller : MonoBehaviour {
	public GameObject arrow;
	public Transform spawnPoint;
	//public float arrowForce;

	void Update () {
		if (Input.GetMouseButtonDown (0))
		{
			GameObject go = Instantiate(arrow, spawnPoint.position, Quaternion.identity);
			//go.GetComponent<Rigidbody>().AddForce(transform.forward * arrowForce, ForceMode.Impulse);
		}
	}
}
