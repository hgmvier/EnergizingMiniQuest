using UnityEngine;


public class QuestManager : MonoBehaviour
{

    private bool _redCoreObtained = false;
    private bool _greenCoreObtained = false;
    private bool _blueCoreObtained = false;
    private AudioSource _source;

    public AudioClip redCoreObtained;
    public AudioClip greenCoreObtained;
    public AudioClip blueCoreObtained;

    private void Start()
    {
        _source = GetComponent<AudioSource>();
    }

    public void RedCoreObtained()
    {
        _redCoreObtained = true;
        _source.clip = redCoreObtained;
        _source.Play();
    }

    public void GreenCoreObtained()
    {
        _greenCoreObtained = true;
        _source.clip = greenCoreObtained;
        _source.Play();
    }

    public void BlueCoreObtained()
    {
        _blueCoreObtained = true;
        _source.clip = blueCoreObtained;
        _source.Play();
    }

    public bool GetRedCoreValue()
    {
        return _redCoreObtained;
    }

    public bool GetGreenCoreValue()
    {
        return _greenCoreObtained;
    }

    public bool GetBlueCoreValue()
    {
        return _blueCoreObtained;
    }
}
