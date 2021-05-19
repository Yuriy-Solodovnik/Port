namespace SPZ2
{
    partial class PortForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortForm));
            this.Namee = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownWorkers = new System.Windows.Forms.NumericUpDown();
            this.Technique = new System.Windows.Forms.Label();
            this.TechPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Docks = new System.Windows.Forms.Label();
            this.numericUpDownTechCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTechPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCostServicing = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDocks = new System.Windows.Forms.NumericUpDown();
            this.Hours = new System.Windows.Forms.Label();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.AddPort = new System.Windows.Forms.Button();
            this.Ships = new System.Windows.Forms.Label();
            this.numericUpDownShips = new System.Windows.Forms.NumericUpDown();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProfitButton = new System.Windows.Forms.Button();
            this.ProfitLabel = new System.Windows.Forms.Label();
            this.ProfitLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTechCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTechPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostServicing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShips)).BeginInit();
            this.SuspendLayout();
            // 
            // Namee
            // 
            this.Namee.AutoSize = true;
            this.Namee.Location = new System.Drawing.Point(13, 13);
            this.Namee.Name = "Namee";
            this.Namee.Size = new System.Drawing.Size(91, 13);
            this.Namee.TabIndex = 0;
            this.Namee.Text = "Название Порта";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // Adress
            // 
            this.Adress.AutoSize = true;
            this.Adress.Location = new System.Drawing.Point(120, 13);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(38, 13);
            this.Adress.TabIndex = 2;
            this.Adress.Text = "Адрес";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(120, 30);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество работников";
            // 
            // numericUpDownWorkers
            // 
            this.numericUpDownWorkers.Location = new System.Drawing.Point(226, 29);
            this.numericUpDownWorkers.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownWorkers.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownWorkers.Name = "numericUpDownWorkers";
            this.numericUpDownWorkers.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownWorkers.TabIndex = 5;
            this.numericUpDownWorkers.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // Technique
            // 
            this.Technique.AutoSize = true;
            this.Technique.Location = new System.Drawing.Point(357, 52);
            this.Technique.Name = "Technique";
            this.Technique.Size = new System.Drawing.Size(109, 13);
            this.Technique.TabIndex = 6;
            this.Technique.Text = "Количество техники";
            // 
            // TechPrice
            // 
            this.TechPrice.AutoSize = true;
            this.TechPrice.Location = new System.Drawing.Point(357, 13);
            this.TechPrice.Name = "TechPrice";
            this.TechPrice.Size = new System.Drawing.Size(123, 13);
            this.TechPrice.TabIndex = 7;
            this.TechPrice.Text = "Цена единицы техники";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(486, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цена обслуживания корабля";
            // 
            // Docks
            // 
            this.Docks.AutoSize = true;
            this.Docks.Location = new System.Drawing.Point(661, 13);
            this.Docks.Name = "Docks";
            this.Docks.Size = new System.Drawing.Size(116, 13);
            this.Docks.TabIndex = 9;
            this.Docks.Text = "Количество причалов";
            // 
            // numericUpDownTechCount
            // 
            this.numericUpDownTechCount.Location = new System.Drawing.Point(360, 68);
            this.numericUpDownTechCount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownTechCount.Name = "numericUpDownTechCount";
            this.numericUpDownTechCount.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownTechCount.TabIndex = 10;
            this.numericUpDownTechCount.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDownTechPrice
            // 
            this.numericUpDownTechPrice.DecimalPlaces = 2;
            this.numericUpDownTechPrice.Location = new System.Drawing.Point(360, 29);
            this.numericUpDownTechPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTechPrice.Name = "numericUpDownTechPrice";
            this.numericUpDownTechPrice.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownTechPrice.TabIndex = 11;
            this.numericUpDownTechPrice.Value = new decimal(new int[] {
            1342,
            0,
            0,
            196608});
            this.numericUpDownTechPrice.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDownCostServicing
            // 
            this.numericUpDownCostServicing.DecimalPlaces = 2;
            this.numericUpDownCostServicing.Location = new System.Drawing.Point(489, 29);
            this.numericUpDownCostServicing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownCostServicing.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCostServicing.Name = "numericUpDownCostServicing";
            this.numericUpDownCostServicing.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownCostServicing.TabIndex = 12;
            this.numericUpDownCostServicing.Value = new decimal(new int[] {
            34522,
            0,
            0,
            131072});
            // 
            // numericUpDownDocks
            // 
            this.numericUpDownDocks.Location = new System.Drawing.Point(664, 31);
            this.numericUpDownDocks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDocks.Name = "numericUpDownDocks";
            this.numericUpDownDocks.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownDocks.TabIndex = 13;
            this.numericUpDownDocks.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownDocks.ValueChanged += new System.EventHandler(this.numericUpDownDocks_ValueChanged);
            // 
            // Hours
            // 
            this.Hours.AutoSize = true;
            this.Hours.Location = new System.Drawing.Point(486, 52);
            this.Hours.Name = "Hours";
            this.Hours.Size = new System.Drawing.Size(176, 13);
            this.Hours.TabIndex = 14;
            this.Hours.Text = "Время обслуживания корабля (h)";
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(489, 68);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(71, 20);
            this.numericUpDownHours.TabIndex = 15;
            this.numericUpDownHours.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // AddPort
            // 
            this.AddPort.Location = new System.Drawing.Point(664, 317);
            this.AddPort.Name = "AddPort";
            this.AddPort.Size = new System.Drawing.Size(115, 54);
            this.AddPort.TabIndex = 16;
            this.AddPort.Text = "Добавить порт";
            this.AddPort.UseVisualStyleBackColor = true;
            this.AddPort.Click += new System.EventHandler(this.AddPort_Click);
            // 
            // Ships
            // 
            this.Ships.AutoSize = true;
            this.Ships.Location = new System.Drawing.Point(10, 146);
            this.Ships.Name = "Ships";
            this.Ships.Size = new System.Drawing.Size(206, 13);
            this.Ships.TabIndex = 17;
            this.Ships.Text = "Предполагаемое количество кораблей";
            // 
            // numericUpDownShips
            // 
            this.numericUpDownShips.Location = new System.Drawing.Point(13, 163);
            this.numericUpDownShips.Name = "numericUpDownShips";
            this.numericUpDownShips.Size = new System.Drawing.Size(83, 20);
            this.numericUpDownShips.TabIndex = 18;
            this.numericUpDownShips.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(540, 317);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(87, 54);
            this.CancelButton.TabIndex = 19;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProfitButton
            // 
            this.ProfitButton.Location = new System.Drawing.Point(235, 146);
            this.ProfitButton.Name = "ProfitButton";
            this.ProfitButton.Size = new System.Drawing.Size(96, 37);
            this.ProfitButton.TabIndex = 20;
            this.ProfitButton.Text = "Рассчитать прибыль";
            this.ProfitButton.UseVisualStyleBackColor = true;
            this.ProfitButton.Click += new System.EventHandler(this.ProfitButton_Click);
            // 
            // ProfitLabel
            // 
            this.ProfitLabel.AutoSize = true;
            this.ProfitLabel.Location = new System.Drawing.Point(360, 146);
            this.ProfitLabel.Name = "ProfitLabel";
            this.ProfitLabel.Size = new System.Drawing.Size(53, 13);
            this.ProfitLabel.TabIndex = 21;
            this.ProfitLabel.Text = "Прибыль";
            // 
            // ProfitLabel2
            // 
            this.ProfitLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfitLabel2.Location = new System.Drawing.Point(363, 163);
            this.ProfitLabel2.Name = "ProfitLabel2";
            this.ProfitLabel2.Size = new System.Drawing.Size(103, 23);
            this.ProfitLabel2.TabIndex = 22;
            this.ProfitLabel2.Text = "Не определено";
            // 
            // PortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 383);
            this.Controls.Add(this.ProfitLabel2);
            this.Controls.Add(this.ProfitLabel);
            this.Controls.Add(this.ProfitButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.numericUpDownShips);
            this.Controls.Add(this.Ships);
            this.Controls.Add(this.AddPort);
            this.Controls.Add(this.numericUpDownHours);
            this.Controls.Add(this.Hours);
            this.Controls.Add(this.numericUpDownDocks);
            this.Controls.Add(this.numericUpDownCostServicing);
            this.Controls.Add(this.numericUpDownTechPrice);
            this.Controls.Add(this.numericUpDownTechCount);
            this.Controls.Add(this.Docks);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TechPrice);
            this.Controls.Add(this.Technique);
            this.Controls.Add(this.numericUpDownWorkers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.Namee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PortForm";
            this.Text = "PortForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTechCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTechPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostServicing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namee;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label Adress;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownWorkers;
        private System.Windows.Forms.Label Technique;
        private System.Windows.Forms.Label TechPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Docks;
        private System.Windows.Forms.NumericUpDown numericUpDownTechCount;
        private System.Windows.Forms.NumericUpDown numericUpDownTechPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownCostServicing;
        private System.Windows.Forms.NumericUpDown numericUpDownDocks;
        private System.Windows.Forms.Label Hours;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Button AddPort;
        private System.Windows.Forms.Label Ships;
        private System.Windows.Forms.NumericUpDown numericUpDownShips;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ProfitButton;
        private System.Windows.Forms.Label ProfitLabel;
        private System.Windows.Forms.Label ProfitLabel2;
    }
}