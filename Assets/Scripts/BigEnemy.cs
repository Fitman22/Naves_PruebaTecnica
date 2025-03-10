using System.Collections;
using UnityEngine;

public class BigEnemy : MonoBehaviour
{
  [SerializeField] GameObject bullet;
  Rigidbody2D rb;
  [SerializeField] float timeShoot,speedBullet,speedX,speedY,timeVanish;
  [SerializeField] Transform output;
  SpriteRenderer sprite;
  [SerializeField] Vector2 LimitMin,LimitMax;
  bool moveX;
  Vector3 newPosition;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

    }
   void Vanish(){
    
   }
    void Teleport(){

    }
}
