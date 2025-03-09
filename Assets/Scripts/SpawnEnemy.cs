using System.Collections;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
   [SerializeField] GameObject smallEnemy;
    [SerializeField] float timeSpawn;
    [SerializeField]Transform posMin,posMax;
    private void Start() {
       
        StartCoroutine( spawnEnemy());
    }
   IEnumerator spawnEnemy(){
    yield return new WaitForSeconds(timeSpawn);
    Vector2 pos=new Vector2(Random.Range(posMin.position.x,posMax.position.x),Random.Range(posMin.position.y,posMax.position.y));
    GameObject enemy= Instantiate(smallEnemy,pos,transform.rotation);
        StartCoroutine( spawnEnemy());
   }
}
