using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Group 3 Assignment 7
 * Max Herrington
 * Dinesh Ram Condur
 * Monica Devireddy
 * Fatemha Jalali
 * 
 * We were tasked with creating a program that will allow the user to select
 * a team from a list of major league baseball teams and have the number of times 
 * that team has won the world series display on the screen.
 */



namespace World_Series_Winners
{
	public partial class frmWorldSeriesWinners : Form
	{
		public frmWorldSeriesWinners()
		{
			InitializeComponent();
		}

		//Method to reset the number of wins label back to Wins
		public void Reset()
		{
			lblNumberOfWins.Text = "Wins";
		}

		//Method to exit the program and send a somewhat derogatory message about the Blue Jays
		public void Exit()
		{
			MessageBox.Show("Thanks for stopping by. I am terribly sorry if you happen" +
				" to be a Blue Jays fan. They will not get number 3 this year!");
			Close();
		}

		//A single dimensional array containing the winners of the World Series in chronological order
		string[] seriesWinners = {"Boston Americans","New York Giants","Chicago White Sox",
			"Chicago Cubs","Chicago Cubs","Pittsburgh Pirates","Philadelphia Athletics",
			"Philadelphia Athletics","Boston Red Sox","Philadelphia Athletics","Boston Braves",
			"Boston Red Sox","Boston Red Sox","Chicago White Sox","Boston Red Sox","Cincinnati Reds",
			"Cleveland Indians","New York Giants","New York Giants","New York Yankees","Washington Senators",
			"Pittsburgh Pirates","St. Louis Cardinals","New York Yankees","New York Yankees","Philadelphia Athletics",
			"Philadelphia Athletics","St. Louis Cardinals","New York Yankees","New York Giants",
			"St. Louis Cardinals","Detroit Tigers","New York Yankees","New York Yankees","New York Yankees",
			"New York Yankees","Cincinnati Reds","New York Yankees","St. Louis Cardinals","New York Yankees",
			"St. Louis Cardinals","Detroit Tigers","St. Louis Cardinals","New York Yankees","Cleveland Indians",
			"New York Yankees","New York Yankees","New York Yankees","New York Yankees","New York Yankees",
			"New York Giants","Brooklyn Dodgers","New York Yankees","Milwaukee Braves","New York Yankees",
			"Los Angeles Dodgers","Pittsburgh Pirates","New York Yankees","New York Yankees","Los Angeles Dodgers",
			"St. Louis Cardinals","Los Angeles Dodgers","Baltimore Orioles","St. Louis Cardinals","Detroit Tigers",
			"New York Mets","Baltimore Orioles","Pittsburgh Pirates","Oakland Athletics","Oakland Athletics",
			"Oakland Athletics","Cincinnati Reds","Cincinnati Reds","New York Yankees","New York Yankees",
			"Pittsburgh Pirates","Philadelphia Phillies","Los Angeles Dodgers","St. Louis Cardinals",
			"Baltimore Orioles","Detroit Tigers","Kansas City Royals","New York Mets","Minnesota Twins",
			"Los Angeles Dodgers","Oakland Athletics","Cincinnati Reds","Minnesota Twins","Toronto Blue Jays",
			"Toronto Blue Jays","Atlanta Braves","New York Yankees","Florida Marlins","New York Yankees",
			"New York Yankees","New York Yankees","Arizona Diamondbacks","Anaheim Angels","Florida Marlins",
			"Boston Red Sox","Chicago White Sox","St. Louis Cardinals","Boston Red Sox","Philadelphia Phillies",
			"New York Yankees","San Francisco Giants","St. Louis Cardinals","San Francisco Giants"};

		//A method to compare the listbox of teams with the array of winners and count the number
			//of wins for the team the user selected.
		public string WinCalculator(string team)
		{
			//initialize the count to 0
			int winCount = 0;

			//run through the length of the winners array
			for (int i = 0; i < seriesWinners.Length; i++)
			{
				//add 1 to winCount when the team selected matches an element of the array
				if (lstTeamSelector.SelectedItem.ToString() == seriesWinners[i])
				{
					winCount++;
				}
			}
			//return the winCount as a string to the user
			return lblNumberOfWins.Text = Convert.ToString(winCount);
		}

		private void lstTeamSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			//use the selected team as the parameter for the method
			WinCalculator(Convert.ToString(lstTeamSelector.SelectedIndex));
		}

		//run the reset method when the user clicks the reset button
		private void btnReset_Click(object sender, EventArgs e)
		{
			Reset();
		}

		//run the exit method when the user clicks the exit button
		private void btnExit_Click(object sender, EventArgs e)
		{
			Exit();
		}
	}
}
