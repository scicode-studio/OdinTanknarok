using UnityEngine;

namespace ODIN
{
    public class OdinConnectionTest : MonoBehaviour
    {
        [SerializeField] private string roomName;
        void Start()
        {
            OdinHandler.Instance.JoinRoom(roomName);    
        }
    }
}