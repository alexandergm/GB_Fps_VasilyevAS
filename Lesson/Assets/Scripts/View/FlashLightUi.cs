using UnityEngine;
using UnityEngine.UI;

namespace Geekbrains
{
    public sealed class FlashLightUi : MonoBehaviour
    {
        public Slider _slider;
        // image

        private void Awake()
        {
            _slider = GetComponent<Slider>();
        }

       
        public void SetActive(bool value)
        {
            _slider.gameObject.SetActive(value);
        }
    }
}
