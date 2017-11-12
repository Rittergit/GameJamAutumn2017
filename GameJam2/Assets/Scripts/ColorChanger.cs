using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
    
    public int index;
    public Color color;
    private Renderer rend;
   
    void setRenderer()
    {
        rend = GetComponent<Renderer>();
    }
    public void setColor(Color color)
    {
        rend.material.color = color;
    }


    // Use this for initialization
	void Start () {
        setRenderer();
        setColor(color);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
