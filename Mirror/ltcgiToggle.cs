//Based on pimakers's example script
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class ltcgiToggle : UdonSharpBehaviour
{
    [SerializeField] MirrorManager manager;
    [SerializeField] GameObject MirrorToToggle;
    [SerializeField] BoxCollider buttonCollider;
    public LTCGI_UdonAdapter Adapter;
    public bool StartingState = true;
    private bool state;
    void Start()
    {
        state = StartingState;
        Adapter._SetGlobalState(state);
        if (!Networking.LocalPlayer.IsUserInVR())
        {
            buttonCollider.enabled = true;
        }
    }
    public void _Desktopbutton()
    {
        manager.ToggleMirror(MirrorToToggle);
        state = !state;
        Adapter._SetGlobalState(state);
    }
    public void _SendMaxEvent()
    {
        manager.ToggleMirror(MirrorToToggle);
        state = !state;
        Adapter._SetGlobalState(state);
    }
}
