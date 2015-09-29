using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn6
{
    class Predict_Left
    {
        /**C# deployment code of Neural Networks Model**/

        public static string[] MLP_128_6_2(string[] CatInputs)
        {

            //"Input Variable" comment is added besides Input(Response) variables.


            int Cat_idx = 0;

            string Var4 = CatInputs[Cat_idx++]; //Input Variable

            string Var5 = CatInputs[Cat_idx++]; //Input Variable

            string Var6 = CatInputs[Cat_idx++]; //Input Variable

            string Var7 = CatInputs[Cat_idx++]; //Input Variable

            string Var8 = CatInputs[Cat_idx++]; //Input Variable

            string Var9 = CatInputs[Cat_idx++]; //Input Variable

            string Var10 = CatInputs[Cat_idx++]; //Input Variable

            string Var11 = CatInputs[Cat_idx++]; //Input Variable

            string Var12 = CatInputs[Cat_idx++]; //Input Variable

            string Var13 = CatInputs[Cat_idx++]; //Input Variable

            string Var14 = CatInputs[Cat_idx++]; //Input Variable

            string Var15 = CatInputs[Cat_idx++]; //Input Variable

            string Var16 = CatInputs[Cat_idx++]; //Input Variable

            string Var17 = CatInputs[Cat_idx++]; //Input Variable

            string Var19 = CatInputs[Cat_idx++]; //Input Variable

            string Var20 = CatInputs[Cat_idx++]; //Input Variable

            string Var21 = CatInputs[Cat_idx++]; //Input Variable

            string Var22 = CatInputs[Cat_idx++]; //Input Variable

            string Var23 = CatInputs[Cat_idx++]; //Input Variable

            string Var24 = CatInputs[Cat_idx++]; //Input Variable

            string Var25 = CatInputs[Cat_idx++]; //Input Variable

            string Var26 = CatInputs[Cat_idx++]; //Input Variable

            string Var27 = CatInputs[Cat_idx++]; //Input Variable

            string Var28 = CatInputs[Cat_idx++]; //Input Variable

            string Var29 = CatInputs[Cat_idx++]; //Input Variable

            string Var30 = CatInputs[Cat_idx++]; //Input Variable

            string __statist_PredCat = "";

            string[] __statist_DCats = new string[2];

            __statist_DCats[0] = "0";

            __statist_DCats[1] = "4";



            double __statist_ConfLevel = 3.0E-300;







            double[,] __statist_i_h_wts = new double[6, 128];



            __statist_i_h_wts[0, 0] = -1.15552251839365e+000;

            __statist_i_h_wts[0, 1] = -1.50671639862539e-001;

            __statist_i_h_wts[0, 2] = 7.49849685107126e-001;

            __statist_i_h_wts[0, 3] = -1.76359294477658e+000;

            __statist_i_h_wts[0, 4] = 9.27006447554904e-001;

            __statist_i_h_wts[0, 5] = -6.39022586884801e-001;

            __statist_i_h_wts[0, 6] = -1.76569230743374e+000;

            __statist_i_h_wts[0, 7] = 2.79525023312784e-001;

            __statist_i_h_wts[0, 8] = 4.93559997075695e-001;

            __statist_i_h_wts[0, 9] = 1.73941986013791e+000;

            __statist_i_h_wts[0, 10] = -6.40768853505951e-001;

            __statist_i_h_wts[0, 11] = -7.23808329629017e-002;

            __statist_i_h_wts[0, 12] = -2.77412125602649e-001;

            __statist_i_h_wts[0, 13] = -1.57746650729587e+000;

            __statist_i_h_wts[0, 14] = -7.04843827555299e-002;

            __statist_i_h_wts[0, 15] = 3.02192607038582e-003;

            __statist_i_h_wts[0, 16] = 2.92412685628283e-001;

            __statist_i_h_wts[0, 17] = 1.37575049569953e+000;

            __statist_i_h_wts[0, 18] = -1.44803923870156e+000;

            __statist_i_h_wts[0, 19] = -2.94611407766411e-001;

            __statist_i_h_wts[0, 20] = 5.81231653137391e-001;

            __statist_i_h_wts[0, 21] = 2.75615580600862e-001;

            __statist_i_h_wts[0, 22] = -1.39688910755384e-001;

            __statist_i_h_wts[0, 23] = 1.88835951080965e-001;

            __statist_i_h_wts[0, 24] = -3.77279585202315e-001;

            __statist_i_h_wts[0, 25] = -8.35802469087682e-004;

            __statist_i_h_wts[0, 26] = 2.20030599776591e+000;

            __statist_i_h_wts[0, 27] = -1.71514391961372e+000;

            __statist_i_h_wts[0, 28] = 1.79624036229795e+000;

            __statist_i_h_wts[0, 29] = -3.33949076787345e-001;

            __statist_i_h_wts[0, 30] = 1.14589925174719e-001;

            __statist_i_h_wts[0, 31] = -5.75666517656955e-001;

            __statist_i_h_wts[0, 32] = -7.42534554096618e-001;

            __statist_i_h_wts[0, 33] = 4.24295698382551e-002;

            __statist_i_h_wts[0, 34] = -1.73572954840936e-001;

            __statist_i_h_wts[0, 35] = -3.04546732173414e-002;

            __statist_i_h_wts[0, 36] = 1.64320844528462e-003;

            __statist_i_h_wts[0, 37] = 8.61871929657614e-001;

            __statist_i_h_wts[0, 38] = 3.16329842619116e-001;

            __statist_i_h_wts[0, 39] = 1.87899073257690e-002;

            __statist_i_h_wts[0, 40] = 1.00974999107713e+000;

            __statist_i_h_wts[0, 41] = 1.08544265672625e+000;

            __statist_i_h_wts[0, 42] = 9.84279364695498e-001;

            __statist_i_h_wts[0, 43] = 1.42502760149863e-002;

            __statist_i_h_wts[0, 44] = 1.69980010664447e-003;

            __statist_i_h_wts[0, 45] = -1.17777521874415e+000;

            __statist_i_h_wts[0, 46] = 1.70202386782776e-001;

            __statist_i_h_wts[0, 47] = 1.50093304883492e-002;

            __statist_i_h_wts[0, 48] = 4.64568983782082e-001;

            __statist_i_h_wts[0, 49] = -3.00681169729310e-001;

            __statist_i_h_wts[0, 50] = -6.50669999343116e-002;

            __statist_i_h_wts[0, 51] = -6.99052535203477e-001;

            __statist_i_h_wts[0, 52] = 1.48479517277043e+000;

            __statist_i_h_wts[0, 53] = 1.02945760455750e+000;

            __statist_i_h_wts[0, 54] = -8.76637004590709e-001;

            __statist_i_h_wts[0, 55] = -5.90538705829816e-001;

            __statist_i_h_wts[0, 56] = -2.69340160292854e-001;

            __statist_i_h_wts[0, 57] = 4.07451267410740e-001;

            __statist_i_h_wts[0, 58] = 3.30653721444070e-001;

            __statist_i_h_wts[0, 59] = 1.54821722635148e+000;

            __statist_i_h_wts[0, 60] = 2.60522130415791e-001;

            __statist_i_h_wts[0, 61] = -1.35222105508196e+000;

            __statist_i_h_wts[0, 62] = -2.59613356169426e-001;

            __statist_i_h_wts[0, 63] = -6.16643958699050e-001;

            __statist_i_h_wts[0, 64] = 1.37424623896319e+000;

            __statist_i_h_wts[0, 65] = -1.97881462804624e-001;

            __statist_i_h_wts[0, 66] = -4.06730413297156e-001;

            __statist_i_h_wts[0, 67] = 1.05158086536291e+000;

            __statist_i_h_wts[0, 68] = -1.37059297021598e+000;

            __statist_i_h_wts[0, 69] = -1.69819216647767e-001;

            __statist_i_h_wts[0, 70] = 2.00826067627919e+000;

            __statist_i_h_wts[0, 71] = 1.20380304149654e+000;

            __statist_i_h_wts[0, 72] = 1.46355483297431e+000;

            __statist_i_h_wts[0, 73] = -2.20614595533981e+000;

            __statist_i_h_wts[0, 74] = 2.76828393498638e-001;

            __statist_i_h_wts[0, 75] = 1.56851828625050e+000;

            __statist_i_h_wts[0, 76] = -1.40066361515520e+000;

            __statist_i_h_wts[0, 77] = -2.46412488289583e+000;

            __statist_i_h_wts[0, 78] = -7.06420152719014e-001;

            __statist_i_h_wts[0, 79] = 3.63762212635063e+000;

            __statist_i_h_wts[0, 80] = -1.28132408339056e+000;

            __statist_i_h_wts[0, 81] = -7.94480394896427e-001;

            __statist_i_h_wts[0, 82] = 2.54513358343006e+000;

            __statist_i_h_wts[0, 83] = 2.53226204170469e-001;

            __statist_i_h_wts[0, 84] = -1.75873297064670e+000;

            __statist_i_h_wts[0, 85] = 1.98855634127584e+000;

            __statist_i_h_wts[0, 86] = 2.40635677048573e+000;

            __statist_i_h_wts[0, 87] = 4.06719015769095e+000;

            __statist_i_h_wts[0, 88] = -6.01041773943032e+000;

            __statist_i_h_wts[0, 89] = 8.71123383173902e+000;

            __statist_i_h_wts[0, 90] = 2.39514709534718e-001;

            __statist_i_h_wts[0, 91] = -8.48550546019805e+000;

            __statist_i_h_wts[0, 92] = -2.29509330937408e+000;

            __statist_i_h_wts[0, 93] = -2.20129391988076e+000;

            __statist_i_h_wts[0, 94] = 4.98477874505730e+000;

            __statist_i_h_wts[0, 95] = -2.06836389507504e+000;

            __statist_i_h_wts[0, 96] = -1.54629875330791e+000;

            __statist_i_h_wts[0, 97] = 4.07867480961360e+000;

            __statist_i_h_wts[0, 98] = 1.99085634130257e-001;

            __statist_i_h_wts[0, 99] = 6.28664161923926e-001;

            __statist_i_h_wts[0, 100] = -3.77446244564680e-001;

            __statist_i_h_wts[0, 101] = 1.33599020364978e+000;

            __statist_i_h_wts[0, 102] = 2.01474709932194e-001;

            __statist_i_h_wts[0, 103] = -1.10390393544878e+000;

            __statist_i_h_wts[0, 104] = -1.13440102629530e+000;

            __statist_i_h_wts[0, 105] = -1.15104622190461e+000;

            __statist_i_h_wts[0, 106] = 2.73778839361310e+000;

            __statist_i_h_wts[0, 107] = -1.08824070449711e+000;

            __statist_i_h_wts[0, 108] = -8.86154698851453e-001;

            __statist_i_h_wts[0, 109] = 2.44122446089179e+000;

            __statist_i_h_wts[0, 110] = -5.57257040093350e-001;

            __statist_i_h_wts[0, 111] = -1.41238033053234e+000;

            __statist_i_h_wts[0, 112] = 2.42413010352368e+000;

            __statist_i_h_wts[0, 113] = 5.79163795306140e-001;

            __statist_i_h_wts[0, 114] = 1.18070072861214e+000;

            __statist_i_h_wts[0, 115] = -1.30478510011408e+000;

            __statist_i_h_wts[0, 116] = 5.15799292264213e-001;

            __statist_i_h_wts[0, 117] = 1.22174984005132e+000;

            __statist_i_h_wts[0, 118] = -1.27371031680373e+000;

            __statist_i_h_wts[0, 119] = -1.17432432319047e+000;

            __statist_i_h_wts[0, 120] = -1.41057153913975e+000;

            __statist_i_h_wts[0, 121] = 3.04104291222164e+000;

            __statist_i_h_wts[0, 122] = 1.74318519099105e-002;

            __statist_i_h_wts[0, 123] = -7.74935313236906e-001;

            __statist_i_h_wts[0, 124] = 1.20746564382745e+000;

            __statist_i_h_wts[0, 125] = -8.88220265463040e-001;

            __statist_i_h_wts[0, 126] = 5.80165557719202e-001;

            __statist_i_h_wts[0, 127] = 7.78003578984016e-001;



            __statist_i_h_wts[1, 0] = -6.46018544469304e-001;

            __statist_i_h_wts[1, 1] = -3.59658634103723e-001;

            __statist_i_h_wts[1, 2] = 8.87176743226077e-001;

            __statist_i_h_wts[1, 3] = -1.02941681634354e+000;

            __statist_i_h_wts[1, 4] = 8.77354686128104e-001;

            __statist_i_h_wts[1, 5] = -1.49593904386710e+000;

            __statist_i_h_wts[1, 6] = -1.07000715314572e+000;

            __statist_i_h_wts[1, 7] = -9.80870552259694e-002;

            __statist_i_h_wts[1, 8] = -5.85415690114900e-001;

            __statist_i_h_wts[1, 9] = 8.91230255040755e-001;

            __statist_i_h_wts[1, 10] = -1.11943372510410e+000;

            __statist_i_h_wts[1, 11] = -1.01025955479522e-001;

            __statist_i_h_wts[1, 12] = 1.17130626544302e-001;

            __statist_i_h_wts[1, 13] = -1.52325548876971e+000;

            __statist_i_h_wts[1, 14] = -4.26010350099912e-002;

            __statist_i_h_wts[1, 15] = 7.27008411015313e-001;

            __statist_i_h_wts[1, 16] = 5.84599731546604e-001;

            __statist_i_h_wts[1, 17] = 1.29062643394942e+000;

            __statist_i_h_wts[1, 18] = -1.31377228433972e+000;

            __statist_i_h_wts[1, 19] = -1.64857438419160e-001;

            __statist_i_h_wts[1, 20] = 4.33509383657021e-001;

            __statist_i_h_wts[1, 21] = -5.39524235487210e-002;

            __statist_i_h_wts[1, 22] = 4.47515682120359e-001;

            __statist_i_h_wts[1, 23] = 1.13688716392023e+000;

            __statist_i_h_wts[1, 24] = -2.03847554077581e-001;

            __statist_i_h_wts[1, 25] = 1.08732600459533e-001;

            __statist_i_h_wts[1, 26] = 1.11042123619256e+000;

            __statist_i_h_wts[1, 27] = -5.33767560453435e-001;

            __statist_i_h_wts[1, 28] = 7.20978814972899e-001;

            __statist_i_h_wts[1, 29] = -2.60283654808163e-001;

            __statist_i_h_wts[1, 30] = 1.36779541467845e-001;

            __statist_i_h_wts[1, 31] = 9.45407881923167e-002;

            __statist_i_h_wts[1, 32] = -9.45152531487256e-001;

            __statist_i_h_wts[1, 33] = -3.63564327137946e-002;

            __statist_i_h_wts[1, 34] = 4.26745847783962e-001;

            __statist_i_h_wts[1, 35] = 6.64738922889868e-001;

            __statist_i_h_wts[1, 36] = -8.84333978747152e-003;

            __statist_i_h_wts[1, 37] = 1.31557326948452e-001;

            __statist_i_h_wts[1, 38] = 6.06750219608229e-001;

            __statist_i_h_wts[1, 39] = 4.47291677616111e-001;

            __statist_i_h_wts[1, 40] = -4.30740066759968e-001;

            __statist_i_h_wts[1, 41] = 5.84496588829896e-001;

            __statist_i_h_wts[1, 42] = 2.12494861133484e+000;

            __statist_i_h_wts[1, 43] = -4.49537525869504e-001;

            __statist_i_h_wts[1, 44] = -6.78651538554018e-002;

            __statist_i_h_wts[1, 45] = -2.81987641174300e-002;

            __statist_i_h_wts[1, 46] = 2.20782625019023e-001;

            __statist_i_h_wts[1, 47] = -4.80399857425159e-003;

            __statist_i_h_wts[1, 48] = -1.07991782667423e-001;

            __statist_i_h_wts[1, 49] = 1.25020173397723e-001;

            __statist_i_h_wts[1, 50] = -1.11558265254566e+000;

            __statist_i_h_wts[1, 51] = -6.07803544258301e-001;

            __statist_i_h_wts[1, 52] = 2.67181117331177e+000;

            __statist_i_h_wts[1, 53] = 9.77525706787331e-001;

            __statist_i_h_wts[1, 54] = -2.38286961553517e+000;

            __statist_i_h_wts[1, 55] = -9.72519946727001e-001;

            __statist_i_h_wts[1, 56] = 4.12539809913251e-001;

            __statist_i_h_wts[1, 57] = 8.85354658266274e-002;

            __statist_i_h_wts[1, 58] = -1.17023438485996e-001;

            __statist_i_h_wts[1, 59] = 1.87022439501828e+000;

            __statist_i_h_wts[1, 60] = 2.65328199217380e-001;

            __statist_i_h_wts[1, 61] = -1.76933722270759e+000;

            __statist_i_h_wts[1, 62] = -5.94787540998366e-001;

            __statist_i_h_wts[1, 63] = 3.00747450255409e-001;

            __statist_i_h_wts[1, 64] = 6.51946603728839e-001;

            __statist_i_h_wts[1, 65] = 2.77364909686083e-001;

            __statist_i_h_wts[1, 66] = -7.38523432136405e-001;

            __statist_i_h_wts[1, 67] = 8.22419900108112e-001;

            __statist_i_h_wts[1, 68] = 2.41731940158432e-001;

            __statist_i_h_wts[1, 69] = -2.12657704426138e+000;

            __statist_i_h_wts[1, 70] = 2.23989533391600e+000;

            __statist_i_h_wts[1, 71] = 2.86989160483822e+000;

            __statist_i_h_wts[1, 72] = 1.70421733924292e-002;

            __statist_i_h_wts[1, 73] = -2.48935595679124e+000;

            __statist_i_h_wts[1, 74] = 3.28532344903455e-001;

            __statist_i_h_wts[1, 75] = 2.24014552750930e+000;

            __statist_i_h_wts[1, 76] = -2.18700284841694e+000;

            __statist_i_h_wts[1, 77] = -2.56103841172528e+000;

            __statist_i_h_wts[1, 78] = -2.76121164061883e-001;

            __statist_i_h_wts[1, 79] = 3.22184189231480e+000;

            __statist_i_h_wts[1, 80] = -6.62712777318116e-001;

            __statist_i_h_wts[1, 81] = -6.45276568474270e-001;

            __statist_i_h_wts[1, 82] = 1.71664413518672e+000;

            __statist_i_h_wts[1, 83] = -1.81167247566945e-001;

            __statist_i_h_wts[1, 84] = -1.23701560642815e+000;

            __statist_i_h_wts[1, 85] = 1.79915422316595e+000;

            __statist_i_h_wts[1, 86] = 4.63066416590145e+000;

            __statist_i_h_wts[1, 87] = 2.24794794215130e+000;

            __statist_i_h_wts[1, 88] = -6.53406543668934e+000;

            __statist_i_h_wts[1, 89] = 9.47107612530876e+000;

            __statist_i_h_wts[1, 90] = 1.35349843314471e+000;

            __statist_i_h_wts[1, 91] = -1.04508147015581e+001;

            __statist_i_h_wts[1, 92] = -2.52032729511544e+000;

            __statist_i_h_wts[1, 93] = -1.41294492088245e+000;

            __statist_i_h_wts[1, 94] = 4.31170429397972e+000;

            __statist_i_h_wts[1, 95] = -2.30365902212418e+000;

            __statist_i_h_wts[1, 96] = -1.08370090071563e+000;

            __statist_i_h_wts[1, 97] = 3.77272119128290e+000;

            __statist_i_h_wts[1, 98] = 1.07303180295217e+000;

            __statist_i_h_wts[1, 99] = -4.83467688322015e-001;

            __statist_i_h_wts[1, 100] = -2.27536251310037e-001;

            __statist_i_h_wts[1, 101] = -8.44820302821299e-001;

            __statist_i_h_wts[1, 102] = 1.98015370685635e+000;

            __statist_i_h_wts[1, 103] = -7.65244102064196e-001;

            __statist_i_h_wts[1, 104] = -3.00822109891563e+000;

            __statist_i_h_wts[1, 105] = 4.18737559847175e-001;

            __statist_i_h_wts[1, 106] = 2.93686585301237e+000;

            __statist_i_h_wts[1, 107] = -1.44685970978980e+000;

            __statist_i_h_wts[1, 108] = -2.91067915143151e-001;

            __statist_i_h_wts[1, 109] = 2.12114828565891e+000;

            __statist_i_h_wts[1, 110] = -6.71294736964335e-001;

            __statist_i_h_wts[1, 111] = -1.33176930534625e+000;

            __statist_i_h_wts[1, 112] = 2.34303964951543e+000;

            __statist_i_h_wts[1, 113] = 1.69493428706599e+000;

            __statist_i_h_wts[1, 114] = 5.74467199259573e-002;

            __statist_i_h_wts[1, 115] = -1.37362745068364e+000;

            __statist_i_h_wts[1, 116] = 9.20707939445872e-001;

            __statist_i_h_wts[1, 117] = 6.25162478794564e-001;

            __statist_i_h_wts[1, 118] = -1.17791149646012e+000;

            __statist_i_h_wts[1, 119] = -4.04469669942287e-001;

            __statist_i_h_wts[1, 120] = -1.80697910140854e+000;

            __statist_i_h_wts[1, 121] = 2.57350918564724e+000;

            __statist_i_h_wts[1, 122] = 1.11483888298635e-001;

            __statist_i_h_wts[1, 123] = -4.63225305247977e-001;

            __statist_i_h_wts[1, 124] = 7.28738787580240e-001;

            __statist_i_h_wts[1, 125] = -7.90005614908871e-001;

            __statist_i_h_wts[1, 126] = 3.26007506136103e-001;

            __statist_i_h_wts[1, 127] = 8.55571041474478e-001;



            __statist_i_h_wts[2, 0] = -4.09437752556013e-001;

            __statist_i_h_wts[2, 1] = -8.76240657961297e-001;

            __statist_i_h_wts[2, 2] = 6.69870777108944e-001;

            __statist_i_h_wts[2, 3] = -1.30304374639572e+000;

            __statist_i_h_wts[2, 4] = 6.09331501228026e-001;

            __statist_i_h_wts[2, 5] = -8.03906730578588e-001;

            __statist_i_h_wts[2, 6] = -4.60785194717761e-001;

            __statist_i_h_wts[2, 7] = -2.09413151646013e-001;

            __statist_i_h_wts[2, 8] = -4.25606685547960e-002;

            __statist_i_h_wts[2, 9] = 9.26728488844853e-001;

            __statist_i_h_wts[2, 10] = -5.63345849053103e-001;

            __statist_i_h_wts[2, 11] = 1.61212964870109e-001;

            __statist_i_h_wts[2, 12] = 1.26070652720074e-002;

            __statist_i_h_wts[2, 13] = -5.86978223867256e-001;

            __statist_i_h_wts[2, 14] = -3.11464323806068e-002;

            __statist_i_h_wts[2, 15] = 7.67941592801207e-001;

            __statist_i_h_wts[2, 16] = 2.89948255629012e-001;

            __statist_i_h_wts[2, 17] = 6.51653224008596e-001;

            __statist_i_h_wts[2, 18] = -4.75697401874756e-001;

            __statist_i_h_wts[2, 19] = -2.51156213095622e-001;

            __statist_i_h_wts[2, 20] = 5.81347146617750e-001;

            __statist_i_h_wts[2, 21] = 5.75892973265541e-001;

            __statist_i_h_wts[2, 22] = 6.98773751868240e-001;

            __statist_i_h_wts[2, 23] = 4.08737614104542e-001;

            __statist_i_h_wts[2, 24] = -1.91626095208713e-001;

            __statist_i_h_wts[2, 25] = -9.65114761667704e-001;

            __statist_i_h_wts[2, 26] = 7.00085031089061e-001;

            __statist_i_h_wts[2, 27] = -1.09219270685414e+000;

            __statist_i_h_wts[2, 28] = 4.66508441840642e-001;

            __statist_i_h_wts[2, 29] = 7.64236195827311e-003;

            __statist_i_h_wts[2, 30] = 3.31982963719690e-001;

            __statist_i_h_wts[2, 31] = -3.27181768468411e-001;

            __statist_i_h_wts[2, 32] = -5.29566637727683e-001;

            __statist_i_h_wts[2, 33] = 2.06768400599968e-001;

            __statist_i_h_wts[2, 34] = 8.28575362034471e-002;

            __statist_i_h_wts[2, 35] = 2.17438470848414e-001;

            __statist_i_h_wts[2, 36] = -9.25655830933354e-003;

            __statist_i_h_wts[2, 37] = 5.94616823952858e-001;

            __statist_i_h_wts[2, 38] = 8.78561213782992e-003;

            __statist_i_h_wts[2, 39] = -3.43356341877709e-001;

            __statist_i_h_wts[2, 40] = 7.55989326160117e-002;

            __statist_i_h_wts[2, 41] = 4.65693087607491e-001;

            __statist_i_h_wts[2, 42] = 2.36572638540507e-001;

            __statist_i_h_wts[2, 43] = -3.98128672978768e-001;

            __statist_i_h_wts[2, 44] = -1.57435026454043e-001;

            __statist_i_h_wts[2, 45] = -1.14014754975004e-001;

            __statist_i_h_wts[2, 46] = 1.39306379998948e-001;

            __statist_i_h_wts[2, 47] = 1.59398394558120e-002;

            __statist_i_h_wts[2, 48] = -1.13208905256880e-001;

            __statist_i_h_wts[2, 49] = -1.22293396946768e+000;

            __statist_i_h_wts[2, 50] = -7.63817216532371e-001;

            __statist_i_h_wts[2, 51] = -8.21726740087187e-001;

            __statist_i_h_wts[2, 52] = 2.37147094484286e+000;

            __statist_i_h_wts[2, 53] = 1.19754190041086e+000;

            __statist_i_h_wts[2, 54] = -3.52954288263932e-001;

            __statist_i_h_wts[2, 55] = 3.84058938837966e-002;

            __statist_i_h_wts[2, 56] = -4.40494749828965e-001;

            __statist_i_h_wts[2, 57] = 5.52982450312356e-001;

            __statist_i_h_wts[2, 58] = -4.82484154218962e-002;

            __statist_i_h_wts[2, 59] = 8.52574329295088e-001;

            __statist_i_h_wts[2, 60] = -1.19099397605471e-001;

            __statist_i_h_wts[2, 61] = -6.62112677599703e-001;

            __statist_i_h_wts[2, 62] = -1.17097383009421e+000;

            __statist_i_h_wts[2, 63] = 1.31666248434138e-001;

            __statist_i_h_wts[2, 64] = 1.12618689456252e+000;

            __statist_i_h_wts[2, 65] = 1.75765870097791e-001;

            __statist_i_h_wts[2, 66] = -6.59966304851308e-001;

            __statist_i_h_wts[2, 67] = 5.52734271757954e-001;

            __statist_i_h_wts[2, 68] = -3.49856770506845e-001;

            __statist_i_h_wts[2, 69] = -5.81954610344625e-001;

            __statist_i_h_wts[2, 70] = 1.02237506898233e+000;

            __statist_i_h_wts[2, 71] = 7.24563831013749e-001;

            __statist_i_h_wts[2, 72] = 8.25058928435139e-001;

            __statist_i_h_wts[2, 73] = -1.47992520033321e+000;

            __statist_i_h_wts[2, 74] = -2.80587124946478e-001;

            __statist_i_h_wts[2, 75] = 1.18312793696550e+000;

            __statist_i_h_wts[2, 76] = -8.00909188310059e-001;

            __statist_i_h_wts[2, 77] = -2.04088622408237e+000;

            __statist_i_h_wts[2, 78] = -2.57296799333586e-001;

            __statist_i_h_wts[2, 79] = 2.38272560534548e+000;

            __statist_i_h_wts[2, 80] = 5.94461618192940e-001;

            __statist_i_h_wts[2, 81] = -1.54421548072948e+000;

            __statist_i_h_wts[2, 82] = 1.02120852320183e+000;

            __statist_i_h_wts[2, 83] = -5.92610516501246e-001;

            __statist_i_h_wts[2, 84] = 2.38298893543351e-001;

            __statist_i_h_wts[2, 85] = 4.26161124182212e-001;

            __statist_i_h_wts[2, 86] = 4.11526349390188e+000;

            __statist_i_h_wts[2, 87] = 4.17053534377713e-001;

            __statist_i_h_wts[2, 88] = -4.45713534595233e+000;

            __statist_i_h_wts[2, 89] = 7.24358215314165e+000;

            __statist_i_h_wts[2, 90] = -5.24190184365059e-001;

            __statist_i_h_wts[2, 91] = -6.65492571402451e+000;

            __statist_i_h_wts[2, 92] = -9.86993971129383e-001;

            __statist_i_h_wts[2, 93] = -1.44132476891069e+000;

            __statist_i_h_wts[2, 94] = 2.50006769528946e+000;

            __statist_i_h_wts[2, 95] = -1.32506590169431e+000;

            __statist_i_h_wts[2, 96] = -8.22237435632098e-001;

            __statist_i_h_wts[2, 97] = 2.21582279366573e+000;

            __statist_i_h_wts[2, 98] = -1.57331882087993e-001;

            __statist_i_h_wts[2, 99] = 4.14097473575739e-001;

            __statist_i_h_wts[2, 100] = -1.85023750552659e-001;

            __statist_i_h_wts[2, 101] = -6.43042553094644e-001;

            __statist_i_h_wts[2, 102] = 6.51441675411774e-001;

            __statist_i_h_wts[2, 103] = 5.81190512424405e-002;

            __statist_i_h_wts[2, 104] = -2.68557595728059e+000;

            __statist_i_h_wts[2, 105] = 1.22372763619995e+000;

            __statist_i_h_wts[2, 106] = 1.53406007483016e+000;

            __statist_i_h_wts[2, 107] = -8.39177507320594e-001;

            __statist_i_h_wts[2, 108] = -4.40559828863934e-001;

            __statist_i_h_wts[2, 109] = 1.36424372854530e+000;

            __statist_i_h_wts[2, 110] = -1.18067576023612e+000;

            __statist_i_h_wts[2, 111] = -2.32732507267764e-001;

            __statist_i_h_wts[2, 112] = 1.48047908570632e+000;

            __statist_i_h_wts[2, 113] = 2.32646979407514e-001;

            __statist_i_h_wts[2, 114] = 6.80665560418866e-001;

            __statist_i_h_wts[2, 115] = -8.44179586343406e-001;

            __statist_i_h_wts[2, 116] = 5.37985973230719e-001;

            __statist_i_h_wts[2, 117] = 2.95118810033717e-001;

            __statist_i_h_wts[2, 118] = -7.42269864329916e-001;

            __statist_i_h_wts[2, 119] = -1.08493605594255e+000;

            __statist_i_h_wts[2, 120] = -2.65154222331310e-001;

            __statist_i_h_wts[2, 121] = 1.39603826942437e+000;

            __statist_i_h_wts[2, 122] = 2.79141437403920e-001;

            __statist_i_h_wts[2, 123] = -6.05552684079059e-001;

            __statist_i_h_wts[2, 124] = 3.89280764783200e-001;

            __statist_i_h_wts[2, 125] = -9.63645470291296e-001;

            __statist_i_h_wts[2, 126] = 9.63712445293377e-001;

            __statist_i_h_wts[2, 127] = 8.36677020935234e-002;



            __statist_i_h_wts[3, 0] = -3.16017645908797e-001;

            __statist_i_h_wts[3, 1] = -7.41641895646634e-001;

            __statist_i_h_wts[3, 2] = 4.82500542528288e-001;

            __statist_i_h_wts[3, 3] = -3.79985946133578e-001;

            __statist_i_h_wts[3, 4] = 5.08435786213313e-001;

            __statist_i_h_wts[3, 5] = -8.60891587548554e-001;

            __statist_i_h_wts[3, 6] = -4.72345094779143e-001;

            __statist_i_h_wts[3, 7] = -4.69229556185650e-001;

            __statist_i_h_wts[3, 8] = -1.11798055278737e-001;

            __statist_i_h_wts[3, 9] = 4.39469315557310e-001;

            __statist_i_h_wts[3, 10] = -8.02961351413491e-001;

            __statist_i_h_wts[3, 11] = -1.32198551023794e-001;

            __statist_i_h_wts[3, 12] = -1.16066015559837e-001;

            __statist_i_h_wts[3, 13] = -5.12163139321246e-001;

            __statist_i_h_wts[3, 14] = 2.52108087671646e-001;

            __statist_i_h_wts[3, 15] = 6.09307891845446e-001;

            __statist_i_h_wts[3, 16] = 5.43133330632266e-001;

            __statist_i_h_wts[3, 17] = 4.77930841540441e-001;

            __statist_i_h_wts[3, 18] = -8.67830891605409e-002;

            __statist_i_h_wts[3, 19] = -5.80790821598866e-003;

            __statist_i_h_wts[3, 20] = 2.52343009010016e-001;

            __statist_i_h_wts[3, 21] = 5.75190564390210e-001;

            __statist_i_h_wts[3, 22] = 4.21445745845642e-001;

            __statist_i_h_wts[3, 23] = 4.18574578335006e-001;

            __statist_i_h_wts[3, 24] = 4.74216741692705e-001;

            __statist_i_h_wts[3, 25] = -3.80709459477459e-001;

            __statist_i_h_wts[3, 26] = 1.52841209680757e-001;

            __statist_i_h_wts[3, 27] = -7.42560635215328e-001;

            __statist_i_h_wts[3, 28] = 2.18881889985789e-001;

            __statist_i_h_wts[3, 29] = -6.20518286282733e-002;

            __statist_i_h_wts[3, 30] = 1.82752912151471e-001;

            __statist_i_h_wts[3, 31] = -2.87538293313542e-001;

            __statist_i_h_wts[3, 32] = -8.53758663014047e-001;

            __statist_i_h_wts[3, 33] = -8.71687321026514e-004;

            __statist_i_h_wts[3, 34] = 5.50908724770021e-001;

            __statist_i_h_wts[3, 35] = 6.18566161967670e-001;

            __statist_i_h_wts[3, 36] = 2.70267326193738e-003;

            __statist_i_h_wts[3, 37] = 2.48229542541910e-001;

            __statist_i_h_wts[3, 38] = 3.24262133643343e-002;

            __statist_i_h_wts[3, 39] = 3.13077164200060e-001;

            __statist_i_h_wts[3, 40] = -1.02812448194006e-001;

            __statist_i_h_wts[3, 41] = 1.95586433204900e-001;

            __statist_i_h_wts[3, 42] = 1.40832091954978e-002;

            __statist_i_h_wts[3, 43] = 9.72912202178779e-002;

            __statist_i_h_wts[3, 44] = -3.71696489905539e-002;

            __statist_i_h_wts[3, 45] = -1.66398935713998e-001;

            __statist_i_h_wts[3, 46] = 1.18695545718053e-001;

            __statist_i_h_wts[3, 47] = 5.90711413679854e-003;

            __statist_i_h_wts[3, 48] = -1.29843364919872e-001;

            __statist_i_h_wts[3, 49] = -5.09433489767889e-001;

            __statist_i_h_wts[3, 50] = -1.49537549364880e+000;

            __statist_i_h_wts[3, 51] = -2.38680968583581e-001;

            __statist_i_h_wts[3, 52] = 2.49635324311496e+000;

            __statist_i_h_wts[3, 53] = 1.06200658265705e+000;

            __statist_i_h_wts[3, 54] = -1.35550476662243e+000;

            __statist_i_h_wts[3, 55] = 5.64379279622893e-001;

            __statist_i_h_wts[3, 56] = 5.65510611300001e-001;

            __statist_i_h_wts[3, 57] = 1.24305459014357e-001;

            __statist_i_h_wts[3, 58] = -2.60449583103023e-001;

            __statist_i_h_wts[3, 59] = 1.37381216775234e+000;

            __statist_i_h_wts[3, 60] = -2.46208320126497e-001;

            __statist_i_h_wts[3, 61] = -6.81307388827032e-001;

            __statist_i_h_wts[3, 62] = -4.53533360066117e-002;

            __statist_i_h_wts[3, 63] = -5.18115313597935e-001;

            __statist_i_h_wts[3, 64] = 9.77466381115856e-001;

            __statist_i_h_wts[3, 65] = 2.42420709970699e+000;

            __statist_i_h_wts[3, 66] = -2.22084869685890e+000;

            __statist_i_h_wts[3, 67] = 2.33107096789250e-001;

            __statist_i_h_wts[3, 68] = 1.60002235238178e+000;

            __statist_i_h_wts[3, 69] = -1.98036772188804e+000;

            __statist_i_h_wts[3, 70] = 8.23276852539786e-001;

            __statist_i_h_wts[3, 71] = 7.12406935699282e-001;

            __statist_i_h_wts[3, 72] = 9.49318569474534e-001;

            __statist_i_h_wts[3, 73] = -1.21868136839527e+000;

            __statist_i_h_wts[3, 74] = -6.22770708610559e-001;

            __statist_i_h_wts[3, 75] = 2.06045342441035e+000;

            __statist_i_h_wts[3, 76] = -1.01841779495393e+000;

            __statist_i_h_wts[3, 77] = -1.57692461740761e+000;

            __statist_i_h_wts[3, 78] = 7.94511205435373e-002;

            __statist_i_h_wts[3, 79] = 1.93397891566982e+000;

            __statist_i_h_wts[3, 80] = 4.68079228171064e-001;

            __statist_i_h_wts[3, 81] = -8.47627192093396e-001;

            __statist_i_h_wts[3, 82] = 8.30951047345625e-001;

            __statist_i_h_wts[3, 83] = 2.49112394956096e-001;

            __statist_i_h_wts[3, 84] = 7.87340108568931e-003;

            __statist_i_h_wts[3, 85] = 1.96009422921110e-001;

            __statist_i_h_wts[3, 86] = 5.81206234472537e+000;

            __statist_i_h_wts[3, 87] = -1.40892627736269e+000;

            __statist_i_h_wts[3, 88] = -3.98426778720280e+000;

            __statist_i_h_wts[3, 89] = 7.25375271986937e+000;

            __statist_i_h_wts[3, 90] = -5.45951578993875e-001;

            __statist_i_h_wts[3, 91] = -6.26078914793952e+000;

            __statist_i_h_wts[3, 92] = -1.04041686282130e+000;

            __statist_i_h_wts[3, 93] = -4.77511556313530e-001;

            __statist_i_h_wts[3, 94] = 1.96885731218866e+000;

            __statist_i_h_wts[3, 95] = -2.00239979498697e+000;

            __statist_i_h_wts[3, 96] = 4.34638515986888e-001;

            __statist_i_h_wts[3, 97] = 2.00077316267386e+000;

            __statist_i_h_wts[3, 98] = 5.55585791469956e-001;

            __statist_i_h_wts[3, 99] = 1.14670190999170e-001;

            __statist_i_h_wts[3, 100] = -2.45167379270629e-001;

            __statist_i_h_wts[3, 101] = -1.13602612622617e+000;

            __statist_i_h_wts[3, 102] = 1.49729427351055e+000;

            __statist_i_h_wts[3, 103] = 9.10337902813601e-002;

            __statist_i_h_wts[3, 104] = -1.98429010563045e+000;

            __statist_i_h_wts[3, 105] = 1.10867855781375e+000;

            __statist_i_h_wts[3, 106] = 1.29660466843979e+000;

            __statist_i_h_wts[3, 107] = -7.94171553041254e-001;

            __statist_i_h_wts[3, 108] = 2.92451202685940e-001;

            __statist_i_h_wts[3, 109] = 9.52642135808963e-001;

            __statist_i_h_wts[3, 110] = -2.94102269120115e-001;

            __statist_i_h_wts[3, 111] = -3.61460844331271e-001;

            __statist_i_h_wts[3, 112] = 1.10825859757191e+000;

            __statist_i_h_wts[3, 113] = 1.12458230804107e+000;

            __statist_i_h_wts[3, 114] = 2.37012573441793e-001;

            __statist_i_h_wts[3, 115] = -8.94217189358276e-001;

            __statist_i_h_wts[3, 116] = 1.10817245110173e+000;

            __statist_i_h_wts[3, 117] = -1.00528526230283e-002;

            __statist_i_h_wts[3, 118] = -6.45384062763486e-001;

            __statist_i_h_wts[3, 119] = 3.80653561368414e-001;

            __statist_i_h_wts[3, 120] = -1.15702274262415e+000;

            __statist_i_h_wts[3, 121] = 1.20469977828720e+000;

            __statist_i_h_wts[3, 122] = 1.43436582130250e-002;

            __statist_i_h_wts[3, 123] = 2.19287542441373e-001;

            __statist_i_h_wts[3, 124] = 2.10142051393847e-001;

            __statist_i_h_wts[3, 125] = -6.02248836796433e-001;

            __statist_i_h_wts[3, 126] = 7.82670049804172e-001;

            __statist_i_h_wts[3, 127] = 2.58976243249531e-001;



            __statist_i_h_wts[4, 0] = -5.20804178021411e-001;

            __statist_i_h_wts[4, 1] = -7.20931432457136e-001;

            __statist_i_h_wts[4, 2] = 5.17182020062714e-001;

            __statist_i_h_wts[4, 3] = -6.63930832370716e-001;

            __statist_i_h_wts[4, 4] = 4.33204071806812e-001;

            __statist_i_h_wts[4, 5] = -1.01073406054550e+000;

            __statist_i_h_wts[4, 6] = -6.49531882273625e-001;

            __statist_i_h_wts[4, 7] = -5.80793963845549e-001;

            __statist_i_h_wts[4, 8] = -2.49923756477075e-001;

            __statist_i_h_wts[4, 9] = 4.58637603267611e-001;

            __statist_i_h_wts[4, 10] = -9.94204754868671e-001;

            __statist_i_h_wts[4, 11] = -1.43016265196472e-001;

            __statist_i_h_wts[4, 12] = -2.08929346682907e-001;

            __statist_i_h_wts[4, 13] = -4.90551318683779e-001;

            __statist_i_h_wts[4, 14] = 1.29184352777052e-001;

            __statist_i_h_wts[4, 15] = 6.21350470853409e-001;

            __statist_i_h_wts[4, 16] = 5.26771621134118e-001;

            __statist_i_h_wts[4, 17] = 5.53679925408921e-001;

            __statist_i_h_wts[4, 18] = -4.04411818524338e-001;

            __statist_i_h_wts[4, 19] = 5.87759673807201e-002;

            __statist_i_h_wts[4, 20] = 3.84493300047474e-001;

            __statist_i_h_wts[4, 21] = 4.81594721227826e-001;

            __statist_i_h_wts[4, 22] = 3.94609254051169e-001;

            __statist_i_h_wts[4, 23] = 4.43096516565493e-001;

            __statist_i_h_wts[4, 24] = 4.36689122769415e-001;

            __statist_i_h_wts[4, 25] = -3.56782118691370e-001;

            __statist_i_h_wts[4, 26] = 1.70531392166321e-001;

            __statist_i_h_wts[4, 27] = -6.44344120062715e-001;

            __statist_i_h_wts[4, 28] = 3.19996512054111e-001;

            __statist_i_h_wts[4, 29] = -4.50725797707731e-002;

            __statist_i_h_wts[4, 30] = 1.43773313578024e-001;

            __statist_i_h_wts[4, 31] = -5.55156974381085e-001;

            __statist_i_h_wts[4, 32] = -8.10697451368990e-001;

            __statist_i_h_wts[4, 33] = 1.19260549484120e-001;

            __statist_i_h_wts[4, 34] = 5.32367360975965e-001;

            __statist_i_h_wts[4, 35] = 6.03458139637993e-001;

            __statist_i_h_wts[4, 36] = -5.23907811793785e-003;

            __statist_i_h_wts[4, 37] = 9.15516445566567e-002;

            __statist_i_h_wts[4, 38] = 2.56630501172283e-002;

            __statist_i_h_wts[4, 39] = 5.17258025672169e-001;

            __statist_i_h_wts[4, 40] = -2.88748322774055e-001;

            __statist_i_h_wts[4, 41] = 3.19131402175890e-001;

            __statist_i_h_wts[4, 42] = 1.16311349931578e-001;

            __statist_i_h_wts[4, 43] = -2.98490054200348e-001;

            __statist_i_h_wts[4, 44] = 2.04839574028366e-002;

            __statist_i_h_wts[4, 45] = -7.17676491169220e-002;

            __statist_i_h_wts[4, 46] = 1.17772782788921e-001;

            __statist_i_h_wts[4, 47] = 7.16190943585503e-003;

            __statist_i_h_wts[4, 48] = -4.07537278501589e-001;

            __statist_i_h_wts[4, 49] = -8.26042736666106e-001;

            __statist_i_h_wts[4, 50] = -1.58219065351914e+000;

            __statist_i_h_wts[4, 51] = -2.16115356997597e-001;

            __statist_i_h_wts[4, 52] = 2.11784705298756e+000;

            __statist_i_h_wts[4, 53] = 6.83748917116824e-001;

            __statist_i_h_wts[4, 54] = -1.09342761960459e+000;

            __statist_i_h_wts[4, 55] = 4.52343989556636e-001;

            __statist_i_h_wts[4, 56] = 3.21176949484138e-001;

            __statist_i_h_wts[4, 57] = -9.77283908166629e-001;

            __statist_i_h_wts[4, 58] = -3.01752057316149e-001;

            __statist_i_h_wts[4, 59] = 2.08731032747657e+000;

            __statist_i_h_wts[4, 60] = -2.10074513222314e+000;

            __statist_i_h_wts[4, 61] = -9.60315666078675e-001;

            __statist_i_h_wts[4, 62] = 7.21353917761452e-001;

            __statist_i_h_wts[4, 63] = -2.47624178566484e+000;

            __statist_i_h_wts[4, 64] = 7.62865217074828e-001;

            __statist_i_h_wts[4, 65] = 1.97550981634807e+000;

            __statist_i_h_wts[4, 66] = -2.94175216637724e+000;

            __statist_i_h_wts[4, 67] = -3.05160627006413e-003;

            __statist_i_h_wts[4, 68] = 1.01521026874756e+000;

            __statist_i_h_wts[4, 69] = -2.77824541161710e+000;

            __statist_i_h_wts[4, 70] = 7.84265215843567e-001;

            __statist_i_h_wts[4, 71] = 5.91384534712713e-002;

            __statist_i_h_wts[4, 72] = 3.14947579857404e-001;

            __statist_i_h_wts[4, 73] = -1.35422207292585e+000;

            __statist_i_h_wts[4, 74] = -5.57486727361912e-002;

            __statist_i_h_wts[4, 75] = 2.97171849097784e-001;

            __statist_i_h_wts[4, 76] = -1.23684406229524e+000;

            __statist_i_h_wts[4, 77] = -1.24002109609340e+000;

            __statist_i_h_wts[4, 78] = -1.53046966825576e+000;

            __statist_i_h_wts[4, 79] = 1.80206160691696e+000;

            __statist_i_h_wts[4, 80] = -1.28287300090632e-001;

            __statist_i_h_wts[4, 81] = -1.59740366243788e+000;

            __statist_i_h_wts[4, 82] = 7.70397986213170e-001;

            __statist_i_h_wts[4, 83] = -6.74023605763082e-001;

            __statist_i_h_wts[4, 84] = -5.74933640255516e-001;

            __statist_i_h_wts[4, 85] = 2.70643720530270e-001;

            __statist_i_h_wts[4, 86] = 4.88956188750880e+000;

            __statist_i_h_wts[4, 87] = -1.48240058586423e+000;

            __statist_i_h_wts[4, 88] = -4.38972105456281e+000;

            __statist_i_h_wts[4, 89] = 8.19744084539037e+000;

            __statist_i_h_wts[4, 90] = -2.03186017992820e+000;

            __statist_i_h_wts[4, 91] = -7.15302390284820e+000;

            __statist_i_h_wts[4, 92] = -1.86733693884749e+000;

            __statist_i_h_wts[4, 93] = -1.12965421393327e+000;

            __statist_i_h_wts[4, 94] = 2.00842390719717e+000;

            __statist_i_h_wts[4, 95] = -3.18342457727811e+000;

            __statist_i_h_wts[4, 96] = 2.55024062232310e-001;

            __statist_i_h_wts[4, 97] = 1.94586805789560e+000;

            __statist_i_h_wts[4, 98] = -4.39470346359619e-001;

            __statist_i_h_wts[4, 99] = -2.83640114989698e-001;

            __statist_i_h_wts[4, 100] = -2.58922798459971e-001;

            __statist_i_h_wts[4, 101] = -5.33453601030021e-001;

            __statist_i_h_wts[4, 102] = -3.16944998601570e-001;

            __statist_i_h_wts[4, 103] = -9.73884987802247e-002;

            __statist_i_h_wts[4, 104] = -1.62717856266577e+000;

            __statist_i_h_wts[4, 105] = -7.83560594537152e-001;

            __statist_i_h_wts[4, 106] = 1.42702730059435e+000;

            __statist_i_h_wts[4, 107] = -1.62780289450603e+000;

            __statist_i_h_wts[4, 108] = -3.32025236426892e-001;

            __statist_i_h_wts[4, 109] = 9.70959320537776e-001;

            __statist_i_h_wts[4, 110] = -1.98276030821471e+000;

            __statist_i_h_wts[4, 111] = 2.41553937846279e-002;

            __statist_i_h_wts[4, 112] = 9.53029142865634e-001;

            __statist_i_h_wts[4, 113] = 9.68304506926158e-002;

            __statist_i_h_wts[4, 114] = -1.03824831487956e-001;

            __statist_i_h_wts[4, 115] = -9.61555247004633e-001;

            __statist_i_h_wts[4, 116] = 1.26531959623676e+000;

            __statist_i_h_wts[4, 117] = -1.44047757006300e+000;

            __statist_i_h_wts[4, 118] = -7.89621813842324e-001;

            __statist_i_h_wts[4, 119] = 8.53350292340562e-001;

            __statist_i_h_wts[4, 120] = -3.08538040043510e+000;

            __statist_i_h_wts[4, 121] = 1.27648434504519e+000;

            __statist_i_h_wts[4, 122] = -3.85197775932671e-001;

            __statist_i_h_wts[4, 123] = -7.96013421854970e-001;

            __statist_i_h_wts[4, 124] = 2.19851228587489e-001;

            __statist_i_h_wts[4, 125] = -1.63698273355627e+000;

            __statist_i_h_wts[4, 126] = 4.46786074038340e-001;

            __statist_i_h_wts[4, 127] = 1.86672501847281e-001;



            __statist_i_h_wts[5, 0] = -3.03729072893758e-002;

            __statist_i_h_wts[5, 1] = -6.84618149598066e-002;

            __statist_i_h_wts[5, 2] = 2.11345214219013e-002;

            __statist_i_h_wts[5, 3] = -1.92241366830998e-001;

            __statist_i_h_wts[5, 4] = 7.83383865942008e-002;

            __statist_i_h_wts[5, 5] = -4.42433511581641e-001;

            __statist_i_h_wts[5, 6] = -2.74839760290385e-001;

            __statist_i_h_wts[5, 7] = -7.88983089174252e-002;

            __statist_i_h_wts[5, 8] = -5.77713436245446e-002;

            __statist_i_h_wts[5, 9] = 5.25123705638809e-003;

            __statist_i_h_wts[5, 10] = -2.04751937377603e-001;

            __statist_i_h_wts[5, 11] = -1.12072267743005e-002;

            __statist_i_h_wts[5, 12] = 1.14308143091236e-001;

            __statist_i_h_wts[5, 13] = -9.60736153326082e-002;

            __statist_i_h_wts[5, 14] = -2.82695886129227e-002;

            __statist_i_h_wts[5, 15] = 1.29030584432223e-001;

            __statist_i_h_wts[5, 16] = 6.24852281540116e-002;

            __statist_i_h_wts[5, 17] = 8.22299751833819e-002;

            __statist_i_h_wts[5, 18] = -7.74824704576456e-002;

            __statist_i_h_wts[5, 19] = -5.86958527426097e-002;

            __statist_i_h_wts[5, 20] = 5.65551396054943e-002;

            __statist_i_h_wts[5, 21] = 6.81076004731768e-002;

            __statist_i_h_wts[5, 22] = -1.91796730941855e-002;

            __statist_i_h_wts[5, 23] = 2.54264191638216e-002;

            __statist_i_h_wts[5, 24] = -4.15731714992008e-002;

            __statist_i_h_wts[5, 25] = -1.79395046196894e-001;

            __statist_i_h_wts[5, 26] = 3.46393867891354e-002;

            __statist_i_h_wts[5, 27] = -6.06897934417940e-002;

            __statist_i_h_wts[5, 28] = 3.30697642028435e-002;

            __statist_i_h_wts[5, 29] = -4.51676367644367e-002;

            __statist_i_h_wts[5, 30] = 2.20539311947199e-002;

            __statist_i_h_wts[5, 31] = -8.88785093907317e-003;

            __statist_i_h_wts[5, 32] = -1.00327832749564e-001;

            __statist_i_h_wts[5, 33] = 2.05083395466779e-003;

            __statist_i_h_wts[5, 34] = 9.94162615702380e-002;

            __statist_i_h_wts[5, 35] = 8.13815514222663e-002;

            __statist_i_h_wts[5, 36] = -4.19125748096596e-003;

            __statist_i_h_wts[5, 37] = 4.18688641895849e-002;

            __statist_i_h_wts[5, 38] = -5.17226203974395e-002;

            __statist_i_h_wts[5, 39] = 4.27716342955051e-002;

            __statist_i_h_wts[5, 40] = -7.33471487574388e-002;

            __statist_i_h_wts[5, 41] = 2.57271502162556e-002;

            __statist_i_h_wts[5, 42] = 3.03197091384960e-001;

            __statist_i_h_wts[5, 43] = -2.93672476083662e-001;

            __statist_i_h_wts[5, 44] = 1.06765288557469e-002;

            __statist_i_h_wts[5, 45] = -1.96018118083823e-002;

            __statist_i_h_wts[5, 46] = 8.86105355336024e-003;

            __statist_i_h_wts[5, 47] = 1.57537244281094e-002;

            __statist_i_h_wts[5, 48] = -5.46019780095945e-001;

            __statist_i_h_wts[5, 49] = -5.64272886804306e-002;

            __statist_i_h_wts[5, 50] = -5.92603184267173e-001;

            __statist_i_h_wts[5, 51] = -2.97513836308946e-001;

            __statist_i_h_wts[5, 52] = 4.76531751011540e-001;

            __statist_i_h_wts[5, 53] = 9.71207705756142e-002;

            __statist_i_h_wts[5, 54] = -2.25148722116904e-001;

            __statist_i_h_wts[5, 55] = 1.26030222120914e-001;

            __statist_i_h_wts[5, 56] = 2.43936837967445e-001;

            __statist_i_h_wts[5, 57] = -1.07109279123955e+000;

            __statist_i_h_wts[5, 58] = -2.15869690148605e-001;

            __statist_i_h_wts[5, 59] = 8.86745451586741e-001;

            __statist_i_h_wts[5, 60] = -1.72731055784216e+000;

            __statist_i_h_wts[5, 61] = -1.52966341723417e-001;

            __statist_i_h_wts[5, 62] = -1.55294332971287e+000;

            __statist_i_h_wts[5, 63] = 3.74121064228330e-001;

            __statist_i_h_wts[5, 64] = 1.58198327399037e-001;

            __statist_i_h_wts[5, 65] = -1.68065074269477e-001;

            __statist_i_h_wts[5, 66] = -8.76651288728209e-001;

            __statist_i_h_wts[5, 67] = 1.23685211233657e-002;

            __statist_i_h_wts[5, 68] = -7.74275843150294e-001;

            __statist_i_h_wts[5, 69] = -3.94665244769908e-001;

            __statist_i_h_wts[5, 70] = 1.33984502199803e-001;

            __statist_i_h_wts[5, 71] = 1.87704434000250e-001;

            __statist_i_h_wts[5, 72] = -7.43390263900373e-001;

            __statist_i_h_wts[5, 73] = -4.49469778409147e-001;

            __statist_i_h_wts[5, 74] = 4.06329363499858e-001;

            __statist_i_h_wts[5, 75] = -1.12135296585767e+000;

            __statist_i_h_wts[5, 76] = -3.29859828201125e-001;

            __statist_i_h_wts[5, 77] = -2.45489171166675e+000;

            __statist_i_h_wts[5, 78] = 1.02029976706132e+000;

            __statist_i_h_wts[5, 79] = 4.16746724725697e-001;

            __statist_i_h_wts[5, 80] = -7.09524826594759e-001;

            __statist_i_h_wts[5, 81] = -4.51570731453596e-001;

            __statist_i_h_wts[5, 82] = 1.21245901742976e-001;

            __statist_i_h_wts[5, 83] = -1.10160335359770e+000;

            __statist_i_h_wts[5, 84] = -1.20575007206226e-002;

            __statist_i_h_wts[5, 85] = 9.19174513528194e-002;

            __statist_i_h_wts[5, 86] = 2.97061372837928e+000;

            __statist_i_h_wts[5, 87] = -3.12053395280720e+000;

            __statist_i_h_wts[5, 88] = -9.04202917647904e-001;

            __statist_i_h_wts[5, 89] = 4.67671917670440e+000;

            __statist_i_h_wts[5, 90] = -3.81750491371196e+000;

            __statist_i_h_wts[5, 91] = -1.88856132840883e+000;

            __statist_i_h_wts[5, 92] = 1.35306674456177e+000;

            __statist_i_h_wts[5, 93] = -2.79412034982046e+000;

            __statist_i_h_wts[5, 94] = 4.17716017543166e-001;

            __statist_i_h_wts[5, 95] = 3.49063176205373e-001;

            __statist_i_h_wts[5, 96] = -1.64558864299916e+000;

            __statist_i_h_wts[5, 97] = 2.76556889557435e-001;

            __statist_i_h_wts[5, 98] = -5.51612786983378e-002;

            __statist_i_h_wts[5, 99] = -9.37817338990315e-001;

            __statist_i_h_wts[5, 100] = -5.58443666566118e-002;

            __statist_i_h_wts[5, 101] = 2.51027073532111e-001;

            __statist_i_h_wts[5, 102] = -1.31210491687484e+000;

            __statist_i_h_wts[5, 103] = 1.45330452436876e-002;

            __statist_i_h_wts[5, 104] = -2.35265154292126e+000;

            __statist_i_h_wts[5, 105] = 8.57569186131281e-001;

            __statist_i_h_wts[5, 106] = 4.68104382441499e-001;

            __statist_i_h_wts[5, 107] = -9.39198544344917e-001;

            __statist_i_h_wts[5, 108] = -3.03270494074624e-001;

            __statist_i_h_wts[5, 109] = 2.22265925335558e-001;

            __statist_i_h_wts[5, 110] = -1.23397525785482e+000;

            __statist_i_h_wts[5, 111] = 9.74496427650996e-003;

            __statist_i_h_wts[5, 112] = 1.97470957979118e-001;

            __statist_i_h_wts[5, 113] = 2.20202327818185e-001;

            __statist_i_h_wts[5, 114] = -9.85304019820986e-001;

            __statist_i_h_wts[5, 115] = -2.73177944347324e-001;

            __statist_i_h_wts[5, 116] = 7.49481068136574e-001;

            __statist_i_h_wts[5, 117] = -1.57819431342509e+000;

            __statist_i_h_wts[5, 118] = -2.19993824700026e-001;

            __statist_i_h_wts[5, 119] = -1.80940130659182e+000;

            __statist_i_h_wts[5, 120] = 3.72177604422432e-001;

            __statist_i_h_wts[5, 121] = 4.15537761673306e-001;

            __statist_i_h_wts[5, 122] = -5.57938154186890e-001;

            __statist_i_h_wts[5, 123] = -5.60247054621472e-001;

            __statist_i_h_wts[5, 124] = 8.14992936312766e-002;

            __statist_i_h_wts[5, 125] = -1.24094000572278e+000;

            __statist_i_h_wts[5, 126] = 1.89134888704729e-001;

            __statist_i_h_wts[5, 127] = 2.71991086836392e-002;



            double[,] __statist_h_o_wts = new double[2, 6];



            __statist_h_o_wts[0, 0] = 3.47004958921840e+000;

            __statist_h_o_wts[0, 1] = 8.72345222528351e-001;

            __statist_h_o_wts[0, 2] = 2.34273776409380e+000;

            __statist_h_o_wts[0, 3] = -3.54587525584667e-001;

            __statist_h_o_wts[0, 4] = -2.91509173288332e+000;

            __statist_h_o_wts[0, 5] = 1.54574677067261e+000;



            __statist_h_o_wts[1, 0] = -3.44013726153891e+000;

            __statist_h_o_wts[1, 1] = -9.39352249607248e-001;

            __statist_h_o_wts[1, 2] = -2.41557653421285e+000;

            __statist_h_o_wts[1, 3] = 3.46619766350181e-001;

            __statist_h_o_wts[1, 4] = 2.85135457287261e+000;

            __statist_h_o_wts[1, 5] = -1.57752463193933e+000;



            double[] __statist_hidden_bias = new double[6];

            __statist_hidden_bias[0] = 4.74817915291547e-001;

            __statist_hidden_bias[1] = 3.57454913360932e-001;

            __statist_hidden_bias[2] = 8.45575732790661e-002;

            __statist_hidden_bias[3] = 4.45194065062825e-001;

            __statist_hidden_bias[4] = -9.68527174897281e-001;

            __statist_hidden_bias[5] = -1.04397611859814e+000;



            double[] __statist_output_bias = new double[2];

            __statist_output_bias[0] = -6.47347673336295e-001;

            __statist_output_bias[1] = 6.57123318875958e-001;



            double[] __statist_inputs = new double[128];



            double[] __statist_hidden = new double[6];



            double[] __statist_outputs = new double[2];

            __statist_outputs[0] = -1.0e+307;

            __statist_outputs[1] = -1.0e+307;





            if (Var4 == "0")
            {

                __statist_inputs[0] = 1;

            }

            else
            {

                __statist_inputs[0] = 0;

            }



            if (Var4 == "1")
            {

                __statist_inputs[1] = 1;

            }

            else
            {

                __statist_inputs[1] = 0;

            }



            if (Var4 == "10")
            {

                __statist_inputs[2] = 1;

            }

            else
            {

                __statist_inputs[2] = 0;

            }



            if (Var4 == "11")
            {

                __statist_inputs[3] = 1;

            }

            else
            {

                __statist_inputs[3] = 0;

            }



            if (Var4 == "12")
            {

                __statist_inputs[4] = 1;

            }

            else
            {

                __statist_inputs[4] = 0;

            }



            if (Var4 == "13")
            {

                __statist_inputs[5] = 1;

            }

            else
            {

                __statist_inputs[5] = 0;

            }



            if (Var4 == "14")
            {

                __statist_inputs[6] = 1;

            }

            else
            {

                __statist_inputs[6] = 0;

            }



            if (Var4 == "15")
            {

                __statist_inputs[7] = 1;

            }

            else
            {

                __statist_inputs[7] = 0;

            }



            if (Var4 == "16")
            {

                __statist_inputs[8] = 1;

            }

            else
            {

                __statist_inputs[8] = 0;

            }



            if (Var4 == "17")
            {

                __statist_inputs[9] = 1;

            }

            else
            {

                __statist_inputs[9] = 0;

            }



            if (Var4 == "18")
            {

                __statist_inputs[10] = 1;

            }

            else
            {

                __statist_inputs[10] = 0;

            }



            if (Var4 == "19")
            {

                __statist_inputs[11] = 1;

            }

            else
            {

                __statist_inputs[11] = 0;

            }



            if (Var4 == "2")
            {

                __statist_inputs[12] = 1;

            }

            else
            {

                __statist_inputs[12] = 0;

            }



            if (Var4 == "20")
            {

                __statist_inputs[13] = 1;

            }

            else
            {

                __statist_inputs[13] = 0;

            }



            if (Var4 == "21")
            {

                __statist_inputs[14] = 1;

            }

            else
            {

                __statist_inputs[14] = 0;

            }



            if (Var4 == "22")
            {

                __statist_inputs[15] = 1;

            }

            else
            {

                __statist_inputs[15] = 0;

            }



            if (Var4 == "23")
            {

                __statist_inputs[16] = 1;

            }

            else
            {

                __statist_inputs[16] = 0;

            }



            if (Var4 == "24")
            {

                __statist_inputs[17] = 1;

            }

            else
            {

                __statist_inputs[17] = 0;

            }



            if (Var4 == "25")
            {

                __statist_inputs[18] = 1;

            }

            else
            {

                __statist_inputs[18] = 0;

            }



            if (Var4 == "26")
            {

                __statist_inputs[19] = 1;

            }

            else
            {

                __statist_inputs[19] = 0;

            }



            if (Var4 == "27")
            {

                __statist_inputs[20] = 1;

            }

            else
            {

                __statist_inputs[20] = 0;

            }



            if (Var4 == "28")
            {

                __statist_inputs[21] = 1;

            }

            else
            {

                __statist_inputs[21] = 0;

            }



            if (Var4 == "29")
            {

                __statist_inputs[22] = 1;

            }

            else
            {

                __statist_inputs[22] = 0;

            }



            if (Var4 == "3")
            {

                __statist_inputs[23] = 1;

            }

            else
            {

                __statist_inputs[23] = 0;

            }



            if (Var4 == "30")
            {

                __statist_inputs[24] = 1;

            }

            else
            {

                __statist_inputs[24] = 0;

            }



            if (Var4 == "31")
            {

                __statist_inputs[25] = 1;

            }

            else
            {

                __statist_inputs[25] = 0;

            }



            if (Var4 == "32")
            {

                __statist_inputs[26] = 1;

            }

            else
            {

                __statist_inputs[26] = 0;

            }



            if (Var4 == "33")
            {

                __statist_inputs[27] = 1;

            }

            else
            {

                __statist_inputs[27] = 0;

            }



            if (Var4 == "34")
            {

                __statist_inputs[28] = 1;

            }

            else
            {

                __statist_inputs[28] = 0;

            }



            if (Var4 == "35")
            {

                __statist_inputs[29] = 1;

            }

            else
            {

                __statist_inputs[29] = 0;

            }



            if (Var4 == "36")
            {

                __statist_inputs[30] = 1;

            }

            else
            {

                __statist_inputs[30] = 0;

            }



            if (Var4 == "37")
            {

                __statist_inputs[31] = 1;

            }

            else
            {

                __statist_inputs[31] = 0;

            }



            if (Var4 == "38")
            {

                __statist_inputs[32] = 1;

            }

            else
            {

                __statist_inputs[32] = 0;

            }



            if (Var4 == "39")
            {

                __statist_inputs[33] = 1;

            }

            else
            {

                __statist_inputs[33] = 0;

            }



            if (Var4 == "4")
            {

                __statist_inputs[34] = 1;

            }

            else
            {

                __statist_inputs[34] = 0;

            }



            if (Var4 == "40")
            {

                __statist_inputs[35] = 1;

            }

            else
            {

                __statist_inputs[35] = 0;

            }



            if (Var4 == "41")
            {

                __statist_inputs[36] = 1;

            }

            else
            {

                __statist_inputs[36] = 0;

            }



            if (Var4 == "5")
            {

                __statist_inputs[37] = 1;

            }

            else
            {

                __statist_inputs[37] = 0;

            }



            if (Var4 == "6")
            {

                __statist_inputs[38] = 1;

            }

            else
            {

                __statist_inputs[38] = 0;

            }



            if (Var4 == "7")
            {

                __statist_inputs[39] = 1;

            }

            else
            {

                __statist_inputs[39] = 0;

            }



            if (Var4 == "8")
            {

                __statist_inputs[40] = 1;

            }

            else
            {

                __statist_inputs[40] = 0;

            }



            if (Var4 == "9")
            {

                __statist_inputs[41] = 1;

            }

            else
            {

                __statist_inputs[41] = 0;

            }



            if (Var5 == "0")
            {

                __statist_inputs[42] = 1;

            }

            else
            {

                __statist_inputs[42] = 0;

            }



            if (Var5 == "1")
            {

                __statist_inputs[43] = 1;

            }

            else
            {

                __statist_inputs[43] = 0;

            }



            if (Var5 == "10")
            {

                __statist_inputs[44] = 1;

            }

            else
            {

                __statist_inputs[44] = 0;

            }



            if (Var5 == "11")
            {

                __statist_inputs[45] = 1;

            }

            else
            {

                __statist_inputs[45] = 0;

            }



            if (Var5 == "12")
            {

                __statist_inputs[46] = 1;

            }

            else
            {

                __statist_inputs[46] = 0;

            }



            if (Var5 == "13")
            {

                __statist_inputs[47] = 1;

            }

            else
            {

                __statist_inputs[47] = 0;

            }



            if (Var5 == "2")
            {

                __statist_inputs[48] = 1;

            }

            else
            {

                __statist_inputs[48] = 0;

            }



            if (Var5 == "3")
            {

                __statist_inputs[49] = 1;

            }

            else
            {

                __statist_inputs[49] = 0;

            }



            if (Var5 == "4")
            {

                __statist_inputs[50] = 1;

            }

            else
            {

                __statist_inputs[50] = 0;

            }



            if (Var5 == "5")
            {

                __statist_inputs[51] = 1;

            }

            else
            {

                __statist_inputs[51] = 0;

            }



            if (Var5 == "6")
            {

                __statist_inputs[52] = 1;

            }

            else
            {

                __statist_inputs[52] = 0;

            }



            if (Var5 == "7")
            {

                __statist_inputs[53] = 1;

            }

            else
            {

                __statist_inputs[53] = 0;

            }



            if (Var5 == "8")
            {

                __statist_inputs[54] = 1;

            }

            else
            {

                __statist_inputs[54] = 0;

            }



            if (Var5 == "9")
            {

                __statist_inputs[55] = 1;

            }

            else
            {

                __statist_inputs[55] = 0;

            }



            if (Var6 == "0")
            {

                __statist_inputs[56] = 1;

            }

            else
            {

                __statist_inputs[56] = 0;

            }



            if (Var6 == "1")
            {

                __statist_inputs[57] = 1;

            }

            else
            {

                __statist_inputs[57] = 0;

            }



            if (Var6 == "2")
            {

                __statist_inputs[58] = 1;

            }

            else
            {

                __statist_inputs[58] = 0;

            }



            if (Var7 == "0")
            {

                __statist_inputs[59] = 1;

            }

            else
            {

                __statist_inputs[59] = 0;

            }



            if (Var7 == "1")
            {

                __statist_inputs[60] = 1;

            }

            else
            {

                __statist_inputs[60] = 0;

            }



            if (Var7 == "2")
            {

                __statist_inputs[61] = 1;

            }

            else
            {

                __statist_inputs[61] = 0;

            }



            if (Var8 == "0")
            {

                __statist_inputs[62] = 1;

            }

            else
            {

                __statist_inputs[62] = 0;

            }



            if (Var8 == "1")
            {

                __statist_inputs[63] = 1;

            }

            else
            {

                __statist_inputs[63] = 0;

            }



            if (Var8 == "2")
            {

                __statist_inputs[64] = 1;

            }

            else
            {

                __statist_inputs[64] = 0;

            }



            if (Var9 == "0")
            {

                __statist_inputs[65] = 1;

            }

            else
            {

                __statist_inputs[65] = 0;

            }



            if (Var9 == "1")
            {

                __statist_inputs[66] = 1;

            }

            else
            {

                __statist_inputs[66] = 0;

            }



            if (Var9 == "2")
            {

                __statist_inputs[67] = 1;

            }

            else
            {

                __statist_inputs[67] = 0;

            }



            if (Var10 == "0")
            {

                __statist_inputs[68] = 1;

            }

            else
            {

                __statist_inputs[68] = 0;

            }



            if (Var10 == "1")
            {

                __statist_inputs[69] = 1;

            }

            else
            {

                __statist_inputs[69] = 0;

            }



            if (Var10 == "2")
            {

                __statist_inputs[70] = 1;

            }

            else
            {

                __statist_inputs[70] = 0;

            }



            if (Var11 == "0")
            {

                __statist_inputs[71] = 1;

            }

            else
            {

                __statist_inputs[71] = 0;

            }



            if (Var11 == "1")
            {

                __statist_inputs[72] = 1;

            }

            else
            {

                __statist_inputs[72] = 0;

            }



            if (Var11 == "2")
            {

                __statist_inputs[73] = 1;

            }

            else
            {

                __statist_inputs[73] = 0;

            }



            if (Var12 == "0")
            {

                __statist_inputs[74] = 1;

            }

            else
            {

                __statist_inputs[74] = 0;

            }



            if (Var12 == "1")
            {

                __statist_inputs[75] = 1;

            }

            else
            {

                __statist_inputs[75] = 0;

            }



            if (Var12 == "2")
            {

                __statist_inputs[76] = 1;

            }

            else
            {

                __statist_inputs[76] = 0;

            }



            if (Var13 == "0")
            {

                __statist_inputs[77] = 1;

            }

            else
            {

                __statist_inputs[77] = 0;

            }



            if (Var13 == "1")
            {

                __statist_inputs[78] = 1;

            }

            else
            {

                __statist_inputs[78] = 0;

            }



            if (Var13 == "2")
            {

                __statist_inputs[79] = 1;

            }

            else
            {

                __statist_inputs[79] = 0;

            }



            if (Var14 == "0")
            {

                __statist_inputs[80] = 1;

            }

            else
            {

                __statist_inputs[80] = 0;

            }



            if (Var14 == "1")
            {

                __statist_inputs[81] = 1;

            }

            else
            {

                __statist_inputs[81] = 0;

            }



            if (Var14 == "2")
            {

                __statist_inputs[82] = 1;

            }

            else
            {

                __statist_inputs[82] = 0;

            }



            if (Var15 == "0")
            {

                __statist_inputs[83] = 1;

            }

            else
            {

                __statist_inputs[83] = 0;

            }



            if (Var15 == "1")
            {

                __statist_inputs[84] = 1;

            }

            else
            {

                __statist_inputs[84] = 0;

            }



            if (Var15 == "2")
            {

                __statist_inputs[85] = 1;

            }

            else
            {

                __statist_inputs[85] = 0;

            }



            if (Var16 == "0")
            {

                __statist_inputs[86] = 1;

            }

            else
            {

                __statist_inputs[86] = 0;

            }



            if (Var16 == "1")
            {

                __statist_inputs[87] = 1;

            }

            else
            {

                __statist_inputs[87] = 0;

            }



            if (Var16 == "2")
            {

                __statist_inputs[88] = 1;

            }

            else
            {

                __statist_inputs[88] = 0;

            }



            if (Var17 == "0")
            {

                __statist_inputs[89] = 1;

            }

            else
            {

                __statist_inputs[89] = 0;

            }



            if (Var17 == "1")
            {

                __statist_inputs[90] = 1;

            }

            else
            {

                __statist_inputs[90] = 0;

            }



            if (Var17 == "2")
            {

                __statist_inputs[91] = 1;

            }

            else
            {

                __statist_inputs[91] = 0;

            }



            if (Var19 == "0")
            {

                __statist_inputs[92] = 1;

            }

            else
            {

                __statist_inputs[92] = 0;

            }



            if (Var19 == "1")
            {

                __statist_inputs[93] = 1;

            }

            else
            {

                __statist_inputs[93] = 0;

            }



            if (Var19 == "2")
            {

                __statist_inputs[94] = 1;

            }

            else
            {

                __statist_inputs[94] = 0;

            }



            if (Var20 == "0")
            {

                __statist_inputs[95] = 1;

            }

            else
            {

                __statist_inputs[95] = 0;

            }



            if (Var20 == "1")
            {

                __statist_inputs[96] = 1;

            }

            else
            {

                __statist_inputs[96] = 0;

            }



            if (Var20 == "2")
            {

                __statist_inputs[97] = 1;

            }

            else
            {

                __statist_inputs[97] = 0;

            }



            if (Var21 == "0")
            {

                __statist_inputs[98] = 1;

            }

            else
            {

                __statist_inputs[98] = 0;

            }



            if (Var21 == "1")
            {

                __statist_inputs[99] = 1;

            }

            else
            {

                __statist_inputs[99] = 0;

            }



            if (Var21 == "2")
            {

                __statist_inputs[100] = 1;

            }

            else
            {

                __statist_inputs[100] = 0;

            }



            if (Var22 == "0")
            {

                __statist_inputs[101] = 1;

            }

            else
            {

                __statist_inputs[101] = 0;

            }



            if (Var22 == "1")
            {

                __statist_inputs[102] = 1;

            }

            else
            {

                __statist_inputs[102] = 0;

            }



            if (Var22 == "2")
            {

                __statist_inputs[103] = 1;

            }

            else
            {

                __statist_inputs[103] = 0;

            }



            if (Var23 == "0")
            {

                __statist_inputs[104] = 1;

            }

            else
            {

                __statist_inputs[104] = 0;

            }



            if (Var23 == "1")
            {

                __statist_inputs[105] = 1;

            }

            else
            {

                __statist_inputs[105] = 0;

            }



            if (Var23 == "2")
            {

                __statist_inputs[106] = 1;

            }

            else
            {

                __statist_inputs[106] = 0;

            }



            if (Var24 == "0")
            {

                __statist_inputs[107] = 1;

            }

            else
            {

                __statist_inputs[107] = 0;

            }



            if (Var24 == "1")
            {

                __statist_inputs[108] = 1;

            }

            else
            {

                __statist_inputs[108] = 0;

            }



            if (Var24 == "2")
            {

                __statist_inputs[109] = 1;

            }

            else
            {

                __statist_inputs[109] = 0;

            }



            if (Var25 == "0")
            {

                __statist_inputs[110] = 1;

            }

            else
            {

                __statist_inputs[110] = 0;

            }



            if (Var25 == "1")
            {

                __statist_inputs[111] = 1;

            }

            else
            {

                __statist_inputs[111] = 0;

            }



            if (Var25 == "2")
            {

                __statist_inputs[112] = 1;

            }

            else
            {

                __statist_inputs[112] = 0;

            }



            if (Var26 == "0")
            {

                __statist_inputs[113] = 1;

            }

            else
            {

                __statist_inputs[113] = 0;

            }



            if (Var26 == "1")
            {

                __statist_inputs[114] = 1;

            }

            else
            {

                __statist_inputs[114] = 0;

            }



            if (Var26 == "2")
            {

                __statist_inputs[115] = 1;

            }

            else
            {

                __statist_inputs[115] = 0;

            }



            if (Var27 == "0")
            {

                __statist_inputs[116] = 1;

            }

            else
            {

                __statist_inputs[116] = 0;

            }



            if (Var27 == "1")
            {

                __statist_inputs[117] = 1;

            }

            else
            {

                __statist_inputs[117] = 0;

            }



            if (Var27 == "2")
            {

                __statist_inputs[118] = 1;

            }

            else
            {

                __statist_inputs[118] = 0;

            }



            if (Var28 == "0")
            {

                __statist_inputs[119] = 1;

            }

            else
            {

                __statist_inputs[119] = 0;

            }



            if (Var28 == "1")
            {

                __statist_inputs[120] = 1;

            }

            else
            {

                __statist_inputs[120] = 0;

            }



            if (Var28 == "2")
            {

                __statist_inputs[121] = 1;

            }

            else
            {

                __statist_inputs[121] = 0;

            }



            if (Var29 == "0")
            {

                __statist_inputs[122] = 1;

            }

            else
            {

                __statist_inputs[122] = 0;

            }



            if (Var29 == "1")
            {

                __statist_inputs[123] = 1;

            }

            else
            {

                __statist_inputs[123] = 0;

            }



            if (Var29 == "2")
            {

                __statist_inputs[124] = 1;

            }

            else
            {

                __statist_inputs[124] = 0;

            }



            if (Var30 == "0")
            {

                __statist_inputs[125] = 1;

            }

            else
            {

                __statist_inputs[125] = 0;

            }



            if (Var30 == "1")
            {

                __statist_inputs[126] = 1;

            }

            else
            {

                __statist_inputs[126] = 0;

            }



            if (Var30 == "2")
            {

                __statist_inputs[127] = 1;

            }

            else
            {

                __statist_inputs[127] = 0;

            }



            double __statist_delta = 0;

            double __statist_maximum = 1;

            double __statist_minimum = 0;

            int __statist_ninputs = 128;

            int __statist_nhidden = 6;



            /*Compute feed forward signals from Input layer to hidden layer*/

            for (int __statist_row = 0; __statist_row < __statist_nhidden; __statist_row++)
            {

                __statist_hidden[__statist_row] = 0.0;

                for (int __statist_col = 0; __statist_col < __statist_ninputs; __statist_col++)
                {

                    __statist_hidden[__statist_row] = __statist_hidden[__statist_row] + (__statist_i_h_wts[__statist_row, __statist_col] * __statist_inputs[__statist_col]);

                }

                __statist_hidden[__statist_row] = __statist_hidden[__statist_row] + __statist_hidden_bias[__statist_row];

            }



            for (int __statist_row = 0; __statist_row < __statist_nhidden; __statist_row++)
            {

                if (__statist_hidden[__statist_row] > 100.0)
                {

                    __statist_hidden[__statist_row] = 1.0;

                }

                else
                {

                    if (__statist_hidden[__statist_row] < -100.0)
                    {

                        __statist_hidden[__statist_row] = 0.0;

                    }

                    else
                    {

                        __statist_hidden[__statist_row] = 1.0 / (1.0 + Math.Exp(-__statist_hidden[__statist_row]));

                    }

                }

            }



            int __statist_noutputs = 2;



            /*Compute feed forward signals from hidden layer to output layer*/

            for (int __statist_row2 = 0; __statist_row2 < __statist_noutputs; __statist_row2++)
            {

                __statist_outputs[__statist_row2] = 0.0;

                for (int __statist_col2 = 0; __statist_col2 < __statist_nhidden; __statist_col2++)
                {

                    __statist_outputs[__statist_row2] = __statist_outputs[__statist_row2] + (__statist_h_o_wts[__statist_row2, __statist_col2] * __statist_hidden[__statist_col2]);

                }

                __statist_outputs[__statist_row2] = __statist_outputs[__statist_row2] + __statist_output_bias[__statist_row2];

            }





            double __statist_sum = 0.0;

            double __statist_maxIndex = 0;

            for (int __statist_jj = 0; __statist_jj < __statist_noutputs; __statist_jj++)
            {

                if (__statist_outputs[__statist_jj] > 200)
                {

                    double __statist_max = __statist_outputs[1];

                    __statist_maxIndex = 0;

                    for (int __statist_ii = 0; __statist_ii < __statist_noutputs; __statist_ii++)
                    {

                        if (__statist_outputs[__statist_ii] > __statist_max)
                        {

                            __statist_max = __statist_outputs[__statist_ii];

                            __statist_maxIndex = __statist_ii;

                        }

                    }



                    for (int __statist_kk = 0; __statist_kk < __statist_noutputs; __statist_kk++)
                    {

                        if (__statist_kk == __statist_maxIndex)
                        {

                            __statist_outputs[__statist_jj] = 1.0;

                        }

                        else
                        {

                            __statist_outputs[__statist_kk] = 0.0;

                        }

                    }

                }

                else
                {

                    __statist_outputs[__statist_jj] = Math.Exp(__statist_outputs[__statist_jj]);

                    __statist_sum = __statist_sum + __statist_outputs[__statist_jj];

                }

            }

            for (int __statist_ll = 0; __statist_ll < __statist_noutputs; __statist_ll++)
            {

                if (__statist_sum != 0)
                {

                    __statist_outputs[__statist_ll] = __statist_outputs[__statist_ll] / __statist_sum;

                }

            }



            int __statist_PredIndex = 1;

            for (int __statist_ii = 0; __statist_ii < __statist_noutputs; __statist_ii++)
            {

                if (__statist_ConfLevel < __statist_outputs[__statist_ii])
                {

                    __statist_ConfLevel = __statist_outputs[__statist_ii];

                    __statist_PredIndex = __statist_ii;

                }

            }
            
            __statist_PredCat = __statist_DCats[__statist_PredIndex];
            
            string[] prediction = new string[2] { __statist_PredCat, __statist_ConfLevel.ToString() };
            
            return prediction;

        }


        public static string[] Main(string[] args)
        {

            int argID = 0;

            string[] CatInputs = new string[26];

            int catID = 0;



            if (args.Length >= 26)
            {

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

                CatInputs[catID++] = args[argID++];

            }

            else
            {

                string Comment = "";

                string Comment1 = "**************************************************************************\n";

                Comment += Comment1;

                string Comment2 = "Please enter at least NaN command line parameters in the following order for \nthe program to Predict.\n";

                Comment += Comment2;

                Comment += Comment1;

                string Comment3 = "Var4  Type - String (categories are { \"0\"  \"1\"  \"10\"  \"11\"  \"12\"  \"13\"  \"14\"  \"15\"  \"16\"  \"17\"  \"18\"  \"19\"  \"2\"  \"20\"  \"21\"  \"22\"  \"23\"  \"24\"  \"25\"  \"26\"  \"27\"  \"28\"  \"29\"  \"3\"  \"30\"  \"31\"  \"32\"  \"33\"  \"34\"  \"35\"  \"36\"  \"37\"  \"38\"  \"39\"  \"4\"  \"40\"  \"41\"  \"5\"  \"6\"  \"7\"  \"8\"  \"9\" } )\n";

                Comment += Comment3;

                string Comment4 = "Var5  Type - String (categories are { \"0\"  \"1\"  \"10\"  \"11\"  \"12\"  \"13\"  \"2\"  \"3\"  \"4\"  \"5\"  \"6\"  \"7\"  \"8\"  \"9\" } )\n";

                Comment += Comment4;

                string Comment5 = "Var6  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment5;

                string Comment6 = "Var7  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment6;

                string Comment7 = "Var8  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment7;

                string Comment8 = "Var9  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment8;

                string Comment9 = "Var10  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment9;

                string Comment10 = "Var11  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment10;

                string Comment11 = "Var12  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment11;

                string Comment12 = "Var13  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment12;

                string Comment13 = "Var14  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment13;

                string Comment14 = "Var15  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment14;

                string Comment15 = "Var16  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment15;

                string Comment16 = "Var17  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment16;

                string Comment17 = "Var19  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment17;

                string Comment18 = "Var20  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment18;

                string Comment19 = "Var21  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment19;

                string Comment20 = "Var22  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment20;

                string Comment21 = "Var23  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment21;

                string Comment22 = "Var24  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment22;

                string Comment23 = "Var25  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment23;

                string Comment24 = "Var26  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment24;

                string Comment25 = "Var27  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment25;

                string Comment26 = "Var28  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment26;

                string Comment27 = "Var29  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment27;

                string Comment28 = "Var30  Type - String (categories are { \"0\"  \"1\"  \"2\" } )\n";

                Comment += Comment28;

                Comment += Comment1;

                return new string[] { Comment };

            }

            return MLP_128_6_2(CatInputs);
        }
    }
}
