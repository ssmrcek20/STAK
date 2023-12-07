using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ChargersManager
{
    internal class CSVManager
    {
        private readonly string filePath = Path.Combine(Application.StartupPath, "prvi-zadatak.csv");
        private readonly string filePathRes = Path.Combine(Application.StartupPath, "Rezervacije.csv");

        public List<Stations> getStations()
        {
            var lines = File.ReadAllLines(filePath, Encoding.GetEncoding(1250));
            var stations = new List<Stations>();

            for (int i = 1; i < lines.Length; i++)
            {
                var values = ParseCsvLine(lines[i]);
                var station = new Stations(values[0], values[1], values[2], values[3], values[4], values[5]);
                stations.Add(station);
            }

            return stations;
        }

        private string[] ParseCsvLine(string line)
        {
            List<string> values = new List<string>();
            bool inQuotes = false;
            int start = 0;

            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (line[i] == ',' && !inQuotes)
                {
                    values.Add(line.Substring(start, i - start).Trim('"'));
                    start = i + 1;
                }
            }

            values.Add(line.Substring(start).Trim('"'));

            return values.ToArray();
        }

        public Stations getStation(string name)
        {
            var lines = File.ReadAllLines(filePath, Encoding.GetEncoding(1250));

            for (int i = 1; i < lines.Length; i++)
            {
                var values = ParseCsvLine(lines[i]);
                if (values[1] == name)
                {
                    return new Stations(values[0], values[1], values[2], values[3], values[4], values[5]);
                }
            }
            return null;
        }

        public void AddStation(Stations station)
        {
            var lines = File.ReadAllLines(filePath, Encoding.GetEncoding(1250));
            if (lines.Length > 1)
            {
                var lastLine = lines[lines.Length - 1];
                var lastValues = ParseCsvLine(lastLine);
                int lastId;
                if (int.TryParse(lastValues[0], out lastId))
                {
                    station.Id = (lastId + 1).ToString();
                }
            }
            else
            {
                station.Id = "1";
            }

            using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.GetEncoding(1250)))
            {
                var stationData = new List<string>
                {
                    station.Id, station.Name, station.Address, station.Spots, station.State, station.Paying
                };

                var formattedData = stationData.Select(data => data.Contains(",") ? $"\"{data}\"" : data);

                sw.WriteLine(string.Join(",", formattedData));
            }
        }

        public void DeleteStation(string station)
        {
            var lines = File.ReadAllLines(filePath, Encoding.GetEncoding(1250));
            var updatedLines = new List<string>();

            foreach (var line in lines)
            {
                var values = ParseCsvLine(line);
                if (values[1] != station)
                {
                    updatedLines.Add(line);
                }
            }

            File.WriteAllLines(filePath, updatedLines, Encoding.GetEncoding(1250));
        }

        public List<Reservation> getReservations()
        {
            var lines = File.ReadAllLines(filePathRes, Encoding.GetEncoding(1250));
            var reservations = new List<Reservation>();

            for (int i = 0; i < lines.Length; i++)
            {
                var values = lines[i].Split(',');
                var reservation = new Reservation(values[0], values[1], values[2]);
                reservations.Add(reservation);
            }

            return reservations;
        }

        public void AddReservation(string name, DateTime dateTimeStart, DateTime dateTimeEnd)
        {
            var station = getStation(name);
            if(station == null)
            {
                return;
            } 

            using (StreamWriter sw = new StreamWriter(filePathRes, true, Encoding.GetEncoding(1250)))
            {
                var resData = new List<string>
                {
                    station.Id, dateTimeStart.ToString(), dateTimeEnd.ToString()
                };

                sw.WriteLine(string.Join(",", resData));
            }
        }
    }
}
