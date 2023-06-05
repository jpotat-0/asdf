using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject cameraTarget;
    public float rotateSpeed = 2.0f;
    private float rotate;
    public float height = 6.0f;
    public float distance = 5.0f;
    public float zoomAmount = 0.1f;
    public float smoothing = 2.0f;

    private bool inputFollow;
    private bool inputRotateR;
    private bool inputRotateL;
    private bool inputMouseScrollUp;
    private bool inputMouseScrollDown;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
