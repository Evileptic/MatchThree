using UnityEngine.UI;

namespace ZlodeyPack
{
    public class LoseScreen : Screen
    {
        public Button RestartLevelButton;

        private void Start()
        {
            RestartLevelButton.onClick.AddListener(RestartLevel);
        }

        private void RestartLevel()
        {
            
        }
    }
}