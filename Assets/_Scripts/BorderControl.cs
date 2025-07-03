using Unity.VisualScripting;
using UnityEngine;

public class BorderControl : MonoBehaviour
{

    [Header("Editor configs")]
    public float radius = 1f;
    public bool keepOnScreen = false;

    [Header("Dynamic configs")]
    public bool isOnScreen = true;
    public float cameraWidth, cameraHeight;
    public bool exitRight, exitLeft, exitUp, exitDown;


    void Awake()
    {
        cameraHeight = Camera.main.orthographicSize;
        cameraWidth = Camera.main.aspect * cameraHeight;
    }

    void LateUpdate()
    {
        Vector3 pos = transform.position;
        isOnScreen = true;
        exitRight = exitLeft = exitUp = exitDown = false;

        if (pos.x > cameraWidth - radius)
        {
            pos.x = cameraWidth - radius;
            exitRight = true;
        }
        if (pos.x < -cameraWidth + radius)
        {
            pos.x = -cameraWidth + radius;
            exitLeft = true;
        }
        if (pos.y > cameraHeight - radius)
        {
            pos.y = cameraHeight - radius;
            exitUp = true;
        }
        if (pos.y < -cameraHeight + radius)
        {
            pos.y = -cameraHeight + radius;
            exitDown = true;
        }

        isOnScreen = !(exitRight || exitLeft || exitUp || exitDown);

        if (keepOnScreen && !isOnScreen)
        {
            transform.position = pos;
            isOnScreen = true;
        }
    }

    void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;

        Vector3 borderSize = new Vector3(cameraWidth * 2, cameraHeight * 2, 0.1f);
        Gizmos.DrawWireCube(Vector3.zero, borderSize);
    }
}
