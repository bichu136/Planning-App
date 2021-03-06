﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Net;
using System.Xml;
using System.IO;
using System.Globalization;
namespace Do_An
{
    public class Weather
    {
        //http://home.openweathermap.org/users/sign_in -- link đăng ký lấy API
        private List<DateTime> days;
        private List<String> tempF;
        private List<String> weathers;
        private List<string> type_weather;
        private const string API_KEY = "0d10ac8477cafab5fb3e1ca0839f4032";


        private const string CurrentUrl =
            "http://api.openweathermap.org/data/2.5/weather?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;
        private const string ForecastUrl =
            "http://api.openweathermap.org/data/2.5/forecast?" +
            "@QUERY@=@LOC@&mode=xml&units=imperial&APPID=" + API_KEY;
        // ví dụ khi setting địa điểm vũng tàu sẽ đến link http://api.openweathermap.org/data/2.5/forecast?q=v%C5%A9ng%20t%C3%A0u&mode=xml&units=imperial&APPID=0d10ac8477cafab5fb3e1ca0839f4032
        public List<DateTime> Days { get => days; set => days = value; }
        public List<string> TempF { get => tempF; set => tempF = value; }
        public List<string> Weathers { get => weathers; set => weathers = value; }
        public List<string> Type_weather { get => type_weather; set => type_weather = value; }

        public void getData(String City)
        {
            //Link đăng ký Api openweathermap để ấy thông tin điền vào phần key của đoạn code API: http://home.openweathermap.org/users/sign_in 
            // t.Start();
            string url = ForecastUrl.Replace("@LOC@", City);
            url = url.Replace("@QUERY@", "q");


            using (WebClient client = new WebClient())
            {

                try
                {
                    InnergetData(client.DownloadString(url));
                }
                catch (WebException ex)
                {
                    DisplayError(ex);
                    //string path = @"c:\MyTest.txt";
                    //FileStream x = new FileStream(path,FileMode.OpenOrCreate);
                    //x.Write(Encoding.ASCII.GetBytes(cboTinh.Text),, cboTinh.Text.Length);
                }
                 catch (Exception ex)
                {

                }
            }
        }
        private void InnergetData(string xml)
        {
            XmlDocument xml_doc = new XmlDocument();
            xml_doc.LoadXml(xml);
            char degrees = (char)176;
            Days = new List<DateTime>();
            tempF = new List<String>();
            weathers = new List<string>();
            type_weather = new List<String>();
            foreach (XmlNode time_node in xml_doc.SelectNodes("//time"))
            {
                DateTime time =
                    DateTime.Parse(time_node.Attributes["from"].Value,
                        null, DateTimeStyles.AssumeUniversal);
                XmlNode temp_node = time_node.SelectSingleNode("temperature");
                string temp = temp_node.Attributes["value"].Value;
                XmlNode symb_node = time_node.SelectSingleNode("symbol");
                string symb = symb_node.Attributes["name"].Value;

                XmlNode typeweather_node = time_node.SelectSingleNode("symbol");
                string typeweather = typeweather_node.Attributes["number"].Value;
                Type_weather.Add(typeweather);
                days.Add(time);
                tempF.Add(temp + degrees);
                weathers.Add(symb);
            }
        }
        private void DisplayError(WebException exception)
        {
            try
            {

                StreamReader reader = new StreamReader(exception.Response.GetResponseStream());
                XmlDocument response_doc = new XmlDocument();
                response_doc.LoadXml(reader.ReadToEnd());
                XmlNode message_node = response_doc.SelectSingleNode("//message");
                throw new Exception(message_node.InnerText);
            }
            catch (Exception ex)
            {
                throw new Exception("Unknown error\n" + ex.Message);
            }
        }
    }
}

