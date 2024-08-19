using System;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Discord_Message_Sender
{

    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private static readonly string TrueSend = "Message sent.";

        private static string webhookUrl;
        private static string Bot_Name;
        private static string MessageContent;
        private static string avatarURL;

        public Form1()
        {
            InitializeComponent();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            webhookUrl = WebHook.Text.ToString();

            MessageContent = Message.Text.ToString();

            Bot_Name = BotName.Text.ToString();

            avatarURL = avatar_url_box.Text.ToString();

            Message.Clear();

            Task.Run(SendMessage);

            SendInfo();
        }

        public static async Task SendMessage()
        {
            var message = new
            {
                username = Bot_Name,
                content = MessageContent,
                avatar_url = avatarURL
            };

            var json2 = JsonConvert.SerializeObject(message);
            var data2 = new StringContent(json2, Encoding.UTF8, "application/json");

            await client.PostAsync(webhookUrl, data2);

        }

        async void SendInfo()
        {

            InfoSendView.ForeColor = Color.LimeGreen;
            InfoSendView.Text = TrueSend;

            await Task.Delay(5000);

            InfoSendView.ResetText();

        }

        private void avatar_url_box_TextChanged(object sender, EventArgs e)
        {
            avatarURL = avatar_url_box.Text.ToString();

            avatar_Box.ImageLocation = avatarURL;
        }
    }
}
