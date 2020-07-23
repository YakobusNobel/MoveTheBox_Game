using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public Collision info;

    public bool isGround;

    public float forward = 1000;

    public float sideways = 500;

    public float jump = 10;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forward * Time.deltaTime);
        
        if(Input.GetKey("d")){
            rb.AddForce(sideways * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sideways * Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("w")){
            if(isGround == true){
                rb.velocity = Vector2.up * jump;
                isGround = false;
            }   
        }
        if(rb.position.y < -1){
            FindObjectOfType<GameManager>().endGame();
        }
    }

    void OnCollisionEnter(Collision info) {
        if(info.collider.tag == "Ground"){
            isGround = true;
        }
    }
}
