using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
		public float moveSpeed = 0.5f;
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				this.transform.position += new Vector3 (Input.GetAxis ("Mouse X"), 0, moveSpeed);
				Camera.main.transform.position += new Vector3 (0, 0, moveSpeed);
		}

		void OnTriggerEnter (Collider other)
		{
				if (other.name == "Car") {
						Debug.Log ("A' Dau qua!");
				}
		}
}
