using UnityEngine;
using System.Collections;

public class CameraPos : MonoBehaviour
{

    //Must be public
    public void ChangePos1()
    {
        transform.position = new Vector3(0f, 0f, 107.7f);
    }

    //Must be public
    public void ChangePos2()
    {
        transform.position = new Vector3(131.7f, 1.4f, 40.9f);
    }

    public void ChangePos3()
    {
        transform.position = new Vector3(76.3f, 0.5f, 87.2f);
    }
}
