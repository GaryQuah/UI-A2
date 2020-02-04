using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiplayerTab : MonoBehaviour
{
    [SerializeField] Button InviteBtn;
    [SerializeField] GameObject LobbyTab;
    [SerializeField] GameObject InvitationTab;
    [SerializeField] Button InvitationTabBackBtn;

    void Start()
    {
        InviteBtn.onClick.AddListener(InviteButtonEvent);
        InvitationTabBackBtn.onClick.AddListener(InvitationTabBackButtonEvent);

        InvitationTab.SetActive(false);
    }

    void Update()
    {
        
    }

    public void InviteButtonEvent()
    {
        InvitationTab.SetActive(true);
        LobbyTab.SetActive(false);
    }

    public void InvitationTabBackButtonEvent()
    {
        LobbyTab.SetActive(true);
        InvitationTab.SetActive(false);
    }
}
