
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRCAudioLink;
using static VRC.SDKBase.VRCShader;
public class _AudiolinkToggle : UdonSharpBehaviour
{
    [SerializeField] SettingsManager manager;
    [SerializeField] AudioLink udonAudioLink;
    [SerializeField] BoxCollider buttonCollider;
    public Texture2D fakeTexture;
    public RenderTexture audioRenderTexture;

    bool audiolinkToggle = true;
    private void Start()
    {

        if (!Networking.LocalPlayer.IsUserInVR())
        {
            buttonCollider.enabled = true;
        }
    }

    public void _Desktopbutton()
    {
        audiolinkToggle = !audiolinkToggle;
        if (audiolinkToggle)
        {
            SetGlobalTexture(PropertyToID("_AudioTexture"), audioRenderTexture);
        }
        else
        {
            SetGlobalTexture(PropertyToID("_AudioTexture"), fakeTexture);
        }
        manager.ToggleSetting();
    }
    public void _SendMaxEvent()
    {
        audiolinkToggle = !audiolinkToggle;
        if (audiolinkToggle)
        {
            SetGlobalTexture(PropertyToID("_AudioTexture"), audioRenderTexture);
        }
        else
        {
            SetGlobalTexture(PropertyToID("_AudioTexture"), fakeTexture);
        }
        manager.ToggleSetting();
    }
}
