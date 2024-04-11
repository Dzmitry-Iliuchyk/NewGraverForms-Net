
using GraverLibrary.Models.Enums;
using GraverLibrary.Services;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraverLibrary.Services.Common;
using Microsoft.Extensions.Logging;

namespace NewGraverForms_Net
{
    public partial class FormAxis : Form
    {
        private readonly IBaseMarkerService _service;
        private readonly ILogger<FormAxis> _logger;

        public FormAxis(IBaseMarkerService service, ILogger<FormAxis> logger = null)
        {

            InitializeComponent();
            this._service = service;
            _logger = logger;


        }

        protected override void OnLoad(EventArgs e)
        {
            textBox_X_Coord.Text = _service.GetCoordinateX();
            textBox_Y_Coord.Text = _service.GetCoordinateY();
            X_Coord_Label_Value.Text = textBox_X_Coord.Text;
            Y_Coord_Label_Value.Text = textBox_Y_Coord.Text;
            base.OnLoad(e);
        }
        private async void AcceptXY_Button_Click(object sender, EventArgs e)
        {
            try
            {
                _service.MoveToCoordinateByX(float.Parse(textBox_X_Coord.Text));
                await Task.Delay(100);
                _service.MoveToCoordinateByY(float.Parse(textBox_Y_Coord.Text));
                X_Coord_Label_Value.Text = textBox_X_Coord.Text;
                Y_Coord_Label_Value.Text = textBox_Y_Coord.Text;
            }
            catch (Exception ex)
            {
                //Log.Error("Метод: " + ex.TargetSite);
                //Log.Error(ex.Message);
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int newCoordY = int.Parse(Y_Coord_Label_Value.Text) - 1;
            _service.MoveToCoordinateByY(newCoordY);
            Y_Coord_Label_Value.Text = newCoordY.ToString();
            //Log.Information("Сдвиг по оси Y вниз");

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            int newCoordX = int.Parse(X_Coord_Label_Value.Text) - 1;
            _service.MoveToCoordinateByX(newCoordX);
            X_Coord_Label_Value.Text = newCoordX.ToString();
            //Log.Information("Сдвиг по оси X влево");

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            int newCoordX = int.Parse(X_Coord_Label_Value.Text) + 1;
            _service.MoveToCoordinateByX(newCoordX);
            X_Coord_Label_Value.Text = newCoordX.ToString();
            //Log.Information("Сдвиг по оси X вправо");
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int newCoordY = int.Parse(Y_Coord_Label_Value.Text) + 1;
            _service.MoveToCoordinateByY(newCoordY);
            Y_Coord_Label_Value.Text = newCoordY.ToString();
            //Log.Information("Сдвиг по оси Y вверх");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Up:
                    buttonUp.PerformClick();
                    break;
                case Keys.Down:
                    buttonDown.PerformClick();
                    break;
                case Keys.Left:
                    buttonLeft.PerformClick();
                    break;
                case Keys.Right:
                    buttonRight.PerformClick();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void buttonCheckCoord_Click(object sender, EventArgs e)
        {
            var X = _service.GetCoordinateX();
            var Y = _service.GetCoordinateY();
            X_Coord_Label_Value.ResetText();
            X_Coord_Label_Value.Text = X.ToString();
            Y_Coord_Label_Value.ResetText();
            Y_Coord_Label_Value.Text = Y;
        }
    }
}
