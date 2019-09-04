using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    //public static UI instance;
    public static Text UiText;
    public GameObject PauseScreen;
    public static GameObject canvas;

    bool paused = false;

	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("Canvas");
        //UiText = 
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setPaused()
    {
        if (!paused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
        paused = !paused;
        PauseScreen.SetActive(paused);
    }

    public void changeSceneTo(string name)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(name);
    }

    public void setObjectActive(GameObject target)
    {
        target.SetActive(!target.activeSelf);
    }

    public static void changeText(string targetName, string newText)
    {
        GameObject.Find(targetName).GetComponent<Text>().text = newText;//perhaps make container of all texts
    }

    public void resetScore()
    {
        PlayerPrefs.SetInt("Highscore", 0);
    }

    public static GameObject findInUI(string name)
    {
        foreach (GameObject g in canvas))
        {
            if (g.name == name)
            {
                return g;
            }
        }
        return null;
    }
}
