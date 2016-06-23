using UnityEngine;
using System.Collections;

public class Camera_Zoom : MonoBehaviour {

    public float zoomSize = 5;

	void Update () {
        
        if(Input.GetAxis("Mouse ScrollWheel") > 0 )
        {
            if (zoomSize > 4)
                zoomSize -= 1;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            if (zoomSize < 8)
                zoomSize += 1;
        }

        GetComponent<Camera>().orthographicSize = zoomSize;
    }

}
