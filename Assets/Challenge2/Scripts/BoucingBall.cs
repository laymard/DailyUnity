using UnityEngine;
using System.Collections;

public class BoucingBall : MonoBehaviour {

    public float minSpeed;
    public float maxSpeed;

	// Use this for initialization
	void Start () {
        Vector3 initSpeed;
        initSpeed.y = 0;initSpeed.z = Random.Range(minSpeed, maxSpeed); initSpeed.x = Random.Range(minSpeed, maxSpeed);

        float randx, randz;
        randx = Random.Range(-0.5f, 0.5f);
        randz = Random.Range(-0.5f, 0.5f);
        Debug.Log("Randx:" + randx + " | Randz:" + randz);

        if (randx < 0) initSpeed.x *= -1;
        if (randz < 0) initSpeed.z *= -1;
        this.GetComponent<Rigidbody>().AddForce(initSpeed,ForceMode.VelocityChange);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {


        
    }

    void OnCollisionEnter(Collision coll)
    {
        this.GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
