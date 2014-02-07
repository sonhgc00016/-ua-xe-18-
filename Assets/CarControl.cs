using UnityEngine;
using System.Collections;

public class CarControl : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Camera.main.transform.position.z >= (this.transform.position.z + 20)) {
						Vector3 v = this.transform.position;
						v.x = 0;
						v += new Vector3 (Random.Range (-4.5f, 4.5f), 0, Random.Range (40, 60));
						this.transform.position = v;
				}
		}
}
