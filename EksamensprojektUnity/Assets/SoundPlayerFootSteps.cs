using UnityEngine;

public class SoundPlayerFootsteps : MonoBehaviour
{
    [Header("Wwise Events")]
    public AK.Wwise.Event Play_FSForward;
    public AK.Wwise.Event Play_FSBack;
    public AK.Wwise.Event Play_FSSide;

    [Header("Foot Objects")]
    public GameObject leftFoot;
    public GameObject rightFoot;

    [Header("Material")]
    public string currentMaterial = "Wood";

    [Header("Animator")]
    public Animator animator;
    public string verticalParameter = "moveAmountVertical";
    public string horizontalParameter = "moveAmountHorizontal";

    [Header("Double Trigger Protection")]
    public float minTimeBetweenFootsteps = 0.05f;
    private float lastFootstepTime;

    private bool CanPlayFootstep()
    {
        if (Time.time - lastFootstepTime < minTimeBetweenFootsteps)
            return false;

        lastFootstepTime = Time.time;
        return true;
    }

    private AK.Wwise.Event GetDominantFootstepEvent()
    {
        float vertical = animator.GetFloat(verticalParameter);
        float horizontal = animator.GetFloat(horizontalParameter);

        if (Mathf.Abs(horizontal) > Mathf.Abs(vertical))
        {
            return Play_FSSide;
        }

        if (vertical < 0f)
        {
            return Play_FSBack;
        }

        return Play_FSForward;
    }

    private void PlayFootstep(GameObject footObject)
    {
        if (!CanPlayFootstep()) return;
        if (footObject == null) return;

        AK.Wwise.Event footstepEvent = GetDominantFootstepEvent();

        if (footstepEvent == null) return;

        AkSoundEngine.SetSwitch("Materials", currentMaterial, footObject);

        uint playingId = footstepEvent.Post(footObject);

        Debug.Log($"Footstep posted on {footObject.name} | Material: {currentMaterial} | PlayingID: {playingId}");
    }

    public void SetFootstepMaterial(string newMaterial)
    {
        currentMaterial = newMaterial;
    }

    public void FSLeft()
    {
        PlayFootstep(leftFoot);
    }

    public void FSRight()
    {
        PlayFootstep(rightFoot);
    }
}