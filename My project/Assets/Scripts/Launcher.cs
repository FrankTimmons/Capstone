using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using Photon.Realtime;

public class Launcher : MonoBehaviourPunCallbacks
{
  public static Launcher instance;
  private void Awake()
  {
    instance = this;
  }

  public GameObject loadingScreen;
  public TMP_Text loadingText;

  public GameObject menuButtons;

  public GameObject createRoomScreen;
  public TMP_InputField roomNameInput;
  private List<TMP_Text> allPlayerNames = new List<TMP_Text>();

  public GameObject roomScreen;
  public TMP_Text roomNameText, playerNameLabel;

  public GameObject errorScreen;
  public TMP_Text errorText;

  public GameObject roomBrowserScreen;
  public RoomButton theRoomButton;
  public List<RoomButton> allRoomButtons = new List<RoomButton>();

  // Start is called before the first frame update
  void Start()
  {
    CloseMenus();

    loadingScreen.SetActive(true);
    loadingText.text = "Connecting to Network...";

    PhotonNetwork.ConnectUsingSettings();
  }

  void CloseMenus()
  {
    loadingScreen.SetActive(false);
    menuButtons.SetActive(false);
    createRoomScreen.SetActive(false);
    roomScreen.SetActive(false);
    errorScreen.SetActive(false);
    roomBrowserScreen.SetActive(false);
  }

  public override void OnConnectedToMaster()
  {
    PhotonNetwork.JoinLobby();

    loadingText.text = "Joining Lobby...";
  }

  public override void OnJoinedLobby()
  {
    CloseMenus();
    menuButtons.SetActive(true);
  }

  public void OpenRoomCreate()
  {
    CloseMenus();
    createRoomScreen.SetActive(true);
  }

  public void CreateRoom()
  {
    if (!string.IsNullOrEmpty(roomNameInput.text))
    {
      RoomOptions options = new RoomOptions();
      options.MaxPlayers = 8;

      PhotonNetwork.CreateRoom(roomNameInput.text, options);

      CloseMenus();
      loadingText.text = "Creating Room...";
      loadingScreen.SetActive(true);
    }
  }

  public override void OnJoinedRoom()
  {
    CloseMenus();

    roomScreen.SetActive(true);
    roomNameText.text = PhotonNetwork.CurrentRoom.Name;

    PhotonNetwork.NickName = Random.Range(0, 1000).ToString();

    ListAllPlayers();
  }

  private void ListAllPlayers()
  {
    foreach(TMP_Text player in allPlayerNames)
    {
      Destroy(player.gameObject);
    }
    allPlayerNames.Clear();

    Player[] players = PhotonNetwork.PlayerList;

    for(int i = 0; i < players.Length; i++)
    {
      TMP_Text newPlayerLabel = Instantiate(playerNameLabel, playerNameLabel.transform.parent);
      newPlayerLabel.text = players[i].NickName;
      newPlayerLabel.gameObject.SetActive(true);

      allPlayerNames.Add(newPlayerLabel);
    }
  }

  public override void OnCreateRoomFailed(short returnCode, string message)
  {
    errorText.text = "Failed to Create Room: " + message;
    CloseMenus();
    errorScreen.SetActive(true);
  }

  public void CloseErrorScreen()
  {
    CloseMenus();
    menuButtons.SetActive(true);
  }

  public void LeaveRoom()
  {
    PhotonNetwork.LeaveRoom();
    CloseMenus();
    loadingText.text = "Leaving Room";
    loadingScreen.SetActive(true);
  }

  public override void OnLeftRoom()
  {
    CloseMenus();
    menuButtons.SetActive(true);
  }

  public void OpenRoomBrowser()
  {
    CloseMenus();
    roomBrowserScreen.SetActive(true);
  }

  public void CloseRoomBrowser()
  {
    CloseMenus();
    menuButtons.SetActive(true);
  }

  public override void OnRoomListUpdate(List<RoomInfo> roomList)
  {
    foreach(RoomButton rb in allRoomButtons)
    {
      Destroy(rb.gameObject);
    }

    allRoomButtons.Clear();

    theRoomButton.gameObject.SetActive(false);

    for(int i = 0; i < roomList.Count; i++)
    {
      if(roomList[i].PlayerCount != roomList[i].MaxPlayers && !roomList[i].RemovedFromList)
      {
        RoomButton newButton = Instantiate(theRoomButton, theRoomButton.transform.parent);
        newButton.SetButtonDetails(roomList[i]);
        newButton.gameObject.SetActive(true);

        allRoomButtons.Add(newButton);
      }
    }
  }

  public void JoinRoom(RoomInfo inputInfo)
  {
    PhotonNetwork.JoinRoom(inputInfo.Name);

    CloseMenus();
    loadingText.text = "Joining Room";
    loadingScreen.SetActive(true);
  }

  public void QuitGame()
  {
    Application.Quit();
  }
}
