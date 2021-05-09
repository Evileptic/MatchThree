using UnityEngine.UI;

namespace MatchThree
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