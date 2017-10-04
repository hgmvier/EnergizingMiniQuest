using UnityEngine;
using System.Collections;


public class GeneratorStation : MonoBehaviour
{

    public float currentPowerLevel;

    private const float _maxPowerLevel = 100f;
    private float _decreaseDelay = 2f;
    private int _decreaseValue = 1;

    private void Start()
    {
        currentPowerLevel = _maxPowerLevel;
        StartCoroutine(DecreasePowerLevel(_decreaseDelay));
    }

    private void Update()
    {
        if (currentPowerLevel <= 0)
        {
            currentPowerLevel = 0f;
            FindObjectOfType<LevelLoader>().LoadLevel("Lose");
        }
    }

    IEnumerator DecreasePowerLevel(float delay)
    {
        while (true)
        {
            currentPowerLevel -= _decreaseValue;
            yield return new WaitForSeconds(delay);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            currentPowerLevel = _maxPowerLevel;
            FindObjectOfType<LevelLoader>().LoadLevel("Win");
        }
    }

    //Getter and setters

    public float GetMaxPowerLevel()
    {
        return _maxPowerLevel;
    }
}
