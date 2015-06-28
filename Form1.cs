using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Threading;
using Parse;

namespace windowsParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ParseObject gameScore = new ParseObject("GameScore");
            //gameScore["score"] = 1337;
            //gameScore["playerName"] = "Sean Plott";
            //await gameScore.SaveAsync();
            /*
            int number = 42;
            string str = "the number is " + number;
            DateTime date = DateTime.Now;
            byte[] data = System.Text.Encoding.UTF8.GetBytes("foo");
            IList<object> list = new List<object> { str, number };
            IDictionary<string, object> dictionary = new Dictionary<string, object>
            {
                { "number", number },
                { "string", str }
            };

            var bigObject = new ParseObject("BigObject");
            bigObject["myNumber"] = number;
            bigObject["myString"] = str;
            bigObject["myDate"] = date;
            bigObject["myData"] = data;
            bigObject["myList"] = list;
            bigObject["myDictionary"] = dictionary;
            await bigObject.SaveAsync();
             */ 
        }

        //private async void button_SyncStart_Click(object sender, EventArgs e)
        //{
        //    label1.Text = "";
        //    label2.Text = "";
        //    var mainTask = new Task<long>(Sum);
        //    mainTask.Start();
        //    await mainTask;
        //    label1.Text = mainTask.Result.ToString();
        //    label2.Text = "任務完成";
        //}
        //private long Sum()
        //{
        //    long sum = 0;
        //    for (int i = 0; i < 200; i++)
        //    {
        //        sum++;
        //    }
        //    SpinWait.SpinUntil(() => false, 10000);
        //    return sum;
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            SaveAsync();
        }



        protected async void SaveAsync()
        {
            ParseObject gameScore = new ParseObject("GameScore");
            gameScore["score"] = 1337;
            gameScore["playerName"] = "Sean Plott";
            await gameScore.SaveAsync();                    
        }
    }

}
