using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

   private Camera p_camera;
    public Transform player;

	// Use this for initialization
	void Start () {
        p_camera = this.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetAxisRaw("Mouse X") != 0)
        {
            p_camera.transform.RotateAround(player.position, player.up, 2.0f * Input.GetAxisRaw("Mouse X"));
        }
        if (Input.GetAxisRaw("Mouse Y") != 0)
        {
            p_camera.transform.RotateAround(player.position, player.right, 2.0f * Input.GetAxisRaw("Mouse Y"));
        }

        p_camera.transform.LookAt(player);

    }
}
