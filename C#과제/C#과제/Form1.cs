using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_과제
{
    public partial class Form1 : Form
    {
        Deck deck;
        Player player;
        Dealer dealer;

        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            player = new Player(100);
            dealer = new Dealer();
            moneyLabel.Text = "100";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imagePath = @"D:\Git\blackjack\C#과제\Image\deck_image.png";
            deck_pb.SizeMode = PictureBoxSizeMode.Zoom;
            deck_pb.Image = Image.FromFile(imagePath);

            string backgroundImagePath = @"D:\Git\blackjack\C#과제\Image\BackGround.jpg";
            this.BackgroundImage = Image.FromFile(backgroundImagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch;

            MakePictureBoxTransparent(player_pb1);
            MakePictureBoxTransparent(player_pb2);
            MakePictureBoxTransparent(player_pb3);
            MakePictureBoxTransparent(deal_pb1);
            MakePictureBoxTransparent(deal_pb2);
            MakePictureBoxTransparent(deal_pb3);
        }

        private void MakePictureBoxTransparent(PictureBox pb)
        {
            pb.BackColor = Color.Transparent;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Visible = false;
        }

        private void LoadImage(PictureBox pictureBox, string path)
        {
            if (System.IO.File.Exists(path))
            {
                Image oldImage = pictureBox.Image;
                pictureBox.Image = Image.FromFile(path);
                pictureBox.Visible = true;
                oldImage?.Dispose();
            }
            else
            {
                pictureBox.Image = null;
                pictureBox.Visible = false;
            }
        }

        private void hit_btn_Click(object sender, EventArgs e)
        {
            if (deck.Cards.Count > 0)
            {
                Card card = deck.Cards[0];
                deck.Cards.RemoveAt(0);
                player.Hand.Add(card);

                LoadImage(player_pb3, $"D:\\Git\\blackjack\\C#과제\\Card\\{card.Rank.Trim()}{card.Suit}.png");
                UpdatePoints();
            }
            if (dealer.CalculateTotal() <= 16 && dealer.Hand.Count < 3)
            {
                if (deck.Cards.Count > 0)
                {
                    Card card = deck.Cards[0];
                    deck.Cards.RemoveAt(0);
                    dealer.Hand.Add(card);

                    LoadImage(deal_pb3, $"D:\\Git\\blackjack\\C#과제\\Card\\{card.Rank.Trim()}{card.Suit}.png");
                    UpdatePoints();
                }
            }
            ComparePoints();
            betLabel.Text = "";
        }

        private void stay_btn_Click(object sender, EventArgs e)
        {
            if (dealer.CalculateTotal() <= 16 && dealer.Hand.Count < 3)
            {
                if (deck.Cards.Count > 0)
                {
                    Card card = deck.Cards[0];
                    deck.Cards.RemoveAt(0);
                    dealer.Hand.Add(card);

                    LoadImage(deal_pb3, $"D:\\Git\\blackjack\\C#과제\\Card\\{card.Rank.Trim()}{card.Suit}.png");
                    UpdatePoints();
                }
            }
            ComparePoints();
            betLabel.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            condition.Text = "";
            player.Hand.Clear();
            dealer.Hand.Clear();

            if (deck.Cards.Count > 0)
            {
                Card card1 = deck.Cards[0];
                deck.Cards.RemoveAt(0);
                player.Hand.Add(card1);

                LoadImage(player_pb1, $"D:\\Git\\blackjack\\C#과제\\Card\\{card1.Rank.Trim()}{card1.Suit}.png");
                UpdatePoints();

                if (deck.Cards.Count > 0)
                {
                    Card card2 = deck.Cards[0];
                    deck.Cards.RemoveAt(0);
                    player.Hand.Add(card2);

                    LoadImage(player_pb2, $"D:\\Git\\blackjack\\C#과제\\Card\\{card2.Rank.Trim()}{card2.Suit}.png");
                    UpdatePoints();
                }
            }

            if (deck.Cards.Count > 0)
            {
                Card card3 = deck.Cards[0];
                deck.Cards.RemoveAt(0);
                dealer.Hand.Add(card3);

                LoadImage(deal_pb1, $"D:\\Git\\blackjack\\C#과제\\Card\\{card3.Rank.Trim()}{card3.Suit}.png");
                UpdatePoints();

                if (deck.Cards.Count > 0)
                {
                    Card card4 = deck.Cards[0];
                    deck.Cards.RemoveAt(0);
                    dealer.Hand.Add(card4);

                    LoadImage(deal_pb2, $"D:\\Git\\blackjack\\C#과제\\Card\\{card4.Rank.Trim()}{card4.Suit}.png");
                    UpdatePoints();
                }
            }
        }

        private void bet_btn_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(betTextBox.Text);
            int currentMoney = int.Parse(moneyLabel.Text);
            currentMoney -= betAmount;
            moneyLabel.Text = currentMoney.ToString();
            betLabel.Text = betTextBox.Text;
            betTextBox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            condition.Text = "";
            deck = null;
            player = null;
            dealer = null;
            deck = new Deck();
            player = new Player(100);
            dealer = new Dealer();

            player_pb1.Image = null; player_pb1.Visible = false;
            player_pb2.Image = null; player_pb2.Visible = false;
            player_pb3.Image = null; player_pb3.Visible = false;
            deal_pb1.Image = null; deal_pb1.Visible = false;
            deal_pb2.Image = null; deal_pb2.Visible = false;
            deal_pb3.Image = null; deal_pb3.Visible = false;

            UpdatePoints();
        }

        private void UpdatePoints()
        {
            int playerTotal = player.Hand.Sum(card => card.Value);
            int dealerTotal = dealer.Hand.Sum(card => card.Value);
            player_point.Text = playerTotal.ToString();
            deal_point.Text = dealerTotal.ToString();
        }

        private void ComparePoints()
        {
            int playerTotal = player.Hand.Sum(card => card.Value);
            int dealerTotal = dealer.Hand.Sum(card => card.Value);
            int currentMoney = int.Parse(moneyLabel.Text);

            if (playerTotal > 21 && dealerTotal > 21)
                condition.Text = "딜러와 플레이어가 버스트 되었습니다. 무승부";
            else if (playerTotal > 21)
                condition.Text = "플레이어가 버스트되었습니다. 딜러 승리";
            else if (dealerTotal > 21)
            {
                condition.Text = "딜러가 버스트되었습니다. 플레이어 승리";
                int winAmount = int.Parse(betLabel.Text) * 2;
                currentMoney += winAmount;
                moneyLabel.Text = currentMoney.ToString();
            }
            else
            {
                if (playerTotal > dealerTotal)
                {
                    condition.Text = "플레이어가 승리했습니다.";
                    int winAmount = int.Parse(betLabel.Text) * 2;
                    currentMoney += winAmount;
                    moneyLabel.Text = currentMoney.ToString();
                }
                else if (dealerTotal > playerTotal)
                {
                    condition.Text = "딜러가 승리했습니다.";
                }
                else
                {
                    condition.Text = "   동점입니다. 무승부";
                }
            }

            if (currentMoney <= 0)
                MessageBox.Show("플레이어가 점수를 다 잃었습니다.");
        }

        private void re_btn_Click(object sender, EventArgs e)
        {
            moneyLabel.Text = "100";
            betLabel.Text = "";
            betTextBox.Text = "";

            player_pb1.Image = null; player_pb1.Visible = false;
            player_pb2.Image = null; player_pb2.Visible = false;
            player_pb3.Image = null; player_pb3.Visible = false;
            deal_pb1.Image = null; deal_pb1.Visible = false;
            deal_pb2.Image = null; deal_pb2.Visible = false;
            deal_pb3.Image = null; deal_pb3.Visible = false;

            player.Hand.Clear();
            dealer.Hand.Clear();
            player_point.Text = "";
            deal_point.Text = "";
            condition.Text = "";
        }

        private void deal_point_Click(object sender, EventArgs e) { }
    }

    public class Card
    {
        public string Suit { get; set; }
        public string Rank { get; set; }
        public int Value { get; set; }

        public Card(string suit, string rank, int value)
        {
            Suit = suit;
            Rank = rank;
            Value = value;
        }
    }

    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
            string[] suits = { "H", "D", "C", "S" };
            string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

            foreach (var suit in suits)
            {
                for (int i = 0; i < ranks.Length; i++)
                {
                    Card card = new Card(suit, ranks[i], values[i]);
                    Cards.Add(card);
                }
            }
            Shuffle();
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(x => rnd.Next()).ToList();
        }
    }

    public class Player
    {
        public List<Card> Hand { get; set; }
        public Player(int startingMoney) { Hand = new List<Card>(); }
    }

    public class Dealer
    {
        public List<Card> Hand { get; set; }
        public Dealer() { Hand = new List<Card>(); }
        public int CalculateTotal() => Hand.Sum(card => card.Value);
    }
}
