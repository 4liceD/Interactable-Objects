
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class _SettingsToggle : UdonSharpBehaviour
{
    [SerializeField] SettingsManager manager;
    [SerializeField] GameObject settingToToggle;
    [SerializeField] BoxCollider buttonCollider;
    MeshRenderer m_Material;
    [SerializeField] Material MaterialOn;
    [SerializeField] Material MaterialOff;
    public bool DefaultOn;
    private void Start()
    {
        m_Material = GetComponent<MeshRenderer>();
        if (!Networking.LocalPlayer.IsUserInVR())
        {
            buttonCollider.enabled = true;
        }
    }
    public void _Desktopbutton()
    {
        manager.ToggleSetting();
        DefaultOn = !DefaultOn;
        if (DefaultOn)
        {
            settingToToggle.SetActive(true);
            m_Material.material = MaterialOn;
        }
        else{
            settingToToggle.SetActive(false);
            m_Material.material = MaterialOff;
        }
       

    }
    public void _SendMaxEvent()
    {
        manager.ToggleSetting();
        DefaultOn = !DefaultOn;
        if (DefaultOn)
        {
            settingToToggle.SetActive(true);
            m_Material.material = MaterialOn;
        }
        else{
            settingToToggle.SetActive(false);
            m_Material.material = MaterialOff;
        }
    }
}
