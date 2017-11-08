//Tyler tucker
//a choose your own adventure text game, were the user is running for president

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;  

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int Scene = 0;   //variables
        int delay = 370; //Fascism > Communism
        int percentage;

        Random ranGen = new Random(); //random number gen

        public Form1()
        {
            InitializeComponent();
            outputLabel.Text = "You are literally any US citzen ever, would you like to run for president?";
            redOption.Text = "Yes";
            blueOption.Text = "No";
            Refresh();
            yellowOption.Visible = false;
            yellowButton.Visible = false;
            c.Visible = false;
            lPicture.Visible = false;
            wPicture.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            SoundPlayer button = new SoundPlayer(Properties.Resources.Ding);  //makes sound players
            SoundPlayer Win = new SoundPlayer(Properties.Resources.Win);
            SoundPlayer Lose = new SoundPlayer(Properties.Resources.lose);

            if (e.KeyCode == Keys.M)       //red button press and what will happen
            {
                button.Play();

                if (Scene == 0) { Scene = 1; }
                else if (Scene == 1)
                {
                    Scene = 3;
                    blueButton.Visible = true;
                    blueOption.Visible = true;
                }
                else if (Scene == 3) { Scene = 5; }
                else if (Scene == 5) { Scene = 7; }
                else if (Scene == 6) { Scene = 8; }
                else if (Scene == 8) { Scene = 18; }
                else if (Scene == 9) { Scene = 12; }
                else if (Scene == 12)
                {
                    Scene = 13;
                    yellowButton.Visible = false;
                    yellowOption.Visible = false;
                    c.Visible = false;
                }

                else if (Scene == 14) { Scene = 20; }
                else if (Scene == 13) { Scene = 16; }
                else if (Scene == 21) { Scene = 0; }
                else if (Scene == 22) { Scene = 0; }
            }

            else if (e.KeyCode == Keys.B)  //blue button press and what will happen when it is pressed
            {
                button.Play();

                if (Scene == 0) { Scene = 2; }
                else if (Scene == 1)
                {
                    blueButton.Visible = false;
                    blueOption.Visible = false;
                }
                else if (Scene == 3) { Scene = 4; }
                else if (Scene == 4) { Scene = 21; }
                else if (Scene == 5) { Scene = 6; }
                else if (Scene == 6) { Scene = 9; }
                else if (Scene == 9) { Scene = 10; }
                else if (Scene == 12)
                {
                    Scene = 14;
                    yellowButton.Visible = false;
                    yellowOption.Visible = false;
                    c.Visible = false;
                }
                else if (Scene == 14) { Scene = 21; }
                else if (Scene == 8) { Scene = 19; }
                else if (Scene == 21) Close();
                else if (Scene == 22) Close();
            }

            else if (e.KeyCode == Keys.C)  //yellow button press and what will happen when it is pushed
            {
                if (Scene == 12)
                {
                    button.Play();

                    Scene = 15;
                    yellowOption.Visible = false;
                    yellowButton.Visible = false;
                    c.Visible = false;
                }
            }

            else if (e.KeyCode == Keys.L)  //to get to play again screen user presses L
            {
                if (Scene == 7 || Scene == 2 || Scene == 4 || Scene == 10 || Scene == 18 || Scene == 16 || Scene == 17 || Scene == 20) { Scene = 21; }
            }
            else if (e.KeyCode == Keys.W)  //to get to play again screen user presses W
            {
                if (Scene == 15 || Scene == 19 || Scene == 15) { Scene = 22; }
            }

            switch (Scene) //all scenes can what options that are presented to the user
            {
                case 0:
                    lPicture.Visible = false;
                    wPicture.Visible = false;
                    outputLabel.Text = "You are literally any US citzen ever, would you like to run for president?";
                    redOption.Text = "Yes";
                    blueOption.Text = "No";
                    Refresh();
                    break;
                case 1:
                    Thread.Sleep(delay);
                    outputLabel.Text = "You're in!! its time to choose your party, would you like to be a Communist or a Facist?";
                    redOption.Text = "Communist";
                    blueOption.Text = "Fascist";
                    Refresh();
                    break;
                case 2:
                    outputLabel.Text = "You continued to live up to nothing in life, your parents are disappointed\ and you die alone....You Lose. Press L to take the L";
                    redOption.Text = "";
                    blueOption.Text = "";
                    Refresh();
                    break;
                case 3:
                    outputLabel.Text = "Now that you have chosen your party its time for your first press conference. Would you like to have it November 12th or January 3rd?";
                    redOption.Text = "January 3rd";
                    blueOption.Text = "Novemeber 12th";
                    Refresh();
                    break;
                case 4:
                    outputLabel.Text = "The fascists came to your press conference and assasinated you... You Lose. Press L to take the L";
                    redOption.Text = "";
                    blueOption.Text = "";
                    Refresh();
                    break;
                case 5:
                    outputLabel.Text = "Your press conference was a success, voters love the communist party. Choose a country to bribe so you can win the election. Iran or Russia?";
                    redOption.Text = "Russia";
                    blueOption.Text = "Iran";
                    Refresh();
                    break;
                case 6:
                    outputLabel.Text = "Iran promises you all there oil and you tell the public";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "Once you win the election Iran does not keep its promise, will you go to war with Iran?";
                    redOption.Text = "Yes";
                    blueOption.Text = "No";
                    Refresh();
                    break;
                case 7:
                    outputLabel.Text = "Stalin awakes from the dead, and kills you, You Lose. Press L to take the L";
                    redOption.Text = "";
                    blueOption.Text = "";
                    Refresh();
                    break;
                case 8:
                    outputLabel.Text = "You attack Iran";
                    Refresh();
                    Thread.Sleep(2000);
                    outputLabel.Text = "The war goes on for 6 months, Iran wants to sign a peace treaty. Will you sign? or will you demand all there oil?";
                    redOption.Text = "Give up";
                    blueOption.Text = "Demand Oil";
                    Refresh();
                    break;
                case 9:
                    outputLabel.Text = "Three months later Iran donates all its oil to russia. Now will you go to war with Iran?";
                    redOption.Text = "Yes";
                    blueOption.Text = "No";
                    Refresh();
                    break;
                case 10:
                    outputLabel.Text = "Iran invades first, your country is mad at you and assasinates you....You Lose. Press L to take the L";
                    redOption.Text = "";
                    blueOption.Text = "";
                    Refresh();
                    break;
                case 12:
                    percentage = ranGen.Next(1, 101);
                    if (percentage > 30)
                    {
                        outputLabel.Text = "Justin Trudeu comes to the US for a meeting. What do you tell him?";
                        redOption.Text = "You are going to invade cuz you salty";
                        blueOption.Text = "You lie and say you want to change the national anthem";
                        yellowOption.Text = "Invade canada insted";
                        yellowButton.Visible = true;
                        yellowOption.Visible = true;
                        c.Visible = true;
                        Refresh();
                    }
                    else
                    {
                        outputLabel.Text = "You attack Iran, and take all there oil, Canada then attacks you to get the oil and ww3 breaks out....You Lose. Press L to take the L";
                        redOption.Text = "";
                        blueOption.Text = "";
                        Refresh();
                    }
                    break;
                case 13:
                    outputLabel.Text = "Justin Trudeau joins the war efforts, but you need more Country to invade Iran. Will you recruit Switzerland or Germany?";
                    redOption.Text = "Switzerland";
                    blueOption.Text = "Germany";
                    Refresh();
                    break;
                case 14:
                    outputLabel.Text = "Justin Trudeau thinks you wasted his time and leaves. Do you try and stop him?";
                    redOption.Text = "Oui";
                    blueOption.Text = "Non";
                    Refresh();
                    break;
                case 15:
                    outputLabel.Text = "Canada says sorry and gives you all their oil...You win. Press W to take the W";
                    redOption.Text = "";
                    blueOption.Text = "";
                    Refresh();
                    break;
                case 16:
                    outputLabel.Text = "Switzerland is neutral, you attack anyway and lose due to a shortage of soldiers.....You Lose. Press L to take the L";
                    redOption.Text = "";
                    blueOption.Text = "";
                    Refresh();
                    break;
                case 17:
                    outputLabel.Text = "Germany is still salty about the treaty of versify they nuke the US.... You Lose. Press L to take the L";
                    redOption.Text = "";
                    blueOption.Text = "";
                    Refresh();
                    break;
                case 18:
                    outputLabel.Text = "You failed this country...You Lose. Press L to take the L";
                    redOption.Text = "";
                    blueOption.Text = "";
                    Refresh();
                    break;
                case 19:
                    outputLabel.Text = "Iran can't fight any longer, they give in and give you all the oil...You Win. Press W to take the W.";
                    redOption.Text = "";
                    blueOption.Text = "";
                    Refresh();
                    break;
                case 20:
                    outputLabel.Text = "He leaves anyway...You Lose. Press L to take the L";
                    redOption.Text = "";
                    blueOption.Text = "";
                    Refresh();
                    break;
                case 21:
                    lPicture.Visible = true;
                    outputLabel.Text = "YOU TOOK THE L...Do you want to play again?";
                    redOption.Text = "Yes";
                    blueOption.Text = "No";
                    Lose.Play();
                    Refresh();
                    break;
                case 22:
                    wPicture.Visible = true;
                    outputLabel.Text = "YOU TOOK THE W...Do you want to play again?";
                    redOption.Text = "Yes";
                    blueOption.Text = "No";
                    Win.Play();
                    break;
                default:
                    break;
            }
        }
    }
}








