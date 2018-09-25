using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;

namespace Pinguinos
{
    public class DataController : MonoBehaviour
    {
        private SaveData playerProgress;

        private string gameDataFileName = "data.json";

        void Start()
        {
            DontDestroyOnLoad(gameObject);

            LoadGameData();

            LoadPlayerProgress();

            //TODO: CAMBIAR NOMBRE DE ESCENA A LA ESCENA DEL MENÚ.
            SceneManager.LoadScene("");
        }

        public void SubmitNewPlayerScore(int newScore)
        {
            // If newScore is greater than playerProgress.highestScore, update playerProgress with the new value and call SavePlayerProgress()
            if (newScore > playerProgress.highestScore)
            {
                playerProgress.highestScore = newScore;
                SavePlayerProgress();
            }
        }

        public int GetHighestPlayerScore()
        {
            return playerProgress.highestScore;
        }

        private void LoadGameData()
        {
            // Path.Combine combines strings into a file path
            // Application.StreamingAssets points to Assets/StreamingAssets in the Editor, and the StreamingAssets folder in a build
            string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);

            if (File.Exists(filePath))
            {
                // Read the json from the file into a string
                string dataAsJson = File.ReadAllText(filePath);
                // Pass the json to JsonUtility, and tell it to create a GameData object from it
                Pinguinos.SaveData loadedData = JsonUtility.FromJson<Pinguinos.SaveData>(dataAsJson);
            }
            else
            {
                //Si el archivo no existe, no los carga.
                Debug.LogError("No se pueden cargar los datos");
            }
        }

        // This function could be extended easily to handle any additional data we wanted to store in our PlayerProgress object
        private void LoadPlayerProgress()
        {
            // Create a new PlayerProgress object
            playerProgress = new Pinguinos.SaveData();

            // If PlayerPrefs contains a key called "highestScore", set the value of playerProgress.highestScore using the value associated with that key
            if (PlayerPrefs.HasKey("highestScore"))
            {
                playerProgress.highestScore = PlayerPrefs.GetInt("highestScore");
            }

            if (PlayerPrefs.HasKey("timesWon"))
            {
                playerProgress.timesWon = PlayerPrefs.GetInt("timesWon");
            }

            if (PlayerPrefs.HasKey("timesLost"))
            {
                playerProgress.timesLost = PlayerPrefs.GetInt("timesLost");
            }

            if (PlayerPrefs.HasKey("extraCharA"))
            {
                playerProgress.extraCharA = PlayerPrefs.GetInt("extraCharA");
            }

            if (PlayerPrefs.HasKey("extraCharB"))
            {
                playerProgress.extraCharB = PlayerPrefs.GetInt("extraCharB");
            }
        }

        // This function could be extended easily to handle any additional data we wanted to store in our PlayerProgress object
        private void SavePlayerProgress()
        {
            // Save the value playerProgress.highestScore to PlayerPrefs, with a key of "highestScore"
            PlayerPrefs.SetInt("highestScore", playerProgress.highestScore);
            PlayerPrefs.SetInt("timesWon", playerProgress.timesWon);
            PlayerPrefs.SetInt("timesLost", playerProgress.timesLost);
            PlayerPrefs.SetInt("timesWon", playerProgress.timesWon);
            PlayerPrefs.SetInt("extraCharA", playerProgress.extraCharA);
            PlayerPrefs.SetInt("extraCharB", playerProgress.extraCharB);
        }
    }
}
