using System;
using System.Collections;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;

namespace OutSystems.NssHMAC_SHA1 {

	public class CssHMAC_SHA1: IssHMAC_SHA1 {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssHashedStr"></param>
		/// <param name="ssBaseStr"></param>
		/// <param name="ssHMACKey"></param>
		public void MssHash(out string ssHashedStr, string ssBaseStr, string ssHMACKey) {
			ssHashedStr = "";
            // TODO: Write implementation for action

            Byte[] secretBytes = UTF8Encoding.UTF8.GetBytes(ssHMACKey);
            HMACSHA1 hmac = new HMACSHA1(secretBytes);

            Byte[] dataBytes = UTF8Encoding.UTF8.GetBytes(ssBaseStr);
            Byte[] calcHash = hmac.ComputeHash(dataBytes);
            String calcHashString = Convert.ToBase64String(calcHash);
            ssHashedStr= calcHashString;


        } // MssHash


	} // CssHMAC_SHA1

} // OutSystems.NssHMAC_SHA1

