using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public static Spawn instance;

	// Use this for initialization
	void Start ()
    {
        instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static GameObject spawn(GameObject go)
    {
        return Instantiate(go, new Vector3(), Quaternion.identity);
    }

    public static GameObject spawn(GameObject go, Vector3 position)
    {
        return Instantiate(go, position, Quaternion.identity);
    }

    public static GameObject spawn(GameObject go, Vector3 position, Vector3 facing)
    {
        return null;
        //new Vector3(Mathf.a);
        //return Instantiate(go, position, Quaternion.identity);
    }

    public static GameObject spawnRight(GameObject go)
    {
        Vector2 pos = new Vector2(GameManager.topRightP.x + 1, 0);
        return Instantiate(go, pos, Quaternion.identity);
    }

    public static GameObject spawnRightRand(GameObject go)
    {
        Vector2 pos = Area.RandOffscreenPos(Vector2.right);
        return Instantiate(go, pos, Quaternion.identity);
    }
}
