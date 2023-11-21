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
            getURL();
        }


        private void Form1_Load(object sender, EventArgs e) {
            tbInfo.Text = "左にURLを入力してください";
            tbInfo.ReadOnly = true;
        }

        private void lbRssTitle_Click(object sender, EventArgs e) {
            if (lbRssTitle.Items.Count != 0)
            {
                wbBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
                tbRegisterName.Text = ItemDatas[lbRssTitle.SelectedIndex].Title;
                tbRegisterURL.Text = ItemDatas[lbRssTitle.SelectedIndex].Link;
            }
            else
            {
                tbInfo.Text = "選択する項目がありません";
            }
        }

        private void rbIT_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/it.xml";
            getURL();
        }

        private void rbEntertainment_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/entertainment.xml";
            getURL();
        }

        private void rbBusiness_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/business.xml";
            getURL();
        }

        private void rbDomestic_CheckedChanged(object sender, EventArgs e) {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/domestic.xml";
            getURL();
        }

        private void btRegister_Click(object sender, EventArgs e) {
            if (!tbRegisterURL.Text.Equals("") && !tbRegisterName.Text.Equals(""))
            {
                //ListBoxの中身がある時に限って実行
                //if (lbRssTitle.Items.Count != 0 && tbRegisterName.Text == null && tbRegisterURL.Text == null)
                //{
                //    tbRegisterName.Text = lbRssTitle.SelectedItem.ToString();
                //    tbRegisterURL.Text = ItemDatas[lbRssTitle.SelectedIndex].Link;
                //};

                favoriteSet favorite = new favoriteSet(tbRegisterURL.Text, tbRegisterName.Text);

                //Dictionaryにすでに情報が登録されていた場合
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
            else
            {
                tbInfo.Text = "URLと名前を入力してください";
            }
        }

        private void cbRegisterView_SelectedIndexChanged(object sender, EventArgs e) {
            favoriteSet favorite = (favoriteSet)cbRegisterView.SelectedItem;
            //取得したURLがカテゴリではなく記事のURLだったら
            if (favorite.Key.Contains("pickup"))
            {
                //直接記事を表示
                wbBrowser.Navigate(favorite.Key);
            }
            else
            {
                tbUrl.Text = favorite.Key.ToString();
                getURL();
            }
        }

        private void btReset_Click(object sender, EventArgs e) {
            tbUrl.Text = "";
            tbInfo.Text = "";
            tbRegisterName.Text = "";
            tbRegisterURL.Text = "";
            lbRssTitle.Items.Clear();
            cbRegisterView.Items.Clear();
            wbBrowser.DocumentText = "";
        }

        public void getURL() {
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

        private void btRegisterReset_Click(object sender, EventArgs e) {
            tbRegisterName.Text = "";
            tbRegisterURL.Text = "";
        }

        private void btNext_Click(object sender, EventArgs e) {
            try
            {
                wbBrowser.Navigate(ItemDatas[++lbRssTitle.SelectedIndex].Link);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void btPrev_Click(object sender, EventArgs e) {
            try
            {
                wbBrowser.Navigate(ItemDatas[--lbRssTitle.SelectedIndex].Link);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
        }

        private void btComboBoxRemove_Click(object sender, EventArgs e) {
            favoriteSet favorite = (favoriteSet)cbRegisterView.SelectedItem;
            if (favorite != null)
            {
                favoriteDict.Remove(favorite.Key);
                cbRegisterView.Items.RemoveAt(cbRegisterView.SelectedIndex);
            }
            else
            {
                tbInfo.Text = "削除する項目が存在しません";
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e) {
            
        }
    }
}
