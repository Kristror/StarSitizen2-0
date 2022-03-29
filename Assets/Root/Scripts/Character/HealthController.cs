using UI;
using UnityEngine;

namespace Characters
{
    class HealthController : MonoBehaviour
    {
        [SerializeField] private Collider _shipCollider;
        [SerializeField] private ShipController _shipController;
        [SerializeField] private GameObject _shipObject;
        [SerializeField] private GameObject _deathScreen;
        private float _spawnDistance;

        public float SpawnDistance
        {
            get => _spawnDistance;
            set => _spawnDistance = value;
        }

        private void Start()
        {
            _shipController.onCollision = Death;
        }       

        public void Death()
        {
            _shipObject.SetActive(false);
            _shipCollider.enabled = false;
            _shipController._active = false;
            var deathScreen = Instantiate(_deathScreen, Vector3.zero, Quaternion.identity);
            deathScreen.GetComponent<Death>().Initiate(Resurrect);
        }

        public void Resurrect()
        {
            _shipObject.SetActive(true);
            _shipCollider.enabled = true;
            _shipController._active = true;
            gameObject.transform.position = Random.insideUnitSphere * _spawnDistance;
        }
    }
}
