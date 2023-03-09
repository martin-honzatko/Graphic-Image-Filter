using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicImageFilter.Models
{
    internal static class ColourIntHexConverter
    {
        #region Convert green HEX value to int
        public static int ConvertGreen(int green)
        {
            int result = new int();
            switch (green)
            {
                case 0x0000:
                    result = 0;
                    break;
                case 0x00FF:
                    result = 1;
                    break;
                case 0x01FE:
                    result = 2;
                    break;
                case 0x02FD:
                    result = 3;
                    break;
                case 0x03FC:
                    result = 4;
                    break;
                case 0x04FB:
                    result = 5;
                    break;
                case 0x05FA:
                    result = 6;
                    break;
                case 0x06F9:
                    result = 7;
                    break;
                case 0x07F8:
                    result = 8;
                    break;
                case 0x08F7:
                    result = 9;
                    break;
                case 0x09F6:
                    result = 10;
                    break;
                case 0x0AF5:
                    result = 11;
                    break;
                case 0x0BF4:
                    result = 12;
                    break;
                case 0x0CF3:
                    result = 13;
                    break;
                case 0x0DF2:
                    result = 14;
                    break;
                case 0x0EF1:
                    result = 15;
                    break;
                case 0x0FF0:
                    result = 16;
                    break;
                case 0x10EF:
                    result = 17;
                    break;
                case 0x11EE:
                    result = 18;
                    break;
                case 0x12ED:
                    result = 19;
                    break;
                case 0x13EC:
                    result = 20;
                    break;
                case 0x14EB:
                    result = 21;
                    break;
                case 0x15EA:
                    result = 22;
                    break;
                case 0x16E9:
                    result = 23;
                    break;
                case 0x17E8:
                    result = 24;
                    break;
                case 0x18E7:
                    result = 25;
                    break;
                case 0x19E6:
                    result = 26;
                    break;
                case 0x1AE5:
                    result = 27;
                    break;
                case 0x1BE4:
                    result = 28;
                    break;
                case 0x1CE3:
                    result = 29;
                    break;
                case 0x1DE2:
                    result = 30;
                    break;
                case 0x1EE1:
                    result = 31;
                    break;
                case 0x1FE0:
                    result = 32;
                    break;
                case 0x20DF:
                    result = 33;
                    break;
                case 0x21DE:
                    result = 34;
                    break;
                case 0x22DD:
                    result = 35;
                    break;
                case 0x23DC:
                    result = 36;
                    break;
                case 0x24DB:
                    result = 37;
                    break;
                case 0x25DA:
                    result = 38;
                    break;
                case 0x26D9:
                    result = 39;
                    break;
                case 0x27D8:
                    result = 40;
                    break;
                case 0x28D7:
                    result = 41;
                    break;
                case 0x29D6:
                    result = 42;
                    break;
                case 0x2AD5:
                    result = 43;
                    break;
                case 0x2BD4:
                    result = 44;
                    break;
                case 0x2CD3:
                    result = 45;
                    break;
                case 0x2DD2:
                    result = 46;
                    break;
                case 0x2ED1:
                    result = 47;
                    break;
                case 0x2FD0:
                    result = 48;
                    break;
                case 0x30CF:
                    result = 49;
                    break;
                case 0x31CE:
                    result = 50;
                    break;
                case 0x32CD:
                    result = 51;
                    break;
                case 0x33CC:
                    result = 52;
                    break;
                case 0x34CB:
                    result = 53;
                    break;
                case 0x35CA:
                    result = 54;
                    break;
                case 0x36C9:
                    result = 55;
                    break;
                case 0x37C8:
                    result = 56;
                    break;
                case 0x38C7:
                    result = 57;
                    break;
                case 0x39C6:
                    result = 58;
                    break;
                case 0x3AC5:
                    result = 59;
                    break;
                case 0x3BC4:
                    result = 60;
                    break;
                case 0x3CC3:
                    result = 61;
                    break;
                case 0x3DC2:
                    result = 62;
                    break;
                case 0x3EC1:
                    result = 63;
                    break;
                case 0x3FC0:
                    result = 64;
                    break;
                case 0x40BF:
                    result = 65;
                    break;
                case 0x41BE:
                    result = 66;
                    break;
                case 0x42BD:
                    result = 67;
                    break;
                case 0x43BC:
                    result = 68;
                    break;
                case 0x44BB:
                    result = 69;
                    break;
                case 0x45BA:
                    result = 70;
                    break;
                case 0x46B9:
                    result = 71;
                    break;
                case 0x47B8:
                    result = 72;
                    break;
                case 0x48B7:
                    result = 73;
                    break;
                case 0x49B6:
                    result = 74;
                    break;
                case 0x4AB5:
                    result = 75;
                    break;
                case 0x4BB4:
                    result = 76;
                    break;
                case 0x4CB3:
                    result = 77;
                    break;
                case 0x4DB2:
                    result = 78;
                    break;
                case 0x4EB1:
                    result = 79;
                    break;
                case 0x4FB0:
                    result = 80;
                    break;
                case 0x50AF:
                    result = 81;
                    break;
                case 0x51AE:
                    result = 82;
                    break;
                case 0x52AD:
                    result = 83;
                    break;
                case 0x53AC:
                    result = 84;
                    break;
                case 0x54AB:
                    result = 85;
                    break;
                case 0x55AA:
                    result = 86;
                    break;
                case 0x56A9:
                    result = 87;
                    break;
                case 0x57A8:
                    result = 88;
                    break;
                case 0x58A7:
                    result = 89;
                    break;
                case 0x59A6:
                    result = 90;
                    break;
                case 0x5AA5:
                    result = 91;
                    break;
                case 0x5BA4:
                    result = 92;
                    break;
                case 0x5CA3:
                    result = 93;
                    break;
                case 0x5DA2:
                    result = 94;
                    break;
                case 0x5EA1:
                    result = 95;
                    break;
                case 0x5FA0:
                    result = 96;
                    break;
                case 0x609F:
                    result = 97;
                    break;
                case 0x619E:
                    result = 98;
                    break;
                case 0x629D:
                    result = 99;
                    break;
                case 0x639C:
                    result = 100;
                    break;
                case 0x649B:
                    result = 101;
                    break;
                case 0x659A:
                    result = 102;
                    break;
                case 0x6699:
                    result = 103;
                    break;
                case 0x6798:
                    result = 104;
                    break;
                case 0x6897:
                    result = 105;
                    break;
                case 0x6996:
                    result = 106;
                    break;
                case 0x6A95:
                    result = 107;
                    break;
                case 0x6B94:
                    result = 108;
                    break;
                case 0x6C93:
                    result = 109;
                    break;
                case 0x6D92:
                    result = 110;
                    break;
                case 0x6E91:
                    result = 111;
                    break;
                case 0x6F90:
                    result = 112;
                    break;
                case 0x708F:
                    result = 113;
                    break;
                case 0x718E:
                    result = 114;
                    break;
                case 0x728D:
                    result = 115;
                    break;
                case 0x738C:
                    result = 116;
                    break;
                case 0x748B:
                    result = 117;
                    break;
                case 0x758A:
                    result = 118;
                    break;
                case 0x7689:
                    result = 119;
                    break;
                case 0x7788:
                    result = 120;
                    break;
                case 0x7887:
                    result = 121;
                    break;
                case 0x7986:
                    result = 122;
                    break;
                case 0x7A85:
                    result = 123;
                    break;
                case 0x7B84:
                    result = 124;
                    break;
                case 0x7C83:
                    result = 125;
                    break;
                case 0x7D82:
                    result = 126;
                    break;
                case 0x7E81:
                    result = 127;
                    break;
                case 0x7F80:
                    result = 128;
                    break;
                case 0x807F:
                    result = 129;
                    break;
                case 0x817E:
                    result = 130;
                    break;
                case 0x827D:
                    result = 131;
                    break;
                case 0x837C:
                    result = 132;
                    break;
                case 0x847B:
                    result = 133;
                    break;
                case 0x857A:
                    result = 134;
                    break;
                case 0x8679:
                    result = 135;
                    break;
                case 0x8778:
                    result = 136;
                    break;
                case 0x8877:
                    result = 137;
                    break;
                case 0x8976:
                    result = 138;
                    break;
                case 0x8A75:
                    result = 139;
                    break;
                case 0x8B74:
                    result = 140;
                    break;
                case 0x8C73:
                    result = 141;
                    break;
                case 0x8D72:
                    result = 142;
                    break;
                case 0x8E71:
                    result = 143;
                    break;
                case 0x8F70:
                    result = 144;
                    break;
                case 0x906F:
                    result = 145;
                    break;
                case 0x916E:
                    result = 146;
                    break;
                case 0x926D:
                    result = 147;
                    break;
                case 0x936C:
                    result = 148;
                    break;
                case 0x946B:
                    result = 149;
                    break;
                case 0x956A:
                    result = 150;
                    break;
                case 0x9669:
                    result = 151;
                    break;
                case 0x9768:
                    result = 152;
                    break;
                case 0x9867:
                    result = 153;
                    break;
                case 0x9966:
                    result = 154;
                    break;
                case 0x9A65:
                    result = 155;
                    break;
                case 0x9B64:
                    result = 156;
                    break;
                case 0x9C63:
                    result = 157;
                    break;
                case 0x9D62:
                    result = 158;
                    break;
                case 0x9E61:
                    result = 159;
                    break;
                case 0x9F60:
                    result = 160;
                    break;
                case 0xA05F:
                    result = 161;
                    break;
                case 0xA15E:
                    result = 162;
                    break;
                case 0xA25D:
                    result = 163;
                    break;
                case 0xA35C:
                    result = 164;
                    break;
                case 0xA45B:
                    result = 165;
                    break;
                case 0xA55A:
                    result = 166;
                    break;
                case 0xA659:
                    result = 167;
                    break;
                case 0xA758:
                    result = 168;
                    break;
                case 0xA857:
                    result = 169;
                    break;
                case 0xA956:
                    result = 170;
                    break;
                case 0xAA55:
                    result = 171;
                    break;
                case 0xAB54:
                    result = 172;
                    break;
                case 0xAC53:
                    result = 173;
                    break;
                case 0xAD52:
                    result = 174;
                    break;
                case 0xAE51:
                    result = 175;
                    break;
                case 0xAF50:
                    result = 176;
                    break;
                case 0xB04F:
                    result = 177;
                    break;
                case 0xB14E:
                    result = 178;
                    break;
                case 0xB24D:
                    result = 179;
                    break;
                case 0xB34C:
                    result = 180;
                    break;
                case 0xB44B:
                    result = 181;
                    break;
                case 0xB54A:
                    result = 182;
                    break;
                case 0xB649:
                    result = 183;
                    break;
                case 0xB748:
                    result = 184;
                    break;
                case 0xB847:
                    result = 185;
                    break;
                case 0xB946:
                    result = 186;
                    break;
                case 0xBA45:
                    result = 187;
                    break;
                case 0xBB44:
                    result = 188;
                    break;
                case 0xBC43:
                    result = 189;
                    break;
                case 0xBD42:
                    result = 190;
                    break;
                case 0xBE41:
                    result = 191;
                    break;
                case 0xBF40:
                    result = 192;
                    break;
                case 0xC03F:
                    result = 193;
                    break;
                case 0xC13E:
                    result = 194;
                    break;
                case 0xC23D:
                    result = 195;
                    break;
                case 0xC33C:
                    result = 196;
                    break;
                case 0xC43B:
                    result = 197;
                    break;
                case 0xC53A:
                    result = 198;
                    break;
                case 0xC639:
                    result = 199;
                    break;
                case 0xC738:
                    result = 200;
                    break;
                case 0xC837:
                    result = 201;
                    break;
                case 0xC936:
                    result = 202;
                    break;
                case 0xCA35:
                    result = 203;
                    break;
                case 0xCB34:
                    result = 204;
                    break;
                case 0xCC33:
                    result = 205;
                    break;
                case 0xCD32:
                    result = 206;
                    break;
                case 0xCE31:
                    result = 207;
                    break;
                case 0xCF30:
                    result = 208;
                    break;
                case 0xD02F:
                    result = 209;
                    break;
                case 0xD12E:
                    result = 210;
                    break;
                case 0xD22D:
                    result = 211;
                    break;
                case 0xD32C:
                    result = 212;
                    break;
                case 0xD42B:
                    result = 213;
                    break;
                case 0xD52A:
                    result = 214;
                    break;
                case 0xD629:
                    result = 215;
                    break;
                case 0xD728:
                    result = 216;
                    break;
                case 0xD827:
                    result = 217;
                    break;
                case 0xD926:
                    result = 218;
                    break;
                case 0xDA25:
                    result = 219;
                    break;
                case 0xDB60:
                    result = 220;
                    break;
                case 0xDD22:
                    result = 221;
                    break;
                case 0xDE21:
                    result = 222;
                    break;
                case 0xDF20:
                    result = 223;
                    break;
                case 0xE01F:
                    result = 224;
                    break;
                case 0xE11E:
                    result = 225;
                    break;
                case 0xE21D:
                    result = 226;
                    break;
                case 0xE31C:
                    result = 227;
                    break;
                case 0xE41B:
                    result = 228;
                    break;
                case 0xE51A:
                    result = 229;
                    break;
                case 0xE619:
                    result = 230;
                    break;
                case 0xE718:
                    result = 231;
                    break;
                case 0xE817:
                    result = 232;
                    break;
                case 0xE916:
                    result = 233;
                    break;
                case 0xEA15:
                    result = 234;
                    break;
                case 0xEB14:
                    result = 235;
                    break;
                case 0xEC13:
                    result = 236;
                    break;
                case 0xED12:
                    result = 237;
                    break;
                case 0xEE11:
                    result = 238;
                    break;
                case 0xEF10:
                    result = 239;
                    break;
                case 0xF00F:
                    result = 240;
                    break;
                case 0xF10E:
                    result = 241;
                    break;
                case 0xF20D:
                    result = 242;
                    break;
                case 0xF30C:
                    result = 243;
                    break;
                case 0xF40B:
                    result = 244;
                    break;
                case 0xF50A:
                    result = 245;
                    break;
                case 0xF609:
                    result = 246;
                    break;
                case 0xF708:
                    result = 247;
                    break;
                case 0xF807:
                    result = 248;
                    break;
                case 0xF906:
                    result = 249;
                    break;
                case 0xFA05:
                    result = 250;
                    break;
                case 0xFB04:
                    result = 251;
                    break;
                case 0xFC03:
                    result = 252;
                    break;
                case 0xFD02:
                    result = 253;
                    break;
                case 0xFE01:
                    result = 254;
                    break;
                case 0xFF00:
                    result = 255;
                    break;
            }

            return result;
        }
        #endregion

        #region Convert green int value to HEX
        public static void ConvertGreenBack(int value)
        {
            switch (value)
            {
                case 0:
                    ArrayBMIConverter.green = 0x0000;
                    break;
                case 1:
                    ArrayBMIConverter.green = 0x00FF;
                    break;
                case 2:
                    ArrayBMIConverter.green = 0x01FE;
                    break;
                case 3:
                    ArrayBMIConverter.green = 0x02FD;
                    break;
                case 4:
                    ArrayBMIConverter.green = 0x03FC;
                    break;
                case 5:
                    ArrayBMIConverter.green = 0x04FB;
                    break;
                case 6:
                    ArrayBMIConverter.green = 0x05FA;
                    break;
                case 7:
                    ArrayBMIConverter.green = 0x06F9;
                    break;
                case 8:
                    ArrayBMIConverter.green = 0x07F8;
                    break;
                case 9:
                    ArrayBMIConverter.green = 0x08F7;
                    break;
                case 10:
                    ArrayBMIConverter.green = 0x09F6;
                    break;
                case 11:
                    ArrayBMIConverter.green = 0x0AF5;
                    break;
                case 12:
                    ArrayBMIConverter.green = 0x0BF4;
                    break;
                case 13:
                    ArrayBMIConverter.green = 0x0CF3;
                    break;
                case 14:
                    ArrayBMIConverter.green = 0x0DF2;
                    break;
                case 15:
                    ArrayBMIConverter.green = 0x0EF1;
                    break;
                case 16:
                    ArrayBMIConverter.green = 0x0FF0;
                    break;
                case 17:
                    ArrayBMIConverter.green = 0x10EF;
                    break;
                case 18:
                    ArrayBMIConverter.green = 0x11EE;
                    break;
                case 19:
                    ArrayBMIConverter.green = 0x12ED;
                    break;
                case 20:
                    ArrayBMIConverter.green = 0x13EC;
                    break;
                case 21:
                    ArrayBMIConverter.green = 0x14EB;
                    break;
                case 22:
                    ArrayBMIConverter.green = 0x15EA;
                    break;
                case 23:
                    ArrayBMIConverter.green = 0x16E9;
                    break;
                case 24:
                    ArrayBMIConverter.green = 0x17E8;
                    break;
                case 25:
                    ArrayBMIConverter.green = 0x18E7;
                    break;
                case 26:
                    ArrayBMIConverter.green = 0x19E6;
                    break;
                case 27:
                    ArrayBMIConverter.green = 0x1AE5;
                    break;
                case 28:
                    ArrayBMIConverter.green = 0x1BE4;
                    break;
                case 29:
                    ArrayBMIConverter.green = 0x1CE3;
                    break;
                case 30:
                    ArrayBMIConverter.green = 0x1DE2;
                    break;
                case 31:
                    ArrayBMIConverter.green = 0x1EE1;
                    break;
                case 32:
                    ArrayBMIConverter.green = 0x1FE0;
                    break;
                case 33:
                    ArrayBMIConverter.green = 0x20DF;
                    break;
                case 34:
                    ArrayBMIConverter.green = 0x21DE;
                    break;
                case 35:
                    ArrayBMIConverter.green = 0x22DD;
                    break;
                case 36:
                    ArrayBMIConverter.green = 0x23DC;
                    break;
                case 37:
                    ArrayBMIConverter.green = 0x24DB;
                    break;
                case 38:
                    ArrayBMIConverter.green = 0x25DA;
                    break;
                case 39:
                    ArrayBMIConverter.green = 0x26D9;
                    break;
                case 40:
                    ArrayBMIConverter.green = 0x27D8;
                    break;
                case 41:
                    ArrayBMIConverter.green = 0x28D7;
                    break;
                case 42:
                    ArrayBMIConverter.green = 0x29D6;
                    break;
                case 43:
                    ArrayBMIConverter.green = 0x2AD5;
                    break;
                case 44:
                    ArrayBMIConverter.green = 0x2BD4;
                    break;
                case 45:
                    ArrayBMIConverter.green = 0x2CD3;
                    break;
                case 46:
                    ArrayBMIConverter.green = 0x2DD2;
                    break;
                case 47:
                    ArrayBMIConverter.green = 0x2ED1;
                    break;
                case 48:
                    ArrayBMIConverter.green = 0x2FD0;
                    break;
                case 49:
                    ArrayBMIConverter.green = 0x30CF;
                    break;
                case 50:
                    ArrayBMIConverter.green = 0x31CE;
                    break;
                case 51:
                    ArrayBMIConverter.green = 0x32CD;
                    break;
                case 52:
                    ArrayBMIConverter.green = 0x33CC;
                    break;
                case 53:
                    ArrayBMIConverter.green = 0x34CB;
                    break;
                case 54:
                    ArrayBMIConverter.green = 0x35CA;
                    break;
                case 55:
                    ArrayBMIConverter.green = 0x36C9;
                    break;
                case 56:
                    ArrayBMIConverter.green = 0x37C8;
                    break;
                case 57:
                    ArrayBMIConverter.green = 0x38C7;
                    break;
                case 58:
                    ArrayBMIConverter.green = 0x39C6;
                    break;
                case 59:
                    ArrayBMIConverter.green = 0x3AC5;
                    break;
                case 60:
                    ArrayBMIConverter.green = 0x3BC4;
                    break;
                case 61:
                    ArrayBMIConverter.green = 0x3CC3;
                    break;
                case 62:
                    ArrayBMIConverter.green = 0x3DC2;
                    break;
                case 63:
                    ArrayBMIConverter.green = 0x3EC1;
                    break;
                case 64:
                    ArrayBMIConverter.green = 0x3FC0;
                    break;
                case 65:
                    ArrayBMIConverter.green = 0x40BF;
                    break;
                case 66:
                    ArrayBMIConverter.green = 0x41BE;
                    break;
                case 67:
                    ArrayBMIConverter.green = 0x42BD;
                    break;
                case 68:
                    ArrayBMIConverter.green = 0x43BC;
                    break;
                case 69:
                    ArrayBMIConverter.green = 0x44BB;
                    break;
                case 70:
                    ArrayBMIConverter.green = 0x45BA;
                    break;
                case 71:
                    ArrayBMIConverter.green = 0x46B9;
                    break;
                case 72:
                    ArrayBMIConverter.green = 0x47B8;
                    break;
                case 73:
                    ArrayBMIConverter.green = 0x48B7;
                    break;
                case 74:
                    ArrayBMIConverter.green = 0x49B6;
                    break;
                case 75:
                    ArrayBMIConverter.green = 0x4AB5;
                    break;
                case 76:
                    ArrayBMIConverter.green = 0x4BB4;
                    break;
                case 77:
                    ArrayBMIConverter.green = 0x4CB3;
                    break;
                case 78:
                    ArrayBMIConverter.green = 0x4DB2;
                    break;
                case 79:
                    ArrayBMIConverter.green = 0x4EB1;
                    break;
                case 80:
                    ArrayBMIConverter.green = 0x4FB0;
                    break;
                case 81:
                    ArrayBMIConverter.green = 0x50AF;
                    break;
                case 82:
                    ArrayBMIConverter.green = 0x51AE;
                    break;
                case 83:
                    ArrayBMIConverter.green = 0x52AD;
                    break;
                case 84:
                    ArrayBMIConverter.green = 0x53AC;
                    break;
                case 85:
                    ArrayBMIConverter.green = 0x54AB;
                    break;
                case 86:
                    ArrayBMIConverter.green = 0x55AA;
                    break;
                case 87:
                    ArrayBMIConverter.green = 0x56A9;
                    break;
                case 88:
                    ArrayBMIConverter.green = 0x57A8;
                    break;
                case 89:
                    ArrayBMIConverter.green = 0x58A7;
                    break;
                case 90:
                    ArrayBMIConverter.green = 0x59A6;
                    break;
                case 91:
                    ArrayBMIConverter.green = 0x5AA5;
                    break;
                case 92:
                    ArrayBMIConverter.green = 0x5BA4;
                    break;
                case 93:
                    ArrayBMIConverter.green = 0x5CA3;
                    break;
                case 94:
                    ArrayBMIConverter.green = 0x5DA2;
                    break;
                case 95:
                    ArrayBMIConverter.green = 0x5EA1;
                    break;
                case 96:
                    ArrayBMIConverter.green = 0x5FA0;
                    break;
                case 97:
                    ArrayBMIConverter.green = 0x609F;
                    break;
                case 98:
                    ArrayBMIConverter.green = 0x619E;
                    break;
                case 99:
                    ArrayBMIConverter.green = 0x629D;
                    break;
                case 100:
                    ArrayBMIConverter.green = 0x639C;
                    break;
                case 101:
                    ArrayBMIConverter.green = 0x649B;
                    break;
                case 102:
                    ArrayBMIConverter.green = 0x659A;
                    break;
                case 103:
                    ArrayBMIConverter.green = 0x6699;
                    break;
                case 104:
                    ArrayBMIConverter.green = 0x6798;
                    break;
                case 105:
                    ArrayBMIConverter.green = 0x6897;
                    break;
                case 106:
                    ArrayBMIConverter.green = 0x6996;
                    break;
                case 107:
                    ArrayBMIConverter.green = 0x6A95;
                    break;
                case 108:
                    ArrayBMIConverter.green = 0x6B94;
                    break;
                case 109:
                    ArrayBMIConverter.green = 0x6C93;
                    break;
                case 110:
                    ArrayBMIConverter.green = 0x6D92;
                    break;
                case 111:
                    ArrayBMIConverter.green = 0x6E91;
                    break;
                case 112:
                    ArrayBMIConverter.green = 0x6F90;
                    break;
                case 113:
                    ArrayBMIConverter.green = 0x708F;
                    break;
                case 114:
                    ArrayBMIConverter.green = 0x718E;
                    break;
                case 115:
                    ArrayBMIConverter.green = 0x728D;
                    break;
                case 116:
                    ArrayBMIConverter.green = 0x738C;
                    break;
                case 117:
                    ArrayBMIConverter.green = 0x748B;
                    break;
                case 118:
                    ArrayBMIConverter.green = 0x758A;
                    break;
                case 119:
                    ArrayBMIConverter.green = 0x7689;
                    break;
                case 120:
                    ArrayBMIConverter.green = 0x7788;
                    break;
                case 121:
                    ArrayBMIConverter.green = 0x7887;
                    break;
                case 122:
                    ArrayBMIConverter.green = 0x7986;
                    break;
                case 123:
                    ArrayBMIConverter.green = 0x7A85;
                    break;
                case 124:
                    ArrayBMIConverter.green = 0x7B84;
                    break;
                case 125:
                    ArrayBMIConverter.green = 0x7C83;
                    break;
                case 126:
                    ArrayBMIConverter.green = 0x7D82;
                    break;
                case 127:
                    ArrayBMIConverter.green = 0x7E81;
                    break;
                case 128:
                    ArrayBMIConverter.green = 0x7F80;
                    break;
                case 129:
                    ArrayBMIConverter.green = 0x807F;
                    break;
                case 130:
                    ArrayBMIConverter.green = 0x817E;
                    break;
                case 131:
                    ArrayBMIConverter.green = 0x827D;
                    break;
                case 132:
                    ArrayBMIConverter.green = 0x837C;
                    break;
                case 133:
                    ArrayBMIConverter.green = 0x847B;
                    break;
                case 134:
                    ArrayBMIConverter.green = 0x857A;
                    break;
                case 135:
                    ArrayBMIConverter.green = 0x8679;
                    break;
                case 136:
                    ArrayBMIConverter.green = 0x8778;
                    break;
                case 137:
                    ArrayBMIConverter.green = 0x8877;
                    break;
                case 138:
                    ArrayBMIConverter.green = 0x8976;
                    break;
                case 139:
                    ArrayBMIConverter.green = 0x8A75;
                    break;
                case 140:
                    ArrayBMIConverter.green = 0x8B74;
                    break;
                case 141:
                    ArrayBMIConverter.green = 0x8C73;
                    break;
                case 142:
                    ArrayBMIConverter.green = 0x8D72;
                    break;
                case 143:
                    ArrayBMIConverter.green = 0x8E71;
                    break;
                case 144:
                    ArrayBMIConverter.green = 0x8F70;
                    break;
                case 145:
                    ArrayBMIConverter.green = 0x906F;
                    break;
                case 146:
                    ArrayBMIConverter.green = 0x916E;
                    break;
                case 147:
                    ArrayBMIConverter.green = 0x926D;
                    break;
                case 148:
                    ArrayBMIConverter.green = 0x936C;
                    break;
                case 149:
                    ArrayBMIConverter.green = 0x946B;
                    break;
                case 150:
                    ArrayBMIConverter.green = 0x956A;
                    break;
                case 151:
                    ArrayBMIConverter.green = 0x9669;
                    break;
                case 152:
                    ArrayBMIConverter.green = 0x9768;
                    break;
                case 153:
                    ArrayBMIConverter.green = 0x9867;
                    break;
                case 154:
                    ArrayBMIConverter.green = 0x9966;
                    break;
                case 155:
                    ArrayBMIConverter.green = 0x9A65;
                    break;
                case 156:
                    ArrayBMIConverter.green = 0x9B64;
                    break;
                case 157:
                    ArrayBMIConverter.green = 0x9C63;
                    break;
                case 158:
                    ArrayBMIConverter.green = 0x9D62;
                    break;
                case 159:
                    ArrayBMIConverter.green = 0x9E61;
                    break;
                case 160:
                    ArrayBMIConverter.green = 0x9F60;
                    break;
                case 161:
                    ArrayBMIConverter.green = 0xA05F;
                    break;
                case 162:
                    ArrayBMIConverter.green = 0xA15E;
                    break;
                case 163:
                    ArrayBMIConverter.green = 0xA25D;
                    break;
                case 164:
                    ArrayBMIConverter.green = 0xA35C;
                    break;
                case 165:
                    ArrayBMIConverter.green = 0xA45B;
                    break;
                case 166:
                    ArrayBMIConverter.green = 0xA55A;
                    break;
                case 167:
                    ArrayBMIConverter.green = 0xA659;
                    break;
                case 168:
                    ArrayBMIConverter.green = 0xA758;
                    break;
                case 169:
                    ArrayBMIConverter.green = 0xA857;
                    break;
                case 170:
                    ArrayBMIConverter.green = 0xA956;
                    break;
                case 171:
                    ArrayBMIConverter.green = 0xAA55;
                    break;
                case 172:
                    ArrayBMIConverter.green = 0xAB54;
                    break;
                case 173:
                    ArrayBMIConverter.green = 0xAC53;
                    break;
                case 174:
                    ArrayBMIConverter.green = 0xAD52;
                    break;
                case 175:
                    ArrayBMIConverter.green = 0xAE51;
                    break;
                case 176:
                    ArrayBMIConverter.green = 0xAF50;
                    break;
                case 177:
                    ArrayBMIConverter.green = 0xB04F;
                    break;
                case 178:
                    ArrayBMIConverter.green = 0xB14E;
                    break;
                case 179:
                    ArrayBMIConverter.green = 0xB24D;
                    break;
                case 180:
                    ArrayBMIConverter.green = 0xB34C;
                    break;
                case 181:
                    ArrayBMIConverter.green = 0xB44B;
                    break;
                case 182:
                    ArrayBMIConverter.green = 0xB54A;
                    break;
                case 183:
                    ArrayBMIConverter.green = 0xB649;
                    break;
                case 184:
                    ArrayBMIConverter.green = 0xB748;
                    break;
                case 185:
                    ArrayBMIConverter.green = 0xB847;
                    break;
                case 186:
                    ArrayBMIConverter.green = 0xB946;
                    break;
                case 187:
                    ArrayBMIConverter.green = 0xBA45;
                    break;
                case 188:
                    ArrayBMIConverter.green = 0xBB44;
                    break;
                case 189:
                    ArrayBMIConverter.green = 0xBC43;
                    break;
                case 190:
                    ArrayBMIConverter.green = 0xBD42;
                    break;
                case 191:
                    ArrayBMIConverter.green = 0xBE41;
                    break;
                case 192:
                    ArrayBMIConverter.green = 0xBF40;
                    break;
                case 193:
                    ArrayBMIConverter.green = 0xC03F;
                    break;
                case 194:
                    ArrayBMIConverter.green = 0xC13E;
                    break;
                case 195:
                    ArrayBMIConverter.green = 0xC23D;
                    break;
                case 196:
                    ArrayBMIConverter.green = 0xC33C;
                    break;
                case 197:
                    ArrayBMIConverter.green = 0xC43B;
                    break;
                case 198:
                    ArrayBMIConverter.green = 0xC53A;
                    break;
                case 199:
                    ArrayBMIConverter.green = 0xC639;
                    break;
                case 200:
                    ArrayBMIConverter.green = 0xC738;
                    break;
                case 201:
                    ArrayBMIConverter.green = 0xC837;
                    break;
                case 202:
                    ArrayBMIConverter.green = 0xC936;
                    break;
                case 203:
                    ArrayBMIConverter.green = 0xCA35;
                    break;
                case 204:
                    ArrayBMIConverter.green = 0xCB34;
                    break;
                case 205:
                    ArrayBMIConverter.green = 0xCC33;
                    break;
                case 206:
                    ArrayBMIConverter.green = 0xCD32;
                    break;
                case 207:
                    ArrayBMIConverter.green = 0xCE31;
                    break;
                case 208:
                    ArrayBMIConverter.green = 0xCF30;
                    break;
                case 209:
                    ArrayBMIConverter.green = 0xD02F;
                    break;
                case 210:
                    ArrayBMIConverter.green = 0xD12E;
                    break;
                case 211:
                    ArrayBMIConverter.green = 0xD22D;
                    break;
                case 212:
                    ArrayBMIConverter.green = 0xD32C;
                    break;
                case 213:
                    ArrayBMIConverter.green = 0xD42B;
                    break;
                case 214:
                    ArrayBMIConverter.green = 0xD52A;
                    break;
                case 215:
                    ArrayBMIConverter.green = 0xD629;
                    break;
                case 216:
                    ArrayBMIConverter.green = 0xD728;
                    break;
                case 217:
                    ArrayBMIConverter.green = 0xD827;
                    break;
                case 218:
                    ArrayBMIConverter.green = 0xD926;
                    break;
                case 219:
                    ArrayBMIConverter.green = 0xDA25;
                    break;
                case 220:
                    ArrayBMIConverter.green = 0xDB60;
                    break;
                case 221:
                    ArrayBMIConverter.green = 0xDD22;
                    break;
                case 222:
                    ArrayBMIConverter.green = 0xDE21;
                    break;
                case 223:
                    ArrayBMIConverter.green = 0xDF20;
                    break;
                case 224:
                    ArrayBMIConverter.green = 0xE01F;
                    break;
                case 225:
                    ArrayBMIConverter.green = 0xE11E;
                    break;
                case 226:
                    ArrayBMIConverter.green = 0xE21D;
                    break;
                case 227:
                    ArrayBMIConverter.green = 0xE31C;
                    break;
                case 228:
                    ArrayBMIConverter.green = 0xE41B;
                    break;
                case 229:
                    ArrayBMIConverter.green = 0xE51A;
                    break;
                case 230:
                    ArrayBMIConverter.green = 0xE619;
                    break;
                case 231:
                    ArrayBMIConverter.green = 0xE718;
                    break;
                case 232:
                    ArrayBMIConverter.green = 0xE817;
                    break;
                case 233:
                    ArrayBMIConverter.green = 0xE916;
                    break;
                case 234:
                    ArrayBMIConverter.green = 0xEA15;
                    break;
                case 235:
                    ArrayBMIConverter.green = 0xEB14;
                    break;
                case 236:
                    ArrayBMIConverter.green = 0xEC13;
                    break;
                case 237:
                    ArrayBMIConverter.green = 0xED12;
                    break;
                case 238:
                    ArrayBMIConverter.green = 0xEE11;
                    break;
                case 239:
                    ArrayBMIConverter.green = 0xEF10;
                    break;
                case 240:
                    ArrayBMIConverter.green = 0xF00F;
                    break;
                case 241:
                    ArrayBMIConverter.green = 0xF10E;
                    break;
                case 242:
                    ArrayBMIConverter.green = 0xF20D;
                    break;
                case 243:
                    ArrayBMIConverter.green = 0xF30C;
                    break;
                case 244:
                    ArrayBMIConverter.green = 0xF40B;
                    break;
                case 245:
                    ArrayBMIConverter.green = 0xF50A;
                    break;
                case 246:
                    ArrayBMIConverter.green = 0xF609;
                    break;
                case 247:
                    ArrayBMIConverter.green = 0xF708;
                    break;
                case 248:
                    ArrayBMIConverter.green = 0xF807;
                    break;
                case 249:
                    ArrayBMIConverter.green = 0xF906;
                    break;
                case 250:
                    ArrayBMIConverter.green = 0xFA05;
                    break;
                case 251:
                    ArrayBMIConverter.green = 0xFB04;
                    break;
                case 252:
                    ArrayBMIConverter.green = 0xFC03;
                    break;
                case 253:
                    ArrayBMIConverter.green = 0xFD02;
                    break;
                case 254:
                    ArrayBMIConverter.green = 0xFE01;
                    break;
                case 255:
                    ArrayBMIConverter.green = 0xFF00;
                    break;
            }
        }
        #endregion

        #region Convert red HEX value to int
        public static int ConvertRed(int red)
        {
            int result = new int();
            switch (red)
            {
                case 0x000000:
                    result = 0;
                    break;
                case 0x00FF00:
                    result = 1;
                    break;
                case 0x01FE00:
                    result = 2;
                    break;
                case 0x02FD00:
                    result = 3;
                    break;
                case 0x03FC00:
                    result = 4;
                    break;
                case 0x04FB00:
                    result = 5;
                    break;
                case 0x05FA00:
                    result = 6;
                    break;
                case 0x06F900:
                    result = 7;
                    break;
                case 0x07F800:
                    result = 8;
                    break;
                case 0x08F700:
                    result = 9;
                    break;
                case 0x09F600:
                    result = 10;
                    break;
                case 0x0AF500:
                    result = 11;
                    break;
                case 0x0BF400:
                    result = 12;
                    break;
                case 0x0CF300:
                    result = 13;
                    break;
                case 0x0DF200:
                    result = 14;
                    break;
                case 0x0EF100:
                    result = 15;
                    break;
                case 0x0FF000:
                    result = 16;
                    break;
                case 0x10EF00:
                    result = 17;
                    break;
                case 0x11EE00:
                    result = 18;
                    break;
                case 0x12ED00:
                    result = 19;
                    break;
                case 0x13EC00:
                    result = 20;
                    break;
                case 0x14EB00:
                    result = 21;
                    break;
                case 0x15EA00:
                    result = 22;
                    break;
                case 0x16E900:
                    result = 23;
                    break;
                case 0x17E800:
                    result = 24;
                    break;
                case 0x18E700:
                    result = 25;
                    break;
                case 0x19E600:
                    result = 26;
                    break;
                case 0x1AE500:
                    result = 27;
                    break;
                case 0x1BE400:
                    result = 28;
                    break;
                case 0x1CE300:
                    result = 29;
                    break;
                case 0x1DE200:
                    result = 30;
                    break;
                case 0x1EE100:
                    result = 31;
                    break;
                case 0x1FE000:
                    result = 32;
                    break;
                case 0x20DF00:
                    result = 33;
                    break;
                case 0x21DE00:
                    result = 34;
                    break;
                case 0x22DD00:
                    result = 35;
                    break;
                case 0x23DC00:
                    result = 36;
                    break;
                case 0x24DB00:
                    result = 37;
                    break;
                case 0x25DA00:
                    result = 38;
                    break;
                case 0x26D900:
                    result = 39;
                    break;
                case 0x27D800:
                    result = 40;
                    break;
                case 0x28D700:
                    result = 41;
                    break;
                case 0x29D600:
                    result = 42;
                    break;
                case 0x2AD500:
                    result = 43;
                    break;
                case 0x2BD400:
                    result = 44;
                    break;
                case 0x2CD300:
                    result = 45;
                    break;
                case 0x2DD200:
                    result = 46;
                    break;
                case 0x2ED100:
                    result = 47;
                    break;
                case 0x2FD000:
                    result = 48;
                    break;
                case 0x30CF00:
                    result = 49;
                    break;
                case 0x31CE00:
                    result = 50;
                    break;
                case 0x32CD00:
                    result = 51;
                    break;
                case 0x33CC00:
                    result = 52;
                    break;
                case 0x34CB00:
                    result = 53;
                    break;
                case 0x35CA00:
                    result = 54;
                    break;
                case 0x36C900:
                    result = 55;
                    break;
                case 0x37C800:
                    result = 56;
                    break;
                case 0x38C700:
                    result = 57;
                    break;
                case 0x39C600:
                    result = 58;
                    break;
                case 0x3AC500:
                    result = 59;
                    break;
                case 0x3BC400:
                    result = 60;
                    break;
                case 0x3CC300:
                    result = 61;
                    break;
                case 0x3DC200:
                    result = 62;
                    break;
                case 0x3EC100:
                    result = 63;
                    break;
                case 0x3FC000:
                    result = 64;
                    break;
                case 0x40BF00:
                    result = 65;
                    break;
                case 0x41BE00:
                    result = 66;
                    break;
                case 0x42BD00:
                    result = 67;
                    break;
                case 0x43BC00:
                    result = 68;
                    break;
                case 0x44BB00:
                    result = 69;
                    break;
                case 0x45BA00:
                    result = 70;
                    break;
                case 0x46B900:
                    result = 71;
                    break;
                case 0x47B800:
                    result = 72;
                    break;
                case 0x48B700:
                    result = 73;
                    break;
                case 0x49B600:
                    result = 74;
                    break;
                case 0x4AB500:
                    result = 75;
                    break;
                case 0x4BB400:
                    result = 76;
                    break;
                case 0x4CB300:
                    result = 77;
                    break;
                case 0x4DB200:
                    result = 78;
                    break;
                case 0x4EB100:
                    result = 79;
                    break;
                case 0x4FB000:
                    result = 80;
                    break;
                case 0x50AF00:
                    result = 81;
                    break;
                case 0x51AE00:
                    result = 82;
                    break;
                case 0x52AD00:
                    result = 83;
                    break;
                case 0x53AC00:
                    result = 84;
                    break;
                case 0x54AB00:
                    result = 85;
                    break;
                case 0x55AA00:
                    result = 86;
                    break;
                case 0x56A900:
                    result = 87;
                    break;
                case 0x57A800:
                    result = 88;
                    break;
                case 0x58A700:
                    result = 89;
                    break;
                case 0x59A600:
                    result = 90;
                    break;
                case 0x5AA500:
                    result = 91;
                    break;
                case 0x5BA400:
                    result = 92;
                    break;
                case 0x5CA300:
                    result = 93;
                    break;
                case 0x5DA200:
                    result = 94;
                    break;
                case 0x5EA100:
                    result = 95;
                    break;
                case 0x5FA000:
                    result = 96;
                    break;
                case 0x609F00:
                    result = 97;
                    break;
                case 0x619E00:
                    result = 98;
                    break;
                case 0x629D00:
                    result = 99;
                    break;
                case 0x639C00:
                    result = 100;
                    break;
                case 0x649B00:
                    result = 101;
                    break;
                case 0x659A00:
                    result = 102;
                    break;
                case 0x669900:
                    result = 103;
                    break;
                case 0x679800:
                    result = 104;
                    break;
                case 0x689700:
                    result = 105;
                    break;
                case 0x699600:
                    result = 106;
                    break;
                case 0x6A9500:
                    result = 107;
                    break;
                case 0x6B9400:
                    result = 108;
                    break;
                case 0x6C9300:
                    result = 109;
                    break;
                case 0x6D9200:
                    result = 110;
                    break;
                case 0x6E9100:
                    result = 111;
                    break;
                case 0x6F9000:
                    result = 112;
                    break;
                case 0x708F00:
                    result = 113;
                    break;
                case 0x718E00:
                    result = 114;
                    break;
                case 0x728D00:
                    result = 115;
                    break;
                case 0x738C00:
                    result = 116;
                    break;
                case 0x748B00:
                    result = 117;
                    break;
                case 0x758A00:
                    result = 118;
                    break;
                case 0x768900:
                    result = 119;
                    break;
                case 0x778800:
                    result = 120;
                    break;
                case 0x788700:
                    result = 121;
                    break;
                case 0x798600:
                    result = 122;
                    break;
                case 0x7A8500:
                    result = 123;
                    break;
                case 0x7B8400:
                    result = 124;
                    break;
                case 0x7C8300:
                    result = 125;
                    break;
                case 0x7D8200:
                    result = 126;
                    break;
                case 0x7E8100:
                    result = 127;
                    break;
                case 0x7F8000:
                    result = 128;
                    break;
                case 0x807F00:
                    result = 129;
                    break;
                case 0x817E00:
                    result = 130;
                    break;
                case 0x827D00:
                    result = 131;
                    break;
                case 0x837C00:
                    result = 132;
                    break;
                case 0x847B00:
                    result = 133;
                    break;
                case 0x857A00:
                    result = 134;
                    break;
                case 0x867900:
                    result = 135;
                    break;
                case 0x877800:
                    result = 136;
                    break;
                case 0x887700:
                    result = 137;
                    break;
                case 0x897600:
                    result = 138;
                    break;
                case 0x8A7500:
                    result = 139;
                    break;
                case 0x8B7400:
                    result = 140;
                    break;
                case 0x8C7300:
                    result = 141;
                    break;
                case 0x8D7200:
                    result = 142;
                    break;
                case 0x8E7100:
                    result = 143;
                    break;
                case 0x8F7000:
                    result = 144;
                    break;
                case 0x906F00:
                    result = 145;
                    break;
                case 0x916E00:
                    result = 146;
                    break;
                case 0x926D00:
                    result = 147;
                    break;
                case 0x936C00:
                    result = 148;
                    break;
                case 0x946B00:
                    result = 149;
                    break;
                case 0x956A00:
                    result = 150;
                    break;
                case 0x966900:
                    result = 151;
                    break;
                case 0x976800:
                    result = 152;
                    break;
                case 0x986700:
                    result = 153;
                    break;
                case 0x996600:
                    result = 154;
                    break;
                case 0x9A6500:
                    result = 155;
                    break;
                case 0x9B6400:
                    result = 156;
                    break;
                case 0x9C6300:
                    result = 157;
                    break;
                case 0x9D6200:
                    result = 158;
                    break;
                case 0x9E6100:
                    result = 159;
                    break;
                case 0x9F6000:
                    result = 160;
                    break;
                case 0xA05F00:
                    result = 161;
                    break;
                case 0xA15E00:
                    result = 162;
                    break;
                case 0xA25D00:
                    result = 163;
                    break;
                case 0xA35C00:
                    result = 164;
                    break;
                case 0xA45B00:
                    result = 165;
                    break;
                case 0xA55A00:
                    result = 166;
                    break;
                case 0xA65900:
                    result = 167;
                    break;
                case 0xA75800:
                    result = 168;
                    break;
                case 0xA85700:
                    result = 169;
                    break;
                case 0xA95600:
                    result = 170;
                    break;
                case 0xAA5500:
                    result = 171;
                    break;
                case 0xAB5400:
                    result = 172;
                    break;
                case 0xAC5300:
                    result = 173;
                    break;
                case 0xAD5200:
                    result = 174;
                    break;
                case 0xAE5100:
                    result = 175;
                    break;
                case 0xAF5000:
                    result = 176;
                    break;
                case 0xB04F00:
                    result = 177;
                    break;
                case 0xB14E00:
                    result = 178;
                    break;
                case 0xB24D00:
                    result = 179;
                    break;
                case 0xB34C00:
                    result = 180;
                    break;
                case 0xB44B00:
                    result = 181;
                    break;
                case 0xB54A00:
                    result = 182;
                    break;
                case 0xB64900:
                    result = 183;
                    break;
                case 0xB74800:
                    result = 184;
                    break;
                case 0xB84700:
                    result = 185;
                    break;
                case 0xB94600:
                    result = 186;
                    break;
                case 0xBA4500:
                    result = 187;
                    break;
                case 0xBB4400:
                    result = 188;
                    break;
                case 0xBC4300:
                    result = 189;
                    break;
                case 0xBD4200:
                    result = 190;
                    break;
                case 0xBE4100:
                    result = 191;
                    break;
                case 0xBF4000:
                    result = 192;
                    break;
                case 0xC03F00:
                    result = 193;
                    break;
                case 0xC13E00:
                    result = 194;
                    break;
                case 0xC23D00:
                    result = 195;
                    break;
                case 0xC33C00:
                    result = 196;
                    break;
                case 0xC43B00:
                    result = 197;
                    break;
                case 0xC53A00:
                    result = 198;
                    break;
                case 0xC63900:
                    result = 199;
                    break;
                case 0xC73800:
                    result = 200;
                    break;
                case 0xC83700:
                    result = 201;
                    break;
                case 0xC93600:
                    result = 202;
                    break;
                case 0xCA3500:
                    result = 203;
                    break;
                case 0xCB3400:
                    result = 204;
                    break;
                case 0xCC3300:
                    result = 205;
                    break;
                case 0xCD3200:
                    result = 206;
                    break;
                case 0xCE3100:
                    result = 207;
                    break;
                case 0xCF3000:
                    result = 208;
                    break;
                case 0xD02F00:
                    result = 209;
                    break;
                case 0xD12E00:
                    result = 210;
                    break;
                case 0xD22D00:
                    result = 211;
                    break;
                case 0xD32C00:
                    result = 212;
                    break;
                case 0xD42B00:
                    result = 213;
                    break;
                case 0xD52A00:
                    result = 214;
                    break;
                case 0xD62900:
                    result = 215;
                    break;
                case 0xD72800:
                    result = 216;
                    break;
                case 0xD82700:
                    result = 217;
                    break;
                case 0xD92600:
                    result = 218;
                    break;
                case 0xDA2500:
                    result = 219;
                    break;
                case 0xDB6000:
                    result = 220;
                    break;
                case 0xDD2200:
                    result = 221;
                    break;
                case 0xDE2100:
                    result = 222;
                    break;
                case 0xDF2000:
                    result = 223;
                    break;
                case 0xE01F00:
                    result = 224;
                    break;
                case 0xE11E00:
                    result = 225;
                    break;
                case 0xE21D00:
                    result = 226;
                    break;
                case 0xE31C00:
                    result = 227;
                    break;
                case 0xE41B00:
                    result = 228;
                    break;
                case 0xE51A00:
                    result = 229;
                    break;
                case 0xE61900:
                    result = 230;
                    break;
                case 0xE71800:
                    result = 231;
                    break;
                case 0xE81700:
                    result = 232;
                    break;
                case 0xE91600:
                    result = 233;
                    break;
                case 0xEA1500:
                    result = 234;
                    break;
                case 0xEB1400:
                    result = 235;
                    break;
                case 0xEC1300:
                    result = 236;
                    break;
                case 0xED1200:
                    result = 237;
                    break;
                case 0xEE1100:
                    result = 238;
                    break;
                case 0xEF1000:
                    result = 239;
                    break;
                case 0xF00F00:
                    result = 240;
                    break;
                case 0xF10E00:
                    result = 241;
                    break;
                case 0xF20D00:
                    result = 242;
                    break;
                case 0xF30C00:
                    result = 243;
                    break;
                case 0xF40B00:
                    result = 244;
                    break;
                case 0xF50A00:
                    result = 245;
                    break;
                case 0xF60900:
                    result = 246;
                    break;
                case 0xF70800:
                    result = 247;
                    break;
                case 0xF80700:
                    result = 248;
                    break;
                case 0xF90600:
                    result = 249;
                    break;
                case 0xFA0500:
                    result = 250;
                    break;
                case 0xFB0400:
                    result = 251;
                    break;
                case 0xFC0300:
                    result = 252;
                    break;
                case 0xFD0200:
                    result = 253;
                    break;
                case 0xFE0100:
                    result = 254;
                    break;
                case 0xFF0000:
                    result = 255;
                    break;
            }

            return result;
        }
        #endregion

        #region Convert red int value to HEX
        public static void ConvertRedBack(int value)
        {
            switch (value)
            {
                case 0:
                    ArrayBMIConverter.red = 0x000000;
                    break;
                case 1:
                    ArrayBMIConverter.red = 0x00FF00;
                    break;
                case 2:
                    ArrayBMIConverter.red = 0x01FE00;
                    break;
                case 3:
                    ArrayBMIConverter.red = 0x02FD00;
                    break;
                case 4:
                    ArrayBMIConverter.red = 0x03FC00;
                    break;
                case 5:
                    ArrayBMIConverter.red = 0x04FB00;
                    break;
                case 6:
                    ArrayBMIConverter.red = 0x05FA00;
                    break;
                case 7:
                    ArrayBMIConverter.red = 0x06F900;
                    break;
                case 8:
                    ArrayBMIConverter.red = 0x07F800;
                    break;
                case 9:
                    ArrayBMIConverter.red = 0x08F700;
                    break;
                case 10:
                    ArrayBMIConverter.red = 0x09F600;
                    break;
                case 11:
                    ArrayBMIConverter.red = 0x0AF500;
                    break;
                case 12:
                    ArrayBMIConverter.red = 0x0BF400;
                    break;
                case 13:
                    ArrayBMIConverter.red = 0x0CF300;
                    break;
                case 14:
                    ArrayBMIConverter.red = 0x0DF200;
                    break;
                case 15:
                    ArrayBMIConverter.red = 0x0EF100;
                    break;
                case 16:
                    ArrayBMIConverter.red = 0x0FF000;
                    break;
                case 17:
                    ArrayBMIConverter.red = 0x10EF00;
                    break;
                case 18:
                    ArrayBMIConverter.red = 0x11EE00;
                    break;
                case 19:
                    ArrayBMIConverter.red = 0x12ED00;
                    break;
                case 20:
                    ArrayBMIConverter.red = 0x13EC00;
                    break;
                case 21:
                    ArrayBMIConverter.red = 0x14EB00;
                    break;
                case 22:
                    ArrayBMIConverter.red = 0x15EA00;
                    break;
                case 23:
                    ArrayBMIConverter.red = 0x16E900;
                    break;
                case 24:
                    ArrayBMIConverter.red = 0x17E800;
                    break;
                case 25:
                    ArrayBMIConverter.red = 0x18E700;
                    break;
                case 26:
                    ArrayBMIConverter.red = 0x19E600;
                    break;
                case 27:
                    ArrayBMIConverter.red = 0x1AE500;
                    break;
                case 28:
                    ArrayBMIConverter.red = 0x1BE400;
                    break;
                case 29:
                    ArrayBMIConverter.red = 0x1CE300;
                    break;
                case 30:
                    ArrayBMIConverter.red = 0x1DE200;
                    break;
                case 31:
                    ArrayBMIConverter.red = 0x1EE100;
                    break;
                case 32:
                    ArrayBMIConverter.red = 0x1FE000;
                    break;
                case 33:
                    ArrayBMIConverter.red = 0x20DF00;
                    break;
                case 34:
                    ArrayBMIConverter.red = 0x21DE00;
                    break;
                case 35:
                    ArrayBMIConverter.red = 0x22DD00;
                    break;
                case 36:
                    ArrayBMIConverter.red = 0x23DC00;
                    break;
                case 37:
                    ArrayBMIConverter.red = 0x24DB00;
                    break;
                case 38:
                    ArrayBMIConverter.red = 0x25DA00;
                    break;
                case 39:
                    ArrayBMIConverter.red = 0x26D900;
                    break;
                case 40:
                    ArrayBMIConverter.red = 0x27D800;
                    break;
                case 41:
                    ArrayBMIConverter.red = 0x28D700;
                    break;
                case 42:
                    ArrayBMIConverter.red = 0x29D600;
                    break;
                case 43:
                    ArrayBMIConverter.red = 0x2AD500;
                    break;
                case 44:
                    ArrayBMIConverter.red = 0x2BD400;
                    break;
                case 45:
                    ArrayBMIConverter.red = 0x2CD300;
                    break;
                case 46:
                    ArrayBMIConverter.red = 0x2DD200;
                    break;
                case 47:
                    ArrayBMIConverter.red = 0x2ED100;
                    break;
                case 48:
                    ArrayBMIConverter.red = 0x2FD000;
                    break;
                case 49:
                    ArrayBMIConverter.red = 0x30CF00;
                    break;
                case 50:
                    ArrayBMIConverter.red = 0x31CE00;
                    break;
                case 51:
                    ArrayBMIConverter.red = 0x32CD00;
                    break;
                case 52:
                    ArrayBMIConverter.red = 0x33CC00;
                    break;
                case 53:
                    ArrayBMIConverter.red = 0x34CB00;
                    break;
                case 54:
                    ArrayBMIConverter.red = 0x35CA00;
                    break;
                case 55:
                    ArrayBMIConverter.red = 0x36C900;
                    break;
                case 56:
                    ArrayBMIConverter.red = 0x37C800;
                    break;
                case 57:
                    ArrayBMIConverter.red = 0x38C700;
                    break;
                case 58:
                    ArrayBMIConverter.red = 0x39C600;
                    break;
                case 59:
                    ArrayBMIConverter.red = 0x3AC500;
                    break;
                case 60:
                    ArrayBMIConverter.red = 0x3BC400;
                    break;
                case 61:
                    ArrayBMIConverter.red = 0x3CC300;
                    break;
                case 62:
                    ArrayBMIConverter.red = 0x3DC200;
                    break;
                case 63:
                    ArrayBMIConverter.red = 0x3EC100;
                    break;
                case 64:
                    ArrayBMIConverter.red = 0x3FC000;
                    break;
                case 65:
                    ArrayBMIConverter.red = 0x40BF00;
                    break;
                case 66:
                    ArrayBMIConverter.red = 0x41BE00;
                    break;
                case 67:
                    ArrayBMIConverter.red = 0x42BD00;
                    break;
                case 68:
                    ArrayBMIConverter.red = 0x43BC00;
                    break;
                case 69:
                    ArrayBMIConverter.red = 0x44BB00;
                    break;
                case 70:
                    ArrayBMIConverter.red = 0x45BA00;
                    break;
                case 71:
                    ArrayBMIConverter.red = 0x46B900;
                    break;
                case 72:
                    ArrayBMIConverter.red = 0x47B800;
                    break;
                case 73:
                    ArrayBMIConverter.red = 0x48B700;
                    break;
                case 74:
                    ArrayBMIConverter.red = 0x49B600;
                    break;
                case 75:
                    ArrayBMIConverter.red = 0x4AB500;
                    break;
                case 76:
                    ArrayBMIConverter.red = 0x4BB400;
                    break;
                case 77:
                    ArrayBMIConverter.red = 0x4CB300;
                    break;
                case 78:
                    ArrayBMIConverter.red = 0x4DB200;
                    break;
                case 79:
                    ArrayBMIConverter.red = 0x4EB100;
                    break;
                case 80:
                    ArrayBMIConverter.red = 0x4FB000;
                    break;
                case 81:
                    ArrayBMIConverter.red = 0x50AF00;
                    break;
                case 82:
                    ArrayBMIConverter.red = 0x51AE00;
                    break;
                case 83:
                    ArrayBMIConverter.red = 0x52AD00;
                    break;
                case 84:
                    ArrayBMIConverter.red = 0x53AC00;
                    break;
                case 85:
                    ArrayBMIConverter.red = 0x54AB00;
                    break;
                case 86:
                    ArrayBMIConverter.red = 0x55AA00;
                    break;
                case 87:
                    ArrayBMIConverter.red = 0x56A900;
                    break;
                case 88:
                    ArrayBMIConverter.red = 0x57A800;
                    break;
                case 89:
                    ArrayBMIConverter.red = 0x58A700;
                    break;
                case 90:
                    ArrayBMIConverter.red = 0x59A600;
                    break;
                case 91:
                    ArrayBMIConverter.red = 0x5AA500;
                    break;
                case 92:
                    ArrayBMIConverter.red = 0x5BA400;
                    break;
                case 93:
                    ArrayBMIConverter.red = 0x5CA300;
                    break;
                case 94:
                    ArrayBMIConverter.red = 0x5DA200;
                    break;
                case 95:
                    ArrayBMIConverter.red = 0x5EA100;
                    break;
                case 96:
                    ArrayBMIConverter.red = 0x5FA000;
                    break;
                case 97:
                    ArrayBMIConverter.red = 0x609F00;
                    break;
                case 98:
                    ArrayBMIConverter.red = 0x619E00;
                    break;
                case 99:
                    ArrayBMIConverter.red = 0x629D00;
                    break;
                case 100:
                    ArrayBMIConverter.red = 0x639C00;
                    break;
                case 101:
                    ArrayBMIConverter.red = 0x649B00;
                    break;
                case 102:
                    ArrayBMIConverter.red = 0x659A00;
                    break;
                case 103:
                    ArrayBMIConverter.red = 0x669900;
                    break;
                case 104:
                    ArrayBMIConverter.red = 0x679800;
                    break;
                case 105:
                    ArrayBMIConverter.red = 0x689700;
                    break;
                case 106:
                    ArrayBMIConverter.red = 0x699600;
                    break;
                case 107:
                    ArrayBMIConverter.red = 0x6A9500;
                    break;
                case 108:
                    ArrayBMIConverter.red = 0x6B9400;
                    break;
                case 109:
                    ArrayBMIConverter.red = 0x6C9300;
                    break;
                case 110:
                    ArrayBMIConverter.red = 0x6D9200;
                    break;
                case 111:
                    ArrayBMIConverter.red = 0x6E9100;
                    break;
                case 112:
                    ArrayBMIConverter.red = 0x6F9000;
                    break;
                case 113:
                    ArrayBMIConverter.red = 0x708F00;
                    break;
                case 114:
                    ArrayBMIConverter.red = 0x718E00;
                    break;
                case 115:
                    ArrayBMIConverter.red = 0x728D00;
                    break;
                case 116:
                    ArrayBMIConverter.red = 0x738C00;
                    break;
                case 117:
                    ArrayBMIConverter.red = 0x748B00;
                    break;
                case 118:
                    ArrayBMIConverter.red = 0x758A00;
                    break;
                case 119:
                    ArrayBMIConverter.red = 0x768900;
                    break;
                case 120:
                    ArrayBMIConverter.red = 0x778800;
                    break;
                case 121:
                    ArrayBMIConverter.red = 0x788700;
                    break;
                case 122:
                    ArrayBMIConverter.red = 0x798600;
                    break;
                case 123:
                    ArrayBMIConverter.red = 0x7A8500;
                    break;
                case 124:
                    ArrayBMIConverter.red = 0x7B8400;
                    break;
                case 125:
                    ArrayBMIConverter.red = 0x7C8300;
                    break;
                case 126:
                    ArrayBMIConverter.red = 0x7D8200;
                    break;
                case 127:
                    ArrayBMIConverter.red = 0x7E8100;
                    break;
                case 128:
                    ArrayBMIConverter.red = 0x7F8000;
                    break;
                case 129:
                    ArrayBMIConverter.red = 0x807F00;
                    break;
                case 130:
                    ArrayBMIConverter.red = 0x817E00;
                    break;
                case 131:
                    ArrayBMIConverter.red = 0x827D00;
                    break;
                case 132:
                    ArrayBMIConverter.red = 0x837C00;
                    break;
                case 133:
                    ArrayBMIConverter.red = 0x847B00;
                    break;
                case 134:
                    ArrayBMIConverter.red = 0x857A00;
                    break;
                case 135:
                    ArrayBMIConverter.red = 0x867900;
                    break;
                case 136:
                    ArrayBMIConverter.red = 0x877800;
                    break;
                case 137:
                    ArrayBMIConverter.red = 0x887700;
                    break;
                case 138:
                    ArrayBMIConverter.red = 0x897600;
                    break;
                case 139:
                    ArrayBMIConverter.red = 0x8A7500;
                    break;
                case 140:
                    ArrayBMIConverter.red = 0x8B7400;
                    break;
                case 141:
                    ArrayBMIConverter.red = 0x8C7300;
                    break;
                case 142:
                    ArrayBMIConverter.red = 0x8D7200;
                    break;
                case 143:
                    ArrayBMIConverter.red = 0x8E7100;
                    break;
                case 144:
                    ArrayBMIConverter.red = 0x8F7000;
                    break;
                case 145:
                    ArrayBMIConverter.red = 0x906F00;
                    break;
                case 146:
                    ArrayBMIConverter.red = 0x916E00;
                    break;
                case 147:
                    ArrayBMIConverter.red = 0x926D00;
                    break;
                case 148:
                    ArrayBMIConverter.red = 0x936C00;
                    break;
                case 149:
                    ArrayBMIConverter.red = 0x946B00;
                    break;
                case 150:
                    ArrayBMIConverter.red = 0x956A00;
                    break;
                case 151:
                    ArrayBMIConverter.red = 0x966900;
                    break;
                case 152:
                    ArrayBMIConverter.red = 0x976800;
                    break;
                case 153:
                    ArrayBMIConverter.red = 0x986700;
                    break;
                case 154:
                    ArrayBMIConverter.red = 0x996600;
                    break;
                case 155:
                    ArrayBMIConverter.red = 0x9A6500;
                    break;
                case 156:
                    ArrayBMIConverter.red = 0x9B6400;
                    break;
                case 157:
                    ArrayBMIConverter.red = 0x9C6300;
                    break;
                case 158:
                    ArrayBMIConverter.red = 0x9D6200;
                    break;
                case 159:
                    ArrayBMIConverter.red = 0x9E6100;
                    break;
                case 160:
                    ArrayBMIConverter.red = 0x9F6000;
                    break;
                case 161:
                    ArrayBMIConverter.red = 0xA05F00;
                    break;
                case 162:
                    ArrayBMIConverter.red = 0xA15E00;
                    break;
                case 163:
                    ArrayBMIConverter.red = 0xA25D00;
                    break;
                case 164:
                    ArrayBMIConverter.red = 0xA35C00;
                    break;
                case 165:
                    ArrayBMIConverter.red = 0xA45B00;
                    break;
                case 166:
                    ArrayBMIConverter.red = 0xA55A00;
                    break;
                case 167:
                    ArrayBMIConverter.red = 0xA65900;
                    break;
                case 168:
                    ArrayBMIConverter.red = 0xA75800;
                    break;
                case 169:
                    ArrayBMIConverter.red = 0xA85700;
                    break;
                case 170:
                    ArrayBMIConverter.red = 0xA95600;
                    break;
                case 171:
                    ArrayBMIConverter.red = 0xAA5500;
                    break;
                case 172:
                    ArrayBMIConverter.red = 0xAB5400;
                    break;
                case 173:
                    ArrayBMIConverter.red = 0xAC5300;
                    break;
                case 174:
                    ArrayBMIConverter.red = 0xAD5200;
                    break;
                case 175:
                    ArrayBMIConverter.red = 0xAE5100;
                    break;
                case 176:
                    ArrayBMIConverter.red = 0xAF5000;
                    break;
                case 177:
                    ArrayBMIConverter.red = 0xB04F00;
                    break;
                case 178:
                    ArrayBMIConverter.red = 0xB14E00;
                    break;
                case 179:
                    ArrayBMIConverter.red = 0xB24D00;
                    break;
                case 180:
                    ArrayBMIConverter.red = 0xB34C00;
                    break;
                case 181:
                    ArrayBMIConverter.red = 0xB44B00;
                    break;
                case 182:
                    ArrayBMIConverter.red = 0xB54A00;
                    break;
                case 183:
                    ArrayBMIConverter.red = 0xB64900;
                    break;
                case 184:
                    ArrayBMIConverter.red = 0xB74800;
                    break;
                case 185:
                    ArrayBMIConverter.red = 0xB84700;
                    break;
                case 186:
                    ArrayBMIConverter.red = 0xB94600;
                    break;
                case 187:
                    ArrayBMIConverter.red = 0xBA4500;
                    break;
                case 188:
                    ArrayBMIConverter.red = 0xBB4400;
                    break;
                case 189:
                    ArrayBMIConverter.red = 0xBC4300;
                    break;
                case 190:
                    ArrayBMIConverter.red = 0xBD4200;
                    break;
                case 191:
                    ArrayBMIConverter.red = 0xBE4100;
                    break;
                case 192:
                    ArrayBMIConverter.red = 0xBF4000;
                    break;
                case 193:
                    ArrayBMIConverter.red = 0xC03F00;
                    break;
                case 194:
                    ArrayBMIConverter.red = 0xC13E00;
                    break;
                case 195:
                    ArrayBMIConverter.red = 0xC23D00;
                    break;
                case 196:
                    ArrayBMIConverter.red = 0xC33C00;
                    break;
                case 197:
                    ArrayBMIConverter.red = 0xC43B00;
                    break;
                case 198:
                    ArrayBMIConverter.red = 0xC53A00;
                    break;
                case 199:
                    ArrayBMIConverter.red = 0xC63900;
                    break;
                case 200:
                    ArrayBMIConverter.red = 0xC73800;
                    break;
                case 201:
                    ArrayBMIConverter.red = 0xC83700;
                    break;
                case 202:
                    ArrayBMIConverter.red = 0xC93600;
                    break;
                case 203:
                    ArrayBMIConverter.red = 0xCA3500;
                    break;
                case 204:
                    ArrayBMIConverter.red = 0xCB3400;
                    break;
                case 205:
                    ArrayBMIConverter.red = 0xCC3300;
                    break;
                case 206:
                    ArrayBMIConverter.red = 0xCD3200;
                    break;
                case 207:
                    ArrayBMIConverter.red = 0xCE3100;
                    break;
                case 208:
                    ArrayBMIConverter.red = 0xCF3000;
                    break;
                case 209:
                    ArrayBMIConverter.red = 0xD02F00;
                    break;
                case 210:
                    ArrayBMIConverter.red = 0xD12E00;
                    break;
                case 211:
                    ArrayBMIConverter.red = 0xD22D00;
                    break;
                case 212:
                    ArrayBMIConverter.red = 0xD32C00;
                    break;
                case 213:
                    ArrayBMIConverter.red = 0xD42B00;
                    break;
                case 214:
                    ArrayBMIConverter.red = 0xD52A00;
                    break;
                case 215:
                    ArrayBMIConverter.red = 0xD62900;
                    break;
                case 216:
                    ArrayBMIConverter.red = 0xD72800;
                    break;
                case 217:
                    ArrayBMIConverter.red = 0xD82700;
                    break;
                case 218:
                    ArrayBMIConverter.red = 0xD92600;
                    break;
                case 219:
                    ArrayBMIConverter.red = 0xDA2500;
                    break;
                case 220:
                    ArrayBMIConverter.red = 0xDB6000;
                    break;
                case 221:
                    ArrayBMIConverter.red = 0xDD2200;
                    break;
                case 222:
                    ArrayBMIConverter.red = 0xDE2100;
                    break;
                case 223:
                    ArrayBMIConverter.red = 0xDF2000;
                    break;
                case 224:
                    ArrayBMIConverter.red = 0xE01F00;
                    break;
                case 225:
                    ArrayBMIConverter.red = 0xE11E00;
                    break;
                case 226:
                    ArrayBMIConverter.red = 0xE21D00;
                    break;
                case 227:
                    ArrayBMIConverter.red = 0xE31C00;
                    break;
                case 228:
                    ArrayBMIConverter.red = 0xE41B00;
                    break;
                case 229:
                    ArrayBMIConverter.red = 0xE51A00;
                    break;
                case 230:
                    ArrayBMIConverter.red = 0xE61900;
                    break;
                case 231:
                    ArrayBMIConverter.red = 0xE71800;
                    break;
                case 232:
                    ArrayBMIConverter.red = 0xE81700;
                    break;
                case 233:
                    ArrayBMIConverter.red = 0xE91600;
                    break;
                case 234:
                    ArrayBMIConverter.red = 0xEA1500;
                    break;
                case 235:
                    ArrayBMIConverter.red = 0xEB1400;
                    break;
                case 236:
                    ArrayBMIConverter.red = 0xEC1300;
                    break;
                case 237:
                    ArrayBMIConverter.red = 0xED1200;
                    break;
                case 238:
                    ArrayBMIConverter.red = 0xEE1100;
                    break;
                case 239:
                    ArrayBMIConverter.red = 0xEF1000;
                    break;
                case 240:
                    ArrayBMIConverter.red = 0xF00F00;
                    break;
                case 241:
                    ArrayBMIConverter.red = 0xF10E00;
                    break;
                case 242:
                    ArrayBMIConverter.red = 0xF20D00;
                    break;
                case 243:
                    ArrayBMIConverter.red = 0xF30C00;
                    break;
                case 244:
                    ArrayBMIConverter.red = 0xF40B00;
                    break;
                case 245:
                    ArrayBMIConverter.red = 0xF50A00;
                    break;
                case 246:
                    ArrayBMIConverter.red = 0xF60900;
                    break;
                case 247:
                    ArrayBMIConverter.red = 0xF70800;
                    break;
                case 248:
                    ArrayBMIConverter.red = 0xF80700;
                    break;
                case 249:
                    ArrayBMIConverter.red = 0xF90600;
                    break;
                case 250:
                    ArrayBMIConverter.red = 0xFA0500;
                    break;
                case 251:
                    ArrayBMIConverter.red = 0xFB0400;
                    break;
                case 252:
                    ArrayBMIConverter.red = 0xFC0300;
                    break;
                case 253:
                    ArrayBMIConverter.red = 0xFD0200;
                    break;
                case 254:
                    ArrayBMIConverter.red = 0xFE0100;
                    break;
                case 255:
                    ArrayBMIConverter.red = 0xFF0000;
                    break;
            }
        }
        #endregion
    }
}
