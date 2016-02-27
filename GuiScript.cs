using UnityEngine;
using System.Collections;

public class GuiScript : MonoBehaviour {

public Texture2D crosshair;
public Rect position;
	
    void Start () {
	
	}

	void Update () {
	position = new Rect((Screen.width - crosshair.width) / 2,(Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);
	}

    void OnGUI()
    {
        GUI.DrawTexture (position, crosshair);
    }
}
