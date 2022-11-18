
namespace PedometerU
{

    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;
    using Platforms;


    public class StepCounter : MonoBehaviour
    {
        public TMP_Text stepText, distanceText;
        private Pedometer pedometer;

        private void Start()
        {
            // Create a new pedometer
            pedometer = new Pedometer(OnStep);
            // Reset UI
            OnStep(0, 0);
        }

        private void OnStep(int steps, double distance)
        {
            // Display the values // Distance in feet
            stepText.text = steps.ToString() + " Steps";
            distanceText.text = (distance).ToString("F2") + " M";
        }

        private void OnDisable()
        {
            // Release the pedometer
            pedometer.Dispose();
            pedometer = null;
        }
    }
}
