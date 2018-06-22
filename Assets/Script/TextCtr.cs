using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextCtr : MonoBehaviour {
    public TextBase textBase;

    public bool sToggle;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.S))
        {
            sToggle = !sToggle;
            if (sToggle)
            {
                textBase.HideAll();
            }
            else
            {
                textBase.ShowAll();
                textBase.ChangeColor(Color.green, 1f, LeanTweenType.easeInCirc);

            }
        }
    }
}
