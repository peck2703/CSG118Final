using UnityEngine;
using System.Collections;

public class MainMenuKey : MonoBehaviour
{
    public string nextLevel;
	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.anyKeyDown)
        {
            Application.LoadLevel(nextLevel);
        }
	}
}
