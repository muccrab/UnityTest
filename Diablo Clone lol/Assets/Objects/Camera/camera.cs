using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public int cammvoff = 20; //offset for camera movement based on mouse position
    public float cammaxspeed = 0.1f; //maximal speed of the camera 
    public float camspeedmult = 0.01f; //camera speed that adds to the current one
    Vector3 camspeed = new Vector3(0,0,0); //current camera speed
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("CenterView")){
            Vector3 playerpos = GameObject.Find("Player").transform.position;
            transform.position = new Vector3(playerpos.x,0,playerpos.z) + new Vector3(0,5,-3);
        }
        else
        {
            Vector2 mousepos = Input.mousePosition; //Get Mouse Position
            if (mousepos.x < cammvoff)
            {
                if (camspeed.x > -cammaxspeed) camspeed.x -= cammaxspeed;
            }
            else if (mousepos.x > Screen.width-cammvoff)
            {
                if (camspeed.x < cammaxspeed) camspeed.x += cammaxspeed;
            }
            else
            {
                camspeed.x = 0;
            }
            if (mousepos.y < cammvoff)
            {
                if (camspeed.z > -cammaxspeed) camspeed.z -= cammaxspeed;
            }
            else if (mousepos.y > Screen.height-cammvoff)
            {
                if (camspeed.z < cammaxspeed) camspeed.z += cammaxspeed;
            }
            else
            {
                camspeed.z = 0;
            }

            transform.position += camspeed;
        }
    }
}
