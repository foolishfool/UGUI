/***
 * 
 *    Title: "Dark Crash" Project
 *           
 *    Script Function:
 *           
 * 
 *    Description: 
 *  
 * 
 *    Date: 2017
 *    
 *    Version: 0.1
 *    
 *    Modify Recoder: Qiang Fu
 *   
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCharacterAttr : MonoBehaviour {



    int attribute;

    // Use this for initialization
    void Start () {

        attribute = int.Parse(this.transform.GetChild(0).GetComponent<Text>().text);
    }
	
	// Update is called once per frame
	void Update () {		
	}

    public void OnMouseDown()
    {
        print(this.transform.GetChild(0).GetComponent<Text>().text);
        attribute++;
        // attrbute = this.transform.GetChild(0).GetType();
        this.transform.GetChild(0).GetComponent<Text>().text = attribute.ToString();


    }


}
