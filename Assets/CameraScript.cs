using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

   private Camera camera;
    public Transform player;

	// Use this for initialization
	void Start () {
        camera = this.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(Input.GetAxisRaw("Mouse X"));

        if (Input.GetAxisRaw("Mouse X") != 0)
        {
            camera.transform.RotateAround(player.position, player.up, 2.0f * Input.GetAxisRaw("Mouse X"));
        }
        if (Input.GetAxisRaw("Mouse Y") != 0)
        {
            camera.transform.RotateAround(player.position, player.right, 2.0f * Input.GetAxisRaw("Mouse Y"));
        }

        camera.transform.LookAt(player);

    }
}
