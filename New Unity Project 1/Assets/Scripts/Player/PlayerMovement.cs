using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 6f; 
}
Vector3 movement;
Animator anmin;
Rigidbody playerRigidbody;
int floorMask;
float camRayLength = 100f;

void Awake()
{
	floormask = LayerMask.GetMask ("Floor");
	anim = GetComponent<Animator> ();
	playerRigidbody = GetComponent<Rigidbody> ();


	void FixedUpdate()
	{
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
	
	}

	void Move (float h, float v)
	{
		movement.Set (h, 0f, v);
	
		movement = movement.normalized * speed * Time.deltaTime;

		playerRigidbody.MovePosition (transform.position + movement);
	}

	void Turning()
	{
		Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

		RaycastHit floorHit;

		if(Physics.Raycast (camRay, out floorHit, camRayLength, floorMask))
	    
			Vector3 playerToMouse = floorHit.point - transform.position;
	 		playerToMouse.y 0f; 
			





		}

}
















