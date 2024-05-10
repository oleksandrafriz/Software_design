using System;

namespace ClassLibrary3
{
    public sealed class Authenticator
    {
        private static volatile Authenticator instance;
        private static object syncRoot = new object();


        public static Authenticator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Authenticator();
                        }
                    }
                }
                return instance;
            }
        }

        public void Authenticate()
        {
            Console.WriteLine("Authenticated successfully!");
        }
    }

   
}
