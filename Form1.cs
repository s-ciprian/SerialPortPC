using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SerialPortPC;

namespace SerialPortPC_App
{
    public partial class Form1 : Form
    {
        // Create a serial port instance
        private static SerialPort _serialPortPc = null;

        // Selected serial port from the GUI
        string selectedSerialPort = null;

        public Form1()
        {
            InitializeComponent();

            // Initialize a new serial port
            _serialPortPc = new SerialPort();
        }

        /// <summary>
        /// On button OpenComPort Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_OpenComPort_Click(object sender, EventArgs e)
        {
            // If serial port is closed, try to open it
            if (_serialPortPc.IsOpen == false)
            {
                try
                {
                    // Configure serial port
                    _serialPortPc.PortName = selectedSerialPort;
                    _serialPortPc.BaudRate = 115200;
                    _serialPortPc.DataBits = 8;
                    _serialPortPc.StopBits = StopBits.One;
                    _serialPortPc.Parity = Parity.None;

                    // Open serial port
                    _serialPortPc.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }

            // Update statu label text
            UpdateSerialPortStatusLable(_serialPortPc.IsOpen);
        }
        /// <summary>
        /// On button CloseComPort Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_CloseComPort_Click(object sender, EventArgs e)
        {
            if (_serialPortPc.IsOpen)
            {
                try
                {
                    _serialPortPc.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }

            // Update statu label text
            UpdateSerialPortStatusLable(_serialPortPc.IsOpen);
        }

        /// <summary>
        /// Update serial port status label
        /// </summary>
        /// <param name="status"></param>
        private void UpdateSerialPortStatusLable(bool status)
        {
            // Update serial port status label
            if (status)
            {
                label_PortStaus.Text = comboBox_ExisitingSerialPorts.Text + " is open";
            }
            else
            {
                label_PortStaus.Text = comboBox_ExisitingSerialPorts.Text + " is closed";
            }
        }

        /// <summary>
        /// When a new serial port was selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_ExisitingSerialPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSerialPort = (string)comboBox_ExisitingSerialPorts.SelectedItem;
        }

        /// <summary>
        /// Get exisiting serial ports on system and poulate a drop down list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_ExisitingSerialPorts_DropDown(object sender, EventArgs e)
        {
            string[] available_ports = null;

            try
            {
                // Get available COM ports
                available_ports = SerialPort.GetPortNames();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }

            // Clear drop down list
            comboBox_ExisitingSerialPorts.Items.Clear();

            if (available_ports != null)
            {
                // Add existing serial ports in the list
                foreach (string serial_port in available_ports)
                {
                    comboBox_ExisitingSerialPorts.Items.Add(serial_port);
                }
            }
        }
    }
}
