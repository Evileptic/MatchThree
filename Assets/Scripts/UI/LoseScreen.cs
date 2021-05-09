using UnityEngine.UI;

namespace MatchThree
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