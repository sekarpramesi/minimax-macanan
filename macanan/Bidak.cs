using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace macanan
{
    class Bidak
    {
        int posX;
        int posY;
        bool isDead;
        string type;

        Point pos;

        int index = -1;
        static int jumlah = 0;
        int[] nextpos;
        int[][] path;
        int point;

        public Bidak(Point pos, int point, string tipeBidak, int[] nextpos, int[][] path)
        {
            this.point = point;

            this.pos = pos;

            isDead = false;
            type = tipeBidak;

            this.nextpos = nextpos;
            this.path = path;

            index = jumlah;
            jumlah++;

        }

        public void setPos(Point pos)
        {
            this.pos = pos;
        }

        public Point getPos()
        {
            return this.pos;
        }

        public void setNextpos(int[] nextpos)
        {
            this.nextpos = nextpos;
        }

        public int[] getNextpos()
        {
            return this.nextpos;
        }

        public void setPath(int[][] path)
        {
            this.path = path;
        }

        public int[][] getPath()
        {
            return this.path;
        }

        public void setPoint(int point)
        {
            this.point = point;
        }

        public int getPoint()
        {
            return this.point;
        }

        public int getPosX()
        {
            return this.posX;
        }

        public void setPosX(int value)
        {
            this.posX = value;
        }
        public int getPosY()
        {
            return this.posY;
        }

        public void setPosY(int value)
        {
            this.posY = value;
        }
        public bool getIsDead()
        {
            return this.isDead;
        }

        public void setIsDead(bool value)
        {
            this.isDead = value;
        }
        public string getType()
        {
            return this.type;
        }

        public void setType(string value)
        {
            this.type = value;
        }

        public int getIndexBidak()
        {
            return this.index;
        }


        public int getJumlahKoneksi(char[] statusPos)
        {
            int jumlah = nextpos.Length;
            for (int i = 0; i < nextpos.Length; i++)
            {
                if (statusPos[nextpos[i]] == 'M' || statusPos[nextpos[i]] == 'O')
                {
                    jumlah--;
                }
            }

            return jumlah;
        }

        public int getJumlahLoncatan(char[] statusPos, int[][] path)
        {
            int jumlah = 0;
            int pos;
            if (this.type == "Macan")
            {
                for (int i = 0; i < path.Length; i++)
                {
                    int jumlahWong = 0;
                    for (int j = 0; j < path[i].Length; j++)
                    {
                        pos = path[i][j];
                        if (statusPos[pos] == 'O')
                        {

                            jumlahWong++;


                        }
                        else if (statusPos[pos] == 'X')
                        {
                            if (jumlahWong % 2 == 1)
                            {

                                jumlah++;
                            }
                            break;
                        }
                    }
                }
            }
            return jumlah;
        }
    }
}
