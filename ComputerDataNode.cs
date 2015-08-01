using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeviceStructure
{
    public class DeviceNode
    {
        private string hostBlock;//entire host tag stream
        private string dataBlock;//entire data block stream
        private string city = "not listed";//filtered out city
        private string country = "not listed";//filtered out country
        private string hostName;//filtered out host name
        private string ip;
        private string latitude;
        private string longitude;
        private string port;
        private List<string> ports;
        private List<string> productsList;
        private string os;
        private string isp;
        private List<string> services;
        private List<string> creds;
        private int onlineStatus = 0;
        private string org;
        private string region_name;
        private string area_code;
        private string postal_code;
        private string country_name;
        private string link;
        private string version;
        private string productName;
        private string asn;
        private string devicetype;
        private int id;

        //Things that affect secuirty/accessability Factor of a device(assumes to be safe (false) until told otherwise (true))
        private bool httpRequiresLogin = true;
        private bool httpGivesLogins = false;
        private bool httpAdvertisesRunningServices = false;
        private bool ftpReuiresLogin = false;
        private bool ftpAllowsAnnoymousLogin = false;
        private bool telNetON = false;
        private bool dnsBroadcastingToPublic = false;
        private bool sipBroadcastingToPublic = false;
        private bool netBIOSBroadcastingToPublic = false;
        private bool mODBUSBroadcastingToPublic = false;
        private bool snmpOutOfDate = false;
        private bool defaultLoginsAndOrPasswordsListed = false;
        private bool smtpOn = false;
        private bool sipExposed = false;
        private bool givesUpPII = false;
        private bool vunerableSSHVersion = false;
        private bool wwwauthenticate = false;
        private bool httpOnline = false;
        private string scrappedHTTPData;
        private bool ftpOnline = false;
        //--------------------------------------------MAKE NODES---------------------------------------------------//

        public DeviceNode(string HostBlock, string DataBlock)
        {
            hostBlock = HostBlock;
            dataBlock = DataBlock;
        }

        public DeviceNode()
        {
            hostBlock = hostName;
        }

        //-----------------------------------------------PROPERTYS OF EACH NODE-------------------------------------------------------------------//
        public string Country_Name
        {
            get { return country_name; }
            set { country_name = value; }
        }
        public int Conf
        {
            get;
            set;
        }
        public string Org
        {
            get { return org; }
            set { org = value; }
        }
        public string Area_Code
        {
            get { return area_code; }
            set { area_code = value; }
        }
        public string Postal_Code
        {
            get { return postal_code; }
            set { postal_code = value; }
        }
        public string HostISP
        {
            get { return isp; }
            set { isp = value; }
        }
        public List<string> HostServices
        {
            get { return services; }
            set { services = value; }
        }//tells whats running
        public List<string> HostCreds
        {
            get { return creds; }
            set { creds = value; }
        }//tells login names and/or passwords

        public string HostName//gives the unfiltered string for host name
        {
            get
            {
                if (hostName != null)
                {
                    return hostName;
                }
                else
                    return HostIP;
            }
            set
            {
                hostName = value;
            }

        }
        public string HostCity//gives sorted out city
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string HostCountry//gives sorted out country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }
        public string HostIP//gives sorted out ip
        {
            get
            {
                if (ip == null)
                {
                    return ip = "NO IP";
                }
                else
                    return ip;
            }
            set
            {
                ip = value;
            }
        }
        public string HostLatitude//gives sorted out lat
        {
            get { return latitude; }
            set
            {
                latitude = value;
            }
        }
        public string HostLongitude//gives sorted out long
        {
            get { return longitude; }
            set
            {
                longitude = value;
            }
        }
        public string HostPorts//gives sorted out port
        {
            get { return port; }
            set
            {
                port = value;
            }
        }
        public List<string> HostPort
        {
            get
            {
                return ports;
            }
            set
            {
                ports = value;
            }
        }
        public List<string> ProductsList
        {
            get
            {
                return productsList;
            }
            set
            {
                productsList = value;
            }
        }
        public string DataBlock//gives unsorted and un filtered datablock
        {
            get { return dataBlock; }
            set { dataBlock = value; }
        }
        //ONLINE STATUS Values:
        //0= not checked yet
        //1 = online
        //-1 = offline
        public int OnlineStatus//is the device Verified to be online
        {get{return onlineStatus;}set{onlineStatus = value;}}
        public string ScrappedHTTPData
        { set { scrappedHTTPData = value; } get { return scrappedHTTPData; } }
        public int Device_ID
        { get; set; }
        public string Link
        { get { return link; } set { link = value; } }
        public string Device_Type
        { get { return devicetype; } set { devicetype = value; } }
        public string Version
        { get { return version; } set { version = value; } }
        public string ProductName
        { get { return productName; } set { productName = value; } }
        public string ASN
        { get { return asn; } set { asn = value; } }
        public string Domain
        {get;set;}
        public string MapsHyperLink
        {get;set;}
        public string LastUpdated
        { get; set;}

        //----------------------------------------------PROPERTYS OF EACH NODE CHECKS METHODS------------------------------------------------------------------//
        public bool HTTPRequiresLogin
        { set { httpRequiresLogin = value; } get { return httpRequiresLogin; } }
        public bool HTTPGivesLogins
        { get { return httpGivesLogins; } set { httpGivesLogins = value; } }
        public bool HTTPAdvertisesRunningServices
        { get { return httpAdvertisesRunningServices; } }
        public bool HTTPOnline
        { set { httpOnline = value; } get { return httpOnline; } }
        public bool FTPOnline
        { set { ftpOnline = value; } get { return ftpOnline; } }
        public bool FTPRequiresLogin
        { set { ftpReuiresLogin = value; } get { return ftpReuiresLogin; } }
        public bool FTPAllowsAnnoymousLogin
        { set { ftpAllowsAnnoymousLogin = value; } get { return ftpAllowsAnnoymousLogin; } }
        public bool TELNEToN
        { set { telNetON = value; } get { return telNetON; } }
        public bool DNSBroadcastingToPublic
        { get { return dnsBroadcastingToPublic; } set { dnsBroadcastingToPublic = value; } }
        public bool SIPBroadcastingToPublic
        { get { return sipBroadcastingToPublic; } set { sipBroadcastingToPublic = value; } }
        public bool NETBIOSBroadcastingToPublic
        { get { return netBIOSBroadcastingToPublic; } set { netBIOSBroadcastingToPublic = value; } }
        public bool MODBUSBroadcastingToPublic
        { get { return mODBUSBroadcastingToPublic; } set { mODBUSBroadcastingToPublic = value; } }
        public bool SNMPOutOfDate
        { get { return snmpOutOfDate; } set { snmpOutOfDate = value; } }
        public bool DefaultLoginsAndOrPasswordsListed
        { get { return defaultLoginsAndOrPasswordsListed; } set { defaultLoginsAndOrPasswordsListed = value; } }
        public bool SMTPOn
        { get { return smtpOn; } set { smtpOn = value; } }
        public bool SIPExposed
        { get { return sipExposed; } set { sipExposed = value; } }
        public bool GivesUpPII
        { get { return givesUpPII; } set { givesUpPII = value; } }
        public bool VunerableSSHVersion
        {
            get { return vunerableSSHVersion; }
            set { vunerableSSHVersion = value; }
        }
    }
        public class sortOnAccessabilityFactor : IComparer<DeviceNode>
        {
            public int Compare(DeviceNode a, DeviceNode b)
            {
                if (a.FindandSetAccessabilityFactor > b.FindandSetAccessabilityFactor) return 1;
                else if (a.FindandSetAccessabilityFactor < b.FindandSetAccessabilityFactor) return -1;
                else return 0;
            }
        }
}
