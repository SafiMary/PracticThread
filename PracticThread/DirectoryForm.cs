using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PracticThread.FileForm;

namespace PracticThread
{
    public partial class DirectoryForm : Form
    {
        List<Thread> threads;// массив потоков, будет заполняться в зависимости сколько укажет пользователь
        string DirName;// имя каталога, который будет скопирован
        string newPathDir;// путь куда будет скопирован каталог, выбранный пользователем 
        int CountThread;//счетчик потоков
        
        public DirectoryForm()
        {
            InitializeComponent();
            numericUpCount.Minimum = 1;
            numericUpCount.Maximum = 100;
            progressBarProcess.Step = 100;

        }

        private void pictureBoxFrom_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    DirName = fbd.SelectedPath;
                }
            }
           
        }

        private void pictureBoxTo_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    newPathDir = fbd.SelectedPath;

                }
            }
        }

        private void numericUpCount_ValueChanged(object sender, EventArgs e)
        {
            CountThread = (int)numericUpCount.Value;
        }

        public void MethodCopy()
        { 
            CopyDir.Copy(DirName,newPathDir);
        }
            private void buttonCopy_Click(object sender, EventArgs e)
        {
            threads = new List<Thread>(CountThread);//создали лист с потоками размером, указанным пользователем

            for (int i = 0; i < CountThread; i++) // экземпляров Thread
            {
                threads.Add(new Thread(new ThreadStart(MethodCopy)));//создаем потоки по кол-ву пользователя, передаем наш метод

            }
            for (int i = 0; i < CountThread; i++) // экземпляров Thread
            {
                threads[i].Start();//запускаем потоки
                
            }
            progressBarProcess.PerformStep();
       
            for (int i = 0; i < CountThread; i++) // экземпляров Thread
            {
                threads[i].Abort();//останавливаем потоки
            }
        }
        [Obsolete]
        private void buttonResume_Click(object sender, EventArgs e)//возобновление
        {
            foreach (Thread item in threads)
            {
                if (item.ThreadState == ThreadState.Suspended)
                    item.Suspend();
            }

        }
        [Obsolete]
        private void buttonAbort_Click(object sender, EventArgs e)// завершение
        {
            progressBarProcess.Value = 0;
            foreach (Thread item in threads)
            {
                if (item.IsAlive)
                    item.Abort();
            }
        }
        [Obsolete]
        private void buttonSuspend_Click(object sender, EventArgs e)// приостановка
        {
            foreach (Thread item in threads)
            {
                if (item.IsAlive)
                    item.Suspend();
            }
        }

    }
    }
