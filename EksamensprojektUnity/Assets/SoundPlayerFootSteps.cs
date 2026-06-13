using UnityEngine;

public class SoundPlayerFootsteps : MonoBehaviour
{
    public AK.Wwise.Event Play_FSForward;
    public AK.Wwise.Event Play_FSBack;
    public AK.Wwise.Event Play_FSSide;

    private void Start()
    {
        AkSoundEngine.SetSwitch("Materials", "Wood", gameObject);
        uint id = Play_FSForward.Post(gameObject);
        Debug.Log("Playing ID: " + id);
        Debug.Log("Footstep script started on: " + gameObject.name);
        Debug.Log("Forward event is null: " + (Play_FSForward == null));
    }

    public void FSLeftForward()
    {
        Debug.Log("FSLeftForward");
        uint id = Play_FSForward.Post(gameObject);
        Debug.Log("Play_FSForward PlayingID: " + id);
    }

    public void FSRightForward()
    {
        Debug.Log("FSRightForward");
        uint id = Play_FSForward.Post(gameObject);
        Debug.Log("Play_FSForward PlayingID: " + id);
    }

    public void FSLeftBack()
    {
        Debug.Log("FSLeftBack");
        uint id = Play_FSBack.Post(gameObject);
        Debug.Log("Play_FSBack PlayingID: " + id);
    }

    public void FSRightBack()
    {
        Debug.Log("FSRightBack");
        uint id = Play_FSBack.Post(gameObject);
        Debug.Log("Play_FSBack PlayingID: " + id);
    }

    public void FSLeftSide()
    {
        Debug.Log("FSLeftSide");
        uint id = Play_FSSide.Post(gameObject);
        Debug.Log("Play_FSSide PlayingID: " + id);
    }

    public void FSRightSide()
    {
        Debug.Log("FSRightSide");
        uint id = Play_FSSide.Post(gameObject);
        Debug.Log("Play_FSSide PlayingID: " + id);
    }
}