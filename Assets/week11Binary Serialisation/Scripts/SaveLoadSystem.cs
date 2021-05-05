using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialisation
{
    public class SaveLoadSystem : MonoBehaviour
    {
        // * Streaming assets is a folder that Unity creates that we can use to
        // * to load/save data in, in the Editor ut us ub tge orihect fikderm
        // *  in a buld, it is in the exe's build folder.
        private string FilePath => Application.streamingAssetsPath + "/gameData";

        [SerializeField] private bool useBinary = false;

        [SerializeField] private GameData gameData = new GameData();



        void Save()
        {
            if (useBinary)
            {
                SaveBinary();
            }
            else
            {
                //JSOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOON
                SaveJson();
            }
        }


        private void SaveBinary()
        {

        }

        private void SaveJson()
        {
            //Json surprise, is easy but less effecient. because Unity has built in JSON
            // * Converts the obhect to a JSON string that we can read/write
            // * to and from a file.
            string json = JsonUtility.ToJson(gameData);

            // *This will write all the contents of the string (param 2) to the -
            // * file at the path (param 1), the standard is to use ".json" as the file
            // * extention for Json files
            File.WriteAllText(FilePath + ".json", json);
            
            // thanks to system.IO you can make it whatever you want. yay
        }


        void Load()
        {
            if (useBinary)
                LoadBinary();
            else
                LoadJson();
        }

        private void LoadBinary()
        {

        }
        private void LoadJson()
        {

        }




        private void OnGUI()
        {
            if (GUILayout.Button("Save"))
            {
                // Do that save jimmy!
            }


            if (GUILayout.Button("Load"))
            {
                // Do that Load jimmy! Sure thing tommy!
            }


            


        }
    }
}
//