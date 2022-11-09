using System;
using Game.Scripts.NPC;
using Tool;
using UnityEngine;

namespace Game.Scripts.Mission
{
    public class KillFireDragon : Mission
    {
        public static KillFireDragon Instance;
        public Enemy.Enemy.EnemyType monsterType;

        protected override void Awake()
        {
            base.Awake();
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
            this.RegisterListener(EventID.EnemyDie, (monsterSender, param) =>
            {
                var enemy = monsterSender as Enemy.Enemy;
                if (enemy != null && enemy.enemyType == monsterType)
                {
                    DoneAPart();
                }
            });
           
        }

        private void Update()
        {
            if (amount == currentAmountDone)
            {
                textMeshPro.text = "Đã Hoàn Thành Nv";
                NpcMap1.Instance.textTalk.text = "Tốt Lắm Tiếp tục hành trình đi";
                Destroy(gameObject,5);
                return;
            }
            else
            {
                DontDestroyOnLoad(gameObject);
            }
        }
        
    }
}
