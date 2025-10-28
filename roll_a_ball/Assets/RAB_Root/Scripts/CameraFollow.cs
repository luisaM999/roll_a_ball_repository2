using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform player;

    public Vector3 offset; 

    public float cameraSpeed = 10f;




    void Start()
    {
       



    }

    
    void LateUpdate()
    {
        transform.position = player.position + offset;



    }
}
