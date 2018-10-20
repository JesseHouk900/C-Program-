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
using System.Drawing;
using System.IO;

namespace ScanAnalyzer
{
    public abstract class ScanAnalyzer
    {
        //private string[,] grid; // Array to hold the grid size
        //private int[] sample1; // Array to hold the first sample
        //private int[] sample2;  // Array to hold the second sample
        public Point[][] pictureGrid;
        private Point[] samples; // Array to hold any samples of an analyzer
        private int guessCounter; // Number of Guesses 
        Random rand = new Random(); // Instance to create random numbers
        private int rows;// Number of rows for grid
        private int columns; // Number of columns for the grid
        private string imageName;
        //private FindSampleGame form; // Instance of the form 


        // Default constructor
        public ScanAnalyzer()
        {
            //int[,] grid = new int[rows, columns]; // 2d array to hold rows and column size entered by the user
            SetGrid(10, 10);
            imageName = "GridSquare.jpg";
            samples = new Point[1];

            samples[0].Row = rand.Next(0, 10); // random integer for sample 1 = row
            samples[0].Column = rand.Next(0, 10); // random integer for sample 1 = column

            guessCounter = 0; // Initializing the guess counter to 0

            //grid = new string[a, b]; // Initializng the array named grid
            ResetGrid();    // Resets the  array back 
            //this.form = form; // Playing the game of a form which is set here

            DisplayPictureBoxes();
        }

        // parameterized constructed taking in rows, columns, locations of the previously generated secret
        // evidence locations, and the name of the evidence image, ending in a .png preferably //and form as parameters
        public ScanAnalyzer(int a, int b, Point[] sampleLocations, string nameOfImage/*, FindSampleGame form*/)
        {
            SetGrid(a, b); // set the size of the grid
            imageName = nameOfImage;
            //sample1 = new int[2]; // Sample 1 holds the random location of the first item
            //sample2 = new int[2]; // Sample 2 holds the random location of the first item
            samples = sampleLocations;
            //samples = new Point[sampleLocations.Length];
            //if (samples.Length != 0)
            //{
                //// *************** Move to where new locations are made ******************
                ////bool repeat;
                ////samples[0].Row = rand.Next(0, a); // random integer for sample 1 = row
                ////samples[0].Column = rand.Next(0, b); // random integer for sample 1 = column
                // prevent any other samples from being the same point as sample 1
                //for (int i = 0; i < sampleLocations.Length; i++)
                //{
                    //samples[i] = sampleLocations[i];
                //    // *************** Move to where new locations are made ******************
                //    //do
                //    //{
                //    //    repeat = false;
                //    //    samples[i].Row = rand.Next(0, a); // random integer for sample i = row
                //    //    samples[i].Column = rand.Next(0, b); // random integer for sample i = column
                //    //    for (int j = 0; j < i; j++)
                //    //    {
                //    //        // check previous sample j locations against sample i
                //    //        if (samples[i].Row == samples[j].Row && samples[i].Column == samples[j].Column)
                //    //        {
                //    //            repeat = true;
                //    //        }
                //    //    }
                //    //} while (repeat);
                //}
            //}
            guessCounter = 0; // Initializing the guess counter to 0

            //grid = new string[a, b]; // Initializng the array named grid
            ResetGrid();    // Resets the  array back 
            //this.form = form; // Playing the game of a form which is set here

            DisplayPictureBoxes();
            //form.AppearGrid = DisplayGrid(); // // Displays the matrix in the textbox
        }

        //public String DisplayGrid()
        //{
        //    String matrixDisplay = " ";
        //    int rw = 0, clmn = 0; // row and column initialized to 0
        //    for (int i = 0; i < columns; i++) // printing the grid using a for-loop
        //        matrixDisplay = matrixDisplay + i; // Concatening for displaying 
        //    matrixDisplay += Environment.NewLine; // New line

        //    for (rw = 0; rw < rows; rw++) // For-loop to traverse through the element in the array
        //    {
        //        matrixDisplay = matrixDisplay + rw; // To display the grid
        //        do
        //        {
        //            matrixDisplay += grid[rw, clmn]; //
        //            clmn++; // incrementing the column
        //        }
        //        while (clmn < columns);  // while loop that will keep executing until the new column is lesser than the grid column
        //        clmn = 0; // initializing the column to 0
        //        matrixDisplay += Environment.NewLine; // new line 

        //    }
        //    return matrixDisplay; // Returns the grid back 

        //}

        /*This function is to reset grid everytime after the game is completed.
         It takes in no parameter and also returns nothing*/

