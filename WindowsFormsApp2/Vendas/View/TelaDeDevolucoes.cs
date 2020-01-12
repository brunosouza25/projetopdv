﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Vendas.View
{
    public partial class TelaDeDevolucoes : UserControl
    {
        DadosTableAdapters.Itens_DevolucaoTableAdapter dadosDevolucao = new DadosTableAdapters.Itens_DevolucaoTableAdapter();
        string deData, ateData;
        public TelaDeDevolucoes()
        {
            InitializeComponent();
            deData = DateTime.Now.ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void carregarListaDevolucoes()
        {
            var auxDevo = dadosDevolucao.retornarDevolucoes(Convert.ToDateTime(deData), Convert.ToDateTime(ateData));

            listaDevolucoes.Items.Clear();


            for (int i = 0; i < auxDevo.Count; i++)
            {
                ListViewItem item = new ListViewItem();

                item.SubItems.Add(auxDevo[i]["idItensDevolucao"].ToString());
                item.SubItems.Add(auxDevo[i]["idVenda"].ToString());
                item.SubItems.Add(Convert.ToDateTime(auxDevo[i]["dataDevolucao"]).ToString("dd/MM/yyyy"));
                //item.SubItems.Add(auxDevo[i]["observacoes"].ToString());

                listaDevolucoes.Items.Add(item);
            }
        }
        private void btnHoje_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarListaDevolucoes();
        }

        private void btnOntem_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            deData = DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");

            carregarListaDevolucoes();
        }

        private void btn7Dias_Click(object sender, EventArgs e)
        {
            deData = DateTime.Now.AddDays(-7).ToString("dd/MM/yyyy");
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            carregarListaDevolucoes();
        }

        private void btnEsteMes_Click(object sender, EventArgs e)
        {
            ateData = DateTime.Now.ToString("dd/MM/yyyy");
            deData = DateTime.Now.ToString("01/MM/yyyy");
            carregarListaDevolucoes();
        }

        private void btnMesPassado_Click(object sender, EventArgs e)
        {

            //DateTime ultimoDiaDoMes = new DateTime(data.Year, data.Month, DateTime.DaysInMonth(data.Year, data.Month));



            var data = DateTime.Now.AddMonths(-1);
            var ultimoDia = DateTime.DaysInMonth(data.Year, data.Month);
            var dataUltimoDia = new DateTime(data.Year, data.Month, ultimoDia); //possibilidade de remoção desta linha

            ateData = (dataUltimoDia.ToString("01/MM/yyyy"));
            deData = (dataUltimoDia.ToString("dd/MM/yyyy"));
            carregarListaDevolucoes();

        }

        private void btnUltimos3Meses_Click(object sender, EventArgs e)
        {

            var data = DateTime.Now.AddMonths(-3);

            ateData = (DateTime.Now.ToString("dd/MM/yyyy"));
            deData = (data.ToString("dd/MM/yyyy"));
            carregarListaDevolucoes();
        }

        private void btnDevo_Click(object sender, EventArgs e)
        {
            TelaDevolucao devolucao = new TelaDevolucao();
            devolucao.ShowDialog();
            carregarListaDevolucoes() ;
        }

        private void btnPerso_Click(object sender, EventArgs e)
        {
            DateTime a, b;
            if (DateTime.TryParse(txtBoxDeMes.Text, out a) && DateTime.TryParse(txtBoxAteMes.Text, out b) && b > a)
            {
                deData = txtBoxDeMes.Text;
                ateData = txtBoxAteMes.Text;
                carregarListaDevolucoes();
            }
            else
                MessageBox.Show("Datas invalidas");
        }
    }
}