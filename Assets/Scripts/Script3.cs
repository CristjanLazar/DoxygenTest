using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.CJ.DoxygenTest
{
    /// <summary>
    /// Description for Script3. 
    /// </summary>
    public class Script3 : MonoBehaviour
    {
        /// <summary>
        /// Description for field myClass.
        /// </summary>
        public MyClass2 myClass;

        /// <summary>
        /// Description for function MyFunc.
        /// </summary>
        public void MyFunc()
        {
            
        }
        
        /// <summary>
        /// Description for MyClass.
        /// </summary>
        public class MyClass
        {
            /// <summary>
            /// Description for field int1.
            /// </summary>
            public int int1;
        
            /// <summary>
            /// Description for filed int2.
            /// </summary>
            public int int2;

            /// <summary>
            /// Description for MyFunc.
            /// </summary>
            public void MyFunc()
            {
            
            }

            private void MyPrivateFunc()
            {
            
            }
        }

        /// <summary>
        /// Description for MyClass2.
        /// </summary>
        public class MyClass2 : MyClass
        {
            private void MyPrivateFunc()
            {
            
            }
        }
    }
}

