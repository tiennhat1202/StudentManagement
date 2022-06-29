﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void customizeDesign()
        {
            panel_stdsubmenu.Visible= false;
            panel_coursesubmenu.Visible= false;
            panel_scoresubmenu.Visible= false;
        }

        private void hideSubmenu()
        {
            if(panel_stdsubmenu.Visible == true)
               panel_stdsubmenu.Visible = false;
            if (panel_coursesubmenu.Visible == true)
                panel_coursesubmenu.Visible = false;
            if (panel_scoresubmenu.Visible == true)
                panel_scoresubmenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else 
                submenu.Visible = false;
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_stdsubmenu);
        }

        private void button_registration_Click(object sender, EventArgs e)
        {
            //hideSubmenu();
        }

        private void button_managestd_Click(object sender, EventArgs e)
        {
           // hideSubmenu();

        }

        private void button_status_Click(object sender, EventArgs e)
        {
           // hideSubmenu();

        }

        private void button_course_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_coursesubmenu);
        }

        private void button_newcourse_Click(object sender, EventArgs e)
        {
            //hideSubmenu();

        }

        private void button_managecourse_Click(object sender, EventArgs e)
        {
            //hideSubmenu();

        }

        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoresubmenu);
        }

        private void button_newscore_Click(object sender, EventArgs e)
        {
           // hideSubmenu();

        }

        private void button_managescore_Click(object sender, EventArgs e)
        {
           // hideSubmenu();

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            

        }

      
    }
}
