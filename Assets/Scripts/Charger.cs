using UnityEngine;


public class Charger : MonoBehaviour
{

    private Vector3 _rotationVector;
    private float _rotationSpeed = 10f;
    private const int _maxCharge = 100;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            RechargePlayer();
        }
    }

    private void RechargePlayer()
    {
        FindObjectOfType<Battery>().currentPower = _maxCharge;
        GetComponent<AudioSource>().Play();
    }

    private void Start()
    {
        _rotationVector = new Vector3(0f, _rotationSpeed, 0f);
    }

    private void Update()
    {
        transform.Rotate(_rotationVector * Time.deltaTime);
    }

}
