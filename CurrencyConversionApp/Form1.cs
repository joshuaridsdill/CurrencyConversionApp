namespace CurrencyConversionApp
{
    public partial class Form1 : Form
    {
        double result;
        Currency currency;
        Currency currencyResult;

        public double CalculateCurrencyConversion(CurrencyType currencyType1, CurrencyType currencyType2)
        {
            switch (currencyType1)
            {
                case CurrencyType.GBP:
                    switch (currencyType2)
                    {
                        case CurrencyType.USD:
                            result = (double)numericUpDown1.Value * 1.24;
                            break;
                        case CurrencyType.AUS:
                            result = (double)numericUpDown1.Value * 1.81;
                            break;
                        case CurrencyType.EUR:
                            result = (double)numericUpDown1.Value * 1.16;
                            break;
                        default:
                            break;
                    }
                    break;
                case CurrencyType.USD:
                    switch (currencyType2)
                    {
                        case CurrencyType.GBP:
                            result = (double)numericUpDown1.Value * 0.81;
                            break;
                        case CurrencyType.AUS:
                            result = (double)numericUpDown1.Value * 1.46;
                            break;
                        case CurrencyType.EUR:
                            result = (double)numericUpDown1.Value * 0.94;
                            break;
                        default:
                            break;
                    }
                    break;
                case CurrencyType.AUS:
                    switch (currencyType2)
                    {
                        case CurrencyType.GBP:
                            result = (double)numericUpDown1.Value * 0.55;
                            break;
                        case CurrencyType.USD:
                            result = (double)numericUpDown1.Value * 0.69;
                            break;
                        case CurrencyType.EUR:
                            result = (double)numericUpDown1.Value * 0.64;
                            break;
                        default:
                            break;
                    }
                    break;
                case CurrencyType.EUR:
                    switch (currencyType2)
                    {
                        case CurrencyType.GBP:
                            result = (double)numericUpDown1.Value * 0.86;
                            break;
                        case CurrencyType.USD:
                            result = (double)numericUpDown1.Value * 1.07;
                            break;
                        case CurrencyType.AUS:
                            result = (double)numericUpDown1.Value * 1.56;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }

            return result;
        }

        public Currency CalculateCurrencyConversions_Upd(Currency currency, Currency currencyResult)
        {
            switch (currencyResult.Type)
            {
                case CurrencyType.GBP:
                    currencyResult = currency.toGBP();
                    break;
                case CurrencyType.USD:
                    currencyResult = currency.toUSD();
                    break;
                case CurrencyType.AUS:
                    currencyResult = currency.toAUS();
                    break;
                case CurrencyType.EUR:
                    currencyResult = currency.toEUR();
                    break;
            }

            return currencyResult;
        }

        public Form1()
        {
            InitializeComponent();
            result = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<CurrencyType> currencyTypes = new List<CurrencyType>();
            currencyTypes.Add(CurrencyType.GBP);
            currencyTypes.Add(CurrencyType.USD);
            currencyTypes.Add(CurrencyType.AUS);
            currencyTypes.Add(CurrencyType.EUR);

            foreach(CurrencyType currency in currencyTypes)
            {
                cb_currenyType1.Items.Add(currency);
                cb_currenyType2.Items.Add(currency);
            }

            cb_currenyType1.SelectedIndex = 0;
            cb_currenyType2.SelectedIndex = 1;

            //currency.Price = 0;
            //currency.Type = CurrencyType.GBP;

            //currencyResult.Price = 0;
            //currencyResult.Type = CurrencyType.USD;
        }

        private void btn_logConversion_Click(object sender, EventArgs e)
        {
            CurrencyType currencyType1 = (CurrencyType)cb_currenyType1.SelectedIndex;
            CurrencyType currencyType2 = (CurrencyType)cb_currenyType2.SelectedIndex;
            //CurrencyType currencyType1 = (CurrencyType)currency.Type;
            //CurrencyType currencyType2 = (CurrencyType)currencyResult.Type;
            string log = currencyType1 + "->" + currencyType2 + ": " + lbl_ConversionResult.Text;
            lb_previousConversions.Items.Add(log);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //currency.Price = (double)numericUpDown1.Value;
            //currencyResult = CalculateCurrencyConversions_Upd(currency, currencyResult);

            //lbl_ConversionResult.Text = currencyResult.Price.ToString();

            lbl_ConversionResult.Text = CalculateCurrencyConversion((CurrencyType)cb_currenyType1.SelectedIndex, (CurrencyType)cb_currenyType2.SelectedIndex).ToString();
        }

        private void cb_currenyType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //currency.Type = (CurrencyType)cb_currenyType2.SelectedIndex;
            //currencyResult = CalculateCurrencyConversions_Upd(currency, currencyResult);

            //lbl_ConversionResult.Text = currencyResult.Price.ToString();

            lbl_ConversionResult.Text = CalculateCurrencyConversion((CurrencyType)cb_currenyType1.SelectedIndex, (CurrencyType)cb_currenyType2.SelectedIndex).ToString();
        }

        private void cb_currenyType2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //currencyResult = CalculateCurrencyConversions_Upd(currency, currencyResult);

            //lbl_ConversionResult.Text = currencyResult.Price.ToString();

            lbl_ConversionResult.Text = CalculateCurrencyConversion((CurrencyType)cb_currenyType1.SelectedIndex, (CurrencyType)cb_currenyType2.SelectedIndex).ToString();
        }

        private void btn_SaveLog_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = saveFileDialog1.FileName + "." + DateTime.Now.ToString("dd_MM_yy");

            if(saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                BinaryWriter binaryWriter = new BinaryWriter(File.Create(path));

                foreach (string index in lb_previousConversions.Items)
                {
                    binaryWriter.Write(index);
                }
                binaryWriter.Dispose();
            }
        }

        private void btn_clearLog_Click(object sender, EventArgs e)
        {
            lb_previousConversions.Items.Clear();
        }

        private void btn_queryLog_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = openFileDialog1.FileName + "." + DateTime.Now.ToString("dd_MM_yy");

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                string readFile = File.ReadAllText(path);
                lb_previousConversions.Items.Clear();
                lb_previousConversions.Items.Add(readFile);
            }
        }
    }
}