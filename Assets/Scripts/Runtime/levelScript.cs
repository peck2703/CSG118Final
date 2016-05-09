using UnityEngine;
using System.Collections;

public class levelScript : MonoBehaviour
{
    public GameObject enemies;
    public int numOfEnemiesToSpawn;
    public GameObject[] currentEnemies;
    public float xMinSpawn, xMaxSpawn, yMinSpawn, yMaxSpawn;
    public Vector3 necessaryRotation;

	// Use this for initialization
	void Start ()
    {
        currentEnemies = new GameObject[numOfEnemiesToSpawn];
        for (int i = 0; i < numOfEnemiesToSpawn; i++)
        {
            SpawnEnemies(i, Random.Range(xMinSpawn, xMaxSpawn), Random.Range(yMinSpawn, yMaxSpawn));
        }
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        CheckReferencesToEnemies();
	}
    
    //Check the array for destroyed enemies, if so, re-instantiate them
    void CheckReferencesToEnemies()
    {
        for(int i = 0; i < numOfEnemiesToSpawn; i++)
        {
            if (currentEnemies[i] = null)
            {
                print("Spawn Enemy at index " + i);
                SpawnEnemies(i, Random.Range(xMinSpawn, xMaxSpawn), Random.Range(yMinSpawn, yMaxSpawn));
            }
        }
    }

    //Instantiate each enemy
    void SpawnEnemies(int index, float xPos, float yPos)
    {
        currentEnemies[index] = (GameObject)Instantiate(enemies, new Vector3(xPos, yPos, 0), Quaternion.Euler(necessaryRotation.x, necessaryRotation.y, necessaryRotation.z));
    }
}
