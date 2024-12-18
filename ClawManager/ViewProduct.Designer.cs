﻿namespace ClawManager
{
    partial class ViewProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProduct));
            lbNome = new Label();
            btnCloseView = new Button();
            lbCodigoBarras = new Label();
            tbRegistro = new Label();
            lbValidade = new Label();
            lbPeso = new Label();
            lbPreco = new Label();
            lbEstoque = new Label();
            lbVolume = new Label();
            lbCusto = new Label();
            lbMarca = new Label();
            lbProvedor = new Label();
            lbCategoria = new Label();
            lbDescricao = new Label();
            panel1 = new Panel();
            tbCodigoBarras = new TextBox();
            panel2 = new Panel();
            tbRegis = new TextBox();
            panel3 = new Panel();
            tbValidade = new TextBox();
            panel4 = new Panel();
            tbCusto = new TextBox();
            panel5 = new Panel();
            tbPreco = new TextBox();
            panel6 = new Panel();
            tbEstoque = new TextBox();
            panel7 = new Panel();
            tbPeso = new TextBox();
            panel8 = new Panel();
            tbVolume = new TextBox();
            panel9 = new Panel();
            tbMarca = new TextBox();
            panel10 = new Panel();
            tbProvedor = new TextBox();
            panel11 = new Panel();
            tbCategoria = new TextBox();
            panel12 = new Panel();
            tbDescricao = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnEditar = new Button();
            btnExcluir = new Button();
            label14 = new Label();
            lbID = new Label();
            panel13 = new Panel();
            panel14 = new Panel();
            tbNome = new TextBox();
            btnConfirm = new Button();
            btnCancel = new Button();
            btnHoverEditar = new Button();
            lbRegis = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            panel13.SuspendLayout();
            panel14.SuspendLayout();
            SuspendLayout();
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lbNome.ForeColor = SystemColors.ButtonHighlight;
            lbNome.Location = new Point(5, -1);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(130, 41);
            lbNome.TabIndex = 0;
            lbNome.Text = "Biscoito";
            // 
            // btnCloseView
            // 
            btnCloseView.BackgroundImage = (Image)resources.GetObject("btnCloseView.BackgroundImage");
            btnCloseView.BackgroundImageLayout = ImageLayout.Center;
            btnCloseView.FlatStyle = FlatStyle.Flat;
            btnCloseView.ForeColor = Color.FromArgb(43, 27, 50);
            btnCloseView.Location = new Point(638, 6);
            btnCloseView.Name = "btnCloseView";
            btnCloseView.Size = new Size(30, 30);
            btnCloseView.TabIndex = 1;
            btnCloseView.UseVisualStyleBackColor = true;
            btnCloseView.Click += btnCloseView_Click;
            // 
            // lbCodigoBarras
            // 
            lbCodigoBarras.AutoSize = true;
            lbCodigoBarras.Font = new Font("Segoe UI", 12F);
            lbCodigoBarras.ForeColor = Color.White;
            lbCodigoBarras.Location = new Point(3, 1);
            lbCodigoBarras.Name = "lbCodigoBarras";
            lbCodigoBarras.Size = new Size(121, 21);
            lbCodigoBarras.TabIndex = 2;
            lbCodigoBarras.Text = "99999/999/888";
            lbCodigoBarras.Click += lbCodigoBarras_Click;
            // 
            // tbRegistro
            // 
            tbRegistro.AutoSize = true;
            tbRegistro.Font = new Font("Segoe UI", 12F);
            tbRegistro.Location = new Point(7, 1);
            tbRegistro.Name = "tbRegistro";
            tbRegistro.Size = new Size(0, 21);
            tbRegistro.TabIndex = 3;
            tbRegistro.Click += lbRegistro_Click;
            // 
            // lbValidade
            // 
            lbValidade.AutoSize = true;
            lbValidade.Font = new Font("Segoe UI", 12F);
            lbValidade.Location = new Point(10, 1);
            lbValidade.Name = "lbValidade";
            lbValidade.Size = new Size(88, 21);
            lbValidade.TabIndex = 4;
            lbValidade.Text = "Não consta";
            lbValidade.Click += label2_Click;
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.Font = new Font("Segoe UI", 12F);
            lbPeso.Location = new Point(3, 1);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(37, 21);
            lbPeso.TabIndex = 5;
            lbPeso.Text = "50g";
            lbPeso.Click += lbPeso_Click;
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Font = new Font("Segoe UI", 12F);
            lbPreco.Location = new Point(3, 1);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(63, 21);
            lbPreco.TabIndex = 6;
            lbPreco.Text = "R$ 4,00";
            lbPreco.Click += lbPreco_Click;
            // 
            // lbEstoque
            // 
            lbEstoque.AutoSize = true;
            lbEstoque.BackColor = Color.FromArgb(62, 41, 71);
            lbEstoque.Font = new Font("Segoe UI", 12F);
            lbEstoque.Location = new Point(3, 1);
            lbEstoque.Name = "lbEstoque";
            lbEstoque.Size = new Size(59, 21);
            lbEstoque.TabIndex = 7;
            lbEstoque.Text = "500 un";
            lbEstoque.Click += lbEstoque_Click;
            // 
            // lbVolume
            // 
            lbVolume.AutoSize = true;
            lbVolume.Font = new Font("Segoe UI", 12F);
            lbVolume.Location = new Point(3, 1);
            lbVolume.Name = "lbVolume";
            lbVolume.Size = new Size(46, 21);
            lbVolume.TabIndex = 8;
            lbVolume.Text = "50ml";
            lbVolume.Click += lbVolume_Click;
            // 
            // lbCusto
            // 
            lbCusto.AutoSize = true;
            lbCusto.Font = new Font("Segoe UI", 12F);
            lbCusto.Location = new Point(3, 1);
            lbCusto.Name = "lbCusto";
            lbCusto.Size = new Size(63, 21);
            lbCusto.TabIndex = 9;
            lbCusto.Text = "R$ 2,00";
            lbCusto.Click += lbCusto_Click;
            // 
            // lbMarca
            // 
            lbMarca.AutoSize = true;
            lbMarca.Font = new Font("Segoe UI", 12F);
            lbMarca.Location = new Point(3, 1);
            lbMarca.Name = "lbMarca";
            lbMarca.Size = new Size(74, 21);
            lbMarca.TabIndex = 10;
            lbMarca.Text = "Richester";
            lbMarca.Click += lbMarca_Click;
            // 
            // lbProvedor
            // 
            lbProvedor.AutoSize = true;
            lbProvedor.Font = new Font("Segoe UI", 12F);
            lbProvedor.Location = new Point(3, 2);
            lbProvedor.Name = "lbProvedor";
            lbProvedor.Size = new Size(110, 21);
            lbProvedor.TabIndex = 11;
            lbProvedor.Text = "M Dias Branco";
            lbProvedor.Click += lbProvedor_Click;
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Font = new Font("Segoe UI", 12F);
            lbCategoria.Location = new Point(3, 1);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(168, 21);
            lbCategoria.TabIndex = 12;
            lbCategoria.Text = "Industrializados, Doces";
            // 
            // lbDescricao
            // 
            lbDescricao.AutoSize = true;
            lbDescricao.Font = new Font("Segoe UI", 12F);
            lbDescricao.Location = new Point(3, 1);
            lbDescricao.Name = "lbDescricao";
            lbDescricao.Size = new Size(349, 21);
            lbDescricao.TabIndex = 13;
            lbDescricao.Text = "Promoção com -5% de desconto toda sexta-feira.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(62, 41, 71);
            panel1.Controls.Add(tbCodigoBarras);
            panel1.Controls.Add(lbCodigoBarras);
            panel1.Location = new Point(11, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 25);
            panel1.TabIndex = 14;
            // 
            // tbCodigoBarras
            // 
            tbCodigoBarras.BackColor = Color.FromArgb(62, 41, 71);
            tbCodigoBarras.BorderStyle = BorderStyle.None;
            tbCodigoBarras.Font = new Font("Segoe UI", 12F);
            tbCodigoBarras.ForeColor = Color.White;
            tbCodigoBarras.Location = new Point(5, 2);
            tbCodigoBarras.Name = "tbCodigoBarras";
            tbCodigoBarras.Size = new Size(167, 22);
            tbCodigoBarras.TabIndex = 38;
            tbCodigoBarras.TextChanged += tbCodigoBarras_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(62, 41, 71);
            panel2.Controls.Add(tbRegis);
            panel2.Controls.Add(tbRegistro);
            panel2.Controls.Add(lbRegis);
            panel2.Location = new Point(357, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(108, 25);
            panel2.TabIndex = 15;
            // 
            // tbRegis
            // 
            tbRegis.BackColor = Color.FromArgb(62, 41, 71);
            tbRegis.BorderStyle = BorderStyle.None;
            tbRegis.Font = new Font("Segoe UI", 12F);
            tbRegis.ForeColor = Color.White;
            tbRegis.Location = new Point(4, 2);
            tbRegis.Name = "tbRegis";
            tbRegis.Size = new Size(99, 22);
            tbRegis.TabIndex = 38;
            tbRegis.TextChanged += tbRegis_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(62, 41, 71);
            panel3.Controls.Add(tbValidade);
            panel3.Controls.Add(lbValidade);
            panel3.Location = new Point(485, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(108, 25);
            panel3.TabIndex = 16;
            // 
            // tbValidade
            // 
            tbValidade.BackColor = Color.FromArgb(62, 41, 71);
            tbValidade.BorderStyle = BorderStyle.None;
            tbValidade.Font = new Font("Segoe UI", 12F);
            tbValidade.ForeColor = Color.White;
            tbValidade.Location = new Point(5, 2);
            tbValidade.Name = "tbValidade";
            tbValidade.Size = new Size(99, 22);
            tbValidade.TabIndex = 38;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(62, 41, 71);
            panel4.Controls.Add(tbCusto);
            panel4.Controls.Add(lbCusto);
            panel4.Location = new Point(11, 90);
            panel4.Name = "panel4";
            panel4.Size = new Size(108, 25);
            panel4.TabIndex = 16;
            // 
            // tbCusto
            // 
            tbCusto.BackColor = Color.FromArgb(62, 41, 71);
            tbCusto.BorderStyle = BorderStyle.None;
            tbCusto.Font = new Font("Segoe UI", 12F);
            tbCusto.ForeColor = Color.White;
            tbCusto.Location = new Point(5, 2);
            tbCusto.Name = "tbCusto";
            tbCusto.Size = new Size(99, 22);
            tbCusto.TabIndex = 39;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(62, 41, 71);
            panel5.Controls.Add(tbPreco);
            panel5.Controls.Add(lbPreco);
            panel5.Location = new Point(138, 90);
            panel5.Name = "panel5";
            panel5.Size = new Size(108, 25);
            panel5.TabIndex = 17;
            // 
            // tbPreco
            // 
            tbPreco.BackColor = Color.FromArgb(62, 41, 71);
            tbPreco.BorderStyle = BorderStyle.None;
            tbPreco.Font = new Font("Segoe UI", 12F);
            tbPreco.ForeColor = Color.White;
            tbPreco.Location = new Point(7, 1);
            tbPreco.Name = "tbPreco";
            tbPreco.Size = new Size(99, 22);
            tbPreco.TabIndex = 37;
            tbPreco.TextChanged += tbPreco_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(62, 41, 71);
            panel6.Controls.Add(tbEstoque);
            panel6.Controls.Add(lbEstoque);
            panel6.Location = new Point(297, 90);
            panel6.Name = "panel6";
            panel6.Size = new Size(85, 25);
            panel6.TabIndex = 18;
            // 
            // tbEstoque
            // 
            tbEstoque.BackColor = Color.FromArgb(62, 41, 71);
            tbEstoque.BorderStyle = BorderStyle.None;
            tbEstoque.Font = new Font("Segoe UI", 12F);
            tbEstoque.ForeColor = Color.White;
            tbEstoque.Location = new Point(7, 1);
            tbEstoque.Name = "tbEstoque";
            tbEstoque.Size = new Size(78, 22);
            tbEstoque.TabIndex = 38;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(62, 41, 71);
            panel7.Controls.Add(tbPeso);
            panel7.Controls.Add(lbPeso);
            panel7.Location = new Point(403, 90);
            panel7.Name = "panel7";
            panel7.Size = new Size(85, 25);
            panel7.TabIndex = 18;
            // 
            // tbPeso
            // 
            tbPeso.BackColor = Color.FromArgb(62, 41, 71);
            tbPeso.BorderStyle = BorderStyle.None;
            tbPeso.Font = new Font("Segoe UI", 12F);
            tbPeso.ForeColor = Color.White;
            tbPeso.Location = new Point(3, 2);
            tbPeso.Name = "tbPeso";
            tbPeso.Size = new Size(79, 22);
            tbPeso.TabIndex = 38;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(62, 41, 71);
            panel8.Controls.Add(tbVolume);
            panel8.Controls.Add(lbVolume);
            panel8.Location = new Point(508, 90);
            panel8.Name = "panel8";
            panel8.Size = new Size(85, 25);
            panel8.TabIndex = 19;
            // 
            // tbVolume
            // 
            tbVolume.BackColor = Color.FromArgb(62, 41, 71);
            tbVolume.BorderStyle = BorderStyle.None;
            tbVolume.Font = new Font("Segoe UI", 12F);
            tbVolume.ForeColor = Color.White;
            tbVolume.Location = new Point(5, 2);
            tbVolume.Name = "tbVolume";
            tbVolume.Size = new Size(79, 22);
            tbVolume.TabIndex = 38;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(62, 41, 71);
            panel9.Controls.Add(tbMarca);
            panel9.Controls.Add(lbMarca);
            panel9.Location = new Point(11, 158);
            panel9.Name = "panel9";
            panel9.Size = new Size(280, 25);
            panel9.TabIndex = 15;
            // 
            // tbMarca
            // 
            tbMarca.BackColor = Color.FromArgb(62, 41, 71);
            tbMarca.BorderStyle = BorderStyle.None;
            tbMarca.Font = new Font("Segoe UI", 12F);
            tbMarca.ForeColor = Color.White;
            tbMarca.Location = new Point(7, 1);
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(272, 22);
            tbMarca.TabIndex = 39;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(62, 41, 71);
            panel10.Controls.Add(tbProvedor);
            panel10.Controls.Add(lbProvedor);
            panel10.Location = new Point(313, 158);
            panel10.Name = "panel10";
            panel10.Size = new Size(280, 25);
            panel10.TabIndex = 16;
            // 
            // tbProvedor
            // 
            tbProvedor.BackColor = Color.FromArgb(62, 41, 71);
            tbProvedor.BorderStyle = BorderStyle.None;
            tbProvedor.Font = new Font("Segoe UI", 12F);
            tbProvedor.ForeColor = Color.White;
            tbProvedor.Location = new Point(5, 2);
            tbProvedor.Name = "tbProvedor";
            tbProvedor.Size = new Size(272, 22);
            tbProvedor.TabIndex = 40;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(62, 41, 71);
            panel11.Controls.Add(tbCategoria);
            panel11.Controls.Add(lbCategoria);
            panel11.Location = new Point(11, 226);
            panel11.Name = "panel11";
            panel11.Size = new Size(582, 25);
            panel11.TabIndex = 15;
            // 
            // tbCategoria
            // 
            tbCategoria.BackColor = Color.FromArgb(62, 41, 71);
            tbCategoria.BorderStyle = BorderStyle.None;
            tbCategoria.Font = new Font("Segoe UI", 12F);
            tbCategoria.ForeColor = Color.White;
            tbCategoria.Location = new Point(7, 1);
            tbCategoria.Name = "tbCategoria";
            tbCategoria.Size = new Size(574, 22);
            tbCategoria.TabIndex = 41;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(62, 41, 71);
            panel12.Controls.Add(tbDescricao);
            panel12.Controls.Add(lbDescricao);
            panel12.Location = new Point(11, 293);
            panel12.Name = "panel12";
            panel12.Size = new Size(582, 25);
            panel12.TabIndex = 16;
            // 
            // tbDescricao
            // 
            tbDescricao.BackColor = Color.FromArgb(62, 41, 71);
            tbDescricao.BorderStyle = BorderStyle.None;
            tbDescricao.Font = new Font("Segoe UI", 12F);
            tbDescricao.ForeColor = Color.White;
            tbDescricao.Location = new Point(4, 2);
            tbDescricao.Name = "tbDescricao";
            tbDescricao.Size = new Size(569, 22);
            tbDescricao.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 1);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 20;
            label1.Text = "Código de Barras:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(357, 1);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 21;
            label3.Text = "Registro:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 1);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 22;
            label4.Text = "Validade:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 72);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 23;
            label5.Text = "Custo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 72);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 24;
            label6.Text = "Preço:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(297, 72);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 25;
            label7.Text = "Qtd. Estoque:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(403, 72);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 26;
            label8.Text = "Peso:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(508, 72);
            label9.Name = "label9";
            label9.Size = new Size(50, 15);
            label9.TabIndex = 27;
            label9.Text = "Volume:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 140);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 28;
            label10.Text = "Marca:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(313, 140);
            label11.Name = "label11";
            label11.Size = new Size(70, 15);
            label11.TabIndex = 29;
            label11.Text = "Fornecedor:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 208);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 30;
            label12.Text = "Categoria:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 275);
            label13.Name = "label13";
            label13.Size = new Size(77, 15);
            label13.TabIndex = 31;
            label13.Text = "Observações:";
            // 
            // btnEditar
            // 
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.FromArgb(43, 27, 50);
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.Location = new Point(531, 23);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(40, 40);
            btnEditar.TabIndex = 32;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Cursor = Cursors.Hand;
            btnExcluir.FlatAppearance.BorderSize = 0;
            btnExcluir.FlatStyle = FlatStyle.Flat;
            btnExcluir.ForeColor = Color.FromArgb(43, 27, 50);
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.Location = new Point(588, 25);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(40, 40);
            btnExcluir.TabIndex = 33;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12.75F);
            label14.Location = new Point(9, 40);
            label14.Name = "label14";
            label14.Size = new Size(36, 23);
            label14.TabIndex = 34;
            label14.Text = "ID: ";
            label14.Click += label14_Click;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 12.75F);
            lbID.Location = new Point(39, 40);
            lbID.Name = "lbID";
            lbID.Size = new Size(28, 23);
            lbID.TabIndex = 35;
            lbID.Text = "01";
            lbID.TextAlign = ContentAlignment.MiddleLeft;
            lbID.Click += lbID_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(label13);
            panel13.Controls.Add(label12);
            panel13.Controls.Add(label11);
            panel13.Controls.Add(label10);
            panel13.Controls.Add(label9);
            panel13.Controls.Add(label8);
            panel13.Controls.Add(label7);
            panel13.Controls.Add(label6);
            panel13.Controls.Add(label5);
            panel13.Controls.Add(label4);
            panel13.Controls.Add(label3);
            panel13.Controls.Add(label1);
            panel13.Controls.Add(panel12);
            panel13.Controls.Add(panel11);
            panel13.Controls.Add(panel10);
            panel13.Controls.Add(panel9);
            panel13.Controls.Add(panel8);
            panel13.Controls.Add(panel7);
            panel13.Controls.Add(panel6);
            panel13.Controls.Add(panel5);
            panel13.Controls.Add(panel4);
            panel13.Controls.Add(panel3);
            panel13.Controls.Add(panel2);
            panel13.Controls.Add(panel1);
            panel13.Location = new Point(35, 91);
            panel13.Name = "panel13";
            panel13.Size = new Size(602, 326);
            panel13.TabIndex = 36;
            // 
            // panel14
            // 
            panel14.Controls.Add(tbNome);
            panel14.Controls.Add(lbID);
            panel14.Controls.Add(label14);
            panel14.Controls.Add(lbNome);
            panel14.Location = new Point(35, 19);
            panel14.Name = "panel14";
            panel14.Size = new Size(482, 70);
            panel14.TabIndex = 37;
            panel14.Paint += panel14_Paint;
            // 
            // tbNome
            // 
            tbNome.BackColor = Color.FromArgb(62, 41, 71);
            tbNome.BorderStyle = BorderStyle.None;
            tbNome.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            tbNome.ForeColor = Color.White;
            tbNome.Location = new Point(12, 0);
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(470, 40);
            tbNome.TabIndex = 36;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(196, 165, 237);
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = Color.Black;
            btnConfirm.Location = new Point(531, 426);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(106, 23);
            btnConfirm.TabIndex = 38;
            btnConfirm.Text = "Confirmar";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.WhiteSmoke;
            btnCancel.Location = new Point(419, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 25);
            btnCancel.TabIndex = 39;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnHoverEditar
            // 
            btnHoverEditar.BackColor = Color.White;
            btnHoverEditar.Cursor = Cursors.Hand;
            btnHoverEditar.FlatAppearance.BorderSize = 0;
            btnHoverEditar.FlatStyle = FlatStyle.Flat;
            btnHoverEditar.ForeColor = Color.White;
            btnHoverEditar.Image = (Image)resources.GetObject("btnHoverEditar.Image");
            btnHoverEditar.Location = new Point(588, 25);
            btnHoverEditar.Name = "btnHoverEditar";
            btnHoverEditar.Size = new Size(40, 40);
            btnHoverEditar.TabIndex = 40;
            btnHoverEditar.UseVisualStyleBackColor = false;
            // 
            // lbRegis
            // 
            lbRegis.AutoSize = true;
            lbRegis.Font = new Font("Segoe UI", 12F);
            lbRegis.Location = new Point(3, 1);
            lbRegis.Name = "lbRegis";
            lbRegis.Size = new Size(92, 21);
            lbRegis.TabIndex = 39;
            lbRegis.Text = "Dias Branco";
            // 
            // ViewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(43, 27, 50);
            ClientSize = new Size(675, 467);
            Controls.Add(btnHoverEditar);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(panel14);
            Controls.Add(panel13);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCloseView);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewProduct";
            StartPosition = FormStartPosition.CenterParent;
            Text = "p";
            TopMost = true;
            Load += ViewProduct_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lbNome;
        private Button btnCloseView;
        private Label lbCodigoBarras;
        private Label tbRegistro;
        private Label lbValidade;
        private Label lbPeso;
        private Label lbPreco;
        private Label lbEstoque;
        private Label lbVolume;
        private Label lbCusto;
        private Label lbMarca;
        private Label lbProvedor;
        private Label lbCategoria;
        private Label lbDescricao;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnEditar;
        private Button btnExcluir;
        private Label label14;
        private Label lbID;
        private Panel panel13;
        private Panel panel14;
        private Button btnConfirm;
        private Button btnCancel;
        private TextBox tbNome;
        private TextBox tbEstoque;
        private TextBox tbMarca;
        private TextBox tbProvedor;
        private TextBox tbCategoria;
        private TextBox tbPreco;
        private Button btnHoverEditar;
        private TextBox tbCodigoBarras;
        private TextBox tbRegis;
        private TextBox tbValidade;
        private TextBox tbCusto;
        private TextBox tbPeso;
        private TextBox tbVolume;
        private TextBox tbDescricao;
        private Label lbRegis;
    }
}