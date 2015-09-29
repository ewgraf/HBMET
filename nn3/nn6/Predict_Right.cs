using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nn6
{
    class Predict_Right
    {
        /**C# deployment code of Neural Networks Model**/

        /**==========================================================================
        Before running the C# deployment code please read the following.

         STATISTICA variable names will be exported as-is into the C# deployment script;
        please verify the resulting script to ensure that the variable names follow the C#
        naming conventions and modify the names if necessary.

        ==========================================================================**/

        public static string[] MLP_128_9_2(string[] CatInputs)
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

            __statist_DCats[1] = "2";



            double __statist_ConfLevel = 3.0E-300;







            double[,] __statist_i_h_wts = new double[9, 128];



            __statist_i_h_wts[0, 0] = 3.16380716914245e-002;

            __statist_i_h_wts[0, 1] = 1.05442512833321e-002;

            __statist_i_h_wts[0, 2] = 2.49802339065923e-002;

            __statist_i_h_wts[0, 3] = 8.46758104835306e-002;

            __statist_i_h_wts[0, 4] = 3.59076402187793e-002;

            __statist_i_h_wts[0, 5] = 3.26846646334088e-002;

            __statist_i_h_wts[0, 6] = -7.23764743913518e-002;

            __statist_i_h_wts[0, 7] = 3.79932102985263e-002;

            __statist_i_h_wts[0, 8] = -4.95051328580262e-002;

            __statist_i_h_wts[0, 9] = 4.27126396522327e-002;

            __statist_i_h_wts[0, 10] = -4.38083841334777e-003;

            __statist_i_h_wts[0, 11] = 1.78808376654940e-002;

            __statist_i_h_wts[0, 12] = -6.39051438497303e-002;

            __statist_i_h_wts[0, 13] = 4.37080774153347e-002;

            __statist_i_h_wts[0, 14] = 2.65762776778258e-002;

            __statist_i_h_wts[0, 15] = -2.88557463055720e-002;

            __statist_i_h_wts[0, 16] = -3.75038276754743e-002;

            __statist_i_h_wts[0, 17] = -5.13766294258746e-003;

            __statist_i_h_wts[0, 18] = 6.98202900050158e-002;

            __statist_i_h_wts[0, 19] = 9.34876698351496e-002;

            __statist_i_h_wts[0, 20] = 1.39519710820817e-002;

            __statist_i_h_wts[0, 21] = 4.76280019867444e-002;

            __statist_i_h_wts[0, 22] = 3.85192347827601e-003;

            __statist_i_h_wts[0, 23] = 3.63492920218360e-002;

            __statist_i_h_wts[0, 24] = -7.43998794864812e-002;

            __statist_i_h_wts[0, 25] = -5.70873228055000e-002;

            __statist_i_h_wts[0, 26] = -9.05226284837981e-002;

            __statist_i_h_wts[0, 27] = -2.09993081679440e-002;

            __statist_i_h_wts[0, 28] = -5.74175623871426e-003;

            __statist_i_h_wts[0, 29] = 4.61606839931947e-002;

            __statist_i_h_wts[0, 30] = 6.02327637816891e-002;

            __statist_i_h_wts[0, 31] = -5.81268679213001e-002;

            __statist_i_h_wts[0, 32] = -4.61060984107249e-002;

            __statist_i_h_wts[0, 33] = -1.66440254082824e-003;

            __statist_i_h_wts[0, 34] = -6.81286928179797e-002;

            __statist_i_h_wts[0, 35] = 4.31755442130319e-002;

            __statist_i_h_wts[0, 36] = 2.32265700647602e-003;

            __statist_i_h_wts[0, 37] = -2.83407506140542e-002;

            __statist_i_h_wts[0, 38] = 1.32816446040713e-002;

            __statist_i_h_wts[0, 39] = -7.01528437143989e-002;

            __statist_i_h_wts[0, 40] = 3.29883036367958e-002;

            __statist_i_h_wts[0, 41] = -8.83494464688992e-002;

            __statist_i_h_wts[0, 42] = -1.15576951196808e-001;

            __statist_i_h_wts[0, 43] = 5.79990922910795e-002;

            __statist_i_h_wts[0, 44] = -1.05635687360070e-001;

            __statist_i_h_wts[0, 45] = -5.92474825879132e-003;

            __statist_i_h_wts[0, 46] = -1.95604801871997e-002;

            __statist_i_h_wts[0, 47] = 2.14844271701948e-003;

            __statist_i_h_wts[0, 48] = -2.49408987526335e-002;

            __statist_i_h_wts[0, 49] = -1.71975283661246e-002;

            __statist_i_h_wts[0, 50] = 4.94444277152030e-002;

            __statist_i_h_wts[0, 51] = 4.93772195755004e-004;

            __statist_i_h_wts[0, 52] = 5.74839561088266e-002;

            __statist_i_h_wts[0, 53] = -3.89549594775697e-002;

            __statist_i_h_wts[0, 54] = 6.97641681013653e-002;

            __statist_i_h_wts[0, 55] = 1.32771978566227e-001;

            __statist_i_h_wts[0, 56] = -1.23701217238416e-001;

            __statist_i_h_wts[0, 57] = 3.97103995481514e-002;

            __statist_i_h_wts[0, 58] = 1.34348894335303e-001;

            __statist_i_h_wts[0, 59] = -4.30726962154712e-002;

            __statist_i_h_wts[0, 60] = -7.05429082870139e-002;

            __statist_i_h_wts[0, 61] = 1.29743177044663e-001;

            __statist_i_h_wts[0, 62] = -4.72407831857184e-001;

            __statist_i_h_wts[0, 63] = 2.65686692187702e-001;

            __statist_i_h_wts[0, 64] = 2.30417772843553e-001;

            __statist_i_h_wts[0, 65] = -4.03422007269130e-002;

            __statist_i_h_wts[0, 66] = 6.97048925973803e-002;

            __statist_i_h_wts[0, 67] = 6.75699903925125e-003;

            __statist_i_h_wts[0, 68] = -1.16652181624466e-001;

            __statist_i_h_wts[0, 69] = 2.89176796299297e-001;

            __statist_i_h_wts[0, 70] = -1.20476299717886e-001;

            __statist_i_h_wts[0, 71] = -2.18612594427317e-001;

            __statist_i_h_wts[0, 72] = 1.37880838660844e-001;

            __statist_i_h_wts[0, 73] = 1.20441986469150e-001;

            __statist_i_h_wts[0, 74] = -5.41587868229503e-002;

            __statist_i_h_wts[0, 75] = -7.23640457739645e-002;

            __statist_i_h_wts[0, 76] = 1.80276137850475e-001;

            __statist_i_h_wts[0, 77] = -4.72998982119433e-001;

            __statist_i_h_wts[0, 78] = 2.70702930053504e-001;

            __statist_i_h_wts[0, 79] = 2.38190046365615e-001;

            __statist_i_h_wts[0, 80] = 1.32225616648251e-001;

            __statist_i_h_wts[0, 81] = 6.48415326466043e-002;

            __statist_i_h_wts[0, 82] = -1.64278099043662e-001;

            __statist_i_h_wts[0, 83] = 1.94339529176807e-002;

            __statist_i_h_wts[0, 84] = 1.62909238528348e-001;

            __statist_i_h_wts[0, 85] = -1.59590144150338e-001;

            __statist_i_h_wts[0, 86] = 1.58050188065641e-001;

            __statist_i_h_wts[0, 87] = -3.87312209292774e-001;

            __statist_i_h_wts[0, 88] = 2.79416874119931e-001;

            __statist_i_h_wts[0, 89] = 2.30607022173013e-001;

            __statist_i_h_wts[0, 90] = -5.03756899660305e-001;

            __statist_i_h_wts[0, 91] = 2.88331061406645e-001;

            __statist_i_h_wts[0, 92] = 8.80732191931051e-001;

            __statist_i_h_wts[0, 93] = -1.34384230681330e-001;

            __statist_i_h_wts[0, 94] = -7.15619419418379e-001;

            __statist_i_h_wts[0, 95] = 5.42980207610108e-001;

            __statist_i_h_wts[0, 96] = -1.87210721645574e-001;

            __statist_i_h_wts[0, 97] = -3.10442880536129e-001;

            __statist_i_h_wts[0, 98] = -4.43224387607450e-002;

            __statist_i_h_wts[0, 99] = 4.10744856113464e-002;

            __statist_i_h_wts[0, 100] = 4.92250452211293e-002;

            __statist_i_h_wts[0, 101] = 3.11601993575828e-002;

            __statist_i_h_wts[0, 102] = -6.56714874779533e-002;

            __statist_i_h_wts[0, 103] = 7.97989731428948e-002;

            __statist_i_h_wts[0, 104] = -5.15051084151771e-001;

            __statist_i_h_wts[0, 105] = 3.25842063689894e-001;

            __statist_i_h_wts[0, 106] = 2.49151629860146e-001;

            __statist_i_h_wts[0, 107] = 9.56750692317528e-003;

            __statist_i_h_wts[0, 108] = 1.33568412245460e-001;

            __statist_i_h_wts[0, 109] = -1.20331863637707e-001;

            __statist_i_h_wts[0, 110] = -2.62304920565549e-002;

            __statist_i_h_wts[0, 111] = 2.21294912144253e-001;

            __statist_i_h_wts[0, 112] = -1.53637884965821e-001;

            __statist_i_h_wts[0, 113] = -3.50867650326159e-002;

            __statist_i_h_wts[0, 114] = -1.52661537498025e-002;

            __statist_i_h_wts[0, 115] = 8.09405032191607e-002;

            __statist_i_h_wts[0, 116] = 8.30516843080580e-002;

            __statist_i_h_wts[0, 117] = -1.57505561618010e-001;

            __statist_i_h_wts[0, 118] = 1.15598697199321e-001;

            __statist_i_h_wts[0, 119] = -2.72054410786182e-001;

            __statist_i_h_wts[0, 120] = 2.38164788859314e-001;

            __statist_i_h_wts[0, 121] = 8.87184509157667e-002;

            __statist_i_h_wts[0, 122] = 1.43555634157252e-001;

            __statist_i_h_wts[0, 123] = -1.29444676950235e-001;

            __statist_i_h_wts[0, 124] = 1.29011208528940e-002;

            __statist_i_h_wts[0, 125] = 8.28812421857143e-002;

            __statist_i_h_wts[0, 126] = 4.53610720887742e-002;

            __statist_i_h_wts[0, 127] = -6.49040522275058e-002;



            __statist_i_h_wts[1, 0] = -2.03962639600117e-002;

            __statist_i_h_wts[1, 1] = -5.77191015480114e-003;

            __statist_i_h_wts[1, 2] = -3.74887058455879e-002;

            __statist_i_h_wts[1, 3] = -2.79499234447913e-002;

            __statist_i_h_wts[1, 4] = -2.00178179726213e-002;

            __statist_i_h_wts[1, 5] = -3.35149023215834e-002;

            __statist_i_h_wts[1, 6] = 1.07901103661308e-002;

            __statist_i_h_wts[1, 7] = -3.04280766927477e-003;

            __statist_i_h_wts[1, 8] = 2.89882616577715e-002;

            __statist_i_h_wts[1, 9] = 1.19632891987188e-002;

            __statist_i_h_wts[1, 10] = 3.15200182862773e-003;

            __statist_i_h_wts[1, 11] = 1.51037178378043e-002;

            __statist_i_h_wts[1, 12] = 2.00287557906598e-002;

            __statist_i_h_wts[1, 13] = -1.47576204776287e-002;

            __statist_i_h_wts[1, 14] = -3.17267731189424e-002;

            __statist_i_h_wts[1, 15] = 1.66509840696524e-002;

            __statist_i_h_wts[1, 16] = 1.40132867811387e-002;

            __statist_i_h_wts[1, 17] = 1.84728132875507e-002;

            __statist_i_h_wts[1, 18] = -3.26968127029287e-002;

            __statist_i_h_wts[1, 19] = -3.85264193350367e-002;

            __statist_i_h_wts[1, 20] = -1.94046962057848e-003;

            __statist_i_h_wts[1, 21] = 7.01623416656207e-003;

            __statist_i_h_wts[1, 22] = 3.14233915855726e-003;

            __statist_i_h_wts[1, 23] = -3.08647193705791e-002;

            __statist_i_h_wts[1, 24] = 1.71422786161452e-002;

            __statist_i_h_wts[1, 25] = 3.87230992960196e-002;

            __statist_i_h_wts[1, 26] = 2.68237721052560e-002;

            __statist_i_h_wts[1, 27] = 5.32816723214237e-002;

            __statist_i_h_wts[1, 28] = 1.66541020682052e-002;

            __statist_i_h_wts[1, 29] = -3.82316450954346e-002;

            __statist_i_h_wts[1, 30] = -4.02094128725544e-002;

            __statist_i_h_wts[1, 31] = 4.59656173103629e-002;

            __statist_i_h_wts[1, 32] = 4.76204224199447e-002;

            __statist_i_h_wts[1, 33] = 2.25164724408249e-002;

            __statist_i_h_wts[1, 34] = 2.79281367246857e-002;

            __statist_i_h_wts[1, 35] = -2.64378049182636e-002;

            __statist_i_h_wts[1, 36] = 2.23389350692657e-003;

            __statist_i_h_wts[1, 37] = 1.80044124408215e-002;

            __statist_i_h_wts[1, 38] = 8.76333439358631e-003;

            __statist_i_h_wts[1, 39] = 1.94766197528387e-002;

            __statist_i_h_wts[1, 40] = -2.49818265762562e-002;

            __statist_i_h_wts[1, 41] = 4.47815982050123e-002;

            __statist_i_h_wts[1, 42] = 1.90770070841274e-002;

            __statist_i_h_wts[1, 43] = -2.00718253380610e-003;

            __statist_i_h_wts[1, 44] = 5.21236969813385e-002;

            __statist_i_h_wts[1, 45] = -2.66226052454264e-003;

            __statist_i_h_wts[1, 46] = 8.08442615053636e-003;

            __statist_i_h_wts[1, 47] = 1.03164757824112e-004;

            __statist_i_h_wts[1, 48] = -5.50658137044984e-003;

            __statist_i_h_wts[1, 49] = 3.91407424040642e-002;

            __statist_i_h_wts[1, 50] = -1.26307707592843e-002;

            __statist_i_h_wts[1, 51] = 7.43383659750483e-003;

            __statist_i_h_wts[1, 52] = 1.09602903545632e-002;

            __statist_i_h_wts[1, 53] = 2.19337631468157e-003;

            __statist_i_h_wts[1, 54] = -2.14866275399457e-002;

            __statist_i_h_wts[1, 55] = -5.94353652054358e-002;

            __statist_i_h_wts[1, 56] = 3.76622381973521e-002;

            __statist_i_h_wts[1, 57] = 4.07177630320641e-002;

            __statist_i_h_wts[1, 58] = -4.93151407001331e-002;

            __statist_i_h_wts[1, 59] = 5.54908552032558e-002;

            __statist_i_h_wts[1, 60] = 3.54863464841013e-002;

            __statist_i_h_wts[1, 61] = -4.58372602785963e-002;

            __statist_i_h_wts[1, 62] = 4.34320419773199e-003;

            __statist_i_h_wts[1, 63] = 1.34559010883593e-001;

            __statist_i_h_wts[1, 64] = -9.45566995509054e-002;

            __statist_i_h_wts[1, 65] = 1.31631100103786e-002;

            __statist_i_h_wts[1, 66] = 5.22995391753919e-002;

            __statist_i_h_wts[1, 67] = -1.63753790582223e-004;

            __statist_i_h_wts[1, 68] = 7.81125662723240e-003;

            __statist_i_h_wts[1, 69] = -4.31201983378205e-003;

            __statist_i_h_wts[1, 70] = 5.25281270763168e-002;

            __statist_i_h_wts[1, 71] = 2.66470710843354e-002;

            __statist_i_h_wts[1, 72] = 8.01251686171207e-002;

            __statist_i_h_wts[1, 73] = -4.37827861148502e-002;

            __statist_i_h_wts[1, 74] = 6.97879355195962e-002;

            __statist_i_h_wts[1, 75] = 6.35130087732345e-002;

            __statist_i_h_wts[1, 76] = -7.93390465701671e-002;

            __statist_i_h_wts[1, 77] = -1.57863975041851e-002;

            __statist_i_h_wts[1, 78] = 1.71797518721515e-001;

            __statist_i_h_wts[1, 79] = -1.03372906402224e-001;

            __statist_i_h_wts[1, 80] = -4.98499733015900e-002;

            __statist_i_h_wts[1, 81] = 3.44953996448658e-002;

            __statist_i_h_wts[1, 82] = 5.29246292733581e-002;

            __statist_i_h_wts[1, 83] = -2.67261541196198e-002;

            __statist_i_h_wts[1, 84] = -5.86843695913745e-003;

            __statist_i_h_wts[1, 85] = 7.72994096245546e-002;

            __statist_i_h_wts[1, 86] = 1.36248675853984e-001;

            __statist_i_h_wts[1, 87] = 5.02054392582504e-002;

            __statist_i_h_wts[1, 88] = -1.37385847520281e-001;

            __statist_i_h_wts[1, 89] = 1.92836169578041e-001;

            __statist_i_h_wts[1, 90] = 1.86683117158453e-002;

            __statist_i_h_wts[1, 91] = -1.23263999922641e-001;

            __statist_i_h_wts[1, 92] = -1.86027752853080e-001;

            __statist_i_h_wts[1, 93] = -6.86339033941650e-002;

            __statist_i_h_wts[1, 94] = 3.03067842218125e-001;

            __statist_i_h_wts[1, 95] = -8.48151275539966e-003;

            __statist_i_h_wts[1, 96] = -8.62305199645294e-002;

            __statist_i_h_wts[1, 97] = 1.31262345505987e-001;

            __statist_i_h_wts[1, 98] = 2.10296166293880e-002;

            __statist_i_h_wts[1, 99] = 4.80448619817084e-002;

            __statist_i_h_wts[1, 100] = -1.13240978142770e-002;

            __statist_i_h_wts[1, 101] = 6.29022017383522e-002;

            __statist_i_h_wts[1, 102] = 6.31290636171599e-002;

            __statist_i_h_wts[1, 103] = -5.94611463681432e-002;

            __statist_i_h_wts[1, 104] = -1.95439979842581e-002;

            __statist_i_h_wts[1, 105] = 1.67455123384338e-001;

            __statist_i_h_wts[1, 106] = -1.16157368847516e-001;

            __statist_i_h_wts[1, 107] = -4.53587018775518e-002;

            __statist_i_h_wts[1, 108] = 3.30949775712223e-002;

            __statist_i_h_wts[1, 109] = 6.40894485870867e-002;

            __statist_i_h_wts[1, 110] = -2.09768427739050e-003;

            __statist_i_h_wts[1, 111] = -3.10486782617019e-002;

            __statist_i_h_wts[1, 112] = 9.27227126876705e-002;

            __statist_i_h_wts[1, 113] = 1.28598231901876e-002;

            __statist_i_h_wts[1, 114] = 5.40990288257784e-002;

            __statist_i_h_wts[1, 115] = -4.07418201096203e-002;

            __statist_i_h_wts[1, 116] = 5.56963894073042e-002;

            __statist_i_h_wts[1, 117] = 4.64881736637677e-002;

            __statist_i_h_wts[1, 118] = -5.14713301714223e-002;

            __statist_i_h_wts[1, 119] = -3.48206164483116e-002;

            __statist_i_h_wts[1, 120] = 1.20385218330662e-001;

            __statist_i_h_wts[1, 121] = -2.03352386903191e-002;

            __statist_i_h_wts[1, 122] = 3.11060960030832e-002;

            __statist_i_h_wts[1, 123] = 1.17452799011663e-002;

            __statist_i_h_wts[1, 124] = -5.55821828338989e-003;

            __statist_i_h_wts[1, 125] = 3.28023160699445e-002;

            __statist_i_h_wts[1, 126] = -2.27659145797787e-002;

            __statist_i_h_wts[1, 127] = 1.91755492942363e-002;



            __statist_i_h_wts[2, 0] = 9.50461181712325e-004;

            __statist_i_h_wts[2, 1] = 5.55661338663838e-003;

            __statist_i_h_wts[2, 2] = -6.31642445433485e-002;

            __statist_i_h_wts[2, 3] = 3.36154868649760e-002;

            __statist_i_h_wts[2, 4] = -1.71393042538927e-002;

            __statist_i_h_wts[2, 5] = 3.03623165165711e-002;

            __statist_i_h_wts[2, 6] = -2.63651404560542e-002;

            __statist_i_h_wts[2, 7] = 1.05137788247196e-002;

            __statist_i_h_wts[2, 8] = -5.78109194085048e-002;

            __statist_i_h_wts[2, 9] = 1.37168173921530e-002;

            __statist_i_h_wts[2, 10] = 6.76766118288390e-002;

            __statist_i_h_wts[2, 11] = 4.02184672262125e-002;

            __statist_i_h_wts[2, 12] = -6.34818744773925e-002;

            __statist_i_h_wts[2, 13] = 1.16753221464323e-001;

            __statist_i_h_wts[2, 14] = 7.62656759483888e-002;

            __statist_i_h_wts[2, 15] = -5.28819433725941e-002;

            __statist_i_h_wts[2, 16] = -1.25067679645716e-002;

            __statist_i_h_wts[2, 17] = 2.57746242985986e-003;

            __statist_i_h_wts[2, 18] = 4.93967547354436e-002;

            __statist_i_h_wts[2, 19] = 5.15656456842656e-002;

            __statist_i_h_wts[2, 20] = 5.34604549577061e-002;

            __statist_i_h_wts[2, 21] = -1.33652783213843e-002;

            __statist_i_h_wts[2, 22] = -1.70092459966088e-002;

            __statist_i_h_wts[2, 23] = 2.33235837378661e-002;

            __statist_i_h_wts[2, 24] = 1.73916708507879e-002;

            __statist_i_h_wts[2, 25] = -9.27640781314601e-002;

            __statist_i_h_wts[2, 26] = -1.12483376969606e-001;

            __statist_i_h_wts[2, 27] = -7.20841997821652e-002;

            __statist_i_h_wts[2, 28] = -4.50969948751564e-002;

            __statist_i_h_wts[2, 29] = 9.70178920834374e-002;

            __statist_i_h_wts[2, 30] = 1.35414239599279e-001;

            __statist_i_h_wts[2, 31] = -3.83544535411485e-002;

            __statist_i_h_wts[2, 32] = 2.33946483635615e-003;

            __statist_i_h_wts[2, 33] = 1.92323216533300e-003;

            __statist_i_h_wts[2, 34] = -7.36461540306922e-002;

            __statist_i_h_wts[2, 35] = 9.71916517360945e-002;

            __statist_i_h_wts[2, 36] = -3.99808033976014e-003;

            __statist_i_h_wts[2, 37] = -3.89253250788114e-002;

            __statist_i_h_wts[2, 38] = -2.72583416577276e-002;

            __statist_i_h_wts[2, 39] = -1.05481006062997e-001;

            __statist_i_h_wts[2, 40] = -2.56746139043811e-002;

            __statist_i_h_wts[2, 41] = -1.19862233065975e-001;

            __statist_i_h_wts[2, 42] = -3.89077419990220e-001;

            __statist_i_h_wts[2, 43] = -1.08260341100556e-002;

            __statist_i_h_wts[2, 44] = -8.64018627994752e-002;

            __statist_i_h_wts[2, 45] = -1.33348633464847e-002;

            __statist_i_h_wts[2, 46] = -2.34553353220289e-003;

            __statist_i_h_wts[2, 47] = 3.32796239405729e-003;

            __statist_i_h_wts[2, 48] = -5.06477359690901e-002;

            __statist_i_h_wts[2, 49] = -1.01039374858549e-001;

            __statist_i_h_wts[2, 50] = 2.57047984300332e-001;

            __statist_i_h_wts[2, 51] = 9.65310511782064e-003;

            __statist_i_h_wts[2, 52] = 4.08912855659893e-002;

            __statist_i_h_wts[2, 53] = 5.71368959036485e-002;

            __statist_i_h_wts[2, 54] = 5.67807277924562e-002;

            __statist_i_h_wts[2, 55] = 1.78222238303087e-001;

            __statist_i_h_wts[2, 56] = -4.44030962536439e-001;

            __statist_i_h_wts[2, 57] = 2.07158691727182e-001;

            __statist_i_h_wts[2, 58] = 1.38643748817469e-001;

            __statist_i_h_wts[2, 59] = -2.58403964941374e-001;

            __statist_i_h_wts[2, 60] = 5.27007771076793e-002;

            __statist_i_h_wts[2, 61] = 1.62833404463087e-001;

            __statist_i_h_wts[2, 62] = -2.19556759900442e+000;

            __statist_i_h_wts[2, 63] = 1.85743311542259e+000;

            __statist_i_h_wts[2, 64] = 2.58113253557961e-001;

            __statist_i_h_wts[2, 65] = 2.29772957403079e-002;

            __statist_i_h_wts[2, 66] = -3.98981084408984e-002;

            __statist_i_h_wts[2, 67] = -5.75319607961091e-002;

            __statist_i_h_wts[2, 68] = -3.79527387757789e-001;

            __statist_i_h_wts[2, 69] = 5.45271478454702e-001;

            __statist_i_h_wts[2, 70] = -2.62142636983186e-001;

            __statist_i_h_wts[2, 71] = -5.25696037083433e-001;

            __statist_i_h_wts[2, 72] = 3.20849948896284e-001;

            __statist_i_h_wts[2, 73] = 1.04154965714275e-001;

            __statist_i_h_wts[2, 74] = -3.00907856368707e-001;

            __statist_i_h_wts[2, 75] = 5.65296372315189e-002;

            __statist_i_h_wts[2, 76] = 1.54083271106363e-001;

            __statist_i_h_wts[2, 77] = -2.33858636228153e+000;

            __statist_i_h_wts[2, 78] = 1.87167388681301e+000;

            __statist_i_h_wts[2, 79] = 3.90814332710163e-001;

            __statist_i_h_wts[2, 80] = 3.74213575789034e-001;

            __statist_i_h_wts[2, 81] = -1.96265825877634e-001;

            __statist_i_h_wts[2, 82] = -2.46015680860204e-001;

            __statist_i_h_wts[2, 83] = -7.03828965047892e-002;

            __statist_i_h_wts[2, 84] = 2.45533074663779e-001;

            __statist_i_h_wts[2, 85] = -2.42439040681705e-001;

            __statist_i_h_wts[2, 86] = 1.53466082784702e+000;

            __statist_i_h_wts[2, 87] = -1.89849358788780e+000;

            __statist_i_h_wts[2, 88] = 2.81240077342002e-001;

            __statist_i_h_wts[2, 89] = 1.90892257581731e+000;

            __statist_i_h_wts[2, 90] = -2.31682715759638e+000;

            __statist_i_h_wts[2, 91] = 3.35983830159224e-001;

            __statist_i_h_wts[2, 92] = 2.99992191328638e+000;

            __statist_i_h_wts[2, 93] = -2.01385586956056e+000;

            __statist_i_h_wts[2, 94] = -1.07623964008329e+000;

            __statist_i_h_wts[2, 95] = 2.10692321051067e+000;

            __statist_i_h_wts[2, 96] = -1.48443441835177e+000;

            __statist_i_h_wts[2, 97] = -6.93963451023998e-001;

            __statist_i_h_wts[2, 98] = 8.53411360245013e-003;

            __statist_i_h_wts[2, 99] = -1.77095125166230e-001;

            __statist_i_h_wts[2, 100] = 9.78749508279523e-002;

            __statist_i_h_wts[2, 101] = 5.84527677766585e-002;

            __statist_i_h_wts[2, 102] = -2.27754915165603e-001;

            __statist_i_h_wts[2, 103] = 1.02278301979335e-001;

            __statist_i_h_wts[2, 104] = -2.28078342794523e+000;

            __statist_i_h_wts[2, 105] = 1.89282732431022e+000;

            __statist_i_h_wts[2, 106] = 3.33442912720346e-001;

            __statist_i_h_wts[2, 107] = 3.21865703262596e-001;

            __statist_i_h_wts[2, 108] = -2.22263658667120e-001;

            __statist_i_h_wts[2, 109] = -1.40591701335681e-001;

            __statist_i_h_wts[2, 110] = 5.47017829467292e-002;

            __statist_i_h_wts[2, 111] = 1.47511669465822e-001;

            __statist_i_h_wts[2, 112] = -2.89182647893923e-001;

            __statist_i_h_wts[2, 113] = 1.39237088452084e-001;

            __statist_i_h_wts[2, 114] = -2.64961246923206e-001;

            __statist_i_h_wts[2, 115] = 6.42762508149713e-002;

            __statist_i_h_wts[2, 116] = 6.74214776120041e-002;

            __statist_i_h_wts[2, 117] = -1.90857781776270e-001;

            __statist_i_h_wts[2, 118] = 3.78916547803606e-002;

            __statist_i_h_wts[2, 119] = -1.76058060843561e+000;

            __statist_i_h_wts[2, 120] = 1.50617519667042e+000;

            __statist_i_h_wts[2, 121] = 1.81838944595320e-001;

            __statist_i_h_wts[2, 122] = 5.56760301457020e-001;

            __statist_i_h_wts[2, 123] = -5.93623986964274e-001;

            __statist_i_h_wts[2, 124] = -2.43443753925690e-002;

            __statist_i_h_wts[2, 125] = 2.88913453604602e-001;

            __statist_i_h_wts[2, 126] = -1.91631176921029e-001;

            __statist_i_h_wts[2, 127] = -1.48659109175216e-001;



            __statist_i_h_wts[3, 0] = 1.20122803061281e-002;

            __statist_i_h_wts[3, 1] = -3.88684365999447e-003;

            __statist_i_h_wts[3, 2] = 3.67016247572446e-002;

            __statist_i_h_wts[3, 3] = 5.56075923074243e-002;

            __statist_i_h_wts[3, 4] = 5.98739883111397e-002;

            __statist_i_h_wts[3, 5] = 5.68941542435066e-002;

            __statist_i_h_wts[3, 6] = -3.86784193139667e-002;

            __statist_i_h_wts[3, 7] = 2.82883311008122e-002;

            __statist_i_h_wts[3, 8] = -4.25493014283921e-002;

            __statist_i_h_wts[3, 9] = 1.12480937638288e-002;

            __statist_i_h_wts[3, 10] = -2.60985349206130e-003;

            __statist_i_h_wts[3, 11] = 3.45106218291896e-003;

            __statist_i_h_wts[3, 12] = -9.37322164417304e-002;

            __statist_i_h_wts[3, 13] = 5.65658340485924e-002;

            __statist_i_h_wts[3, 14] = 3.35127392243780e-002;

            __statist_i_h_wts[3, 15] = -2.77904610393988e-002;

            __statist_i_h_wts[3, 16] = -5.86534836566369e-002;

            __statist_i_h_wts[3, 17] = -1.05729366192780e-002;

            __statist_i_h_wts[3, 18] = 5.84876568693863e-002;

            __statist_i_h_wts[3, 19] = 7.42358381179052e-002;

            __statist_i_h_wts[3, 20] = 8.09307915426879e-003;

            __statist_i_h_wts[3, 21] = -1.63910762290377e-002;

            __statist_i_h_wts[3, 22] = 1.51515232081380e-002;

            __statist_i_h_wts[3, 23] = 4.24416407968885e-002;

            __statist_i_h_wts[3, 24] = -4.73055063321265e-002;

            __statist_i_h_wts[3, 25] = -5.17950041601677e-002;

            __statist_i_h_wts[3, 26] = -5.20368885256468e-002;

            __statist_i_h_wts[3, 27] = -3.11659344647014e-002;

            __statist_i_h_wts[3, 28] = -2.24413240188991e-002;

            __statist_i_h_wts[3, 29] = 6.87576699278673e-002;

            __statist_i_h_wts[3, 30] = 7.81869998929771e-002;

            __statist_i_h_wts[3, 31] = -8.03305269342980e-002;

            __statist_i_h_wts[3, 32] = -4.34976306364853e-002;

            __statist_i_h_wts[3, 33] = -1.99064736166914e-002;

            __statist_i_h_wts[3, 34] = -4.03514751184883e-002;

            __statist_i_h_wts[3, 35] = 2.57789252106126e-002;

            __statist_i_h_wts[3, 36] = -2.29095370467352e-003;

            __statist_i_h_wts[3, 37] = -2.28587771950473e-002;

            __statist_i_h_wts[3, 38] = 9.40662659619872e-003;

            __statist_i_h_wts[3, 39] = -1.00712731790232e-002;

            __statist_i_h_wts[3, 40] = 4.75358396300360e-002;

            __statist_i_h_wts[3, 41] = -7.21663084999914e-002;

            __statist_i_h_wts[3, 42] = -1.15481136743566e-001;

            __statist_i_h_wts[3, 43] = 3.44084961863394e-002;

            __statist_i_h_wts[3, 44] = -6.80843599008377e-002;

            __statist_i_h_wts[3, 45] = -1.80914543760387e-002;

            __statist_i_h_wts[3, 46] = -2.71014310955265e-002;

            __statist_i_h_wts[3, 47] = -6.60381066487277e-003;

            __statist_i_h_wts[3, 48] = 2.84678107533981e-002;

            __statist_i_h_wts[3, 49] = -2.48435821848899e-002;

            __statist_i_h_wts[3, 50] = 2.63238906502023e-002;

            __statist_i_h_wts[3, 51] = 2.50542850203751e-002;

            __statist_i_h_wts[3, 52] = 1.20464253684759e-002;

            __statist_i_h_wts[3, 53] = 7.76654488363825e-003;

            __statist_i_h_wts[3, 54] = 4.65068087752435e-002;

            __statist_i_h_wts[3, 55] = 1.12721358906891e-001;

            __statist_i_h_wts[3, 56] = -6.86134851832067e-002;

            __statist_i_h_wts[3, 57] = -1.93894454044966e-002;

            __statist_i_h_wts[3, 58] = 9.51332468878789e-002;

            __statist_i_h_wts[3, 59] = 1.73367199329935e-002;

            __statist_i_h_wts[3, 60] = -6.18991550342227e-002;

            __statist_i_h_wts[3, 61] = 9.43991261753571e-002;

            __statist_i_h_wts[3, 62] = -5.23889336410318e-002;

            __statist_i_h_wts[3, 63] = -8.89553126164752e-002;

            __statist_i_h_wts[3, 64] = 1.77205072524836e-001;

            __statist_i_h_wts[3, 65] = 6.36507623181720e-002;

            __statist_i_h_wts[3, 66] = -6.93067608897504e-002;

            __statist_i_h_wts[3, 67] = 1.98384305197985e-002;

            __statist_i_h_wts[3, 68] = 3.41271639160822e-002;

            __statist_i_h_wts[3, 69] = 9.85794631452810e-002;

            __statist_i_h_wts[3, 70] = -8.11585055089377e-002;

            __statist_i_h_wts[3, 71] = -9.17684191190907e-002;

            __statist_i_h_wts[3, 72] = 1.40110055964709e-002;

            __statist_i_h_wts[3, 73] = 9.93075993284397e-002;

            __statist_i_h_wts[3, 74] = -5.11092333624256e-002;

            __statist_i_h_wts[3, 75] = -6.59265569726545e-002;

            __statist_i_h_wts[3, 76] = 1.18960280941376e-001;

            __statist_i_h_wts[3, 77] = -3.56273276910110e-002;

            __statist_i_h_wts[3, 78] = -1.35713256504702e-001;

            __statist_i_h_wts[3, 79] = 2.25633762084530e-001;

            __statist_i_h_wts[3, 80] = 1.92383104234526e-001;

            __statist_i_h_wts[3, 81] = -5.07863226761478e-002;

            __statist_i_h_wts[3, 82] = -1.15049305180183e-001;

            __statist_i_h_wts[3, 83] = 9.43150511557705e-002;

            __statist_i_h_wts[3, 84] = 1.72961581243548e-002;

            __statist_i_h_wts[3, 85] = -9.80503445393052e-002;

            __statist_i_h_wts[3, 86] = -1.29120342317244e-001;

            __statist_i_h_wts[3, 87] = -7.53658748551908e-002;

            __statist_i_h_wts[3, 88] = 2.16173441817318e-001;

            __statist_i_h_wts[3, 89] = -1.36591274257807e-001;

            __statist_i_h_wts[3, 90] = -8.31302048938538e-002;

            __statist_i_h_wts[3, 91] = 2.42604757230324e-001;

            __statist_i_h_wts[3, 92] = 6.71785364069839e-001;

            __statist_i_h_wts[3, 93] = -4.05500977464186e-002;

            __statist_i_h_wts[3, 94] = -6.00968793449839e-001;

            __statist_i_h_wts[3, 95] = 1.91036575092152e-001;

            __statist_i_h_wts[3, 96] = 9.61383364318340e-002;

            __statist_i_h_wts[3, 97] = -2.56576934754435e-001;

            __statist_i_h_wts[3, 98] = -4.75478434870799e-002;

            __statist_i_h_wts[3, 99] = 3.37818757193479e-002;

            __statist_i_h_wts[3, 100] = 5.54341430514569e-002;

            __statist_i_h_wts[3, 101] = -5.30374238078678e-002;

            __statist_i_h_wts[3, 102] = -3.05637991467754e-002;

            __statist_i_h_wts[3, 103] = 9.18126784723041e-002;

            __statist_i_h_wts[3, 104] = -1.05959906776005e-001;

            __statist_i_h_wts[3, 105] = -1.03090533425103e-001;

            __statist_i_h_wts[3, 106] = 2.11541055485069e-001;

            __statist_i_h_wts[3, 107] = 1.10988050859104e-001;

            __statist_i_h_wts[3, 108] = 5.35833173033344e-004;

            __statist_i_h_wts[3, 109] = -1.00464982454783e-001;

            __statist_i_h_wts[3, 110] = 1.07535066102016e-001;

            __statist_i_h_wts[3, 111] = 4.40420265970757e-002;

            __statist_i_h_wts[3, 112] = -1.29530693773209e-001;

            __statist_i_h_wts[3, 113] = -7.54955743259997e-002;

            __statist_i_h_wts[3, 114] = 8.74472252194354e-003;

            __statist_i_h_wts[3, 115] = 7.24160083194878e-002;

            __statist_i_h_wts[3, 116] = -6.32829126922033e-002;

            __statist_i_h_wts[3, 117] = -6.60076600684721e-003;

            __statist_i_h_wts[3, 118] = 8.84006392392907e-002;

            __statist_i_h_wts[3, 119] = -3.06251594596533e-002;

            __statist_i_h_wts[3, 120] = -2.43103716885587e-002;

            __statist_i_h_wts[3, 121] = 8.71425689692705e-002;

            __statist_i_h_wts[3, 122] = 3.63242063078362e-002;

            __statist_i_h_wts[3, 123] = -2.60600283058177e-003;

            __statist_i_h_wts[3, 124] = -1.08723014297367e-002;

            __statist_i_h_wts[3, 125] = 7.07080839398426e-002;

            __statist_i_h_wts[3, 126] = -1.29643019042109e-002;

            __statist_i_h_wts[3, 127] = -2.74489667985418e-002;



            __statist_i_h_wts[4, 0] = -1.11033339470018e-002;

            __statist_i_h_wts[4, 1] = -3.58351410654586e-002;

            __statist_i_h_wts[4, 2] = -6.78193998751437e-003;

            __statist_i_h_wts[4, 3] = 1.09174417718229e-001;

            __statist_i_h_wts[4, 4] = 4.93350395200389e-002;

            __statist_i_h_wts[4, 5] = 5.23772788008226e-002;

            __statist_i_h_wts[4, 6] = -7.89555568473187e-002;

            __statist_i_h_wts[4, 7] = 5.16503343764005e-002;

            __statist_i_h_wts[4, 8] = -6.35339754871992e-002;

            __statist_i_h_wts[4, 9] = 4.11842222909225e-002;

            __statist_i_h_wts[4, 10] = -1.11048936994427e-002;

            __statist_i_h_wts[4, 11] = 3.38652571593076e-002;

            __statist_i_h_wts[4, 12] = -1.65534820657746e-001;

            __statist_i_h_wts[4, 13] = 1.01153295714303e-001;

            __statist_i_h_wts[4, 14] = 2.60743766216170e-002;

            __statist_i_h_wts[4, 15] = -6.35276404694241e-002;

            __statist_i_h_wts[4, 16] = -7.67899411755827e-002;

            __statist_i_h_wts[4, 17] = 2.16843189675820e-002;

            __statist_i_h_wts[4, 18] = -7.58158496667801e-003;

            __statist_i_h_wts[4, 19] = 1.10907120155905e-001;

            __statist_i_h_wts[4, 20] = 2.49375956548274e-002;

            __statist_i_h_wts[4, 21] = 3.53958698902223e-003;

            __statist_i_h_wts[4, 22] = -1.28153830308201e-002;

            __statist_i_h_wts[4, 23] = 1.05465005221895e-002;

            __statist_i_h_wts[4, 24] = -5.69628074107765e-002;

            __statist_i_h_wts[4, 25] = -6.98295455699489e-002;

            __statist_i_h_wts[4, 26] = -5.26498318606194e-002;

            __statist_i_h_wts[4, 27] = 3.22276502699555e-003;

            __statist_i_h_wts[4, 28] = 4.85194938056596e-003;

            __statist_i_h_wts[4, 29] = 1.00969751029234e-001;

            __statist_i_h_wts[4, 30] = 1.16863525115412e-001;

            __statist_i_h_wts[4, 31] = -7.36547236396123e-002;

            __statist_i_h_wts[4, 32] = -4.10376078437978e-002;

            __statist_i_h_wts[4, 33] = -2.65179033406940e-002;

            __statist_i_h_wts[4, 34] = -1.14549610416741e-001;

            __statist_i_h_wts[4, 35] = 1.59473567446920e-002;

            __statist_i_h_wts[4, 36] = -1.03923760808601e-002;

            __statist_i_h_wts[4, 37] = -5.71850694343949e-002;

            __statist_i_h_wts[4, 38] = 9.14098207813613e-003;

            __statist_i_h_wts[4, 39] = -9.98473382178386e-002;

            __statist_i_h_wts[4, 40] = 2.62615944975260e-002;

            __statist_i_h_wts[4, 41] = -7.82478207512471e-002;

            __statist_i_h_wts[4, 42] = -3.68152583004192e-001;

            __statist_i_h_wts[4, 43] = -1.33506699919624e-002;

            __statist_i_h_wts[4, 44] = -1.11136963982387e-001;

            __statist_i_h_wts[4, 45] = 2.70362455527327e-002;

            __statist_i_h_wts[4, 46] = -1.65552720505062e-002;

            __statist_i_h_wts[4, 47] = 1.10951767880102e-002;

            __statist_i_h_wts[4, 48] = 4.94760084452333e-002;

            __statist_i_h_wts[4, 49] = -1.18514348633773e-001;

            __statist_i_h_wts[4, 50] = 1.10389135057817e-001;

            __statist_i_h_wts[4, 51] = 2.12716085620069e-002;

            __statist_i_h_wts[4, 52] = 3.23799175348104e-002;

            __statist_i_h_wts[4, 53] = 4.67486269587657e-003;

            __statist_i_h_wts[4, 54] = 1.08459881926604e-001;

            __statist_i_h_wts[4, 55] = 1.15166049681910e-001;

            __statist_i_h_wts[4, 56] = -2.63257600490916e-001;

            __statist_i_h_wts[4, 57] = -9.22175100320501e-002;

            __statist_i_h_wts[4, 58] = 1.74834886110522e-001;

            __statist_i_h_wts[4, 59] = -1.31697186155904e-002;

            __statist_i_h_wts[4, 60] = -3.36550309898050e-001;

            __statist_i_h_wts[4, 61] = 1.65046979873373e-001;

            __statist_i_h_wts[4, 62] = -2.36292182003670e-001;

            __statist_i_h_wts[4, 63] = -2.38507349842188e-001;

            __statist_i_h_wts[4, 64] = 2.90751322471094e-001;

            __statist_i_h_wts[4, 65] = 1.14272501496049e-001;

            __statist_i_h_wts[4, 66] = -3.16691403130711e-001;

            __statist_i_h_wts[4, 67] = -3.05583306567486e-003;

            __statist_i_h_wts[4, 68] = -1.87267567221498e-001;

            __statist_i_h_wts[4, 69] = 2.30169177085281e-001;

            __statist_i_h_wts[4, 70] = -2.25245944769264e-001;

            __statist_i_h_wts[4, 71] = -4.27975072600007e-001;

            __statist_i_h_wts[4, 72] = 8.30456708157391e-002;

            __statist_i_h_wts[4, 73] = 1.52306482366937e-001;

            __statist_i_h_wts[4, 74] = -1.38174797416342e-001;

            __statist_i_h_wts[4, 75] = -2.19745960098670e-001;

            __statist_i_h_wts[4, 76] = 1.95234984275762e-001;

            __statist_i_h_wts[4, 77] = -2.12590863389169e-001;

            __statist_i_h_wts[4, 78] = -3.29987067201539e-001;

            __statist_i_h_wts[4, 79] = 3.53643384352158e-001;

            __statist_i_h_wts[4, 80] = 3.61147463603662e-001;

            __statist_i_h_wts[4, 81] = -2.83751884625605e-001;

            __statist_i_h_wts[4, 82] = -2.63440633140742e-001;

            __statist_i_h_wts[4, 83] = -6.40358223540382e-004;

            __statist_i_h_wts[4, 84] = 3.75824694082671e-002;

            __statist_i_h_wts[4, 85] = -2.11924626236384e-001;

            __statist_i_h_wts[4, 86] = -2.20881236589340e-001;

            __statist_i_h_wts[4, 87] = -3.28262245139276e-001;

            __statist_i_h_wts[4, 88] = 3.91089176349109e-001;

            __statist_i_h_wts[4, 89] = 2.90051654348864e-003;

            __statist_i_h_wts[4, 90] = -6.27521671404674e-001;

            __statist_i_h_wts[4, 91] = 4.39985404053126e-001;

            __statist_i_h_wts[4, 92] = 1.50269255410424e+000;

            __statist_i_h_wts[4, 93] = -4.19042806146902e-001;

            __statist_i_h_wts[4, 94] = -1.26515665985537e+000;

            __statist_i_h_wts[4, 95] = 6.78733519265672e-001;

            __statist_i_h_wts[4, 96] = -1.57145493197257e-001;

            __statist_i_h_wts[4, 97] = -7.00370422049498e-001;

            __statist_i_h_wts[4, 98] = -2.72519826263475e-001;

            __statist_i_h_wts[4, 99] = -1.48698086571409e-002;

            __statist_i_h_wts[4, 100] = 7.09839641663466e-002;

            __statist_i_h_wts[4, 101] = -4.59017374739025e-002;

            __statist_i_h_wts[4, 102] = -2.16130980695120e-001;

            __statist_i_h_wts[4, 103] = 9.52881022985131e-002;

            __statist_i_h_wts[4, 104] = -4.09231038120558e-001;

            __statist_i_h_wts[4, 105] = -9.96959015151375e-002;

            __statist_i_h_wts[4, 106] = 3.30496895847194e-001;

            __statist_i_h_wts[4, 107] = 1.73827749945551e-001;

            __statist_i_h_wts[4, 108] = -1.25871776279437e-001;

            __statist_i_h_wts[4, 109] = -2.33354379934801e-001;

            __statist_i_h_wts[4, 110] = -3.39359024996750e-003;

            __statist_i_h_wts[4, 111] = 9.21117880315635e-002;

            __statist_i_h_wts[4, 112] = -2.87610612919226e-001;

            __statist_i_h_wts[4, 113] = -2.75783498150086e-001;

            __statist_i_h_wts[4, 114] = -4.40297558297095e-002;

            __statist_i_h_wts[4, 115] = 1.27785425968725e-001;

            __statist_i_h_wts[4, 116] = -1.12458561700655e-001;

            __statist_i_h_wts[4, 117] = -1.92991832510520e-001;

            __statist_i_h_wts[4, 118] = 1.03735789074914e-001;

            __statist_i_h_wts[4, 119] = -1.93124450220325e-001;

            __statist_i_h_wts[4, 120] = -1.32076652081895e-001;

            __statist_i_h_wts[4, 121] = 1.53199946992467e-001;

            __statist_i_h_wts[4, 122] = 2.38967574170569e-001;

            __statist_i_h_wts[4, 123] = -3.77801103190772e-001;

            __statist_i_h_wts[4, 124] = -5.90723832007993e-002;

            __statist_i_h_wts[4, 125] = 1.43986256018070e-001;

            __statist_i_h_wts[4, 126] = -1.74562838531444e-001;

            __statist_i_h_wts[4, 127] = -1.37119689643862e-001;



            __statist_i_h_wts[5, 0] = -1.12183269040295e-002;

            __statist_i_h_wts[5, 1] = 8.21650458013309e-004;

            __statist_i_h_wts[5, 2] = 2.20586484705887e-002;

            __statist_i_h_wts[5, 3] = -5.46514797494244e-002;

            __statist_i_h_wts[5, 4] = -1.27599064418801e-002;

            __statist_i_h_wts[5, 5] = -1.78366997886673e-002;

            __statist_i_h_wts[5, 6] = 4.72466478896514e-002;

            __statist_i_h_wts[5, 7] = -2.51000955472694e-002;

            __statist_i_h_wts[5, 8] = 2.40100647283384e-002;

            __statist_i_h_wts[5, 9] = -1.46493363014632e-002;

            __statist_i_h_wts[5, 10] = 1.08863184367748e-002;

            __statist_i_h_wts[5, 11] = -3.51563450209484e-002;

            __statist_i_h_wts[5, 12] = 7.15927150973457e-002;

            __statist_i_h_wts[5, 13] = -8.32875121616388e-002;

            __statist_i_h_wts[5, 14] = -4.77989184494255e-003;

            __statist_i_h_wts[5, 15] = 3.83608129214073e-002;

            __statist_i_h_wts[5, 16] = 4.13672055069272e-002;

            __statist_i_h_wts[5, 17] = -1.39578685763308e-002;

            __statist_i_h_wts[5, 18] = -3.28360639603906e-002;

            __statist_i_h_wts[5, 19] = -7.13468010671261e-002;

            __statist_i_h_wts[5, 20] = -3.95342892705637e-002;

            __statist_i_h_wts[5, 21] = 7.27059451800348e-004;

            __statist_i_h_wts[5, 22] = 3.22187975252084e-002;

            __statist_i_h_wts[5, 23] = -9.40929312808587e-003;

            __statist_i_h_wts[5, 24] = 4.32352419480857e-002;

            __statist_i_h_wts[5, 25] = 7.29137149162249e-002;

            __statist_i_h_wts[5, 26] = 7.80936007356060e-002;

            __statist_i_h_wts[5, 27] = 7.58260019295377e-003;

            __statist_i_h_wts[5, 28] = 2.78377047138367e-002;

            __statist_i_h_wts[5, 29] = -5.63314433913415e-002;

            __statist_i_h_wts[5, 30] = -1.16201247629892e-001;

            __statist_i_h_wts[5, 31] = 2.22047559211549e-002;

            __statist_i_h_wts[5, 32] = 2.71185793625424e-002;

            __statist_i_h_wts[5, 33] = 4.96911474075217e-003;

            __statist_i_h_wts[5, 34] = 5.45787510220442e-002;

            __statist_i_h_wts[5, 35] = -2.69976976413053e-002;

            __statist_i_h_wts[5, 36] = 9.84687568892433e-003;

            __statist_i_h_wts[5, 37] = 5.30701044746350e-002;

            __statist_i_h_wts[5, 38] = 2.42425579046395e-002;

            __statist_i_h_wts[5, 39] = 7.11800918737470e-002;

            __statist_i_h_wts[5, 40] = 8.79434080023970e-003;

            __statist_i_h_wts[5, 41] = 1.13046535546119e-001;

            __statist_i_h_wts[5, 42] = 3.13113430097743e-001;

            __statist_i_h_wts[5, 43] = 2.11772687601098e-002;

            __statist_i_h_wts[5, 44] = 7.93642119473688e-002;

            __statist_i_h_wts[5, 45] = 1.69029750311244e-002;

            __statist_i_h_wts[5, 46] = 4.68004274909924e-004;

            __statist_i_h_wts[5, 47] = -8.69078957943203e-003;

            __statist_i_h_wts[5, 48] = 6.75696416830469e-002;

            __statist_i_h_wts[5, 49] = 7.18475036539785e-002;

            __statist_i_h_wts[5, 50] = -1.17580549472228e-001;

            __statist_i_h_wts[5, 51] = -1.20332750503413e-002;

            __statist_i_h_wts[5, 52] = -1.26048505944605e-002;

            __statist_i_h_wts[5, 53] = -1.03938065531998e-002;

            __statist_i_h_wts[5, 54] = -5.03493209071398e-002;

            __statist_i_h_wts[5, 55] = -1.30084302442333e-001;

            __statist_i_h_wts[5, 56] = 4.66346153893813e-001;

            __statist_i_h_wts[5, 57] = -8.74394267286931e-002;

            __statist_i_h_wts[5, 58] = -1.20417065455892e-001;

            __statist_i_h_wts[5, 59] = 3.24982312832934e-001;

            __statist_i_h_wts[5, 60] = 7.34863543346386e-002;

            __statist_i_h_wts[5, 61] = -1.19458676614381e-001;

            __statist_i_h_wts[5, 62] = 1.48884038979217e+000;

            __statist_i_h_wts[5, 63] = -9.99847133716542e-001;

            __statist_i_h_wts[5, 64] = -2.60682887113653e-001;

            __statist_i_h_wts[5, 65] = 1.37008126084466e-001;

            __statist_i_h_wts[5, 66] = 9.97353363104117e-002;

            __statist_i_h_wts[5, 67] = 4.57217994922066e-002;

            __statist_i_h_wts[5, 68] = 4.97353529832216e-001;

            __statist_i_h_wts[5, 69] = -3.99197308599472e-001;

            __statist_i_h_wts[5, 70] = 1.93816125927958e-001;

            __statist_i_h_wts[5, 71] = 5.67091189571537e-001;

            __statist_i_h_wts[5, 72] = -2.33458339629217e-001;

            __statist_i_h_wts[5, 73] = -8.33344237489948e-002;

            __statist_i_h_wts[5, 74] = 3.46875638285765e-001;

            __statist_i_h_wts[5, 75] = 4.83063119979169e-002;

            __statist_i_h_wts[5, 76] = -1.32457205715660e-001;

            __statist_i_h_wts[5, 77] = 1.59936091652409e+000;

            __statist_i_h_wts[5, 78] = -1.01949358545241e+000;

            __statist_i_h_wts[5, 79] = -3.03423428181456e-001;

            __statist_i_h_wts[5, 80] = -9.65811808218591e-002;

            __statist_i_h_wts[5, 81] = 1.82742356074100e-001;

            __statist_i_h_wts[5, 82] = 1.88807330928021e-001;

            __statist_i_h_wts[5, 83] = 2.48232915034366e-001;

            __statist_i_h_wts[5, 84] = -1.72960688746572e-001;

            __statist_i_h_wts[5, 85] = 1.92549762897020e-001;

            __statist_i_h_wts[5, 86] = -7.77152335724218e-001;

            __statist_i_h_wts[5, 87] = 1.27428852376307e+000;

            __statist_i_h_wts[5, 88] = -2.28135193745173e-001;

            __statist_i_h_wts[5, 89] = -1.10234898905042e+000;

            __statist_i_h_wts[5, 90] = 1.62826897077726e+000;

            __statist_i_h_wts[5, 91] = -2.44907159674914e-001;

            __statist_i_h_wts[5, 92] = -2.02464839992710e+000;

            __statist_i_h_wts[5, 93] = 1.43320013810437e+000;

            __statist_i_h_wts[5, 94] = 8.84704729496986e-001;

            __statist_i_h_wts[5, 95] = -1.38694345637815e+000;

            __statist_i_h_wts[5, 96] = 1.10511219753750e+000;

            __statist_i_h_wts[5, 97] = 5.46390496348723e-001;

            __statist_i_h_wts[5, 98] = 2.30129775814393e-001;

            __statist_i_h_wts[5, 99] = 1.11976866838670e-001;

            __statist_i_h_wts[5, 100] = -6.31061106289384e-002;

            __statist_i_h_wts[5, 101] = 1.26949692860368e-001;

            __statist_i_h_wts[5, 102] = 2.16052145849474e-001;

            __statist_i_h_wts[5, 103] = -6.44451951016762e-002;

            __statist_i_h_wts[5, 104] = 1.62197344306184e+000;

            __statist_i_h_wts[5, 105] = -1.08224425343148e+000;

            __statist_i_h_wts[5, 106] = -2.84289196937474e-001;

            __statist_i_h_wts[5, 107] = -5.26318545026100e-002;

            __statist_i_h_wts[5, 108] = 1.63192860924015e-001;

            __statist_i_h_wts[5, 109] = 1.35105141998872e-001;

            __statist_i_h_wts[5, 110] = 1.90461131002887e-001;

            __statist_i_h_wts[5, 111] = -1.51397885705686e-001;

            __statist_i_h_wts[5, 112] = 2.10837715888788e-001;

            __statist_i_h_wts[5, 113] = 1.40402190617089e-001;

            __statist_i_h_wts[5, 114] = 1.78694239309868e-001;

            __statist_i_h_wts[5, 115] = -7.00722851328584e-002;

            __statist_i_h_wts[5, 116] = 9.01071282427838e-002;

            __statist_i_h_wts[5, 117] = 2.49904652607693e-001;

            __statist_i_h_wts[5, 118] = -5.59826767890015e-002;

            __statist_i_h_wts[5, 119] = 1.23534344253317e+000;

            __statist_i_h_wts[5, 120] = -8.33162958577307e-001;

            __statist_i_h_wts[5, 121] = -1.44508324190930e-001;

            __statist_i_h_wts[5, 122] = -2.67862562448630e-001;

            __statist_i_h_wts[5, 123] = 4.97691279703147e-001;

            __statist_i_h_wts[5, 124] = 1.08619222987673e-002;

            __statist_i_h_wts[5, 125] = -3.48618810384954e-002;

            __statist_i_h_wts[5, 126] = 1.78588166052888e-001;

            __statist_i_h_wts[5, 127] = 1.26415903360268e-001;



            __statist_i_h_wts[6, 0] = 1.34843857047627e-001;

            __statist_i_h_wts[6, 1] = 8.30431588694218e-002;

            __statist_i_h_wts[6, 2] = 1.42520035487540e-001;

            __statist_i_h_wts[6, 3] = 1.16902000910745e-001;

            __statist_i_h_wts[6, 4] = 3.88739884613529e-002;

            __statist_i_h_wts[6, 5] = 1.68767304333810e-001;

            __statist_i_h_wts[6, 6] = -8.89396816717064e-002;

            __statist_i_h_wts[6, 7] = 3.11966591193922e-002;

            __statist_i_h_wts[6, 8] = -1.24235852054648e-001;

            __statist_i_h_wts[6, 9] = -6.02038980380890e-002;

            __statist_i_h_wts[6, 10] = 1.82366617812124e-002;

            __statist_i_h_wts[6, 11] = 6.88678025341995e-002;

            __statist_i_h_wts[6, 12] = -2.05159041252931e-001;

            __statist_i_h_wts[6, 13] = 8.17649427532004e-002;

            __statist_i_h_wts[6, 14] = 1.66616771090448e-001;

            __statist_i_h_wts[6, 15] = -3.71915879182371e-002;

            __statist_i_h_wts[6, 16] = -9.03820680353099e-002;

            __statist_i_h_wts[6, 17] = 6.76105630535680e-003;

            __statist_i_h_wts[6, 18] = 1.91144194902817e-001;

            __statist_i_h_wts[6, 19] = 2.27474495384197e-001;

            __statist_i_h_wts[6, 20] = 2.92379106590232e-002;

            __statist_i_h_wts[6, 21] = 7.52382417168103e-003;

            __statist_i_h_wts[6, 22] = -9.92781925187169e-003;

            __statist_i_h_wts[6, 23] = 1.43124133055462e-001;

            __statist_i_h_wts[6, 24] = -1.55543766729233e-001;

            __statist_i_h_wts[6, 25] = -1.80902452270987e-001;

            __statist_i_h_wts[6, 26] = -1.61353882688870e-001;

            __statist_i_h_wts[6, 27] = -1.21716306131511e-001;

            __statist_i_h_wts[6, 28] = -4.45646423014341e-002;

            __statist_i_h_wts[6, 29] = 2.12635041667432e-001;

            __statist_i_h_wts[6, 30] = 1.93040205989453e-001;

            __statist_i_h_wts[6, 31] = -2.31578205204076e-001;

            __statist_i_h_wts[6, 32] = -1.68480802854214e-001;

            __statist_i_h_wts[6, 33] = -4.80964291321380e-002;

            __statist_i_h_wts[6, 34] = -1.42120282232247e-001;

            __statist_i_h_wts[6, 35] = 9.06799130642993e-002;

            __statist_i_h_wts[6, 36] = -1.59479133825593e-003;

            __statist_i_h_wts[6, 37] = -4.78821628140569e-002;

            __statist_i_h_wts[6, 38] = -1.40484464403471e-002;

            __statist_i_h_wts[6, 39] = -3.19674521789366e-003;

            __statist_i_h_wts[6, 40] = 1.45798586313923e-001;

            __statist_i_h_wts[6, 41] = -2.48500069165160e-001;

            __statist_i_h_wts[6, 42] = -1.38743055126529e-002;

            __statist_i_h_wts[6, 43] = 4.06406596894411e-002;

            __statist_i_h_wts[6, 44] = -2.86756407572073e-001;

            __statist_i_h_wts[6, 45] = -6.11818935511848e-002;

            __statist_i_h_wts[6, 46] = -5.37716551699357e-002;

            __statist_i_h_wts[6, 47] = 6.81073101432353e-003;

            __statist_i_h_wts[6, 48] = 1.12791682281729e-002;

            __statist_i_h_wts[6, 49] = -4.94203818621074e-002;

            __statist_i_h_wts[6, 50] = 6.38498591847971e-002;

            __statist_i_h_wts[6, 51] = 4.95337373553319e-002;

            __statist_i_h_wts[6, 52] = 3.68694100734831e-002;

            __statist_i_h_wts[6, 53] = -8.29312231672655e-002;

            __statist_i_h_wts[6, 54] = 7.90085036261553e-002;

            __statist_i_h_wts[6, 55] = 2.96060084720880e-001;

            __statist_i_h_wts[6, 56] = -3.53106744296407e-002;

            __statist_i_h_wts[6, 57] = -1.29652261954771e-001;

            __statist_i_h_wts[6, 58] = 2.65832597732269e-001;

            __statist_i_h_wts[6, 59] = -4.33486247105022e-002;

            __statist_i_h_wts[6, 60] = -1.23034419703135e-001;

            __statist_i_h_wts[6, 61] = 2.26600072102413e-001;

            __statist_i_h_wts[6, 62] = -2.30818609198529e-001;

            __statist_i_h_wts[6, 63] = -1.09663123110806e-001;

            __statist_i_h_wts[6, 64] = 4.41532089584064e-001;

            __statist_i_h_wts[6, 65] = -5.58219061546201e-002;

            __statist_i_h_wts[6, 66] = 5.75861417849801e-002;

            __statist_i_h_wts[6, 67] = 7.75011750148779e-002;

            __statist_i_h_wts[6, 68] = 1.50819110421676e-001;

            __statist_i_h_wts[6, 69] = 9.94128896536735e-002;

            __statist_i_h_wts[6, 70] = -1.64200896472149e-001;

            __statist_i_h_wts[6, 71] = -8.90201210519746e-002;

            __statist_i_h_wts[6, 72] = -5.97248835642218e-002;

            __statist_i_h_wts[6, 73] = 2.25726374380548e-001;

            __statist_i_h_wts[6, 74] = -1.37747691122757e-001;

            __statist_i_h_wts[6, 75] = -1.20100005133236e-001;

            __statist_i_h_wts[6, 76] = 3.46738250566175e-001;

            __statist_i_h_wts[6, 77] = -2.68897525703719e-001;

            __statist_i_h_wts[6, 78] = -1.90185786725492e-001;

            __statist_i_h_wts[6, 79] = 5.53698311756462e-001;

            __statist_i_h_wts[6, 80] = 2.20960006737561e-001;

            __statist_i_h_wts[6, 81] = 1.67989656149714e-001;

            __statist_i_h_wts[6, 82] = -2.84156801476478e-001;

            __statist_i_h_wts[6, 83] = 1.69249457041377e-001;

            __statist_i_h_wts[6, 84] = 2.25858747060688e-001;

            __statist_i_h_wts[6, 85] = -3.10499963208592e-001;

            __statist_i_h_wts[6, 86] = -2.43209415053018e-001;

            __statist_i_h_wts[6, 87] = -2.75149554683628e-001;

            __statist_i_h_wts[6, 88] = 6.07664017198810e-001;

            __statist_i_h_wts[6, 89] = -3.90689788914435e-001;

            __statist_i_h_wts[6, 90] = -7.62497697905162e-002;

            __statist_i_h_wts[6, 91] = 5.56604425590696e-001;

            __statist_i_h_wts[6, 92] = 1.28581512915889e+000;

            __statist_i_h_wts[6, 93] = 3.09627446869364e-001;

            __statist_i_h_wts[6, 94] = -1.51253523825408e+000;

            __statist_i_h_wts[6, 95] = 3.07807325324328e-001;

            __statist_i_h_wts[6, 96] = 2.64481074986380e-001;

            __statist_i_h_wts[6, 97] = -4.91410209216533e-001;

            __statist_i_h_wts[6, 98] = 3.08964796362405e-002;

            __statist_i_h_wts[6, 99] = -4.37687948397023e-002;

            __statist_i_h_wts[6, 100] = 8.15448939272536e-002;

            __statist_i_h_wts[6, 101] = -1.17713159180544e-001;

            __statist_i_h_wts[6, 102] = -9.75928191270231e-002;

            __statist_i_h_wts[6, 103] = 3.07746814858613e-001;

            __statist_i_h_wts[6, 104] = -3.68554216691474e-001;

            __statist_i_h_wts[6, 105] = -1.29539543800359e-001;

            __statist_i_h_wts[6, 106] = 5.80960024769108e-001;

            __statist_i_h_wts[6, 107] = 1.74113202135143e-001;

            __statist_i_h_wts[6, 108] = 9.65921222975455e-002;

            __statist_i_h_wts[6, 109] = -1.61602140673980e-001;

            __statist_i_h_wts[6, 110] = 2.66838971878192e-001;

            __statist_i_h_wts[6, 111] = 1.81623398879984e-001;

            __statist_i_h_wts[6, 112] = -3.54748272711559e-001;

            __statist_i_h_wts[6, 113] = 3.27234580498733e-002;

            __statist_i_h_wts[6, 114] = -1.24956872405457e-001;

            __statist_i_h_wts[6, 115] = 1.74548741193301e-001;

            __statist_i_h_wts[6, 116] = -5.23297519041697e-004;

            __statist_i_h_wts[6, 117] = -2.06838307286099e-001;

            __statist_i_h_wts[6, 118] = 2.75057830247875e-001;

            __statist_i_h_wts[6, 119] = -6.85684534856738e-002;

            __statist_i_h_wts[6, 120] = 3.49719379209855e-004;

            __statist_i_h_wts[6, 121] = 1.52285197986582e-001;

            __statist_i_h_wts[6, 122] = -5.17872647742008e-002;

            __statist_i_h_wts[6, 123] = 1.56398556270092e-001;

            __statist_i_h_wts[6, 124] = -3.91962146040787e-002;

            __statist_i_h_wts[6, 125] = 9.62371706591941e-002;

            __statist_i_h_wts[6, 126] = 5.13057658767205e-002;

            __statist_i_h_wts[6, 127] = -5.89430764063611e-002;



            __statist_i_h_wts[7, 0] = -2.65206477473655e-003;

            __statist_i_h_wts[7, 1] = 7.17390215403877e-003;

            __statist_i_h_wts[7, 2] = 1.05727137685588e-002;

            __statist_i_h_wts[7, 3] = -8.33438403679601e-002;

            __statist_i_h_wts[7, 4] = -1.83641848455940e-002;

            __statist_i_h_wts[7, 5] = -2.99614271518841e-002;

            __statist_i_h_wts[7, 6] = 6.74904545708294e-002;

            __statist_i_h_wts[7, 7] = -3.04658389387690e-002;

            __statist_i_h_wts[7, 8] = 3.15528598472206e-002;

            __statist_i_h_wts[7, 9] = -4.33161363303830e-002;

            __statist_i_h_wts[7, 10] = -2.58913730436221e-002;

            __statist_i_h_wts[7, 11] = -6.90122703390745e-002;

            __statist_i_h_wts[7, 12] = 1.02276269922963e-001;

            __statist_i_h_wts[7, 13] = -8.55141189300000e-002;

            __statist_i_h_wts[7, 14] = -1.30018756639797e-002;

            __statist_i_h_wts[7, 15] = 4.05259969989926e-002;

            __statist_i_h_wts[7, 16] = 7.15564522130462e-002;

            __statist_i_h_wts[7, 17] = -3.97761283156815e-002;

            __statist_i_h_wts[7, 18] = -1.00453482343279e-002;

            __statist_i_h_wts[7, 19] = -1.05500459557886e-001;

            __statist_i_h_wts[7, 20] = -3.84163830215407e-002;

            __statist_i_h_wts[7, 21] = 4.16416078329334e-002;

            __statist_i_h_wts[7, 22] = -4.96610282903757e-003;

            __statist_i_h_wts[7, 23] = -1.30120711059422e-002;

            __statist_i_h_wts[7, 24] = 5.58340198138684e-002;

            __statist_i_h_wts[7, 25] = 3.10369762781949e-002;

            __statist_i_h_wts[7, 26] = 2.90305236413680e-002;

            __statist_i_h_wts[7, 27] = 6.54237002553672e-003;

            __statist_i_h_wts[7, 28] = -3.28795516343283e-003;

            __statist_i_h_wts[7, 29] = -8.85366276293528e-002;

            __statist_i_h_wts[7, 30] = -1.31089347275621e-001;

            __statist_i_h_wts[7, 31] = 5.53936179185950e-002;

            __statist_i_h_wts[7, 32] = 3.08646977047688e-002;

            __statist_i_h_wts[7, 33] = -3.19904066386197e-003;

            __statist_i_h_wts[7, 34] = 1.04260927616379e-001;

            __statist_i_h_wts[7, 35] = -1.73269993993525e-002;

            __statist_i_h_wts[7, 36] = -5.34738497340880e-003;

            __statist_i_h_wts[7, 37] = 7.06773585064223e-002;

            __statist_i_h_wts[7, 38] = -6.27843010800459e-003;

            __statist_i_h_wts[7, 39] = 7.67204913493436e-002;

            __statist_i_h_wts[7, 40] = -2.26504014811741e-002;

            __statist_i_h_wts[7, 41] = 8.86366020475559e-002;

            __statist_i_h_wts[7, 42] = 3.16714814604738e-001;

            __statist_i_h_wts[7, 43] = 6.32420136145125e-002;

            __statist_i_h_wts[7, 44] = 9.53144113620236e-002;

            __statist_i_h_wts[7, 45] = -2.20466341719683e-002;

            __statist_i_h_wts[7, 46] = 1.84939009795020e-002;

            __statist_i_h_wts[7, 47] = -2.82876816228851e-003;

            __statist_i_h_wts[7, 48] = -1.76336813228347e-002;

            __statist_i_h_wts[7, 49] = 2.69724927231392e-002;

            __statist_i_h_wts[7, 50] = -1.43314632589907e-001;

            __statist_i_h_wts[7, 51] = -6.73147881924779e-002;

            __statist_i_h_wts[7, 52] = -5.59158362836114e-002;

            __statist_i_h_wts[7, 53] = 1.33594273674036e-002;

            __statist_i_h_wts[7, 54] = -5.38049580941867e-002;

            __statist_i_h_wts[7, 55] = -1.13167016377804e-001;

            __statist_i_h_wts[7, 56] = 2.42772262415188e-001;

            __statist_i_h_wts[7, 57] = -2.19745932625719e-002;

            __statist_i_h_wts[7, 58] = -1.50249994415655e-001;

            __statist_i_h_wts[7, 59] = 1.37425511504088e-001;

            __statist_i_h_wts[7, 60] = 9.47724720181253e-002;

            __statist_i_h_wts[7, 61] = -1.48117538333832e-001;

            __statist_i_h_wts[7, 62] = 8.56382837862315e-001;

            __statist_i_h_wts[7, 63] = -5.12150576477414e-001;

            __statist_i_h_wts[7, 64] = -2.54407033911941e-001;

            __statist_i_h_wts[7, 65] = 9.82598826096177e-002;

            __statist_i_h_wts[7, 66] = 1.36346590804044e-002;

            __statist_i_h_wts[7, 67] = -5.23841981382580e-002;

            __statist_i_h_wts[7, 68] = 2.54732094456461e-001;

            __statist_i_h_wts[7, 69] = -3.13089679975039e-001;

            __statist_i_h_wts[7, 70] = 1.20753200031147e-001;

            __statist_i_h_wts[7, 71] = 4.25345913634336e-001;

            __statist_i_h_wts[7, 72] = -2.23104058747731e-001;

            __statist_i_h_wts[7, 73] = -1.26729130834687e-001;

            __statist_i_h_wts[7, 74] = 2.15927553256233e-001;

            __statist_i_h_wts[7, 75] = 1.91257200538528e-002;

            __statist_i_h_wts[7, 76] = -1.69837349083815e-001;

            __statist_i_h_wts[7, 77] = 8.95330975699074e-001;

            __statist_i_h_wts[7, 78] = -4.82615482979795e-001;

            __statist_i_h_wts[7, 79] = -3.36888175780964e-001;

            __statist_i_h_wts[7, 80] = -5.53576250701542e-002;

            __statist_i_h_wts[7, 81] = -4.81213655832621e-002;

            __statist_i_h_wts[7, 82] = 1.80909331032487e-001;

            __statist_i_h_wts[7, 83] = 6.64358114688133e-002;

            __statist_i_h_wts[7, 84] = -1.45167742080476e-001;

            __statist_i_h_wts[7, 85] = 1.77210604137911e-001;

            __statist_i_h_wts[7, 86] = -3.50548262565732e-001;

            __statist_i_h_wts[7, 87] = 6.64172777324324e-001;

            __statist_i_h_wts[7, 88] = -2.72511019578461e-001;

            __statist_i_h_wts[7, 89] = -5.57311901252733e-001;

            __statist_i_h_wts[7, 90] = 9.86026345875330e-001;

            __statist_i_h_wts[7, 91] = -3.29588138798298e-001;

            __statist_i_h_wts[7, 92] = -1.57786292567731e+000;

            __statist_i_h_wts[7, 93] = 6.00377368233605e-001;

            __statist_i_h_wts[7, 94] = 1.05052750561916e+000;

            __statist_i_h_wts[7, 95] = -1.01530989544667e+000;

            __statist_i_h_wts[7, 96] = 4.96759711963538e-001;

            __statist_i_h_wts[7, 97] = 5.81676731080098e-001;

            __statist_i_h_wts[7, 98] = 1.96141933942681e-001;

            __statist_i_h_wts[7, 99] = -6.98788501156724e-002;

            __statist_i_h_wts[7, 100] = -7.06568289875073e-002;

            __statist_i_h_wts[7, 101] = 6.56701797682210e-002;

            __statist_i_h_wts[7, 102] = 7.75399572764980e-002;

            __statist_i_h_wts[7, 103] = -6.05131489639354e-002;

            __statist_i_h_wts[7, 104] = 1.05803781984189e+000;

            __statist_i_h_wts[7, 105] = -6.53541009431611e-001;

            __statist_i_h_wts[7, 106] = -3.16299083077371e-001;

            __statist_i_h_wts[7, 107] = 4.19133112956363e-002;

            __statist_i_h_wts[7, 108] = -1.60579694680899e-001;

            __statist_i_h_wts[7, 109] = 1.96780380061320e-001;

            __statist_i_h_wts[7, 110] = 5.96560374068258e-002;

            __statist_i_h_wts[7, 111] = -2.23775743719725e-001;

            __statist_i_h_wts[7, 112] = 2.33768869727412e-001;

            __statist_i_h_wts[7, 113] = 1.82724467703327e-001;

            __statist_i_h_wts[7, 114] = -2.89314702165300e-002;

            __statist_i_h_wts[7, 115] = -8.89690079486173e-002;

            __statist_i_h_wts[7, 116] = 4.39975309243442e-002;

            __statist_i_h_wts[7, 117] = 1.29301189429641e-001;

            __statist_i_h_wts[7, 118] = -9.76571319048482e-002;

            __statist_i_h_wts[7, 119] = 7.59754331830369e-001;

            __statist_i_h_wts[7, 120] = -4.94300405219748e-001;

            __statist_i_h_wts[7, 121] = -1.85180381731148e-001;

            __statist_i_h_wts[7, 122] = -1.28781806793583e-001;

            __statist_i_h_wts[7, 123] = 1.81501712617323e-001;

            __statist_i_h_wts[7, 124] = 1.58177909062225e-002;

            __statist_i_h_wts[7, 125] = -9.36831596190171e-002;

            __statist_i_h_wts[7, 126] = 4.40934009175272e-002;

            __statist_i_h_wts[7, 127] = 1.02395708440040e-001;



            __statist_i_h_wts[8, 0] = -7.61973084852149e-003;

            __statist_i_h_wts[8, 1] = 1.53940449877010e-002;

            __statist_i_h_wts[8, 2] = 4.29320702915895e-002;

            __statist_i_h_wts[8, 3] = 6.43901639631362e-003;

            __statist_i_h_wts[8, 4] = -3.09303015225705e-003;

            __statist_i_h_wts[8, 5] = -1.32925056470545e-002;

            __statist_i_h_wts[8, 6] = -2.86832348750587e-003;

            __statist_i_h_wts[8, 7] = 1.59194206622734e-002;

            __statist_i_h_wts[8, 8] = 2.66724033748462e-002;

            __statist_i_h_wts[8, 9] = 2.64801895864015e-003;

            __statist_i_h_wts[8, 10] = 2.42053155817565e-002;

            __statist_i_h_wts[8, 11] = 5.46844842807723e-003;

            __statist_i_h_wts[8, 12] = -4.63724203405694e-003;

            __statist_i_h_wts[8, 13] = -9.63190251929424e-003;

            __statist_i_h_wts[8, 14] = -6.14287857317254e-003;

            __statist_i_h_wts[8, 15] = 4.95112690856469e-005;

            __statist_i_h_wts[8, 16] = -4.55509295614590e-002;

            __statist_i_h_wts[8, 17] = 2.31766314397790e-002;

            __statist_i_h_wts[8, 18] = -2.01731028328381e-002;

            __statist_i_h_wts[8, 19] = 1.27245671488593e-003;

            __statist_i_h_wts[8, 20] = -1.16177513886830e-002;

            __statist_i_h_wts[8, 21] = -2.06568958524038e-002;

            __statist_i_h_wts[8, 22] = 1.84600896042166e-002;

            __statist_i_h_wts[8, 23] = 2.72445641586303e-003;

            __statist_i_h_wts[8, 24] = 8.15112619921149e-003;

            __statist_i_h_wts[8, 25] = 4.33008801038130e-002;

            __statist_i_h_wts[8, 26] = 4.99475943365202e-002;

            __statist_i_h_wts[8, 27] = 4.07742442269841e-002;

            __statist_i_h_wts[8, 28] = 2.98775189507872e-002;

            __statist_i_h_wts[8, 29] = -9.43481651095275e-003;

            __statist_i_h_wts[8, 30] = -2.89066799351750e-002;

            __statist_i_h_wts[8, 31] = -1.71977085299131e-002;

            __statist_i_h_wts[8, 32] = 1.65233647066133e-002;

            __statist_i_h_wts[8, 33] = 7.67827720411097e-004;

            __statist_i_h_wts[8, 34] = 1.79548372299422e-005;

            __statist_i_h_wts[8, 35] = -1.81553772182329e-002;

            __statist_i_h_wts[8, 36] = 7.00106481029190e-004;

            __statist_i_h_wts[8, 37] = 1.16329907084032e-002;

            __statist_i_h_wts[8, 38] = 6.41674153649320e-003;

            __statist_i_h_wts[8, 39] = 1.88932124684345e-002;

            __statist_i_h_wts[8, 40] = 2.88335762174437e-002;

            __statist_i_h_wts[8, 41] = 5.13182687797956e-002;

            __statist_i_h_wts[8, 42] = 1.15951736265347e-001;

            __statist_i_h_wts[8, 43] = -1.95027846565491e-002;

            __statist_i_h_wts[8, 44] = 1.91978038585905e-003;

            __statist_i_h_wts[8, 45] = 1.15442633889462e-002;

            __statist_i_h_wts[8, 46] = 1.24623363457912e-003;

            __statist_i_h_wts[8, 47] = -1.59053296850555e-002;

            __statist_i_h_wts[8, 48] = 5.64669885467709e-002;

            __statist_i_h_wts[8, 49] = 6.96632739731527e-002;

            __statist_i_h_wts[8, 50] = -3.80190219211131e-002;

            __statist_i_h_wts[8, 51] = 2.56534723436656e-002;

            __statist_i_h_wts[8, 52] = 5.00454928491987e-002;

            __statist_i_h_wts[8, 53] = -5.35744891590181e-003;

            __statist_i_h_wts[8, 54] = 5.04831252448002e-003;

            __statist_i_h_wts[8, 55] = -6.71277719409321e-002;

            __statist_i_h_wts[8, 56] = 2.89844843919331e-001;

            __statist_i_h_wts[8, 57] = -3.90762493693894e-002;

            __statist_i_h_wts[8, 58] = -3.06683344301447e-002;

            __statist_i_h_wts[8, 59] = 1.89139031758551e-001;

            __statist_i_h_wts[8, 60] = 7.39309709256479e-002;

            __statist_i_h_wts[8, 61] = -1.57809352685143e-002;

            __statist_i_h_wts[8, 62] = 8.29946772290606e-001;

            __statist_i_h_wts[8, 63] = -5.57627685803678e-001;

            __statist_i_h_wts[8, 64] = -4.80843572628185e-002;

            __statist_i_h_wts[8, 65] = 7.33277632386115e-002;

            __statist_i_h_wts[8, 66] = 1.14767925484316e-001;

            __statist_i_h_wts[8, 67] = 1.01099030812073e-001;

            __statist_i_h_wts[8, 68] = 2.80158944236317e-001;

            __statist_i_h_wts[8, 69] = -1.78547906149263e-001;

            __statist_i_h_wts[8, 70] = 1.33883357467870e-001;

            __statist_i_h_wts[8, 71] = 2.78173005556280e-001;

            __statist_i_h_wts[8, 72] = -2.80734845757628e-002;

            __statist_i_h_wts[8, 73] = -1.09640549504284e-002;

            __statist_i_h_wts[8, 74] = 1.70761176820368e-001;

            __statist_i_h_wts[8, 75] = 8.35484012026695e-002;

            __statist_i_h_wts[8, 76] = -2.86761328706327e-002;

            __statist_i_h_wts[8, 77] = 8.44720288872756e-001;

            __statist_i_h_wts[8, 78] = -5.61936110126376e-001;

            __statist_i_h_wts[8, 79] = -8.34564016846843e-002;

            __statist_i_h_wts[8, 80] = -6.43429277747489e-002;

            __statist_i_h_wts[8, 81] = 2.35720546354905e-001;

            __statist_i_h_wts[8, 82] = 9.43856667606534e-002;

            __statist_i_h_wts[8, 83] = 1.56454314890993e-001;

            __statist_i_h_wts[8, 84] = -5.27537635036079e-002;

            __statist_i_h_wts[8, 85] = 9.11426670734538e-002;

            __statist_i_h_wts[8, 86] = -4.72871446943537e-001;

            __statist_i_h_wts[8, 87] = 7.67234750726479e-001;

            __statist_i_h_wts[8, 88] = -6.72894603079530e-002;

            __statist_i_h_wts[8, 89] = -6.39540650552149e-001;

            __statist_i_h_wts[8, 90] = 9.39363851589319e-001;

            __statist_i_h_wts[8, 91] = -5.96008381327777e-002;

            __statist_i_h_wts[8, 92] = -8.48706994661353e-001;

            __statist_i_h_wts[8, 93] = 8.81919744428817e-001;

            __statist_i_h_wts[8, 94] = 2.09036493428353e-001;

            __statist_i_h_wts[8, 95] = -6.28509195618425e-001;

            __statist_i_h_wts[8, 96] = 6.95611771696734e-001;

            __statist_i_h_wts[8, 97] = 1.62751320804927e-001;

            __statist_i_h_wts[8, 98] = 7.40272373734489e-002;

            __statist_i_h_wts[8, 99] = 1.75744755796288e-001;

            __statist_i_h_wts[8, 100] = -2.13315837935574e-002;

            __statist_i_h_wts[8, 101] = 6.71378136617242e-002;

            __statist_i_h_wts[8, 102] = 1.98600214049062e-001;

            __statist_i_h_wts[8, 103] = -1.61061250966807e-002;

            __statist_i_h_wts[8, 104] = 8.03580841284123e-001;

            __statist_i_h_wts[8, 105] = -5.30891590364027e-001;

            __statist_i_h_wts[8, 106] = -5.82006171014302e-002;

            __statist_i_h_wts[8, 107] = -7.10638728492993e-002;

            __statist_i_h_wts[8, 108] = 2.71768929143392e-001;

            __statist_i_h_wts[8, 109] = 3.40820156299330e-002;

            __statist_i_h_wts[8, 110] = 1.59080654326819e-001;

            __statist_i_h_wts[8, 111] = -2.54801049972761e-007;

            __statist_i_h_wts[8, 112] = 6.99173933222510e-002;

            __statist_i_h_wts[8, 113] = 4.86412512187192e-003;

            __statist_i_h_wts[8, 114] = 2.36871711584361e-001;

            __statist_i_h_wts[8, 115] = 4.65799060789044e-003;

            __statist_i_h_wts[8, 116] = 1.99857394673436e-002;

            __statist_i_h_wts[8, 117] = 1.91345233270671e-001;

            __statist_i_h_wts[8, 118] = 1.21612539518292e-002;

            __statist_i_h_wts[8, 119] = 6.40593339249001e-001;

            __statist_i_h_wts[8, 120] = -4.02388351522243e-001;

            __statist_i_h_wts[8, 121] = -8.91151177993511e-003;

            __statist_i_h_wts[8, 122] = -1.77782822832189e-001;

            __statist_i_h_wts[8, 123] = 4.14792887961777e-001;

            __statist_i_h_wts[8, 124] = -2.29721624552787e-002;

            __statist_i_h_wts[8, 125] = -1.81165857234612e-003;

            __statist_i_h_wts[8, 126] = 1.56519267163575e-001;

            __statist_i_h_wts[8, 127] = 1.02112008951858e-001;



            double[,] __statist_h_o_wts = new double[2, 9];



            __statist_h_o_wts[0, 0] = 7.33729036823640e-001;

            __statist_h_o_wts[0, 1] = -4.21144078714249e-001;

            __statist_h_o_wts[0, 2] = -6.50459291502674e-001;

            __statist_h_o_wts[0, 3] = 6.30819571710947e-001;

            __statist_h_o_wts[0, 4] = 1.07545720696626e+000;

            __statist_h_o_wts[0, 5] = 2.87437123904891e-002;

            __statist_h_o_wts[0, 6] = 1.96463396337655e+000;

            __statist_h_o_wts[0, 7] = -6.35945218492725e-001;

            __statist_h_o_wts[0, 8] = 7.43743889492041e-001;



            __statist_h_o_wts[1, 0] = -7.51249325644955e-001;

            __statist_h_o_wts[1, 1] = 4.49175015710348e-001;

            __statist_h_o_wts[1, 2] = 6.23437969313283e-001;

            __statist_h_o_wts[1, 3] = -7.04065316326343e-001;

            __statist_h_o_wts[1, 4] = -1.11771358088892e+000;

            __statist_h_o_wts[1, 5] = -4.22137677909848e-002;

            __statist_h_o_wts[1, 6] = -1.99145701052749e+000;

            __statist_h_o_wts[1, 7] = 6.79913185646152e-001;

            __statist_h_o_wts[1, 8] = -6.72940980155154e-001;



            double[] __statist_hidden_bias = new double[9];

            __statist_hidden_bias[0] = 2.33818415986603e-002;

            __statist_hidden_bias[1] = 4.38657306512755e-002;

            __statist_hidden_bias[2] = -7.57051380641348e-002;

            __statist_hidden_bias[3] = 1.19594344285314e-002;

            __statist_hidden_bias[4] = -1.82434341870355e-001;

            __statist_hidden_bias[5] = 2.64527686912325e-001;

            __statist_hidden_bias[6] = 7.65393021783563e-002;

            __statist_hidden_bias[7] = 7.79683162043457e-002;

            __statist_hidden_bias[8] = 2.35691260779891e-001;



            double[] __statist_output_bias = new double[2];

            __statist_output_bias[0] = 1.50546878113307e+000;

            __statist_output_bias[1] = -1.53509620714670e+000;



            double[] __statist_inputs = new double[128];



            double[] __statist_hidden = new double[9];



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

            int __statist_nhidden = 9;



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

            return MLP_128_9_2(CatInputs);

        }
    }
}
