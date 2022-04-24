using System.Collections;
using UnityEngine;

public class CollectableSpawnerLogic : MonoBehaviour
{
    public GameObject collectable;
    public GameObject badcollectable;
    public float collectableSpawnTime = 1.0f;
    public float badcollectableSpawnTime = 2.0f;
    float randomXCollectable = 0.0f;
    float randomYCollectable = 0.0f;
    float randomXBadCollectable = 0.0f;
    float randomYBadCollectable = 0.0f;
    readonly float maxX = 17.5f;
    readonly float maxY = 9.0f;
    
    void Start()
    {
        StartCoroutine(SpawnCollactables());
        StartCoroutine(SpawnBadCollactables());
    }
            IEnumerator SpawnCollactables() {
            while (true){
                SpawnCollactable();
                yield return new WaitForSeconds(collectableSpawnTime);
            }
        }
        
            IEnumerator SpawnBadCollactables() {
            while (true){
                SpawnBadCollactable();
                yield return new WaitForSeconds(badcollectableSpawnTime);
            }
        }

    void SpawnBadCollactable(){
        randomXBadCollectable = Random.Range(-maxX, maxX);
        randomYBadCollectable = Random.Range(-maxY, maxY);

        Instantiate(collectable, new Vector3(randomXBadCollectable, randomYBadCollectable, 0), Quaternion.identity); 
    }
     void SpawnCollactable(){
        randomXCollectable = Random.Range(-maxX, maxX);
        randomYCollectable = Random.Range(-maxY, maxY);

        Instantiate(badcollectable, new Vector3(randomXCollectable, randomYCollectable, 0), Quaternion.identity); 
    }
}
