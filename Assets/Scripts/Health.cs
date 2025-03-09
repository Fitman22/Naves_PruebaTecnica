using UnityEngine;
public class Health : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    [SerializeField] int points;
    [SerializeField]bool isPlayer;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Bullet")){
            Destroy(collision.gameObject);
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
