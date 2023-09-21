using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers_accounts
{
     class HiLoGame
    {
        const double defAmount = 1000;
        private double _PlayerAmount = 0;
        private double _BetAmount = 0;
        public int[] CardDeck = new int[53];
        private int _CardIndex = 1;

        public HiLoGame()
        {
            _PlayerAmount = defAmount;
            _BetAmount = 10;

            for (int x = 0; x < 53; x += 1)
            {
                CardDeck[x] = x;
            }
        }




        ~HiLoGame()
        {
            _PlayerAmount = 0;
            _BetAmount = 0;
        }


        public double PlayerAmount
        {
             get { return _PlayerAmount; }
            set { _PlayerAmount = value; }
        }
        public double BetAmount
        { 
            get { return _BetAmount; } 
            set { _BetAmount = value; }
        }
        public int GetCardDeckIndex
        {
            get { return _CardIndex; }
        }


        public double NewGame(bool keepScore)
        {
            if (!keepScore) { _PlayerAmount = 1000; }
            _CardIndex = 1;
            this.ShuffleDeck();
            return _PlayerAmount;
        }

        public double NewGame()
        {
            _PlayerAmount = 1000;
            _CardIndex = 1;
            this.ShuffleDeck();
            return _PlayerAmount;
        }


        private int ShuffleDeck()
        {
            int iRet = 0;
            Random rnd = new Random(DateTime.Now.Millisecond);

            for (int x = 1; x < 53; x += 1)
            {
                CardDeck[x] = x;
            }
            try
            {
                for (int x = 1; x < 53; x += 1)
                {
                    int y = rnd.Next(1, 52);
                    int z = CardDeck[x];
                    CardDeck[x] = CardDeck[y];
                    CardDeck[y] = z;
                }
            }
            catch (Exception) 
            {
                iRet= -1;
            }
            return iRet;
        }

        private int NextCard()
        {
            _CardIndex += 1;
            if (_CardIndex > 52) { _CardIndex = 1; }
            return _CardIndex;
        }
        public byte CheckResult(byte optClicked)
        {
            byte byRet = 0;
            int iSuit = -1; int iCardNo = -1;
            int iPrevSuit = -1; int iPrevCardNo = -1;

            this.NextCard();
            iCardNo = Convert.ToInt16(CardDeck[_CardIndex] % 13);
            iSuit = Convert.ToInt16(CardDeck[_CardIndex] / 4);

            iPrevCardNo = Convert.ToInt16(CardDeck[_CardIndex - 1] % 13);
            iPrevSuit = Convert.ToInt16(CardDeck[_CardIndex - 1] / 4);
            if (iCardNo == iPrevCardNo) { byRet = 0; _PlayerAmount -= _BetAmount; }
            else if ((iCardNo > iPrevCardNo && optClicked== 2) ||
                                                (iCardNo < iPrevCardNo && optClicked == 1))
            { byRet = 2; _PlayerAmount += _BetAmount; }
            else { byRet = 1; _PlayerAmount-= _BetAmount; }
            return byRet;
        }
    }
}
