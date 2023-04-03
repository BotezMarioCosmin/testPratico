namespace testPratico
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.textBoxNumser = new System.Windows.Forms.TextBox();
            this.textBoxModello = new System.Windows.Forms.TextBox();
            this.textBoxRam = new System.Windows.Forms.TextBox();
            this.textBoxCapienza = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxPollici = new System.Windows.Forms.TextBox();
            this.labelNumser = new System.Windows.Forms.Label();
            this.labelModello = new System.Windows.Forms.Label();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelCapienza = new System.Windows.Forms.Label();
            this.labelPollici = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonIndexOf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggiungi.Location = new System.Drawing.Point(29, 292);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(324, 51);
            this.buttonAggiungi.TabIndex = 1;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // textBoxNumser
            // 
            this.textBoxNumser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumser.Location = new System.Drawing.Point(29, 59);
            this.textBoxNumser.Name = "textBoxNumser";
            this.textBoxNumser.Size = new System.Drawing.Size(324, 29);
            this.textBoxNumser.TabIndex = 2;
            // 
            // textBoxModello
            // 
            this.textBoxModello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModello.Location = new System.Drawing.Point(29, 107);
            this.textBoxModello.Name = "textBoxModello";
            this.textBoxModello.Size = new System.Drawing.Size(324, 29);
            this.textBoxModello.TabIndex = 3;
            // 
            // textBoxRam
            // 
            this.textBoxRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRam.Location = new System.Drawing.Point(29, 153);
            this.textBoxRam.Name = "textBoxRam";
            this.textBoxRam.Size = new System.Drawing.Size(324, 29);
            this.textBoxRam.TabIndex = 4;
            // 
            // textBoxCapienza
            // 
            this.textBoxCapienza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCapienza.Location = new System.Drawing.Point(29, 201);
            this.textBoxCapienza.Name = "textBoxCapienza";
            this.textBoxCapienza.Size = new System.Drawing.Size(324, 29);
            this.textBoxCapienza.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(29, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(324, 32);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBoxPollici
            // 
            this.textBoxPollici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPollici.Location = new System.Drawing.Point(29, 249);
            this.textBoxPollici.Name = "textBoxPollici";
            this.textBoxPollici.Size = new System.Drawing.Size(324, 29);
            this.textBoxPollici.TabIndex = 7;
            // 
            // labelNumser
            // 
            this.labelNumser.AutoSize = true;
            this.labelNumser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumser.Location = new System.Drawing.Point(359, 64);
            this.labelNumser.Name = "labelNumser";
            this.labelNumser.Size = new System.Drawing.Size(142, 24);
            this.labelNumser.TabIndex = 8;
            this.labelNumser.Text = "Numero Seriale";
            // 
            // labelModello
            // 
            this.labelModello.AutoSize = true;
            this.labelModello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModello.Location = new System.Drawing.Point(359, 112);
            this.labelModello.Name = "labelModello";
            this.labelModello.Size = new System.Drawing.Size(78, 24);
            this.labelModello.TabIndex = 9;
            this.labelModello.Text = "Modello";
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRam.Location = new System.Drawing.Point(359, 158);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(49, 24);
            this.labelRam.TabIndex = 10;
            this.labelRam.Text = "Ram";
            // 
            // labelCapienza
            // 
            this.labelCapienza.AutoSize = true;
            this.labelCapienza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapienza.Location = new System.Drawing.Point(359, 206);
            this.labelCapienza.Name = "labelCapienza";
            this.labelCapienza.Size = new System.Drawing.Size(89, 24);
            this.labelCapienza.TabIndex = 11;
            this.labelCapienza.Text = "Capienza";
            // 
            // labelPollici
            // 
            this.labelPollici.AutoSize = true;
            this.labelPollici.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPollici.Location = new System.Drawing.Point(359, 252);
            this.labelPollici.Name = "labelPollici";
            this.labelPollici.Size = new System.Drawing.Size(59, 24);
            this.labelPollici.TabIndex = 12;
            this.labelPollici.Text = "Pollici";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(519, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(269, 266);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.Location = new System.Drawing.Point(519, 292);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(269, 51);
            this.buttonSort.TabIndex = 14;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // buttonIndexOf
            // 
            this.buttonIndexOf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIndexOf.Location = new System.Drawing.Point(519, 349);
            this.buttonIndexOf.Name = "buttonIndexOf";
            this.buttonIndexOf.Size = new System.Drawing.Size(269, 51);
            this.buttonIndexOf.TabIndex = 15;
            this.buttonIndexOf.Text = "IndexOf";
            this.buttonIndexOf.UseVisualStyleBackColor = true;
            this.buttonIndexOf.Click += new System.EventHandler(this.buttonIndexOf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIndexOf);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelPollici);
            this.Controls.Add(this.labelCapienza);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.labelModello);
            this.Controls.Add(this.labelNumser);
            this.Controls.Add(this.textBoxPollici);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxCapienza);
            this.Controls.Add(this.textBoxRam);
            this.Controls.Add(this.textBoxModello);
            this.Controls.Add(this.textBoxNumser);
            this.Controls.Add(this.buttonAggiungi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.TextBox textBoxNumser;
        private System.Windows.Forms.TextBox textBoxModello;
        private System.Windows.Forms.TextBox textBoxRam;
        private System.Windows.Forms.TextBox textBoxCapienza;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxPollici;
        private System.Windows.Forms.Label labelNumser;
        private System.Windows.Forms.Label labelModello;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelCapienza;
        private System.Windows.Forms.Label labelPollici;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonIndexOf;
    }
}

