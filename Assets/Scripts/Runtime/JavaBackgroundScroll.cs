using UnityEngine;
using System.Collections;

public class JavaBackgroundScroll : MonoBehaviour {

    public float scrollSpeed;
    Renderer rend;
    public bool horizontal;

    // Use this for initialization
    void Start ()
    {
        rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (horizontal)
        {
            rend.material.SetTextureOffset("_MainTex", new Vector2(Time.time * scrollSpeed, 0));
        }
        else
        {
            rend.material.SetTextureOffset("_MainTex", new Vector2(0, Time.time * scrollSpeed));
        }
    }
}
