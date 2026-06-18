using UnityEngine;

public class IntroMusicSwitch : MonoBehaviour
{

    public AK.Wwise.Switch roomCheck;
    public GameObject introRoomTrigger;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(other.name);
            roomCheck.SetValue(introRoomTrigger);
        }
    }
}
