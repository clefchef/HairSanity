using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HairSanity
{
    /// <summary>
    /// 
    /// </summary>
    public class Communication
    {
        public Communication() { }
        /// <summary>
        /// 
        /// </summary>
        /// <summary>
        /// Accessor functions
        /// </summary>
        public string MessageType { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public void SomeMethod(){}
        /// <summary>
        /// Clean up...
        /// </summary>
        ~Communication(){}

    }
}
