namespace MyDictionary
{
    partial class MyDictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyDictionary));
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.meaning_sound = new System.Windows.Forms.Button();
            this.word_sound = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.Adding = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MeaninigNeeded = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Meaning = new System.Windows.Forms.Label();
            this.word = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exite = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Adding.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // meaning_sound
            // 
            this.meaning_sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("meaning_sound.BackgroundImage")));
            this.meaning_sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.meaning_sound, BunifuAnimatorNS.DecorationType.None);
            this.meaning_sound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.meaning_sound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.meaning_sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.meaning_sound.Location = new System.Drawing.Point(191, 244);
            this.meaning_sound.Name = "meaning_sound";
            this.meaning_sound.Size = new System.Drawing.Size(30, 29);
            this.meaning_sound.TabIndex = 33;
            this.meaning_sound.UseVisualStyleBackColor = true;
            this.meaning_sound.Click += new System.EventHandler(this.meaning_sound_Click);
            // 
            // word_sound
            // 
            this.word_sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("word_sound.BackgroundImage")));
            this.word_sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.word_sound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.word_sound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.word_sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.word_sound.Location = new System.Drawing.Point(569, 178);
            this.word_sound.Name = "word_sound";
            this.word_sound.Size = new System.Drawing.Size(30, 29);
            this.word_sound.TabIndex = 32;
            this.word_sound.UseVisualStyleBackColor = true;
            this.word_sound.Click += new System.EventHandler(this.word_sound_Click);
            // 
            // search
            // 
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Location = new System.Drawing.Point(605, 178);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(38, 29);
            this.search.TabIndex = 31;
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Adding
            // 
            this.Adding.Controls.Add(this.button1);
            this.Adding.Controls.Add(this.label3);
            this.Adding.Controls.Add(this.MeaninigNeeded);
            this.Adding.Location = new System.Drawing.Point(-1, 339);
            this.Adding.Name = "Adding";
            this.Adding.Size = new System.Drawing.Size(927, 154);
            this.Adding.TabIndex = 30;
            this.Adding.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(371, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add To MyDictionary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Add The Meaning of The Word";
            // 
            // MeaninigNeeded
            // 
            this.MeaninigNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeaninigNeeded.Location = new System.Drawing.Point(192, 68);
            this.MeaninigNeeded.Multiline = true;
            this.MeaninigNeeded.Name = "MeaninigNeeded";
            this.MeaninigNeeded.Size = new System.Drawing.Size(563, 29);
            this.MeaninigNeeded.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "The Meaning is :";
            // 
            // Meaning
            // 
            this.Meaning.AutoSize = true;
            this.Meaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Meaning.Location = new System.Drawing.Point(382, 244);
            this.Meaning.Name = "Meaning";
            this.Meaning.Size = new System.Drawing.Size(0, 24);
            this.Meaning.TabIndex = 28;
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.word.Location = new System.Drawing.Point(191, 178);
            this.word.Name = "word";
            this.word.Size = new System.Drawing.Size(315, 29);
            this.word.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 66);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(815, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(387, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "My Dictionary";
            // 
            // exite
            // 
            this.exite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exite.BackgroundImage")));
            this.exite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exite.FlatAppearance.BorderSize = 0;
            this.exite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exite.Location = new System.Drawing.Point(886, 8);
            this.exite.Name = "exite";
            this.exite.Size = new System.Drawing.Size(32, 25);
            this.exite.TabIndex = 25;
            this.exite.UseVisualStyleBackColor = true;
            this.exite.Click += new System.EventHandler(this.exite_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.MaxAnimationTime = 4300;
            // 
            // MyDictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 500);
            this.Controls.Add(this.meaning_sound);
            this.Controls.Add(this.word_sound);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Adding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Meaning);
            this.Controls.Add(this.word);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyDictionary";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Adding.ResumeLayout(false);
            this.Adding.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button meaning_sound;
        private System.Windows.Forms.Button word_sound;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel Adding;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MeaninigNeeded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Meaning;
        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exite;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
    }
}