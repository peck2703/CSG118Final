using UnityEngine;
using System.Collections;

public class mainGUI : MonoBehaviour
{

	public string levelSelect;
	public string nextLevel;
	public string mainMenu;
	public Camera mainCamera;

    public Texture starWarsButton;
    public Texture starTrekButton;
    public Texture spaceballsButton;

    public bool optionButtonPressed = false;
	// Use this for initialization

    void Start()
    {
        mainCamera = Camera.main;
    }
	void OnGUI()
	{
		if (!optionButtonPressed) {
			if (GUI.Button (new Rect ((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight - 250) / 2, 200, 50), starWarsButton))
            {
				Application.LoadLevel (nextLevel);
			}
			if (GUI.Button (new Rect ((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight - 125) / 2, 200, 50), starTrekButton))
            {
				Application.LoadLevel (levelSelect);
			}
			if (GUI.Button (new Rect ((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight - 0) / 2, 200, 50), spaceballsButton))
            {

			}
            if (GUI.Button(new Rect((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight + 125) / 2, 200, 50), "Options"))
            { 
                optionButtonPressed = true;
            }
        }
        else if (optionButtonPressed) {
            if (GUI.Button(new Rect((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight - 250) / 2, 200, 50), "Video"))
            {

            }
            if (GUI.Button(new Rect((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight - 125) / 2, 200, 50), "Audio"))
            {

            }
            if (GUI.Button(new Rect((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight - 0) / 2, 200, 50), "Controls"))
            {

            }
            if (GUI.Button(new Rect((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight + 125) / 2, 200, 50), "Back to Main Menu"))
            {
                optionButtonPressed = false;
            }
            if (GUI.Button())
            //PlayerPrefs.SetInt("LevelUnlocked")
        }
	}
}
