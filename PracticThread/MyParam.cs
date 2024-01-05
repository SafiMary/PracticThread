using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticThread
{
    internal class MyParam
    {
        public string newPath;
        public string OldPath;
        bool isCopy = true;

        public MyParam(string OldPath, string newPath, bool isCopy)
        {
            this.OldPath = OldPath;
            this.newPath = newPath;
            this.isCopy = isCopy;
        }
        [DllImport("kernel32.dll",
 CharSet = CharSet.Unicode,
 CallingConvention = CallingConvention.StdCall,
 SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CopyFile(
         [MarshalAs(UnmanagedType.LPWStr)] string lpExistingFileName,
         [MarshalAs(UnmanagedType.LPWStr)] string lpNewFileName,
         [MarshalAs(UnmanagedType.Bool)] bool bFailIfExists);
        public void MethodCopy()
        {
            CopyFile(OldPath, newPath, isCopy);
        }


    }
}
