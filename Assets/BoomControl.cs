using UnityEngine;
using System.Collections;

public class BoomControl : MonoBehaviour {
	public Vector3 force;
	private Rigidbody2D rigid;
	// Use this for initialization
	void Start () {
		rigid=gameObject.GetComponent<Rigidbody2D>();
		rigid.AddForce(force);
	}
	
	// Update is called once per frame
	void Update () {
	


	}
}
