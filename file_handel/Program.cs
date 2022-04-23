using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace file_handel
{
    class Program
    {
        public void copy(){
            String source="/home/lastvirus/Desktop/.NET Lab/file.txt";
            String dir="/home/lastvirus/Desktop/A/file1.txt";
                try{
                    if(!Directory.Exists(dir)){
                        Directory.CreateDirectory(dir);
                        File.Move(source,dir,true);
                    }
                    else{
                    String destination=dir;
                    File.Move(source,destination,true);
                    }
                }
                catch(Exception exp){
                    Console.WriteLine(exp.ToString());
                }
        }
         
        static void Main(string[] args)
        {
           Program cp = new Program();
           cp.copy();
        }
    }
}
