


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor.SceneManagement;

public class LevelTransfer : MonoBehaviour {

	// Use this for initialization
  
    public int nextLevel;
    public bool isReturn;

    

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        if (isReturn)
        {
            print(LevelList.preLevel+ "eeeeeeeeeeeeeeeeee");

            Application.LoadLevel(LevelList.preLevel); }
        else
        {
            LevelList.preLevel = Application.loadedLevel;
            print(LevelList.preLevel);
            Application.LoadLevel(nextLevel);
        }
        
    }

}
