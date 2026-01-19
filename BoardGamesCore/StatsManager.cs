using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCore
{
    public class StatsManager
    {
        private readonly string filename;
        public List<Player> allPlayers { get; } = new List<Player>();

        public StatsManager(string filename)
        {
            this.filename = filename;
        }

        public List<Player> LoadStats(List<Player> currentPlayers)
        {
            allPlayers.Clear();

            try
            {
                if (File.Exists(filename))
                {
                    using (StreamReader fin = new StreamReader(filename))
                    {
                        string line;
                        while ((line = fin.ReadLine()) != null)
                        {
                            string[] lines = line.Split(' ');

                            if (lines.Length != 2 || !int.TryParse(lines[1], out int wins))
                            {
                                throw new FormatException("Неверный формат строки статистики");
                            }

                            string name = lines[0];
                            Player oldPlayer = new Player(name);
                            oldPlayer.winCount = wins;
                            allPlayers.Add(oldPlayer);
                        }
                    }
                }
            }

            catch (FileNotFoundException ex)
            {
                //Console.WriteLine("Файл не найден. Будет создан новый.");
            }
            catch (FormatException ex)
            {
                //Console.WriteLine("Файл поврежден.");
            }

            // Выделить в отдельный метод
            foreach (Player current in currentPlayers)
            {
                bool found = false;
                foreach (Player saved in allPlayers)
                {
                    if (saved.name == current.name)
                    {
                        saved.winCount += current.winCount;
                        found = true;
                        break;
                    }
                }

                if (!found) allPlayers.Add(current);
            }

            return allPlayers;
        }


        public void SaveStats(List<Player> currentPlayers)
        {
            // Выделить в отдельный метод
            foreach (Player current in currentPlayers)
            {
                foreach (Player saved in allPlayers)
                {
                    if (saved.name == current.name)
                    {
                        
                        break;
                    }
                }
            }

            using (StreamWriter fout = new StreamWriter(filename))
            {
                foreach (Player player in allPlayers)
                {
                    fout.WriteLine($"{player.name} {player.winCount}");
                }
            }
        }


    }
}
