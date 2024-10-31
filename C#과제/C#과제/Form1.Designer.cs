namespace C_과제
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.hit_btn = new System.Windows.Forms.Button();
            this.stay_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bet_btn = new System.Windows.Forms.Button();
            this.betTextBox = new System.Windows.Forms.TextBox();
            this.player_pb1 = new System.Windows.Forms.PictureBox();
            this.player_pb2 = new System.Windows.Forms.PictureBox();
            this.player_pb3 = new System.Windows.Forms.PictureBox();
            this.deal_pb1 = new System.Windows.Forms.PictureBox();
            this.deal_pb2 = new System.Windows.Forms.PictureBox();
            this.deal_pb3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.deck_pb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.betLabel = new System.Windows.Forms.Label();
            this.player_point = new System.Windows.Forms.Label();
            this.deal_point = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.Label();
            this.re_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player_pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deal_pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deal_pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deal_pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deck_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // hit_btn
            // 
            this.hit_btn.BackColor = System.Drawing.Color.Blue;
            this.hit_btn.Font = new System.Drawing.Font("굴림", 12F);
            this.hit_btn.ForeColor = System.Drawing.Color.Yellow;
            this.hit_btn.Location = new System.Drawing.Point(253, 393);
            this.hit_btn.Name = "hit_btn";
            this.hit_btn.Size = new System.Drawing.Size(75, 23);
            this.hit_btn.TabIndex = 0;
            this.hit_btn.Text = "HIT";
            this.hit_btn.UseVisualStyleBackColor = false;
            this.hit_btn.Click += new System.EventHandler(this.hit_btn_Click);
            // 
            // stay_btn
            // 
            this.stay_btn.BackColor = System.Drawing.Color.Purple;
            this.stay_btn.Font = new System.Drawing.Font("굴림", 12F);
            this.stay_btn.ForeColor = System.Drawing.Color.Yellow;
            this.stay_btn.Location = new System.Drawing.Point(437, 393);
            this.stay_btn.Name = "stay_btn";
            this.stay_btn.Size = new System.Drawing.Size(75, 23);
            this.stay_btn.TabIndex = 1;
            this.stay_btn.Text = "STAY";
            this.stay_btn.UseVisualStyleBackColor = false;
            this.stay_btn.Click += new System.EventHandler(this.stay_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LawnGreen;
            this.button3.ForeColor = System.Drawing.Color.DarkViolet;
            this.button3.Location = new System.Drawing.Point(603, 185);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "DRAW";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bet_btn
            // 
            this.bet_btn.BackColor = System.Drawing.Color.Teal;
            this.bet_btn.ForeColor = System.Drawing.Color.Gold;
            this.bet_btn.Location = new System.Drawing.Point(709, 343);
            this.bet_btn.Name = "bet_btn";
            this.bet_btn.Size = new System.Drawing.Size(75, 23);
            this.bet_btn.TabIndex = 3;
            this.bet_btn.Text = "BET";
            this.bet_btn.UseVisualStyleBackColor = false;
            this.bet_btn.Click += new System.EventHandler(this.bet_btn_Click);
            // 
            // betTextBox
            // 
            this.betTextBox.Location = new System.Drawing.Point(603, 345);
            this.betTextBox.Name = "betTextBox";
            this.betTextBox.Size = new System.Drawing.Size(100, 21);
            this.betTextBox.TabIndex = 4;
            // 
            // player_pb1
            // 
            this.player_pb1.Location = new System.Drawing.Point(235, 249);
            this.player_pb1.Name = "player_pb1";
            this.player_pb1.Size = new System.Drawing.Size(93, 117);
            this.player_pb1.TabIndex = 5;
            this.player_pb1.TabStop = false;
            // 
            // player_pb2
            // 
            this.player_pb2.Location = new System.Drawing.Point(338, 249);
            this.player_pb2.Name = "player_pb2";
            this.player_pb2.Size = new System.Drawing.Size(93, 117);
            this.player_pb2.TabIndex = 6;
            this.player_pb2.TabStop = false;
            // 
            // player_pb3
            // 
            this.player_pb3.Location = new System.Drawing.Point(437, 249);
            this.player_pb3.Name = "player_pb3";
            this.player_pb3.Size = new System.Drawing.Size(92, 117);
            this.player_pb3.TabIndex = 7;
            this.player_pb3.TabStop = false;
            // 
            // deal_pb1
            // 
            this.deal_pb1.Location = new System.Drawing.Point(235, 48);
            this.deal_pb1.Name = "deal_pb1";
            this.deal_pb1.Size = new System.Drawing.Size(93, 117);
            this.deal_pb1.TabIndex = 8;
            this.deal_pb1.TabStop = false;
            // 
            // deal_pb2
            // 
            this.deal_pb2.Location = new System.Drawing.Point(338, 48);
            this.deal_pb2.Name = "deal_pb2";
            this.deal_pb2.Size = new System.Drawing.Size(93, 117);
            this.deal_pb2.TabIndex = 9;
            this.deal_pb2.TabStop = false;
            // 
            // deal_pb3
            // 
            this.deal_pb3.Location = new System.Drawing.Point(437, 48);
            this.deal_pb3.Name = "deal_pb3";
            this.deal_pb3.Size = new System.Drawing.Size(92, 117);
            this.deal_pb3.TabIndex = 10;
            this.deal_pb3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(603, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 13;
            // 
            // deck_pb
            // 
            this.deck_pb.Location = new System.Drawing.Point(603, 48);
            this.deck_pb.Name = "deck_pb";
            this.deck_pb.Size = new System.Drawing.Size(160, 117);
            this.deck_pb.TabIndex = 14;
            this.deck_pb.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(113, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 16;
            this.label1.Text = "DEALER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("굴림", 20F);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(318, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "PLAYER";
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(641, 382);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(0, 12);
            this.moneyLabel.TabIndex = 18;
            // 
            // betLabel
            // 
            this.betLabel.AutoSize = true;
            this.betLabel.Location = new System.Drawing.Point(665, 312);
            this.betLabel.Name = "betLabel";
            this.betLabel.Size = new System.Drawing.Size(0, 12);
            this.betLabel.TabIndex = 19;
            // 
            // player_point
            // 
            this.player_point.AutoSize = true;
            this.player_point.BackColor = System.Drawing.Color.Black;
            this.player_point.Font = new System.Drawing.Font("굴림", 20F);
            this.player_point.ForeColor = System.Drawing.Color.Yellow;
            this.player_point.Location = new System.Drawing.Point(437, 419);
            this.player_point.Name = "player_point";
            this.player_point.Size = new System.Drawing.Size(28, 27);
            this.player_point.TabIndex = 20;
            this.player_point.Text = "0";
            // 
            // deal_point
            // 
            this.deal_point.AutoSize = true;
            this.deal_point.BackColor = System.Drawing.Color.Black;
            this.deal_point.Font = new System.Drawing.Font("굴림", 20F);
            this.deal_point.ForeColor = System.Drawing.Color.Yellow;
            this.deal_point.Location = new System.Drawing.Point(283, 9);
            this.deal_point.Name = "deal_point";
            this.deal_point.Size = new System.Drawing.Size(28, 27);
            this.deal_point.TabIndex = 21;
            this.deal_point.Text = "0";
            this.deal_point.Click += new System.EventHandler(this.deal_point_Click);
            // 
            // condition
            // 
            this.condition.AutoSize = true;
            this.condition.BackColor = System.Drawing.Color.Black;
            this.condition.Font = new System.Drawing.Font("굴림", 16F);
            this.condition.ForeColor = System.Drawing.Color.Yellow;
            this.condition.Location = new System.Drawing.Point(295, 196);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(0, 22);
            this.condition.TabIndex = 22;
            // 
            // re_btn
            // 
            this.re_btn.BackColor = System.Drawing.Color.Yellow;
            this.re_btn.ForeColor = System.Drawing.Color.Red;
            this.re_btn.Location = new System.Drawing.Point(37, 343);
            this.re_btn.Name = "re_btn";
            this.re_btn.Size = new System.Drawing.Size(75, 23);
            this.re_btn.TabIndex = 23;
            this.re_btn.Text = "RE START";
            this.re_btn.UseVisualStyleBackColor = false;
            this.re_btn.Click += new System.EventHandler(this.re_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(601, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 24;
            this.label4.Text = "점수:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("굴림", 9F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(603, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "베팅 점수:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.re_btn);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.deal_point);
            this.Controls.Add(this.player_point);
            this.Controls.Add(this.betLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deck_pb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deal_pb3);
            this.Controls.Add(this.deal_pb2);
            this.Controls.Add(this.deal_pb1);
            this.Controls.Add(this.player_pb3);
            this.Controls.Add(this.player_pb2);
            this.Controls.Add(this.player_pb1);
            this.Controls.Add(this.betTextBox);
            this.Controls.Add(this.bet_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.stay_btn);
            this.Controls.Add(this.hit_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.player_pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deal_pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deal_pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deal_pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deck_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hit_btn;
        private System.Windows.Forms.Button stay_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bet_btn;
        private System.Windows.Forms.TextBox betTextBox;
        private System.Windows.Forms.PictureBox player_pb1;
        private System.Windows.Forms.PictureBox player_pb2;
        private System.Windows.Forms.PictureBox player_pb3;
        private System.Windows.Forms.PictureBox deal_pb1;
        private System.Windows.Forms.PictureBox deal_pb2;
        private System.Windows.Forms.PictureBox deal_pb3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox deck_pb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label betLabel;
        private System.Windows.Forms.Label player_point;
        private System.Windows.Forms.Label deal_point;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Button re_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

