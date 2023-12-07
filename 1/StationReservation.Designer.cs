namespace ChargersManager
{
    partial class StationReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StationReservation));
            label1=new Label();
            label2=new Label();
            dateTimePicker1=new DateTimePicker();
            numericUpDown1=new NumericUpDown();
            button1=new Button();
            listView1=new ListView();
            listView2=new ListView();
            listView3=new ListView();
            groupBox1=new GroupBox();
            label3=new Label();
            label4=new Label();
            label5=new Label();
            button2=new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(42, 35);
            label1.Name="label1";
            label1.Size=new Size(145, 19);
            label1.TabIndex=7;
            label1.Text="Vrijeme rezervacije:";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Location=new Point(42, 81);
            label2.Name="label2";
            label2.Size=new Size(164, 19);
            label2.TabIndex=8;
            label2.Text="Punjenje u minutama:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat="HH:mm dd.MM.yyyy";
            dateTimePicker1.Format=DateTimePickerFormat.Custom;
            dateTimePicker1.Location=new Point(239, 29);
            dateTimePicker1.MaxDate=new DateTime(2033, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate=new DateTime(2023, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name="dateTimePicker1";
            dateTimePicker1.ShowUpDown=true;
            dateTimePicker1.Size=new Size(155, 27);
            dateTimePicker1.TabIndex=9;
            dateTimePicker1.Value=new DateTime(2023, 12, 7, 14, 15, 54, 0);
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location=new Point(239, 79);
            numericUpDown1.Maximum=new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name="numericUpDown1";
            numericUpDown1.Size=new Size(155, 27);
            numericUpDown1.TabIndex=10;
            numericUpDown1.Value=new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(453, 42);
            button1.Margin=new Padding(4);
            button1.Name="button1";
            button1.Size=new Size(162, 51);
            button1.TabIndex=11;
            button1.Text="Prikaži punionice";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // listView1
            // 
            listView1.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left;
            listView1.Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location=new Point(13, 182);
            listView1.Margin=new Padding(4);
            listView1.Name="listView1";
            listView1.Size=new Size(200, 279);
            listView1.TabIndex=12;
            listView1.TileSize=new Size(10, 10);
            listView1.UseCompatibleStateImageBehavior=false;
            listView1.View=View.List;
            // 
            // listView2
            // 
            listView2.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left;
            listView2.Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView2.Location=new Point(239, 182);
            listView2.Margin=new Padding(4);
            listView2.Name="listView2";
            listView2.Size=new Size(200, 279);
            listView2.TabIndex=13;
            listView2.TileSize=new Size(10, 10);
            listView2.UseCompatibleStateImageBehavior=false;
            listView2.View=View.List;
            // 
            // listView3
            // 
            listView3.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left;
            listView3.Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            listView3.Location=new Point(465, 182);
            listView3.Margin=new Padding(4);
            listView3.Name="listView3";
            listView3.Size=new Size(200, 279);
            listView3.TabIndex=14;
            listView3.TileSize=new Size(10, 10);
            listView3.UseCompatibleStateImageBehavior=false;
            listView3.View=View.List;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location=new Point(12, 12);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(653, 127);
            groupBox1.TabIndex=15;
            groupBox1.TabStop=false;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Location=new Point(36, 159);
            label3.Name="label3";
            label3.Size=new Size(139, 19);
            label3.TabIndex=16;
            label3.Text="Zauzete punionice";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.Location=new Point(251, 159);
            label4.Name="label4";
            label4.Size=new Size(164, 19);
            label4.TabIndex=17;
            label4.Text="Rezervirane punionice";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.Location=new Point(495, 159);
            label5.Name="label5";
            label5.Size=new Size(149, 19);
            label5.TabIndex=18;
            label5.Text="Slobodne punionice";
            // 
            // button2
            // 
            button2.Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location=new Point(483, 484);
            button2.Margin=new Padding(4);
            button2.Name="button2";
            button2.Size=new Size(162, 51);
            button2.TabIndex=19;
            button2.Text="Rezerviraj punionicu";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // StationReservation
            // 
            AutoScaleDimensions=new SizeF(9F, 19F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(677, 548);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(4);
            Name="StationReservation";
            Text="Rezerviraj punionicu";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
    }
}