using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Dimelo.Sdk.Helpers
{
    /// <summary>
    /// Helper class for signing 
    /// </summary>
    public static class SigningHelper
    {
        /// <summary>
        /// Calculate hash for provided content with secret and return it as the signature.
        /// We use the SHA512 encryption.
        /// </summary>
        /// <param name="secret">Secret string</param>
        /// <param name="content">Content to sign</param>
        /// <returns>Hash of the content as signature</returns>
        public static string Sign(string secret, string content)
        {
            if (string.IsNullOrWhiteSpace(secret)) throw new ArgumentNullException("Provide valid secret for signing");
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentNullException("Cannot sign empty content");

            Encoding encoding = Encoding.UTF8;
            byte[] secretBytes = encoding.GetBytes(secret);
            byte[] contentBytes = encoding.GetBytes(content);
            using (var hmacsha = new HMACSHA512(secretBytes))
            {
                byte[] hashmessage = hmacsha.ComputeHash(contentBytes);
                string hash = BitConverter.ToString(hashmessage).Replace("-", string.Empty).ToLower();
                return hash;
            }
        }

        public static Boolean ValidateSignature(string secret, string content, string expectedSignature)
        {
            if (string.IsNullOrWhiteSpace(secret)) throw new ArgumentNullException("Provide valid secret for validating");
            if (string.IsNullOrWhiteSpace(content)) throw new ArgumentNullException("Cannot validate empty content");
            if (string.IsNullOrWhiteSpace(expectedSignature)) throw new ArgumentNullException("Cannot validate empty signature");

            var signature = Sign(secret, content);
            return (signature.Equals(expectedSignature));
        }
    }
}
