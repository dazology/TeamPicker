using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using CBRI.MSOffice;

namespace FootballTeamGenerator
{
    public partial class FootballTeamGenerator : Form
    {
               
        private List<Player> vlAvailablePlayers = new List<Player>();
        private List<Player> vlPlayers = new List<Player>();
        private ListViewColumnSorter lvwColumnSorter;

        public FootballTeamGenerator()
        {
            InitializeComponent();

            lvwColumnSorter = new ListViewColumnSorter();
            this.lsvFootballers.ListViewItemSorter = lvwColumnSorter;

            LoadPlayers();

            lsvAvailablePlayers.Sorting = SortOrder.Ascending;
            vlAvailablePlayers.Sort();
            LoadAvailableList();

            lsvAvailablePlayers.ItemChecked += new ItemCheckedEventHandler(lsvAvailablePlayers_ItemChecked);
        }

        void lsvAvailablePlayers_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Tag is Player)
            {
                ((Player)e.Item.Tag).Playing = e.Item.Checked;
            }
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            if (!SavePlayers())
            {
                MessageBox.Show("Save failed");
            }

            vlPlayers = new List<Player>();

            foreach (Player play in vlAvailablePlayers)
            {
                if (play.Playing)
                {
                    vlPlayers.Add(play);
                }
            }

            Generator.GenerateTeams(ref vlPlayers);

