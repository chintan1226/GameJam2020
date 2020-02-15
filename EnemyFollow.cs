using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyFollow : MonoBehaviour
    {
        public float speed;
        public float follow;

        private Transform target;
        
        void Start()
        {
            target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }
        void Update()
        {
            while (Vector2.Distance(transform.position, target.position) < follow)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
        }
    }   
}
