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

    public string starWarsLevel;
    public string starTrekLevel;
    public string spaceballsLevel;

    public bool optionButtonPressed = false;

    void Start()
    {
        mainCamera = Camera.main;
    }
	void OnGUI()
	{
		if (!optionButtonPressed) {
			if (GUI.Button (new Rect ((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight - 250) / 2, 200, 50), starWarsButton))
            {
				Application.LoadLevel (starWarsLevel);
			}
			if (GUI.Button (new Rect ((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight - 125) / 2, 200, 50), starTrekButton))
            {
				
			}
			if (GUI.Button (new Rect ((mainCamera.pixelWidth - 200) / 2, (mainCamera.pixelHeight - 0) / 2, 200, 50), spaceballsButton))
            {
                Application.LoadLevel(spaceballsLevel);
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
        }
	}
}
