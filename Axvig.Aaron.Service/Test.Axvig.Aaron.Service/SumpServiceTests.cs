using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace Test.Axvig.Aaron.Service
{
    [TestClass]
    public class SumpServiceTests
    {
        [TestMethod]
        public void NewReading()
        {
            Assert.AreEqual(0, CreateReading(5));
        }

        [TestMethod]
        public void GetResults()
        {
            Assert.AreEqual(new List<int>(), GetReadings());
        }

        public static int CreateReading(double meters)
        {
            WebRequest request = WebRequest.Create(new Uri("http://aaron.axvig.com/service/Sump.svc/" + meters));
            request.Method = "POST";
            request.ContentType = "text/json";
            byte[] bytes = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject("temp"));
            request.ContentLength = bytes.Length;
            request.GetRequestStream().Write(bytes, 0, bytes.Length);
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    return JsonConvert.DeserializeObject<int>(sr.ReadToEnd());
                }
            }
        }

        public static List<int> GetReadings()
        {
            WebRequest request = WebRequest.Create(new Uri("http://aaron.axvig.com/service/Sump.svc/200"));
            request.Method = "GET";
            request.ContentType = "text/json";
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                {
                    return JsonConvert.DeserializeObject<List<int>>(sr.ReadToEnd());
                }
            }
        }
    }
}
