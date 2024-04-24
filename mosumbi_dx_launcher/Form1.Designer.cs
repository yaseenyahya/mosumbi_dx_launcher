
namespace mosumbi_dx_launcher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_dwm_on = new System.Windows.Forms.Button();
            this.bt_dwm_off = new System.Windows.Forms.Button();
            this.bt_run = new System.Windows.Forms.Button();
            this.tb_run = new System.Windows.Forms.TextBox();
            this.tmr_restore = new System.Windows.Forms.Timer(this.components);
            this.tb_console = new System.Windows.Forms.TextBox();
            this.ch_win11_mouse = new System.Windows.Forms.CheckBox();
            this.ch_win11_login = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_launch_mosumbi_control = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_dwm_on
            // 
            this.bt_dwm_on.Location = new System.Drawing.Point(12, 43);
            this.bt_dwm_on.Name = "bt_dwm_on";
            this.bt_dwm_on.Size = new System.Drawing.Size(260, 24);
            this.bt_dwm_on.TabIndex = 0;
            this.bt_dwm_on.Text = "Enable DWM";
            this.bt_dwm_on.UseVisualStyleBackColor = true;
            this.bt_dwm_on.Click += new System.EventHandler(this.bt_dwm_on_Click);
            // 
            // bt_dwm_off
            // 
            this.bt_dwm_off.Location = new System.Drawing.Point(12, 73);
            this.bt_dwm_off.Name = "bt_dwm_off";
            this.bt_dwm_off.Size = new System.Drawing.Size(260, 24);
            this.bt_dwm_off.TabIndex = 1;
            this.bt_dwm_off.Text = "Disable DWM";
            this.bt_dwm_off.UseVisualStyleBackColor = true;
            this.bt_dwm_off.Click += new System.EventHandler(this.bt_dwm_off_Click);
            // 
            // bt_run
            // 
            this.bt_run.Location = new System.Drawing.Point(88, 103);
            this.bt_run.Name = "bt_run";
            this.bt_run.Size = new System.Drawing.Size(56, 22);
            this.bt_run.TabIndex = 3;
            this.bt_run.Text = "Run";
            this.bt_run.UseVisualStyleBackColor = true;
            this.bt_run.Click += new System.EventHandler(this.bt_run_Click);
            // 
            // tb_run
            // 
            this.tb_run.Location = new System.Drawing.Point(12, 128);
            this.tb_run.Name = "tb_run";
            this.tb_run.Size = new System.Drawing.Size(260, 20);
            this.tb_run.TabIndex = 4;
            this.tb_run.Text = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe";
            // 
            // tmr_restore
            // 
            this.tmr_restore.Interval = 5000;
            this.tmr_restore.Tick += new System.EventHandler(this.tmr_restore_Tick);
            // 
            // tb_console
            // 
            this.tb_console.BackColor = System.Drawing.Color.White;
            this.tb_console.Location = new System.Drawing.Point(329, 12);
            this.tb_console.Multiline = true;
            this.tb_console.Name = "tb_console";
            this.tb_console.ReadOnly = true;
            this.tb_console.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_console.Size = new System.Drawing.Size(243, 61);
            this.tb_console.TabIndex = 5;
            this.tb_console.TabStop = false;
            // 
            // ch_win11_mouse
            // 
            this.ch_win11_mouse.AutoSize = true;
            this.ch_win11_mouse.Location = new System.Drawing.Point(329, 78);
            this.ch_win11_mouse.Name = "ch_win11_mouse";
            this.ch_win11_mouse.Size = new System.Drawing.Size(190, 17);
            this.ch_win11_mouse.TabIndex = 6;
            this.ch_win11_mouse.Text = "Windows 11 Mouse fix (dwminit.dll)";
            this.ch_win11_mouse.UseVisualStyleBackColor = true;
            // 
            // ch_win11_login
            // 
            this.ch_win11_login.AutoSize = true;
            this.ch_win11_login.Location = new System.Drawing.Point(329, 101);
            this.ch_win11_login.Name = "ch_win11_login";
            this.ch_win11_login.Size = new System.Drawing.Size(240, 17);
            this.ch_win11_login.TabIndex = 6;
            this.ch_win11_login.Text = "Windows 11 Login fix (Windows.UI.Logon.dll)";
            this.ch_win11_login.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Browser Path";
            // 
            // btn_launch_mosumbi_control
            // 
            this.btn_launch_mosumbi_control.Location = new System.Drawing.Point(12, 13);
            this.btn_launch_mosumbi_control.Name = "btn_launch_mosumbi_control";
            this.btn_launch_mosumbi_control.Size = new System.Drawing.Size(260, 24);
            this.btn_launch_mosumbi_control.TabIndex = 8;
            this.btn_launch_mosumbi_control.Text = "Launch Mosumbi Control";
            this.btn_launch_mosumbi_control.UseVisualStyleBackColor = true;
            this.btn_launch_mosumbi_control.Click += new System.EventHandler(this.btn_launch_mosumbi_control_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.btn_launch_mosumbi_control);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ch_win11_login);
            this.Controls.Add(this.ch_win11_mouse);
            this.Controls.Add(this.tb_console);
            this.Controls.Add(this.tb_run);
            this.Controls.Add(this.bt_run);
            this.Controls.Add(this.bt_dwm_off);
            this.Controls.Add(this.bt_dwm_on);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mosumbi Dx Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_dwm_on;
        private System.Windows.Forms.Button bt_dwm_off;
        private System.Windows.Forms.Button bt_run;
        private System.Windows.Forms.TextBox tb_run;
        private System.Windows.Forms.Timer tmr_restore;
        private System.Windows.Forms.TextBox tb_console;
        private System.Windows.Forms.CheckBox ch_win11_mouse;
        private System.Windows.Forms.CheckBox ch_win11_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_launch_mosumbi_control;
    }
}

