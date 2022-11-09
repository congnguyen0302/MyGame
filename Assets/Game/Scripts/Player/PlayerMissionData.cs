using System.Collections.Generic;
using UnityEngine;

namespace Game.Scripts.Player
{
    public class PlayerMissionData 
    {
        public List<string> DoneMissions;
        public List<string> DoingMissions;

        private PlayerMissionData()
        {
            DoneMissions = new List<string>();
            DoingMissions = new List<string>();
            LoadData();
        }

        public void LoadData()
        {
            int i = 0;
            if (DoneMissions != null)
            {
                while (true)
                {
                    string mission = PlayerPrefs.GetString(DONE_MISSIONS_PASS + i, "");
                    if (mission == "")
                    {
                        break;
                    }
                    i++;
                }
                
            }
        }

        public void SaveData()
        {
            if (DoneMissions != null)
            {
                for (int i = 0; i < DoneMissions.Count; i++)
                {
                    PlayerPrefs.SetString(DONE_MISSIONS_PASS+i,DoneMissions[i]);
                }
            }
        }

        private const string DONE_MISSIONS_PASS = "DoneMissions_";
    }
}
