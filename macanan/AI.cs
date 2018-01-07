using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macanan
{
    class AI
    {
        List<Bidak> bidaks;
        int[][][] path;
        int[][] nextpos;
        public void AI()
        {
        }
        /*
        public int[] giliranAI(String playerAI, Board papan)
        {
            int[] bestMove = null;
            int[] hasil = null;
            this.bidaks = papan.getBidak();
            if (playerAI == "M")
            {
                hasil = minimax(papan, 2, true);
            }
            else
                if (playerAI == "O")
                {
                    hasil = minimax(papan, 2, false);
                }
            bestMove[0] = hasil[0];//kodeBidak
            bestMove[1] = hasil[1];//kodeNextPos
            bestMove[2] = hasil[2];//keterangan Pemenang

            return bestMove;
        }
        */
        public int minimax(Board state, bool max)
        {
            this.bidaks = state.getBidak();
            this.path = state.getPath();
            this.nextpos = state.getNextpos();
            int val = -1;
            int arah = -1;

            if (max)
            {
                val = _max(state, 2, true);
            }
            else
            {
                val = _min(state, 2, false);
            }

            return val;//action that causes val

        }
        public int _max(Board state, int depth, bool max)
        {
            int[] bestMove = null;
            if (depth == 0 || gameOver(state)[0] > -1)
            {
                //akses semua arah, dihitung masing2 evalnya per arah dlm for
                List<List<List<int[]>>> info = arahBoleh(state, max);
                //index sebenarnya
                //*index pertama info di for sesuai jumlah bidak o/m.
                //*kalo m paten index pertamanya = 0;
                //berarti dibawah ini untuk macan
                int tempindex = info[0][0][0][0]; //paten
                List<int[]> arah = info[0][1];

                int[] evalperarah = new int[8];
                List<Bidak> tempbidak = bidaks;


                for (int i = 0; i < arah.Count; i++)
                {

                    //jenis dia diam, gerak atau loncat
                    int jenis = arah[i][0];
                    int pointnya = arah[i][1];
                    int pointlama = tempbidak[tempindex].getPoint();
                    tempbidak[tempindex].setPoint(pointnya);
                    tempbidak[tempindex].setNextpos(nextpos[pointnya]);
                    tempbidak[tempindex].setPath(path[i]);

                    Board nextstate = new Board(path, nextpos);
                    //ngeset per bidak di ubah juga di board
                    nextstate.setBidak(tempbidak);
                    nextstate.setStatusPos(pointlama, 'X');
                    nextstate.setStatusPos(pointnya, 'O');

                    evalperarah[i] = evaluation(nextstate, max);
                }
            }

            //evalperarah[indexarahnya]
            for (int i = 0; i < 8; i++)
            {
                evalperarah[i];
            }
            int v = int.MinValue;
            foreach (int[] gerak in arahBoleh(state, max))
            {
                Board b = state;
                List<Bidak> bids = new List<Bidak>();

                //ambil setiap gerak
                //bikin board baru
                v = Math.Max(v, _min(state, depth, max));
            }
            return v;
        }

        public int _min(Board state, int depth, bool max)
        {
            int[] bestMove = null;
            if (depth == 0 || gameOver(state)[0] > -1)
            {
                //akses semua arah, dihitung masing2 evalnya per arah dlm for
                List<List<List<int[]>>> info = arahBoleh(state, max);
                //index sebenarnya
                //*index pertama info di for sesuai jumlah bidak o/m.
                //*kalo m paten index pertamanya = 0;
                //berarti dibawah ini untuk macan
                int tempindex = info[0][0][0][0]; //paten
                List<int[]> arah = info[0][1];

                int[] evalperarah = new int[8];
                List<Bidak> tempbidak = bidaks;


                for (int i = 0; i < arah.Count; i++)
                {

                    //jenis dia diam, gerak atau loncat
                    int jenis = arah[i][0];
                    int pointnya = arah[i][1];
                    int pointlama = tempbidak[tempindex].getPoint();
                    tempbidak[tempindex].setPoint(pointnya);
                    tempbidak[tempindex].setNextpos(nextpos[pointnya]);
                    tempbidak[tempindex].setPath(path[i]);

                    Board nextstate = new Board(path, nextpos);
                    //ngeset per bidak di ubah juga di board
                    nextstate.setBidak(tempbidak);
                    nextstate.setStatusPos(pointlama, 'X');
                    nextstate.setStatusPos(pointnya, 'O');

                    evalperarah[i] = evaluation(nextstate, max);
                }
                //return evaluation(state, max);
            }
            int v = int.MaxValue;

            foreach (int[] gerak in arahBoleh(state, max))
            {
                v = Math.Min(v, _max(state, depth, max));
            }
            return v;
        }
        public int evaluation(Board state, bool player)
        {

            int koneksi = 0;
            int loncatan = 0;
            int nilaiA = 0;
            int nilaiB = 0;
            if (player)
            {
                koneksi = state.getTotalKoneksi("M");
                loncatan = state.getTotalLoncatan("M");
                nilaiA = 5 * (koneksi + loncatan * 8);
            }
            else
            {
                koneksi = state.getTotalKoneksi("O");
                loncatan = state.getTotalLoncatan("O");
                nilaiB = 1 * (koneksi + loncatan * 0);
            }

            return nilaiA - nilaiB;
        }

        public int[] gameOver(Board state)
        {
            //0 macan 1 wong
            int[] pemenangAr = { -1, -1 };
            int pemenang;
            if (state.getTotalKoneksi("M") <= 0 && state.getTotalLoncatan("M") <= 0)
            {
                pemenang = 1;
                pemenangAr[0] = 1;
                pemenangAr[1] = pemenang;
            }
            else if (state.getJumlahWong() <= 17)
            {
                pemenang = 1;
                pemenangAr[0] = 0;
                pemenangAr[1] = pemenang;
            }



            return pemenangAr;
        }

        public List<List<List<int[]>>> arahBoleh(Board state, bool player)
        {
            char[] statpos = state.getStatusPos();
            //int[][] informasi = null;//index bidak,isi path
            List<List<List<int[]>>> info = new List<List<List<int[]>>>();
            List<Bidak> b = state.getBidak();
            List<int[]> arah = new List<int[]>();
            if (player)
            {
                int index = 0;
                foreach (Bidak bidaks in b)
                {
                    List<List<int[]>> infotiapbidak = new List<List<int[]>>();


                    int[] index2 = { index };
                    List<int[]> tempindex = new List<int[]>();
                    List<List<int[]>> tempindex2 = new List<List<int[]>>();
                    tempindex.Add(index2);
                    tempindex2.Add(tempindex);

                    info.Add(tempindex2);

                    if (bidaks.getType() == "M")
                    {
                        int[][] paths = bidaks.getPath();

                        for (int i = 0; i < paths.Length; i++)
                        {
                            arah.Add(checkArah(bidaks.getPoint(), paths[i], statpos));
                            infotiapbidak.Add(arah);
                        }


                    }

                    infotiapbidak.Add(tempindex);



                    info.Add(infotiapbidak);

                    index++;
                }

            }
            else
            {
            }
            return info;
        }

        public int[] checkArah(int point, int[] check, char[] statpos)
        {
            int jml = 0;
            int tempPos = -1;
            int[] val = { -1, -1 };//jenis,tempat--jenis 0=diam,1=gerak,2=loncat
            List<int> loncatKe = new List<int>();
            for (int i = 0; i < check.Length; i++)
            {
                int tempat = check[i];
                if (statpos[tempat] == 'O')
                {
                    jml++;
                }
                else if (statpos[tempat] == 'X')
                {
                    tempPos = tempat;
                    break;
                }
            }
            if (jml == 0)
            {
                val[0] = 1;
                val[1] = tempPos;
            }
            else if (jml > 0)
            {
                if (jml % 2 == 0)
                {
                    val[0] = 0;
                    val[1] = tempPos;
                }
                else if (jml % 2 == 1)
                {
                    val[0] = 2;
                    val[1] = tempPos;
                }
            }

            return val;
        }
    }
}
