using UnityEngine;

public class ClockStingerTrigger : MonoBehaviour
{

    public AK.Wwise.Switch clockStingerCheck;
    public GameObject clockSuspenseTrigger;
    public GameObject outroStinger;
    public GameObject outroMusic;

    void Awake()
    {
        outroStinger.SetActive(false);
        outroMusic.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log(other.name);
            clockStingerCheck.SetValue(clockSuspenseTrigger);
            outroStinger.SetActive(true);
            outroMusic.SetActive(true);
        }
    }
}
