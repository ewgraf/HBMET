using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn6
{
    class Predict_Bottom
    {
        /**C# deployment code of Neural Networks Model**/

        public static string[] MLP_128_8_2(string[] CatInputs)
        {
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

            __statist_DCats[1] = "3";



            double __statist_ConfLevel = 3.0E-300;







            double[,] __statist_i_h_wts = new double[8, 128];



            __statist_i_h_wts[0, 0] = 2.44066441906476e-002;

            __statist_i_h_wts[0, 1] = 2.27353278210295e-001;

            __statist_i_h_wts[0, 2] = 2.82218492814916e-001;

            __statist_i_h_wts[0, 3] = -3.45666564362374e-001;

            __statist_i_h_wts[0, 4] = 1.62889034775423e-001;

            __statist_i_h_wts[0, 5] = -6.94823067145852e-002;

            __statist_i_h_wts[0, 6] = -2.24600069804907e-001;

            __statist_i_h_wts[0, 7] = -7.00854681229800e-002;

            __statist_i_h_wts[0, 8] = 1.07431542995828e-002;

            __statist_i_h_wts[0, 9] = -3.75345613057302e-002;

            __statist_i_h_wts[0, 10] = 1.60533275432147e-002;

            __statist_i_h_wts[0, 11] = 1.35420840937359e-001;

            __statist_i_h_wts[0, 12] = -3.82630400310561e-002;

            __statist_i_h_wts[0, 13] = 6.52700069784224e-002;

            __statist_i_h_wts[0, 14] = 2.24192921527145e-001;

            __statist_i_h_wts[0, 15] = 6.11805505415462e-002;

            __statist_i_h_wts[0, 16] = -2.68136842874455e-001;

            __statist_i_h_wts[0, 17] = -5.00158332705070e-002;

            __statist_i_h_wts[0, 18] = -1.86805276642758e-001;

            __statist_i_h_wts[0, 19] = 3.45367627190471e-001;

            __statist_i_h_wts[0, 20] = 2.46194207347462e-001;

            __statist_i_h_wts[0, 21] = -1.08791922252879e-001;

            __statist_i_h_wts[0, 22] = -1.75787570174221e-001;

            __statist_i_h_wts[0, 23] = -3.52809408475362e-001;

            __statist_i_h_wts[0, 24] = -7.53495308731222e-002;

            __statist_i_h_wts[0, 25] = -9.12827604553184e-002;

            __statist_i_h_wts[0, 26] = -6.88389533274209e-003;

            __statist_i_h_wts[0, 27] = -2.78002761527728e-001;

            __statist_i_h_wts[0, 28] = -5.65317618040575e-003;

            __statist_i_h_wts[0, 29] = 4.15124334086180e-001;

            __statist_i_h_wts[0, 30] = 2.68384213226797e-001;

            __statist_i_h_wts[0, 31] = -1.13213277766518e-001;

            __statist_i_h_wts[0, 32] = -1.36386095835247e-001;

            __statist_i_h_wts[0, 33] = 8.65052593040342e-002;

            __statist_i_h_wts[0, 34] = 5.13692119575933e-002;

            __statist_i_h_wts[0, 35] = 1.65679878867247e-001;

            __statist_i_h_wts[0, 36] = -8.93163119433404e-003;

            __statist_i_h_wts[0, 37] = 2.10923855249228e-001;

            __statist_i_h_wts[0, 38] = -1.21142851397010e-001;

            __statist_i_h_wts[0, 39] = -2.28631358855663e-001;

            __statist_i_h_wts[0, 40] = -2.32765844088133e-001;

            __statist_i_h_wts[0, 41] = -1.69231865288275e-001;

            __statist_i_h_wts[0, 42] = -4.47500177171218e-002;

            __statist_i_h_wts[0, 43] = 8.25101553007085e-002;

            __statist_i_h_wts[0, 44] = -4.70295075440628e-002;

            __statist_i_h_wts[0, 45] = -2.24059818598877e-002;

            __statist_i_h_wts[0, 46] = 5.54935240758021e-002;

            __statist_i_h_wts[0, 47] = -5.10826119060876e-002;

            __statist_i_h_wts[0, 48] = -1.20528765696581e-002;

            __statist_i_h_wts[0, 49] = -9.57512216668397e-002;

            __statist_i_h_wts[0, 50] = -2.60000326536328e-001;

            __statist_i_h_wts[0, 51] = -1.81657193870027e-001;

            __statist_i_h_wts[0, 52] = 3.62252068639058e-002;

            __statist_i_h_wts[0, 53] = -2.95989866956529e-001;

            __statist_i_h_wts[0, 54] = -5.39713450305680e-003;

            __statist_i_h_wts[0, 55] = 5.96656858615546e-001;

            __statist_i_h_wts[0, 56] = -1.98885721789479e-001;

            __statist_i_h_wts[0, 57] = 9.88610174716809e-003;

            __statist_i_h_wts[0, 58] = -7.76530656194540e-002;

            __statist_i_h_wts[0, 59] = 2.58859597951268e-001;

            __statist_i_h_wts[0, 60] = 7.74797898825224e-002;

            __statist_i_h_wts[0, 61] = -6.12564516184459e-001;

            __statist_i_h_wts[0, 62] = -6.83197610225549e-003;

            __statist_i_h_wts[0, 63] = 6.67680365883341e-001;

            __statist_i_h_wts[0, 64] = -9.33854113511769e-001;

            __statist_i_h_wts[0, 65] = 3.82946280082862e-001;

            __statist_i_h_wts[0, 66] = -2.80899029134559e-001;

            __statist_i_h_wts[0, 67] = -3.49307541664641e-001;

            __statist_i_h_wts[0, 68] = 1.33503277164896e-001;

            __statist_i_h_wts[0, 69] = -1.06362947352629e-001;

            __statist_i_h_wts[0, 70] = -2.88319819463992e-001;

            __statist_i_h_wts[0, 71] = -2.31386034553355e-002;

            __statist_i_h_wts[0, 72] = -2.38166683785664e-003;

            __statist_i_h_wts[0, 73] = -2.52460806067373e-001;

            __statist_i_h_wts[0, 74] = 2.12143385266731e-001;

            __statist_i_h_wts[0, 75] = 1.35127944777376e-001;

            __statist_i_h_wts[0, 76] = -6.02289815436270e-001;

            __statist_i_h_wts[0, 77] = 8.27683158161528e-002;

            __statist_i_h_wts[0, 78] = 1.16901822411524e+000;

            __statist_i_h_wts[0, 79] = -1.50477658589338e+000;

            __statist_i_h_wts[0, 80] = 2.31226022945369e-001;

            __statist_i_h_wts[0, 81] = 4.11727144752070e-002;

            __statist_i_h_wts[0, 82] = -5.34530245751169e-001;

            __statist_i_h_wts[0, 83] = 1.77194385210543e-001;

            __statist_i_h_wts[0, 84] = -2.02234563239318e-001;

            __statist_i_h_wts[0, 85] = -2.46126027827590e-001;

            __statist_i_h_wts[0, 86] = 5.00095121774955e-001;

            __statist_i_h_wts[0, 87] = -2.31622401322747e-001;

            __statist_i_h_wts[0, 88] = -5.39040110590556e-001;

            __statist_i_h_wts[0, 89] = 9.48996934221415e-001;

            __statist_i_h_wts[0, 90] = -2.72340677601236e-001;

            __statist_i_h_wts[0, 91] = -9.33086149224685e-001;

            __statist_i_h_wts[0, 92] = 8.64529365487584e-001;

            __statist_i_h_wts[0, 93] = -2.67434809716069e-001;

            __statist_i_h_wts[0, 94] = -8.81163441672137e-001;

            __statist_i_h_wts[0, 95] = 3.48263505526699e-001;

            __statist_i_h_wts[0, 96] = -3.08066056092600e-001;

            __statist_i_h_wts[0, 97] = -3.05464032641100e-001;

            __statist_i_h_wts[0, 98] = -5.79925340665616e-001;

            __statist_i_h_wts[0, 99] = -1.22268055883372e-001;

            __statist_i_h_wts[0, 100] = 4.28442309334400e-001;

            __statist_i_h_wts[0, 101] = -3.80007357461840e-001;

            __statist_i_h_wts[0, 102] = -3.69306706111563e-001;

            __statist_i_h_wts[0, 103] = 5.10023714800929e-001;

            __statist_i_h_wts[0, 104] = -3.03443026782243e+000;

            __statist_i_h_wts[0, 105] = -1.22269219393351e-001;

            __statist_i_h_wts[0, 106] = 2.91329044036221e+000;

            __statist_i_h_wts[0, 107] = -5.27611006461467e-001;

            __statist_i_h_wts[0, 108] = -3.68812507321773e-001;

            __statist_i_h_wts[0, 109] = 6.19290007097890e-001;

            __statist_i_h_wts[0, 110] = -4.75969717482922e-001;

            __statist_i_h_wts[0, 111] = 1.04373156957008e-003;

            __statist_i_h_wts[0, 112] = 2.12069074105575e-001;

            __statist_i_h_wts[0, 113] = -3.55004738895562e-001;

            __statist_i_h_wts[0, 114] = -6.93566927707643e-002;

            __statist_i_h_wts[0, 115] = 1.76396066833633e-001;

            __statist_i_h_wts[0, 116] = -1.88465114566245e-001;

            __statist_i_h_wts[0, 117] = -4.06461617564614e-001;

            __statist_i_h_wts[0, 118] = 3.51511669190316e-001;

            __statist_i_h_wts[0, 119] = -1.67205005770371e+000;

            __statist_i_h_wts[0, 120] = -4.61907277514494e-001;

            __statist_i_h_wts[0, 121] = 1.86581924700493e+000;

            __statist_i_h_wts[0, 122] = -3.54371358900874e-001;

            __statist_i_h_wts[0, 123] = -2.10615920353789e-001;

            __statist_i_h_wts[0, 124] = 3.34990779380170e-001;

            __statist_i_h_wts[0, 125] = -3.59332356515041e-001;

            __statist_i_h_wts[0, 126] = -2.19524699810319e-001;

            __statist_i_h_wts[0, 127] = 3.10658240136656e-001;



            __statist_i_h_wts[1, 0] = 1.37075774571323e-002;

            __statist_i_h_wts[1, 1] = 2.48371134122708e-002;

            __statist_i_h_wts[1, 2] = 1.51579367890340e-001;

            __statist_i_h_wts[1, 3] = -1.37774789338089e-001;

            __statist_i_h_wts[1, 4] = 4.08835192498178e-002;

            __statist_i_h_wts[1, 5] = 4.01182713658594e-002;

            __statist_i_h_wts[1, 6] = -2.16956803595670e-002;

            __statist_i_h_wts[1, 7] = -2.69005311316572e-003;

            __statist_i_h_wts[1, 8] = 8.25989156432983e-002;

            __statist_i_h_wts[1, 9] = 2.69172897683401e-002;

            __statist_i_h_wts[1, 10] = 6.88224047918896e-002;

            __statist_i_h_wts[1, 11] = 4.82507925113113e-002;

            __statist_i_h_wts[1, 12] = -1.04213971718723e-001;

            __statist_i_h_wts[1, 13] = 7.16182748153946e-003;

            __statist_i_h_wts[1, 14] = 9.09257800480989e-002;

            __statist_i_h_wts[1, 15] = 3.06909063158797e-002;

            __statist_i_h_wts[1, 16] = -1.06840614426574e-001;

            __statist_i_h_wts[1, 17] = 1.34583648403697e-003;

            __statist_i_h_wts[1, 18] = 1.18106996820604e-002;

            __statist_i_h_wts[1, 19] = 1.58029742672996e-001;

            __statist_i_h_wts[1, 20] = 5.91323571069054e-002;

            __statist_i_h_wts[1, 21] = -4.33443031597570e-002;

            __statist_i_h_wts[1, 22] = -7.38555098823304e-002;

            __statist_i_h_wts[1, 23] = -1.55783975069558e-001;

            __statist_i_h_wts[1, 24] = -4.52990567528235e-002;

            __statist_i_h_wts[1, 25] = 3.90004836589314e-002;

            __statist_i_h_wts[1, 26] = -5.45859888625677e-003;

            __statist_i_h_wts[1, 27] = -1.26828297443230e-001;

            __statist_i_h_wts[1, 28] = -4.08157377158451e-002;

            __statist_i_h_wts[1, 29] = 1.53492142217696e-001;

            __statist_i_h_wts[1, 30] = 9.44455776496535e-002;

            __statist_i_h_wts[1, 31] = 1.23223434351029e-002;

            __statist_i_h_wts[1, 32] = -5.02311365992408e-003;

            __statist_i_h_wts[1, 33] = -8.12567872260386e-003;

            __statist_i_h_wts[1, 34] = 2.45943562672583e-002;

            __statist_i_h_wts[1, 35] = 2.11217706948640e-002;

            __statist_i_h_wts[1, 36] = -2.54569532313767e-003;

            __statist_i_h_wts[1, 37] = 3.88263685882102e-002;

            __statist_i_h_wts[1, 38] = -4.38566064345835e-002;

            __statist_i_h_wts[1, 39] = -6.52178862741174e-002;

            __statist_i_h_wts[1, 40] = -8.93500948511118e-002;

            __statist_i_h_wts[1, 41] = -2.33009162487828e-002;

            __statist_i_h_wts[1, 42] = -2.09809501127317e-001;

            __statist_i_h_wts[1, 43] = 6.77227972821338e-003;

            __statist_i_h_wts[1, 44] = 8.35417934909474e-003;

            __statist_i_h_wts[1, 45] = 1.64469140252209e-002;

            __statist_i_h_wts[1, 46] = 4.97795140810282e-002;

            __statist_i_h_wts[1, 47] = -3.87819380235139e-002;

            __statist_i_h_wts[1, 48] = -2.22653546174431e-002;

            __statist_i_h_wts[1, 49] = 2.46219392257562e-002;

            __statist_i_h_wts[1, 50] = 2.20894096622599e-001;

            __statist_i_h_wts[1, 51] = 3.26014369287745e-001;

            __statist_i_h_wts[1, 52] = -5.36372158199513e-002;

            __statist_i_h_wts[1, 53] = 4.65761651065058e-002;

            __statist_i_h_wts[1, 54] = -1.12447501445883e-001;

            __statist_i_h_wts[1, 55] = -8.12686068118161e-002;

            __statist_i_h_wts[1, 56] = 6.81415098140019e-002;

            __statist_i_h_wts[1, 57] = 1.24185003659534e-001;

            __statist_i_h_wts[1, 58] = -3.40439463787857e-002;

            __statist_i_h_wts[1, 59] = 1.56702926240284e-001;

            __statist_i_h_wts[1, 60] = 1.65436717140311e-001;

            __statist_i_h_wts[1, 61] = -1.79888003560931e-001;

            __statist_i_h_wts[1, 62] = 5.25008318651113e-001;

            __statist_i_h_wts[1, 63] = -2.40396709077712e-001;

            __statist_i_h_wts[1, 64] = -1.50572091000506e-001;

            __statist_i_h_wts[1, 65] = -1.82289842418597e-001;

            __statist_i_h_wts[1, 66] = 3.70919282038781e-001;

            __statist_i_h_wts[1, 67] = -3.97284979046768e-002;

            __statist_i_h_wts[1, 68] = -6.70881677570680e-002;

            __statist_i_h_wts[1, 69] = 3.23068764639585e-001;

            __statist_i_h_wts[1, 70] = -1.25763746313253e-001;

            __statist_i_h_wts[1, 71] = 1.93093093496872e-001;

            __statist_i_h_wts[1, 72] = -1.36635912587015e-002;

            __statist_i_h_wts[1, 73] = -3.48118383143564e-002;

            __statist_i_h_wts[1, 74] = 5.25826230945145e-002;

            __statist_i_h_wts[1, 75] = 2.48417385652885e-001;

            __statist_i_h_wts[1, 76] = -1.61699897652128e-001;

            __statist_i_h_wts[1, 77] = 9.58186036858006e-001;

            __statist_i_h_wts[1, 78] = -6.66733415919143e-001;

            __statist_i_h_wts[1, 79] = -1.61123398832385e-001;

            __statist_i_h_wts[1, 80] = 5.72247340068061e-002;

            __statist_i_h_wts[1, 81] = 2.23813390881949e-001;

            __statist_i_h_wts[1, 82] = -1.59885264853569e-001;

            __statist_i_h_wts[1, 83] = -8.22842908655464e-002;

            __statist_i_h_wts[1, 84] = 3.04328705294786e-001;

            __statist_i_h_wts[1, 85] = -9.69524444449780e-002;

            __statist_i_h_wts[1, 86] = -8.51586177946749e-002;

            __statist_i_h_wts[1, 87] = 3.44888377078298e-001;

            __statist_i_h_wts[1, 88] = -1.18733157601964e-001;

            __statist_i_h_wts[1, 89] = -3.80515603107333e-001;

            __statist_i_h_wts[1, 90] = 7.32587215623778e-001;

            __statist_i_h_wts[1, 91] = -1.81334440327677e-001;

            __statist_i_h_wts[1, 92] = -2.46824238440400e-001;

            __statist_i_h_wts[1, 93] = 6.16306167916757e-001;

            __statist_i_h_wts[1, 94] = -2.26861193288321e-001;

            __statist_i_h_wts[1, 95] = -5.67074384920636e-002;

            __statist_i_h_wts[1, 96] = 3.20776125595608e-001;

            __statist_i_h_wts[1, 97] = -1.27277891990938e-001;

            __statist_i_h_wts[1, 98] = 2.73352629558582e-001;

            __statist_i_h_wts[1, 99] = -1.88782365362761e-001;

            __statist_i_h_wts[1, 100] = 4.47586591270089e-002;

            __statist_i_h_wts[1, 101] = -1.50453820897760e-002;

            __statist_i_h_wts[1, 102] = -4.32783600602586e-002;

            __statist_i_h_wts[1, 103] = 1.95717971800256e-001;

            __statist_i_h_wts[1, 104] = 5.30994596536592e-002;

            __statist_i_h_wts[1, 105] = -3.08533345474748e-001;

            __statist_i_h_wts[1, 106] = 3.85423647337186e-001;

            __statist_i_h_wts[1, 107] = 2.63173398709830e-002;

            __statist_i_h_wts[1, 108] = -8.99519690146882e-002;

            __statist_i_h_wts[1, 109] = 1.88750035530687e-001;

            __statist_i_h_wts[1, 110] = 3.37601243680041e-001;

            __statist_i_h_wts[1, 111] = -2.25752047327687e-001;

            __statist_i_h_wts[1, 112] = 2.92090516744721e-002;

            __statist_i_h_wts[1, 113] = 1.96176259260097e-001;

            __statist_i_h_wts[1, 114] = -1.16589493277979e-001;

            __statist_i_h_wts[1, 115] = 5.45554167691205e-002;

            __statist_i_h_wts[1, 116] = -3.33663167519953e-002;

            __statist_i_h_wts[1, 117] = 3.91811017155270e-002;

            __statist_i_h_wts[1, 118] = 1.30770996588579e-001;

            __statist_i_h_wts[1, 119] = 4.24590047837765e-001;

            __statist_i_h_wts[1, 120] = -4.13005533697443e-001;

            __statist_i_h_wts[1, 121] = 1.56148730585433e-001;

            __statist_i_h_wts[1, 122] = -4.30321548915218e-002;

            __statist_i_h_wts[1, 123] = 5.93871048303392e-002;

            __statist_i_h_wts[1, 124] = 1.41240134655424e-001;

            __statist_i_h_wts[1, 125] = 1.88966597084839e-001;

            __statist_i_h_wts[1, 126] = -1.56080623711876e-001;

            __statist_i_h_wts[1, 127] = 8.83406220036262e-002;



            __statist_i_h_wts[2, 0] = -1.57925166110728e-002;

            __statist_i_h_wts[2, 1] = -1.03380673117659e-001;

            __statist_i_h_wts[2, 2] = -1.11521535917375e-001;

            __statist_i_h_wts[2, 3] = 1.30423366924661e-001;

            __statist_i_h_wts[2, 4] = -6.51396963054573e-002;

            __statist_i_h_wts[2, 5] = 3.24324689881546e-002;

            __statist_i_h_wts[2, 6] = 1.12632866239085e-001;

            __statist_i_h_wts[2, 7] = 2.99223575279549e-002;

            __statist_i_h_wts[2, 8] = 2.58544582516177e-005;

            __statist_i_h_wts[2, 9] = 3.63303068569185e-002;

            __statist_i_h_wts[2, 10] = 1.80203494117617e-003;

            __statist_i_h_wts[2, 11] = -6.26673909715842e-002;

            __statist_i_h_wts[2, 12] = -2.80562287274703e-003;

            __statist_i_h_wts[2, 13] = -5.31027662385309e-002;

            __statist_i_h_wts[2, 14] = -1.00224690655753e-001;

            __statist_i_h_wts[2, 15] = -1.54157561910068e-002;

            __statist_i_h_wts[2, 16] = 1.12360991259907e-001;

            __statist_i_h_wts[2, 17] = 4.16882712842231e-002;

            __statist_i_h_wts[2, 18] = 7.25739848949319e-002;

            __statist_i_h_wts[2, 19] = -1.56604217004389e-001;

            __statist_i_h_wts[2, 20] = -1.07703187544496e-001;

            __statist_i_h_wts[2, 21] = 5.15107707039394e-002;

            __statist_i_h_wts[2, 22] = 7.43885155069293e-002;

            __statist_i_h_wts[2, 23] = 1.53884352194819e-001;

            __statist_i_h_wts[2, 24] = 5.19937669789817e-002;

            __statist_i_h_wts[2, 25] = 4.66302154103016e-002;

            __statist_i_h_wts[2, 26] = 7.32130435841872e-003;

            __statist_i_h_wts[2, 27] = 1.33812487130584e-001;

            __statist_i_h_wts[2, 28] = -1.10071158484237e-002;

            __statist_i_h_wts[2, 29] = -1.80270173195772e-001;

            __statist_i_h_wts[2, 30] = -1.12874884088146e-001;

            __statist_i_h_wts[2, 31] = 4.22733894945877e-002;

            __statist_i_h_wts[2, 32] = 5.90580057906069e-002;

            __statist_i_h_wts[2, 33] = -4.75505693664038e-002;

            __statist_i_h_wts[2, 34] = -1.42413202926518e-002;

            __statist_i_h_wts[2, 35] = -8.62030047906471e-002;

            __statist_i_h_wts[2, 36] = 1.76773444565257e-003;

            __statist_i_h_wts[2, 37] = -9.77701099126623e-002;

            __statist_i_h_wts[2, 38] = 5.04586462359883e-002;

            __statist_i_h_wts[2, 39] = 8.97738253204470e-002;

            __statist_i_h_wts[2, 40] = 9.30940408016643e-002;

            __statist_i_h_wts[2, 41] = 7.98918443807101e-002;

            __statist_i_h_wts[2, 42] = 2.69437648725521e-003;

            __statist_i_h_wts[2, 43] = -2.09686846165243e-002;

            __statist_i_h_wts[2, 44] = 2.14325578710789e-002;

            __statist_i_h_wts[2, 45] = 7.33756182823164e-003;

            __statist_i_h_wts[2, 46] = -2.12517252421722e-002;

            __statist_i_h_wts[2, 47] = 2.64941429559560e-002;

            __statist_i_h_wts[2, 48] = 3.68018849594003e-002;

            __statist_i_h_wts[2, 49] = 5.87313953497181e-002;

            __statist_i_h_wts[2, 50] = 1.68368486311024e-001;

            __statist_i_h_wts[2, 51] = 1.22086874193972e-001;

            __statist_i_h_wts[2, 52] = -1.99598560103850e-002;

            __statist_i_h_wts[2, 53] = 1.71980928373629e-001;

            __statist_i_h_wts[2, 54] = -1.12345382533939e-002;

            __statist_i_h_wts[2, 55] = -3.16229257708822e-001;

            __statist_i_h_wts[2, 56] = 1.22561276830947e-001;

            __statist_i_h_wts[2, 57] = 5.87928274501709e-002;

            __statist_i_h_wts[2, 58] = 2.30584511870234e-002;

            __statist_i_h_wts[2, 59] = -8.77750995780383e-002;

            __statist_i_h_wts[2, 60] = 3.83871400358869e-002;

            __statist_i_h_wts[2, 61] = 2.78139017079174e-001;

            __statist_i_h_wts[2, 62] = 2.13667787956003e-001;

            __statist_i_h_wts[2, 63] = -4.34635283289539e-001;

            __statist_i_h_wts[2, 64] = 4.31780413489710e-001;

            __statist_i_h_wts[2, 65] = -1.55169084632705e-001;

            __statist_i_h_wts[2, 66] = 2.02913469537099e-001;

            __statist_i_h_wts[2, 67] = 1.83678374231620e-001;

            __statist_i_h_wts[2, 68] = -1.99081671579189e-002;

            __statist_i_h_wts[2, 69] = 1.08583927362976e-001;

            __statist_i_h_wts[2, 70] = 1.41972655279838e-001;

            __statist_i_h_wts[2, 71] = 5.58030465866921e-002;

            __statist_i_h_wts[2, 72] = 5.00528167756671e-002;

            __statist_i_h_wts[2, 73] = 1.10011421979192e-001;

            __statist_i_h_wts[2, 74] = -9.07228113591024e-002;

            __statist_i_h_wts[2, 75] = 2.44097240875437e-002;

            __statist_i_h_wts[2, 76] = 2.64901678483107e-001;

            __statist_i_h_wts[2, 77] = 2.44290052290453e-001;

            __statist_i_h_wts[2, 78] = -7.63681871819839e-001;

            __statist_i_h_wts[2, 79] = 7.29538526817436e-001;

            __statist_i_h_wts[2, 80] = -5.70659118943708e-002;

            __statist_i_h_wts[2, 81] = 4.73160514301987e-002;

            __statist_i_h_wts[2, 82] = 2.27145585086463e-001;

            __statist_i_h_wts[2, 83] = -4.76912815466540e-002;

            __statist_i_h_wts[2, 84] = 1.47332559225675e-001;

            __statist_i_h_wts[2, 85] = 1.05693514268930e-001;

            __statist_i_h_wts[2, 86] = -3.89585315134981e-001;

            __statist_i_h_wts[2, 87] = 3.66046103221559e-001;

            __statist_i_h_wts[2, 88] = 2.61685980006867e-001;

            __statist_i_h_wts[2, 89] = -7.17742306988959e-001;

            __statist_i_h_wts[2, 90] = 4.39001833355460e-001;

            __statist_i_h_wts[2, 91] = 4.43987016057802e-001;

            __statist_i_h_wts[2, 92] = -5.78574002073553e-001;

            __statist_i_h_wts[2, 93] = 3.97648307161582e-001;

            __statist_i_h_wts[2, 94] = 4.10043847220993e-001;

            __statist_i_h_wts[2, 95] = -2.27944805645203e-001;

            __statist_i_h_wts[2, 96] = 3.40029061164479e-001;

            __statist_i_h_wts[2, 97] = 1.26018194334216e-001;

            __statist_i_h_wts[2, 98] = 3.26716786678132e-001;

            __statist_i_h_wts[2, 99] = 1.17422218210825e-001;

            __statist_i_h_wts[2, 100] = -2.03471150916104e-001;

            __statist_i_h_wts[2, 101] = 1.96160758325395e-001;

            __statist_i_h_wts[2, 102] = 2.54855286043970e-001;

            __statist_i_h_wts[2, 103] = -2.24192771697419e-001;

            __statist_i_h_wts[2, 104] = 1.64181024345319e+000;

            __statist_i_h_wts[2, 105] = -7.78257532512410e-002;

            __statist_i_h_wts[2, 106] = -1.34800229941568e+000;

            __statist_i_h_wts[2, 107] = 2.96007039705001e-001;

            __statist_i_h_wts[2, 108] = 1.84256064505967e-001;

            __statist_i_h_wts[2, 109] = -2.85998204071906e-001;

            __statist_i_h_wts[2, 110] = 3.53009131893072e-001;

            __statist_i_h_wts[2, 111] = -4.36668065184025e-002;

            __statist_i_h_wts[2, 112] = -9.25860919545626e-002;

            __statist_i_h_wts[2, 113] = 2.02362533619542e-001;

            __statist_i_h_wts[2, 114] = 8.69386976499042e-002;

            __statist_i_h_wts[2, 115] = -8.46006357826560e-002;

            __statist_i_h_wts[2, 116] = 9.43377799305563e-002;

            __statist_i_h_wts[2, 117] = 2.72934214042168e-001;

            __statist_i_h_wts[2, 118] = -1.55306945971046e-001;

            __statist_i_h_wts[2, 119] = 1.02451726793647e+000;

            __statist_i_h_wts[2, 120] = 8.73055285249482e-002;

            __statist_i_h_wts[2, 121] = -9.03438061419243e-001;

            __statist_i_h_wts[2, 122] = 2.25022479892098e-001;

            __statist_i_h_wts[2, 123] = 1.24470110253129e-001;

            __statist_i_h_wts[2, 124] = -1.33747320548491e-001;

            __statist_i_h_wts[2, 125] = 2.64872847433330e-001;

            __statist_i_h_wts[2, 126] = 9.86279543770409e-002;

            __statist_i_h_wts[2, 127] = -1.33835966081784e-001;



            __statist_i_h_wts[3, 0] = -2.42627589536815e-002;

            __statist_i_h_wts[3, 1] = -1.26538687289323e-001;

            __statist_i_h_wts[3, 2] = -1.69113387432999e-001;

            __statist_i_h_wts[3, 3] = 1.82912712565121e-001;

            __statist_i_h_wts[3, 4] = -1.07905309284873e-001;

            __statist_i_h_wts[3, 5] = 2.76050419522071e-002;

            __statist_i_h_wts[3, 6] = 1.09966801334551e-001;

            __statist_i_h_wts[3, 7] = 3.14548653966226e-002;

            __statist_i_h_wts[3, 8] = -2.42309526546152e-002;

            __statist_i_h_wts[3, 9] = 1.75945068480744e-002;

            __statist_i_h_wts[3, 10] = -7.40767760728482e-003;

            __statist_i_h_wts[3, 11] = -8.23644648314375e-002;

            __statist_i_h_wts[3, 12] = 3.37897607877780e-002;

            __statist_i_h_wts[3, 13] = -3.94706499798973e-002;

            __statist_i_h_wts[3, 14] = -1.53548253514100e-001;

            __statist_i_h_wts[3, 15] = -3.55156038519574e-002;

            __statist_i_h_wts[3, 16] = 1.57051283520751e-001;

            __statist_i_h_wts[3, 17] = 2.92305124236153e-002;

            __statist_i_h_wts[3, 18] = 8.75760209379291e-002;

            __statist_i_h_wts[3, 19] = -2.03637438060000e-001;

            __statist_i_h_wts[3, 20] = -1.51778556603392e-001;

            __statist_i_h_wts[3, 21] = 7.12575098658990e-002;

            __statist_i_h_wts[3, 22] = 9.57296963156903e-002;

            __statist_i_h_wts[3, 23] = 2.09425356313779e-001;

            __statist_i_h_wts[3, 24] = 5.41613792773972e-002;

            __statist_i_h_wts[3, 25] = 2.75777586214841e-002;

            __statist_i_h_wts[3, 26] = 1.67486034835778e-002;

            __statist_i_h_wts[3, 27] = 1.76833735708215e-001;

            __statist_i_h_wts[3, 28] = -9.06567587879248e-003;

            __statist_i_h_wts[3, 29] = -2.37524359302254e-001;

            __statist_i_h_wts[3, 30] = -1.50780042115595e-001;

            __statist_i_h_wts[3, 31] = 5.28212852003416e-002;

            __statist_i_h_wts[3, 32] = 9.40216292934885e-002;

            __statist_i_h_wts[3, 33] = -4.39643708827541e-002;

            __statist_i_h_wts[3, 34] = -2.58795411917350e-002;

            __statist_i_h_wts[3, 35] = -9.35763521451778e-002;

            __statist_i_h_wts[3, 36] = -1.02010768955892e-003;

            __statist_i_h_wts[3, 37] = -1.22449007208510e-001;

            __statist_i_h_wts[3, 38] = 6.00405236066715e-002;

            __statist_i_h_wts[3, 39] = 1.20328726430683e-001;

            __statist_i_h_wts[3, 40] = 1.21172172655523e-001;

            __statist_i_h_wts[3, 41] = 8.39205960893556e-002;

            __statist_i_h_wts[3, 42] = 6.12619347830582e-002;

            __statist_i_h_wts[3, 43] = -3.81268037532963e-002;

            __statist_i_h_wts[3, 44] = 4.44996598205890e-002;

            __statist_i_h_wts[3, 45] = 1.02058517776037e-002;

            __statist_i_h_wts[3, 46] = -4.03141094127820e-002;

            __statist_i_h_wts[3, 47] = 5.65047168873065e-002;

            __statist_i_h_wts[3, 48] = 1.30829167474834e-002;

            __statist_i_h_wts[3, 49] = 3.43107344841499e-002;

            __statist_i_h_wts[3, 50] = 7.58735041291961e-002;

            __statist_i_h_wts[3, 51] = 2.88081683167973e-002;

            __statist_i_h_wts[3, 52] = -2.21701258890707e-002;

            __statist_i_h_wts[3, 53] = 1.54287060778309e-001;

            __statist_i_h_wts[3, 54] = -2.03472910649576e-003;

            __statist_i_h_wts[3, 55] = -3.00256705280904e-001;

            __statist_i_h_wts[3, 56] = 9.90568341473134e-002;

            __statist_i_h_wts[3, 57] = -4.31556020963191e-002;

            __statist_i_h_wts[3, 58] = 2.68131751509127e-002;

            __statist_i_h_wts[3, 59] = -1.70912093316518e-001;

            __statist_i_h_wts[3, 60] = -8.50945663445149e-002;

            __statist_i_h_wts[3, 61] = 3.30096140082445e-001;

            __statist_i_h_wts[3, 62] = -9.83071197893987e-002;

            __statist_i_h_wts[3, 63] = -2.92218572790560e-001;

            __statist_i_h_wts[3, 64] = 4.98715598089417e-001;

            __statist_i_h_wts[3, 65] = -1.94706718611945e-001;

            __statist_i_h_wts[3, 66] = 6.35276174095842e-002;

            __statist_i_h_wts[3, 67] = 1.97395416340841e-001;

            __statist_i_h_wts[3, 68] = -6.48295741746921e-002;

            __statist_i_h_wts[3, 69] = -5.56984505424297e-003;

            __statist_i_h_wts[3, 70] = 1.75766761013841e-001;

            __statist_i_h_wts[3, 71] = -2.26776893081587e-002;

            __statist_i_h_wts[3, 72] = -1.93206845973144e-002;

            __statist_i_h_wts[3, 73] = 1.35725107033323e-001;

            __statist_i_h_wts[3, 74] = -1.13248220444808e-001;

            __statist_i_h_wts[3, 75] = -1.35062958254946e-001;

            __statist_i_h_wts[3, 76] = 3.31497949209672e-001;

            __statist_i_h_wts[3, 77] = -2.22656740704693e-001;

            __statist_i_h_wts[3, 78] = -4.65192592760755e-001;

            __statist_i_h_wts[3, 79] = 8.09625050816907e-001;

            __statist_i_h_wts[3, 80] = -1.37074866436307e-001;

            __statist_i_h_wts[3, 81] = -6.65652877507117e-002;

            __statist_i_h_wts[3, 82] = 2.96134496989439e-001;

            __statist_i_h_wts[3, 83] = -8.54188379680319e-002;

            __statist_i_h_wts[3, 84] = 5.64152860200647e-002;

            __statist_i_h_wts[3, 85] = 1.36643877183729e-001;

            __statist_i_h_wts[3, 86] = -2.16810409137193e-001;

            __statist_i_h_wts[3, 87] = 3.62080221670913e-002;

            __statist_i_h_wts[3, 88] = 2.99967664242150e-001;

            __statist_i_h_wts[3, 89] = -3.98932340594877e-001;

            __statist_i_h_wts[3, 90] = -2.65123934623478e-002;

            __statist_i_h_wts[3, 91] = 5.21644475561623e-001;

            __statist_i_h_wts[3, 92] = -3.99060639873683e-001;

            __statist_i_h_wts[3, 93] = 9.49694035630563e-003;

            __statist_i_h_wts[3, 94] = 4.68735796858483e-001;

            __statist_i_h_wts[3, 95] = -1.66389176804164e-001;

            __statist_i_h_wts[3, 96] = 8.29769759626509e-002;

            __statist_i_h_wts[3, 97] = 1.81010580832448e-001;

            __statist_i_h_wts[3, 98] = 2.69780642032450e-001;

            __statist_i_h_wts[3, 99] = 6.33073653915904e-002;

            __statist_i_h_wts[3, 100] = -2.17082603377121e-001;

            __statist_i_h_wts[3, 101] = 2.06925615879712e-001;

            __statist_i_h_wts[3, 102] = 2.13993553951439e-001;

            __statist_i_h_wts[3, 103] = -2.95694451615945e-001;

            __statist_i_h_wts[3, 104] = 1.51278813453470e+000;

            __statist_i_h_wts[3, 105] = 1.18624374911502e-001;

            __statist_i_h_wts[3, 106] = -1.56687129287168e+000;

            __statist_i_h_wts[3, 107] = 2.54100639964065e-001;

            __statist_i_h_wts[3, 108] = 1.88285179416008e-001;

            __statist_i_h_wts[3, 109] = -3.49420623456132e-001;

            __statist_i_h_wts[3, 110] = 1.80043939211238e-001;

            __statist_i_h_wts[3, 111] = 1.88515229846983e-002;

            __statist_i_h_wts[3, 112] = -1.30117852793643e-001;

            __statist_i_h_wts[3, 113] = 1.71011603170846e-001;

            __statist_i_h_wts[3, 114] = 2.01818697297000e-002;

            __statist_i_h_wts[3, 115] = -9.53356426096632e-002;

            __statist_i_h_wts[3, 116] = 9.85393465132729e-002;

            __statist_i_h_wts[3, 117] = 1.88940905369518e-001;

            __statist_i_h_wts[3, 118] = -1.89223494038034e-001;

            __statist_i_h_wts[3, 119] = 7.72713203979119e-001;

            __statist_i_h_wts[3, 120] = 3.15451042363227e-001;

            __statist_i_h_wts[3, 121] = -9.88416237581394e-001;

            __statist_i_h_wts[3, 122] = 1.89760910781794e-001;

            __statist_i_h_wts[3, 123] = 9.14081593784584e-002;

            __statist_i_h_wts[3, 124] = -1.82089570270320e-001;

            __statist_i_h_wts[3, 125] = 1.33047853284199e-001;

            __statist_i_h_wts[3, 126] = 1.42887779386719e-001;

            __statist_i_h_wts[3, 127] = -1.80797966246231e-001;



            __statist_i_h_wts[4, 0] = -1.79982374535263e-002;

            __statist_i_h_wts[4, 1] = -1.56072947762844e-001;

            __statist_i_h_wts[4, 2] = -1.16752166958770e-001;

            __statist_i_h_wts[4, 3] = 1.99402865263975e-001;

            __statist_i_h_wts[4, 4] = -1.15249906964186e-001;

            __statist_i_h_wts[4, 5] = 6.89130648992614e-002;

            __statist_i_h_wts[4, 6] = 1.37440953772963e-001;

            __statist_i_h_wts[4, 7] = 7.02336858826226e-002;

            __statist_i_h_wts[4, 8] = 2.65699310302523e-002;

            __statist_i_h_wts[4, 9] = 4.61281080774723e-002;

            __statist_i_h_wts[4, 10] = 2.40105187443919e-002;

            __statist_i_h_wts[4, 11] = -6.76535944706587e-002;

            __statist_i_h_wts[4, 12] = -2.40337276371249e-002;

            __statist_i_h_wts[4, 13] = -5.92972982464144e-002;

            __statist_i_h_wts[4, 14] = -1.08974727526754e-001;

            __statist_i_h_wts[4, 15] = -2.48007745765502e-002;

            __statist_i_h_wts[4, 16] = 1.50140514454246e-001;

            __statist_i_h_wts[4, 17] = 3.23237342864513e-002;

            __statist_i_h_wts[4, 18] = 1.48484436593722e-001;

            __statist_i_h_wts[4, 19] = -1.80210489526363e-001;

            __statist_i_h_wts[4, 20] = -1.54115447307045e-001;

            __statist_i_h_wts[4, 21] = 6.03116866418845e-002;

            __statist_i_h_wts[4, 22] = 9.42878517973044e-002;

            __statist_i_h_wts[4, 23] = 1.79914326761679e-001;

            __statist_i_h_wts[4, 24] = 2.69935655596191e-002;

            __statist_i_h_wts[4, 25] = 7.77019777424494e-002;

            __statist_i_h_wts[4, 26] = 3.10315029781846e-002;

            __statist_i_h_wts[4, 27] = 1.56632049784331e-001;

            __statist_i_h_wts[4, 28] = -1.25719403779981e-002;

            __statist_i_h_wts[4, 29] = -2.22838347853861e-001;

            __statist_i_h_wts[4, 30] = -1.63899353174856e-001;

            __statist_i_h_wts[4, 31] = 7.43949924871750e-002;

            __statist_i_h_wts[4, 32] = 8.97537525738855e-002;

            __statist_i_h_wts[4, 33] = -7.04518222348103e-002;

            __statist_i_h_wts[4, 34] = -4.53357854052936e-002;

            __statist_i_h_wts[4, 35] = -1.14223356550556e-001;

            __statist_i_h_wts[4, 36] = 2.43745489025751e-003;

            __statist_i_h_wts[4, 37] = -1.33749844892755e-001;

            __statist_i_h_wts[4, 38] = 7.19661749806044e-002;

            __statist_i_h_wts[4, 39] = 1.19035897327306e-001;

            __statist_i_h_wts[4, 40] = 1.33033121754193e-001;

            __statist_i_h_wts[4, 41] = 1.21614048578686e-001;

            __statist_i_h_wts[4, 42] = -7.64354873777818e-002;

            __statist_i_h_wts[4, 43] = -3.12138016912750e-002;

            __statist_i_h_wts[4, 44] = 3.02024265717123e-002;

            __statist_i_h_wts[4, 45] = 1.58867731927610e-002;

            __statist_i_h_wts[4, 46] = -1.06150256083208e-002;

            __statist_i_h_wts[4, 47] = 3.71683181830640e-002;

            __statist_i_h_wts[4, 48] = 2.85544936705012e-002;

            __statist_i_h_wts[4, 49] = 1.02280512261430e-001;

            __statist_i_h_wts[4, 50] = 3.05992289167070e-001;

            __statist_i_h_wts[4, 51] = 2.97407024446209e-001;

            __statist_i_h_wts[4, 52] = -6.02577201015610e-002;

            __statist_i_h_wts[4, 53] = 2.39654121991883e-001;

            __statist_i_h_wts[4, 54] = -5.87978940887690e-002;

            __statist_i_h_wts[4, 55] = -4.78481877944660e-001;

            __statist_i_h_wts[4, 56] = 1.62806515394560e-001;

            __statist_i_h_wts[4, 57] = 1.37148566167559e-001;

            __statist_i_h_wts[4, 58] = 2.89140354136417e-002;

            __statist_i_h_wts[4, 59] = -1.38967327335422e-001;

            __statist_i_h_wts[4, 60] = 1.07168234224716e-001;

            __statist_i_h_wts[4, 61] = 3.44207079826669e-001;

            __statist_i_h_wts[4, 62] = 4.87456642316165e-001;

            __statist_i_h_wts[4, 63] = -7.30864129513361e-001;

            __statist_i_h_wts[4, 64] = 5.99009475909254e-001;

            __statist_i_h_wts[4, 65] = -3.67887695965593e-001;

            __statist_i_h_wts[4, 66] = 4.17019032015610e-001;

            __statist_i_h_wts[4, 67] = 2.73735531801888e-001;

            __statist_i_h_wts[4, 68] = -1.04050134324036e-001;

            __statist_i_h_wts[4, 69] = 2.50093355840808e-001;

            __statist_i_h_wts[4, 70] = 1.48764057653642e-001;

            __statist_i_h_wts[4, 71] = 8.43728781532324e-002;

            __statist_i_h_wts[4, 72] = 9.81468805509269e-002;

            __statist_i_h_wts[4, 73] = 1.68072370430128e-001;

            __statist_i_h_wts[4, 74] = -1.53236046434887e-001;

            __statist_i_h_wts[4, 75] = 1.20353539763040e-001;

            __statist_i_h_wts[4, 76] = 3.74802493815038e-001;

            __statist_i_h_wts[4, 77] = 6.33809935617760e-001;

            __statist_i_h_wts[4, 78] = -1.34459059095598e+000;

            __statist_i_h_wts[4, 79] = 1.02033925617695e+000;

            __statist_i_h_wts[4, 80] = -8.30892443282339e-002;

            __statist_i_h_wts[4, 81] = 1.17386965391547e-001;

            __statist_i_h_wts[4, 82] = 3.03702826772465e-001;

            __statist_i_h_wts[4, 83] = -1.37517364179193e-001;

            __statist_i_h_wts[4, 84] = 3.31475360896056e-001;

            __statist_i_h_wts[4, 85] = 1.23646091914156e-001;

            __statist_i_h_wts[4, 86] = -6.11527554302138e-001;

            __statist_i_h_wts[4, 87] = 6.03466281376550e-001;

            __statist_i_h_wts[4, 88] = 3.43995468638691e-001;

            __statist_i_h_wts[4, 89] = -1.14399669040246e+000;

            __statist_i_h_wts[4, 90] = 8.60662584057785e-001;

            __statist_i_h_wts[4, 91] = 6.18415296623921e-001;

            __statist_i_h_wts[4, 92] = -8.93256217863749e-001;

            __statist_i_h_wts[4, 93] = 6.89094854699567e-001;

            __statist_i_h_wts[4, 94] = 5.41734546766366e-001;

            __statist_i_h_wts[4, 95] = -3.75904890700492e-001;

            __statist_i_h_wts[4, 96] = 5.27306757335980e-001;

            __statist_i_h_wts[4, 97] = 1.82084500872053e-001;

            __statist_i_h_wts[4, 98] = 5.26842660916424e-001;

            __statist_i_h_wts[4, 99] = 9.51432377231165e-002;

            __statist_i_h_wts[4, 100] = -2.90944198489432e-001;

            __statist_i_h_wts[4, 101] = 2.47426166979800e-001;

            __statist_i_h_wts[4, 102] = 3.48853603418972e-001;

            __statist_i_h_wts[4, 103] = -2.78547902807372e-001;

            __statist_i_h_wts[4, 104] = 2.46374702167356e+000;

            __statist_i_h_wts[4, 105] = -2.22454748580683e-001;

            __statist_i_h_wts[4, 106] = -1.89966693634995e+000;

            __statist_i_h_wts[4, 107] = 4.44859184038014e-001;

            __statist_i_h_wts[4, 108] = 2.39167774429047e-001;

            __statist_i_h_wts[4, 109] = -3.51119285793441e-001;

            __statist_i_h_wts[4, 110] = 5.99221304194342e-001;

            __statist_i_h_wts[4, 111] = -1.28969515549528e-001;

            __statist_i_h_wts[4, 112] = -1.22412741460980e-001;

            __statist_i_h_wts[4, 113] = 3.28147537781406e-001;

            __statist_i_h_wts[4, 114] = 1.17746581160257e-001;

            __statist_i_h_wts[4, 115] = -1.05455157146487e-001;

            __statist_i_h_wts[4, 116] = 7.72574749904518e-002;

            __statist_i_h_wts[4, 117] = 4.19828295922997e-001;

            __statist_i_h_wts[4, 118] = -1.83658723283850e-001;

            __statist_i_h_wts[4, 119] = 1.63818686436249e+000;

            __statist_i_h_wts[4, 120] = -1.45673803181327e-002;

            __statist_i_h_wts[4, 121] = -1.28577724790930e+000;

            __statist_i_h_wts[4, 122] = 2.83406992506193e-001;

            __statist_i_h_wts[4, 123] = 1.97939034310676e-001;

            __statist_i_h_wts[4, 124] = -1.49456162702294e-001;

            __statist_i_h_wts[4, 125] = 4.54284236991715e-001;

            __statist_i_h_wts[4, 126] = 7.66831569379754e-002;

            __statist_i_h_wts[4, 127] = -1.95743616547213e-001;



            __statist_i_h_wts[5, 0] = -1.13673330025784e-002;

            __statist_i_h_wts[5, 1] = -5.27881042857449e-002;

            __statist_i_h_wts[5, 2] = -7.95919943590127e-002;

            __statist_i_h_wts[5, 3] = 9.88544953564669e-002;

            __statist_i_h_wts[5, 4] = -3.10768222144950e-002;

            __statist_i_h_wts[5, 5] = 1.11409916563481e-002;

            __statist_i_h_wts[5, 6] = 4.96277258924013e-002;

            __statist_i_h_wts[5, 7] = 2.15888077935368e-002;

            __statist_i_h_wts[5, 8] = -2.12463165002850e-002;

            __statist_i_h_wts[5, 9] = 3.33159026929848e-002;

            __statist_i_h_wts[5, 10] = 1.01340557047150e-002;

            __statist_i_h_wts[5, 11] = -4.52750545608044e-002;

            __statist_i_h_wts[5, 12] = 1.03627899302133e-002;

            __statist_i_h_wts[5, 13] = -2.03034021565045e-002;

            __statist_i_h_wts[5, 14] = -6.62686754511689e-002;

            __statist_i_h_wts[5, 15] = -2.51325359123306e-002;

            __statist_i_h_wts[5, 16] = 6.65564232342640e-002;

            __statist_i_h_wts[5, 17] = 1.59457011606693e-002;

            __statist_i_h_wts[5, 18] = 3.15389653733409e-002;

            __statist_i_h_wts[5, 19] = -1.03137855579185e-001;

            __statist_i_h_wts[5, 20] = -6.14174093175757e-002;

            __statist_i_h_wts[5, 21] = 2.71843853560772e-002;

            __statist_i_h_wts[5, 22] = 2.95559716002402e-002;

            __statist_i_h_wts[5, 23] = 8.68872556228352e-002;

            __statist_i_h_wts[5, 24] = 3.14496243316885e-002;

            __statist_i_h_wts[5, 25] = 2.43561096877456e-002;

            __statist_i_h_wts[5, 26] = 8.83078251369609e-003;

            __statist_i_h_wts[5, 27] = 6.09110409223170e-002;

            __statist_i_h_wts[5, 28] = -2.38324226944894e-002;

            __statist_i_h_wts[5, 29] = -1.10358127900544e-001;

            __statist_i_h_wts[5, 30] = -5.89644800310438e-002;

            __statist_i_h_wts[5, 31] = 4.26605283046117e-002;

            __statist_i_h_wts[5, 32] = 4.07431004521548e-002;

            __statist_i_h_wts[5, 33] = -3.09324937526019e-002;

            __statist_i_h_wts[5, 34] = -2.23675566729923e-002;

            __statist_i_h_wts[5, 35] = -4.42689244658007e-002;

            __statist_i_h_wts[5, 36] = 4.85500695731624e-003;

            __statist_i_h_wts[5, 37] = -4.71237349963364e-002;

            __statist_i_h_wts[5, 38] = 2.21900344552286e-002;

            __statist_i_h_wts[5, 39] = 4.55522725657271e-002;

            __statist_i_h_wts[5, 40] = 4.66296258282289e-002;

            __statist_i_h_wts[5, 41] = 3.95964056554887e-002;

            __statist_i_h_wts[5, 42] = 3.22365038489849e-002;

            __statist_i_h_wts[5, 43] = -2.49074637557516e-002;

            __statist_i_h_wts[5, 44] = 2.11243020721648e-002;

            __statist_i_h_wts[5, 45] = 5.36785143818994e-003;

            __statist_i_h_wts[5, 46] = -2.04000178150340e-002;

            __statist_i_h_wts[5, 47] = 9.50518998995354e-003;

            __statist_i_h_wts[5, 48] = -1.23191060043645e-002;

            __statist_i_h_wts[5, 49] = 2.96214776009934e-002;

            __statist_i_h_wts[5, 50] = 5.22899922744333e-002;

            __statist_i_h_wts[5, 51] = 2.71246581736798e-002;

            __statist_i_h_wts[5, 52] = 9.66566748048475e-003;

            __statist_i_h_wts[5, 53] = 8.24929789182388e-002;

            __statist_i_h_wts[5, 54] = 2.26580499012478e-003;

            __statist_i_h_wts[5, 55] = -1.47269692484248e-001;

            __statist_i_h_wts[5, 56] = 7.67703239138430e-002;

            __statist_i_h_wts[5, 57] = -2.94092842582958e-002;

            __statist_i_h_wts[5, 58] = 1.24793779617915e-002;

            __statist_i_h_wts[5, 59] = -3.73712250886789e-002;

            __statist_i_h_wts[5, 60] = -6.88539542166009e-002;

            __statist_i_h_wts[5, 61] = 1.57803996511164e-001;

            __statist_i_h_wts[5, 62] = -1.16918057168511e-001;

            __statist_i_h_wts[5, 63] = -8.43998177457786e-002;

            __statist_i_h_wts[5, 64] = 2.32159304531880e-001;

            __statist_i_h_wts[5, 65] = -9.63885211316519e-002;

            __statist_i_h_wts[5, 66] = 4.65672740455349e-002;

            __statist_i_h_wts[5, 67] = 1.09180258216809e-001;

            __statist_i_h_wts[5, 68] = -3.72903290553190e-002;

            __statist_i_h_wts[5, 69] = 1.27564689958846e-003;

            __statist_i_h_wts[5, 70] = 8.97069854536043e-002;

            __statist_i_h_wts[5, 71] = 1.95980830483406e-002;

            __statist_i_h_wts[5, 72] = -2.60746367540942e-002;

            __statist_i_h_wts[5, 73] = 6.42507282963797e-002;

            __statist_i_h_wts[5, 74] = -4.00760641551274e-002;

            __statist_i_h_wts[5, 75] = -7.28159737235218e-002;

            __statist_i_h_wts[5, 76] = 1.64552760351586e-001;

            __statist_i_h_wts[5, 77] = -1.54048246499422e-001;

            __statist_i_h_wts[5, 78] = -2.00142801634178e-001;

            __statist_i_h_wts[5, 79] = 3.77326461453423e-001;

            __statist_i_h_wts[5, 80] = -5.89041702309694e-002;

            __statist_i_h_wts[5, 81] = -3.36107330685458e-002;

            __statist_i_h_wts[5, 82] = 1.35243130904394e-001;

            __statist_i_h_wts[5, 83] = -4.81861708901019e-002;

            __statist_i_h_wts[5, 84] = 4.60387744173621e-002;

            __statist_i_h_wts[5, 85] = 7.29319564395594e-002;

            __statist_i_h_wts[5, 86] = -1.99342074300683e-002;

            __statist_i_h_wts[5, 87] = -7.65629867980522e-002;

            __statist_i_h_wts[5, 88] = 1.40303152993580e-001;

            __statist_i_h_wts[5, 89] = -1.18292265623205e-001;

            __statist_i_h_wts[5, 90] = -6.77562096254470e-002;

            __statist_i_h_wts[5, 91] = 2.66314503207336e-001;

            __statist_i_h_wts[5, 92] = -1.52788450495917e-001;

            __statist_i_h_wts[5, 93] = -3.53909753325731e-002;

            __statist_i_h_wts[5, 94] = 2.35641941494872e-001;

            __statist_i_h_wts[5, 95] = -4.15897571320929e-002;

            __statist_i_h_wts[5, 96] = 1.22026211149918e-002;

            __statist_i_h_wts[5, 97] = 7.95656548380941e-002;

            __statist_i_h_wts[5, 98] = 1.59125786338626e-001;

            __statist_i_h_wts[5, 99] = 2.50363274797043e-004;

            __statist_i_h_wts[5, 100] = -1.23413915218206e-001;

            __statist_i_h_wts[5, 101] = 1.24434006595756e-001;

            __statist_i_h_wts[5, 102] = 5.54802638975921e-002;

            __statist_i_h_wts[5, 103] = -1.33984435370667e-001;

            __statist_i_h_wts[5, 104] = 6.83918238001224e-001;

            __statist_i_h_wts[5, 105] = 1.41780380045963e-001;

            __statist_i_h_wts[5, 106] = -7.89002059706447e-001;

            __statist_i_h_wts[5, 107] = 1.11577475056032e-001;

            __statist_i_h_wts[5, 108] = 9.98547566858972e-002;

            __statist_i_h_wts[5, 109] = -1.64246698738632e-001;

            __statist_i_h_wts[5, 110] = 7.35179815952758e-002;

            __statist_i_h_wts[5, 111] = 3.75199361286064e-002;

            __statist_i_h_wts[5, 112] = -5.95294268114065e-002;

            __statist_i_h_wts[5, 113] = 1.09959068371217e-001;

            __statist_i_h_wts[5, 114] = -1.19228400394114e-002;

            __statist_i_h_wts[5, 115] = -5.19976270980948e-002;

            __statist_i_h_wts[5, 116] = 8.27176901604162e-002;

            __statist_i_h_wts[5, 117] = 5.14938648441425e-002;

            __statist_i_h_wts[5, 118] = -1.06690883894251e-001;

            __statist_i_h_wts[5, 119] = 3.08156216338050e-001;

            __statist_i_h_wts[5, 120] = 2.34535353179928e-001;

            __statist_i_h_wts[5, 121] = -4.93304131229065e-001;

            __statist_i_h_wts[5, 122] = 8.61217424141730e-002;

            __statist_i_h_wts[5, 123] = 5.68243775562962e-002;

            __statist_i_h_wts[5, 124] = -7.92368766697931e-002;

            __statist_i_h_wts[5, 125] = 5.16260160068993e-002;

            __statist_i_h_wts[5, 126] = 8.18929599076119e-002;

            __statist_i_h_wts[5, 127] = -9.66098382491333e-002;



            __statist_i_h_wts[6, 0] = -1.30719399003875e-002;

            __statist_i_h_wts[6, 1] = 2.52778806212769e-003;

            __statist_i_h_wts[6, 2] = -8.08490654815260e-002;

            __statist_i_h_wts[6, 3] = 6.12257218946510e-002;

            __statist_i_h_wts[6, 4] = -2.54801005716074e-002;

            __statist_i_h_wts[6, 5] = -3.12092610522084e-002;

            __statist_i_h_wts[6, 6] = -8.95357111054615e-003;

            __statist_i_h_wts[6, 7] = -1.36630439187166e-002;

            __statist_i_h_wts[6, 8] = -5.95469364128995e-002;

            __statist_i_h_wts[6, 9] = -1.47469648990601e-002;

            __statist_i_h_wts[6, 10] = -4.61572969916914e-002;

            __statist_i_h_wts[6, 11] = -8.87550363823056e-003;

            __statist_i_h_wts[6, 12] = 5.59064004025184e-002;

            __statist_i_h_wts[6, 13] = -1.92532192080744e-002;

            __statist_i_h_wts[6, 14] = -4.69265446876167e-002;

            __statist_i_h_wts[6, 15] = -1.67765208104748e-002;

            __statist_i_h_wts[6, 16] = 4.64144718720439e-002;

            __statist_i_h_wts[6, 17] = 2.32266451111566e-002;

            __statist_i_h_wts[6, 18] = -1.72989993854765e-002;

            __statist_i_h_wts[6, 19] = -7.30089827046291e-002;

            __statist_i_h_wts[6, 20] = -3.80125730286873e-002;

            __statist_i_h_wts[6, 21] = 2.17028867924237e-002;

            __statist_i_h_wts[6, 22] = 3.34970210918649e-002;

            __statist_i_h_wts[6, 23] = 7.44202022111832e-002;

            __statist_i_h_wts[6, 24] = 3.08113608878942e-002;

            __statist_i_h_wts[6, 25] = -2.04937416488533e-002;

            __statist_i_h_wts[6, 26] = -3.87329861159479e-003;

            __statist_i_h_wts[6, 27] = 5.36448186017680e-002;

            __statist_i_h_wts[6, 28] = -1.09768284649234e-002;

            __statist_i_h_wts[6, 29] = -7.17045567100764e-002;

            __statist_i_h_wts[6, 30] = -4.74742779522092e-002;

            __statist_i_h_wts[6, 31] = -4.16791295820092e-004;

            __statist_i_h_wts[6, 32] = -2.59206628455638e-002;

            __statist_i_h_wts[6, 33] = 2.07880208031409e-002;

            __statist_i_h_wts[6, 34] = -8.75297996691623e-003;

            __statist_i_h_wts[6, 35] = -2.73017887973203e-002;

            __statist_i_h_wts[6, 36] = -5.23240645576982e-003;

            __statist_i_h_wts[6, 37] = -4.16218482349514e-003;

            __statist_i_h_wts[6, 38] = 3.38734113759745e-002;

            __statist_i_h_wts[6, 39] = 3.60674432477440e-002;

            __statist_i_h_wts[6, 40] = 3.15846303858747e-002;

            __statist_i_h_wts[6, 41] = 2.05186916634927e-005;

            __statist_i_h_wts[6, 42] = 8.76415563836430e-002;

            __statist_i_h_wts[6, 43] = -5.50406164589149e-003;

            __statist_i_h_wts[6, 44] = -1.52075083952498e-002;

            __statist_i_h_wts[6, 45] = -1.28054633098568e-002;

            __statist_i_h_wts[6, 46] = -1.44911848212888e-002;

            __statist_i_h_wts[6, 47] = 1.61090939250769e-002;

            __statist_i_h_wts[6, 48] = -4.48807692998320e-003;

            __statist_i_h_wts[6, 49] = -1.67750094382461e-002;

            __statist_i_h_wts[6, 50] = -1.22777226122563e-001;

            __statist_i_h_wts[6, 51] = -1.57563801355185e-001;

            __statist_i_h_wts[6, 52] = 1.22252048728062e-002;

            __statist_i_h_wts[6, 53] = -2.15866072010295e-002;

            __statist_i_h_wts[6, 54] = 5.41424320735031e-002;

            __statist_i_h_wts[6, 55] = 6.52912706376548e-002;

            __statist_i_h_wts[6, 56] = -6.47786883498296e-002;

            __statist_i_h_wts[6, 57] = -9.21851585394640e-002;

            __statist_i_h_wts[6, 58] = 1.65117384133935e-002;

            __statist_i_h_wts[6, 59] = -1.08271759870683e-001;

            __statist_i_h_wts[6, 60] = -1.09793857799239e-001;

            __statist_i_h_wts[6, 61] = 6.98470502058820e-002;

            __statist_i_h_wts[6, 62] = -3.56466127396046e-001;

            __statist_i_h_wts[6, 63] = 1.25990784852679e-001;

            __statist_i_h_wts[6, 64] = 5.64570014443332e-002;

            __statist_i_h_wts[6, 65] = 4.06371284631721e-002;

            __statist_i_h_wts[6, 66] = -1.75017342651982e-001;

            __statist_i_h_wts[6, 67] = -5.62863553556034e-003;

            __statist_i_h_wts[6, 68] = -3.36409982933536e-002;

            __statist_i_h_wts[6, 69] = -1.71582853007009e-001;

            __statist_i_h_wts[6, 70] = 5.82002778866170e-002;

            __statist_i_h_wts[6, 71] = -1.29964654938858e-001;

            __statist_i_h_wts[6, 72] = -4.20066745589386e-002;

            __statist_i_h_wts[6, 73] = 9.64698154378249e-004;

            __statist_i_h_wts[6, 74] = -6.53969637465698e-002;

            __statist_i_h_wts[6, 75] = -1.69630094409640e-001;

            __statist_i_h_wts[6, 76] = 7.09676536918294e-002;

            __statist_i_h_wts[6, 77] = -5.48816273719392e-001;

            __statist_i_h_wts[6, 78] = 3.51478497372728e-001;

            __statist_i_h_wts[6, 79] = 5.63924551536731e-002;

            __statist_i_h_wts[6, 80] = -7.95327066076812e-002;

            __statist_i_h_wts[6, 81] = -1.19288057442855e-001;

            __statist_i_h_wts[6, 82] = 4.60184967627267e-002;

            __statist_i_h_wts[6, 83] = -4.13700331925783e-002;

            __statist_i_h_wts[6, 84] = -1.70239334508689e-001;

            __statist_i_h_wts[6, 85] = 4.23442733690863e-002;

            __statist_i_h_wts[6, 86] = 1.17689259644069e-001;

            __statist_i_h_wts[6, 87] = -2.88608468027035e-001;

            __statist_i_h_wts[6, 88] = 3.17981060325660e-002;

            __statist_i_h_wts[6, 89] = 3.00024679289279e-001;

            __statist_i_h_wts[6, 90] = -5.07973114679649e-001;

            __statist_i_h_wts[6, 91] = 5.43737793386313e-002;

            __statist_i_h_wts[6, 92] = 2.10033779912623e-001;

            __statist_i_h_wts[6, 93] = -4.29215070347254e-001;

            __statist_i_h_wts[6, 94] = 7.25754977941082e-002;

            __statist_i_h_wts[6, 95] = 9.29513703795684e-002;

            __statist_i_h_wts[6, 96] = -2.52814761991702e-001;

            __statist_i_h_wts[6, 97] = 4.15057826257741e-002;

            __statist_i_h_wts[6, 98] = -1.46193850839743e-001;

            __statist_i_h_wts[6, 99] = 1.71924626136773e-002;

            __statist_i_h_wts[6, 100] = -2.44015555450624e-002;

            __statist_i_h_wts[6, 101] = -2.50390111804246e-002;

            __statist_i_h_wts[6, 102] = -1.84547623453142e-002;

            __statist_i_h_wts[6, 103] = -9.22465177434746e-002;

            __statist_i_h_wts[6, 104] = -1.68220365894704e-001;

            __statist_i_h_wts[6, 105] = 1.83940996501161e-001;

            __statist_i_h_wts[6, 106] = -1.45865908523419e-001;

            __statist_i_h_wts[6, 107] = -5.57039415665557e-002;

            __statist_i_h_wts[6, 108] = -1.09468918075718e-002;

            __statist_i_h_wts[6, 109] = -8.92918969309331e-002;

            __statist_i_h_wts[6, 110] = -2.21649148775077e-001;

            __statist_i_h_wts[6, 111] = 7.89611421991997e-002;

            __statist_i_h_wts[6, 112] = -2.61272214949891e-002;

            __statist_i_h_wts[6, 113] = -1.37843537924340e-001;

            __statist_i_h_wts[6, 114] = 1.44776710411648e-003;

            __statist_i_h_wts[6, 115] = -1.13134143803597e-002;

            __statist_i_h_wts[6, 116] = -1.88558767494963e-002;

            __statist_i_h_wts[6, 117] = -7.29366884120746e-002;

            __statist_i_h_wts[6, 118] = -7.14801697837509e-002;

            __statist_i_h_wts[6, 119] = -3.13002702459620e-001;

            __statist_i_h_wts[6, 120] = 1.96528713341343e-001;

            __statist_i_h_wts[6, 121] = -6.41528923387495e-002;

            __statist_i_h_wts[6, 122] = -2.84400537512608e-002;

            __statist_i_h_wts[6, 123] = -6.25181661714280e-002;

            __statist_i_h_wts[6, 124] = -7.94740530717002e-002;

            __statist_i_h_wts[6, 125] = -1.65709867683288e-001;

            __statist_i_h_wts[6, 126] = 4.46153576983803e-002;

            __statist_i_h_wts[6, 127] = -4.03246711111118e-002;



            __statist_i_h_wts[7, 0] = 2.65206757068054e-003;

            __statist_i_h_wts[7, 1] = -9.40818077445794e-003;

            __statist_i_h_wts[7, 2] = -7.20918274363967e-002;

            __statist_i_h_wts[7, 3] = 3.26515396366028e-002;

            __statist_i_h_wts[7, 4] = -1.41910804256485e-002;

            __statist_i_h_wts[7, 5] = -1.16916653503556e-002;

            __statist_i_h_wts[7, 6] = -1.39134024286714e-002;

            __statist_i_h_wts[7, 7] = -9.80575771199609e-003;

            __statist_i_h_wts[7, 8] = -1.19527100652642e-002;

            __statist_i_h_wts[7, 9] = -2.70333119883911e-002;

            __statist_i_h_wts[7, 10] = -2.06940226795426e-002;

            __statist_i_h_wts[7, 11] = -2.60282886793935e-002;

            __statist_i_h_wts[7, 12] = 3.89271402251566e-002;

            __statist_i_h_wts[7, 13] = -4.06846429274465e-003;

            __statist_i_h_wts[7, 14] = -3.13228858663815e-002;

            __statist_i_h_wts[7, 15] = -2.25039088244851e-002;

            __statist_i_h_wts[7, 16] = 2.55587311743789e-002;

            __statist_i_h_wts[7, 17] = -7.84462994975063e-003;

            __statist_i_h_wts[7, 18] = -2.97798443780040e-003;

            __statist_i_h_wts[7, 19] = -6.40736859910200e-002;

            __statist_i_h_wts[7, 20] = -2.21874000551080e-002;

            __statist_i_h_wts[7, 21] = 1.67154454026157e-002;

            __statist_i_h_wts[7, 22] = 8.63203325928925e-003;

            __statist_i_h_wts[7, 23] = 3.88056162505474e-002;

            __statist_i_h_wts[7, 24] = 1.17911032754714e-002;

            __statist_i_h_wts[7, 25] = -6.60168946071151e-003;

            __statist_i_h_wts[7, 26] = -9.53279238026564e-003;

            __statist_i_h_wts[7, 27] = 3.28636776842835e-002;

            __statist_i_h_wts[7, 28] = -8.00404785599711e-003;

            __statist_i_h_wts[7, 29] = -3.86453759197554e-002;

            __statist_i_h_wts[7, 30] = -1.35541744704268e-002;

            __statist_i_h_wts[7, 31] = 1.97027432632157e-002;

            __statist_i_h_wts[7, 32] = 9.02408724779545e-003;

            __statist_i_h_wts[7, 33] = 4.65621380652230e-003;

            __statist_i_h_wts[7, 34] = 2.99298701036471e-003;

            __statist_i_h_wts[7, 35] = -2.90830219173792e-003;

            __statist_i_h_wts[7, 36] = -4.01932974127525e-003;

            __statist_i_h_wts[7, 37] = -1.18295746859376e-002;

            __statist_i_h_wts[7, 38] = 1.89330029498396e-002;

            __statist_i_h_wts[7, 39] = 2.64332566640637e-002;

            __statist_i_h_wts[7, 40] = 1.32005085935918e-002;

            __statist_i_h_wts[7, 41] = 1.35984386998230e-002;

            __statist_i_h_wts[7, 42] = 5.34458338043937e-002;

            __statist_i_h_wts[7, 43] = -1.09089933381600e-002;

            __statist_i_h_wts[7, 44] = -2.23078203812080e-002;

            __statist_i_h_wts[7, 45] = -3.87223037545137e-003;

            __statist_i_h_wts[7, 46] = 1.40710675468445e-003;

            __statist_i_h_wts[7, 47] = 3.53447247270508e-003;

            __statist_i_h_wts[7, 48] = 3.33303923414474e-003;

            __statist_i_h_wts[7, 49] = -6.28945475067936e-003;

            __statist_i_h_wts[7, 50] = -7.20121107286645e-002;

            __statist_i_h_wts[7, 51] = -9.15464597580052e-002;

            __statist_i_h_wts[7, 52] = 1.99685792706601e-002;

            __statist_i_h_wts[7, 53] = -8.60046867586818e-003;

            __statist_i_h_wts[7, 54] = 2.80552151907150e-002;

            __statist_i_h_wts[7, 55] = 2.69970513458446e-002;

            __statist_i_h_wts[7, 56] = -1.63412203624010e-002;

            __statist_i_h_wts[7, 57] = -6.25385281897289e-002;

            __statist_i_h_wts[7, 58] = 8.21409151774727e-003;

            __statist_i_h_wts[7, 59] = -4.44058381995539e-002;

            __statist_i_h_wts[7, 60] = -1.01711614933010e-001;

            __statist_i_h_wts[7, 61] = 5.48306523545237e-002;

            __statist_i_h_wts[7, 62] = -2.23937954219758e-001;

            __statist_i_h_wts[7, 63] = 1.03184907371884e-001;

            __statist_i_h_wts[7, 64] = 4.59240738756618e-002;

            __statist_i_h_wts[7, 65] = 2.86913023983035e-002;

            __statist_i_h_wts[7, 66] = -1.14390160332828e-001;

            __statist_i_h_wts[7, 67] = 1.10955511171212e-002;

            __statist_i_h_wts[7, 68] = -1.66922509972112e-002;

            __statist_i_h_wts[7, 69] = -1.04582616849010e-001;

            __statist_i_h_wts[7, 70] = 3.73490104713901e-002;

            __statist_i_h_wts[7, 71] = -5.51301265144029e-002;

            __statist_i_h_wts[7, 72] = -3.45202394908947e-002;

            __statist_i_h_wts[7, 73] = 1.30737580958960e-002;

            __statist_i_h_wts[7, 74] = -3.00573013476465e-002;

            __statist_i_h_wts[7, 75] = -1.00975229635724e-001;

            __statist_i_h_wts[7, 76] = 5.71753465184583e-002;

            __statist_i_h_wts[7, 77] = -3.52886308658559e-001;

            __statist_i_h_wts[7, 78] = 2.22368106386804e-001;

            __statist_i_h_wts[7, 79] = 5.70819733048376e-002;

            __statist_i_h_wts[7, 80] = -5.64099727627825e-002;

            __statist_i_h_wts[7, 81] = -7.97465704916529e-002;

            __statist_i_h_wts[7, 82] = 4.05659441203296e-002;

            __statist_i_h_wts[7, 83] = -7.45251586517762e-003;

            __statist_i_h_wts[7, 84] = -8.06823311262320e-002;

            __statist_i_h_wts[7, 85] = 2.36851207032430e-002;

            __statist_i_h_wts[7, 86] = 9.26197468518947e-002;

            __statist_i_h_wts[7, 87] = -1.97510449747888e-001;

            __statist_i_h_wts[7, 88] = 2.99037949103310e-002;

            __statist_i_h_wts[7, 89] = 1.98517558626647e-001;

            __statist_i_h_wts[7, 90] = -3.26713131816557e-001;

            __statist_i_h_wts[7, 91] = 3.28563219469787e-002;

            __statist_i_h_wts[7, 92] = 1.31279942093028e-001;

            __statist_i_h_wts[7, 93] = -2.65596873370619e-001;

            __statist_i_h_wts[7, 94] = 5.24586211482332e-002;

            __statist_i_h_wts[7, 95] = 6.44882083710550e-002;

            __statist_i_h_wts[7, 96] = -1.70806043268372e-001;

            __statist_i_h_wts[7, 97] = 3.37019378968519e-002;

            __statist_i_h_wts[7, 98] = -5.90426748890736e-002;

            __statist_i_h_wts[7, 99] = 2.72111100766221e-002;

            __statist_i_h_wts[7, 100] = -2.88488878016829e-002;

            __statist_i_h_wts[7, 101] = 1.32373394116155e-002;

            __statist_i_h_wts[7, 102] = -3.35491149024138e-002;

            __statist_i_h_wts[7, 103] = -5.73846302872956e-002;

            __statist_i_h_wts[7, 104] = -8.82389821243927e-002;

            __statist_i_h_wts[7, 105] = 1.38929278749895e-001;

            __statist_i_h_wts[7, 106] = -1.34115773244761e-001;

            __statist_i_h_wts[7, 107] = -3.83875647647456e-002;

            __statist_i_h_wts[7, 108] = 4.45637418630084e-003;

            __statist_i_h_wts[7, 109] = -6.76492758678918e-002;

            __statist_i_h_wts[7, 110] = -1.25250334255289e-001;

            __statist_i_h_wts[7, 111] = 8.22470904858482e-002;

            __statist_i_h_wts[7, 112] = -8.29180599848114e-003;

            __statist_i_h_wts[7, 113] = -5.97083988460392e-002;

            __statist_i_h_wts[7, 114] = -2.52823766098506e-003;

            __statist_i_h_wts[7, 115] = -2.67561117280581e-002;

            __statist_i_h_wts[7, 116] = 1.70132493917298e-002;

            __statist_i_h_wts[7, 117] = -2.41249352765370e-002;

            __statist_i_h_wts[7, 118] = -4.88443587459795e-002;

            __statist_i_h_wts[7, 119] = -1.84944420113246e-001;

            __statist_i_h_wts[7, 120] = 1.64513092067416e-001;

            __statist_i_h_wts[7, 121] = -6.79285342144223e-002;

            __statist_i_h_wts[7, 122] = -1.39095511950206e-002;

            __statist_i_h_wts[7, 123] = -3.41174668347026e-002;

            __statist_i_h_wts[7, 124] = -6.04430022366875e-002;

            __statist_i_h_wts[7, 125] = -8.94011213158899e-002;

            __statist_i_h_wts[7, 126] = 4.74846839888702e-002;

            __statist_i_h_wts[7, 127] = -3.70423133611077e-002;



            double[,] __statist_h_o_wts = new double[2, 8];



            __statist_h_o_wts[0, 0] = -4.35076787365484e-001;

            __statist_h_o_wts[0, 1] = -4.74030762413647e-001;

            __statist_h_o_wts[0, 2] = 1.30770003586168e-001;

            __statist_h_o_wts[0, 3] = 3.10539352563985e-001;

            __statist_h_o_wts[0, 4] = 9.33964369463023e-002;

            __statist_h_o_wts[0, 5] = 1.02848704643714e-001;

            __statist_h_o_wts[0, 6] = 2.01647447959057e-001;

            __statist_h_o_wts[0, 7] = 1.39731806533204e-001;



            __statist_h_o_wts[1, 0] = 4.81044269786132e-001;

            __statist_h_o_wts[1, 1] = 4.38122102245335e-001;

            __statist_h_o_wts[1, 2] = -1.64265388360487e-001;

            __statist_h_o_wts[1, 3] = -3.15427080394505e-001;

            __statist_h_o_wts[1, 4] = -6.90624358809254e-002;

            __statist_h_o_wts[1, 5] = -2.11985889241166e-001;

            __statist_h_o_wts[1, 6] = -1.87356044348062e-001;

            __statist_h_o_wts[1, 7] = -1.17500860643799e-001;



            double[] __statist_hidden_bias = new double[8];

            __statist_hidden_bias[0] = -2.46958816010702e-001;

            __statist_hidden_bias[1] = 1.50069508414803e-001;

            __statist_hidden_bias[2] = 2.04330186960182e-001;

            __statist_hidden_bias[3] = 9.13172547716729e-002;

            __statist_hidden_bias[4] = 3.13482603314538e-001;

            __statist_hidden_bias[5] = 5.06111796441045e-002;

            __statist_hidden_bias[6] = -1.49909685887112e-001;

            __statist_hidden_bias[7] = -8.77241644341331e-002;



            double[] __statist_output_bias = new double[2];

            __statist_output_bias[0] = 2.49753448893251e-001;

            __statist_output_bias[1] = -3.37962964650893e-001;



            double[] __statist_inputs = new double[128];



            double[] __statist_hidden = new double[8];



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

            int __statist_nhidden = 8;



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



       public static string[] Main (string[] args) 
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

         return MLP_128_8_2(CatInputs);
       }
        
    }
}
