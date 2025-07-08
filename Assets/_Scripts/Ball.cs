using UnityEngine;
using UnityEngine.Events;
using UnityEngine.PlayerLoop;

public class Ball : MonoBehaviour
{
    [SerializeField] public Settings settings;
    bool isGameStarted = false;

    Vector3 lastPosition = Vector3.zero;
    Vector3 direction = Vector3.zero;
    Rigidbody rigidbody;
    BorderControl control;
    public UnityEvent ballDestroyed;

    void Awake()
    {
        control = GetComponent<BorderControl>();
    }

    void Start()
    {
        Transform playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        Vector3 initialPosition = playerTransform.position;
        initialPosition.y += 2;
        transform.position = initialPosition;
        transform.SetParent(playerTransform);
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (control.exitDown)
        {
            ballDestroyed.Invoke();
            Destroy(gameObject);
        }

        if (control.exitUp)
        {
            direction = transform.position - lastPosition;
            Debug.Log("Ball touch the upper border");
            direction.y *= -1;
            direction = direction.normalized;
            rigidbody.velocity = settings.ballSpeed * direction;
            control.exitUp = false;
            control.enabled = false;
            Invoke("EnableControl", 0.1f);
        }

        if (control.exitLeft || control.exitRight)
        {
            direction = transform.position - lastPosition;
            Debug.Log("Ball touch a lateral border");
            direction.x *= -1;
            direction = direction.normalized;
            rigidbody.velocity = settings.ballSpeed * direction;

            if (control.exitLeft)
                control.exitLeft = false;
            else
                control.exitRight = false;

            control.enabled = false;
            Invoke("EnableControl", 0.1f);
        }


        if ((Input.GetKey(KeyCode.Space) || Input.GetButton("Submit")) && !isGameStarted)
        {
            isGameStarted = true;
            transform.SetParent(null);
            GetComponent<Rigidbody>().velocity = settings.ballSpeed * Vector3.up;
        }
    }

    void EnableControl()
    {
        control.enabled = true;
    }

    void FixedUpdate()
    {
        lastPosition = transform.position;
    }

    void LateUpdate()
    {
        if (direction != Vector3.zero)
            direction = Vector3.zero;
    }
}
