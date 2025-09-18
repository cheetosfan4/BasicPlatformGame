using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    //these will be used to determine where to spawn the collectibles
    //I will get these values from the empty gameobjects we created by referencing their x and y values
    public GameObject lowestYSpawn;
    public GameObject highestYSpawn;

    //These are public variables to allow me to drag and drop our prefabs
    public GameObject yellowCollectible;
    public GameObject redCollectible;
    public GameObject blueCollectible;

    //random number to determine which collectible to spawn
    private int randomPrefab;

    //which collectible to spawn
    private GameObject collectibleToSpawn;

    //need a reference to time so we can determine how often to spawn a collectible
    private float time;
    //how long to wait between spawning collectibles
    public float delay;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //add to time. see how much time has passed since last frame
        time += Time.deltaTime;
        if (time >= delay) {
            spawnObject();
            //reset time so the delay is set for the next object to spawn
            time = 0f;
        }
    }
    
    private void spawnObject() {
        //get a random number to determine which object to spawn.
        //The max number is Random.Range is exclusive (up to not including)
        //the code below will return the numbers: 0, 1, or 2
        randomPrefab = Random.Range(0, 3);

        if(randomPrefab == 0) {
            collectibleToSpawn = Instantiate(redCollectible);
        }
        else if(randomPrefab == 1) {
            collectibleToSpawn = Instantiate(blueCollectible);
        }
        else if(randomPrefab == 2) {
            collectibleToSpawn = Instantiate(yellowCollectible);
        }

        collectibleToSpawn.transform.position = new Vector2(lowestYSpawn.transform.position.x, Random.Range(lowestYSpawn.transform.position.y, highestYSpawn.transform.position.y));

    }

}
