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
        Deck deck; // 카드 덱
        Player player; // 플레이어
        Dealer dealer; // 딜러

        public Form1()
        {
            InitializeComponent();
            deck = new Deck(); // 카드 덱 생성
            player = new Player(100); // 플레이어 생성, 시작 금액은 100
            dealer = new Dealer(); // 딜러 생성

            moneyLabel.Text = "100"; // moneyLabel에 100 할당
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imagePath = @"C:\Users\user\Desktop\황석규신기륜\hwang_shin_make.png";
            deck_pb.SizeMode = PictureBoxSizeMode.Zoom;
            deck_pb.Image = Image.FromFile(imagePath);

            string backgroundImagePath = @"C:\Users\user\Desktop\황석규신기륜\made.jpg";
            this.BackgroundImage = Image.FromFile(backgroundImagePath);
            this.BackgroundImageLayout = ImageLayout.Stretch; // 배경 이미지가 폼에 맞게 늘어나도록 설정

        }

        private void LoadImage(PictureBox pictureBox, string path)
        {
            Image oldImage = pictureBox.Image;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = Image.FromFile(path);
            oldImage?.Dispose();
        }

        private void hit_btn_Click(object sender, EventArgs e) // HIT
        {
            if (deck.Cards.Count > 0)
            {
                Card card = deck.Cards[0];
                deck.Cards.RemoveAt(0);
                player.Hand.Add(card);

                LoadImage(player_pb3, $"C:\\Users\\user\\Desktop\\카드\\{card.Suit.Trim()}{card.Rank}.jpg");

                UpdatePoints();
            }
            if (dealer.CalculateTotal() <= 16 && dealer.Hand.Count < 3)
            {
                if (deck.Cards.Count > 0)
                {
                    Card card = deck.Cards[0];
                    deck.Cards.RemoveAt(0);
                    dealer.Hand.Add(card);

                    LoadImage(deal_pb3, $"C:\\Users\\user\\Desktop\\카드\\{card.Suit.Trim()}{card.Rank}.jpg");

                    UpdatePoints();
                }
            }
            ComparePoints();

            betLabel.Text = ""; // betLabel을 빈 값으로 설정
        }

        private void stay_btn_Click(object sender, EventArgs e) // STAY
        {
            if (dealer.CalculateTotal() <= 16 && dealer.Hand.Count < 3)
            {
                if (deck.Cards.Count > 0)
                {
                    Card card = deck.Cards[0];
                    deck.Cards.RemoveAt(0);
                    dealer.Hand.Add(card);

                    LoadImage(deal_pb3, $"C:\\Users\\user\\Desktop\\카드\\{card.Suit.Trim()}{card.Rank}.jpg");

                    UpdatePoints();
                }
            }
            ComparePoints();

            betLabel.Text = ""; // betLabel을 빈 값으로 설정
        }

        private void button3_Click(object sender, EventArgs e) // DRAW
        {
            condition.Text = "";
            player.Hand.Clear(); // 플레이어의 Hand 초기화
            dealer.Hand.Clear(); // 딜러의 Hand 초기화

            if (deck.Cards.Count > 0)
            {
                Card card1 = deck.Cards[0];
                deck.Cards.RemoveAt(0);
                player.Hand.Add(card1);

                LoadImage(player_pb1, $"C:\\Users\\user\\Desktop\\카드\\{card1.Suit.Trim()}{card1.Rank}.jpg");

                UpdatePoints();

                if (deck.Cards.Count > 0)
                {
                    Card card2 = deck.Cards[0];
                    deck.Cards.RemoveAt(0);
                    player.Hand.Add(card2);

                    LoadImage(player_pb2, $"C:\\Users\\user\\Desktop\\카드\\{card2.Suit.Trim()}{card2.Rank}.jpg");

                    UpdatePoints();
                }
            }

            if (deck.Cards.Count > 0)
            {
                Card card3 = deck.Cards[0];
                deck.Cards.RemoveAt(0);
                dealer.Hand.Add(card3);

                LoadImage(deal_pb1, $"C:\\Users\\user\\Desktop\\카드\\{card3.Suit.Trim()}{card3.Rank}.jpg");

                UpdatePoints();

                if (deck.Cards.Count > 0)
                {
                    Card card4 = deck.Cards[0];
                    deck.Cards.RemoveAt(0);
                    dealer.Hand.Add(card4);

                    LoadImage(deal_pb2, $"C:\\Users\\user\\Desktop\\카드\\{card4.Suit.Trim()}{card4.Rank}.jpg");

                    UpdatePoints();
                }
            }
        }

        private void bet_btn_Click(object sender, EventArgs e)
        {
            int betAmount = int.Parse(betTextBox.Text); // betTextBox의 값을 정수로 변환
            int currentMoney = int.Parse(moneyLabel.Text); // moneyLabel의 값을 정수로 변환

            currentMoney -= betAmount; // 배팅금액을 현재 돈에서 빼기

            moneyLabel.Text = currentMoney.ToString(); // 빼준 값을 다시 moneyLabel에 할당
            betLabel.Text = betTextBox.Text; // betTextBox의 값을 betLabel에 할당

            betTextBox.Text = ""; // betTextBox를 빈 값으로 설정
        }

        private void button1_Click(object sender, EventArgs e) // PLAY
        {
            condition.Text = "";
            deck = null;
            player = null;
            dealer = null;
            deck = new Deck();
            player = new Player(100);
            dealer = new Dealer();
            player_pb1.Image = null;
            player_pb2.Image = null;
            player_pb3.Image = null;
            deal_pb1.Image = null;
            deal_pb2.Image = null;
            deal_pb3.Image = null;
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
            {
                condition.Text = "딜러와 플레이어가 버스트 되었습니다. 무승부";
            }
            else if (playerTotal > 21)
            {
                condition.Text = "플레이어가 버스트되었습니다. 딜러 승리";
            }
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

            // 플레이어의 점수가 0 이하가 될 때 메시지 박스 표시
            if (currentMoney <= 0)
            {
                MessageBox.Show("플레이어가 점수를 다 잃었습니다.");
            }
        }

        private void re_btn_Click(object sender, EventArgs e)
        {
            moneyLabel.Text = "100"; // moneyLabel을 100으로 설정
            betLabel.Text = ""; // betLabel을 빈 값으로 설정
            betTextBox.Text = ""; // betTextBox를 빈 값으로 설정

            // 모든 PictureBox를 빈 값으로 설정
            player_pb1.Image = null;
            player_pb2.Image = null;
            player_pb3.Image = null;
            deal_pb1.Image = null;
            deal_pb2.Image = null;
            deal_pb3.Image = null;

            // 딜러와 플레이어의 점수를 초기화
            player.Hand.Clear();
            dealer.Hand.Clear();
            player_point.Text = "";
            deal_point.Text = "";

            // condition을 빈 값으로 설정
            condition.Text = "";
        }

        private void deal_point_Click(object sender, EventArgs e)
        {

        }
    }
}

namespace C_과제
{
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

            string[] suits = { "하트", "다이아몬드", "클로버", "스페이드" };
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

        public Player(int startingMoney)
        {
            Hand = new List<Card>();
        }
    }

    public class Dealer
    {
        public List<Card> Hand { get; set; }

        public Dealer()
        {
            Hand = new List<Card>();
        }

        public int CalculateTotal()
        {
            int total = 0;
            foreach (Card card in Hand)
            {
                total += card.Value;
            }
            return total;
        }
    }
}