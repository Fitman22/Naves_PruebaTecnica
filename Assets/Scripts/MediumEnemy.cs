using System.Collections;
using UnityEngine;

public class MediumEnemy : MonoBehaviour
{
  [SerializeField] GameObject bullet;
  Rigidbody2D rb;
  [SerializeField] float timeShoot,speedBullet,speedX,speedY;
  [SerializeField] Transform output;
  bool moveX;
    AudioSource sound;
  Vector3 newPosition;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
         sound=GetComponent<AudioSource>();
        rb.linearVelocityY=-speedY;
        StartCoroutine(shoot());
          Move();
    }
    IEnumerator shoot(){
        yield return new WaitForSeconds(timeShoot);
        GameObject bulletinst = Instantiate(bullet,output.position,output.rotation);
        bulletinst.GetComponent<Rigidbody2D>().linearVelocityY=-speedBullet;
        sound.Play();
        Destroy(bulletinst,8f);
         StartCoroutine(shoot());
    }
     void Move(){
        newPosition= new Vector3(transform.position.x+(Random.Range(-7, 7)),transform.position.y-speedY,0);
        newPosition.x=Mathf.Clamp(newPosition.x,-7.4f,7.4f);
     }
    void Update()
    {
            if(Vector2.Distance(newPosition,transform.position)>0.2){
                Vector2 position = Vector2.MoveTowards(rb.position,newPosition , speedX * Time.deltaTime);
                rb.MovePosition(position);
            }
            else{
                 Move();
            }
    }

}
