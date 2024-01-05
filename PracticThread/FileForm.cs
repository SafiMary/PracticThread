using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using static PracticThread.FileForm;

namespace PracticThread
{
    public partial class FileForm : Form
    {
        List<Thread> threads;// массив потоков, будет заполняться в зависимости сколько укажет пользователь
        string fileName;// имя файла, который будет скопирован
        string newPathFile;// путь куда будет скопирован, выбранный пользователем файл
        MyParam myParam;//экзмепляр класса с параметрами
        int CountThread;//счетчик потоков
        public FileForm()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "Zip files(*.zip)| *.zip |Png files(*.png)| *.png |Bitmap files(*.bmp)| *.bmp | Image files(*.jpg) | *.jpg| Text files(*.txt)|*.txt|All files(*.*)|*.*";
            numericUpCount.Minimum = 1;
            numericUpCount.Maximum = 100;
            progressBarProcess.Step = 100;
        }
       
        private void pictureBoxfrom_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                newPathFile = saveFileDialog1.FileName;
            }
        }

        private void Copy_MyFile(int CountThread)
        {

            myParam = new MyParam(fileName, newPathFile, true);//создали экземляр класса с параметрами
            threads = new List<Thread>(CountThread);//создали лист с потоками размером, указанным пользователем

            for (int i = 0; i < CountThread; i++) // экземпляров Thread
            {
                threads.Add(new Thread(new ThreadStart(myParam.MethodCopy)));//создаем потоки по кол-ву пользователя, передаем наш метод

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

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Copy_MyFile(CountThread);

        }

        private void numericUpCount_ValueChanged(object sender, EventArgs e)
        {
            CountThread = (int)numericUpCount.Value;
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


    }
}
 
    

