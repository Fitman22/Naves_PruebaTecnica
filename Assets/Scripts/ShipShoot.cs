using UnityEngine;

public class ShipShoot : MonoBehaviour
{
   
  InputSystem_Actions.PlayerActions controls;

  [SerializeField] int damage;
  [SerializeField] float speedBullet;
  [SerializeField] GameObject bullet;
  [SerializeField] Transform output;
  AudioSource sound;
    void Start()
    {
        controls=ControlsController.getControls();
        sound=GetComponent<AudioSource>();
        controls.Attack.started+=ctr=>Shoot();
    }
    void Shoot(){
        GameObject BulletIns= Instantiate(bullet,output.position,output.rotation);
        BulletIns.GetComponent<Rigidbody2D>().linearVelocityY=speedBullet;
        sound.Play();
        Destroy(BulletIns,6f);
    }
}
