using System.Collections;
using UnityEngine;
public class Health : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    [SerializeField] int points;
    [SerializeField]bool isPlayer;
    void Start()
    {
         StartCoroutine(checkDistance());
    }
    IEnumerator checkDistance(){
        if(transform.position.y<-6){
            Destroy(gameObject);
        }
        yield return new WaitForSeconds(10f);
        StartCoroutine(checkDistance());
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet")){
            Destroy(collision.gameObject);
            Die();
        }
        if(collision.CompareTag("Player")){
            collision.GetComponent<Health>().Die();
            Die();
        }
    }
    public void Die(){
        if(isPlayer)OptionsGame.instance.Lose();
        GameObject explode = Instantiate(explosion,transform.position,transform.rotation);
        ScoreController.instance.addScore(points);
        Destroy(explode,3f);
        Destroy(gameObject);
   }
}
