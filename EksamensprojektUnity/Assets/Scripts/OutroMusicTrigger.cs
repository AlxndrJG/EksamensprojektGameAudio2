using UnityEngine;

public class OutroMusicTrigger : MonoBehaviour
{

    public AK.Wwise.Event outrokMusicTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            outrokMusicTrigger.Post(gameObject);
        }
    }

}