            LoadGeneratedPlayers();
        }


        private void LoadGeneratedPlayers()
        {
   
            lsvFootballers.Items.Clear();
            lsvFootballers.Groups.Clear();
            lsvFootballers.Groups.Add(new ListViewGroup("Team A"));

            foreach (Player play in vlPlayers)
            {
                if (play.SelectedTeam == Team.A)
                {
                    AddPlayerToPlayingList(play, lsvFootballers.Groups[0]);
                  
                }
            }
            
            AddBlankItem(lsvFootballers.Groups[0]);
            AddTotalToList(
                Generator.TeamTotalShooting(vlPlayers, Team.A).ToString(),
                Generator.TeamTotalPassing(vlPlayers, Team.A).ToString(),
                Generator.TeamTotalTackling(vlPlayers, Team.A).ToString(),
                Generator.TeamTotalDefending(vlPlayers, Team.A).ToString(),
                Generator.TeamTotalBallControl(vlPlayers, Team.A).ToString(),
                Generator.TeamTotalGoalkeeping(vlPlayers, Team.A).ToString(),
                Generator.TeamTotalEnergy(vlPlayers, Team.A).ToString(),
                Generator.TeamTotal(vlPlayers, Team.A).ToString(),
                lsvFootballers.Groups[0]);
            AddBlankItem(lsvFootballers.Groups[0]);
            lsvFootballers.Sorting = SortOrder.Ascending;
            lsvFootballers.Groups.Add(new ListViewGroup("Team B"));

           

            foreach (Player play in vlPlayers)
            {
                if (play.SelectedTeam == Team.B)
                {
                    AddPlayerToPlayingList(play, lsvFootballers.Groups[1]);

                }
            }

            AddBlankItem(lsvFootballers.Groups[1]);
            AddTotalToList(
                Generator.TeamTotalShooting(vlPlayers, Team.B).ToString(),
                Generator.TeamTotalPassing(vlPlayers, Team.B).ToString(),
                Generator.TeamTotalTackling(vlPlayers, Team.B).ToString(),
                Generator.TeamTotalDefending(vlPlayers, Team.B).ToString(),
                Generator.TeamTotalBallControl(vlPlayers, Team.B).ToString(),
                Generator.TeamTotalGoalkeeping(vlPlayers, Team.B).ToString(),
                Generator.TeamTotalEnergy(vlPlayers, Team.B).ToString(),
                Generator.TeamTotal(vlPlayers, Team.B).ToString(),
             
                lsvFootballers.Groups[1]);
        }

        private void cmdAddFootballer_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() != string.Empty)
            {
                ClearDatabindings();
                vlAvailablePlayers.Add(new Player(txtName.Text, (int)numShooting.Value, (int)numPassing.Value, (int)numDefending.Value, (int)numTackling.Value, (int)numGoalkeeping.Value, (int)numBallControl.Value, (int)numEnergy.Value));
                LoadAvailableList();
                txtName.Text = string.Empty;
                numShooting.Value = 0;

                

            }
            else
            {
                MessageBox.Show("Missing player name", "Enter player name", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void LoadAvailableList()
        {
            lsvAvailablePlayers.Items.Clear();
            
            foreach (Player play in vlAvailablePlayers)
            {
                AddPlayerToAvailableList(play);
            }
        }

        private void LoadList()
        {
            lsvFootballers.Items.Clear();
            lsvFootballers.Groups.Clear();

            foreach (Player play in vlPlayers)
            {
                AddPlayerToList(play);
            }
        }

        private void AddPlayerToAvailableList(Player player)
        {
            ListViewItem item = new ListViewItem(player.Name);
            item.SubItems.Add(player.ShootingAbility.ToString());
            item.SubItems.Add(player.PassingAbility.ToString());
            item.SubItems.Add(player.DefendingAbility.ToString());
            item.SubItems.Add(player.TacklingAbility.ToString());  
            item.SubItems.Add(player.BallControl.ToString());
            item.SubItems.Add(player.Goalkeeping.ToString());
            item.SubItems.Add(player.Energy.ToString());
            item.SubItems.Add(player.Overall.ToString());
            item.Tag = player;
            item.Checked = player.Playing;
            lsvAvailablePlayers.Items.Add(item);
        }

        private void AddPlayerToList(Player player)
        {
            AddPlayerToPlayingList(player, null);
        }

        private void AddPlayerToPlayingList(Player player, ListViewGroup group)
        {  
            ListViewItem item = new ListViewItem(player.Name);
            item.SubItems.Add(player.ShootingAbility.ToString());
            item.SubItems.Add(player.PassingAbility.ToString());
            item.SubItems.Add(player.DefendingAbility.ToString());
            item.SubItems.Add(player.TacklingAbility.ToString()); 
            item.SubItems.Add(player.BallControl.ToString());
            item.SubItems.Add(player.Goalkeeping.ToString());
            item.SubItems.Add(player.Energy.ToString());
            item.SubItems.Add(player.Overall.ToString());
            item.Tag = player;
            if (group != null)
            {
                item.Group = group;
            }
            lsvFootballers.Items.Add(item);
           
        }

        private void AddTotalToList(string total, string totalShooting, string totalPassing, string totalDefending, string totalTackling, string totalBallControl, string totalGoalkeeping, string totalEnergy,  ListViewGroup group)
        {
            ListViewItem item = new ListViewItem("Total:");
            item.SubItems.Add(total);
            item.SubItems.Add(totalShooting);
            item.SubItems.Add(totalPassing);
            item.SubItems.Add(totalDefending);
            item.SubItems.Add(totalTackling); 
            item.SubItems.Add(totalBallControl);
            item.SubItems.Add(totalGoalkeeping);
            item.SubItems.Add(totalEnergy);
            if (group != null)
            {
                item.Group = group;
            }
            lsvFootballers.Items.Add(item);
           
        }

        private void AddBlankItem(ListViewGroup group)
        {
            ListViewItem item = new ListViewItem();
            item.Group = group;
            lsvFootballers.Items.Add(item);
        
        }

        private void lsvFootballers_DoubleClick(object sender, EventArgs e)
        {
            if (lsvFootballers.SelectedItems.Count == 1)
            {
                vlPlayers.Remove(lsvFootballers.SelectedItems[0].Tag as Player);
                LoadList();
            }
        }



        private bool SavePlayers()
        {
            bool RetVal = false;
            StreamWriter output = new StreamWriter(Program.C_PLAYERS_XML);
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
                serializer.Serialize(output, this.vlAvailablePlayers);
                RetVal = true;
            }
            catch (Exception ex)
            {
            }
            finally
            {
                output.Close();
            }
            return RetVal;
        }


        private void LoadPlayers()
        {
            if (File.Exists(Program.C_PLAYERS_XML))
            {
                StreamReader input = new StreamReader(Program.C_PLAYERS_XML);
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
                    vlAvailablePlayers = serializer.Deserialize(input) as List<Player>;
                }
                catch
                {
                }
                finally
                {
                    input.Close();
                }
            }
        }

        private void lsvAvailablePlayers_DoubleClick(object sender, EventArgs e)
        {
            //if (lsvAvailablePlayers.SelectedItems.Count == 1)
            //{
            //    if (vlPlayers.Count < 10)
            //    {
            //        vlPlayers.Add(lsvAvailablePlayers.SelectedItems[0].Tag as Player);
            //        LoadList();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Can only have a maximum of 10 players", "Max 10 players", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    }
            //}
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!SavePlayers())
            {
                e.Cancel = true;
                MessageBox.Show("Save failed");
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvAvailablePlayers.SelectedItems)
            {
                vlAvailablePlayers.Remove(item.Tag as Player);
            }

            LoadAvailableList();
        }

        private void cmdAddPlayers_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvAvailablePlayers.SelectedItems)
            {
                vlPlayers.Add(item.Tag as Player);
            }
            LoadList();
        }

        private void cmdEmail_Click(object sender, EventArgs e)
        {
            StringBuilder sBody = new StringBuilder();
            string sTeamB = string.Empty;
            string sTo = string.Empty;
            
            sBody.AppendLine("Suggested teams for the football on Thursday:");
            sBody.AppendLine("");
            sBody.AppendLine("Team A");
            sBody.AppendLine("");

            foreach (Player play in vlPlayers)
            {
                if (play.SelectedTeam == Team.A)
                {
                    sBody.AppendLine(play.Name);
                }
                else if (play.SelectedTeam == Team.B)
                {
                    sTeamB += play.Name + "\n";
                }

                try
                {
                    sTo += play.Name.Substring(play.Name.IndexOf(" ") + 1) + ", " + play.Name.Substring(0, play.Name.IndexOf(" ")) + "; ";
                }
                catch
                {
                    MessageBox.Show("Cant add " + play.Name + "'s name to the to list", "Dodgy Name", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }

            sBody.AppendLine("");
            sBody.AppendLine("Team B");
            sBody.AppendLine("");
            sBody.Append(sTeamB);

            try
            {
                MSOutlook.SendMAPIMessage("", "campden", sTo, "", "", "Thursday Football Teams", sBody.ToString(), "", true, false, false, "", MAPIBodyFormat.Plain);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, error, eh eh eh. Something about... " + ex.Message + ", got any ideas..?", "Something bad happened", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lsvAvailablePlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvAvailablePlayers.SelectedItems.Count == 1)
            {
                ClearDatabindings();
                AddDatabindings();
            }
            else
            {
                txtName.DataBindings.Clear();
                txtName.Text = string.Empty;
                numShooting.DataBindings.Clear();
                numShooting.Value = 0;
                numPassing.DataBindings.Clear();
                numPassing.Value = 0;
                numTackling.DataBindings.Clear();
                numTackling.Value = 0;
                numDefending.DataBindings.Clear();
                numDefending.Value = 0;
                numGoalkeeping.DataBindings.Clear();
                numGoalkeeping.Value = 0;
                numBallControl.DataBindings.Clear();
                numBallControl.Value = 0;
                numEnergy.DataBindings.Clear();
                numEnergy.Value = 0;
                LoadAvailableList();
            }
        }

        private void AddDatabindings()
        {
            txtName.DataBindings.Add("Text", ((Player)lsvAvailablePlayers.SelectedItems[0].Tag), "Name");
            numShooting.DataBindings.Add("Value", ((Player)lsvAvailablePlayers.SelectedItems[0].Tag), "ShootingAbility");
            numPassing.DataBindings.Add("Value", ((Player)lsvAvailablePlayers.SelectedItems[0].Tag), "PassingAbility");
            numTackling.DataBindings.Add("Value", ((Player)lsvAvailablePlayers.SelectedItems[0].Tag), "TacklingAbility");
            numDefending.DataBindings.Add("Value", ((Player)lsvAvailablePlayers.SelectedItems[0].Tag), "DefendingAbility");
            numGoalkeeping.DataBindings.Add("Value", ((Player)lsvAvailablePlayers.SelectedItems[0].Tag), "GoalKeeping");
            numBallControl.DataBindings.Add("Value", ((Player)lsvAvailablePlayers.SelectedItems[0].Tag), "BallControl");
            numEnergy.DataBindings.Add("Value", ((Player)lsvAvailablePlayers.SelectedItems[0].Tag), "Energy");
        
        }

        private void ClearDatabindings()
        {
           txtName.DataBindings.Clear();
           numShooting.DataBindings.Clear();
           numPassing.DataBindings.Clear();
           numTackling.DataBindings.Clear();
           numDefending.DataBindings.Clear();
           numGoalkeeping.DataBindings.Clear();
           numBallControl.DataBindings.Clear();
           numEnergy.DataBindings.Clear();
         }
        

        private void cmdSortAvailable_Click(object sender, EventArgs e)
        {
            vlAvailablePlayers.Sort();
            LoadAvailableList();
        }

        private void cmdSaveList_Click(object sender, EventArgs e)
        {
            if (!SavePlayers())
            {
                MessageBox.Show("Save failed");
            }
        }

        private void lsvFootballers_Click(object sender, EventArgs e)
        {
            cmdSwap.Enabled = lsvFootballers.SelectedItems.Count == 2;


        }

        private void cmdSwap_Click(object sender, EventArgs e)
        {
            Player p1 = (Player)this.lsvFootballers.SelectedItems[0].Tag as Player;
            Player p2 = (Player)this.lsvFootballers.SelectedItems[1].Tag as Player;

            if (p1.SelectedTeam != p2.SelectedTeam)
            {
                Team t = p1.SelectedTeam;
                p1.SelectedTeam = p2.SelectedTeam;
                p2.SelectedTeam = t;
                LoadGeneratedPlayers();
            }
            
       }

        private void FootballTeamGenerator_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (!SavePlayers())
            {
                MessageBox.Show("Save failed");
            }
        }

        private void lsvFootballers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lsvFootballers.Sort();
				
        }

        private void lsvFootballers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      }
}