using UnityEngine;

public class SpaceAnimation : MonoBehaviour
{
    [SerializeField] float startHeight,maxHeight,speed;
    
    SpriteRenderer sprite;
    void Start()
    {
        sprite=GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        sprite.size+=new Vector2(0,speed*Time.deltaTime);
        if(sprite.size.y>maxHeight){
            sprite.size=new Vector2(sprite.size.x,startHeight);
        }
    }
}
