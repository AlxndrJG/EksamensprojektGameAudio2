using UnityEngine;
using UnityEngine.InputSystem;

public class TriggerEmissionAndLid : MonoBehaviour
{ 
    public GameObject tvGameObject;
    public GameObject clockGameObject;
    public GameObject spotLight;

    [Header ("Materials")]
    public Material emissionMaterialBlue;

    [Header ("Sound")]
    //public AK.Wwise.Event clockOn;
    public AK.Wwise.Event tvOff;

    [Header ("Gameobjects")]
    public GameObject clockSuspenseTrigger;
    public GameObject clockStingerTrigger;

    //private bool _hasRun = false;

    void Start()
    {
        emissionMaterialBlue.EnableKeyword("_EMISSION");
        clockSuspenseTrigger.SetActive(false);
        clockStingerTrigger.SetActive(false);
    }

    void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player") && Keyboard.current.eKey.isPressed)
        {
            Debug.Log("Triggered");
            emissionMaterialBlue.DisableKeyword("_EMISSION");
            spotLight.SetActive(false);
            tvOff.Post(tvGameObject);
            clockSuspenseTrigger.SetActive(true);
            clockStingerTrigger.SetActive(true);
            //clockOn.Post(clockGameObject);
            //_hasRun = true;

        }
    }
}
