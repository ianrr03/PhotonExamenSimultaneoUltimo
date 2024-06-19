using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    //[SerializeField] Text myName;
    //[SerializeField] Text theirName;
    //internal static object instance;

    void Start()
    {
        InstatiatePlayers();
        //myName.text = PhotonNetwork.NickName;
    }
    //public void SetTheirName(string nameIn)
    //{
    //    //theirName.text = nameIn;
    //}




    // Update is called once per frame
    void Update()
    {

    }

    private void InstatiatePlayers()
    {

        int playerNumber = PhotonNetwork.LocalPlayer.ActorNumber;
        switch (playerNumber)
        {
            case 1:
                PhotonNetwork.Instantiate("Player1", new Vector3(0, -0.5f, 2f), Quaternion.identity);
                break;
            case 2:
                PhotonNetwork.Instantiate("Player2", new Vector3(0, -0.5f, -2f), Quaternion.identity);
                break;
        }
    }

}
