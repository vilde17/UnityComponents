using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {

    public SpriteRenderer rend;
    public Color color;
    public TrailRenderer trialrend;
    
	// Use this for initialization
	void Start() {
        rend.color = color;
        rend.color = new Color(1f, 0.25f, 0.33f);
        //transform.position = new Vector3(-5f, transform.position.y);
        
       
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 360f * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -360f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-4f * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.magenta;
            trialrend.endColor = new Color(1, 0, 1);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(4f * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.red;
        }


    }
}
