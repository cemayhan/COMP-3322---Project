﻿using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

public static class EncryptDecrypt
{
    public static string Encrypt(string toEncrypt, bool useHashing)
    {
        byte[] keyArray;
        byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

        AppSettingsReader appSettingsReader = new AppSettingsReader();


        string key = ConfigurationManager.ConnectionStrings["accessdatabasekey"].ConnectionString;

        //If hashing use get hashcode regards to your key
        if (useHashing)
        {
            MD5CryptoServiceProvider hashMD5 = new MD5CryptoServiceProvider();
            keyArray = hashMD5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            //Always release the resources and flush data of the Cryptographic service provide. Best Practice
            hashMD5.Clear();
        }
        else
        {
            keyArray = UTF8Encoding.UTF8.GetBytes(key);
        }

        TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
        //Set the secret key for the tripleDES algorithm
        tripleDES.Key = keyArray;
        //Mode of operation. there are other 4 modes.. We choose ECB(Electronic code Book)
        tripleDES.Mode = CipherMode.ECB;
        //Padding mode(if any extra byte added)

        tripleDES.Padding = PaddingMode.PKCS7;

        ICryptoTransform cTransform = tripleDES.CreateEncryptor();
        //Transform the specified region of bytes array to resultArray
        byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

        //Release resources held by TripleDes Encryptor
        tripleDES.Clear();

        //Return the encrypted data into unreadable string format
        return Convert.ToBase64String(resultArray, 0, resultArray.Length);
    }

    public static string Decrypt(string cipherString, bool useHashing)
    {
        byte[] keyArray;

        //Get the byte code of the string
        byte[] toEncryptArray = Convert.FromBase64String(cipherString);

        AppSettingsReader settingsReader = new AppSettingsReader();

        //Same key to open the lock!
        string key = ConfigurationManager.ConnectionStrings["accessdatabasekey"].ConnectionString;

        if (useHashing)
        {
            //If hashing was used get the hash code with regards to your key
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            //Release any resource held by the MD5CryptoServiceProvider
            hashmd5.Clear();
        }
        else
        {
            //If hashing was not implemented get the byte code of the key
            keyArray = UTF8Encoding.UTF8.GetBytes(key);
        }

        TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
        //Set the secret key for the tripleDES algorithm
        tripleDES.Key = keyArray;
        //Mode of operation. there are other 4 modes.. We choose ECB(Electronic code Book)

        tripleDES.Mode = CipherMode.ECB;
        //Padding mode(if any extra byte added)
        tripleDES.Padding = PaddingMode.PKCS7;

        ICryptoTransform cTransform = tripleDES.CreateDecryptor();
        byte[] resultArray = cTransform.TransformFinalBlock(
                                toEncryptArray, 0, toEncryptArray.Length);
        //Release resources held by TripleDes Encryptor                
        tripleDES.Clear();

        //Return the Clear decrypted TEXT
        return UTF8Encoding.UTF8.GetString(resultArray);
    }
}