using UnityEngine;

enum ControlType
{
    Keyboard,
    Mouse,
    Controller,
}

public class Player : MonoBehaviour
{

    [SerializeField] int screenLimitX = 23;
    [SerializeField] int paddleSpeed = 35;
    [SerializeField] ControlType controlType = ControlType.Mouse;


    void Update()
    {
        Vector3 pos = transform.position;

        switch (controlType)
        {
            case ControlType.Controller:
            case ControlType.Keyboard:
                transform.Translate(Input.GetAxis("Horizontal") * Vector3.down * paddleSpeed * Time.deltaTime);
                pos = transform.position;
                break;
            case ControlType.Mouse:
                Vector3 mousePositionScreen = Input.mousePosition;
                mousePositionScreen.z = -Camera.main.transform.position.z;

                Vector3 mousePositionWorld = Camera.main.ScreenToWorldPoint(mousePositionScreen);

                pos.x = mousePositionWorld.x;
                break;
        }

        if (pos.x < -screenLimitX)
            pos.x = -screenLimitX;

        else if (pos.x > screenLimitX)
            pos.x = screenLimitX;

        transform.position = pos;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Vector3 direction = collision.contacts[0].point - transform.position;
            direction = direction.normalized;
            collision.rigidbody.velocity = collision.gameObject.GetComponent<Ball>().speed * direction;
        }
    }

}
