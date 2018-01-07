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
    class Board
    {
        char[] statusPos = new char[38];
        int[][][] path;
        int[][] nextpos;

        int jumlahWong = 0;
        int jumlahMacan = 0;

        int jumlahKoneksiWong = 0;
        int jumlahLoncatanWong = 0;

        int jumlahKoneksiMacan = 0;
        int jumlahLoncatanMacan = 0;

        List<Bidak> bidak = new List<Bidak>();

        public Board(int[][][] path, int[][] nextpos)
        {
            this.nextpos = nextpos;
            for (int i = 0; i < 38; i++)
            {
                statusPos[i] = 'X';
            }

            this.path = path;
        }

        public int[][][] getPath()
        {
            return this.path;
        }

        public int[][] getNextpos()
        {
            return this.nextpos;
        }

        public void setJumlahWong(int jumlah)
        {
            this.jumlahWong = jumlah;
        }

        public int getJumlahWong()
        {
            return this.jumlahWong;
        }

        public void setJumlahMacan(int jumlah)
        {
            this.jumlahMacan = jumlah;
        }

        public int getJumlahMacan()
        {
            return this.jumlahMacan;
        }

        public void setBidak(List<Bidak> bidak)
        {
            this.bidak = bidak;
        }

        public List<Bidak> getBidak()
        {
            return this.bidak;
        }

        public void setStatusPos(int index, char type)
        {
            statusPos[index] = type;
            if (type == 'M')
            {
                jumlahMacan++;
            }
            else if (type == 'O')
            {
                jumlahWong++;
            }
        }

        public char[] getStatusPos()
        {
            return this.statusPos;
        }

        public int getTotalKoneksi(string type)
        {
            int total = 0;
            for (int i = 0; i < bidak.Count; i++)
            {
                if (bidak[i].getType() == type)
                {
                    int temp = bidak[i].getJumlahKoneksi(this.statusPos);
                    total += temp;
                }
            }

            return total;
        }

        public int getTotalLoncatan(string type)
        {
            int total = 0;
            for (int i = 0; i < bidak.Count; i++)
            {
                if (bidak[i].getType() == type)
                {
                    int index = bidak[i].getPoint();
                    int temp = bidak[i].getJumlahLoncatan(this.statusPos, this.path[index]);
                    total += temp;
                }
            }

            return total;
        }

    }
}
