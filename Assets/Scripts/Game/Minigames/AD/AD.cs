using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Minigames
{
    public class AD : MonoBehaviour
    {
        [SerializeField] private Image rightProgressBar;
        [SerializeField] private Image leftProgressBar;

        public void SetProgressBarFill( float value )
        {
            rightProgressBar.fillAmount = value;
            leftProgressBar.fillAmount = value;
        }
    }
}
