using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        Dictionary<string, string> favoriteDict = new Dictionary<string, string>();

        class favoriteSet {
            public string Key { get; set; }
            public string Value { get; set; }

            public favoriteSet(string Key, string Value) {
                this.Key = Key;
                this.Value = Value;
            }

            public override string ToString() {
                return Value;
            }
        }

        List<ItemData> ItemDatas = new List<ItemData>();
        private void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.TextLength != 0)
            {
                using (var wc = new WebClient())
                {
                    try
                    {
                        var url = wc.OpenRead(tbUrl.Text);
                        XDocument xdoc = XDocument.Load(url);

                        ItemDatas.Clear();
                        lbRssTitle.Items.Clear();

                        ItemDatas = xdoc.Root.Descendants("item")
                                                .Select(x => new ItemData
                                                {
                                                    Title = (string)x.Element("title"),
                                                    Link = (string)x.Element("link"),
                                                }).ToList();

                        foreach (var node in ItemDatas)
                        {
                            lbRssTitle.Items.Add(node.Title);
                        }

                    }
                    catch (System.Net.WebException)
                    {
                        tbUrl.Text = string.Empty;
                        tbInfo.Text = "正しいURLを入力してください";
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e) {
            tbInfo.Text = "左にURLを入力してください";
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            if (lbRssTitle.Items.Count != 0)
            {
                wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
            }
            else
            {
                tbInfo.Text = "選択する項目がありません";
            }
        }

        private void rbIT_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
        }

        private void rbEntertainment_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
        }

        private void rbBusiness_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/business.xml";
        }

        private void rbDomestic_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/categories/domestic.xml";
        }

        private void btRegister_Click(object sender, EventArgs e) {

            favoriteSet favorite = new favoriteSet(tbRegisterURL.Text, tbRegisterName.Text);
            if (favoriteDict.ContainsKey(tbRegisterURL.Text) || favoriteDict.ContainsValue(tbRegisterName.Text))
            {
                tbInfo.Text = "名前かURLが登録データと重複しています";
            }
            else
            {
                cbRegisterView.Items.Add(favorite);
                favoriteDict.Add(tbRegisterURL.Text, tbRegisterName.Text);
                tbInfo.Text = "お気に入りデータが登録されました";
            }
        }

        private void cbRegisterView_SelectedIndexChanged(object sender, EventArgs e) {
            favoriteSet favorite = (favoriteSet)cbRegisterView.SelectedItem;
            tbUrl.Text = favorite.Key.ToString();

            
        }
    }
}
