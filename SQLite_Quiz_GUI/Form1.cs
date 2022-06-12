using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using QuezLib;
namespace SQLite_Quiz_GUI
{
    public partial class Form1 : Form
    {
        Random rndm;
        List <Question> questions = new List<Question>();
        List<Answer> answers = new List<Answer>();
        Question currentQestion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rndm = new Random();
            currentQestion = new Question();
            GetQuestions();
            ShowQuestion();
            LoadAnswers();
            ShowAnswers();
        }

        private void ShowQuestion() 
        {
            currentQestion = questions[rndm.Next(3)];
            label_Question.Text = currentQestion.Qstn;
           
        }
        private void ShowAnswers() 
        {
            radioButton_A.Text = answers[0].Ansr;
            radioButton_B.Text = answers[1].Ansr;
            radioButton_C.Text = answers[2].Ansr;
            radioButton_D.Text = "Something else";
            radioButton_A.Tag = questions[0].Correct;
            radioButton_B.Tag = questions[1].Correct;
            radioButton_C.Tag = questions[2].Correct;
            radioButton_D.Tag = 5;
        }
        private void LoadAnswers() 
        {
            const string CSTRING = @"Data Source=C:\Users\User\Desktop\MultichoicesQuiz.db;Version=3";
            using (SQLiteConnection conn = new SQLiteConnection(CSTRING))
            {
                conn.Open();



                string cmd = string.Format("select * from Answers");
                using (SQLiteCommand sql_cmd = new SQLiteCommand(cmd, conn))
                {
                    using (SQLiteDataReader rdr = sql_cmd.ExecuteReader())
                    {
                       
                        while (rdr.Read())
                        {
                            Answer a = new Answer();
                            a.Aid = rdr.GetInt32(0);
                            a.Qid = rdr.GetInt32(1);
                            a.Id = rdr.GetInt32(2);
                            a.Ansr = rdr.GetString(3);
                            // LabelAnswers(counter).Text = rdr.GetString(0);
                            answers.Add(a);
                           
                        }
                        rdr.Close();
                    }
                }




                conn.Close();
            }
        }
      

        private void GetQuestions()
        {
            const string CSTRING = @"Data Source=C:\Users\User\Desktop\MultichoicesQuiz.db;Version=3";
            using (SQLiteConnection conn = new SQLiteConnection(CSTRING))
            {
                conn.Open();

               
               
                    string cmd = string.Format("select * from Questions");
                    using (SQLiteCommand sql_cmd = new SQLiteCommand(cmd, conn))
                    {
                        using (SQLiteDataReader rdr = sql_cmd.ExecuteReader())
                        {
                       
                            while (rdr.Read())
                            {
                                Question q = new Question();
                                
                                q.Qid = rdr.GetInt32(0);
                                q.Qstn=rdr.GetString(1);
                                q.Correct = rdr.GetInt32(2);
                                questions.Add(q);
                               
                            }
                            rdr.Close();
                        }
                    }

                
                

                conn.Close();
            }
        }

        private void button_NewQuestion_Click(object sender, EventArgs e)
        {
                        
            
        }

        private void button_check_Click(object sender, EventArgs e)
        {
            if (radioButton_A.Checked)
            {
                if (((int)radioButton_A.Tag == currentQestion.Correct))
                    MessageBox.Show("Correct");
                else
                    MessageBox.Show("Wrong");
                
              
            }
            else if (radioButton_B.Checked)
            {
                if (((int)radioButton_B.Tag == currentQestion.Correct))
                    MessageBox.Show("Correct");
                else
                    MessageBox.Show("Wrong");
            }
            else if (radioButton_C.Checked)
            {
                if (((int)radioButton_C.Tag == currentQestion.Correct))
                    MessageBox.Show("Correct");
                else
                    MessageBox.Show("Wrong");
            }
            else if (radioButton_D.Checked)
            {
                if (((int)radioButton_D.Tag == 4))
                    MessageBox.Show("Correct");
                else
                    MessageBox.Show("Wrong");
            }
            else 
            {
                MessageBox.Show("Choose your answer!");
            }



        }
        
        private RadioButton RadioButtonList(int i) 
        {
            List<RadioButton> radioButtons = new List<RadioButton>();
            radioButtons.Add(radioButton_A);
            radioButtons.Add(radioButton_B);
            radioButtons.Add(radioButton_C);
            radioButtons.Add(radioButton_D);

            return radioButtons[i];
        }
    }
}
