namespace Testes
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
            this.Leest = new System.Windows.Forms.ListBox();
            this.remove = new System.Windows.Forms.Button();
            this.addtem = new System.Windows.Forms.Button();
            this.addply = new System.Windows.Forms.Button();
            this.txttmcntry = new System.Windows.Forms.TextBox();
            this.txttmcity = new System.Windows.Forms.TextBox();
            this.txtplynum = new System.Windows.Forms.TextBox();
            this.txtplynam = new System.Windows.Forms.TextBox();
            this.txttmname = new System.Windows.Forms.TextBox();
            this.cmbpos = new System.Windows.Forms.ComboBox();
            this.cmbteam = new System.Windows.Forms.ComboBox();
            this.cmbcntry = new System.Windows.Forms.ComboBox();
            this.lblchscountry = new System.Windows.Forms.Label();
            this.lblchsteam = new System.Windows.Forms.Label();
            this.lbladdteam = new System.Windows.Forms.Label();
            this.lbltmname = new System.Windows.Forms.Label();
            this.lbltmcountry = new System.Windows.Forms.Label();
            this.lbltmcity = new System.Windows.Forms.Label();
            this.lbladdplayer = new System.Windows.Forms.Label();
            this.lblplynam = new System.Windows.Forms.Label();
            this.lblplynum = new System.Windows.Forms.Label();
            this.lblplypos = new System.Windows.Forms.Label();
            this.lblteamlist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Leest
            // 
            this.Leest.FormattingEnabled = true;
            this.Leest.ItemHeight = 16;
            this.Leest.Location = new System.Drawing.Point(31, 204);
            this.Leest.Name = "Leest";
            this.Leest.Size = new System.Drawing.Size(249, 148);
            this.Leest.TabIndex = 45;
            this.Leest.SelectedIndexChanged += new System.EventHandler(this.lbox_SelectedIndexChanged);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(31, 368);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(75, 23);
            this.remove.TabIndex = 44;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // addtem
            // 
            this.addtem.Location = new System.Drawing.Point(381, 259);
            this.addtem.Name = "addtem";
            this.addtem.Size = new System.Drawing.Size(75, 23);
            this.addtem.TabIndex = 43;
            this.addtem.Text = "Add";
            this.addtem.UseVisualStyleBackColor = true;
            this.addtem.Click += new System.EventHandler(this.addtem_Click);
            // 
            // addply
            // 
            this.addply.Location = new System.Drawing.Point(648, 259);
            this.addply.Name = "addply";
            this.addply.Size = new System.Drawing.Size(75, 23);
            this.addply.TabIndex = 42;
            this.addply.Text = "Add";
            this.addply.UseVisualStyleBackColor = true;
            // 
            // txttmcntry
            // 
            this.txttmcntry.Location = new System.Drawing.Point(381, 151);
            this.txttmcntry.Name = "txttmcntry";
            this.txttmcntry.Size = new System.Drawing.Size(100, 22);
            this.txttmcntry.TabIndex = 41;
            // 
            // txttmcity
            // 
            this.txttmcity.Location = new System.Drawing.Point(381, 204);
            this.txttmcity.Name = "txttmcity";
            this.txttmcity.Size = new System.Drawing.Size(100, 22);
            this.txttmcity.TabIndex = 40;
            // 
            // txtplynum
            // 
            this.txtplynum.Location = new System.Drawing.Point(648, 153);
            this.txtplynum.Name = "txtplynum";
            this.txtplynum.Size = new System.Drawing.Size(100, 22);
            this.txtplynum.TabIndex = 39;
            // 
            // txtplynam
            // 
            this.txtplynam.Location = new System.Drawing.Point(648, 100);
            this.txtplynam.Name = "txtplynam";
            this.txtplynam.Size = new System.Drawing.Size(100, 22);
            this.txtplynam.TabIndex = 38;
            // 
            // txttmname
            // 
            this.txttmname.Location = new System.Drawing.Point(381, 98);
            this.txttmname.Name = "txttmname";
            this.txttmname.Size = new System.Drawing.Size(100, 22);
            this.txttmname.TabIndex = 37;
            // 
            // cmbpos
            // 
            this.cmbpos.FormattingEnabled = true;
            this.cmbpos.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.cmbpos.Location = new System.Drawing.Point(648, 204);
            this.cmbpos.Name = "cmbpos";
            this.cmbpos.Size = new System.Drawing.Size(121, 24);
            this.cmbpos.TabIndex = 36;
            // 
            // cmbteam
            // 
            this.cmbteam.FormattingEnabled = true;
            this.cmbteam.Location = new System.Drawing.Point(145, 151);
            this.cmbteam.Name = "cmbteam";
            this.cmbteam.Size = new System.Drawing.Size(121, 24);
            this.cmbteam.TabIndex = 35;
            this.cmbteam.SelectedIndexChanged += new System.EventHandler(this.Choosing);
            // 
            // cmbcntry
            // 
            this.cmbcntry.FormattingEnabled = true;
            this.cmbcntry.Location = new System.Drawing.Point(145, 98);
            this.cmbcntry.Name = "cmbcntry";
            this.cmbcntry.Size = new System.Drawing.Size(121, 24);
            this.cmbcntry.TabIndex = 34;
            this.cmbcntry.SelectedIndexChanged += new System.EventHandler(this.cmbcntry_SelectedIndexChanged);
            this.cmbcntry.SelectionChangeCommitted += new System.EventHandler(this.cosingcont);
            // 
            // lblchscountry
            // 
            this.lblchscountry.AutoSize = true;
            this.lblchscountry.Location = new System.Drawing.Point(31, 98);
            this.lblchscountry.Name = "lblchscountry";
            this.lblchscountry.Size = new System.Drawing.Size(108, 16);
            this.lblchscountry.TabIndex = 33;
            this.lblchscountry.Text = "Choose Country: ";
            // 
            // lblchsteam
            // 
            this.lblchsteam.AutoSize = true;
            this.lblchsteam.Location = new System.Drawing.Point(31, 151);
            this.lblchsteam.Name = "lblchsteam";
            this.lblchsteam.Size = new System.Drawing.Size(99, 16);
            this.lblchsteam.TabIndex = 32;
            this.lblchsteam.Text = "Choose Team: ";
            // 
            // lbladdteam
            // 
            this.lbladdteam.AutoSize = true;
            this.lbladdteam.Location = new System.Drawing.Point(286, 59);
            this.lbladdteam.Name = "lbladdteam";
            this.lbladdteam.Size = new System.Drawing.Size(89, 16);
            this.lbladdteam.TabIndex = 31;
            this.lbladdteam.Text = "Adding Team";
            // 
            // lbltmname
            // 
            this.lbltmname.AutoSize = true;
            this.lbltmname.Location = new System.Drawing.Point(286, 98);
            this.lbltmname.Name = "lbltmname";
            this.lbltmname.Size = new System.Drawing.Size(89, 16);
            this.lbltmname.TabIndex = 30;
            this.lbltmname.Text = "Team Name: ";
            // 
            // lbltmcountry
            // 
            this.lbltmcountry.AutoSize = true;
            this.lbltmcountry.Location = new System.Drawing.Point(286, 151);
            this.lbltmcountry.Name = "lbltmcountry";
            this.lbltmcountry.Size = new System.Drawing.Size(97, 16);
            this.lbltmcountry.TabIndex = 29;
            this.lbltmcountry.Text = "Team Country: ";
            // 
            // lbltmcity
            // 
            this.lbltmcity.AutoSize = true;
            this.lbltmcity.Location = new System.Drawing.Point(286, 204);
            this.lbltmcity.Name = "lbltmcity";
            this.lbltmcity.Size = new System.Drawing.Size(74, 16);
            this.lbltmcity.TabIndex = 28;
            this.lbltmcity.Text = "Team City: ";
            // 
            // lbladdplayer
            // 
            this.lbladdplayer.AutoSize = true;
            this.lbladdplayer.Location = new System.Drawing.Point(539, 59);
            this.lbladdplayer.Name = "lbladdplayer";
            this.lbladdplayer.Size = new System.Drawing.Size(99, 16);
            this.lbladdplayer.TabIndex = 27;
            this.lbladdplayer.Text = "Adding Players";
            // 
            // lblplynam
            // 
            this.lblplynam.AutoSize = true;
            this.lblplynam.Location = new System.Drawing.Point(539, 98);
            this.lblplynam.Name = "lblplynam";
            this.lblplynam.Size = new System.Drawing.Size(92, 16);
            this.lblplynam.TabIndex = 26;
            this.lblplynam.Text = "Player Name: ";
            // 
            // lblplynum
            // 
            this.lblplynum.AutoSize = true;
            this.lblplynum.Location = new System.Drawing.Point(539, 151);
            this.lblplynum.Name = "lblplynum";
            this.lblplynum.Size = new System.Drawing.Size(103, 16);
            this.lblplynum.TabIndex = 25;
            this.lblplynum.Text = "Player Number: ";
            // 
            // lblplypos
            // 
            this.lblplypos.AutoSize = true;
            this.lblplypos.Location = new System.Drawing.Point(539, 204);
            this.lblplypos.Name = "lblplypos";
            this.lblplypos.Size = new System.Drawing.Size(103, 16);
            this.lblplypos.TabIndex = 24;
            this.lblplypos.Text = "Player Position: ";
            // 
            // lblteamlist
            // 
            this.lblteamlist.AutoSize = true;
            this.lblteamlist.Location = new System.Drawing.Point(31, 59);
            this.lblteamlist.Name = "lblteamlist";
            this.lblteamlist.Size = new System.Drawing.Size(112, 16);
            this.lblteamlist.TabIndex = 23;
            this.lblteamlist.Text = "Soccer Team List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Leest);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.addtem);
            this.Controls.Add(this.addply);
            this.Controls.Add(this.txttmcntry);
            this.Controls.Add(this.txttmcity);
            this.Controls.Add(this.txtplynum);
            this.Controls.Add(this.txtplynam);
            this.Controls.Add(this.txttmname);
            this.Controls.Add(this.cmbpos);
            this.Controls.Add(this.cmbteam);
            this.Controls.Add(this.cmbcntry);
            this.Controls.Add(this.lblchscountry);
            this.Controls.Add(this.lblchsteam);
            this.Controls.Add(this.lbladdteam);
            this.Controls.Add(this.lbltmname);
            this.Controls.Add(this.lbltmcountry);
            this.Controls.Add(this.lbltmcity);
            this.Controls.Add(this.lbladdplayer);
            this.Controls.Add(this.lblplynam);
            this.Controls.Add(this.lblplynum);
            this.Controls.Add(this.lblplypos);
            this.Controls.Add(this.lblteamlist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Leest;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button addtem;
        private System.Windows.Forms.Button addply;
        private System.Windows.Forms.TextBox txttmcntry;
        private System.Windows.Forms.TextBox txttmcity;
        private System.Windows.Forms.TextBox txtplynum;
        private System.Windows.Forms.TextBox txtplynam;
        private System.Windows.Forms.TextBox txttmname;
        private System.Windows.Forms.ComboBox cmbpos;
        private System.Windows.Forms.ComboBox cmbteam;
        private System.Windows.Forms.ComboBox cmbcntry;
        private System.Windows.Forms.Label lblchscountry;
        private System.Windows.Forms.Label lblchsteam;
        private System.Windows.Forms.Label lbladdteam;
        private System.Windows.Forms.Label lbltmname;
        private System.Windows.Forms.Label lbltmcountry;
        private System.Windows.Forms.Label lbltmcity;
        private System.Windows.Forms.Label lbladdplayer;
        private System.Windows.Forms.Label lblplynam;
        private System.Windows.Forms.Label lblplynum;
        private System.Windows.Forms.Label lblplypos;
        private System.Windows.Forms.Label lblteamlist;
    }
}

