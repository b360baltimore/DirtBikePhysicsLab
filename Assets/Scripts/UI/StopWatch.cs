using UnityEngine;
using TMPro;

namespace B360
{
    public class StopWatch : MonoBehaviour
    {
        private bool _running = false;
        private float _elapsedTime = 0f;
        public TMPro.TMP_Text _elapsedText;


        // Start is called before the first frame update
        void Start()
        {
            ResetTime();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (_running)
            {
                _elapsedTime += Time.deltaTime;
                _elapsedText.text = System.Math.Round(_elapsedTime, 1).ToString("0.0") + " s";
            }
        }

        public void StartTime()
        {
            _running = true;
        }

        public void PauseTime()
        {
            _running = false;
        }

        public void ResetTime()
        {
            _running = false;
            _elapsedTime = 0;
            _elapsedText.text = System.Math.Round(_elapsedTime, 1).ToString("0.0") + " s";
        }


    }
}
