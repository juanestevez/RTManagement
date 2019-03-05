namespace RT_Management
{
    partial class frmStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStats));
            this.zedGrafico = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zedGrafico
            // 
            this.zedGrafico.Location = new System.Drawing.Point(-1, -3);
            this.zedGrafico.Name = "zedGrafico";
            this.zedGrafico.ScrollGrace = 0D;
            this.zedGrafico.ScrollMaxX = 0D;
            this.zedGrafico.ScrollMaxY = 0D;
            this.zedGrafico.ScrollMaxY2 = 0D;
            this.zedGrafico.ScrollMinX = 0D;
            this.zedGrafico.ScrollMinY = 0D;
            this.zedGrafico.ScrollMinY2 = 0D;
            this.zedGrafico.Size = new System.Drawing.Size(672, 441);
            this.zedGrafico.TabIndex = 6;
            // 
            // frmStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 432);
            this.Controls.Add(this.zedGrafico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStats";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Estadísticas";
            this.Load += new System.EventHandler(this.FrmStats_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGrafico;
    }
}