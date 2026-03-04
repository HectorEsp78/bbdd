using LabBBDD.dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabBBDD.presentación
{
    public partial class FormPaises : Form
    {
        public FormPaises()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FormPaises_Load(object sender, EventArgs e)
        {
            Pais pAux = new Pais("1");
            try
            {
                List<Pais> paises = pAux.ObtenerTodosPaises();
                foreach (Pais p in paises) {
                    lstPaises.Items.Add(p);
                }
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPaises.SelectedItem != null)
            {
                Pais p = lstPaises.SelectedItem as Pais;
                txtId.Text = p.Id;
                txtNombre.Text = p.Nombre;
                numBaseImpuestos.Value = p.BaseImpuestos;
                btnInsertar.Enabled = false;
                btnEliminar.Enabled = true;
                btnActualizar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty)
            {
                Pais pais = new Pais(txtId.Text);
                if (MessageBox.Show("Estas seguro de borrar " + pais.Id + "?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        if (pais.EliminarPais() == 1)
                        {
                            int indice = lstPaises.SelectedIndex;
                            lstPaises.Items.RemoveAt(indice);
                            btnLimpiar.PerformClick();
                            btnInsertar.Enabled = true; // borrar?
                            btnActualizar.Enabled = true; // borrar?
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }

             private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty && txtNombre.Text != string.Empty)
            {
                Pais pais = new Pais(txtId.Text);
                pais.Nombre = txtNombre.Text;
                pais.BaseImpuestos = numBaseImpuestos.Value;
                try
                {
                    if (pais.ActualizarPais() == 1)
                    {
                        int indice = lstPaises.SelectedIndex;
                        lstPaises.Items.RemoveAt(indice);
                        lstPaises.Items.Insert(indice, pais);
                        btnLimpiar.PerformClick();
                    }
                }
                catch
                {
                }
            }
        }
        private string obtenerId(string nombre)
        {
            string nombreNorm = new string(
                nombre.Normalize(System.Text.NormalizationForm.FormD)
                      .Where(c => System.Globalization.CharUnicodeInfo.GetUnicodeCategory(c)
                                  != System.Globalization.UnicodeCategory.NonSpacingMark)
                      .ToArray()
            ).ToUpper();

            string idBase = nombreNorm.Substring(0, Math.Min(3, nombreNorm.Length)).PadRight(3, 'A');
            string Id = idBase;

            int letraIdx = 3;
            Pais pAux = new Pais("_"); 

            while (pAux.IdExiste(Id) && letraIdx < nombreNorm.Length)
            {
                Id = idBase.Substring(0, 2) + nombreNorm[letraIdx];
                letraIdx++;
            }

            return Id;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Pais pAux = new Pais();
            try
            {
                List<Pais> paises = pAux.ObtenerTodosPaises();
                foreach (Pais p in paises)
                {
                    lstPaises.Items.Add(p);
                }
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != string.Empty)
            {
                string Id = obtenerId(txtNombre.Text);
                Pais pais = new Pais(Id);
                pais.Nombre = txtNombre.Text;
                pais.BaseImpuestos = numBaseImpuestos.Value;
                try
                {
                    if (pais.InsertarPais() == 1)
                    {
                        lstPaises.Items.Add(pais);
                        btnLimpiar.PerformClick();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source);
                }

            }
        }
    }

    }

