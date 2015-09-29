using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn6
{
    class Predict_Top
    {
        public static string[] MLP_128_20_2(string[] CatInputs)
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

            __statist_DCats[1] = "1";



            double __statist_ConfLevel = 3.0E-300;







            double[,] __statist_i_h_wts = new double[20, 128];



            __statist_i_h_wts[0, 0] = -2.84972942561158e-002;

            __statist_i_h_wts[0, 1] = -5.87667283414164e-002;

            __statist_i_h_wts[0, 2] = -9.75979833081872e-003;

            __statist_i_h_wts[0, 3] = 3.19811121459524e-002;

            __statist_i_h_wts[0, 4] = -1.46954932956612e-002;

            __statist_i_h_wts[0, 5] = 1.65851180146167e-002;

            __statist_i_h_wts[0, 6] = 3.13942698026052e-003;

            __statist_i_h_wts[0, 7] = 2.08782190661417e-002;

            __statist_i_h_wts[0, 8] = 2.46372778899599e-002;

            __statist_i_h_wts[0, 9] = 1.51900961429118e-002;

            __statist_i_h_wts[0, 10] = 1.60381241367094e-002;

            __statist_i_h_wts[0, 11] = 4.29097249784035e-002;

            __statist_i_h_wts[0, 12] = -6.52118330364609e-002;

            __statist_i_h_wts[0, 13] = -2.66331363213362e-002;

            __statist_i_h_wts[0, 14] = -1.77514194979376e-002;

            __statist_i_h_wts[0, 15] = -1.86523047984882e-002;

            __statist_i_h_wts[0, 16] = 8.27453555170857e-003;

            __statist_i_h_wts[0, 17] = -4.40704564816891e-002;

            __statist_i_h_wts[0, 18] = 2.40735848874530e-003;

            __statist_i_h_wts[0, 19] = -9.85031454305847e-003;

            __statist_i_h_wts[0, 20] = -5.06694801648734e-002;

            __statist_i_h_wts[0, 21] = -3.17981705326670e-003;

            __statist_i_h_wts[0, 22] = -2.79975228207116e-002;

            __statist_i_h_wts[0, 23] = 2.21774967327613e-002;

            __statist_i_h_wts[0, 24] = 5.16514863967771e-003;

            __statist_i_h_wts[0, 25] = -6.12642046112777e-003;

            __statist_i_h_wts[0, 26] = -7.13071038095117e-003;

            __statist_i_h_wts[0, 27] = -6.77580486193977e-003;

            __statist_i_h_wts[0, 28] = -7.97034699057901e-003;

            __statist_i_h_wts[0, 29] = 1.34772398606902e-002;

            __statist_i_h_wts[0, 30] = 2.64954951116383e-002;

            __statist_i_h_wts[0, 31] = 1.48756613067162e-002;

            __statist_i_h_wts[0, 32] = 1.87335897431737e-002;

            __statist_i_h_wts[0, 33] = -6.67520787648773e-003;

            __statist_i_h_wts[0, 34] = -2.88555175068511e-002;

            __statist_i_h_wts[0, 35] = -3.14215816322401e-003;

            __statist_i_h_wts[0, 36] = 7.53530460619011e-003;

            __statist_i_h_wts[0, 37] = -3.74678428994198e-002;

            __statist_i_h_wts[0, 38] = -1.29565687285104e-002;

            __statist_i_h_wts[0, 39] = -8.66121844231287e-003;

            __statist_i_h_wts[0, 40] = 2.13188131801468e-002;

            __statist_i_h_wts[0, 41] = -1.32981291135585e-002;

            __statist_i_h_wts[0, 42] = -2.12053087605931e-001;

            __statist_i_h_wts[0, 43] = -3.48347114224747e-002;

            __statist_i_h_wts[0, 44] = -2.46961695196577e-002;

            __statist_i_h_wts[0, 45] = 8.47058227729454e-003;

            __statist_i_h_wts[0, 46] = -8.24307894026785e-003;

            __statist_i_h_wts[0, 47] = -1.81976670287487e-003;

            __statist_i_h_wts[0, 48] = 8.32593605380382e-002;

            __statist_i_h_wts[0, 49] = 3.48037055382521e-002;

            __statist_i_h_wts[0, 50] = 1.69909865060514e-002;

            __statist_i_h_wts[0, 51] = 1.21061734360492e-001;

            __statist_i_h_wts[0, 52] = 1.50426341297827e-001;

            __statist_i_h_wts[0, 53] = 7.30662188967948e-002;

            __statist_i_h_wts[0, 54] = -1.32601230622518e-001;

            __statist_i_h_wts[0, 55] = -8.98848356278436e-002;

            __statist_i_h_wts[0, 56] = -1.14949066178675e-001;

            __statist_i_h_wts[0, 57] = -1.22275181915642e-002;

            __statist_i_h_wts[0, 58] = 2.54602854296231e-002;

            __statist_i_h_wts[0, 59] = -2.94341493545428e-002;

            __statist_i_h_wts[0, 60] = -1.15785112904157e-001;

            __statist_i_h_wts[0, 61] = 3.21368397369951e-002;

            __statist_i_h_wts[0, 62] = -6.95568108996296e-001;

            __statist_i_h_wts[0, 63] = 1.88245849458189e-001;

            __statist_i_h_wts[0, 64] = 3.90082829558717e-001;

            __statist_i_h_wts[0, 65] = 4.18827244691596e-002;

            __statist_i_h_wts[0, 66] = -2.86692084252373e-001;

            __statist_i_h_wts[0, 67] = 1.50943580348495e-001;

            __statist_i_h_wts[0, 68] = -2.40860240889805e-001;

            __statist_i_h_wts[0, 69] = 1.35526500270249e-001;

            __statist_i_h_wts[0, 70] = 3.72942303238995e-003;

            __statist_i_h_wts[0, 71] = -2.80307369749047e-001;

            __statist_i_h_wts[0, 72] = 1.91809688515695e-001;

            __statist_i_h_wts[0, 73] = 3.05887604591944e-002;

            __statist_i_h_wts[0, 74] = -3.22326940644893e-001;

            __statist_i_h_wts[0, 75] = 1.46355783261895e-001;

            __statist_i_h_wts[0, 76] = 6.98740847377141e-002;

            __statist_i_h_wts[0, 77] = -8.96181776384612e-001;

            __statist_i_h_wts[0, 78] = 1.65045287028502e-001;

            __statist_i_h_wts[0, 79] = 6.04676342322648e-001;

            __statist_i_h_wts[0, 80] = -1.13296310098846e-001;

            __statist_i_h_wts[0, 81] = -2.36585536640429e-002;

            __statist_i_h_wts[0, 82] = 3.84709075290238e-002;

            __statist_i_h_wts[0, 83] = -3.67198153531661e-001;

            __statist_i_h_wts[0, 84] = 2.15245361169030e-001;

            __statist_i_h_wts[0, 85] = 2.84495633313184e-002;

            __statist_i_h_wts[0, 86] = 2.22186329841870e-001;

            __statist_i_h_wts[0, 87] = -2.82634277354355e-001;

            __statist_i_h_wts[0, 88] = -4.23032186568571e-002;

            __statist_i_h_wts[0, 89] = 3.16286902972859e-001;

            __statist_i_h_wts[0, 90] = -3.11167252003347e-001;

            __statist_i_h_wts[0, 91] = -9.69175422282025e-002;

            __statist_i_h_wts[0, 92] = 3.11981428042267e-001;

            __statist_i_h_wts[0, 93] = -3.32766370730695e-001;

            __statist_i_h_wts[0, 94] = -8.65466994435724e-002;

            __statist_i_h_wts[0, 95] = 1.35044260092898e-001;

            __statist_i_h_wts[0, 96] = -2.13746888678984e-001;

            __statist_i_h_wts[0, 97] = -2.07137332908568e-002;

            __statist_i_h_wts[0, 98] = -9.62505236437763e-002;

            __statist_i_h_wts[0, 99] = -1.08787091090515e-002;

            __statist_i_h_wts[0, 100] = 1.00718092504158e-003;

            __statist_i_h_wts[0, 101] = -9.16687051468802e-002;

            __statist_i_h_wts[0, 102] = 5.60098101940278e-003;

            __statist_i_h_wts[0, 103] = -2.56584303853080e-002;

            __statist_i_h_wts[0, 104] = -4.58529040270988e-001;

            __statist_i_h_wts[0, 105] = 5.15262140126276e-001;

            __statist_i_h_wts[0, 106] = -1.73965292562967e-001;

            __statist_i_h_wts[0, 107] = -1.10613789685519e-001;

            __statist_i_h_wts[0, 108] = 6.62520164479637e-002;

            __statist_i_h_wts[0, 109] = -4.19501694183429e-002;

            __statist_i_h_wts[0, 110] = -8.88884227659988e-002;

            __statist_i_h_wts[0, 111] = 7.54364786165395e-003;

            __statist_i_h_wts[0, 112] = -2.06904919181238e-002;

            __statist_i_h_wts[0, 113] = -7.11144663015226e-002;

            __statist_i_h_wts[0, 114] = 7.13176513321076e-003;

            __statist_i_h_wts[0, 115] = -2.38392912027382e-002;

            __statist_i_h_wts[0, 116] = -2.76090260640756e-002;

            __statist_i_h_wts[0, 117] = -8.48693466449351e-002;

            __statist_i_h_wts[0, 118] = -1.00623939345602e-002;

            __statist_i_h_wts[0, 119] = -3.39328771327449e-001;

            __statist_i_h_wts[0, 120] = 3.31033723816658e-001;

            __statist_i_h_wts[0, 121] = -1.14306012155448e-001;

            __statist_i_h_wts[0, 122] = 6.37913562399383e-002;

            __statist_i_h_wts[0, 123] = -1.72688139565887e-001;

            __statist_i_h_wts[0, 124] = 3.94251195909677e-004;

            __statist_i_h_wts[0, 125] = -3.96770110895031e-002;

            __statist_i_h_wts[0, 126] = 9.72657569718445e-003;

            __statist_i_h_wts[0, 127] = -4.45861555766883e-002;



            __statist_i_h_wts[1, 0] = -1.06091585640262e-001;

            __statist_i_h_wts[1, 1] = -1.07072447103141e-001;

            __statist_i_h_wts[1, 2] = -1.72314975838451e-003;

            __statist_i_h_wts[1, 3] = 1.34064076720129e-001;

            __statist_i_h_wts[1, 4] = 4.44206953140857e-002;

            __statist_i_h_wts[1, 5] = -4.70624391596398e-002;

            __statist_i_h_wts[1, 6] = -6.34806380479912e-002;

            __statist_i_h_wts[1, 7] = 1.09344634289284e-002;

            __statist_i_h_wts[1, 8] = -1.10573153701500e-001;

            __statist_i_h_wts[1, 9] = 1.37530985997650e-001;

            __statist_i_h_wts[1, 10] = -6.19806378217878e-002;

            __statist_i_h_wts[1, 11] = 1.15497009390432e-002;

            __statist_i_h_wts[1, 12] = -7.32756943641030e-002;

            __statist_i_h_wts[1, 13] = -5.90705828610181e-002;

            __statist_i_h_wts[1, 14] = -6.94727062542569e-002;

            __statist_i_h_wts[1, 15] = 2.76198053246521e-002;

            __statist_i_h_wts[1, 16] = 1.16864765720225e-002;

            __statist_i_h_wts[1, 17] = 1.53213575985736e-002;

            __statist_i_h_wts[1, 18] = 7.20529687549865e-003;

            __statist_i_h_wts[1, 19] = -4.12659381291856e-002;

            __statist_i_h_wts[1, 20] = -7.51749440386685e-002;

            __statist_i_h_wts[1, 21] = 6.99693056154233e-002;

            __statist_i_h_wts[1, 22] = 7.51313028491306e-002;

            __statist_i_h_wts[1, 23] = 1.75010148197004e-001;

            __statist_i_h_wts[1, 24] = 8.41204345670629e-003;

            __statist_i_h_wts[1, 25] = 4.24698066577232e-003;

            __statist_i_h_wts[1, 26] = 4.16927093455698e-002;

            __statist_i_h_wts[1, 27] = 8.05960074813286e-002;

            __statist_i_h_wts[1, 28] = 4.62420356977534e-002;

            __statist_i_h_wts[1, 29] = -2.50746950942175e-002;

            __statist_i_h_wts[1, 30] = -2.05335749002976e-002;

            __statist_i_h_wts[1, 31] = -1.17552098636464e-001;

            __statist_i_h_wts[1, 32] = -8.92104115154509e-002;

            __statist_i_h_wts[1, 33] = -8.77153481752614e-002;

            __statist_i_h_wts[1, 34] = -8.04073446501748e-002;

            __statist_i_h_wts[1, 35] = -5.14224552812944e-002;

            __statist_i_h_wts[1, 36] = 6.29138800629649e-004;

            __statist_i_h_wts[1, 37] = -1.83266204452381e-001;

            __statist_i_h_wts[1, 38] = 5.93250693050037e-002;

            __statist_i_h_wts[1, 39] = 7.20680577865343e-002;

            __statist_i_h_wts[1, 40] = 1.05379998208211e-001;

            __statist_i_h_wts[1, 41] = 1.00979142491327e-001;

            __statist_i_h_wts[1, 42] = -1.85504492720936e-001;

            __statist_i_h_wts[1, 43] = -6.26288075179136e-002;

            __statist_i_h_wts[1, 44] = -8.83320763760157e-002;

            __statist_i_h_wts[1, 45] = -3.21070468660522e-002;

            __statist_i_h_wts[1, 46] = 3.09093538242713e-003;

            __statist_i_h_wts[1, 47] = 2.43564894469898e-002;

            __statist_i_h_wts[1, 48] = -5.29049712829296e-003;

            __statist_i_h_wts[1, 49] = 3.25009309684815e-002;

            __statist_i_h_wts[1, 50] = 3.22270095449728e-002;

            __statist_i_h_wts[1, 51] = 7.84000962067655e-002;

            __statist_i_h_wts[1, 52] = 2.97032716353731e-001;

            __statist_i_h_wts[1, 53] = 3.96793930478255e-002;

            __statist_i_h_wts[1, 54] = -1.24737330497411e-001;

            __statist_i_h_wts[1, 55] = -2.29827300062110e-001;

            __statist_i_h_wts[1, 56] = -1.95808999673125e-001;

            __statist_i_h_wts[1, 57] = -7.32384979175344e-002;

            __statist_i_h_wts[1, 58] = 1.71020616620382e-002;

            __statist_i_h_wts[1, 59] = -1.77007808778039e-001;

            __statist_i_h_wts[1, 60] = -1.87909395451240e-001;

            __statist_i_h_wts[1, 61] = 1.63318458628033e-001;

            __statist_i_h_wts[1, 62] = -2.99830656527732e-001;

            __statist_i_h_wts[1, 63] = -4.87355232857944e-001;

            __statist_i_h_wts[1, 64] = 5.63603178790397e-001;

            __statist_i_h_wts[1, 65] = -3.06655694241858e-002;

            __statist_i_h_wts[1, 66] = -4.30024612532951e-001;

            __statist_i_h_wts[1, 67] = 2.34022351488622e-001;

            __statist_i_h_wts[1, 68] = 7.83186502706939e-003;

            __statist_i_h_wts[1, 69] = -2.45003537416779e-001;

            __statist_i_h_wts[1, 70] = 2.74435549358344e-002;

            __statist_i_h_wts[1, 71] = -2.29935200843591e-002;

            __statist_i_h_wts[1, 72] = -1.82769013251361e-001;

            __statist_i_h_wts[1, 73] = -3.28176002380307e-002;

            __statist_i_h_wts[1, 74] = -6.89617187321834e-002;

            __statist_i_h_wts[1, 75] = -2.54345794493862e-001;

            __statist_i_h_wts[1, 76] = 9.96663058063685e-002;

            __statist_i_h_wts[1, 77] = -5.60939887976255e-001;

            __statist_i_h_wts[1, 78] = -5.98191058598140e-001;

            __statist_i_h_wts[1, 79] = 9.30862465497524e-001;

            __statist_i_h_wts[1, 80] = 2.63061608789101e-001;

            __statist_i_h_wts[1, 81] = -5.14092564935716e-001;

            __statist_i_h_wts[1, 82] = 4.24525747351475e-002;

            __statist_i_h_wts[1, 83] = 7.25632708234591e-002;

            __statist_i_h_wts[1, 84] = -2.15662187769620e-001;

            __statist_i_h_wts[1, 85] = -7.33061947890733e-002;

            __statist_i_h_wts[1, 86] = -6.62011439180677e-002;

            __statist_i_h_wts[1, 87] = 1.53985284376108e-001;

            __statist_i_h_wts[1, 88] = -2.85961660141058e-001;

            __statist_i_h_wts[1, 89] = -1.28970972242575e-001;

            __statist_i_h_wts[1, 90] = 3.95482381145849e-001;

            __statist_i_h_wts[1, 91] = -4.77455073139438e-001;

            __statist_i_h_wts[1, 92] = -3.07411927562588e-001;

            __statist_i_h_wts[1, 93] = 3.44982905715497e-001;

            __statist_i_h_wts[1, 94] = -2.68896288483797e-001;

            __statist_i_h_wts[1, 95] = -4.24848919056467e-001;

            __statist_i_h_wts[1, 96] = 3.45254362214554e-001;

            __statist_i_h_wts[1, 97] = -1.31777013852304e-001;

            __statist_i_h_wts[1, 98] = 4.57613180082967e-002;

            __statist_i_h_wts[1, 99] = -1.51237526134246e-001;

            __statist_i_h_wts[1, 100] = -1.25521516330863e-001;

            __statist_i_h_wts[1, 101] = 8.47197694794621e-002;

            __statist_i_h_wts[1, 102] = -1.18610070654979e-001;

            __statist_i_h_wts[1, 103] = -1.95300716218600e-001;

            __statist_i_h_wts[1, 104] = 6.04860704482784e-001;

            __statist_i_h_wts[1, 105] = -3.09226971281583e-001;

            __statist_i_h_wts[1, 106] = -5.01860100550913e-001;

            __statist_i_h_wts[1, 107] = 1.19393920213542e-002;

            __statist_i_h_wts[1, 108] = 6.26129344804380e-003;

            __statist_i_h_wts[1, 109] = -2.46668612487094e-001;

            __statist_i_h_wts[1, 110] = 1.71941352489756e-001;

            __statist_i_h_wts[1, 111] = -2.28474649316200e-001;

            __statist_i_h_wts[1, 112] = -1.59465853236339e-001;

            __statist_i_h_wts[1, 113] = 4.14802579375372e-002;

            __statist_i_h_wts[1, 114] = -1.88585445296185e-001;

            __statist_i_h_wts[1, 115] = -7.95599988899859e-002;

            __statist_i_h_wts[1, 116] = 6.80795673592884e-002;

            __statist_i_h_wts[1, 117] = -1.44175927854857e-001;

            __statist_i_h_wts[1, 118] = -1.36248845687627e-001;

            __statist_i_h_wts[1, 119] = 6.67037234293467e-001;

            __statist_i_h_wts[1, 120] = -5.03555805502091e-001;

            __statist_i_h_wts[1, 121] = -3.89357461171903e-001;

            __statist_i_h_wts[1, 122] = 7.29264732338092e-002;

            __statist_i_h_wts[1, 123] = -2.15708605018941e-001;

            __statist_i_h_wts[1, 124] = -6.41977990179490e-002;

            __statist_i_h_wts[1, 125] = 1.73463768077744e-001;

            __statist_i_h_wts[1, 126] = -2.13758265996735e-001;

            __statist_i_h_wts[1, 127] = -1.85663712132720e-001;



            __statist_i_h_wts[2, 0] = 1.29596561112842e-001;

            __statist_i_h_wts[2, 1] = 1.10663294399159e-001;

            __statist_i_h_wts[2, 2] = 3.20731543730234e-002;

            __statist_i_h_wts[2, 3] = -1.48377851242336e-001;

            __statist_i_h_wts[2, 4] = -7.53829945166124e-002;

            __statist_i_h_wts[2, 5] = 1.10523209432275e-001;

            __statist_i_h_wts[2, 6] = 5.06252838423320e-002;

            __statist_i_h_wts[2, 7] = -8.40477838201348e-002;

            __statist_i_h_wts[2, 8] = 6.68307096287040e-002;

            __statist_i_h_wts[2, 9] = -1.80397053430604e-001;

            __statist_i_h_wts[2, 10] = 1.11249460077645e-001;

            __statist_i_h_wts[2, 11] = 4.85073134941580e-002;

            __statist_i_h_wts[2, 12] = 6.84665602157568e-002;

            __statist_i_h_wts[2, 13] = 2.23580267491262e-003;

            __statist_i_h_wts[2, 14] = 6.88762016038133e-002;

            __statist_i_h_wts[2, 15] = -6.40298135574272e-002;

            __statist_i_h_wts[2, 16] = -6.29169682463095e-002;

            __statist_i_h_wts[2, 17] = -2.24222751533840e-001;

            __statist_i_h_wts[2, 18] = -4.41064148988261e-002;

            __statist_i_h_wts[2, 19] = 1.40901062714944e-001;

            __statist_i_h_wts[2, 20] = 6.38106519058337e-002;

            __statist_i_h_wts[2, 21] = -5.52346722659405e-002;

            __statist_i_h_wts[2, 22] = -8.70804458255399e-002;

            __statist_i_h_wts[2, 23] = -2.96952986314998e-001;

            __statist_i_h_wts[2, 24] = 1.63708358076868e-002;

            __statist_i_h_wts[2, 25] = 8.47153938169182e-002;

            __statist_i_h_wts[2, 26] = -1.87525253685074e-002;

            __statist_i_h_wts[2, 27] = -7.15069814363600e-002;

            __statist_i_h_wts[2, 28] = -1.16636819933149e-003;

            __statist_i_h_wts[2, 29] = 8.09717172756416e-002;

            __statist_i_h_wts[2, 30] = 9.25260551063914e-002;

            __statist_i_h_wts[2, 31] = 1.07876405615771e-001;

            __statist_i_h_wts[2, 32] = 1.13152408231271e-001;

            __statist_i_h_wts[2, 33] = 1.27593957118657e-001;

            __statist_i_h_wts[2, 34] = 7.21872470133345e-002;

            __statist_i_h_wts[2, 35] = 6.30830610682991e-002;

            __statist_i_h_wts[2, 36] = 5.19068619520525e-003;

            __statist_i_h_wts[2, 37] = 2.77563937971989e-001;

            __statist_i_h_wts[2, 38] = -9.49514243461863e-002;

            __statist_i_h_wts[2, 39] = -2.56640431598278e-002;

            __statist_i_h_wts[2, 40] = -1.44503538239059e-001;

            __statist_i_h_wts[2, 41] = -7.85853392990240e-002;

            __statist_i_h_wts[2, 42] = 1.00441606626484e-001;

            __statist_i_h_wts[2, 43] = 1.99551986412711e-001;

            __statist_i_h_wts[2, 44] = 1.02591065369471e-001;

            __statist_i_h_wts[2, 45] = 9.02416663973897e-003;

            __statist_i_h_wts[2, 46] = -5.67628315066869e-003;

            __statist_i_h_wts[2, 47] = -2.84629979965213e-003;

            __statist_i_h_wts[2, 48] = -6.81234479872803e-002;

            __statist_i_h_wts[2, 49] = 1.16944365571143e-002;

            __statist_i_h_wts[2, 50] = -1.02382287571893e-001;

            __statist_i_h_wts[2, 51] = -1.62323758724029e-001;

            __statist_i_h_wts[2, 52] = -1.56783789769235e-001;

            __statist_i_h_wts[2, 53] = -6.56718121068177e-002;

            __statist_i_h_wts[2, 54] = 1.07347127868653e-001;

            __statist_i_h_wts[2, 55] = 2.79738663719388e-001;

            __statist_i_h_wts[2, 56] = 7.91189608850994e-002;

            __statist_i_h_wts[2, 57] = 1.65874441919391e-001;

            __statist_i_h_wts[2, 58] = -5.98693417669569e-002;

            __statist_i_h_wts[2, 59] = 1.49444000867966e-001;

            __statist_i_h_wts[2, 60] = 2.71925862181419e-001;

            __statist_i_h_wts[2, 61] = -2.19671447160805e-001;

            __statist_i_h_wts[2, 62] = 9.17317313714176e-001;

            __statist_i_h_wts[2, 63] = -3.70636159881559e-002;

            __statist_i_h_wts[2, 64] = -7.26229191432726e-001;

            __statist_i_h_wts[2, 65] = 3.37965514380482e-001;

            __statist_i_h_wts[2, 66] = 1.10792804432132e-001;

            __statist_i_h_wts[2, 67] = -2.63940677789181e-001;

            __statist_i_h_wts[2, 68] = 3.65676940298148e-001;

            __statist_i_h_wts[2, 69] = -4.65868383236246e-002;

            __statist_i_h_wts[2, 70] = -1.07483547071007e-001;

            __statist_i_h_wts[2, 71] = 3.10057018238620e-001;

            __statist_i_h_wts[2, 72] = -1.94817399954997e-001;

            __statist_i_h_wts[2, 73] = 9.25588764790405e-002;

            __statist_i_h_wts[2, 74] = 5.09675787930256e-001;

            __statist_i_h_wts[2, 75] = -1.64222184211592e-001;

            __statist_i_h_wts[2, 76] = -1.51398896162311e-001;

            __statist_i_h_wts[2, 77] = 1.59984092232362e+000;

            __statist_i_h_wts[2, 78] = -1.34781456804946e-001;

            __statist_i_h_wts[2, 79] = -1.28117209166791e+000;

            __statist_i_h_wts[2, 80] = 2.78987493103961e-001;

            __statist_i_h_wts[2, 81] = 7.54030467797949e-003;

            __statist_i_h_wts[2, 82] = -6.49237813835921e-002;

            __statist_i_h_wts[2, 83] = 4.27579990153935e-001;

            __statist_i_h_wts[2, 84] = -2.34842588047375e-001;

            __statist_i_h_wts[2, 85] = 4.00689784593809e-003;

            __statist_i_h_wts[2, 86] = -3.79672704345037e-001;

            __statist_i_h_wts[2, 87] = 1.98903036694726e-001;

            __statist_i_h_wts[2, 88] = 3.77515095611813e-001;

            __statist_i_h_wts[2, 89] = -5.46956141808552e-001;

            __statist_i_h_wts[2, 90] = 1.78214085933281e-001;

            __statist_i_h_wts[2, 91] = 5.62508159241438e-001;

            __statist_i_h_wts[2, 92] = -6.55417334902707e-001;

            __statist_i_h_wts[2, 93] = 3.51679833461406e-001;

            __statist_i_h_wts[2, 94] = 4.92644589627719e-001;

            __statist_i_h_wts[2, 95] = -1.88575340941791e-001;

            __statist_i_h_wts[2, 96] = 1.83529632214890e-001;

            __statist_i_h_wts[2, 97] = 1.73828565047594e-001;

            __statist_i_h_wts[2, 98] = 1.58675724227078e-002;

            __statist_i_h_wts[2, 99] = 1.18764937532584e-002;

            __statist_i_h_wts[2, 100] = 1.76120972980672e-001;

            __statist_i_h_wts[2, 101] = 7.07284130805949e-002;

            __statist_i_h_wts[2, 102] = -1.84787327519942e-001;

            __statist_i_h_wts[2, 103] = 2.94370395107230e-001;

            __statist_i_h_wts[2, 104] = 2.90577693192725e-001;

            __statist_i_h_wts[2, 105] = -7.98149701416437e-001;

            __statist_i_h_wts[2, 106] = 6.92502296914513e-001;

            __statist_i_h_wts[2, 107] = 1.19370599417863e-001;

            __statist_i_h_wts[2, 108] = -2.61307746546868e-001;

            __statist_i_h_wts[2, 109] = 3.60090550108218e-001;

            __statist_i_h_wts[2, 110] = 3.33351631375869e-002;

            __statist_i_h_wts[2, 111] = -8.68754660301236e-002;

            __statist_i_h_wts[2, 112] = 2.38104108101259e-001;

            __statist_i_h_wts[2, 113] = 9.34963758521380e-003;

            __statist_i_h_wts[2, 114] = 1.22555687427918e-001;

            __statist_i_h_wts[2, 115] = 8.76783741431860e-002;

            __statist_i_h_wts[2, 116] = 3.53166806187683e-002;

            __statist_i_h_wts[2, 117] = -1.03429375771834e-001;

            __statist_i_h_wts[2, 118] = 2.63859875867400e-001;

            __statist_i_h_wts[2, 119] = 1.31763276632412e-001;

            __statist_i_h_wts[2, 120] = -5.21516817056862e-001;

            __statist_i_h_wts[2, 121] = 5.74280288098364e-001;

            __statist_i_h_wts[2, 122] = 1.73273996671314e-002;

            __statist_i_h_wts[2, 123] = 3.04712166884479e-002;

            __statist_i_h_wts[2, 124] = 1.47306287062646e-001;

            __statist_i_h_wts[2, 125] = 9.83429068960879e-002;

            __statist_i_h_wts[2, 126] = -1.70671491333068e-001;

            __statist_i_h_wts[2, 127] = 2.56316174899641e-001;



            __statist_i_h_wts[3, 0] = 3.08985275774711e-002;

            __statist_i_h_wts[3, 1] = 4.85787017873847e-002;

            __statist_i_h_wts[3, 2] = 2.91971308855374e-002;

            __statist_i_h_wts[3, 3] = -7.40181825340451e-002;

            __statist_i_h_wts[3, 4] = -3.75522994840625e-002;

            __statist_i_h_wts[3, 5] = 9.46388879457349e-002;

            __statist_i_h_wts[3, 6] = 4.04402182927020e-002;

            __statist_i_h_wts[3, 7] = -2.90360125124659e-002;

            __statist_i_h_wts[3, 8] = 5.49116894059059e-002;

            __statist_i_h_wts[3, 9] = -5.87065278619118e-002;

            __statist_i_h_wts[3, 10] = 3.78926321242697e-002;

            __statist_i_h_wts[3, 11] = -1.68226102816410e-004;

            __statist_i_h_wts[3, 12] = 8.72050174117790e-003;

            __statist_i_h_wts[3, 13] = 6.32867620211899e-003;

            __statist_i_h_wts[3, 14] = 3.55214647559596e-002;

            __statist_i_h_wts[3, 15] = -5.74898827491854e-003;

            __statist_i_h_wts[3, 16] = -4.06249762943107e-002;

            __statist_i_h_wts[3, 17] = -6.70935495291737e-002;

            __statist_i_h_wts[3, 18] = 4.04538027263713e-003;

            __statist_i_h_wts[3, 19] = 5.83819326513245e-002;

            __statist_i_h_wts[3, 20] = 1.88653405500177e-002;

            __statist_i_h_wts[3, 21] = -5.18302985156357e-002;

            __statist_i_h_wts[3, 22] = -2.92974011105073e-002;

            __statist_i_h_wts[3, 23] = -1.41043407505651e-001;

            __statist_i_h_wts[3, 24] = 1.45485132678833e-002;

            __statist_i_h_wts[3, 25] = 3.28330296009557e-002;

            __statist_i_h_wts[3, 26] = -1.06084205509470e-002;

            __statist_i_h_wts[3, 27] = -5.03993106051987e-002;

            __statist_i_h_wts[3, 28] = -3.59954300988601e-002;

            __statist_i_h_wts[3, 29] = -8.90625601241581e-003;

            __statist_i_h_wts[3, 30] = 2.89895392806470e-002;

            __statist_i_h_wts[3, 31] = 2.21671156092183e-002;

            __statist_i_h_wts[3, 32] = 3.50497742043323e-002;

            __statist_i_h_wts[3, 33] = 8.70802433842932e-002;

            __statist_i_h_wts[3, 34] = 4.43130236046624e-002;

            __statist_i_h_wts[3, 35] = 4.77224454682148e-002;

            __statist_i_h_wts[3, 36] = -5.71624883998320e-003;

            __statist_i_h_wts[3, 37] = 1.01288203964775e-001;

            __statist_i_h_wts[3, 38] = -6.78530767605398e-002;

            __statist_i_h_wts[3, 39] = -2.21541872778928e-002;

            __statist_i_h_wts[3, 40] = -8.95206981916545e-002;

            __statist_i_h_wts[3, 41] = -4.13948147704931e-002;

            __statist_i_h_wts[3, 42] = -2.94436529931762e-003;

            __statist_i_h_wts[3, 43] = 6.86463917346118e-002;

            __statist_i_h_wts[3, 44] = 3.56338762365310e-002;

            __statist_i_h_wts[3, 45] = -9.82413498645467e-004;

            __statist_i_h_wts[3, 46] = 9.14635661540741e-003;

            __statist_i_h_wts[3, 47] = -1.23404337882002e-002;

            __statist_i_h_wts[3, 48] = -2.56511648216769e-003;

            __statist_i_h_wts[3, 49] = 4.84933503484908e-003;

            __statist_i_h_wts[3, 50] = -1.99819541180504e-002;

            __statist_i_h_wts[3, 51] = 2.90534018419196e-002;

            __statist_i_h_wts[3, 52] = -8.04785223790541e-002;

            __statist_i_h_wts[3, 53] = -1.06274602857834e-001;

            __statist_i_h_wts[3, 54] = 3.29787226229003e-002;

            __statist_i_h_wts[3, 55] = 1.31208414463144e-001;

            __statist_i_h_wts[3, 56] = 4.12365671615078e-002;

            __statist_i_h_wts[3, 57] = 2.57295693084373e-002;

            __statist_i_h_wts[3, 58] = -2.62327272976971e-002;

            __statist_i_h_wts[3, 59] = 1.14584998504703e-001;

            __statist_i_h_wts[3, 60] = 5.99718542271359e-002;

            __statist_i_h_wts[3, 61] = -1.35445558458264e-001;

            __statist_i_h_wts[3, 62] = 1.99379559505773e-001;

            __statist_i_h_wts[3, 63] = 1.38156463124660e-001;

            __statist_i_h_wts[3, 64] = -2.92871685200141e-001;

            __statist_i_h_wts[3, 65] = 8.26009269732628e-002;

            __statist_i_h_wts[3, 66] = 8.79266662812475e-002;

            __statist_i_h_wts[3, 67] = -1.23822710073052e-001;

            __statist_i_h_wts[3, 68] = 1.75533146318349e-002;

            __statist_i_h_wts[3, 69] = 1.10552369895474e-001;

            __statist_i_h_wts[3, 70] = -5.13060024248355e-002;

            __statist_i_h_wts[3, 71] = 2.01298999312700e-002;

            __statist_i_h_wts[3, 72] = 8.82944354791033e-003;

            __statist_i_h_wts[3, 73] = 5.88560767129124e-003;

            __statist_i_h_wts[3, 74] = 8.09402987979085e-002;

            __statist_i_h_wts[3, 75] = 5.82847504812077e-002;

            __statist_i_h_wts[3, 76] = -7.56292879448598e-002;

            __statist_i_h_wts[3, 77] = 4.93282451675110e-001;

            __statist_i_h_wts[3, 78] = 1.07692545621622e-001;

            __statist_i_h_wts[3, 79] = -5.29825996083693e-001;

            __statist_i_h_wts[3, 80] = -2.32553661307978e-003;

            __statist_i_h_wts[3, 81] = 1.07085767882686e-001;

            __statist_i_h_wts[3, 82] = -5.28791308080226e-002;

            __statist_i_h_wts[3, 83] = 5.36041800802274e-002;

            __statist_i_h_wts[3, 84] = 3.70261244970178e-002;

            __statist_i_h_wts[3, 85] = -1.82154603338703e-002;

            __statist_i_h_wts[3, 86] = -2.52378504691963e-002;

            __statist_i_h_wts[3, 87] = -5.99277919316595e-002;

            __statist_i_h_wts[3, 88] = 1.48679014700893e-001;

            __statist_i_h_wts[3, 89] = -1.05422656563828e-001;

            __statist_i_h_wts[3, 90] = -9.90257246418577e-002;

            __statist_i_h_wts[3, 91] = 2.65449830106614e-001;

            __statist_i_h_wts[3, 92] = -1.07421075478197e-001;

            __statist_i_h_wts[3, 93] = -2.60544024962517e-002;

            __statist_i_h_wts[3, 94] = 1.87166813063164e-001;

            __statist_i_h_wts[3, 95] = 4.42592525890719e-002;

            __statist_i_h_wts[3, 96] = -6.62238559844819e-002;

            __statist_i_h_wts[3, 97] = 8.86132967554788e-002;

            __statist_i_h_wts[3, 98] = -5.23772374088155e-002;

            __statist_i_h_wts[3, 99] = 1.52855633892569e-002;

            __statist_i_h_wts[3, 100] = 1.09858618814288e-001;

            __statist_i_h_wts[3, 101] = -5.39845298911505e-002;

            __statist_i_h_wts[3, 102] = -2.24007272048828e-002;

            __statist_i_h_wts[3, 103] = 1.33452933821557e-001;

            __statist_i_h_wts[3, 104] = -1.28288467111308e-001;

            __statist_i_h_wts[3, 105] = -1.10633523029772e-001;

            __statist_i_h_wts[3, 106] = 3.03835608766259e-001;

            __statist_i_h_wts[3, 107] = -8.41698595587227e-002;

            __statist_i_h_wts[3, 108] = -1.86196061921045e-002;

            __statist_i_h_wts[3, 109] = 1.86203272389450e-001;

            __statist_i_h_wts[3, 110] = -7.33667125044576e-002;

            __statist_i_h_wts[3, 111] = 1.98821711547654e-003;

            __statist_i_h_wts[3, 112] = 1.30054736580709e-001;

            __statist_i_h_wts[3, 113] = -4.16860382490806e-002;

            __statist_i_h_wts[3, 114] = 3.87072270086644e-002;

            __statist_i_h_wts[3, 115] = 7.39457457859828e-002;

            __statist_i_h_wts[3, 116] = -4.81870682645113e-002;

            __statist_i_h_wts[3, 117] = -1.09563146973814e-002;

            __statist_i_h_wts[3, 118] = 1.15083356049375e-001;

            __statist_i_h_wts[3, 119] = -1.49120717886658e-001;

            __statist_i_h_wts[3, 120] = -3.15414070214544e-002;

            __statist_i_h_wts[3, 121] = 2.49258660958966e-001;

            __statist_i_h_wts[3, 122] = -6.30275358226260e-002;

            __statist_i_h_wts[3, 123] = 5.35384607050403e-002;

            __statist_i_h_wts[3, 124] = 7.35375083623198e-002;

            __statist_i_h_wts[3, 125] = -3.33454575604850e-002;

            __statist_i_h_wts[3, 126] = -6.63565267789590e-003;

            __statist_i_h_wts[3, 127] = 1.06081320627200e-001;



            __statist_i_h_wts[4, 0] = 1.49944470235914e-002;

            __statist_i_h_wts[4, 1] = -9.58255664729110e-003;

            __statist_i_h_wts[4, 2] = 2.04991433776162e-002;

            __statist_i_h_wts[4, 3] = -1.36478647743092e-002;

            __statist_i_h_wts[4, 4] = 8.84857344179887e-003;

            __statist_i_h_wts[4, 5] = 2.22370727653358e-002;

            __statist_i_h_wts[4, 6] = 4.83780035669072e-003;

            __statist_i_h_wts[4, 7] = 1.33876437101166e-002;

            __statist_i_h_wts[4, 8] = 2.01735464376353e-002;

            __statist_i_h_wts[4, 9] = -9.00088513617187e-003;

            __statist_i_h_wts[4, 10] = 1.63075380725623e-002;

            __statist_i_h_wts[4, 11] = -1.06989865799098e-002;

            __statist_i_h_wts[4, 12] = 1.37595287029562e-002;

            __statist_i_h_wts[4, 13] = 4.75772848067776e-003;

            __statist_i_h_wts[4, 14] = -1.68066948430240e-002;

            __statist_i_h_wts[4, 15] = -7.14815280102593e-003;

            __statist_i_h_wts[4, 16] = -3.85798351130462e-004;

            __statist_i_h_wts[4, 17] = 1.50521616239830e-003;

            __statist_i_h_wts[4, 18] = -9.69114337456570e-003;

            __statist_i_h_wts[4, 19] = 2.09442064062895e-002;

            __statist_i_h_wts[4, 20] = 6.70955929047339e-003;

            __statist_i_h_wts[4, 21] = 4.46435958758905e-003;

            __statist_i_h_wts[4, 22] = -7.08647906184917e-003;

            __statist_i_h_wts[4, 23] = -2.25879105481922e-002;

            __statist_i_h_wts[4, 24] = 1.41597666544551e-002;

            __statist_i_h_wts[4, 25] = 6.05694569358336e-003;

            __statist_i_h_wts[4, 26] = 1.34669828055431e-002;

            __statist_i_h_wts[4, 27] = -3.75280815850851e-003;

            __statist_i_h_wts[4, 28] = -1.83149514659510e-003;

            __statist_i_h_wts[4, 29] = 4.94967949758037e-003;

            __statist_i_h_wts[4, 30] = 2.91134807053418e-003;

            __statist_i_h_wts[4, 31] = 2.03737351068970e-002;

            __statist_i_h_wts[4, 32] = -7.50811828263616e-003;

            __statist_i_h_wts[4, 33] = 1.18757008944543e-002;

            __statist_i_h_wts[4, 34] = 1.33796942388096e-002;

            __statist_i_h_wts[4, 35] = -7.17425308854089e-003;

            __statist_i_h_wts[4, 36] = -3.12153640416385e-003;

            __statist_i_h_wts[4, 37] = 1.56572006094521e-002;

            __statist_i_h_wts[4, 38] = -1.89478189723471e-002;

            __statist_i_h_wts[4, 39] = -3.24995142980871e-003;

            __statist_i_h_wts[4, 40] = -1.66815792310129e-003;

            __statist_i_h_wts[4, 41] = 9.07975217900460e-003;

            __statist_i_h_wts[4, 42] = -3.92031398122567e-003;

            __statist_i_h_wts[4, 43] = 2.40326780503683e-002;

            __statist_i_h_wts[4, 44] = 4.83128356204192e-003;

            __statist_i_h_wts[4, 45] = 4.51594008227717e-003;

            __statist_i_h_wts[4, 46] = -1.55344037345519e-002;

            __statist_i_h_wts[4, 47] = -1.75411295064660e-002;

            __statist_i_h_wts[4, 48] = -2.77054341914864e-003;

            __statist_i_h_wts[4, 49] = 7.59476713530337e-003;

            __statist_i_h_wts[4, 50] = 1.60777551266083e-002;

            __statist_i_h_wts[4, 51] = 2.73404218782059e-003;

            __statist_i_h_wts[4, 52] = -3.12120381692335e-003;

            __statist_i_h_wts[4, 53] = 2.60453184708968e-003;

            __statist_i_h_wts[4, 54] = -3.92610648385067e-003;

            __statist_i_h_wts[4, 55] = 1.84676669185344e-002;

            __statist_i_h_wts[4, 56] = 6.14076099409087e-002;

            __statist_i_h_wts[4, 57] = -6.14357461681208e-003;

            __statist_i_h_wts[4, 58] = -1.04389041104437e-002;

            __statist_i_h_wts[4, 59] = 6.76938116813271e-002;

            __statist_i_h_wts[4, 60] = 2.10663255634520e-003;

            __statist_i_h_wts[4, 61] = -1.07874363887862e-002;

            __statist_i_h_wts[4, 62] = 1.08588277542401e-001;

            __statist_i_h_wts[4, 63] = -3.05103895291224e-002;

            __statist_i_h_wts[4, 64] = -3.93510618461042e-002;

            __statist_i_h_wts[4, 65] = 4.42515765276942e-002;

            __statist_i_h_wts[4, 66] = 1.19696732490182e-002;

            __statist_i_h_wts[4, 67] = -3.98165594865824e-003;

            __statist_i_h_wts[4, 68] = 4.55290393455145e-002;

            __statist_i_h_wts[4, 69] = -4.61817932545435e-003;

            __statist_i_h_wts[4, 70] = 1.29881237650452e-003;

            __statist_i_h_wts[4, 71] = 6.29962965005265e-002;

            __statist_i_h_wts[4, 72] = 1.01333678584272e-003;

            __statist_i_h_wts[4, 73] = 1.48088350166283e-002;

            __statist_i_h_wts[4, 74] = 6.66067431583828e-002;

            __statist_i_h_wts[4, 75] = -2.11704494333027e-002;

            __statist_i_h_wts[4, 76] = -1.00311236707802e-002;

            __statist_i_h_wts[4, 77] = 1.53655772970253e-001;

            __statist_i_h_wts[4, 78] = -7.28404419330656e-002;

            __statist_i_h_wts[4, 79] = -5.06139450568279e-002;

            __statist_i_h_wts[4, 80] = 4.17676711904805e-002;

            __statist_i_h_wts[4, 81] = 1.03112926135383e-002;

            __statist_i_h_wts[4, 82] = 4.08808881378664e-003;

            __statist_i_h_wts[4, 83] = 6.21360183805524e-002;

            __statist_i_h_wts[4, 84] = -1.70327126034373e-002;

            __statist_i_h_wts[4, 85] = -5.95034065848768e-003;

            __statist_i_h_wts[4, 86] = -6.48857420616515e-002;

            __statist_i_h_wts[4, 87] = 8.84263841647330e-002;

            __statist_i_h_wts[4, 88] = 2.27008654291066e-002;

            __statist_i_h_wts[4, 89] = -8.31323451467150e-002;

            __statist_i_h_wts[4, 90] = 9.47618285370405e-002;

            __statist_i_h_wts[4, 91] = 5.58902063973831e-002;

            __statist_i_h_wts[4, 92] = -9.83411962297060e-002;

            __statist_i_h_wts[4, 93] = 1.17470231567777e-001;

            __statist_i_h_wts[4, 94] = 4.45506531384726e-002;

            __statist_i_h_wts[4, 95] = -4.51701571089775e-002;

            __statist_i_h_wts[4, 96] = 5.90189847782721e-002;

            __statist_i_h_wts[4, 97] = 5.14959963678978e-003;

            __statist_i_h_wts[4, 98] = 2.35423500063409e-002;

            __statist_i_h_wts[4, 99] = -3.40879339600061e-003;

            __statist_i_h_wts[4, 100] = 1.43264091674844e-002;

            __statist_i_h_wts[4, 101] = 4.95489008080434e-002;

            __statist_i_h_wts[4, 102] = 9.29226670949812e-003;

            __statist_i_h_wts[4, 103] = 1.29840881171746e-002;

            __statist_i_h_wts[4, 104] = 8.86806532625553e-002;

            __statist_i_h_wts[4, 105] = -6.24226346212650e-002;

            __statist_i_h_wts[4, 106] = 4.36393790333680e-002;

            __statist_i_h_wts[4, 107] = 1.11250390696989e-002;

            __statist_i_h_wts[4, 108] = 6.73955618316470e-003;

            __statist_i_h_wts[4, 109] = 1.77295002651337e-002;

            __statist_i_h_wts[4, 110] = 5.68139656145609e-002;

            __statist_i_h_wts[4, 111] = -1.72968134068277e-002;

            __statist_i_h_wts[4, 112] = 2.23112606067915e-002;

            __statist_i_h_wts[4, 113] = 2.70518289234023e-002;

            __statist_i_h_wts[4, 114] = 9.58490250889617e-004;

            __statist_i_h_wts[4, 115] = 6.46494958004478e-003;

            __statist_i_h_wts[4, 116] = 3.44222729371607e-002;

            __statist_i_h_wts[4, 117] = 4.16706400883744e-003;

            __statist_i_h_wts[4, 118] = 2.86968266813072e-002;

            __statist_i_h_wts[4, 119] = 8.40922539207742e-002;

            __statist_i_h_wts[4, 120] = -6.41801554545098e-002;

            __statist_i_h_wts[4, 121] = 1.17906732523285e-002;

            __statist_i_h_wts[4, 122] = 1.16810103019706e-002;

            __statist_i_h_wts[4, 123] = 2.79875184099281e-002;

            __statist_i_h_wts[4, 124] = -2.06989084259805e-003;

            __statist_i_h_wts[4, 125] = 4.35745644932484e-002;

            __statist_i_h_wts[4, 126] = -4.31112807456660e-003;

            __statist_i_h_wts[4, 127] = 3.66180784202170e-002;



            __statist_i_h_wts[5, 0] = -7.66079709065249e-002;

            __statist_i_h_wts[5, 1] = -9.29439130559002e-002;

            __statist_i_h_wts[5, 2] = -1.38158473440597e-002;

            __statist_i_h_wts[5, 3] = 1.58913414230894e-001;

            __statist_i_h_wts[5, 4] = 6.28744600058392e-002;

            __statist_i_h_wts[5, 5] = -1.66239577255181e-001;

            __statist_i_h_wts[5, 6] = -1.15612628422331e-001;

            __statist_i_h_wts[5, 7] = 7.78205352318556e-002;

            __statist_i_h_wts[5, 8] = -2.03935554393511e-001;

            __statist_i_h_wts[5, 9] = 1.68582389866099e-001;

            __statist_i_h_wts[5, 10] = -8.04954361086061e-002;

            __statist_i_h_wts[5, 11] = -6.22884748253783e-002;

            __statist_i_h_wts[5, 12] = -6.94323455153599e-002;

            __statist_i_h_wts[5, 13] = -4.00362470638136e-002;

            __statist_i_h_wts[5, 14] = -1.62421436666654e-001;

            __statist_i_h_wts[5, 15] = 4.48963822806332e-002;

            __statist_i_h_wts[5, 16] = 6.47169130433831e-002;

            __statist_i_h_wts[5, 17] = 1.70316334179788e-001;

            __statist_i_h_wts[5, 18] = -2.40877554836515e-002;

            __statist_i_h_wts[5, 19] = -1.33684701147342e-001;

            __statist_i_h_wts[5, 20] = -7.40252168645456e-002;

            __statist_i_h_wts[5, 21] = 9.87338172971637e-002;

            __statist_i_h_wts[5, 22] = 1.44068169104013e-001;

            __statist_i_h_wts[5, 23] = 3.02372068290955e-001;

            __statist_i_h_wts[5, 24] = -5.29970733668333e-002;

            __statist_i_h_wts[5, 25] = -6.32700920978656e-002;

            __statist_i_h_wts[5, 26] = 3.51410392284883e-003;

            __statist_i_h_wts[5, 27] = 1.17418661397475e-001;

            __statist_i_h_wts[5, 28] = 9.92599452191368e-002;

            __statist_i_h_wts[5, 29] = 3.70561053493326e-002;

            __statist_i_h_wts[5, 30] = -3.74504775712635e-002;

            __statist_i_h_wts[5, 31] = -1.05748814903254e-001;

            __statist_i_h_wts[5, 32] = -9.84673218616407e-002;

            __statist_i_h_wts[5, 33] = -1.46242735531830e-001;

            __statist_i_h_wts[5, 34] = -1.50673490632180e-001;

            __statist_i_h_wts[5, 35] = -3.57885060774902e-002;

            __statist_i_h_wts[5, 36] = -1.32764323993811e-002;

            __statist_i_h_wts[5, 37] = -2.48778523507675e-001;

            __statist_i_h_wts[5, 38] = 1.56944134247515e-001;

            __statist_i_h_wts[5, 39] = 1.02648256184249e-001;

            __statist_i_h_wts[5, 40] = 2.01478586660086e-001;

            __statist_i_h_wts[5, 41] = 1.52261645461486e-001;

            __statist_i_h_wts[5, 42] = -9.44666126455061e-002;

            __statist_i_h_wts[5, 43] = -1.29490793522851e-001;

            __statist_i_h_wts[5, 44] = -1.05032431235605e-001;

            __statist_i_h_wts[5, 45] = -4.41685040240414e-002;

            __statist_i_h_wts[5, 46] = 2.03347876329134e-002;

            __statist_i_h_wts[5, 47] = 2.48672255277246e-002;

            __statist_i_h_wts[5, 48] = 4.98659547462581e-002;

            __statist_i_h_wts[5, 49] = 4.69414091077714e-002;

            __statist_i_h_wts[5, 50] = 4.11166723005977e-002;

            __statist_i_h_wts[5, 51] = -5.38586164900250e-002;

            __statist_i_h_wts[5, 52] = 2.46572459258684e-001;

            __statist_i_h_wts[5, 53] = 2.82065854063761e-001;

            __statist_i_h_wts[5, 54] = -1.10539749350321e-001;

            __statist_i_h_wts[5, 55] = -3.05419097278693e-001;

            __statist_i_h_wts[5, 56] = -2.50516793738243e-001;

            __statist_i_h_wts[5, 57] = 4.48442806913812e-002;

            __statist_i_h_wts[5, 58] = 9.03863570468276e-002;

            __statist_i_h_wts[5, 59] = -2.69509242051761e-001;

            __statist_i_h_wts[5, 60] = -2.20081408098014e-001;

            __statist_i_h_wts[5, 61] = 3.57315134323410e-001;

            __statist_i_h_wts[5, 62] = -4.19239456910581e-001;

            __statist_i_h_wts[5, 63] = -4.10413746910669e-001;

            __statist_i_h_wts[5, 64] = 7.01475611759307e-001;

            __statist_i_h_wts[5, 65] = -1.74381056602770e-001;

            __statist_i_h_wts[5, 66] = -2.41391470073334e-001;

            __statist_i_h_wts[5, 67] = 2.61344250896721e-001;

            __statist_i_h_wts[5, 68] = 5.21103073257308e-002;

            __statist_i_h_wts[5, 69] = -3.41532320331482e-001;

            __statist_i_h_wts[5, 70] = 1.39965496127241e-001;

            __statist_i_h_wts[5, 71] = -7.34147260845193e-002;

            __statist_i_h_wts[5, 72] = 8.94967591186828e-002;

            __statist_i_h_wts[5, 73] = -1.44731300509454e-001;

            __statist_i_h_wts[5, 74] = -1.39334478754300e-001;

            __statist_i_h_wts[5, 75] = -1.66603825519610e-001;

            __statist_i_h_wts[5, 76] = 1.52321437495883e-001;

            __statist_i_h_wts[5, 77] = -1.10338062316258e+000;

            __statist_i_h_wts[5, 78] = -3.84273259914752e-001;

            __statist_i_h_wts[5, 79] = 1.35038671734464e+000;

            __statist_i_h_wts[5, 80] = 1.92378342521509e-002;

            __statist_i_h_wts[5, 81] = -3.31528589027781e-001;

            __statist_i_h_wts[5, 82] = 1.58298255118807e-001;

            __statist_i_h_wts[5, 83] = -9.28194773482862e-002;

            __statist_i_h_wts[5, 84] = -2.69308228620974e-002;

            __statist_i_h_wts[5, 85] = -3.50392692049905e-002;

            __statist_i_h_wts[5, 86] = -8.34345170995191e-002;

            __statist_i_h_wts[5, 87] = 2.88383303607997e-001;

            __statist_i_h_wts[5, 88] = -3.33824829963750e-001;

            __statist_i_h_wts[5, 89] = 3.73819408490804e-001;

            __statist_i_h_wts[5, 90] = 1.70444694644997e-001;

            __statist_i_h_wts[5, 91] = -6.75925705951066e-001;

            __statist_i_h_wts[5, 92] = 2.97970558147962e-001;

            __statist_i_h_wts[5, 93] = 2.82924615166961e-002;

            __statist_i_h_wts[5, 94] = -4.67822535530394e-001;

            __statist_i_h_wts[5, 95] = -1.26335092651603e-001;

            __statist_i_h_wts[5, 96] = 1.86703762733286e-001;

            __statist_i_h_wts[5, 97] = -2.08245031496147e-001;

            __statist_i_h_wts[5, 98] = -1.59746304956447e-001;

            __statist_i_h_wts[5, 99] = 2.52493350478516e-001;

            __statist_i_h_wts[5, 100] = -2.40972382203559e-001;

            __statist_i_h_wts[5, 101] = 1.93258827904178e-001;

            __statist_i_h_wts[5, 102] = 5.78345298231766e-003;

            __statist_i_h_wts[5, 103] = -3.32717258030676e-001;

            __statist_i_h_wts[5, 104] = 3.58700449082447e-001;

            __statist_i_h_wts[5, 105] = 1.86472482823491e-001;

            __statist_i_h_wts[5, 106] = -6.85977414506871e-001;

            __statist_i_h_wts[5, 107] = 2.62888426402565e-001;

            __statist_i_h_wts[5, 108] = 1.68909921067610e-002;

            __statist_i_h_wts[5, 109] = -4.21618236639726e-001;

            __statist_i_h_wts[5, 110] = 1.47569579589642e-001;

            __statist_i_h_wts[5, 111] = 5.33106959777022e-002;

            __statist_i_h_wts[5, 112] = -3.33500197542549e-001;

            __statist_i_h_wts[5, 113] = -1.95606345558309e-001;

            __statist_i_h_wts[5, 114] = 1.76362970563179e-001;

            __statist_i_h_wts[5, 115] = -1.17137397549469e-001;

            __statist_i_h_wts[5, 116] = 1.23076632416013e-001;

            __statist_i_h_wts[5, 117] = 5.84723052080145e-002;

            __statist_i_h_wts[5, 118] = -3.14915445343566e-001;

            __statist_i_h_wts[5, 119] = 4.04832406510911e-001;

            __statist_i_h_wts[5, 120] = 4.61348450269866e-003;

            __statist_i_h_wts[5, 121] = -5.58318244899419e-001;

            __statist_i_h_wts[5, 122] = 1.42386166109265e-001;

            __statist_i_h_wts[5, 123] = -1.24960049759474e-001;

            __statist_i_h_wts[5, 124] = -1.54843164311605e-001;

            __statist_i_h_wts[5, 125] = -1.46956501560222e-005;

            __statist_i_h_wts[5, 126] = 1.23860056845161e-001;

            __statist_i_h_wts[5, 127] = -2.67559456149588e-001;



            __statist_i_h_wts[6, 0] = -6.35229550012218e-002;

            __statist_i_h_wts[6, 1] = -8.81549478605575e-002;

            __statist_i_h_wts[6, 2] = -5.12567210282573e-002;

            __statist_i_h_wts[6, 3] = 1.49720829178542e-001;

            __statist_i_h_wts[6, 4] = 9.93189668304995e-002;

            __statist_i_h_wts[6, 5] = -1.44890690491855e-001;

            __statist_i_h_wts[6, 6] = -1.16918081860505e-001;

            __statist_i_h_wts[6, 7] = 9.01544205613789e-002;

            __statist_i_h_wts[6, 8] = -1.21650215294664e-001;

            __statist_i_h_wts[6, 9] = 1.58787610653207e-001;

            __statist_i_h_wts[6, 10] = -3.79421549688086e-002;

            __statist_i_h_wts[6, 11] = -4.08060511968432e-002;

            __statist_i_h_wts[6, 12] = -4.95724212128278e-002;

            __statist_i_h_wts[6, 13] = -7.12872542880338e-004;

            __statist_i_h_wts[6, 14] = -1.12087198507015e-001;

            __statist_i_h_wts[6, 15] = -5.04768809535524e-003;

            __statist_i_h_wts[6, 16] = 5.84503797204832e-002;

            __statist_i_h_wts[6, 17] = 1.56039978232579e-001;

            __statist_i_h_wts[6, 18] = -2.60880865461002e-002;

            __statist_i_h_wts[6, 19] = -1.28072064246019e-001;

            __statist_i_h_wts[6, 20] = -4.55777049353663e-002;

            __statist_i_h_wts[6, 21] = 8.89698543447808e-002;

            __statist_i_h_wts[6, 22] = 1.22509464270369e-001;

            __statist_i_h_wts[6, 23] = 3.16682016506423e-001;

            __statist_i_h_wts[6, 24] = -4.22182633661424e-002;

            __statist_i_h_wts[6, 25] = -1.19162665963391e-001;

            __statist_i_h_wts[6, 26] = 3.83765137810771e-002;

            __statist_i_h_wts[6, 27] = 9.35708024879702e-002;

            __statist_i_h_wts[6, 28] = 4.19117509498575e-002;

            __statist_i_h_wts[6, 29] = 5.83139500484237e-003;

            __statist_i_h_wts[6, 30] = -4.16289264684275e-002;

            __statist_i_h_wts[6, 31] = -1.07607337250492e-001;

            __statist_i_h_wts[6, 32] = -9.26238804768773e-002;

            __statist_i_h_wts[6, 33] = -1.66475817061759e-001;

            __statist_i_h_wts[6, 34] = -1.08472128392273e-001;

            __statist_i_h_wts[6, 35] = -9.26197419463268e-002;

            __statist_i_h_wts[6, 36] = 3.34887293056128e-004;

            __statist_i_h_wts[6, 37] = -2.15613100530746e-001;

            __statist_i_h_wts[6, 38] = 1.39069920935599e-001;

            __statist_i_h_wts[6, 39] = 5.26974401702887e-002;

            __statist_i_h_wts[6, 40] = 1.49591302834678e-001;

            __statist_i_h_wts[6, 41] = 1.23176268401971e-001;

            __statist_i_h_wts[6, 42] = 2.06274640032964e-002;

            __statist_i_h_wts[6, 43] = -1.32458376003162e-001;

            __statist_i_h_wts[6, 44] = -1.17141945706711e-001;

            __statist_i_h_wts[6, 45] = -4.46084970499252e-002;

            __statist_i_h_wts[6, 46] = 9.46864687857498e-003;

            __statist_i_h_wts[6, 47] = 4.68975184039461e-002;

            __statist_i_h_wts[6, 48] = -5.59376838360547e-003;

            __statist_i_h_wts[6, 49] = -1.45936189646318e-002;

            __statist_i_h_wts[6, 50] = 1.44502019021982e-001;

            __statist_i_h_wts[6, 51] = 4.66545339211563e-003;

            __statist_i_h_wts[6, 52] = 1.45812476535896e-001;

            __statist_i_h_wts[6, 53] = 1.78467869524647e-001;

            __statist_i_h_wts[6, 54] = -6.47098083646555e-002;

            __statist_i_h_wts[6, 55] = -2.72528894585207e-001;

            __statist_i_h_wts[6, 56] = -3.15744383515649e-002;

            __statist_i_h_wts[6, 57] = -8.87584772800763e-002;

            __statist_i_h_wts[6, 58] = 6.11492132048836e-002;

            __statist_i_h_wts[6, 59] = -2.25527920287016e-001;

            __statist_i_h_wts[6, 60] = -1.38560335357178e-001;

            __statist_i_h_wts[6, 61] = 2.72336422751314e-001;

            __statist_i_h_wts[6, 62] = -4.52209110156256e-001;

            __statist_i_h_wts[6, 63] = -3.11469555106253e-001;

            __statist_i_h_wts[6, 64] = 6.76836291959119e-001;

            __statist_i_h_wts[6, 65] = -2.51401281695677e-001;

            __statist_i_h_wts[6, 66] = -1.22941207475495e-001;

            __statist_i_h_wts[6, 67] = 2.52148968530975e-001;

            __statist_i_h_wts[6, 68] = -4.25074112151063e-002;

            __statist_i_h_wts[6, 69] = -1.31633719398225e-001;

            __statist_i_h_wts[6, 70] = 8.62056879712752e-002;

            __statist_i_h_wts[6, 71] = 4.04730692118150e-002;

            __statist_i_h_wts[6, 72] = -8.00485109153470e-002;

            __statist_i_h_wts[6, 73] = -5.28966681170077e-002;

            __statist_i_h_wts[6, 74] = -9.53682066849497e-002;

            __statist_i_h_wts[6, 75] = -1.12720895041189e-001;

            __statist_i_h_wts[6, 76] = 1.51130031024495e-001;

            __statist_i_h_wts[6, 77] = -1.12823085922519e+000;

            __statist_i_h_wts[6, 78] = -1.83440039342394e-001;

            __statist_i_h_wts[6, 79] = 1.22420860110487e+000;

            __statist_i_h_wts[6, 80] = -1.96076424308367e-002;

            __statist_i_h_wts[6, 81] = -1.61898713951620e-001;

            __statist_i_h_wts[6, 82] = 9.91172895077522e-002;

            __statist_i_h_wts[6, 83] = -1.04585827495404e-001;

            __statist_i_h_wts[6, 84] = -1.31457255300211e-002;

            __statist_i_h_wts[6, 85] = 2.52686794949945e-002;

            __statist_i_h_wts[6, 86] = 2.47527692262978e-001;

            __statist_i_h_wts[6, 87] = -3.88858107458140e-002;

            __statist_i_h_wts[6, 88] = -3.16487175828658e-001;

            __statist_i_h_wts[6, 89] = 3.87592157225431e-001;

            __statist_i_h_wts[6, 90] = 1.46949936607272e-001;

            __statist_i_h_wts[6, 91] = -6.23601894544356e-001;

            __statist_i_h_wts[6, 92] = 3.95405426628982e-001;

            __statist_i_h_wts[6, 93] = -2.16978027826598e-004;

            __statist_i_h_wts[6, 94] = -4.75767582905912e-001;

            __statist_i_h_wts[6, 95] = 6.22880915625575e-002;

            __statist_i_h_wts[6, 96] = 9.29759000483705e-002;

            __statist_i_h_wts[6, 97] = -2.44902686163316e-001;

            __statist_i_h_wts[6, 98] = 7.24705159009973e-002;

            __statist_i_h_wts[6, 99] = 7.46982393255049e-002;

            __statist_i_h_wts[6, 100] = -2.13693831101053e-001;

            __statist_i_h_wts[6, 101] = 1.50742652458797e-001;

            __statist_i_h_wts[6, 102] = 9.32535005685335e-002;

            __statist_i_h_wts[6, 103] = -3.09980497937872e-001;

            __statist_i_h_wts[6, 104] = 1.34019822350022e-001;

            __statist_i_h_wts[6, 105] = 4.81062821291177e-001;

            __statist_i_h_wts[6, 106] = -6.76577476411448e-001;

            __statist_i_h_wts[6, 107] = 1.04773866392103e-001;

            __statist_i_h_wts[6, 108] = 1.86607721843774e-001;

            __statist_i_h_wts[6, 109] = -3.92898953203507e-001;

            __statist_i_h_wts[6, 110] = 5.20551944795225e-002;

            __statist_i_h_wts[6, 111] = 1.45369379705424e-001;

            __statist_i_h_wts[6, 112] = -2.92203007344558e-001;

            __statist_i_h_wts[6, 113] = 4.56266743581788e-002;

            __statist_i_h_wts[6, 114] = -2.55666858101079e-002;

            __statist_i_h_wts[6, 115] = -1.25119854255978e-001;

            __statist_i_h_wts[6, 116] = 8.54796764010970e-002;

            __statist_i_h_wts[6, 117] = 1.02639124237545e-001;

            __statist_i_h_wts[6, 118] = -2.63635590616364e-001;

            __statist_i_h_wts[6, 119] = 2.40968106680221e-001;

            __statist_i_h_wts[6, 120] = 2.36208468121504e-001;

            __statist_i_h_wts[6, 121] = -5.69233584880210e-001;

            __statist_i_h_wts[6, 122] = 4.98637201135510e-002;

            __statist_i_h_wts[6, 123] = 2.75612519735545e-002;

            __statist_i_h_wts[6, 124] = -1.69941106609641e-001;

            __statist_i_h_wts[6, 125] = 1.70592555575445e-002;

            __statist_i_h_wts[6, 126] = 1.87478556791519e-001;

            __statist_i_h_wts[6, 127] = -2.73343732937894e-001;



            __statist_i_h_wts[7, 0] = -2.49884450696482e-002;

            __statist_i_h_wts[7, 1] = -4.93153140465013e-002;

            __statist_i_h_wts[7, 2] = -4.89455037117732e-002;

            __statist_i_h_wts[7, 3] = 6.80721618456593e-002;

            __statist_i_h_wts[7, 4] = 5.21856768501741e-002;

            __statist_i_h_wts[7, 5] = -1.06457129120538e-001;

            __statist_i_h_wts[7, 6] = -5.70115499128352e-002;

            __statist_i_h_wts[7, 7] = 3.02503748918811e-002;

            __statist_i_h_wts[7, 8] = -4.35289009768559e-002;

            __statist_i_h_wts[7, 9] = 5.48699763208410e-002;

            __statist_i_h_wts[7, 10] = -5.33266773697143e-002;

            __statist_i_h_wts[7, 11] = -4.05222154686660e-002;

            __statist_i_h_wts[7, 12] = -5.25971566618902e-003;

            __statist_i_h_wts[7, 13] = -2.66268478364167e-003;

            __statist_i_h_wts[7, 14] = -4.94666361322440e-002;

            __statist_i_h_wts[7, 15] = 2.12893682526984e-002;

            __statist_i_h_wts[7, 16] = 8.39679531095713e-002;

            __statist_i_h_wts[7, 17] = 8.11847809996188e-002;

            __statist_i_h_wts[7, 18] = -9.83391972975199e-003;

            __statist_i_h_wts[7, 19] = -4.04029489138252e-002;

            __statist_i_h_wts[7, 20] = 1.36867642990696e-002;

            __statist_i_h_wts[7, 21] = 4.11116920458193e-002;

            __statist_i_h_wts[7, 22] = 5.47296306582662e-002;

            __statist_i_h_wts[7, 23] = 1.51030642782131e-001;

            __statist_i_h_wts[7, 24] = -2.85971630614788e-002;

            __statist_i_h_wts[7, 25] = -4.62546370803603e-002;

            __statist_i_h_wts[7, 26] = -6.90094602276476e-003;

            __statist_i_h_wts[7, 27] = 6.30139458074053e-002;

            __statist_i_h_wts[7, 28] = 4.79317707750357e-002;

            __statist_i_h_wts[7, 29] = -1.95224875803915e-002;

            __statist_i_h_wts[7, 30] = -3.24517152786565e-002;

            __statist_i_h_wts[7, 31] = 5.66351706077184e-003;

            __statist_i_h_wts[7, 32] = -7.26760257342419e-002;

            __statist_i_h_wts[7, 33] = -8.78850396349461e-002;

            __statist_i_h_wts[7, 34] = -5.33238965575726e-002;

            __statist_i_h_wts[7, 35] = -5.23142100839449e-002;

            __statist_i_h_wts[7, 36] = -1.56706532606338e-002;

            __statist_i_h_wts[7, 37] = -6.23433195967947e-002;

            __statist_i_h_wts[7, 38] = 9.90646593727958e-002;

            __statist_i_h_wts[7, 39] = 8.05820498832608e-003;

            __statist_i_h_wts[7, 40] = 8.49021016638168e-002;

            __statist_i_h_wts[7, 41] = 4.96425700349363e-002;

            __statist_i_h_wts[7, 42] = 6.90670818878023e-002;

            __statist_i_h_wts[7, 43] = -4.98808822092802e-002;

            __statist_i_h_wts[7, 44] = -2.02969575463099e-002;

            __statist_i_h_wts[7, 45] = -9.43651615386383e-003;

            __statist_i_h_wts[7, 46] = 2.21225713497472e-003;

            __statist_i_h_wts[7, 47] = 1.40765172252061e-002;

            __statist_i_h_wts[7, 48] = 3.65664666275302e-002;

            __statist_i_h_wts[7, 49] = -1.87421308370353e-002;

            __statist_i_h_wts[7, 50] = -1.15042990508226e-002;

            __statist_i_h_wts[7, 51] = -5.84407947656542e-002;

            __statist_i_h_wts[7, 52] = 6.28157145069904e-002;

            __statist_i_h_wts[7, 53] = 1.19807339864102e-001;

            __statist_i_h_wts[7, 54] = 1.24593995017689e-002;

            __statist_i_h_wts[7, 55] = -8.31016476201598e-002;

            __statist_i_h_wts[7, 56] = 6.83802082601696e-002;

            __statist_i_h_wts[7, 57] = -7.34415030468214e-002;

            __statist_i_h_wts[7, 58] = 1.20855685553752e-002;

            __statist_i_h_wts[7, 59] = -8.51034676822486e-002;

            __statist_i_h_wts[7, 60] = -2.62033817807944e-002;

            __statist_i_h_wts[7, 61] = 1.43439846045988e-001;

            __statist_i_h_wts[7, 62] = 4.39446510442410e-002;

            __statist_i_h_wts[7, 63] = -2.77694733996058e-001;

            __statist_i_h_wts[7, 64] = 2.66834897915924e-001;

            __statist_i_h_wts[7, 65] = -8.58427486588510e-002;

            __statist_i_h_wts[7, 66] = 8.03721038042992e-003;

            __statist_i_h_wts[7, 67] = 8.43666085330691e-002;

            __statist_i_h_wts[7, 68] = 1.02375536232348e-001;

            __statist_i_h_wts[7, 69] = -1.46382247446748e-001;

            __statist_i_h_wts[7, 70] = 9.06461668987537e-002;

            __statist_i_h_wts[7, 71] = 1.08773733706802e-001;

            __statist_i_h_wts[7, 72] = -5.09890715077884e-002;

            __statist_i_h_wts[7, 73] = -4.81442802793125e-002;

            __statist_i_h_wts[7, 74] = 5.63113031822332e-002;

            __statist_i_h_wts[7, 75] = -1.10687757907572e-001;

            __statist_i_h_wts[7, 76] = 9.91322763118057e-002;

            __statist_i_h_wts[7, 77] = -2.63637289835456e-001;

            __statist_i_h_wts[7, 78] = -2.26404945725646e-001;

            __statist_i_h_wts[7, 79] = 5.44848210820173e-001;

            __statist_i_h_wts[7, 80] = 1.87229927489861e-002;

            __statist_i_h_wts[7, 81] = -6.91959986936144e-002;

            __statist_i_h_wts[7, 82] = 7.40961291398646e-002;

            __statist_i_h_wts[7, 83] = 3.13549833714395e-002;

            __statist_i_h_wts[7, 84] = -2.46849960957683e-002;

            __statist_i_h_wts[7, 85] = 4.74676708933333e-002;

            __statist_i_h_wts[7, 86] = -8.88595524075520e-002;

            __statist_i_h_wts[7, 87] = 2.71781464390785e-001;

            __statist_i_h_wts[7, 88] = -1.30520998436990e-001;

            __statist_i_h_wts[7, 89] = -2.19185437778200e-002;

            __statist_i_h_wts[7, 90] = 2.74267338085568e-001;

            __statist_i_h_wts[7, 91] = -2.30113395762048e-001;

            __statist_i_h_wts[7, 92] = -1.80310362282632e-003;

            __statist_i_h_wts[7, 93] = 2.40160130668808e-001;

            __statist_i_h_wts[7, 94] = -1.84179716774237e-001;

            __statist_i_h_wts[7, 95] = -1.47155202550149e-001;

            __statist_i_h_wts[7, 96] = 2.10560634957204e-001;

            __statist_i_h_wts[7, 97] = -5.84189938956375e-002;

            __statist_i_h_wts[7, 98] = 2.05001094599530e-001;

            __statist_i_h_wts[7, 99] = -4.90577265660532e-002;

            __statist_i_h_wts[7, 100] = -1.19782257740928e-001;

            __statist_i_h_wts[7, 101] = 1.56472263163730e-001;

            __statist_i_h_wts[7, 102] = 7.59451249051452e-003;

            __statist_i_h_wts[7, 103] = -1.58299194721423e-001;

            __statist_i_h_wts[7, 104] = 2.88366517962897e-001;

            __statist_i_h_wts[7, 105] = 3.27318372117625e-002;

            __statist_i_h_wts[7, 106] = -3.03711910744612e-001;

            __statist_i_h_wts[7, 107] = 2.28073675332973e-001;

            __statist_i_h_wts[7, 108] = -1.00937786277584e-002;

            __statist_i_h_wts[7, 109] = -2.07471535180144e-001;

            __statist_i_h_wts[7, 110] = 1.70020332743754e-001;

            __statist_i_h_wts[7, 111] = 1.37845170580797e-002;

            __statist_i_h_wts[7, 112] = -1.46728240006854e-001;

            __statist_i_h_wts[7, 113] = 1.29699873983054e-001;

            __statist_i_h_wts[7, 114] = -2.92148448168746e-002;

            __statist_i_h_wts[7, 115] = -7.45347703117038e-002;

            __statist_i_h_wts[7, 116] = 1.02751537243744e-001;

            __statist_i_h_wts[7, 117] = 4.19379883487512e-002;

            __statist_i_h_wts[7, 118] = -1.16144081210989e-001;

            __statist_i_h_wts[7, 119] = 2.81093472297388e-001;

            __statist_i_h_wts[7, 120] = -1.15427100725054e-002;

            __statist_i_h_wts[7, 121] = -2.33969384756418e-001;

            __statist_i_h_wts[7, 122] = 1.30596593697179e-001;

            __statist_i_h_wts[7, 123] = -5.00647837938025e-002;

            __statist_i_h_wts[7, 124] = -5.74891334531316e-002;

            __statist_i_h_wts[7, 125] = 1.04766274362735e-001;

            __statist_i_h_wts[7, 126] = 5.30028016841225e-002;

            __statist_i_h_wts[7, 127] = -1.23087948956049e-001;



            __statist_i_h_wts[8, 0] = -7.10781319126416e-002;

            __statist_i_h_wts[8, 1] = -8.76496002031766e-002;

            __statist_i_h_wts[8, 2] = -3.43542344046361e-002;

            __statist_i_h_wts[8, 3] = 1.03107882012198e-001;

            __statist_i_h_wts[8, 4] = 5.46259126226929e-002;

            __statist_i_h_wts[8, 5] = -6.78592670034003e-002;

            __statist_i_h_wts[8, 6] = -4.57198020529366e-002;

            __statist_i_h_wts[8, 7] = 7.51326965985309e-002;

            __statist_i_h_wts[8, 8] = -8.79694494076167e-002;

            __statist_i_h_wts[8, 9] = 1.38869106230088e-001;

            __statist_i_h_wts[8, 10] = -8.25273658827450e-002;

            __statist_i_h_wts[8, 11] = -2.29275738835060e-002;

            __statist_i_h_wts[8, 12] = -6.52475358781850e-002;

            __statist_i_h_wts[8, 13] = 2.26191464440965e-004;

            __statist_i_h_wts[8, 14] = -6.37244126933894e-002;

            __statist_i_h_wts[8, 15] = 2.30113434097956e-003;

            __statist_i_h_wts[8, 16] = 2.12884802603301e-002;

            __statist_i_h_wts[8, 17] = 1.12479135584029e-001;

            __statist_i_h_wts[8, 18] = 3.60177021708144e-002;

            __statist_i_h_wts[8, 19] = -8.03219739355295e-002;

            __statist_i_h_wts[8, 20] = -4.70941918151022e-002;

            __statist_i_h_wts[8, 21] = 6.77319989354022e-002;

            __statist_i_h_wts[8, 22] = 9.05482717254463e-002;

            __statist_i_h_wts[8, 23] = 1.97059440143058e-001;

            __statist_i_h_wts[8, 24] = -2.05407276942934e-002;

            __statist_i_h_wts[8, 25] = -6.46421090239466e-002;

            __statist_i_h_wts[8, 26] = 4.17053344276711e-002;

            __statist_i_h_wts[8, 27] = 6.14098254079772e-002;

            __statist_i_h_wts[8, 28] = 1.03148418295268e-002;

            __statist_i_h_wts[8, 29] = -3.81101573557987e-002;

            __statist_i_h_wts[8, 30] = -4.13187483932455e-002;

            __statist_i_h_wts[8, 31] = -8.14137634070909e-002;

            __statist_i_h_wts[8, 32] = -6.13725376584705e-002;

            __statist_i_h_wts[8, 33] = -1.29081503462588e-001;

            __statist_i_h_wts[8, 34] = -7.46821321655634e-002;

            __statist_i_h_wts[8, 35] = -5.11149842826002e-002;

            __statist_i_h_wts[8, 36] = -7.67306522825073e-003;

            __statist_i_h_wts[8, 37] = -2.21993588887815e-001;

            __statist_i_h_wts[8, 38] = 6.19929006358572e-002;

            __statist_i_h_wts[8, 39] = 4.87378057497063e-002;

            __statist_i_h_wts[8, 40] = 1.05284338527607e-001;

            __statist_i_h_wts[8, 41] = 6.63150536584372e-002;

            __statist_i_h_wts[8, 42] = -9.73393559145452e-002;

            __statist_i_h_wts[8, 43] = -1.32104260718234e-001;

            __statist_i_h_wts[8, 44] = -9.07928122470052e-002;

            __statist_i_h_wts[8, 45] = -2.44272119882349e-002;

            __statist_i_h_wts[8, 46] = 4.77233190727272e-003;

            __statist_i_h_wts[8, 47] = 3.77494718812787e-002;

            __statist_i_h_wts[8, 48] = 2.22417067318680e-002;

            __statist_i_h_wts[8, 49] = -1.65836495566273e-002;

            __statist_i_h_wts[8, 50] = 1.13767502058288e-001;

            __statist_i_h_wts[8, 51] = 1.40915739865946e-001;

            __statist_i_h_wts[8, 52] = 1.72852777206700e-001;

            __statist_i_h_wts[8, 53] = 1.36830697810586e-001;

            __statist_i_h_wts[8, 54] = -1.11163831006532e-001;

            __statist_i_h_wts[8, 55] = -2.10640078683595e-001;

            __statist_i_h_wts[8, 56] = -7.44113333548112e-002;

            __statist_i_h_wts[8, 57] = -7.90422592942385e-002;

            __statist_i_h_wts[8, 58] = 3.02934473540559e-002;

            __statist_i_h_wts[8, 59] = -7.93693544922150e-002;

            __statist_i_h_wts[8, 60] = -1.92718419947743e-001;

            __statist_i_h_wts[8, 61] = 2.00971368509982e-001;

            __statist_i_h_wts[8, 62] = -6.76523134624174e-001;

            __statist_i_h_wts[8, 63] = -7.22454357157726e-003;

            __statist_i_h_wts[8, 64] = 5.89745763207357e-001;

            __statist_i_h_wts[8, 65] = -1.41809483894833e-001;

            __statist_i_h_wts[8, 66] = -1.97473000504033e-001;

            __statist_i_h_wts[8, 67] = 2.21813404327999e-001;

            __statist_i_h_wts[8, 68] = -2.05282937049628e-001;

            __statist_i_h_wts[8, 69] = 4.65468924118519e-002;

            __statist_i_h_wts[8, 70] = 8.17103948646170e-002;

            __statist_i_h_wts[8, 71] = -1.14035591100910e-001;

            __statist_i_h_wts[8, 72] = 6.13476180260125e-002;

            __statist_i_h_wts[8, 73] = -6.10347428241857e-002;

            __statist_i_h_wts[8, 74] = -2.58226547547515e-001;

            __statist_i_h_wts[8, 75] = 7.69992904828965e-002;

            __statist_i_h_wts[8, 76] = 9.94334571520524e-002;

            __statist_i_h_wts[8, 77] = -1.17305558244750e+000;

            __statist_i_h_wts[8, 78] = 5.53921437256965e-002;

            __statist_i_h_wts[8, 79] = 1.04309246493927e+000;

            __statist_i_h_wts[8, 80] = -3.16296347935173e-002;

            __statist_i_h_wts[8, 81] = -9.72621402783455e-002;

            __statist_i_h_wts[8, 82] = 4.65086084243124e-002;

            __statist_i_h_wts[8, 83] = -1.97874730133694e-001;

            __statist_i_h_wts[8, 84] = 8.88823031192304e-002;

            __statist_i_h_wts[8, 85] = -3.06907938486963e-003;

            __statist_i_h_wts[8, 86] = 3.17352845677106e-001;

            __statist_i_h_wts[8, 87] = -1.29539160237681e-001;

            __statist_i_h_wts[8, 88] = -2.75727981208757e-001;

            __statist_i_h_wts[8, 89] = 4.31617715354973e-001;

            __statist_i_h_wts[8, 90] = -4.15901949103659e-002;

            __statist_i_h_wts[8, 91] = -4.77824897110322e-001;

            __statist_i_h_wts[8, 92] = 5.05546590551312e-001;

            __statist_i_h_wts[8, 93] = -1.85475962845828e-001;

            __statist_i_h_wts[8, 94] = -3.79752725470140e-001;

            __statist_i_h_wts[8, 95] = 1.41121670340629e-001;

            __statist_i_h_wts[8, 96] = -5.58259638237982e-002;

            __statist_i_h_wts[8, 97] = -1.62011992313110e-001;

            __statist_i_h_wts[8, 98] = -3.09901490957236e-003;

            __statist_i_h_wts[8, 99] = 3.92743875792361e-002;

            __statist_i_h_wts[8, 100] = -1.36079956818967e-001;

            __statist_i_h_wts[8, 101] = 3.72771533559452e-002;

            __statist_i_h_wts[8, 102] = 7.51821723867527e-002;

            __statist_i_h_wts[8, 103] = -2.21802668476257e-001;

            __statist_i_h_wts[8, 104] = -1.24253449886842e-001;

            __statist_i_h_wts[8, 105] = 5.61884895491305e-001;

            __statist_i_h_wts[8, 106] = -5.50235935880617e-001;

            __statist_i_h_wts[8, 107] = -1.00608028475240e-002;

            __statist_i_h_wts[8, 108] = 1.85962851453175e-001;

            __statist_i_h_wts[8, 109] = -2.99040266165775e-001;

            __statist_i_h_wts[8, 110] = 3.49154551327121e-002;

            __statist_i_h_wts[8, 111] = 1.00356804840812e-001;

            __statist_i_h_wts[8, 112] = -2.04754258381850e-001;

            __statist_i_h_wts[8, 113] = 4.60984721189742e-002;

            __statist_i_h_wts[8, 114] = -3.97258436227722e-002;

            __statist_i_h_wts[8, 115] = -5.40417100717690e-002;

            __statist_i_h_wts[8, 116] = 7.63327263319688e-002;

            __statist_i_h_wts[8, 117] = 3.88988087071039e-002;

            __statist_i_h_wts[8, 118] = -2.25190792054619e-001;

            __statist_i_h_wts[8, 119] = 2.20184059670695e-002;

            __statist_i_h_wts[8, 120] = 3.24910329276025e-001;

            __statist_i_h_wts[8, 121] = -4.44272508672652e-001;

            __statist_i_h_wts[8, 122] = 6.05361857334738e-002;

            __statist_i_h_wts[8, 123] = -3.07737926936150e-002;

            __statist_i_h_wts[8, 124] = -1.11833220254530e-001;

            __statist_i_h_wts[8, 125] = -1.82906893267586e-003;

            __statist_i_h_wts[8, 126] = 9.67515624138357e-002;

            __statist_i_h_wts[8, 127] = -2.00279314975483e-001;



            __statist_i_h_wts[9, 0] = 4.32962884474513e-002;

            __statist_i_h_wts[9, 1] = 3.49033805818001e-002;

            __statist_i_h_wts[9, 2] = 4.25180186891418e-002;

            __statist_i_h_wts[9, 3] = -8.35623785303525e-002;

            __statist_i_h_wts[9, 4] = -2.22113039988491e-002;

            __statist_i_h_wts[9, 5] = 7.16752833846889e-002;

            __statist_i_h_wts[9, 6] = 5.54306119731889e-002;

            __statist_i_h_wts[9, 7] = -6.24321272277790e-002;

            __statist_i_h_wts[9, 8] = 5.20170118398017e-002;

            __statist_i_h_wts[9, 9] = -1.01060645370276e-001;

            __statist_i_h_wts[9, 10] = 6.40642841315691e-002;

            __statist_i_h_wts[9, 11] = 1.85130307487116e-002;

            __statist_i_h_wts[9, 12] = 2.63424248453268e-002;

            __statist_i_h_wts[9, 13] = 1.61918966142642e-002;

            __statist_i_h_wts[9, 14] = 5.16695820495628e-002;

            __statist_i_h_wts[9, 15] = -4.73400658661260e-003;

            __statist_i_h_wts[9, 16] = -3.31782516424683e-002;

            __statist_i_h_wts[9, 17] = -9.67273116855118e-002;

            __statist_i_h_wts[9, 18] = 4.66934563289611e-003;

            __statist_i_h_wts[9, 19] = 6.18505092118471e-002;

            __statist_i_h_wts[9, 20] = 3.29479896153021e-002;

            __statist_i_h_wts[9, 21] = -3.79167347054215e-002;

            __statist_i_h_wts[9, 22] = -3.72862254576419e-002;

            __statist_i_h_wts[9, 23] = -1.57470063562898e-001;

            __statist_i_h_wts[9, 24] = 1.56935431928494e-002;

            __statist_i_h_wts[9, 25] = 3.59098627340543e-002;

            __statist_i_h_wts[9, 26] = -1.21696697473023e-002;

            __statist_i_h_wts[9, 27] = -5.46002149283978e-002;

            __statist_i_h_wts[9, 28] = -4.41981233708957e-002;

            __statist_i_h_wts[9, 29] = -5.10211259760321e-003;

            __statist_i_h_wts[9, 30] = 3.24498816704096e-002;

            __statist_i_h_wts[9, 31] = 3.99064181515883e-002;

            __statist_i_h_wts[9, 32] = 5.64723214405589e-002;

            __statist_i_h_wts[9, 33] = 7.12021593314375e-002;

            __statist_i_h_wts[9, 34] = 6.60219714339809e-002;

            __statist_i_h_wts[9, 35] = 4.27796818114193e-002;

            __statist_i_h_wts[9, 36] = -1.82667221326285e-004;

            __statist_i_h_wts[9, 37] = 1.31562328178739e-001;

            __statist_i_h_wts[9, 38] = -7.81186094345308e-002;

            __statist_i_h_wts[9, 39] = -4.01352444562924e-002;

            __statist_i_h_wts[9, 40] = -9.35171346684701e-002;

            __statist_i_h_wts[9, 41] = -6.21531500495836e-002;

            __statist_i_h_wts[9, 42] = -3.99985640772480e-003;

            __statist_i_h_wts[9, 43] = 4.76719188057461e-002;

            __statist_i_h_wts[9, 44] = 6.14718567310087e-002;

            __statist_i_h_wts[9, 45] = 1.42510868402127e-002;

            __statist_i_h_wts[9, 46] = 2.92870657162128e-003;

            __statist_i_h_wts[9, 47] = -6.39395279601145e-003;

            __statist_i_h_wts[9, 48] = -5.30880057887544e-002;

            __statist_i_h_wts[9, 49] = -6.59894552692250e-003;

            __statist_i_h_wts[9, 50] = -1.36818460692551e-002;

            __statist_i_h_wts[9, 51] = 9.96433065294548e-003;

            __statist_i_h_wts[9, 52] = -1.30802768215655e-001;

            __statist_i_h_wts[9, 53] = -1.13865038378377e-001;

            __statist_i_h_wts[9, 54] = 2.84281187066748e-002;

            __statist_i_h_wts[9, 55] = 1.65388709042979e-001;

            __statist_i_h_wts[9, 56] = -7.48914911305893e-004;

            __statist_i_h_wts[9, 57] = 3.23145681046658e-002;

            __statist_i_h_wts[9, 58] = -1.65319262984589e-002;

            __statist_i_h_wts[9, 59] = 3.79664696846077e-002;

            __statist_i_h_wts[9, 60] = 1.24432914148100e-001;

            __statist_i_h_wts[9, 61] = -1.68237804500347e-001;

            __statist_i_h_wts[9, 62] = 1.30778681464365e-001;

            __statist_i_h_wts[9, 63] = 2.43306761599974e-001;

            __statist_i_h_wts[9, 64] = -3.43959359565608e-001;

            __statist_i_h_wts[9, 65] = -1.34709474156017e-003;

            __statist_i_h_wts[9, 66] = 1.13214318909465e-001;

            __statist_i_h_wts[9, 67] = -1.38128017358431e-001;

            __statist_i_h_wts[9, 68] = -6.38448648891134e-002;

            __statist_i_h_wts[9, 69] = 1.58091161199586e-001;

            __statist_i_h_wts[9, 70] = -8.36907954548281e-002;

            __statist_i_h_wts[9, 71] = -3.85682791619036e-002;

            __statist_i_h_wts[9, 72] = 2.05425321796305e-002;

            __statist_i_h_wts[9, 73] = 2.57887137998513e-002;

            __statist_i_h_wts[9, 74] = 4.58447156185419e-002;

            __statist_i_h_wts[9, 75] = 6.99496397906306e-002;

            __statist_i_h_wts[9, 76] = -1.05090419598050e-001;

            __statist_i_h_wts[9, 77] = 4.84597641431831e-001;

            __statist_i_h_wts[9, 78] = 2.40229449407160e-001;

            __statist_i_h_wts[9, 79] = -6.92373834516832e-001;

            __statist_i_h_wts[9, 80] = -7.11383812834892e-002;

            __statist_i_h_wts[9, 81] = 1.41704317973920e-001;

            __statist_i_h_wts[9, 82] = -8.30147783277880e-002;

            __statist_i_h_wts[9, 83] = -3.67526047592112e-002;

            __statist_i_h_wts[9, 84] = 7.35945608684357e-002;

            __statist_i_h_wts[9, 85] = -1.61333966025542e-002;

            __statist_i_h_wts[9, 86] = 4.71018133207046e-002;

            __statist_i_h_wts[9, 87] = -2.17674381313890e-001;

            __statist_i_h_wts[9, 88] = 1.71926342683709e-001;

            __statist_i_h_wts[9, 89] = -3.35234483917727e-003;

            __statist_i_h_wts[9, 90] = -2.71363816740012e-001;

            __statist_i_h_wts[9, 91] = 2.65819199857322e-001;

            __statist_i_h_wts[9, 92] = -5.72232170312566e-002;

            __statist_i_h_wts[9, 93] = -1.72885418193213e-001;

            __statist_i_h_wts[9, 94] = 2.15054602542770e-001;

            __statist_i_h_wts[9, 95] = 9.66550074778796e-002;

            __statist_i_h_wts[9, 96] = -1.68681866473751e-001;

            __statist_i_h_wts[9, 97] = 6.68246755934229e-002;

            __statist_i_h_wts[9, 98] = -1.31932341059247e-001;

            __statist_i_h_wts[9, 99] = -8.36302636286635e-005;

            __statist_i_h_wts[9, 100] = 1.19318046145616e-001;

            __statist_i_h_wts[9, 101] = -1.22613835979166e-001;

            __statist_i_h_wts[9, 102] = -3.31995819449862e-002;

            __statist_i_h_wts[9, 103] = 1.65416141138617e-001;

            __statist_i_h_wts[9, 104] = -2.78796897776264e-001;

            __statist_i_h_wts[9, 105] = -1.00896575678963e-001;

            __statist_i_h_wts[9, 106] = 3.60908348399679e-001;

            __statist_i_h_wts[9, 107] = -1.62110961702676e-001;

            __statist_i_h_wts[9, 108] = -4.88189601588805e-002;

            __statist_i_h_wts[9, 109] = 2.15966070784464e-001;

            __statist_i_h_wts[9, 110] = -1.95818491940132e-001;

            __statist_i_h_wts[9, 111] = 4.18423937007716e-002;

            __statist_i_h_wts[9, 112] = 1.46967732650208e-001;

            __statist_i_h_wts[9, 113] = -9.24702364612108e-002;

            __statist_i_h_wts[9, 114] = 2.03789782570852e-002;

            __statist_i_h_wts[9, 115] = 8.71683219391745e-002;

            __statist_i_h_wts[9, 116] = -1.04571593831119e-001;

            __statist_i_h_wts[9, 117] = -1.88232628979934e-002;

            __statist_i_h_wts[9, 118] = 1.26567793049942e-001;

            __statist_i_h_wts[9, 119] = -3.05212701223113e-001;

            __statist_i_h_wts[9, 120] = 1.75209968779291e-002;

            __statist_i_h_wts[9, 121] = 2.86390733492649e-001;

            __statist_i_h_wts[9, 122] = -1.39340826970025e-001;

            __statist_i_h_wts[9, 123] = 7.71558458363149e-002;

            __statist_i_h_wts[9, 124] = 7.95013223648870e-002;

            __statist_i_h_wts[9, 125] = -1.58996870625330e-001;

            __statist_i_h_wts[9, 126] = 1.65721944723440e-002;

            __statist_i_h_wts[9, 127] = 1.35435685400509e-001;



            __statist_i_h_wts[10, 0] = -6.67406270767606e-002;

            __statist_i_h_wts[10, 1] = -7.80081015094457e-002;

            __statist_i_h_wts[10, 2] = -5.40969102228355e-002;

            __statist_i_h_wts[10, 3] = 1.14348590356199e-001;

            __statist_i_h_wts[10, 4] = 8.68561452036470e-002;

            __statist_i_h_wts[10, 5] = -1.86126920620403e-001;

            __statist_i_h_wts[10, 6] = -8.02617469091700e-002;

            __statist_i_h_wts[10, 7] = 1.00521140342088e-001;

            __statist_i_h_wts[10, 8] = -1.17325750200798e-001;

            __statist_i_h_wts[10, 9] = 1.69685851482259e-001;

            __statist_i_h_wts[10, 10] = -9.68731410887426e-002;

            __statist_i_h_wts[10, 11] = -5.54533737868669e-002;

            __statist_i_h_wts[10, 12] = -4.28429520216396e-002;

            __statist_i_h_wts[10, 13] = 4.58139256691035e-002;

            __statist_i_h_wts[10, 14] = -8.29537975780556e-002;

            __statist_i_h_wts[10, 15] = 1.35607844926294e-002;

            __statist_i_h_wts[10, 16] = 8.35987747867846e-002;

            __statist_i_h_wts[10, 17] = 2.02177368052930e-001;

            __statist_i_h_wts[10, 18] = 2.26468576483679e-002;

            __statist_i_h_wts[10, 19] = -1.63632285386397e-001;

            __statist_i_h_wts[10, 20] = -4.18187023659991e-002;

            __statist_i_h_wts[10, 21] = 9.08072304529470e-002;

            __statist_i_h_wts[10, 22] = 9.86383145392380e-002;

            __statist_i_h_wts[10, 23] = 3.02245516011514e-001;

            __statist_i_h_wts[10, 24] = -4.95077619520273e-002;

            __statist_i_h_wts[10, 25] = -8.43028976096830e-002;

            __statist_i_h_wts[10, 26] = 3.38440146876661e-002;

            __statist_i_h_wts[10, 27] = 1.09131995651134e-001;

            __statist_i_h_wts[10, 28] = 3.91571817803137e-002;

            __statist_i_h_wts[10, 29] = -8.59985908506275e-002;

            __statist_i_h_wts[10, 30] = -9.47494851560596e-002;

            __statist_i_h_wts[10, 31] = -7.71671761806395e-002;

            __statist_i_h_wts[10, 32] = -1.06407530469754e-001;

            __statist_i_h_wts[10, 33] = -1.89141446330391e-001;

            __statist_i_h_wts[10, 34] = -7.00660502685236e-002;

            __statist_i_h_wts[10, 35] = -6.50014127140260e-002;

            __statist_i_h_wts[10, 36] = -5.38956693908552e-003;

            __statist_i_h_wts[10, 37] = -2.26620728021783e-001;

            __statist_i_h_wts[10, 38] = 1.18268416725113e-001;

            __statist_i_h_wts[10, 39] = 4.30367983705992e-002;

            __statist_i_h_wts[10, 40] = 1.46247297981562e-001;

            __statist_i_h_wts[10, 41] = 1.12006553975067e-001;

            __statist_i_h_wts[10, 42] = 2.32832463979268e-002;

            __statist_i_h_wts[10, 43] = -1.79110264147359e-001;

            __statist_i_h_wts[10, 44] = -9.89989649106362e-002;

            __statist_i_h_wts[10, 45] = -2.67559286047120e-002;

            __statist_i_h_wts[10, 46] = -1.42729549940528e-003;

            __statist_i_h_wts[10, 47] = 4.18651943928855e-002;

            __statist_i_h_wts[10, 48] = -1.00297553884278e-002;

            __statist_i_h_wts[10, 49] = -1.97355564758149e-002;

            __statist_i_h_wts[10, 50] = 8.90829008552615e-002;

            __statist_i_h_wts[10, 51] = 7.45136250077976e-002;

            __statist_i_h_wts[10, 52] = 1.41039086745590e-001;

            __statist_i_h_wts[10, 53] = 1.41646643995985e-001;

            __statist_i_h_wts[10, 54] = -6.62930591222527e-002;

            __statist_i_h_wts[10, 55] = -2.69638079296253e-001;

            __statist_i_h_wts[10, 56] = -7.36021952520992e-002;

            __statist_i_h_wts[10, 57] = -1.44617584491381e-001;

            __statist_i_h_wts[10, 58] = 5.46419092505245e-002;

            __statist_i_h_wts[10, 59] = -2.40787911382376e-001;

            __statist_i_h_wts[10, 60] = -2.30247257892757e-001;

            __statist_i_h_wts[10, 61] = 2.95072118658756e-001;

            __statist_i_h_wts[10, 62] = -5.83571257944965e-001;

            __statist_i_h_wts[10, 63] = -2.58639993547943e-001;

            __statist_i_h_wts[10, 64] = 6.68283396791413e-001;

            __statist_i_h_wts[10, 65] = -2.96830400209894e-001;

            __statist_i_h_wts[10, 66] = -1.37033268331975e-001;

            __statist_i_h_wts[10, 67] = 2.49412068405134e-001;

            __statist_i_h_wts[10, 68] = -2.37484002620549e-001;

            __statist_i_h_wts[10, 69] = -1.04549872772670e-001;

            __statist_i_h_wts[10, 70] = 1.42688249536559e-001;

            __statist_i_h_wts[10, 71] = -9.25455375976838e-002;

            __statist_i_h_wts[10, 72] = -4.50269097495652e-002;

            __statist_i_h_wts[10, 73] = -8.43252259815208e-002;

            __statist_i_h_wts[10, 74] = -3.25345237881160e-001;

            __statist_i_h_wts[10, 75] = 3.98396388306165e-002;

            __statist_i_h_wts[10, 76] = 1.05385450083542e-001;

            __statist_i_h_wts[10, 77] = -1.22625331911004e+000;

            __statist_i_h_wts[10, 78] = -1.48737103719402e-001;

            __statist_i_h_wts[10, 79] = 1.20515933565760e+000;

            __statist_i_h_wts[10, 80] = -2.06017112351719e-001;

            __statist_i_h_wts[10, 81] = -6.66312968153339e-002;

            __statist_i_h_wts[10, 82] = 6.24948538882877e-002;

            __statist_i_h_wts[10, 83] = -2.99783077567159e-001;

            __statist_i_h_wts[10, 84] = 6.32338001509381e-002;

            __statist_i_h_wts[10, 85] = 1.75550479676099e-002;

            __statist_i_h_wts[10, 86] = 2.50486249631046e-001;

            __statist_i_h_wts[10, 87] = -1.09912182495075e-001;

            __statist_i_h_wts[10, 88] = -3.51851220055925e-001;

            __statist_i_h_wts[10, 89] = 4.16859467319952e-001;

            __statist_i_h_wts[10, 90] = 2.42931122359856e-002;

            __statist_i_h_wts[10, 91] = -6.06838128559747e-001;

            __statist_i_h_wts[10, 92] = 4.75343587915751e-001;

            __statist_i_h_wts[10, 93] = -1.69285003645876e-001;

            __statist_i_h_wts[10, 94] = -4.91133563191310e-001;

            __statist_i_h_wts[10, 95] = 6.32583757446223e-002;

            __statist_i_h_wts[10, 96] = -8.08604573813068e-002;

            __statist_i_h_wts[10, 97] = -1.78449349269039e-001;

            __statist_i_h_wts[10, 98] = 8.25185493389820e-002;

            __statist_i_h_wts[10, 99] = -7.27037731024891e-002;

            __statist_i_h_wts[10, 100] = -2.09843274734222e-001;

            __statist_i_h_wts[10, 101] = -7.13884799026546e-003;

            __statist_i_h_wts[10, 102] = 1.30948811295455e-001;

            __statist_i_h_wts[10, 103] = -3.27214340688844e-001;

            __statist_i_h_wts[10, 104] = -7.59270053201399e-002;

            __statist_i_h_wts[10, 105] = 5.70708474140939e-001;

            __statist_i_h_wts[10, 106] = -6.73706014925352e-001;

            __statist_i_h_wts[10, 107] = 6.16502682787013e-002;

            __statist_i_h_wts[10, 108] = 1.64273026753914e-001;

            __statist_i_h_wts[10, 109] = -3.86611255072215e-001;

            __statist_i_h_wts[10, 110] = -4.33214541489644e-003;

            __statist_i_h_wts[10, 111] = 1.05552569533055e-001;

            __statist_i_h_wts[10, 112] = -2.71133936489420e-001;

            __statist_i_h_wts[10, 113] = -5.33312546221873e-003;

            __statist_i_h_wts[10, 114] = -7.62149145572742e-002;

            __statist_i_h_wts[10, 115] = -1.27183584563891e-001;

            __statist_i_h_wts[10, 116] = -8.92896359780834e-003;

            __statist_i_h_wts[10, 117] = 1.24019287637103e-001;

            __statist_i_h_wts[10, 118] = -2.93702410107030e-001;

            __statist_i_h_wts[10, 119] = 6.14355400051380e-003;

            __statist_i_h_wts[10, 120] = 3.69899620199560e-001;

            __statist_i_h_wts[10, 121] = -5.73528438891247e-001;

            __statist_i_h_wts[10, 122] = -2.62899897084784e-002;

            __statist_i_h_wts[10, 123] = 2.81031195959728e-003;

            __statist_i_h_wts[10, 124] = -1.55884486390477e-001;

            __statist_i_h_wts[10, 125] = -1.16284660071359e-001;

            __statist_i_h_wts[10, 126] = 2.20367146384516e-001;

            __statist_i_h_wts[10, 127] = -2.68364356706242e-001;



            __statist_i_h_wts[11, 0] = -1.20433074394913e-002;

            __statist_i_h_wts[11, 1] = -1.80397840653527e-002;

            __statist_i_h_wts[11, 2] = 1.03945277172857e-002;

            __statist_i_h_wts[11, 3] = -1.13239580961555e-003;

            __statist_i_h_wts[11, 4] = -1.05171313790356e-002;

            __statist_i_h_wts[11, 5] = 2.37703563524320e-002;

            __statist_i_h_wts[11, 6] = -2.99579439170928e-003;

            __statist_i_h_wts[11, 7] = 1.09565333514668e-004;

            __statist_i_h_wts[11, 8] = 2.51862591124953e-002;

            __statist_i_h_wts[11, 9] = -3.98676850597961e-004;

            __statist_i_h_wts[11, 10] = 2.35663836066135e-002;

            __statist_i_h_wts[11, 11] = 3.54425739469655e-002;

            __statist_i_h_wts[11, 12] = -1.97652672075443e-002;

            __statist_i_h_wts[11, 13] = -2.23981440490040e-003;

            __statist_i_h_wts[11, 14] = -3.55909245507615e-003;

            __statist_i_h_wts[11, 15] = 1.19315936612066e-002;

            __statist_i_h_wts[11, 16] = 1.86916748399545e-002;

            __statist_i_h_wts[11, 17] = -2.13524082650540e-002;

            __statist_i_h_wts[11, 18] = -4.45613045428866e-004;

            __statist_i_h_wts[11, 19] = 3.51011987739681e-003;

            __statist_i_h_wts[11, 20] = -1.51988163837109e-002;

            __statist_i_h_wts[11, 21] = -1.64092764640121e-002;

            __statist_i_h_wts[11, 22] = -9.84732648069364e-003;

            __statist_i_h_wts[11, 23] = -2.09415275122906e-002;

            __statist_i_h_wts[11, 24] = 7.95697242641222e-003;

            __statist_i_h_wts[11, 25] = 1.20861490857177e-002;

            __statist_i_h_wts[11, 26] = 2.03162051003651e-003;

            __statist_i_h_wts[11, 27] = -1.02901387504788e-002;

            __statist_i_h_wts[11, 28] = -6.97765374276500e-004;

            __statist_i_h_wts[11, 29] = -8.07128655507036e-003;

            __statist_i_h_wts[11, 30] = 5.63464255159890e-003;

            __statist_i_h_wts[11, 31] = -3.56967898139014e-004;

            __statist_i_h_wts[11, 32] = 4.19687043530262e-003;

            __statist_i_h_wts[11, 33] = -2.28790610115461e-003;

            __statist_i_h_wts[11, 34] = -1.78369438059035e-002;

            __statist_i_h_wts[11, 35] = -1.11608665466184e-002;

            __statist_i_h_wts[11, 36] = 7.77930952312261e-003;

            __statist_i_h_wts[11, 37] = 2.87215373305538e-003;

            __statist_i_h_wts[11, 38] = -1.36763094907128e-002;

            __statist_i_h_wts[11, 39] = -1.58430559802879e-002;

            __statist_i_h_wts[11, 40] = -7.45730007070234e-003;

            __statist_i_h_wts[11, 41] = -1.50496933002687e-002;

            __statist_i_h_wts[11, 42] = -1.00804709524084e-001;

            __statist_i_h_wts[11, 43] = 2.57336213190789e-003;

            __statist_i_h_wts[11, 44] = 1.11494057714079e-002;

            __statist_i_h_wts[11, 45] = 1.51404321851648e-002;

            __statist_i_h_wts[11, 46] = 5.57350094165223e-003;

            __statist_i_h_wts[11, 47] = 3.82708443569848e-003;

            __statist_i_h_wts[11, 48] = 3.81666017663743e-002;

            __statist_i_h_wts[11, 49] = 1.73406543234632e-002;

            __statist_i_h_wts[11, 50] = -3.49577913341353e-003;

            __statist_i_h_wts[11, 51] = 6.02830238824027e-002;

            __statist_i_h_wts[11, 52] = 5.64940618153868e-002;

            __statist_i_h_wts[11, 53] = 1.50650378510294e-002;

            __statist_i_h_wts[11, 54] = -4.01256118921551e-002;

            __statist_i_h_wts[11, 55] = 3.63889110187591e-003;

            __statist_i_h_wts[11, 56] = -1.64910718427969e-002;

            __statist_i_h_wts[11, 57] = 5.93822470385865e-003;

            __statist_i_h_wts[11, 58] = 5.99717782331205e-003;

            __statist_i_h_wts[11, 59] = 1.25080818213244e-002;

            __statist_i_h_wts[11, 60] = -4.17850625272548e-002;

            __statist_i_h_wts[11, 61] = -1.72166664521329e-002;

            __statist_i_h_wts[11, 62] = -2.14103723506743e-001;

            __statist_i_h_wts[11, 63] = 9.67331344775367e-002;

            __statist_i_h_wts[11, 64] = 9.80103332015852e-002;

            __statist_i_h_wts[11, 65] = 2.16925768873309e-002;

            __statist_i_h_wts[11, 66] = -9.30700308045050e-002;

            __statist_i_h_wts[11, 67] = 2.74996324058159e-002;

            __statist_i_h_wts[11, 68] = -8.20524046798893e-002;

            __statist_i_h_wts[11, 69] = 8.27547949000584e-002;

            __statist_i_h_wts[11, 70] = -2.80544390133079e-003;

            __statist_i_h_wts[11, 71] = -1.25196199268021e-001;

            __statist_i_h_wts[11, 72] = 9.67371092750756e-002;

            __statist_i_h_wts[11, 73] = -7.11616076327584e-003;

            __statist_i_h_wts[11, 74] = -1.23201630635589e-001;

            __statist_i_h_wts[11, 75] = 5.98230168708807e-002;

            __statist_i_h_wts[11, 76] = 3.88279436505310e-002;

            __statist_i_h_wts[11, 77] = -2.51740423043408e-001;

            __statist_i_h_wts[11, 78] = 7.94320075693449e-002;

            __statist_i_h_wts[11, 79] = 1.51043936451960e-001;

            __statist_i_h_wts[11, 80] = -3.86887088886434e-002;

            __statist_i_h_wts[11, 81] = 3.34743006904110e-002;

            __statist_i_h_wts[11, 82] = 1.04363428927954e-003;

            __statist_i_h_wts[11, 83] = -1.42258434483322e-001;

            __statist_i_h_wts[11, 84] = 1.02876675552020e-001;

            __statist_i_h_wts[11, 85] = 2.74343844724860e-002;

            __statist_i_h_wts[11, 86] = 8.74741976214596e-002;

            __statist_i_h_wts[11, 87] = -1.21977348292599e-001;

            __statist_i_h_wts[11, 88] = -8.03974089133383e-003;

            __statist_i_h_wts[11, 89] = 1.20579468140635e-001;

            __statist_i_h_wts[11, 90] = -1.34081017544654e-001;

            __statist_i_h_wts[11, 91] = 4.85789586187107e-004;

            __statist_i_h_wts[11, 92] = 9.89222292335270e-002;

            __statist_i_h_wts[11, 93] = -1.24405953865954e-001;

            __statist_i_h_wts[11, 94] = -2.44658725598395e-002;

            __statist_i_h_wts[11, 95] = 4.74315738679888e-002;

            __statist_i_h_wts[11, 96] = -7.50505632404746e-002;

            __statist_i_h_wts[11, 97] = -9.10409439391577e-003;

            __statist_i_h_wts[11, 98] = -4.60174869057357e-002;

            __statist_i_h_wts[11, 99] = 3.35603151199248e-003;

            __statist_i_h_wts[11, 100] = 1.14493513492366e-002;

            __statist_i_h_wts[11, 101] = -5.00842367307959e-002;

            __statist_i_h_wts[11, 102] = 6.89919050039786e-003;

            __statist_i_h_wts[11, 103] = 1.42250794771209e-003;

            __statist_i_h_wts[11, 104] = -2.02512666133068e-001;

            __statist_i_h_wts[11, 105] = 1.98567213677182e-001;

            __statist_i_h_wts[11, 106] = -2.31524422890592e-002;

            __statist_i_h_wts[11, 107] = -7.12011329251958e-002;

            __statist_i_h_wts[11, 108] = 3.10584454418127e-002;

            __statist_i_h_wts[11, 109] = -2.81526389920384e-003;

            __statist_i_h_wts[11, 110] = -3.64529433147811e-002;

            __statist_i_h_wts[11, 111] = 5.64911729326189e-003;

            __statist_i_h_wts[11, 112] = -5.38852341586953e-003;

            __statist_i_h_wts[11, 113] = -1.10296483938849e-002;

            __statist_i_h_wts[11, 114] = 1.26618355314953e-002;

            __statist_i_h_wts[11, 115] = -1.68829594425459e-002;

            __statist_i_h_wts[11, 116] = -2.47194879469417e-002;

            __statist_i_h_wts[11, 117] = -2.81007451112851e-002;

            __statist_i_h_wts[11, 118] = 5.72779236328229e-003;

            __statist_i_h_wts[11, 119] = -1.51038091288237e-001;

            __statist_i_h_wts[11, 120] = 1.38800136741426e-001;

            __statist_i_h_wts[11, 121] = 8.09929944925043e-003;

            __statist_i_h_wts[11, 122] = 1.43248717607598e-002;

            __statist_i_h_wts[11, 123] = -3.90437384328484e-002;

            __statist_i_h_wts[11, 124] = -1.05014179000896e-003;

            __statist_i_h_wts[11, 125] = -8.12683514820271e-003;

            __statist_i_h_wts[11, 126] = 2.72418506464665e-003;

            __statist_i_h_wts[11, 127] = -1.93004379776972e-002;



            __statist_i_h_wts[12, 0] = -2.68394935967867e-002;

            __statist_i_h_wts[12, 1] = 6.31312273783130e-002;

            __statist_i_h_wts[12, 2] = 2.87175676147365e-002;

            __statist_i_h_wts[12, 3] = 3.16230926518171e-002;

            __statist_i_h_wts[12, 4] = 4.41795236539059e-002;

            __statist_i_h_wts[12, 5] = -4.62181100425061e-002;

            __statist_i_h_wts[12, 6] = -6.21130324838258e-003;

            __statist_i_h_wts[12, 7] = -5.78671143111644e-002;

            __statist_i_h_wts[12, 8] = -6.85304456504597e-002;

            __statist_i_h_wts[12, 9] = 1.91825891695817e-002;

            __statist_i_h_wts[12, 10] = -5.24518313096242e-002;

            __statist_i_h_wts[12, 11] = -6.79683784620847e-002;

            __statist_i_h_wts[12, 12] = 5.19844294462296e-002;

            __statist_i_h_wts[12, 13] = -5.61677238994376e-002;

            __statist_i_h_wts[12, 14] = 4.19041529811417e-002;

            __statist_i_h_wts[12, 15] = 4.63608342617408e-002;

            __statist_i_h_wts[12, 16] = 2.98050569450278e-003;

            __statist_i_h_wts[12, 17] = 9.37858292102297e-002;

            __statist_i_h_wts[12, 18] = -4.75858172844053e-002;

            __statist_i_h_wts[12, 19] = -1.42265815851870e-003;

            __statist_i_h_wts[12, 20] = 3.67928544331026e-002;

            __statist_i_h_wts[12, 21] = 1.26233137357281e-002;

            __statist_i_h_wts[12, 22] = 3.60966941624174e-002;

            __statist_i_h_wts[12, 23] = 4.22263097521316e-002;

            __statist_i_h_wts[12, 24] = -1.10660701440708e-002;

            __statist_i_h_wts[12, 25] = -3.49946886154112e-002;

            __statist_i_h_wts[12, 26] = 5.00128068763647e-003;

            __statist_i_h_wts[12, 27] = 2.20768891708060e-002;

            __statist_i_h_wts[12, 28] = 2.76575945554929e-003;

            __statist_i_h_wts[12, 29] = 4.91104254298328e-002;

            __statist_i_h_wts[12, 30] = -4.15726132177418e-002;

            __statist_i_h_wts[12, 31] = -4.66522015944256e-002;

            __statist_i_h_wts[12, 32] = -2.48453469704815e-002;

            __statist_i_h_wts[12, 33] = 1.54513485876011e-002;

            __statist_i_h_wts[12, 34] = 3.00049137218786e-002;

            __statist_i_h_wts[12, 35] = 1.28273633609507e-002;

            __statist_i_h_wts[12, 36] = 3.60152655268286e-003;

            __statist_i_h_wts[12, 37] = -4.43146925516957e-002;

            __statist_i_h_wts[12, 38] = 6.22988993900154e-003;

            __statist_i_h_wts[12, 39] = 1.35107689200529e-002;

            __statist_i_h_wts[12, 40] = 3.58791044269333e-003;

            __statist_i_h_wts[12, 41] = 4.37626596219406e-002;

            __statist_i_h_wts[12, 42] = 2.52271064952473e-001;

            __statist_i_h_wts[12, 43] = 3.35880341764482e-002;

            __statist_i_h_wts[12, 44] = 1.58925568992709e-002;

            __statist_i_h_wts[12, 45] = 6.24509608980380e-003;

            __statist_i_h_wts[12, 46] = 4.29326934495882e-003;

            __statist_i_h_wts[12, 47] = 3.15681451876710e-003;

            __statist_i_h_wts[12, 48] = -7.18013168299299e-003;

            __statist_i_h_wts[12, 49] = 1.51371286899131e-002;

            __statist_i_h_wts[12, 50] = -3.23865138165857e-002;

            __statist_i_h_wts[12, 51] = -1.19796572881079e-001;

            __statist_i_h_wts[12, 52] = -2.00944198530544e-001;

            __statist_i_h_wts[12, 53] = 4.39572523105900e-003;

            __statist_i_h_wts[12, 54] = 1.69146657123096e-001;

            __statist_i_h_wts[12, 55] = 3.04107288981133e-002;

            __statist_i_h_wts[12, 56] = 3.30998253742360e-001;

            __statist_i_h_wts[12, 57] = -1.29432367284077e-001;

            __statist_i_h_wts[12, 58] = -5.71183414112532e-002;

            __statist_i_h_wts[12, 59] = 3.08618420899318e-001;

            __statist_i_h_wts[12, 60] = -8.66850984959409e-002;

            __statist_i_h_wts[12, 61] = -4.40827210339854e-002;

            __statist_i_h_wts[12, 62] = 1.16357427678033e+000;

            __statist_i_h_wts[12, 63] = -5.70020398297546e-001;

            __statist_i_h_wts[12, 64] = -4.58628388450690e-001;

            __statist_i_h_wts[12, 65] = 2.12890865832713e-002;

            __statist_i_h_wts[12, 66] = 2.95748639710242e-001;

            __statist_i_h_wts[12, 67] = -1.51395298225772e-001;

            __statist_i_h_wts[12, 68] = 4.62796725528752e-001;

            __statist_i_h_wts[12, 69] = -3.05806590152116e-001;

            __statist_i_h_wts[12, 70] = 6.30110364644615e-003;

            __statist_i_h_wts[12, 71] = 3.83599821617382e-001;

            __statist_i_h_wts[12, 72] = -1.75626278126133e-001;

            __statist_i_h_wts[12, 73] = -7.92750533727247e-002;

            __statist_i_h_wts[12, 74] = 4.27510946884072e-001;

            __statist_i_h_wts[12, 75] = -2.08686054845627e-001;

            __statist_i_h_wts[12, 76] = -7.77136816574104e-002;

            __statist_i_h_wts[12, 77] = 1.25920213458196e+000;

            __statist_i_h_wts[12, 78] = -5.92658890378499e-001;

            __statist_i_h_wts[12, 79] = -5.15328565431394e-001;

            __statist_i_h_wts[12, 80] = 8.85772870125332e-002;

            __statist_i_h_wts[12, 81] = 7.14210820084306e-002;

            __statist_i_h_wts[12, 82] = -2.24218376628306e-002;

            __statist_i_h_wts[12, 83] = 5.52061180136214e-001;

            __statist_i_h_wts[12, 84] = -3.75391347705700e-001;

            __statist_i_h_wts[12, 85] = -4.63073972193224e-002;

            __statist_i_h_wts[12, 86] = -5.83199311480013e-001;

            __statist_i_h_wts[12, 87] = 7.07001034377018e-001;

            __statist_i_h_wts[12, 88] = 6.13545560102188e-003;

            __statist_i_h_wts[12, 89] = -6.98864511622963e-001;

            __statist_i_h_wts[12, 90] = 7.34556042520798e-001;

            __statist_i_h_wts[12, 91] = 9.51274455279649e-002;

            __statist_i_h_wts[12, 92] = -7.72713572122323e-001;

            __statist_i_h_wts[12, 93] = 8.72455500581714e-001;

            __statist_i_h_wts[12, 94] = 1.96392076461396e-002;

            __statist_i_h_wts[12, 95] = -4.08436236222105e-001;

            __statist_i_h_wts[12, 96] = 5.10737685668584e-001;

            __statist_i_h_wts[12, 97] = 3.31106686331265e-002;

            __statist_i_h_wts[12, 98] = 2.10867742456906e-001;

            __statist_i_h_wts[12, 99] = -1.58723605227018e-002;

            __statist_i_h_wts[12, 100] = -5.64553532188269e-002;

            __statist_i_h_wts[12, 101] = 2.17596808493061e-001;

            __statist_i_h_wts[12, 102] = -3.24842996742522e-002;

            __statist_i_h_wts[12, 103] = -5.67439667038112e-002;

            __statist_i_h_wts[12, 104] = 9.92093355690611e-001;

            __statist_i_h_wts[12, 105] = -9.30563309604150e-001;

            __statist_i_h_wts[12, 106] = 8.15091715140219e-002;

            __statist_i_h_wts[12, 107] = 1.28421234500331e-001;

            __statist_i_h_wts[12, 108] = -1.13935372520312e-003;

            __statist_i_h_wts[12, 109] = 6.13557230152451e-003;

            __statist_i_h_wts[12, 110] = 4.22386425794037e-001;

            __statist_i_h_wts[12, 111] = -2.79952440288313e-001;

            __statist_i_h_wts[12, 112] = -1.25702808941206e-002;

            __statist_i_h_wts[12, 113] = 1.33807837891294e-001;

            __statist_i_h_wts[12, 114] = -5.59573131040488e-002;

            __statist_i_h_wts[12, 115] = 6.69871872569340e-002;

            __statist_i_h_wts[12, 116] = 1.09691844989429e-001;

            __statist_i_h_wts[12, 117] = 8.99481336005345e-002;

            __statist_i_h_wts[12, 118] = -6.35554263975448e-002;

            __statist_i_h_wts[12, 119] = 8.04252490061701e-001;

            __statist_i_h_wts[12, 120] = -7.00335451811322e-001;

            __statist_i_h_wts[12, 121] = 5.76070333335150e-003;

            __statist_i_h_wts[12, 122] = -3.98474190243545e-002;

            __statist_i_h_wts[12, 123] = 2.18418595038118e-001;

            __statist_i_h_wts[12, 124] = -2.83001630298627e-002;

            __statist_i_h_wts[12, 125] = 2.86645907004434e-001;

            __statist_i_h_wts[12, 126] = -1.76538421700679e-001;

            __statist_i_h_wts[12, 127] = 1.97285091155135e-002;



            __statist_i_h_wts[13, 0] = 3.62613971911835e-002;

            __statist_i_h_wts[13, 1] = 5.44375881677497e-002;

            __statist_i_h_wts[13, 2] = -3.16625628639839e-004;

            __statist_i_h_wts[13, 3] = -1.10979078140112e-002;

            __statist_i_h_wts[13, 4] = -1.67148383193518e-003;

            __statist_i_h_wts[13, 5] = -9.56630139707241e-003;

            __statist_i_h_wts[13, 6] = -1.07857385998717e-002;

            __statist_i_h_wts[13, 7] = -1.26611014389077e-002;

            __statist_i_h_wts[13, 8] = -2.05272962199708e-002;

            __statist_i_h_wts[13, 9] = -1.49435056368125e-002;

            __statist_i_h_wts[13, 10] = -1.31175429664927e-002;

            __statist_i_h_wts[13, 11] = -2.18791221844628e-002;

            __statist_i_h_wts[13, 12] = 4.15241518323912e-002;

            __statist_i_h_wts[13, 13] = 1.15652371653640e-003;

            __statist_i_h_wts[13, 14] = 1.64264565135088e-003;

            __statist_i_h_wts[13, 15] = 1.78994381232682e-002;

            __statist_i_h_wts[13, 16] = -7.12696379682205e-004;

            __statist_i_h_wts[13, 17] = 1.80494032105894e-003;

            __statist_i_h_wts[13, 18] = -1.83146794920663e-003;

            __statist_i_h_wts[13, 19] = 1.87560978340135e-002;

            __statist_i_h_wts[13, 20] = 3.44595773976459e-002;

            __statist_i_h_wts[13, 21] = -8.16506524614146e-003;

            __statist_i_h_wts[13, 22] = 2.50613664120996e-002;

            __statist_i_h_wts[13, 23] = -3.51728664338652e-003;

            __statist_i_h_wts[13, 24] = -1.19079157996225e-002;

            __statist_i_h_wts[13, 25] = -1.42752402601395e-002;

            __statist_i_h_wts[13, 26] = 3.68244572052387e-003;

            __statist_i_h_wts[13, 27] = 2.30641871469226e-003;

            __statist_i_h_wts[13, 28] = -1.18568134534770e-002;

            __statist_i_h_wts[13, 29] = -1.18349684558436e-002;

            __statist_i_h_wts[13, 30] = -6.72592268947736e-003;

            __statist_i_h_wts[13, 31] = -7.97868563290344e-003;

            __statist_i_h_wts[13, 32] = -1.43078780512509e-002;

            __statist_i_h_wts[13, 33] = 1.88913693609215e-002;

            __statist_i_h_wts[13, 34] = 1.32460089067492e-002;

            __statist_i_h_wts[13, 35] = 4.24706338437675e-003;

            __statist_i_h_wts[13, 36] = -3.92813374209769e-004;

            __statist_i_h_wts[13, 37] = 2.82063778985176e-002;

            __statist_i_h_wts[13, 38] = 2.45718634399776e-002;

            __statist_i_h_wts[13, 39] = 5.16455564773982e-003;

            __statist_i_h_wts[13, 40] = -4.23066595006857e-003;

            __statist_i_h_wts[13, 41] = 1.23475567704620e-003;

            __statist_i_h_wts[13, 42] = 1.39930941818110e-001;

            __statist_i_h_wts[13, 43] = 2.84302017152212e-002;

            __statist_i_h_wts[13, 44] = 1.37676751040357e-002;

            __statist_i_h_wts[13, 45] = 9.22005281736128e-003;

            __statist_i_h_wts[13, 46] = 5.43822157244682e-004;

            __statist_i_h_wts[13, 47] = 3.20113629194113e-003;

            __statist_i_h_wts[13, 48] = -4.06143279832610e-002;

            __statist_i_h_wts[13, 49] = -1.89545714437532e-002;

            __statist_i_h_wts[13, 50] = -2.35202172062294e-002;

            __statist_i_h_wts[13, 51] = -7.91511201344526e-002;

            __statist_i_h_wts[13, 52] = -7.67140297294275e-002;

            __statist_i_h_wts[13, 53] = -2.72012560632085e-002;

            __statist_i_h_wts[13, 54] = 8.45106719571728e-002;

            __statist_i_h_wts[13, 55] = 4.71991128786235e-002;

            __statist_i_h_wts[13, 56] = 3.98310553651149e-002;

            __statist_i_h_wts[13, 57] = 2.19140158746639e-002;

            __statist_i_h_wts[13, 58] = -1.49094725787006e-002;

            __statist_i_h_wts[13, 59] = -2.26747002708393e-002;

            __statist_i_h_wts[13, 60] = 8.31387601179756e-002;

            __statist_i_h_wts[13, 61] = -1.25067990215244e-002;

            __statist_i_h_wts[13, 62] = 3.70723014178055e-001;

            __statist_i_h_wts[13, 63] = -9.20661318907679e-002;

            __statist_i_h_wts[13, 64] = -2.04435345619946e-001;

            __statist_i_h_wts[13, 65] = -2.25335794815073e-002;

            __statist_i_h_wts[13, 66] = 1.57750180007360e-001;

            __statist_i_h_wts[13, 67] = -7.68608942082285e-002;

            __statist_i_h_wts[13, 68] = 1.39877300626083e-001;

            __statist_i_h_wts[13, 69] = -7.72269149441488e-002;

            __statist_i_h_wts[13, 70] = 2.92201724873505e-003;

            __statist_i_h_wts[13, 71] = 1.47392652244197e-001;

            __statist_i_h_wts[13, 72] = -7.90733053523989e-002;

            __statist_i_h_wts[13, 73] = -1.11387866616050e-002;

            __statist_i_h_wts[13, 74] = 1.65628732389384e-001;

            __statist_i_h_wts[13, 75] = -6.48391127553530e-002;

            __statist_i_h_wts[13, 76] = -4.49276544152800e-002;

            __statist_i_h_wts[13, 77] = 4.47151547635945e-001;

            __statist_i_h_wts[13, 78] = -5.64739768620732e-002;

            __statist_i_h_wts[13, 79] = -3.34082670558237e-001;

            __statist_i_h_wts[13, 80] = 6.27351551532404e-002;

            __statist_i_h_wts[13, 81] = 3.77722903065812e-002;

            __statist_i_h_wts[13, 82] = -2.13628601111601e-002;

            __statist_i_h_wts[13, 83] = 1.93959495321989e-001;

            __statist_i_h_wts[13, 84] = -1.01285179676619e-001;

            __statist_i_h_wts[13, 85] = 6.49831557411749e-003;

            __statist_i_h_wts[13, 86] = -1.17782085504668e-001;

            __statist_i_h_wts[13, 87] = 1.49232225745678e-001;

            __statist_i_h_wts[13, 88] = 1.99485303259664e-002;

            __statist_i_h_wts[13, 89] = -1.19818726254289e-001;

            __statist_i_h_wts[13, 90] = 1.50735754905886e-001;

            __statist_i_h_wts[13, 91] = 4.59745073371143e-002;

            __statist_i_h_wts[13, 92] = -1.30354991445520e-001;

            __statist_i_h_wts[13, 93] = 1.42917577914451e-001;

            __statist_i_h_wts[13, 94] = 5.47527018450850e-002;

            __statist_i_h_wts[13, 95] = -3.61187649654719e-002;

            __statist_i_h_wts[13, 96] = 8.23902230728877e-002;

            __statist_i_h_wts[13, 97] = 1.15657547378328e-002;

            __statist_i_h_wts[13, 98] = 4.66725714678377e-002;

            __statist_i_h_wts[13, 99] = -5.07738177502763e-003;

            __statist_i_h_wts[13, 100] = 2.24334313710312e-003;

            __statist_i_h_wts[13, 101] = 4.97972402924590e-002;

            __statist_i_h_wts[13, 102] = 1.25442098183904e-002;

            __statist_i_h_wts[13, 103] = 1.02109138735064e-003;

            __statist_i_h_wts[13, 104] = 2.39735853834754e-001;

            __statist_i_h_wts[13, 105] = -2.70840493732246e-001;

            __statist_i_h_wts[13, 106] = 9.55903363132035e-002;

            __statist_i_h_wts[13, 107] = 1.01731789693771e-001;

            __statist_i_h_wts[13, 108] = -4.25289392464937e-002;

            __statist_i_h_wts[13, 109] = 1.31568201707946e-002;

            __statist_i_h_wts[13, 110] = 3.57359179697170e-002;

            __statist_i_h_wts[13, 111] = 1.81586706075871e-002;

            __statist_i_h_wts[13, 112] = 8.25824372191605e-003;

            __statist_i_h_wts[13, 113] = 3.58427304028600e-002;

            __statist_i_h_wts[13, 114] = 2.83945510302308e-002;

            __statist_i_h_wts[13, 115] = 1.02876649924123e-002;

            __statist_i_h_wts[13, 116] = 3.27129923240791e-003;

            __statist_i_h_wts[13, 117] = 6.28161916626509e-002;

            __statist_i_h_wts[13, 118] = -2.29602537885428e-003;

            __statist_i_h_wts[13, 119] = 1.68280312571568e-001;

            __statist_i_h_wts[13, 120] = -1.46258665326162e-001;

            __statist_i_h_wts[13, 121] = 4.93118220240985e-002;

            __statist_i_h_wts[13, 122] = -1.22081190280579e-002;

            __statist_i_h_wts[13, 123] = 5.69744004569326e-002;

            __statist_i_h_wts[13, 124] = 9.01250865620786e-004;

            __statist_i_h_wts[13, 125] = 9.63470513425630e-003;

            __statist_i_h_wts[13, 126] = 1.86483164134339e-002;

            __statist_i_h_wts[13, 127] = 2.31369147324735e-002;



            __statist_i_h_wts[14, 0] = -6.37247988802084e-002;

            __statist_i_h_wts[14, 1] = -6.91614206759778e-002;

            __statist_i_h_wts[14, 2] = -2.35726345349873e-002;

            __statist_i_h_wts[14, 3] = 8.45236955623839e-002;

            __statist_i_h_wts[14, 4] = 2.25806712323411e-002;

            __statist_i_h_wts[14, 5] = -6.17757959573931e-002;

            __statist_i_h_wts[14, 6] = -2.87921204892960e-002;

            __statist_i_h_wts[14, 7] = 3.99158796579851e-002;

            __statist_i_h_wts[14, 8] = -3.97524206141603e-002;

            __statist_i_h_wts[14, 9] = 9.69900613381658e-002;

            __statist_i_h_wts[14, 10] = -6.44056559512339e-002;

            __statist_i_h_wts[14, 11] = -1.29508240037278e-003;

            __statist_i_h_wts[14, 12] = -4.77191697997407e-002;

            __statist_i_h_wts[14, 13] = -1.00808826520202e-002;

            __statist_i_h_wts[14, 14] = -5.20698605183291e-002;

            __statist_i_h_wts[14, 15] = -5.57981263197680e-003;

            __statist_i_h_wts[14, 16] = 3.29854845747731e-002;

            __statist_i_h_wts[14, 17] = 8.38705177048292e-002;

            __statist_i_h_wts[14, 18] = 1.91716946978355e-002;

            __statist_i_h_wts[14, 19] = -5.31433514401160e-002;

            __statist_i_h_wts[14, 20] = -3.97983725448297e-002;

            __statist_i_h_wts[14, 21] = 4.82359085172418e-002;

            __statist_i_h_wts[14, 22] = 3.81617025952720e-002;

            __statist_i_h_wts[14, 23] = 1.56417554546150e-001;

            __statist_i_h_wts[14, 24] = -1.89619237873385e-002;

            __statist_i_h_wts[14, 25] = -4.42972710348462e-002;

            __statist_i_h_wts[14, 26] = 1.74186638662870e-002;

            __statist_i_h_wts[14, 27] = 3.77475651009259e-002;

            __statist_i_h_wts[14, 28] = 1.79591452238775e-002;

            __statist_i_h_wts[14, 29] = -3.18392022096488e-002;

            __statist_i_h_wts[14, 30] = -1.45648255532173e-002;

            __statist_i_h_wts[14, 31] = -6.42376363298488e-002;

            __statist_i_h_wts[14, 32] = -4.18420490004336e-002;

            __statist_i_h_wts[14, 33] = -9.18885309698219e-002;

            __statist_i_h_wts[14, 34] = -1.91402972609469e-002;

            __statist_i_h_wts[14, 35] = -4.38226432921661e-002;

            __statist_i_h_wts[14, 36] = -9.48714047981022e-003;

            __statist_i_h_wts[14, 37] = -1.54649367115850e-001;

            __statist_i_h_wts[14, 38] = 6.07363392160915e-002;

            __statist_i_h_wts[14, 39] = 2.41807962031324e-002;

            __statist_i_h_wts[14, 40] = 8.19994855576312e-002;

            __statist_i_h_wts[14, 41] = 4.17262350978883e-002;

            __statist_i_h_wts[14, 42] = -1.36536152239114e-001;

            __statist_i_h_wts[14, 43] = -7.47182374895310e-002;

            __statist_i_h_wts[14, 44] = -6.30018193800726e-002;

            __statist_i_h_wts[14, 45] = -4.76721080839084e-003;

            __statist_i_h_wts[14, 46] = -3.92165137688554e-003;

            __statist_i_h_wts[14, 47] = 1.48023576677383e-002;

            __statist_i_h_wts[14, 48] = 3.30851505203989e-002;

            __statist_i_h_wts[14, 49] = -9.12786346355906e-003;

            __statist_i_h_wts[14, 50] = 3.48643484221315e-002;

            __statist_i_h_wts[14, 51] = 9.30121599220246e-002;

            __statist_i_h_wts[14, 52] = 1.21360396045474e-001;

            __statist_i_h_wts[14, 53] = 1.04270305943215e-001;

            __statist_i_h_wts[14, 54] = -1.19680623223379e-001;

            __statist_i_h_wts[14, 55] = -1.79908697721354e-001;

            __statist_i_h_wts[14, 56] = -1.05377165022582e-001;

            __statist_i_h_wts[14, 57] = -6.45869143375249e-002;

            __statist_i_h_wts[14, 58] = 4.12281962046540e-002;

            __statist_i_h_wts[14, 59] = -1.08474353769258e-001;

            __statist_i_h_wts[14, 60] = -1.50817265473381e-001;

            __statist_i_h_wts[14, 61] = 1.44647952273351e-001;

            __statist_i_h_wts[14, 62] = -6.39423546276697e-001;

            __statist_i_h_wts[14, 63] = 1.29602232009526e-002;

            __statist_i_h_wts[14, 64] = 4.80706723811393e-001;

            __statist_i_h_wts[14, 65] = -9.54132039121863e-002;

            __statist_i_h_wts[14, 66] = -2.04354797476213e-001;

            __statist_i_h_wts[14, 67] = 1.67136748865565e-001;

            __statist_i_h_wts[14, 68] = -1.89111266458933e-001;

            __statist_i_h_wts[14, 69] = 2.95277318474321e-003;

            __statist_i_h_wts[14, 70] = 6.85414988224222e-002;

            __statist_i_h_wts[14, 71] = -1.84766500012907e-001;

            __statist_i_h_wts[14, 72] = 1.11671187360095e-001;

            __statist_i_h_wts[14, 73] = -2.86721293241141e-002;

            __statist_i_h_wts[14, 74] = -2.67556717355595e-001;

            __statist_i_h_wts[14, 75] = 3.16880643799214e-002;

            __statist_i_h_wts[14, 76] = 9.24363670804705e-002;

            __statist_i_h_wts[14, 77] = -1.00384758937301e+000;

            __statist_i_h_wts[14, 78] = 3.49264677526820e-002;

            __statist_i_h_wts[14, 79] = 8.65519929353104e-001;

            __statist_i_h_wts[14, 80] = -7.47508762717173e-002;

            __statist_i_h_wts[14, 81] = -9.00301875689615e-002;

            __statist_i_h_wts[14, 82] = 4.69167316771060e-002;

            __statist_i_h_wts[14, 83] = -2.36363359027011e-001;

            __statist_i_h_wts[14, 84] = 8.86872578180796e-002;

            __statist_i_h_wts[14, 85] = -3.99260834427504e-003;

            __statist_i_h_wts[14, 86] = 2.17440717926320e-001;

            __statist_i_h_wts[14, 87] = -1.25993021431944e-001;

            __statist_i_h_wts[14, 88] = -1.94806748892902e-001;

            __statist_i_h_wts[14, 89] = 3.17869786764278e-001;

            __statist_i_h_wts[14, 90] = -6.13133761111178e-002;

            __statist_i_h_wts[14, 91] = -3.43962561080822e-001;

            __statist_i_h_wts[14, 92] = 3.58077155657140e-001;

            __statist_i_h_wts[14, 93] = -1.91131982847650e-001;

            __statist_i_h_wts[14, 94] = -2.90372749653449e-001;

            __statist_i_h_wts[14, 95] = 5.83896859774818e-002;

            __statist_i_h_wts[14, 96] = -7.70528110217736e-002;

            __statist_i_h_wts[14, 97] = -9.27227920814014e-002;

            __statist_i_h_wts[14, 98] = 3.87563784706524e-003;

            __statist_i_h_wts[14, 99] = -1.37695464003763e-002;

            __statist_i_h_wts[14, 100] = -1.17550488199278e-001;

            __statist_i_h_wts[14, 101] = 2.86212844736441e-003;

            __statist_i_h_wts[14, 102] = 4.29829792658182e-002;

            __statist_i_h_wts[14, 103] = -1.57531488202069e-001;

            __statist_i_h_wts[14, 104] = -1.42672958374340e-001;

            __statist_i_h_wts[14, 105] = 4.26143065739651e-001;

            __statist_i_h_wts[14, 106] = -4.13500393176226e-001;

            __statist_i_h_wts[14, 107] = 1.47396181664664e-003;

            __statist_i_h_wts[14, 108] = 9.18632868184645e-002;

            __statist_i_h_wts[14, 109] = -2.09296128858843e-001;

            __statist_i_h_wts[14, 110] = 2.13270558001304e-002;

            __statist_i_h_wts[14, 111] = -1.01572775567018e-002;

            __statist_i_h_wts[14, 112] = -1.56923388098974e-001;

            __statist_i_h_wts[14, 113] = 1.92412495464041e-002;

            __statist_i_h_wts[14, 114] = -7.41956233153419e-002;

            __statist_i_h_wts[14, 115] = -7.02753985254144e-002;

            __statist_i_h_wts[14, 116] = 5.64180947537196e-002;

            __statist_i_h_wts[14, 117] = -2.25805962003066e-002;

            __statist_i_h_wts[14, 118] = -1.47565938441931e-001;

            __statist_i_h_wts[14, 119] = -1.88126884745867e-002;

            __statist_i_h_wts[14, 120] = 2.29818039646824e-001;

            __statist_i_h_wts[14, 121] = -3.16656249898605e-001;

            __statist_i_h_wts[14, 122] = 7.76602168865331e-002;

            __statist_i_h_wts[14, 123] = -1.06605241536032e-001;

            __statist_i_h_wts[14, 124] = -8.43929515061330e-002;

            __statist_i_h_wts[14, 125] = 1.23626324483860e-002;

            __statist_i_h_wts[14, 126] = 2.62986298825895e-002;

            __statist_i_h_wts[14, 127] = -1.74223257795091e-001;



            __statist_i_h_wts[15, 0] = 4.28626637993709e-002;

            __statist_i_h_wts[15, 1] = 4.21370485426565e-002;

            __statist_i_h_wts[15, 2] = 5.78318279469213e-003;

            __statist_i_h_wts[15, 3] = -4.38378756575447e-002;

            __statist_i_h_wts[15, 4] = -6.35348702820084e-003;

            __statist_i_h_wts[15, 5] = 2.99151055348135e-002;

            __statist_i_h_wts[15, 6] = 4.59300365262624e-003;

            __statist_i_h_wts[15, 7] = -2.30848006289639e-002;

            __statist_i_h_wts[15, 8] = 8.46699668623270e-003;

            __statist_i_h_wts[15, 9] = -4.49413054857297e-002;

            __statist_i_h_wts[15, 10] = -4.99599318266095e-004;

            __statist_i_h_wts[15, 11] = -3.57755421249126e-003;

            __statist_i_h_wts[15, 12] = 5.29067418833494e-002;

            __statist_i_h_wts[15, 13] = -5.98830357262260e-004;

            __statist_i_h_wts[15, 14] = 2.64473929350874e-002;

            __statist_i_h_wts[15, 15] = -7.62825141406380e-003;

            __statist_i_h_wts[15, 16] = -1.17454845831081e-002;

            __statist_i_h_wts[15, 17] = -4.83974059953866e-003;

            __statist_i_h_wts[15, 18] = -1.01033996032541e-002;

            __statist_i_h_wts[15, 19] = 1.22298901045208e-002;

            __statist_i_h_wts[15, 20] = 1.74715114251272e-002;

            __statist_i_h_wts[15, 21] = -2.46162294141083e-002;

            __statist_i_h_wts[15, 22] = 1.25892355920026e-002;

            __statist_i_h_wts[15, 23] = -4.11295604126855e-002;

            __statist_i_h_wts[15, 24] = -1.78041883171337e-002;

            __statist_i_h_wts[15, 25] = -2.09748250597287e-003;

            __statist_i_h_wts[15, 26] = 1.62848073871382e-004;

            __statist_i_h_wts[15, 27] = -1.35343471081807e-002;

            __statist_i_h_wts[15, 28] = 8.51211341324048e-003;

            __statist_i_h_wts[15, 29] = 1.00900975930130e-002;

            __statist_i_h_wts[15, 30] = -1.94942141497924e-003;

            __statist_i_h_wts[15, 31] = 2.23899697814126e-002;

            __statist_i_h_wts[15, 32] = 3.66058926138615e-003;

            __statist_i_h_wts[15, 33] = 1.68669097878484e-002;

            __statist_i_h_wts[15, 34] = 2.60476466207415e-002;

            __statist_i_h_wts[15, 35] = 5.07838693306378e-003;

            __statist_i_h_wts[15, 36] = 1.12842807370544e-003;

            __statist_i_h_wts[15, 37] = 6.92440073499693e-002;

            __statist_i_h_wts[15, 38] = -9.06356344276388e-003;

            __statist_i_h_wts[15, 39] = 7.80032725300882e-003;

            __statist_i_h_wts[15, 40] = -2.70867968018548e-002;

            __statist_i_h_wts[15, 41] = -1.51201109405779e-002;

            __statist_i_h_wts[15, 42] = 1.58885153368047e-001;

            __statist_i_h_wts[15, 43] = 3.06954631672081e-002;

            __statist_i_h_wts[15, 44] = 3.82081933967071e-002;

            __statist_i_h_wts[15, 45] = 5.61519382970924e-003;

            __statist_i_h_wts[15, 46] = -6.95748412140847e-004;

            __statist_i_h_wts[15, 47] = 8.40918485775016e-003;

            __statist_i_h_wts[15, 48] = -4.89563551028360e-002;

            __statist_i_h_wts[15, 49] = -1.24747210202999e-002;

            __statist_i_h_wts[15, 50] = -4.92995934156138e-003;

            __statist_i_h_wts[15, 51] = -9.64498495537506e-002;

            __statist_i_h_wts[15, 52] = -1.05069146529295e-001;

            __statist_i_h_wts[15, 53] = -4.02850803009607e-002;

            __statist_i_h_wts[15, 54] = 1.07541335251164e-001;

            __statist_i_h_wts[15, 55] = 1.02062919589928e-001;

            __statist_i_h_wts[15, 56] = 1.33227212547229e-001;

            __statist_i_h_wts[15, 57] = 2.10933383513540e-002;

            __statist_i_h_wts[15, 58] = -2.83500482275494e-002;

            __statist_i_h_wts[15, 59] = 8.87961386236713e-002;

            __statist_i_h_wts[15, 60] = 1.26277021423232e-001;

            __statist_i_h_wts[15, 61] = -8.32868758035544e-002;

            __statist_i_h_wts[15, 62] = 5.96088994019952e-001;

            __statist_i_h_wts[15, 63] = -1.35743106517070e-001;

            __statist_i_h_wts[15, 64] = -3.20728863188383e-001;

            __statist_i_h_wts[15, 65] = 4.10627477829028e-002;

            __statist_i_h_wts[15, 66] = 2.09485870619983e-001;

            __statist_i_h_wts[15, 67] = -1.17798839653708e-001;

            __statist_i_h_wts[15, 68] = 2.45985325283947e-001;

            __statist_i_h_wts[15, 69] = -6.21960398522584e-002;

            __statist_i_h_wts[15, 70] = -1.16079077902977e-002;

            __statist_i_h_wts[15, 71] = 2.48562565518382e-001;

            __statist_i_h_wts[15, 72] = -1.07652716580652e-001;

            __statist_i_h_wts[15, 73] = 1.33657377244150e-003;

            __statist_i_h_wts[15, 74] = 2.85254234485675e-001;

            __statist_i_h_wts[15, 75] = -9.51252321421111e-002;

            __statist_i_h_wts[15, 76] = -6.48914674412612e-002;

            __statist_i_h_wts[15, 77] = 7.77705099290465e-001;

            __statist_i_h_wts[15, 78] = -9.88583290660419e-002;

            __statist_i_h_wts[15, 79] = -5.48186925060110e-001;

            __statist_i_h_wts[15, 80] = 1.37503591267601e-001;

            __statist_i_h_wts[15, 81] = 6.17180523976359e-002;

            __statist_i_h_wts[15, 82] = -3.20040030650681e-002;

            __statist_i_h_wts[15, 83] = 3.04352912814384e-001;

            __statist_i_h_wts[15, 84] = -1.40179915162824e-001;

            __statist_i_h_wts[15, 85] = -1.53945097785854e-002;

            __statist_i_h_wts[15, 86] = -1.86921859007285e-001;

            __statist_i_h_wts[15, 87] = 2.56907567375479e-001;

            __statist_i_h_wts[15, 88] = 9.84715677362885e-002;

            __statist_i_h_wts[15, 89] = -2.72153061734813e-001;

            __statist_i_h_wts[15, 90] = 2.82022631212621e-001;

            __statist_i_h_wts[15, 91] = 1.53091236971917e-001;

            __statist_i_h_wts[15, 92] = -2.81998169239524e-001;

            __statist_i_h_wts[15, 93] = 3.08315225986040e-001;

            __statist_i_h_wts[15, 94] = 1.14331894008767e-001;

            __statist_i_h_wts[15, 95] = -1.01525699613669e-001;

            __statist_i_h_wts[15, 96] = 2.15954743306059e-001;

            __statist_i_h_wts[15, 97] = 4.22990316359905e-002;

            __statist_i_h_wts[15, 98] = 1.28403341981675e-001;

            __statist_i_h_wts[15, 99] = -8.20961577835419e-003;

            __statist_i_h_wts[15, 100] = 4.22905055090855e-003;

            __statist_i_h_wts[15, 101] = 9.95462720627789e-002;

            __statist_i_h_wts[15, 102] = -1.92736443030493e-002;

            __statist_i_h_wts[15, 103] = 5.36934314578237e-002;

            __statist_i_h_wts[15, 104] = 3.76996103868337e-001;

            __statist_i_h_wts[15, 105] = -4.27579401413927e-001;

            __statist_i_h_wts[15, 106] = 2.10153679725384e-001;

            __statist_i_h_wts[15, 107] = 1.36431214530780e-001;

            __statist_i_h_wts[15, 108] = -5.57963173839031e-002;

            __statist_i_h_wts[15, 109] = 8.49069514898283e-002;

            __statist_i_h_wts[15, 110] = 8.09239257629425e-002;

            __statist_i_h_wts[15, 111] = -8.32467509935711e-004;

            __statist_i_h_wts[15, 112] = 5.81190683266290e-002;

            __statist_i_h_wts[15, 113] = 6.33245262327534e-002;

            __statist_i_h_wts[15, 114] = 1.60545878682191e-002;

            __statist_i_h_wts[15, 115] = 2.68234416755606e-002;

            __statist_i_h_wts[15, 116] = 3.95555305283283e-002;

            __statist_i_h_wts[15, 117] = 4.36687251740153e-002;

            __statist_i_h_wts[15, 118] = 3.80273161451257e-002;

            __statist_i_h_wts[15, 119] = 2.62539465524951e-001;

            __statist_i_h_wts[15, 120] = -2.67893527149946e-001;

            __statist_i_h_wts[15, 121] = 1.23712361658530e-001;

            __statist_i_h_wts[15, 122] = -1.56723938564155e-002;

            __statist_i_h_wts[15, 123] = 1.22668475293954e-001;

            __statist_i_h_wts[15, 124] = 2.93069801029151e-002;

            __statist_i_h_wts[15, 125] = 5.97679584971726e-002;

            __statist_i_h_wts[15, 126] = 2.14786342386140e-002;

            __statist_i_h_wts[15, 127] = 6.72676212712317e-002;



            __statist_i_h_wts[16, 0] = 2.60800599421233e-002;

            __statist_i_h_wts[16, 1] = 5.07951474966602e-002;

            __statist_i_h_wts[16, 2] = 2.23819592783711e-002;

            __statist_i_h_wts[16, 3] = -3.08165513183372e-002;

            __statist_i_h_wts[16, 4] = -1.50520402336869e-004;

            __statist_i_h_wts[16, 5] = 7.51302752686314e-003;

            __statist_i_h_wts[16, 6] = 1.41823315076612e-003;

            __statist_i_h_wts[16, 7] = -3.65826502712893e-002;

            __statist_i_h_wts[16, 8] = 1.76032233026594e-002;

            __statist_i_h_wts[16, 9] = -3.27128495304187e-002;

            __statist_i_h_wts[16, 10] = 1.77116636390838e-002;

            __statist_i_h_wts[16, 11] = -8.87796328422207e-003;

            __statist_i_h_wts[16, 12] = 4.85867301240680e-002;

            __statist_i_h_wts[16, 13] = 7.71900466871122e-003;

            __statist_i_h_wts[16, 14] = 1.84769242995442e-002;

            __statist_i_h_wts[16, 15] = -7.48341964861955e-003;

            __statist_i_h_wts[16, 16] = -2.14827128071398e-002;

            __statist_i_h_wts[16, 17] = 4.49884051603928e-003;

            __statist_i_h_wts[16, 18] = -2.31021520507720e-002;

            __statist_i_h_wts[16, 19] = 2.57691869657745e-002;

            __statist_i_h_wts[16, 20] = 1.75144640001375e-002;

            __statist_i_h_wts[16, 21] = -1.20605540756176e-002;

            __statist_i_h_wts[16, 22] = 1.84322013850236e-002;

            __statist_i_h_wts[16, 23] = -6.17946647843239e-002;

            __statist_i_h_wts[16, 24] = -6.06857961278177e-003;

            __statist_i_h_wts[16, 25] = 1.32883265190228e-003;

            __statist_i_h_wts[16, 26] = 1.04056148027170e-002;

            __statist_i_h_wts[16, 27] = -3.96353189703206e-002;

            __statist_i_h_wts[16, 28] = -1.56773853272813e-003;

            __statist_i_h_wts[16, 29] = 4.11488857198864e-004;

            __statist_i_h_wts[16, 30] = 1.39959247148046e-002;

            __statist_i_h_wts[16, 31] = -6.18364275377097e-003;

            __statist_i_h_wts[16, 32] = -1.24128504257556e-002;

            __statist_i_h_wts[16, 33] = 3.75767046519416e-002;

            __statist_i_h_wts[16, 34] = 2.70657966252781e-002;

            __statist_i_h_wts[16, 35] = 1.46507974149226e-002;

            __statist_i_h_wts[16, 36] = -9.53932434469186e-003;

            __statist_i_h_wts[16, 37] = 6.32284447258644e-002;

            __statist_i_h_wts[16, 38] = 3.65770889550740e-004;

            __statist_i_h_wts[16, 39] = 1.81209791110160e-003;

            __statist_i_h_wts[16, 40] = -1.91671970033905e-002;

            __statist_i_h_wts[16, 41] = -3.26466570358347e-003;

            __statist_i_h_wts[16, 42] = 1.77442656399762e-001;

            __statist_i_h_wts[16, 43] = 5.56740229369079e-002;

            __statist_i_h_wts[16, 44] = 1.96320795045398e-002;

            __statist_i_h_wts[16, 45] = 1.30374325095050e-002;

            __statist_i_h_wts[16, 46] = -3.04283915871774e-003;

            __statist_i_h_wts[16, 47] = -4.24051597405306e-003;

            __statist_i_h_wts[16, 48] = -2.17431121017257e-002;

            __statist_i_h_wts[16, 49] = -2.84574975748735e-002;

            __statist_i_h_wts[16, 50] = 1.02163701876024e-002;

            __statist_i_h_wts[16, 51] = -8.33588772015222e-002;

            __statist_i_h_wts[16, 52] = -1.06903715607874e-001;

            __statist_i_h_wts[16, 53] = -5.56648966615236e-002;

            __statist_i_h_wts[16, 54] = 1.09220215429093e-001;

            __statist_i_h_wts[16, 55] = 1.08773583526066e-001;

            __statist_i_h_wts[16, 56] = 1.73057784969208e-001;

            __statist_i_h_wts[16, 57] = 7.64163336054845e-003;

            __statist_i_h_wts[16, 58] = -2.11073307935654e-002;

            __statist_i_h_wts[16, 59] = 1.26973970848521e-001;

            __statist_i_h_wts[16, 60] = 1.05739292944193e-001;

            __statist_i_h_wts[16, 61] = -8.00357450216259e-002;

            __statist_i_h_wts[16, 62] = 7.40595185541820e-001;

            __statist_i_h_wts[16, 63] = -2.31161384806564e-001;

            __statist_i_h_wts[16, 64] = -3.72478774361193e-001;

            __statist_i_h_wts[16, 65] = 7.03827577267561e-002;

            __statist_i_h_wts[16, 66] = 1.87888753945700e-001;

            __statist_i_h_wts[16, 67] = -1.15110681134467e-001;

            __statist_i_h_wts[16, 68] = 2.98240611729707e-001;

            __statist_i_h_wts[16, 69] = -1.11573227023317e-001;

            __statist_i_h_wts[16, 70] = -3.93235465813511e-002;

            __statist_i_h_wts[16, 71] = 3.14894378083630e-001;

            __statist_i_h_wts[16, 72] = -1.65053598147172e-001;

            __statist_i_h_wts[16, 73] = 1.35898433467958e-002;

            __statist_i_h_wts[16, 74] = 3.59378087027973e-001;

            __statist_i_h_wts[16, 75] = -1.23675226931912e-001;

            __statist_i_h_wts[16, 76] = -1.01833783318682e-001;

            __statist_i_h_wts[16, 77] = 9.75414152711405e-001;

            __statist_i_h_wts[16, 78] = -2.47980102373369e-001;

            __statist_i_h_wts[16, 79] = -6.07428985519360e-001;

            __statist_i_h_wts[16, 80] = 1.91595029800070e-001;

            __statist_i_h_wts[16, 81] = 5.19002127363018e-003;

            __statist_i_h_wts[16, 82] = -5.40080666310902e-002;

            __statist_i_h_wts[16, 83] = 3.94844621709348e-001;

            __statist_i_h_wts[16, 84] = -2.21337197983262e-001;

            __statist_i_h_wts[16, 85] = -1.75176608438420e-002;

            __statist_i_h_wts[16, 86] = -2.95418212294062e-001;

            __statist_i_h_wts[16, 87] = 3.54430322769384e-001;

            __statist_i_h_wts[16, 88] = 9.56929418760165e-002;

            __statist_i_h_wts[16, 89] = -4.21062944214477e-001;

            __statist_i_h_wts[16, 90] = 4.07036052885017e-001;

            __statist_i_h_wts[16, 91] = 1.72024537844443e-001;

            __statist_i_h_wts[16, 92] = -4.62708154274011e-001;

            __statist_i_h_wts[16, 93] = 4.71230879647375e-001;

            __statist_i_h_wts[16, 94] = 1.44767177204612e-001;

            __statist_i_h_wts[16, 95] = -2.18701258538261e-001;

            __statist_i_h_wts[16, 96] = 3.00019111139313e-001;

            __statist_i_h_wts[16, 97] = 4.92066471039446e-002;

            __statist_i_h_wts[16, 98] = 1.48776035391976e-001;

            __statist_i_h_wts[16, 99] = -1.65998235554696e-002;

            __statist_i_h_wts[16, 100] = 3.28885811654147e-002;

            __statist_i_h_wts[16, 101] = 1.45308830334862e-001;

            __statist_i_h_wts[16, 102] = -4.37593483262302e-002;

            __statist_i_h_wts[16, 103] = 6.45564602589683e-002;

            __statist_i_h_wts[16, 104] = 5.21402271760805e-001;

            __statist_i_h_wts[16, 105] = -6.06022419056031e-001;

            __statist_i_h_wts[16, 106] = 2.00804845265321e-001;

            __statist_i_h_wts[16, 107] = 1.31089449621017e-001;

            __statist_i_h_wts[16, 108] = -7.49979504544564e-002;

            __statist_i_h_wts[16, 109] = 8.73229231848115e-002;

            __statist_i_h_wts[16, 110] = 1.43098262469666e-001;

            __statist_i_h_wts[16, 111] = -6.15061172758175e-002;

            __statist_i_h_wts[16, 112] = 5.76180270507430e-002;

            __statist_i_h_wts[16, 113] = 9.86868310750662e-002;

            __statist_i_h_wts[16, 114] = 1.43882741753899e-002;

            __statist_i_h_wts[16, 115] = 3.20391521328189e-002;

            __statist_i_h_wts[16, 116] = 6.43018975214590e-002;

            __statist_i_h_wts[16, 117] = 3.76614228476969e-002;

            __statist_i_h_wts[16, 118] = 4.57312815020957e-002;

            __statist_i_h_wts[16, 119] = 4.23340759861813e-001;

            __statist_i_h_wts[16, 120] = -4.18116792712130e-001;

            __statist_i_h_wts[16, 121] = 1.51665891205311e-001;

            __statist_i_h_wts[16, 122] = 1.23385402089360e-002;

            __statist_i_h_wts[16, 123] = 1.30726241304550e-001;

            __statist_i_h_wts[16, 124] = 2.79784834296693e-002;

            __statist_i_h_wts[16, 125] = 1.20889799586867e-001;

            __statist_i_h_wts[16, 126] = -5.11917889232581e-002;

            __statist_i_h_wts[16, 127] = 7.41135819907465e-002;



            __statist_i_h_wts[17, 0] = -1.23702559578391e-001;

            __statist_i_h_wts[17, 1] = -1.57057045234232e-001;

            __statist_i_h_wts[17, 2] = 4.99087813275396e-002;

            __statist_i_h_wts[17, 3] = 1.21547882540370e-001;

            __statist_i_h_wts[17, 4] = 5.55824824459282e-002;

            __statist_i_h_wts[17, 5] = 1.78750318490392e-002;

            __statist_i_h_wts[17, 6] = -1.55427227619887e-002;

            __statist_i_h_wts[17, 7] = 7.63735079106644e-002;

            __statist_i_h_wts[17, 8] = -3.66887845856974e-002;

            __statist_i_h_wts[17, 9] = 1.08773971522319e-001;

            __statist_i_h_wts[17, 10] = 6.66919937052480e-002;

            __statist_i_h_wts[17, 11] = 4.79918272403266e-002;

            __statist_i_h_wts[17, 12] = -8.04489494610740e-002;

            __statist_i_h_wts[17, 13] = -5.91550817099453e-002;

            __statist_i_h_wts[17, 14] = -4.16199505508848e-002;

            __statist_i_h_wts[17, 15] = -5.81938527285004e-002;

            __statist_i_h_wts[17, 16] = 2.26406835676421e-002;

            __statist_i_h_wts[17, 17] = 2.41191571843985e-002;

            __statist_i_h_wts[17, 18] = 5.96809539396721e-002;

            __statist_i_h_wts[17, 19] = -8.36340263072343e-002;

            __statist_i_h_wts[17, 20] = -1.07556863835895e-001;

            __statist_i_h_wts[17, 21] = 7.34526490190840e-002;

            __statist_i_h_wts[17, 22] = 4.44779436327342e-002;

            __statist_i_h_wts[17, 23] = 2.49485709331770e-001;

            __statist_i_h_wts[17, 24] = -3.37815659718169e-003;

            __statist_i_h_wts[17, 25] = -5.63564718184894e-002;

            __statist_i_h_wts[17, 26] = 7.71035246331403e-002;

            __statist_i_h_wts[17, 27] = 6.26921733189985e-002;

            __statist_i_h_wts[17, 28] = 1.11503091632743e-002;

            __statist_i_h_wts[17, 29] = -8.79331528411525e-003;

            __statist_i_h_wts[17, 30] = 2.38143479123863e-002;

            __statist_i_h_wts[17, 31] = -5.56032864019348e-002;

            __statist_i_h_wts[17, 32] = -1.02771354756793e-002;

            __statist_i_h_wts[17, 33] = -8.38935458573987e-002;

            __statist_i_h_wts[17, 34] = -9.70942365825692e-002;

            __statist_i_h_wts[17, 35] = -3.79409911626579e-002;

            __statist_i_h_wts[17, 36] = -8.82779244682389e-003;

            __statist_i_h_wts[17, 37] = -1.99550133220062e-001;

            __statist_i_h_wts[17, 38] = 5.41370050547668e-002;

            __statist_i_h_wts[17, 39] = 3.44004354927973e-002;

            __statist_i_h_wts[17, 40] = 1.81313944724085e-001;

            __statist_i_h_wts[17, 41] = 5.71492708316351e-002;

            __statist_i_h_wts[17, 42] = -3.69061742881923e-001;

            __statist_i_h_wts[17, 43] = -5.59645331769558e-002;

            __statist_i_h_wts[17, 44] = -1.05557981819694e-001;

            __statist_i_h_wts[17, 45] = -3.24231938146124e-002;

            __statist_i_h_wts[17, 46] = -2.69274633651350e-002;

            __statist_i_h_wts[17, 47] = 1.04638165684824e-002;

            __statist_i_h_wts[17, 48] = 1.95036291285067e-001;

            __statist_i_h_wts[17, 49] = 8.49783379781099e-002;

            __statist_i_h_wts[17, 50] = 2.22991986629398e-001;

            __statist_i_h_wts[17, 51] = 1.98221659201195e-001;

            __statist_i_h_wts[17, 52] = 3.48929770825531e-001;

            __statist_i_h_wts[17, 53] = 2.29478478775442e-001;

            __statist_i_h_wts[17, 54] = -3.09802624177697e-001;

            __statist_i_h_wts[17, 55] = -2.89136953035913e-001;

            __statist_i_h_wts[17, 56] = -1.42894036982419e-001;

            __statist_i_h_wts[17, 57] = 2.50149484159564e-001;

            __statist_i_h_wts[17, 58] = 7.94611378865916e-002;

            __statist_i_h_wts[17, 59] = 1.24078542527500e-001;

            __statist_i_h_wts[17, 60] = -1.87689030369381e-001;

            __statist_i_h_wts[17, 61] = 2.36110126416888e-001;

            __statist_i_h_wts[17, 62] = -2.21395852092721e+000;

            __statist_i_h_wts[17, 63] = 1.27104618332663e+000;

            __statist_i_h_wts[17, 64] = 1.11401438192439e+000;

            __statist_i_h_wts[17, 65] = 3.42804783798333e-001;

            __statist_i_h_wts[17, 66] = -5.93745454760260e-001;

            __statist_i_h_wts[17, 67] = 4.08366773299628e-001;

            __statist_i_h_wts[17, 68] = -4.43657794641701e-001;

            __statist_i_h_wts[17, 69] = 5.69216512868168e-001;

            __statist_i_h_wts[17, 70] = 3.26466812913970e-002;

            __statist_i_h_wts[17, 71] = -4.38043822753390e-001;

            __statist_i_h_wts[17, 72] = 6.67006510557607e-001;

            __statist_i_h_wts[17, 73] = -2.95295833764338e-002;

            __statist_i_h_wts[17, 74] = -5.36526470106300e-001;

            __statist_i_h_wts[17, 75] = 5.54564631822159e-001;

            __statist_i_h_wts[17, 76] = 1.44383694222566e-001;

            __statist_i_h_wts[17, 77] = -2.97798334357139e+000;

            __statist_i_h_wts[17, 78] = 1.32853698619682e+000;

            __statist_i_h_wts[17, 79] = 1.79346466536100e+000;

            __statist_i_h_wts[17, 80] = 1.47216422581388e-001;

            __statist_i_h_wts[17, 81] = -3.71093035613819e-002;

            __statist_i_h_wts[17, 82] = 6.83282585876572e-002;

            __statist_i_h_wts[17, 83] = -5.92188557497219e-001;

            __statist_i_h_wts[17, 84] = 7.28559890341944e-001;

            __statist_i_h_wts[17, 85] = 1.25381345462088e-002;

            __statist_i_h_wts[17, 86] = 1.05737200676696e+000;

            __statist_i_h_wts[17, 87] = -5.62056644314174e-001;

            __statist_i_h_wts[17, 88] = -3.40612374611231e-001;

            __statist_i_h_wts[17, 89] = 1.40936752152031e+000;

            __statist_i_h_wts[17, 90] = -5.82055642126548e-001;

            __statist_i_h_wts[17, 91] = -6.73488101527863e-001;

            __statist_i_h_wts[17, 92] = 1.51818832966906e+000;

            __statist_i_h_wts[17, 93] = -8.06303610084762e-001;

            __statist_i_h_wts[17, 94] = -5.48428781357697e-001;

            __statist_i_h_wts[17, 95] = 6.91645975323337e-001;

            __statist_i_h_wts[17, 96] = -3.60357336644826e-001;

            __statist_i_h_wts[17, 97] = -1.55516978818112e-001;

            __statist_i_h_wts[17, 98] = 3.47054113459764e-002;

            __statist_i_h_wts[17, 99] = 2.25076005875546e-001;

            __statist_i_h_wts[17, 100] = -8.89123035793812e-002;

            __statist_i_h_wts[17, 101] = 2.68762560580722e-001;

            __statist_i_h_wts[17, 102] = 9.47335817810881e-002;

            __statist_i_h_wts[17, 103] = -1.85580411127933e-001;

            __statist_i_h_wts[17, 104] = -8.97480595464989e-001;

            __statist_i_h_wts[17, 105] = 1.71859617843148e+000;

            __statist_i_h_wts[17, 106] = -6.41557728259622e-001;

            __statist_i_h_wts[17, 107] = 2.71197974605015e-001;

            __statist_i_h_wts[17, 108] = 1.85207318990782e-001;

            __statist_i_h_wts[17, 109] = -2.88273418165970e-001;

            __statist_i_h_wts[17, 110] = 1.49439337752102e-001;

            __statist_i_h_wts[17, 111] = 2.03754586560631e-001;

            __statist_i_h_wts[17, 112] = -2.01723788319818e-001;

            __statist_i_h_wts[17, 113] = 1.93328009832778e-001;

            __statist_i_h_wts[17, 114] = 9.24541802223239e-002;

            __statist_i_h_wts[17, 115] = -9.85328047534719e-002;

            __statist_i_h_wts[17, 116] = 3.85492735222498e-001;

            __statist_i_h_wts[17, 117] = 3.08373639428321e-002;

            __statist_i_h_wts[17, 118] = -2.64240486715795e-001;

            __statist_i_h_wts[17, 119] = -6.87157149826558e-001;

            __statist_i_h_wts[17, 120] = 1.32651591180630e+000;

            __statist_i_h_wts[17, 121] = -4.55184133948206e-001;

            __statist_i_h_wts[17, 122] = 5.75564359058807e-001;

            __statist_i_h_wts[17, 123] = -3.48112821241576e-001;

            __statist_i_h_wts[17, 124] = -1.94639337417326e-002;

            __statist_i_h_wts[17, 125] = 1.88923121613697e-001;

            __statist_i_h_wts[17, 126] = 2.29550023611958e-001;

            __statist_i_h_wts[17, 127] = -2.57043752177710e-001;



            __statist_i_h_wts[18, 0] = -2.43788899431393e-003;

            __statist_i_h_wts[18, 1] = 8.55851687030297e-003;

            __statist_i_h_wts[18, 2] = 5.21258705571995e-003;

            __statist_i_h_wts[18, 3] = -1.73437377291865e-002;

            __statist_i_h_wts[18, 4] = -3.90951096563455e-003;

            __statist_i_h_wts[18, 5] = -9.32528672173430e-003;

            __statist_i_h_wts[18, 6] = 1.33180183788423e-002;

            __statist_i_h_wts[18, 7] = -1.11973980072187e-002;

            __statist_i_h_wts[18, 8] = -3.34292185870394e-004;

            __statist_i_h_wts[18, 9] = -4.97999885753498e-003;

            __statist_i_h_wts[18, 10] = -5.72012512169538e-004;

            __statist_i_h_wts[18, 11] = -7.24278141700610e-003;

            __statist_i_h_wts[18, 12] = -2.88111324808075e-003;

            __statist_i_h_wts[18, 13] = -4.77530022487770e-003;

            __statist_i_h_wts[18, 14] = 5.37056168476156e-003;

            __statist_i_h_wts[18, 15] = 9.05895307333064e-003;

            __statist_i_h_wts[18, 16] = 6.48360928628540e-005;

            __statist_i_h_wts[18, 17] = -5.19907202690518e-003;

            __statist_i_h_wts[18, 18] = 4.78088236996988e-003;

            __statist_i_h_wts[18, 19] = 6.32241340932466e-003;

            __statist_i_h_wts[18, 20] = 7.21056069891542e-003;

            __statist_i_h_wts[18, 21] = -7.21167458205449e-003;

            __statist_i_h_wts[18, 22] = -9.25829670638707e-003;

            __statist_i_h_wts[18, 23] = -2.10782065604831e-003;

            __statist_i_h_wts[18, 24] = -1.21721560173330e-003;

            __statist_i_h_wts[18, 25] = -8.05473330628510e-003;

            __statist_i_h_wts[18, 26] = -9.54281979784307e-003;

            __statist_i_h_wts[18, 27] = 1.67653852469675e-002;

            __statist_i_h_wts[18, 28] = -1.34192106701421e-002;

            __statist_i_h_wts[18, 29] = -1.15413694139201e-002;

            __statist_i_h_wts[18, 30] = -2.65656355027318e-004;

            __statist_i_h_wts[18, 31] = 5.92880396180340e-003;

            __statist_i_h_wts[18, 32] = -5.09907288886179e-003;

            __statist_i_h_wts[18, 33] = -1.42182657617126e-002;

            __statist_i_h_wts[18, 34] = -8.48894883341817e-003;

            __statist_i_h_wts[18, 35] = 9.17815997626379e-003;

            __statist_i_h_wts[18, 36] = -1.80256339998821e-003;

            __statist_i_h_wts[18, 37] = -1.20043197533679e-002;

            __statist_i_h_wts[18, 38] = 1.01662141845971e-002;

            __statist_i_h_wts[18, 39] = 7.50409876749077e-003;

            __statist_i_h_wts[18, 40] = -2.09739875798537e-003;

            __statist_i_h_wts[18, 41] = -1.80758089261469e-002;

            __statist_i_h_wts[18, 42] = -2.21416493341408e-002;

            __statist_i_h_wts[18, 43] = -1.36573206998336e-002;

            __statist_i_h_wts[18, 44] = -3.12662500641968e-003;

            __statist_i_h_wts[18, 45] = -5.29906796905455e-003;

            __statist_i_h_wts[18, 46] = -2.15289236885240e-002;

            __statist_i_h_wts[18, 47] = -7.56899844910995e-003;

            __statist_i_h_wts[18, 48] = -1.27998116908252e-002;

            __statist_i_h_wts[18, 49] = 1.39991352974325e-005;

            __statist_i_h_wts[18, 50] = 1.05531808220235e-003;

            __statist_i_h_wts[18, 51] = -1.55674941860972e-003;

            __statist_i_h_wts[18, 52] = 9.24906814505478e-004;

            __statist_i_h_wts[18, 53] = -2.54481176045082e-003;

            __statist_i_h_wts[18, 54] = -1.37952192449110e-002;

            __statist_i_h_wts[18, 55] = -4.15939680245867e-003;

            __statist_i_h_wts[18, 56] = -6.80560329329216e-002;

            __statist_i_h_wts[18, 57] = 2.11579476844757e-002;

            __statist_i_h_wts[18, 58] = -1.38470759793744e-003;

            __statist_i_h_wts[18, 59] = -7.31268759623923e-002;

            __statist_i_h_wts[18, 60] = 2.10199270223028e-002;

            __statist_i_h_wts[18, 61] = -6.40060679245104e-003;

            __statist_i_h_wts[18, 62] = -1.98620722950169e-001;

            __statist_i_h_wts[18, 63] = 1.44322262691895e-001;

            __statist_i_h_wts[18, 64] = 1.70156004293746e-002;

            __statist_i_h_wts[18, 65] = -5.58130089680065e-002;

            __statist_i_h_wts[18, 66] = 1.13035366979321e-003;

            __statist_i_h_wts[18, 67] = -1.76491843611670e-002;

            __statist_i_h_wts[18, 68] = -8.97468062132913e-002;

            __statist_i_h_wts[18, 69] = 5.29098547441209e-002;

            __statist_i_h_wts[18, 70] = 1.26022322293342e-002;

            __statist_i_h_wts[18, 71] = -1.07860367697972e-001;

            __statist_i_h_wts[18, 72] = 5.12009609312585e-002;

            __statist_i_h_wts[18, 73] = -1.47502623027705e-003;

            __statist_i_h_wts[18, 74] = -8.20294372294916e-002;

            __statist_i_h_wts[18, 75] = 4.55150684140321e-002;

            __statist_i_h_wts[18, 76] = 3.65961596378073e-003;

            __statist_i_h_wts[18, 77] = -2.26696023011546e-001;

            __statist_i_h_wts[18, 78] = 1.65924167992203e-001;

            __statist_i_h_wts[18, 79] = 1.98116624999678e-002;

            __statist_i_h_wts[18, 80] = -7.97634337109379e-002;

            __statist_i_h_wts[18, 81] = 5.21548048340495e-002;

            __statist_i_h_wts[18, 82] = 3.43721901294721e-003;

            __statist_i_h_wts[18, 83] = -1.29617028210513e-001;

            __statist_i_h_wts[18, 84] = 7.41379166247597e-002;

            __statist_i_h_wts[18, 85] = -7.13239256992999e-003;

            __statist_i_h_wts[18, 86] = 1.18035950967988e-001;

            __statist_i_h_wts[18, 87] = -1.58641611280274e-001;

            __statist_i_h_wts[18, 88] = -1.48323565845762e-002;

            __statist_i_h_wts[18, 89] = 1.53422831866709e-001;

            __statist_i_h_wts[18, 90] = -1.88978653036159e-001;

            __statist_i_h_wts[18, 91] = -2.58356953707096e-002;

            __statist_i_h_wts[18, 92] = 1.82425558782295e-001;

            __statist_i_h_wts[18, 93] = -2.11263517595390e-001;

            __statist_i_h_wts[18, 94] = -1.31714591099475e-003;

            __statist_i_h_wts[18, 95] = 1.37267595677706e-001;

            __statist_i_h_wts[18, 96] = -1.40872718740858e-001;

            __statist_i_h_wts[18, 97] = -2.36741045664815e-002;

            __statist_i_h_wts[18, 98] = -5.87264904861347e-002;

            __statist_i_h_wts[18, 99] = 1.28037743120786e-002;

            __statist_i_h_wts[18, 100] = 2.20340627020563e-002;

            __statist_i_h_wts[18, 101] = -5.37933619506546e-002;

            __statist_i_h_wts[18, 102] = 1.55781910356594e-002;

            __statist_i_h_wts[18, 103] = 5.92347842571030e-003;

            __statist_i_h_wts[18, 104] = -2.08849379695924e-001;

            __statist_i_h_wts[18, 105] = 1.69144641402641e-001;

            __statist_i_h_wts[18, 106] = 7.29810971210854e-003;

            __statist_i_h_wts[18, 107] = -4.87974344417552e-002;

            __statist_i_h_wts[18, 108] = 6.20365673445813e-003;

            __statist_i_h_wts[18, 109] = -1.36580245267282e-002;

            __statist_i_h_wts[18, 110] = -8.51405792401263e-002;

            __statist_i_h_wts[18, 111] = 4.64797865216492e-002;

            __statist_i_h_wts[18, 112] = -6.54149024490860e-004;

            __statist_i_h_wts[18, 113] = -6.33874577764269e-002;

            __statist_i_h_wts[18, 114] = 1.56928491983142e-002;

            __statist_i_h_wts[18, 115] = 2.19886679486143e-003;

            __statist_i_h_wts[18, 116] = -4.51386715012797e-002;

            __statist_i_h_wts[18, 117] = 7.49621389466333e-003;

            __statist_i_h_wts[18, 118] = -5.49624014666843e-003;

            __statist_i_h_wts[18, 119] = -1.87069889854700e-001;

            __statist_i_h_wts[18, 120] = 1.45276066819434e-001;

            __statist_i_h_wts[18, 121] = 1.93811907936731e-002;

            __statist_i_h_wts[18, 122] = -3.74439375548332e-002;

            __statist_i_h_wts[18, 123] = -1.31732616454846e-002;

            __statist_i_h_wts[18, 124] = 4.05281983680769e-003;

            __statist_i_h_wts[18, 125] = -7.13636418888685e-002;

            __statist_i_h_wts[18, 126] = 2.30302491649541e-002;

            __statist_i_h_wts[18, 127] = -1.80218524034307e-002;



            __statist_i_h_wts[19, 0] = -1.01142477695882e-001;

            __statist_i_h_wts[19, 1] = -9.01074017660029e-002;

            __statist_i_h_wts[19, 2] = -3.88172235055781e-002;

            __statist_i_h_wts[19, 3] = 1.17134014599335e-001;

            __statist_i_h_wts[19, 4] = 6.18877645709114e-002;

            __statist_i_h_wts[19, 5] = -5.29474514758525e-002;

            __statist_i_h_wts[19, 6] = -1.62132420717073e-002;

            __statist_i_h_wts[19, 7] = 6.17884049642319e-002;

            __statist_i_h_wts[19, 8] = -5.29298896483217e-002;

            __statist_i_h_wts[19, 9] = 1.21103616985183e-001;

            __statist_i_h_wts[19, 10] = -7.12716348572842e-002;

            __statist_i_h_wts[19, 11] = -2.22324987888178e-002;

            __statist_i_h_wts[19, 12] = -8.71306408709401e-002;

            __statist_i_h_wts[19, 13] = -5.93659635992365e-003;

            __statist_i_h_wts[19, 14] = -5.36846312550293e-002;

            __statist_i_h_wts[19, 15] = 4.82419225591210e-002;

            __statist_i_h_wts[19, 16] = 6.28920780494946e-002;

            __statist_i_h_wts[19, 17] = 1.48992992563918e-001;

            __statist_i_h_wts[19, 18] = 3.48865242358053e-002;

            __statist_i_h_wts[19, 19] = -1.04211783164369e-001;

            __statist_i_h_wts[19, 20] = -6.70278023653158e-002;

            __statist_i_h_wts[19, 21] = 5.14285115241998e-002;

            __statist_i_h_wts[19, 22] = 5.70303598211597e-002;

            __statist_i_h_wts[19, 23] = 2.15626604242699e-001;

            __statist_i_h_wts[19, 24] = -1.87457827043876e-002;

            __statist_i_h_wts[19, 25] = -4.28491902320816e-002;

            __statist_i_h_wts[19, 26] = -1.43887986658665e-004;

            __statist_i_h_wts[19, 27] = 5.07020458798796e-002;

            __statist_i_h_wts[19, 28] = 9.92939042740859e-004;

            __statist_i_h_wts[19, 29] = -3.44326155646273e-002;

            __statist_i_h_wts[19, 30] = -3.95543859319883e-002;

            __statist_i_h_wts[19, 31] = -4.20676496019002e-002;

            __statist_i_h_wts[19, 32] = -5.40399935068806e-002;

            __statist_i_h_wts[19, 33] = -6.96949041051050e-002;

            __statist_i_h_wts[19, 34] = -6.49034003319676e-002;

            __statist_i_h_wts[19, 35] = -4.68319576792808e-002;

            __statist_i_h_wts[19, 36] = 6.52873352962248e-003;

            __statist_i_h_wts[19, 37] = -2.20252926039622e-001;

            __statist_i_h_wts[19, 38] = 3.81038801131308e-002;

            __statist_i_h_wts[19, 39] = 1.56594018943495e-002;

            __statist_i_h_wts[19, 40] = 9.61471601307800e-002;

            __statist_i_h_wts[19, 41] = 4.73457342418469e-002;

            __statist_i_h_wts[19, 42] = -2.33814409258505e-001;

            __statist_i_h_wts[19, 43] = -1.14582811897376e-001;

            __statist_i_h_wts[19, 44] = -8.01918557268384e-002;

            __statist_i_h_wts[19, 45] = -1.18970256692365e-002;

            __statist_i_h_wts[19, 46] = 1.34494391622340e-002;

            __statist_i_h_wts[19, 47] = 1.10941809547022e-002;

            __statist_i_h_wts[19, 48] = 1.06491387716546e-001;

            __statist_i_h_wts[19, 49] = 3.23917533418662e-002;

            __statist_i_h_wts[19, 50] = 6.29024029375298e-002;

            __statist_i_h_wts[19, 51] = 1.44734431937118e-001;

            __statist_i_h_wts[19, 52] = 1.92241276932003e-001;

            __statist_i_h_wts[19, 53] = 7.07192002948737e-002;

            __statist_i_h_wts[19, 54] = -1.49273220902999e-001;

            __statist_i_h_wts[19, 55] = -2.27206784100366e-001;

            __statist_i_h_wts[19, 56] = -1.59201630695914e-001;

            __statist_i_h_wts[19, 57] = -1.13845912875458e-001;

            __statist_i_h_wts[19, 58] = 5.51950818341703e-002;

            __statist_i_h_wts[19, 59] = -1.34464540470838e-001;

            __statist_i_h_wts[19, 60] = -2.68404740062335e-001;

            __statist_i_h_wts[19, 61] = 1.79458561828844e-001;

            __statist_i_h_wts[19, 62] = -1.12981267696551e+000;

            __statist_i_h_wts[19, 63] = 2.01230000331547e-001;

            __statist_i_h_wts[19, 64] = 6.85463919295448e-001;

            __statist_i_h_wts[19, 65] = -2.41689623640503e-001;

            __statist_i_h_wts[19, 66] = -2.05090388441832e-001;

            __statist_i_h_wts[19, 67] = 2.31144625442795e-001;

            __statist_i_h_wts[19, 68] = -4.14692466563720e-001;

            __statist_i_h_wts[19, 69] = 1.17503799908969e-001;

            __statist_i_h_wts[19, 70] = 7.19672294876941e-002;

            __statist_i_h_wts[19, 71] = -4.83228754493727e-001;

            __statist_i_h_wts[19, 72] = 3.31391416470630e-001;

            __statist_i_h_wts[19, 73] = -4.07624848869332e-002;

            __statist_i_h_wts[19, 74] = -6.40584298214549e-001;

            __statist_i_h_wts[19, 75] = 2.29694563888890e-001;

            __statist_i_h_wts[19, 76] = 1.84075512486805e-001;

            __statist_i_h_wts[19, 77] = -1.69784764126187e+000;

            __statist_i_h_wts[19, 78] = 2.38943903349480e-001;

            __statist_i_h_wts[19, 79] = 1.24991059150367e+000;

            __statist_i_h_wts[19, 80] = -3.42549959492074e-001;

            __statist_i_h_wts[19, 81] = 2.15396890155873e-002;

            __statist_i_h_wts[19, 82] = 1.00245852294764e-001;

            __statist_i_h_wts[19, 83] = -6.05142626355132e-001;

            __statist_i_h_wts[19, 84] = 3.74341350913668e-001;

            __statist_i_h_wts[19, 85] = 7.09065084790348e-004;

            __statist_i_h_wts[19, 86] = 4.60928790366760e-001;

            __statist_i_h_wts[19, 87] = -3.90705473900742e-001;

            __statist_i_h_wts[19, 88] = -2.65399944636048e-001;

            __statist_i_h_wts[19, 89] = 6.42966921716104e-001;

            __statist_i_h_wts[19, 90] = -4.29838905400596e-001;

            __statist_i_h_wts[19, 91] = -4.32949709452387e-001;

            __statist_i_h_wts[19, 92] = 7.64722968990004e-001;

            __statist_i_h_wts[19, 93] = -6.04929157816347e-001;

            __statist_i_h_wts[19, 94] = -3.77069021319551e-001;

            __statist_i_h_wts[19, 95] = 3.20224863159267e-001;

            __statist_i_h_wts[19, 96] = -3.92113361343302e-001;

            __statist_i_h_wts[19, 97] = -1.26814927152480e-001;

            __statist_i_h_wts[19, 98] = -2.06405453172373e-001;

            __statist_i_h_wts[19, 99] = 8.35999872355150e-002;

            __statist_i_h_wts[19, 100] = -1.29504292815870e-001;

            __statist_i_h_wts[19, 101] = -2.10770226057278e-001;

            __statist_i_h_wts[19, 102] = 2.13083806621990e-001;

            __statist_i_h_wts[19, 103] = -2.04156502580950e-001;

            __statist_i_h_wts[19, 104] = -6.93632753995025e-001;

            __statist_i_h_wts[19, 105] = 1.01271482057913e+000;

            __statist_i_h_wts[19, 106] = -5.72020271407951e-001;

            __statist_i_h_wts[19, 107] = -2.31710862195997e-001;

            __statist_i_h_wts[19, 108] = 2.57533697536488e-001;

            __statist_i_h_wts[19, 109] = -2.57086772735570e-001;

            __statist_i_h_wts[19, 110] = -1.25540521661538e-001;

            __statist_i_h_wts[19, 111] = 7.24778419604536e-002;

            __statist_i_h_wts[19, 112] = -1.92578650359774e-001;

            __statist_i_h_wts[19, 113] = -1.37125487145685e-001;

            __statist_i_h_wts[19, 114] = -2.28699085130622e-002;

            __statist_i_h_wts[19, 115] = -5.62157303608874e-002;

            __statist_i_h_wts[19, 116] = -7.35431965483980e-002;

            __statist_i_h_wts[19, 117] = 4.88033068165441e-002;

            __statist_i_h_wts[19, 118] = -1.83346566409702e-001;

            __statist_i_h_wts[19, 119] = -4.89653143692238e-001;

            __statist_i_h_wts[19, 120] = 6.72800344772266e-001;

            __statist_i_h_wts[19, 121] = -4.17089310721987e-001;

            __statist_i_h_wts[19, 122] = -3.39775753873020e-002;

            __statist_i_h_wts[19, 123] = -1.00855772721841e-001;

            __statist_i_h_wts[19, 124] = -1.09419551496277e-001;

            __statist_i_h_wts[19, 125] = -1.15963669569451e-001;

            __statist_i_h_wts[19, 126] = 1.11592040183731e-001;

            __statist_i_h_wts[19, 127] = -1.95023469291452e-001;



            double[,] __statist_h_o_wts = new double[2, 20];



            __statist_h_o_wts[0, 0] = 2.83348012031131e-001;

            __statist_h_o_wts[0, 1] = -6.53015181164395e-001;

            __statist_h_o_wts[0, 2] = 5.96234038743141e-001;

            __statist_h_o_wts[0, 3] = 1.28434007243443e-001;

            __statist_h_o_wts[0, 4] = 1.29961427244025e-001;

            __statist_h_o_wts[0, 5] = -7.20178674252831e-001;

            __statist_h_o_wts[0, 6] = -5.73386812269377e-001;

            __statist_h_o_wts[0, 7] = -2.48226778538629e-001;

            __statist_h_o_wts[0, 8] = -3.75941005398113e-001;

            __statist_h_o_wts[0, 9] = 5.85503013540930e-002;

            __statist_h_o_wts[0, 10] = -5.72569368917114e-001;

            __statist_h_o_wts[0, 11] = 2.33002208506733e-002;

            __statist_h_o_wts[0, 12] = -7.39051288384488e-001;

            __statist_h_o_wts[0, 13] = -3.58616183643775e-002;

            __statist_h_o_wts[0, 14] = -1.46704387335892e-001;

            __statist_h_o_wts[0, 15] = -1.32124381124946e-002;

            __statist_h_o_wts[0, 16] = -3.64019113790704e-002;

            __statist_h_o_wts[0, 17] = -9.06883338305965e-001;

            __statist_h_o_wts[0, 18] = -1.16397991610142e-001;

            __statist_h_o_wts[0, 19] = -2.39480760242710e-001;



            __statist_h_o_wts[1, 0] = -2.68189259032805e-001;

            __statist_h_o_wts[1, 1] = 6.47618093860962e-001;

            __statist_h_o_wts[1, 2] = -6.17068206475349e-001;

            __statist_h_o_wts[1, 3] = -1.03426622737205e-001;

            __statist_h_o_wts[1, 4] = -1.29520764898545e-001;

            __statist_h_o_wts[1, 5] = 8.08527719996682e-001;

            __statist_h_o_wts[1, 6] = 5.73609348994794e-001;

            __statist_h_o_wts[1, 7] = 2.03133603472865e-001;

            __statist_h_o_wts[1, 8] = 3.43928335910801e-001;

            __statist_h_o_wts[1, 9] = -7.11391850135806e-002;

            __statist_h_o_wts[1, 10] = 5.58798158656027e-001;

            __statist_h_o_wts[1, 11] = -5.61950168851966e-002;

            __statist_h_o_wts[1, 12] = 7.47229617230274e-001;

            __statist_h_o_wts[1, 13] = 3.84187914094787e-002;

            __statist_h_o_wts[1, 14] = 1.35004461485770e-001;

            __statist_h_o_wts[1, 15] = -1.72034487834064e-002;

            __statist_h_o_wts[1, 16] = 6.35543239304604e-002;

            __statist_h_o_wts[1, 17] = 9.21922716141711e-001;

            __statist_h_o_wts[1, 18] = 1.20246077082489e-001;

            __statist_h_o_wts[1, 19] = 2.29403836790012e-001;



            double[] __statist_hidden_bias = new double[20];

            __statist_hidden_bias[0] = -1.08530395511824e-001;

            __statist_hidden_bias[1] = -2.20889273080511e-001;

            __statist_hidden_bias[2] = 1.91710798495189e-001;

            __statist_hidden_bias[3] = 6.76234870420726e-002;

            __statist_hidden_bias[4] = 4.29835127877267e-002;

            __statist_hidden_bias[5] = -1.51660039257726e-001;

            __statist_hidden_bias[6] = -8.90367767022593e-002;

            __statist_hidden_bias[7] = 2.52931211533208e-002;

            __statist_hidden_bias[8] = -8.05400871093605e-002;

            __statist_hidden_bias[9] = 6.52487142142332e-003;

            __statist_hidden_bias[10] = -1.97817638348857e-001;

            __statist_hidden_bias[11] = -2.22009961829177e-002;

            __statist_hidden_bias[12] = 1.47834286038105e-001;

            __statist_hidden_bias[13] = 5.67654125612474e-002;

            __statist_hidden_bias[14] = -1.27476171636631e-001;

            __statist_hidden_bias[15] = 1.57476323836244e-001;

            __statist_hidden_bias[16] = 1.51223303841515e-001;

            __statist_hidden_bias[17] = 1.62229135069266e-001;

            __statist_hidden_bias[18] = -4.75553133550824e-002;

            __statist_hidden_bias[19] = -2.15733647565485e-001;



            double[] __statist_output_bias = new double[2];

            __statist_output_bias[0] = 8.69856783162258e-001;

            __statist_output_bias[1] = -8.09517543838846e-001;



            double[] __statist_inputs = new double[128];



            double[] __statist_hidden = new double[20];



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

            int __statist_nhidden = 20;



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

                        __statist_hidden[__statist_row] = -1.0;

                    }

                    else
                    {

                        __statist_hidden[__statist_row] = Math.Tanh(__statist_hidden[__statist_row]);

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

            return MLP_128_20_2(CatInputs);
        }
    }
}
