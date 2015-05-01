using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Kinect;

namespace BrainTrainingApp
{
    public partial class Form1 : Form
    {
        public int qNum;
        public float answerTime = 0;
        public HandState handState;

        KinectSensor kinect;
        BodyFrameReader bodyFrameReader;


        Body[] bodies;



        public Form1()
        {
            InitializeComponent();
           
        }


        private void Form1_Loaded(object sender, EventArgs e)
        {
            try
            {
                kinect = KinectSensor.GetDefault();
                if (kinect == null)
                {
                    throw new Exception("Kinectを開けません");
                }

                kinect.Open();

                // Bodyを入れる配列を作る
                bodies = new Body[kinect.BodyFrameSource.BodyCount];

                // ボディーリーダーを開く
                bodyFrameReader = kinect.BodyFrameSource.OpenReader();
                bodyFrameReader.FrameArrived += bodyFrameReader_FrameArrived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (bodyFrameReader != null)
            {
                bodyFrameReader.Dispose();
                bodyFrameReader = null;
            }

            if (kinect != null)
            {
                kinect.Close();
                kinect = null;
            }
        }

        // ボディの更新
        private void UpdateBodyFrame(BodyFrameArrivedEventArgs e)
        {
            using (var bodyFrame = e.FrameReference.AcquireFrame())
            {
                if (bodyFrame == null)
                {
                    return;
                }


                bodyFrame.GetAndRefreshBodyData(bodies);
                updateHandState(bodies);
            }
        }


        //手の情報（グー・チョキ・パー）の更新
        public void updateHandState(Body[] bodies)
        {
            foreach (var body in bodies.Where(b => b.IsTracked))
            {
                foreach (var joint in body.Joints)
                {
                    if (joint.Value.TrackingState == TrackingState.Tracked)
                    {
                        if (joint.Value.JointType == JointType.HandRight)
                        {
                            handState = body.HandRightState;

                        }

                    }

                }

            }
        }

        //クリックイベント

        private void startButton_Click_1(object sender, EventArgs e)
        {


            qNum = 1;

            QNumLabel.Text = qNum.ToString();


            foreach (var body in bodies.Where(b => b.IsTracked))
            {
                foreach (var joint in body.Joints)
                {
                    if (joint.Value.TrackingState == TrackingState.Tracked)
                    {
                        if (joint.Value.JointType == JointType.HandRight)
                        {
                            //decideWinOrLose();
                            decideQuestion();

                        }
                        else if (joint.Value.TrackingState == TrackingState.Inferred)
                        {
                            MessageBox.Show("手の平をしっかりと、カメラに向けてください。");
                        }

                    }
                }
            }



            // TimeSpan startTime = DateTime.Now.TimeOfDay;
            //Console.Write(startTime);

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            qNum++;

            QNumLabel.Text = qNum.ToString();


            //ここはリファクタリングしたい
            decideQuestion();
            //decideWinOrLose();

            if (qNum > 20)
            {
                // TimeSpan endTime = DateTime.Now.TimeOfDay;
                //TimeSpan startTime;

                //TimeSpan recordTime = endTime - startTime;

                MessageBox.Show("Finish!!");
                //MessageBox.Show(recordTime.ToString("ss"));



            }
        }


        //出題する問題を決定する

        private void decideQuestion()
        {

            Random nRandom = new System.Random();


            float handNum = nRandom.Next(3);
            double handNumFloor = Math.Floor(handNum);


            if (handNumFloor == 0)
            {
                handPictureBox.Image = BrainTrainingApp.Properties.Resources.rock;
                Console.Write(handState);

                while (handState != HandState.Open)
                {
                    MessageBox.Show("外れ！");
                }

                //handStateTimer.Stop();
                nextButton.PerformClick();

            }
            else if (handNumFloor == 1)
            {
                handPictureBox.Image = BrainTrainingApp.Properties.Resources.paper;
                Console.Write(handState);

                while (handState != HandState.Lasso)
                {
                    MessageBox.Show("外れ！");
                }

                handStateTimer.Stop();
                nextButton.PerformClick();


            }
            else
            {
                handPictureBox.Image = BrainTrainingApp.Properties.Resources.scissors;
                Console.Write(handState);

                while (handState != HandState.Closed)
                {
                    MessageBox.Show("外れ！");
                }

                //handStateTimer.Stop();
                nextButton.PerformClick();
            }

        }



        /*
        private void decideWinOrLose()
        {
            Random wOrLRandom = new System.Random();

            float wOrLNum = wOrLRandom.Next(2);
            double wOrLNumFloor = Math.Floor(wOrLNum);


            if (wOrLNumFloor == 0)
            {
                winOrLoseLabel.Text = "勝";

            }
            else
            {
                winOrLoseLabel.Text = "負";
            }
        }
        */


        //身体が動くたびに、働くメソッド

        void bodyFrameReader_FrameArrived(object sender, BodyFrameArrivedEventArgs e)
        {
            UpdateBodyFrame(e);
        }


        

        /*
        private void updateHandStateTimer()
        {
            handStateTimer.Interval = 1000;
            handStateTimer.Start();
        }

        private void handStateTimer_Tick(object sender, EventArgs e)
        {
            updateHandState();
        }
        */
    }

}

