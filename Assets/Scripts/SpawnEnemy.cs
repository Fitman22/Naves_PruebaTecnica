using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [System.Serializable]
    class enemy{
        public GameObject prefab;
        public float probability;
    }
   [SerializeField] List<enemy> enemies;
    [SerializeField] float timeSpawn;
    [SerializeField]Transform posMin,posMax;
    private void Start() {
       
        StartCoroutine( spawnEnemy());
    }
   IEnumerator spawnEnemy(){
    yield return new WaitForSeconds(timeSpawn);
    Vector2 pos=new Vector2(Random.Range(posMin.position.x,posMax.position.x),Random.Range(posMin.position.y,posMax.position.y));
    GameObject enemy= Instantiate(randomEnemy(),pos,transform.rotation);
    StartCoroutine( spawnEnemy());
   }
   GameObject randomEnemy(){
     float randomValue = Random.Range(0, 1f);
        float cumulativeProbability = 0f;
        float totalWeight = 0f;
        foreach (var enemy in enemies) totalWeight += enemy.probability;

        foreach (var enemy in enemies)
        {
            cumulativeProbability += enemy.probability / totalWeight;
            if (randomValue <= cumulativeProbability) return enemy.prefab;
        }

        return enemies[0].prefab; 
   }
}
