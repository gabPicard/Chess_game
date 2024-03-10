using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace Test_echecs
{
    public partial class Form1 : Form
    {
        private List<Image> square_images = new List<Image>();
        Board board = new Board("empty");


        public Form1()
        {
            InitializeComponent();
            LoadSquareImages();
            this.Paint += Board_Creation;
            this.Click += VotreFormulaire_Click;

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(333, 300);
            this.Name = "Plateau";
            this.ResumeLayout(false);

        }

        private void LoadSquareImages()
        {
            square_images.Add(Image.FromFile("Case_noire.png"));
            square_images.Add(Image.FromFile("Case_blanche.png"));
            square_images.Add(Image.FromFile("Case_noire_selec.png"));
            square_images.Add(Image.FromFile("Case_blanche_selec.png"));
        }

        private void Board_Creation(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int counter = 0;
            int positionX = 100;
            int positionY = 100;
            int square_size = 100;
            Image square = null;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board.Chess_board[i, j] == "black_empty")
                    {
                        square = square_images[0];
                    }
                    else if (board.Chess_board[i, j] == "white_empty")
                    {
                        square = square_images[1];
                    }
                    else if (board.Chess_board[i, j] == "black_selec")
                    {
                        square = square_images[2];
                    }
                    else if (board.Chess_board[i, j] == "white_selec")
                    {
                        square = square_images[3];
                    }
                    g.DrawImage(square, new Rectangle(positionX, positionY, square_size, square_size));
                    counter++;
                    positionX += square_size;

                }
                counter++;
                positionX = 100;
                positionY += square_size;
            }
        }

        private void VotreFormulaire_Click(object sender, EventArgs e)
        {
            // Obtenir les coordonnées du clic
            MouseEventArgs mouseEvent = (MouseEventArgs)e;
            int x = mouseEvent.X;
            int y = mouseEvent.Y;
            Selected_Square(x, y);

        }

        private void Selected_Square(int x, int y)
        {
            if (x > 99 && x < 801 && y > 99 && y < 801)
            {
                x = (x / 100) - 1;
                y = (y / 100) - 1;
                board.Board_Update_Square(y, x);
                Invalidate();
            }
        }

    }
}