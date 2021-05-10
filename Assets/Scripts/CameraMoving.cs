using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;

    //public static bool cameraMove = true;
    public GameObject move;
    public GameObject mainCamera;
    public GameObject character;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        move.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == pos2.position)
        {
            nextPos = pos1.position;
            mainCamera.SetActive(false);
            character.SetActive(false);

        }

        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
        if(transform.position == pos1.position)
        {
            move.SetActive(false);
            mainCamera.SetActive(true);
            character.SetActive(true);
        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
    }
}
