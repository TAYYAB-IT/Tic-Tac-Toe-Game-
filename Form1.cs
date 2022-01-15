using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{

    public partial class Tic_Tac_Toe : Form
    {
        public Tic_Tac_Toe()
        {
            InitializeComponent();
        }
        private void start_button_Click(object sender, EventArgs e)
        {
            if(player_1_name.Text!=""&& player_2_name.Text!="" && player_1_name.Text!= player_2_label.Text)
            {
                player_1_name.ReadOnly=player_2_name.ReadOnly=true;
                start_button.Visible = false;
                player_turn.Visible = button_0.Visible = button_1.Visible = button_2.Visible = button_3.Visible = button_4.Visible
                    = button_5.Visible = button_6.Visible = button_7.Visible = button_8.Visible = true;
            }
            else if (player_1_name.Text != "" &&player_2_name.Text=="" && player_1_name.Text != player_2_label.Text)
            {
                player_2_name.Text = "Computer";
                player_1_name.ReadOnly = player_2_name.ReadOnly = true;
                start_button.Visible = false;
                player_turn.Visible = button_0.Visible = button_1.Visible = button_2.Visible = button_3.Visible = button_4.Visible
                    = button_5.Visible = button_6.Visible = button_7.Visible = button_8.Visible = true;
                if (player_turn.Text == "PLAYER #02")
                {
                    rand();

                }
            }
            else
            {
                MessageBox.Show("Enter Your Names Carefully, Then Start the Game!");
            }
        }
        private void reset()
        {
            player_1_name.ReadOnly = player_2_name.ReadOnly = false;
            player_1_name.Text = player_2_name.Text = "";
            start_button.Visible = true;
            player_turn.Visible = false;
            button_0.Text = button_1.Text = button_2.Text = button_3.Text = button_4.Text = button_5.Text = button_6.Text = button_7.Text = button_8.Text = "";
            button_0.Visible = button_1.Visible = button_2.Visible = button_3.Visible = button_4.Visible = button_5.Visible = button_6.Visible = button_7.Visible = button_8.Visible = false;
            button_0.Enabled = button_1.Enabled = button_2.Enabled = button_3.Enabled = button_4.Enabled = button_5.Enabled = button_6.Enabled = button_7.Enabled = button_8.Enabled = true;
            button_0.BackColor = button_1.BackColor = button_2.BackColor = button_3.BackColor = button_4.BackColor = button_5.BackColor = button_6.BackColor = button_7.BackColor = button_8.BackColor = Color.White;
            result_box.Visible = reset_button.Visible = restart_button.Visible = false;
            
            return;
        }
        private void restart()
        {
            button_0.Text = button_1.Text = button_2.Text = button_3.Text = button_4.Text = button_5.Text = button_6.Text = button_7.Text = button_8.Text = "";
            button_0.Enabled = button_1.Enabled = button_2.Enabled = button_3.Enabled = button_4.Enabled = button_5.Enabled = button_6.Enabled = button_7.Enabled = button_8.Enabled = true;
            button_0.BackColor = button_1.BackColor = button_2.BackColor = button_3.BackColor = button_4.BackColor = button_5.BackColor = button_6.BackColor = button_7.BackColor = button_8.BackColor = Color.White;
            result_box.Visible = reset_button.Visible = restart_button.Visible = false;
            player_turn.Visible = true;
            if (player_turn.Text == "PLAYER #02" && player_2_name.Text == "Computer")
            {
                rand();

            }
            return;
        }
        private void final(int player) {
            button_0.Enabled = button_1.Enabled = button_2.Enabled = button_3.Enabled = button_4.Enabled = button_5.Enabled = button_6.Enabled = button_7.Enabled = button_8.Enabled = false;

            switch (player)
            {
                case 0:
                    result_box.Text = "Game Tied";
                    
                    break;
                case 1:
                    result_box.Text=$"Congratulation! PLAYER #01 \n  {player_1_name.Text}  Won.";
                    break;
                case 2:
                    result_box.Text=$"Congratulation! PLAYER #02 \n  {player_2_name.Text}  Won.";
                    break;
            }
            result_box.Visible = restart_button.Visible = reset_button.Visible = true;
            player_turn.Visible = false;
            return;
        }
        private bool result()
        {
            if((button_0.Text!=""&&button_1.Text!=""&& button_2.Text != "") && (button_0.Text == button_1.Text && button_0.Text == button_2.Text))
            {
                if (button_0.Text == "X")
                {
                    final(1);
                }
                else
                {
                    final(2);
                }
                return true;
            }
            else if((button_0.Text != "" && button_3.Text != "" && button_6.Text != "") && (button_0.Text == button_3.Text && button_0.Text == button_6.Text))
            {
                if(button_0.Text == "X")
                {
                    final(1);
                }
                else
                {
                    final(2);
                }
                return true;
            }
            else if((button_0.Text != "" && button_4.Text != "" && button_8.Text != "") && (button_0.Text == button_4.Text && button_0.Text == button_8.Text))
            {
                if (button_0.Text == "X")
                {
                    final(1);
                }
                else
                {
                    final(2);
                }
                return true;
            }
            else if((button_3.Text != "" && button_4.Text != "" && button_5.Text != "") && (button_3.Text == button_4.Text && button_3.Text == button_5.Text)){
                if (button_3.Text == "X")
                {
                    final(1);
                }
                else
                {
                    final(2);
                }
                return true;
            }

            else if ((button_6.Text != "" && button_7.Text != "" && button_8.Text != "") && (button_6.Text == button_7.Text && button_6.Text == button_8.Text))
            {
                if (button_6.Text == "X")
                {
                    final(1);
                }
                else
                {
                    final(2);
                }
                return true;
            }

            else if ((button_1.Text != "" && button_4.Text != "" && button_7.Text != "") && (button_1.Text == button_4.Text && button_1.Text == button_7.Text))
            {
                if (button_1.Text == "X")
                {
                    final(1);
                }
                else
                {
                    final(2);
                }
                return true;
            }

            else if ((button_2.Text != "" && button_5.Text != "" && button_8.Text != "") && (button_2.Text == button_5.Text && button_2.Text == button_8.Text))
            {
                if (button_2.Text == "X")
                {
                    final(1);
                }
                else
                {
                    final(2);
                }
                return true;
            }

            else if ((button_2.Text != "" && button_4.Text != "" && button_6.Text != "") && (button_2.Text == button_4.Text && button_2.Text == button_6.Text))
            {
                if (button_2.Text == "X")
                {
                    final(1);
                }
                else
                {
                    final(2);
                }
                return true;
            }
            else if(button_0.Text!=""&& button_1.Text!=""&& button_2.Text != "" && button_3.Text != "" && button_4.Text != "" && button_5.Text != "" && button_6.Text != "" && button_7.Text != "" && button_8.Text != "")
            {
                final(0);
                return true;
            }
            else
            {
                return false;
            }
        }
        private void rand()
        {
            Random rd = new Random();
            int num;
            while (true)
            {
                num = rd.Next(9);
                
                if (num == 0 && button_0.Enabled)
                {
                    button_0.BackColor = Color.DarkRed;
                    button_0.Text = "O";

                    button_0.Enabled = false;
                    player_turn.Text = "PLAYER #01";break;
                }
              else  if (num == 1 && button_1.Enabled)
                {
                    button_1.BackColor = Color.DarkRed;
                    button_1.Text = "O";

                    button_1.Enabled = false;
                    player_turn.Text = "PLAYER #01"; break;
                }
              else  if (num == 2 && button_2.Enabled)
                {
                    button_2.BackColor = Color.DarkRed;
                    button_2.Text = "O";

                    button_2.Enabled = false;
                    player_turn.Text = "PLAYER #01"; break;
                }
               else if (num == 3 && button_3.Enabled)
                {
                    button_3.BackColor = Color.DarkRed;
                    button_3.Text = "O";

                    button_3.Enabled = false;
                    player_turn.Text = "PLAYER #01"; break;
                }
               else if (num == 4 && button_4.Enabled)
                {
                    button_4.BackColor = Color.DarkRed;
                    button_4.Text = "O";

                    button_4.Enabled = false;
                    player_turn.Text = "PLAYER #01"; break;
                }
                else if (num == 5 && button_5.Enabled)
                {
                    button_5.BackColor = Color.DarkRed;
                    button_5.Text = "O";

                    button_5.Enabled = false;
                    player_turn.Text = "PLAYER #01"; break;
                }
                else if (num == 6 && button_6.Enabled)
                {
                    button_6.BackColor = Color.DarkRed;
                    button_6.Text = "O";

                    button_6.Enabled = false;
                    player_turn.Text = "PLAYER #01"; break;
                }
               else if (num == 7 && button_7.Enabled)
                {
                    button_7.BackColor = Color.DarkRed;
                    button_7.Text = "O";

                    button_7.Enabled = false;
                    player_turn.Text = "PLAYER #01"; break;
                }
                else if (num == 8 && button_8.Enabled)
                {
                    button_8.BackColor = Color.DarkRed;
                    button_8.Text = "O";

                    button_8.Enabled = false;
                    player_turn.Text = "PLAYER #01"; break;
                }
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if(player_turn.Text=="PLAYER #01")
            {
                button_0.BackColor = Color.DarkGreen;
                button_0.Text = "X";
               
                button_0.Enabled= false;
                player_turn.Text = "PLAYER #02";
               if( !result())
                if (player_2_name.Text == "Computer")
                {
                   
                    rand();
                    result();
                }
            }
            else
            {
                button_0.BackColor = Color.DarkRed;
                button_0.Text = "O";
                
                button_0.Enabled = false;
                player_turn.Text = "PLAYER #01";
                result();
            }
            
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if (player_turn.Text == "PLAYER #01")
            {
                button_1.BackColor = Color.DarkGreen;
                button_1.Text = "X";

                button_1.Enabled = false;
                player_turn.Text = "PLAYER #02";
                if (!result())
                    if (player_2_name.Text == "Computer")
                {
                    rand();
                    result();
                }
            }
            else
            {
                button_1.BackColor = Color.DarkRed;
                button_1.Text = "O";

                button_1.Enabled = false;
                player_turn.Text = "PLAYER #01";
                result();
            }
            
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (player_turn.Text == "PLAYER #01")
            {
                button_2.BackColor = Color.DarkGreen;
                button_2.Text = "X";
                
                button_2.Enabled = false;
                player_turn.Text = "PLAYER #02";
                if (!result())
                    if (player_2_name.Text == "Computer")
                {
                    rand();
                    result();
                }
            }
            else
            {
                button_2.BackColor = Color.DarkRed;
                button_2.Text = "O";
                
                button_2.Enabled = false;
                player_turn.Text = "PLAYER #01";
                result();
            }
            
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (player_turn.Text == "PLAYER #01")
            {
                button_3.BackColor = Color.DarkGreen;
                button_3.Text = "X";
                
                button_3.Enabled = false;
                player_turn.Text = "PLAYER #02";
                if (!result())
                    if (player_2_name.Text == "Computer")
                {
                    rand();
                    result();
                }
            }
            else
            {
                button_3.BackColor = Color.DarkRed;
                button_3.Text = "O";
                
                button_3.Enabled = false;
                player_turn.Text = "PLAYER #01";
                result();
            }
            
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (player_turn.Text == "PLAYER #01")
            {
                button_4.BackColor = Color.DarkGreen;
                button_4.Text = "X";
                
                button_4.Enabled = false;
                player_turn.Text = "PLAYER #02";
                if (!result())
                    if (player_2_name.Text == "Computer")
                {
                    rand();
                    result();
                }
            }
            else
            {
                button_4.BackColor = Color.DarkRed;
                button_4.Text = "O";
                
                button_4.Enabled = false;
                player_turn.Text = "PLAYER #01";
                result();
            }
           
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (player_turn.Text == "PLAYER #01")
            {
                button_5.BackColor = Color.DarkGreen;
                button_5.Text = "X";
                
                button_5.Enabled = false;
                player_turn.Text = "PLAYER #02";
                if (!result())
                    if (player_2_name.Text == "Computer")
                {
                    rand();
                    result();
                }
            }
            else
            {
                button_5.BackColor = Color.DarkRed;
                button_5.Text = "O";
                
                button_5.Enabled = false;
                player_turn.Text = "PLAYER #01";
                result();
            }

        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (player_turn.Text == "PLAYER #01")
            {
                button_6.BackColor = Color.DarkGreen;
                button_6.Text = "X";
               
                button_6.Enabled = false;
                player_turn.Text = "PLAYER #02";
                if (!result())
                    if (player_2_name.Text == "Computer")
                {
                    rand();
                    result();
                }
            }
            else
            {
                button_6.BackColor = Color.DarkRed;
                button_6.Text = "O";
               
                button_6.Enabled = false;
                player_turn.Text = "PLAYER #01";
                result();
            }
            
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (player_turn.Text == "PLAYER #01")
            {
                button_7.BackColor = Color.DarkGreen;
                button_7.Text = "X";
               
                button_7.Enabled = false;
                player_turn.Text = "PLAYER #02";
                if (!result())
                    if (player_2_name.Text == "Computer")
                {
                    rand();
                    result();
                }
            }
            else
            {
                button_7.BackColor = Color.DarkRed;
                button_7.Text = "O";
                
                button_7.Enabled = false;
                player_turn.Text = "PLAYER #01";
                result();
            }
            
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (player_turn.Text == "PLAYER #01")
            {
                button_8.BackColor = Color.DarkGreen;
                button_8.Text = "X";
                
                button_8.Enabled = false;
                player_turn.Text = "PLAYER #02";
                if (!result())
                    if (player_2_name.Text == "Computer")
                {
                    rand();
                    result();
                }
            }
            else
            {
                button_8.BackColor = Color.DarkRed;
                button_8.Text = "O";
               
                button_8.Enabled = false;
                player_turn.Text = "PLAYER #01";
                result();
            }
           
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            restart();
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            reset();
        }

    }
}
