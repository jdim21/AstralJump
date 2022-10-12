using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Platformer.UI
{
    /// <summary>
    /// A simple controller for switching between UI panels.
    /// </summary>
    public class MainUIController : MonoBehaviour
    {
        public GameObject[] panels;

        bool showMainCanvas = false;

        public void ToggleMainMenu(bool show)
        {
            if (show)
            {
                Time.timeScale = 0;
                this.gameObject.SetActive(true);
                foreach (var i in panels) i.SetActive(false);
            }
            else
            {
                Time.timeScale = 1;
                this.gameObject.SetActive(false);
                foreach (var i in panels) i.SetActive(true);
            }
            this.showMainCanvas = show;
        }

        public void SetActivePanel(int index)
        {
            for (var i = 0; i < panels.Length; i++)
            {
                var active = i == index;
                var g = panels[i];
                if (g.activeSelf != active) g.SetActive(active);
            }
        }

        void OnEnable()
        {
            SetActivePanel(0);
            EventSystem.current.SetSelectedGameObject(null);
        }

        public void RestartLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void QuitToMainMenu()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(0);
        }
    }
}