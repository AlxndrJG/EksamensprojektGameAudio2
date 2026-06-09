using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject postionToPlayerFrom;
    
    
    
    public AK.Wwise.Event testSound;
    public AK.Wwise.Event testStop;
    public AK.Wwise.Switch materialSwitchGrass;
    public AK.Wwise.Switch materialSwitchConcrete;
    public AK.Wwise.Switch materialSwitchDirt;
    public AK.Wwise.State musicStateAlive;

    public AK.Wwise.RTPC musicIntensityRTCP;
    
    [Range(0f, 100f)]
    public float intensity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        testSound.Post(postionToPlayerFrom);
        testStop.Post(gameObject);
        materialSwitchConcrete.SetValue(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        // musicIntensityRTCP.SetGlobalValue(intensity);
        musicIntensityRTCP.SetValue(postionToPlayerFrom, intensity);
    }
}
