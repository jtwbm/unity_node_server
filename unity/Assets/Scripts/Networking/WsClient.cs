using UnityEngine;
using WebSocketSharp;

public class WsClient : MonoBehaviour
{
    [Header("WebSocket Component")]
    public string url = "ws://localhost:8080";

    // useless yet
    public bool autoConnect;
    public int reconnectDelay = 5;
    public int expirationTime = 1800;
    public int pingInterval = 25;
    public int pingTimeout = 60;
    
    WebSocket ws;
    public virtual void Start()
    {
        ws = new WebSocket(url);
        ws.Connect();

        ws.OnMessage += (sender, e) =>
        {
            Debug.Log("Message Received from "+((WebSocket)sender).Url+", Data : "+e.Data);
        };

        ws.OnClose += (sender, e) => {
          Debug.Log($"WebSocker is disconnected from {((WebSocket)sender).Url}, {e.Code}");
        };
    }
    public virtual void Update()
    {
      if (ws == null) {
        return;
      }

      if (Input.GetKeyDown(KeyCode.Space))
      {
          ws.Send("1");
      }  
    }
}
