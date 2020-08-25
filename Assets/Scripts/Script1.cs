using UnityEngine;

namespace com.CJ.DoxygenTest
{
    /// <summary>
    /// Script1 description.
    /// </summary>
    public class Script1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        /// <summary>
        /// Description for my MyPublicFunction.
        /// </summary>
        public virtual void MyPublicFunction()
        {
        
        }

        /// <summary>
        /// Description for my MyPublicFunction2.
        /// </summary>
        /// <param name="param1">Parameter 1</param>
        /// <param name="param2">Parameter 2</param>
        /// <returns>Returns an int result.</returns>
        public virtual int MyPublicFunction2(int param1, int param2)
        {
            return 0;
        }

        /// <summary>
        /// My private function.
        /// </summary>
        private void MyPrivatefunction()
        {
        
        }
        
        /// <summary>
        /// A new function.
        /// </summary>
        /// <returns>Returns an int.</returns>
        public int ANewFunction()
        {
            return 0;
        }
        
        /// <summary>
        /// A newer function.
        /// </summary>
        /// <returns>Returns an int.</returns>
        public int ANewerFunction()
        {
            return 0;
        }
        
        /// <summary>
        /// An even newer function.
        /// </summary>
        /// <returns>Returns an int.</returns>
        public int AnEvenNewerFunction()
        {
            return 0;
        }

        /// <summary>
        /// Description for my MyProtectedFunction2.
        /// </summary>
        /// <returns>Returns an int result.</returns>
        protected virtual int MyProtectedFunction2()
        {
            return 0;
        }
    }
}

