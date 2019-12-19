using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;

namespace OutSystems.NssHMAC_SHA1 {

	public interface IssHMAC_SHA1 {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssHashedStr"></param>
		/// <param name="ssBaseStr"></param>
		/// <param name="ssHMACKey"></param>
		void MssHash(out string ssHashedStr, string ssBaseStr, string ssHMACKey);

	} // IssHMAC_SHA1

} // OutSystems.NssHMAC_SHA1
