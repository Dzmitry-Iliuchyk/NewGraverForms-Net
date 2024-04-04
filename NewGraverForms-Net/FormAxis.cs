
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

namespace NewGraverForms_Net
{
    public partial class FormAxis : Form
    {
        private IBaseMarkerService service;

        public FormAxis(IBaseMarkerService service)
        {
            InitializeComponent();
            this.service = service;
            textBox_X_Coord.Text = service.GetCoordinateX();
            textBox_Y_Coord.Text = service.GetCoordinateY();
            X_Coord_Label_Value.Text = textBox_X_Coord.Text;
            Y_Coord_Label_Value.Text = textBox_Y_Coord.Text;
        }

        private void AcceptXY_Button_Click(object sender, EventArgs e)
        {
            try
            {
                service.MoveToCoordinateByX(float.Parse(textBox_X_Coord.Text));
                service.MoveToCoordinateByY(float.Parse(textBox_Y_Coord.Text));
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
            service.MoveToCoordinateByY(newCoordY);
            Y_Coord_Label_Value.Text = newCoordY.ToString();
            //Log.Information("Сдвиг по оси Y вниз");

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            int newCoordX = int.Parse(X_Coord_Label_Value.Text) - 1;
            service.MoveToCoordinateByX(newCoordX);
            X_Coord_Label_Value.Text = newCoordX.ToString();
            //Log.Information("Сдвиг по оси X влево");

        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            int newCoordX = int.Parse(X_Coord_Label_Value.Text) + 1;
            service.MoveToCoordinateByX(newCoordX);
            X_Coord_Label_Value.Text = newCoordX.ToString();
            //Log.Information("Сдвиг по оси X вправо");
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int newCoordY = int.Parse(Y_Coord_Label_Value.Text) + 1;
            service.MoveToCoordinateByY(newCoordY);
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
    }
}
