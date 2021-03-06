﻿namespace Poker.Models.Players
{
    using System.Windows.Forms;
    using Interfaces;

    /// <summary>
    /// Class defining the behavior for the poker bots.
    /// </summary>
    /// <seealso cref="Poker.Models.Players.Player" />
    /// <seealso cref="Poker.Interfaces.IBot" />
    public class Bot : Player, IBot
    {
        public Bot(
            string name,
            int startCard,
            int verticalLocationCoordinate,
            int horizontalLocationCoordinate,
            AnchorStyles verticalLocation = 0,
            AnchorStyles horizontalLocation = 0)
            : base(name)
        {
            this.StartCard = startCard;
            this.VerticalLocationCoordinate = verticalLocationCoordinate;
            this.HorizontalLocationCoordinate = horizontalLocationCoordinate;
            this.HorizontalLocation = horizontalLocation;
            this.VerticalLocation = verticalLocation;
            this.Status = new Label();
            this.TextBoxBotChips = new TextBox();
        }
        
        public int StartCard { get; set; }

        public int VerticalLocationCoordinate { get; set; }

        public int HorizontalLocationCoordinate { get; set; }

        public AnchorStyles VerticalLocation { get; set; }

        public AnchorStyles HorizontalLocation { get; set; }

        public Label Status { get; set; }

        public TextBox TextBoxBotChips { get; set; }

        public AnchorStyles GetAnchorStyles()
        {
            if (this.VerticalLocation == 0)
            {
                return this.HorizontalLocation;
            }
            else if (this.HorizontalLocation == 0)
            {
                return this.VerticalLocation;
            }
            else
            {
                return this.VerticalLocation | this.HorizontalLocation;
            }
        }
    }
}
