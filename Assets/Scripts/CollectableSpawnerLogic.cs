using System.Collections;
using System.Collections.Generic;
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
    float maxX = 17.5f;
    float maxY = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnCollactables());
        StartCoroutine(spawnBadCollactables());
    }
            IEnumerator spawnCollactables() {
            while (true){
                spawnCollactable();
                yield return new WaitForSeconds(collectableSpawnTime);
            }
        }
        
            IEnumerator spawnBadCollactables() {
            while (true){
                spawnBadCollactable();
                yield return new WaitForSeconds(badcollectableSpawnTime);
            }
        }

    void spawnBadCollactable(){
        randomXBadCollectable = Random.Range(-maxX, maxX);
        randomYBadCollectable = Random.Range(-maxY, maxY);

        Instantiate(collectable, new Vector3(randomXBadCollectable, randomYBadCollectable, 0), Quaternion.identity); 
    }
     void spawnCollactable(){
        randomXCollectable = Random.Range(-maxX, maxX);
        randomYCollectable = Random.Range(-maxY, maxY);

        Instantiate(badcollectable, new Vector3(randomXCollectable, randomYCollectable, 0), Quaternion.identity); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
