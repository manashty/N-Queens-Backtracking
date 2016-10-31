using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Threading;

namespace ARMNQueens
{
    public partial class ARMNQueens : Form
    {
        static List<int> queens, queensPrev;
        static List<List<int>> queensAll;
        static Thread threadAttempt, threadAll;
        static bool isRun = true;

        Graphics g;
        static Image queen;
        public ARMNQueens()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            queen = Properties.Resources.Knight;
        }

        private void num_NumberOfQueens_ValueChanged(object sender, EventArgs e)
        {
            Reset();
        }

        private void ARMNQueens_Load(object sender, EventArgs e)
        {
            queens = new List<int>();
            queensPrev = new List<int>();
            queensAll = new List<List<int>>();
            Reset();

            for (int i = 0; i < imageList1.Images.Count; i++)
            {
                listView1.Items.Add(" ", i);
            }
        }

        public void DrawAll(bool limited)
        {
            if (!limited)
            {
                g.Clear(Color.White);
                DrawRooms();

            }
            DrawQueens(limited);
        }

        public void DrawQueens(bool limited)
        {
            if (queensPrev.Count != queens.Count)//New One
                queensPrev = queens.ToList<int>();
            for (int i = 0; i < queens.Count; i++)
            {
                if (!limited)
                    DrawQueen(i);
                else//Limited
                {
                    if (queensPrev[i] != queens[i])
                    {
                        float widthOfRooms = pictureBox1.Width / (float)queens.Count;
                        DrawRoom(widthOfRooms, i, queensPrev[i], ((i + queensPrev[i] /*j*/ ) % 2 == 0) ? Color.Blue : pictureBox1.BackColor);//Clear The Previous
                        DrawQueen(i);
                    }
                }
            }
            queensPrev = queens.ToList<int>();
        }

        public void DrawQueen(float x, float y, float width)
        {
            try
            {
                g.DrawImage(queen, x, y, width, width);
            }
            catch (Exception)
            {

            }

        }

        public void DrawQueen(int index)
        {
            try
            {
                float widthOfRooms = pictureBox1.Width / (float)queens.Count;
                DrawQueen(index * widthOfRooms, queens[index] * widthOfRooms, widthOfRooms);
            }
            catch (Exception)
            {

            }
        }

