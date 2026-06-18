using UnityEngine;

public class ClockStingerTrigger : MonoBehaviour
{

    public AK.Wwise.Switch clockStingerCheck;
    public AK.Wwise.Event outroMusic;
    public GameObject clockSuspenseTrigger;
    public GameObject outroStinger;
    private bool isTriggered = false;

    void Awake()
    {
        outroStinger.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            clockStingerCheck.SetValue(clockSuspenseTrigger);
            outroStinger.SetActive(true);
            isTriggered = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && isTriggered == true)
        {
            outroMusic.Post(gameObject);
        }
    }

}
