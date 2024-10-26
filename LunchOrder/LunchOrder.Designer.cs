


namespace LunchOrder
{
    partial class FRMLunchOrder
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
            GroupBoxMain = new GroupBox();
            RadioSalad = new RadioButton();
            RadioPizza = new RadioButton();
            RadioHamburger = new RadioButton();
            GroupBoxAddOn = new GroupBox();
            CheckAddOn3 = new CheckBox();
            CheckAddOn2 = new CheckBox();
            CheckAddOn1 = new CheckBox();
            GroupBoxTotal = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            TextBoxTotal = new TextBox();
            TextBoxTax = new TextBox();
            TextBoxSubtotal = new TextBox();
            ButtonPlaceOrder = new Button();
            ButtonExitForm = new Button();
            ButtonResetForm = new Button();
            GroupBoxMain.SuspendLayout();
            GroupBoxAddOn.SuspendLayout();
            GroupBoxTotal.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxMain
            // 
            GroupBoxMain.BackColor = SystemColors.WindowFrame;
            GroupBoxMain.Controls.Add(RadioSalad);
            GroupBoxMain.Controls.Add(RadioPizza);
            GroupBoxMain.Controls.Add(RadioHamburger);
            GroupBoxMain.ForeColor = SystemColors.ButtonFace;
            GroupBoxMain.Location = new Point(31, 60);
            GroupBoxMain.Name = "GroupBoxMain";
            GroupBoxMain.Size = new Size(185, 115);
            GroupBoxMain.TabIndex = 0;
            GroupBoxMain.TabStop = false;
            GroupBoxMain.Text = "Main Course";
            // 
            // RadioSalad
            // 
            RadioSalad.AutoSize = true;
            RadioSalad.Location = new Point(17, 75);
            RadioSalad.Name = "RadioSalad";
            RadioSalad.Size = new Size(53, 19);
            RadioSalad.TabIndex = 2;
            RadioSalad.TabStop = true;
            RadioSalad.Text = "Salad";
            RadioSalad.UseVisualStyleBackColor = true;
            // 
            // RadioPizza
            // 
            RadioPizza.AutoSize = true;
            RadioPizza.Location = new Point(17, 50);
            RadioPizza.Name = "RadioPizza";
            RadioPizza.Size = new Size(51, 19);
            RadioPizza.TabIndex = 1;
            RadioPizza.TabStop = true;
            RadioPizza.Text = "Pizza";
            RadioPizza.UseVisualStyleBackColor = true;
            // 
            // RadioHamburger
            // 
            RadioHamburger.AutoSize = true;
            RadioHamburger.Location = new Point(17, 25);
            RadioHamburger.Name = "RadioHamburger";
            RadioHamburger.Size = new Size(86, 19);
            RadioHamburger.TabIndex = 0;
            RadioHamburger.TabStop = true;
            RadioHamburger.Text = "Hamburger";
            RadioHamburger.UseVisualStyleBackColor = true;
            // 
            // GroupBoxAddOn
            // 
            GroupBoxAddOn.Controls.Add(CheckAddOn3);
            GroupBoxAddOn.Controls.Add(CheckAddOn2);
            GroupBoxAddOn.Controls.Add(CheckAddOn1);
            GroupBoxAddOn.Location = new Point(282, 60);
            GroupBoxAddOn.Name = "GroupBoxAddOn";
            GroupBoxAddOn.Size = new Size(206, 115);
            GroupBoxAddOn.TabIndex = 1;
            GroupBoxAddOn.TabStop = false;
            GroupBoxAddOn.Text = "Add-On Items";
            // 
            // CheckAddOn3
            // 
            CheckAddOn3.AutoSize = true;
            CheckAddOn3.Location = new Point(17, 78);
            CheckAddOn3.Name = "CheckAddOn3";
            CheckAddOn3.Size = new Size(83, 19);
            CheckAddOn3.TabIndex = 2;
            CheckAddOn3.Text = "checkBox3";
            CheckAddOn3.UseVisualStyleBackColor = true;
            // 
            // CheckAddOn2
            // 
            CheckAddOn2.AutoSize = true;
            CheckAddOn2.Location = new Point(17, 53);
            CheckAddOn2.Name = "CheckAddOn2";
            CheckAddOn2.Size = new Size(83, 19);
            CheckAddOn2.TabIndex = 1;
            CheckAddOn2.Text = "checkBox2";
            CheckAddOn2.UseVisualStyleBackColor = true;
            // 
            // CheckAddOn1
            // 
            CheckAddOn1.AutoSize = true;
            CheckAddOn1.Location = new Point(17, 28);
            CheckAddOn1.Name = "CheckAddOn1";
            CheckAddOn1.Size = new Size(83, 19);
            CheckAddOn1.TabIndex = 0;
            CheckAddOn1.Text = "checkBox1";
            CheckAddOn1.UseVisualStyleBackColor = true;
            // 
            // GroupBoxTotal
            // 
            GroupBoxTotal.Controls.Add(label3);
            GroupBoxTotal.Controls.Add(label2);
            GroupBoxTotal.Controls.Add(label1);
            GroupBoxTotal.Controls.Add(TextBoxTotal);
            GroupBoxTotal.Controls.Add(TextBoxTax);
            GroupBoxTotal.Controls.Add(TextBoxSubtotal);
            GroupBoxTotal.Location = new Point(31, 229);
            GroupBoxTotal.Name = "GroupBoxTotal";
            GroupBoxTotal.Size = new Size(246, 127);
            GroupBoxTotal.TabIndex = 2;
            GroupBoxTotal.TabStop = false;
            GroupBoxTotal.Text = "Order Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 88);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "Order Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 59);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Tax (5%):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 25);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Subtotal:";
            // 
            // TextBoxTotal
            // 
            TextBoxTotal.Location = new Point(102, 80);
            TextBoxTotal.Name = "TextBoxTotal";
            TextBoxTotal.Size = new Size(100, 23);
            TextBoxTotal.TabIndex = 2;
            // 
            // TextBoxTax
            // 
            TextBoxTax.Location = new Point(102, 51);
            TextBoxTax.Name = "TextBoxTax";
            TextBoxTax.Size = new Size(100, 23);
            TextBoxTax.TabIndex = 1;
            // 
            // TextBoxSubtotal
            // 
            TextBoxSubtotal.Location = new Point(102, 22);
            TextBoxSubtotal.Name = "TextBoxSubtotal";
            TextBoxSubtotal.Size = new Size(100, 23);
            TextBoxSubtotal.TabIndex = 0;
            // 
            // ButtonPlaceOrder
            // 
            ButtonPlaceOrder.Location = new Point(352, 229);
            ButtonPlaceOrder.Name = "ButtonPlaceOrder";
            ButtonPlaceOrder.Size = new Size(75, 23);
            ButtonPlaceOrder.TabIndex = 3;
            ButtonPlaceOrder.Text = "Place Order";
            ButtonPlaceOrder.UseVisualStyleBackColor = true;
            ButtonPlaceOrder.Click += ButtonPlaceOrder_Click;
            // 
            // ButtonExitForm
            // 
            ButtonExitForm.Location = new Point(352, 333);
            ButtonExitForm.Name = "ButtonExitForm";
            ButtonExitForm.Size = new Size(75, 23);
            ButtonExitForm.TabIndex = 4;
            ButtonExitForm.Text = "Exit";
            ButtonExitForm.UseVisualStyleBackColor = true;
            ButtonExitForm.Click += ButtonExitForm_Click;
            // 
            // ButtonResetForm
            // 
            ButtonResetForm.Location = new Point(352, 279);
            ButtonResetForm.Name = "ButtonResetForm";
            ButtonResetForm.Size = new Size(75, 23);
            ButtonResetForm.TabIndex = 5;
            ButtonResetForm.Text = "Reset";
            ButtonResetForm.UseVisualStyleBackColor = true;
            ButtonResetForm.Click += ButtonResetForm_Click;
            // 
            // FRMLunchOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(514, 386);
            Controls.Add(ButtonResetForm);
            Controls.Add(ButtonExitForm);
            Controls.Add(ButtonPlaceOrder);
            Controls.Add(GroupBoxTotal);
            Controls.Add(GroupBoxAddOn);
            Controls.Add(GroupBoxMain);
            Name = "FRMLunchOrder";
            Text = "Lunch Order";
            GroupBoxMain.ResumeLayout(false);
            GroupBoxMain.PerformLayout();
            GroupBoxAddOn.ResumeLayout(false);
            GroupBoxAddOn.PerformLayout();
            GroupBoxTotal.ResumeLayout(false);
            GroupBoxTotal.PerformLayout();
            ResumeLayout(false);
        }





        #endregion

        private GroupBox GroupBoxMain;
        private RadioButton RadioSalad;
        private RadioButton RadioPizza;
        private RadioButton RadioHamburger;
        private GroupBox GroupBoxAddOn;
        private CheckBox CheckAddOn1;
        private CheckBox CheckAddOn3;
        private CheckBox CheckAddOn2;
        private GroupBox GroupBoxTotal;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox TextBoxTotal;
        private TextBox TextBoxTax;
        private TextBox TextBoxSubtotal;
        private Button ButtonPlaceOrder;
        private Button ButtonExitForm;
        private Button ButtonResetForm;
    }
}