        public void DrawRooms()
        {
            try
            {
                float widthOfRooms = pictureBox1.Width / (float)queens.Count;
                for (int i = 0; i < queens.Count; i++)
                {
                    for (int j = i % 2; j < queens.Count; j += 2)
                    {
                        DrawRoom(widthOfRooms, i, j, Color.Blue);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void DrawRoom(float widthOfRooms, int i, int j, Color c)
        {
            g.FillRectangle(new SolidBrush(c), i * widthOfRooms, j * widthOfRooms, widthOfRooms, widthOfRooms);
        }

        static bool firstAttempt = true;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            GetNextQueens(firstAttempt);
            firstAttempt = false;
        }

        private void GetNextQueens(bool isFirstAttempt)
        {
            if (isFirstAttempt)
                FindNextPromising(0, true);// Start From Zero                               
            else//Assume before them are correct, try to fix from the end
                FindNextPromising((int)num_NumberOfQueens.Value - 1, false);
            DrawAll(true);
        }
        /// <summary>
        /// Finds the next promising place possible. Returns false if it was unsuccessful
        /// </summary>
        /// <param name="index">The Index of the queen</param>
        /// <param name="reset">Whether should start from the begining or not (Put True for Next ones, False for previous ones)</param>
        /// <returns>Whether a promising place has been found or not</returns>
        private static bool FindNextPromising(int index, bool reset/*, int startingIndex*/)
        {
            if (index == -1)//Nothing Has Been Found and Reached Zero Already
                return false;
            if (index == queens.Count)
                return true;//Already a Solution and gone further than the last one
            for (queens[index] = reset ? 0 : (queens[index] + 1); queens[index] < queens.Count; queens[index]++)// Search the places from the index Place to the possible number of places
            {
                if (IsPromising(index))
                    return FindNextPromising(index + 1, true);//Found a promising place, Find the next one
            }
            return FindNextPromising(index - 1, false);//Found Nothing, Change Previous
                                    
        }
        public static Int64 numOfPromisingCheck = 0;
        public static Int64 numOfPromising = 0;
        private static bool IsPromising(int index)
        {
            numOfPromisingCheck++;
            try
            {
                for (int i = 0; i < index; i++)
                {
                    if ((queens[i] == queens[index])//Same Row
                        ||
                        ((index - i) == Math.Abs(queens[i] - queens[index])))//Diagonal
                        return false;
                }
                numOfPromising++;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {

            try
            {
                queens.Clear();
                for (int i = 0; i < num_NumberOfQueens.Value; i++)
                {
                    queens.Add(i);
                }
                firstAttempt = true;
                DrawAll(false);
                timer1.Enabled = false;
                isRun = false;
            }
            catch (Exception)
            {


            }
            finally
            {
                ThreadsStop();
            }

        }

        private void ARMNQueens_Paint(object sender, PaintEventArgs e)
        {
            DrawAll(true);
        }

        private void ARMNQueens_Resize(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            DrawAll(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawAll(true);
            waitAmount = (int)num_Delay.Value;
        }

        private void btn_AttemptShow_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            isRun = true;
            numOfQueens = (int)num_NumberOfQueens.Value - 1;
            threadAttempt = new Thread(new ThreadStart(AttemptShow));
            threadAttempt.Start();
        }

        private static void AttemptShow()
        {
            GetNextQueensForShow(firstAttempt);
            firstAttempt = false;
        }
        private static int numOfQueens = 4;
        private static void GetNextQueensForShow(bool isFirstAttempt)
        {
            if (isFirstAttempt)
                FindNextPromisingThread(0, true);// Start From Zero
            else//Assume before them are correct, try to fix from the end
                FindNextPromisingThread(numOfQueens, false);
        }
        static int waitAmount = 100;
        /// <summary>
        /// Finds the next promising place possible. Returns false if it was unsuccessful
        /// </summary>
        /// <param name="index">The Index of the queen</param>
        /// <param name="reset">Whether should start from the begining or not (Put True for Next ones, False for previous ones)</param>
        /// <returns>Whether a promising place has been found or not</returns>
        private static bool FindNextPromisingThread(int index, bool reset)
        {
            if (!isRun)
                return false;
            if (index == -1)//Nothing Has Been Found and Reached Zero Already
                return false;
            if (index == queens.Count)
                return true;//Already a Solution and gone further than the last one
            for (queens[index] = reset ? 0 : (queens[index] + 1); queens[index] < queens.Count; queens[index]++)// Search the places from the index Place to the possible number of places
            {
                if (!isRun)
                    return false;
                Thread.Sleep(waitAmount);
                if (IsPromising(index))
                    return FindNextPromisingThread(index + 1, true);//Found a promising place, Find the next one                
            }
            return FindNextPromisingThread(index - 1, false);//Found Nothing, Change Previous
        }

        private static int FindNextPromisingThreadNoWait(int index)
        {
            if (!isRun)//For Thread End
                return -2;


            if (index == queens.Count)
            {
                queensAll.Add(queens.ToList<int>());
                return 0;//Already a Solution and gone further than the last one
            }
            for (queens[index] = 0; queens[index] < queens.Count; queens[index]++)// Search the places from the index Place to the possible number of places
            {
                if (IsPromising(index))//Found a promising place, Find the next one
                {
                    if (FindNextPromisingThreadNoWait(index + 1) == -2)//Check Thread End
                        return -2;//Thread's Gonna End                    
                }
            }
            return -1;//Found Nothing, Change Previous











            /*if (!isRun)
                return false;
            if (index == -1)//Nothing Has Been Found and Reached Zero Already
                return false;
            if (index == queens.Count)
                return true;//Already a Solution and gone further than the last one
            for (queens[index] = reset ? 0 : (queens[index] + 1); queens[index] < queens.Count; queens[index]++)// Search the places from the index Place to the possible number of places
            {
                if (!isRun)
                    return false;
                if (IsPromising(index))
                    return FindNextPromisingThreadNoWait(index + 1, true);//Found a promising place, Find the next one
            }
            return FindNextPromisingThreadNoWait(index - 1, false);//Found Nothing, Change Previous*/
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            isRun = false;
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            isRun = true;
            timer2.Enabled = true;
            numOfQueens = (int)num_NumberOfQueens.Value - 1;
            numOfPromising = 0;
            numOfPromisingCheck = 0;
            threadAll = new Thread(new ThreadStart(GetAllResults));
            threadAll.Start();
            trackBar1.Enabled = false;
        }

        private static void GetAllResults()
        {
            queensAll.Clear();
            FindNextPromisingThreadNoWait(0);// Start From Zero   








            //while (queens[0] < queens.Count)//I Do this because at least 2 answers for the 4 queens is possible
            //{
            //    queensAll.Add(queens.ToList<int>());
            //    FindNextPromisingThreadNoWait(0/*numOfQueens*/, false);
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            trackBar1.Minimum = 0;
            trackBar1.Maximum = queensAll.Count - 1;
            this.Text = "Current: " + (trackBar1.Value + 1).ToString() + " of " + (trackBar1.Maximum + 1).ToString();
            if ((queens[0] > queens.Count - 1))//All Finished
            {
                trackBar1.Enabled = true;
                timer2.Enabled = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            queens = queensAll[trackBar1.Value];
            this.Text = "Current: " + (trackBar1.Value + 1).ToString() + " of " + (trackBar1.Maximum + 1).ToString();
            DrawAll(true);
        }

        private void num_Delay_ValueChanged(object sender, EventArgs e)
        {
            waitAmount = (int)num_Delay.Value;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            DrawAll(false);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DrawAll(false);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                queen = imageList1.Images[listView1.SelectedIndices[0]];
                DrawAll(false);
            }
            catch (Exception)
            {

            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            //Reset();
            num_NumberOfQueens.Value = 20;
            num_NumberOfQueens_ValueChanged(sender, e);
            queens[0] = 10;
            queens[1] = 9;
            queens[2] = 8;
            queens[3] = 7;
            queens[4] = 6;
            queens[5] = 7;
            queens[6] = 8;
            queens[7] = 9;
            queens[8] = 10;
            queens[9] = 7;
            queens[10] = 6;
            queens[11] = 5;
            queens[12] = 4;
            queens[13] = 3;
            queens[14] = 4;
            queens[15] = 3;
            queens[16] = 4;
            queens[17] = 5;
            queens[18] = 6;
            queens[19] = 7;
            DrawAll(false);
            MessageBox.Show("Created by:\nAlireza Manashty\n     (ARM)\n May 2009 \n ARM7@YMail.com\n");
        }

        private void ARMNQueens_FormClosing(object sender, FormClosingEventArgs e)
        {
            ThreadsStop();
        }

        private static void ThreadsStop()
        {
            isRun = false;
            try
            {
                threadAll.Abort();
                threadAll.Join();

                threadAttempt.Abort();
                threadAttempt.Join();
            }
            catch (Exception)
            {


            }
        }

        private void btn_StopThread_Click(object sender, EventArgs e)
        {
            trackBar1.Enabled = true;
            ThreadsStop();

        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For Queens = " + (numOfQueens+1).ToString() + "\r\n" + "Number of Promising Checks: " + (numOfPromisingCheck+1).ToString() + "\r\nNumber of Promisings: " + (numOfPromising+1).ToString());
        }

    }
}
