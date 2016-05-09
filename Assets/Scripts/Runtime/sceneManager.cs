using UnityEngine;
using System.Collections;

public class sceneManager : MonoBehaviour
{
    public bool timedGame = false;
    float gameTime = 60.0f;
    public int score = 0;
    public int lives = 3;
    public float delayTimer = 2.0f;

    public GameObject myPlayer;
    private float myNewXpos, myNewYPos;
	// Use this for initialization
	void Start ()
    {
        if (timedGame)
        {
            InvokeRepeating("CountDown", 1.0f, 1.0f);
        }
	}

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        {
            Application.LoadLevel("LoseScreenScene");
            lives = 3;
            PlayerPrefs.SetInt("SCORE", score);
            score = 0;
        }
        if (gameTime <= 0)
        {
            Application.LoadLevel("WinScene");
            lives = 3;
            PlayerPrefs.SetInt("Score", score);
            score = 0;
        }
        ;
    }
    public void AddScore(int scoreAmount)
    {
        score+= scoreAmount;
    }
    IEnumerator Respawn(float spawnDelay)
    {
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(myPlayer, new Vector3(myNewXpos, myNewYPos, 0), Quaternion.Euler(0, 0, 0));
    }
    public void SubtractLife(float newXpos, float newYPos)
    {
        lives -= 1;
        score++;
        //myPlayer = player;
        myNewXpos = newXpos;
        myNewYPos = newYPos;
        delayTimer = 2.0f;
        StartCoroutine("Respawn", 2.0f);
    }

    void CountDown()
    {
        if (--gameTime == 0)
        {
            CancelInvoke("CountDown");
        }
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score: " + score);
        GUI.Label(new Rect(10, 25, 100, 35), "Lives: " + lives);
        if(timedGame)
        {
            GUI.Label(new Rect(Screen.width - 75, 10, 100, 20), "Counter: " + gameTime);
        }
        
    }
}
