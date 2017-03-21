using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Evidenta_Membrilor
{
    public class Form1 : Form
    {
        private TablesManager tablesManager;
        private IContainer components;
        private Label label1;
        private TextBox pk_numarul_fisa_personala;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox date_personale_numarul;
        private TextBox date_personale_judet;
        private TextBox date_personale_strada;
        private TextBox date_personale_telefon;
        private TextBox date_personale_studii;
        private TextBox date_personale_localitatea;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox date_personale_prenume;
        private TextBox date_personale_nume;
        private ComboBox date_personale_calitatea_la_inscriere;
        private GroupBox groupBox2;
        private TextBox starea_civila_modificari_ulterioare_expl;
        private TextBox starea_civila_situatia_la_inscriere_expl;
        private Label label24;
        private Label label23;
        private ComboBox starea_civila_modificari_ulterioare;
        private Label label22;
        private ComboBox starea_civila_situatia_la_inscriere;
        private Label label21;
        private TextBox starea_civila_fiul_si_al;
        private TextBox starea_civila_fiul_lui;
        private Label label20;
        private Label label19;
        private TextBox starea_civila_cnp;
        private Label label18;
        private TextBox starea_civila_locul_nasterii;
        private Label label17;
        private Label label10;
        private GroupBox groupBox3;
        private TextBox primire_membru_expl;
        private Label label26;
        private Label label25;
        private ComboBox primire_membru_modalitatea;
        private GroupBox groupBox4;
        private TextBox acte_cult_inmormantare_pastor;
        private Label label39;
        private TextBox acte_cult_inmormantare_biserica;
        private Label label40;
        private TextBox acte_cult_ordinare_pastor;
        private Label label36;
        private TextBox acte_cult_ordinare_biserica;
        private Label label37;
        private TextBox acte_cult_casatoria_pastor;
        private Label label33;
        private TextBox acte_cult_casatoria_biserica;
        private Label label34;
        private TextBox acte_cult_botez_pastor;
        private Label label30;
        private TextBox acte_cult_botez_biserica;
        private Label label31;
        private TextBox acte_cult_binec_pastor;
        private Label label28;
        private TextBox acte_cult_binec_biserica;
        private Label label29;
        private GroupBox groupBox5;
        private TextBox familia_copil10_nr_fisa;
        private ComboBox familia_copil10_stare_civila;
        private TextBox familia_copil10_nume;
        private TextBox familia_copil9_nr_fisa;
        private ComboBox familia_copil9_stare_civila;
        private TextBox familia_copil9_nume;
        private TextBox familia_copil8_nr_fisa;
        private ComboBox familia_copil8_stare_civila;
        private TextBox familia_copil8_nume;
        private TextBox familia_copil7_nr_fisa;
        private ComboBox familia_copil7_stare_civila;
        private TextBox familia_copil7_nume;
        private TextBox familia_copil6_nr_fisa;
        private ComboBox familia_copil6_stare_civila;
        private TextBox familia_copil6_nume;
        private TextBox familia_copil5_nr_fisa;
        private ComboBox familia_copil5_stare_civila;
        private TextBox familia_copil5_nume;
        private TextBox familia_copil4_nr_fisa;
        private ComboBox familia_copil4_stare_civila;
        private TextBox familia_copil4_nume;
        private TextBox familia_copil3_nr_fisa;
        private ComboBox familia_copil3_stare_civila;
        private TextBox familia_copil3_nume;
        private TextBox familia_copil2_nr_fisa;
        private ComboBox familia_copil2_stare_civila;
        private TextBox familia_copil2_nume;
        private TextBox familia_copil1_nr_fisa;
        private ComboBox familia_copil1_stare_civila;
        private Label label54;
        private Label label53;
        private Label label52;
        private Label label51;
        private Label label50;
        private Label label49;
        private TextBox familia_copil1_nume;
        private TextBox familia_sotul_religie;
        private Label label46;
        private TextBox familia_sotul_localitate;
        private Label label45;
        private Label label44;
        private TextBox familia_sotul_numar_fisa;
        private Label label43;
        private TextBox familia_sotul;
        private CheckBox acte_cult_inmormantare;
        private CheckBox acte_cult_ordinare;
        private CheckBox acte_cult_casatoria;
        private CheckBox acte_cult_botez;
        private CheckBox acte_cult_binec;
        private GroupBox groupBox6;
        private TextBox iesire_evidenta_expl;
        private Label label32;
        private Label label27;
        private Label label12;
        private ComboBox iesire_evidenta_motiv;
        private Label label4;
        private Label label3;
        private Button btn_save;
        private Button btn_delete;
        private Label label38;
        private Label label35;
        private CheckBox familia_copil10;
        private CheckBox familia_copil9;
        private CheckBox familia_copil8;
        private CheckBox familia_copil7;
        private CheckBox familia_copil6;
        private CheckBox familia_copil5;
        private CheckBox familia_copil4;
        private CheckBox familia_copil3;
        private CheckBox familia_copil2;
        private CheckBox familia_copil1;
        private ListView lstMembers;
        private ColumnHeader nr_fisa;
        private ColumnHeader nume;
        private ColumnHeader prenume;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label41;
        private Label memberCount;
        private Label kidsCount;
        private Label label42;
        private Label label47;
        private Label label48;
        private LinkLabel linkLabel1;
        private TextBox date_data_inscrierii;
        private TextBox starea_civila_data_nasterii;
        private TextBox primire_membru_data;
        private TextBox acte_cult_inmormantare_data;
        private TextBox acte_cult_ordinare_data;
        private TextBox acte_cult_casatoria_data;
        private TextBox acte_cult_botez_data;
        private TextBox acte_cult_binec_data;
        private TextBox familia_copil10_data_botez;
        private TextBox familia_copil10_data_binec;
        private TextBox familia_copil10_data_nasterii;
        private TextBox familia_copil9_data_botez;
        private TextBox familia_copil9_data_binec;
        private TextBox familia_copil9_data_nasterii;
        private TextBox familia_copil8_data_botez;
        private TextBox familia_copil8_data_binec;
        private TextBox familia_copil8_data_nasterii;
        private TextBox familia_copil7_data_botez;
        private TextBox familia_copil7_data_binec;
        private TextBox familia_copil7_data_nasterii;
        private TextBox familia_copil6_data_botez;
        private TextBox familia_copil6_data_binec;
        private TextBox familia_copil6_data_nasterii;
        private TextBox familia_copil5_data_botez;
        private TextBox familia_copil5_data_binec;
        private TextBox familia_copil5_data_nasterii;
        private TextBox familia_copil4_data_botez;
        private TextBox familia_copil4_data_binec;
        private TextBox familia_copil4_data_nasterii;
        private TextBox familia_copil3_data_botez;
        private TextBox familia_copil3_data_binec;
        private TextBox familia_copil3_data_nasterii;
        private TextBox familia_copil2_data_botez;
        private TextBox familia_copil2_data_binec;
        private TextBox familia_copil2_data_nasterii;
        private TextBox familia_copil1_data_botez;
        private TextBox familia_copil1_data_binec;
        private TextBox familia_copil1_data_nasterii;
        private TextBox familia_sotul_data_nasterii;
        private TextBox iesire_evidenta_data;
        private Label label55;

        public Form1()
        {
            InitializeComponent();
            initDataBase();
            populateMembersList("");
            clearInputs();
        }

        private void populateMembersList(string query)
        {
            lstMembers.View = View.Details;
            lstMembers.GridLines = true;
            lstMembers.FullRowSelect = true;
            string[] items = new string[3];
            lstMembers.Items.Clear();
            foreach (DisplayedMember allMember in tablesManager.getAllMembers(query))
            {
                items[0] = allMember.NrFisa.ToString();
                items[1] = allMember.Nume;
                items[2] = allMember.Prenume;
                lstMembers.Items.Add(new ListViewItem(items)
                {
                    BackColor = ColorTranslator.FromHtml("#DEDEDE")
                });
            }
            updateStats();
        }

        private void updateStats()
        {
            memberCount.Text = tablesManager.getMembersCount().ToString();
            kidsCount.Text = tablesManager.getChildrenCount().ToString();
        }

        private void initDataBase()
        {
            tablesManager = new TablesManager();
            tablesManager.createDataBaseFile();
            tablesManager.createTables();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(pk_numarul_fisa_personala.Text, out result))
            {
                int num1 = (int)MessageBox.Show("Fisa personala a membrului trebuie sa fie un numar natural!\nDatele nu au putut fi salvate.", "Date incorecte!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id1 = int.Parse(pk_numarul_fisa_personala.Text);
                if (tablesManager.idAlreadyInDataBase(id1))
                {
                    MessageBox.Show("Numarul fisei a mai fost folosit!\nDatele nu au putut fi salvate.", "Date incorecte!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TablesManager tablesManager1 = tablesManager;
                    int id2 = id1;
                    string text1 = date_personale_nume.Text;
                    string text2 = date_personale_prenume.Text;
                    string text3 = date_personale_localitatea.Text;
                    string text4 = date_personale_strada.Text;
                    string text5 = date_personale_numarul.Text;
                    string text6 = date_personale_judet.Text;
                    string text7 = date_personale_telefon.Text;
                    string text8 = date_personale_studii.Text;
                    string calitatea = date_personale_calitatea_la_inscriere.SelectedItem.ToString();
                    string dateTime = date_data_inscrierii.Text;
                    string str1 = tablesManager1.insertDatePersonale(id2, text1, text2, text3, text4, text5, text6, text7, text8, calitatea, dateTime);
                    if (!str1.Equals(Status.OK))
                    {
                        MessageBox.Show(str1 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        TablesManager tablesManager2 = tablesManager;
                        int id3 = id1;
                        string dataNasterii1 = starea_civila_data_nasterii.Text;
                        string text9 = starea_civila_locul_nasterii.Text;
                        string text10 = starea_civila_cnp.Text;
                        string text11 = starea_civila_fiul_lui.Text;
                        string text12 = starea_civila_fiul_si_al.Text;
                        string situatia = starea_civila_situatia_la_inscriere.SelectedItem.ToString();
                        string text13 = starea_civila_situatia_la_inscriere_expl.Text;
                        string modificari = starea_civila_modificari_ulterioare.SelectedItem.ToString();
                        string text14 = starea_civila_modificari_ulterioare_expl.Text;
                        string str2 = tablesManager2.insertStareaCivila(id3, dataNasterii1, text9, text10, text11, text12, situatia, text13, modificari, text14);
                        if (!str2.Equals(Status.OK))
                        {
                            MessageBox.Show(str2 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            TablesManager tablesManager3 = tablesManager;
                            int id4 = id1;
                            string modalitatea = primire_membru_modalitatea.SelectedItem.ToString();
                            string data1 = primire_membru_data.Text;
                            string text15 = primire_membru_expl.Text;
                            string str3 = tablesManager3.insertPrimireMembru(id4, modalitatea, data1, text15);
                            if (!str3.Equals(Status.OK))
                            {
                                MessageBox.Show(str3 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            else
                            {
                                string str4 = insertActeCultInDataBase(id1);
                                if (!str4.Equals(Status.OK))
                                {
                                    MessageBox.Show(str4 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                else
                                {
                                    TablesManager tablesManager4 = tablesManager;
                                    int id5 = id1;
                                    string text16 = familia_sotul.Text;
                                    string text17 = familia_sotul_numar_fisa.Text;
                                    string dataNasterii2 = familia_sotul_data_nasterii.Text;
                                    string text18 = familia_sotul_localitate.Text;
                                    string text19 = familia_sotul_religie.Text;
                                    string str5 = tablesManager4.insertPartener(id5, text16, text17, dataNasterii2, text18, text19);
                                    if (!str5.Equals(Status.OK))
                                    {
                                        MessageBox.Show(str5 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    }
                                    else
                                    {
                                        insertCopiiInDataBase(id1);
                                        TablesManager tablesManager5 = tablesManager;
                                        int id6 = id1;
                                        string motiv = iesire_evidenta_motiv.SelectedItem.ToString();
                                        string data2 = iesire_evidenta_data.Text;
                                        string text20 = iesire_evidenta_expl.Text;
                                        string str6 = tablesManager5.insertIesireEvidenta(id6, motiv, data2, text20);
                                        if (!str6.Equals(Status.OK))
                                        {
                                            MessageBox.Show(str6 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        }
                                        else
                                        {
                                            populateMembersList("");
                                            textBox1.Clear();
                                            clearInputs();
                                            MessageBox.Show("Fisa cu numarul " + (object)id1 + " a fost salvata.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void clearInputs()
        {
            pk_numarul_fisa_personala.Clear();
            date_data_inscrierii.Clear();
            date_personale_nume.Clear();
            date_personale_prenume.Clear();
            date_personale_localitatea.Clear();
            date_personale_strada.Clear();
            date_personale_numarul.Clear();
            date_personale_judet.Clear();
            date_personale_telefon.Clear();
            date_personale_studii.Clear();
            date_personale_calitatea_la_inscriere.SelectedIndex = 0;
            starea_civila_data_nasterii.Clear();
            starea_civila_locul_nasterii.Clear();
            starea_civila_cnp.Clear();
            starea_civila_fiul_lui.Clear();
            starea_civila_fiul_si_al.Clear();
            starea_civila_situatia_la_inscriere.SelectedIndex = 0;
            starea_civila_situatia_la_inscriere_expl.Clear();
            starea_civila_modificari_ulterioare.SelectedIndex = 0;
            starea_civila_modificari_ulterioare_expl.Clear();
            primire_membru_modalitatea.SelectedIndex = 0;
            primire_membru_data.Clear();
            primire_membru_expl.Clear();
            acte_cult_binec.Checked = false;
            acte_cult_binec_data.Clear();
            acte_cult_binec_biserica.Clear();
            acte_cult_binec_pastor.Clear();
            acte_cult_botez.Checked = false;
            acte_cult_botez_data.Clear();
            acte_cult_botez_biserica.Clear();
            acte_cult_botez_pastor.Clear();
            acte_cult_casatoria.Checked = false;
            acte_cult_casatoria_data.Clear();
            acte_cult_casatoria_biserica.Clear();
            acte_cult_casatoria_pastor.Clear();
            acte_cult_ordinare.Checked = false;
            acte_cult_ordinare_data.Clear();
            acte_cult_ordinare_biserica.Clear();
            acte_cult_ordinare_pastor.Clear();
            acte_cult_inmormantare.Checked = false;
            acte_cult_inmormantare_data.Clear();
            acte_cult_inmormantare_biserica.Clear();
            acte_cult_inmormantare_pastor.Clear();
            familia_sotul.Clear();
            familia_sotul_numar_fisa.Clear();
            familia_sotul_data_nasterii.Clear();
            familia_sotul_localitate.Clear();
            familia_sotul_religie.Clear();
            familia_copil1.Checked = false;
            familia_copil1_nume.Clear();
            familia_copil1_data_nasterii.Clear();
            familia_copil1_data_binec.Clear();
            familia_copil1_data_botez.Clear();
            familia_copil1_stare_civila.SelectedIndex = 0;
            familia_copil1_nr_fisa.Clear();
            familia_copil2.Checked = false;
            familia_copil2_nume.Clear();
            familia_copil2_data_nasterii.Clear();
            familia_copil2_data_binec.Clear();
            familia_copil2_data_botez.Clear();
            familia_copil2_stare_civila.SelectedIndex = 0;
            familia_copil2_nr_fisa.Clear();
            familia_copil3.Checked = false;
            familia_copil3_nume.Clear();
            familia_copil3_data_nasterii.Clear();
            familia_copil3_data_binec.Clear();
            familia_copil3_data_botez.Clear();
            familia_copil3_stare_civila.SelectedIndex = 0;
            familia_copil3_nr_fisa.Clear();
            familia_copil4.Checked = false;
            familia_copil4_nume.Clear();
            familia_copil4_data_nasterii.Clear();
            familia_copil4_data_binec.Clear();
            familia_copil4_data_botez.Clear();
            familia_copil4_stare_civila.SelectedIndex = 0;
            familia_copil4_nr_fisa.Clear();
            familia_copil5.Checked = false;
            familia_copil5_nume.Clear();
            familia_copil5_data_nasterii.Clear();
            familia_copil5_data_binec.Clear();
            familia_copil5_data_botez.Clear();
            familia_copil5_stare_civila.SelectedIndex = 0;
            familia_copil5_nr_fisa.Clear();
            familia_copil6.Checked = false;
            familia_copil6_nume.Clear();
            familia_copil6_data_nasterii.Clear();
            familia_copil6_data_binec.Clear();
            familia_copil6_data_botez.Clear();
            familia_copil6_stare_civila.SelectedIndex = 0;
            familia_copil6_nr_fisa.Clear();
            familia_copil7.Checked = false;
            familia_copil7_nume.Clear();
            familia_copil7_data_nasterii.Clear();
            familia_copil7_data_binec.Clear();
            familia_copil7_data_botez.Clear();
            familia_copil7_stare_civila.SelectedIndex = 0;
            familia_copil7_nr_fisa.Clear();
            familia_copil8.Checked = false;
            familia_copil8_nume.Clear();
            familia_copil8_data_nasterii.Clear();
            familia_copil8_data_binec.Clear();
            familia_copil8_data_botez.Clear();
            familia_copil8_stare_civila.SelectedIndex = 0;
            familia_copil8_nr_fisa.Clear();
            familia_copil9.Checked = false;
            familia_copil9_nume.Clear();
            familia_copil9_data_nasterii.Clear();
            familia_copil9_data_binec.Clear();
            familia_copil9_data_botez.Clear();
            familia_copil9_stare_civila.SelectedIndex = 0;
            familia_copil9_nr_fisa.Clear();
            familia_copil10.Checked = false;
            familia_copil10_nume.Clear();
            familia_copil10_data_nasterii.Clear();
            familia_copil10_data_binec.Clear();
            familia_copil10_data_botez.Clear();
            familia_copil10_stare_civila.SelectedIndex = 0;
            familia_copil10_nr_fisa.Clear();
            iesire_evidenta_motiv.SelectedIndex = 0;
            iesire_evidenta_data.Clear();
            iesire_evidenta_expl.Clear();
        }

        private string insertActeCultInDataBase(int id)
        {
            string str1 = Status.OK;
            string str2 = Status.OK;
            string str3 = Status.OK;
            string str4 = Status.OK;
            string str5 = Status.OK;
            if (acte_cult_binec.Checked)
                str1 = tablesManager.insertActCult(id, acte_cult_binec.Text, acte_cult_binec_data.Text, acte_cult_binec_biserica.Text, acte_cult_binec_pastor.Text);
            if (acte_cult_botez.Checked)
                str2 = tablesManager.insertActCult(id, acte_cult_botez.Text, acte_cult_botez_data.Text, acte_cult_botez_biserica.Text, acte_cult_botez_pastor.Text);
            if (acte_cult_casatoria.Checked)
                str3 = tablesManager.insertActCult(id, acte_cult_casatoria.Text, acte_cult_casatoria_data.Text, acte_cult_casatoria_biserica.Text, acte_cult_casatoria_pastor.Text);
            if (acte_cult_inmormantare.Checked)
                str4 = tablesManager.insertActCult(id, acte_cult_inmormantare.Text, acte_cult_inmormantare_data.Text, acte_cult_inmormantare_biserica.Text, acte_cult_inmormantare_pastor.Text);
            if (acte_cult_ordinare.Checked)
                str5 = tablesManager.insertActCult(id, acte_cult_ordinare.Text, acte_cult_ordinare_data.Text, acte_cult_ordinare_biserica.Text, acte_cult_ordinare_pastor.Text);
            if (str1.Equals(Status.OK) && str2.Equals(Status.OK) && (str3.Equals(Status.OK) && str4.Equals(Status.OK)) && str5.Equals(Status.OK))
                return Status.OK;
            return "S-a intamplat o eroare la salvarea actelor de cult in baza de date.";
        }

        private void insertCopiiInDataBase(int id)
        {
            if (familia_copil1.Checked)
                tablesManager.insertCopil(id, 1, familia_copil1_nume.Text, familia_copil1_data_nasterii.Text, familia_copil1_data_binec.Text, familia_copil1_data_botez.Text, familia_copil1_stare_civila.Text, familia_copil1_nr_fisa.Text);
            if (familia_copil2.Checked)
                tablesManager.insertCopil(id, 2, familia_copil2_nume.Text, familia_copil2_data_nasterii.Text, familia_copil2_data_binec.Text, familia_copil2_data_botez.Text, familia_copil2_stare_civila.Text, familia_copil2_nr_fisa.Text);
            if (familia_copil3.Checked)
                tablesManager.insertCopil(id, 3, familia_copil3_nume.Text, familia_copil3_data_nasterii.Text, familia_copil3_data_binec.Text, familia_copil3_data_botez.Text, familia_copil3_stare_civila.Text, familia_copil3_nr_fisa.Text);
            if (familia_copil4.Checked)
                tablesManager.insertCopil(id, 4, familia_copil4_nume.Text, familia_copil4_data_nasterii.Text, familia_copil4_data_binec.Text, familia_copil4_data_botez.Text, familia_copil4_stare_civila.Text, familia_copil4_nr_fisa.Text);
            if (familia_copil5.Checked)
                tablesManager.insertCopil(id, 5, familia_copil5_nume.Text, familia_copil5_data_nasterii.Text, familia_copil5_data_binec.Text, familia_copil5_data_botez.Text, familia_copil5_stare_civila.Text, familia_copil5_nr_fisa.Text);
            if (familia_copil6.Checked)
                tablesManager.insertCopil(id, 6, familia_copil6_nume.Text, familia_copil6_data_nasterii.Text, familia_copil6_data_binec.Text, familia_copil6_data_botez.Text, familia_copil6_stare_civila.Text, familia_copil6_nr_fisa.Text);
            if (familia_copil7.Checked)
                tablesManager.insertCopil(id, 7, familia_copil7_nume.Text, familia_copil7_data_nasterii.Text, familia_copil7_data_binec.Text, familia_copil7_data_botez.Text, familia_copil7_stare_civila.Text, familia_copil7_nr_fisa.Text);
            if (familia_copil8.Checked)
                tablesManager.insertCopil(id, 8, familia_copil8_nume.Text, familia_copil8_data_nasterii.Text, familia_copil8_data_binec.Text, familia_copil8_data_botez.Text, familia_copil8_stare_civila.Text, familia_copil8_nr_fisa.Text);
            if (familia_copil9.Checked)
                tablesManager.insertCopil(id, 9, familia_copil9_nume.Text, familia_copil9_data_nasterii.Text, familia_copil9_data_binec.Text, familia_copil9_data_botez.Text, familia_copil9_stare_civila.Text, familia_copil9_nr_fisa.Text);
            if (!familia_copil10.Checked)
                return;
            tablesManager.insertCopil(id, 10, familia_copil10_nume.Text, familia_copil10_data_nasterii.Text, familia_copil10_data_binec.Text, familia_copil10_data_botez.Text, familia_copil10_stare_civila.Text, familia_copil10_nr_fisa.Text);
        }

        private void lstMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMembers.SelectedItems.Count <= 0)
                return;
            clearInputs();
            int memberId = int.Parse(lstMembers.SelectedItems[0].SubItems[0].Text);
            PersonalData memberPersonalData = tablesManager.getMemberPersonalData(memberId);
            showMemberPersonalData(memberId, memberPersonalData);
            showMemberStareCivila(tablesManager.getMemberStareCivila(memberId));
            showMemberPrimireInfo(tablesManager.getMemberPrimireInfo(memberId));
            showMemberActeCult(tablesManager.getMemberActeCult(memberId));
            showMmeberPartener(tablesManager.getMemberPartener(memberId));
            showMemberChildren(tablesManager.getMemberChildren(memberId));
            showMemberIesireInfo(tablesManager.getMemberIesireInfo(memberId));
        }

        private void showMemberIesireInfo(IesireMembru iesireMembru)
        {
            string motiv = iesireMembru.Motiv;
            if (!(motiv == "Nu se aplică"))
            {
                if (!(motiv == "Transfer"))
                {
                    if (!(motiv == "Deces"))
                    {
                        if (!(motiv == "La cerere"))
                        {
                            if (motiv == "Excludere")
                                iesire_evidenta_motiv.SelectedIndex = 4;
                            else
                                iesire_evidenta_motiv.SelectedIndex = -1;
                        }
                        else
                            iesire_evidenta_motiv.SelectedIndex = 3;
                    }
                    else
                        iesire_evidenta_motiv.SelectedIndex = 2;
                }
                else
                    iesire_evidenta_motiv.SelectedIndex = 1;
            }
            else
                iesire_evidenta_motiv.SelectedIndex = 0;
            iesire_evidenta_data.Text = iesireMembru.Data;
            iesire_evidenta_expl.Text = iesireMembru.Expl;
        }

        private void showMemberChildren(List<MemberChild> children)
        {
            foreach (MemberChild child in children)
            {
                switch (child.Copil_nr)
                {
                    case 1:
                        familia_copil1.Checked = true;
                        familia_copil1_nume.Text = child.Nume;
                        familia_copil1_data_nasterii.Text = child.Data_nasterii;
                        familia_copil1_data_binec.Text = child.Data_binec;
                        familia_copil1_data_botez.Text = child.Data_botez;
                        string stareCivila1 = child.Stare_civila;
                        familia_copil1_stare_civila.SelectedIndex = getChildStareCivilaIndex(stareCivila1);
                        familia_copil1_nr_fisa.Text = child.Nr_fisa;
                        continue;
                    case 2:
                        familia_copil2.Checked = true;
                        familia_copil2_nume.Text = child.Nume;
                        familia_copil2_data_nasterii.Text = child.Data_nasterii;
                        familia_copil2_data_binec.Text = child.Data_binec;
                        familia_copil2_data_botez.Text = child.Data_botez;
                        string stareCivila2 = child.Stare_civila;
                        familia_copil2_stare_civila.SelectedIndex = getChildStareCivilaIndex(stareCivila2);
                        familia_copil2_nr_fisa.Text = child.Nr_fisa;
                        continue;
                    case 3:
                        familia_copil3.Checked = true;
                        familia_copil3_nume.Text = child.Nume;
                        familia_copil3_data_nasterii.Text = child.Data_nasterii;
                        familia_copil3_data_binec.Text = child.Data_binec;
                        familia_copil3_data_botez.Text = child.Data_botez;
                        string stareCivila3 = child.Stare_civila;
                        familia_copil3_stare_civila.SelectedIndex = getChildStareCivilaIndex(stareCivila3);
                        familia_copil3_nr_fisa.Text = child.Nr_fisa;
                        continue;
                    case 4:
                        familia_copil4.Checked = true;
                        familia_copil4_nume.Text = child.Nume;
                        familia_copil4_data_nasterii.Text = child.Data_nasterii;
                        familia_copil4_data_binec.Text = child.Data_binec;
                        familia_copil4_data_botez.Text = child.Data_botez;
                        string stareCivila4 = child.Stare_civila;
                        familia_copil4_stare_civila.SelectedIndex = getChildStareCivilaIndex(stareCivila4);
                        familia_copil4_nr_fisa.Text = child.Nr_fisa;
                        continue;
                    case 5:
                        familia_copil5.Checked = true;
                        familia_copil5_nume.Text = child.Nume;
                        familia_copil5_data_nasterii.Text = child.Data_nasterii;
                        familia_copil5_data_binec.Text = child.Data_binec;
                        familia_copil5_data_botez.Text = child.Data_botez;
                        string stareCivila5 = child.Stare_civila;
                        familia_copil5_stare_civila.SelectedIndex = getChildStareCivilaIndex(stareCivila5);
                        familia_copil5_nr_fisa.Text = child.Nr_fisa;
                        continue;
                    case 6:
                        familia_copil6.Checked = true;
                        familia_copil6_nume.Text = child.Nume;
                        familia_copil6_data_nasterii.Text = child.Data_nasterii;
                        familia_copil6_data_binec.Text = child.Data_binec;
                        familia_copil6_data_botez.Text = child.Data_botez;
                        string stareCivila6 = child.Stare_civila;
                        familia_copil6_stare_civila.SelectedIndex = getChildStareCivilaIndex(stareCivila6);
                        familia_copil6_nr_fisa.Text = child.Nr_fisa;
                        continue;
                    case 7:
                        familia_copil7.Checked = true;
                        familia_copil7_nume.Text = child.Nume;
                        familia_copil7_data_nasterii.Text = child.Data_nasterii;
                        familia_copil7_data_binec.Text = child.Data_binec;
                        familia_copil7_data_botez.Text = child.Data_botez;
                        string stareCivila7 = child.Stare_civila;
                        familia_copil7_stare_civila.SelectedIndex = getChildStareCivilaIndex(stareCivila7);
                        familia_copil7_nr_fisa.Text = child.Nr_fisa;
                        continue;
                    case 8:
                        familia_copil8.Checked = true;
                        familia_copil8_nume.Text = child.Nume;
                        familia_copil8_data_nasterii.Text = child.Data_nasterii;
                        familia_copil8_data_binec.Text = child.Data_binec;
                        familia_copil8_data_botez.Text = child.Data_botez;
                        string stareCivila8 = child.Stare_civila;
                        familia_copil8_stare_civila.SelectedIndex = getChildStareCivilaIndex(stareCivila8);
                        familia_copil8_nr_fisa.Text = child.Nr_fisa;
                        continue;
                    case 9:
                        familia_copil9.Checked = true;
                        familia_copil9_nume.Text = child.Nume;
                        familia_copil9_data_nasterii.Text = child.Data_nasterii;
                        familia_copil9_data_binec.Text = child.Data_binec;
                        familia_copil9_data_botez.Text = child.Data_botez;
                        string stareCivila9 = child.Stare_civila;
                        familia_copil9_stare_civila.SelectedIndex = getChildStareCivilaIndex(stareCivila9);
                        familia_copil9_nr_fisa.Text = child.Nr_fisa;
                        continue;
                    case 10:
                        familia_copil10.Checked = true;
                        familia_copil10_nume.Text = child.Nume;
                        familia_copil10_data_nasterii.Text = child.Data_nasterii;
                        familia_copil10_data_binec.Text = child.Data_binec;
                        familia_copil10_data_botez.Text = child.Data_botez;
                        string stareCivila10 = child.Stare_civila;
                        familia_copil10_stare_civila.SelectedIndex = getChildStareCivilaIndex(stareCivila10);
                        familia_copil10_nr_fisa.Text = child.Nr_fisa;
                        continue;
                    default:
                        continue;
                }
            }
        }

        private int getChildStareCivilaIndex(string stareCivila)
        {
            if (!(stareCivila == "Nu se aplică"))
            {
                if (!(stareCivila == "Necasatorit(ă)"))
                {
                    if (!(stareCivila == "Casatorit(ă)"))
                    {
                        if (!(stareCivila == "Vaduv(ă)"))
                        {
                            if (stareCivila == "Altele")
                                return 4;
                            else
                                return -1;
                        }
                        else
                            return 3;
                    }
                    else
                        return 2;
                }
                else
                    return 1;
            }
            else
                return 0;
        }

        private void showMmeberPartener(PartenerMembru partener)
        {
            familia_sotul.Text = partener.Nume;
            familia_sotul_data_nasterii.Text = partener.DataN;
            familia_sotul_localitate.Text = partener.Loc;
            familia_sotul_numar_fisa.Text = partener.NrFisa;
            familia_sotul_religie.Text = partener.Rel;
        }

        private void showMemberActeCult(List<ActCult> acteCult)
        {
            foreach (ActCult actCult in acteCult)
            {
                Console.WriteLine("#####act: " + actCult.Act);
                string act = actCult.Act;
                if (!(act == "Binecuvantare"))
                {
                    if (!(act.Equals("Botez in apa")))
                    {
                        if (!(act == "Casatorie"))
                        {
                            if (!(act == "Ordinare"))
                            {
                                if (act == "Inmormantare")
                                {
                                    acte_cult_inmormantare.Checked = true;
                                    acte_cult_inmormantare_biserica.Text = actCult.Biserica;
                                    acte_cult_inmormantare_data.Text = actCult.Data;
                                    acte_cult_inmormantare_pastor.Text = actCult.Pastor;
                                }
                            }
                            else
                            {
                                acte_cult_ordinare.Checked = true;
                                acte_cult_ordinare_biserica.Text = actCult.Biserica;
                                acte_cult_ordinare_data.Text = actCult.Data;
                                acte_cult_ordinare_pastor.Text = actCult.Pastor;
                            }
                        }
                        else
                        {
                            acte_cult_casatoria.Checked = true;
                            acte_cult_casatoria_biserica.Text = actCult.Biserica;
                            acte_cult_casatoria_data.Text = actCult.Data;
                            acte_cult_casatoria_pastor.Text = actCult.Pastor;
                        }
                    }
                    else
                    {
                        acte_cult_botez.Checked = true;
                        acte_cult_botez_biserica.Text = actCult.Biserica;
                        acte_cult_botez_data.Text = actCult.Data;
                        acte_cult_botez_pastor.Text = actCult.Pastor;
                    }
                }
                else
                {
                    acte_cult_binec.Checked = true;
                    acte_cult_binec_biserica.Text = actCult.Biserica;
                    acte_cult_binec_data.Text = actCult.Data;
                    acte_cult_binec_pastor.Text = actCult.Pastor;
                }
            }
        }

        private void showMemberPrimireInfo(PrimireMembru primireMembru)
        {
            string modalitatea = primireMembru.Modalitatea;
            if (!(modalitatea == "Prin transfer"))
            {
                if (!(modalitatea == "Prin botez"))
                {
                    if (modalitatea == "La cerere")
                        primire_membru_modalitatea.SelectedIndex = 2;
                    else
                        primire_membru_modalitatea.SelectedIndex = -1;
                }
                else
                    primire_membru_modalitatea.SelectedIndex = 1;
            }
            else
                primire_membru_modalitatea.SelectedIndex = 0;
            primire_membru_data.Text = primireMembru.Data;
            primire_membru_expl.Text = primireMembru.Expl;
        }

        private void showMemberStareCivila(StareaCivila stareCivila)
        {
            starea_civila_data_nasterii.Text = stareCivila.DataNasterii;
            starea_civila_locul_nasterii.Text = stareCivila.LoculNasterii;
            starea_civila_cnp.Text = stareCivila.Cnp;
            starea_civila_fiul_lui.Text = stareCivila.Tata;
            starea_civila_fiul_si_al.Text = stareCivila.Mama;
            string situatia = stareCivila.Situatia;
            if (!(situatia == "Necăsătorit(ă)"))
            {
                if (!(situatia == "Căsătorit(ă)"))
                {
                    if (!(situatia == "Văduv(ă)"))
                    {
                        if (situatia == "Altele")
                            starea_civila_situatia_la_inscriere.SelectedIndex = 3;
                        else
                            starea_civila_situatia_la_inscriere.SelectedIndex = -1;
                    }
                    else
                        starea_civila_situatia_la_inscriere.SelectedIndex = 2;
                }
                else
                    starea_civila_situatia_la_inscriere.SelectedIndex = 1;
            }
            else
                starea_civila_situatia_la_inscriere.SelectedIndex = 0;
            starea_civila_situatia_la_inscriere_expl.Text = stareCivila.SituatiaExpl;

            string modif = stareCivila.Modif;
            if (!(modif == "Nu se aplică"))
            {
                if (!(modif == "Căsătorie"))
                {
                    if (!(modif == "Văduvie"))
                    {
                        if (modif == "Deces")
                        {
                            starea_civila_modificari_ulterioare.SelectedIndex = 3;
                        }
                        else
                        {
                            starea_civila_modificari_ulterioare.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        starea_civila_modificari_ulterioare.SelectedIndex = 2;
                    }
                }
                else
                {
                    starea_civila_modificari_ulterioare.SelectedIndex = 1;
                }
            }
            else
            {
                starea_civila_modificari_ulterioare.SelectedIndex = 0;
            }
            starea_civila_modificari_ulterioare_expl.Text = stareCivila.ModifExpl;
        }

        private void showMemberPersonalData(int memberId, PersonalData personalData)
        {
            pk_numarul_fisa_personala.Text = memberId.ToString();
            date_data_inscrierii.Text = personalData.DataInscrierii;
            date_personale_nume.Text = personalData.Nume;
            date_personale_prenume.Text = personalData.Prenume;
            date_personale_localitatea.Text = personalData.Localitate;
            date_personale_strada.Text = personalData.Strada;
            date_personale_numarul.Text = personalData.Numarul;
            date_personale_judet.Text = personalData.Judet;
            date_personale_telefon.Text = personalData.Telefon;
            date_personale_studii.Text = personalData.Studii;
            if (personalData.Calitatea.Equals("Membru"))
                date_personale_calitatea_la_inscriere.SelectedIndex = 0;
            else if (personalData.Calitatea.Equals("Personal ordinat"))
                date_personale_calitatea_la_inscriere.SelectedIndex = 1;
            else
                date_personale_calitatea_la_inscriere.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearInputs();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            populateMembersList(textBox1.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lstMembers.SelectedItems.Count <= 0)
            {
                int num1 = (int)MessageBox.Show("Selectati un membru din lista.", "Nimic selectat!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                int memberId = int.Parse(lstMembers.SelectedItems[0].SubItems[0].Text);
                tablesManager.deleteIesireEvidentaInfo(memberId);
                tablesManager.deleteMemberChilds(memberId);
                tablesManager.deleteMemberPartner(memberId);
                tablesManager.deleteActeCult(memberId);
                tablesManager.deletePrimireInfo(memberId);
                tablesManager.deleteStareCivila(memberId);
                tablesManager.deleteDatePersonale(memberId);
                populateMembersList("");
                textBox1.Clear();
                lstMembers.SelectedItems.Clear();
                clearInputs();
                int num2 = (int)MessageBox.Show("Fisa cu numarul " + (object)memberId + " a fost eliminata.", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(pk_numarul_fisa_personala.Text, out result))
            {
                MessageBox.Show("Fisa personala a membrului trebuie sa fie un numar natural!\nDatele nu au putut fi salvate.", "Date incorecte!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id1 = int.Parse(pk_numarul_fisa_personala.Text);
                if (!tablesManager.idAlreadyInDataBase(id1))
                {
                    MessageBox.Show("Numarul fisei nu exista in baza de date!\nActualizarea nu a avut succes.", "Date incorecte!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    TablesManager tablesManager1 = tablesManager;
                    int id2 = id1;
                    string text1 = date_personale_nume.Text;
                    string text2 = date_personale_prenume.Text;
                    string text3 = date_personale_localitatea.Text;
                    string text4 = date_personale_strada.Text;
                    string text5 = date_personale_numarul.Text;
                    string text6 = date_personale_judet.Text;
                    string text7 = date_personale_telefon.Text;
                    string text8 = date_personale_studii.Text;
                    string calitatea = date_personale_calitatea_la_inscriere.SelectedItem.ToString();
                    string data_inscrierii = date_data_inscrierii.Text;
                    string str1 = tablesManager1.updateDatePersonale(id2, text1, text2, text3, text4, text5, text6, text7, text8, calitatea, data_inscrierii);
                    if (!str1.Equals(Status.OK))
                    {
                        MessageBox.Show(str1 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        TablesManager tablesManager2 = tablesManager;
                        int id3 = id1;
                        string dataNasterii1 = starea_civila_data_nasterii.Text;
                        string text9 = starea_civila_locul_nasterii.Text;
                        string text10 = starea_civila_cnp.Text;
                        string text11 = starea_civila_fiul_lui.Text;
                        string text12 = starea_civila_fiul_si_al.Text;
                        string situatia = starea_civila_situatia_la_inscriere.SelectedItem.ToString();
                        string text13 = starea_civila_situatia_la_inscriere_expl.Text;
                        string modificari = starea_civila_modificari_ulterioare.SelectedItem.ToString();
                        string text14 = starea_civila_modificari_ulterioare_expl.Text;
                        string str2 = tablesManager2.updateStareaCivila(id3, dataNasterii1, text9, text10, text11, text12, situatia, text13, modificari, text14);
                        if (!str2.Equals(Status.OK))
                        {
                            MessageBox.Show(str2 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            TablesManager tablesManager3 = tablesManager;
                            int id4 = id1;
                            string modalitatea = primire_membru_modalitatea.SelectedItem.ToString();
                            string data1 = primire_membru_data.Text;
                            string text15 = primire_membru_expl.Text;
                            string str3 = tablesManager3.updatePrimireMembru(id4, modalitatea, data1, text15);
                            if (!str3.Equals(Status.OK))
                            {
                                MessageBox.Show(str3 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            }
                            else
                            {
                                string str4 = updateActeCult(id1);
                                if (!str4.Equals(Status.OK))
                                {
                                    MessageBox.Show(str4 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                }
                                else
                                {
                                    TablesManager tablesManager4 = tablesManager;
                                    int id5 = id1;
                                    string text16 = familia_sotul.Text;
                                    string text17 = familia_sotul_numar_fisa.Text;
                                    string dataNasterii2 = familia_sotul_data_nasterii.Text;
                                    string text18 = familia_sotul_localitate.Text;
                                    string text19 = familia_sotul_religie.Text;
                                    string str5 = tablesManager4.updatePartener(id5, text16, text17, dataNasterii2, text18, text19);
                                    if (!str5.Equals(Status.OK))
                                    {
                                        MessageBox.Show(str5 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                    }
                                    else
                                    {
                                        updateChildren(id1);
                                        TablesManager tablesManager5 = tablesManager;
                                        int id6 = id1;
                                        string motiv = iesire_evidenta_motiv.SelectedItem.ToString();
                                        string data2 = iesire_evidenta_data.Text;
                                        string text20 = iesire_evidenta_expl.Text;
                                        string str6 = tablesManager5.updateIesireEvidenta(id6, motiv, data2, text20);
                                        if (!str6.Equals(Status.OK))
                                        {
                                            MessageBox.Show(str6 + "\nDatele nu au fost salvate", "Eroare!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                        }
                                        else
                                        {
                                            populateMembersList("");
                                            textBox1.Clear();
                                            MessageBox.Show("Fisa cu numarul " + (object)id1 + " a fost actualizata cu succes.", "Operatie reusita!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void updateChildren(int id)
        {
            tablesManager.deleteMemberChilds(id);
            insertCopiiInDataBase(id);
        }

        private string updateActeCult(int id)
        {
            tablesManager.deleteActeCult(id);
            return insertActeCultInDataBase(id);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.beteldumbraveni.com");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pk_numarul_fisa_personala = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date_data_inscrierii = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.date_personale_calitatea_la_inscriere = new System.Windows.Forms.ComboBox();
            this.date_personale_numarul = new System.Windows.Forms.TextBox();
            this.date_personale_judet = new System.Windows.Forms.TextBox();
            this.date_personale_strada = new System.Windows.Forms.TextBox();
            this.date_personale_telefon = new System.Windows.Forms.TextBox();
            this.date_personale_studii = new System.Windows.Forms.TextBox();
            this.date_personale_localitatea = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.date_personale_prenume = new System.Windows.Forms.TextBox();
            this.date_personale_nume = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.starea_civila_data_nasterii = new System.Windows.Forms.TextBox();
            this.starea_civila_modificari_ulterioare_expl = new System.Windows.Forms.TextBox();
            this.starea_civila_situatia_la_inscriere_expl = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.starea_civila_modificari_ulterioare = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.starea_civila_situatia_la_inscriere = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.starea_civila_fiul_si_al = new System.Windows.Forms.TextBox();
            this.starea_civila_fiul_lui = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.starea_civila_cnp = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.starea_civila_locul_nasterii = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.primire_membru_data = new System.Windows.Forms.TextBox();
            this.primire_membru_expl = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.primire_membru_modalitatea = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.acte_cult_inmormantare_data = new System.Windows.Forms.TextBox();
            this.acte_cult_ordinare_data = new System.Windows.Forms.TextBox();
            this.acte_cult_casatoria_data = new System.Windows.Forms.TextBox();
            this.acte_cult_botez_data = new System.Windows.Forms.TextBox();
            this.acte_cult_binec_data = new System.Windows.Forms.TextBox();
            this.acte_cult_inmormantare = new System.Windows.Forms.CheckBox();
            this.acte_cult_ordinare = new System.Windows.Forms.CheckBox();
            this.acte_cult_casatoria = new System.Windows.Forms.CheckBox();
            this.acte_cult_botez = new System.Windows.Forms.CheckBox();
            this.acte_cult_binec = new System.Windows.Forms.CheckBox();
            this.acte_cult_inmormantare_pastor = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.acte_cult_inmormantare_biserica = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.acte_cult_ordinare_pastor = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.acte_cult_ordinare_biserica = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.acte_cult_casatoria_pastor = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.acte_cult_casatoria_biserica = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.acte_cult_botez_pastor = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.acte_cult_botez_biserica = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.acte_cult_binec_pastor = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.acte_cult_binec_biserica = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.familia_copil10_data_botez = new System.Windows.Forms.TextBox();
            this.familia_copil10_data_binec = new System.Windows.Forms.TextBox();
            this.familia_copil10_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_copil9_data_botez = new System.Windows.Forms.TextBox();
            this.familia_copil9_data_binec = new System.Windows.Forms.TextBox();
            this.familia_copil9_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_copil8_data_botez = new System.Windows.Forms.TextBox();
            this.familia_copil8_data_binec = new System.Windows.Forms.TextBox();
            this.familia_copil8_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_copil7_data_botez = new System.Windows.Forms.TextBox();
            this.familia_copil7_data_binec = new System.Windows.Forms.TextBox();
            this.familia_copil7_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_copil6_data_botez = new System.Windows.Forms.TextBox();
            this.familia_copil6_data_binec = new System.Windows.Forms.TextBox();
            this.familia_copil6_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_copil5_data_botez = new System.Windows.Forms.TextBox();
            this.familia_copil5_data_binec = new System.Windows.Forms.TextBox();
            this.familia_copil5_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_copil4_data_botez = new System.Windows.Forms.TextBox();
            this.familia_copil4_data_binec = new System.Windows.Forms.TextBox();
            this.familia_copil4_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_copil3_data_botez = new System.Windows.Forms.TextBox();
            this.familia_copil3_data_binec = new System.Windows.Forms.TextBox();
            this.familia_copil3_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_copil2_data_botez = new System.Windows.Forms.TextBox();
            this.familia_copil2_data_binec = new System.Windows.Forms.TextBox();
            this.familia_copil2_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_copil1_data_botez = new System.Windows.Forms.TextBox();
            this.familia_copil1_data_binec = new System.Windows.Forms.TextBox();
            this.familia_copil1_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_sotul_data_nasterii = new System.Windows.Forms.TextBox();
            this.familia_copil10 = new System.Windows.Forms.CheckBox();
            this.familia_copil9 = new System.Windows.Forms.CheckBox();
            this.familia_copil8 = new System.Windows.Forms.CheckBox();
            this.familia_copil7 = new System.Windows.Forms.CheckBox();
            this.familia_copil6 = new System.Windows.Forms.CheckBox();
            this.familia_copil5 = new System.Windows.Forms.CheckBox();
            this.familia_copil4 = new System.Windows.Forms.CheckBox();
            this.familia_copil3 = new System.Windows.Forms.CheckBox();
            this.familia_copil2 = new System.Windows.Forms.CheckBox();
            this.familia_copil1 = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.familia_copil10_nr_fisa = new System.Windows.Forms.TextBox();
            this.familia_copil10_stare_civila = new System.Windows.Forms.ComboBox();
            this.familia_copil10_nume = new System.Windows.Forms.TextBox();
            this.familia_copil9_nr_fisa = new System.Windows.Forms.TextBox();
            this.familia_copil9_stare_civila = new System.Windows.Forms.ComboBox();
            this.familia_copil9_nume = new System.Windows.Forms.TextBox();
            this.familia_copil8_nr_fisa = new System.Windows.Forms.TextBox();
            this.familia_copil8_stare_civila = new System.Windows.Forms.ComboBox();
            this.familia_copil8_nume = new System.Windows.Forms.TextBox();
            this.familia_copil7_nr_fisa = new System.Windows.Forms.TextBox();
            this.familia_copil7_stare_civila = new System.Windows.Forms.ComboBox();
            this.familia_copil7_nume = new System.Windows.Forms.TextBox();
            this.familia_copil6_nr_fisa = new System.Windows.Forms.TextBox();
            this.familia_copil6_stare_civila = new System.Windows.Forms.ComboBox();
            this.familia_copil6_nume = new System.Windows.Forms.TextBox();
            this.familia_copil5_nr_fisa = new System.Windows.Forms.TextBox();
            this.familia_copil5_stare_civila = new System.Windows.Forms.ComboBox();
            this.familia_copil5_nume = new System.Windows.Forms.TextBox();
            this.familia_copil4_nr_fisa = new System.Windows.Forms.TextBox();
            this.familia_copil4_stare_civila = new System.Windows.Forms.ComboBox();
            this.familia_copil4_nume = new System.Windows.Forms.TextBox();
            this.familia_copil3_nr_fisa = new System.Windows.Forms.TextBox();
            this.familia_copil3_stare_civila = new System.Windows.Forms.ComboBox();
            this.familia_copil3_nume = new System.Windows.Forms.TextBox();
            this.familia_copil2_nr_fisa = new System.Windows.Forms.TextBox();
            this.familia_copil2_stare_civila = new System.Windows.Forms.ComboBox();
            this.familia_copil2_nume = new System.Windows.Forms.TextBox();
            this.familia_copil1_nr_fisa = new System.Windows.Forms.TextBox();
            this.familia_copil1_stare_civila = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.familia_copil1_nume = new System.Windows.Forms.TextBox();
            this.familia_sotul_religie = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.familia_sotul_localitate = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.familia_sotul_numar_fisa = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.familia_sotul = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.iesire_evidenta_data = new System.Windows.Forms.TextBox();
            this.iesire_evidenta_expl = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.iesire_evidenta_motiv = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lstMembers = new System.Windows.Forms.ListView();
            this.nr_fisa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prenume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.memberCount = new System.Windows.Forms.Label();
            this.kidsCount = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label55 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIŞA PERSONALĂ NUMĂRUL: ";
            // 
            // pk_numarul_fisa_personala
            // 
            this.pk_numarul_fisa_personala.Location = new System.Drawing.Point(596, 46);
            this.pk_numarul_fisa_personala.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.pk_numarul_fisa_personala.MaxLength = 5;
            this.pk_numarul_fisa_personala.Name = "pk_numarul_fisa_personala";
            this.pk_numarul_fisa_personala.Size = new System.Drawing.Size(88, 29);
            this.pk_numarul_fisa_personala.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data înscrierii:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.date_data_inscrierii);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.date_personale_calitatea_la_inscriere);
            this.groupBox1.Controls.Add(this.date_personale_numarul);
            this.groupBox1.Controls.Add(this.date_personale_judet);
            this.groupBox1.Controls.Add(this.date_personale_strada);
            this.groupBox1.Controls.Add(this.date_personale_telefon);
            this.groupBox1.Controls.Add(this.date_personale_studii);
            this.groupBox1.Controls.Add(this.date_personale_localitatea);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.date_personale_prenume);
            this.groupBox1.Controls.Add(this.date_personale_nume);
            this.groupBox1.Location = new System.Drawing.Point(369, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox1.Size = new System.Drawing.Size(894, 162);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date personale:";
            // 
            // date_data_inscrierii
            // 
            this.date_data_inscrierii.Location = new System.Drawing.Point(406, 112);
            this.date_data_inscrierii.Name = "date_data_inscrierii";
            this.date_data_inscrierii.Size = new System.Drawing.Size(116, 29);
            this.date_data_inscrierii.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 32;
            this.label4.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nume:";
            // 
            // date_personale_calitatea_la_inscriere
            // 
            this.date_personale_calitatea_la_inscriere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.date_personale_calitatea_la_inscriere.FormattingEnabled = true;
            this.date_personale_calitatea_la_inscriere.Items.AddRange(new object[] {
            "Membru",
            "Personal ordinat"});
            this.date_personale_calitatea_la_inscriere.Location = new System.Drawing.Point(718, 113);
            this.date_personale_calitatea_la_inscriere.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.date_personale_calitatea_la_inscriere.Name = "date_personale_calitatea_la_inscriere";
            this.date_personale_calitatea_la_inscriere.Size = new System.Drawing.Size(161, 29);
            this.date_personale_calitatea_la_inscriere.TabIndex = 30;
            // 
            // date_personale_numarul
            // 
            this.date_personale_numarul.Location = new System.Drawing.Point(392, 70);
            this.date_personale_numarul.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.date_personale_numarul.MaxLength = 10;
            this.date_personale_numarul.Name = "date_personale_numarul";
            this.date_personale_numarul.Size = new System.Drawing.Size(77, 29);
            this.date_personale_numarul.TabIndex = 28;
            // 
            // date_personale_judet
            // 
            this.date_personale_judet.Location = new System.Drawing.Point(532, 70);
            this.date_personale_judet.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.date_personale_judet.MaxLength = 40;
            this.date_personale_judet.Name = "date_personale_judet";
            this.date_personale_judet.Size = new System.Drawing.Size(148, 29);
            this.date_personale_judet.TabIndex = 26;
            // 
            // date_personale_strada
            // 
            this.date_personale_strada.Location = new System.Drawing.Point(79, 70);
            this.date_personale_strada.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.date_personale_strada.MaxLength = 100;
            this.date_personale_strada.Name = "date_personale_strada";
            this.date_personale_strada.Size = new System.Drawing.Size(218, 29);
            this.date_personale_strada.TabIndex = 25;
            // 
            // date_personale_telefon
            // 
            this.date_personale_telefon.Location = new System.Drawing.Point(755, 70);
            this.date_personale_telefon.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.date_personale_telefon.MaxLength = 20;
            this.date_personale_telefon.Name = "date_personale_telefon";
            this.date_personale_telefon.Size = new System.Drawing.Size(124, 29);
            this.date_personale_telefon.TabIndex = 24;
            // 
            // date_personale_studii
            // 
            this.date_personale_studii.Location = new System.Drawing.Point(79, 112);
            this.date_personale_studii.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.date_personale_studii.MaxLength = 50;
            this.date_personale_studii.Name = "date_personale_studii";
            this.date_personale_studii.Size = new System.Drawing.Size(199, 29);
            this.date_personale_studii.TabIndex = 22;
            // 
            // date_personale_localitatea
            // 
            this.date_personale_localitatea.Location = new System.Drawing.Point(718, 28);
            this.date_personale_localitatea.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.date_personale_localitatea.MaxLength = 100;
            this.date_personale_localitatea.Name = "date_personale_localitatea";
            this.date_personale_localitatea.Size = new System.Drawing.Size(163, 29);
            this.date_personale_localitatea.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(528, 115);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(186, 21);
            this.label16.TabIndex = 19;
            this.label16.Text = "Calitatea la data inscrierii:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 115);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 21);
            this.label15.TabIndex = 18;
            this.label15.Text = "Studii:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(686, 74);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 21);
            this.label14.TabIndex = 17;
            this.label14.Text = "Telefon:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(482, 74);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 21);
            this.label13.TabIndex = 16;
            this.label13.Text = "Judeţ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Numărul:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Strada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Localitatea:";
            // 
            // date_personale_prenume
            // 
            this.date_personale_prenume.Location = new System.Drawing.Point(392, 28);
            this.date_personale_prenume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.date_personale_prenume.MaxLength = 100;
            this.date_personale_prenume.Name = "date_personale_prenume";
            this.date_personale_prenume.Size = new System.Drawing.Size(218, 29);
            this.date_personale_prenume.TabIndex = 7;
            // 
            // date_personale_nume
            // 
            this.date_personale_nume.Location = new System.Drawing.Point(79, 28);
            this.date_personale_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.date_personale_nume.MaxLength = 100;
            this.date_personale_nume.Name = "date_personale_nume";
            this.date_personale_nume.Size = new System.Drawing.Size(218, 29);
            this.date_personale_nume.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.starea_civila_data_nasterii);
            this.groupBox2.Controls.Add(this.starea_civila_modificari_ulterioare_expl);
            this.groupBox2.Controls.Add(this.starea_civila_situatia_la_inscriere_expl);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.starea_civila_modificari_ulterioare);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.starea_civila_situatia_la_inscriere);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.starea_civila_fiul_si_al);
            this.groupBox2.Controls.Add(this.starea_civila_fiul_lui);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.starea_civila_cnp);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.starea_civila_locul_nasterii);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(369, 279);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox2.Size = new System.Drawing.Size(894, 216);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Date privind starea civila:";
            // 
            // starea_civila_data_nasterii
            // 
            this.starea_civila_data_nasterii.Location = new System.Drawing.Point(139, 40);
            this.starea_civila_data_nasterii.Name = "starea_civila_data_nasterii";
            this.starea_civila_data_nasterii.Size = new System.Drawing.Size(139, 29);
            this.starea_civila_data_nasterii.TabIndex = 18;
            // 
            // starea_civila_modificari_ulterioare_expl
            // 
            this.starea_civila_modificari_ulterioare_expl.Location = new System.Drawing.Point(552, 167);
            this.starea_civila_modificari_ulterioare_expl.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.starea_civila_modificari_ulterioare_expl.MaxLength = 100;
            this.starea_civila_modificari_ulterioare_expl.Name = "starea_civila_modificari_ulterioare_expl";
            this.starea_civila_modificari_ulterioare_expl.Size = new System.Drawing.Size(327, 29);
            this.starea_civila_modificari_ulterioare_expl.TabIndex = 17;
            // 
            // starea_civila_situatia_la_inscriere_expl
            // 
            this.starea_civila_situatia_la_inscriere_expl.Location = new System.Drawing.Point(552, 124);
            this.starea_civila_situatia_la_inscriere_expl.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.starea_civila_situatia_la_inscriere_expl.MaxLength = 100;
            this.starea_civila_situatia_la_inscriere_expl.Name = "starea_civila_situatia_la_inscriere_expl";
            this.starea_civila_situatia_la_inscriere_expl.Size = new System.Drawing.Size(327, 29);
            this.starea_civila_situatia_la_inscriere_expl.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(469, 169);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(73, 21);
            this.label24.TabIndex = 15;
            this.label24.Text = "Explicaţii:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(469, 127);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 21);
            this.label23.TabIndex = 14;
            this.label23.Text = "Explicaţii:";
            // 
            // starea_civila_modificari_ulterioare
            // 
            this.starea_civila_modificari_ulterioare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.starea_civila_modificari_ulterioare.FormattingEnabled = true;
            this.starea_civila_modificari_ulterioare.Items.AddRange(new object[] {
            "Nu se aplică",
            "Căsătorie",
            "Văduvie",
            "Deces"});
            this.starea_civila_modificari_ulterioare.Location = new System.Drawing.Point(253, 167);
            this.starea_civila_modificari_ulterioare.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.starea_civila_modificari_ulterioare.Name = "starea_civila_modificari_ulterioare";
            this.starea_civila_modificari_ulterioare.Size = new System.Drawing.Size(204, 29);
            this.starea_civila_modificari_ulterioare.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 169);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(216, 21);
            this.label22.TabIndex = 12;
            this.label22.Text = "Modificări intervenite ulterior:";
            // 
            // starea_civila_situatia_la_inscriere
            // 
            this.starea_civila_situatia_la_inscriere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.starea_civila_situatia_la_inscriere.FormattingEnabled = true;
            this.starea_civila_situatia_la_inscriere.Items.AddRange(new object[] {
            "Necăsătorit(ă)",
            "Căsătorit(ă)",
            "Văduv(ă)",
            "Altele"});
            this.starea_civila_situatia_la_inscriere.Location = new System.Drawing.Point(295, 124);
            this.starea_civila_situatia_la_inscriere.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.starea_civila_situatia_la_inscriere.Name = "starea_civila_situatia_la_inscriere";
            this.starea_civila_situatia_la_inscriere.Size = new System.Drawing.Size(160, 29);
            this.starea_civila_situatia_la_inscriere.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 127);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(261, 21);
            this.label21.TabIndex = 10;
            this.label21.Text = "Situaţia la data înscrierii ca membru:";
            // 
            // starea_civila_fiul_si_al
            // 
            this.starea_civila_fiul_si_al.Location = new System.Drawing.Point(552, 82);
            this.starea_civila_fiul_si_al.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.starea_civila_fiul_si_al.MaxLength = 50;
            this.starea_civila_fiul_si_al.Name = "starea_civila_fiul_si_al";
            this.starea_civila_fiul_si_al.Size = new System.Drawing.Size(328, 29);
            this.starea_civila_fiul_si_al.TabIndex = 9;
            // 
            // starea_civila_fiul_lui
            // 
            this.starea_civila_fiul_lui.Location = new System.Drawing.Point(139, 82);
            this.starea_civila_fiul_lui.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.starea_civila_fiul_lui.MaxLength = 50;
            this.starea_civila_fiul_lui.Name = "starea_civila_fiul_lui";
            this.starea_civila_fiul_lui.Size = new System.Drawing.Size(330, 29);
            this.starea_civila_fiul_lui.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(502, 85);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 21);
            this.label20.TabIndex = 7;
            this.label20.Text = "si al:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 85);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 21);
            this.label19.TabIndex = 6;
            this.label19.Text = "Fiul/Fiica lui:";
            // 
            // starea_civila_cnp
            // 
            this.starea_civila_cnp.Location = new System.Drawing.Point(657, 40);
            this.starea_civila_cnp.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.starea_civila_cnp.MaxLength = 13;
            this.starea_civila_cnp.Name = "starea_civila_cnp";
            this.starea_civila_cnp.Size = new System.Drawing.Size(222, 29);
            this.starea_civila_cnp.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(597, 43);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 21);
            this.label18.TabIndex = 4;
            this.label18.Text = "CNP:";
            // 
            // starea_civila_locul_nasterii
            // 
            this.starea_civila_locul_nasterii.Location = new System.Drawing.Point(413, 40);
            this.starea_civila_locul_nasterii.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.starea_civila_locul_nasterii.MaxLength = 100;
            this.starea_civila_locul_nasterii.Name = "starea_civila_locul_nasterii";
            this.starea_civila_locul_nasterii.Size = new System.Drawing.Size(159, 29);
            this.starea_civila_locul_nasterii.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(296, 43);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 21);
            this.label17.TabIndex = 2;
            this.label17.Text = "Locul naşterii:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Data naşterii:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.primire_membru_data);
            this.groupBox3.Controls.Add(this.primire_membru_expl);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.primire_membru_modalitatea);
            this.groupBox3.Location = new System.Drawing.Point(369, 523);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox3.Size = new System.Drawing.Size(894, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date privind modul de primire ca membru:";
            // 
            // primire_membru_data
            // 
            this.primire_membru_data.Location = new System.Drawing.Point(307, 47);
            this.primire_membru_data.Name = "primire_membru_data";
            this.primire_membru_data.Size = new System.Drawing.Size(148, 29);
            this.primire_membru_data.TabIndex = 5;
            // 
            // primire_membru_expl
            // 
            this.primire_membru_expl.Location = new System.Drawing.Point(552, 47);
            this.primire_membru_expl.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.primire_membru_expl.MaxLength = 100;
            this.primire_membru_expl.Name = "primire_membru_expl";
            this.primire_membru_expl.Size = new System.Drawing.Size(327, 29);
            this.primire_membru_expl.TabIndex = 4;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(469, 49);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(73, 21);
            this.label26.TabIndex = 3;
            this.label26.Text = "Explicaţii:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(243, 48);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 21);
            this.label25.TabIndex = 1;
            this.label25.Text = "la data:";
            // 
            // primire_membru_modalitatea
            // 
            this.primire_membru_modalitatea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.primire_membru_modalitatea.FormattingEnabled = true;
            this.primire_membru_modalitatea.Items.AddRange(new object[] {
            "Prin transfer",
            "Prin botez",
            "La cerere"});
            this.primire_membru_modalitatea.Location = new System.Drawing.Point(27, 47);
            this.primire_membru_modalitatea.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.primire_membru_modalitatea.Name = "primire_membru_modalitatea";
            this.primire_membru_modalitatea.Size = new System.Drawing.Size(203, 29);
            this.primire_membru_modalitatea.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.acte_cult_inmormantare_data);
            this.groupBox4.Controls.Add(this.acte_cult_ordinare_data);
            this.groupBox4.Controls.Add(this.acte_cult_casatoria_data);
            this.groupBox4.Controls.Add(this.acte_cult_botez_data);
            this.groupBox4.Controls.Add(this.acte_cult_binec_data);
            this.groupBox4.Controls.Add(this.acte_cult_inmormantare);
            this.groupBox4.Controls.Add(this.acte_cult_ordinare);
            this.groupBox4.Controls.Add(this.acte_cult_casatoria);
            this.groupBox4.Controls.Add(this.acte_cult_botez);
            this.groupBox4.Controls.Add(this.acte_cult_binec);
            this.groupBox4.Controls.Add(this.acte_cult_inmormantare_pastor);
            this.groupBox4.Controls.Add(this.label39);
            this.groupBox4.Controls.Add(this.acte_cult_inmormantare_biserica);
            this.groupBox4.Controls.Add(this.label40);
            this.groupBox4.Controls.Add(this.acte_cult_ordinare_pastor);
            this.groupBox4.Controls.Add(this.label36);
            this.groupBox4.Controls.Add(this.acte_cult_ordinare_biserica);
            this.groupBox4.Controls.Add(this.label37);
            this.groupBox4.Controls.Add(this.acte_cult_casatoria_pastor);
            this.groupBox4.Controls.Add(this.label33);
            this.groupBox4.Controls.Add(this.acte_cult_casatoria_biserica);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.acte_cult_botez_pastor);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.acte_cult_botez_biserica);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.acte_cult_binec_pastor);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.acte_cult_binec_biserica);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Location = new System.Drawing.Point(369, 650);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox4.Size = new System.Drawing.Size(894, 247);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Date privind actele de cult oficiate:";
            // 
            // acte_cult_inmormantare_data
            // 
            this.acte_cult_inmormantare_data.Location = new System.Drawing.Point(160, 202);
            this.acte_cult_inmormantare_data.Name = "acte_cult_inmormantare_data";
            this.acte_cult_inmormantare_data.Size = new System.Drawing.Size(100, 29);
            this.acte_cult_inmormantare_data.TabIndex = 40;
            // 
            // acte_cult_ordinare_data
            // 
            this.acte_cult_ordinare_data.Location = new System.Drawing.Point(159, 160);
            this.acte_cult_ordinare_data.Name = "acte_cult_ordinare_data";
            this.acte_cult_ordinare_data.Size = new System.Drawing.Size(100, 29);
            this.acte_cult_ordinare_data.TabIndex = 39;
            // 
            // acte_cult_casatoria_data
            // 
            this.acte_cult_casatoria_data.Location = new System.Drawing.Point(159, 118);
            this.acte_cult_casatoria_data.Name = "acte_cult_casatoria_data";
            this.acte_cult_casatoria_data.Size = new System.Drawing.Size(101, 29);
            this.acte_cult_casatoria_data.TabIndex = 38;
            // 
            // acte_cult_botez_data
            // 
            this.acte_cult_botez_data.Location = new System.Drawing.Point(159, 77);
            this.acte_cult_botez_data.Name = "acte_cult_botez_data";
            this.acte_cult_botez_data.Size = new System.Drawing.Size(101, 29);
            this.acte_cult_botez_data.TabIndex = 37;
            // 
            // acte_cult_binec_data
            // 
            this.acte_cult_binec_data.Location = new System.Drawing.Point(159, 35);
            this.acte_cult_binec_data.Name = "acte_cult_binec_data";
            this.acte_cult_binec_data.Size = new System.Drawing.Size(101, 29);
            this.acte_cult_binec_data.TabIndex = 36;
            // 
            // acte_cult_inmormantare
            // 
            this.acte_cult_inmormantare.AutoSize = true;
            this.acte_cult_inmormantare.Location = new System.Drawing.Point(27, 204);
            this.acte_cult_inmormantare.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_inmormantare.Name = "acte_cult_inmormantare";
            this.acte_cult_inmormantare.Size = new System.Drawing.Size(129, 25);
            this.acte_cult_inmormantare.TabIndex = 35;
            this.acte_cult_inmormantare.Text = "Inmormantare";
            this.acte_cult_inmormantare.UseVisualStyleBackColor = true;
            // 
            // acte_cult_ordinare
            // 
            this.acte_cult_ordinare.AutoSize = true;
            this.acte_cult_ordinare.Location = new System.Drawing.Point(27, 162);
            this.acte_cult_ordinare.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_ordinare.Name = "acte_cult_ordinare";
            this.acte_cult_ordinare.Size = new System.Drawing.Size(91, 25);
            this.acte_cult_ordinare.TabIndex = 34;
            this.acte_cult_ordinare.Text = "Ordinare";
            this.acte_cult_ordinare.UseVisualStyleBackColor = true;
            // 
            // acte_cult_casatoria
            // 
            this.acte_cult_casatoria.AutoSize = true;
            this.acte_cult_casatoria.Location = new System.Drawing.Point(27, 120);
            this.acte_cult_casatoria.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_casatoria.Name = "acte_cult_casatoria";
            this.acte_cult_casatoria.Size = new System.Drawing.Size(94, 25);
            this.acte_cult_casatoria.TabIndex = 33;
            this.acte_cult_casatoria.Text = "Casatorie";
            this.acte_cult_casatoria.UseVisualStyleBackColor = true;
            // 
            // acte_cult_botez
            // 
            this.acte_cult_botez.AutoSize = true;
            this.acte_cult_botez.Location = new System.Drawing.Point(27, 78);
            this.acte_cult_botez.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_botez.Name = "acte_cult_botez";
            this.acte_cult_botez.Size = new System.Drawing.Size(113, 25);
            this.acte_cult_botez.TabIndex = 32;
            this.acte_cult_botez.Text = "Botez in apa";
            this.acte_cult_botez.UseVisualStyleBackColor = true;
            // 
            // acte_cult_binec
            // 
            this.acte_cult_binec.AutoSize = true;
            this.acte_cult_binec.Location = new System.Drawing.Point(27, 36);
            this.acte_cult_binec.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_binec.Name = "acte_cult_binec";
            this.acte_cult_binec.Size = new System.Drawing.Size(127, 25);
            this.acte_cult_binec.TabIndex = 31;
            this.acte_cult_binec.Text = "Binecuvantare";
            this.acte_cult_binec.UseVisualStyleBackColor = true;
            // 
            // acte_cult_inmormantare_pastor
            // 
            this.acte_cult_inmormantare_pastor.Location = new System.Drawing.Point(659, 203);
            this.acte_cult_inmormantare_pastor.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_inmormantare_pastor.MaxLength = 100;
            this.acte_cult_inmormantare_pastor.Name = "acte_cult_inmormantare_pastor";
            this.acte_cult_inmormantare_pastor.Size = new System.Drawing.Size(221, 29);
            this.acte_cult_inmormantare_pastor.TabIndex = 30;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(588, 205);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(57, 21);
            this.label39.TabIndex = 29;
            this.label39.Text = "Pastor:";
            // 
            // acte_cult_inmormantare_biserica
            // 
            this.acte_cult_inmormantare_biserica.Location = new System.Drawing.Point(348, 203);
            this.acte_cult_inmormantare_biserica.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_inmormantare_biserica.MaxLength = 100;
            this.acte_cult_inmormantare_biserica.Name = "acte_cult_inmormantare_biserica";
            this.acte_cult_inmormantare_biserica.Size = new System.Drawing.Size(224, 29);
            this.acte_cult_inmormantare_biserica.TabIndex = 28;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(278, 206);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(66, 21);
            this.label40.TabIndex = 27;
            this.label40.Text = "Biserica:";
            // 
            // acte_cult_ordinare_pastor
            // 
            this.acte_cult_ordinare_pastor.Location = new System.Drawing.Point(659, 161);
            this.acte_cult_ordinare_pastor.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_ordinare_pastor.MaxLength = 100;
            this.acte_cult_ordinare_pastor.Name = "acte_cult_ordinare_pastor";
            this.acte_cult_ordinare_pastor.Size = new System.Drawing.Size(221, 29);
            this.acte_cult_ordinare_pastor.TabIndex = 24;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(588, 163);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(57, 21);
            this.label36.TabIndex = 23;
            this.label36.Text = "Pastor:";
            // 
            // acte_cult_ordinare_biserica
            // 
            this.acte_cult_ordinare_biserica.Location = new System.Drawing.Point(348, 162);
            this.acte_cult_ordinare_biserica.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_ordinare_biserica.MaxLength = 100;
            this.acte_cult_ordinare_biserica.Name = "acte_cult_ordinare_biserica";
            this.acte_cult_ordinare_biserica.Size = new System.Drawing.Size(224, 29);
            this.acte_cult_ordinare_biserica.TabIndex = 22;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(278, 164);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 21);
            this.label37.TabIndex = 21;
            this.label37.Text = "Biserica:";
            // 
            // acte_cult_casatoria_pastor
            // 
            this.acte_cult_casatoria_pastor.Location = new System.Drawing.Point(659, 119);
            this.acte_cult_casatoria_pastor.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_casatoria_pastor.MaxLength = 100;
            this.acte_cult_casatoria_pastor.Name = "acte_cult_casatoria_pastor";
            this.acte_cult_casatoria_pastor.Size = new System.Drawing.Size(221, 29);
            this.acte_cult_casatoria_pastor.TabIndex = 18;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(588, 121);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(57, 21);
            this.label33.TabIndex = 17;
            this.label33.Text = "Pastor:";
            // 
            // acte_cult_casatoria_biserica
            // 
            this.acte_cult_casatoria_biserica.Location = new System.Drawing.Point(348, 119);
            this.acte_cult_casatoria_biserica.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_casatoria_biserica.MaxLength = 100;
            this.acte_cult_casatoria_biserica.Name = "acte_cult_casatoria_biserica";
            this.acte_cult_casatoria_biserica.Size = new System.Drawing.Size(224, 29);
            this.acte_cult_casatoria_biserica.TabIndex = 16;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(278, 122);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(66, 21);
            this.label34.TabIndex = 15;
            this.label34.Text = "Biserica:";
            // 
            // acte_cult_botez_pastor
            // 
            this.acte_cult_botez_pastor.Location = new System.Drawing.Point(659, 77);
            this.acte_cult_botez_pastor.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_botez_pastor.MaxLength = 100;
            this.acte_cult_botez_pastor.Name = "acte_cult_botez_pastor";
            this.acte_cult_botez_pastor.Size = new System.Drawing.Size(221, 29);
            this.acte_cult_botez_pastor.TabIndex = 12;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(588, 79);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(57, 21);
            this.label30.TabIndex = 11;
            this.label30.Text = "Pastor:";
            // 
            // acte_cult_botez_biserica
            // 
            this.acte_cult_botez_biserica.Location = new System.Drawing.Point(348, 79);
            this.acte_cult_botez_biserica.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_botez_biserica.MaxLength = 100;
            this.acte_cult_botez_biserica.Name = "acte_cult_botez_biserica";
            this.acte_cult_botez_biserica.Size = new System.Drawing.Size(224, 29);
            this.acte_cult_botez_biserica.TabIndex = 10;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(278, 80);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(66, 21);
            this.label31.TabIndex = 9;
            this.label31.Text = "Biserica:";
            // 
            // acte_cult_binec_pastor
            // 
            this.acte_cult_binec_pastor.Location = new System.Drawing.Point(659, 35);
            this.acte_cult_binec_pastor.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_binec_pastor.MaxLength = 100;
            this.acte_cult_binec_pastor.Name = "acte_cult_binec_pastor";
            this.acte_cult_binec_pastor.Size = new System.Drawing.Size(221, 29);
            this.acte_cult_binec_pastor.TabIndex = 6;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(588, 37);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(57, 21);
            this.label28.TabIndex = 5;
            this.label28.Text = "Pastor:";
            // 
            // acte_cult_binec_biserica
            // 
            this.acte_cult_binec_biserica.Location = new System.Drawing.Point(348, 35);
            this.acte_cult_binec_biserica.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.acte_cult_binec_biserica.MaxLength = 100;
            this.acte_cult_binec_biserica.Name = "acte_cult_binec_biserica";
            this.acte_cult_binec_biserica.Size = new System.Drawing.Size(224, 29);
            this.acte_cult_binec_biserica.TabIndex = 4;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(278, 38);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(66, 21);
            this.label29.TabIndex = 3;
            this.label29.Text = "Biserica:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.familia_copil10_data_botez);
            this.groupBox5.Controls.Add(this.familia_copil10_data_binec);
            this.groupBox5.Controls.Add(this.familia_copil10_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_copil9_data_botez);
            this.groupBox5.Controls.Add(this.familia_copil9_data_binec);
            this.groupBox5.Controls.Add(this.familia_copil9_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_copil8_data_botez);
            this.groupBox5.Controls.Add(this.familia_copil8_data_binec);
            this.groupBox5.Controls.Add(this.familia_copil8_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_copil7_data_botez);
            this.groupBox5.Controls.Add(this.familia_copil7_data_binec);
            this.groupBox5.Controls.Add(this.familia_copil7_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_copil6_data_botez);
            this.groupBox5.Controls.Add(this.familia_copil6_data_binec);
            this.groupBox5.Controls.Add(this.familia_copil6_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_copil5_data_botez);
            this.groupBox5.Controls.Add(this.familia_copil5_data_binec);
            this.groupBox5.Controls.Add(this.familia_copil5_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_copil4_data_botez);
            this.groupBox5.Controls.Add(this.familia_copil4_data_binec);
            this.groupBox5.Controls.Add(this.familia_copil4_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_copil3_data_botez);
            this.groupBox5.Controls.Add(this.familia_copil3_data_binec);
            this.groupBox5.Controls.Add(this.familia_copil3_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_copil2_data_botez);
            this.groupBox5.Controls.Add(this.familia_copil2_data_binec);
            this.groupBox5.Controls.Add(this.familia_copil2_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_copil1_data_botez);
            this.groupBox5.Controls.Add(this.familia_copil1_data_binec);
            this.groupBox5.Controls.Add(this.familia_copil1_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_sotul_data_nasterii);
            this.groupBox5.Controls.Add(this.familia_copil10);
            this.groupBox5.Controls.Add(this.familia_copil9);
            this.groupBox5.Controls.Add(this.familia_copil8);
            this.groupBox5.Controls.Add(this.familia_copil7);
            this.groupBox5.Controls.Add(this.familia_copil6);
            this.groupBox5.Controls.Add(this.familia_copil5);
            this.groupBox5.Controls.Add(this.familia_copil4);
            this.groupBox5.Controls.Add(this.familia_copil3);
            this.groupBox5.Controls.Add(this.familia_copil2);
            this.groupBox5.Controls.Add(this.familia_copil1);
            this.groupBox5.Controls.Add(this.label38);
            this.groupBox5.Controls.Add(this.label35);
            this.groupBox5.Controls.Add(this.familia_copil10_nr_fisa);
            this.groupBox5.Controls.Add(this.familia_copil10_stare_civila);
            this.groupBox5.Controls.Add(this.familia_copil10_nume);
            this.groupBox5.Controls.Add(this.familia_copil9_nr_fisa);
            this.groupBox5.Controls.Add(this.familia_copil9_stare_civila);
            this.groupBox5.Controls.Add(this.familia_copil9_nume);
            this.groupBox5.Controls.Add(this.familia_copil8_nr_fisa);
            this.groupBox5.Controls.Add(this.familia_copil8_stare_civila);
            this.groupBox5.Controls.Add(this.familia_copil8_nume);
            this.groupBox5.Controls.Add(this.familia_copil7_nr_fisa);
            this.groupBox5.Controls.Add(this.familia_copil7_stare_civila);
            this.groupBox5.Controls.Add(this.familia_copil7_nume);
            this.groupBox5.Controls.Add(this.familia_copil6_nr_fisa);
            this.groupBox5.Controls.Add(this.familia_copil6_stare_civila);
            this.groupBox5.Controls.Add(this.familia_copil6_nume);
            this.groupBox5.Controls.Add(this.familia_copil5_nr_fisa);
            this.groupBox5.Controls.Add(this.familia_copil5_stare_civila);
            this.groupBox5.Controls.Add(this.familia_copil5_nume);
            this.groupBox5.Controls.Add(this.familia_copil4_nr_fisa);
            this.groupBox5.Controls.Add(this.familia_copil4_stare_civila);
            this.groupBox5.Controls.Add(this.familia_copil4_nume);
            this.groupBox5.Controls.Add(this.familia_copil3_nr_fisa);
            this.groupBox5.Controls.Add(this.familia_copil3_stare_civila);
            this.groupBox5.Controls.Add(this.familia_copil3_nume);
            this.groupBox5.Controls.Add(this.familia_copil2_nr_fisa);
            this.groupBox5.Controls.Add(this.familia_copil2_stare_civila);
            this.groupBox5.Controls.Add(this.familia_copil2_nume);
            this.groupBox5.Controls.Add(this.familia_copil1_nr_fisa);
            this.groupBox5.Controls.Add(this.familia_copil1_stare_civila);
            this.groupBox5.Controls.Add(this.label54);
            this.groupBox5.Controls.Add(this.label53);
            this.groupBox5.Controls.Add(this.label52);
            this.groupBox5.Controls.Add(this.label51);
            this.groupBox5.Controls.Add(this.label50);
            this.groupBox5.Controls.Add(this.label49);
            this.groupBox5.Controls.Add(this.familia_copil1_nume);
            this.groupBox5.Controls.Add(this.familia_sotul_religie);
            this.groupBox5.Controls.Add(this.label46);
            this.groupBox5.Controls.Add(this.familia_sotul_localitate);
            this.groupBox5.Controls.Add(this.label45);
            this.groupBox5.Controls.Add(this.label44);
            this.groupBox5.Controls.Add(this.familia_sotul_numar_fisa);
            this.groupBox5.Controls.Add(this.label43);
            this.groupBox5.Controls.Add(this.familia_sotul);
            this.groupBox5.Location = new System.Drawing.Point(369, 919);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox5.Size = new System.Drawing.Size(894, 583);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Date privind familia:";
            // 
            // familia_copil10_data_botez
            // 
            this.familia_copil10_data_botez.Location = new System.Drawing.Point(569, 530);
            this.familia_copil10_data_botez.Name = "familia_copil10_data_botez";
            this.familia_copil10_data_botez.Size = new System.Drawing.Size(100, 29);
            this.familia_copil10_data_botez.TabIndex = 129;
            // 
            // familia_copil10_data_binec
            // 
            this.familia_copil10_data_binec.Location = new System.Drawing.Point(451, 530);
            this.familia_copil10_data_binec.Name = "familia_copil10_data_binec";
            this.familia_copil10_data_binec.Size = new System.Drawing.Size(105, 29);
            this.familia_copil10_data_binec.TabIndex = 128;
            // 
            // familia_copil10_data_nasterii
            // 
            this.familia_copil10_data_nasterii.Location = new System.Drawing.Point(330, 531);
            this.familia_copil10_data_nasterii.Name = "familia_copil10_data_nasterii";
            this.familia_copil10_data_nasterii.Size = new System.Drawing.Size(105, 29);
            this.familia_copil10_data_nasterii.TabIndex = 127;
            // 
            // familia_copil9_data_botez
            // 
            this.familia_copil9_data_botez.Location = new System.Drawing.Point(569, 489);
            this.familia_copil9_data_botez.Name = "familia_copil9_data_botez";
            this.familia_copil9_data_botez.Size = new System.Drawing.Size(100, 29);
            this.familia_copil9_data_botez.TabIndex = 126;
            // 
            // familia_copil9_data_binec
            // 
            this.familia_copil9_data_binec.Location = new System.Drawing.Point(451, 488);
            this.familia_copil9_data_binec.Name = "familia_copil9_data_binec";
            this.familia_copil9_data_binec.Size = new System.Drawing.Size(105, 29);
            this.familia_copil9_data_binec.TabIndex = 125;
            // 
            // familia_copil9_data_nasterii
            // 
            this.familia_copil9_data_nasterii.Location = new System.Drawing.Point(330, 488);
            this.familia_copil9_data_nasterii.Name = "familia_copil9_data_nasterii";
            this.familia_copil9_data_nasterii.Size = new System.Drawing.Size(104, 29);
            this.familia_copil9_data_nasterii.TabIndex = 124;
            // 
            // familia_copil8_data_botez
            // 
            this.familia_copil8_data_botez.Location = new System.Drawing.Point(569, 448);
            this.familia_copil8_data_botez.Name = "familia_copil8_data_botez";
            this.familia_copil8_data_botez.Size = new System.Drawing.Size(100, 29);
            this.familia_copil8_data_botez.TabIndex = 123;
            // 
            // familia_copil8_data_binec
            // 
            this.familia_copil8_data_binec.Location = new System.Drawing.Point(451, 447);
            this.familia_copil8_data_binec.Name = "familia_copil8_data_binec";
            this.familia_copil8_data_binec.Size = new System.Drawing.Size(105, 29);
            this.familia_copil8_data_binec.TabIndex = 122;
            // 
            // familia_copil8_data_nasterii
            // 
            this.familia_copil8_data_nasterii.Location = new System.Drawing.Point(330, 447);
            this.familia_copil8_data_nasterii.Name = "familia_copil8_data_nasterii";
            this.familia_copil8_data_nasterii.Size = new System.Drawing.Size(105, 29);
            this.familia_copil8_data_nasterii.TabIndex = 121;
            // 
            // familia_copil7_data_botez
            // 
            this.familia_copil7_data_botez.Location = new System.Drawing.Point(569, 404);
            this.familia_copil7_data_botez.Name = "familia_copil7_data_botez";
            this.familia_copil7_data_botez.Size = new System.Drawing.Size(100, 29);
            this.familia_copil7_data_botez.TabIndex = 120;
            // 
            // familia_copil7_data_binec
            // 
            this.familia_copil7_data_binec.Location = new System.Drawing.Point(451, 404);
            this.familia_copil7_data_binec.Name = "familia_copil7_data_binec";
            this.familia_copil7_data_binec.Size = new System.Drawing.Size(105, 29);
            this.familia_copil7_data_binec.TabIndex = 119;
            // 
            // familia_copil7_data_nasterii
            // 
            this.familia_copil7_data_nasterii.Location = new System.Drawing.Point(330, 404);
            this.familia_copil7_data_nasterii.Name = "familia_copil7_data_nasterii";
            this.familia_copil7_data_nasterii.Size = new System.Drawing.Size(104, 29);
            this.familia_copil7_data_nasterii.TabIndex = 118;
            // 
            // familia_copil6_data_botez
            // 
            this.familia_copil6_data_botez.Location = new System.Drawing.Point(569, 362);
            this.familia_copil6_data_botez.Name = "familia_copil6_data_botez";
            this.familia_copil6_data_botez.Size = new System.Drawing.Size(100, 29);
            this.familia_copil6_data_botez.TabIndex = 117;
            // 
            // familia_copil6_data_binec
            // 
            this.familia_copil6_data_binec.Location = new System.Drawing.Point(451, 364);
            this.familia_copil6_data_binec.Name = "familia_copil6_data_binec";
            this.familia_copil6_data_binec.Size = new System.Drawing.Size(105, 29);
            this.familia_copil6_data_binec.TabIndex = 116;
            // 
            // familia_copil6_data_nasterii
            // 
            this.familia_copil6_data_nasterii.Location = new System.Drawing.Point(330, 365);
            this.familia_copil6_data_nasterii.Name = "familia_copil6_data_nasterii";
            this.familia_copil6_data_nasterii.Size = new System.Drawing.Size(105, 29);
            this.familia_copil6_data_nasterii.TabIndex = 115;
            // 
            // familia_copil5_data_botez
            // 
            this.familia_copil5_data_botez.Location = new System.Drawing.Point(569, 321);
            this.familia_copil5_data_botez.Name = "familia_copil5_data_botez";
            this.familia_copil5_data_botez.Size = new System.Drawing.Size(100, 29);
            this.familia_copil5_data_botez.TabIndex = 114;
            // 
            // familia_copil5_data_binec
            // 
            this.familia_copil5_data_binec.Location = new System.Drawing.Point(451, 320);
            this.familia_copil5_data_binec.Name = "familia_copil5_data_binec";
            this.familia_copil5_data_binec.Size = new System.Drawing.Size(105, 29);
            this.familia_copil5_data_binec.TabIndex = 113;
            // 
            // familia_copil5_data_nasterii
            // 
            this.familia_copil5_data_nasterii.Location = new System.Drawing.Point(330, 320);
            this.familia_copil5_data_nasterii.Name = "familia_copil5_data_nasterii";
            this.familia_copil5_data_nasterii.Size = new System.Drawing.Size(104, 29);
            this.familia_copil5_data_nasterii.TabIndex = 112;
            // 
            // familia_copil4_data_botez
            // 
            this.familia_copil4_data_botez.Location = new System.Drawing.Point(569, 279);
            this.familia_copil4_data_botez.Name = "familia_copil4_data_botez";
            this.familia_copil4_data_botez.Size = new System.Drawing.Size(100, 29);
            this.familia_copil4_data_botez.TabIndex = 111;
            // 
            // familia_copil4_data_binec
            // 
            this.familia_copil4_data_binec.Location = new System.Drawing.Point(451, 280);
            this.familia_copil4_data_binec.Name = "familia_copil4_data_binec";
            this.familia_copil4_data_binec.Size = new System.Drawing.Size(105, 29);
            this.familia_copil4_data_binec.TabIndex = 110;
            // 
            // familia_copil4_data_nasterii
            // 
            this.familia_copil4_data_nasterii.Location = new System.Drawing.Point(330, 279);
            this.familia_copil4_data_nasterii.Name = "familia_copil4_data_nasterii";
            this.familia_copil4_data_nasterii.Size = new System.Drawing.Size(104, 29);
            this.familia_copil4_data_nasterii.TabIndex = 109;
            // 
            // familia_copil3_data_botez
            // 
            this.familia_copil3_data_botez.Location = new System.Drawing.Point(569, 236);
            this.familia_copil3_data_botez.Name = "familia_copil3_data_botez";
            this.familia_copil3_data_botez.Size = new System.Drawing.Size(100, 29);
            this.familia_copil3_data_botez.TabIndex = 108;
            // 
            // familia_copil3_data_binec
            // 
            this.familia_copil3_data_binec.Location = new System.Drawing.Point(451, 236);
            this.familia_copil3_data_binec.Name = "familia_copil3_data_binec";
            this.familia_copil3_data_binec.Size = new System.Drawing.Size(105, 29);
            this.familia_copil3_data_binec.TabIndex = 107;
            // 
            // familia_copil3_data_nasterii
            // 
            this.familia_copil3_data_nasterii.Location = new System.Drawing.Point(330, 237);
            this.familia_copil3_data_nasterii.Name = "familia_copil3_data_nasterii";
            this.familia_copil3_data_nasterii.Size = new System.Drawing.Size(104, 29);
            this.familia_copil3_data_nasterii.TabIndex = 106;
            // 
            // familia_copil2_data_botez
            // 
            this.familia_copil2_data_botez.Location = new System.Drawing.Point(569, 195);
            this.familia_copil2_data_botez.Name = "familia_copil2_data_botez";
            this.familia_copil2_data_botez.Size = new System.Drawing.Size(100, 29);
            this.familia_copil2_data_botez.TabIndex = 105;
            // 
            // familia_copil2_data_binec
            // 
            this.familia_copil2_data_binec.Location = new System.Drawing.Point(451, 194);
            this.familia_copil2_data_binec.Name = "familia_copil2_data_binec";
            this.familia_copil2_data_binec.Size = new System.Drawing.Size(105, 29);
            this.familia_copil2_data_binec.TabIndex = 104;
            // 
            // familia_copil2_data_nasterii
            // 
            this.familia_copil2_data_nasterii.Location = new System.Drawing.Point(330, 194);
            this.familia_copil2_data_nasterii.Name = "familia_copil2_data_nasterii";
            this.familia_copil2_data_nasterii.Size = new System.Drawing.Size(105, 29);
            this.familia_copil2_data_nasterii.TabIndex = 103;
            // 
            // familia_copil1_data_botez
            // 
            this.familia_copil1_data_botez.Location = new System.Drawing.Point(569, 154);
            this.familia_copil1_data_botez.Name = "familia_copil1_data_botez";
            this.familia_copil1_data_botez.Size = new System.Drawing.Size(100, 29);
            this.familia_copil1_data_botez.TabIndex = 102;
            // 
            // familia_copil1_data_binec
            // 
            this.familia_copil1_data_binec.Location = new System.Drawing.Point(451, 153);
            this.familia_copil1_data_binec.Name = "familia_copil1_data_binec";
            this.familia_copil1_data_binec.Size = new System.Drawing.Size(105, 29);
            this.familia_copil1_data_binec.TabIndex = 101;
            // 
            // familia_copil1_data_nasterii
            // 
            this.familia_copil1_data_nasterii.Location = new System.Drawing.Point(330, 153);
            this.familia_copil1_data_nasterii.Name = "familia_copil1_data_nasterii";
            this.familia_copil1_data_nasterii.Size = new System.Drawing.Size(105, 29);
            this.familia_copil1_data_nasterii.TabIndex = 100;
            // 
            // familia_sotul_data_nasterii
            // 
            this.familia_sotul_data_nasterii.Location = new System.Drawing.Point(126, 79);
            this.familia_sotul_data_nasterii.Name = "familia_sotul_data_nasterii";
            this.familia_sotul_data_nasterii.Size = new System.Drawing.Size(133, 29);
            this.familia_sotul_data_nasterii.TabIndex = 99;
            // 
            // familia_copil10
            // 
            this.familia_copil10.AutoSize = true;
            this.familia_copil10.Location = new System.Drawing.Point(12, 532);
            this.familia_copil10.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.familia_copil10.Name = "familia_copil10";
            this.familia_copil10.Size = new System.Drawing.Size(47, 25);
            this.familia_copil10.TabIndex = 98;
            this.familia_copil10.Text = "10";
            this.familia_copil10.UseVisualStyleBackColor = true;
            // 
            // familia_copil9
            // 
            this.familia_copil9.AutoSize = true;
            this.familia_copil9.Location = new System.Drawing.Point(18, 490);
            this.familia_copil9.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.familia_copil9.Name = "familia_copil9";
            this.familia_copil9.Size = new System.Drawing.Size(38, 25);
            this.familia_copil9.TabIndex = 97;
            this.familia_copil9.Text = "9";
            this.familia_copil9.UseVisualStyleBackColor = true;
            // 
            // familia_copil8
            // 
            this.familia_copil8.AutoSize = true;
            this.familia_copil8.Location = new System.Drawing.Point(19, 452);
            this.familia_copil8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.familia_copil8.Name = "familia_copil8";
            this.familia_copil8.Size = new System.Drawing.Size(38, 25);
            this.familia_copil8.TabIndex = 96;
            this.familia_copil8.Text = "8";
            this.familia_copil8.UseVisualStyleBackColor = true;
            // 
            // familia_copil7
            // 
            this.familia_copil7.AutoSize = true;
            this.familia_copil7.Location = new System.Drawing.Point(19, 406);
            this.familia_copil7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.familia_copil7.Name = "familia_copil7";
            this.familia_copil7.Size = new System.Drawing.Size(38, 25);
            this.familia_copil7.TabIndex = 95;
            this.familia_copil7.Text = "7";
            this.familia_copil7.UseVisualStyleBackColor = true;
            // 
            // familia_copil6
            // 
            this.familia_copil6.AutoSize = true;
            this.familia_copil6.Location = new System.Drawing.Point(19, 364);
            this.familia_copil6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.familia_copil6.Name = "familia_copil6";
            this.familia_copil6.Size = new System.Drawing.Size(38, 25);
            this.familia_copil6.TabIndex = 94;
            this.familia_copil6.Text = "6";
            this.familia_copil6.UseVisualStyleBackColor = true;
            // 
            // familia_copil5
            // 
            this.familia_copil5.AutoSize = true;
            this.familia_copil5.Location = new System.Drawing.Point(19, 326);
            this.familia_copil5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.familia_copil5.Name = "familia_copil5";
            this.familia_copil5.Size = new System.Drawing.Size(38, 25);
            this.familia_copil5.TabIndex = 93;
            this.familia_copil5.Text = "5";
            this.familia_copil5.UseVisualStyleBackColor = true;
            // 
            // familia_copil4
            // 
            this.familia_copil4.AutoSize = true;
            this.familia_copil4.Location = new System.Drawing.Point(19, 280);
            this.familia_copil4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.familia_copil4.Name = "familia_copil4";
            this.familia_copil4.Size = new System.Drawing.Size(38, 25);
            this.familia_copil4.TabIndex = 92;
            this.familia_copil4.Text = "4";
            this.familia_copil4.UseVisualStyleBackColor = true;
            // 
            // familia_copil3
            // 
            this.familia_copil3.AutoSize = true;
            this.familia_copil3.Location = new System.Drawing.Point(19, 238);
            this.familia_copil3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.familia_copil3.Name = "familia_copil3";
            this.familia_copil3.Size = new System.Drawing.Size(38, 25);
            this.familia_copil3.TabIndex = 91;
            this.familia_copil3.Text = "3";
            this.familia_copil3.UseVisualStyleBackColor = true;
            // 
            // familia_copil2
            // 
            this.familia_copil2.AutoSize = true;
            this.familia_copil2.Location = new System.Drawing.Point(19, 196);
            this.familia_copil2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.familia_copil2.Name = "familia_copil2";
            this.familia_copil2.Size = new System.Drawing.Size(38, 25);
            this.familia_copil2.TabIndex = 90;
            this.familia_copil2.Text = "2";
            this.familia_copil2.UseVisualStyleBackColor = true;
            // 
            // familia_copil1
            // 
            this.familia_copil1.AutoSize = true;
            this.familia_copil1.Location = new System.Drawing.Point(19, 154);
            this.familia_copil1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.familia_copil1.Name = "familia_copil1";
            this.familia_copil1.Size = new System.Drawing.Size(38, 25);
            this.familia_copil1.TabIndex = 89;
            this.familia_copil1.Text = "1";
            this.familia_copil1.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(20, 126);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(53, 21);
            this.label38.TabIndex = 88;
            this.label38.Text = "Copiii:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(20, 41);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(98, 21);
            this.label35.TabIndex = 87;
            this.label35.Text = "Soţul / Soţia:";
            // 
            // familia_copil10_nr_fisa
            // 
            this.familia_copil10_nr_fisa.Location = new System.Drawing.Point(816, 531);
            this.familia_copil10_nr_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil10_nr_fisa.MaxLength = 5;
            this.familia_copil10_nr_fisa.Name = "familia_copil10_nr_fisa";
            this.familia_copil10_nr_fisa.Size = new System.Drawing.Size(65, 29);
            this.familia_copil10_nr_fisa.TabIndex = 86;
            // 
            // familia_copil10_stare_civila
            // 
            this.familia_copil10_stare_civila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familia_copil10_stare_civila.FormattingEnabled = true;
            this.familia_copil10_stare_civila.Items.AddRange(new object[] {
            "Nu se aplică",
            "Necasatorit(ă)",
            "Casatorit(ă)",
            "Vaduv(ă)",
            "Altele"});
            this.familia_copil10_stare_civila.Location = new System.Drawing.Point(690, 531);
            this.familia_copil10_stare_civila.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil10_stare_civila.Name = "familia_copil10_stare_civila";
            this.familia_copil10_stare_civila.Size = new System.Drawing.Size(121, 29);
            this.familia_copil10_stare_civila.TabIndex = 85;
            // 
            // familia_copil10_nume
            // 
            this.familia_copil10_nume.Location = new System.Drawing.Point(61, 531);
            this.familia_copil10_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil10_nume.MaxLength = 60;
            this.familia_copil10_nume.Name = "familia_copil10_nume";
            this.familia_copil10_nume.Size = new System.Drawing.Size(254, 29);
            this.familia_copil10_nume.TabIndex = 81;
            // 
            // familia_copil9_nr_fisa
            // 
            this.familia_copil9_nr_fisa.Location = new System.Drawing.Point(816, 489);
            this.familia_copil9_nr_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil9_nr_fisa.MaxLength = 5;
            this.familia_copil9_nr_fisa.Name = "familia_copil9_nr_fisa";
            this.familia_copil9_nr_fisa.Size = new System.Drawing.Size(65, 29);
            this.familia_copil9_nr_fisa.TabIndex = 79;
            // 
            // familia_copil9_stare_civila
            // 
            this.familia_copil9_stare_civila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familia_copil9_stare_civila.FormattingEnabled = true;
            this.familia_copil9_stare_civila.Items.AddRange(new object[] {
            "Nu se aplică",
            "Necasatorit(ă)",
            "Casatorit(ă)",
            "Vaduv(ă)",
            "Altele"});
            this.familia_copil9_stare_civila.Location = new System.Drawing.Point(690, 489);
            this.familia_copil9_stare_civila.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil9_stare_civila.Name = "familia_copil9_stare_civila";
            this.familia_copil9_stare_civila.Size = new System.Drawing.Size(121, 29);
            this.familia_copil9_stare_civila.TabIndex = 78;
            // 
            // familia_copil9_nume
            // 
            this.familia_copil9_nume.Location = new System.Drawing.Point(61, 489);
            this.familia_copil9_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil9_nume.MaxLength = 60;
            this.familia_copil9_nume.Name = "familia_copil9_nume";
            this.familia_copil9_nume.Size = new System.Drawing.Size(254, 29);
            this.familia_copil9_nume.TabIndex = 74;
            // 
            // familia_copil8_nr_fisa
            // 
            this.familia_copil8_nr_fisa.Location = new System.Drawing.Point(816, 447);
            this.familia_copil8_nr_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil8_nr_fisa.MaxLength = 5;
            this.familia_copil8_nr_fisa.Name = "familia_copil8_nr_fisa";
            this.familia_copil8_nr_fisa.Size = new System.Drawing.Size(65, 29);
            this.familia_copil8_nr_fisa.TabIndex = 72;
            // 
            // familia_copil8_stare_civila
            // 
            this.familia_copil8_stare_civila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familia_copil8_stare_civila.FormattingEnabled = true;
            this.familia_copil8_stare_civila.Items.AddRange(new object[] {
            "Nu se aplică",
            "Necasatorit(ă)",
            "Casatorit(ă)",
            "Vaduv(ă)",
            "Altele"});
            this.familia_copil8_stare_civila.Location = new System.Drawing.Point(690, 447);
            this.familia_copil8_stare_civila.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil8_stare_civila.Name = "familia_copil8_stare_civila";
            this.familia_copil8_stare_civila.Size = new System.Drawing.Size(121, 29);
            this.familia_copil8_stare_civila.TabIndex = 71;
            // 
            // familia_copil8_nume
            // 
            this.familia_copil8_nume.Location = new System.Drawing.Point(61, 447);
            this.familia_copil8_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil8_nume.MaxLength = 60;
            this.familia_copil8_nume.Name = "familia_copil8_nume";
            this.familia_copil8_nume.Size = new System.Drawing.Size(254, 29);
            this.familia_copil8_nume.TabIndex = 67;
            // 
            // familia_copil7_nr_fisa
            // 
            this.familia_copil7_nr_fisa.Location = new System.Drawing.Point(816, 405);
            this.familia_copil7_nr_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil7_nr_fisa.MaxLength = 5;
            this.familia_copil7_nr_fisa.Name = "familia_copil7_nr_fisa";
            this.familia_copil7_nr_fisa.Size = new System.Drawing.Size(65, 29);
            this.familia_copil7_nr_fisa.TabIndex = 65;
            // 
            // familia_copil7_stare_civila
            // 
            this.familia_copil7_stare_civila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familia_copil7_stare_civila.FormattingEnabled = true;
            this.familia_copil7_stare_civila.Items.AddRange(new object[] {
            "Nu se aplică",
            "Necasatorit(ă)",
            "Casatorit(ă)",
            "Vaduv(ă)",
            "Altele"});
            this.familia_copil7_stare_civila.Location = new System.Drawing.Point(690, 405);
            this.familia_copil7_stare_civila.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil7_stare_civila.Name = "familia_copil7_stare_civila";
            this.familia_copil7_stare_civila.Size = new System.Drawing.Size(121, 29);
            this.familia_copil7_stare_civila.TabIndex = 64;
            // 
            // familia_copil7_nume
            // 
            this.familia_copil7_nume.Location = new System.Drawing.Point(61, 405);
            this.familia_copil7_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil7_nume.MaxLength = 60;
            this.familia_copil7_nume.Name = "familia_copil7_nume";
            this.familia_copil7_nume.Size = new System.Drawing.Size(254, 29);
            this.familia_copil7_nume.TabIndex = 60;
            // 
            // familia_copil6_nr_fisa
            // 
            this.familia_copil6_nr_fisa.Location = new System.Drawing.Point(816, 363);
            this.familia_copil6_nr_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil6_nr_fisa.MaxLength = 5;
            this.familia_copil6_nr_fisa.Name = "familia_copil6_nr_fisa";
            this.familia_copil6_nr_fisa.Size = new System.Drawing.Size(65, 29);
            this.familia_copil6_nr_fisa.TabIndex = 58;
            // 
            // familia_copil6_stare_civila
            // 
            this.familia_copil6_stare_civila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familia_copil6_stare_civila.FormattingEnabled = true;
            this.familia_copil6_stare_civila.Items.AddRange(new object[] {
            "Nu se aplică",
            "Necasatorit(ă)",
            "Casatorit(ă)",
            "Vaduv(ă)",
            "Altele"});
            this.familia_copil6_stare_civila.Location = new System.Drawing.Point(690, 363);
            this.familia_copil6_stare_civila.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil6_stare_civila.Name = "familia_copil6_stare_civila";
            this.familia_copil6_stare_civila.Size = new System.Drawing.Size(121, 29);
            this.familia_copil6_stare_civila.TabIndex = 57;
            // 
            // familia_copil6_nume
            // 
            this.familia_copil6_nume.Location = new System.Drawing.Point(61, 363);
            this.familia_copil6_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil6_nume.MaxLength = 60;
            this.familia_copil6_nume.Name = "familia_copil6_nume";
            this.familia_copil6_nume.Size = new System.Drawing.Size(254, 29);
            this.familia_copil6_nume.TabIndex = 53;
            // 
            // familia_copil5_nr_fisa
            // 
            this.familia_copil5_nr_fisa.Location = new System.Drawing.Point(816, 321);
            this.familia_copil5_nr_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil5_nr_fisa.MaxLength = 5;
            this.familia_copil5_nr_fisa.Name = "familia_copil5_nr_fisa";
            this.familia_copil5_nr_fisa.Size = new System.Drawing.Size(65, 29);
            this.familia_copil5_nr_fisa.TabIndex = 51;
            // 
            // familia_copil5_stare_civila
            // 
            this.familia_copil5_stare_civila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familia_copil5_stare_civila.FormattingEnabled = true;
            this.familia_copil5_stare_civila.Items.AddRange(new object[] {
            "Nu se aplică",
            "Necasatorit(ă)",
            "Casatorit(ă)",
            "Vaduv(ă)",
            "Altele"});
            this.familia_copil5_stare_civila.Location = new System.Drawing.Point(690, 321);
            this.familia_copil5_stare_civila.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil5_stare_civila.Name = "familia_copil5_stare_civila";
            this.familia_copil5_stare_civila.Size = new System.Drawing.Size(121, 29);
            this.familia_copil5_stare_civila.TabIndex = 50;
            // 
            // familia_copil5_nume
            // 
            this.familia_copil5_nume.Location = new System.Drawing.Point(61, 321);
            this.familia_copil5_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil5_nume.MaxLength = 60;
            this.familia_copil5_nume.Name = "familia_copil5_nume";
            this.familia_copil5_nume.Size = new System.Drawing.Size(254, 29);
            this.familia_copil5_nume.TabIndex = 46;
            // 
            // familia_copil4_nr_fisa
            // 
            this.familia_copil4_nr_fisa.Location = new System.Drawing.Point(816, 279);
            this.familia_copil4_nr_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil4_nr_fisa.MaxLength = 5;
            this.familia_copil4_nr_fisa.Name = "familia_copil4_nr_fisa";
            this.familia_copil4_nr_fisa.Size = new System.Drawing.Size(65, 29);
            this.familia_copil4_nr_fisa.TabIndex = 44;
            // 
            // familia_copil4_stare_civila
            // 
            this.familia_copil4_stare_civila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familia_copil4_stare_civila.FormattingEnabled = true;
            this.familia_copil4_stare_civila.Items.AddRange(new object[] {
            "Nu se aplică",
            "Necasatorit(ă)",
            "Casatorit(ă)",
            "Vaduv(ă)",
            "Altele"});
            this.familia_copil4_stare_civila.Location = new System.Drawing.Point(690, 279);
            this.familia_copil4_stare_civila.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil4_stare_civila.Name = "familia_copil4_stare_civila";
            this.familia_copil4_stare_civila.Size = new System.Drawing.Size(121, 29);
            this.familia_copil4_stare_civila.TabIndex = 43;
            // 
            // familia_copil4_nume
            // 
            this.familia_copil4_nume.Location = new System.Drawing.Point(61, 279);
            this.familia_copil4_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil4_nume.MaxLength = 60;
            this.familia_copil4_nume.Name = "familia_copil4_nume";
            this.familia_copil4_nume.Size = new System.Drawing.Size(254, 29);
            this.familia_copil4_nume.TabIndex = 39;
            // 
            // familia_copil3_nr_fisa
            // 
            this.familia_copil3_nr_fisa.Location = new System.Drawing.Point(816, 237);
            this.familia_copil3_nr_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil3_nr_fisa.MaxLength = 5;
            this.familia_copil3_nr_fisa.Name = "familia_copil3_nr_fisa";
            this.familia_copil3_nr_fisa.Size = new System.Drawing.Size(65, 29);
            this.familia_copil3_nr_fisa.TabIndex = 37;
            // 
            // familia_copil3_stare_civila
            // 
            this.familia_copil3_stare_civila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familia_copil3_stare_civila.FormattingEnabled = true;
            this.familia_copil3_stare_civila.Items.AddRange(new object[] {
            "Nu se aplică",
            "Necasatorit(ă)",
            "Casatorit(ă)",
            "Vaduv(ă)",
            "Altele"});
            this.familia_copil3_stare_civila.Location = new System.Drawing.Point(690, 237);
            this.familia_copil3_stare_civila.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil3_stare_civila.Name = "familia_copil3_stare_civila";
            this.familia_copil3_stare_civila.Size = new System.Drawing.Size(121, 29);
            this.familia_copil3_stare_civila.TabIndex = 36;
            // 
            // familia_copil3_nume
            // 
            this.familia_copil3_nume.Location = new System.Drawing.Point(61, 237);
            this.familia_copil3_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil3_nume.MaxLength = 60;
            this.familia_copil3_nume.Name = "familia_copil3_nume";
            this.familia_copil3_nume.Size = new System.Drawing.Size(254, 29);
            this.familia_copil3_nume.TabIndex = 32;
            // 
            // familia_copil2_nr_fisa
            // 
            this.familia_copil2_nr_fisa.Location = new System.Drawing.Point(816, 195);
            this.familia_copil2_nr_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil2_nr_fisa.MaxLength = 5;
            this.familia_copil2_nr_fisa.Name = "familia_copil2_nr_fisa";
            this.familia_copil2_nr_fisa.Size = new System.Drawing.Size(65, 29);
            this.familia_copil2_nr_fisa.TabIndex = 30;
            // 
            // familia_copil2_stare_civila
            // 
            this.familia_copil2_stare_civila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familia_copil2_stare_civila.FormattingEnabled = true;
            this.familia_copil2_stare_civila.Items.AddRange(new object[] {
            "Nu se aplică",
            "Necasatorit(ă)",
            "Casatorit(ă)",
            "Vaduv(ă)",
            "Altele"});
            this.familia_copil2_stare_civila.Location = new System.Drawing.Point(690, 195);
            this.familia_copil2_stare_civila.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil2_stare_civila.Name = "familia_copil2_stare_civila";
            this.familia_copil2_stare_civila.Size = new System.Drawing.Size(121, 29);
            this.familia_copil2_stare_civila.TabIndex = 29;
            // 
            // familia_copil2_nume
            // 
            this.familia_copil2_nume.Location = new System.Drawing.Point(61, 195);
            this.familia_copil2_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil2_nume.MaxLength = 60;
            this.familia_copil2_nume.Name = "familia_copil2_nume";
            this.familia_copil2_nume.Size = new System.Drawing.Size(254, 29);
            this.familia_copil2_nume.TabIndex = 25;
            // 
            // familia_copil1_nr_fisa
            // 
            this.familia_copil1_nr_fisa.Location = new System.Drawing.Point(816, 153);
            this.familia_copil1_nr_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil1_nr_fisa.MaxLength = 5;
            this.familia_copil1_nr_fisa.Name = "familia_copil1_nr_fisa";
            this.familia_copil1_nr_fisa.Size = new System.Drawing.Size(65, 29);
            this.familia_copil1_nr_fisa.TabIndex = 23;
            // 
            // familia_copil1_stare_civila
            // 
            this.familia_copil1_stare_civila.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.familia_copil1_stare_civila.FormattingEnabled = true;
            this.familia_copil1_stare_civila.Items.AddRange(new object[] {
            "Nu se aplică",
            "Necasatorit(ă)",
            "Casatorit(ă)",
            "Vaduv(ă)",
            "Altele"});
            this.familia_copil1_stare_civila.Location = new System.Drawing.Point(690, 153);
            this.familia_copil1_stare_civila.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil1_stare_civila.Name = "familia_copil1_stare_civila";
            this.familia_copil1_stare_civila.Size = new System.Drawing.Size(121, 29);
            this.familia_copil1_stare_civila.TabIndex = 22;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(812, 128);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(62, 21);
            this.label54.TabIndex = 18;
            this.label54.Text = "Fişa Nr.";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(686, 128);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(88, 21);
            this.label53.TabIndex = 17;
            this.label53.Text = "Stare Civila";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(565, 128);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(84, 21);
            this.label52.TabIndex = 16;
            this.label52.Text = "Data Botez";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(447, 128);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(103, 21);
            this.label51.TabIndex = 15;
            this.label51.Text = "Data Binecuv.";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(334, 128);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(100, 21);
            this.label50.TabIndex = 14;
            this.label50.Text = "Data Naşterii";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(101, 128);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(159, 21);
            this.label49.TabIndex = 13;
            this.label49.Text = "Numele şi prenumele";
            // 
            // familia_copil1_nume
            // 
            this.familia_copil1_nume.Location = new System.Drawing.Point(61, 153);
            this.familia_copil1_nume.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_copil1_nume.MaxLength = 60;
            this.familia_copil1_nume.Name = "familia_copil1_nume";
            this.familia_copil1_nume.Size = new System.Drawing.Size(254, 29);
            this.familia_copil1_nume.TabIndex = 12;
            // 
            // familia_sotul_religie
            // 
            this.familia_sotul_religie.Location = new System.Drawing.Point(734, 78);
            this.familia_sotul_religie.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_sotul_religie.MaxLength = 30;
            this.familia_sotul_religie.Name = "familia_sotul_religie";
            this.familia_sotul_religie.Size = new System.Drawing.Size(145, 29);
            this.familia_sotul_religie.TabIndex = 9;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(561, 82);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(169, 21);
            this.label46.TabIndex = 8;
            this.label46.Text = "Apartenenta religioasă:";
            // 
            // familia_sotul_localitate
            // 
            this.familia_sotul_localitate.Location = new System.Drawing.Point(316, 79);
            this.familia_sotul_localitate.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_sotul_localitate.MaxLength = 50;
            this.familia_sotul_localitate.Name = "familia_sotul_localitate";
            this.familia_sotul_localitate.Size = new System.Drawing.Size(226, 29);
            this.familia_sotul_localitate.TabIndex = 7;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(278, 83);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(37, 21);
            this.label45.TabIndex = 6;
            this.label45.Text = "Loc:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(20, 83);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(100, 21);
            this.label44.TabIndex = 4;
            this.label44.Text = "Data naşterii:";
            // 
            // familia_sotul_numar_fisa
            // 
            this.familia_sotul_numar_fisa.Location = new System.Drawing.Point(776, 37);
            this.familia_sotul_numar_fisa.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_sotul_numar_fisa.MaxLength = 5;
            this.familia_sotul_numar_fisa.Name = "familia_sotul_numar_fisa";
            this.familia_sotul_numar_fisa.Size = new System.Drawing.Size(104, 29);
            this.familia_sotul_numar_fisa.TabIndex = 3;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(597, 41);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(175, 21);
            this.label43.TabIndex = 2;
            this.label43.Text = "Fişa personală numarul:";
            // 
            // familia_sotul
            // 
            this.familia_sotul.Location = new System.Drawing.Point(126, 37);
            this.familia_sotul.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.familia_sotul.MaxLength = 100;
            this.familia_sotul.Name = "familia_sotul";
            this.familia_sotul.Size = new System.Drawing.Size(452, 29);
            this.familia_sotul.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox6.Controls.Add(this.iesire_evidenta_data);
            this.groupBox6.Controls.Add(this.iesire_evidenta_expl);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.label27);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.iesire_evidenta_motiv);
            this.groupBox6.Location = new System.Drawing.Point(369, 1522);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox6.Size = new System.Drawing.Size(894, 106);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Date privind ieşirea din evidenţa membrilor bisericii:";
            // 
            // iesire_evidenta_data
            // 
            this.iesire_evidenta_data.Location = new System.Drawing.Point(359, 37);
            this.iesire_evidenta_data.Name = "iesire_evidenta_data";
            this.iesire_evidenta_data.Size = new System.Drawing.Size(110, 29);
            this.iesire_evidenta_data.TabIndex = 6;
            // 
            // iesire_evidenta_expl
            // 
            this.iesire_evidenta_expl.Location = new System.Drawing.Point(569, 37);
            this.iesire_evidenta_expl.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.iesire_evidenta_expl.MaxLength = 100;
            this.iesire_evidenta_expl.Name = "iesire_evidenta_expl";
            this.iesire_evidenta_expl.Size = new System.Drawing.Size(310, 29);
            this.iesire_evidenta_expl.TabIndex = 5;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(491, 41);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(73, 21);
            this.label32.TabIndex = 4;
            this.label32.Text = "Explicaţii:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(295, 41);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 21);
            this.label27.TabIndex = 2;
            this.label27.Text = "la data:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 40);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 21);
            this.label12.TabIndex = 1;
            this.label12.Text = "Motivul:";
            // 
            // iesire_evidenta_motiv
            // 
            this.iesire_evidenta_motiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.iesire_evidenta_motiv.FormattingEnabled = true;
            this.iesire_evidenta_motiv.Items.AddRange(new object[] {
            "Nu se aplică",
            "Transfer",
            "Deces",
            "La cerere",
            "Excludere"});
            this.iesire_evidenta_motiv.Location = new System.Drawing.Point(98, 37);
            this.iesire_evidenta_motiv.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.iesire_evidenta_motiv.Name = "iesire_evidenta_motiv";
            this.iesire_evidenta_motiv.Size = new System.Drawing.Size(178, 29);
            this.iesire_evidenta_motiv.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.LightGreen;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_save.Location = new System.Drawing.Point(932, 42);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 35);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "SALVEAZĂ";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(1184, 42);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(79, 35);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "ŞTERGE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lstMembers
            // 
            this.lstMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nr_fisa,
            this.nume,
            this.prenume});
            this.lstMembers.Location = new System.Drawing.Point(11, 90);
            this.lstMembers.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(336, 478);
            this.lstMembers.TabIndex = 14;
            this.lstMembers.UseCompatibleStateImageBehavior = false;
            this.lstMembers.SelectedIndexChanged += new System.EventHandler(this.lstMembers_SelectedIndexChanged);
            // 
            // nr_fisa
            // 
            this.nr_fisa.Text = "Fişa";
            this.nr_fisa.Width = 45;
            // 
            // nume
            // 
            this.nume.Text = "Nume";
            this.nume.Width = 134;
            // 
            // prenume
            // 
            this.prenume.Text = "Prenume";
            this.prenume.Width = 134;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(754, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "CURĂŢĂ CÂMPURILE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 29);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(1034, 42);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "ACTUALIZEAZĂ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Caută după număr, nume sau prenume...";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 593);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 30);
            this.label9.TabIndex = 20;
            this.label9.Text = "Statistici:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 633);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Numărul Membrilor:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(7, 657);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(134, 21);
            this.label41.TabIndex = 22;
            this.label41.Text = "Numărul Copiilor:";
            // 
            // memberCount
            // 
            this.memberCount.AutoSize = true;
            this.memberCount.Location = new System.Drawing.Point(177, 633);
            this.memberCount.Name = "memberCount";
            this.memberCount.Size = new System.Drawing.Size(45, 21);
            this.memberCount.TabIndex = 23;
            this.memberCount.Text = "error";
            // 
            // kidsCount
            // 
            this.kidsCount.AutoSize = true;
            this.kidsCount.Location = new System.Drawing.Point(177, 657);
            this.kidsCount.Name = "kidsCount";
            this.kidsCount.Size = new System.Drawing.Size(45, 21);
            this.kidsCount.TabIndex = 24;
            this.kidsCount.Text = "error";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label42.Location = new System.Drawing.Point(12, 1559);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(135, 15);
            this.label42.TabIndex = 25;
            this.label42.Text = "Evidenta Membrilor v1.1";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(12, 1602);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(0, 21);
            this.label47.TabIndex = 26;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(12, 1589);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(264, 15);
            this.label48.TabIndex = 27;
            this.label48.Text = "Made For Biserica Penticostală Betel Dumbraveni";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(12, 1604);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 15);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.beteldumbraveni.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(12, 1574);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(222, 15);
            this.label55.TabIndex = 30;
            this.label55.Text = "Lucian Iacob | luciano.iacob@gmail.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1295, 1045);
            this.Controls.Add(this.label55);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label48);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.kidsCount);
            this.Controls.Add(this.memberCount);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pk_numarul_fisa_personala);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.Name = "Form1";
            this.Text = "BISERICA BETEL | EVIDENTA MEMBRILOR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
