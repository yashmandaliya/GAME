
namespace Flappy_Bird
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
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTimer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::Flappy_Bird.Properties.Resources.bird;
            this.flappyBird.Location = new System.Drawing.Point(44, 253);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(82, 70);
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy_Bird.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(273, 376);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(117, 245);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-9, 620);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(607, 179);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_Bird.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(447, -5);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(117, 237);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 3;
            this.pipeTop.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.scoreLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(372, 696);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(97, 32);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "Score:";
            // 
            // gameTimer1
            // 
            this.gameTimer1.Enabled = true;
            this.gameTimer1.Interval = 20;
            this.gameTimer1.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 686);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Press Esc To Stop !!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 722);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Press F6 To Resume !!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(593, 772);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Name = "Form1";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer gameTimer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

