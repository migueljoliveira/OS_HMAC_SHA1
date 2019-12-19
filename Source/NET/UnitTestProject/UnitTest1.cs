using System;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutSystems.NssHMAC_SHA1;

namespace HMAC_testProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string mh;
            string basestr = "GET&https%3A%2F%2Fwww.flickr.com%2Fservices%2Foauth%2Frequest_token&oauth_callback%3Dhttp%253A%252F%252Fwww.example.com%26oauth_consumer_key%3D0388ac71957040f67475739ad834954e%26oauth_nonce%3D10293847%26oauth_signature_method%3DHMAC-SHA1%26oauth_timestamp%3D1301586162%26oauth_version%3D1.0";
            string secret = "7a97640816ab8950";
            CssHMAC_SHA1 sha1obj = new CssHMAC_SHA1();
            sha1obj.MssHash(out mh, basestr, secret);
            Console.WriteLine(mh);


        }
    }
}