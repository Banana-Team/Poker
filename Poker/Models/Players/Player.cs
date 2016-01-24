﻿namespace Poker.Models.Players
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Interfaces;

    public abstract class Player : IPlayer
    {
        private const int DefaultStartChips = 10000;
        private const int DefaultPlayerPanelHeight = 150;
        private const int DefaultPlayerPanelWidth = 180;

        private int chips;

        protected Player()
        {
            //TODO: Is name needed
            this.Name = "";
            this.Chips = DefaultStartChips;
            this.Panel = new Panel();
            this.Type = -1;
            this.Power = 0;
            this.Call = 0;
            this.Raise = 0;
            this.CanMakeTurn = false;
            this.OutOfChips = false;
            this.Folded = false;

            //Initialize player with two cards, the default number of cards for texas poker
            //Expandable for poker with 5 cards
            this.Cards = new List<ICard>
            {
                new Card(),
                new Card()
            };
        }

        public string Name { get; set; }

        public double Power { get; set; }

        public int Chips
        {
            get
            {
                return this.chips;
            }

            set
            {
                if (value < 0)
                {
                    // TODO: throw or set to 0
                }

                this.chips = value;
            }
        }

        public int Call { get; set; }

        public int Raise { get; set; }

        public bool CanMakeTurn { get; set; }

        public bool OutOfChips { get; set; }

        public bool Folded { get; set; }

        public void InitializePanel(Point location)
        {
            this.Panel.Location = location;
            this.Panel.BackColor = Color.Transparent;
            this.Panel.Height = DefaultPlayerPanelHeight;
            this.Panel.Width = DefaultPlayerPanelWidth;
            this.Panel.Visible = false;
        }

        public IList<ICard> Cards { get; private set; }

        public Panel Panel { get; }

        public double Type { get; set; }
    }
}
