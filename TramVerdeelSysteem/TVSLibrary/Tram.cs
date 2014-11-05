using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVSLibrary
{
    public class Tram
    {
        public Sector Sector { get; private set; }
        public Status Status { get; private set; }
        public TramDriver Tramdriver { get; private set; }
        public int TramId { get; private set; }
        public string TramType { get; private set; }

        public Tram(string tramType, int tramId)
        {
            this.TramType = tramType;
            this.TramId = tramId;
            Status = Status.Service;
        }
        public void SetSector(Sector sector)
        {
            this.Sector = sector;
        }
        public void SetStatus(Status status)
        {
            this.Status = status;
        }
        public void SendToCleaning()
        {
            this.Status = Status.Cleaning;
        }
        public void SendToRepair()
        {
            this.Status = Status.Defect;
        }
        public void SetTramDriver(TramDriver tramdriver)
        {
            this.Tramdriver = tramdriver;
        }
        public void SortTram(List<Sector> AllSectors)
        {
            bool trackset = false;
            Sector current = null;
            while (trackset == false)
            {
                if (this.Status == Status.Cleaning)
                {
                }
                if (this.Status == Status.Defect)
                {
                }
                if (this.Status == Status.Service)
                {
                }
                if (this.TramId <= 841 && this.TramId >= 817)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 30)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 33)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 35)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 57)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                if ((this.TramId <= 901 && this.TramId >= 920) || (this.TramId <= 2201 && this.TramId >= 2204))
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 37)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 54)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 56)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                if (this.TramId == 2001 || this.TramId == 2004 || this.TramId == 2014 || this.TramId == 2032 || this.TramId == 2037 || this.TramId == 2039 || this.TramId == 2043 || this.TramId == 2050 || this.TramId == 2058 || this.TramId == 2072)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 32)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 41)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                if (this.TramId == 2002 || this.TramId == 2008 || this.TramId == 2017 || this.TramId == 2018 || this.TramId == 2019 || this.TramId == 2025 || this.TramId == 2031 || this.TramId == 2036 || this.TramId == 2042 || this.TramId == 2049 || this.TramId == 2051 || this.TramId == 2054 || this.TramId == 2055)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 34)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 38)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 55)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 63)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                if (this.TramId == 2003 || this.TramId == 2005 || this.TramId == 2011 || this.TramId == 2012 || this.TramId == 2013 || this.TramId == 2016 || this.TramId == 2020 || this.TramId == 2022 || this.TramId == 2026 || this.TramId == 2027 || this.TramId == 2028 || this.TramId == 2038 || this.TramId == 2044 || this.TramId == 2047 || this.TramId == 2060 || this.TramId == 2071)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 45)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 52)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                if (this.TramId == 2006 || this.TramId == 2010 || this.TramId == 2015 || this.TramId == 2021 || this.TramId == 2030 || this.TramId == 2040 || this.TramId == 2045 || this.TramId == 2046 || this.TramId == 2048 || this.TramId == 2056 || this.TramId == 2067 || this.TramId == 2070)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 44)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 53)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
                if (this.TramId == 2007 || this.TramId == 2009 || this.TramId == 2023 || this.TramId == 2024 || this.TramId == 2029 || this.TramId == 2033 || this.TramId == 2034 || this.TramId == 2035 || this.TramId == 2041 || this.TramId == 2052 || this.TramId == 2053 || this.TramId == 2059 || this.TramId == 2061 || this.TramId == 2064 || this.TramId == 2066 || this.TramId == 2068)
                {
                    foreach (Sector s in AllSectors)
                    {
                        if (s.Track.Number == 36)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                        if (s.Track.Number == 43)
                        {
                            if (s.Available == true)
                            {
                                current = s;
                                trackset = true;
                                break;
                            }
                        }
                    }
                }
            }
            this.Sector = current;
        }
    }
}
