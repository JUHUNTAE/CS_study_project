﻿namespace first_study_project_for_foreach
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
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.btnfor = new System.Windows.Forms.Button();
            this.btnforeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxResult
            // 
            this.tboxResult.Location = new System.Drawing.Point(12, 12);
            this.tboxResult.Multiline = true;
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxResult.Size = new System.Drawing.Size(261, 275);
            this.tboxResult.TabIndex = 0;
            // 
            // btnfor
            // 
            this.btnfor.Location = new System.Drawing.Point(279, 12);
            this.btnfor.Name = "btnfor";
            this.btnfor.Size = new System.Drawing.Size(170, 65);
            this.btnfor.TabIndex = 1;
            this.btnfor.Text = "for 문";
            this.btnfor.UseVisualStyleBackColor = true;
            this.btnfor.Click += new System.EventHandler(this.btnfor_Click);
            // 
            // btnforeach
            // 
            this.btnforeach.Location = new System.Drawing.Point(279, 83);
            this.btnforeach.Name = "btnforeach";
            this.btnforeach.Size = new System.Drawing.Size(170, 65);
            this.btnforeach.TabIndex = 1;
            this.btnforeach.Text = "foreach 문";
            this.btnforeach.UseVisualStyleBackColor = true;
            this.btnforeach.Click += new System.EventHandler(this.btnforeach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 299);
            this.Controls.Add(this.btnforeach);
            this.Controls.Add(this.btnfor);
            this.Controls.Add(this.tboxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.Button btnfor;
        private System.Windows.Forms.Button btnforeach;
    }
}

