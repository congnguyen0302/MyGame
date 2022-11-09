using System;
using System.Collections;
using TMPro;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Game.Scripts.NPC 
{
    public class NpcMap1 : MonoBehaviour
    {
        public static NpcMap1 Instance;
        public GameObject obj;
        public GameObject mission;
        public GameObject buttonTakingMission;
        public GameObject buttonQuitTheMission;
        public GameObject missionFireDragon;
        public float showingButton = 1f;
        public float showingMission = 2f;
        public Coroutine Coroutine;
        public TextMeshProUGUI textTalk;
        
        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            LoadData();
        }

        private void OnDestroy()
        {
            SaveData();
        }

        public void OnTriggerEnter2D(Collider2D col)
        {
            if (col.CompareTag("Player"))
            {
                obj.SetActive(true);

                    if (Coroutine == null)
                    {
                        Coroutine = StartCoroutine(ShowButton());
                    }
                    else
                    {
                        StopCoroutine(Coroutine);
                        Coroutine = StartCoroutine(ShowButton());
                    }
            }
            
        }

        public void TextMission()
        {
            mission.SetActive(true);
            if (Coroutine == null)
            {
                Coroutine = StartCoroutine(ShowMission());
            }
            else
            {
                StopCoroutine(Coroutine);
                Coroutine = StartCoroutine(ShowMission());
            }
            obj.SetActive(false);
            if ( buttonTakingMission!=null)
            {buttonTakingMission.SetActive(true);}
            if ( buttonTakingMission!=null)
            {buttonQuitTheMission.SetActive(true);}
            
        }
        private IEnumerator ShowButton()
        {
            yield return new WaitForSeconds(showingButton);
            obj.SetActive(false);
            Coroutine= null;
        }
    
        private IEnumerator ShowMission()
        {
            yield return new WaitForSeconds(showingMission);
            mission.SetActive(false);
            Coroutine= null;
        }

        public void GetMission()
        {
            
           Destroy(buttonTakingMission);
           Destroy(buttonQuitTheMission);
           GameObject objGameObject = Object.Instantiate(missionFireDragon);
        }

        public void QuitMission()
        {
            buttonTakingMission.SetActive(false);
            buttonQuitTheMission.SetActive(false);
        }

        public void SaveData()
        {
            //PlayerPrefs.SetString("textTalk",textTalk.text);
        }

        public void LoadData()
        {
           // string talk = PlayerPrefs.GetString("textTalk", textTalk.text);
           // textTalk.text = talk;
        }
    }
    
}
