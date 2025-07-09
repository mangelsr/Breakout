using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] Settings settings;

    [SerializeField] int paddleSpeed = 35;


    void Update()
    {
        Vector3 pos = transform.position;

        switch (settings.controlType)
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

        transform.position = pos;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Vector3 direction = collision.contacts[0].point - transform.position;
            direction = direction.normalized;
            collision.rigidbody.velocity = collision.gameObject.GetComponent<Ball>().settings.ballSpeed * direction;
        }
    }

}
