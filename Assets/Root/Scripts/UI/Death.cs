using System;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    class Death : MonoBehaviour
    {
        [SerializeField] private Button _resurectButton;

        public void Initiate(Action resurect)
        {
            _resurectButton.onClick.AddListener(()=> {
                resurect();
                GameObject.Destroy(gameObject);
            });
        }
    }
}
