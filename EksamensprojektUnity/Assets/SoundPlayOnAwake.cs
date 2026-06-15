using UnityEngine;

public class SoundPlayOnAwake : MonoBehaviour
{
    public GameObject TV;
    public GameObject Clock;

    public AK.Wwise.Event Play_TV_Static;
    public AK.Wwise.Event Play_Clock_Tick;

    private void Start()
    {
        Play_TV_Static.Post(TV);
        Play_Clock_Tick.Post(Clock);
    }
}
