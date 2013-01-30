using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Text;
using System.ComponentModel;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator
{
    class ElTesla : Form
    {
        //default values
        protected const double DEFAULT_AMOUNT = 250; //fee rate
        protected const double DEFAUT_FEE = 19.6800; //mounth fee
        protected const double DEFAULT_HRATE = 0.9150; //VT value
        protected const double DEFAULT_LRATE = 0.4636; //NT value
        protected const double DEFAULT_HSTART = 100; //Start Value for VT
        protected const double DEFAULT_HEND = 200; //End Value for VT
        protected const double DEFAULT_LSTART = 100; //Start Value for NT
        protected const double DEFAULT_LEND = 200; //End Value for NT

        //Button for calculate
        private Button btnCommit;
        //private Button btnBlank;

        //Labels for aditional space
        private Label lblBlank1;
        private Label lblBlank2;
        private Label lblBlank3;
        private Label lblBlank4;
        private Label lblBlank5;
        private Label lblBlank6;

        //For separate sections
        private Label lblSeparator1;
        private Label lblSeparator2;
        private Label lblSeparator3;

        //Input section 
        private Label lblInputSection;

        //Create labels
        private Label lblVT; //high rate
        private Label lblNT; //low rate
        private Label lblKnVT; // label for "Kn"
        private Label lblKnNT; //   -||-

        private Label lblFeeAm;
        private Label lblPayAm;
        private Label lblrateFee;

        //Value section
        private Label lblAmountSection;

        private Label lblHStartDate;
        private Label lblHEndDate;
        private Label lblLStartDate;
        private Label lblLEndDate;
        private Label lblHStart;
        private Label lblHEnd;
        private Label lblLStart;
        private Label lblLEnd;

        private Label lblCalcSection;

        //ComboBoxs
        //private ComboBox cbHDay;
        //private ComboBox cbHMounth;
        //private ComboBox cbLDay;
        //private ComboBox cbLMouth;

        //TextBoxs
        private TextBox tbVT; //cijena VT
        private TextBox tbNT; //cijena NT
        private TextBox tbMountlyFee; //naknada
        private TextBox tbRateFee; //akontacija
        private TextBox tbPayment; // paying value
        private TextBox tbHS; //stanje1 VT
        private TextBox tbHE; //stanje2 VT
        private TextBox tbLS; //stanje1 NT
        private TextBox tbLE; //stanje2 NT

        //TableLayout and Panel
        private TableLayoutPanel tableLP = new TableLayoutPanel();
        private Panel panel = new Panel();


        //Strings for labels
        private static String lblInputSectionString = "Unos Podataka";

        private static String lblHighRateString = "Iznos VT sa PDV-om:";
        private static String lblLowRateString = "Iznos NT sa PDV-om:";
        private static String lblFeeString = "Naknada za mjerne usluge sa PDV-om:";
        private static String lblPaymentAmountString = "Akontacijska rata:";


        private static String lblAmountSectionString = "Stanje Brojila"; //section string

        //za odabir dana i mjeseca
        private static String lblHighStartString = "Odaberite pocetni datum za VT:";
        private static String lblHighEndString = "Odaberite zavrsni datum za VT:";
        private static String lblLowStartString = "Odaberite pocetni datum za NT:";
        private static String lblLowEndString = "Odaberite zavrsni datum za NT:";
        //za unos ocitanog stanja
        private static String lblHighInputValue1 = "Unesite pocetno stanje:";
        private static String lblHighInputValue2 = "Unesite zavrsno stanje:";
        private static String lblLowInputValue1 = "Unesite pocetno stanje:";
        private static String lblLowInputvalue2 = "Unesite zavrsno stanje:";

        private static String lblCalcSectionString = "Izracun"; //section string

        //String for button
        private static String btnCalcString = "Calculate";


        public ElTesla()
        {
            //samo poziv funkcije u kojoj cu inicijalizirati sve kontrole
            InitializeComponent();
        }

        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        public override string ToString()
        {
            return "Tariff Calculator";
        }

        //private void okBtn_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //dobra je praksa inicijalizirati kontrole(objekte) u metodi
        //koju pozivamo u konstruktoru
        private void InitializeComponent()
        {
            //prvo layout manager
            this.tableLP = new TableLayoutPanel();
            //zatim label kontrole
            this.lblBlank1 = new Label(); //razmak
            this.lblInputSection = new Label();
            this.lblSeparator1 = new Label(); //separator
            this.lblVT = new Label();
            this.lblKnVT = new Label();
            this.lblNT = new Label();
            this.lblKnNT = new Label();
            this.lblFeeAm = new Label();
            this.lblPayAm = new Label();
            this.lblBlank3 = new Label(); //razmak
            this.lblAmountSection = new Label();
            this.lblSeparator2 = new Label(); //separator
            this.lblBlank4 = new Label(); //razmak
            //za unos datuma i stanja
            //this.lblHStartDate = new Label();
            //this.cbHDay = new ComboBox();
            //this.cbHMounth = new ComboBox();
            //this.lblHStart = new Label();
            //this.lblHEndDate = new Label();
            //this.lblHEnd = new Label();
            //this.lblLStartDate = new Label();
            //this.lblLStart = new Label();
            //this.lblLEndDate = new Label();
            //this.lblLEnd = new Label();
            //zadnja sekcija
            this.lblBlank5 = new Label();//razmak
            this.lblCalcSection = new Label();
            this.lblSeparator3 = new Label();
            this.lblBlank6 = new Label();

            // i Button
            this.btnCommit = new Button();
            this.tbPayment = new TextBox();

            //will increase performance of application
            //must call ResumeLayout after SuspendLayout method
            //will desible logic of components 
            this.tableLP.SuspendLayout(); //on table
            this.SuspendLayout(); //on whole frame(window)

            //adding components on tableLayoutPanel
            //potreban cast u tip AnchorStyles
            //anchor = usidriti
            this.tableLP.Anchor = (AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom) | (AnchorStyles.Left | AnchorStyles.Right));
            this.tableLP.ColumnCount = 21;
            this.tableLP.ColumnStyles.Add(new ColumnStyle());



            //            //name of window
            //            this.Text = "Calculator";

            //            //InitializeComponent();

            //            //make GUI
            //            this.Controls.Add(tlp);
            //            //tlp.Dock = DockStyle.Top;
            //            this.Controls.Add(panel);
            //            panel.Controls.Add(tlp);
            //            tlp.AutoSize = true;

            //            //space
            //            tlp.Controls.Add(lblBlank1);
            //            lblBlank1.AutoSize = true;

            //            tlp.Controls.Add(lblInput);
            //            lblInput.Text = lblInputSectionString;
            //            lblInput.AutoSize = true;
            //            lblInput.Font = new Font(lblInput.Font, lblInput.Font.Style | FontStyle.Bold);

            //            //lblInput.Anchor = (AnchorStyles.Left);

            //            //separator + space
            //            tlp.Controls.Add(lblSeparator);
            //            lblSeparator.AutoSize = false;
            //            lblSeparator.Height = 2;
            //            lblSeparator.Width = 1000;
            //            lblSeparator.BorderStyle = BorderStyle.Fixed3D;
            //            tlp.Controls.Add(lblBlank2);


            //            tlp.Controls.Add(lblVT);
            //            lblVT.Text = lblHighRateString;
            //            lblVT.AutoSize = true;
            //            lblVT.BorderStyle = BorderStyle.Fixed3D;
            //            tlp.Controls.Add(tbVT);
            //            tbVT.TextAlign = HorizontalAlignment.Center;


        }

        [STAThread]
        public static void Main(String[] argv)
        {

            Application.EnableVisualStyles();
            Application.Run(new ElTesla());
        }
    }
}

    

