﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaDAL
{
   public class ErrorDAO 
    {
     

        public ErrorDAO(string explanation)
        {
            
            string file = @"../../../Error.log";
            StreamWriter writer = File.AppendText(file);
            if (!File.Exists(file))
                File.Create(file);

            writer.WriteLine("Occurence time: " + DateTime.Now.ToString() + " Explanation: " + explanation);
            writer.Close();
            //if (Environment.UserInteractive)
            //    throw new Exception("test");
            //else
            //throw new Exception(explanation);
        }
    }
}
