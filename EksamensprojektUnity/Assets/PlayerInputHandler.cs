using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public AkRoomPortal tunnelPortal1;
    public AkRoomPortal tunnelPortal2;

    public bool isOpen = true;


    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            isOpen = !isOpen;
            if (isOpen)
            {
                tunnelPortal1.Open();
                tunnelPortal2.Open();
            }
            else 
            {
                tunnelPortal1.Close();
                tunnelPortal2.Close();
            }
        }
    }
}
