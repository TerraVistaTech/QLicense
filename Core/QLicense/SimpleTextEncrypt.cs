using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Licensing.Properties;

namespace Licensing
{
    public class SimpleTextEncrypt
    {
        public static string Encrypt(string textToEncrypt)
        {
            try
            {
                var toReturn = "";
                var ivByte = Encoding.UTF8.GetBytes(Resources.TextEncryptIV.Substring(0, 8));
                var keyByte = Encoding.UTF8.GetBytes(Resources.TextEncryptKey.Substring(0, 8));
                var inputByteArray = Encoding.UTF8.GetBytes(textToEncrypt);

                using (var des = new DESCryptoServiceProvider())
                {
                    var ms = new MemoryStream();
                    var cs = new CryptoStream(ms, des.CreateEncryptor(keyByte, ivByte), CryptoStreamMode.Write);
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    toReturn = Convert.ToBase64String(ms.ToArray());
                }
                return toReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }

        public static string Decrypt(string textToDecrypt)
        {
            try
            {
                var toReturn = "";
                var ivByte = Encoding.UTF8.GetBytes(Resources.TextEncryptIV.Substring(0, 8));
                var keyBytes = Encoding.UTF8.GetBytes(Resources.TextEncryptKey.Substring(0, 8));
                var inputByteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));

                using (var des = new DESCryptoServiceProvider())
                {
                    var ms = new MemoryStream();
                    var cs = new CryptoStream(ms, des.CreateDecryptor(keyBytes, ivByte), CryptoStreamMode.Write);
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    var encoding = Encoding.UTF8;
                    toReturn = encoding.GetString(ms.ToArray());
                }
                return toReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }
    }
}
