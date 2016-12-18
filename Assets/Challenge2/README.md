# Challenge 2 : Change color material
Aim of the challenge : change material color with script. In this scene, marbles are boucingg inside a cube. Their color turn to red when they entered to collision with something.


## Important part of script

````csharp

// Required Component to call this method : Rigidbody and Sphere Collider
void OnCollisionEnter(Collision coll)
{
    this.GetComponent<MeshRenderer>().material.color = Color.red;
}

````
