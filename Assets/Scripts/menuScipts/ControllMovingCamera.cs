using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllMovingCamera : MonoBehaviour
{
    public CameraMoving cam1;
    public cameraFollow2DPlatformer cam2;



    // Start is called before the first frame update
    void Start()
    {
        cam1 = GetComponent<CameraMoving>();
        cam2 = GetComponent<cameraFollow2DPlatformer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
