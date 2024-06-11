using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class PlayerListItem : MonoBehaviourPunCallbacks {
  [SerializeField] TMP_Text text;
  Photon.Realtime.Player player; ///ojo con Photon.Realtime.Player
  public void SetUp(Photon.Realtime.Player _player) { //idem
    player = _player;
    text.text = _player.NickName;
  }

  public override void OnPlayerLeftRoom(Photon.Realtime.Player otherPlayer) //idem
  {
    if (player == otherPlayer) 
    {
      Destroy(gameObject);
    }
  }

  public override void OnLeftRoom() 
  {
    Destroy(gameObject);
  }
}
