﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _01Basic
{
    public partial class winform : Form
    {
        private SerialPort seiralPort = new SerialPort();

        public winform()
        {
            InitializeComponent();
        }

        private void PortNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("HELLO WORLD");
            //Console.WriteLine("sender : " + sender);
            //Console.WriteLine("EventArgs : " + e);
            ComboBox cb = (ComboBox)sender;
            Console.Write("Selected Idx : " + cb.SelectedIndex);
            Console.WriteLine(" Selected Value : " + cb.Items[cb.SelectedIndex]);
        }

        private void SerialPort_DataRecv(object sender, SerialDataReceivedEventArgs e)
        {
            String recvData = this.seiralPort.ReadExisting();
            Console.Write(recvData);
        }

        private void conn_btn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Conn_btn click : " + this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString());
            try
            {
                this.seiralPort.PortName = this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString();
                this.seiralPort.BaudRate = 9600;
                this.seiralPort.DataBits = 8;
                this.seiralPort.StopBits = System.IO.Ports.StopBits.One;
                this.seiralPort.Parity = System.IO.Ports.Parity.None;
                this.seiralPort.Open();
                Console.WriteLine(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString() + " CONNECTION SUCCESS");
                this.seiralPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataRecv);
            } catch(Exception ex) {
                Console.WriteLine(this.PortNumber.Items[this.PortNumber.SelectedIndex].ToString() + " CONNECTION FAIL");
                this.seiralPort.Close();
            }
        }

        private void led01On_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED01_ON Clicked!");
            if (seiralPort.IsOpen)
            {
                seiralPort.Write("0");
                this.textArea.Text = "";
                this.textArea.AppendText("LED01_ON SUCCESS" + "\r\n");
            }
            else 
            {
                Console.WriteLine("포트가 열리지 않았습니다.");
                this.textArea.Text = "";
                this.textArea.AppendText("LED01_ON FAIL" + "\r\n");
            }
        }

        private void led02On_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED02_ON Clicked!");
            if (seiralPort.IsOpen)
            {
                seiralPort.Write("2");
                this.textArea.Text = "";
                this.textArea.AppendText("LED02_ON SUCCESS" + "\r\n");
            }
            else
            {
                Console.WriteLine("포트가 열리지 않았습니다.");
                this.textArea.Text = "";
                this.textArea.AppendText("LED02_ON FAIL" + "\r\n");
            }
        }

        private void led01Off_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED01_OFF Clicked!");
            if (seiralPort.IsOpen)
            {
                seiralPort.Write("1");
                this.textArea.Text = "";
                this.textArea.AppendText("LED01_OFF SUCCESS" + "\r\n");
            }
            else
            {
                Console.WriteLine("포트가 열리지 않았습니다.");
                this.textArea.Text = "";
                this.textArea.AppendText("LED01_OFF FAIL" + "\r\n");
            }
        }

        private void led02Off_Click(object sender, EventArgs e)
        {
            Console.WriteLine("LED02_OFF Clicked!");
            if (seiralPort.IsOpen)
            {
                seiralPort.Write("3");
                this.textArea.Text = "";
                this.textArea.AppendText("LED02_OFF SUCCESS" + "\r\n");
            }
            else
            {
                Console.WriteLine("포트가 열리지 않았습니다.");
                this.textArea.Text = "";
                this.textArea.AppendText("LED02_OFF FAIL" + "\r\n");
            }
        }
    }
}
