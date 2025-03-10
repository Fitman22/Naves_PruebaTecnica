using System.Collections;
using UnityEngine;

public class BigEnemy : MonoBehaviour
{
  [SerializeField] GameObject bullet;
  [SerializeField] float timeShoot,speedBullet,timeVanish;
  [SerializeField] Transform output;
  [SerializeField] Vector2 LimitMin,LimitMax;
  [SerializeField]Animator anim;
    AudioSource sound;
  bool canShoot;
    void Start()
    {
       sound=GetComponent<AudioSource>();
     StartCoroutine(Vanish());
      StartCoroutine(shoot());
    }
   IEnumerator Vanish(){
      anim.Play("Vanish");
      canShoot=false;
      yield return new WaitForSeconds(timeVanish);
      Vector2 newPosition= new Vector2(Random.Range(LimitMin.x,LimitMax.x),Random.Range(LimitMin.y,LimitMax.y));
      transform.position=newPosition;
      anim.Play("InVanish");  
      canShoot=true;
      yield return new WaitForSeconds(Random.Range(3f,10f));
      StartCoroutine(Vanish());
   }
  IEnumerator shoot(){
        yield return new WaitForSeconds(timeShoot);
        if(canShoot){
        GameObject bulletinst = Instantiate(bullet,output.position,output.rotation);
        Vector2 posTarget= GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector2 target = ((Vector2)transform.position-posTarget).normalized;
        bulletinst.GetComponent<Rigidbody2D>().linearVelocity=target*-speedBullet;
        sound.Play();
        Destroy(bulletinst,7f);
        }
        StartCoroutine(shoot());
    }
}
