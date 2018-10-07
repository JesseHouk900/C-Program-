/* Vasudev Vijayaraman
 * C# Programming - 10/01/2018
 * Dr. Catherine Stringfellow
 * This program is a guessing game using GUI components me that allows a player 
 * to solve puzzles to search for clues to solve a murder mystery. The user gets to enter the grid size 
 * such as the rows and columns. Two samples are located in two different locations and user's goal is 
 * to guess it correctly. Hints will be provided to assist the user */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ScanAnalyzer
{
    public class ScanAnalyzer
    {
        private string[,] grid; // Array to hold the grid size
        private int[] sample1; // Array to hold the first sample
        private int[] sample2;  // Array to hold the second sample
        private int guessCounter; // Number of Guesses 
        Random rand = new Random(); // Instance to create random numbers
        private int rows;// Number of rows for grid
        private int columns; // Number of columns for the grid
        private FindSampleGame form; // Instance of the form 


        // Default constructor
        public ScanAnalyzer()
        {

            int[,] grid = new int[rows, columns]; // 2d array to hold rows and column size entered by the user
            SetGrid(0, 0);
        }

        // parameterized constructed taking in rows, columns and form as parameters
            public ScanAnalyzer(int a, int b, FindSampleGame form) 
            {
            rows = a;
            columns = b;

            sample1 = new int[2]; // Sample 1 holds the random location of the first item
            sample2 = new int[2]; // Sample 2 holds the random location of the first item

            sample1[0] = rand.Next(0, a); // random integer for sample 1 = row
            sample1[1] = rand.Next(0, b); // random integer for sample 1 = row
            sample2[0] = rand.Next(0, a); // random integer for sample 2 = row
            sample2[1] = rand.Next(0, b); // random integer for sample 2 = column
            guessCounter = 0; // Initializing the guess counter to 0

              grid = new string[a, b]; // Initializng the array named grid
                ResetGrid();    // Resets the  array back 
                this.form = form; // Playing the game of a form which is set here
                form.AppearGrid = DisplayGrid(); // // Displays the matrix in the textbox
        }

        public String DisplayGrid()
        {
            String matrixDisplay = " ";
            int rw = 0, clmn = 0; // row and column initialized to 0
            for (int i = 0; i < columns; i++) // printing the grid using a for-loop
                matrixDisplay = matrixDisplay + i; // Concatening for displaying 
                matrixDisplay += Environment.NewLine; // New line

            for (rw = 0; rw < rows; rw++) // For-loop to traverse through the element in the array
            {
                matrixDisplay = matrixDisplay + rw; // To display the grid
                do
                {
                    matrixDisplay += grid[rw, clmn]; //
                    clmn++; // incrementing the column
                }
                while (clmn < columns);  // while loop that will keep executing until the new column is lesser than the grid column
                clmn = 0; // initializing the column to 0
                matrixDisplay += Environment.NewLine; // new line 

            }
            return matrixDisplay; // Returns the grid back 
           
        }

        /*This function is to reset grid everytime after the game is completed.
         It takes in no parameter and also returns nothing*/

        public void ResetGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    grid[i, j] = "~";
            }
        }

        /* This method checks if row value and column value are greater than 0.
         * It takes rowValue and columnValue as parameters and returns void */
      
        public void SetGrid(int rowValue, int columnValue) 
        {
            rows = (rowValue > 0) ? rowValue : 0; 
            columns = (columnValue > 0) ? columnValue : 0;
        }

        /* This method is to get and set the guess counter of the user */

        public int GuessCounter
        {
            get { return guessCounter; }
            set { guessCounter++; }
        }

        /* This method checks if the user's guess is right or wrong, if it
         * is wrong, it prints back the hint. It takes in rowsm columns, guess and assign as parameters
         * and returns a bool value */

        public bool EvaluateGuess(int a, int b, int guess, string assign)
        {
            int[] userSample = new int[2]; // Initializng user the sample Array
            if (guess == 0)
            {
                userSample[0] = sample1[0]; // Sample array 1 assigned to the user's sample
                userSample[1] = sample1[1];
            }
            else
            {
                userSample[0] = sample2[0]; // / Sample array 2 assigned to the user's sample
                userSample[1] = sample2[1];
            }

            if (userSample[0] == a && userSample[1] == b) // checks to see if the user the found correct row and column sample
            {
                grid[a, b] = "X"; // Prints an X in the correct location
                form.AppearGrid = DisplayGrid(); // Displays the X to the grid
                ResetGrid(); // Resets the grid 
                return true; // returns true
            }
            else
            {
                if (userSample[0] == a)
                    checkColumn(a, b, userSample[0]); // To check if it is the right column

                else
                {
                    if (userSample[1] == b)
                        checkRow(a, b, userSample[1]); // To check if it is the right row 
                    else
                    {
                        if (assign == "Xmark") // checks to see if there is an X in the grid
                            checkColumn(a, b, userSample[1]); //
                        else
                            checkRow(a, b, userSample[0]);
                    }
                }
                form.AppearGrid = DisplayGrid();
                return false;
            }

        }



        /* This function checks to see if the user guess is in the right row
        * so it knows to print back whether ^ or v sign. It takes rows, column and
        * userSample as parameter */

        public void checkRow(int rows, int columns, int userSample)
        {
            if (rows > userSample)
                grid[rows, columns] = "^";
            else
            {
            if (rows < userSample)
                    grid[rows, columns] = "v";
            }
        }

        /* This function checks to see if the user guess is in the right column
         * so it knows to print back whether < or > sign. It takes rows, column and
         * userSample as parameter */

        public void checkColumn(int rows, int columns, int userSample)
            {
                if (columns > userSample) // if it is to the left side of the column
                  grid[rows, columns] = "<"; // goes to that grid and prints < sign

                else
                {
                    if (columns < userSample) // if it is right hand side of the column
                        grid[rows, columns] = ">"; // goes to that grid and prints > sign
            }
            }
 
       
    }
}







       

      
