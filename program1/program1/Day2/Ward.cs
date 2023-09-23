using Program1.Day2;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace program1.Day2
{
    internal class Ward
    {
        public int RoomId { get; set; }
        public string PatientFirstName { get; set; } = string.Empty;
        public string PatientLastName { get; set; } = string.Empty;
        public string PatientAddress { get; set; } = string.Empty;

        public string RoomType { get; set; } = string.Empty;
        public string RoomSharing { get; set; } = string.Empty;
        public string WaterPurifier { get; set; } = string.Empty;

        public string BedNumber { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"RoomID:{this.RoomId}, PatientFirstName:{this.PatientFirstName},\n" +
            $"PatientLastName:{this.PatientLastName},PatientAddress:{this.PatientAddress} RoomType:{this.RoomType},\n" +
                $"RoomSharing:{this.RoomSharing}, WaterPurifier:{this.WaterPurifier}, BedNumber:{this.BedNumber},";
        }
    } 
    internal class TestWard
    {
        public static void TestRoom()
        {
            Ward w = new Ward();
            w.RoomId = 1;
            w.PatientFirstName = "Ayushi";
            w.PatientLastName = "Vaishnav";
            w.PatientAddress = "Bulandshahr";
            w.RoomSharing = "5 sharing";
            w.RoomType = "AC";
            w.WaterPurifier = "Yes";
            w.BedNumber = "6";
            String value=w.ToString();
            Console.WriteLine(value);
            
            
        }
    }


}
