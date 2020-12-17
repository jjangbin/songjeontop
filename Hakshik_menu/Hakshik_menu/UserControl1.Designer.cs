
namespace Hakshik_menu
{
    partial class UserControl1
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientButton1_valid = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(74, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "치즈버거";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(5, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "2500";
            // 
            // guna2GradientButton1_valid
            // 
            this.guna2GradientButton1_valid.CheckedState.Parent = this.guna2GradientButton1_valid;
            this.guna2GradientButton1_valid.CustomImages.Parent = this.guna2GradientButton1_valid;
            this.guna2GradientButton1_valid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1_valid.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1_valid.HoverState.Parent = this.guna2GradientButton1_valid;
            this.guna2GradientButton1_valid.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1_valid.Image")));
            this.guna2GradientButton1_valid.Location = new System.Drawing.Point(107, 105);
            this.guna2GradientButton1_valid.Name = "guna2GradientButton1_valid";
            this.guna2GradientButton1_valid.ShadowDecoration.Parent = this.guna2GradientButton1_valid;
            this.guna2GradientButton1_valid.Size = new System.Drawing.Size(34, 30);
            this.guna2GradientButton1_valid.TabIndex = 2;
            this.guna2GradientButton1_valid.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.guna2GradientButton1_valid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "UserControl1";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(139, 138);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1_valid;
    }
}
