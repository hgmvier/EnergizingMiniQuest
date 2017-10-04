using UnityEngine;


public class Secret : MonoBehaviour
{

    private float _speed = 8f;

    private void Update()
    {
        transform.Rotate(0f, _speed * Time.deltaTime, 0f);
    }

}
