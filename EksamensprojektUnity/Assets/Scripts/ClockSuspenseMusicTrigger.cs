using UnityEngine;

public class ClockSuspenseMusicTrigger : MonoBehaviour
{

    public AK.Wwise.Event clockMusicTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            clockMusicTrigger.Post(gameObject);
        }
    }

}
