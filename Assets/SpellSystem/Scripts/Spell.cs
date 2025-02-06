//This script should be added to a prefab for each spell you want to create
//There is 1 error in this script

namespace AbilitySystem.Spells
{
    using UnityEngine;

    public class Spell : MonoBehaviour
    {
        public float coolDownTime = 2f;

        virtual public bool Cast(){
            return false;
        }
    }
}