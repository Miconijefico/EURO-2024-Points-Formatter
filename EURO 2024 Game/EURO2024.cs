using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EURO_2024_Game
{

    public partial class EURO2024 : Form
    {
        private string userFilePath;
        private string resultFilePath;
        public EURO2024()
        {
            InitializeComponent();
        }

       

        private void btnPickUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                userFilePath = openFileDialog.FileName;
                tbUsers.Text = File.ReadAllText(userFilePath);
            }
        }

        private void btnPickResults_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                resultFilePath = openFileDialog.FileName;
                tbResults.Text = File.ReadAllText(resultFilePath);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var calculator = new PointsCalculator();
            var scores = calculator.CalculateScores(userFilePath, resultFilePath);

            string directory = Path.GetDirectoryName(userFilePath);
            string standingsFile = Path.Combine(directory, "standings.txt");

            
            var existingScores = new Dictionary<string, int>();
            if (File.Exists(standingsFile))
            {
                var lines = File.ReadAllLines(standingsFile);
                foreach (var line in lines)
                {
                    var parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        existingScores[parts[0].Trim()] = int.Parse(parts[1].Trim());

                    }
                }
            }

            
            foreach (var score in scores)
            {
                if (existingScores.ContainsKey(score.Key))
                {
                    existingScores[score.Key] += score.Value;
                }
                else
                {
                    existingScores[score.Key] = score.Value;
                }
            }

            
            File.WriteAllText(standingsFile, ""); 
            foreach (var score in existingScores)
            {
                string line = $"{score.Key} : {score.Value}\n";
                File.AppendAllText(standingsFile, line);
                MessageBox.Show("Scores have been inserted successfully!");
                tbStandings.Text = File.ReadAllText(standingsFile);
            }
        }
    }
}
