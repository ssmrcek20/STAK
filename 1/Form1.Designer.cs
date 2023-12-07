namespace ChargersManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listView1=new ListView();
            richTextBox1=new RichTextBox();
            button1=new Button();
            button2=new Button();
            button3=new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Anchor=AnchorStyles.Top|AnchorStyles.Bottom|AnchorStyles.Left;
            listView1.Font=new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.Location=new Point(13, 13);
            listView1.Margin=new Padding(4);
            listView1.Name="listView1";
            listView1.Size=new Size(322, 472);
            listView1.TabIndex=1;
            listView1.TileSize=new Size(10, 10);
            listView1.UseCompatibleStateImageBehavior=false;
            listView1.View=View.List;
            listView1.SelectedIndexChanged+=listView1_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor=AnchorStyles.Top|AnchorStyles.Left|AnchorStyles.Right;
            richTextBox1.Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location=new Point(343, 13);
            richTextBox1.Margin=new Padding(4);
            richTextBox1.Name="richTextBox1";
            richTextBox1.ReadOnly=true;
            richTextBox1.Size=new Size(493, 347);
            richTextBox1.TabIndex=3;
            richTextBox1.Text="";
            // 
            // button1
            // 
            button1.Anchor=AnchorStyles.Bottom;
            button1.Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location=new Point(343, 410);
            button1.Margin=new Padding(4);
            button1.Name="button1";
            button1.Size=new Size(152, 51);
            button1.TabIndex=4;
            button1.Text="Dodaj punionicu";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Anchor=AnchorStyles.Bottom;
            button2.Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location=new Point(508, 410);
            button2.Margin=new Padding(4);
            button2.Name="button2";
            button2.Size=new Size(152, 51);
            button2.TabIndex=5;
            button2.Text="Izbriši punionicu";
            button2.UseVisualStyleBackColor=true;
            button2.Click+=button2_Click;
            // 
            // button3
            // 
            button3.Anchor=AnchorStyles.Bottom;
            button3.Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location=new Point(674, 410);
            button3.Margin=new Padding(4);
            button3.Name="button3";
            button3.Size=new Size(162, 51);
            button3.TabIndex=6;
            button3.Text="Rezerviraj punionicu";
            button3.UseVisualStyleBackColor=true;
            button3.Click+=button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(9F, 19F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(849, 498);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(listView1);
            Font=new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Margin=new Padding(4);
            Name="Form1";
            Text="Upravljač punionica";
            ResumeLayout(false);
        }

        #endregion
        private ListView listView1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}