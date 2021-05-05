using UnityEngine;

namespace Serialisation
{

    [System.Serializable]
    public class GameData
    {
        //so this is how you get around vector 3
        // * Vector3's can't be serilized by s# so we made a float array
        // * and a property instead.
        public Vector3 Position => new Vector3(position[0], position[1], position[2]);


        public Character knight;
        public Character wizard;
        public Character rogue;

        //what we'll use to store position
        public float[] position = new float[3];

        // vector3 it will cause an issue because
        // vector3 are not serialisable types in unity.


        // another constructor, but it's empty?
        public GameData()
        {
            knight = new Character("Knight", 18, 10, 15, 7, 17, 10, 1);
            wizard = new Character("Knight", 10, 18, 12, 17, 10, 12, 1);
            rogue = new Character("Knight", 12, 16, 15, 12, 10, 18, 1);


            // * sets everything to each other in the oder right to left.
            position[0] = position[1] = position[2] = 0;
        }

    }
}