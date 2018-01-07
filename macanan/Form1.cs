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
    public partial class Form1 : Form
    {
        static Point p0 = new Point(0, 0);

        static Point p1 = new Point(160, 30);
        static Point p2 = new Point(310, 30);
        static Point p3 = new Point(460, 30);

        static Point p4 = new Point(235, 110);
        static Point p5 = new Point(310, 110);
        static Point p6 = new Point(385, 110);

        static Point p7 = new Point(110, 210);
        static Point p8 = new Point(210, 210);
        static Point p9 = new Point(310, 210);
        static Point p10 = new Point(410, 210);
        static Point p11 = new Point(510, 210);

        static Point p12 = new Point(110, 310);
        static Point p13 = new Point(210, 310);
        static Point p14 = new Point(310, 310);
        static Point p15 = new Point(410, 310);
        static Point p16 = new Point(510, 310);

        static Point p17 = new Point(110, 410);
        static Point p18 = new Point(210, 410);
        static Point p19 = new Point(310, 410);
        static Point p20 = new Point(410, 410);
        static Point p21 = new Point(510, 410);

        static Point p22 = new Point(110, 510);
        static Point p23 = new Point(210, 510);
        static Point p24 = new Point(310, 510);
        static Point p25 = new Point(410, 510);
        static Point p26 = new Point(510, 510);

        static Point p27 = new Point(110, 610);
        static Point p28 = new Point(210, 610);
        static Point p29 = new Point(310, 610);
        static Point p30 = new Point(410, 610);
        static Point p31 = new Point(510, 610);

        static Point p32 = new Point(235, 710);
        static Point p33 = new Point(310, 710);
        static Point p34 = new Point(385, 710);

        static Point p35 = new Point(160, 810);
        static Point p36 = new Point(310, 810);
        static Point p37 = new Point(460, 810);

        static int[] np0 = { 0, 0};

        static int[] np1 = { 2, 4 };
        static int[] np2 = { 1, 5, 3 };
        static int[] np3 = { 2, 6 };
        static int[] np4 = { 1, 5, 9 };
        static int[] np5 = { 2, 4, 6, 9 };
        static int[] np6 = { 3, 5, 9 };
        static int[] np7 = { 8, 12, 13 };
        static int[] np8 = { 7, 9, 13 };
        static int[] np9 = { 4, 5, 6, 8, 10, 13, 14, 15 };
        static int[] np10 = { 9, 11, 15 };
        static int[] np11 = { 10, 15, 16 };
        static int[] np12 = { 7, 13, 17 };
        static int[] np13 = { 7, 8, 9, 12, 14, 17, 18, 19 };
        static int[] np14 = { 9, 13, 15, 19 };
        static int[] np15 = { 9, 10, 11, 14, 16, 19, 20, 21 };
        static int[] np16 = { 11, 15, 21 };
        static int[] np17 = { 12, 13, 18, 22, 23 };
        static int[] np18 = { 13, 17, 19, 23 };
        static int[] np19 = { 13, 14, 15, 18, 20, 23, 24, 25 };
        static int[] np20 = { 15, 19, 21, 25 };
        static int[] np21 = { 15, 16, 20, 25, 26 };
        static int[] np22 = { 17, 23, 27 };
        static int[] np23 = { 17, 18, 19, 22, 24, 27, 28, 29 };
        static int[] np24 = { 19, 23, 25, 29 };
        static int[] np25 = { 19, 20, 21, 24, 26, 29, 30, 31 };
        static int[] np26 = { 21, 25, 31 };
        static int[] np27 = { 22, 23, 28 };
        static int[] np28 = { 23, 27, 29 };
        static int[] np29 = { 23, 24, 25, 28, 30, 32, 33, 34 };
        static int[] np30 = { 25, 29, 31 };
        static int[] np31 = { 25, 26, 30 };
        static int[] np32 = { 29, 33, 35 };
        static int[] np33 = { 29, 32, 34, 36 };
        static int[] np34 = { 29, 33, 37 };
        static int[] np35 = { 32, 36 };
        static int[] np36 = { 33, 35, 37 };
        static int[] np37 = { 34, 36 };

        static int[] path00 = { 0 };
        static int[][] path0 = { path00 };

        static int[] path1A = { 0 };
        static int[] path1B = { 0 };
        static int[] path1C = { 2, 4 };
        static int[] path1D = { 4, 9, 15, 21 };
        static int[] path1E = { 0 };
        static int[] path1F = { 0 };
        static int[] path1G = { 0 };
        static int[] path1H = { 0 };
        static int[][] path1 = { path1A, path1B, path1C, path1D, path1E, path1F, path1G, path1H };

        static int[] path2A = { 0 };
        static int[] path2B = { 0 };
        static int[] path2C = { 3 };
        static int[] path2D = { 0 };
        static int[] path2E = { 5, 9, 14, 19, 24, 29, 33, 36 };
        static int[] path2F = { 0 };
        static int[] path2G = { 1 };
        static int[] path2H = { 0 };
        static int[][] path2 = { path2A, path2B, path2C, path2D, path2E, path2F, path2G, path2H };

        static int[] path3A = { 0 };
        static int[] path3B = { 0 };
        static int[] path3C = { 3 };
        static int[] path3D = { 0 };
        static int[] path3E = { 0 };
        static int[] path3F = { 6, 9, 13, 17 };
        static int[] path3G = { 2, 1 };
        static int[] path3H = { 0 };
        static int[][] path3 = { path3A, path3B, path3C, path3D, path3E, path3F, path3G, path3H };

        static int[] path4A = { 0 };
        static int[] path4B = { 0 };
        static int[] path4C = { 5, 6 };
        static int[] path4D = { 9, 15, 21 };
        static int[] path4E = { 0 };
        static int[] path4F = { 0 };
        static int[] path4G = { 0 };
        static int[] path4H = { 1 };
        static int[][] path4 = { path4A, path4B, path4C, path4D, path4E, path4F, path4G, path4H };

        static int[] path5A = { 2 };
        static int[] path5B = { 0 };
        static int[] path5C = { 6 };
        static int[] path5D = { 0 };
        static int[] path5E = { 9, 14, 19, 24, 29, 33, 36 };
        static int[] path5F = { 0 };
        static int[] path5G = { 4 };
        static int[] path5H = { 0 };
        static int[][] path5 = { path5A, path5B, path5C, path5D, path5E, path5F, path5G, path5H };

        static int[] path6A = { 0 };
        static int[] path6B = { 0 };
        static int[] path6C = { 3 };
        static int[] path6D = { 0 };
        static int[] path6E = { 0 };
        static int[] path6F = { 9, 13, 17 };
        static int[] path6G = { 5, 4 };
        static int[] path6H = { 0 };
        static int[][] path6 = { path6A, path6B, path6C, path6D, path6E, path6F, path6G, path6H };

        static int[] path7A = { 0 };
        static int[] path7B = { 0 };
        static int[] path7C = { 8, 9, 10, 11 };
        static int[] path7D = { 13, 19, 25, 31 };
        static int[] path7E = { 12, 17, 22, 27 };
        static int[] path7F = { 0 };
        static int[] path7G = { 0 };
        static int[] path7H = { 0 };
        static int[][] path7 = { path7A, path7B, path7C, path7D, path7E, path7F, path7G, path7H };

        static int[] path8A = { 0 };
        static int[] path8B = { 0 };
        static int[] path8C = { 9, 10, 11 };
        static int[] path8D = { 0 };
        static int[] path8E = { 13, 18, 23, 28 };
        static int[] path8F = { 0 };
        static int[] path8G = { 7 };
        static int[] path8H = { 0 };
        static int[][] path8 = { path8A, path8B, path8C, path8D, path8E, path8F, path8G, path8H };

        static int[] path9A = { 5, 2 };
        static int[] path9B = { 6, 3 };
        static int[] path9C = { 10, 11 };
        static int[] path9D = { 15, 21 };
        static int[] path9E = { 14, 19, 24, 29, 33, 36 };
        static int[] path9F = { 13, 17 };
        static int[] path9G = { 8, 7 };
        static int[] path9H = { 4, 1 };
        static int[][] path9 = { path9A, path9B, path9C, path9D, path9E, path9F, path9G, path9H };

        static int[] path10A = { 0 };
        static int[] path10B = { 0 };
        static int[] path10C = { 11 };
        static int[] path10D = { 0 };
        static int[] path10E = { 15, 20, 25, 30 };
        static int[] path10F = { 0 };
        static int[] path10G = { 9, 8, 7 };
        static int[] path10H = { 0 };
        static int[][] path10 = { path10A, path10B, path10C, path10D, path10E, path10F, path10G, path10H };

        static int[] path11A = { 0 };
        static int[] path11B = { 0 };
        static int[] path11C = { 0 };
        static int[] path11D = { 0 };
        static int[] path11E = { 16, 21, 26, 31 };
        static int[] path11F = { 15, 19, 23, 27 };
        static int[] path11G = { 10, 9, 8, 7 };
        static int[] path11H = { 0 };
        static int[][] path11 = { path11A, path11B, path11C, path11D, path11E, path11F, path11G, path11H };

        static int[] path12A = { 7 };
        static int[] path12B = { 0 };
        static int[] path12C = { 13, 14, 15, 16 };
        static int[] path12D = { 0 };
        static int[] path12E = { 17, 22, 27 };
        static int[] path12F = { 0 };
        static int[] path12G = { 0 };
        static int[] path12H = { 0 };
        static int[][] path12 = { path12A, path12B, path12C, path12D, path12E, path12F, path12G, path12H };

        static int[] path13A = { 8 };
        static int[] path13B = { 9, 6, 3 };
        static int[] path13C = { 14, 15, 16 };
        static int[] path13D = { 19, 25, 31 };
        static int[] path13E = { 18, 23, 28 };
        static int[] path13F = { 17 };
        static int[] path13G = { 12 };
        static int[] path13H = { 7 };
        static int[][] path13 = { path13A, path13B, path13C, path13D, path13E, path13F, path13G, path13H };

        static int[] path14A = { 9, 5, 2 };
        static int[] path14B = { 0 };
        static int[] path14C = { 15, 16 };
        static int[] path14D = { 0 };
        static int[] path14E = { 19, 24, 29, 33, 36 };
        static int[] path14F = { 0 };
        static int[] path14G = { 13, 12 };
        static int[] path14H = { 0 };
        static int[][] path14 = { path14A, path14B, path14C, path14D, path14E, path14F, path14G, path14H };

        static int[] path15A = { 10 };
        static int[] path15B = { 11 };
        static int[] path15C = { 16 };
        static int[] path15D = { 21 };
        static int[] path15E = { 20, 25, 30 };
        static int[] path15F = { 19, 23, 27 };
        static int[] path15G = { 14, 13, 12 };
        static int[] path15H = { 9, 4, 1 };
        static int[][] path15 = { path15A, path15B, path15C, path15D, path15E, path15F, path15G, path15H };

        static int[] path16A = { 11 };
        static int[] path16B = { 0 };
        static int[] path16C = { 0 };
        static int[] path16D = { 0 };
        static int[] path16E = { 16, 21, 26, 31 };
        static int[] path16F = { 0 };
        static int[] path16G = { 15, 14, 13, 12 };
        static int[] path16H = { 0 };
        static int[][] path16 = { path16A, path16B, path16C, path16D, path16E, path16F, path16G, path16H };

        static int[] path17A = { 12, 7 };
        static int[] path17B = { 13, 9, 6, 3 };
        static int[] path17C = { 18, 19, 20, 21 };
        static int[] path17D = { 23, 29, 34, 37 };
        static int[] path17E = { 22, 27 };
        static int[] path17F = { 0 };
        static int[] path17G = { 0 };
        static int[] path17H = { 0 };
        static int[][] path17 = { path17A, path17B, path17C, path17D, path17E, path17F, path17G, path17H };

        static int[] path18A = { 13, 8 };
        static int[] path18B = { 0 };
        static int[] path18C = { 19, 20, 21 };
        static int[] path18D = { 0 };
        static int[] path18E = { 23, 28 };
        static int[] path18F = { 0 };
        static int[] path18G = { 17 };
        static int[] path18H = { 0 };
        static int[][] path18 = { path18A, path18B, path18C, path18D, path18E, path18F, path18G, path18H };

        static int[] path19A = { 14, 9, 5, 2 };
        static int[] path19B = { 15, 11 };
        static int[] path19C = { 20, 21 };
        static int[] path19D = { 25, 31 };
        static int[] path19E = { 24, 29, 33, 36 };
        static int[] path19F = { 23, 27 };
        static int[] path19G = { 18, 17 };
        static int[] path19H = { 13, 7 };
        static int[][] path19 = { path19A, path19B, path19C, path19D, path19E, path19F, path19G, path19H };

        static int[] path20A = { 15, 10 };
        static int[] path20B = { 0 };
        static int[] path20C = { 21 };
        static int[] path20D = { 0 };
        static int[] path20E = { 25, 30 };
        static int[] path20F = { 0 };
        static int[] path20G = { 19, 18, 17 };
        static int[] path20H = { 0 };
        static int[][] path20 = { path20A, path20B, path20C, path20D, path20E, path20F, path20G, path20H };

        static int[] path21A = { 16, 11 };
        static int[] path21B = { 0 };
        static int[] path21C = { 0 };
        static int[] path21D = { 0 };
        static int[] path21E = { 26, 31 };
        static int[] path21F = { 25, 29, 32, 35 };
        static int[] path21G = { 20, 19, 18, 17 };
        static int[] path21H = { 15, 9, 4, 1 };
        static int[][] path21 = { path21A, path21B, path21C, path21D, path21E, path21F, path21G, path21H };

        static int[] path22A = { 17, 12, 7 };
        static int[] path22B = { 0 };
        static int[] path22C = { 23, 24, 25, 26 };
        static int[] path22D = { 0 };
        static int[] path22E = { 27 };
        static int[] path22F = { 0 };
        static int[] path22G = { 0 };
        static int[] path22H = { 0 };
        static int[][] path22 = { path22A, path22B, path22C, path22D, path22E, path22F, path22G, path22H };

        static int[] path23A = { 18, 13, 8 };
        static int[] path23B = { 19, 15, 11 };
        static int[] path23C = { 24, 25, 26 };
        static int[] path23D = { 29, 34, 37 };
        static int[] path23E = { 28 };
        static int[] path23F = { 27 };
        static int[] path23G = { 22 };
        static int[] path23H = { 17 };
        static int[][] path23 = { path23A, path23B, path23C, path23D, path23E, path23F, path23G, path23H };

        static int[] path24A = { 19, 14, 9, 5, 2 };
        static int[] path24B = { 0 };
        static int[] path24C = { 25, 26 };
        static int[] path24D = { 0 };
        static int[] path24E = { 29, 33, 36 };
        static int[] path24F = { 0 };
        static int[] path24G = { 23, 22 };
        static int[] path24H = { 0 };
        static int[][] path24 = { path24A, path24B, path24C, path24D, path24E, path24F, path24G, path24H };

        static int[] path25A = { 20, 15, 10 };
        static int[] path25B = { 21 };
        static int[] path25C = { 26 };
        static int[] path25D = { 31 };
        static int[] path25E = { 30 };
        static int[] path25F = { 29, 32, 35 };
        static int[] path25G = { 24, 23, 22 };
        static int[] path25H = { 19, 13, 7 };
        static int[][] path25 = { path25A, path25B, path25C, path25D, path25E, path25F, path25G, path25H };

        static int[] path26A = { 21, 16, 11 };
        static int[] path26B = { 0 };
        static int[] path26C = { 0 };
        static int[] path26D = { 0 };
        static int[] path26E = { 31 };
        static int[] path26F = { 0 };
        static int[] path26G = { 25, 24, 23, 22 };
        static int[] path26H = { 0 };
        static int[][] path26 = { path26A, path26B, path26C, path26D, path26E, path26F, path26G, path26H };

        static int[] path27A = { 22, 17, 12, 7 };
        static int[] path27B = { 23, 19, 15, 11 };
        static int[] path27C = { 28, 29, 30, 31 };
        static int[] path27D = { 0 };
        static int[] path27E = { 0 };
        static int[] path27F = { 0 };
        static int[] path27G = { 0 };
        static int[] path27H = { 0 };
        static int[][] path27 = { path27A, path27B, path27C, path27D, path27E, path27F, path27G, path27H };

        static int[] path28A = { 23, 18, 13, 8 };
        static int[] path28B = { 0 };
        static int[] path28C = { 29, 30, 31 };
        static int[] path28D = { 0 };
        static int[] path28E = { 0 };
        static int[] path28F = { 0 };
        static int[] path28G = { 27 };
        static int[] path28H = { 0 };
        static int[][] path28 = { path28A, path28B, path28C, path28D, path28E, path28F, path28G, path28H };

        static int[] path29A = { 24, 19, 14, 9, 5, 2 };
        static int[] path29B = { 25, 21 };
        static int[] path29C = { 30, 31 };
        static int[] path29D = { 34, 37 };
        static int[] path29E = { 33, 36 };
        static int[] path29F = { 32, 35 };
        static int[] path29G = { 28, 27};
        static int[] path29H = { 23, 17 };
        static int[][] path29 = { path29A, path29B, path29C, path29D, path29E, path29F, path29G, path29H };

        static int[] path30A = { 25, 20, 25, 10 };
        static int[] path30B = { 0 };
        static int[] path30C = { 31 };
        static int[] path30D = { 0 };
        static int[] path30E = { 0 };
        static int[] path30F = { 0 };
        static int[] path30G = { 29, 28, 27 };
        static int[] path30H = { 0 };
        static int[][] path30 = { path30A, path30B, path30C, path30D, path30E, path30F, path30G, path30H };

        static int[] path31A = { 26, 21, 16, 11 };
        static int[] path31B = { 0 };
        static int[] path31C = { 0 };
        static int[] path31D = { 0 };
        static int[] path31E = { 0 };
        static int[] path31F = { 0 };
        static int[] path31G = { 30, 29, 28, 27 };
        static int[] path31H = { 25, 19, 13, 7 };
        static int[][] path31 = { path31A, path31B, path31C, path31D, path31E, path31F, path31G, path31H };

        static int[] path32A = { 0 };
        static int[] path32B = { 29, 25, 21 };
        static int[] path32C = { 33, 34 };
        static int[] path32D = { 0 };
        static int[] path32E = { 0 };
        static int[] path32F = { 35 };
        static int[] path32G = { 0 };
        static int[] path32H = { 0 };
        static int[][] path32 = { path32A, path32B, path32C, path32D, path32E, path32F, path32G, path32H };

        static int[] path33A = { 29, 24, 19, 14, 9, 5, 2 };
        static int[] path33B = { 0 };
        static int[] path33C = { 34 };
        static int[] path33D = { 0 };
        static int[] path33E = { 36 };
        static int[] path33F = { 0 };
        static int[] path33G = { 32 };
        static int[] path33H = { 0 };
        static int[][] path33 = { path33A, path33B, path33C, path33D, path33E, path33F, path33G, path33H };

        static int[] path34A = { 0 };
        static int[] path34B = { 0 };
        static int[] path34C = { 0 };
        static int[] path34D = { 37 };
        static int[] path34E = { 0 };
        static int[] path34F = { 0 };
        static int[] path34G = { 33, 32 };
        static int[] path34H = { 29, 23, 17 };
        static int[][] path34 = { path34A, path34B, path34C, path34D, path34E, path34F, path34G, path34H };

        static int[] path35A = { 0 };
        static int[] path35B = { 32, 29, 25, 21 };
        static int[] path35C = { 36, 37 };
        static int[] path35D = { 0 };
        static int[] path35E = { 0 };
        static int[] path35F = { 0 };
        static int[] path35G = { 0 };
        static int[] path35H = { 0 };
        static int[][] path35 = { path35A, path35B, path35C, path35D, path35E, path35F, path35G, path35H };

        static int[] path36A = { 33, 29, 24, 19, 14, 9, 5, 2 };
        static int[] path36B = { 0 };
        static int[] path36C = { 37 };
        static int[] path36D = { 0 };
        static int[] path36E = { 0 };
        static int[] path36F = { 0 };
        static int[] path36G = { 35 };
        static int[] path36H = { 0 };
        static int[][] path36 = { path36A, path36B, path36C, path36D, path36E, path36F, path36G, path36H };

        static int[] path37A = { 0 };
        static int[] path37B = { 0 };
        static int[] path37C = { 0 };
        static int[] path37D = { 0 };
        static int[] path37E = { 0 };
        static int[] path37F = { 0 };
        static int[] path37G = { 36, 35 };
        static int[] path37H = { 34, 29, 23, 17 };
        static int[][] path37 = { path37A, path37B, path37C, path37D, path37E, path37F, path37G, path37H };

        static Point[] point = {   p0,
                            p1, p2, p3,
                            p4, p5, p6,
                            p7, p8, p9, p10, p11,
                            p12, p13, p14, p15, p16,
                            p17, p18, p19, p20, p21,
                            p22, p23, p24, p25, p26,
                            p27, p28, p29, p30, p31,
                            p32, p33, p34,
                            p35, p36, p37
                        };

        static int[][] nextpos = {
                            np0,
                            np1, np2, np3,
                            np4, np5, np6,
                            np7, np8, np9, np10, np11,
                            np12, np13, np14, np15, np16,
                            np17, np18, np19, np20, np21,
                            np22, np23, np24, np25, np26,
                            np27, np28, np29, np30, np31,
                            np32, np33, np34,
                            np35, np36, np37
                        };

        static int[][][] path = { path0, path1, path2, path3, path4, path5, path6, path7, path8, path9, path10, path11, path12, path13, path14, path15, path16, path17, path18, path19, path20, path21, path22, path23, path24, path25, path26, path27, path28, path29, path30, path31, path32, path33, path34, path35, path36, path37 };

        Point nowpos;
        List<Point> pos = new List<Point>();
        List<int> isDead = new List<int>();
        char[] statusPos = new char[38];
        Rectangle[] rectpos = new Rectangle[38];

        List<Bidak> bidak = new List<Bidak>();

        bool start = false;
        int turn = 0;

        int bidakkiri = 11;
        int bidakkanan = 10;
        Board papan;
        int indexMacan = -1;

        bool drag = false;
        int indexdrag = -1;
        int indexpointdrag = -1;

        int indexpointmacan = -1;

        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            papan = new Board(path);

            for (int i = 0; i < 38; i++)
            {
                statusPos[i] = 'X';
            }


            //Bidak macan = new Bidak(point[13].X, point[13].Y, 13, "Macan", nextpos[13], path[13]);
            //Console.WriteLine(macan.getJumlahKoneksi(statusPos)+"");
            //Console.WriteLine(macan.getJumlahLoncatan(statusPos, path[13])+"");

            //bidak.Add(macan);
            //papan.setBidak(bidak);

            //papan.setStatusPos(13, 'M');
            //papan.setStatusPos(18, 'O');

            //Console.WriteLine(papan.getTotalKoneksi("Macan"));

            
            //int[] cek = { 0, 1, 2 };
            //if (cek.Contains(1))
            //{
            //    Console.WriteLine(Array.IndexOf(cek, 1));
            //    Console.WriteLine("a");
            //}
            panel1.Focus();
            panel1.BackColor = Color.White;
            nowpos = point[1];

            for (int i = 0; i < 38; i++)
            {
                Size sz = new Size(50, 50);
                rectpos[i] = new Rectangle(point[i].X - 25, point[i].Y - 25, 50, 50);
            }

            panel1.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            //map
            Brush brush = new SolidBrush(Color.Blue);
            Pen pen = new Pen(brush, 3);
            Brush brush1 = new SolidBrush(Color.Red);
            Pen pen1 = new Pen(brush1, 3);

            for (int i = 0; i < 38; i++)
            {
                g.FillRectangle(brush1,rectpos[i]);
            }
            
            Point t1 = new Point(160, 30);
            Point t2 = new Point(460, 30);
            Point t3 = new Point(310, 210);
            g.DrawLine(pen, t1, t2);
            g.DrawLine(pen, t2, t3);
            g.DrawLine(pen, t1, t3);

            Point p1 = new Point(225, 110);
            Point p2 = new Point(395, 110);
            g.DrawLine(pen, p1, p2);

            p1 = new Point(310, 30);
            p2 = new Point(310, 210);
            g.DrawLine(pen, p1, p2);

            Rectangle kotakbesar = new Rectangle(110, 210, 400, 400);
            g.DrawRectangle(pen, kotakbesar);

            int x1awal = 210;
            int y1awal = 210;
            int x2awal = 210;
            int y2awal = 610;
            for (int i = 0; i < 3; i++)
            {
                p1 = new Point(x1awal, y1awal);
                p2 = new Point(x2awal, y2awal);
                g.DrawLine(pen, p1, p2);

                x1awal += 100;
                x2awal += 100;
            }

            x1awal = 110;
            y1awal = 310;
            x2awal = 510;
            y2awal = 310;
            for (int i = 0; i < 3; i++)
            {
                p1 = new Point(x1awal, y1awal);
                p2 = new Point(x2awal, y2awal);
                g.DrawLine(pen, p1, p2);

                y1awal += 100;
                y2awal += 100;
            }

            //diagonal atas kiri ke bawah kanan
            p1 = new Point(110, 210);
            p2 = new Point(510, 610);
            g.DrawLine(pen, p1, p2);

            //diagonal atas kanan ke bawah kiri
            p1 = new Point(510, 210);
            p2 = new Point(110, 610);
            g.DrawLine(pen, p1, p2);

            p1 = new Point(310, 210);
            p2 = new Point(510, 410);
            g.DrawLine(pen, p1, p2);

            p1 = new Point(310, 210);
            p2 = new Point(110, 410);
            g.DrawLine(pen, p1, p2);

            p1 = new Point(110, 410);
            p2 = new Point(310, 610);
            g.DrawLine(pen, p1, p2);

            p1 = new Point(510, 410);
            p2 = new Point(310, 610);
            g.DrawLine(pen, p1, p2);

            t1 = new Point(160, 810);
            t2 = new Point(460, 810);
            t3 = new Point(310, 610);
            g.DrawLine(pen, t1, t2);
            g.DrawLine(pen, t2, t3);
            g.DrawLine(pen, t1, t3);

            p1 = new Point(235, 710);
            p2 = new Point(385, 710);
            g.DrawLine(pen, p1, p2);

            p1 = new Point(310, 610);
            p2 = new Point(310, 810);
            g.DrawLine(pen, p1, p2);
            //


            Image img = Image.FromFile("wong.png");
            Size size = new Size(50, 50);

            Point pbidakkiri = new Point(25, 100);
            for (int i = 0; i < 11; i++)
            {
                Point tpos = new Point(pbidakkiri.X, pbidakkiri.Y);
                Rectangle rect_image = new Rectangle(tpos, size);
                g.DrawRectangle(pen, rect_image);

                pbidakkiri.Y += 50;
            }
            pbidakkiri = new Point(25, 100);
            for (int i = 0; i < bidakkiri; i++)
            {
                Point tpos = new Point(pbidakkiri.X, pbidakkiri.Y);
                Rectangle rect_image = new Rectangle(tpos, size);
                g.DrawImage(img, rect_image);
                g.DrawRectangle(pen, rect_image);

                pbidakkiri.Y += 50;
                
            }

            Point pbidakkanan = new Point(545, 100);
            for (int i = 0; i < 11; i++)
            {
                Point tpos = new Point(pbidakkanan.X, pbidakkanan.Y);
                Rectangle rect_image = new Rectangle(tpos, size);
                g.DrawRectangle(pen, rect_image);

                pbidakkanan.Y += 50;
            }
            pbidakkanan = new Point(545, 100);
            for (int i = 0; i < bidakkanan; i++)
            {
                Point tpos = new Point(pbidakkanan.X, pbidakkanan.Y);
                Rectangle rect_image = new Rectangle(tpos, size);
                g.DrawImage(img, rect_image);

                pbidakkanan.Y += 50;

            }

            if (indexMacan == -1)
            {
                img = Image.FromFile("macan.png");
                Point posbidakmacan = new Point(545, 100 + (10 * 50));
                Rectangle rect_macan = new Rectangle(posbidakmacan, size);
                g.DrawImage(img, rect_macan);
            }

            img = Image.FromFile("wong.png");
            for (int i = 0; i < pos.Count; i++)
            {
                if (bidak[i].getType()=="Macan")
                    img = Image.FromFile("macan.png");
                else
                    img = Image.FromFile("wong.png");

                Point tpos = new Point(pos[i].X-25, pos[i].Y-25);
                Rectangle rect_image = new Rectangle(tpos, size);
                g.DrawImage(img, rect_image);
            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            ////turn genap = wong
            //Rectangle rect_cursor = new Rectangle(e.X, e.Y, 1, 1);

            //if (turn % 2 == 0)
            //{
            //    for (int i = 1; i < rectpos.Length; i++)
            //    {
            //        if (rect_cursor.IntersectsWith(rectpos[i]) && pos.Count < 21)
            //        {
            //            if (!drag)
            //            {
            //                Console.WriteLine("wong");
            //                Console.WriteLine(statusPos[i]);
            //                if (statusPos[i] == 'X')
            //                {

            //                    nowpos = point[i];
            //                    pos.Add(point[i]);
            //                    int index = pos.Count - 1;
            //                    bidak.Add(new Bidak(point[i], i, "Wong", nextpos[i], path[i]));
            //                    papan.setBidak(bidak);
            //                    papan.setStatusPos(i, 'O');
            //                    statusPos[i] = 'O';

            //                    if (bidakkiri > 0)
            //                    {
            //                        bidakkiri--;
            //                    }
            //                    else
            //                    {
            //                        bidakkanan--;
            //                    }

            //                    if (pos.Count == 9)
            //                    {
            //                        turn++;
            //                        Console.WriteLine("turn" + turn + "");
            //                    }
            //                    else if (pos.Count > 9)
            //                    {
            //                        turn++;
            //                        Console.WriteLine("turn" + turn + "");
            //                    }

            //                    break;
            //                }
            //            }
            //            //else if (statusPos[i] == 'O')
            //            //{
            //            //    statusPos[i] = 'X';

            //            //    if (pos.Count > 9)
            //            //    {
            //            //        drag = true;
            //            //        indexdrag = i;
            //            //        Console.WriteLine("lalalalal");
            //            //        Console.WriteLine("indexdrag = " + indexdrag);
            //            //    }
            //            //    break;
            //            //}
            //        }
            //    }


            //}


            ////turn ai
            //else if (turn % 2 == 1)
            //{
            //    //manggil Ai harusnya

            //    for (int i = 1; i < rectpos.Length; i++)
            //    {
            //        if (rect_cursor.IntersectsWith(rectpos[i]) && pos.Count < 21)
            //        {

            //            if (!drag)
            //            {
            //                Console.WriteLine("macan");

            //                if (statusPos[i] == 'X')
            //                {
            //                    if (pos.Count == 9)
            //                    {
            //                        nowpos = point[i];
            //                        pos.Add(point[i]);
            //                        int index = pos.Count - 1;
            //                        indexMacan = index;
            //                        bidak.Add(new Bidak(point[i], i, "Macan", nextpos[i], path[i]));
            //                        papan.setBidak(bidak);
            //                        papan.setStatusPos(i, 'M');
            //                        statusPos[i] = 'M';
            //                        turn++;
            //                    }
            //                    else
            //                    {
            //                        int posMacan = bidak[indexMacan].getPoint();
            //                        for (int j = 0; j < nextpos[posMacan].Length; j++)
            //                        {
            //                            Console.WriteLine(i + " == " + nextpos[posMacan][j]);
            //                            if (i == nextpos[posMacan][j])
            //                            {
            //                                pos[indexMacan] = point[i];
            //                                bidak[indexMacan].setPos(point[i]);
            //                                bidak[indexMacan].setPoint(i);
            //                                bidak[indexMacan].setNextpos(nextpos[indexMacan]);
            //                                turn++;
            //                            }
            //                        }

            //                    }


            //                    Console.WriteLine("turn" + turn + "");
            //                    break;
            //                }
            //            }
            //        }
            //    }


            //}
            //Console.WriteLine("klik");
            //Console.WriteLine(papan.getJumlahWong() + "");
            //panel1.Invalidate();
        }   

        

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //Console.WriteLine("drag");
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Rectangle rect_cursor = new Rectangle(e.X - 25, e.Y - 25, 1, 1);
                pos[indexdrag] = new Point(e.X - 25, e.Y - 25);

                //for (int i = 1; i < rectpos.Length; i++)
                //{
                //    if (i != indexpointdrag)
                //    {
                //        if (rect_cursor.IntersectsWith(rectpos[i]))
                //        {
                //            pos[indexdrag] = point[i];
                //            statusPos[i] = 'O';
                //            statusPos[indexpointdrag] = 'X';

                //            drag = false;
                //            break;
                //        }
                //    }
                //}
                
                panel1.Invalidate();
                 
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                bool nemu = false;
                Console.WriteLine("indexpoint drafg = " + indexpointdrag);
                Console.WriteLine("index drag = " + indexdrag);
                for (int i = 1; i < rectpos.Length; i++)
                {
                    if (statusPos[i] == 'X')
                    {

                        if (i != indexpointdrag)
                        {
                            Rectangle temprect = new Rectangle(pos[indexdrag].X, pos[indexdrag].Y, 50, 50);
                            if (temprect.IntersectsWith(rectpos[i]))
                            {
                                if (nextpos[indexpointdrag].Contains(i))
                                {
                                    pos[indexdrag] = point[i];
                                    statusPos[i] = 'O';
                                    statusPos[indexpointdrag] = 'X';

                                    drag = false;
                                    turn++;
                                    nemu = true;
                                    break;
                                }
                            }
                        }
                    }

                        //if (nemu) break;
                        
                    //}

                }

                if (!nemu)
                {
                    pos[indexdrag] = point[indexpointdrag];
                    drag = false;
                }
                    
            }
            panel1.Invalidate();
            Console.WriteLine("release");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //turn genap = wong
            Rectangle rect_cursor = new Rectangle(e.X, e.Y, 1, 1);

            if (turn % 2 == 0)
            {
                for (int i = 1; i < rectpos.Length; i++)
                {
                    if (rect_cursor.IntersectsWith(rectpos[i]) && pos.Count < 21)
                    {
                        Console.WriteLine("wong");
                        Console.WriteLine("status yg diklik = "+statusPos[i]);
                        
                        if (statusPos[i] == 'X')
                        {
                            Console.WriteLine("iya ini kosong");
                            nowpos = point[i];
                            pos.Add(point[i]);
                            int index = pos.Count - 1;
                            bidak.Add(new Bidak(point[i], i, "Wong", nextpos[i], path[i]));
                            papan.setBidak(bidak);
                            papan.setStatusPos(i, 'O');
                            statusPos[i] = 'O';

                            if (bidakkiri > 0)
                            {
                                bidakkiri--;
                            }
                            else
                            {
                                bidakkanan--;
                            }

                            if (pos.Count == 9)
                            {
                                turn++;
                                Console.WriteLine("turn" + turn + "");
                            }
                            else if (pos.Count > 9)
                            {
                                turn++;
                                Console.WriteLine("turn" + turn + "");
                            }

                            break;
                        }
                        else if (statusPos[i] == 'O')
                        {
                            Console.WriteLine("yg di drag di point = " + i);
                            if (pos.Count > 9)
                            {
                                for (int j = 0; j < pos.Count; j++)
                                {
                                    Rectangle temprect = new Rectangle(pos[j].X - 25, pos[j].Y - 25, 50, 50);

                                    if (rect_cursor.IntersectsWith(temprect))
                                    {
                                        indexpointdrag = i;
                                        drag = true;
                                        indexdrag = j;
                                        Console.WriteLine("lalalalal");
                                        Console.WriteLine("indexdrag = " + indexdrag);
                                        break;
                                    }

                                }
                                //statusPos[i] = 'X';

                                break;
                            }

                        }
                    }
                    
                }


            }


            //turn ai
            else if (turn % 2 == 1)
            {
                //manggil Ai harusnya

                for (int i = 1; i < rectpos.Length; i++)
                {
                    if (rect_cursor.IntersectsWith(rectpos[i]) && pos.Count < 21)
                    {

                        Console.WriteLine("macan");

                        if (statusPos[i] == 'X')
                        {
                            if (pos.Count == 9)
                            {
                                nowpos = point[i];
                                pos.Add(point[i]);
                                int index = pos.Count - 1;
                                indexMacan = index;
                                bidak.Add(new Bidak(point[i], i, "Macan", nextpos[i], path[i]));
                                papan.setBidak(bidak);
                                papan.setStatusPos(i, 'M');
                                statusPos[i] = 'M';
                                indexpointmacan = i;
                                turn++;
                            }
                            else
                            {
                                int posMacan = bidak[indexMacan].getPoint();
                                for (int j = 0; j < nextpos[posMacan].Length; j++)
                                {
                                    Console.WriteLine(i + " == " + nextpos[posMacan][j]);
                                    if (i == nextpos[posMacan][j])
                                    {
                                        pos[indexMacan] = point[i];
                                        bidak[indexMacan].setPos(point[i]);
                                        bidak[indexMacan].setPoint(i);
                                        bidak[indexMacan].setNextpos(nextpos[indexMacan]);
                                        statusPos[i] = 'M';
                                        statusPos[indexpointmacan] = 'X';
                                        turn++;
                                    }
                                }

                            }


                            Console.WriteLine("turn" + turn + "");
                            break;
                        }
                        
                    }
                }


            }
            Console.WriteLine("klik");
            Console.WriteLine(papan.getJumlahWong() + "");
            panel1.Invalidate();
        }

        
    }
}
