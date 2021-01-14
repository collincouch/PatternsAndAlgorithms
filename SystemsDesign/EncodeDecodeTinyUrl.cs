using System;
using System.Collections.Generic;

namespace IK.SystemsDesign
{
    /// <summary>
    /// Leet code: 535
    /// </summary>
    public class EncodeDecodeTinyUrl
    {
        List<string> urls = new List<string>();
        public string decode(string shortUrl)
        {
            return urls[int.Parse(shortUrl)];
        }
    }
}