        public void ResetGrid()
        {
            // displayPanel.Clear();
            for (int r = 0; r < rows; r++)
            {
                //pictureGrid[r] = new PictureBox[columns];
                for (int c = 0; c < columns; c++)
                {
                    CreateImage(r, c, imageName);
                    ChangeImage(r, c, imageName);

                }
            }
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //        grid[i, j] = "~";
            //}
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
         * is wrong, it is handled differently depending on how the derived class implements the
         * IncorrectGuess method. It takes in:
         * a - rows,
         * b - columns,
         * guess - how many clues have been found so far,
         * info - any additional information associated with the guess, such as
         *          a direction for the next hint
         * Returns:
         * bool - whether the user made a correct guess or not 
         */

        public bool EvaluateGuess(int a, int b, int guess, string info)
        {
            // sample the user is trying to find
            Point userSample = new Point(samples[guess].Row, samples[guess].Column, samples[guess].ImageName); // Initializng user the sample Array
            
            if (userSample.Row == a && userSample.Column == b) // checks to see if the user the found correct row and column sample
            {
                pictureGrid[a][b].ImageName = imageName; // Prints the appropriate image in the correct location
                DisplayPictureBoxes();
                //form.AppearGrid = DisplayGrid(); // Displays the X to the grid
                ResetGrid(); // Resets the grid 
                return true; // returns true
            }
            else
            {
                IncorrectGuess(info);
                // ********************** Only put in IncorrectGuess method of analyzer that wants
                // to provide hints when user guesses wrong ********************
                //if (userSample.Row == a)
                //    checkColumn(a, b, userSample.Row); // To check if it is the right column

                //else
                //{
                //    if (userSample.Column == b)
                //        checkRow(a, b, userSample.Column); // To check if it is the right row 
                //    else
                //    {
                //        if (info == "down") // checks to see if there is an X in the grid
                //            checkColumn(a, b, userSample.Column); //
                //        else
                //            checkRow(a, b, userSample.Column);
                //    }
                //}
                DisplayPictureBoxes();
                //form.AppearGrid = DisplayGrid();
                return false;
            }

        }

        // ********************** Only put in analyzer that wants to provide hints 
        // when user guesses wrong ********************
        ///* This function checks to see if the user guess is in the right row
        //* so it knows to print back whether ^ or v sign. It takes rows, column and
        //* userSample as parameter */

        //public void checkRow(int rows, int columns, int userSample)
        //{
        //    if (rows > userSample)
        //        pictureBox[rows][columns] = "UpHintImage.png";
        //    else
        //    {
        //        if (rows < userSample)
        //            pictureBox[rows][columns] = "DownHintImage.png";
        //    }
        //}

        ///* This function checks to see if the user guess is in the right column
        // * so it knows to print back whether < or > sign. It takes rows, column and
        // * userSample as parameter */

        //public void checkColumn(int rows, int columns, int userSample)
        //{
        //    if (columns > userSample) // if it is to the left side of the column
        //        pictureBox[rows][columns] = "RightHintImage.png"; // goes to that grid and prints < sign

        //    else
        //    {
        //        if (columns < userSample) // if it is right hand side of the column
        //            pictureBox[rows][columns] = "LeftHintImage.png"; // goes to that grid and prints > sign
        //    }
        //}

        // show the new pictureGrid
        public void DisplayPictureBoxes()
        {
            //int x; int y;
            pictureGrid = new Point[rows][];
            for (int r = 0; r < rows; r++)
            {
                pictureGrid[r] = new Point[columns];
            }
            for (int r = 0; r < rows; r++)
            {
                //pictureGrid[r] = new PictureBox[columns];
                for (int c = 0; c < columns; c++)
                {
                    // below lines are the calculate position lines for a simple square analyzer
                    //x = 88 + (20 * c) + 25;
                    //y = 200 + (20 * r) + 25;
                    // CreateImage(r, c, pictureGrid[r][c].ImageName);
                    ChangeImage(r, c, pictureGrid[r][c].ImageName);
                    //pictureGrid[r][c].Image = Image.FromFile("GridSquare.jpg");
                    //pictureGrid[r][c].Load(Directory.GetCurrentDirectory() + "\\GridSquare.jpg");
                    //form.Controls.Add(pictureGrid[r][c]);
                }
            }

        }

        // initialize a new Point which inherits from PictureBox on the pictureGrid
        // making the image name easily accessable
        private void CreateImage(int r, int c, string image)
        {
            Point pos = CalculatePosition(r, c);
            
            pictureGrid[r][c] = new Point(r, c, image);
            pictureGrid[r][c].Location = new System.Drawing.Point(pos.Row, pos.Column);
            pictureGrid[r][c].SizeMode = PictureBoxSizeMode.StretchImage;
            pictureGrid[r][c].BorderStyle = BorderStyle.FixedSingle;
            pictureGrid[r][c].BackColor = Color.Aqua;
            pictureGrid[r][c].Size = new Size(20, 20);
            pictureGrid[r][c].Anchor = AnchorStyles.Left;
            pictureGrid[r][c].Visible = true;

        }
        // allow derived class to override the CalculatePosition method, but 
        // prevent the method from being called explicitly from any instance.
        // calculate the position for an element in the pictureGrid
        protected abstract Point CalculatePosition(int r, int c);
        
        // ChangeImage is used to take a picture box from the grid and change the
        // image 
        private void ChangeImage(int r, int c, string image)
        {
            pictureGrid[r][c].Image = Image.FromFile(image);
            pictureGrid[r][c].Load(Directory.GetCurrentDirectory() + "\\" + image);
        }

        // allow derived class to override the IncorrectGuess method, but 
        // prevent the method from being called explicitly from any instance.
        // Handle the case where the user has made an incorrect guess for the
        // evidence
        protected abstract void IncorrectGuess(string info);

    }

}










