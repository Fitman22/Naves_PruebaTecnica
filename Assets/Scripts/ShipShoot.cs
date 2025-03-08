using UnityEngine;

public class ShipShoot : MonoBehaviour
{
   
  InputSystem_Actions.PlayerActions controls;

  [SerializeField] int damage;
  [SerializeField] float speedBullet;
  [SerializeField] GameObject bullet;
  [SerializeField] Transform output;
    void Start()
    {
        controls=ControlsController.getControls();
        controls.Attack.started+=ctr=>Shoot();
    }
    void Shoot(){
        GameObject BulletIns= Instantiate(bullet,output.position,output.rotation);
        BulletIns.GetComponent<Rigidbody2D>().linearVelocityY=speedBullet;
        Destroy(BulletIns,6f);
    }
}
