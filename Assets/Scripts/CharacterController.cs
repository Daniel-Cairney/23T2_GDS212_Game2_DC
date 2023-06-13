using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DanielCairney
{



    public class CharacterController : MonoBehaviour
    {
        private Vector2 targetPos;
        public float speed = 5;

        private void Update()
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (Input.GetMouseButtonDown(0))
            {
                targetPos = new Vector2(mousePos.x, mousePos.y);
            }

            transform.position = Vector2.MoveTowards(transform.position, targetPos, Time.deltaTime * speed);

            //transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPos);
        }


    }

}