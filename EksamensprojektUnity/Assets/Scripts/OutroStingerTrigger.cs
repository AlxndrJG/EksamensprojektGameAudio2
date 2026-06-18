using UnityEngine;

public class OutroStingerTrigger : MonoBehaviour
{
    public AK.Wwise.Switch outroStingerCheck;
    public GameObject outroMusicTrigger;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log(other.name);
            outroStingerCheck.SetValue(outroMusicTrigger);
        }
    }
}