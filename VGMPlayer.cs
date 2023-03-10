using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace OPL2LPT_Player
{
    public static class interFace
    {
        [DllImport("inpout32.dll")]
        public static extern UInt32 IsInpOutDriverOpen();
        [DllImport("inpout32.dll")]
        public static extern void Out32(short PortAddress, short Data);
        [DllImport("inpout32.dll")]
        public static extern char Inp32(short PortAddress);

        [DllImport("inpout32.dll")]
        public static extern void DlPortWritePortUshort(short PortAddress, ushort Data);
        [DllImport("inpout32.dll")]
        public static extern ushort DlPortReadPortUshort(short PortAddress);

        [DllImport("inpout32.dll")]
        public static extern void DlPortWritePortUlong(int PortAddress, uint Data);
        [DllImport("inpout32.dll")]
        public static extern uint DlPortReadPortUlong(int PortAddress);

        [DllImport("inpoutx64.dll")]
        public static extern bool GetPhysLong(ref int PortAddress, ref uint Data);
        [DllImport("inpoutx64.dll")]
        public static extern bool SetPhysLong(ref int PortAddress, ref uint Data);


        [DllImport("inpoutx64.dll", EntryPoint = "IsInpOutDriverOpen")]
        public static extern UInt32 IsInpOutDriverOpen_x64();
        [DllImport("inpoutx64.dll", EntryPoint = "Out32")]
        public static extern void Out32_x64(short PortAddress, short Data);
        [DllImport("inpoutx64.dll", EntryPoint = "Inp32")]
        public static extern char Inp32_x64(short PortAddress);

        [DllImport("inpoutx64.dll", EntryPoint = "DlPortWritePortUshort")]
        public static extern void DlPortWritePortUshort_x64(short PortAddress, ushort Data);
        [DllImport("inpoutx64.dll", EntryPoint = "DlPortReadPortUshort")]
        public static extern ushort DlPortReadPortUshort_x64(short PortAddress);

        [DllImport("inpoutx64.dll", EntryPoint = "DlPortWritePortUlong")]
        public static extern void DlPortWritePortUlong_x64(int PortAddress, uint Data);
        [DllImport("inpoutx64.dll", EntryPoint = "DlPortReadPortUlong")]
        public static extern uint DlPortReadPortUlong_x64(int PortAddress);

        [DllImport("inpoutx64.dll", EntryPoint = "GetPhysLong")]
        public static extern bool GetPhysLong_x64(ref int PortAddress, ref uint Data);
        [DllImport("inpoutx64.dll", EntryPoint = "SetPhysLong")]
        public static extern bool SetPhysLong_x64(ref int PortAddress, ref uint Data);

        public static void writeReg(short lptDataPort, short register, short data)
        {
            short lptCtrlPort = lptDataPort;
            lptCtrlPort += 2;

            int[] staticValues = new[] { 12, 8, 12 };

            Out32(lptDataPort, register);

            for (int num = 0; num < 3; num++)
            {
                short val = Convert.ToInt16(staticValues[num]);
                val += 1;
                Out32(lptCtrlPort, val);
            }

            for (int num = 0; num < 6; num++)
            {
                char test = Inp32(lptCtrlPort);
            }

            Out32(lptDataPort, data);

            for (int num = 0; num < 3; num++)
            {
                short val = Convert.ToInt16(staticValues[num]);
                Out32(lptCtrlPort, val);
            }

            for (int num = 0; num < 35; num++)
            {
                char test = Inp32(lptCtrlPort);
            }
        }
    }

    public class CommandLine
    {
        public string CommandHex { get; set; }
        public string PortAsString { get; set; }
        public string DataAsString { get; set; }
        public short PortAsHex { get; set; }
        public short DataAsHex { get; set; }
        public int WaitHex { get; set; }
        public double WaitTime { get; set; }

        public CommandLine(string commandHex,
                           string portAsString,
                           string dataAsString,
                           short portAsHex,
                           short dataAsHex,
                           int waitHex,
                           double waitTime)
        {

            this.CommandHex = commandHex;
            this.PortAsString = portAsString;
            this.DataAsString = dataAsString;
            this.PortAsHex = portAsHex;
            this.DataAsHex = dataAsHex;
            this.WaitHex = waitHex;
            this.WaitTime = waitTime;
        }

    }

    class VGMPlayer
    {
        void VGMPlayer(string filePath, string mode, )
        {
            if (interFace.IsInpOutDriverOpen() == 0)
            {
                System.Console.WriteLine("Failed to open DLL!");
            }

            short lptDataPort;
            short lptControlPort;
            string fileName;
            string currdir;

            currdir = Directory.GetCurrentDirectory();

            fileName = "";
            lptDataPort = 0x0378;
            lptControlPort = lptDataPort;
            lptControlPort += 2;

            if (args.Length == 0)
            {
                fileName = "test.vgz";
            }

            System.Diagnostics.Process VGM2TXT = new System.Diagnostics.Process();
            VGM2TXT.StartInfo.FileName = String.Concat(currdir, "/vgm2txt/vgm2txt.exe");
            VGM2TXT.StartInfo.Arguments = String.Concat(fileName, " 0 0");
            VGM2TXT.StartInfo.RedirectStandardOutput = true;
            VGM2TXT.StartInfo.RedirectStandardError = true;
            VGM2TXT.StartInfo.UseShellExecute = false;
            VGM2TXT.StartInfo.CreateNoWindow = true;

            VGM2TXT.Start();

            List<string> temp = fileName.Split('.').ToList();
            temp.RemoveAt(temp.Count - 1);
            string fNameWithoutExt = String.Join("", temp);

            bool done = false;
            string loadedText = "";

            while (done == false)
            {
                try
                {
                    loadedText = File.ReadAllText(string.Concat(currdir, "/", fNameWithoutExt, ".txt"));
                    done = true;
                    VGM2TXT.Close();

                }
                catch
                {

                }
            }

            temp = loadedText.Replace('\r', ' ').Replace('\t', ' ').Split('\n').ToList();

            long YM3812freq = 0;
            long YM3526freq = 0;
            double oneSample = 1487.0 / 65535.0;


            List<CommandLine> commandLines = new List<CommandLine>();

            for (int num = 0; num < temp.Count; num++)
            {
                string line = temp[num];
                if (line.Length >= 6 && (line.Substring(0, 6) == "YM3812" || line.Substring(0, 6) == "YM3526"))
                {
                    string[] lineData = line.Split(' ');
                    if (line.Substring(0, 6) == "YM3812")
                    {
                        YM3812freq = long.Parse(lineData[3]);
                    }
                    else
                    {
                        YM3526freq = long.Parse(lineData[3]);
                    }
                }
                else if (line.Length >= 2 && line.Substring(0, 2) == "0x")
                {
                    string[] lineData = line.Split(' ');
                    if (lineData[1] == "5A" || lineData[1] == "5B" ||
                           lineData[1] == "61" || lineData[1] == "62" ||
                           lineData[1] == "63")
                    {

                        // short shit1 = short.Parse(String.Concat("0x", lineData[2]));

                        string command = lineData[1];
                        string portHex = "";
                        string dataHex = "";
                        short portNum = 0;
                        short dataNum = 0;
                        int waitNum = 0;

                        if (command == "5A" || command == "5B" || command == "61")
                        {
                            portHex = lineData[2];
                            dataHex = lineData[3];

                            string tempString = String.Concat("0x", lineData[2]);
                            portNum = Convert.ToInt16(tempString, 16);

                            tempString = String.Concat("0x", lineData[3]);
                            dataNum = Convert.ToInt16(tempString, 16);

                        }
                        else if (command == "62")
                        {
                            waitNum = 735;
                        }
                        else if (command == "63")
                        {
                            waitNum = 882;
                        }
                        else if (command == "61")
                        {
                            string tempString = String.Concat("0x", lineData[3], lineData[2]);
                            waitNum = Convert.ToInt32(tempString, 16);
                        }

                        double waitTime = oneSample * waitNum;

                        commandLines.Add(new CommandLine(
                            command, portHex, dataHex, portNum, dataNum, waitNum, waitTime
                            ));
                    }


                }

            }

            foreach (CommandLine cl in commandLines)
            {

                if (cl.CommandHex == "5A" || cl.CommandHex == "5B")
                {
                    interFace.writeReg(lptDataPort, cl.PortAsHex, cl.DataAsHex);
                }
                else
                {
                    Thread.Sleep(Convert.ToInt32(cl.WaitTime));
                }

            }

        }
    }
}
