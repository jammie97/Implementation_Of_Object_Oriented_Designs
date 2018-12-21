﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // TODO: BRANDON: Change Client class to be integrated into the datebase
    public class Client
    {
        /// <summary>
        /// Name of the client.
        /// </summary>
        private string m_name;
        /// <summary>
        /// Clients ID number.
        /// </summary>
        private int m_clientID;

        /// <summary>
        /// Name of the client.
        /// </summary>
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        /// <summary>
        /// Clients ID number.
        /// </summary>
        public int ClientID
        {
            get { return m_clientID; }
            set { m_clientID = value; }
        }
        
    }
}