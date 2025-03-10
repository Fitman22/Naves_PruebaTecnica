using System.Collections;
using UnityEngine;

public class SamllEnemy : MonoBehaviour
{
  [SerializeField] GameObject bullet;
  Rigidbody2D rb;
  [SerializeField] float timeShoot,speedBullet,speedX,speedY;
  [SerializeField] Transform output;
  bool moveX;
  Vector3 newPosition;
   AudioSource sound;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
         sound=GetComponent<AudioSource>();
        rb.linearVelocityY=-speedY;
        StartCoroutine(shoot());
        StartCoroutine(Move());
    }
    IEnumerator shoot(){
        yield return new WaitForSeconds(timeShoot);
        GameObject bulletinst = Instantiate(bullet,output.position,output.rotation);
        bulletinst.GetComponent<Rigidbody2D>().linearVelocityY=-speedBullet;
        sound.Play();
        Destroy(bulletinst,8f);
        StartCoroutine(shoot());
    }
     IEnumerator Move(){
        moveX=true;
        rb.linearVelocityY=0;
        newPosition= new Vector3(transform.position.x+(Random.Range(-3, 3)),transform.position.y,0);
        newPosition.x=Mathf.Clamp(newPosition.x,-8f,8f);
        yield return new WaitForSeconds(Random.Range(9f,29f));
        StartCoroutine(Move());
    }
    void Update()
    {
        if(moveX){
            if(Vector2.Distance(newPosition,transform.position)>0.1){
                Vector2 position = Vector2.MoveTowards(rb.position,newPosition , speedX * Time.deltaTime);
                
                rb.MovePosition(position);
            }
            else{
                moveX=false;
                rb.linearVelocityY=-speedY;
            }
        }
    }

}
