using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    private Transform p_transform;
    public Camera p_camera;

    // Use this for initialization
    void Start()
    {
        p_transform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxisRaw("Vertical") != 0)
        {
            // update orientation from camera
            Vector3 orien = p_transform.position - p_camera.transform.position;
            orien.Normalize();
            Vector3 cleft = -p_camera.transform.right;
            Vector2 cleft2 = new Vector2(cleft.x, cleft.z);

            Vector2 a = new Vector2(orien.x, orien.z);
            a.Normalize();
            Vector2 b = new Vector2(p_transform.forward.x, p_transform.forward.z);
            b.Normalize();

            float sign = Vector2.Dot(b, cleft2);
            if (sign > 0)
            {
                sign = 1f;
            }
            else
            {
                sign = -1f;
            }

            float cos = Vector2.Dot(a, b);
            orien.y = 0;
            orien.Normalize();
            Vector3 cr = Vector3.Cross(orien, p_transform.forward);

           
            if (cos > 1) cos = 1f;
            if (cos < -1) cos = -1f;
            float arccos = Mathf.Acos(cos);
            arccos = Mathf.Rad2Deg * arccos;


            p_transform.RotateAround(p_transform.position, p_transform.up, 0.1f * arccos*sign);
            p_camera.transform.RotateAround(p_transform.position, p_transform.up, -arccos * 0.1f*sign  );

            p_transform.position += p_transform.forward * 0.01f;

        }
    }


}
