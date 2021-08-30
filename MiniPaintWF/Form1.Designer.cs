
namespace MiniPaintWF
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Color = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rb_Outline = new System.Windows.Forms.RadioButton();
            this.rb_Fill = new System.Windows.Forms.RadioButton();
            this.btn_Select = new System.Windows.Forms.Button();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_Width = new System.Windows.Forms.Label();
            this.cb_Figures = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(898, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 59);
            this.button1.TabIndex = 24;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Color
            // 
            this.lbl_Color.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Color.Location = new System.Drawing.Point(738, 28);
            this.lbl_Color.Name = "lbl_Color";
            this.lbl_Color.Size = new System.Drawing.Size(29, 27);
            this.lbl_Color.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(479, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 28);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "10";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(262, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 28);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "10";
            // 
            // rb_Outline
            // 
            this.rb_Outline.AutoSize = true;
            this.rb_Outline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Outline.Location = new System.Drawing.Point(790, 48);
            this.rb_Outline.Name = "rb_Outline";
            this.rb_Outline.Size = new System.Drawing.Size(91, 28);
            this.rb_Outline.TabIndex = 20;
            this.rb_Outline.TabStop = true;
            this.rb_Outline.Text = "Outline";
            this.rb_Outline.UseVisualStyleBackColor = true;
            // 
            // rb_Fill
            // 
            this.rb_Fill.AutoSize = true;
            this.rb_Fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_Fill.Location = new System.Drawing.Point(790, 14);
            this.rb_Fill.Name = "rb_Fill";
            this.rb_Fill.Size = new System.Drawing.Size(55, 28);
            this.rb_Fill.TabIndex = 19;
            this.rb_Fill.TabStop = true;
            this.rb_Fill.Text = "Fill";
            this.rb_Fill.UseVisualStyleBackColor = true;
            // 
            // btn_Select
            // 
            this.btn_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Select.Location = new System.Drawing.Point(640, 28);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(92, 27);
            this.btn_Select.TabIndex = 18;
            this.btn_Select.Text = "Color";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // lbl_Height
            // 
            this.lbl_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Height.Location = new System.Drawing.Point(409, 27);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(75, 33);
            this.lbl_Height.TabIndex = 17;
            this.lbl_Height.Text = "Height";
            // 
            // lbl_Width
            // 
            this.lbl_Width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Width.Location = new System.Drawing.Point(173, 27);
            this.lbl_Width.Name = "lbl_Width";
            this.lbl_Width.Size = new System.Drawing.Size(74, 33);
            this.lbl_Width.TabIndex = 16;
            this.lbl_Width.Text = "Width";
            // 
            // cb_Figures
            // 
            this.cb_Figures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Figures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Figures.FormattingEnabled = true;
            this.cb_Figures.ItemHeight = 22;
            this.cb_Figures.Location = new System.Drawing.Point(12, 27);
            this.cb_Figures.Name = "cb_Figures";
            this.cb_Figures.Size = new System.Drawing.Size(136, 30);
            this.cb_Figures.TabIndex = 15;
            this.cb_Figures.SelectedIndexChanged += new System.EventHandler(this.cb_Figures_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Color);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rb_Outline);
            this.Controls.Add(this.rb_Fill);
            this.Controls.Add(this.btn_Select);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.lbl_Width);
            this.Controls.Add(this.cb_Figures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Color;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rb_Outline;
        private System.Windows.Forms.RadioButton rb_Fill;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_Width;
        private System.Windows.Forms.ComboBox cb_Figures;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

