using UnityEngine;
using System.Collections;

public class moveScript : MonoBehaviour {

    public int speed;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        RectTransform trans = GetComponent<RectTransform>();
        Vector3 loc = trans.localPosition;

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<RectTransform>().localScale = new Vector3(-1f, 1f, 1f);
            GetComponent<RectTransform>().localPosition = new Vector3(loc.x + speed, loc.y, loc.z);

        }

       
    }
}
