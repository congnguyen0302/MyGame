
using System;
using TMPro;
using UnityEngine;

namespace Game.Scripts.Mission
{
    public class Mission : MonoBehaviour
    {
        [SerializeField] public TextMeshProUGUI textMeshPro;
        public string missionName;
        public int amount;
        public int currentAmountDone;
        public bool isDone;

        protected virtual void Awake()
        {
            textMeshPro.text = missionName + " : " + currentAmountDone + "/" + amount;
            //todo something
        }
        public virtual void DoneAPart()
        {
            if (isDone) return;
            currentAmountDone++;
            textMeshPro.text = missionName + " : " + currentAmountDone + "/" + amount;
        }
        
    }
}

  
