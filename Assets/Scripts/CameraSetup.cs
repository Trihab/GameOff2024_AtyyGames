using UnityEngine;

public class CameraSetupz : MonoBehaviour
{
    public Transform camPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        transform.position = camPos.transform.position;
    }
}
