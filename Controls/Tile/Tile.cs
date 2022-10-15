// <copyright file = "Tile.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class Tile : TileBase
    {
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="Tile"/> class.
        /// </summary>
        public Tile( )
        {
            BackColor = Color.FromArgb( 15, 15, 15 );
            ForeColor = Color.White;
            Size = new Size( 140, 140 );
            Font = new Font( "Roboto", 9 );
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            Dock = DockStyle.None;
            TileType = HubTileType.DefaultTile;
            Title.Font = new Font( "Roboto", 8, FontStyle.Bold );
            Title.TextColor = Color.White;
            Body.TextColor = Color.LightSteelBlue;
            Body.Font = new Font( "Roboto", 11 );
            SlideTransition = TransitionDirection.RightToLeft;
            ShowBanner = false;
            HoveredBorderColor = Color.SteelBlue;
            HoverBorderLength = 1;
            EnableHoverColor = true;
            EnableSelectionMarker = false;
            Visible = true;
            Enabled = true;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="Tile"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        public Tile( HubTileType type = HubTileType.DefaultTile )
            : this( )
        {
            TileType = type;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="Tile"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        public Tile( string name, HubTileType type = HubTileType.DefaultTile )
            : this( )
        {
            Name = name;
            TileType = type;
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="Tile"/> class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="size">The size.</param>
        /// <param name="type">The type.</param>
        public Tile( Point location, Size size, HubTileType type = HubTileType.DefaultTile )
            : this( )
        {
            Size = size;
            Location = location;
            TileType = type;
        }
    }
}