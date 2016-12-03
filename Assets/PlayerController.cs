using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Transform transform;
    public Camera camera;

	// Use this for initialization
	void Start () {
        transform = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetAxisRaw("Vertical") != 0)
        {
            // update orientation from camera
            Vector3 orien = transform.position - camera.transform.position;
            orien.Normalize();

            Vector2 a = new Vector2(orien.x, orien.z);
            a.Normalize();
            Vector2 b = new Vector2(transform.forward.x, transform.forward.z);
            b.Normalize();

            float cos = Vector2.Dot(a, b);
            float arccos = Mathf.Acos(cos);
            arccos=Mathf.Rad2Deg*arccos;

            Debug.Log("Arcos : "+arccos);

            transform.RotateAround(transform.position, transform.up, arccos);
            camera.transform.RotateAround(transform.position, transform.up, -arccos);

            transform.position += transform.forward*0.01f;

        }
	}


}
