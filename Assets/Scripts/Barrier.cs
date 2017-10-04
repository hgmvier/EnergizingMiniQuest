using UnityEngine;


public class Barrier : MonoBehaviour
{

    private QuestManager _questManager;

    public PowerCore.Color requiredColor;

    private void Start()
    {
        _questManager = FindObjectOfType<QuestManager>();
    }

    private void CheckRequirement()
    {
        switch (requiredColor)
        {
            case PowerCore.Color.RED:
                if (_questManager.GetRedCoreValue())
                {
                    Destroy(gameObject);
                }
                break;
            case PowerCore.Color.GREEN:
                if (_questManager.GetGreenCoreValue())
                {
                    Destroy(gameObject);
                }
                break;
            case PowerCore.Color.BLUE:
                if (_questManager.GetBlueCoreValue())
                {
                    Destroy(gameObject);
                }
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CheckRequirement();
        }
    }

}
