using UnityEngine;
using System.Collections;

public class ShipController : MonoBehaviour {

	public float speed = 100;

//	void Start(){
//		count = 0;
//		SetCountText ();
//		winText.text = "";
//	}
	
	void FixedUpdate (){
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); 
		
		rigidbody.AddForce(movement * speed * Time.deltaTime);
	}
	
//	void OnTriggerEnter(Collider other) {
//        //Destroy(other.gameObject);
//		if( other.gameObject.tag == "PickUp" ){
//			other.gameObject.SetActive(false);
//			count++;
//			SetCountText ();
//		}
//    }

//	void SetCountText ()
//	{
//		countText.text = "Score: " + count;
//		if ( count >= 8 ){
//			winText.text = "YOU WIN !!";
//		}
//	}
}
