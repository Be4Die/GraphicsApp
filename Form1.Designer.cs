namespace GraphicsApp
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
            tableLayoutPanel1 = new TableLayoutPanel();
            functionsComboBox = new ComboBox();
            label1 = new Label();
            scaleTrackBar = new TrackBar();
            pictureBox = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scaleTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Control;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(functionsComboBox, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(scaleTrackBar, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // functionsComboBox
            // 
            functionsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            functionsComboBox.Font = new Font("Segoe UI", 14F);
            functionsComboBox.Location = new Point(133, 3);
            functionsComboBox.Name = "functionsComboBox";
            functionsComboBox.Size = new Size(272, 33);
            functionsComboBox.TabIndex = 0;
            functionsComboBox.SelectedValueChanged += OnSelectedFunctionChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 1;
            label1.Text = "Фнукция:";
            // 
            // scaleTrackBar
            // 
            tableLayoutPanel1.SetColumnSpan(scaleTrackBar, 2);
            scaleTrackBar.Dock = DockStyle.Fill;
            scaleTrackBar.Location = new Point(3, 413);
            scaleTrackBar.Maximum = 99;
            scaleTrackBar.Minimum = 1;
            scaleTrackBar.Name = "scaleTrackBar";
            scaleTrackBar.Size = new Size(794, 34);
            scaleTrackBar.TabIndex = 2;
            scaleTrackBar.Value = 50;
            scaleTrackBar.ValueChanged += OnScaleValueChanged;
            // 
            // pictureBox
            // 
            tableLayoutPanel1.SetColumnSpan(pictureBox, 2);
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 43);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(794, 364);
            pictureBox.TabIndex = 3;
            pictureBox.TabStop = false;
            pictureBox.Paint += OnPaintPictureBox;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 53, 59);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Resize += OnFromResize;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scaleTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox functionsComboBox;
        private Label label1;
        private TrackBar scaleTrackBar;
        private PictureBox pictureBox;
    }
}
