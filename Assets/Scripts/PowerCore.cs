using UnityEngine;


public class PowerCore : MonoBehaviour
{

    public enum Color
    {
        RED,
        GREEN,
        BLUE
    };

    public Color color;

    private float _rotationSpeed = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (color == Color.RED)
            {
                FindObjectOfType<QuestManager>().RedCoreObtained();
                Destroy(gameObject);
            }

            if (color == Color.GREEN)
            {
                FindObjectOfType<QuestManager>().GreenCoreObtained();
                Destroy(gameObject);
            }

            if (color == Color.BLUE)
            {
                FindObjectOfType<QuestManager>().BlueCoreObtained();
                Destroy(gameObject);
            }
        }
    }

    private void Update()
    {
        transform.Rotate(0f, _rotationSpeed, 0f);
    }

}
