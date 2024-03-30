using System;
using System.Windows.Forms;
using Nethereum.Web3;
using Nethereum.Web3.Accounts;
using Nethereum.Contracts;
using Nethereum.Hex.HexTypes;

namespace NetSimpleGUI
{
    public partial class Form1 : Form
    {
        private Contract contract;
        private Nethereum.Web3.Accounts.Account account;
        private String url;
        private String privateKey;
        private Web3 web3;
        private String contractAddress;
        private String contractABI;
        public Form1()
        {
            InitializeComponent();

            contractAddress = "0xd8ff1F4C7F1cfE21A66B7361D5aF3838FC7a5bb2";
            contractABI = "[{\"inputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"constructor\"},{\"inputs\":[],\"name\":\"getValue\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[],\"name\":\"owner\",\"outputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"stateMutability\":\"view\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"uint256\",\"name\":\"amount\",\"type\":\"uint256\"}],\"name\":\"setValue\",\"outputs\":[],\"stateMutability\":\"nonpayable\",\"type\":\"function\"},{\"inputs\":[{\"internalType\":\"address\",\"name\":\"\",\"type\":\"address\"}],\"name\":\"totalValue\",\"outputs\":[{\"internalType\":\"uint256\",\"name\":\"\",\"type\":\"uint256\"}],\"stateMutability\":\"view\",\"type\":\"function\"}]";

        }

        private async void getValueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var getValueFunction = contract.GetFunction("getValue");
                var value = await getValueFunction.CallAsync<uint>();
                lblContractValue.Text = "Value Retrieved from Contract: " + value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void setValueBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var setValueFunction = contract.GetFunction("setValue");
                uint valueToSet = uint.Parse(setValueInput.Text);

                var transactionReceipt = await setValueFunction.SendTransactionAndWaitForReceiptAsync(account.Address, new HexBigInteger(500000), null, null, valueToSet);
                string transactionHash = transactionReceipt.TransactionHash;
                txHashLbl.Text = transactionHash;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            url = apiLinkInput.Text;
            privateKey = "0x" + privateKeyInput.Text;
            account = new Nethereum.Web3.Accounts.Account(privateKey, 421614);
            web3 = new Web3(account, url);
            contract = web3.Eth.GetContract(contractABI, contractAddress);
            MessageBox.Show("You may now use the Get / Set Value Functions!!");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
