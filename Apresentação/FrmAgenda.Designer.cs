namespace system_infuture.Apresentação
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAtivo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Campo_idConsulta = new System.Windows.Forms.TextBox();
            this.txtbuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Campo_Pesquisar = new System.Windows.Forms.MaskedTextBox();
            this.Campo_Horario = new System.Windows.Forms.MaskedTextBox();
            this.Campo_Retorno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Campo_Celular = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Campo_idCliente = new System.Windows.Forms.TextBox();
            this.Campo_DataConsulta = new System.Windows.Forms.DateTimePicker();
            this.Campo_MotivoConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHorario = new System.Windows.Forms.Label();
            this.Campo_idMedico = new System.Windows.Forms.ComboBox();
            this.tbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbData = new System.Windows.Forms.Label();
            this.lbMMedico = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conteúdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbAtivo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Campo_idConsulta);
            this.groupBox1.Controls.Add(this.txtbuscar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Campo_Pesquisar);
            this.groupBox1.Controls.Add(this.Campo_Horario);
            this.groupBox1.Controls.Add(this.Campo_Retorno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Campo_Celular);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Campo_idCliente);
            this.groupBox1.Controls.Add(this.Campo_DataConsulta);
            this.groupBox1.Controls.Add(this.Campo_MotivoConsulta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbHorario);
            this.groupBox1.Controls.Add(this.Campo_idMedico);
            this.groupBox1.Controls.Add(this.tbTelefone);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.lbData);
            this.groupBox1.Controls.Add(this.lbMMedico);
            this.groupBox1.Controls.Add(this.lbTelefone);
            this.groupBox1.Controls.Add(this.lbNome);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agentamento de consulta";
            // 
            // cbAtivo
            // 
            this.cbAtivo.FormattingEnabled = true;
            this.cbAtivo.Items.AddRange(new object[] {
            "Aguardando",
            "Finalizado"});
            this.cbAtivo.Location = new System.Drawing.Point(686, 235);
            this.cbAtivo.Name = "cbAtivo";
            this.cbAtivo.Size = new System.Drawing.Size(69, 21);
            this.cbAtivo.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(629, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Status :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(573, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "IdConsulta";
            // 
            // Campo_idConsulta
            // 
            this.Campo_idConsulta.Location = new System.Drawing.Point(636, 53);
            this.Campo_idConsulta.Name = "Campo_idConsulta";
            this.Campo_idConsulta.ReadOnly = true;
            this.Campo_idConsulta.Size = new System.Drawing.Size(98, 20);
            this.Campo_idConsulta.TabIndex = 48;
            // 
            // txtbuscar
            // 
            this.txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.txtbuscar.Location = new System.Drawing.Point(261, 48);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(75, 23);
            this.txtbuscar.TabIndex = 47;
            this.txtbuscar.Text = "Buscar";
            this.txtbuscar.UseVisualStyleBackColor = true;
            this.txtbuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "CPF";
            // 
            // Campo_Pesquisar
            // 
            this.Campo_Pesquisar.Location = new System.Drawing.Point(139, 50);
            this.Campo_Pesquisar.Mask = "000,000,000-00";
            this.Campo_Pesquisar.Name = "Campo_Pesquisar";
            this.Campo_Pesquisar.Size = new System.Drawing.Size(100, 20);
            this.Campo_Pesquisar.TabIndex = 45;
            // 
            // Campo_Horario
            // 
            this.Campo_Horario.Location = new System.Drawing.Point(490, 174);
            this.Campo_Horario.Mask = "00:00";
            this.Campo_Horario.Name = "Campo_Horario";
            this.Campo_Horario.Size = new System.Drawing.Size(50, 20);
            this.Campo_Horario.TabIndex = 43;
            this.Campo_Horario.ValidatingType = typeof(System.DateTime);
            // 
            // Campo_Retorno
            // 
            this.Campo_Retorno.FormattingEnabled = true;
            this.Campo_Retorno.Items.AddRange(new object[] {
            "Não",
            "Sim"});
            this.Campo_Retorno.Location = new System.Drawing.Point(549, 235);
            this.Campo_Retorno.Name = "Campo_Retorno";
            this.Campo_Retorno.Size = new System.Drawing.Size(69, 21);
            this.Campo_Retorno.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(492, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Retorno :";
            // 
            // Campo_Celular
            // 
            this.Campo_Celular.Location = new System.Drawing.Point(324, 128);
            this.Campo_Celular.Mask = "(00)0-0000-0000";
            this.Campo_Celular.Name = "Campo_Celular";
            this.Campo_Celular.Size = new System.Drawing.Size(101, 20);
            this.Campo_Celular.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(273, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Celular :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(581, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "IdCliente";
            // 
            // Campo_idCliente
            // 
            this.Campo_idCliente.Location = new System.Drawing.Point(636, 19);
            this.Campo_idCliente.Name = "Campo_idCliente";
            this.Campo_idCliente.ReadOnly = true;
            this.Campo_idCliente.Size = new System.Drawing.Size(98, 20);
            this.Campo_idCliente.TabIndex = 33;
            // 
            // Campo_DataConsulta
            // 
            this.Campo_DataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Campo_DataConsulta.Location = new System.Drawing.Point(312, 176);
            this.Campo_DataConsulta.Name = "Campo_DataConsulta";
            this.Campo_DataConsulta.Size = new System.Drawing.Size(106, 20);
            this.Campo_DataConsulta.TabIndex = 14;
            // 
            // Campo_MotivoConsulta
            // 
            this.Campo_MotivoConsulta.Location = new System.Drawing.Point(140, 211);
            this.Campo_MotivoConsulta.Name = "Campo_MotivoConsulta";
            this.Campo_MotivoConsulta.Size = new System.Drawing.Size(346, 20);
            this.Campo_MotivoConsulta.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Motivo da consulta :";
            // 
            // lbHorario
            // 
            this.lbHorario.AutoSize = true;
            this.lbHorario.ForeColor = System.Drawing.Color.White;
            this.lbHorario.Location = new System.Drawing.Point(437, 177);
            this.lbHorario.Name = "lbHorario";
            this.lbHorario.Size = new System.Drawing.Size(47, 13);
            this.lbHorario.TabIndex = 8;
            this.lbHorario.Text = "Horario :";
            // 
            // Campo_idMedico
            // 
            this.Campo_idMedico.FormattingEnabled = true;
            this.Campo_idMedico.Location = new System.Drawing.Point(140, 174);
            this.Campo_idMedico.Name = "Campo_idMedico";
            this.Campo_idMedico.Size = new System.Drawing.Size(121, 21);
            this.Campo_idMedico.TabIndex = 6;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(139, 128);
            this.tbTelefone.Mask = "(00)0000-0000";
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(102, 20);
            this.tbTelefone.TabIndex = 5;
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(140, 87);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(292, 20);
            this.tbNome.TabIndex = 4;
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.ForeColor = System.Drawing.Color.White;
            this.lbData.Location = new System.Drawing.Point(274, 179);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(36, 13);
            this.lbData.TabIndex = 3;
            this.lbData.Text = "Data :";
            // 
            // lbMMedico
            // 
            this.lbMMedico.AutoSize = true;
            this.lbMMedico.ForeColor = System.Drawing.Color.White;
            this.lbMMedico.Location = new System.Drawing.Point(86, 182);
            this.lbMMedico.Name = "lbMMedico";
            this.lbMMedico.Size = new System.Drawing.Size(48, 13);
            this.lbMMedico.TabIndex = 2;
            this.lbMMedico.Text = "Medico :";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.ForeColor = System.Drawing.Color.White;
            this.lbTelefone.Location = new System.Drawing.Point(78, 131);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(55, 13);
            this.lbTelefone.TabIndex = 1;
            this.lbTelefone.Text = "Telefone :";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.ForeColor = System.Drawing.Color.White;
            this.lbNome.Location = new System.Drawing.Point(90, 87);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(44, 13);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome : ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agendamentoToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.agendamentoToolStripMenuItem.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.agendamentoToolStripMenuItem.Text = "Agendamento";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.clienteToolStripMenuItem.Text = "Cadastro de cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.opçõesToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.ferramentasToolStripMenuItem.Text = "Ferra&mentas";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.opçõesToolStripMenuItem.Text = "&Opções";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conteúdoToolStripMenuItem,
            this.índiceToolStripMenuItem,
            this.pesquisarToolStripMenuItem,
            this.toolStripSeparator5,
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.ajudaToolStripMenuItem.Text = "Aj&uda";
            // 
            // conteúdoToolStripMenuItem
            // 
            this.conteúdoToolStripMenuItem.Name = "conteúdoToolStripMenuItem";
            this.conteúdoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.conteúdoToolStripMenuItem.Text = "&Conteúdo";
            // 
            // índiceToolStripMenuItem
            // 
            this.índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            this.índiceToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.índiceToolStripMenuItem.Text = "Í&ndice";
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pesquisarToolStripMenuItem.Text = "&Pesquisar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(124, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.sobreToolStripMenuItem.Text = "&Sobre...";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem,
            this.cancelarToolStripMenuItem,
            this.salvarToolStripMenuItem1,
            this.excluirToolStripMenuItem,
            this.alterarToolStripMenuItem,
            this.testeToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 25);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.Size = new System.Drawing.Size(800, 34);
            this.menuStrip2.TabIndex = 38;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fecharToolStripMenuItem.Image = global::system_infuture.Properties.Resources.icons8_excluir_64;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(70, 34);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cancelarToolStripMenuItem.Image = global::system_infuture.Properties.Resources.icons8_não_editar_64;
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(81, 34);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.salvarToolStripMenuItem1.Image = global::system_infuture.Properties.Resources.icons8_salvar_48;
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(66, 34);
            this.salvarToolStripMenuItem1.Text = "Salvar";
            this.salvarToolStripMenuItem1.Click += new System.EventHandler(this.salvarToolStripMenuItem1_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.excluirToolStripMenuItem.Image = global::system_infuture.Properties.Resources.icons8_remover_64;
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(70, 34);
            this.excluirToolStripMenuItem.Text = "Excluir";
            this.excluirToolStripMenuItem.Click += new System.EventHandler(this.excluirToolStripMenuItem_Click);
            // 
            // alterarToolStripMenuItem
            // 
            this.alterarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.alterarToolStripMenuItem.Image = global::system_infuture.Properties.Resources.icons8_editar_64;
            this.alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            this.alterarToolStripMenuItem.Size = new System.Drawing.Size(70, 34);
            this.alterarToolStripMenuItem.Text = "Alterar";
            this.alterarToolStripMenuItem.Click += new System.EventHandler(this.alterarToolStripMenuItem_Click);
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.AccessibleDescription = "";
            this.testeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.testeToolStripMenuItem.Image = global::system_infuture.Properties.Resources.icons8_pesquisar_16;
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(85, 34);
            this.testeToolStripMenuItem.Text = "Pesquisar";
            this.testeToolStripMenuItem.ToolTipText = "toolTip1";
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AX Soft [ Agendamento ]";
            this.Load += new System.EventHandler(this.agentamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Campo_MotivoConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHorario;
        private System.Windows.Forms.ComboBox Campo_idMedico;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbMMedico;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Campo_idCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Campo_Retorno;
        private System.Windows.Forms.MaskedTextBox Campo_Horario;
        public System.Windows.Forms.MaskedTextBox tbTelefone;
        public System.Windows.Forms.DateTimePicker Campo_DataConsulta;
        public System.Windows.Forms.MaskedTextBox Campo_Celular;
        private System.Windows.Forms.Button txtbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Campo_Pesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Campo_idConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conteúdoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.TextBox tbNome;
        public System.Windows.Forms.ComboBox cbAtivo;
    }
}