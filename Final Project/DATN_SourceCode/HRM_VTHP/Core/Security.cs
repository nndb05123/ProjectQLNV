using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HRM_VTHP.Core
{
    public class Security
    {
        private static string key = "doank55";

        public static string EncryptMd5(string plainText)
        {
            string encrypted = null;
            try
            {
                byte[] inputBytes = ASCIIEncoding.ASCII.GetBytes(plainText);
                byte[] pwdhash = null;
                MD5CryptoServiceProvider hashmd5;

                //generate an MD5 hash from the password. 
                //a hash is a one way encryption meaning once you generate
                //the hash, you cant derive the password back from it.
                hashmd5 = new MD5CryptoServiceProvider();
                pwdhash = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(key));
                hashmd5 = null;

                // Create a new TripleDES service provider 
                TripleDESCryptoServiceProvider tdesProvider = new TripleDESCryptoServiceProvider();
                tdesProvider.Key = pwdhash;
                tdesProvider.Mode = CipherMode.ECB;

                encrypted = Convert.ToBase64String(
                 tdesProvider.CreateEncryptor().TransformFinalBlock(inputBytes, 0, inputBytes.Length));
            }
            catch
            {
                throw;
            }
            return encrypted;
        }

        public static string DecryptMd5(string DecryptString)
        {
            try
            {
                byte[] keyArray;
                //get the byte code of the string 

                byte[] toEncryptArray = Convert.FromBase64String(DecryptString);

                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();

                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                //set the secret key for the tripleDES algorithm
                tdes.Key = keyArray;
                //mode of operation. there are other 4 modes. 
                //We choose ECB(Electronic code Book)

                tdes.Mode = CipherMode.ECB;
                //padding mode(if any extra byte added)
                tdes.Padding = PaddingMode.PKCS7;

                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(
                                     toEncryptArray, 0, toEncryptArray.Length);
                //Release resources held by TripleDes Encryptor
                tdes.Clear();
                //return the Clear decrypted TEXT
                return UTF8Encoding.UTF8.GetString(resultArray);
            }
            catch
            {
                return "";
            }
        }
    }
}
