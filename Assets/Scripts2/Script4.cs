using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.CJ.DoxygenTest
{
    public class Script4 : Script3
    {
        /// <summary>
        /// A transform assignment.
        /// </summary>
        [SerializeField] private Transform myTransform;

        /// <summary>
        /// A collider assignment.
        /// </summary>
        [SerializeField] private Collider myCollider;
            
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        /// <summary>
        /// A public function.
        /// </summary>
        /// <param name="int1">An int parameter.</param>
        /// <returns>Returns an int.</returns>
        public int MyPublicFunction(int int1)
        {
            return 0;
        }
    }
}

