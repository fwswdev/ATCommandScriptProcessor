using System;
using System.Collections.Generic;
using System.Text;

namespace AT_Command_Script_Processor
{


    public interface IAtScriptProcessing
    {
        List<AtScriptProcessingData> ProcessArrayString(string[] strArray);
    }




    public class AtScriptProcessingData
    {
        public bool IsSpecialCommand { get; set; }
        public byte ByteToSend { get; set; }
        public string ATCommandToSend { get; set; }
        public int Delay { get; set; }
        public bool ReceiveData { get; set; }

        public static AtScriptProcessingData GetContainer()
        {
            var a = new AtScriptProcessingData();
            a.IsSpecialCommand = false;
            a.ATCommandToSend = null;
            a.ByteToSend = 0;
            return a;
        }
    }



    public class AtScriptProcessing : IAtScriptProcessing
    {
        public List<AtScriptProcessingData> ProcessArrayString(string[] strArray)
        {
            var lstAtScriptData = new List<AtScriptProcessingData>();
            

            foreach (var x in strArray)
            {
                if (x.StartsWith(@"//"))
                    continue;

                string[] spliString = x.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (spliString.Length != 4)
                    continue;

                int delay = 0;
                bool boolReadRx = false;
                string ATcmd = "";

                try
                {
                    delay = int.Parse(spliString[2].Trim());
                    boolReadRx = Convert.ToBoolean(spliString[1].Trim());
                    ATcmd = spliString[0].Trim();
                }
                catch
                {
                    continue;
                }

                var atScriptData = AtScriptProcessingData.GetContainer();

                if (ATcmd.StartsWith("__@HEX")) // if special command
                {
                    atScriptData.IsSpecialCommand = true;

                    try
                    {
                        string[] splitstr = ATcmd.Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                        byte ByToSend = Convert.ToByte(  splitstr[1].Trim(), 16);
                        atScriptData.ByteToSend = ByToSend;
                    }
                    catch
                    {
                        continue;
                    }
                }
                else
                {
                    atScriptData.ATCommandToSend = ATcmd;
                }

                atScriptData.Delay = delay;
                atScriptData.ReceiveData = boolReadRx;
                lstAtScriptData.Add(atScriptData);
            }

            return lstAtScriptData;

        }

    }
}
