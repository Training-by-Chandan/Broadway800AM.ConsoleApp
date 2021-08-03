using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway800AM.App
{
    public class HandleException
    {
        public static void CodeWithoutHandlingException()
        {
            int[] a = new int[3];
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;
            a[3] = 40;
        }

        public static void CodeWithHandlingException()
        {
            try
            {
                int[] a = new int[3];
                a[0] = 10;
                a[3] = 40;
                a[1] = 20;
                a[2] = 30;
                a[2] = 40;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public static void ThrowSomeException(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new Exception("Value is null, cannot accept it");
            }
            else if (str.ToUpper() == "CHANDAN")
            {
                throw new ChandanException("Value is Chandan, cannot accept it");
            }
            else if (str.ToUpper().Contains("KASTURI"))
            {
                if (str.ToUpper().Contains("TEST"))
                {
                    try
                    {
                        ExceptionOne();
                    }
                    catch (Exception ex)
                    {
                        throw new KasturiException("Value is Kasturi, cannot accept it", ex);
                    }
                }
                throw new KasturiException("Value is Kasturi, cannot accept it");
            }
            else if (str.ToUpper() == "BIKASH")
            {
                throw new BikashException("Value is Bikash, cannot accept it");
            }
            else
            {
                Console.WriteLine("All ok");
            }
        }

        private static void ExceptionOne()
        {
            try
            {
                ExceptionTwo();
            }
            catch (Exception ex)
            {
                throw new Exception("Some random exception from function one", ex);
            }
        }

        private static void ExceptionTwo()
        {
            throw new Exception("Some random exception from function two");
        }
    }

    [Serializable]
    public class ChandanException : Exception
    {
        public ChandanException()
        {
        }

        public ChandanException(string message) : base(message)
        {
        }

        public ChandanException(string message, Exception inner) : base(message, inner)
        {
        }

        protected ChandanException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class KasturiException : Exception
    {
        public KasturiException()
        {
        }

        public KasturiException(string message) : base(message)
        {
        }

        public KasturiException(string message, Exception inner) : base(message, inner)
        {
        }

        protected KasturiException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class BikashException : Exception
    {
        public BikashException()
        {
        }

        public BikashException(string message) : base(message)
        {
        }

        public BikashException(string message, Exception inner) : base(message, inner)
        {
        }

        protected BikashException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}