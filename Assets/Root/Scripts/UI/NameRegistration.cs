using Main;
using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class NameRegistration:MonoBehaviour
    {
        [SerializeField] private Button _enterNameButton;
        [SerializeField] private InputField _nameInput;
        [SerializeField] private SolarSystemNetworkManager _solarNW;

        public void Start()
        {
            _enterNameButton.onClick.AddListener(RigisterName);
            _solarNW.gameObject.SetActive(false);
        }

        private void RigisterName()
        {
            if (!_nameInput.text.Contains(" ")) _solarNW.playerName = _nameInput.text;
            gameObject.SetActive(false);
            _solarNW.gameObject.SetActive(true);
        }
    }
}
