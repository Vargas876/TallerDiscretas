// Form1.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoDiscretas
{
    public partial class Form1 : Form
    {
        // Time constants
        private const int SECONDS_PER_DAY = 24;
        private const int MORNING_HOUR = 6;
        private const int EVENING_HOUR = 18; // 6:00 PM

        // Temperature threshold
        private const double TEMP_THRESHOLD = 22.0;

        // Current simulation time
        private DateTime currentTime;

        // En Form1.cs, añade esto en el constructor después de InitializeComponent()
        public Form1()
        {
            InitializeComponent();
            InitializeSimulation();

          
        }

        private void InitializeSimulation()
        {
            // Set initial time to 12:00 PM
            currentTime = DateTime.Today.AddHours(12);
            UpdateTimeDisplay();

            // Start the timer
            timerClock.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            // Advance time by 1 hour for each second in real time
            currentTime = currentTime.AddHours(1);
            if (currentTime.Day > DateTime.Today.Day)
            {
                currentTime = DateTime.Today.AddHours(0); // Reset to midnight
            }

            UpdateTimeDisplay();
            UpdateActuatorStates();
        }

        private void UpdateTimeDisplay()
        {
            lblClock.Text = currentTime.ToString("HH:mm");
            lblCurrentTime.Text = "Hora actual: " + currentTime.ToString("HH:mm");
        }

        private void UpdateActuatorStates()
        {
            // Control lights in each room
            ControlLight(chkPresenciaComedor, lblLuzComedor);
            ControlLight(chkPresenciaSala, lblLuzSala);
            ControlLight(chkPresenciaCocina, lblLuzCocina);
            ControlLight(chkPresenciaHabitacion, lblLuzHabitacion);

            // Control air conditioning in each room
            ControlAC(numTempComedor, chkVentanaComedor, chkPuertaComedor, lblACComedor);
            ControlAC(numTempSala, chkVentanaSala, chkPuertaSala, lblACSala);
            ControlAC(numTempCocina, chkVentanaCocina, chkPuertaCocina, lblACCocina);
            ControlAC(numTempHabitacion, chkVentanaHabitacion, chkPuertaHabitacion, lblACHabitacion);
        }

        private void ControlLight(CheckBox presenceSensor, Label lightIndicator)
        {
            // Rule: If time is between 6:00 PM and 6:00 AM and presence is detected, turn on lights
            bool isNightTime = currentTime.Hour >= EVENING_HOUR || currentTime.Hour < MORNING_HOUR;
            bool isPresenceDetected = presenceSensor.Checked;

            if (isNightTime && isPresenceDetected)
            {
                lightIndicator.Text = "ON";
                lightIndicator.BackColor = Color.Yellow;
            }
            else
            {
                lightIndicator.Text = "OFF";
                lightIndicator.BackColor = Color.LightGray;
            }
        }

        private void ControlAC(NumericUpDown tempControl, CheckBox windowSensor, CheckBox doorSensor, Label acIndicator)
        {
            // Rule: If temperature > 22°C and doors and windows are closed, turn on AC
            double roomTemp = (double)tempControl.Value;
            bool isWindowClosed = !windowSensor.Checked; // Checked means open, unchecked means closed
            bool isDoorClosed = !doorSensor.Checked;    // Checked means open, unchecked means closed

            if (roomTemp > TEMP_THRESHOLD && isWindowClosed && isDoorClosed)
            {
                acIndicator.Text = "ON";
                acIndicator.BackColor = Color.LightBlue;
            }
            else
            {
                acIndicator.Text = "OFF";
                acIndicator.BackColor = Color.LightGray;
            }
        }

        // Event handlers for manual controls
        private void numTemp_ValueChanged(object sender, EventArgs e)
        {
            UpdateActuatorStates();
        }

        private void chkSensor_CheckedChanged(object sender, EventArgs e)
        {
            UpdateActuatorStates();
        }

      
    }
}