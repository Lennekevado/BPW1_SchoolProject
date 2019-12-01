using UnityEngine;

public class Arrow_Projectile : MonoBehaviour {
	public float arrowForce;
	void Start () {
		GetComponent<Rigidbody>().AddForce(transform.forward * arrowForce, ForceMode.Impulse);
	}
}
