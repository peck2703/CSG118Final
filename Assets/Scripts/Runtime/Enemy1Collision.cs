using UnityEngine;
using System.Collections;

public class Enemy1Collision : MonoBehaviour
{
    public GameObject explosion;                                                        //Create an intance of the explosion by storing it in a variable
    private int pointsWorth;
    public GameObject sceneManagerGO;
    public int numOfHits = 1;                                                           //Num of hits to destroy object
    public GameObject scoreTexture;

    void Start()
    {
        pointsWorth = GetComponent<Enemy1Collision>().pointsWorth;
        sceneManagerGO = GameObject.Find("SceneManager");
    }
    void Update()
    {
        print(numOfHits);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Laser")                                            //Get the tag off the object on Trigger
        {
            print("Laser Hit");
            if(explosion)                                                               //Check if explosion exists so we don't instantiate nothing
            {
                if (numOfHits >= 0)
                {
                    numOfHits--;
                }
                if (numOfHits <= 0)
                {
                    Instantiate(explosion, transform.position, transform.rotation);

                    Destroy(other.gameObject);                                              //Destroy the laser first then the enemy
                    Destroy(gameObject);
                    sceneManagerGO.GetComponent<sceneManager>().AddScore(pointsWorth);

                    Instantiate(scoreTexture, Vector3.zero, Quaternion.Euler(0,0,0));
                }
            }
        }
    }
}
