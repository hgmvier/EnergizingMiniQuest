using UnityEngine;


public class DestroWall : MonoBehaviour
{

    public float speed = 5f;

    private float _damageValue = 25f;

    //Variables to hold desired location
    public float positionX;
    public float positionY;
    public float positionZ;

    private Vector3 _startPosition;
    private Vector3 _endPosition;

    private bool _reachedEnd = false;

    private void Start()
    {
        _startPosition = transform.position;
        _endPosition = new Vector3(positionX, positionY, positionZ);
    }

    private void InterpolatePosition()
    {
        if (!_reachedEnd)
        {
            transform.position = Vector3.MoveTowards(transform.position, _endPosition, speed * Time.deltaTime);

            if (transform.position == _endPosition)
            {
                _reachedEnd = true;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _startPosition, speed * Time.deltaTime);

            if (transform.position == _startPosition)
            {
                _reachedEnd = false;
            }
        }

    }

    private void Update()
    {
        InterpolatePosition();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Battery>().currentPower -= _damageValue;
            GetComponent<AudioSource>().Play();
        }
    }

}
