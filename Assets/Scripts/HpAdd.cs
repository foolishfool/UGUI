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

public class HpAdd : MonoBehaviour {
    private Slider Hpbar;
    private float timer = 0;

	// Use this for initialization
	void Start () {

        Hpbar = this.transform.GetComponentInParent<Slider>();

    }
	
	// Update is called once per frame
	void Update () {
       
    }
    public void OnMouseDown()
    {

        timer += Time.deltaTime;
        Hpbar.value += timer * 0.2f;
    }


}
