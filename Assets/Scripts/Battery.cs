using UnityEngine;
using System.Collections;

public class Battery : MonoBehaviour
{

    public float currentPower;

    private const float _maxPower = 100f;
    private float _decreaseDelay = 30f;
    private int _decreaseValue = 5;

    private void Start()
    {
        currentPower = _maxPower;
        StartCoroutine(DecreasePower(_decreaseDelay));
    }

    IEnumerator DecreasePower(float delay)
    {
        while (true)
        {
            currentPower -= _decreaseValue;
            yield return new WaitForSeconds(delay);
        }
    }

    public float GetMaxPower()
    {
        return _maxPower;
    }

    private void Update()
    {
        if (currentPower <= 0)
        {
            currentPower = 0f;
            FindObjectOfType<LevelLoader>().LoadLevel("Lose");
        }
    }
}
