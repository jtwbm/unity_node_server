using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;

namespace Project.Networking
{
  public class NetworkClient : WsClient
  {
    WebSocket ws;

    public override void Start() {
      base.Start();
      // SetupEvents();
    }

    public override void Update() {
      base.Update();
    }

    // void SetupEvents() {
    //   // On("open", (E) => {
    //   //   Debug.Log("Connection maid to the server");
    //   // });
    // }
  }
}
