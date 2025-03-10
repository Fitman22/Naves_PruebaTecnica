using UnityEngine;

public class ShipMove : MonoBehaviour
{
  InputSystem_Actions.PlayerActions controls;
  Rigidbody2D rb;
  Animator anim;
  [SerializeField] float Speed;
    void Start()
    {
        controls=ControlsController.getControls();
        anim=GetComponent<Animator>();
        rb=GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector2 movePosition=controls.Move.ReadValue<Vector2>();
        if(movePosition.x!=0){
            rb.MovePosition(rb.position+(movePosition*Speed*Time.deltaTime));
            if(movePosition.x>0){
                anim.SetInteger("dir",2);
            }
            else if(movePosition.x<0){
                anim.SetInteger("dir",1);
            }
        }
        else{
             anim.SetInteger("dir",0);
        }
    }
}
