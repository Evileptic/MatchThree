using UnityEngine.UI;

namespace ZlodeyPack
{
    public class WinScreen : Screen
    {
        public Button NextLevelButton;

        private void Start()
        {
            NextLevelButton.onClick.AddListener(LoadNextLevel);
        }

        private void LoadNextLevel()
        {
            
        }
    }
}