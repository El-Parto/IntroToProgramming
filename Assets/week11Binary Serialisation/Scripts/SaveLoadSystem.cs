using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialisation
{
    public class SaveLoadSystem : MonoBehaviour
    {
        // * Streaming assets is a folder that Unity creates that we can use to
        // * to load/save data in, in the Editor it uses ub the orihect fikderm
        // *  in a build, it is in the exe's build folder.
        private string FilePath => Application.streamingAssetsPath + "/gameData";

        [SerializeField] private bool useBinary = false;

        [SerializeField] private GameData gameData = new GameData();

        private void Start()
        {
            if (!Directory.Exists(Application.streamingAssetsPath))
                Directory.CreateDirectory(Application.streamingAssetsPath);
        }

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

            // * This opens the "river" between the RAM and the file.
            // creating te river                         file loc'             river? Important.
            using (FileStream stream = new FileStream(FilePath + ".save", FileMode.OpenOrCreate))
            {
                
                // like creating the boat that will carry the data from one point to another.
                BinaryFormatter formatter = new BinaryFormatter();

                //give memory stream
                //* transports the data from the RAM to the specified file
                // * like freezing water into ice.
                formatter.Serialize(stream, gameData);

            }

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
            //if there is no save data we shouldn't attempt to load it
            if (!File.Exists(FilePath + ".save"))
                return;



            // * This opens the "river" between the RAM and the file.
            // creating te river                         file loc'             river? Important.
            using (FileStream stream = new FileStream(FilePath + ".save", FileMode.Open))
            {

                // like creating the boat that will carry the data from one point to another.
                BinaryFormatter formatter = new BinaryFormatter();

                gameData = formatter.Deserialize(stream) as GameData;

            }
        }
        
        private void LoadJson()
        {
            // this is how we read the string data from a file
            string json = File.ReadAllText(FilePath + ".json");
            // * This is how you convert the json back to a data type.
            // * The Generic is required for making sure the returned data is 
            //* the same as the passed in
            gameData = JsonUtility.FromJson<GameData>(json);
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Save"))
            {
                // Do that save jimmy!
                Save();
            }

            if (GUILayout.Button("Load"))
            {
                // Do that Load jimmy! Sure thing tommy!
                Load();
            }
        }
    }
}
//