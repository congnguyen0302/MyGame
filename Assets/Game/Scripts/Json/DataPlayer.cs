using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Game.Scripts.Json
{
    [Serializable]
    public class DataPlayer 
    {
        
        public int hpCurrent;
        public int damage;
        public int lv;
        public int expMax;
        public int expCurrent;
        public int coin;
        public TextMeshProUGUI textExp;
        public TextMeshProUGUI textHp;
        public List<Mission> missions;
    }
    [Serializable]
    public class Mission
    {
        public string mission;
        public int amount;
    }
}
