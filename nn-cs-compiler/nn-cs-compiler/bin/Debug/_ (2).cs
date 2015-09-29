/**C# deployment code of Neural Networks Model**/

/**==========================================================================
Before running the C# deployment code please read the following.

 STATISTICA variable names will be exported as-is into the C# deployment script;
please verify the resulting script to ensure that the variable names follow the C#
naming conventions and modify the names if necessary.

==========================================================================**/

using System;


public class Predict24925285_право
{
   public static string[] foo( double[] ContInputs )
   {
     //"Input Variable" comment is added besides Input(Response) variables.

     int Cont_idx=0;
     double Var7 = ContInputs[Cont_idx++]; //Input Variable
     double Var8 = ContInputs[Cont_idx++]; //Input Variable
     double Var9 = ContInputs[Cont_idx++]; //Input Variable
     double Var10 = ContInputs[Cont_idx++]; //Input Variable
     double Var11 = ContInputs[Cont_idx++]; //Input Variable
     double Var12 = ContInputs[Cont_idx++]; //Input Variable
     double Var13 = ContInputs[Cont_idx++]; //Input Variable
     double Var14 = ContInputs[Cont_idx++]; //Input Variable
     double Var15 = ContInputs[Cont_idx++]; //Input Variable
     double Var16 = ContInputs[Cont_idx++]; //Input Variable
     double Var17 = ContInputs[Cont_idx++]; //Input Variable
     double Var18 = ContInputs[Cont_idx++]; //Input Variable
     double Var19 = ContInputs[Cont_idx++]; //Input Variable
     double Var20 = ContInputs[Cont_idx++]; //Input Variable
     double Var21 = ContInputs[Cont_idx++]; //Input Variable
     double Var22 = ContInputs[Cont_idx++]; //Input Variable
     double Var23 = ContInputs[Cont_idx++]; //Input Variable
     double Var24 = ContInputs[Cont_idx++]; //Input Variable
     double Var25 = ContInputs[Cont_idx++]; //Input Variable
     double Var26 = ContInputs[Cont_idx++]; //Input Variable
     double Var27 = ContInputs[Cont_idx++]; //Input Variable
     double Var28 = ContInputs[Cont_idx++]; //Input Variable
     double Var29 = ContInputs[Cont_idx++]; //Input Variable
     double Var30 = ContInputs[Cont_idx++]; //Input Variable
     double Var31 = ContInputs[Cont_idx++]; //Input Variable
     double Var32 = ContInputs[Cont_idx++]; //Input Variable
     double Var33 = ContInputs[Cont_idx++]; //Input Variable
     double Var34 = ContInputs[Cont_idx++]; //Input Variable
     double Var35 = ContInputs[Cont_idx++]; //Input Variable
     double Var36 = ContInputs[Cont_idx++]; //Input Variable
     double Var37 = ContInputs[Cont_idx++]; //Input Variable
     double Var38 = ContInputs[Cont_idx++]; //Input Variable
     double Var39 = ContInputs[Cont_idx++]; //Input Variable
     double Var40 = ContInputs[Cont_idx++]; //Input Variable
     double Var41 = ContInputs[Cont_idx++]; //Input Variable
     double Var42 = ContInputs[Cont_idx++]; //Input Variable
     double Var43 = ContInputs[Cont_idx++]; //Input Variable
     double Var44 = ContInputs[Cont_idx++]; //Input Variable
     double Var45 = ContInputs[Cont_idx++]; //Input Variable
     double Var46 = ContInputs[Cont_idx++]; //Input Variable
     double Var47 = ContInputs[Cont_idx++]; //Input Variable
     double Var48 = ContInputs[Cont_idx++]; //Input Variable
     double Var49 = ContInputs[Cont_idx++]; //Input Variable
     double Var50 = ContInputs[Cont_idx++]; //Input Variable
     double Var51 = ContInputs[Cont_idx++]; //Input Variable
     double Var52 = ContInputs[Cont_idx++]; //Input Variable
     double Var53 = ContInputs[Cont_idx++]; //Input Variable
     double Var54 = ContInputs[Cont_idx++]; //Input Variable
     double Var55 = ContInputs[Cont_idx++]; //Input Variable
     double Var56 = ContInputs[Cont_idx++]; //Input Variable
     double Var57 = ContInputs[Cont_idx++]; //Input Variable
     double Var58 = ContInputs[Cont_idx++]; //Input Variable
     double Var59 = ContInputs[Cont_idx++]; //Input Variable
     double Var60 = ContInputs[Cont_idx++]; //Input Variable
     double Var61 = ContInputs[Cont_idx++]; //Input Variable
     double Var62 = ContInputs[Cont_idx++]; //Input Variable
     double Var63 = ContInputs[Cont_idx++]; //Input Variable
     double Var64 = ContInputs[Cont_idx++]; //Input Variable
     double Var65 = ContInputs[Cont_idx++]; //Input Variable
     double Var66 = ContInputs[Cont_idx++]; //Input Variable
     double Var67 = ContInputs[Cont_idx++]; //Input Variable
     double Var68 = ContInputs[Cont_idx++]; //Input Variable
     double Var69 = ContInputs[Cont_idx++]; //Input Variable
     double Var70 = ContInputs[Cont_idx++]; //Input Variable
     double Var71 = ContInputs[Cont_idx++]; //Input Variable
     double Var72 = ContInputs[Cont_idx++]; //Input Variable
     double Var73 = ContInputs[Cont_idx++]; //Input Variable
     double Var74 = ContInputs[Cont_idx++]; //Input Variable
     double Var75 = ContInputs[Cont_idx++]; //Input Variable
     double Var76 = ContInputs[Cont_idx++]; //Input Variable
     double Var77 = ContInputs[Cont_idx++]; //Input Variable
     double Var78 = ContInputs[Cont_idx++]; //Input Variable
     double Var79 = ContInputs[Cont_idx++]; //Input Variable
     double Var80 = ContInputs[Cont_idx++]; //Input Variable
     double Var81 = ContInputs[Cont_idx++]; //Input Variable
     double Var82 = ContInputs[Cont_idx++]; //Input Variable
     double Var83 = ContInputs[Cont_idx++]; //Input Variable
     double Var84 = ContInputs[Cont_idx++]; //Input Variable
     double Var85 = ContInputs[Cont_idx++]; //Input Variable
     double Var86 = ContInputs[Cont_idx++]; //Input Variable
     double Var87 = ContInputs[Cont_idx++]; //Input Variable
     double Var88 = ContInputs[Cont_idx++]; //Input Variable
     double Var89 = ContInputs[Cont_idx++]; //Input Variable
     double Var90 = ContInputs[Cont_idx++]; //Input Variable
     double Var91 = ContInputs[Cont_idx++]; //Input Variable
     double Var92 = ContInputs[Cont_idx++]; //Input Variable
     double Var93 = ContInputs[Cont_idx++]; //Input Variable
     double Var94 = ContInputs[Cont_idx++]; //Input Variable
     double Var95 = ContInputs[Cont_idx++]; //Input Variable
     double Var96 = ContInputs[Cont_idx++]; //Input Variable
     double Var97 = ContInputs[Cont_idx++]; //Input Variable
     double Var98 = ContInputs[Cont_idx++]; //Input Variable
     double Var99 = ContInputs[Cont_idx++]; //Input Variable
     double Var100 = ContInputs[Cont_idx++]; //Input Variable
     double Var101 = ContInputs[Cont_idx++]; //Input Variable
     double Var102 = ContInputs[Cont_idx++]; //Input Variable
     double Var103 = ContInputs[Cont_idx++]; //Input Variable
     double Var104 = ContInputs[Cont_idx++]; //Input Variable
     double Var105 = ContInputs[Cont_idx++]; //Input Variable
     double Var106 = ContInputs[Cont_idx++]; //Input Variable
     double Var107 = ContInputs[Cont_idx++]; //Input Variable
     double Var108 = ContInputs[Cont_idx++]; //Input Variable
     double Var109 = ContInputs[Cont_idx++]; //Input Variable
     double Var110 = ContInputs[Cont_idx++]; //Input Variable
     double Var111 = ContInputs[Cont_idx++]; //Input Variable
     double Var112 = ContInputs[Cont_idx++]; //Input Variable
     double Var113 = ContInputs[Cont_idx++]; //Input Variable
     double Var114 = ContInputs[Cont_idx++]; //Input Variable
     double Var115 = ContInputs[Cont_idx++]; //Input Variable
     double Var116 = ContInputs[Cont_idx++]; //Input Variable
     double Var117 = ContInputs[Cont_idx++]; //Input Variable
     double Var118 = ContInputs[Cont_idx++]; //Input Variable
     double Var119 = ContInputs[Cont_idx++]; //Input Variable
     double Var120 = ContInputs[Cont_idx++]; //Input Variable
     double Var121 = ContInputs[Cont_idx++]; //Input Variable
     double Var122 = ContInputs[Cont_idx++]; //Input Variable
     double Var123 = ContInputs[Cont_idx++]; //Input Variable
     double Var124 = ContInputs[Cont_idx++]; //Input Variable
     double Var125 = ContInputs[Cont_idx++]; //Input Variable
     double Var126 = ContInputs[Cont_idx++]; //Input Variable
     double Var127 = ContInputs[Cont_idx++]; //Input Variable
     double Var128 = ContInputs[Cont_idx++]; //Input Variable
     double Var129 = ContInputs[Cont_idx++]; //Input Variable
     double Var130 = ContInputs[Cont_idx++]; //Input Variable
     double Var131 = ContInputs[Cont_idx++]; //Input Variable
     double Var132 = ContInputs[Cont_idx++]; //Input Variable
     double Var133 = ContInputs[Cont_idx++]; //Input Variable
     double Var134 = ContInputs[Cont_idx++]; //Input Variable
     double Var135 = ContInputs[Cont_idx++]; //Input Variable
     double Var136 = ContInputs[Cont_idx++]; //Input Variable
     double Var137 = ContInputs[Cont_idx++]; //Input Variable
     double Var138 = ContInputs[Cont_idx++]; //Input Variable
     double Var139 = ContInputs[Cont_idx++]; //Input Variable
     double Var140 = ContInputs[Cont_idx++]; //Input Variable
     double Var141 = ContInputs[Cont_idx++]; //Input Variable
     double Var142 = ContInputs[Cont_idx++]; //Input Variable
     double Var143 = ContInputs[Cont_idx++]; //Input Variable
     double Var144 = ContInputs[Cont_idx++]; //Input Variable
     double Var145 = ContInputs[Cont_idx++]; //Input Variable
     double Var146 = ContInputs[Cont_idx++]; //Input Variable
     double Var147 = ContInputs[Cont_idx++]; //Input Variable
     double Var148 = ContInputs[Cont_idx++]; //Input Variable
     double Var149 = ContInputs[Cont_idx++]; //Input Variable
     double Var150 = ContInputs[Cont_idx++]; //Input Variable
     double Var151 = ContInputs[Cont_idx++]; //Input Variable
     double Var152 = ContInputs[Cont_idx++]; //Input Variable
     double Var153 = ContInputs[Cont_idx++]; //Input Variable
     double Var154 = ContInputs[Cont_idx++]; //Input Variable
     double Var155 = ContInputs[Cont_idx++]; //Input Variable
     double Var156 = ContInputs[Cont_idx++]; //Input Variable
     double Var157 = ContInputs[Cont_idx++]; //Input Variable
     double Var158 = ContInputs[Cont_idx++]; //Input Variable
     double Var159 = ContInputs[Cont_idx++]; //Input Variable
     double Var160 = ContInputs[Cont_idx++]; //Input Variable
     double Var161 = ContInputs[Cont_idx++]; //Input Variable
     double Var162 = ContInputs[Cont_idx++]; //Input Variable
     double Var163 = ContInputs[Cont_idx++]; //Input Variable
     double Var164 = ContInputs[Cont_idx++]; //Input Variable
     double Var165 = ContInputs[Cont_idx++]; //Input Variable
     double Var166 = ContInputs[Cont_idx++]; //Input Variable
     double Var167 = ContInputs[Cont_idx++]; //Input Variable
     double Var168 = ContInputs[Cont_idx++]; //Input Variable
     double Var169 = ContInputs[Cont_idx++]; //Input Variable
     double Var170 = ContInputs[Cont_idx++]; //Input Variable
     double Var171 = ContInputs[Cont_idx++]; //Input Variable
     double Var172 = ContInputs[Cont_idx++]; //Input Variable
     double Var173 = ContInputs[Cont_idx++]; //Input Variable
     double Var174 = ContInputs[Cont_idx++]; //Input Variable
     double Var175 = ContInputs[Cont_idx++]; //Input Variable
     double Var176 = ContInputs[Cont_idx++]; //Input Variable
     double Var177 = ContInputs[Cont_idx++]; //Input Variable
     double Var178 = ContInputs[Cont_idx++]; //Input Variable
     double Var179 = ContInputs[Cont_idx++]; //Input Variable
     double Var180 = ContInputs[Cont_idx++]; //Input Variable
     double Var181 = ContInputs[Cont_idx++]; //Input Variable
     double Var182 = ContInputs[Cont_idx++]; //Input Variable
     double Var183 = ContInputs[Cont_idx++]; //Input Variable
     double Var184 = ContInputs[Cont_idx++]; //Input Variable
     double Var185 = ContInputs[Cont_idx++]; //Input Variable
     double Var186 = ContInputs[Cont_idx++]; //Input Variable
     double Var187 = ContInputs[Cont_idx++]; //Input Variable
     double Var188 = ContInputs[Cont_idx++]; //Input Variable
     double Var189 = ContInputs[Cont_idx++]; //Input Variable
     double Var190 = ContInputs[Cont_idx++]; //Input Variable
     double Var191 = ContInputs[Cont_idx++]; //Input Variable
     double Var192 = ContInputs[Cont_idx++]; //Input Variable
     double Var193 = ContInputs[Cont_idx++]; //Input Variable
     double Var194 = ContInputs[Cont_idx++]; //Input Variable
     double Var195 = ContInputs[Cont_idx++]; //Input Variable
     double Var196 = ContInputs[Cont_idx++]; //Input Variable
     double Var197 = ContInputs[Cont_idx++]; //Input Variable
     double Var198 = ContInputs[Cont_idx++]; //Input Variable
     double Var199 = ContInputs[Cont_idx++]; //Input Variable
     double Var200 = ContInputs[Cont_idx++]; //Input Variable
     double Var201 = ContInputs[Cont_idx++]; //Input Variable
     double Var202 = ContInputs[Cont_idx++]; //Input Variable
     double Var203 = ContInputs[Cont_idx++]; //Input Variable
     double Var204 = ContInputs[Cont_idx++]; //Input Variable
     double Var205 = ContInputs[Cont_idx++]; //Input Variable
     double Var206 = ContInputs[Cont_idx++]; //Input Variable
     double Var207 = ContInputs[Cont_idx++]; //Input Variable
     double Var208 = ContInputs[Cont_idx++]; //Input Variable
     double Var209 = ContInputs[Cont_idx++]; //Input Variable
     double Var210 = ContInputs[Cont_idx++]; //Input Variable
     double Var211 = ContInputs[Cont_idx++]; //Input Variable
     double Var212 = ContInputs[Cont_idx++]; //Input Variable
     double Var213 = ContInputs[Cont_idx++]; //Input Variable
     double Var214 = ContInputs[Cont_idx++]; //Input Variable
     double Var215 = ContInputs[Cont_idx++]; //Input Variable
     double Var216 = ContInputs[Cont_idx++]; //Input Variable
     double Var217 = ContInputs[Cont_idx++]; //Input Variable
     double Var218 = ContInputs[Cont_idx++]; //Input Variable
     double Var219 = ContInputs[Cont_idx++]; //Input Variable
     double Var220 = ContInputs[Cont_idx++]; //Input Variable
     double Var221 = ContInputs[Cont_idx++]; //Input Variable
     double Var222 = ContInputs[Cont_idx++]; //Input Variable
     double Var223 = ContInputs[Cont_idx++]; //Input Variable
     double Var224 = ContInputs[Cont_idx++]; //Input Variable
     double Var225 = ContInputs[Cont_idx++]; //Input Variable
     double Var226 = ContInputs[Cont_idx++]; //Input Variable
     double Var227 = ContInputs[Cont_idx++]; //Input Variable
     double Var228 = ContInputs[Cont_idx++]; //Input Variable
     double Var229 = ContInputs[Cont_idx++]; //Input Variable
     double Var230 = ContInputs[Cont_idx++]; //Input Variable
     double Var231 = ContInputs[Cont_idx++]; //Input Variable
     double Var232 = ContInputs[Cont_idx++]; //Input Variable
     double Var233 = ContInputs[Cont_idx++]; //Input Variable
     double Var234 = ContInputs[Cont_idx++]; //Input Variable
     double Var235 = ContInputs[Cont_idx++]; //Input Variable
     double Var236 = ContInputs[Cont_idx++]; //Input Variable
     double Var237 = ContInputs[Cont_idx++]; //Input Variable
     double Var238 = ContInputs[Cont_idx++]; //Input Variable
     double Var239 = ContInputs[Cont_idx++]; //Input Variable
     double Var240 = ContInputs[Cont_idx++]; //Input Variable
     double Var241 = ContInputs[Cont_idx++]; //Input Variable
     double Var242 = ContInputs[Cont_idx++]; //Input Variable
     double Var243 = ContInputs[Cont_idx++]; //Input Variable
     double Var245 = ContInputs[Cont_idx++]; //Input Variable
     double Var246 = ContInputs[Cont_idx++]; //Input Variable
     double Var247 = ContInputs[Cont_idx++]; //Input Variable
     double Var248 = ContInputs[Cont_idx++]; //Input Variable
     double Var249 = ContInputs[Cont_idx++]; //Input Variable
     double Var250 = ContInputs[Cont_idx++]; //Input Variable
     double Var251 = ContInputs[Cont_idx++]; //Input Variable
     double Var252 = ContInputs[Cont_idx++]; //Input Variable
     double Var253 = ContInputs[Cont_idx++]; //Input Variable
     double Var254 = ContInputs[Cont_idx++]; //Input Variable
     double Var255 = ContInputs[Cont_idx++]; //Input Variable
     double Var256 = ContInputs[Cont_idx++]; //Input Variable
     string __statist_PredCat="";
    string [] __statist_DCats = new string[2];
    __statist_DCats[0]= "0";
    __statist_DCats[1]= "2";

    double __statist_ConfLevel=3.0E-300;

    double[] __statist_max_input = new double[249];
    __statist_max_input[0]= 8.00000000000000e+000;
    __statist_max_input[1]= 8.00000000000000e+000;
    __statist_max_input[2]= 8.00000000000000e+000;
    __statist_max_input[3]= 8.00000000000000e+000;
    __statist_max_input[4]= 8.00000000000000e+000;
    __statist_max_input[5]= 8.00000000000000e+000;
    __statist_max_input[6]= 8.00000000000000e+000;
    __statist_max_input[7]= 8.00000000000000e+000;
    __statist_max_input[8]= 8.00000000000000e+000;
    __statist_max_input[9]= 8.00000000000000e+000;
    __statist_max_input[10]= 8.00000000000000e+000;
    __statist_max_input[11]= 8.00000000000000e+000;
    __statist_max_input[12]= 8.00000000000000e+000;
    __statist_max_input[13]= 8.00000000000000e+000;
    __statist_max_input[14]= 8.00000000000000e+000;
    __statist_max_input[15]= 8.00000000000000e+000;
    __statist_max_input[16]= 8.00000000000000e+000;
    __statist_max_input[17]= 8.00000000000000e+000;
    __statist_max_input[18]= 8.00000000000000e+000;
    __statist_max_input[19]= 8.00000000000000e+000;
    __statist_max_input[20]= 8.00000000000000e+000;
    __statist_max_input[21]= 8.00000000000000e+000;
    __statist_max_input[22]= 8.00000000000000e+000;
    __statist_max_input[23]= 8.00000000000000e+000;
    __statist_max_input[24]= 8.00000000000000e+000;
    __statist_max_input[25]= 8.00000000000000e+000;
    __statist_max_input[26]= 8.00000000000000e+000;
    __statist_max_input[27]= 8.00000000000000e+000;
    __statist_max_input[28]= 8.00000000000000e+000;
    __statist_max_input[29]= 8.00000000000000e+000;
    __statist_max_input[30]= 8.00000000000000e+000;
    __statist_max_input[31]= 8.00000000000000e+000;
    __statist_max_input[32]= 8.00000000000000e+000;
    __statist_max_input[33]= 8.00000000000000e+000;
    __statist_max_input[34]= 8.00000000000000e+000;
    __statist_max_input[35]= 8.00000000000000e+000;
    __statist_max_input[36]= 8.00000000000000e+000;
    __statist_max_input[37]= 8.00000000000000e+000;
    __statist_max_input[38]= 8.00000000000000e+000;
    __statist_max_input[39]= 8.00000000000000e+000;
    __statist_max_input[40]= 8.00000000000000e+000;
    __statist_max_input[41]= 8.00000000000000e+000;
    __statist_max_input[42]= 8.00000000000000e+000;
    __statist_max_input[43]= 8.00000000000000e+000;
    __statist_max_input[44]= 8.00000000000000e+000;
    __statist_max_input[45]= 8.00000000000000e+000;
    __statist_max_input[46]= 8.00000000000000e+000;
    __statist_max_input[47]= 8.00000000000000e+000;
    __statist_max_input[48]= 8.00000000000000e+000;
    __statist_max_input[49]= 8.00000000000000e+000;
    __statist_max_input[50]= 8.00000000000000e+000;
    __statist_max_input[51]= 8.00000000000000e+000;
    __statist_max_input[52]= 8.00000000000000e+000;
    __statist_max_input[53]= 8.00000000000000e+000;
    __statist_max_input[54]= 8.00000000000000e+000;
    __statist_max_input[55]= 8.00000000000000e+000;
    __statist_max_input[56]= 8.00000000000000e+000;
    __statist_max_input[57]= 8.00000000000000e+000;
    __statist_max_input[58]= 8.00000000000000e+000;
    __statist_max_input[59]= 8.00000000000000e+000;
    __statist_max_input[60]= 8.00000000000000e+000;
    __statist_max_input[61]= 8.00000000000000e+000;
    __statist_max_input[62]= 8.00000000000000e+000;
    __statist_max_input[63]= 8.00000000000000e+000;
    __statist_max_input[64]= 8.00000000000000e+000;
    __statist_max_input[65]= 8.00000000000000e+000;
    __statist_max_input[66]= 8.00000000000000e+000;
    __statist_max_input[67]= 8.00000000000000e+000;
    __statist_max_input[68]= 8.00000000000000e+000;
    __statist_max_input[69]= 8.00000000000000e+000;
    __statist_max_input[70]= 8.00000000000000e+000;
    __statist_max_input[71]= 8.00000000000000e+000;
    __statist_max_input[72]= 8.00000000000000e+000;
    __statist_max_input[73]= 8.00000000000000e+000;
    __statist_max_input[74]= 8.00000000000000e+000;
    __statist_max_input[75]= 8.00000000000000e+000;
    __statist_max_input[76]= 8.00000000000000e+000;
    __statist_max_input[77]= 8.00000000000000e+000;
    __statist_max_input[78]= 8.00000000000000e+000;
    __statist_max_input[79]= 8.00000000000000e+000;
    __statist_max_input[80]= 8.00000000000000e+000;
    __statist_max_input[81]= 8.00000000000000e+000;
    __statist_max_input[82]= 8.00000000000000e+000;
    __statist_max_input[83]= 8.00000000000000e+000;
    __statist_max_input[84]= 8.00000000000000e+000;
    __statist_max_input[85]= 8.00000000000000e+000;
    __statist_max_input[86]= 8.00000000000000e+000;
    __statist_max_input[87]= 8.00000000000000e+000;
    __statist_max_input[88]= 8.00000000000000e+000;
    __statist_max_input[89]= 8.00000000000000e+000;
    __statist_max_input[90]= 8.00000000000000e+000;
    __statist_max_input[91]= 8.00000000000000e+000;
    __statist_max_input[92]= 8.00000000000000e+000;
    __statist_max_input[93]= 8.00000000000000e+000;
    __statist_max_input[94]= 8.00000000000000e+000;
    __statist_max_input[95]= 8.00000000000000e+000;
    __statist_max_input[96]= 8.00000000000000e+000;
    __statist_max_input[97]= 8.00000000000000e+000;
    __statist_max_input[98]= 8.00000000000000e+000;
    __statist_max_input[99]= 8.00000000000000e+000;
    __statist_max_input[100]= 8.00000000000000e+000;
    __statist_max_input[101]= 8.00000000000000e+000;
    __statist_max_input[102]= 8.00000000000000e+000;
    __statist_max_input[103]= 8.00000000000000e+000;
    __statist_max_input[104]= 8.00000000000000e+000;
    __statist_max_input[105]= 8.00000000000000e+000;
    __statist_max_input[106]= 8.00000000000000e+000;
    __statist_max_input[107]= 8.00000000000000e+000;
    __statist_max_input[108]= 8.00000000000000e+000;
    __statist_max_input[109]= 8.00000000000000e+000;
    __statist_max_input[110]= 8.00000000000000e+000;
    __statist_max_input[111]= 8.00000000000000e+000;
    __statist_max_input[112]= 8.00000000000000e+000;
    __statist_max_input[113]= 8.00000000000000e+000;
    __statist_max_input[114]= 8.00000000000000e+000;
    __statist_max_input[115]= 8.00000000000000e+000;
    __statist_max_input[116]= 8.00000000000000e+000;
    __statist_max_input[117]= 8.00000000000000e+000;
    __statist_max_input[118]= 8.00000000000000e+000;
    __statist_max_input[119]= 8.00000000000000e+000;
    __statist_max_input[120]= 8.00000000000000e+000;
    __statist_max_input[121]= 8.00000000000000e+000;
    __statist_max_input[122]= 8.00000000000000e+000;
    __statist_max_input[123]= 8.00000000000000e+000;
    __statist_max_input[124]= 8.00000000000000e+000;
    __statist_max_input[125]= 8.00000000000000e+000;
    __statist_max_input[126]= 8.00000000000000e+000;
    __statist_max_input[127]= 8.00000000000000e+000;
    __statist_max_input[128]= 8.00000000000000e+000;
    __statist_max_input[129]= 8.00000000000000e+000;
    __statist_max_input[130]= 8.00000000000000e+000;
    __statist_max_input[131]= 8.00000000000000e+000;
    __statist_max_input[132]= 8.00000000000000e+000;
    __statist_max_input[133]= 8.00000000000000e+000;
    __statist_max_input[134]= 8.00000000000000e+000;
    __statist_max_input[135]= 8.00000000000000e+000;
    __statist_max_input[136]= 8.00000000000000e+000;
    __statist_max_input[137]= 8.00000000000000e+000;
    __statist_max_input[138]= 8.00000000000000e+000;
    __statist_max_input[139]= 8.00000000000000e+000;
    __statist_max_input[140]= 8.00000000000000e+000;
    __statist_max_input[141]= 8.00000000000000e+000;
    __statist_max_input[142]= 8.00000000000000e+000;
    __statist_max_input[143]= 8.00000000000000e+000;
    __statist_max_input[144]= 8.00000000000000e+000;
    __statist_max_input[145]= 8.00000000000000e+000;
    __statist_max_input[146]= 8.00000000000000e+000;
    __statist_max_input[147]= 8.00000000000000e+000;
    __statist_max_input[148]= 8.00000000000000e+000;
    __statist_max_input[149]= 8.00000000000000e+000;
    __statist_max_input[150]= 8.00000000000000e+000;
    __statist_max_input[151]= 8.00000000000000e+000;
    __statist_max_input[152]= 8.00000000000000e+000;
    __statist_max_input[153]= 8.00000000000000e+000;
    __statist_max_input[154]= 8.00000000000000e+000;
    __statist_max_input[155]= 8.00000000000000e+000;
    __statist_max_input[156]= 8.00000000000000e+000;
    __statist_max_input[157]= 8.00000000000000e+000;
    __statist_max_input[158]= 8.00000000000000e+000;
    __statist_max_input[159]= 8.00000000000000e+000;
    __statist_max_input[160]= 8.00000000000000e+000;
    __statist_max_input[161]= 8.00000000000000e+000;
    __statist_max_input[162]= 8.00000000000000e+000;
    __statist_max_input[163]= 8.00000000000000e+000;
    __statist_max_input[164]= 8.00000000000000e+000;
    __statist_max_input[165]= 8.00000000000000e+000;
    __statist_max_input[166]= 8.00000000000000e+000;
    __statist_max_input[167]= 8.00000000000000e+000;
    __statist_max_input[168]= 8.00000000000000e+000;
    __statist_max_input[169]= 8.00000000000000e+000;
    __statist_max_input[170]= 8.00000000000000e+000;
    __statist_max_input[171]= 8.00000000000000e+000;
    __statist_max_input[172]= 8.00000000000000e+000;
    __statist_max_input[173]= 8.00000000000000e+000;
    __statist_max_input[174]= 8.00000000000000e+000;
    __statist_max_input[175]= 8.00000000000000e+000;
    __statist_max_input[176]= 8.00000000000000e+000;
    __statist_max_input[177]= 8.00000000000000e+000;
    __statist_max_input[178]= 8.00000000000000e+000;
    __statist_max_input[179]= 8.00000000000000e+000;
    __statist_max_input[180]= 8.00000000000000e+000;
    __statist_max_input[181]= 8.00000000000000e+000;
    __statist_max_input[182]= 8.00000000000000e+000;
    __statist_max_input[183]= 8.00000000000000e+000;
    __statist_max_input[184]= 8.00000000000000e+000;
    __statist_max_input[185]= 8.00000000000000e+000;
    __statist_max_input[186]= 8.00000000000000e+000;
    __statist_max_input[187]= 8.00000000000000e+000;
    __statist_max_input[188]= 8.00000000000000e+000;
    __statist_max_input[189]= 8.00000000000000e+000;
    __statist_max_input[190]= 8.00000000000000e+000;
    __statist_max_input[191]= 8.00000000000000e+000;
    __statist_max_input[192]= 8.00000000000000e+000;
    __statist_max_input[193]= 8.00000000000000e+000;
    __statist_max_input[194]= 8.00000000000000e+000;
    __statist_max_input[195]= 8.00000000000000e+000;
    __statist_max_input[196]= 8.00000000000000e+000;
    __statist_max_input[197]= 8.00000000000000e+000;
    __statist_max_input[198]= 8.00000000000000e+000;
    __statist_max_input[199]= 8.00000000000000e+000;
    __statist_max_input[200]= 8.00000000000000e+000;
    __statist_max_input[201]= 8.00000000000000e+000;
    __statist_max_input[202]= 8.00000000000000e+000;
    __statist_max_input[203]= 8.00000000000000e+000;
    __statist_max_input[204]= 8.00000000000000e+000;
    __statist_max_input[205]= 8.00000000000000e+000;
    __statist_max_input[206]= 8.00000000000000e+000;
    __statist_max_input[207]= 8.00000000000000e+000;
    __statist_max_input[208]= 8.00000000000000e+000;
    __statist_max_input[209]= 8.00000000000000e+000;
    __statist_max_input[210]= 8.00000000000000e+000;
    __statist_max_input[211]= 8.00000000000000e+000;
    __statist_max_input[212]= 8.00000000000000e+000;
    __statist_max_input[213]= 8.00000000000000e+000;
    __statist_max_input[214]= 8.00000000000000e+000;
    __statist_max_input[215]= 8.00000000000000e+000;
    __statist_max_input[216]= 8.00000000000000e+000;
    __statist_max_input[217]= 8.00000000000000e+000;
    __statist_max_input[218]= 8.00000000000000e+000;
    __statist_max_input[219]= 8.00000000000000e+000;
    __statist_max_input[220]= 8.00000000000000e+000;
    __statist_max_input[221]= 8.00000000000000e+000;
    __statist_max_input[222]= 8.00000000000000e+000;
    __statist_max_input[223]= 8.00000000000000e+000;
    __statist_max_input[224]= 8.00000000000000e+000;
    __statist_max_input[225]= 2.00000000000000e+000;
    __statist_max_input[226]= 2.00000000000000e+000;
    __statist_max_input[227]= 2.00000000000000e+000;
    __statist_max_input[228]= 2.00000000000000e+000;
    __statist_max_input[229]= 2.00000000000000e+000;
    __statist_max_input[230]= 2.00000000000000e+000;
    __statist_max_input[231]= 2.00000000000000e+000;
    __statist_max_input[232]= 2.00000000000000e+000;
    __statist_max_input[233]= 2.00000000000000e+000;
    __statist_max_input[234]= 2.00000000000000e+000;
    __statist_max_input[235]= 2.00000000000000e+000;
    __statist_max_input[236]= 2.00000000000000e+000;
    __statist_max_input[237]= 2.00000000000000e+000;
    __statist_max_input[238]= 2.00000000000000e+000;
    __statist_max_input[239]= 2.00000000000000e+000;
    __statist_max_input[240]= 2.00000000000000e+000;
    __statist_max_input[241]= 2.00000000000000e+000;
    __statist_max_input[242]= 2.00000000000000e+000;
    __statist_max_input[243]= 2.00000000000000e+000;
    __statist_max_input[244]= 2.00000000000000e+000;
    __statist_max_input[245]= 2.00000000000000e+000;
    __statist_max_input[246]= 2.00000000000000e+000;
    __statist_max_input[247]= 2.00000000000000e+000;
    __statist_max_input[248]= 2.00000000000000e+000;

    double[] __statist_min_input = new double[249];
    __statist_min_input[0]= 0.00000000000000e+000;
    __statist_min_input[1]= 0.00000000000000e+000;
    __statist_min_input[2]= 0.00000000000000e+000;
    __statist_min_input[3]= 0.00000000000000e+000;
    __statist_min_input[4]= 0.00000000000000e+000;
    __statist_min_input[5]= 0.00000000000000e+000;
    __statist_min_input[6]= 0.00000000000000e+000;
    __statist_min_input[7]= 0.00000000000000e+000;
    __statist_min_input[8]= 0.00000000000000e+000;
    __statist_min_input[9]= 0.00000000000000e+000;
    __statist_min_input[10]= 0.00000000000000e+000;
    __statist_min_input[11]= 0.00000000000000e+000;
    __statist_min_input[12]= 0.00000000000000e+000;
    __statist_min_input[13]= 0.00000000000000e+000;
    __statist_min_input[14]= 0.00000000000000e+000;
    __statist_min_input[15]= 0.00000000000000e+000;
    __statist_min_input[16]= 0.00000000000000e+000;
    __statist_min_input[17]= 0.00000000000000e+000;
    __statist_min_input[18]= 0.00000000000000e+000;
    __statist_min_input[19]= 0.00000000000000e+000;
    __statist_min_input[20]= 0.00000000000000e+000;
    __statist_min_input[21]= 0.00000000000000e+000;
    __statist_min_input[22]= 0.00000000000000e+000;
    __statist_min_input[23]= 0.00000000000000e+000;
    __statist_min_input[24]= 0.00000000000000e+000;
    __statist_min_input[25]= 0.00000000000000e+000;
    __statist_min_input[26]= 0.00000000000000e+000;
    __statist_min_input[27]= 0.00000000000000e+000;
    __statist_min_input[28]= 0.00000000000000e+000;
    __statist_min_input[29]= 0.00000000000000e+000;
    __statist_min_input[30]= 0.00000000000000e+000;
    __statist_min_input[31]= 0.00000000000000e+000;
    __statist_min_input[32]= 0.00000000000000e+000;
    __statist_min_input[33]= 0.00000000000000e+000;
    __statist_min_input[34]= 0.00000000000000e+000;
    __statist_min_input[35]= 0.00000000000000e+000;
    __statist_min_input[36]= 0.00000000000000e+000;
    __statist_min_input[37]= 0.00000000000000e+000;
    __statist_min_input[38]= 0.00000000000000e+000;
    __statist_min_input[39]= 0.00000000000000e+000;
    __statist_min_input[40]= 0.00000000000000e+000;
    __statist_min_input[41]= 0.00000000000000e+000;
    __statist_min_input[42]= 0.00000000000000e+000;
    __statist_min_input[43]= 0.00000000000000e+000;
    __statist_min_input[44]= 0.00000000000000e+000;
    __statist_min_input[45]= 0.00000000000000e+000;
    __statist_min_input[46]= 0.00000000000000e+000;
    __statist_min_input[47]= 0.00000000000000e+000;
    __statist_min_input[48]= 0.00000000000000e+000;
    __statist_min_input[49]= 0.00000000000000e+000;
    __statist_min_input[50]= 0.00000000000000e+000;
    __statist_min_input[51]= 0.00000000000000e+000;
    __statist_min_input[52]= 0.00000000000000e+000;
    __statist_min_input[53]= 0.00000000000000e+000;
    __statist_min_input[54]= 0.00000000000000e+000;
    __statist_min_input[55]= 0.00000000000000e+000;
    __statist_min_input[56]= 0.00000000000000e+000;
    __statist_min_input[57]= 0.00000000000000e+000;
    __statist_min_input[58]= 0.00000000000000e+000;
    __statist_min_input[59]= 0.00000000000000e+000;
    __statist_min_input[60]= 0.00000000000000e+000;
    __statist_min_input[61]= 0.00000000000000e+000;
    __statist_min_input[62]= 0.00000000000000e+000;
    __statist_min_input[63]= 0.00000000000000e+000;
    __statist_min_input[64]= 0.00000000000000e+000;
    __statist_min_input[65]= 0.00000000000000e+000;
    __statist_min_input[66]= 0.00000000000000e+000;
    __statist_min_input[67]= 0.00000000000000e+000;
    __statist_min_input[68]= 0.00000000000000e+000;
    __statist_min_input[69]= 0.00000000000000e+000;
    __statist_min_input[70]= 0.00000000000000e+000;
    __statist_min_input[71]= 0.00000000000000e+000;
    __statist_min_input[72]= 0.00000000000000e+000;
    __statist_min_input[73]= 0.00000000000000e+000;
    __statist_min_input[74]= 0.00000000000000e+000;
    __statist_min_input[75]= 0.00000000000000e+000;
    __statist_min_input[76]= 0.00000000000000e+000;
    __statist_min_input[77]= 0.00000000000000e+000;
    __statist_min_input[78]= 0.00000000000000e+000;
    __statist_min_input[79]= 0.00000000000000e+000;
    __statist_min_input[80]= 0.00000000000000e+000;
    __statist_min_input[81]= 0.00000000000000e+000;
    __statist_min_input[82]= 0.00000000000000e+000;
    __statist_min_input[83]= 0.00000000000000e+000;
    __statist_min_input[84]= 0.00000000000000e+000;
    __statist_min_input[85]= 0.00000000000000e+000;
    __statist_min_input[86]= 0.00000000000000e+000;
    __statist_min_input[87]= 0.00000000000000e+000;
    __statist_min_input[88]= 0.00000000000000e+000;
    __statist_min_input[89]= 0.00000000000000e+000;
    __statist_min_input[90]= 0.00000000000000e+000;
    __statist_min_input[91]= 0.00000000000000e+000;
    __statist_min_input[92]= 0.00000000000000e+000;
    __statist_min_input[93]= 0.00000000000000e+000;
    __statist_min_input[94]= 0.00000000000000e+000;
    __statist_min_input[95]= 0.00000000000000e+000;
    __statist_min_input[96]= 0.00000000000000e+000;
    __statist_min_input[97]= 0.00000000000000e+000;
    __statist_min_input[98]= 0.00000000000000e+000;
    __statist_min_input[99]= 0.00000000000000e+000;
    __statist_min_input[100]= 0.00000000000000e+000;
    __statist_min_input[101]= 0.00000000000000e+000;
    __statist_min_input[102]= 0.00000000000000e+000;
    __statist_min_input[103]= 0.00000000000000e+000;
    __statist_min_input[104]= 0.00000000000000e+000;
    __statist_min_input[105]= 0.00000000000000e+000;
    __statist_min_input[106]= 0.00000000000000e+000;
    __statist_min_input[107]= 0.00000000000000e+000;
    __statist_min_input[108]= 0.00000000000000e+000;
    __statist_min_input[109]= 0.00000000000000e+000;
    __statist_min_input[110]= 0.00000000000000e+000;
    __statist_min_input[111]= 0.00000000000000e+000;
    __statist_min_input[112]= 0.00000000000000e+000;
    __statist_min_input[113]= 0.00000000000000e+000;
    __statist_min_input[114]= 0.00000000000000e+000;
    __statist_min_input[115]= 0.00000000000000e+000;
    __statist_min_input[116]= 0.00000000000000e+000;
    __statist_min_input[117]= 0.00000000000000e+000;
    __statist_min_input[118]= 0.00000000000000e+000;
    __statist_min_input[119]= 0.00000000000000e+000;
    __statist_min_input[120]= 0.00000000000000e+000;
    __statist_min_input[121]= 0.00000000000000e+000;
    __statist_min_input[122]= 0.00000000000000e+000;
    __statist_min_input[123]= 0.00000000000000e+000;
    __statist_min_input[124]= 0.00000000000000e+000;
    __statist_min_input[125]= 0.00000000000000e+000;
    __statist_min_input[126]= 0.00000000000000e+000;
    __statist_min_input[127]= 0.00000000000000e+000;
    __statist_min_input[128]= 0.00000000000000e+000;
    __statist_min_input[129]= 0.00000000000000e+000;
    __statist_min_input[130]= 0.00000000000000e+000;
    __statist_min_input[131]= 0.00000000000000e+000;
    __statist_min_input[132]= 0.00000000000000e+000;
    __statist_min_input[133]= 0.00000000000000e+000;
    __statist_min_input[134]= 0.00000000000000e+000;
    __statist_min_input[135]= 0.00000000000000e+000;
    __statist_min_input[136]= 0.00000000000000e+000;
    __statist_min_input[137]= 0.00000000000000e+000;
    __statist_min_input[138]= 0.00000000000000e+000;
    __statist_min_input[139]= 0.00000000000000e+000;
    __statist_min_input[140]= 0.00000000000000e+000;
    __statist_min_input[141]= 0.00000000000000e+000;
    __statist_min_input[142]= 0.00000000000000e+000;
    __statist_min_input[143]= 0.00000000000000e+000;
    __statist_min_input[144]= 0.00000000000000e+000;
    __statist_min_input[145]= 0.00000000000000e+000;
    __statist_min_input[146]= 0.00000000000000e+000;
    __statist_min_input[147]= 0.00000000000000e+000;
    __statist_min_input[148]= 0.00000000000000e+000;
    __statist_min_input[149]= 0.00000000000000e+000;
    __statist_min_input[150]= 0.00000000000000e+000;
    __statist_min_input[151]= 0.00000000000000e+000;
    __statist_min_input[152]= 0.00000000000000e+000;
    __statist_min_input[153]= 0.00000000000000e+000;
    __statist_min_input[154]= 0.00000000000000e+000;
    __statist_min_input[155]= 0.00000000000000e+000;
    __statist_min_input[156]= 0.00000000000000e+000;
    __statist_min_input[157]= 0.00000000000000e+000;
    __statist_min_input[158]= 0.00000000000000e+000;
    __statist_min_input[159]= 0.00000000000000e+000;
    __statist_min_input[160]= 0.00000000000000e+000;
    __statist_min_input[161]= 0.00000000000000e+000;
    __statist_min_input[162]= 0.00000000000000e+000;
    __statist_min_input[163]= 0.00000000000000e+000;
    __statist_min_input[164]= 0.00000000000000e+000;
    __statist_min_input[165]= 0.00000000000000e+000;
    __statist_min_input[166]= 0.00000000000000e+000;
    __statist_min_input[167]= 0.00000000000000e+000;
    __statist_min_input[168]= 0.00000000000000e+000;
    __statist_min_input[169]= 0.00000000000000e+000;
    __statist_min_input[170]= 0.00000000000000e+000;
    __statist_min_input[171]= 0.00000000000000e+000;
    __statist_min_input[172]= 0.00000000000000e+000;
    __statist_min_input[173]= 0.00000000000000e+000;
    __statist_min_input[174]= 0.00000000000000e+000;
    __statist_min_input[175]= 0.00000000000000e+000;
    __statist_min_input[176]= 0.00000000000000e+000;
    __statist_min_input[177]= 0.00000000000000e+000;
    __statist_min_input[178]= 0.00000000000000e+000;
    __statist_min_input[179]= 0.00000000000000e+000;
    __statist_min_input[180]= 0.00000000000000e+000;
    __statist_min_input[181]= 0.00000000000000e+000;
    __statist_min_input[182]= 0.00000000000000e+000;
    __statist_min_input[183]= 0.00000000000000e+000;
    __statist_min_input[184]= 0.00000000000000e+000;
    __statist_min_input[185]= 0.00000000000000e+000;
    __statist_min_input[186]= 0.00000000000000e+000;
    __statist_min_input[187]= 0.00000000000000e+000;
    __statist_min_input[188]= 0.00000000000000e+000;
    __statist_min_input[189]= 0.00000000000000e+000;
    __statist_min_input[190]= 0.00000000000000e+000;
    __statist_min_input[191]= 0.00000000000000e+000;
    __statist_min_input[192]= 0.00000000000000e+000;
    __statist_min_input[193]= 0.00000000000000e+000;
    __statist_min_input[194]= 0.00000000000000e+000;
    __statist_min_input[195]= 0.00000000000000e+000;
    __statist_min_input[196]= 0.00000000000000e+000;
    __statist_min_input[197]= 0.00000000000000e+000;
    __statist_min_input[198]= 0.00000000000000e+000;
    __statist_min_input[199]= 0.00000000000000e+000;
    __statist_min_input[200]= 0.00000000000000e+000;
    __statist_min_input[201]= 0.00000000000000e+000;
    __statist_min_input[202]= 0.00000000000000e+000;
    __statist_min_input[203]= 0.00000000000000e+000;
    __statist_min_input[204]= 0.00000000000000e+000;
    __statist_min_input[205]= 0.00000000000000e+000;
    __statist_min_input[206]= 0.00000000000000e+000;
    __statist_min_input[207]= 0.00000000000000e+000;
    __statist_min_input[208]= 0.00000000000000e+000;
    __statist_min_input[209]= 0.00000000000000e+000;
    __statist_min_input[210]= 0.00000000000000e+000;
    __statist_min_input[211]= 0.00000000000000e+000;
    __statist_min_input[212]= 0.00000000000000e+000;
    __statist_min_input[213]= 0.00000000000000e+000;
    __statist_min_input[214]= 0.00000000000000e+000;
    __statist_min_input[215]= 0.00000000000000e+000;
    __statist_min_input[216]= 0.00000000000000e+000;
    __statist_min_input[217]= 0.00000000000000e+000;
    __statist_min_input[218]= 0.00000000000000e+000;
    __statist_min_input[219]= 0.00000000000000e+000;
    __statist_min_input[220]= 0.00000000000000e+000;
    __statist_min_input[221]= 0.00000000000000e+000;
    __statist_min_input[222]= 0.00000000000000e+000;
    __statist_min_input[223]= 0.00000000000000e+000;
    __statist_min_input[224]= 0.00000000000000e+000;
    __statist_min_input[225]= 0.00000000000000e+000;
    __statist_min_input[226]= 0.00000000000000e+000;
    __statist_min_input[227]= 0.00000000000000e+000;
    __statist_min_input[228]= 0.00000000000000e+000;
    __statist_min_input[229]= 0.00000000000000e+000;
    __statist_min_input[230]= 0.00000000000000e+000;
    __statist_min_input[231]= 0.00000000000000e+000;
    __statist_min_input[232]= 0.00000000000000e+000;
    __statist_min_input[233]= 0.00000000000000e+000;
    __statist_min_input[234]= 0.00000000000000e+000;
    __statist_min_input[235]= 0.00000000000000e+000;
    __statist_min_input[236]= 0.00000000000000e+000;
    __statist_min_input[237]= 0.00000000000000e+000;
    __statist_min_input[238]= 0.00000000000000e+000;
    __statist_min_input[239]= 0.00000000000000e+000;
    __statist_min_input[240]= 0.00000000000000e+000;
    __statist_min_input[241]= 0.00000000000000e+000;
    __statist_min_input[242]= 0.00000000000000e+000;
    __statist_min_input[243]= 0.00000000000000e+000;
    __statist_min_input[244]= 0.00000000000000e+000;
    __statist_min_input[245]= 0.00000000000000e+000;
    __statist_min_input[246]= 0.00000000000000e+000;
    __statist_min_input[247]= 0.00000000000000e+000;
    __statist_min_input[248]= 0.00000000000000e+000;


    double[,] __statist_i_h_wts = new double[25,249];

    __statist_i_h_wts[0,0]=-1.86770364498322e-001;
    __statist_i_h_wts[0,1]=-3.67324975241882e-002;
    __statist_i_h_wts[0,2]=8.41116430935967e-002;
    __statist_i_h_wts[0,3]=1.90540779604529e-002;
    __statist_i_h_wts[0,4]=1.22937368133559e-001;
    __statist_i_h_wts[0,5]=1.65723341562027e-001;
    __statist_i_h_wts[0,6]=3.95392809171650e-002;
    __statist_i_h_wts[0,7]=-1.56634927629891e-002;
    __statist_i_h_wts[0,8]=-7.91354956788234e-002;
    __statist_i_h_wts[0,9]=-9.48501836250835e-002;
    __statist_i_h_wts[0,10]=-9.86494623104012e-002;
    __statist_i_h_wts[0,11]=-1.08508658697547e-001;
    __statist_i_h_wts[0,12]=-1.33730747551631e-001;
    __statist_i_h_wts[0,13]=1.36516273313004e-002;
    __statist_i_h_wts[0,14]=2.70742288511709e-002;
    __statist_i_h_wts[0,15]=-4.23515656502604e-002;
    __statist_i_h_wts[0,16]=5.89390265911500e-002;
    __statist_i_h_wts[0,17]=1.37519034265868e-001;
    __statist_i_h_wts[0,18]=2.91519843160061e-002;
    __statist_i_h_wts[0,19]=1.10387986388064e-001;
    __statist_i_h_wts[0,20]=7.40715576081090e-002;
    __statist_i_h_wts[0,21]=-1.15289190759980e-002;
    __statist_i_h_wts[0,22]=1.14704756481417e-001;
    __statist_i_h_wts[0,23]=1.70795320439905e-002;
    __statist_i_h_wts[0,24]=-4.63691151927442e-002;
    __statist_i_h_wts[0,25]=-9.22875582030750e-002;
    __statist_i_h_wts[0,26]=-8.63423701549377e-003;
    __statist_i_h_wts[0,27]=-6.72539342473905e-002;
    __statist_i_h_wts[0,28]=5.43119968270421e-002;
    __statist_i_h_wts[0,29]=4.52627705463169e-002;
    __statist_i_h_wts[0,30]=1.40778732192039e-001;
    __statist_i_h_wts[0,31]=1.40298662474066e-001;
    __statist_i_h_wts[0,32]=1.21543378484118e-001;
    __statist_i_h_wts[0,33]=1.44917220362203e-001;
    __statist_i_h_wts[0,34]=1.32316758187816e-001;
    __statist_i_h_wts[0,35]=8.19681895497450e-002;
    __statist_i_h_wts[0,36]=7.22139619161867e-002;
    __statist_i_h_wts[0,37]=2.14289545887068e-001;
    __statist_i_h_wts[0,38]=6.94812920638398e-002;
    __statist_i_h_wts[0,39]=1.43482493437926e-002;
    __statist_i_h_wts[0,40]=-5.39795989946862e-002;
    __statist_i_h_wts[0,41]=-9.16809547333974e-002;
    __statist_i_h_wts[0,42]=-1.21380557710959e-001;
    __statist_i_h_wts[0,43]=-2.12207307769893e-002;
    __statist_i_h_wts[0,44]=-4.36485702285922e-003;
    __statist_i_h_wts[0,45]=1.13044612805162e-001;
    __statist_i_h_wts[0,46]=2.59363324704858e-001;
    __statist_i_h_wts[0,47]=2.50762495213271e-002;
    __statist_i_h_wts[0,48]=4.22670471541423e-002;
    __statist_i_h_wts[0,49]=-3.26231401953072e-002;
    __statist_i_h_wts[0,50]=7.21410626528800e-003;
    __statist_i_h_wts[0,51]=-1.77524063993238e-001;
    __statist_i_h_wts[0,52]=6.04410442610885e-002;
    __statist_i_h_wts[0,53]=8.84878692937203e-003;
    __statist_i_h_wts[0,54]=-3.98376668565551e-003;
    __statist_i_h_wts[0,55]=-1.82551491192111e-001;
    __statist_i_h_wts[0,56]=-2.28044287412264e-001;
    __statist_i_h_wts[0,57]=-2.70045132315373e-001;
    __statist_i_h_wts[0,58]=-1.18759525634711e-001;
    __statist_i_h_wts[0,59]=-1.55037017579682e-001;
    __statist_i_h_wts[0,60]=2.54628084176061e-001;
    __statist_i_h_wts[0,61]=2.77025430845494e-001;
    __statist_i_h_wts[0,62]=1.75560821624477e-001;
    __statist_i_h_wts[0,63]=1.85391379187454e-001;
    __statist_i_h_wts[0,64]=4.81259067095564e-002;
    __statist_i_h_wts[0,65]=9.56060147312405e-002;
    __statist_i_h_wts[0,66]=2.60804336482413e-002;
    __statist_i_h_wts[0,67]=2.32476110108008e-001;
    __statist_i_h_wts[0,68]=-7.74053378985350e-002;
    __statist_i_h_wts[0,69]=-1.61258036734523e-001;
    __statist_i_h_wts[0,70]=-3.24104243372964e-001;
    __statist_i_h_wts[0,71]=-2.34260777302248e-001;
    __statist_i_h_wts[0,72]=-2.70853154605563e-001;
    __statist_i_h_wts[0,73]=-8.77224829494333e-002;
    __statist_i_h_wts[0,74]=-1.41387145425487e-001;
    __statist_i_h_wts[0,75]=2.60623116515022e-001;
    __statist_i_h_wts[0,76]=2.06671446200703e-001;
    __statist_i_h_wts[0,77]=9.56169411556075e-004;
    __statist_i_h_wts[0,78]=1.76853500801087e-003;
    __statist_i_h_wts[0,79]=-1.00021158606401e-001;
    __statist_i_h_wts[0,80]=-8.48035788973148e-003;
    __statist_i_h_wts[0,81]=-1.42654347046936e-001;
    __statist_i_h_wts[0,82]=2.22862289677119e-002;
    __statist_i_h_wts[0,83]=-1.62916535981571e-001;
    __statist_i_h_wts[0,84]=-6.01946297076093e-002;
    __statist_i_h_wts[0,85]=-1.38584682518985e-001;
    __statist_i_h_wts[0,86]=-2.90855005838027e-001;
    __statist_i_h_wts[0,87]=-2.47890357653543e-001;
    __statist_i_h_wts[0,88]=-1.14615047123010e-001;
    __statist_i_h_wts[0,89]=-9.19755613447747e-002;
    __statist_i_h_wts[0,90]=5.82248157952044e-002;
    __statist_i_h_wts[0,91]=2.15885866398059e-001;
    __statist_i_h_wts[0,92]=-4.78028688014048e-003;
    __statist_i_h_wts[0,93]=8.65044451139404e-002;
    __statist_i_h_wts[0,94]=-9.01930906017329e-003;
    __statist_i_h_wts[0,95]=1.11342696537114e-001;
    __statist_i_h_wts[0,96]=2.84253804249357e-002;
    __statist_i_h_wts[0,97]=9.55644785674166e-002;
    __statist_i_h_wts[0,98]=-1.67862495341207e-001;
    __statist_i_h_wts[0,99]=-2.92523391523503e-001;
    __statist_i_h_wts[0,100]=-2.37761490961403e-001;
    __statist_i_h_wts[0,101]=-3.97984506046017e-001;
    __statist_i_h_wts[0,102]=-3.36741113228837e-001;
    __statist_i_h_wts[0,103]=-1.45877659524547e-001;
    __statist_i_h_wts[0,104]=-1.51630592586944e-001;
    __statist_i_h_wts[0,105]=9.66377399759721e-002;
    __statist_i_h_wts[0,106]=9.87528059632458e-002;
    __statist_i_h_wts[0,107]=9.74002538885390e-002;
    __statist_i_h_wts[0,108]=1.52906584194612e-001;
    __statist_i_h_wts[0,109]=6.99849601427136e-002;
    __statist_i_h_wts[0,110]=2.20507144256772e-001;
    __statist_i_h_wts[0,111]=2.11309977477866e-001;
    __statist_i_h_wts[0,112]=7.37217756624075e-002;
    __statist_i_h_wts[0,113]=-5.99392108791953e-002;
    __statist_i_h_wts[0,114]=-1.84861824254251e-001;
    __statist_i_h_wts[0,115]=-2.23788620082769e-001;
    __statist_i_h_wts[0,116]=-4.17308745360487e-001;
    __statist_i_h_wts[0,117]=-3.27488071917066e-001;
    __statist_i_h_wts[0,118]=-2.55057326093244e-001;
    __statist_i_h_wts[0,119]=-1.57764493587159e-001;
    __statist_i_h_wts[0,120]=2.89556878326289e-001;
    __statist_i_h_wts[0,121]=1.71322342732765e-001;
    __statist_i_h_wts[0,122]=1.62450864281121e-001;
    __statist_i_h_wts[0,123]=2.92496952523213e-001;
    __statist_i_h_wts[0,124]=1.84752408523975e-001;
    __statist_i_h_wts[0,125]=1.69131619267225e-001;
    __statist_i_h_wts[0,126]=1.77448806182519e-001;
    __statist_i_h_wts[0,127]=-4.01768786426902e-002;
    __statist_i_h_wts[0,128]=-2.94181051548226e-001;
    __statist_i_h_wts[0,129]=-6.66219584304758e-002;
    __statist_i_h_wts[0,130]=-5.53452388649478e-002;
    __statist_i_h_wts[0,131]=-2.70329791120930e-001;
    __statist_i_h_wts[0,132]=-3.17557834777865e-001;
    __statist_i_h_wts[0,133]=-1.92840854235612e-001;
    __statist_i_h_wts[0,134]=-1.44581455487424e-001;
    __statist_i_h_wts[0,135]=2.86420212896700e-001;
    __statist_i_h_wts[0,136]=1.52036804728192e-001;
    __statist_i_h_wts[0,137]=1.31351465107588e-001;
    __statist_i_h_wts[0,138]=2.30284214594778e-001;
    __statist_i_h_wts[0,139]=8.78373578639874e-002;
    __statist_i_h_wts[0,140]=2.79688200329168e-001;
    __statist_i_h_wts[0,141]=8.07794470081714e-002;
    __statist_i_h_wts[0,142]=-1.46182360106891e-001;
    __statist_i_h_wts[0,143]=-2.74309787722394e-001;
    __statist_i_h_wts[0,144]=-1.65398581270892e-001;
    __statist_i_h_wts[0,145]=-7.54288200043528e-002;
    __statist_i_h_wts[0,146]=-8.56215836271158e-002;
    __statist_i_h_wts[0,147]=-1.58925488822040e-001;
    __statist_i_h_wts[0,148]=-1.67285869301681e-001;
    __statist_i_h_wts[0,149]=-1.05846371836761e-001;
    __statist_i_h_wts[0,150]=9.15668765917380e-002;
    __statist_i_h_wts[0,151]=-2.78424179723943e-002;
    __statist_i_h_wts[0,152]=6.94827607177432e-002;
    __statist_i_h_wts[0,153]=8.25896209007795e-002;
    __statist_i_h_wts[0,154]=1.68154462968182e-001;
    __statist_i_h_wts[0,155]=2.46391919897872e-001;
    __statist_i_h_wts[0,156]=2.12189499151074e-002;
    __statist_i_h_wts[0,157]=-1.08426503931049e-001;
    __statist_i_h_wts[0,158]=-2.72558163956116e-001;
    __statist_i_h_wts[0,159]=-8.14495099526066e-002;
    __statist_i_h_wts[0,160]=2.62576320756470e-002;
    __statist_i_h_wts[0,161]=-4.05662169447819e-002;
    __statist_i_h_wts[0,162]=-7.24850607526812e-002;
    __statist_i_h_wts[0,163]=-1.09967987879587e-001;
    __statist_i_h_wts[0,164]=-7.29654866459014e-002;
    __statist_i_h_wts[0,165]=1.99189384563370e-001;
    __statist_i_h_wts[0,166]=2.02674486876919e-001;
    __statist_i_h_wts[0,167]=2.05129327409153e-001;
    __statist_i_h_wts[0,168]=6.70242967397615e-002;
    __statist_i_h_wts[0,169]=2.02152848286123e-001;
    __statist_i_h_wts[0,170]=2.97289783824969e-001;
    __statist_i_h_wts[0,171]=1.08344162075465e-001;
    __statist_i_h_wts[0,172]=-9.51734731374839e-003;
    __statist_i_h_wts[0,173]=-1.06195611202960e-001;
    __statist_i_h_wts[0,174]=9.21554116232408e-002;
    __statist_i_h_wts[0,175]=5.69336884136273e-002;
    __statist_i_h_wts[0,176]=-3.71132326452100e-002;
    __statist_i_h_wts[0,177]=-6.76800684576572e-002;
    __statist_i_h_wts[0,178]=-9.29502899566309e-002;
    __statist_i_h_wts[0,179]=-1.16375759072550e-002;
    __statist_i_h_wts[0,180]=1.28849312865001e-001;
    __statist_i_h_wts[0,181]=1.10096007054162e-001;
    __statist_i_h_wts[0,182]=2.51594699771915e-001;
    __statist_i_h_wts[0,183]=1.81970738334437e-001;
    __statist_i_h_wts[0,184]=1.61562224450603e-001;
    __statist_i_h_wts[0,185]=2.06373680801729e-001;
    __statist_i_h_wts[0,186]=2.02694243403079e-001;
    __statist_i_h_wts[0,187]=1.86703426343911e-001;
    __statist_i_h_wts[0,188]=2.23980690154542e-002;
    __statist_i_h_wts[0,189]=3.58533959266126e-002;
    __statist_i_h_wts[0,190]=4.46752753402999e-002;
    __statist_i_h_wts[0,191]=9.40646689825612e-002;
    __statist_i_h_wts[0,192]=9.32660704297737e-002;
    __statist_i_h_wts[0,193]=1.92855562456667e-001;
    __statist_i_h_wts[0,194]=2.03462143561498e-001;
    __statist_i_h_wts[0,195]=3.26070783143140e-002;
    __statist_i_h_wts[0,196]=-2.44796854247437e-003;
    __statist_i_h_wts[0,197]=1.04525590967982e-001;
    __statist_i_h_wts[0,198]=1.19520237551543e-001;
    __statist_i_h_wts[0,199]=5.51380594561508e-002;
    __statist_i_h_wts[0,200]=2.03880313566006e-002;
    __statist_i_h_wts[0,201]=3.72617000410877e-002;
    __statist_i_h_wts[0,202]=6.56342765127374e-002;
    __statist_i_h_wts[0,203]=1.82181326838041e-002;
    __statist_i_h_wts[0,204]=-2.38714167942345e-002;
    __statist_i_h_wts[0,205]=4.20553885782236e-004;
    __statist_i_h_wts[0,206]=4.36832199172141e-002;
    __statist_i_h_wts[0,207]=1.35472680502622e-001;
    __statist_i_h_wts[0,208]=2.87424479255908e-001;
    __statist_i_h_wts[0,209]=2.60214060999582e-001;
    __statist_i_h_wts[0,210]=9.82514011076431e-002;
    __statist_i_h_wts[0,211]=8.13510830605792e-002;
    __statist_i_h_wts[0,212]=5.73419715493311e-002;
    __statist_i_h_wts[0,213]=1.51410604194578e-001;
    __statist_i_h_wts[0,214]=8.10944553509870e-002;
    __statist_i_h_wts[0,215]=-4.73925670451924e-003;
    __statist_i_h_wts[0,216]=-3.26911945998640e-002;
    __statist_i_h_wts[0,217]=-1.14701029420996e-003;
    __statist_i_h_wts[0,218]=-5.85948393969357e-002;
    __statist_i_h_wts[0,219]=-1.66784059976584e-002;
    __statist_i_h_wts[0,220]=1.48962648062292e-002;
    __statist_i_h_wts[0,221]=6.65662389138990e-002;
    __statist_i_h_wts[0,222]=1.65201756773207e-001;
    __statist_i_h_wts[0,223]=3.21335205721609e-001;
    __statist_i_h_wts[0,224]=2.69144147540416e-001;
    __statist_i_h_wts[0,225]=-4.09779026126789e-002;
    __statist_i_h_wts[0,226]=4.50767101074705e-002;
    __statist_i_h_wts[0,227]=-9.34857727142396e-002;
    __statist_i_h_wts[0,228]=4.05781928790980e-002;
    __statist_i_h_wts[0,229]=-1.40040346406942e-001;
    __statist_i_h_wts[0,230]=-7.80957121872335e-001;
    __statist_i_h_wts[0,231]=-6.75156474765875e-001;
    __statist_i_h_wts[0,232]=-1.32278534665435e+000;
    __statist_i_h_wts[0,233]=-3.98313427166436e-001;
    __statist_i_h_wts[0,234]=-1.55902880408185e+000;
    __statist_i_h_wts[0,235]=1.94371559466825e-001;
    __statist_i_h_wts[0,236]=1.48460424002308e-001;
    __statist_i_h_wts[0,237]=2.86925827557107e+000;
    __statist_i_h_wts[0,238]=1.11401067955665e+000;
    __statist_i_h_wts[0,239]=-4.90449305179046e-001;
    __statist_i_h_wts[0,240]=-7.64936240500288e-002;
    __statist_i_h_wts[0,241]=-1.13470651775100e+000;
    __statist_i_h_wts[0,242]=3.81289978492073e-002;
    __statist_i_h_wts[0,243]=-1.88150061459545e-001;
    __statist_i_h_wts[0,244]=1.07909093526222e-001;
    __statist_i_h_wts[0,245]=5.07011126998030e-001;
    __statist_i_h_wts[0,246]=-3.09810511405871e-001;
    __statist_i_h_wts[0,247]=4.02875579783428e-001;
    __statist_i_h_wts[0,248]=4.38559094470661e-001;

    __statist_i_h_wts[1,0]=1.85670107906497e-001;
    __statist_i_h_wts[1,1]=2.34699527116802e-001;
    __statist_i_h_wts[1,2]=2.62486395471439e-001;
    __statist_i_h_wts[1,3]=2.50280177906119e-001;
    __statist_i_h_wts[1,4]=2.81757023249486e-001;
    __statist_i_h_wts[1,5]=2.55269419680545e-001;
    __statist_i_h_wts[1,6]=2.00296691705417e-001;
    __statist_i_h_wts[1,7]=1.41312918848946e-001;
    __statist_i_h_wts[1,8]=5.81739472333437e-002;
    __statist_i_h_wts[1,9]=3.30021604693236e-002;
    __statist_i_h_wts[1,10]=1.24500586345401e-002;
    __statist_i_h_wts[1,11]=-6.02167697233493e-003;
    __statist_i_h_wts[1,12]=-6.39014651600436e-003;
    __statist_i_h_wts[1,13]=5.73925032014774e-002;
    __statist_i_h_wts[1,14]=9.06150152569380e-002;
    __statist_i_h_wts[1,15]=1.69640832523706e-001;
    __statist_i_h_wts[1,16]=2.15848040567319e-001;
    __statist_i_h_wts[1,17]=2.23183981813569e-001;
    __statist_i_h_wts[1,18]=1.68828511971245e-001;
    __statist_i_h_wts[1,19]=2.27175153798132e-001;
    __statist_i_h_wts[1,20]=1.81310071940763e-001;
    __statist_i_h_wts[1,21]=1.50076037831050e-001;
    __statist_i_h_wts[1,22]=1.15725394900851e-001;
    __statist_i_h_wts[1,23]=1.53673019141322e-002;
    __statist_i_h_wts[1,24]=7.13751105629519e-003;
    __statist_i_h_wts[1,25]=1.38018863395540e-002;
    __statist_i_h_wts[1,26]=3.48011835942788e-002;
    __statist_i_h_wts[1,27]=5.29956105403286e-003;
    __statist_i_h_wts[1,28]=7.39018534723028e-002;
    __statist_i_h_wts[1,29]=7.67454052391939e-002;
    __statist_i_h_wts[1,30]=1.93121940656112e-001;
    __statist_i_h_wts[1,31]=2.10594074465532e-001;
    __statist_i_h_wts[1,32]=1.71303642219570e-001;
    __statist_i_h_wts[1,33]=1.79496830748429e-001;
    __statist_i_h_wts[1,34]=1.71889371260113e-001;
    __statist_i_h_wts[1,35]=1.68571339096606e-001;
    __statist_i_h_wts[1,36]=1.69840193098089e-001;
    __statist_i_h_wts[1,37]=1.48248505728623e-001;
    __statist_i_h_wts[1,38]=8.10683096273548e-002;
    __statist_i_h_wts[1,39]=4.27865664623658e-002;
    __statist_i_h_wts[1,40]=2.67830676022383e-002;
    __statist_i_h_wts[1,41]=-1.02265895646902e-002;
    __statist_i_h_wts[1,42]=-1.25030457764308e-002;
    __statist_i_h_wts[1,43]=2.62887358319548e-002;
    __statist_i_h_wts[1,44]=7.09380287805898e-002;
    __statist_i_h_wts[1,45]=1.64672651159502e-001;
    __statist_i_h_wts[1,46]=1.95735240916449e-001;
    __statist_i_h_wts[1,47]=1.43156470715544e-001;
    __statist_i_h_wts[1,48]=1.19500457745426e-001;
    __statist_i_h_wts[1,49]=7.37920207191817e-002;
    __statist_i_h_wts[1,50]=1.23676492169793e-001;
    __statist_i_h_wts[1,51]=8.24167601038741e-002;
    __statist_i_h_wts[1,52]=1.25295667283267e-001;
    __statist_i_h_wts[1,53]=3.07113887083005e-002;
    __statist_i_h_wts[1,54]=3.61001679307103e-002;
    __statist_i_h_wts[1,55]=-5.07405027432481e-002;
    __statist_i_h_wts[1,56]=-5.22293916780669e-002;
    __statist_i_h_wts[1,57]=-6.70056157000830e-002;
    __statist_i_h_wts[1,58]=-4.94057579191208e-003;
    __statist_i_h_wts[1,59]=6.50854671758816e-003;
    __statist_i_h_wts[1,60]=1.31692244660595e-001;
    __statist_i_h_wts[1,61]=2.09506822468819e-001;
    __statist_i_h_wts[1,62]=1.60684259392049e-001;
    __statist_i_h_wts[1,63]=1.38799702713365e-001;
    __statist_i_h_wts[1,64]=1.29721295547924e-001;
    __statist_i_h_wts[1,65]=1.30221943521932e-001;
    __statist_i_h_wts[1,66]=4.22935726920157e-002;
    __statist_i_h_wts[1,67]=6.34383016674687e-002;
    __statist_i_h_wts[1,68]=-4.82224174630367e-003;
    __statist_i_h_wts[1,69]=-3.14699222967403e-002;
    __statist_i_h_wts[1,70]=-8.75471836144389e-002;
    __statist_i_h_wts[1,71]=-6.60730198644010e-002;
    __statist_i_h_wts[1,72]=-7.20166149942969e-002;
    __statist_i_h_wts[1,73]=-4.33650704353675e-003;
    __statist_i_h_wts[1,74]=6.60484009851215e-004;
    __statist_i_h_wts[1,75]=1.45223858149659e-001;
    __statist_i_h_wts[1,76]=1.63394168677144e-001;
    __statist_i_h_wts[1,77]=1.20398631941244e-001;
    __statist_i_h_wts[1,78]=1.23931535590907e-001;
    __statist_i_h_wts[1,79]=9.08409766050791e-002;
    __statist_i_h_wts[1,80]=5.34227864167147e-002;
    __statist_i_h_wts[1,81]=-3.12061348734180e-002;
    __statist_i_h_wts[1,82]=-3.48839391433555e-002;
    __statist_i_h_wts[1,83]=-5.22791640990029e-002;
    __statist_i_h_wts[1,84]=-2.71286060465706e-002;
    __statist_i_h_wts[1,85]=-5.32529790735479e-002;
    __statist_i_h_wts[1,86]=-7.10135107579139e-002;
    __statist_i_h_wts[1,87]=-7.83017079296272e-002;
    __statist_i_h_wts[1,88]=1.28302228116868e-003;
    __statist_i_h_wts[1,89]=2.42685602269964e-002;
    __statist_i_h_wts[1,90]=8.04686038897978e-002;
    __statist_i_h_wts[1,91]=1.47988075126481e-001;
    __statist_i_h_wts[1,92]=1.25797383193091e-001;
    __statist_i_h_wts[1,93]=1.64388909987777e-001;
    __statist_i_h_wts[1,94]=1.26407064894039e-001;
    __statist_i_h_wts[1,95]=5.30801298126097e-002;
    __statist_i_h_wts[1,96]=-1.67011528562733e-002;
    __statist_i_h_wts[1,97]=-3.41038886230339e-002;
    __statist_i_h_wts[1,98]=-8.83439126016766e-002;
    __statist_i_h_wts[1,99]=-7.66259063585172e-002;
    __statist_i_h_wts[1,100]=-8.40203995851907e-002;
    __statist_i_h_wts[1,101]=-1.08613097592713e-001;
    __statist_i_h_wts[1,102]=-1.04941902183346e-001;
    __statist_i_h_wts[1,103]=-2.67496715911460e-002;
    __statist_i_h_wts[1,104]=-3.76014428867218e-003;
    __statist_i_h_wts[1,105]=5.38133014040705e-002;
    __statist_i_h_wts[1,106]=8.35982279410721e-002;
    __statist_i_h_wts[1,107]=1.02142776597124e-001;
    __statist_i_h_wts[1,108]=1.32394874522809e-001;
    __statist_i_h_wts[1,109]=1.06097112464920e-001;
    __statist_i_h_wts[1,110]=8.59168795533405e-002;
    __statist_i_h_wts[1,111]=3.35849311705478e-002;
    __statist_i_h_wts[1,112]=-5.23770502722983e-004;
    __statist_i_h_wts[1,113]=-3.51953325910414e-002;
    __statist_i_h_wts[1,114]=-3.54864137784470e-002;
    __statist_i_h_wts[1,115]=-7.70364797989056e-002;
    __statist_i_h_wts[1,116]=-1.24642968672998e-001;
    __statist_i_h_wts[1,117]=-1.02340207835298e-001;
    __statist_i_h_wts[1,118]=-7.36184283783575e-002;
    __statist_i_h_wts[1,119]=-1.59506474356357e-002;
    __statist_i_h_wts[1,120]=7.11285683872196e-002;
    __statist_i_h_wts[1,121]=7.85095697242875e-002;
    __statist_i_h_wts[1,122]=1.01806398272615e-001;
    __statist_i_h_wts[1,123]=1.37566876282755e-001;
    __statist_i_h_wts[1,124]=9.87193526411562e-002;
    __statist_i_h_wts[1,125]=6.83638817612351e-002;
    __statist_i_h_wts[1,126]=2.62166670639291e-002;
    __statist_i_h_wts[1,127]=-4.62316115977909e-002;
    __statist_i_h_wts[1,128]=-8.46964205387530e-002;
    __statist_i_h_wts[1,129]=-1.84013574866323e-002;
    __statist_i_h_wts[1,130]=-4.67296014407445e-002;
    __statist_i_h_wts[1,131]=-9.78705078178100e-002;
    __statist_i_h_wts[1,132]=-8.95698434187473e-002;
    __statist_i_h_wts[1,133]=-4.09820844370223e-002;
    __statist_i_h_wts[1,134]=5.52936768747046e-003;
    __statist_i_h_wts[1,135]=6.56811915305726e-002;
    __statist_i_h_wts[1,136]=7.03472470861915e-002;
    __statist_i_h_wts[1,137]=7.07609236061131e-002;
    __statist_i_h_wts[1,138]=1.03274884640104e-001;
    __statist_i_h_wts[1,139]=8.46848518644762e-002;
    __statist_i_h_wts[1,140]=1.08478117293407e-001;
    __statist_i_h_wts[1,141]=1.55668450550813e-002;
    __statist_i_h_wts[1,142]=-3.62334359920158e-002;
    __statist_i_h_wts[1,143]=-5.87056215586027e-002;
    __statist_i_h_wts[1,144]=-4.91916579680622e-002;
    __statist_i_h_wts[1,145]=-4.27783154049691e-002;
    __statist_i_h_wts[1,146]=-5.67211263416063e-002;
    __statist_i_h_wts[1,147]=-6.36664251461889e-002;
    __statist_i_h_wts[1,148]=-1.76697700027008e-002;
    __statist_i_h_wts[1,149]=1.90438411865812e-002;
    __statist_i_h_wts[1,150]=-1.11417651951868e-002;
    __statist_i_h_wts[1,151]=-2.86275901174629e-003;
    __statist_i_h_wts[1,152]=1.19372716581794e-002;
    __statist_i_h_wts[1,153]=3.83001439849853e-002;
    __statist_i_h_wts[1,154]=6.72867590153041e-002;
    __statist_i_h_wts[1,155]=7.88712201830540e-002;
    __statist_i_h_wts[1,156]=7.55034713532509e-003;
    __statist_i_h_wts[1,157]=8.14415558530980e-003;
    __statist_i_h_wts[1,158]=-3.53038473325359e-002;
    __statist_i_h_wts[1,159]=-2.79255365789556e-002;
    __statist_i_h_wts[1,160]=-3.04422756606633e-002;
    __statist_i_h_wts[1,161]=-4.51481438708666e-002;
    __statist_i_h_wts[1,162]=-4.96369229387539e-002;
    __statist_i_h_wts[1,163]=-1.38059440297399e-002;
    __statist_i_h_wts[1,164]=3.28578938702663e-002;
    __statist_i_h_wts[1,165]=3.84643124841418e-002;
    __statist_i_h_wts[1,166]=4.82981493479293e-002;
    __statist_i_h_wts[1,167]=5.72804241305483e-002;
    __statist_i_h_wts[1,168]=5.33054420235724e-002;
    __statist_i_h_wts[1,169]=1.00094146667464e-001;
    __statist_i_h_wts[1,170]=1.06198971454506e-001;
    __statist_i_h_wts[1,171]=5.32722804677640e-002;
    __statist_i_h_wts[1,172]=4.97440541640007e-002;
    __statist_i_h_wts[1,173]=4.25015145001448e-002;
    __statist_i_h_wts[1,174]=4.56813813754214e-002;
    __statist_i_h_wts[1,175]=1.13633354971602e-002;
    __statist_i_h_wts[1,176]=-1.30256176772632e-002;
    __statist_i_h_wts[1,177]=-1.79682893112079e-002;
    __statist_i_h_wts[1,178]=5.03793833025286e-003;
    __statist_i_h_wts[1,179]=4.64747790558851e-002;
    __statist_i_h_wts[1,180]=6.16316050491719e-002;
    __statist_i_h_wts[1,181]=6.02189610484785e-002;
    __statist_i_h_wts[1,182]=8.44319937548829e-002;
    __statist_i_h_wts[1,183]=1.04971020074206e-001;
    __statist_i_h_wts[1,184]=1.02149979282321e-001;
    __statist_i_h_wts[1,185]=1.13909913783412e-001;
    __statist_i_h_wts[1,186]=8.39214406176986e-002;
    __statist_i_h_wts[1,187]=8.49660157866287e-002;
    __statist_i_h_wts[1,188]=5.62265229122834e-002;
    __statist_i_h_wts[1,189]=2.61458503387715e-002;
    __statist_i_h_wts[1,190]=5.27912752016053e-003;
    __statist_i_h_wts[1,191]=2.93766492862234e-002;
    __statist_i_h_wts[1,192]=2.61452127926511e-002;
    __statist_i_h_wts[1,193]=8.20899812231401e-002;
    __statist_i_h_wts[1,194]=7.92115458039494e-002;
    __statist_i_h_wts[1,195]=6.14129300253539e-002;
    __statist_i_h_wts[1,196]=8.43222717176194e-002;
    __statist_i_h_wts[1,197]=1.24709328996284e-001;
    __statist_i_h_wts[1,198]=8.15426003965886e-002;
    __statist_i_h_wts[1,199]=7.93866618974916e-002;
    __statist_i_h_wts[1,200]=1.09429723600718e-001;
    __statist_i_h_wts[1,201]=1.09713957431239e-001;
    __statist_i_h_wts[1,202]=7.69547152133782e-002;
    __statist_i_h_wts[1,203]=6.43508413190530e-002;
    __statist_i_h_wts[1,204]=4.12671463415641e-002;
    __statist_i_h_wts[1,205]=1.78254788760745e-002;
    __statist_i_h_wts[1,206]=9.15080595263287e-003;
    __statist_i_h_wts[1,207]=4.77857749649395e-002;
    __statist_i_h_wts[1,208]=1.07243854665182e-001;
    __statist_i_h_wts[1,209]=1.13603814095734e-001;
    __statist_i_h_wts[1,210]=7.93142482029904e-002;
    __statist_i_h_wts[1,211]=1.02602881559594e-001;
    __statist_i_h_wts[1,212]=7.18699114878728e-002;
    __statist_i_h_wts[1,213]=8.74098206313815e-002;
    __statist_i_h_wts[1,214]=1.06808217086160e-001;
    __statist_i_h_wts[1,215]=1.03835271812800e-001;
    __statist_i_h_wts[1,216]=9.48732634575506e-002;
    __statist_i_h_wts[1,217]=8.21061492319691e-002;
    __statist_i_h_wts[1,218]=7.16109224828511e-002;
    __statist_i_h_wts[1,219]=6.87664670378915e-002;
    __statist_i_h_wts[1,220]=3.63273317995222e-002;
    __statist_i_h_wts[1,221]=6.42989788327027e-002;
    __statist_i_h_wts[1,222]=7.99268390679006e-002;
    __statist_i_h_wts[1,223]=1.40758469429271e-001;
    __statist_i_h_wts[1,224]=1.16651710869004e-001;
    __statist_i_h_wts[1,225]=-2.14420743402741e-002;
    __statist_i_h_wts[1,226]=1.68655009074710e-001;
    __statist_i_h_wts[1,227]=-4.73033576977574e-004;
    __statist_i_h_wts[1,228]=1.94614327669134e-001;
    __statist_i_h_wts[1,229]=-3.87361430849102e-003;
    __statist_i_h_wts[1,230]=-3.96828905982086e-001;
    __statist_i_h_wts[1,231]=-2.09113742660277e-001;
    __statist_i_h_wts[1,232]=-5.38430993538787e-001;
    __statist_i_h_wts[1,233]=-1.99709176790285e-001;
    __statist_i_h_wts[1,234]=-7.68298663638855e-001;
    __statist_i_h_wts[1,235]=8.99314901858911e-002;
    __statist_i_h_wts[1,236]=2.28025548852321e-001;
    __statist_i_h_wts[1,237]=1.22105772892777e+000;
    __statist_i_h_wts[1,238]=3.85317420063896e-001;
    __statist_i_h_wts[1,239]=-3.21846153527987e-001;
    __statist_i_h_wts[1,240]=3.21721496243260e-002;
    __statist_i_h_wts[1,241]=-5.78815477930973e-001;
    __statist_i_h_wts[1,242]=6.45937259598520e-002;
    __statist_i_h_wts[1,243]=-1.94902437687997e-001;
    __statist_i_h_wts[1,244]=3.96989461729935e-002;
    __statist_i_h_wts[1,245]=3.85356579467097e-001;
    __statist_i_h_wts[1,246]=-6.58223473512155e-002;
    __statist_i_h_wts[1,247]=3.39697136031615e-001;
    __statist_i_h_wts[1,248]=1.62538532373933e-001;

    __statist_i_h_wts[2,0]=8.93385424935050e-001;
    __statist_i_h_wts[2,1]=6.54628514972284e-001;
    __statist_i_h_wts[2,2]=4.28762249568611e-001;
    __statist_i_h_wts[2,3]=3.33066044257105e-001;
    __statist_i_h_wts[2,4]=2.76679410487679e-001;
    __statist_i_h_wts[2,5]=2.36090645791248e-001;
    __statist_i_h_wts[2,6]=2.78295057335038e-001;
    __statist_i_h_wts[2,7]=2.58752788177239e-001;
    __statist_i_h_wts[2,8]=8.50814951421672e-002;
    __statist_i_h_wts[2,9]=-7.20527039160068e-002;
    __statist_i_h_wts[2,10]=-1.28574044729669e-001;
    __statist_i_h_wts[2,11]=-5.62690806943360e-002;
    __statist_i_h_wts[2,12]=6.29855985730153e-002;
    __statist_i_h_wts[2,13]=-7.58746736920525e-002;
    __statist_i_h_wts[2,14]=-1.59852570676564e-001;
    __statist_i_h_wts[2,15]=9.56723820791891e-001;
    __statist_i_h_wts[2,16]=6.92130566083003e-001;
    __statist_i_h_wts[2,17]=5.04444043491178e-001;
    __statist_i_h_wts[2,18]=3.29610406945495e-001;
    __statist_i_h_wts[2,19]=2.86774150379554e-001;
    __statist_i_h_wts[2,20]=3.92344189662101e-001;
    __statist_i_h_wts[2,21]=3.13447651108344e-001;
    __statist_i_h_wts[2,22]=3.42991533582886e-001;
    __statist_i_h_wts[2,23]=2.03941462117338e-001;
    __statist_i_h_wts[2,24]=4.25818117200153e-002;
    __statist_i_h_wts[2,25]=-1.74313650804689e-001;
    __statist_i_h_wts[2,26]=-2.43690796236735e-001;
    __statist_i_h_wts[2,27]=-1.52262125826208e-001;
    __statist_i_h_wts[2,28]=-1.61369533132936e-001;
    __statist_i_h_wts[2,29]=-2.46788014719996e-001;
    __statist_i_h_wts[2,30]=7.25384867495406e-001;
    __statist_i_h_wts[2,31]=5.03987320933653e-001;
    __statist_i_h_wts[2,32]=3.59948075345991e-001;
    __statist_i_h_wts[2,33]=5.24395899777213e-002;
    __statist_i_h_wts[2,34]=1.06844185099342e-001;
    __statist_i_h_wts[2,35]=1.77827540371943e-001;
    __statist_i_h_wts[2,36]=8.02280948118744e-002;
    __statist_i_h_wts[2,37]=1.80811105498821e-001;
    __statist_i_h_wts[2,38]=2.05535785188304e-002;
    __statist_i_h_wts[2,39]=-1.18709786291911e-001;
    __statist_i_h_wts[2,40]=-1.17346275287728e-001;
    __statist_i_h_wts[2,41]=-2.10879017414978e-001;
    __statist_i_h_wts[2,42]=-2.27792369367618e-001;
    __statist_i_h_wts[2,43]=-1.48114925139690e-001;
    __statist_i_h_wts[2,44]=-2.68468329157263e-001;
    __statist_i_h_wts[2,45]=4.74170296574607e-001;
    __statist_i_h_wts[2,46]=2.70430313680420e-001;
    __statist_i_h_wts[2,47]=2.57755968166049e-001;
    __statist_i_h_wts[2,48]=-8.52745978918482e-003;
    __statist_i_h_wts[2,49]=1.66711809357326e-001;
    __statist_i_h_wts[2,50]=1.00407803209649e-001;
    __statist_i_h_wts[2,51]=6.39335622554367e-002;
    __statist_i_h_wts[2,52]=3.26157129559398e-002;
    __statist_i_h_wts[2,53]=-7.84816364105550e-002;
    __statist_i_h_wts[2,54]=-2.35506426243991e-001;
    __statist_i_h_wts[2,55]=-2.65527222382935e-001;
    __statist_i_h_wts[2,56]=-4.43742275414494e-001;
    __statist_i_h_wts[2,57]=-3.43577689954617e-001;
    __statist_i_h_wts[2,58]=-3.59074372400127e-001;
    __statist_i_h_wts[2,59]=-4.07611549634798e-001;
    __statist_i_h_wts[2,60]=5.39568060184133e-001;
    __statist_i_h_wts[2,61]=4.04753511768736e-001;
    __statist_i_h_wts[2,62]=3.38059164602943e-001;
    __statist_i_h_wts[2,63]=1.65708308159641e-001;
    __statist_i_h_wts[2,64]=1.62195511820001e-001;
    __statist_i_h_wts[2,65]=1.71285725826528e-001;
    __statist_i_h_wts[2,66]=1.46719833422897e-001;
    __statist_i_h_wts[2,67]=9.60349845346818e-002;
    __statist_i_h_wts[2,68]=7.85110653640631e-002;
    __statist_i_h_wts[2,69]=-1.70739441145726e-001;
    __statist_i_h_wts[2,70]=-2.78105321791217e-001;
    __statist_i_h_wts[2,71]=-5.27152268668175e-001;
    __statist_i_h_wts[2,72]=-4.13253273620279e-001;
    __statist_i_h_wts[2,73]=-5.01566332328252e-001;
    __statist_i_h_wts[2,74]=-5.61333687633595e-001;
    __statist_i_h_wts[2,75]=3.60185352761375e-001;
    __statist_i_h_wts[2,76]=3.30892706015319e-001;
    __statist_i_h_wts[2,77]=3.34574008934396e-001;
    __statist_i_h_wts[2,78]=1.93584242335271e-001;
    __statist_i_h_wts[2,79]=2.04455404057947e-001;
    __statist_i_h_wts[2,80]=3.65218785732455e-002;
    __statist_i_h_wts[2,81]=1.30087825945924e-002;
    __statist_i_h_wts[2,82]=-2.63705144248154e-002;
    __statist_i_h_wts[2,83]=6.34171920796050e-003;
    __statist_i_h_wts[2,84]=-1.63260358732571e-001;
    __statist_i_h_wts[2,85]=-2.05565899138392e-001;
    __statist_i_h_wts[2,86]=-4.10108672547374e-001;
    __statist_i_h_wts[2,87]=-3.50011055271749e-001;
    __statist_i_h_wts[2,88]=-4.91767127160664e-001;
    __statist_i_h_wts[2,89]=-6.17083371696331e-001;
    __statist_i_h_wts[2,90]=4.23395661945676e-001;
    __statist_i_h_wts[2,91]=3.26200617503196e-001;
    __statist_i_h_wts[2,92]=2.73620512937933e-001;
    __statist_i_h_wts[2,93]=1.70008697640848e-001;
    __statist_i_h_wts[2,94]=1.49353645781567e-001;
    __statist_i_h_wts[2,95]=5.21985345152851e-002;
    __statist_i_h_wts[2,96]=-1.23646284165301e-001;
    __statist_i_h_wts[2,97]=-1.82830627009127e-001;
    __statist_i_h_wts[2,98]=-9.43400768364241e-002;
    __statist_i_h_wts[2,99]=-2.54667246743951e-001;
    __statist_i_h_wts[2,100]=-3.34901718108501e-001;
    __statist_i_h_wts[2,101]=-4.38028575913775e-001;
    __statist_i_h_wts[2,102]=-2.74571889304786e-001;
    __statist_i_h_wts[2,103]=-4.44140565946971e-001;
    __statist_i_h_wts[2,104]=-5.14098077761446e-001;
    __statist_i_h_wts[2,105]=4.86189041634332e-001;
    __statist_i_h_wts[2,106]=4.36717113709058e-001;
    __statist_i_h_wts[2,107]=3.60990113596986e-001;
    __statist_i_h_wts[2,108]=1.86034195481028e-001;
    __statist_i_h_wts[2,109]=1.82493718796780e-001;
    __statist_i_h_wts[2,110]=4.19351114133798e-002;
    __statist_i_h_wts[2,111]=-2.03020904449167e-001;
    __statist_i_h_wts[2,112]=-3.47944215003939e-001;
    __statist_i_h_wts[2,113]=-2.90866203233687e-001;
    __statist_i_h_wts[2,114]=-3.88968064708713e-001;
    __statist_i_h_wts[2,115]=-3.45987975959842e-001;
    __statist_i_h_wts[2,116]=-5.14276009869320e-001;
    __statist_i_h_wts[2,117]=-3.15269565692103e-001;
    __statist_i_h_wts[2,118]=-3.23297131337705e-001;
    __statist_i_h_wts[2,119]=-5.22344665064748e-001;
    __statist_i_h_wts[2,120]=4.46434071384469e-001;
    __statist_i_h_wts[2,121]=4.65473389638007e-001;
    __statist_i_h_wts[2,122]=3.83137965416357e-001;
    __statist_i_h_wts[2,123]=2.17364554572725e-001;
    __statist_i_h_wts[2,124]=1.81803946632894e-001;
    __statist_i_h_wts[2,125]=5.28201520043833e-002;
    __statist_i_h_wts[2,126]=-6.31839971042979e-002;
    __statist_i_h_wts[2,127]=-2.13234250444155e-001;
    __statist_i_h_wts[2,128]=-1.55068554973623e-001;
    __statist_i_h_wts[2,129]=-3.24267841697783e-001;
    __statist_i_h_wts[2,130]=-5.26930971567678e-001;
    __statist_i_h_wts[2,131]=-5.97161547430355e-001;
    __statist_i_h_wts[2,132]=-4.39193167855782e-001;
    __statist_i_h_wts[2,133]=-5.04244589387210e-001;
    __statist_i_h_wts[2,134]=-6.34521873027424e-001;
    __statist_i_h_wts[2,135]=3.85661658547754e-001;
    __statist_i_h_wts[2,136]=4.47094050443799e-001;
    __statist_i_h_wts[2,137]=4.24644831565591e-001;
    __statist_i_h_wts[2,138]=2.79618596202747e-001;
    __statist_i_h_wts[2,139]=2.50756950564757e-001;
    __statist_i_h_wts[2,140]=5.39983608172816e-002;
    __statist_i_h_wts[2,141]=-4.96938930045347e-002;
    __statist_i_h_wts[2,142]=-1.76411264759603e-001;
    __statist_i_h_wts[2,143]=-6.20769473100597e-002;
    __statist_i_h_wts[2,144]=-2.04527096629513e-001;
    __statist_i_h_wts[2,145]=-4.03149098892754e-001;
    __statist_i_h_wts[2,146]=-5.81092424352028e-001;
    __statist_i_h_wts[2,147]=-3.69145548092651e-001;
    __statist_i_h_wts[2,148]=-3.41354983220185e-001;
    __statist_i_h_wts[2,149]=-5.38623509180307e-001;
    __statist_i_h_wts[2,150]=4.23751123584504e-001;
    __statist_i_h_wts[2,151]=4.10547277862442e-001;
    __statist_i_h_wts[2,152]=3.09440950138015e-001;
    __statist_i_h_wts[2,153]=2.11989215879937e-001;
    __statist_i_h_wts[2,154]=6.59132441039906e-002;
    __statist_i_h_wts[2,155]=1.42831145781912e-002;
    __statist_i_h_wts[2,156]=-1.63937583148920e-001;
    __statist_i_h_wts[2,157]=-1.71675657645250e-001;
    __statist_i_h_wts[2,158]=-1.24313006932104e-001;
    __statist_i_h_wts[2,159]=-1.30056525654020e-001;
    __statist_i_h_wts[2,160]=-2.00231717723145e-001;
    __statist_i_h_wts[2,161]=-3.63195677053454e-001;
    __statist_i_h_wts[2,162]=-2.24705190865727e-001;
    __statist_i_h_wts[2,163]=-1.22752330422985e-001;
    __statist_i_h_wts[2,164]=-3.73844503925664e-001;
    __statist_i_h_wts[2,165]=2.55641997012864e-001;
    __statist_i_h_wts[2,166]=2.78130594700520e-001;
    __statist_i_h_wts[2,167]=2.84331855879597e-001;
    __statist_i_h_wts[2,168]=1.93829521595515e-001;
    __statist_i_h_wts[2,169]=1.17095710971290e-001;
    __statist_i_h_wts[2,170]=1.38262234576301e-002;
    __statist_i_h_wts[2,171]=-7.91739314678503e-002;
    __statist_i_h_wts[2,172]=-1.18798645820429e-001;
    __statist_i_h_wts[2,173]=-2.01225278789182e-001;
    __statist_i_h_wts[2,174]=-1.72749692183304e-001;
    __statist_i_h_wts[2,175]=-1.56900786812479e-001;
    __statist_i_h_wts[2,176]=-2.91622389634613e-001;
    __statist_i_h_wts[2,177]=-2.25079503907577e-001;
    __statist_i_h_wts[2,178]=-9.49138217807104e-002;
    __statist_i_h_wts[2,179]=-3.68907926666966e-001;
    __statist_i_h_wts[2,180]=2.59743757988161e-001;
    __statist_i_h_wts[2,181]=3.01850841081027e-001;
    __statist_i_h_wts[2,182]=3.19875104406521e-001;
    __statist_i_h_wts[2,183]=2.31661008651674e-001;
    __statist_i_h_wts[2,184]=1.54465471548177e-001;
    __statist_i_h_wts[2,185]=2.18137706807792e-002;
    __statist_i_h_wts[2,186]=1.02993071962208e-002;
    __statist_i_h_wts[2,187]=2.67589219755939e-002;
    __statist_i_h_wts[2,188]=-5.24925248781142e-002;
    __statist_i_h_wts[2,189]=-1.95520003165058e-002;
    __statist_i_h_wts[2,190]=-2.81242604579566e-002;
    __statist_i_h_wts[2,191]=-2.42869140945971e-001;
    __statist_i_h_wts[2,192]=-3.04436196834292e-001;
    __statist_i_h_wts[2,193]=-3.33310830223064e-001;
    __statist_i_h_wts[2,194]=-5.66883196461232e-001;
    __statist_i_h_wts[2,195]=1.41860821889219e-001;
    __statist_i_h_wts[2,196]=1.58393253102185e-001;
    __statist_i_h_wts[2,197]=1.07321124334674e-001;
    __statist_i_h_wts[2,198]=6.14685899632934e-002;
    __statist_i_h_wts[2,199]=-3.52210714108114e-002;
    __statist_i_h_wts[2,200]=-5.89984413820650e-002;
    __statist_i_h_wts[2,201]=-7.23651377993292e-002;
    __statist_i_h_wts[2,202]=-1.86864023591041e-002;
    __statist_i_h_wts[2,203]=-1.03839912452437e-001;
    __statist_i_h_wts[2,204]=-1.13149325892763e-001;
    __statist_i_h_wts[2,205]=-9.97685268144209e-002;
    __statist_i_h_wts[2,206]=-3.23459565909821e-001;
    __statist_i_h_wts[2,207]=-4.56170818830229e-001;
    __statist_i_h_wts[2,208]=-3.56591439736463e-001;
    __statist_i_h_wts[2,209]=-4.74301293862441e-001;
    __statist_i_h_wts[2,210]=1.43712045234734e-001;
    __statist_i_h_wts[2,211]=1.93468982605725e-001;
    __statist_i_h_wts[2,212]=1.80986246789235e-001;
    __statist_i_h_wts[2,213]=1.26190950672236e-001;
    __statist_i_h_wts[2,214]=5.06392712782978e-002;
    __statist_i_h_wts[2,215]=-3.00428531974471e-003;
    __statist_i_h_wts[2,216]=-4.94097908821287e-002;
    __statist_i_h_wts[2,217]=8.89945740403263e-003;
    __statist_i_h_wts[2,218]=-1.34531318393398e-001;
    __statist_i_h_wts[2,219]=-1.63352666422632e-001;
    __statist_i_h_wts[2,220]=-1.90213015068724e-001;
    __statist_i_h_wts[2,221]=-2.84290359091959e-001;
    __statist_i_h_wts[2,222]=-4.18943874655094e-001;
    __statist_i_h_wts[2,223]=-4.00717658533695e-001;
    __statist_i_h_wts[2,224]=-3.95116638501485e-001;
    __statist_i_h_wts[2,225]=7.02332007844308e-002;
    __statist_i_h_wts[2,226]=-6.89094827109154e-001;
    __statist_i_h_wts[2,227]=-1.11905421344786e-001;
    __statist_i_h_wts[2,228]=-8.30847728884117e-001;
    __statist_i_h_wts[2,229]=-1.61680250689316e-002;
    __statist_i_h_wts[2,230]=1.27850393043810e+000;
    __statist_i_h_wts[2,231]=3.67901577331285e-001;
    __statist_i_h_wts[2,232]=1.23528538020272e+000;
    __statist_i_h_wts[2,233]=5.32452204870533e-001;
    __statist_i_h_wts[2,234]=1.65974578440138e+000;
    __statist_i_h_wts[2,235]=1.36595073631418e-001;
    __statist_i_h_wts[2,236]=-7.55241273959398e-001;
    __statist_i_h_wts[2,237]=-2.89180982621270e+000;
    __statist_i_h_wts[2,238]=-7.85418441235787e-001;
    __statist_i_h_wts[2,239]=1.04648093641108e+000;
    __statist_i_h_wts[2,240]=-9.36905253948747e-002;
    __statist_i_h_wts[2,241]=1.63815008760539e+000;
    __statist_i_h_wts[2,242]=-1.33091304147137e-001;
    __statist_i_h_wts[2,243]=8.14979459619692e-001;
    __statist_i_h_wts[2,244]=2.99256778473289e-001;
    __statist_i_h_wts[2,245]=-9.77021507086836e-001;
    __statist_i_h_wts[2,246]=2.18054863067878e-001;
    __statist_i_h_wts[2,247]=-1.26723430948177e+000;
    __statist_i_h_wts[2,248]=-3.07155347749349e-001;

    __statist_i_h_wts[3,0]=1.05712996596401e-002;
    __statist_i_h_wts[3,1]=-3.24255875761293e-002;
    __statist_i_h_wts[3,2]=-4.73202056207474e-002;
    __statist_i_h_wts[3,3]=-6.73448936312587e-002;
    __statist_i_h_wts[3,4]=-8.13386335723852e-002;
    __statist_i_h_wts[3,5]=-5.02566814154918e-002;
    __statist_i_h_wts[3,6]=-1.91497708630357e-002;
    __statist_i_h_wts[3,7]=-7.68131062515415e-003;
    __statist_i_h_wts[3,8]=-1.46214184207647e-002;
    __statist_i_h_wts[3,9]=-2.33679776115085e-002;
    __statist_i_h_wts[3,10]=1.35351524462165e-002;
    __statist_i_h_wts[3,11]=8.47327114016807e-002;
    __statist_i_h_wts[3,12]=1.14552426379225e-001;
    __statist_i_h_wts[3,13]=4.68007012538410e-002;
    __statist_i_h_wts[3,14]=5.17622387318770e-003;
    __statist_i_h_wts[3,15]=2.80973302445867e-002;
    __statist_i_h_wts[3,16]=-1.14775257243191e-002;
    __statist_i_h_wts[3,17]=-7.73186792284217e-003;
    __statist_i_h_wts[3,18]=-3.29789193016993e-002;
    __statist_i_h_wts[3,19]=-4.03721429847890e-002;
    __statist_i_h_wts[3,20]=1.54013731808284e-002;
    __statist_i_h_wts[3,21]=-9.50318104235824e-003;
    __statist_i_h_wts[3,22]=-3.37243299160928e-002;
    __statist_i_h_wts[3,23]=-1.88967992989129e-002;
    __statist_i_h_wts[3,24]=-3.56593196608882e-002;
    __statist_i_h_wts[3,25]=-1.30584410060809e-002;
    __statist_i_h_wts[3,26]=-3.20642516934178e-002;
    __statist_i_h_wts[3,27]=2.41584430038469e-002;
    __statist_i_h_wts[3,28]=7.21497322056559e-002;
    __statist_i_h_wts[3,29]=3.13792413841383e-002;
    __statist_i_h_wts[3,30]=1.31530336751187e-002;
    __statist_i_h_wts[3,31]=-1.52053216127349e-002;
    __statist_i_h_wts[3,32]=4.33607900254105e-002;
    __statist_i_h_wts[3,33]=-3.44070892299285e-002;
    __statist_i_h_wts[3,34]=-3.65966542485112e-003;
    __statist_i_h_wts[3,35]=2.32003203463410e-002;
    __statist_i_h_wts[3,36]=-9.14573265792993e-003;
    __statist_i_h_wts[3,37]=1.22588055417834e-002;
    __statist_i_h_wts[3,38]=4.90912215257657e-005;
    __statist_i_h_wts[3,39]=-1.50234150116957e-002;
    __statist_i_h_wts[3,40]=3.34580188107711e-003;
    __statist_i_h_wts[3,41]=3.21775755874665e-003;
    __statist_i_h_wts[3,42]=2.09011048788611e-002;
    __statist_i_h_wts[3,43]=7.86631462969846e-002;
    __statist_i_h_wts[3,44]=8.49433404976538e-002;
    __statist_i_h_wts[3,45]=2.86002987355034e-002;
    __statist_i_h_wts[3,46]=7.02530664765300e-003;
    __statist_i_h_wts[3,47]=8.77308492427223e-002;
    __statist_i_h_wts[3,48]=1.20352627229457e-002;
    __statist_i_h_wts[3,49]=6.99271542864555e-002;
    __statist_i_h_wts[3,50]=5.28071741965003e-002;
    __statist_i_h_wts[3,51]=8.71235083737792e-002;
    __statist_i_h_wts[3,52]=5.59049938592442e-002;
    __statist_i_h_wts[3,53]=4.87861797718397e-002;
    __statist_i_h_wts[3,54]=4.05740844307169e-002;
    __statist_i_h_wts[3,55]=3.98719724958628e-002;
    __statist_i_h_wts[3,56]=3.50793158322207e-002;
    __statist_i_h_wts[3,57]=8.25590319879358e-002;
    __statist_i_h_wts[3,58]=8.17456714345999e-002;
    __statist_i_h_wts[3,59]=1.14759180097526e-001;
    __statist_i_h_wts[3,60]=4.03147767839438e-002;
    __statist_i_h_wts[3,61]=5.68481974140627e-002;
    __statist_i_h_wts[3,62]=1.06567378685349e-001;
    __statist_i_h_wts[3,63]=8.09386693989716e-002;
    __statist_i_h_wts[3,64]=1.01109981319672e-001;
    __statist_i_h_wts[3,65]=7.92706386622491e-002;
    __statist_i_h_wts[3,66]=1.43418802226547e-001;
    __statist_i_h_wts[3,67]=1.00330562050954e-001;
    __statist_i_h_wts[3,68]=8.69078731703806e-002;
    __statist_i_h_wts[3,69]=4.63998854720140e-002;
    __statist_i_h_wts[3,70]=9.63209973690685e-002;
    __statist_i_h_wts[3,71]=7.85914648570190e-002;
    __statist_i_h_wts[3,72]=1.10043981133630e-001;
    __statist_i_h_wts[3,73]=8.51877728028160e-002;
    __statist_i_h_wts[3,74]=9.79032384383055e-002;
    __statist_i_h_wts[3,75]=-1.11604162309530e-002;
    __statist_i_h_wts[3,76]=1.86839419807764e-002;
    __statist_i_h_wts[3,77]=5.02628171866603e-002;
    __statist_i_h_wts[3,78]=8.40267413370667e-002;
    __statist_i_h_wts[3,79]=1.04656838342145e-001;
    __statist_i_h_wts[3,80]=8.74381745326343e-002;
    __statist_i_h_wts[3,81]=1.53772569421607e-001;
    __statist_i_h_wts[3,82]=1.08053663536592e-001;
    __statist_i_h_wts[3,83]=8.54798238689356e-002;
    __statist_i_h_wts[3,84]=2.00877035667260e-002;
    __statist_i_h_wts[3,85]=6.82252651787505e-002;
    __statist_i_h_wts[3,86]=8.57875699020043e-002;
    __statist_i_h_wts[3,87]=6.24380606952526e-002;
    __statist_i_h_wts[3,88]=6.45736584570041e-002;
    __statist_i_h_wts[3,89]=3.24711032447480e-002;
    __statist_i_h_wts[3,90]=1.31837405616327e-002;
    __statist_i_h_wts[3,91]=9.47709819752693e-003;
    __statist_i_h_wts[3,92]=8.38108657039370e-002;
    __statist_i_h_wts[3,93]=8.50409022960131e-002;
    __statist_i_h_wts[3,94]=8.62469845788795e-002;
    __statist_i_h_wts[3,95]=8.81955969596799e-002;
    __statist_i_h_wts[3,96]=8.31823408299529e-002;
    __statist_i_h_wts[3,97]=8.66974004636154e-002;
    __statist_i_h_wts[3,98]=4.00178043374283e-002;
    __statist_i_h_wts[3,99]=1.73705514662724e-003;
    __statist_i_h_wts[3,100]=2.25905686507984e-002;
    __statist_i_h_wts[3,101]=4.25876035235672e-002;
    __statist_i_h_wts[3,102]=4.77241633845017e-002;
    __statist_i_h_wts[3,103]=3.91881862059651e-002;
    __statist_i_h_wts[3,104]=3.42471330727897e-002;
    __statist_i_h_wts[3,105]=3.26987051732350e-002;
    __statist_i_h_wts[3,106]=2.77343719752395e-002;
    __statist_i_h_wts[3,107]=2.89876391603136e-002;
    __statist_i_h_wts[3,108]=1.43531737836674e-002;
    __statist_i_h_wts[3,109]=3.79620288480157e-002;
    __statist_i_h_wts[3,110]=3.14645755003845e-002;
    __statist_i_h_wts[3,111]=3.86718955141876e-002;
    __statist_i_h_wts[3,112]=7.89528030070908e-002;
    __statist_i_h_wts[3,113]=2.94666183626447e-002;
    __statist_i_h_wts[3,114]=-3.44445647758441e-002;
    __statist_i_h_wts[3,115]=3.80937180863271e-002;
    __statist_i_h_wts[3,116]=5.56009813244191e-002;
    __statist_i_h_wts[3,117]=3.99595953240314e-002;
    __statist_i_h_wts[3,118]=6.34582575265515e-002;
    __statist_i_h_wts[3,119]=3.35642362766668e-002;
    __statist_i_h_wts[3,120]=-1.95370726257163e-003;
    __statist_i_h_wts[3,121]=1.17920716047222e-002;
    __statist_i_h_wts[3,122]=-3.33639078676118e-003;
    __statist_i_h_wts[3,123]=-1.44653191433511e-002;
    __statist_i_h_wts[3,124]=1.20708913247983e-002;
    __statist_i_h_wts[3,125]=3.17125555449883e-002;
    __statist_i_h_wts[3,126]=3.19850140123375e-002;
    __statist_i_h_wts[3,127]=8.39165974867318e-002;
    __statist_i_h_wts[3,128]=1.74226282635468e-002;
    __statist_i_h_wts[3,129]=-7.24975149121034e-002;
    __statist_i_h_wts[3,130]=-1.30245841131408e-002;
    __statist_i_h_wts[3,131]=-3.04015880553254e-002;
    __statist_i_h_wts[3,132]=-1.55767372748402e-002;
    __statist_i_h_wts[3,133]=-1.86784516030575e-002;
    __statist_i_h_wts[3,134]=6.34174776871314e-003;
    __statist_i_h_wts[3,135]=2.54488313045056e-002;
    __statist_i_h_wts[3,136]=6.80976894409620e-003;
    __statist_i_h_wts[3,137]=1.07354633875278e-002;
    __statist_i_h_wts[3,138]=6.01352745253708e-003;
    __statist_i_h_wts[3,139]=3.99761703039373e-002;
    __statist_i_h_wts[3,140]=1.00172474577024e-003;
    __statist_i_h_wts[3,141]=-2.94550345963301e-002;
    __statist_i_h_wts[3,142]=3.64044420992787e-002;
    __statist_i_h_wts[3,143]=-2.68651409596366e-002;
    __statist_i_h_wts[3,144]=-8.37816694538773e-002;
    __statist_i_h_wts[3,145]=-2.60459439409411e-002;
    __statist_i_h_wts[3,146]=-4.43788245964432e-002;
    __statist_i_h_wts[3,147]=-4.56280706894293e-002;
    __statist_i_h_wts[3,148]=1.56939411068093e-002;
    __statist_i_h_wts[3,149]=1.56688906995279e-002;
    __statist_i_h_wts[3,150]=5.72445930627821e-002;
    __statist_i_h_wts[3,151]=5.08031927251716e-002;
    __statist_i_h_wts[3,152]=2.51529108372017e-002;
    __statist_i_h_wts[3,153]=4.90675421627141e-002;
    __statist_i_h_wts[3,154]=4.98793611060920e-002;
    __statist_i_h_wts[3,155]=1.62247158386808e-002;
    __statist_i_h_wts[3,156]=1.74723203721877e-002;
    __statist_i_h_wts[3,157]=5.01798854516088e-002;
    __statist_i_h_wts[3,158]=-2.06269297749669e-002;
    __statist_i_h_wts[3,159]=-2.44400360234025e-002;
    __statist_i_h_wts[3,160]=2.79291487493256e-002;
    __statist_i_h_wts[3,161]=1.80182574563326e-002;
    __statist_i_h_wts[3,162]=3.24638800229898e-003;
    __statist_i_h_wts[3,163]=6.66378470805717e-002;
    __statist_i_h_wts[3,164]=8.96629899296442e-002;
    __statist_i_h_wts[3,165]=4.13442370825168e-002;
    __statist_i_h_wts[3,166]=5.46838571871887e-002;
    __statist_i_h_wts[3,167]=4.39518205895095e-002;
    __statist_i_h_wts[3,168]=4.99853885970916e-002;
    __statist_i_h_wts[3,169]=1.37415510012472e-002;
    __statist_i_h_wts[3,170]=3.16033255672346e-002;
    __statist_i_h_wts[3,171]=2.65728312910587e-002;
    __statist_i_h_wts[3,172]=4.83671759448787e-002;
    __statist_i_h_wts[3,173]=-3.16635439357406e-002;
    __statist_i_h_wts[3,174]=-5.77648212337837e-002;
    __statist_i_h_wts[3,175]=9.39598409546934e-004;
    __statist_i_h_wts[3,176]=3.77780567306364e-002;
    __statist_i_h_wts[3,177]=4.34484624819151e-002;
    __statist_i_h_wts[3,178]=1.11348894298302e-001;
    __statist_i_h_wts[3,179]=1.00064569042990e-001;
    __statist_i_h_wts[3,180]=2.72376166703058e-002;
    __statist_i_h_wts[3,181]=6.43333980014183e-002;
    __statist_i_h_wts[3,182]=2.45451437429103e-002;
    __statist_i_h_wts[3,183]=1.80266351165246e-002;
    __statist_i_h_wts[3,184]=1.56530303543006e-002;
    __statist_i_h_wts[3,185]=2.94678342600995e-002;
    __statist_i_h_wts[3,186]=3.56289256793143e-002;
    __statist_i_h_wts[3,187]=3.08205934578204e-002;
    __statist_i_h_wts[3,188]=1.34977488377587e-002;
    __statist_i_h_wts[3,189]=2.87024804556568e-002;
    __statist_i_h_wts[3,190]=4.60298763931878e-002;
    __statist_i_h_wts[3,191]=7.67464138105793e-002;
    __statist_i_h_wts[3,192]=6.59098576558021e-002;
    __statist_i_h_wts[3,193]=5.73810624473113e-002;
    __statist_i_h_wts[3,194]=5.11768001661496e-002;
    __statist_i_h_wts[3,195]=1.96826095083818e-002;
    __statist_i_h_wts[3,196]=4.29021595193428e-002;
    __statist_i_h_wts[3,197]=2.36558782998452e-002;
    __statist_i_h_wts[3,198]=3.62925575460014e-002;
    __statist_i_h_wts[3,199]=4.03923378832945e-002;
    __statist_i_h_wts[3,200]=4.88166064949719e-002;
    __statist_i_h_wts[3,201]=6.13424410944862e-002;
    __statist_i_h_wts[3,202]=9.15826193095642e-002;
    __statist_i_h_wts[3,203]=6.93051130319219e-002;
    __statist_i_h_wts[3,204]=3.99546417247117e-002;
    __statist_i_h_wts[3,205]=4.50860858495850e-002;
    __statist_i_h_wts[3,206]=1.11906452570668e-001;
    __statist_i_h_wts[3,207]=3.65837535583242e-002;
    __statist_i_h_wts[3,208]=2.12449090155383e-002;
    __statist_i_h_wts[3,209]=1.99502834095921e-002;
    __statist_i_h_wts[3,210]=4.59271246337837e-002;
    __statist_i_h_wts[3,211]=5.41796629499244e-002;
    __statist_i_h_wts[3,212]=6.24279047832297e-002;
    __statist_i_h_wts[3,213]=5.14542024662527e-002;
    __statist_i_h_wts[3,214]=4.75383406319090e-002;
    __statist_i_h_wts[3,215]=4.64950863419431e-002;
    __statist_i_h_wts[3,216]=6.63105911029169e-002;
    __statist_i_h_wts[3,217]=1.05347085251639e-001;
    __statist_i_h_wts[3,218]=9.32405232025754e-002;
    __statist_i_h_wts[3,219]=6.41063091406809e-002;
    __statist_i_h_wts[3,220]=5.32457588965115e-002;
    __statist_i_h_wts[3,221]=8.50413686870007e-002;
    __statist_i_h_wts[3,222]=2.50321266601466e-002;
    __statist_i_h_wts[3,223]=-2.96352693332919e-002;
    __statist_i_h_wts[3,224]=2.34356208282390e-002;
    __statist_i_h_wts[3,225]=-4.71653524212128e-002;
    __statist_i_h_wts[3,226]=7.64136597749455e-002;
    __statist_i_h_wts[3,227]=-1.77017120319635e-002;
    __statist_i_h_wts[3,228]=6.31204911167274e-002;
    __statist_i_h_wts[3,229]=-2.27488379933872e-002;
    __statist_i_h_wts[3,230]=6.12304722826918e-002;
    __statist_i_h_wts[3,231]=1.05391176938267e-001;
    __statist_i_h_wts[3,232]=6.66083858052658e-002;
    __statist_i_h_wts[3,233]=6.10235857553283e-002;
    __statist_i_h_wts[3,234]=2.62878526825084e-001;
    __statist_i_h_wts[3,235]=5.14985862939656e-002;
    __statist_i_h_wts[3,236]=2.10101646795075e-001;
    __statist_i_h_wts[3,237]=-6.41995284074847e-001;
    __statist_i_h_wts[3,238]=-2.52166223150726e-001;
    __statist_i_h_wts[3,239]=1.81104800480704e-002;
    __statist_i_h_wts[3,240]=1.52279889644950e-001;
    __statist_i_h_wts[3,241]=1.31676126208525e-001;
    __statist_i_h_wts[3,242]=1.61409168725205e-002;
    __statist_i_h_wts[3,243]=-9.20679046745075e-002;
    __statist_i_h_wts[3,244]=3.56671533641712e-002;
    __statist_i_h_wts[3,245]=1.23508681701394e-001;
    __statist_i_h_wts[3,246]=6.69026425911521e-002;
    __statist_i_h_wts[3,247]=7.62379577510282e-002;
    __statist_i_h_wts[3,248]=-1.33935790441943e-001;

    __statist_i_h_wts[4,0]=9.95466212954774e-002;
    __statist_i_h_wts[4,1]=1.12323164100133e-001;
    __statist_i_h_wts[4,2]=4.53661780775748e-002;
    __statist_i_h_wts[4,3]=1.41601539683626e-001;
    __statist_i_h_wts[4,4]=1.49503683424968e-001;
    __statist_i_h_wts[4,5]=1.56797171226876e-001;
    __statist_i_h_wts[4,6]=1.03914509750768e-001;
    __statist_i_h_wts[4,7]=4.97101839955162e-002;
    __statist_i_h_wts[4,8]=6.37968679064486e-002;
    __statist_i_h_wts[4,9]=5.12222080993286e-002;
    __statist_i_h_wts[4,10]=-4.33912643029409e-002;
    __statist_i_h_wts[4,11]=-2.72783576121909e-002;
    __statist_i_h_wts[4,12]=-4.17079806482478e-002;
    __statist_i_h_wts[4,13]=-2.62321582425843e-002;
    __statist_i_h_wts[4,14]=5.73817467138168e-002;
    __statist_i_h_wts[4,15]=1.36620906967842e-001;
    __statist_i_h_wts[4,16]=1.37975825291744e-001;
    __statist_i_h_wts[4,17]=4.78272199606522e-002;
    __statist_i_h_wts[4,18]=1.59975778141115e-001;
    __statist_i_h_wts[4,19]=9.62472920509989e-002;
    __statist_i_h_wts[4,20]=8.95915119723140e-002;
    __statist_i_h_wts[4,21]=5.22224857895852e-002;
    __statist_i_h_wts[4,22]=-1.91833472776687e-003;
    __statist_i_h_wts[4,23]=5.13983313625981e-003;
    __statist_i_h_wts[4,24]=3.13752544554649e-002;
    __statist_i_h_wts[4,25]=-3.30177451310135e-002;
    __statist_i_h_wts[4,26]=7.78623802422214e-003;
    __statist_i_h_wts[4,27]=-2.22671738093694e-002;
    __statist_i_h_wts[4,28]=-3.50047461874709e-002;
    __statist_i_h_wts[4,29]=4.51912601738667e-002;
    __statist_i_h_wts[4,30]=1.87397562417022e-001;
    __statist_i_h_wts[4,31]=1.94739760811500e-001;
    __statist_i_h_wts[4,32]=5.75696599524984e-002;
    __statist_i_h_wts[4,33]=1.75078824075499e-001;
    __statist_i_h_wts[4,34]=1.02662948737332e-001;
    __statist_i_h_wts[4,35]=1.24315509719026e-001;
    __statist_i_h_wts[4,36]=1.06477509550394e-001;
    __statist_i_h_wts[4,37]=3.50947539537138e-002;
    __statist_i_h_wts[4,38]=-2.44721195761504e-002;
    __statist_i_h_wts[4,39]=-2.34431108164304e-002;
    __statist_i_h_wts[4,40]=-4.82671479617184e-002;
    __statist_i_h_wts[4,41]=-5.35281319401955e-002;
    __statist_i_h_wts[4,42]=-4.98541506530765e-002;
    __statist_i_h_wts[4,43]=-9.00170308108005e-002;
    __statist_i_h_wts[4,44]=-2.74815815606569e-002;
    __statist_i_h_wts[4,45]=1.55172148245391e-001;
    __statist_i_h_wts[4,46]=2.46495810774476e-001;
    __statist_i_h_wts[4,47]=1.46766977811258e-001;
    __statist_i_h_wts[4,48]=1.97013146670808e-001;
    __statist_i_h_wts[4,49]=1.64187523676792e-001;
    __statist_i_h_wts[4,50]=1.94143894897884e-001;
    __statist_i_h_wts[4,51]=1.30474724000467e-001;
    __statist_i_h_wts[4,52]=6.75706513197285e-002;
    __statist_i_h_wts[4,53]=-7.37376668004820e-002;
    __statist_i_h_wts[4,54]=-4.65675908732272e-002;
    __statist_i_h_wts[4,55]=-7.80928582708432e-002;
    __statist_i_h_wts[4,56]=-6.60640960841442e-002;
    __statist_i_h_wts[4,57]=-1.57634836308988e-001;
    __statist_i_h_wts[4,58]=-1.46924815559826e-001;
    __statist_i_h_wts[4,59]=-1.58095075173679e-001;
    __statist_i_h_wts[4,60]=1.73977361141706e-001;
    __statist_i_h_wts[4,61]=1.57404226952141e-001;
    __statist_i_h_wts[4,62]=1.26581918967690e-001;
    __statist_i_h_wts[4,63]=1.88903740030599e-001;
    __statist_i_h_wts[4,64]=1.53318186674283e-001;
    __statist_i_h_wts[4,65]=1.73601538192716e-001;
    __statist_i_h_wts[4,66]=1.44399309558390e-001;
    __statist_i_h_wts[4,67]=3.49365242605392e-002;
    __statist_i_h_wts[4,68]=-4.72730121790478e-002;
    __statist_i_h_wts[4,69]=1.20148003811921e-002;
    __statist_i_h_wts[4,70]=-1.55793752321848e-001;
    __statist_i_h_wts[4,71]=-1.41543408546846e-001;
    __statist_i_h_wts[4,72]=-1.65084236765528e-001;
    __statist_i_h_wts[4,73]=-1.76949052304335e-001;
    __statist_i_h_wts[4,74]=-2.16686359530445e-001;
    __statist_i_h_wts[4,75]=2.57865446814413e-001;
    __statist_i_h_wts[4,76]=2.38402450590924e-001;
    __statist_i_h_wts[4,77]=1.50846900283244e-001;
    __statist_i_h_wts[4,78]=1.38484662847611e-001;
    __statist_i_h_wts[4,79]=6.98257114354619e-002;
    __statist_i_h_wts[4,80]=-1.13556015769564e-002;
    __statist_i_h_wts[4,81]=-3.45777835871795e-002;
    __statist_i_h_wts[4,82]=-4.49184732720602e-002;
    __statist_i_h_wts[4,83]=-4.64669177830665e-002;
    __statist_i_h_wts[4,84]=-7.62710850847081e-002;
    __statist_i_h_wts[4,85]=-1.76418966942298e-001;
    __statist_i_h_wts[4,86]=-2.25686434859910e-001;
    __statist_i_h_wts[4,87]=-2.04722736377554e-001;
    __statist_i_h_wts[4,88]=-2.73677683750053e-001;
    __statist_i_h_wts[4,89]=-2.67918706988402e-001;
    __statist_i_h_wts[4,90]=2.90739384086465e-001;
    __statist_i_h_wts[4,91]=2.84096492008283e-001;
    __statist_i_h_wts[4,92]=1.87867637435496e-001;
    __statist_i_h_wts[4,93]=1.65752962138777e-001;
    __statist_i_h_wts[4,94]=1.36567688444058e-001;
    __statist_i_h_wts[4,95]=9.89160103621998e-003;
    __statist_i_h_wts[4,96]=-5.05056775364711e-002;
    __statist_i_h_wts[4,97]=-7.73164874531194e-002;
    __statist_i_h_wts[4,98]=-7.00576224417432e-002;
    __statist_i_h_wts[4,99]=-1.62250093796650e-001;
    __statist_i_h_wts[4,100]=-1.99292323772611e-001;
    __statist_i_h_wts[4,101]=-2.87203261349177e-001;
    __statist_i_h_wts[4,102]=-2.44920099996813e-001;
    __statist_i_h_wts[4,103]=-2.35128710183875e-001;
    __statist_i_h_wts[4,104]=-2.61158237869740e-001;
    __statist_i_h_wts[4,105]=2.43286864775146e-001;
    __statist_i_h_wts[4,106]=1.96218007201188e-001;
    __statist_i_h_wts[4,107]=1.64759184219740e-001;
    __statist_i_h_wts[4,108]=1.85322349003592e-001;
    __statist_i_h_wts[4,109]=1.00035694327663e-001;
    __statist_i_h_wts[4,110]=5.35294037798813e-003;
    __statist_i_h_wts[4,111]=-3.88115447654628e-002;
    __statist_i_h_wts[4,112]=-4.24737559762041e-002;
    __statist_i_h_wts[4,113]=-4.78679432641815e-003;
    __statist_i_h_wts[4,114]=-1.06979223838315e-002;
    __statist_i_h_wts[4,115]=-9.79180222751838e-002;
    __statist_i_h_wts[4,116]=-2.28553598743707e-001;
    __statist_i_h_wts[4,117]=-1.81335994538564e-001;
    __statist_i_h_wts[4,118]=-1.84767516336307e-001;
    __statist_i_h_wts[4,119]=-2.01570335821013e-001;
    __statist_i_h_wts[4,120]=2.31841094173020e-001;
    __statist_i_h_wts[4,121]=1.85239150302252e-001;
    __statist_i_h_wts[4,122]=1.46482301304029e-001;
    __statist_i_h_wts[4,123]=1.51969254972203e-001;
    __statist_i_h_wts[4,124]=8.03115334484114e-002;
    __statist_i_h_wts[4,125]=-6.34765893065099e-002;
    __statist_i_h_wts[4,126]=-1.13970018300663e-001;
    __statist_i_h_wts[4,127]=-1.36615334790416e-001;
    __statist_i_h_wts[4,128]=-9.34258738313253e-002;
    __statist_i_h_wts[4,129]=-2.03273924471770e-002;
    __statist_i_h_wts[4,130]=-1.09948274775375e-001;
    __statist_i_h_wts[4,131]=-1.75677821362399e-001;
    __statist_i_h_wts[4,132]=-1.79886608794075e-001;
    __statist_i_h_wts[4,133]=-1.87763312791897e-001;
    __statist_i_h_wts[4,134]=-2.32010377027129e-001;
    __statist_i_h_wts[4,135]=1.87730118984348e-001;
    __statist_i_h_wts[4,136]=1.98229635199520e-001;
    __statist_i_h_wts[4,137]=1.58646688725602e-001;
    __statist_i_h_wts[4,138]=1.48378531108548e-001;
    __statist_i_h_wts[4,139]=8.79125582205784e-002;
    __statist_i_h_wts[4,140]=1.03143494590339e-001;
    __statist_i_h_wts[4,141]=3.44565790940635e-002;
    __statist_i_h_wts[4,142]=-6.81097982488129e-002;
    __statist_i_h_wts[4,143]=-5.77999020461210e-002;
    __statist_i_h_wts[4,144]=-5.75297285612913e-002;
    __statist_i_h_wts[4,145]=-1.31372099212221e-001;
    __statist_i_h_wts[4,146]=-1.71684642581454e-001;
    __statist_i_h_wts[4,147]=-1.23716722795496e-001;
    __statist_i_h_wts[4,148]=-1.83166502686651e-001;
    __statist_i_h_wts[4,149]=-2.22405512949301e-001;
    __statist_i_h_wts[4,150]=1.62033259094628e-001;
    __statist_i_h_wts[4,151]=1.48955302442705e-001;
    __statist_i_h_wts[4,152]=1.95850666029934e-001;
    __statist_i_h_wts[4,153]=1.54219675332617e-001;
    __statist_i_h_wts[4,154]=1.25912600034918e-001;
    __statist_i_h_wts[4,155]=1.19647473327260e-001;
    __statist_i_h_wts[4,156]=9.33867196036646e-002;
    __statist_i_h_wts[4,157]=-4.11806193503217e-002;
    __statist_i_h_wts[4,158]=-7.52867001452370e-002;
    __statist_i_h_wts[4,159]=-6.73393199139055e-002;
    __statist_i_h_wts[4,160]=-7.94343186422237e-002;
    __statist_i_h_wts[4,161]=-1.41837694747120e-001;
    __statist_i_h_wts[4,162]=-1.09602057456665e-001;
    __statist_i_h_wts[4,163]=-1.51663088191834e-001;
    __statist_i_h_wts[4,164]=-1.83956633569632e-001;
    __statist_i_h_wts[4,165]=1.63793285663034e-001;
    __statist_i_h_wts[4,166]=1.34823644211695e-001;
    __statist_i_h_wts[4,167]=1.68743965978667e-001;
    __statist_i_h_wts[4,168]=1.68209341668303e-001;
    __statist_i_h_wts[4,169]=1.49853729017256e-001;
    __statist_i_h_wts[4,170]=1.11250249775435e-001;
    __statist_i_h_wts[4,171]=6.10231070755764e-002;
    __statist_i_h_wts[4,172]=-1.20172580655849e-003;
    __statist_i_h_wts[4,173]=-2.33686608561329e-002;
    __statist_i_h_wts[4,174]=-3.89932239620888e-002;
    __statist_i_h_wts[4,175]=-7.69321179231888e-002;
    __statist_i_h_wts[4,176]=-1.22698946158569e-001;
    __statist_i_h_wts[4,177]=-1.13230210185890e-001;
    __statist_i_h_wts[4,178]=-2.01781831979156e-001;
    __statist_i_h_wts[4,179]=-1.70885189472573e-001;
    __statist_i_h_wts[4,180]=9.80933014622534e-002;
    __statist_i_h_wts[4,181]=1.19758739754153e-001;
    __statist_i_h_wts[4,182]=1.80760614077946e-001;
    __statist_i_h_wts[4,183]=1.89047831446597e-001;
    __statist_i_h_wts[4,184]=1.83906008469828e-001;
    __statist_i_h_wts[4,185]=1.52883531254341e-001;
    __statist_i_h_wts[4,186]=8.08083156131624e-002;
    __statist_i_h_wts[4,187]=4.45387081912053e-002;
    __statist_i_h_wts[4,188]=-1.19753578899830e-002;
    __statist_i_h_wts[4,189]=-6.30346491607667e-002;
    __statist_i_h_wts[4,190]=-1.05064065621939e-001;
    __statist_i_h_wts[4,191]=-9.49549470112322e-002;
    __statist_i_h_wts[4,192]=-9.91553721513152e-002;
    __statist_i_h_wts[4,193]=-6.94176904572341e-002;
    __statist_i_h_wts[4,194]=-7.82381785646449e-002;
    __statist_i_h_wts[4,195]=9.67658114814826e-002;
    __statist_i_h_wts[4,196]=7.71256790378501e-002;
    __statist_i_h_wts[4,197]=1.25660698788206e-001;
    __statist_i_h_wts[4,198]=8.22158623298163e-002;
    __statist_i_h_wts[4,199]=7.78402340457517e-002;
    __statist_i_h_wts[4,200]=2.96416991776616e-002;
    __statist_i_h_wts[4,201]=-3.17403242523920e-002;
    __statist_i_h_wts[4,202]=-2.13048545289853e-002;
    __statist_i_h_wts[4,203]=-6.76487682546379e-002;
    __statist_i_h_wts[4,204]=-1.25374291705948e-001;
    __statist_i_h_wts[4,205]=-9.82282068753444e-002;
    __statist_i_h_wts[4,206]=-7.76612791911858e-002;
    __statist_i_h_wts[4,207]=-6.59714935942891e-002;
    __statist_i_h_wts[4,208]=-1.38041294669192e-002;
    __statist_i_h_wts[4,209]=-9.91335705664203e-003;
    __statist_i_h_wts[4,210]=7.26640807367981e-002;
    __statist_i_h_wts[4,211]=4.61720204885071e-002;
    __statist_i_h_wts[4,212]=7.31359983230700e-002;
    __statist_i_h_wts[4,213]=7.04531464728083e-002;
    __statist_i_h_wts[4,214]=5.97131477326894e-002;
    __statist_i_h_wts[4,215]=1.38138715886005e-002;
    __statist_i_h_wts[4,216]=-8.21749672477833e-003;
    __statist_i_h_wts[4,217]=3.23487873092561e-003;
    __statist_i_h_wts[4,218]=-5.11945271871191e-002;
    __statist_i_h_wts[4,219]=-8.29476862294801e-002;
    __statist_i_h_wts[4,220]=-7.78369631652550e-002;
    __statist_i_h_wts[4,221]=-6.24994543261533e-002;
    __statist_i_h_wts[4,222]=-5.13851415275306e-002;
    __statist_i_h_wts[4,223]=-2.04770375358187e-002;
    __statist_i_h_wts[4,224]=-1.61726269478901e-002;
    __statist_i_h_wts[4,225]=7.33322046379731e-002;
    __statist_i_h_wts[4,226]=-2.47236371566188e-001;
    __statist_i_h_wts[4,227]=5.78571442458791e-002;
    __statist_i_h_wts[4,228]=-2.15834981271165e-001;
    __statist_i_h_wts[4,229]=-2.27772877841491e-002;
    __statist_i_h_wts[4,230]=1.39792415966879e-001;
    __statist_i_h_wts[4,231]=-7.37598397134613e-002;
    __statist_i_h_wts[4,232]=9.79244480269677e-002;
    __statist_i_h_wts[4,233]=2.47006829513855e-002;
    __statist_i_h_wts[4,234]=2.78761102402894e-002;
    __statist_i_h_wts[4,235]=-9.98294074068485e-002;
    __statist_i_h_wts[4,236]=-4.14702263353927e-001;
    __statist_i_h_wts[4,237]=2.62887905672045e-001;
    __statist_i_h_wts[4,238]=1.66858455042651e-001;
    __statist_i_h_wts[4,239]=1.84192942825564e-001;
    __statist_i_h_wts[4,240]=-2.84266287698230e-001;
    __statist_i_h_wts[4,241]=5.72774804207175e-002;
    __statist_i_h_wts[4,242]=3.12456352141522e-002;
    __statist_i_h_wts[4,243]=3.20938124990493e-001;
    __statist_i_h_wts[4,244]=2.27991253866778e-002;
    __statist_i_h_wts[4,245]=-3.12970940400821e-001;
    __statist_i_h_wts[4,246]=-1.77204302130100e-002;
    __statist_i_h_wts[4,247]=-3.28739892943165e-001;
    __statist_i_h_wts[4,248]=1.50880098134243e-001;

    __statist_i_h_wts[5,0]=-2.10217289282113e-001;
    __statist_i_h_wts[5,1]=-1.31532552837717e-001;
    __statist_i_h_wts[5,2]=-7.92390947178748e-002;
    __statist_i_h_wts[5,3]=-9.22823284268620e-004;
    __statist_i_h_wts[5,4]=3.74322150853546e-002;
    __statist_i_h_wts[5,5]=5.04012450560241e-002;
    __statist_i_h_wts[5,6]=5.48035947360503e-003;
    __statist_i_h_wts[5,7]=-7.62147921700288e-002;
    __statist_i_h_wts[5,8]=-3.97065459315270e-002;
    __statist_i_h_wts[5,9]=6.38354206953508e-003;
    __statist_i_h_wts[5,10]=-2.43961837490427e-003;
    __statist_i_h_wts[5,11]=-2.85342798401356e-002;
    __statist_i_h_wts[5,12]=-7.27745199053502e-002;
    __statist_i_h_wts[5,13]=4.52554275682590e-002;
    __statist_i_h_wts[5,14]=1.24884248285360e-001;
    __statist_i_h_wts[5,15]=-1.81711180605039e-001;
    __statist_i_h_wts[5,16]=-9.60037441499783e-002;
    __statist_i_h_wts[5,17]=-1.12988441567056e-001;
    __statist_i_h_wts[5,18]=-3.93232296942638e-002;
    __statist_i_h_wts[5,19]=-4.32093164018648e-002;
    __statist_i_h_wts[5,20]=-8.21055041666048e-002;
    __statist_i_h_wts[5,21]=-8.60474929428512e-002;
    __statist_i_h_wts[5,22]=-1.09211352282214e-001;
    __statist_i_h_wts[5,23]=-9.42141486870370e-002;
    __statist_i_h_wts[5,24]=-5.68597001088445e-002;
    __statist_i_h_wts[5,25]=2.34453922515333e-002;
    __statist_i_h_wts[5,26]=9.45999975633435e-002;
    __statist_i_h_wts[5,27]=5.66119194488019e-002;
    __statist_i_h_wts[5,28]=5.66593276591050e-002;
    __statist_i_h_wts[5,29]=1.36515598214021e-001;
    __statist_i_h_wts[5,30]=-5.04602027082315e-002;
    __statist_i_h_wts[5,31]=4.82557247862751e-003;
    __statist_i_h_wts[5,32]=-6.17623242891186e-002;
    __statist_i_h_wts[5,33]=1.09640764103397e-001;
    __statist_i_h_wts[5,34]=3.79021833213267e-002;
    __statist_i_h_wts[5,35]=2.32402568053340e-002;
    __statist_i_h_wts[5,36]=7.68426235206321e-002;
    __statist_i_h_wts[5,37]=2.72048675440912e-002;
    __statist_i_h_wts[5,38]=-7.41234001973197e-003;
    __statist_i_h_wts[5,39]=3.51960283037466e-002;
    __statist_i_h_wts[5,40]=5.61000629972157e-002;
    __statist_i_h_wts[5,41]=5.42999181833157e-002;
    __statist_i_h_wts[5,42]=9.51700975830363e-002;
    __statist_i_h_wts[5,43]=3.13682130231039e-002;
    __statist_i_h_wts[5,44]=8.69544064963453e-002;
    __statist_i_h_wts[5,45]=-3.46561744970304e-002;
    __statist_i_h_wts[5,46]=7.00089571939851e-002;
    __statist_i_h_wts[5,47]=-2.65223903462620e-002;
    __statist_i_h_wts[5,48]=8.10450495799697e-002;
    __statist_i_h_wts[5,49]=-4.75095853645497e-002;
    __statist_i_h_wts[5,50]=8.73566171888456e-002;
    __statist_i_h_wts[5,51]=4.60163337379513e-002;
    __statist_i_h_wts[5,52]=1.12212251643078e-001;
    __statist_i_h_wts[5,53]=3.78001869967417e-002;
    __statist_i_h_wts[5,54]=1.05653166120436e-001;
    __statist_i_h_wts[5,55]=6.61116646958867e-002;
    __statist_i_h_wts[5,56]=6.69482817903271e-002;
    __statist_i_h_wts[5,57]=-1.07965040685918e-002;
    __statist_i_h_wts[5,58]=3.07344083836445e-002;
    __statist_i_h_wts[5,59]=-3.19429002387887e-003;
    __statist_i_h_wts[5,60]=-1.11721126172313e-001;
    __statist_i_h_wts[5,61]=-4.86427023437288e-002;
    __statist_i_h_wts[5,62]=-8.29518472803399e-002;
    __statist_i_h_wts[5,63]=1.77111052696162e-002;
    __statist_i_h_wts[5,64]=2.31108720778777e-002;
    __statist_i_h_wts[5,65]=9.59776151794951e-002;
    __statist_i_h_wts[5,66]=8.56386313197843e-002;
    __statist_i_h_wts[5,67]=1.14304170620683e-001;
    __statist_i_h_wts[5,68]=1.34993892330299e-002;
    __statist_i_h_wts[5,69]=1.07712542039703e-001;
    __statist_i_h_wts[5,70]=1.94081868024089e-002;
    __statist_i_h_wts[5,71]=3.29563344752440e-002;
    __statist_i_h_wts[5,72]=2.86990770564161e-002;
    __statist_i_h_wts[5,73]=9.78931173493815e-002;
    __statist_i_h_wts[5,74]=4.11448668256030e-002;
    __statist_i_h_wts[5,75]=1.38869467378251e-002;
    __statist_i_h_wts[5,76]=6.32007174763700e-003;
    __statist_i_h_wts[5,77]=-3.59584239408474e-002;
    __statist_i_h_wts[5,78]=-4.75171312098887e-003;
    __statist_i_h_wts[5,79]=-2.34639106222184e-002;
    __statist_i_h_wts[5,80]=2.14969094496415e-002;
    __statist_i_h_wts[5,81]=-6.07777156583584e-004;
    __statist_i_h_wts[5,82]=7.24059597728694e-002;
    __statist_i_h_wts[5,83]=5.31633709314364e-002;
    __statist_i_h_wts[5,84]=1.21693601007886e-001;
    __statist_i_h_wts[5,85]=7.50870031525963e-002;
    __statist_i_h_wts[5,86]=-3.20028334188704e-002;
    __statist_i_h_wts[5,87]=3.78962858911806e-002;
    __statist_i_h_wts[5,88]=2.08125970017481e-002;
    __statist_i_h_wts[5,89]=5.67040219301272e-002;
    __statist_i_h_wts[5,90]=-7.43129091600111e-002;
    __statist_i_h_wts[5,91]=4.42367371455630e-002;
    __statist_i_h_wts[5,92]=-8.89279937140918e-003;
    __statist_i_h_wts[5,93]=1.45002198342124e-002;
    __statist_i_h_wts[5,94]=4.39182021268506e-002;
    __statist_i_h_wts[5,95]=5.55956757732141e-002;
    __statist_i_h_wts[5,96]=5.26316539802261e-002;
    __statist_i_h_wts[5,97]=8.69976164777209e-002;
    __statist_i_h_wts[5,98]=6.01537257823894e-002;
    __statist_i_h_wts[5,99]=9.48693509747940e-002;
    __statist_i_h_wts[5,100]=1.02062850743807e-001;
    __statist_i_h_wts[5,101]=-1.29947357374738e-003;
    __statist_i_h_wts[5,102]=2.01709756231728e-002;
    __statist_i_h_wts[5,103]=4.70252621092295e-002;
    __statist_i_h_wts[5,104]=1.88001027673473e-002;
    __statist_i_h_wts[5,105]=-1.10643652191937e-001;
    __statist_i_h_wts[5,106]=-3.14838235888247e-002;
    __statist_i_h_wts[5,107]=-3.64416876130522e-002;
    __statist_i_h_wts[5,108]=5.47990295382800e-002;
    __statist_i_h_wts[5,109]=4.41830269789680e-002;
    __statist_i_h_wts[5,110]=1.03274235762442e-001;
    __statist_i_h_wts[5,111]=9.65211417167565e-002;
    __statist_i_h_wts[5,112]=1.19787715507776e-001;
    __statist_i_h_wts[5,113]=1.36445813671983e-001;
    __statist_i_h_wts[5,114]=2.01638926112008e-001;
    __statist_i_h_wts[5,115]=1.16656410553426e-001;
    __statist_i_h_wts[5,116]=5.87200226356789e-003;
    __statist_i_h_wts[5,117]=2.98760241159701e-002;
    __statist_i_h_wts[5,118]=1.54968574097110e-002;
    __statist_i_h_wts[5,119]=6.30207043830014e-002;
    __statist_i_h_wts[5,120]=-8.20137350296685e-002;
    __statist_i_h_wts[5,121]=-6.07197883853797e-002;
    __statist_i_h_wts[5,122]=-2.11522144919919e-002;
    __statist_i_h_wts[5,123]=5.84432929859383e-002;
    __statist_i_h_wts[5,124]=5.28718506215558e-002;
    __statist_i_h_wts[5,125]=2.26476036602835e-002;
    __statist_i_h_wts[5,126]=2.46350350682357e-002;
    __statist_i_h_wts[5,127]=-1.26631300239227e-002;
    __statist_i_h_wts[5,128]=-5.13940512325781e-002;
    __statist_i_h_wts[5,129]=1.23837480037898e-001;
    __statist_i_h_wts[5,130]=1.55911638074790e-001;
    __statist_i_h_wts[5,131]=9.92186545568464e-002;
    __statist_i_h_wts[5,132]=1.07492450463198e-001;
    __statist_i_h_wts[5,133]=1.29718203213916e-001;
    __statist_i_h_wts[5,134]=1.05795526318995e-001;
    __statist_i_h_wts[5,135]=-7.72443780744153e-002;
    __statist_i_h_wts[5,136]=-7.01623015100810e-002;
    __statist_i_h_wts[5,137]=-6.40797778208695e-002;
    __statist_i_h_wts[5,138]=1.67932315643176e-003;
    __statist_i_h_wts[5,139]=-4.40172529940294e-002;
    __statist_i_h_wts[5,140]=9.61843856586413e-002;
    __statist_i_h_wts[5,141]=6.98341932082056e-002;
    __statist_i_h_wts[5,142]=-5.16077306412216e-004;
    __statist_i_h_wts[5,143]=-4.33050991081827e-002;
    __statist_i_h_wts[5,144]=4.52144684828088e-002;
    __statist_i_h_wts[5,145]=9.02474528251292e-002;
    __statist_i_h_wts[5,146]=1.35759041216188e-001;
    __statist_i_h_wts[5,147]=1.19925028055022e-001;
    __statist_i_h_wts[5,148]=7.95240773177141e-002;
    __statist_i_h_wts[5,149]=1.05313160815725e-001;
    __statist_i_h_wts[5,150]=-1.72432314228515e-001;
    __statist_i_h_wts[5,151]=-1.31379717547805e-001;
    __statist_i_h_wts[5,152]=-6.33522724570979e-002;
    __statist_i_h_wts[5,153]=-8.31269264788186e-002;
    __statist_i_h_wts[5,154]=-4.43711793978327e-002;
    __statist_i_h_wts[5,155]=3.29716612108955e-002;
    __statist_i_h_wts[5,156]=2.33811242951088e-002;
    __statist_i_h_wts[5,157]=-3.74982415481976e-002;
    __statist_i_h_wts[5,158]=-4.19176799557067e-002;
    __statist_i_h_wts[5,159]=-5.40251196408319e-003;
    __statist_i_h_wts[5,160]=3.77507145291960e-003;
    __statist_i_h_wts[5,161]=5.16265332747425e-002;
    __statist_i_h_wts[5,162]=5.79097314683864e-002;
    __statist_i_h_wts[5,163]=1.54376596445975e-002;
    __statist_i_h_wts[5,164]=3.23525405524039e-002;
    __statist_i_h_wts[5,165]=-1.02134212693888e-001;
    __statist_i_h_wts[5,166]=-7.52597443094050e-002;
    __statist_i_h_wts[5,167]=-5.34918222756859e-002;
    __statist_i_h_wts[5,168]=-8.22054919657986e-002;
    __statist_i_h_wts[5,169]=-4.28122852452786e-002;
    __statist_i_h_wts[5,170]=-4.00952867664715e-002;
    __statist_i_h_wts[5,171]=-3.94528682235115e-002;
    __statist_i_h_wts[5,172]=-3.74862672311350e-002;
    __statist_i_h_wts[5,173]=-5.11946083015398e-003;
    __statist_i_h_wts[5,174]=5.91743489617138e-002;
    __statist_i_h_wts[5,175]=1.69624849087589e-002;
    __statist_i_h_wts[5,176]=3.14337080227681e-002;
    __statist_i_h_wts[5,177]=5.40069805635093e-002;
    __statist_i_h_wts[5,178]=-3.61573045504839e-002;
    __statist_i_h_wts[5,179]=5.74208728803564e-002;
    __statist_i_h_wts[5,180]=-1.00774137534620e-001;
    __statist_i_h_wts[5,181]=-8.02430083306185e-002;
    __statist_i_h_wts[5,182]=-5.22098492307853e-002;
    __statist_i_h_wts[5,183]=-3.80352317475976e-002;
    __statist_i_h_wts[5,184]=7.66934884860048e-003;
    __statist_i_h_wts[5,185]=8.86484761106891e-003;
    __statist_i_h_wts[5,186]=-1.65372943129974e-002;
    __statist_i_h_wts[5,187]=-3.01324471246702e-002;
    __statist_i_h_wts[5,188]=-3.38114957420607e-002;
    __statist_i_h_wts[5,189]=-6.23901908978034e-002;
    __statist_i_h_wts[5,190]=-8.86103715326704e-002;
    __statist_i_h_wts[5,191]=-1.04338001609951e-002;
    __statist_i_h_wts[5,192]=3.44481193662193e-002;
    __statist_i_h_wts[5,193]=7.92851727830101e-002;
    __statist_i_h_wts[5,194]=1.35238570207928e-001;
    __statist_i_h_wts[5,195]=-9.00954811201177e-002;
    __statist_i_h_wts[5,196]=-8.97933844877957e-002;
    __statist_i_h_wts[5,197]=-5.66044952231831e-002;
    __statist_i_h_wts[5,198]=-1.08192078244701e-001;
    __statist_i_h_wts[5,199]=-6.28010997446513e-002;
    __statist_i_h_wts[5,200]=-5.81687893505213e-002;
    __statist_i_h_wts[5,201]=-8.85056004773975e-002;
    __statist_i_h_wts[5,202]=-6.12035588055064e-002;
    __statist_i_h_wts[5,203]=-2.29994843513088e-002;
    __statist_i_h_wts[5,204]=-4.92154052667786e-002;
    __statist_i_h_wts[5,205]=-4.02095863914080e-002;
    __statist_i_h_wts[5,206]=-3.41456269856340e-003;
    __statist_i_h_wts[5,207]=9.39624286689981e-002;
    __statist_i_h_wts[5,208]=1.26478683119617e-001;
    __statist_i_h_wts[5,209]=1.32113264512696e-001;
    __statist_i_h_wts[5,210]=-9.52288828837622e-002;
    __statist_i_h_wts[5,211]=-9.42001929974583e-002;
    __statist_i_h_wts[5,212]=-9.39491988929925e-002;
    __statist_i_h_wts[5,213]=-1.06162490436198e-001;
    __statist_i_h_wts[5,214]=-6.05289887517371e-002;
    __statist_i_h_wts[5,215]=-6.64541515972241e-002;
    __statist_i_h_wts[5,216]=-6.40525484771702e-002;
    __statist_i_h_wts[5,217]=-5.95508143991110e-002;
    __statist_i_h_wts[5,218]=-3.80676229710787e-002;
    __statist_i_h_wts[5,219]=-4.06492969643527e-002;
    __statist_i_h_wts[5,220]=-1.06018355964043e-002;
    __statist_i_h_wts[5,221]=3.83223062778495e-002;
    __statist_i_h_wts[5,222]=1.07421536312620e-001;
    __statist_i_h_wts[5,223]=1.53081210824141e-001;
    __statist_i_h_wts[5,224]=1.24788185237050e-001;
    __statist_i_h_wts[5,225]=3.05308703385526e-002;
    __statist_i_h_wts[5,226]=1.26249779507826e-001;
    __statist_i_h_wts[5,227]=8.79156866350488e-002;
    __statist_i_h_wts[5,228]=2.05589908992922e-001;
    __statist_i_h_wts[5,229]=-1.38885338498157e-002;
    __statist_i_h_wts[5,230]=-5.17547967773535e-001;
    __statist_i_h_wts[5,231]=-2.87506690375293e-001;
    __statist_i_h_wts[5,232]=-6.59660180430800e-001;
    __statist_i_h_wts[5,233]=-2.63050972410972e-001;
    __statist_i_h_wts[5,234]=-9.60675108099004e-001;
    __statist_i_h_wts[5,235]=-1.14708137766491e-001;
    __statist_i_h_wts[5,236]=-6.81023028798798e-002;
    __statist_i_h_wts[5,237]=1.89311673649854e+000;
    __statist_i_h_wts[5,238]=5.72738073873949e-001;
    __statist_i_h_wts[5,239]=-3.73238716154282e-001;
    __statist_i_h_wts[5,240]=-1.84856307108538e-001;
    __statist_i_h_wts[5,241]=-8.13281552662774e-001;
    __statist_i_h_wts[5,242]=6.51267718198135e-002;
    __statist_i_h_wts[5,243]=-7.09806646494619e-002;
    __statist_i_h_wts[5,244]=-1.18802570173445e-001;
    __statist_i_h_wts[5,245]=2.16744243383916e-001;
    __statist_i_h_wts[5,246]=-1.68921584694319e-001;
    __statist_i_h_wts[5,247]=2.66594343637271e-001;
    __statist_i_h_wts[5,248]=2.70903287859236e-001;

    __statist_i_h_wts[6,0]=-3.04336020361533e-001;
    __statist_i_h_wts[6,1]=-2.46311354932428e-001;
    __statist_i_h_wts[6,2]=-2.04032498622380e-001;
    __statist_i_h_wts[6,3]=-1.68775445468384e-001;
    __statist_i_h_wts[6,4]=-1.34761957231061e-001;
    __statist_i_h_wts[6,5]=-1.09146153723399e-001;
    __statist_i_h_wts[6,6]=-1.01811090034255e-001;
    __statist_i_h_wts[6,7]=-9.94456713693364e-002;
    __statist_i_h_wts[6,8]=-6.45359075595467e-002;
    __statist_i_h_wts[6,9]=7.17639212808799e-003;
    __statist_i_h_wts[6,10]=-2.20361540526236e-002;
    __statist_i_h_wts[6,11]=-1.24043125748291e-002;
    __statist_i_h_wts[6,12]=-3.06101756148554e-002;
    __statist_i_h_wts[6,13]=3.19995440021251e-002;
    __statist_i_h_wts[6,14]=8.86388879489249e-002;
    __statist_i_h_wts[6,15]=-3.24579606933377e-001;
    __statist_i_h_wts[6,16]=-2.94241241809145e-001;
    __statist_i_h_wts[6,17]=-2.93832991056822e-001;
    __statist_i_h_wts[6,18]=-2.18658699963000e-001;
    __statist_i_h_wts[6,19]=-2.00563642063959e-001;
    __statist_i_h_wts[6,20]=-2.06391120870318e-001;
    __statist_i_h_wts[6,21]=-1.82053443675024e-001;
    __statist_i_h_wts[6,22]=-1.52513166366462e-001;
    __statist_i_h_wts[6,23]=-9.92685889481253e-002;
    __statist_i_h_wts[6,24]=-2.45241452800666e-002;
    __statist_i_h_wts[6,25]=1.78018323972608e-002;
    __statist_i_h_wts[6,26]=4.67703108283303e-002;
    __statist_i_h_wts[6,27]=7.66850907663011e-002;
    __statist_i_h_wts[6,28]=7.27839566882023e-002;
    __statist_i_h_wts[6,29]=1.07641444769197e-001;
    __statist_i_h_wts[6,30]=-2.65440569444050e-001;
    __statist_i_h_wts[6,31]=-1.94259384156740e-001;
    __statist_i_h_wts[6,32]=-2.35671345271626e-001;
    __statist_i_h_wts[6,33]=-1.31144915366171e-001;
    __statist_i_h_wts[6,34]=-1.26833157665330e-001;
    __statist_i_h_wts[6,35]=-1.16579127195139e-001;
    __statist_i_h_wts[6,36]=-6.61550686342782e-002;
    __statist_i_h_wts[6,37]=-5.62988772028680e-002;
    __statist_i_h_wts[6,38]=-2.38234349678191e-002;
    __statist_i_h_wts[6,39]=6.31411061085544e-002;
    __statist_i_h_wts[6,40]=5.71766691769578e-002;
    __statist_i_h_wts[6,41]=8.03013076439529e-002;
    __statist_i_h_wts[6,42]=1.01420246628122e-001;
    __statist_i_h_wts[6,43]=7.22693664893053e-002;
    __statist_i_h_wts[6,44]=1.00668644285098e-001;
    __statist_i_h_wts[6,45]=-2.21015614382459e-001;
    __statist_i_h_wts[6,46]=-1.46356581221580e-001;
    __statist_i_h_wts[6,47]=-1.99936068833122e-001;
    __statist_i_h_wts[6,48]=-1.46528372155817e-001;
    __statist_i_h_wts[6,49]=-1.58465701989114e-001;
    __statist_i_h_wts[6,50]=-5.19440039344785e-002;
    __statist_i_h_wts[6,51]=-6.96314703923048e-003;
    __statist_i_h_wts[6,52]=2.86268059412374e-002;
    __statist_i_h_wts[6,53]=3.74058247521652e-002;
    __statist_i_h_wts[6,54]=1.25283193195714e-001;
    __statist_i_h_wts[6,55]=9.79055957858540e-002;
    __statist_i_h_wts[6,56]=9.44700755045415e-002;
    __statist_i_h_wts[6,57]=5.78826828299286e-002;
    __statist_i_h_wts[6,58]=9.01061625177680e-002;
    __statist_i_h_wts[6,59]=6.67791081990373e-002;
    __statist_i_h_wts[6,60]=-2.33636516289262e-001;
    __statist_i_h_wts[6,61]=-1.82614500189813e-001;
    __statist_i_h_wts[6,62]=-1.99270578083265e-001;
    __statist_i_h_wts[6,63]=-1.51511565427419e-001;
    __statist_i_h_wts[6,64]=-1.16818614072023e-001;
    __statist_i_h_wts[6,65]=-6.67982407739059e-002;
    __statist_i_h_wts[6,66]=2.11111354143402e-002;
    __statist_i_h_wts[6,67]=5.26137683303208e-002;
    __statist_i_h_wts[6,68]=5.10684566004290e-002;
    __statist_i_h_wts[6,69]=1.45991151887941e-001;
    __statist_i_h_wts[6,70]=1.11720822866161e-001;
    __statist_i_h_wts[6,71]=1.27738534494222e-001;
    __statist_i_h_wts[6,72]=1.03969469154488e-001;
    __statist_i_h_wts[6,73]=1.52070657223256e-001;
    __statist_i_h_wts[6,74]=1.09577586302004e-001;
    __statist_i_h_wts[6,75]=-1.69537613422971e-001;
    __statist_i_h_wts[6,76]=-1.12132219062741e-001;
    __statist_i_h_wts[6,77]=-1.67314214937762e-001;
    __statist_i_h_wts[6,78]=-1.32512986767242e-001;
    __statist_i_h_wts[6,79]=-1.32367953815409e-001;
    __statist_i_h_wts[6,80]=-4.75829566708277e-002;
    __statist_i_h_wts[6,81]=4.85741223765606e-003;
    __statist_i_h_wts[6,82]=2.70369277394289e-002;
    __statist_i_h_wts[6,83]=6.73537397394998e-002;
    __statist_i_h_wts[6,84]=1.35526124570346e-001;
    __statist_i_h_wts[6,85]=1.27942616090974e-001;
    __statist_i_h_wts[6,86]=6.99942659889016e-002;
    __statist_i_h_wts[6,87]=7.82414432362794e-002;
    __statist_i_h_wts[6,88]=9.36859937165150e-002;
    __statist_i_h_wts[6,89]=8.52951821041499e-002;
    __statist_i_h_wts[6,90]=-1.60962768851616e-001;
    __statist_i_h_wts[6,91]=-6.85163782339265e-002;
    __statist_i_h_wts[6,92]=-1.05847359160864e-001;
    __statist_i_h_wts[6,93]=-5.97436793125166e-002;
    __statist_i_h_wts[6,94]=-4.08502672934944e-002;
    __statist_i_h_wts[6,95]=-2.24842678719524e-002;
    __statist_i_h_wts[6,96]=4.64517158730419e-002;
    __statist_i_h_wts[6,97]=5.63357152631773e-002;
    __statist_i_h_wts[6,98]=1.02023118274020e-001;
    __statist_i_h_wts[6,99]=1.59107534844242e-001;
    __statist_i_h_wts[6,100]=1.62600485751851e-001;
    __statist_i_h_wts[6,101]=9.09347737779041e-002;
    __statist_i_h_wts[6,102]=7.62858640052086e-002;
    __statist_i_h_wts[6,103]=1.39198931730684e-001;
    __statist_i_h_wts[6,104]=1.01944926090318e-001;
    __statist_i_h_wts[6,105]=-1.60562042659415e-001;
    __statist_i_h_wts[6,106]=-1.08747805864672e-001;
    __statist_i_h_wts[6,107]=-1.10370069346620e-001;
    __statist_i_h_wts[6,108]=-3.16713999713705e-002;
    __statist_i_h_wts[6,109]=-3.94888599516727e-002;
    __statist_i_h_wts[6,110]=3.75306733505914e-002;
    __statist_i_h_wts[6,111]=9.31129261212357e-002;
    __statist_i_h_wts[6,112]=1.02292953000899e-001;
    __statist_i_h_wts[6,113]=1.59345690038820e-001;
    __statist_i_h_wts[6,114]=2.09462663864772e-001;
    __statist_i_h_wts[6,115]=1.93120053670372e-001;
    __statist_i_h_wts[6,116]=1.39183604228721e-001;
    __statist_i_h_wts[6,117]=1.01853098835012e-001;
    __statist_i_h_wts[6,118]=1.21672991759779e-001;
    __statist_i_h_wts[6,119]=1.23133358162142e-001;
    __statist_i_h_wts[6,120]=-1.11187975853633e-001;
    __statist_i_h_wts[6,121]=-1.16513547841305e-001;
    __statist_i_h_wts[6,122]=-9.83651069121846e-002;
    __statist_i_h_wts[6,123]=-4.73746210549984e-002;
    __statist_i_h_wts[6,124]=-2.85258153855845e-002;
    __statist_i_h_wts[6,125]=9.36539798173991e-003;
    __statist_i_h_wts[6,126]=3.00203201880657e-002;
    __statist_i_h_wts[6,127]=3.55482203044641e-002;
    __statist_i_h_wts[6,128]=3.55283735113769e-003;
    __statist_i_h_wts[6,129]=1.38004094824438e-001;
    __statist_i_h_wts[6,130]=1.78257813353363e-001;
    __statist_i_h_wts[6,131]=1.49095020812622e-001;
    __statist_i_h_wts[6,132]=1.48842287818989e-001;
    __statist_i_h_wts[6,133]=1.88842567876995e-001;
    __statist_i_h_wts[6,134]=1.29293890133799e-001;
    __statist_i_h_wts[6,135]=-1.10572769073420e-001;
    __statist_i_h_wts[6,136]=-8.28968192749637e-002;
    __statist_i_h_wts[6,137]=-9.82294419230680e-002;
    __statist_i_h_wts[6,138]=-6.21740416425445e-002;
    __statist_i_h_wts[6,139]=-5.59994990506024e-002;
    __statist_i_h_wts[6,140]=5.35519900725333e-002;
    __statist_i_h_wts[6,141]=5.88700053179193e-002;
    __statist_i_h_wts[6,142]=4.78253516591970e-002;
    __statist_i_h_wts[6,143]=-6.89442404128130e-003;
    __statist_i_h_wts[6,144]=5.79323388258160e-002;
    __statist_i_h_wts[6,145]=1.05365257531670e-001;
    __statist_i_h_wts[6,146]=1.67877399815345e-001;
    __statist_i_h_wts[6,147]=1.46167437150560e-001;
    __statist_i_h_wts[6,148]=1.48636044796535e-001;
    __statist_i_h_wts[6,149]=1.37033385266230e-001;
    __statist_i_h_wts[6,150]=-1.24134731897003e-001;
    __statist_i_h_wts[6,151]=-9.94945825164481e-002;
    __statist_i_h_wts[6,152]=-5.45830481152874e-002;
    __statist_i_h_wts[6,153]=-6.87053742888175e-002;
    __statist_i_h_wts[6,154]=-7.59853257378435e-003;
    __statist_i_h_wts[6,155]=5.78279908328218e-002;
    __statist_i_h_wts[6,156]=8.43542852064164e-002;
    __statist_i_h_wts[6,157]=5.81717498198976e-002;
    __statist_i_h_wts[6,158]=2.75123255241104e-002;
    __statist_i_h_wts[6,159]=2.23290711734698e-002;
    __statist_i_h_wts[6,160]=5.61865585542429e-002;
    __statist_i_h_wts[6,161]=1.12949593094595e-001;
    __statist_i_h_wts[6,162]=1.10833769854117e-001;
    __statist_i_h_wts[6,163]=1.05600195425672e-001;
    __statist_i_h_wts[6,164]=1.03262693058261e-001;
    __statist_i_h_wts[6,165]=-8.14286241216270e-002;
    __statist_i_h_wts[6,166]=-8.16459178847724e-002;
    __statist_i_h_wts[6,167]=-4.62854236175936e-002;
    __statist_i_h_wts[6,168]=-4.15823629773011e-002;
    __statist_i_h_wts[6,169]=-1.78666596980717e-002;
    __statist_i_h_wts[6,170]=6.36088420864824e-003;
    __statist_i_h_wts[6,171]=2.96902794840606e-002;
    __statist_i_h_wts[6,172]=2.89331242943853e-002;
    __statist_i_h_wts[6,173]=2.33964440563028e-002;
    __statist_i_h_wts[6,174]=5.17677967631618e-002;
    __statist_i_h_wts[6,175]=5.61507588683382e-002;
    __statist_i_h_wts[6,176]=9.52413724514836e-002;
    __statist_i_h_wts[6,177]=1.00077366779215e-001;
    __statist_i_h_wts[6,178]=6.95396225270934e-002;
    __statist_i_h_wts[6,179]=1.00068052391733e-001;
    __statist_i_h_wts[6,180]=-9.21619879037600e-002;
    __statist_i_h_wts[6,181]=-8.91761827728614e-002;
    __statist_i_h_wts[6,182]=-3.84768939727033e-002;
    __statist_i_h_wts[6,183]=-3.05086774860415e-002;
    __statist_i_h_wts[6,184]=-9.85991828146929e-003;
    __statist_i_h_wts[6,185]=2.37027999803388e-002;
    __statist_i_h_wts[6,186]=2.27853019156268e-002;
    __statist_i_h_wts[6,187]=4.29591215383221e-002;
    __statist_i_h_wts[6,188]=2.52627050255866e-002;
    __statist_i_h_wts[6,189]=3.89914540642532e-003;
    __statist_i_h_wts[6,190]=7.16828849437486e-004;
    __statist_i_h_wts[6,191]=8.35586387771679e-002;
    __statist_i_h_wts[6,192]=1.10561093076127e-001;
    __statist_i_h_wts[6,193]=1.35220567040240e-001;
    __statist_i_h_wts[6,194]=1.47732493022876e-001;
    __statist_i_h_wts[6,195]=-8.94216527783405e-002;
    __statist_i_h_wts[6,196]=-1.05636962652249e-001;
    __statist_i_h_wts[6,197]=-6.46871525647206e-002;
    __statist_i_h_wts[6,198]=-8.84185255291175e-002;
    __statist_i_h_wts[6,199]=-5.99697344295910e-002;
    __statist_i_h_wts[6,200]=-3.58548681995777e-002;
    __statist_i_h_wts[6,201]=-5.02913922743786e-002;
    __statist_i_h_wts[6,202]=-3.94862230763480e-002;
    __statist_i_h_wts[6,203]=-2.13691039341708e-002;
    __statist_i_h_wts[6,204]=-3.38251133160338e-002;
    __statist_i_h_wts[6,205]=-7.83130675815186e-003;
    __statist_i_h_wts[6,206]=5.56473464863140e-002;
    __statist_i_h_wts[6,207]=1.08753373527762e-001;
    __statist_i_h_wts[6,208]=1.40403185946383e-001;
    __statist_i_h_wts[6,209]=1.48143206659604e-001;
    __statist_i_h_wts[6,210]=-8.41147822771256e-002;
    __statist_i_h_wts[6,211]=-9.61252613279425e-002;
    __statist_i_h_wts[6,212]=-8.83057932531258e-002;
    __statist_i_h_wts[6,213]=-8.41806153293956e-002;
    __statist_i_h_wts[6,214]=-5.66816544459282e-002;
    __statist_i_h_wts[6,215]=-5.17596504535186e-002;
    __statist_i_h_wts[6,216]=-4.14964990363630e-002;
    __statist_i_h_wts[6,217]=-1.92712616468624e-002;
    __statist_i_h_wts[6,218]=-2.08357045985462e-002;
    __statist_i_h_wts[6,219]=-1.51279785233480e-002;
    __statist_i_h_wts[6,220]=1.36320838265030e-002;
    __statist_i_h_wts[6,221]=5.23123544314057e-002;
    __statist_i_h_wts[6,222]=8.76469058680239e-002;
    __statist_i_h_wts[6,223]=1.10154820240009e-001;
    __statist_i_h_wts[6,224]=1.16506777059655e-001;
    __statist_i_h_wts[6,225]=-2.48865585607617e-002;
    __statist_i_h_wts[6,226]=2.27360418044836e-001;
    __statist_i_h_wts[6,227]=4.41429096573512e-002;
    __statist_i_h_wts[6,228]=3.10548696811066e-001;
    __statist_i_h_wts[6,229]=6.33425090339793e-003;
    __statist_i_h_wts[6,230]=-5.26013488216443e-001;
    __statist_i_h_wts[6,231]=-2.39429762053205e-001;
    __statist_i_h_wts[6,232]=-6.34510517421113e-001;
    __statist_i_h_wts[6,233]=-2.62685159910589e-001;
    __statist_i_h_wts[6,234]=-8.43709973405694e-001;
    __statist_i_h_wts[6,235]=-1.56341170617361e-002;
    __statist_i_h_wts[6,236]=2.57818605764208e-001;
    __statist_i_h_wts[6,237]=1.37154028201678e+000;
    __statist_i_h_wts[6,238]=4.27923880476494e-001;
    __statist_i_h_wts[6,239]=-4.73563252186950e-001;
    __statist_i_h_wts[6,240]=-4.46012784828135e-002;
    __statist_i_h_wts[6,241]=-7.69709737686959e-001;
    __statist_i_h_wts[6,242]=4.71573198329515e-002;
    __statist_i_h_wts[6,243]=-3.07166229874293e-001;
    __statist_i_h_wts[6,244]=-3.96043870283959e-002;
    __statist_i_h_wts[6,245]=4.43211091266458e-001;
    __statist_i_h_wts[6,246]=-7.89273628228472e-002;
    __statist_i_h_wts[6,247]=4.16027596227678e-001;
    __statist_i_h_wts[6,248]=2.09368846258520e-001;

    __statist_i_h_wts[7,0]=-2.84261670592002e-001;
    __statist_i_h_wts[7,1]=-1.59262078695323e-001;
    __statist_i_h_wts[7,2]=-1.26347118784527e-001;
    __statist_i_h_wts[7,3]=-7.69999181237650e-002;
    __statist_i_h_wts[7,4]=-2.09641498460206e-002;
    __statist_i_h_wts[7,5]=6.70596576956655e-002;
    __statist_i_h_wts[7,6]=4.59859004667471e-004;
    __statist_i_h_wts[7,7]=-6.36668293347289e-002;
    __statist_i_h_wts[7,8]=-1.00522530016380e-001;
    __statist_i_h_wts[7,9]=-3.16149961803868e-002;
    __statist_i_h_wts[7,10]=-9.53204609061540e-002;
    __statist_i_h_wts[7,11]=-1.75565168657172e-002;
    __statist_i_h_wts[7,12]=-4.94014930925803e-002;
    __statist_i_h_wts[7,13]=8.97756791968955e-002;
    __statist_i_h_wts[7,14]=1.44057152058611e-001;
    __statist_i_h_wts[7,15]=-1.94300411855628e-001;
    __statist_i_h_wts[7,16]=-1.14368230790407e-001;
    __statist_i_h_wts[7,17]=-1.25307848001095e-001;
    __statist_i_h_wts[7,18]=-1.13371422790563e-001;
    __statist_i_h_wts[7,19]=-6.19032899724617e-002;
    __statist_i_h_wts[7,20]=-4.60612155701461e-002;
    __statist_i_h_wts[7,21]=-6.67277161480699e-002;
    __statist_i_h_wts[7,22]=-1.51990391294539e-002;
    __statist_i_h_wts[7,23]=-6.76773778280670e-002;
    __statist_i_h_wts[7,24]=-1.80290709781743e-002;
    __statist_i_h_wts[7,25]=-5.10738564199903e-002;
    __statist_i_h_wts[7,26]=1.01972043532206e-001;
    __statist_i_h_wts[7,27]=7.82118630496631e-002;
    __statist_i_h_wts[7,28]=1.33796313032982e-001;
    __statist_i_h_wts[7,29]=1.77836051721372e-001;
    __statist_i_h_wts[7,30]=-7.23825377255491e-002;
    __statist_i_h_wts[7,31]=-5.92093166649872e-002;
    __statist_i_h_wts[7,32]=-1.62524616190618e-001;
    __statist_i_h_wts[7,33]=-2.68865084299131e-002;
    __statist_i_h_wts[7,34]=-4.75416744711214e-003;
    __statist_i_h_wts[7,35]=3.35482590795605e-002;
    __statist_i_h_wts[7,36]=1.00395597431385e-001;
    __statist_i_h_wts[7,37]=1.13200906299174e-001;
    __statist_i_h_wts[7,38]=4.54054944511898e-002;
    __statist_i_h_wts[7,39]=9.40538475108505e-002;
    __statist_i_h_wts[7,40]=4.10022888133369e-002;
    __statist_i_h_wts[7,41]=5.65091287480052e-002;
    __statist_i_h_wts[7,42]=8.48941993241761e-002;
    __statist_i_h_wts[7,43]=7.56764328453885e-002;
    __statist_i_h_wts[7,44]=1.23942540755002e-001;
    __statist_i_h_wts[7,45]=-1.10409393711401e-001;
    __statist_i_h_wts[7,46]=-6.93529744403138e-003;
    __statist_i_h_wts[7,47]=-6.61621693028411e-002;
    __statist_i_h_wts[7,48]=-2.42036996501435e-002;
    __statist_i_h_wts[7,49]=-1.99793478602609e-002;
    __statist_i_h_wts[7,50]=1.36344975085952e-001;
    __statist_i_h_wts[7,51]=1.00513868031849e-001;
    __statist_i_h_wts[7,52]=9.65749779514144e-002;
    __statist_i_h_wts[7,53]=9.10979257369122e-003;
    __statist_i_h_wts[7,54]=1.63033004030334e-001;
    __statist_i_h_wts[7,55]=3.69148436232071e-002;
    __statist_i_h_wts[7,56]=1.79009290779333e-002;
    __statist_i_h_wts[7,57]=-8.11357355599882e-002;
    __statist_i_h_wts[7,58]=3.36426275537490e-002;
    __statist_i_h_wts[7,59]=-2.03945205246700e-002;
    __statist_i_h_wts[7,60]=-1.34924253965670e-001;
    __statist_i_h_wts[7,61]=-7.34580357304155e-002;
    __statist_i_h_wts[7,62]=-3.63090743258485e-002;
    __statist_i_h_wts[7,63]=-1.19376621641228e-002;
    __statist_i_h_wts[7,64]=7.80569881184155e-002;
    __statist_i_h_wts[7,65]=1.71960481554983e-001;
    __statist_i_h_wts[7,66]=1.27967549238413e-001;
    __statist_i_h_wts[7,67]=1.08410263024934e-001;
    __statist_i_h_wts[7,68]=-8.08941173126422e-003;
    __statist_i_h_wts[7,69]=1.26876783553878e-001;
    __statist_i_h_wts[7,70]=-3.65831264485388e-002;
    __statist_i_h_wts[7,71]=-1.98333541128026e-002;
    __statist_i_h_wts[7,72]=-1.23660503385090e-002;
    __statist_i_h_wts[7,73]=9.96401653244769e-002;
    __statist_i_h_wts[7,74]=-9.17113129297140e-003;
    __statist_i_h_wts[7,75]=-4.60599778729277e-002;
    __statist_i_h_wts[7,76]=-8.18813485855829e-002;
    __statist_i_h_wts[7,77]=-5.44703167031920e-002;
    __statist_i_h_wts[7,78]=-4.96694699984886e-002;
    __statist_i_h_wts[7,79]=-3.08732180996261e-002;
    __statist_i_h_wts[7,80]=-1.83974480270865e-002;
    __statist_i_h_wts[7,81]=-6.75263608208700e-002;
    __statist_i_h_wts[7,82]=8.00329740946210e-002;
    __statist_i_h_wts[7,83]=8.42036922964430e-002;
    __statist_i_h_wts[7,84]=1.68602273218817e-001;
    __statist_i_h_wts[7,85]=1.16846819294649e-001;
    __statist_i_h_wts[7,86]=-2.78274916328245e-002;
    __statist_i_h_wts[7,87]=1.80131220469576e-002;
    __statist_i_h_wts[7,88]=1.31884225110808e-002;
    __statist_i_h_wts[7,89]=-2.38350409539453e-002;
    __statist_i_h_wts[7,90]=-1.25633537041207e-001;
    __statist_i_h_wts[7,91]=-1.80379309516014e-002;
    __statist_i_h_wts[7,92]=-2.76944561875246e-003;
    __statist_i_h_wts[7,93]=4.60182686066083e-002;
    __statist_i_h_wts[7,94]=1.04038208013928e-001;
    __statist_i_h_wts[7,95]=1.05338788235190e-001;
    __statist_i_h_wts[7,96]=-1.41673051978042e-002;
    __statist_i_h_wts[7,97]=3.85530760800282e-002;
    __statist_i_h_wts[7,98]=3.65097179886252e-002;
    __statist_i_h_wts[7,99]=2.80156170136022e-002;
    __statist_i_h_wts[7,100]=7.89147053102779e-002;
    __statist_i_h_wts[7,101]=-9.30821418394256e-002;
    __statist_i_h_wts[7,102]=-5.19204547662269e-002;
    __statist_i_h_wts[7,103]=6.24339732695163e-002;
    __statist_i_h_wts[7,104]=-3.59937408477352e-002;
    __statist_i_h_wts[7,105]=-1.81824364419194e-001;
    __statist_i_h_wts[7,106]=-8.88336609623498e-002;
    __statist_i_h_wts[7,107]=-3.85808116696781e-002;
    __statist_i_h_wts[7,108]=-9.64088480578823e-003;
    __statist_i_h_wts[7,109]=4.65320784302749e-002;
    __statist_i_h_wts[7,110]=1.32433806590079e-001;
    __statist_i_h_wts[7,111]=1.75188842221949e-002;
    __statist_i_h_wts[7,112]=4.93260346372715e-002;
    __statist_i_h_wts[7,113]=1.32498052754629e-001;
    __statist_i_h_wts[7,114]=1.16263753073613e-001;
    __statist_i_h_wts[7,115]=6.56508793768226e-002;
    __statist_i_h_wts[7,116]=-1.31664803666549e-001;
    __statist_i_h_wts[7,117]=-7.74707184968455e-002;
    __statist_i_h_wts[7,118]=-6.29637584565804e-002;
    __statist_i_h_wts[7,119]=-3.53721079344914e-002;
    __statist_i_h_wts[7,120]=-1.00736913984680e-001;
    __statist_i_h_wts[7,121]=-1.08311604977771e-001;
    __statist_i_h_wts[7,122]=-5.83687172018437e-002;
    __statist_i_h_wts[7,123]=4.79247729000493e-002;
    __statist_i_h_wts[7,124]=8.20513042909229e-002;
    __statist_i_h_wts[7,125]=1.84681240905363e-002;
    __statist_i_h_wts[7,126]=3.36138436829900e-002;
    __statist_i_h_wts[7,127]=3.86573930841053e-002;
    __statist_i_h_wts[7,128]=-8.78481803146487e-002;
    __statist_i_h_wts[7,129]=1.24946313908278e-001;
    __statist_i_h_wts[7,130]=9.83267679749663e-002;
    __statist_i_h_wts[7,131]=-3.77031474637215e-002;
    __statist_i_h_wts[7,132]=-6.87866094987371e-002;
    __statist_i_h_wts[7,133]=-7.30127558145053e-003;
    __statist_i_h_wts[7,134]=-3.84739540980553e-002;
    __statist_i_h_wts[7,135]=-1.38404653656378e-001;
    __statist_i_h_wts[7,136]=-8.72693037294472e-002;
    __statist_i_h_wts[7,137]=-6.46288162317931e-002;
    __statist_i_h_wts[7,138]=4.22469103480297e-002;
    __statist_i_h_wts[7,139]=-2.32179102893559e-002;
    __statist_i_h_wts[7,140]=1.36972923350989e-001;
    __statist_i_h_wts[7,141]=3.75487663095546e-002;
    __statist_i_h_wts[7,142]=1.64622714194416e-003;
    __statist_i_h_wts[7,143]=-1.16759675112881e-001;
    __statist_i_h_wts[7,144]=-3.00542249547160e-002;
    __statist_i_h_wts[7,145]=-1.30591744406825e-005;
    __statist_i_h_wts[7,146]=2.45564285222511e-002;
    __statist_i_h_wts[7,147]=1.41406916932399e-002;
    __statist_i_h_wts[7,148]=1.40941758398929e-002;
    __statist_i_h_wts[7,149]=1.54497217632431e-003;
    __statist_i_h_wts[7,150]=-1.91414901398488e-001;
    __statist_i_h_wts[7,151]=-1.57724629402502e-001;
    __statist_i_h_wts[7,152]=-6.29100074059527e-002;
    __statist_i_h_wts[7,153]=-7.05274597226915e-002;
    __statist_i_h_wts[7,154]=9.31442742732650e-003;
    __statist_i_h_wts[7,155]=8.38821106507328e-002;
    __statist_i_h_wts[7,156]=-1.48783845143783e-002;
    __statist_i_h_wts[7,157]=-6.04084143701325e-002;
    __statist_i_h_wts[7,158]=-1.47299309974656e-001;
    __statist_i_h_wts[7,159]=-4.47262258170030e-002;
    __statist_i_h_wts[7,160]=2.06550472347676e-002;
    __statist_i_h_wts[7,161]=2.91599601438091e-003;
    __statist_i_h_wts[7,162]=5.36626656407613e-004;
    __statist_i_h_wts[7,163]=-1.76558128648846e-002;
    __statist_i_h_wts[7,164]=-9.06968628274930e-003;
    __statist_i_h_wts[7,165]=-1.48720513358535e-001;
    __statist_i_h_wts[7,166]=-1.21641939469375e-001;
    __statist_i_h_wts[7,167]=-4.02121916375758e-002;
    __statist_i_h_wts[7,168]=-1.59310990266660e-001;
    __statist_i_h_wts[7,169]=-2.82796173880712e-003;
    __statist_i_h_wts[7,170]=-6.45841511491273e-004;
    __statist_i_h_wts[7,171]=-7.17528083428075e-002;
    __statist_i_h_wts[7,172]=-5.02173668732545e-002;
    __statist_i_h_wts[7,173]=-3.31070201949674e-002;
    __statist_i_h_wts[7,174]=6.96134254888691e-002;
    __statist_i_h_wts[7,175]=9.36597643573511e-002;
    __statist_i_h_wts[7,176]=4.17768907626219e-002;
    __statist_i_h_wts[7,177]=8.95884234326775e-003;
    __statist_i_h_wts[7,178]=-6.35017461472422e-002;
    __statist_i_h_wts[7,179]=3.55165297027479e-002;
    __statist_i_h_wts[7,180]=-1.23982724448102e-001;
    __statist_i_h_wts[7,181]=-9.69141237650887e-002;
    __statist_i_h_wts[7,182]=-2.43916792779635e-002;
    __statist_i_h_wts[7,183]=-4.81287041897754e-002;
    __statist_i_h_wts[7,184]=-4.84386378641523e-003;
    __statist_i_h_wts[7,185]=2.75979065342334e-002;
    __statist_i_h_wts[7,186]=-1.28477881794320e-002;
    __statist_i_h_wts[7,187]=5.72286171258009e-002;
    __statist_i_h_wts[7,188]=2.04489940414010e-002;
    __statist_i_h_wts[7,189]=-1.60480147083443e-002;
    __statist_i_h_wts[7,190]=9.28735776847819e-003;
    __statist_i_h_wts[7,191]=5.65002895034807e-002;
    __statist_i_h_wts[7,192]=3.96491525336987e-002;
    __statist_i_h_wts[7,193]=1.32982951540491e-001;
    __statist_i_h_wts[7,194]=1.25376804914430e-001;
    __statist_i_h_wts[7,195]=-1.02778376034778e-001;
    __statist_i_h_wts[7,196]=-1.29174823188865e-001;
    __statist_i_h_wts[7,197]=-8.98292918395068e-002;
    __statist_i_h_wts[7,198]=-1.20093452799466e-001;
    __statist_i_h_wts[7,199]=-7.98712420827771e-002;
    __statist_i_h_wts[7,200]=-6.21162170613692e-002;
    __statist_i_h_wts[7,201]=-1.03370732648979e-001;
    __statist_i_h_wts[7,202]=-3.46714839126015e-002;
    __statist_i_h_wts[7,203]=-1.22241368462253e-002;
    __statist_i_h_wts[7,204]=-6.66356185001755e-002;
    __statist_i_h_wts[7,205]=-4.75273576231733e-002;
    __statist_i_h_wts[7,206]=-3.31396776801492e-002;
    __statist_i_h_wts[7,207]=2.87262003523378e-002;
    __statist_i_h_wts[7,208]=1.33798613519972e-001;
    __statist_i_h_wts[7,209]=1.03641898515618e-001;
    __statist_i_h_wts[7,210]=-1.02725184147648e-001;
    __statist_i_h_wts[7,211]=-1.32551145270249e-001;
    __statist_i_h_wts[7,212]=-1.08053713960933e-001;
    __statist_i_h_wts[7,213]=-6.12074766149397e-002;
    __statist_i_h_wts[7,214]=-1.54572061828520e-002;
    __statist_i_h_wts[7,215]=-1.81256745948289e-002;
    __statist_i_h_wts[7,216]=-3.29199385373495e-002;
    __statist_i_h_wts[7,217]=-2.79342366892991e-003;
    __statist_i_h_wts[7,218]=-1.78601138109625e-002;
    __statist_i_h_wts[7,219]=-7.01335976847424e-002;
    __statist_i_h_wts[7,220]=-7.80809097034587e-002;
    __statist_i_h_wts[7,221]=-3.95896434923242e-002;
    __statist_i_h_wts[7,222]=1.49810367048022e-002;
    __statist_i_h_wts[7,223]=1.10447488726387e-001;
    __statist_i_h_wts[7,224]=8.59861247852654e-002;
    __statist_i_h_wts[7,225]=-2.43647535560405e-002;
    __statist_i_h_wts[7,226]=6.41827493794498e-003;
    __statist_i_h_wts[7,227]=-5.56363064906501e-002;
    __statist_i_h_wts[7,228]=-1.90503132541675e-002;
    __statist_i_h_wts[7,229]=-1.37450156964149e-001;
    __statist_i_h_wts[7,230]=-6.22800883014995e-001;
    __statist_i_h_wts[7,231]=-4.06270836333668e-001;
    __statist_i_h_wts[7,232]=-8.46251903513008e-001;
    __statist_i_h_wts[7,233]=-2.43570589823448e-001;
    __statist_i_h_wts[7,234]=-9.65244815422203e-001;
    __statist_i_h_wts[7,235]=-1.13379988439466e-001;
    __statist_i_h_wts[7,236]=-2.05489493804897e-001;
    __statist_i_h_wts[7,237]=1.95638255608295e+000;
    __statist_i_h_wts[7,238]=5.98707439802197e-001;
    __statist_i_h_wts[7,239]=-3.68203795712421e-001;
    __statist_i_h_wts[7,240]=-3.34837400649029e-001;
    __statist_i_h_wts[7,241]=-9.07052719833079e-001;
    __statist_i_h_wts[7,242]=1.46078047541080e-001;
    __statist_i_h_wts[7,243]=6.39184653910934e-002;
    __statist_i_h_wts[7,244]=-3.52578399595411e-002;
    __statist_i_h_wts[7,245]=1.64157843521744e-001;
    __statist_i_h_wts[7,246]=-2.33006298078495e-001;
    __statist_i_h_wts[7,247]=9.02146817043410e-002;
    __statist_i_h_wts[7,248]=2.99287102559130e-001;

    __statist_i_h_wts[8,0]=-2.69648949690048e-001;
    __statist_i_h_wts[8,1]=-1.99387046245061e-001;
    __statist_i_h_wts[8,2]=-1.35710123729176e-001;
    __statist_i_h_wts[8,3]=-1.50171045552194e-001;
    __statist_i_h_wts[8,4]=-8.95161261634255e-002;
    __statist_i_h_wts[8,5]=-2.18192386519537e-002;
    __statist_i_h_wts[8,6]=-2.63940882776069e-002;
    __statist_i_h_wts[8,7]=-5.70015401165696e-002;
    __statist_i_h_wts[8,8]=-1.27485138763573e-001;
    __statist_i_h_wts[8,9]=-6.78683843704204e-002;
    __statist_i_h_wts[8,10]=-9.78405741425647e-002;
    __statist_i_h_wts[8,11]=-1.30941788905418e-001;
    __statist_i_h_wts[8,12]=-1.59763143745186e-001;
    __statist_i_h_wts[8,13]=-5.77436683162909e-002;
    __statist_i_h_wts[8,14]=-4.93196485671484e-002;
    __statist_i_h_wts[8,15]=-2.71241311300925e-001;
    __statist_i_h_wts[8,16]=-2.34136210797986e-001;
    __statist_i_h_wts[8,17]=-1.86497233437042e-001;
    __statist_i_h_wts[8,18]=-2.20250254347255e-001;
    __statist_i_h_wts[8,19]=-1.11774809630172e-001;
    __statist_i_h_wts[8,20]=-7.58470867074262e-002;
    __statist_i_h_wts[8,21]=-4.73107423542328e-002;
    __statist_i_h_wts[8,22]=-9.90314913849123e-003;
    __statist_i_h_wts[8,23]=-8.63185497484109e-002;
    __statist_i_h_wts[8,24]=-3.95992803152761e-002;
    __statist_i_h_wts[8,25]=-6.18563480967106e-002;
    __statist_i_h_wts[8,26]=-1.59790790058977e-002;
    __statist_i_h_wts[8,27]=-6.67546909097274e-002;
    __statist_i_h_wts[8,28]=-1.51636979687629e-002;
    __statist_i_h_wts[8,29]=-2.31165573910217e-002;
    __statist_i_h_wts[8,30]=-2.59496116313986e-001;
    __statist_i_h_wts[8,31]=-2.47483738008157e-001;
    __statist_i_h_wts[8,32]=-2.31051563452961e-001;
    __statist_i_h_wts[8,33]=-2.18500852584550e-001;
    __statist_i_h_wts[8,34]=-1.57429057667889e-001;
    __statist_i_h_wts[8,35]=-7.42307819626992e-002;
    __statist_i_h_wts[8,36]=3.58466007636566e-002;
    __statist_i_h_wts[8,37]=8.19426284299963e-002;
    __statist_i_h_wts[8,38]=4.47807147318316e-002;
    __statist_i_h_wts[8,39]=9.61010375163883e-002;
    __statist_i_h_wts[8,40]=2.17003314514820e-002;
    __statist_i_h_wts[8,41]=-9.23534979682858e-003;
    __statist_i_h_wts[8,42]=-2.98062991532507e-002;
    __statist_i_h_wts[8,43]=-1.75370657837445e-002;
    __statist_i_h_wts[8,44]=-9.62481030113418e-003;
    __statist_i_h_wts[8,45]=-3.28865345274931e-001;
    __statist_i_h_wts[8,46]=-2.35319315191694e-001;
    __statist_i_h_wts[8,47]=-2.61908442943726e-001;
    __statist_i_h_wts[8,48]=-2.56260410434523e-001;
    __statist_i_h_wts[8,49]=-2.38656804318801e-001;
    __statist_i_h_wts[8,50]=-9.89176928997084e-002;
    __statist_i_h_wts[8,51]=-2.04069925189921e-002;
    __statist_i_h_wts[8,52]=1.33865307418882e-001;
    __statist_i_h_wts[8,53]=9.17135850568888e-002;
    __statist_i_h_wts[8,54]=1.48009098730898e-001;
    __statist_i_h_wts[8,55]=5.97847527233308e-002;
    __statist_i_h_wts[8,56]=3.18138791744105e-002;
    __statist_i_h_wts[8,57]=-5.43042628748434e-002;
    __statist_i_h_wts[8,58]=1.94637518306784e-002;
    __statist_i_h_wts[8,59]=-7.73995474908274e-003;
    __statist_i_h_wts[8,60]=-3.08117206517236e-001;
    __statist_i_h_wts[8,61]=-1.97673702587472e-001;
    __statist_i_h_wts[8,62]=-1.82781074322159e-001;
    __statist_i_h_wts[8,63]=-2.05335032998448e-001;
    __statist_i_h_wts[8,64]=-1.21424445532962e-001;
    __statist_i_h_wts[8,65]=-5.22472204188276e-002;
    __statist_i_h_wts[8,66]=-2.41523048159512e-002;
    __statist_i_h_wts[8,67]=8.79058942154381e-002;
    __statist_i_h_wts[8,68]=4.13574800024875e-002;
    __statist_i_h_wts[8,69]=7.87266679259399e-002;
    __statist_i_h_wts[8,70]=-8.11724923171535e-003;
    __statist_i_h_wts[8,71]=5.78723539430905e-002;
    __statist_i_h_wts[8,72]=1.65813800341581e-002;
    __statist_i_h_wts[8,73]=4.73386552314750e-002;
    __statist_i_h_wts[8,74]=2.11478113449470e-002;
    __statist_i_h_wts[8,75]=-2.78239533368914e-001;
    __statist_i_h_wts[8,76]=-2.25428486948699e-001;
    __statist_i_h_wts[8,77]=-2.52352009134421e-001;
    __statist_i_h_wts[8,78]=-2.15156717913886e-001;
    __statist_i_h_wts[8,79]=-1.84541971817178e-001;
    __statist_i_h_wts[8,80]=-1.16704467181813e-001;
    __statist_i_h_wts[8,81]=-1.29685436499621e-001;
    __statist_i_h_wts[8,82]=3.22867114159143e-003;
    __statist_i_h_wts[8,83]=2.35385393230144e-002;
    __statist_i_h_wts[8,84]=1.58303392681614e-001;
    __statist_i_h_wts[8,85]=1.22664119503360e-001;
    __statist_i_h_wts[8,86]=8.75851859283324e-002;
    __statist_i_h_wts[8,87]=5.43225804430618e-002;
    __statist_i_h_wts[8,88]=1.08280271162355e-001;
    __statist_i_h_wts[8,89]=7.52894650513025e-002;
    __statist_i_h_wts[8,90]=-3.44190507427194e-001;
    __statist_i_h_wts[8,91]=-2.23911999866289e-001;
    __statist_i_h_wts[8,92]=-2.30479237270487e-001;
    __statist_i_h_wts[8,93]=-1.28385375650162e-001;
    __statist_i_h_wts[8,94]=-1.15458743381562e-001;
    __statist_i_h_wts[8,95]=-7.83134835139676e-002;
    __statist_i_h_wts[8,96]=-7.11478382323793e-002;
    __statist_i_h_wts[8,97]=1.57369550144373e-002;
    __statist_i_h_wts[8,98]=2.01166540850147e-002;
    __statist_i_h_wts[8,99]=1.04745547263986e-001;
    __statist_i_h_wts[8,100]=1.23609429917354e-001;
    __statist_i_h_wts[8,101]=5.86431844461771e-002;
    __statist_i_h_wts[8,102]=3.50374594574008e-002;
    __statist_i_h_wts[8,103]=1.05061856389247e-001;
    __statist_i_h_wts[8,104]=4.82353611881980e-002;
    __statist_i_h_wts[8,105]=-3.44373187631073e-001;
    __statist_i_h_wts[8,106]=-2.49447752800393e-001;
    __statist_i_h_wts[8,107]=-2.18361582932070e-001;
    __statist_i_h_wts[8,108]=-1.65023418356885e-001;
    __statist_i_h_wts[8,109]=-1.10629952738609e-001;
    __statist_i_h_wts[8,110]=-3.58797280626557e-002;
    __statist_i_h_wts[8,111]=2.39439672734864e-002;
    __statist_i_h_wts[8,112]=6.30183074327745e-002;
    __statist_i_h_wts[8,113]=4.49207241614452e-002;
    __statist_i_h_wts[8,114]=9.14185709956097e-002;
    __statist_i_h_wts[8,115]=2.67821570637740e-002;
    __statist_i_h_wts[8,116]=1.02191781712283e-002;
    __statist_i_h_wts[8,117]=1.13874835155263e-002;
    __statist_i_h_wts[8,118]=8.46569853454754e-003;
    __statist_i_h_wts[8,119]=-2.57597599826934e-004;
    __statist_i_h_wts[8,120]=-2.37644472709655e-001;
    __statist_i_h_wts[8,121]=-2.21129031115415e-001;
    __statist_i_h_wts[8,122]=-1.58055547477860e-001;
    __statist_i_h_wts[8,123]=-8.46421808081454e-002;
    __statist_i_h_wts[8,124]=2.20127271321024e-003;
    __statist_i_h_wts[8,125]=3.65535814849604e-002;
    __statist_i_h_wts[8,126]=7.61479603346009e-002;
    __statist_i_h_wts[8,127]=1.35070601359134e-002;
    __statist_i_h_wts[8,128]=-3.07611840977469e-002;
    __statist_i_h_wts[8,129]=1.01149772152006e-001;
    __statist_i_h_wts[8,130]=8.09922452828824e-002;
    __statist_i_h_wts[8,131]=4.21693927592794e-002;
    __statist_i_h_wts[8,132]=4.57241677091979e-002;
    __statist_i_h_wts[8,133]=4.75918103993674e-002;
    __statist_i_h_wts[8,134]=1.58397037628228e-002;
    __statist_i_h_wts[8,135]=-2.54597551348001e-001;
    __statist_i_h_wts[8,136]=-2.10881441033767e-001;
    __statist_i_h_wts[8,137]=-1.90275561446385e-001;
    __statist_i_h_wts[8,138]=-8.69932012432522e-002;
    __statist_i_h_wts[8,139]=-4.02540742545312e-002;
    __statist_i_h_wts[8,140]=7.04322060640412e-002;
    __statist_i_h_wts[8,141]=4.07277033631572e-002;
    __statist_i_h_wts[8,142]=-2.46589892533653e-002;
    __statist_i_h_wts[8,143]=-9.48387977867863e-002;
    __statist_i_h_wts[8,144]=-3.38308117011805e-002;
    __statist_i_h_wts[8,145]=2.17126538603665e-002;
    __statist_i_h_wts[8,146]=4.06561518009215e-002;
    __statist_i_h_wts[8,147]=5.12759806303245e-002;
    __statist_i_h_wts[8,148]=6.88216860243626e-002;
    __statist_i_h_wts[8,149]=4.29015019998293e-002;
    __statist_i_h_wts[8,150]=-3.27532232370086e-001;
    __statist_i_h_wts[8,151]=-2.79045009873354e-001;
    __statist_i_h_wts[8,152]=-2.23857153970335e-001;
    __statist_i_h_wts[8,153]=-2.06284265724205e-001;
    __statist_i_h_wts[8,154]=-4.58324558381393e-002;
    __statist_i_h_wts[8,155]=2.69394678351958e-002;
    __statist_i_h_wts[8,156]=1.75310205440734e-003;
    __statist_i_h_wts[8,157]=-3.95693683522997e-003;
    __statist_i_h_wts[8,158]=-6.04379219628666e-002;
    __statist_i_h_wts[8,159]=-9.21176274302918e-003;
    __statist_i_h_wts[8,160]=4.18051379689742e-002;
    __statist_i_h_wts[8,161]=3.56902607411128e-002;
    __statist_i_h_wts[8,162]=6.24371939941061e-002;
    __statist_i_h_wts[8,163]=4.80962438366256e-002;
    __statist_i_h_wts[8,164]=5.58438195357585e-003;
    __statist_i_h_wts[8,165]=-1.62320653366953e-001;
    __statist_i_h_wts[8,166]=-1.75181955431461e-001;
    __statist_i_h_wts[8,167]=-1.32721860570750e-001;
    __statist_i_h_wts[8,168]=-1.20124279354198e-001;
    __statist_i_h_wts[8,169]=-1.49330233639480e-002;
    __statist_i_h_wts[8,170]=5.73601571709003e-002;
    __statist_i_h_wts[8,171]=1.49316425826715e-002;
    __statist_i_h_wts[8,172]=4.44039146677789e-003;
    __statist_i_h_wts[8,173]=-9.19460085380630e-003;
    __statist_i_h_wts[8,174]=6.36069321245775e-002;
    __statist_i_h_wts[8,175]=6.65317048862270e-002;
    __statist_i_h_wts[8,176]=4.14887696438608e-002;
    __statist_i_h_wts[8,177]=2.85650892954135e-002;
    __statist_i_h_wts[8,178]=8.30199146762281e-003;
    __statist_i_h_wts[8,179]=2.63501538032948e-002;
    __statist_i_h_wts[8,180]=-1.64420864373202e-001;
    __statist_i_h_wts[8,181]=-1.81983469384991e-001;
    __statist_i_h_wts[8,182]=-1.10150074879106e-001;
    __statist_i_h_wts[8,183]=-6.48238748552815e-002;
    __statist_i_h_wts[8,184]=-5.03087036189692e-002;
    __statist_i_h_wts[8,185]=-1.61355413663813e-002;
    __statist_i_h_wts[8,186]=1.60763030313820e-002;
    __statist_i_h_wts[8,187]=2.18800095840287e-002;
    __statist_i_h_wts[8,188]=1.24725029237913e-002;
    __statist_i_h_wts[8,189]=1.44724044953513e-002;
    __statist_i_h_wts[8,190]=2.39963501708796e-002;
    __statist_i_h_wts[8,191]=5.76525769759674e-002;
    __statist_i_h_wts[8,192]=6.01443387892073e-002;
    __statist_i_h_wts[8,193]=1.05118774125326e-001;
    __statist_i_h_wts[8,194]=7.54394130674967e-002;
    __statist_i_h_wts[8,195]=-1.78158143630173e-001;
    __statist_i_h_wts[8,196]=-1.47305429905354e-001;
    __statist_i_h_wts[8,197]=-8.35052411465269e-002;
    __statist_i_h_wts[8,198]=-1.01585576669868e-001;
    __statist_i_h_wts[8,199]=-1.11619142674579e-001;
    __statist_i_h_wts[8,200]=-5.91236732307892e-002;
    __statist_i_h_wts[8,201]=-4.92518281086188e-002;
    __statist_i_h_wts[8,202]=-4.13926661351559e-002;
    __statist_i_h_wts[8,203]=-2.56735056618399e-002;
    __statist_i_h_wts[8,204]=-3.95323590387533e-002;
    __statist_i_h_wts[8,205]=-5.33668469901801e-002;
    __statist_i_h_wts[8,206]=-2.05416300092689e-002;
    __statist_i_h_wts[8,207]=2.34920323501466e-002;
    __statist_i_h_wts[8,208]=9.54887304459670e-002;
    __statist_i_h_wts[8,209]=5.53303353155806e-002;
    __statist_i_h_wts[8,210]=-1.50853390680701e-001;
    __statist_i_h_wts[8,211]=-1.21259395801124e-001;
    __statist_i_h_wts[8,212]=-1.38287875805704e-001;
    __statist_i_h_wts[8,213]=-1.13746429866084e-001;
    __statist_i_h_wts[8,214]=-1.16455109983249e-001;
    __statist_i_h_wts[8,215]=-9.12156255614973e-002;
    __statist_i_h_wts[8,216]=-1.02797749552017e-001;
    __statist_i_h_wts[8,217]=-8.65486219941531e-002;
    __statist_i_h_wts[8,218]=-7.58464961880774e-002;
    __statist_i_h_wts[8,219]=-7.63094968533223e-002;
    __statist_i_h_wts[8,220]=-9.48299487766488e-002;
    __statist_i_h_wts[8,221]=-5.08577770663000e-002;
    __statist_i_h_wts[8,222]=7.28301280324495e-004;
    __statist_i_h_wts[8,223]=6.38617265249502e-002;
    __statist_i_h_wts[8,224]=3.06272009026573e-002;
    __statist_i_h_wts[8,225]=-2.01165567128424e-001;
    __statist_i_h_wts[8,226]=1.57188133731788e-001;
    __statist_i_h_wts[8,227]=-1.47487980792084e-001;
    __statist_i_h_wts[8,228]=1.97557386093055e-001;
    __statist_i_h_wts[8,229]=-1.40007891607508e-001;
    __statist_i_h_wts[8,230]=-6.87476837464081e-001;
    __statist_i_h_wts[8,231]=-3.81289964130301e-001;
    __statist_i_h_wts[8,232]=-8.85166612773765e-001;
    __statist_i_h_wts[8,233]=-3.05046954834254e-001;
    __statist_i_h_wts[8,234]=-1.12818584062012e+000;
    __statist_i_h_wts[8,235]=-1.49257859004098e-002;
    __statist_i_h_wts[8,236]=2.32740987177165e-001;
    __statist_i_h_wts[8,237]=1.67553446328073e+000;
    __statist_i_h_wts[8,238]=5.01595787585999e-001;
    __statist_i_h_wts[8,239]=-5.86388836558815e-001;
    __statist_i_h_wts[8,240]=-9.83230610598056e-003;
    __statist_i_h_wts[8,241]=-9.66929412205398e-001;
    __statist_i_h_wts[8,242]=8.84412659407227e-002;
    __statist_i_h_wts[8,243]=-3.74150766458780e-001;
    __statist_i_h_wts[8,244]=-9.91303048370726e-002;
    __statist_i_h_wts[8,245]=4.90280191299926e-001;
    __statist_i_h_wts[8,246]=-2.35407199252703e-001;
    __statist_i_h_wts[8,247]=3.99212298450694e-001;
    __statist_i_h_wts[8,248]=1.19409190182199e-001;

    __statist_i_h_wts[9,0]=-4.67416035847824e-001;
    __statist_i_h_wts[9,1]=-4.01165759036847e-001;
    __statist_i_h_wts[9,2]=-3.28612547223174e-001;
    __statist_i_h_wts[9,3]=-3.11468681569669e-001;
    __statist_i_h_wts[9,4]=-2.49235741064779e-001;
    __statist_i_h_wts[9,5]=-2.01471391702419e-001;
    __statist_i_h_wts[9,6]=-1.34851507590903e-001;
    __statist_i_h_wts[9,7]=-8.37409978893387e-002;
    __statist_i_h_wts[9,8]=-3.55515142147997e-002;
    __statist_i_h_wts[9,9]=7.08373930263552e-002;
    __statist_i_h_wts[9,10]=6.67103012469487e-002;
    __statist_i_h_wts[9,11]=6.08115394739217e-002;
    __statist_i_h_wts[9,12]=5.52036744220267e-002;
    __statist_i_h_wts[9,13]=1.62088782407605e-001;
    __statist_i_h_wts[9,14]=1.71279761318457e-001;
    __statist_i_h_wts[9,15]=-5.28225740828896e-001;
    __statist_i_h_wts[9,16]=-4.68314403622941e-001;
    __statist_i_h_wts[9,17]=-4.45190727163143e-001;
    __statist_i_h_wts[9,18]=-4.33302361675339e-001;
    __statist_i_h_wts[9,19]=-3.18696880073115e-001;
    __statist_i_h_wts[9,20]=-2.90634217152208e-001;
    __statist_i_h_wts[9,21]=-1.98601291939792e-001;
    __statist_i_h_wts[9,22]=-9.42815676373580e-002;
    __statist_i_h_wts[9,23]=-3.64736019219588e-002;
    __statist_i_h_wts[9,24]=7.64373611104784e-002;
    __statist_i_h_wts[9,25]=1.22242858452152e-001;
    __statist_i_h_wts[9,26]=2.05008381273217e-001;
    __statist_i_h_wts[9,27]=1.99377908409040e-001;
    __statist_i_h_wts[9,28]=1.98315928073598e-001;
    __statist_i_h_wts[9,29]=1.89833742475253e-001;
    __statist_i_h_wts[9,30]=-4.53605367789892e-001;
    __statist_i_h_wts[9,31]=-3.93345212485646e-001;
    __statist_i_h_wts[9,32]=-3.85337165208469e-001;
    __statist_i_h_wts[9,33]=-3.08688399032253e-001;
    __statist_i_h_wts[9,34]=-2.36868452079541e-001;
    __statist_i_h_wts[9,35]=-1.71911064533489e-001;
    __statist_i_h_wts[9,36]=-3.54995494123112e-002;
    __statist_i_h_wts[9,37]=3.66140086895417e-002;
    __statist_i_h_wts[9,38]=7.95644361773741e-002;
    __statist_i_h_wts[9,39]=2.10199679513096e-001;
    __statist_i_h_wts[9,40]=2.10023374435200e-001;
    __statist_i_h_wts[9,41]=2.53189928625554e-001;
    __statist_i_h_wts[9,42]=2.49516538383483e-001;
    __statist_i_h_wts[9,43]=2.34964914049081e-001;
    __statist_i_h_wts[9,44]=2.39246203214804e-001;
    __statist_i_h_wts[9,45]=-3.65049005393150e-001;
    __statist_i_h_wts[9,46]=-2.32524638761964e-001;
    __statist_i_h_wts[9,47]=-2.48837314444438e-001;
    __statist_i_h_wts[9,48]=-1.85886407393665e-001;
    __statist_i_h_wts[9,49]=-9.75927929218410e-002;
    __statist_i_h_wts[9,50]=1.08271282552900e-002;
    __statist_i_h_wts[9,51]=1.03816390440793e-001;
    __statist_i_h_wts[9,52]=2.15195312843171e-001;
    __statist_i_h_wts[9,53]=2.50030547451671e-001;
    __statist_i_h_wts[9,54]=3.46066300187540e-001;
    __statist_i_h_wts[9,55]=3.56495519976024e-001;
    __statist_i_h_wts[9,56]=3.81571092124239e-001;
    __statist_i_h_wts[9,57]=3.26924040411150e-001;
    __statist_i_h_wts[9,58]=3.84482642009357e-001;
    __statist_i_h_wts[9,59]=3.68592997277650e-001;
    __statist_i_h_wts[9,60]=-3.23527015999541e-001;
    __statist_i_h_wts[9,61]=-2.45931860492771e-001;
    __statist_i_h_wts[9,62]=-2.37100523388222e-001;
    __statist_i_h_wts[9,63]=-1.97466341711058e-001;
    __statist_i_h_wts[9,64]=-7.68304517588592e-002;
    __statist_i_h_wts[9,65]=-2.27157482378362e-002;
    __statist_i_h_wts[9,66]=1.51960693400683e-001;
    __statist_i_h_wts[9,67]=2.49663789038284e-001;
    __statist_i_h_wts[9,68]=2.79174284093261e-001;
    __statist_i_h_wts[9,69]=3.91038547460307e-001;
    __statist_i_h_wts[9,70]=3.72328939143517e-001;
    __statist_i_h_wts[9,71]=4.08906646564855e-001;
    __statist_i_h_wts[9,72]=4.04138362792701e-001;
    __statist_i_h_wts[9,73]=4.37941410966606e-001;
    __statist_i_h_wts[9,74]=4.35448395619780e-001;
    __statist_i_h_wts[9,75]=-2.36910318668774e-001;
    __statist_i_h_wts[9,76]=-1.78195850683150e-001;
    __statist_i_h_wts[9,77]=-2.17239286505635e-001;
    __statist_i_h_wts[9,78]=-1.68401367329737e-001;
    __statist_i_h_wts[9,79]=-7.27540427842171e-002;
    __statist_i_h_wts[9,80]=5.28408342700174e-002;
    __statist_i_h_wts[9,81]=1.73648577769594e-001;
    __statist_i_h_wts[9,82]=2.70965427021684e-001;
    __statist_i_h_wts[9,83]=3.08834914097843e-001;
    __statist_i_h_wts[9,84]=4.47365498786344e-001;
    __statist_i_h_wts[9,85]=4.70802107865819e-001;
    __statist_i_h_wts[9,86]=4.29964542931047e-001;
    __statist_i_h_wts[9,87]=4.50788070834121e-001;
    __statist_i_h_wts[9,88]=4.63723375772285e-001;
    __statist_i_h_wts[9,89]=4.84262228984412e-001;
    __statist_i_h_wts[9,90]=-3.12135970873656e-001;
    __statist_i_h_wts[9,91]=-1.77287071487201e-001;
    __statist_i_h_wts[9,92]=-1.77977645239600e-001;
    __statist_i_h_wts[9,93]=-8.44974355442437e-002;
    __statist_i_h_wts[9,94]=-1.89475633489981e-002;
    __statist_i_h_wts[9,95]=1.01999290764135e-001;
    __statist_i_h_wts[9,96]=1.42175410183971e-001;
    __statist_i_h_wts[9,97]=2.55608844994249e-001;
    __statist_i_h_wts[9,98]=3.30683728270395e-001;
    __statist_i_h_wts[9,99]=4.76258674732054e-001;
    __statist_i_h_wts[9,100]=4.93733375401054e-001;
    __statist_i_h_wts[9,101]=4.31228955670073e-001;
    __statist_i_h_wts[9,102]=4.15834312249165e-001;
    __statist_i_h_wts[9,103]=4.66732900229991e-001;
    __statist_i_h_wts[9,104]=4.58754881587013e-001;
    __statist_i_h_wts[9,105]=-2.90470109918724e-001;
    __statist_i_h_wts[9,106]=-1.89468819131001e-001;
    __statist_i_h_wts[9,107]=-1.72166177543886e-001;
    __statist_i_h_wts[9,108]=-7.67396497584255e-002;
    __statist_i_h_wts[9,109]=2.87624229442014e-002;
    __statist_i_h_wts[9,110]=1.64582550406246e-001;
    __statist_i_h_wts[9,111]=2.13339483000108e-001;
    __statist_i_h_wts[9,112]=2.69536036008364e-001;
    __statist_i_h_wts[9,113]=3.45172211855713e-001;
    __statist_i_h_wts[9,114]=4.53504658250584e-001;
    __statist_i_h_wts[9,115]=4.21302653741888e-001;
    __statist_i_h_wts[9,116]=4.04408731992800e-001;
    __statist_i_h_wts[9,117]=3.87883861843949e-001;
    __statist_i_h_wts[9,118]=3.76843519904394e-001;
    __statist_i_h_wts[9,119]=4.12285012832219e-001;
    __statist_i_h_wts[9,120]=-2.70271699315046e-001;
    __statist_i_h_wts[9,121]=-2.24026712477271e-001;
    __statist_i_h_wts[9,122]=-1.58867709347781e-001;
    __statist_i_h_wts[9,123]=-5.85174529232689e-002;
    __statist_i_h_wts[9,124]=6.55043681996282e-002;
    __statist_i_h_wts[9,125]=1.63189999543662e-001;
    __statist_i_h_wts[9,126]=2.15057746169228e-001;
    __statist_i_h_wts[9,127]=2.30347286954836e-001;
    __statist_i_h_wts[9,128]=2.25772253367849e-001;
    __statist_i_h_wts[9,129]=3.27049952954964e-001;
    __statist_i_h_wts[9,130]=4.31158065589842e-001;
    __statist_i_h_wts[9,131]=4.14157633276727e-001;
    __statist_i_h_wts[9,132]=4.31206176393356e-001;
    __statist_i_h_wts[9,133]=4.67858403432317e-001;
    __statist_i_h_wts[9,134]=4.48862013228003e-001;
    __statist_i_h_wts[9,135]=-2.24427347715094e-001;
    __statist_i_h_wts[9,136]=-2.16287303020277e-001;
    __statist_i_h_wts[9,137]=-2.07927164231543e-001;
    __statist_i_h_wts[9,138]=-1.04677895958792e-001;
    __statist_i_h_wts[9,139]=6.92059375736017e-003;
    __statist_i_h_wts[9,140]=1.14663376603171e-001;
    __statist_i_h_wts[9,141]=1.58468764534789e-001;
    __statist_i_h_wts[9,142]=1.57807309439810e-001;
    __statist_i_h_wts[9,143]=1.11289051984495e-001;
    __statist_i_h_wts[9,144]=1.91630901549977e-001;
    __statist_i_h_wts[9,145]=3.12897233387657e-001;
    __statist_i_h_wts[9,146]=4.02308325413096e-001;
    __statist_i_h_wts[9,147]=4.26347575457966e-001;
    __statist_i_h_wts[9,148]=4.79235926551000e-001;
    __statist_i_h_wts[9,149]=4.53805760765476e-001;
    __statist_i_h_wts[9,150]=-2.65052615327327e-001;
    __statist_i_h_wts[9,151]=-2.51881813033902e-001;
    __statist_i_h_wts[9,152]=-1.91326282112025e-001;
    __statist_i_h_wts[9,153]=-1.40469580514791e-001;
    __statist_i_h_wts[9,154]=-1.08555782480924e-002;
    __statist_i_h_wts[9,155]=8.31370763263820e-002;
    __statist_i_h_wts[9,156]=1.21042023485849e-001;
    __statist_i_h_wts[9,157]=1.29378125487712e-001;
    __statist_i_h_wts[9,158]=1.24040816923469e-001;
    __statist_i_h_wts[9,159]=1.62717919014511e-001;
    __statist_i_h_wts[9,160]=2.13485804836631e-001;
    __statist_i_h_wts[9,161]=3.27252002298291e-001;
    __statist_i_h_wts[9,162]=3.76191331391930e-001;
    __statist_i_h_wts[9,163]=3.70142272044934e-001;
    __statist_i_h_wts[9,164]=3.77339602238172e-001;
    __statist_i_h_wts[9,165]=-2.14535666503630e-001;
    __statist_i_h_wts[9,166]=-2.00870087072900e-001;
    __statist_i_h_wts[9,167]=-1.66288192879239e-001;
    __statist_i_h_wts[9,168]=-1.78929856776003e-001;
    __statist_i_h_wts[9,169]=-8.89506306337009e-002;
    __statist_i_h_wts[9,170]=-1.19236184745274e-002;
    __statist_i_h_wts[9,171]=6.48849637349746e-002;
    __statist_i_h_wts[9,172]=8.47761901051025e-002;
    __statist_i_h_wts[9,173]=1.12440401790933e-001;
    __statist_i_h_wts[9,174]=1.72281152650350e-001;
    __statist_i_h_wts[9,175]=2.03705837102145e-001;
    __statist_i_h_wts[9,176]=3.08362071118393e-001;
    __statist_i_h_wts[9,177]=3.41521705152473e-001;
    __statist_i_h_wts[9,178]=3.56503809251329e-001;
    __statist_i_h_wts[9,179]=3.92145251563079e-001;
    __statist_i_h_wts[9,180]=-2.11240310205223e-001;
    __statist_i_h_wts[9,181]=-2.18012297556773e-001;
    __statist_i_h_wts[9,182]=-1.70235448178496e-001;
    __statist_i_h_wts[9,183]=-1.54734791550150e-001;
    __statist_i_h_wts[9,184]=-1.28565844896388e-001;
    __statist_i_h_wts[9,185]=-2.69877547305115e-002;
    __statist_i_h_wts[9,186]=3.29375423382313e-002;
    __statist_i_h_wts[9,187]=7.52881030858604e-002;
    __statist_i_h_wts[9,188]=9.09703801421969e-002;
    __statist_i_h_wts[9,189]=1.18395916217597e-001;
    __statist_i_h_wts[9,190]=1.74245322843731e-001;
    __statist_i_h_wts[9,191]=2.85339360973971e-001;
    __statist_i_h_wts[9,192]=3.45405804966757e-001;
    __statist_i_h_wts[9,193]=3.81030109583130e-001;
    __statist_i_h_wts[9,194]=4.00823149100368e-001;
    __statist_i_h_wts[9,195]=-2.04926961714284e-001;
    __statist_i_h_wts[9,196]=-1.99492777192534e-001;
    __statist_i_h_wts[9,197]=-1.94042773694232e-001;
    __statist_i_h_wts[9,198]=-1.78032335295814e-001;
    __statist_i_h_wts[9,199]=-1.28991651206220e-001;
    __statist_i_h_wts[9,200]=-5.86219793328548e-002;
    __statist_i_h_wts[9,201]=-8.47361147398951e-003;
    __statist_i_h_wts[9,202]=1.72303269046670e-002;
    __statist_i_h_wts[9,203]=7.35069839485749e-002;
    __statist_i_h_wts[9,204]=9.54461568208281e-002;
    __statist_i_h_wts[9,205]=1.30131871111699e-001;
    __statist_i_h_wts[9,206]=2.23130647386300e-001;
    __statist_i_h_wts[9,207]=3.07095891322908e-001;
    __statist_i_h_wts[9,208]=3.70975332319125e-001;
    __statist_i_h_wts[9,209]=3.32431990784262e-001;
    __statist_i_h_wts[9,210]=-1.34925230187809e-001;
    __statist_i_h_wts[9,211]=-1.38393347016591e-001;
    __statist_i_h_wts[9,212]=-1.73968757440438e-001;
    __statist_i_h_wts[9,213]=-1.22802701257721e-001;
    __statist_i_h_wts[9,214]=-1.18787189512417e-001;
    __statist_i_h_wts[9,215]=-7.49168494358471e-002;
    __statist_i_h_wts[9,216]=-1.92182716106653e-002;
    __statist_i_h_wts[9,217]=-9.85758377533176e-003;
    __statist_i_h_wts[9,218]=5.00907131302980e-002;
    __statist_i_h_wts[9,219]=9.07627054250155e-002;
    __statist_i_h_wts[9,220]=1.48496820675684e-001;
    __statist_i_h_wts[9,221]=2.10162854590963e-001;
    __statist_i_h_wts[9,222]=2.84054698101446e-001;
    __statist_i_h_wts[9,223]=3.34360088466090e-001;
    __statist_i_h_wts[9,224]=2.95164856138320e-001;
    __statist_i_h_wts[9,225]=-1.39211609254074e-001;
    __statist_i_h_wts[9,226]=5.35183650116409e-001;
    __statist_i_h_wts[9,227]=-1.64642755664309e-002;
    __statist_i_h_wts[9,228]=6.23192500966919e-001;
    __statist_i_h_wts[9,229]=-5.22358262040368e-002;
    __statist_i_h_wts[9,230]=-9.67038276166664e-001;
    __statist_i_h_wts[9,231]=-3.44802858675582e-001;
    __statist_i_h_wts[9,232]=-1.11367633976553e+000;
    __statist_i_h_wts[9,233]=-4.20811145913714e-001;
    __statist_i_h_wts[9,234]=-1.36859148236917e+000;
    __statist_i_h_wts[9,235]=7.25490943376731e-002;
    __statist_i_h_wts[9,236]=7.94344697501084e-001;
    __statist_i_h_wts[9,237]=2.05655289656167e+000;
    __statist_i_h_wts[9,238]=6.00392104076597e-001;
    __statist_i_h_wts[9,239]=-8.88942351865320e-001;
    __statist_i_h_wts[9,240]=1.21098221992561e-001;
    __statist_i_h_wts[9,241]=-1.30975337400531e+000;
    __statist_i_h_wts[9,242]=1.01653851833672e-001;
    __statist_i_h_wts[9,243]=-7.37405817410754e-001;
    __statist_i_h_wts[9,244]=-4.71425387011293e-002;
    __statist_i_h_wts[9,245]=1.00568690539733e+000;
    __statist_i_h_wts[9,246]=-8.86999841652306e-002;
    __statist_i_h_wts[9,247]=9.74501124979299e-001;
    __statist_i_h_wts[9,248]=2.10728218513570e-001;

    __statist_i_h_wts[10,0]=-2.93531214973199e-001;
    __statist_i_h_wts[10,1]=-2.60249483346725e-001;
    __statist_i_h_wts[10,2]=-2.20590254725504e-001;
    __statist_i_h_wts[10,3]=-2.21726604468336e-001;
    __statist_i_h_wts[10,4]=-1.80679835574197e-001;
    __statist_i_h_wts[10,5]=-1.67855301032952e-001;
    __statist_i_h_wts[10,6]=-1.24278542464509e-001;
    __statist_i_h_wts[10,7]=-1.05888428369798e-001;
    __statist_i_h_wts[10,8]=-9.10067710598007e-002;
    __statist_i_h_wts[10,9]=-3.16904363146326e-002;
    __statist_i_h_wts[10,10]=-5.11751893125667e-002;
    __statist_i_h_wts[10,11]=-4.57588576474094e-002;
    __statist_i_h_wts[10,12]=-7.10573661657213e-002;
    __statist_i_h_wts[10,13]=-1.50265234211462e-002;
    __statist_i_h_wts[10,14]=1.83505514536628e-003;
    __statist_i_h_wts[10,15]=-3.22661902277823e-001;
    __statist_i_h_wts[10,16]=-3.18918102857863e-001;
    __statist_i_h_wts[10,17]=-2.81704750105430e-001;
    __statist_i_h_wts[10,18]=-2.93851032244894e-001;
    __statist_i_h_wts[10,19]=-2.25415126266152e-001;
    __statist_i_h_wts[10,20]=-2.04052577077163e-001;
    __statist_i_h_wts[10,21]=-1.42086163093415e-001;
    __statist_i_h_wts[10,22]=-9.47765462051476e-002;
    __statist_i_h_wts[10,23]=-6.39113026586609e-002;
    __statist_i_h_wts[10,24]=-8.28216084494414e-003;
    __statist_i_h_wts[10,25]=-1.45096864155227e-002;
    __statist_i_h_wts[10,26]=2.84667193550314e-002;
    __statist_i_h_wts[10,27]=1.55557399551697e-002;
    __statist_i_h_wts[10,28]=1.42133978977395e-002;
    __statist_i_h_wts[10,29]=1.41060970868128e-002;
    __statist_i_h_wts[10,30]=-3.04830439360298e-001;
    __statist_i_h_wts[10,31]=-2.87797063532819e-001;
    __statist_i_h_wts[10,32]=-2.77480439280914e-001;
    __statist_i_h_wts[10,33]=-2.56096662962999e-001;
    __statist_i_h_wts[10,34]=-2.14597550646482e-001;
    __statist_i_h_wts[10,35]=-1.57540906058650e-001;
    __statist_i_h_wts[10,36]=-9.44883255542852e-002;
    __statist_i_h_wts[10,37]=-4.78381543936377e-002;
    __statist_i_h_wts[10,38]=-8.52571620099097e-003;
    __statist_i_h_wts[10,39]=4.45185802425721e-002;
    __statist_i_h_wts[10,40]=4.52669154800549e-002;
    __statist_i_h_wts[10,41]=5.04487067437238e-002;
    __statist_i_h_wts[10,42]=6.40156398370097e-002;
    __statist_i_h_wts[10,43]=4.34707979204878e-002;
    __statist_i_h_wts[10,44]=4.97971770416168e-002;
    __statist_i_h_wts[10,45]=-2.88318791698563e-001;
    __statist_i_h_wts[10,46]=-2.39903602858761e-001;
    __statist_i_h_wts[10,47]=-2.45846269504412e-001;
    __statist_i_h_wts[10,48]=-2.39970060404623e-001;
    __statist_i_h_wts[10,49]=-1.93623213966711e-001;
    __statist_i_h_wts[10,50]=-1.13424646121118e-001;
    __statist_i_h_wts[10,51]=-7.80835574404162e-002;
    __statist_i_h_wts[10,52]=2.40344745784553e-002;
    __statist_i_h_wts[10,53]=5.14650956528779e-002;
    __statist_i_h_wts[10,54]=1.12317849645364e-001;
    __statist_i_h_wts[10,55]=9.47924848498680e-002;
    __statist_i_h_wts[10,56]=1.07201267657466e-001;
    __statist_i_h_wts[10,57]=1.00914854096278e-001;
    __statist_i_h_wts[10,58]=1.05762305051002e-001;
    __statist_i_h_wts[10,59]=9.13206660298968e-002;
    __statist_i_h_wts[10,60]=-3.23738153232134e-001;
    __statist_i_h_wts[10,61]=-2.79150056253139e-001;
    __statist_i_h_wts[10,62]=-2.59875275496104e-001;
    __statist_i_h_wts[10,63]=-2.38640915542017e-001;
    __statist_i_h_wts[10,64]=-1.88342165071581e-001;
    __statist_i_h_wts[10,65]=-1.29960220700231e-001;
    __statist_i_h_wts[10,66]=-6.59328945610971e-002;
    __statist_i_h_wts[10,67]=1.71151764787992e-002;
    __statist_i_h_wts[10,68]=5.95270987291889e-002;
    __statist_i_h_wts[10,69]=1.24589409103911e-001;
    __statist_i_h_wts[10,70]=1.15490281788870e-001;
    __statist_i_h_wts[10,71]=1.42731915098385e-001;
    __statist_i_h_wts[10,72]=1.36476914318340e-001;
    __statist_i_h_wts[10,73]=1.51542995925713e-001;
    __statist_i_h_wts[10,74]=1.36152947351096e-001;
    __statist_i_h_wts[10,75]=-2.94367914043590e-001;
    __statist_i_h_wts[10,76]=-2.86877166348075e-001;
    __statist_i_h_wts[10,77]=-2.86977208119914e-001;
    __statist_i_h_wts[10,78]=-2.51132289990580e-001;
    __statist_i_h_wts[10,79]=-2.14021618742367e-001;
    __statist_i_h_wts[10,80]=-1.39314101119762e-001;
    __statist_i_h_wts[10,81]=-7.72512942771000e-002;
    __statist_i_h_wts[10,82]=6.27942717725230e-003;
    __statist_i_h_wts[10,83]=6.85563688028750e-002;
    __statist_i_h_wts[10,84]=1.74655358504629e-001;
    __statist_i_h_wts[10,85]=1.78399480567493e-001;
    __statist_i_h_wts[10,86]=1.88546463737862e-001;
    __statist_i_h_wts[10,87]=1.67910157999116e-001;
    __statist_i_h_wts[10,88]=1.84005610632285e-001;
    __statist_i_h_wts[10,89]=1.71801578797987e-001;
    __statist_i_h_wts[10,90]=-3.31120335098538e-001;
    __statist_i_h_wts[10,91]=-2.70528413871482e-001;
    __statist_i_h_wts[10,92]=-2.75871041106389e-001;
    __statist_i_h_wts[10,93]=-2.07371572558325e-001;
    __statist_i_h_wts[10,94]=-1.83320009129466e-001;
    __statist_i_h_wts[10,95]=-1.17094680799893e-001;
    __statist_i_h_wts[10,96]=-7.30835969643177e-002;
    __statist_i_h_wts[10,97]=2.90203776676796e-003;
    __statist_i_h_wts[10,98]=9.16075964152173e-002;
    __statist_i_h_wts[10,99]=1.92744452441929e-001;
    __statist_i_h_wts[10,100]=2.03949149689365e-001;
    __statist_i_h_wts[10,101]=1.91073363613156e-001;
    __statist_i_h_wts[10,102]=1.75761601443731e-001;
    __statist_i_h_wts[10,103]=1.83435614938067e-001;
    __statist_i_h_wts[10,104]=1.49784171661559e-001;
    __statist_i_h_wts[10,105]=-3.24985586526225e-001;
    __statist_i_h_wts[10,106]=-2.75974900255261e-001;
    __statist_i_h_wts[10,107]=-2.57000565993995e-001;
    __statist_i_h_wts[10,108]=-2.21394610956435e-001;
    __statist_i_h_wts[10,109]=-1.72878811466601e-001;
    __statist_i_h_wts[10,110]=-7.27374822965544e-002;
    __statist_i_h_wts[10,111]=-3.37448594262032e-002;
    __statist_i_h_wts[10,112]=1.51558193858447e-002;
    __statist_i_h_wts[10,113]=8.03709149550994e-002;
    __statist_i_h_wts[10,114]=1.68629678177671e-001;
    __statist_i_h_wts[10,115]=1.61710464241587e-001;
    __statist_i_h_wts[10,116]=1.93442769207799e-001;
    __statist_i_h_wts[10,117]=1.61789947060259e-001;
    __statist_i_h_wts[10,118]=1.49245911810323e-001;
    __statist_i_h_wts[10,119]=1.29999756048212e-001;
    __statist_i_h_wts[10,120]=-2.76793382100755e-001;
    __statist_i_h_wts[10,121]=-2.64105957677052e-001;
    __statist_i_h_wts[10,122]=-2.21645091335433e-001;
    __statist_i_h_wts[10,123]=-1.73980428966482e-001;
    __statist_i_h_wts[10,124]=-1.17618078993300e-001;
    __statist_i_h_wts[10,125]=-6.58910828006674e-002;
    __statist_i_h_wts[10,126]=-6.06584881713175e-003;
    __statist_i_h_wts[10,127]=5.70700106603272e-003;
    __statist_i_h_wts[10,128]=3.94557586124395e-002;
    __statist_i_h_wts[10,129]=1.34004727061669e-001;
    __statist_i_h_wts[10,130]=1.76073130051660e-001;
    __statist_i_h_wts[10,131]=1.85297824217347e-001;
    __statist_i_h_wts[10,132]=1.87291455777442e-001;
    __statist_i_h_wts[10,133]=1.79168490453949e-001;
    __statist_i_h_wts[10,134]=1.47029198738299e-001;
    __statist_i_h_wts[10,135]=-2.27852326442990e-001;
    __statist_i_h_wts[10,136]=-2.30535223664745e-001;
    __statist_i_h_wts[10,137]=-2.29113412959166e-001;
    __statist_i_h_wts[10,138]=-1.67409368999057e-001;
    __statist_i_h_wts[10,139]=-1.24535513369675e-001;
    __statist_i_h_wts[10,140]=-6.79771065900148e-002;
    __statist_i_h_wts[10,141]=-2.57907003128305e-002;
    __statist_i_h_wts[10,142]=-2.38835567580326e-002;
    __statist_i_h_wts[10,143]=1.70013822890737e-003;
    __statist_i_h_wts[10,144]=6.82921472025682e-002;
    __statist_i_h_wts[10,145]=1.19903954846736e-001;
    __statist_i_h_wts[10,146]=1.71451890422958e-001;
    __statist_i_h_wts[10,147]=1.72150659531272e-001;
    __statist_i_h_wts[10,148]=1.81162659649849e-001;
    __statist_i_h_wts[10,149]=1.51210895616272e-001;
    __statist_i_h_wts[10,150]=-2.50316382499215e-001;
    __statist_i_h_wts[10,151]=-2.27046046670827e-001;
    __statist_i_h_wts[10,152]=-1.93031603625872e-001;
    __statist_i_h_wts[10,153]=-1.97819726065614e-001;
    __statist_i_h_wts[10,154]=-1.11416112743137e-001;
    __statist_i_h_wts[10,155]=-7.06103048310872e-002;
    __statist_i_h_wts[10,156]=-5.60212433932126e-002;
    __statist_i_h_wts[10,157]=-1.73432220384204e-002;
    __statist_i_h_wts[10,158]=1.55125312253856e-002;
    __statist_i_h_wts[10,159]=5.60996520465011e-002;
    __statist_i_h_wts[10,160]=7.24756626944267e-002;
    __statist_i_h_wts[10,161]=1.24904464359869e-001;
    __statist_i_h_wts[10,162]=1.62113323498492e-001;
    __statist_i_h_wts[10,163]=1.28627498773060e-001;
    __statist_i_h_wts[10,164]=9.58834303164898e-002;
    __statist_i_h_wts[10,165]=-1.97775846969316e-001;
    __statist_i_h_wts[10,166]=-1.88500769048128e-001;
    __statist_i_h_wts[10,167]=-1.79280791169797e-001;
    __statist_i_h_wts[10,168]=-1.70523408580208e-001;
    __statist_i_h_wts[10,169]=-1.20856380433070e-001;
    __statist_i_h_wts[10,170]=-7.34155919662777e-002;
    __statist_i_h_wts[10,171]=-5.74151341447220e-002;
    __statist_i_h_wts[10,172]=-3.11904870906039e-002;
    __statist_i_h_wts[10,173]=-1.29481455355742e-004;
    __statist_i_h_wts[10,174]=4.22471736519456e-002;
    __statist_i_h_wts[10,175]=7.37147116584357e-002;
    __statist_i_h_wts[10,176]=1.13181792408798e-001;
    __statist_i_h_wts[10,177]=1.09790075981741e-001;
    __statist_i_h_wts[10,178]=1.11305240799993e-001;
    __statist_i_h_wts[10,179]=1.18079240612392e-001;
    __statist_i_h_wts[10,180]=-1.72022178287405e-001;
    __statist_i_h_wts[10,181]=-1.85850493989568e-001;
    __statist_i_h_wts[10,182]=-1.58804394497247e-001;
    __statist_i_h_wts[10,183]=-1.52692515403362e-001;
    __statist_i_h_wts[10,184]=-1.15398868440453e-001;
    __statist_i_h_wts[10,185]=-9.69494976286301e-002;
    __statist_i_h_wts[10,186]=-5.91642604959893e-002;
    __statist_i_h_wts[10,187]=-4.93076295922075e-002;
    __statist_i_h_wts[10,188]=2.99190298518957e-003;
    __statist_i_h_wts[10,189]=2.65609179055363e-002;
    __statist_i_h_wts[10,190]=2.35447882489448e-002;
    __statist_i_h_wts[10,191]=8.46165835730035e-002;
    __statist_i_h_wts[10,192]=1.07986090308944e-001;
    __statist_i_h_wts[10,193]=1.17579237737808e-001;
    __statist_i_h_wts[10,194]=1.22640737080224e-001;
    __statist_i_h_wts[10,195]=-1.68198339655987e-001;
    __statist_i_h_wts[10,196]=-1.71953090935088e-001;
    __statist_i_h_wts[10,197]=-1.48606317106930e-001;
    __statist_i_h_wts[10,198]=-1.68320953294273e-001;
    __statist_i_h_wts[10,199]=-1.42911181117650e-001;
    __statist_i_h_wts[10,200]=-1.07394800435744e-001;
    __statist_i_h_wts[10,201]=-9.87289287604337e-002;
    __statist_i_h_wts[10,202]=-7.37652104803566e-002;
    __statist_i_h_wts[10,203]=-3.27575505608336e-002;
    __statist_i_h_wts[10,204]=-1.50544422038764e-002;
    __statist_i_h_wts[10,205]=-3.54773663672416e-003;
    __statist_i_h_wts[10,206]=5.18584234355719e-002;
    __statist_i_h_wts[10,207]=7.96212673699184e-002;
    __statist_i_h_wts[10,208]=1.01102283608151e-001;
    __statist_i_h_wts[10,209]=8.08794411271539e-002;
    __statist_i_h_wts[10,210]=-1.51622740652262e-001;
    __statist_i_h_wts[10,211]=-1.37292174075485e-001;
    __statist_i_h_wts[10,212]=-1.72222176071950e-001;
    __statist_i_h_wts[10,213]=-1.54533786160032e-001;
    __statist_i_h_wts[10,214]=-1.24363511626796e-001;
    __statist_i_h_wts[10,215]=-1.17985695792615e-001;
    __statist_i_h_wts[10,216]=-1.09297615541711e-001;
    __statist_i_h_wts[10,217]=-8.91087996722348e-002;
    __statist_i_h_wts[10,218]=-6.55099790466048e-002;
    __statist_i_h_wts[10,219]=-3.26372841680811e-002;
    __statist_i_h_wts[10,220]=-1.29645654229250e-002;
    __statist_i_h_wts[10,221]=1.67706685784368e-002;
    __statist_i_h_wts[10,222]=4.84325998041744e-002;
    __statist_i_h_wts[10,223]=6.79438465457967e-002;
    __statist_i_h_wts[10,224]=4.23862069033044e-002;
    __statist_i_h_wts[10,225]=-1.30605715568260e-001;
    __statist_i_h_wts[10,226]=1.90673099909029e-001;
    __statist_i_h_wts[10,227]=-6.56075646869102e-002;
    __statist_i_h_wts[10,228]=2.38243368741334e-001;
    __statist_i_h_wts[10,229]=-5.62130455415699e-002;
    __statist_i_h_wts[10,230]=-4.83228511903698e-001;
    __statist_i_h_wts[10,231]=-1.82104658597150e-001;
    __statist_i_h_wts[10,232]=-5.67554473868542e-001;
    __statist_i_h_wts[10,233]=-2.00104876765336e-001;
    __statist_i_h_wts[10,234]=-6.99520886443481e-001;
    __statist_i_h_wts[10,235]=-7.07627493088763e-003;
    __statist_i_h_wts[10,236]=3.17872421522795e-001;
    __statist_i_h_wts[10,237]=9.73774923266364e-001;
    __statist_i_h_wts[10,238]=2.72032896625090e-001;
    __statist_i_h_wts[10,239]=-4.39136450083379e-001;
    __statist_i_h_wts[10,240]=5.55868814930413e-002;
    __statist_i_h_wts[10,241]=-6.59914949052476e-001;
    __statist_i_h_wts[10,242]=3.61682896879512e-002;
    __statist_i_h_wts[10,243]=-3.50962820220523e-001;
    __statist_i_h_wts[10,244]=-6.64845882095240e-002;
    __statist_i_h_wts[10,245]=4.23761566995175e-001;
    __statist_i_h_wts[10,246]=-1.04086406235854e-001;
    __statist_i_h_wts[10,247]=4.06720792998262e-001;
    __statist_i_h_wts[10,248]=6.81626665358443e-002;

    __statist_i_h_wts[11,0]=-3.40676523405591e-001;
    __statist_i_h_wts[11,1]=-3.11716987537610e-001;
    __statist_i_h_wts[11,2]=-2.70643647745134e-001;
    __statist_i_h_wts[11,3]=-2.77855890708209e-001;
    __statist_i_h_wts[11,4]=-2.34162958652025e-001;
    __statist_i_h_wts[11,5]=-1.82799020205253e-001;
    __statist_i_h_wts[11,6]=-1.07107523538838e-001;
    __statist_i_h_wts[11,7]=-3.32512900455344e-002;
    __statist_i_h_wts[11,8]=1.70001187327820e-002;
    __statist_i_h_wts[11,9]=9.52472356357855e-002;
    __statist_i_h_wts[11,10]=1.18802618211657e-001;
    __statist_i_h_wts[11,11]=1.00755409768299e-001;
    __statist_i_h_wts[11,12]=1.11926668607663e-001;
    __statist_i_h_wts[11,13]=1.59680013124899e-001;
    __statist_i_h_wts[11,14]=1.24817232308807e-001;
    __statist_i_h_wts[11,15]=-3.59108988769242e-001;
    __statist_i_h_wts[11,16]=-3.35167100145599e-001;
    __statist_i_h_wts[11,17]=-3.28369364894318e-001;
    __statist_i_h_wts[11,18]=-3.27480392100729e-001;
    __statist_i_h_wts[11,19]=-2.64044846935360e-001;
    __statist_i_h_wts[11,20]=-1.88312828141471e-001;
    __statist_i_h_wts[11,21]=-1.09092178069997e-001;
    __statist_i_h_wts[11,22]=-2.27787631530943e-002;
    __statist_i_h_wts[11,23]=5.65822444248229e-002;
    __statist_i_h_wts[11,24]=1.40130299638818e-001;
    __statist_i_h_wts[11,25]=1.64884739906989e-001;
    __statist_i_h_wts[11,26]=1.90417517244308e-001;
    __statist_i_h_wts[11,27]=2.01457882957845e-001;
    __statist_i_h_wts[11,28]=2.09628716483651e-001;
    __statist_i_h_wts[11,29]=1.58029559094630e-001;
    __statist_i_h_wts[11,30]=-4.01419256562831e-001;
    __statist_i_h_wts[11,31]=-3.73963173724646e-001;
    __statist_i_h_wts[11,32]=-3.57050340111047e-001;
    __statist_i_h_wts[11,33]=-3.44812426017468e-001;
    __statist_i_h_wts[11,34]=-2.81345950457555e-001;
    __statist_i_h_wts[11,35]=-1.96448488521120e-001;
    __statist_i_h_wts[11,36]=-9.78795364857133e-002;
    __statist_i_h_wts[11,37]=-9.50202110241005e-003;
    __statist_i_h_wts[11,38]=7.29495315999961e-002;
    __statist_i_h_wts[11,39]=1.71915643298082e-001;
    __statist_i_h_wts[11,40]=2.14019742443047e-001;
    __statist_i_h_wts[11,41]=2.35243567709100e-001;
    __statist_i_h_wts[11,42]=2.47948098867953e-001;
    __statist_i_h_wts[11,43]=2.33329160864612e-001;
    __statist_i_h_wts[11,44]=2.34758199101030e-001;
    __statist_i_h_wts[11,45]=-3.61949466079834e-001;
    __statist_i_h_wts[11,46]=-3.42102599085980e-001;
    __statist_i_h_wts[11,47]=-3.18762189193375e-001;
    __statist_i_h_wts[11,48]=-3.00275619182764e-001;
    __statist_i_h_wts[11,49]=-2.17785677656375e-001;
    __statist_i_h_wts[11,50]=-1.23951204700971e-001;
    __statist_i_h_wts[11,51]=-1.70031397614083e-002;
    __statist_i_h_wts[11,52]=9.12174087965518e-002;
    __statist_i_h_wts[11,53]=2.08238260942791e-001;
    __statist_i_h_wts[11,54]=2.85153168793323e-001;
    __statist_i_h_wts[11,55]=3.37699491424173e-001;
    __statist_i_h_wts[11,56]=3.56935759069836e-001;
    __statist_i_h_wts[11,57]=3.63430625915244e-001;
    __statist_i_h_wts[11,58]=3.65232758209333e-001;
    __statist_i_h_wts[11,59]=3.50425766211857e-001;
    __statist_i_h_wts[11,60]=-3.87473555186989e-001;
    __statist_i_h_wts[11,61]=-3.57809352164455e-001;
    __statist_i_h_wts[11,62]=-3.42854184967516e-001;
    __statist_i_h_wts[11,63]=-3.10066416820159e-001;
    __statist_i_h_wts[11,64]=-2.14020212078315e-001;
    __statist_i_h_wts[11,65]=-1.57989065406088e-001;
    __statist_i_h_wts[11,66]=-2.69249223287518e-002;
    __statist_i_h_wts[11,67]=1.08269162955009e-001;
    __statist_i_h_wts[11,68]=2.15967513798782e-001;
    __statist_i_h_wts[11,69]=3.25289996604844e-001;
    __statist_i_h_wts[11,70]=3.83432149142478e-001;
    __statist_i_h_wts[11,71]=4.20173027550832e-001;
    __statist_i_h_wts[11,72]=3.98067202027788e-001;
    __statist_i_h_wts[11,73]=4.21035059027802e-001;
    __statist_i_h_wts[11,74]=4.14044370435438e-001;
    __statist_i_h_wts[11,75]=-3.64576391179185e-001;
    __statist_i_h_wts[11,76]=-3.61499599574916e-001;
    __statist_i_h_wts[11,77]=-3.57970806330802e-001;
    __statist_i_h_wts[11,78]=-3.13421146437888e-001;
    __statist_i_h_wts[11,79]=-2.38890999303774e-001;
    __statist_i_h_wts[11,80]=-1.20365581873622e-001;
    __statist_i_h_wts[11,81]=-5.34281042608359e-003;
    __statist_i_h_wts[11,82]=1.22386075494665e-001;
    __statist_i_h_wts[11,83]=2.05773078461016e-001;
    __statist_i_h_wts[11,84]=3.61497980557503e-001;
    __statist_i_h_wts[11,85]=4.32153946146347e-001;
    __statist_i_h_wts[11,86]=4.61306525356290e-001;
    __statist_i_h_wts[11,87]=4.70686801874537e-001;
    __statist_i_h_wts[11,88]=4.82525207498936e-001;
    __statist_i_h_wts[11,89]=4.68883005497350e-001;
    __statist_i_h_wts[11,90]=-3.81901724722131e-001;
    __statist_i_h_wts[11,91]=-3.34259130075960e-001;
    __statist_i_h_wts[11,92]=-3.23017555681126e-001;
    __statist_i_h_wts[11,93]=-2.71484369791175e-001;
    __statist_i_h_wts[11,94]=-2.01237445460185e-001;
    __statist_i_h_wts[11,95]=-6.79711755264870e-002;
    __statist_i_h_wts[11,96]=-1.77417271535522e-002;
    __statist_i_h_wts[11,97]=1.25833953127250e-001;
    __statist_i_h_wts[11,98]=2.74449812450251e-001;
    __statist_i_h_wts[11,99]=4.09026880960253e-001;
    __statist_i_h_wts[11,100]=4.61871248724548e-001;
    __statist_i_h_wts[11,101]=5.17011337204657e-001;
    __statist_i_h_wts[11,102]=5.13046594368900e-001;
    __statist_i_h_wts[11,103]=5.05089036943473e-001;
    __statist_i_h_wts[11,104]=4.72892093242659e-001;
    __statist_i_h_wts[11,105]=-3.51508700666650e-001;
    __statist_i_h_wts[11,106]=-3.43120314064268e-001;
    __statist_i_h_wts[11,107]=-3.13783463205986e-001;
    __statist_i_h_wts[11,108]=-2.85837790059423e-001;
    __statist_i_h_wts[11,109]=-1.88184526957322e-001;
    __statist_i_h_wts[11,110]=-3.42319560986459e-002;
    __statist_i_h_wts[11,111]=4.03444419619076e-002;
    __statist_i_h_wts[11,112]=1.41878693065959e-001;
    __statist_i_h_wts[11,113]=2.66112353613164e-001;
    __statist_i_h_wts[11,114]=3.83414964797360e-001;
    __statist_i_h_wts[11,115]=4.13387773006388e-001;
    __statist_i_h_wts[11,116]=4.77324038289158e-001;
    __statist_i_h_wts[11,117]=4.80018449999008e-001;
    __statist_i_h_wts[11,118]=4.40658338659649e-001;
    __statist_i_h_wts[11,119]=4.07871355718275e-001;
    __statist_i_h_wts[11,120]=-3.26302921757882e-001;
    __statist_i_h_wts[11,121]=-3.36018692642889e-001;
    __statist_i_h_wts[11,122]=-3.11890102707912e-001;
    __statist_i_h_wts[11,123]=-2.48635645277800e-001;
    __statist_i_h_wts[11,124]=-1.29632719093877e-001;
    __statist_i_h_wts[11,125]=-1.17004809887708e-002;
    __statist_i_h_wts[11,126]=6.66889665697022e-002;
    __statist_i_h_wts[11,127]=1.67136491614921e-001;
    __statist_i_h_wts[11,128]=2.48876226810422e-001;
    __statist_i_h_wts[11,129]=3.32357065323496e-001;
    __statist_i_h_wts[11,130]=4.13729959209611e-001;
    __statist_i_h_wts[11,131]=4.63701697004200e-001;
    __statist_i_h_wts[11,132]=5.16597700913460e-001;
    __statist_i_h_wts[11,133]=4.92065947112779e-001;
    __statist_i_h_wts[11,134]=4.36819967995304e-001;
    __statist_i_h_wts[11,135]=-2.60358074580723e-001;
    __statist_i_h_wts[11,136]=-2.79046853384922e-001;
    __statist_i_h_wts[11,137]=-2.85829078050343e-001;
    __statist_i_h_wts[11,138]=-2.28962787939919e-001;
    __statist_i_h_wts[11,139]=-1.33547452806808e-001;
    __statist_i_h_wts[11,140]=-7.44275029434325e-002;
    __statist_i_h_wts[11,141]=4.41100910186416e-002;
    __statist_i_h_wts[11,142]=1.40011819893120e-001;
    __statist_i_h_wts[11,143]=2.10988541500704e-001;
    __statist_i_h_wts[11,144]=2.76210593916536e-001;
    __statist_i_h_wts[11,145]=3.39432484909420e-001;
    __statist_i_h_wts[11,146]=4.44348857115733e-001;
    __statist_i_h_wts[11,147]=4.77361031214579e-001;
    __statist_i_h_wts[11,148]=4.84794247616274e-001;
    __statist_i_h_wts[11,149]=4.12382771554983e-001;
    __statist_i_h_wts[11,150]=-2.35056917184014e-001;
    __statist_i_h_wts[11,151]=-2.75929254089035e-001;
    __statist_i_h_wts[11,152]=-2.58737286684592e-001;
    __statist_i_h_wts[11,153]=-2.39021965404783e-001;
    __statist_i_h_wts[11,154]=-1.42304710375174e-001;
    __statist_i_h_wts[11,155]=-8.74377945959637e-002;
    __statist_i_h_wts[11,156]=-4.37201422380445e-003;
    __statist_i_h_wts[11,157]=1.06583935771928e-001;
    __statist_i_h_wts[11,158]=2.07989062518367e-001;
    __statist_i_h_wts[11,159]=2.66394046358985e-001;
    __statist_i_h_wts[11,160]=2.97777950352484e-001;
    __statist_i_h_wts[11,161]=4.03179796908859e-001;
    __statist_i_h_wts[11,162]=4.51037334678478e-001;
    __statist_i_h_wts[11,163]=4.05835725423541e-001;
    __statist_i_h_wts[11,164]=3.50858116903147e-001;
    __statist_i_h_wts[11,165]=-1.71968858311146e-001;
    __statist_i_h_wts[11,166]=-2.02517465929726e-001;
    __statist_i_h_wts[11,167]=-2.01745595388396e-001;
    __statist_i_h_wts[11,168]=-2.09799159975734e-001;
    __statist_i_h_wts[11,169]=-1.54792571961400e-001;
    __statist_i_h_wts[11,170]=-9.42658775567136e-002;
    __statist_i_h_wts[11,171]=-3.55395654354967e-002;
    __statist_i_h_wts[11,172]=4.07270972311874e-002;
    __statist_i_h_wts[11,173]=1.20808363020898e-001;
    __statist_i_h_wts[11,174]=1.90536556655036e-001;
    __statist_i_h_wts[11,175]=2.43761912680480e-001;
    __statist_i_h_wts[11,176]=3.25401342189877e-001;
    __statist_i_h_wts[11,177]=3.57296953087656e-001;
    __statist_i_h_wts[11,178]=3.87100948314055e-001;
    __statist_i_h_wts[11,179]=3.50608586704552e-001;
    __statist_i_h_wts[11,180]=-1.44286012275490e-001;
    __statist_i_h_wts[11,181]=-1.69930039065241e-001;
    __statist_i_h_wts[11,182]=-1.60839591398858e-001;
    __statist_i_h_wts[11,183]=-1.62685070887514e-001;
    __statist_i_h_wts[11,184]=-1.56357450307837e-001;
    __statist_i_h_wts[11,185]=-1.24502271481117e-001;
    __statist_i_h_wts[11,186]=-4.84441975813662e-002;
    __statist_i_h_wts[11,187]=1.51699574213260e-002;
    __statist_i_h_wts[11,188]=1.26118975561422e-001;
    __statist_i_h_wts[11,189]=1.66554601580389e-001;
    __statist_i_h_wts[11,190]=2.04222364084237e-001;
    __statist_i_h_wts[11,191]=2.72689220609617e-001;
    __statist_i_h_wts[11,192]=3.30659240059778e-001;
    __statist_i_h_wts[11,193]=3.25708728097347e-001;
    __statist_i_h_wts[11,194]=2.95413922663460e-001;
    __statist_i_h_wts[11,195]=-1.24838333813002e-001;
    __statist_i_h_wts[11,196]=-1.36113247565955e-001;
    __statist_i_h_wts[11,197]=-1.42080067080510e-001;
    __statist_i_h_wts[11,198]=-1.32692839752115e-001;
    __statist_i_h_wts[11,199]=-1.22618455434440e-001;
    __statist_i_h_wts[11,200]=-9.47850157427453e-002;
    __statist_i_h_wts[11,201]=-2.37576586547149e-002;
    __statist_i_h_wts[11,202]=5.21668521733835e-003;
    __statist_i_h_wts[11,203]=1.08365400350611e-001;
    __statist_i_h_wts[11,204]=1.30788353950142e-001;
    __statist_i_h_wts[11,205]=1.71445944386412e-001;
    __statist_i_h_wts[11,206]=2.20054895207886e-001;
    __statist_i_h_wts[11,207]=2.36759397764097e-001;
    __statist_i_h_wts[11,208]=2.56109664504004e-001;
    __statist_i_h_wts[11,209]=2.13497823551990e-001;
    __statist_i_h_wts[11,210]=-8.07799279575785e-002;
    __statist_i_h_wts[11,211]=-8.09310346750471e-002;
    __statist_i_h_wts[11,212]=-1.08137253528591e-001;
    __statist_i_h_wts[11,213]=-9.19440034951413e-002;
    __statist_i_h_wts[11,214]=-8.90633912267745e-002;
    __statist_i_h_wts[11,215]=-6.74352466968476e-002;
    __statist_i_h_wts[11,216]=-4.01229511251803e-002;
    __statist_i_h_wts[11,217]=-1.13829770534312e-003;
    __statist_i_h_wts[11,218]=4.06223601346101e-002;
    __statist_i_h_wts[11,219]=9.67152880942071e-002;
    __statist_i_h_wts[11,220]=1.28736119360827e-001;
    __statist_i_h_wts[11,221]=1.79897321504919e-001;
    __statist_i_h_wts[11,222]=2.21083473699268e-001;
    __statist_i_h_wts[11,223]=2.08564565890805e-001;
    __statist_i_h_wts[11,224]=1.91688659836180e-001;
    __statist_i_h_wts[11,225]=-1.13868881547879e-001;
    __statist_i_h_wts[11,226]=2.26822238654891e-001;
    __statist_i_h_wts[11,227]=-5.75128715057259e-002;
    __statist_i_h_wts[11,228]=2.79114024823282e-001;
    __statist_i_h_wts[11,229]=-3.07701464757950e-002;
    __statist_i_h_wts[11,230]=-4.62989200226313e-001;
    __statist_i_h_wts[11,231]=-1.44875280140666e-001;
    __statist_i_h_wts[11,232]=-5.02078481129130e-001;
    __statist_i_h_wts[11,233]=-1.85100564159093e-001;
    __statist_i_h_wts[11,234]=-5.34727687879282e-001;
    __statist_i_h_wts[11,235]=3.16103720680064e-002;
    __statist_i_h_wts[11,236]=4.34542238142517e-001;
    __statist_i_h_wts[11,237]=7.91924642353945e-001;
    __statist_i_h_wts[11,238]=2.59213337402777e-001;
    __statist_i_h_wts[11,239]=-4.19183795511506e-001;
    __statist_i_h_wts[11,240]=1.30745364414487e-001;
    __statist_i_h_wts[11,241]=-5.68267318609716e-001;
    __statist_i_h_wts[11,242]=4.61145073376642e-002;
    __statist_i_h_wts[11,243]=-3.48328417109838e-001;
    __statist_i_h_wts[11,244]=-5.72260663823028e-002;
    __statist_i_h_wts[11,245]=4.81435758461657e-001;
    __statist_i_h_wts[11,246]=-2.04550882448754e-002;
    __statist_i_h_wts[11,247]=4.70517692883320e-001;
    __statist_i_h_wts[11,248]=7.01299196984582e-002;

    __statist_i_h_wts[12,0]=3.49858597519912e-002;
    __statist_i_h_wts[12,1]=3.71219899645162e-002;
    __statist_i_h_wts[12,2]=9.62556357494444e-002;
    __statist_i_h_wts[12,3]=1.15658544518567e-001;
    __statist_i_h_wts[12,4]=2.11559265410803e-001;
    __statist_i_h_wts[12,5]=1.45785170563655e-001;
    __statist_i_h_wts[12,6]=1.26539440217422e-002;
    __statist_i_h_wts[12,7]=-4.00795241075301e-002;
    __statist_i_h_wts[12,8]=-7.24923090586504e-002;
    __statist_i_h_wts[12,9]=-3.56813433205851e-002;
    __statist_i_h_wts[12,10]=-4.82438916374278e-002;
    __statist_i_h_wts[12,11]=-1.07921071211879e-001;
    __statist_i_h_wts[12,12]=-1.51617229495264e-001;
    __statist_i_h_wts[12,13]=1.66878671569847e-002;
    __statist_i_h_wts[12,14]=6.41751983043479e-002;
    __statist_i_h_wts[12,15]=1.23335154964985e-001;
    __statist_i_h_wts[12,16]=1.02724079514221e-001;
    __statist_i_h_wts[12,17]=6.23987851624487e-002;
    __statist_i_h_wts[12,18]=3.25455082956632e-002;
    __statist_i_h_wts[12,19]=1.13287316027248e-001;
    __statist_i_h_wts[12,20]=-2.57968644971495e-002;
    __statist_i_h_wts[12,21]=-5.50202713766930e-002;
    __statist_i_h_wts[12,22]=-1.80227326110093e-002;
    __statist_i_h_wts[12,23]=-8.62538362649100e-003;
    __statist_i_h_wts[12,24]=-2.45910276571687e-002;
    __statist_i_h_wts[12,25]=4.13843402147496e-002;
    __statist_i_h_wts[12,26]=7.55320994273400e-002;
    __statist_i_h_wts[12,27]=5.29623752252438e-002;
    __statist_i_h_wts[12,28]=-2.87781794135373e-004;
    __statist_i_h_wts[12,29]=3.00628210901333e-002;
    __statist_i_h_wts[12,30]=2.11384374541813e-001;
    __statist_i_h_wts[12,31]=1.08001629294381e-001;
    __statist_i_h_wts[12,32]=-5.44846303606208e-002;
    __statist_i_h_wts[12,33]=6.26924333059620e-002;
    __statist_i_h_wts[12,34]=2.98858768411153e-002;
    __statist_i_h_wts[12,35]=-2.32045456630341e-002;
    __statist_i_h_wts[12,36]=4.25835218853791e-002;
    __statist_i_h_wts[12,37]=1.71750114407241e-002;
    __statist_i_h_wts[12,38]=-7.36019595963269e-002;
    __statist_i_h_wts[12,39]=-6.29871201215812e-002;
    __statist_i_h_wts[12,40]=-1.27208040707539e-002;
    __statist_i_h_wts[12,41]=-2.78093656754020e-002;
    __statist_i_h_wts[12,42]=7.07372002197359e-003;
    __statist_i_h_wts[12,43]=-7.99684075968941e-002;
    __statist_i_h_wts[12,44]=-9.28034147812682e-002;
    __statist_i_h_wts[12,45]=1.17640820054284e-001;
    __statist_i_h_wts[12,46]=7.89048748240572e-002;
    __statist_i_h_wts[12,47]=-1.17624386271336e-001;
    __statist_i_h_wts[12,48]=-1.45558886555675e-002;
    __statist_i_h_wts[12,49]=-8.52900200588163e-002;
    __statist_i_h_wts[12,50]=-4.41165297171670e-002;
    __statist_i_h_wts[12,51]=-6.18947927905027e-002;
    __statist_i_h_wts[12,52]=1.06866499035032e-001;
    __statist_i_h_wts[12,53]=1.28479987338414e-003;
    __statist_i_h_wts[12,54]=4.02041615564059e-003;
    __statist_i_h_wts[12,55]=3.46846231349630e-002;
    __statist_i_h_wts[12,56]=2.58603422655347e-002;
    __statist_i_h_wts[12,57]=-7.88861717033822e-002;
    __statist_i_h_wts[12,58]=-6.55182793086574e-002;
    __statist_i_h_wts[12,59]=-1.17230970640434e-002;
    __statist_i_h_wts[12,60]=3.48403093965569e-003;
    __statist_i_h_wts[12,61]=1.76046137940320e-002;
    __statist_i_h_wts[12,62]=-1.72844572796325e-001;
    __statist_i_h_wts[12,63]=-7.05392129159743e-002;
    __statist_i_h_wts[12,64]=-5.88362339125613e-002;
    __statist_i_h_wts[12,65]=-6.37035061881256e-002;
    __statist_i_h_wts[12,66]=-8.17143920007914e-002;
    __statist_i_h_wts[12,67]=9.55257386140383e-002;
    __statist_i_h_wts[12,68]=-5.22707954758860e-004;
    __statist_i_h_wts[12,69]=-3.80937524869927e-002;
    __statist_i_h_wts[12,70]=-4.26976777263142e-002;
    __statist_i_h_wts[12,71]=-1.78114245391568e-002;
    __statist_i_h_wts[12,72]=-8.71909904862968e-002;
    __statist_i_h_wts[12,73]=-2.55496813985794e-002;
    __statist_i_h_wts[12,74]=-2.52639933790472e-002;
    __statist_i_h_wts[12,75]=1.34307863937324e-001;
    __statist_i_h_wts[12,76]=1.39602965808656e-001;
    __statist_i_h_wts[12,77]=-2.69671109535132e-002;
    __statist_i_h_wts[12,78]=-7.66398641577812e-002;
    __statist_i_h_wts[12,79]=-8.58585455105286e-002;
    __statist_i_h_wts[12,80]=-7.18353745151372e-002;
    __statist_i_h_wts[12,81]=-9.16403879808433e-002;
    __statist_i_h_wts[12,82]=1.58228805918614e-002;
    __statist_i_h_wts[12,83]=7.73276911368315e-002;
    __statist_i_h_wts[12,84]=2.90253303101697e-002;
    __statist_i_h_wts[12,85]=1.64042107345325e-002;
    __statist_i_h_wts[12,86]=-9.75976382937172e-002;
    __statist_i_h_wts[12,87]=-4.25713292731724e-002;
    __statist_i_h_wts[12,88]=3.73916637249505e-003;
    __statist_i_h_wts[12,89]=9.88878519259056e-002;
    __statist_i_h_wts[12,90]=-5.37026768501713e-002;
    __statist_i_h_wts[12,91]=5.59199430568990e-002;
    __statist_i_h_wts[12,92]=-1.26233287389726e-001;
    __statist_i_h_wts[12,93]=-8.87614038023292e-002;
    __statist_i_h_wts[12,94]=-4.48657493429664e-002;
    __statist_i_h_wts[12,95]=-8.28703627287847e-003;
    __statist_i_h_wts[12,96]=-4.65374894249313e-002;
    __statist_i_h_wts[12,97]=-1.80758444391329e-002;
    __statist_i_h_wts[12,98]=-6.80681953129424e-002;
    __statist_i_h_wts[12,99]=-1.80308928215201e-002;
    __statist_i_h_wts[12,100]=3.45261543668690e-002;
    __statist_i_h_wts[12,101]=-4.03359739812204e-002;
    __statist_i_h_wts[12,102]=-9.06659543751685e-002;
    __statist_i_h_wts[12,103]=4.79667081561035e-003;
    __statist_i_h_wts[12,104]=-1.88740173422647e-005;
    __statist_i_h_wts[12,105]=-1.16050648417525e-001;
    __statist_i_h_wts[12,106]=-8.01085365794819e-002;
    __statist_i_h_wts[12,107]=-7.54100946607689e-002;
    __statist_i_h_wts[12,108]=-2.10577819166187e-002;
    __statist_i_h_wts[12,109]=4.31570922846720e-002;
    __statist_i_h_wts[12,110]=1.23199606161354e-001;
    __statist_i_h_wts[12,111]=-7.55349546564962e-003;
    __statist_i_h_wts[12,112]=-1.01424797868093e-001;
    __statist_i_h_wts[12,113]=-4.09503986345509e-003;
    __statist_i_h_wts[12,114]=8.38891382782762e-002;
    __statist_i_h_wts[12,115]=7.61112826011651e-002;
    __statist_i_h_wts[12,116]=-4.74129202036156e-002;
    __statist_i_h_wts[12,117]=-1.40592127590662e-001;
    __statist_i_h_wts[12,118]=-9.75970910122384e-002;
    __statist_i_h_wts[12,119]=-2.19442537212136e-002;
    __statist_i_h_wts[12,120]=-2.67928405761467e-002;
    __statist_i_h_wts[12,121]=-4.82209161095605e-002;
    __statist_i_h_wts[12,122]=2.42558253846626e-002;
    __statist_i_h_wts[12,123]=1.11600204499934e-001;
    __statist_i_h_wts[12,124]=4.51188954465986e-002;
    __statist_i_h_wts[12,125]=2.54326171796474e-002;
    __statist_i_h_wts[12,126]=-7.43712134683376e-002;
    __statist_i_h_wts[12,127]=-2.47877625793994e-001;
    __statist_i_h_wts[12,128]=-1.66742732007181e-001;
    __statist_i_h_wts[12,129]=6.32811235299352e-002;
    __statist_i_h_wts[12,130]=1.57534472280592e-001;
    __statist_i_h_wts[12,131]=7.45896489684179e-002;
    __statist_i_h_wts[12,132]=2.79102218997741e-002;
    __statist_i_h_wts[12,133]=8.57463167039970e-002;
    __statist_i_h_wts[12,134]=2.59884138892432e-002;
    __statist_i_h_wts[12,135]=-8.62446910930028e-003;
    __statist_i_h_wts[12,136]=1.68945456590193e-002;
    __statist_i_h_wts[12,137]=4.52865168856531e-002;
    __statist_i_h_wts[12,138]=9.89168016466090e-002;
    __statist_i_h_wts[12,139]=-1.83114751928902e-002;
    __statist_i_h_wts[12,140]=1.54898072567197e-001;
    __statist_i_h_wts[12,141]=4.08621556898381e-004;
    __statist_i_h_wts[12,142]=-1.17163308338352e-001;
    __statist_i_h_wts[12,143]=-2.28788391517987e-002;
    __statist_i_h_wts[12,144]=3.17118156169575e-002;
    __statist_i_h_wts[12,145]=1.02098104264119e-001;
    __statist_i_h_wts[12,146]=1.04295206121157e-001;
    __statist_i_h_wts[12,147]=9.44508280050771e-002;
    __statist_i_h_wts[12,148]=8.41793280509980e-002;
    __statist_i_h_wts[12,149]=-1.46638361970790e-002;
    __statist_i_h_wts[12,150]=-1.33155243473351e-001;
    __statist_i_h_wts[12,151]=-6.52687574782895e-002;
    __statist_i_h_wts[12,152]=1.65385024703427e-002;
    __statist_i_h_wts[12,153]=-8.94920318621017e-003;
    __statist_i_h_wts[12,154]=3.06024354717377e-002;
    __statist_i_h_wts[12,155]=1.75186276248577e-001;
    __statist_i_h_wts[12,156]=-1.87666836465091e-002;
    __statist_i_h_wts[12,157]=-8.30464557942578e-002;
    __statist_i_h_wts[12,158]=2.17166796141986e-002;
    __statist_i_h_wts[12,159]=-6.26036585137425e-002;
    __statist_i_h_wts[12,160]=-7.89536049537584e-002;
    __statist_i_h_wts[12,161]=-6.15321103877340e-002;
    __statist_i_h_wts[12,162]=-3.53718759583042e-002;
    __statist_i_h_wts[12,163]=-8.43092779995732e-002;
    __statist_i_h_wts[12,164]=-1.57851132636345e-001;
    __statist_i_h_wts[12,165]=-4.86725873950495e-002;
    __statist_i_h_wts[12,166]=-2.59519584590309e-002;
    __statist_i_h_wts[12,167]=-3.95818079839973e-002;
    __statist_i_h_wts[12,168]=-3.13561073993088e-002;
    __statist_i_h_wts[12,169]=3.41313717719243e-002;
    __statist_i_h_wts[12,170]=8.73977338060378e-002;
    __statist_i_h_wts[12,171]=-1.27641848442375e-002;
    __statist_i_h_wts[12,172]=-5.01741819655055e-002;
    __statist_i_h_wts[12,173]=4.32056580987506e-002;
    __statist_i_h_wts[12,174]=6.38064351418602e-002;
    __statist_i_h_wts[12,175]=-5.10136150365353e-002;
    __statist_i_h_wts[12,176]=-9.58864009645352e-002;
    __statist_i_h_wts[12,177]=-1.86872570833943e-002;
    __statist_i_h_wts[12,178]=-2.17828162518375e-002;
    __statist_i_h_wts[12,179]=-5.87670483578837e-002;
    __statist_i_h_wts[12,180]=-2.86251376233805e-002;
    __statist_i_h_wts[12,181]=-2.27535202125730e-002;
    __statist_i_h_wts[12,182]=-2.66489794088318e-003;
    __statist_i_h_wts[12,183]=8.01916761143570e-002;
    __statist_i_h_wts[12,184]=8.61205664178561e-002;
    __statist_i_h_wts[12,185]=8.50962647519241e-002;
    __statist_i_h_wts[12,186]=5.62960758540911e-002;
    __statist_i_h_wts[12,187]=2.22926771784091e-002;
    __statist_i_h_wts[12,188]=-3.58486868352214e-003;
    __statist_i_h_wts[12,189]=-5.26334060499353e-002;
    __statist_i_h_wts[12,190]=-1.03369242837192e-002;
    __statist_i_h_wts[12,191]=-6.07893448304716e-002;
    __statist_i_h_wts[12,192]=-6.46167864329045e-003;
    __statist_i_h_wts[12,193]=1.50513948727878e-001;
    __statist_i_h_wts[12,194]=8.68745485218754e-002;
    __statist_i_h_wts[12,195]=-2.72699300680822e-002;
    __statist_i_h_wts[12,196]=-1.58521150376919e-002;
    __statist_i_h_wts[12,197]=5.71351452919640e-002;
    __statist_i_h_wts[12,198]=-1.53476549445271e-002;
    __statist_i_h_wts[12,199]=4.13778786998473e-002;
    __statist_i_h_wts[12,200]=4.86884047801226e-002;
    __statist_i_h_wts[12,201]=4.42750143861128e-002;
    __statist_i_h_wts[12,202]=2.81943008758062e-004;
    __statist_i_h_wts[12,203]=-2.59712647608955e-002;
    __statist_i_h_wts[12,204]=-5.77967255180059e-002;
    __statist_i_h_wts[12,205]=4.17071747104087e-002;
    __statist_i_h_wts[12,206]=-5.48328011329082e-002;
    __statist_i_h_wts[12,207]=1.16333888998996e-001;
    __statist_i_h_wts[12,208]=1.85929317554620e-001;
    __statist_i_h_wts[12,209]=2.65790817864877e-002;
    __statist_i_h_wts[12,210]=-6.78192327318244e-002;
    __statist_i_h_wts[12,211]=-6.46795270454743e-002;
    __statist_i_h_wts[12,212]=-3.59597750196430e-002;
    __statist_i_h_wts[12,213]=-1.15076727663413e-002;
    __statist_i_h_wts[12,214]=2.11617213389792e-002;
    __statist_i_h_wts[12,215]=2.02756512425265e-003;
    __statist_i_h_wts[12,216]=2.68837615823761e-002;
    __statist_i_h_wts[12,217]=-2.26918458521679e-002;
    __statist_i_h_wts[12,218]=-2.12819286150534e-002;
    __statist_i_h_wts[12,219]=2.19352540317749e-002;
    __statist_i_h_wts[12,220]=4.23307204122616e-002;
    __statist_i_h_wts[12,221]=-4.12610131979126e-002;
    __statist_i_h_wts[12,222]=9.85602529314961e-002;
    __statist_i_h_wts[12,223]=1.38688666697604e-001;
    __statist_i_h_wts[12,224]=-2.64568840731228e-002;
    __statist_i_h_wts[12,225]=2.78769549560704e-002;
    __statist_i_h_wts[12,226]=1.76459374444794e-001;
    __statist_i_h_wts[12,227]=6.10584986029378e-002;
    __statist_i_h_wts[12,228]=2.30893456805601e-001;
    __statist_i_h_wts[12,229]=7.78908498117238e-002;
    __statist_i_h_wts[12,230]=-7.99567002424821e-001;
    __statist_i_h_wts[12,231]=-4.75004714149664e-001;
    __statist_i_h_wts[12,232]=-1.10265288358713e+000;
    __statist_i_h_wts[12,233]=-4.86160268127833e-001;
    __statist_i_h_wts[12,234]=-1.52751216024397e+000;
    __statist_i_h_wts[12,235]=1.07330413360104e-001;
    __statist_i_h_wts[12,236]=2.36491003451516e-001;
    __statist_i_h_wts[12,237]=2.84759130907484e+000;
    __statist_i_h_wts[12,238]=9.37145560399808e-001;
    __statist_i_h_wts[12,239]=-5.68748449271913e-001;
    __statist_i_h_wts[12,240]=-3.26374675729001e-002;
    __statist_i_h_wts[12,241]=-1.19571698283050e+000;
    __statist_i_h_wts[12,242]=-4.80294174474108e-002;
    __statist_i_h_wts[12,243]=1.20576710323966e-003;
    __statist_i_h_wts[12,244]=3.86268747714767e-002;
    __statist_i_h_wts[12,245]=5.03051853371535e-001;
    __statist_i_h_wts[12,246]=-1.56739246187306e-001;
    __statist_i_h_wts[12,247]=5.14750258023345e-001;
    __statist_i_h_wts[12,248]=4.74773762066347e-001;

    __statist_i_h_wts[13,0]=-3.40533573830203e-001;
    __statist_i_h_wts[13,1]=-3.12253023903722e-001;
    __statist_i_h_wts[13,2]=-2.46190895338547e-001;
    __statist_i_h_wts[13,3]=-2.15600132055246e-001;
    __statist_i_h_wts[13,4]=-1.67234447678363e-001;
    __statist_i_h_wts[13,5]=-1.45273963691214e-001;
    __statist_i_h_wts[13,6]=-1.21799682550602e-001;
    __statist_i_h_wts[13,7]=-9.35984669502934e-002;
    __statist_i_h_wts[13,8]=-4.98809296271831e-002;
    __statist_i_h_wts[13,9]=2.29455333432875e-002;
    __statist_i_h_wts[13,10]=2.97656777581834e-002;
    __statist_i_h_wts[13,11]=2.43378568073578e-002;
    __statist_i_h_wts[13,12]=2.23965183103708e-003;
    __statist_i_h_wts[13,13]=7.73155310153250e-002;
    __statist_i_h_wts[13,14]=1.17669287145334e-001;
    __statist_i_h_wts[13,15]=-3.84009059739000e-001;
    __statist_i_h_wts[13,16]=-3.54803165914014e-001;
    __statist_i_h_wts[13,17]=-3.28950920436260e-001;
    __statist_i_h_wts[13,18]=-2.90276174985084e-001;
    __statist_i_h_wts[13,19]=-2.24682893742064e-001;
    __statist_i_h_wts[13,20]=-2.47308024526877e-001;
    __statist_i_h_wts[13,21]=-1.71128612251779e-001;
    __statist_i_h_wts[13,22]=-1.25981098277797e-001;
    __statist_i_h_wts[13,23]=-7.51598534429361e-002;
    __statist_i_h_wts[13,24]=1.77138030184777e-002;
    __statist_i_h_wts[13,25]=8.01616399930774e-002;
    __statist_i_h_wts[13,26]=1.38079055114078e-001;
    __statist_i_h_wts[13,27]=1.30497275879677e-001;
    __statist_i_h_wts[13,28]=1.29775445086719e-001;
    __statist_i_h_wts[13,29]=1.53816435159469e-001;
    __statist_i_h_wts[13,30]=-3.22129685440382e-001;
    __statist_i_h_wts[13,31]=-2.67904207326308e-001;
    __statist_i_h_wts[13,32]=-2.62087288482467e-001;
    __statist_i_h_wts[13,33]=-1.81782755851838e-001;
    __statist_i_h_wts[13,34]=-1.54307075743488e-001;
    __statist_i_h_wts[13,35]=-1.18378352056333e-001;
    __statist_i_h_wts[13,36]=-3.59650789762757e-002;
    __statist_i_h_wts[13,37]=-1.16690117776739e-002;
    __statist_i_h_wts[13,38]=3.85490108279513e-002;
    __statist_i_h_wts[13,39]=1.32443129949958e-001;
    __statist_i_h_wts[13,40]=1.38244879056000e-001;
    __statist_i_h_wts[13,41]=1.66339898287470e-001;
    __statist_i_h_wts[13,42]=1.78345954231060e-001;
    __statist_i_h_wts[13,43]=1.36219615408985e-001;
    __statist_i_h_wts[13,44]=1.55282331720465e-001;
    __statist_i_h_wts[13,45]=-2.64785403469807e-001;
    __statist_i_h_wts[13,46]=-1.98775658441896e-001;
    __statist_i_h_wts[13,47]=-2.44641125965109e-001;
    __statist_i_h_wts[13,48]=-1.91430294980227e-001;
    __statist_i_h_wts[13,49]=-1.73285786625194e-001;
    __statist_i_h_wts[13,50]=-7.40823645942896e-002;
    __statist_i_h_wts[13,51]=-7.86153569937632e-003;
    __statist_i_h_wts[13,52]=9.28447697776787e-002;
    __statist_i_h_wts[13,53]=1.08805258721933e-001;
    __statist_i_h_wts[13,54]=2.03704023388145e-001;
    __statist_i_h_wts[13,55]=1.82437484916164e-001;
    __statist_i_h_wts[13,56]=2.21269432416672e-001;
    __statist_i_h_wts[13,57]=1.80574755477061e-001;
    __statist_i_h_wts[13,58]=1.95412856896339e-001;
    __statist_i_h_wts[13,59]=1.73960805931348e-001;
    __statist_i_h_wts[13,60]=-2.67498841295147e-001;
    __statist_i_h_wts[13,61]=-2.31975417529401e-001;
    __statist_i_h_wts[13,62]=-2.44801164245872e-001;
    __statist_i_h_wts[13,63]=-2.12979166132950e-001;
    __statist_i_h_wts[13,64]=-1.71447343131966e-001;
    __statist_i_h_wts[13,65]=-9.44141886391761e-002;
    __statist_i_h_wts[13,66]=2.41072599203197e-002;
    __statist_i_h_wts[13,67]=9.45109697438955e-002;
    __statist_i_h_wts[13,68]=1.01449683452182e-001;
    __statist_i_h_wts[13,69]=2.17508319789740e-001;
    __statist_i_h_wts[13,70]=2.01091316409905e-001;
    __statist_i_h_wts[13,71]=2.48330800937629e-001;
    __statist_i_h_wts[13,72]=2.23118199986251e-001;
    __statist_i_h_wts[13,73]=2.58616331008869e-001;
    __statist_i_h_wts[13,74]=2.19050374060236e-001;
    __statist_i_h_wts[13,75]=-2.29933707821376e-001;
    __statist_i_h_wts[13,76]=-1.69555891171964e-001;
    __statist_i_h_wts[13,77]=-2.15659959901922e-001;
    __statist_i_h_wts[13,78]=-1.79803087352173e-001;
    __statist_i_h_wts[13,79]=-1.46908817905010e-001;
    __statist_i_h_wts[13,80]=-4.62770803432104e-002;
    __statist_i_h_wts[13,81]=2.69753923909811e-002;
    __statist_i_h_wts[13,82]=9.44951152112892e-002;
    __statist_i_h_wts[13,83]=1.36627386483614e-001;
    __statist_i_h_wts[13,84]=2.11685286501613e-001;
    __statist_i_h_wts[13,85]=2.29005892767057e-001;
    __statist_i_h_wts[13,86]=2.06154667328269e-001;
    __statist_i_h_wts[13,87]=2.06144747892423e-001;
    __statist_i_h_wts[13,88]=2.16656186258346e-001;
    __statist_i_h_wts[13,89]=2.06333754928153e-001;
    __statist_i_h_wts[13,90]=-2.57850947105331e-001;
    __statist_i_h_wts[13,91]=-1.58521178397179e-001;
    __statist_i_h_wts[13,92]=-1.87692879453407e-001;
    __statist_i_h_wts[13,93]=-1.32881984003024e-001;
    __statist_i_h_wts[13,94]=-9.71642093177524e-002;
    __statist_i_h_wts[13,95]=-2.66572918054886e-002;
    __statist_i_h_wts[13,96]=3.62453126237774e-002;
    __statist_i_h_wts[13,97]=9.26076319640027e-002;
    __statist_i_h_wts[13,98]=1.30949887781536e-001;
    __statist_i_h_wts[13,99]=2.42965634842179e-001;
    __statist_i_h_wts[13,100]=2.60346065092402e-001;
    __statist_i_h_wts[13,101]=2.06151504514256e-001;
    __statist_i_h_wts[13,102]=1.91076366033584e-001;
    __statist_i_h_wts[13,103]=2.41215744671414e-001;
    __statist_i_h_wts[13,104]=2.00730361774237e-001;
    __statist_i_h_wts[13,105]=-2.66524032554926e-001;
    __statist_i_h_wts[13,106]=-1.83513483374258e-001;
    __statist_i_h_wts[13,107]=-1.70341545674816e-001;
    __statist_i_h_wts[13,108]=-1.18555098462980e-001;
    __statist_i_h_wts[13,109]=-6.99249633455493e-002;
    __statist_i_h_wts[13,110]=1.81606287571759e-002;
    __statist_i_h_wts[13,111]=9.11072925570486e-002;
    __statist_i_h_wts[13,112]=1.20625735011367e-001;
    __statist_i_h_wts[13,113]=1.56723146236580e-001;
    __statist_i_h_wts[13,114]=2.37285287145254e-001;
    __statist_i_h_wts[13,115]=2.48376753642912e-001;
    __statist_i_h_wts[13,116]=2.17844339522533e-001;
    __statist_i_h_wts[13,117]=1.98390743550069e-001;
    __statist_i_h_wts[13,118]=1.81753922640580e-001;
    __statist_i_h_wts[13,119]=2.20276772084142e-001;
    __statist_i_h_wts[13,120]=-2.18883572211784e-001;
    __statist_i_h_wts[13,121]=-1.85156733291172e-001;
    __statist_i_h_wts[13,122]=-1.50801641723456e-001;
    __statist_i_h_wts[13,123]=-9.72448968686840e-002;
    __statist_i_h_wts[13,124]=-6.73224130000645e-002;
    __statist_i_h_wts[13,125]=1.20874470441089e-002;
    __statist_i_h_wts[13,126]=6.16542264774689e-002;
    __statist_i_h_wts[13,127]=8.33292367764457e-002;
    __statist_i_h_wts[13,128]=5.21081884247291e-002;
    __statist_i_h_wts[13,129]=1.62662194282854e-001;
    __statist_i_h_wts[13,130]=2.34222038976838e-001;
    __statist_i_h_wts[13,131]=2.19505847367984e-001;
    __statist_i_h_wts[13,132]=2.32627501728965e-001;
    __statist_i_h_wts[13,133]=2.47580222074764e-001;
    __statist_i_h_wts[13,134]=2.39027729751686e-001;
    __statist_i_h_wts[13,135]=-1.87482770488352e-001;
    __statist_i_h_wts[13,136]=-1.70756312082186e-001;
    __statist_i_h_wts[13,137]=-1.61000113934800e-001;
    __statist_i_h_wts[13,138]=-1.16927901713212e-001;
    __statist_i_h_wts[13,139]=-7.43755234799230e-002;
    __statist_i_h_wts[13,140]=2.98582356940634e-002;
    __statist_i_h_wts[13,141]=4.82988786991998e-002;
    __statist_i_h_wts[13,142]=2.79418385569962e-002;
    __statist_i_h_wts[13,143]=-2.55328652896380e-002;
    __statist_i_h_wts[13,144]=5.77500492027873e-002;
    __statist_i_h_wts[13,145]=1.54833912558361e-001;
    __statist_i_h_wts[13,146]=2.09676295594627e-001;
    __statist_i_h_wts[13,147]=1.92187680054842e-001;
    __statist_i_h_wts[13,148]=2.02620147071673e-001;
    __statist_i_h_wts[13,149]=2.07015385561671e-001;
    __statist_i_h_wts[13,150]=-2.28544796014076e-001;
    __statist_i_h_wts[13,151]=-1.90224862100861e-001;
    __statist_i_h_wts[13,152]=-1.44699404522246e-001;
    __statist_i_h_wts[13,153]=-1.56856120738240e-001;
    __statist_i_h_wts[13,154]=-5.82742858880637e-002;
    __statist_i_h_wts[13,155]=1.83254059412460e-002;
    __statist_i_h_wts[13,156]=5.23037680092197e-002;
    __statist_i_h_wts[13,157]=5.47435757427136e-002;
    __statist_i_h_wts[13,158]=2.43249002853620e-003;
    __statist_i_h_wts[13,159]=1.55454007458649e-002;
    __statist_i_h_wts[13,160]=7.36727158041161e-002;
    __statist_i_h_wts[13,161]=1.45682375743578e-001;
    __statist_i_h_wts[13,162]=1.44250210889468e-001;
    __statist_i_h_wts[13,163]=1.56897733493385e-001;
    __statist_i_h_wts[13,164]=1.61795133390476e-001;
    __statist_i_h_wts[13,165]=-1.76166807203295e-001;
    __statist_i_h_wts[13,166]=-1.52154254736463e-001;
    __statist_i_h_wts[13,167]=-1.35536914255385e-001;
    __statist_i_h_wts[13,168]=-1.26546932993444e-001;
    __statist_i_h_wts[13,169]=-7.47822548773421e-002;
    __statist_i_h_wts[13,170]=-2.35747687420143e-002;
    __statist_i_h_wts[13,171]=2.63297411265589e-002;
    __statist_i_h_wts[13,172]=3.57028354662564e-002;
    __statist_i_h_wts[13,173]=5.45571045298463e-003;
    __statist_i_h_wts[13,174]=5.41972237338850e-002;
    __statist_i_h_wts[13,175]=8.55173860966023e-002;
    __statist_i_h_wts[13,176]=1.34631985940108e-001;
    __statist_i_h_wts[13,177]=1.35600918345905e-001;
    __statist_i_h_wts[13,178]=1.16668000887760e-001;
    __statist_i_h_wts[13,179]=1.71357068178974e-001;
    __statist_i_h_wts[13,180]=-1.59205308640101e-001;
    __statist_i_h_wts[13,181]=-1.64358108890378e-001;
    __statist_i_h_wts[13,182]=-1.25736465143231e-001;
    __statist_i_h_wts[13,183]=-1.00630192196588e-001;
    __statist_i_h_wts[13,184]=-7.97732536182286e-002;
    __statist_i_h_wts[13,185]=-1.85443847566767e-002;
    __statist_i_h_wts[13,186]=-3.94865628262763e-003;
    __statist_i_h_wts[13,187]=5.40755921872092e-003;
    __statist_i_h_wts[13,188]=-5.49640258902276e-003;
    __statist_i_h_wts[13,189]=6.48726120966369e-003;
    __statist_i_h_wts[13,190]=3.32363801843018e-002;
    __statist_i_h_wts[13,191]=1.17835753016642e-001;
    __statist_i_h_wts[13,192]=1.58171655787984e-001;
    __statist_i_h_wts[13,193]=1.78273030058932e-001;
    __statist_i_h_wts[13,194]=2.14894191582155e-001;
    __statist_i_h_wts[13,195]=-1.51563155397943e-001;
    __statist_i_h_wts[13,196]=-1.46958263023301e-001;
    __statist_i_h_wts[13,197]=-1.19280034411401e-001;
    __statist_i_h_wts[13,198]=-1.49775070193731e-001;
    __statist_i_h_wts[13,199]=-9.45575606332008e-002;
    __statist_i_h_wts[13,200]=-6.20640611378991e-002;
    __statist_i_h_wts[13,201]=-5.19846631209250e-002;
    __statist_i_h_wts[13,202]=-3.78957197136192e-002;
    __statist_i_h_wts[13,203]=-9.82855748608897e-003;
    __statist_i_h_wts[13,204]=-2.74616135960198e-002;
    __statist_i_h_wts[13,205]=-6.88122838723319e-004;
    __statist_i_h_wts[13,206]=9.63444422278262e-002;
    __statist_i_h_wts[13,207]=1.40969642481017e-001;
    __statist_i_h_wts[13,208]=1.75622140269175e-001;
    __statist_i_h_wts[13,209]=1.72118957206156e-001;
    __statist_i_h_wts[13,210]=-1.33379739236322e-001;
    __statist_i_h_wts[13,211]=-1.38842789771134e-001;
    __statist_i_h_wts[13,212]=-1.61590833735127e-001;
    __statist_i_h_wts[13,213]=-1.19486434105193e-001;
    __statist_i_h_wts[13,214]=-9.18272455558671e-002;
    __statist_i_h_wts[13,215]=-8.15760639465063e-002;
    __statist_i_h_wts[13,216]=-5.22765536316867e-002;
    __statist_i_h_wts[13,217]=-4.83378643490506e-002;
    __statist_i_h_wts[13,218]=-2.62453589701710e-002;
    __statist_i_h_wts[13,219]=7.92700424063881e-003;
    __statist_i_h_wts[13,220]=2.78199291567636e-002;
    __statist_i_h_wts[13,221]=7.44978163451444e-002;
    __statist_i_h_wts[13,222]=1.24359466791824e-001;
    __statist_i_h_wts[13,223]=1.70211992939202e-001;
    __statist_i_h_wts[13,224]=1.47393751578780e-001;
    __statist_i_h_wts[13,225]=-5.70792227375185e-002;
    __statist_i_h_wts[13,226]=3.82362389082580e-001;
    __statist_i_h_wts[13,227]=4.83703643769338e-002;
    __statist_i_h_wts[13,228]=4.48811529320570e-001;
    __statist_i_h_wts[13,229]=2.95233251411917e-003;
    __statist_i_h_wts[13,230]=-6.85121372684946e-001;
    __statist_i_h_wts[13,231]=-2.75720518040855e-001;
    __statist_i_h_wts[13,232]=-8.03860090998305e-001;
    __statist_i_h_wts[13,233]=-3.16108500737392e-001;
    __statist_i_h_wts[13,234]=-1.06307631369275e+000;
    __statist_i_h_wts[13,235]=1.35707936614962e-002;
    __statist_i_h_wts[13,236]=4.55764697706942e-001;
    __statist_i_h_wts[13,237]=1.61194151860313e+000;
    __statist_i_h_wts[13,238]=4.65239447459278e-001;
    __statist_i_h_wts[13,239]=-6.40999289381750e-001;
    __statist_i_h_wts[13,240]=2.35353730237528e-002;
    __statist_i_h_wts[13,241]=-9.81989712032996e-001;
    __statist_i_h_wts[13,242]=5.57224672995445e-002;
    __statist_i_h_wts[13,243]=-5.00932177767500e-001;
    __statist_i_h_wts[13,244]=-6.70595734143739e-002;
    __statist_i_h_wts[13,245]=6.51037026460166e-001;
    __statist_i_h_wts[13,246]=-1.16392582042190e-001;
    __statist_i_h_wts[13,247]=6.53543274354570e-001;
    __statist_i_h_wts[13,248]=1.82209035067110e-001;

    __statist_i_h_wts[14,0]=-1.53009495878617e-001;
    __statist_i_h_wts[14,1]=-7.32857791998090e-002;
    __statist_i_h_wts[14,2]=-2.76228019370355e-002;
    __statist_i_h_wts[14,3]=8.14312965591640e-002;
    __statist_i_h_wts[14,4]=1.14180406363257e-001;
    __statist_i_h_wts[14,5]=1.57937930675716e-001;
    __statist_i_h_wts[14,6]=1.19894011142934e-002;
    __statist_i_h_wts[14,7]=-1.36719679542678e-001;
    __statist_i_h_wts[14,8]=-8.12211698620406e-002;
    __statist_i_h_wts[14,9]=5.08298013178522e-002;
    __statist_i_h_wts[14,10]=-5.05599938088032e-002;
    __statist_i_h_wts[14,11]=-7.15179996675619e-002;
    __statist_i_h_wts[14,12]=-1.52312340449772e-001;
    __statist_i_h_wts[14,13]=4.61050048797488e-002;
    __statist_i_h_wts[14,14]=2.31799023187369e-001;
    __statist_i_h_wts[14,15]=-5.92713704410440e-003;
    __statist_i_h_wts[14,16]=5.35169733355617e-002;
    __statist_i_h_wts[14,17]=-2.63267213158241e-002;
    __statist_i_h_wts[14,18]=7.57152885698527e-002;
    __statist_i_h_wts[14,19]=3.40766520790015e-002;
    __statist_i_h_wts[14,20]=-5.25192673747811e-002;
    __statist_i_h_wts[14,21]=-1.14269635306125e-001;
    __statist_i_h_wts[14,22]=-6.19483235707919e-002;
    __statist_i_h_wts[14,23]=-6.36606327365668e-002;
    __statist_i_h_wts[14,24]=-2.49375539631999e-002;
    __statist_i_h_wts[14,25]=2.84486585285870e-002;
    __statist_i_h_wts[14,26]=1.90925274142150e-001;
    __statist_i_h_wts[14,27]=8.76563087285310e-002;
    __statist_i_h_wts[14,28]=9.11640182602486e-003;
    __statist_i_h_wts[14,29]=1.55158364963023e-001;
    __statist_i_h_wts[14,30]=7.71970912617263e-002;
    __statist_i_h_wts[14,31]=6.99431207895012e-002;
    __statist_i_h_wts[14,32]=-1.26926468352037e-001;
    __statist_i_h_wts[14,33]=1.75820573084859e-001;
    __statist_i_h_wts[14,34]=-8.58869198662186e-003;
    __statist_i_h_wts[14,35]=4.48458271483312e-003;
    __statist_i_h_wts[14,36]=1.35620596433994e-001;
    __statist_i_h_wts[14,37]=6.46353795859565e-002;
    __statist_i_h_wts[14,38]=-4.98925236772193e-002;
    __statist_i_h_wts[14,39]=2.79264122186813e-004;
    __statist_i_h_wts[14,40]=3.30765362192123e-003;
    __statist_i_h_wts[14,41]=-1.46296743850874e-002;
    __statist_i_h_wts[14,42]=5.10225350422161e-002;
    __statist_i_h_wts[14,43]=-9.60604715273760e-002;
    __statist_i_h_wts[14,44]=2.88491501701636e-002;
    __statist_i_h_wts[14,45]=-4.54888100450016e-002;
    __statist_i_h_wts[14,46]=5.93815922844710e-002;
    __statist_i_h_wts[14,47]=-1.79678501861885e-001;
    __statist_i_h_wts[14,48]=2.47196148763295e-002;
    __statist_i_h_wts[14,49]=-2.39071902299863e-001;
    __statist_i_h_wts[14,50]=-7.05864772729937e-002;
    __statist_i_h_wts[14,51]=-8.08179912487010e-002;
    __statist_i_h_wts[14,52]=9.30633286536907e-002;
    __statist_i_h_wts[14,53]=-6.60193059059020e-002;
    __statist_i_h_wts[14,54]=8.76221705068495e-002;
    __statist_i_h_wts[14,55]=2.08010559785959e-002;
    __statist_i_h_wts[14,56]=7.53939977028026e-002;
    __statist_i_h_wts[14,57]=-8.07825098468434e-002;
    __statist_i_h_wts[14,58]=-7.99682980735336e-002;
    __statist_i_h_wts[14,59]=-3.17076177404801e-002;
    __statist_i_h_wts[14,60]=-8.41397159808653e-002;
    __statist_i_h_wts[14,61]=-6.15886949637399e-002;
    __statist_i_h_wts[14,62]=-1.09564337324891e-001;
    __statist_i_h_wts[14,63]=3.14753239035260e-002;
    __statist_i_h_wts[14,64]=-4.71373831575809e-002;
    __statist_i_h_wts[14,65]=5.80682633294358e-002;
    __statist_i_h_wts[14,66]=-2.45346182267284e-002;
    __statist_i_h_wts[14,67]=1.21929426368445e-001;
    __statist_i_h_wts[14,68]=-1.31486846448054e-001;
    __statist_i_h_wts[14,69]=1.31023731247569e-002;
    __statist_i_h_wts[14,70]=-1.35455282728813e-001;
    __statist_i_h_wts[14,71]=-4.02319792811996e-002;
    __statist_i_h_wts[14,72]=-2.64670866663495e-002;
    __statist_i_h_wts[14,73]=5.95406065553948e-002;
    __statist_i_h_wts[14,74]=-5.27407778923304e-003;
    __statist_i_h_wts[14,75]=5.44949129270067e-002;
    __statist_i_h_wts[14,76]=4.20809238412591e-002;
    __statist_i_h_wts[14,77]=2.02716537052865e-002;
    __statist_i_h_wts[14,78]=-4.08291570162993e-002;
    __statist_i_h_wts[14,79]=-1.14828530515668e-001;
    __statist_i_h_wts[14,80]=-1.19912273208175e-001;
    __statist_i_h_wts[14,81]=-1.89633305791472e-001;
    __statist_i_h_wts[14,82]=-1.75504652714711e-002;
    __statist_i_h_wts[14,83]=-1.06650913681709e-001;
    __statist_i_h_wts[14,84]=5.01852766853895e-003;
    __statist_i_h_wts[14,85]=-2.98742959206035e-002;
    __statist_i_h_wts[14,86]=-1.49658172341581e-001;
    __statist_i_h_wts[14,87]=-1.92855125636774e-003;
    __statist_i_h_wts[14,88]=-4.97524293102945e-004;
    __statist_i_h_wts[14,89]=1.67757245840341e-001;
    __statist_i_h_wts[14,90]=-7.42028537562968e-002;
    __statist_i_h_wts[14,91]=1.01606833513300e-001;
    __statist_i_h_wts[14,92]=-5.18992419143528e-002;
    __statist_i_h_wts[14,93]=-3.92078635484856e-002;
    __statist_i_h_wts[14,94]=-2.51595891220504e-003;
    __statist_i_h_wts[14,95]=-3.35661313400965e-002;
    __statist_i_h_wts[14,96]=4.64495809880418e-002;
    __statist_i_h_wts[14,97]=7.72239475135816e-002;
    __statist_i_h_wts[14,98]=-5.40893600413282e-002;
    __statist_i_h_wts[14,99]=-8.25126484627943e-002;
    __statist_i_h_wts[14,100]=-3.73292914085729e-002;
    __statist_i_h_wts[14,101]=-8.28362878986195e-002;
    __statist_i_h_wts[14,102]=-2.47274268984081e-002;
    __statist_i_h_wts[14,103]=5.25383408776878e-002;
    __statist_i_h_wts[14,104]=5.42919742920287e-002;
    __statist_i_h_wts[14,105]=-1.58273409741580e-001;
    __statist_i_h_wts[14,106]=-9.29200743295840e-002;
    __statist_i_h_wts[14,107]=-1.20833481054681e-001;
    __statist_i_h_wts[14,108]=1.19821631603409e-002;
    __statist_i_h_wts[14,109]=-7.45261803412852e-002;
    __statist_i_h_wts[14,110]=1.29684421864785e-002;
    __statist_i_h_wts[14,111]=1.26925514149717e-001;
    __statist_i_h_wts[14,112]=2.62150294120452e-002;
    __statist_i_h_wts[14,113]=6.10341695196012e-002;
    __statist_i_h_wts[14,114]=3.88396398358806e-002;
    __statist_i_h_wts[14,115]=-1.20638609652734e-001;
    __statist_i_h_wts[14,116]=-1.25252657555727e-001;
    __statist_i_h_wts[14,117]=-3.46948032140661e-002;
    __statist_i_h_wts[14,118]=-5.85524073593733e-002;
    __statist_i_h_wts[14,119]=1.73921597352343e-002;
    __statist_i_h_wts[14,120]=7.35795145383056e-003;
    __statist_i_h_wts[14,121]=-6.95378098396883e-003;
    __statist_i_h_wts[14,122]=9.77960172989478e-003;
    __statist_i_h_wts[14,123]=1.15101393207112e-001;
    __statist_i_h_wts[14,124]=6.34495468823568e-003;
    __statist_i_h_wts[14,125]=-1.35763898810739e-001;
    __statist_i_h_wts[14,126]=-1.86961421954324e-002;
    __statist_i_h_wts[14,127]=-1.26905451205637e-001;
    __statist_i_h_wts[14,128]=-2.12200927683510e-001;
    __statist_i_h_wts[14,129]=4.60319584016438e-002;
    __statist_i_h_wts[14,130]=-5.94705519840872e-002;
    __statist_i_h_wts[14,131]=2.91458494603369e-002;
    __statist_i_h_wts[14,132]=1.32465319009720e-001;
    __statist_i_h_wts[14,133]=1.55192293261037e-001;
    __statist_i_h_wts[14,134]=8.30726410032695e-002;
    __statist_i_h_wts[14,135]=-6.61758180620415e-003;
    __statist_i_h_wts[14,136]=-4.13633182590142e-002;
    __statist_i_h_wts[14,137]=-4.94240343410308e-002;
    __statist_i_h_wts[14,138]=6.76717001670083e-003;
    __statist_i_h_wts[14,139]=-1.51812767892502e-001;
    __statist_i_h_wts[14,140]=9.76869306301445e-002;
    __statist_i_h_wts[14,141]=7.89101285875112e-002;
    __statist_i_h_wts[14,142]=-5.92687297006805e-002;
    __statist_i_h_wts[14,143]=-9.32032654180066e-002;
    __statist_i_h_wts[14,144]=1.04648159104089e-003;
    __statist_i_h_wts[14,145]=-5.87726599210768e-002;
    __statist_i_h_wts[14,146]=1.00136075693461e-001;
    __statist_i_h_wts[14,147]=1.64648724918241e-001;
    __statist_i_h_wts[14,148]=5.79996337987732e-002;
    __statist_i_h_wts[14,149]=9.49078064664003e-003;
    __statist_i_h_wts[14,150]=-1.31600398851595e-001;
    __statist_i_h_wts[14,151]=-1.25253653591808e-001;
    __statist_i_h_wts[14,152]=-4.33290961590473e-002;
    __statist_i_h_wts[14,153]=-1.11223231276293e-001;
    __statist_i_h_wts[14,154]=-6.91158821813434e-002;
    __statist_i_h_wts[14,155]=8.37352171350306e-002;
    __statist_i_h_wts[14,156]=6.02021142806572e-002;
    __statist_i_h_wts[14,157]=-1.21898022715344e-001;
    __statist_i_h_wts[14,158]=-7.47246107157900e-002;
    __statist_i_h_wts[14,159]=-1.29492983680657e-002;
    __statist_i_h_wts[14,160]=-1.13611404824855e-001;
    __statist_i_h_wts[14,161]=-5.38351204669693e-002;
    __statist_i_h_wts[14,162]=8.68063781809815e-002;
    __statist_i_h_wts[14,163]=-5.60568954239099e-002;
    __statist_i_h_wts[14,164]=-1.38835694144538e-001;
    __statist_i_h_wts[14,165]=4.21402620151829e-002;
    __statist_i_h_wts[14,166]=3.64746122306274e-002;
    __statist_i_h_wts[14,167]=6.85926965026139e-002;
    __statist_i_h_wts[14,168]=-8.46112477880996e-002;
    __statist_i_h_wts[14,169]=6.67627246144632e-004;
    __statist_i_h_wts[14,170]=3.93750190858425e-003;
    __statist_i_h_wts[14,171]=-4.60181213170627e-002;
    __statist_i_h_wts[14,172]=-7.04403635766503e-002;
    __statist_i_h_wts[14,173]=1.98515751405996e-002;
    __statist_i_h_wts[14,174]=2.27576203878876e-001;
    __statist_i_h_wts[14,175]=8.08378043007399e-002;
    __statist_i_h_wts[14,176]=-8.65441022733307e-002;
    __statist_i_h_wts[14,177]=3.21539490912021e-003;
    __statist_i_h_wts[14,178]=-7.08821947607772e-002;
    __statist_i_h_wts[14,179]=-7.35269037190771e-002;
    __statist_i_h_wts[14,180]=2.64354549214575e-002;
    __statist_i_h_wts[14,181]=7.19123868969317e-003;
    __statist_i_h_wts[14,182]=5.96693632516945e-002;
    __statist_i_h_wts[14,183]=2.34990649737835e-002;
    __statist_i_h_wts[14,184]=3.94351069341449e-002;
    __statist_i_h_wts[14,185]=2.02390003405347e-002;
    __statist_i_h_wts[14,186]=-3.48074947528225e-002;
    __statist_i_h_wts[14,187]=1.95933598599419e-002;
    __statist_i_h_wts[14,188]=-4.05071225889854e-002;
    __statist_i_h_wts[14,189]=3.25131595101560e-002;
    __statist_i_h_wts[14,190]=-2.97595781273434e-002;
    __statist_i_h_wts[14,191]=-1.26566837202950e-001;
    __statist_i_h_wts[14,192]=-4.63659760632466e-002;
    __statist_i_h_wts[14,193]=9.38002064108197e-002;
    __statist_i_h_wts[14,194]=8.01945974059470e-002;
    __statist_i_h_wts[14,195]=5.15651279519105e-002;
    __statist_i_h_wts[14,196]=1.56335562217003e-002;
    __statist_i_h_wts[14,197]=1.46499169438065e-001;
    __statist_i_h_wts[14,198]=2.88295562807248e-003;
    __statist_i_h_wts[14,199]=1.34062535081894e-002;
    __statist_i_h_wts[14,200]=4.01578462030802e-003;
    __statist_i_h_wts[14,201]=1.62918391591581e-002;
    __statist_i_h_wts[14,202]=-5.19878831480201e-002;
    __statist_i_h_wts[14,203]=5.26300925377334e-002;
    __statist_i_h_wts[14,204]=5.51512818279884e-002;
    __statist_i_h_wts[14,205]=4.21648397025547e-002;
    __statist_i_h_wts[14,206]=-1.24519412652754e-001;
    __statist_i_h_wts[14,207]=3.53476448018581e-002;
    __statist_i_h_wts[14,208]=1.71569447741417e-001;
    __statist_i_h_wts[14,209]=8.31348323067421e-002;
    __statist_i_h_wts[14,210]=-3.07994620779646e-003;
    __statist_i_h_wts[14,211]=-1.08322776152604e-002;
    __statist_i_h_wts[14,212]=5.46066812211558e-002;
    __statist_i_h_wts[14,213]=4.80825393176832e-002;
    __statist_i_h_wts[14,214]=3.85295722285164e-002;
    __statist_i_h_wts[14,215]=2.02435806056437e-002;
    __statist_i_h_wts[14,216]=1.10867579321467e-002;
    __statist_i_h_wts[14,217]=-2.20006021183737e-002;
    __statist_i_h_wts[14,218]=3.88542979821230e-002;
    __statist_i_h_wts[14,219]=6.95631182243718e-002;
    __statist_i_h_wts[14,220]=7.82827160817137e-002;
    __statist_i_h_wts[14,221]=-2.32382074119062e-002;
    __statist_i_h_wts[14,222]=1.16656754649027e-001;
    __statist_i_h_wts[14,223]=2.27408984373571e-001;
    __statist_i_h_wts[14,224]=1.03018314748195e-001;
    __statist_i_h_wts[14,225]=1.12139637029832e-001;
    __statist_i_h_wts[14,226]=-3.66617392700525e-001;
    __statist_i_h_wts[14,227]=-5.62608295866418e-002;
    __statist_i_h_wts[14,228]=-3.03774761565003e-001;
    __statist_i_h_wts[14,229]=-1.02960376622702e-001;
    __statist_i_h_wts[14,230]=-9.95240200225714e-002;
    __statist_i_h_wts[14,231]=-3.67800810540502e-001;
    __statist_i_h_wts[14,232]=-3.84371041192675e-001;
    __statist_i_h_wts[14,233]=-2.77359154002152e-002;
    __statist_i_h_wts[14,234]=-5.76421398780372e-001;
    __statist_i_h_wts[14,235]=-3.23196069512320e-001;
    __statist_i_h_wts[14,236]=-1.13803246727223e+000;
    __statist_i_h_wts[14,237]=2.24445805970493e+000;
    __statist_i_h_wts[14,238]=8.84033988057182e-001;
    __statist_i_h_wts[14,239]=1.96556678163667e-001;
    __statist_i_h_wts[14,240]=-4.39403195316655e-001;
    __statist_i_h_wts[14,241]=-4.22543264687851e-001;
    __statist_i_h_wts[14,242]=2.11470832619301e-001;
    __statist_i_h_wts[14,243]=5.90644561686251e-001;
    __statist_i_h_wts[14,244]=-2.32575212125431e-001;
    __statist_i_h_wts[14,245]=-7.24945294330268e-001;
    __statist_i_h_wts[14,246]=-4.90097757677521e-001;
    __statist_i_h_wts[14,247]=-4.37979378027218e-001;
    __statist_i_h_wts[14,248]=2.57839716035548e-001;

    __statist_i_h_wts[15,0]=3.48446071144241e-002;
    __statist_i_h_wts[15,1]=7.02195078473679e-002;
    __statist_i_h_wts[15,2]=3.72492232061121e-002;
    __statist_i_h_wts[15,3]=6.54412356288638e-002;
    __statist_i_h_wts[15,4]=5.55852106914616e-002;
    __statist_i_h_wts[15,5]=4.89026349254261e-002;
    __statist_i_h_wts[15,6]=1.67276039738999e-002;
    __statist_i_h_wts[15,7]=2.28242032034179e-003;
    __statist_i_h_wts[15,8]=6.78610249420070e-003;
    __statist_i_h_wts[15,9]=-1.08534605158569e-002;
    __statist_i_h_wts[15,10]=-2.46078196617545e-002;
    __statist_i_h_wts[15,11]=-4.07345048345785e-002;
    __statist_i_h_wts[15,12]=-4.01727599007656e-002;
    __statist_i_h_wts[15,13]=-4.03155528487846e-002;
    __statist_i_h_wts[15,14]=-9.03863469124184e-003;
    __statist_i_h_wts[15,15]=2.43281239826846e-002;
    __statist_i_h_wts[15,16]=5.58211011337019e-002;
    __statist_i_h_wts[15,17]=4.89607925284258e-002;
    __statist_i_h_wts[15,18]=7.11776260752607e-002;
    __statist_i_h_wts[15,19]=6.17025517141177e-002;
    __statist_i_h_wts[15,20]=4.33864813521250e-002;
    __statist_i_h_wts[15,21]=1.32749987740900e-002;
    __statist_i_h_wts[15,22]=-9.88961202024419e-003;
    __statist_i_h_wts[15,23]=-7.06350716313674e-003;
    __statist_i_h_wts[15,24]=-2.64387945439679e-002;
    __statist_i_h_wts[15,25]=-3.81325628497248e-003;
    __statist_i_h_wts[15,26]=-2.65097321022848e-002;
    __statist_i_h_wts[15,27]=-3.93091679074788e-002;
    __statist_i_h_wts[15,28]=-3.78367943561289e-002;
    __statist_i_h_wts[15,29]=-1.06627025370684e-002;
    __statist_i_h_wts[15,30]=6.79869365825986e-002;
    __statist_i_h_wts[15,31]=7.15239189113998e-002;
    __statist_i_h_wts[15,32]=6.36901918868943e-002;
    __statist_i_h_wts[15,33]=8.92676797995663e-002;
    __statist_i_h_wts[15,34]=5.99116123663770e-002;
    __statist_i_h_wts[15,35]=3.02081606361321e-002;
    __statist_i_h_wts[15,36]=1.90778946032051e-002;
    __statist_i_h_wts[15,37]=8.11224929377599e-004;
    __statist_i_h_wts[15,38]=-1.54568625144766e-002;
    __statist_i_h_wts[15,39]=-2.76751047755692e-002;
    __statist_i_h_wts[15,40]=-3.61871624546787e-002;
    __statist_i_h_wts[15,41]=-3.86365758452008e-002;
    __statist_i_h_wts[15,42]=-5.17323884184397e-002;
    __statist_i_h_wts[15,43]=-5.07866675926063e-002;
    __statist_i_h_wts[15,44]=-3.51287115993095e-002;
    __statist_i_h_wts[15,45]=4.34585512594807e-002;
    __statist_i_h_wts[15,46]=6.66353469051729e-002;
    __statist_i_h_wts[15,47]=3.06974851517849e-002;
    __statist_i_h_wts[15,48]=4.89840391879272e-002;
    __statist_i_h_wts[15,49]=2.50120283778046e-002;
    __statist_i_h_wts[15,50]=1.60001673503147e-002;
    __statist_i_h_wts[15,51]=-1.15943868257097e-002;
    __statist_i_h_wts[15,52]=-1.82318779744107e-002;
    __statist_i_h_wts[15,53]=-4.83530478725469e-002;
    __statist_i_h_wts[15,54]=-4.86560753863201e-002;
    __statist_i_h_wts[15,55]=-6.93370499015931e-002;
    __statist_i_h_wts[15,56]=-6.83138393691903e-002;
    __statist_i_h_wts[15,57]=-7.48118403001584e-002;
    __statist_i_h_wts[15,58]=-7.95811809937758e-002;
    __statist_i_h_wts[15,59]=-8.18007919593695e-002;
    __statist_i_h_wts[15,60]=5.21177850353606e-002;
    __statist_i_h_wts[15,61]=4.49390676130356e-002;
    __statist_i_h_wts[15,62]=2.49050486044568e-002;
    __statist_i_h_wts[15,63]=3.77379776993632e-002;
    __statist_i_h_wts[15,64]=2.67694498412108e-002;
    __statist_i_h_wts[15,65]=1.21496550482408e-002;
    __statist_i_h_wts[15,66]=-3.52566493003752e-002;
    __statist_i_h_wts[15,67]=-3.88962467053818e-002;
    __statist_i_h_wts[15,68]=-5.83974603036440e-002;
    __statist_i_h_wts[15,69]=-5.75546251039837e-002;
    __statist_i_h_wts[15,70]=-8.88807413888772e-002;
    __statist_i_h_wts[15,71]=-8.46089780899953e-002;
    __statist_i_h_wts[15,72]=-8.87245541261381e-002;
    __statist_i_h_wts[15,73]=-7.18412269281913e-002;
    __statist_i_h_wts[15,74]=-7.78056505441451e-002;
    __statist_i_h_wts[15,75]=6.95105099486726e-002;
    __statist_i_h_wts[15,76]=5.20120524277556e-002;
    __statist_i_h_wts[15,77]=4.47250066334402e-002;
    __statist_i_h_wts[15,78]=3.72121336005355e-002;
    __statist_i_h_wts[15,79]=1.01711841815116e-002;
    __statist_i_h_wts[15,80]=-5.33829322192700e-003;
    __statist_i_h_wts[15,81]=-4.25385385957105e-002;
    __statist_i_h_wts[15,82]=-6.79580910672262e-002;
    __statist_i_h_wts[15,83]=-7.52630019658695e-002;
    __statist_i_h_wts[15,84]=-7.41573574945396e-002;
    __statist_i_h_wts[15,85]=-9.23055024836131e-002;
    __statist_i_h_wts[15,86]=-1.00757661285599e-001;
    __statist_i_h_wts[15,87]=-9.10638169685823e-002;
    __statist_i_h_wts[15,88]=-1.00350542763178e-001;
    __statist_i_h_wts[15,89]=-7.63168916420860e-002;
    __statist_i_h_wts[15,90]=7.41978025299547e-002;
    __statist_i_h_wts[15,91]=6.64669218821710e-002;
    __statist_i_h_wts[15,92]=4.11077614450895e-002;
    __statist_i_h_wts[15,93]=4.42282832610811e-002;
    __statist_i_h_wts[15,94]=6.89476234588030e-003;
    __statist_i_h_wts[15,95]=-9.81491023609669e-003;
    __statist_i_h_wts[15,96]=-1.67361638078531e-002;
    __statist_i_h_wts[15,97]=-3.79837512631441e-002;
    __statist_i_h_wts[15,98]=-5.28916305559652e-002;
    __statist_i_h_wts[15,99]=-6.39628043740829e-002;
    __statist_i_h_wts[15,100]=-8.18267457485178e-002;
    __statist_i_h_wts[15,101]=-9.13067825935999e-002;
    __statist_i_h_wts[15,102]=-1.00003840209172e-001;
    __statist_i_h_wts[15,103]=-8.80577700835661e-002;
    __statist_i_h_wts[15,104]=-6.23308104138345e-002;
    __statist_i_h_wts[15,105]=7.20093887792868e-002;
    __statist_i_h_wts[15,106]=6.23733807081748e-002;
    __statist_i_h_wts[15,107]=4.47548043007283e-002;
    __statist_i_h_wts[15,108]=5.01124106013094e-002;
    __statist_i_h_wts[15,109]=4.10965065911007e-002;
    __statist_i_h_wts[15,110]=3.14951290592565e-002;
    __statist_i_h_wts[15,111]=-1.61027093755218e-004;
    __statist_i_h_wts[15,112]=-2.90021280243261e-002;
    __statist_i_h_wts[15,113]=-2.37142998213040e-002;
    __statist_i_h_wts[15,114]=-3.31736372608070e-002;
    __statist_i_h_wts[15,115]=-5.22338453625029e-002;
    __statist_i_h_wts[15,116]=-6.65302916801924e-002;
    __statist_i_h_wts[15,117]=-8.25588170353609e-002;
    __statist_i_h_wts[15,118]=-6.11576737042178e-002;
    __statist_i_h_wts[15,119]=-6.56248580041474e-002;
    __statist_i_h_wts[15,120]=7.60638930497816e-002;
    __statist_i_h_wts[15,121]=6.98668521651370e-002;
    __statist_i_h_wts[15,122]=6.36593432300758e-002;
    __statist_i_h_wts[15,123]=6.91518163192481e-002;
    __statist_i_h_wts[15,124]=3.85592009060726e-002;
    __statist_i_h_wts[15,125]=1.71594506447578e-003;
    __statist_i_h_wts[15,126]=-5.52879387338899e-003;
    __statist_i_h_wts[15,127]=-1.72284968901689e-002;
    __statist_i_h_wts[15,128]=-2.17970295500217e-002;
    __statist_i_h_wts[15,129]=-1.38373621955013e-002;
    __statist_i_h_wts[15,130]=-2.88105119030481e-002;
    __statist_i_h_wts[15,131]=-2.74471684527880e-002;
    __statist_i_h_wts[15,132]=-5.24013948001444e-002;
    __statist_i_h_wts[15,133]=-3.43666592727309e-002;
    __statist_i_h_wts[15,134]=-3.92973857738456e-002;
    __statist_i_h_wts[15,135]=4.81516212071966e-002;
    __statist_i_h_wts[15,136]=5.70129805523660e-002;
    __statist_i_h_wts[15,137]=6.62095560417986e-002;
    __statist_i_h_wts[15,138]=5.03845557808525e-002;
    __statist_i_h_wts[15,139]=2.92118422173953e-002;
    __statist_i_h_wts[15,140]=1.55546251774259e-002;
    __statist_i_h_wts[15,141]=1.59537584696268e-002;
    __statist_i_h_wts[15,142]=-1.12314829325127e-002;
    __statist_i_h_wts[15,143]=-1.20941381775504e-002;
    __statist_i_h_wts[15,144]=-1.20012635219862e-002;
    __statist_i_h_wts[15,145]=-1.14844768161999e-002;
    __statist_i_h_wts[15,146]=-2.23638598096514e-002;
    __statist_i_h_wts[15,147]=-3.72136394441114e-002;
    __statist_i_h_wts[15,148]=-5.62931287219641e-002;
    __statist_i_h_wts[15,149]=-5.26796348958849e-002;
    __statist_i_h_wts[15,150]=3.30400854032570e-002;
    __statist_i_h_wts[15,151]=4.10997861136342e-002;
    __statist_i_h_wts[15,152]=5.52897795002147e-002;
    __statist_i_h_wts[15,153]=3.94649067876101e-002;
    __statist_i_h_wts[15,154]=2.89318246848340e-002;
    __statist_i_h_wts[15,155]=4.04655571966733e-002;
    __statist_i_h_wts[15,156]=2.54263855837790e-002;
    __statist_i_h_wts[15,157]=-7.00071044510492e-003;
    __statist_i_h_wts[15,158]=-1.60579176034682e-002;
    __statist_i_h_wts[15,159]=-1.01870749494119e-002;
    __statist_i_h_wts[15,160]=-2.45916310639178e-002;
    __statist_i_h_wts[15,161]=-3.50070564540371e-002;
    __statist_i_h_wts[15,162]=-4.86820811404961e-002;
    __statist_i_h_wts[15,163]=-5.95799764618150e-002;
    __statist_i_h_wts[15,164]=-6.46684795331061e-002;
    __statist_i_h_wts[15,165]=3.14634024848055e-002;
    __statist_i_h_wts[15,166]=5.32355115711606e-002;
    __statist_i_h_wts[15,167]=4.96803685770437e-002;
    __statist_i_h_wts[15,168]=4.42362139777845e-002;
    __statist_i_h_wts[15,169]=3.23759595676568e-002;
    __statist_i_h_wts[15,170]=1.60461470137758e-002;
    __statist_i_h_wts[15,171]=1.70707234782033e-002;
    __statist_i_h_wts[15,172]=-1.47630330060620e-002;
    __statist_i_h_wts[15,173]=-6.64828319748262e-003;
    __statist_i_h_wts[15,174]=-1.88068108564291e-003;
    __statist_i_h_wts[15,175]=-3.79178006800506e-002;
    __statist_i_h_wts[15,176]=-5.33148130149450e-002;
    __statist_i_h_wts[15,177]=-4.88881915239899e-002;
    __statist_i_h_wts[15,178]=-7.00270114767472e-002;
    __statist_i_h_wts[15,179]=-7.25829354735113e-002;
    __statist_i_h_wts[15,180]=3.15851439742313e-002;
    __statist_i_h_wts[15,181]=2.42784608623616e-002;
    __statist_i_h_wts[15,182]=4.50341488705855e-002;
    __statist_i_h_wts[15,183]=4.39256010479397e-002;
    __statist_i_h_wts[15,184]=4.94368624580671e-002;
    __statist_i_h_wts[15,185]=3.30458703838174e-002;
    __statist_i_h_wts[15,186]=1.96966953701342e-002;
    __statist_i_h_wts[15,187]=-2.11098666540483e-003;
    __statist_i_h_wts[15,188]=-8.23812179397557e-003;
    __statist_i_h_wts[15,189]=-2.27280452206232e-002;
    __statist_i_h_wts[15,190]=-4.25359244630860e-002;
    __statist_i_h_wts[15,191]=-5.14997188249602e-002;
    __statist_i_h_wts[15,192]=-4.44074111225193e-002;
    __statist_i_h_wts[15,193]=-3.69741177380583e-002;
    __statist_i_h_wts[15,194]=-3.04240358417973e-002;
    __statist_i_h_wts[15,195]=3.39958921088854e-002;
    __statist_i_h_wts[15,196]=2.60828860861489e-002;
    __statist_i_h_wts[15,197]=4.73130860221464e-002;
    __statist_i_h_wts[15,198]=3.55025585648607e-002;
    __statist_i_h_wts[15,199]=2.15465517599677e-002;
    __statist_i_h_wts[15,200]=1.08447695700359e-002;
    __statist_i_h_wts[15,201]=-1.56537014588122e-002;
    __statist_i_h_wts[15,202]=-1.09109734319270e-002;
    __statist_i_h_wts[15,203]=-2.87082868350875e-002;
    __statist_i_h_wts[15,204]=-3.11128871480319e-002;
    __statist_i_h_wts[15,205]=-3.25316596609035e-002;
    __statist_i_h_wts[15,206]=-5.91922262604546e-002;
    __statist_i_h_wts[15,207]=-3.31936961094920e-002;
    __statist_i_h_wts[15,208]=-2.99198135409507e-002;
    __statist_i_h_wts[15,209]=-3.41945811236338e-002;
    __statist_i_h_wts[15,210]=2.04712459810886e-002;
    __statist_i_h_wts[15,211]=2.82776399763319e-002;
    __statist_i_h_wts[15,212]=2.11875275279196e-002;
    __statist_i_h_wts[15,213]=2.72717663674677e-002;
    __statist_i_h_wts[15,214]=1.26402254337595e-002;
    __statist_i_h_wts[15,215]=1.41307363636183e-002;
    __statist_i_h_wts[15,216]=8.49722194507325e-003;
    __statist_i_h_wts[15,217]=-2.07476801806708e-002;
    __statist_i_h_wts[15,218]=-2.16424423112375e-002;
    __statist_i_h_wts[15,219]=-3.12894793774067e-002;
    __statist_i_h_wts[15,220]=-3.19306024340002e-002;
    __statist_i_h_wts[15,221]=-4.80160907433070e-002;
    __statist_i_h_wts[15,222]=-5.27289259360808e-003;
    __statist_i_h_wts[15,223]=-8.15800826901845e-003;
    __statist_i_h_wts[15,224]=-1.59258534672678e-002;
    __statist_i_h_wts[15,225]=3.52511640503875e-002;
    __statist_i_h_wts[15,226]=-5.79234813050174e-002;
    __statist_i_h_wts[15,227]=3.23974287252130e-002;
    __statist_i_h_wts[15,228]=-4.71637643734876e-002;
    __statist_i_h_wts[15,229]=2.09746158708576e-002;
    __statist_i_h_wts[15,230]=4.44077912048528e-002;
    __statist_i_h_wts[15,231]=-3.29871732633158e-002;
    __statist_i_h_wts[15,232]=6.10094476265357e-002;
    __statist_i_h_wts[15,233]=1.60886198649971e-003;
    __statist_i_h_wts[15,234]=-8.81565807234847e-003;
    __statist_i_h_wts[15,235]=2.35388586366276e-003;
    __statist_i_h_wts[15,236]=-1.26554706959188e-001;
    __statist_i_h_wts[15,237]=9.24700844384584e-002;
    __statist_i_h_wts[15,238]=6.45333610693012e-002;
    __statist_i_h_wts[15,239]=7.36414173919441e-002;
    __statist_i_h_wts[15,240]=-7.66057281934108e-002;
    __statist_i_h_wts[15,241]=5.89969947339981e-002;
    __statist_i_h_wts[15,242]=-3.14381672457724e-002;
    __statist_i_h_wts[15,243]=1.01083239297866e-001;
    __statist_i_h_wts[15,244]=2.40578510494840e-002;
    __statist_i_h_wts[15,245]=-1.18024217195643e-001;
    __statist_i_h_wts[15,246]=-5.64105872350749e-003;
    __statist_i_h_wts[15,247]=-9.54053428792181e-002;
    __statist_i_h_wts[15,248]=6.39113929203953e-002;

    __statist_i_h_wts[16,0]=3.07368450395417e-001;
    __statist_i_h_wts[16,1]=2.82269046852860e-001;
    __statist_i_h_wts[16,2]=2.47581780176585e-001;
    __statist_i_h_wts[16,3]=2.28561150405556e-001;
    __statist_i_h_wts[16,4]=1.87288281518003e-001;
    __statist_i_h_wts[16,5]=1.60861932757394e-001;
    __statist_i_h_wts[16,6]=1.31749322855404e-001;
    __statist_i_h_wts[16,7]=8.80903921934804e-002;
    __statist_i_h_wts[16,8]=3.81284671786522e-002;
    __statist_i_h_wts[16,9]=-3.13552723940166e-002;
    __statist_i_h_wts[16,10]=-2.20298813895648e-002;
    __statist_i_h_wts[16,11]=-4.81704820886459e-002;
    __statist_i_h_wts[16,12]=-3.66593064200411e-002;
    __statist_i_h_wts[16,13]=-8.17710174430709e-002;
    __statist_i_h_wts[16,14]=-8.14085066135039e-002;
    __statist_i_h_wts[16,15]=3.36765468091869e-001;
    __statist_i_h_wts[16,16]=3.09214690146881e-001;
    __statist_i_h_wts[16,17]=3.07678929629793e-001;
    __statist_i_h_wts[16,18]=2.74163351907323e-001;
    __statist_i_h_wts[16,19]=2.33905057348549e-001;
    __statist_i_h_wts[16,20]=2.13339620084624e-001;
    __statist_i_h_wts[16,21]=1.56888476248249e-001;
    __statist_i_h_wts[16,22]=9.67410403770430e-002;
    __statist_i_h_wts[16,23]=4.83980178832394e-002;
    __statist_i_h_wts[16,24]=-2.49942795119969e-002;
    __statist_i_h_wts[16,25]=-6.97042165050885e-002;
    __statist_i_h_wts[16,26]=-1.16449080831722e-001;
    __statist_i_h_wts[16,27]=-1.21754814102598e-001;
    __statist_i_h_wts[16,28]=-1.03363268981518e-001;
    __statist_i_h_wts[16,29]=-1.16001156910321e-001;
    __statist_i_h_wts[16,30]=3.19228814255186e-001;
    __statist_i_h_wts[16,31]=3.14334648388226e-001;
    __statist_i_h_wts[16,32]=2.82326192045637e-001;
    __statist_i_h_wts[16,33]=2.40406393219934e-001;
    __statist_i_h_wts[16,34]=2.00159142652337e-001;
    __statist_i_h_wts[16,35]=1.56782600622424e-001;
    __statist_i_h_wts[16,36]=9.47897731176939e-002;
    __statist_i_h_wts[16,37]=4.25163847381910e-002;
    __statist_i_h_wts[16,38]=-1.21275028558655e-002;
    __statist_i_h_wts[16,39]=-9.39356094450239e-002;
    __statist_i_h_wts[16,40]=-1.17468732955252e-001;
    __statist_i_h_wts[16,41]=-1.39601249354441e-001;
    __statist_i_h_wts[16,42]=-1.50938634724625e-001;
    __statist_i_h_wts[16,43]=-1.36973176816496e-001;
    __statist_i_h_wts[16,44]=-1.32803129611301e-001;
    __statist_i_h_wts[16,45]=2.81996932607841e-001;
    __statist_i_h_wts[16,46]=2.42671594836051e-001;
    __statist_i_h_wts[16,47]=2.52786201419391e-001;
    __statist_i_h_wts[16,48]=2.04991039039450e-001;
    __statist_i_h_wts[16,49]=1.70792637945950e-001;
    __statist_i_h_wts[16,50]=9.85868751840371e-002;
    __statist_i_h_wts[16,51]=2.69409747385444e-002;
    __statist_i_h_wts[16,52]=-5.11381297942383e-002;
    __statist_i_h_wts[16,53]=-9.77178362828025e-002;
    __statist_i_h_wts[16,54]=-1.72224462898291e-001;
    __statist_i_h_wts[16,55]=-1.92578062641775e-001;
    __statist_i_h_wts[16,56]=-1.88913511028730e-001;
    __statist_i_h_wts[16,57]=-1.93562316573405e-001;
    __statist_i_h_wts[16,58]=-2.14690724076794e-001;
    __statist_i_h_wts[16,59]=-1.86222457186951e-001;
    __statist_i_h_wts[16,60]=2.77783276165557e-001;
    __statist_i_h_wts[16,61]=2.58229336573442e-001;
    __statist_i_h_wts[16,62]=2.39543815324445e-001;
    __statist_i_h_wts[16,63]=2.10799044764758e-001;
    __statist_i_h_wts[16,64]=1.61653271610966e-001;
    __statist_i_h_wts[16,65]=1.21055265755978e-001;
    __statist_i_h_wts[16,66]=1.80001640736563e-002;
    __statist_i_h_wts[16,67]=-6.77370792829328e-002;
    __statist_i_h_wts[16,68]=-1.14675292241806e-001;
    __statist_i_h_wts[16,69]=-1.83351163158160e-001;
    __statist_i_h_wts[16,70]=-2.12755787270313e-001;
    __statist_i_h_wts[16,71]=-2.36193227352521e-001;
    __statist_i_h_wts[16,72]=-2.51555423083399e-001;
    __statist_i_h_wts[16,73]=-2.47534541975267e-001;
    __statist_i_h_wts[16,74]=-2.34552058140366e-001;
    __statist_i_h_wts[16,75]=2.52326367742815e-001;
    __statist_i_h_wts[16,76]=2.32721600289173e-001;
    __statist_i_h_wts[16,77]=2.38785186809009e-001;
    __statist_i_h_wts[16,78]=2.00528233323493e-001;
    __statist_i_h_wts[16,79]=1.61852260964960e-001;
    __statist_i_h_wts[16,80]=6.83612914672054e-002;
    __statist_i_h_wts[16,81]=-3.98830328720389e-003;
    __statist_i_h_wts[16,82]=-7.39680692580011e-002;
    __statist_i_h_wts[16,83]=-1.29744738099095e-001;
    __statist_i_h_wts[16,84]=-2.06770821553219e-001;
    __statist_i_h_wts[16,85]=-2.33347177965714e-001;
    __statist_i_h_wts[16,86]=-2.38308129895586e-001;
    __statist_i_h_wts[16,87]=-2.40151228905179e-001;
    __statist_i_h_wts[16,88]=-2.46702287880492e-001;
    __statist_i_h_wts[16,89]=-2.43034535344416e-001;
    __statist_i_h_wts[16,90]=2.59376415413418e-001;
    __statist_i_h_wts[16,91]=2.03191230291347e-001;
    __statist_i_h_wts[16,92]=2.07417750253757e-001;
    __statist_i_h_wts[16,93]=1.66792347165109e-001;
    __statist_i_h_wts[16,94]=1.30171942894114e-001;
    __statist_i_h_wts[16,95]=5.17259323791642e-002;
    __statist_i_h_wts[16,96]=-1.60258049535528e-002;
    __statist_i_h_wts[16,97]=-8.58897330442886e-002;
    __statist_i_h_wts[16,98]=-1.61277914885284e-001;
    __statist_i_h_wts[16,99]=-2.40821212315082e-001;
    __statist_i_h_wts[16,100]=-2.67260827558677e-001;
    __statist_i_h_wts[16,101]=-2.53931953471038e-001;
    __statist_i_h_wts[16,102]=-2.35452407932458e-001;
    __statist_i_h_wts[16,103]=-2.64590001888142e-001;
    __statist_i_h_wts[16,104]=-2.41106341302715e-001;
    __statist_i_h_wts[16,105]=2.64318903602858e-001;
    __statist_i_h_wts[16,106]=2.25780513875662e-001;
    __statist_i_h_wts[16,107]=2.07640202594294e-001;
    __statist_i_h_wts[16,108]=1.74253719816726e-001;
    __statist_i_h_wts[16,109]=1.28038453200018e-001;
    __statist_i_h_wts[16,110]=2.79909122505994e-002;
    __statist_i_h_wts[16,111]=-5.17981902549444e-002;
    __statist_i_h_wts[16,112]=-9.93313249417868e-002;
    __statist_i_h_wts[16,113]=-1.81663823420898e-001;
    __statist_i_h_wts[16,114]=-2.35967265477729e-001;
    __statist_i_h_wts[16,115]=-2.51089805156407e-001;
    __statist_i_h_wts[16,116]=-2.75726742529320e-001;
    __statist_i_h_wts[16,117]=-2.40508662929256e-001;
    __statist_i_h_wts[16,118]=-2.28519683438750e-001;
    __statist_i_h_wts[16,119]=-2.38697637813427e-001;
    __statist_i_h_wts[16,120]=2.38306433897711e-001;
    __statist_i_h_wts[16,121]=2.36966704138666e-001;
    __statist_i_h_wts[16,122]=2.13741680394959e-001;
    __statist_i_h_wts[16,123]=1.67288438174020e-001;
    __statist_i_h_wts[16,124]=1.10235853090376e-001;
    __statist_i_h_wts[16,125]=3.63189386716191e-002;
    __statist_i_h_wts[16,126]=-3.07080343012608e-002;
    __statist_i_h_wts[16,127]=-7.30065976359557e-002;
    __statist_i_h_wts[16,128]=-9.82006265103904e-002;
    __statist_i_h_wts[16,129]=-1.54076090469988e-001;
    __statist_i_h_wts[16,130]=-2.37958468249957e-001;
    __statist_i_h_wts[16,131]=-2.47704915676856e-001;
    __statist_i_h_wts[16,132]=-2.51710222140729e-001;
    __statist_i_h_wts[16,133]=-2.73958957940071e-001;
    __statist_i_h_wts[16,134]=-2.59481661902963e-001;
    __statist_i_h_wts[16,135]=1.96358703375111e-001;
    __statist_i_h_wts[16,136]=2.07478291432010e-001;
    __statist_i_h_wts[16,137]=2.16249501118398e-001;
    __statist_i_h_wts[16,138]=1.57538932062610e-001;
    __statist_i_h_wts[16,139]=1.22979104726987e-001;
    __statist_i_h_wts[16,140]=5.43683384119419e-002;
    __statist_i_h_wts[16,141]=-4.19748767348524e-003;
    __statist_i_h_wts[16,142]=-4.84975734292730e-002;
    __statist_i_h_wts[16,143]=-5.46173033499965e-002;
    __statist_i_h_wts[16,144]=-9.55738935177039e-002;
    __statist_i_h_wts[16,145]=-1.79211682752431e-001;
    __statist_i_h_wts[16,146]=-2.33730238432796e-001;
    __statist_i_h_wts[16,147]=-2.46189553248167e-001;
    __statist_i_h_wts[16,148]=-2.60074673362754e-001;
    __statist_i_h_wts[16,149]=-2.33890666979302e-001;
    __statist_i_h_wts[16,150]=2.00412111682646e-001;
    __statist_i_h_wts[16,151]=2.09372708806453e-001;
    __statist_i_h_wts[16,152]=1.87246493853094e-001;
    __statist_i_h_wts[16,153]=1.68776709375588e-001;
    __statist_i_h_wts[16,154]=1.03572357294922e-001;
    __statist_i_h_wts[16,155]=4.46269671102213e-002;
    __statist_i_h_wts[16,156]=-7.10134759116619e-003;
    __statist_i_h_wts[16,157]=-5.32327687424611e-002;
    __statist_i_h_wts[16,158]=-5.52102987812048e-002;
    __statist_i_h_wts[16,159]=-8.34043317632454e-002;
    __statist_i_h_wts[16,160]=-1.14983950385306e-001;
    __statist_i_h_wts[16,161]=-1.95531348059701e-001;
    __statist_i_h_wts[16,162]=-2.06085672548949e-001;
    __statist_i_h_wts[16,163]=-2.10654396548031e-001;
    __statist_i_h_wts[16,164]=-1.97624787456186e-001;
    __statist_i_h_wts[16,165]=1.72773051095834e-001;
    __statist_i_h_wts[16,166]=1.70603922630153e-001;
    __statist_i_h_wts[16,167]=1.69345889503154e-001;
    __statist_i_h_wts[16,168]=1.61067384398392e-001;
    __statist_i_h_wts[16,169]=1.05147833192121e-001;
    __statist_i_h_wts[16,170]=5.73382859322041e-002;
    __statist_i_h_wts[16,171]=2.27205990567365e-002;
    __statist_i_h_wts[16,172]=-7.79251018192962e-003;
    __statist_i_h_wts[16,173]=-4.72059339687033e-002;
    __statist_i_h_wts[16,174]=-8.77594793261097e-002;
    __statist_i_h_wts[16,175]=-9.70020792470312e-002;
    __statist_i_h_wts[16,176]=-1.68789466065580e-001;
    __statist_i_h_wts[16,177]=-1.86669311853278e-001;
    __statist_i_h_wts[16,178]=-1.95867869826382e-001;
    __statist_i_h_wts[16,179]=-1.95808234171430e-001;
    __statist_i_h_wts[16,180]=1.63524066051507e-001;
    __statist_i_h_wts[16,181]=1.62317196019291e-001;
    __statist_i_h_wts[16,182]=1.32987408938266e-001;
    __statist_i_h_wts[16,183]=1.37417041899722e-001;
    __statist_i_h_wts[16,184]=1.25954515010024e-001;
    __statist_i_h_wts[16,185]=8.04891122316103e-002;
    __statist_i_h_wts[16,186]=4.17027121368024e-002;
    __statist_i_h_wts[16,187]=8.01108897534659e-003;
    __statist_i_h_wts[16,188]=-3.04889515558767e-002;
    __statist_i_h_wts[16,189]=-5.67414769617833e-002;
    __statist_i_h_wts[16,190]=-7.74386190938315e-002;
    __statist_i_h_wts[16,191]=-1.40035850314225e-001;
    __statist_i_h_wts[16,192]=-1.78597049535636e-001;
    __statist_i_h_wts[16,193]=-1.81749393735095e-001;
    __statist_i_h_wts[16,194]=-1.87661347228729e-001;
    __statist_i_h_wts[16,195]=1.32163566698239e-001;
    __statist_i_h_wts[16,196]=1.27790462942625e-001;
    __statist_i_h_wts[16,197]=1.33374653898457e-001;
    __statist_i_h_wts[16,198]=1.10590132401998e-001;
    __statist_i_h_wts[16,199]=9.22229900571128e-002;
    __statist_i_h_wts[16,200]=7.18177518838497e-002;
    __statist_i_h_wts[16,201]=2.87005649207496e-002;
    __statist_i_h_wts[16,202]=1.67464270181611e-002;
    __statist_i_h_wts[16,203]=-2.45005507167889e-002;
    __statist_i_h_wts[16,204]=-2.67295773166049e-002;
    __statist_i_h_wts[16,205]=-4.68466433344648e-002;
    __statist_i_h_wts[16,206]=-1.08706511952966e-001;
    __statist_i_h_wts[16,207]=-1.29462805212267e-001;
    __statist_i_h_wts[16,208]=-1.57945385055346e-001;
    __statist_i_h_wts[16,209]=-1.46634417033253e-001;
    __statist_i_h_wts[16,210]=9.84464757229697e-002;
    __statist_i_h_wts[16,211]=1.04850399486560e-001;
    __statist_i_h_wts[16,212]=1.23286280454424e-001;
    __statist_i_h_wts[16,213]=1.03358488149163e-001;
    __statist_i_h_wts[16,214]=8.39727826022186e-002;
    __statist_i_h_wts[16,215]=7.51679653357839e-002;
    __statist_i_h_wts[16,216]=4.27794743002881e-002;
    __statist_i_h_wts[16,217]=2.15157229490517e-002;
    __statist_i_h_wts[16,218]=-6.30529929941055e-003;
    __statist_i_h_wts[16,219]=-2.96458013250019e-002;
    __statist_i_h_wts[16,220]=-5.32116075408894e-002;
    __statist_i_h_wts[16,221]=-8.59924556985587e-002;
    __statist_i_h_wts[16,222]=-1.13040856451223e-001;
    __statist_i_h_wts[16,223]=-1.39583745722820e-001;
    __statist_i_h_wts[16,224]=-1.06114835273371e-001;
    __statist_i_h_wts[16,225]=7.16750334494244e-002;
    __statist_i_h_wts[16,226]=-2.42199484024505e-001;
    __statist_i_h_wts[16,227]=2.69527396912806e-002;
    __statist_i_h_wts[16,228]=-2.77416429786092e-001;
    __statist_i_h_wts[16,229]=7.80122868338811e-003;
    __statist_i_h_wts[16,230]=4.53099515782836e-001;
    __statist_i_h_wts[16,231]=1.51375452507478e-001;
    __statist_i_h_wts[16,232]=5.13176441581495e-001;
    __statist_i_h_wts[16,233]=1.95802356691493e-001;
    __statist_i_h_wts[16,234]=5.96529509583792e-001;
    __statist_i_h_wts[16,235]=2.13911700019223e-003;
    __statist_i_h_wts[16,236]=-3.46669740102399e-001;
    __statist_i_h_wts[16,237]=-9.02417866486982e-001;
    __statist_i_h_wts[16,238]=-2.76748116836717e-001;
    __statist_i_h_wts[16,239]=4.22080345072855e-001;
    __statist_i_h_wts[16,240]=-6.33801244848171e-002;
    __statist_i_h_wts[16,241]=6.28220128022718e-001;
    __statist_i_h_wts[16,242]=-5.81780908177924e-002;
    __statist_i_h_wts[16,243]=3.49100735255875e-001;
    __statist_i_h_wts[16,244]=3.79614432395638e-002;
    __statist_i_h_wts[16,245]=-4.58264171401398e-001;
    __statist_i_h_wts[16,246]=5.20778645495190e-002;
    __statist_i_h_wts[16,247]=-4.54182443363164e-001;
    __statist_i_h_wts[16,248]=-8.49700670358340e-002;

    __statist_i_h_wts[17,0]=-2.65278749367276e-001;
    __statist_i_h_wts[17,1]=-2.37485091964413e-001;
    __statist_i_h_wts[17,2]=-1.46646552420265e-001;
    __statist_i_h_wts[17,3]=-1.11886105749669e-001;
    __statist_i_h_wts[17,4]=-5.42287601547545e-002;
    __statist_i_h_wts[17,5]=-4.52078718312023e-002;
    __statist_i_h_wts[17,6]=-1.86880511333282e-002;
    __statist_i_h_wts[17,7]=8.16761885104583e-004;
    __statist_i_h_wts[17,8]=6.36353762839532e-002;
    __statist_i_h_wts[17,9]=1.31141379696462e-001;
    __statist_i_h_wts[17,10]=1.49954281814358e-001;
    __statist_i_h_wts[17,11]=1.20262008998419e-001;
    __statist_i_h_wts[17,12]=6.60814368810489e-002;
    __statist_i_h_wts[17,13]=1.55056228216312e-001;
    __statist_i_h_wts[17,14]=2.03903228701887e-001;
    __statist_i_h_wts[17,15]=-2.96788544154521e-001;
    __statist_i_h_wts[17,16]=-2.59989228515482e-001;
    __statist_i_h_wts[17,17]=-2.07021150051324e-001;
    __statist_i_h_wts[17,18]=-1.62139887249557e-001;
    __statist_i_h_wts[17,19]=-1.21134311968721e-001;
    __statist_i_h_wts[17,20]=-1.37025514367453e-001;
    __statist_i_h_wts[17,21]=-7.20635352719508e-002;
    __statist_i_h_wts[17,22]=-1.64058184988420e-002;
    __statist_i_h_wts[17,23]=2.01400478423197e-002;
    __statist_i_h_wts[17,24]=1.00256806491148e-001;
    __statist_i_h_wts[17,25]=1.88866726972798e-001;
    __statist_i_h_wts[17,26]=2.27901817662931e-001;
    __statist_i_h_wts[17,27]=2.03406407158326e-001;
    __statist_i_h_wts[17,28]=1.98388789521047e-001;
    __statist_i_h_wts[17,29]=2.39249816970178e-001;
    __statist_i_h_wts[17,30]=-2.25770816756692e-001;
    __statist_i_h_wts[17,31]=-1.59485713951870e-001;
    __statist_i_h_wts[17,32]=-1.57094003601831e-001;
    __statist_i_h_wts[17,33]=-4.98568161585872e-002;
    __statist_i_h_wts[17,34]=-4.10453182503270e-002;
    __statist_i_h_wts[17,35]=-3.19647959911160e-002;
    __statist_i_h_wts[17,36]=3.48203487899907e-002;
    __statist_i_h_wts[17,37]=8.31461072503124e-002;
    __statist_i_h_wts[17,38]=1.07693692470127e-001;
    __statist_i_h_wts[17,39]=2.15818619229036e-001;
    __statist_i_h_wts[17,40]=2.24516771337842e-001;
    __statist_i_h_wts[17,41]=2.40617541292836e-001;
    __statist_i_h_wts[17,42]=2.59744277003206e-001;
    __statist_i_h_wts[17,43]=2.05455224521088e-001;
    __statist_i_h_wts[17,44]=2.35274431633989e-001;
    __statist_i_h_wts[17,45]=-1.64515269980000e-001;
    __statist_i_h_wts[17,46]=-8.41558628512920e-002;
    __statist_i_h_wts[17,47]=-1.63613960420514e-001;
    __statist_i_h_wts[17,48]=-8.93337283261207e-002;
    __statist_i_h_wts[17,49]=-1.08285518620147e-001;
    __statist_i_h_wts[17,50]=-1.61760040751719e-003;
    __statist_i_h_wts[17,51]=3.22558593075190e-002;
    __statist_i_h_wts[17,52]=1.29780932608188e-001;
    __statist_i_h_wts[17,53]=1.37624087438356e-001;
    __statist_i_h_wts[17,54]=2.44665014075057e-001;
    __statist_i_h_wts[17,55]=2.43943994797721e-001;
    __statist_i_h_wts[17,56]=3.23846758089877e-001;
    __statist_i_h_wts[17,57]=2.64923485248022e-001;
    __statist_i_h_wts[17,58]=2.81206122764316e-001;
    __statist_i_h_wts[17,59]=2.57367496699428e-001;
    __statist_i_h_wts[17,60]=-2.01395570569119e-001;
    __statist_i_h_wts[17,61]=-1.47026285198464e-001;
    __statist_i_h_wts[17,62]=-1.78083258552178e-001;
    __statist_i_h_wts[17,63]=-1.22943954341778e-001;
    __statist_i_h_wts[17,64]=-1.03197203330319e-001;
    __statist_i_h_wts[17,65]=-3.81162134388285e-002;
    __statist_i_h_wts[17,66]=4.24044484379377e-002;
    __statist_i_h_wts[17,67]=1.10191213711939e-001;
    __statist_i_h_wts[17,68]=1.15124813760784e-001;
    __statist_i_h_wts[17,69]=2.36062285889046e-001;
    __statist_i_h_wts[17,70]=2.31093632810968e-001;
    __statist_i_h_wts[17,71]=3.04794945616549e-001;
    __statist_i_h_wts[17,72]=2.98329056590004e-001;
    __statist_i_h_wts[17,73]=3.27841617809977e-001;
    __statist_i_h_wts[17,74]=3.07137021706705e-001;
    __statist_i_h_wts[17,75]=-1.42325438778413e-001;
    __statist_i_h_wts[17,76]=-8.42025279189527e-002;
    __statist_i_h_wts[17,77]=-1.59227704215617e-001;
    __statist_i_h_wts[17,78]=-1.72620487258675e-001;
    __statist_i_h_wts[17,79]=-1.27273942703980e-001;
    __statist_i_h_wts[17,80]=-1.03825433608645e-002;
    __statist_i_h_wts[17,81]=4.84920836925249e-002;
    __statist_i_h_wts[17,82]=7.30071610658122e-002;
    __statist_i_h_wts[17,83]=1.14024578185937e-001;
    __statist_i_h_wts[17,84]=2.02243367759067e-001;
    __statist_i_h_wts[17,85]=2.02950431515873e-001;
    __statist_i_h_wts[17,86]=2.50181325352320e-001;
    __statist_i_h_wts[17,87]=2.72414569416000e-001;
    __statist_i_h_wts[17,88]=2.83099463352749e-001;
    __statist_i_h_wts[17,89]=3.14906954111687e-001;
    __statist_i_h_wts[17,90]=-2.24083157880645e-001;
    __statist_i_h_wts[17,91]=-1.21817700708798e-001;
    __statist_i_h_wts[17,92]=-1.56748246451626e-001;
    __statist_i_h_wts[17,93]=-1.35408469227072e-001;
    __statist_i_h_wts[17,94]=-1.21816870897657e-001;
    __statist_i_h_wts[17,95]=-3.76004659789261e-002;
    __statist_i_h_wts[17,96]=2.43943284848810e-002;
    __statist_i_h_wts[17,97]=8.63122995045546e-002;
    __statist_i_h_wts[17,98]=1.02663291508751e-001;
    __statist_i_h_wts[17,99]=2.28146086353918e-001;
    __statist_i_h_wts[17,100]=2.44871623694791e-001;
    __statist_i_h_wts[17,101]=2.44008412440426e-001;
    __statist_i_h_wts[17,102]=2.47977678036546e-001;
    __statist_i_h_wts[17,103]=2.73779293089369e-001;
    __statist_i_h_wts[17,104]=2.64431520652698e-001;
    __statist_i_h_wts[17,105]=-2.25210380403098e-001;
    __statist_i_h_wts[17,106]=-1.46207484258708e-001;
    __statist_i_h_wts[17,107]=-1.49311194829204e-001;
    __statist_i_h_wts[17,108]=-1.00205906651372e-001;
    __statist_i_h_wts[17,109]=-5.95746761584905e-002;
    __statist_i_h_wts[17,110]=3.12294368069219e-002;
    __statist_i_h_wts[17,111]=8.28253119353205e-002;
    __statist_i_h_wts[17,112]=1.19104289730255e-001;
    __statist_i_h_wts[17,113]=1.47588488941738e-001;
    __statist_i_h_wts[17,114]=2.22286400347702e-001;
    __statist_i_h_wts[17,115]=2.08410114045267e-001;
    __statist_i_h_wts[17,116]=2.32049320551800e-001;
    __statist_i_h_wts[17,117]=2.23917471494473e-001;
    __statist_i_h_wts[17,118]=2.34414471483796e-001;
    __statist_i_h_wts[17,119]=2.74315067127256e-001;
    __statist_i_h_wts[17,120]=-1.65951314399542e-001;
    __statist_i_h_wts[17,121]=-1.49133837982478e-001;
    __statist_i_h_wts[17,122]=-1.31209216835864e-001;
    __statist_i_h_wts[17,123]=-8.33387665502576e-002;
    __statist_i_h_wts[17,124]=-5.55822936426620e-002;
    __statist_i_h_wts[17,125]=-8.77055260771487e-003;
    __statist_i_h_wts[17,126]=3.72186044780965e-002;
    __statist_i_h_wts[17,127]=3.79401519921206e-002;
    __statist_i_h_wts[17,128]=2.66284124361802e-002;
    __statist_i_h_wts[17,129]=1.47836817886129e-001;
    __statist_i_h_wts[17,130]=2.24920694070076e-001;
    __statist_i_h_wts[17,131]=2.50149838127653e-001;
    __statist_i_h_wts[17,132]=2.73772262466217e-001;
    __statist_i_h_wts[17,133]=3.08307960119543e-001;
    __statist_i_h_wts[17,134]=2.96182302758682e-001;
    __statist_i_h_wts[17,135]=-1.49677942212154e-001;
    __statist_i_h_wts[17,136]=-1.27973385344766e-001;
    __statist_i_h_wts[17,137]=-1.34373562692739e-001;
    __statist_i_h_wts[17,138]=-1.11301701742302e-001;
    __statist_i_h_wts[17,139]=-9.76849949995949e-002;
    __statist_i_h_wts[17,140]=-7.68227575612031e-004;
    __statist_i_h_wts[17,141]=3.28127683711555e-002;
    __statist_i_h_wts[17,142]=-6.14651237256088e-003;
    __statist_i_h_wts[17,143]=-6.23693155901856e-002;
    __statist_i_h_wts[17,144]=3.70628286600033e-002;
    __statist_i_h_wts[17,145]=1.51576961118078e-001;
    __statist_i_h_wts[17,146]=2.10881865828336e-001;
    __statist_i_h_wts[17,147]=2.17793197078192e-001;
    __statist_i_h_wts[17,148]=2.21141687074184e-001;
    __statist_i_h_wts[17,149]=2.39835805785183e-001;
    __statist_i_h_wts[17,150]=-1.74390554388208e-001;
    __statist_i_h_wts[17,151]=-1.62765850736204e-001;
    __statist_i_h_wts[17,152]=-1.05691365951257e-001;
    __statist_i_h_wts[17,153]=-1.30690582593156e-001;
    __statist_i_h_wts[17,154]=-5.87101514810012e-002;
    __statist_i_h_wts[17,155]=5.56404092599407e-003;
    __statist_i_h_wts[17,156]=1.20027790285219e-002;
    __statist_i_h_wts[17,157]=-6.81092262467881e-004;
    __statist_i_h_wts[17,158]=-2.66548418358789e-002;
    __statist_i_h_wts[17,159]=-3.83886571553481e-003;
    __statist_i_h_wts[17,160]=4.60369977655846e-002;
    __statist_i_h_wts[17,161]=1.17469021677360e-001;
    __statist_i_h_wts[17,162]=1.45686344324960e-001;
    __statist_i_h_wts[17,163]=1.47725334907670e-001;
    __statist_i_h_wts[17,164]=1.84847027388289e-001;
    __statist_i_h_wts[17,165]=-1.20447977655076e-001;
    __statist_i_h_wts[17,166]=-9.22077464451988e-002;
    __statist_i_h_wts[17,167]=-9.66735274480414e-002;
    __statist_i_h_wts[17,168]=-9.39758870019469e-002;
    __statist_i_h_wts[17,169]=-6.73889869053164e-002;
    __statist_i_h_wts[17,170]=-2.86097583576813e-002;
    __statist_i_h_wts[17,171]=9.36593495268468e-003;
    __statist_i_h_wts[17,172]=-7.91034840092492e-003;
    __statist_i_h_wts[17,173]=-4.21740228765681e-003;
    __statist_i_h_wts[17,174]=2.47001314225469e-002;
    __statist_i_h_wts[17,175]=3.09605246438366e-002;
    __statist_i_h_wts[17,176]=1.00663443427498e-001;
    __statist_i_h_wts[17,177]=1.18205060358371e-001;
    __statist_i_h_wts[17,178]=1.21000600974221e-001;
    __statist_i_h_wts[17,179]=1.75928766035077e-001;
    __statist_i_h_wts[17,180]=-1.19262747811181e-001;
    __statist_i_h_wts[17,181]=-1.02771116171635e-001;
    __statist_i_h_wts[17,182]=-8.86209835489417e-002;
    __statist_i_h_wts[17,183]=-7.75294624900233e-002;
    __statist_i_h_wts[17,184]=-5.14875748796663e-002;
    __statist_i_h_wts[17,185]=-1.14337406971308e-002;
    __statist_i_h_wts[17,186]=2.98442632067972e-003;
    __statist_i_h_wts[17,187]=-2.24516985443574e-002;
    __statist_i_h_wts[17,188]=-3.82259155001809e-002;
    __statist_i_h_wts[17,189]=-4.10110850233219e-002;
    __statist_i_h_wts[17,190]=-2.06502293683333e-002;
    __statist_i_h_wts[17,191]=7.60007557659500e-002;
    __statist_i_h_wts[17,192]=1.29290923041628e-001;
    __statist_i_h_wts[17,193]=1.82594146733382e-001;
    __statist_i_h_wts[17,194]=2.44606981557408e-001;
    __statist_i_h_wts[17,195]=-1.11126926544172e-001;
    __statist_i_h_wts[17,196]=-9.26349222053816e-002;
    __statist_i_h_wts[17,197]=-6.78944048184063e-002;
    __statist_i_h_wts[17,198]=-1.08833983541636e-001;
    __statist_i_h_wts[17,199]=-6.67245701174602e-002;
    __statist_i_h_wts[17,200]=-3.65046710881028e-002;
    __statist_i_h_wts[17,201]=-3.10482777536106e-002;
    __statist_i_h_wts[17,202]=-4.09682609272948e-002;
    __statist_i_h_wts[17,203]=-1.62318581218697e-002;
    __statist_i_h_wts[17,204]=-1.47508359186634e-002;
    __statist_i_h_wts[17,205]=1.41986060468375e-002;
    __statist_i_h_wts[17,206]=9.79329443419724e-002;
    __statist_i_h_wts[17,207]=1.68132815675630e-001;
    __statist_i_h_wts[17,208]=2.12810201150379e-001;
    __statist_i_h_wts[17,209]=2.06169417914123e-001;
    __statist_i_h_wts[17,210]=-7.73717146091042e-002;
    __statist_i_h_wts[17,211]=-8.75063903834474e-002;
    __statist_i_h_wts[17,212]=-9.82440380266463e-002;
    __statist_i_h_wts[17,213]=-8.26479359602421e-002;
    __statist_i_h_wts[17,214]=-7.07878078217970e-002;
    __statist_i_h_wts[17,215]=-4.00262066554225e-002;
    __statist_i_h_wts[17,216]=-2.93737871790588e-002;
    __statist_i_h_wts[17,217]=-4.48898483342822e-002;
    __statist_i_h_wts[17,218]=-2.11733121023443e-002;
    __statist_i_h_wts[17,219]=1.51241214170898e-002;
    __statist_i_h_wts[17,220]=3.52391494912211e-002;
    __statist_i_h_wts[17,221]=1.01653195556263e-001;
    __statist_i_h_wts[17,222]=1.59909139832861e-001;
    __statist_i_h_wts[17,223]=2.10845241677709e-001;
    __statist_i_h_wts[17,224]=2.00426585475447e-001;
    __statist_i_h_wts[17,225]=-2.03221593295455e-003;
    __statist_i_h_wts[17,226]=3.84403999393854e-001;
    __statist_i_h_wts[17,227]=1.04596569584493e-001;
    __statist_i_h_wts[17,228]=4.71370768841936e-001;
    __statist_i_h_wts[17,229]=4.57036183341698e-002;
    __statist_i_h_wts[17,230]=-6.24510487499685e-001;
    __statist_i_h_wts[17,231]=-2.60310002676439e-001;
    __statist_i_h_wts[17,232]=-7.26923062009142e-001;
    __statist_i_h_wts[17,233]=-3.06378134357085e-001;
    __statist_i_h_wts[17,234]=-1.03533582561612e+000;
    __statist_i_h_wts[17,235]=9.68512375805974e-006;
    __statist_i_h_wts[17,236]=3.99543571631372e-001;
    __statist_i_h_wts[17,237]=1.66180990966526e+000;
    __statist_i_h_wts[17,238]=4.99810895509684e-001;
    __statist_i_h_wts[17,239]=-5.80233267151964e-001;
    __statist_i_h_wts[17,240]=3.83381772783210e-003;
    __statist_i_h_wts[17,241]=-9.65509103620105e-001;
    __statist_i_h_wts[17,242]=6.47979328452257e-002;
    __statist_i_h_wts[17,243]=-4.36307941279662e-001;
    __statist_i_h_wts[17,244]=-4.22921122535556e-002;
    __statist_i_h_wts[17,245]=6.15749362007053e-001;
    __statist_i_h_wts[17,246]=-8.05729775258621e-002;
    __statist_i_h_wts[17,247]=6.33571934253790e-001;
    __statist_i_h_wts[17,248]=1.94060045185238e-001;

    __statist_i_h_wts[18,0]=-2.00962515465696e-001;
    __statist_i_h_wts[18,1]=-1.48208491907072e-001;
    __statist_i_h_wts[18,2]=-1.12022460077924e-001;
    __statist_i_h_wts[18,3]=-1.35732838785457e-001;
    __statist_i_h_wts[18,4]=-7.77769090219098e-002;
    __statist_i_h_wts[18,5]=-1.30994321580410e-002;
    __statist_i_h_wts[18,6]=9.12889975666687e-003;
    __statist_i_h_wts[18,7]=-1.41408038649956e-002;
    __statist_i_h_wts[18,8]=-3.80029664382513e-002;
    __statist_i_h_wts[18,9]=-5.08363239865284e-003;
    __statist_i_h_wts[18,10]=-7.44382905324277e-002;
    __statist_i_h_wts[18,11]=1.02725011666356e-002;
    __statist_i_h_wts[18,12]=-5.05455272323126e-002;
    __statist_i_h_wts[18,13]=8.62142181664437e-002;
    __statist_i_h_wts[18,14]=9.55940271908872e-002;
    __statist_i_h_wts[18,15]=-1.38472431757647e-001;
    __statist_i_h_wts[18,16]=-1.13035333301513e-001;
    __statist_i_h_wts[18,17]=-1.34143771625464e-001;
    __statist_i_h_wts[18,18]=-2.37672741158707e-001;
    __statist_i_h_wts[18,19]=-1.52287084031926e-001;
    __statist_i_h_wts[18,20]=-9.70598636043608e-002;
    __statist_i_h_wts[18,21]=-7.30800195485822e-002;
    __statist_i_h_wts[18,22]=2.41241158153253e-002;
    __statist_i_h_wts[18,23]=-1.48411843100981e-002;
    __statist_i_h_wts[18,24]=6.11947309722864e-003;
    __statist_i_h_wts[18,25]=-5.24624074944942e-002;
    __statist_i_h_wts[18,26]=1.17497380541516e-001;
    __statist_i_h_wts[18,27]=6.63042067428452e-002;
    __statist_i_h_wts[18,28]=1.29477800277049e-001;
    __statist_i_h_wts[18,29]=1.18416292234417e-001;
    __statist_i_h_wts[18,30]=-2.55260444782377e-002;
    __statist_i_h_wts[18,31]=-7.89367919165853e-002;
    __statist_i_h_wts[18,32]=-1.80873644623641e-001;
    __statist_i_h_wts[18,33]=-1.71624827490534e-001;
    __statist_i_h_wts[18,34]=-1.38737837856798e-001;
    __statist_i_h_wts[18,35]=-5.36240236504192e-002;
    __statist_i_h_wts[18,36]=2.37824072687589e-002;
    __statist_i_h_wts[18,37]=1.21004610793726e-001;
    __statist_i_h_wts[18,38]=5.79600087330246e-002;
    __statist_i_h_wts[18,39]=2.67115705403446e-002;
    __statist_i_h_wts[18,40]=2.21620938747603e-002;
    __statist_i_h_wts[18,41]=8.04136401123985e-002;
    __statist_i_h_wts[18,42]=6.19683212709836e-002;
    __statist_i_h_wts[18,43]=9.14535190989123e-002;
    __statist_i_h_wts[18,44]=9.68639993510237e-002;
    __statist_i_h_wts[18,45]=-6.96072309504489e-002;
    __statist_i_h_wts[18,46]=1.48536806618581e-002;
    __statist_i_h_wts[18,47]=-4.91574667251438e-002;
    __statist_i_h_wts[18,48]=-1.36803014183001e-001;
    __statist_i_h_wts[18,49]=-1.11877248649143e-001;
    __statist_i_h_wts[18,50]=2.25823975755897e-002;
    __statist_i_h_wts[18,51]=1.25861464195490e-002;
    __statist_i_h_wts[18,52]=1.27782917853725e-001;
    __statist_i_h_wts[18,53]=8.79806363762222e-002;
    __statist_i_h_wts[18,54]=1.28680203507720e-001;
    __statist_i_h_wts[18,55]=4.58324127640672e-002;
    __statist_i_h_wts[18,56]=6.46268512021031e-002;
    __statist_i_h_wts[18,57]=-2.78580576224242e-003;
    __statist_i_h_wts[18,58]=6.36571999026627e-002;
    __statist_i_h_wts[18,59]=1.72620616933045e-002;
    __statist_i_h_wts[18,60]=-1.76197544612586e-001;
    __statist_i_h_wts[18,61]=-1.50648151762435e-001;
    __statist_i_h_wts[18,62]=-1.24352542872171e-001;
    __statist_i_h_wts[18,63]=-1.25620368953651e-001;
    __statist_i_h_wts[18,64]=-1.13628353654238e-002;
    __statist_i_h_wts[18,65]=5.98743013427229e-002;
    __statist_i_h_wts[18,66]=1.03714571260027e-001;
    __statist_i_h_wts[18,67]=1.52215839788906e-001;
    __statist_i_h_wts[18,68]=9.71828311026757e-002;
    __statist_i_h_wts[18,69]=1.48256002876011e-001;
    __statist_i_h_wts[18,70]=-2.22962098400370e-002;
    __statist_i_h_wts[18,71]=4.06011755789616e-002;
    __statist_i_h_wts[18,72]=5.69629263257152e-002;
    __statist_i_h_wts[18,73]=8.97659827835808e-002;
    __statist_i_h_wts[18,74]=2.03054423016052e-002;
    __statist_i_h_wts[18,75]=-4.59744095687496e-002;
    __statist_i_h_wts[18,76]=-1.37634956272021e-001;
    __statist_i_h_wts[18,77]=-1.26345233499276e-001;
    __statist_i_h_wts[18,78]=-1.36147686719715e-001;
    __statist_i_h_wts[18,79]=-1.27054908703874e-001;
    __statist_i_h_wts[18,80]=-1.20704512328133e-001;
    __statist_i_h_wts[18,81]=-1.01014519754949e-001;
    __statist_i_h_wts[18,82]=7.21274141491579e-002;
    __statist_i_h_wts[18,83]=1.50524694624343e-001;
    __statist_i_h_wts[18,84]=2.41986350281533e-001;
    __statist_i_h_wts[18,85]=2.06279915433424e-001;
    __statist_i_h_wts[18,86]=1.28088930664766e-001;
    __statist_i_h_wts[18,87]=1.58855409231651e-001;
    __statist_i_h_wts[18,88]=8.74801965914805e-002;
    __statist_i_h_wts[18,89]=3.95117399036279e-002;
    __statist_i_h_wts[18,90]=-1.56364767031377e-001;
    __statist_i_h_wts[18,91]=-4.52689010201873e-002;
    __statist_i_h_wts[18,92]=-6.55198766677526e-002;
    __statist_i_h_wts[18,93]=-1.51229242125768e-002;
    __statist_i_h_wts[18,94]=6.85691986369907e-002;
    __statist_i_h_wts[18,95]=7.14437562428310e-002;
    __statist_i_h_wts[18,96]=-3.33057963331850e-002;
    __statist_i_h_wts[18,97]=8.53117007306492e-002;
    __statist_i_h_wts[18,98]=1.27583756127865e-001;
    __statist_i_h_wts[18,99]=1.86394754863147e-001;
    __statist_i_h_wts[18,100]=2.22494339773413e-001;
    __statist_i_h_wts[18,101]=9.08463287883689e-002;
    __statist_i_h_wts[18,102]=1.48799510007519e-001;
    __statist_i_h_wts[18,103]=1.37001943917398e-001;
    __statist_i_h_wts[18,104]=5.29832645237682e-002;
    __statist_i_h_wts[18,105]=-2.39640530942371e-001;
    __statist_i_h_wts[18,106]=-1.41632034356612e-001;
    __statist_i_h_wts[18,107]=-1.08874134663269e-001;
    __statist_i_h_wts[18,108]=-9.35487983515850e-002;
    __statist_i_h_wts[18,109]=-1.65581648066268e-002;
    __statist_i_h_wts[18,110]=1.08140548534950e-001;
    __statist_i_h_wts[18,111]=-2.58199695949115e-002;
    __statist_i_h_wts[18,112]=3.68610844325922e-002;
    __statist_i_h_wts[18,113]=1.65729606595486e-001;
    __statist_i_h_wts[18,114]=2.49502818581810e-001;
    __statist_i_h_wts[18,115]=1.92635582918910e-001;
    __statist_i_h_wts[18,116]=2.80241005413007e-002;
    __statist_i_h_wts[18,117]=8.65748929218150e-002;
    __statist_i_h_wts[18,118]=3.68201178515391e-002;
    __statist_i_h_wts[18,119]=1.88908724164225e-002;
    __statist_i_h_wts[18,120]=-1.92112385649526e-001;
    __statist_i_h_wts[18,121]=-1.91329288640906e-001;
    __statist_i_h_wts[18,122]=-1.18461033929485e-001;
    __statist_i_h_wts[18,123]=-2.95290560129411e-002;
    __statist_i_h_wts[18,124]=4.29601614294407e-002;
    __statist_i_h_wts[18,125]=1.31760865648008e-002;
    __statist_i_h_wts[18,126]=-2.10092218381891e-002;
    __statist_i_h_wts[18,127]=-4.91640628662782e-003;
    __statist_i_h_wts[18,128]=7.91229020136814e-003;
    __statist_i_h_wts[18,129]=2.00944831334031e-001;
    __statist_i_h_wts[18,130]=1.58802793845252e-001;
    __statist_i_h_wts[18,131]=7.31308075291370e-002;
    __statist_i_h_wts[18,132]=1.06145156658649e-001;
    __statist_i_h_wts[18,133]=6.37852073844612e-002;
    __statist_i_h_wts[18,134]=-6.64054231314577e-004;
    __statist_i_h_wts[18,135]=-1.46988468676691e-001;
    __statist_i_h_wts[18,136]=-1.11672654847414e-001;
    __statist_i_h_wts[18,137]=-7.68691304796461e-002;
    __statist_i_h_wts[18,138]=-2.27012896506305e-002;
    __statist_i_h_wts[18,139]=-3.09748909937410e-002;
    __statist_i_h_wts[18,140]=7.69198046911232e-002;
    __statist_i_h_wts[18,141]=2.35019450043880e-002;
    __statist_i_h_wts[18,142]=-2.75569602380122e-002;
    __statist_i_h_wts[18,143]=-3.15068096264262e-002;
    __statist_i_h_wts[18,144]=5.62459326167509e-002;
    __statist_i_h_wts[18,145]=7.29170881618641e-002;
    __statist_i_h_wts[18,146]=1.06636057064205e-001;
    __statist_i_h_wts[18,147]=1.26059684439208e-001;
    __statist_i_h_wts[18,148]=7.14400386467412e-002;
    __statist_i_h_wts[18,149]=1.01026082506142e-002;
    __statist_i_h_wts[18,150]=-2.01261018425138e-001;
    __statist_i_h_wts[18,151]=-1.83508999965403e-001;
    __statist_i_h_wts[18,152]=-8.75831325989675e-002;
    __statist_i_h_wts[18,153]=-1.35560390896147e-001;
    __statist_i_h_wts[18,154]=-4.83708697741691e-002;
    __statist_i_h_wts[18,155]=3.54416887418766e-002;
    __statist_i_h_wts[18,156]=-1.54584442102849e-002;
    __statist_i_h_wts[18,157]=-6.20058905676618e-002;
    __statist_i_h_wts[18,158]=-6.65824966201286e-002;
    __statist_i_h_wts[18,159]=3.47537622868134e-002;
    __statist_i_h_wts[18,160]=8.10991991118752e-002;
    __statist_i_h_wts[18,161]=1.00568793815425e-001;
    __statist_i_h_wts[18,162]=1.27348807191501e-001;
    __statist_i_h_wts[18,163]=4.66232769735361e-002;
    __statist_i_h_wts[18,164]=2.92842077504539e-002;
    __statist_i_h_wts[18,165]=-1.10415234632127e-001;
    __statist_i_h_wts[18,166]=-1.16424289486235e-001;
    __statist_i_h_wts[18,167]=-1.97877836432734e-002;
    __statist_i_h_wts[18,168]=-1.15604338581276e-001;
    __statist_i_h_wts[18,169]=5.42473794860890e-003;
    __statist_i_h_wts[18,170]=1.39673912895002e-002;
    __statist_i_h_wts[18,171]=-6.50325196753876e-002;
    __statist_i_h_wts[18,172]=-4.26490822345409e-002;
    __statist_i_h_wts[18,173]=-1.58084286795714e-002;
    __statist_i_h_wts[18,174]=7.99145703624527e-002;
    __statist_i_h_wts[18,175]=7.80765163674580e-002;
    __statist_i_h_wts[18,176]=6.41364676759933e-002;
    __statist_i_h_wts[18,177]=5.12315013322835e-002;
    __statist_i_h_wts[18,178]=-1.24983991367931e-002;
    __statist_i_h_wts[18,179]=3.24630378866716e-002;
    __statist_i_h_wts[18,180]=-1.07031744485897e-001;
    __statist_i_h_wts[18,181]=-1.19250524850991e-001;
    __statist_i_h_wts[18,182]=-1.04509274270109e-002;
    __statist_i_h_wts[18,183]=-2.15985179007508e-002;
    __statist_i_h_wts[18,184]=1.56136080645863e-003;
    __statist_i_h_wts[18,185]=1.17071596888330e-002;
    __statist_i_h_wts[18,186]=-1.17210050444347e-002;
    __statist_i_h_wts[18,187]=5.72903789656412e-002;
    __statist_i_h_wts[18,188]=2.72079713552180e-002;
    __statist_i_h_wts[18,189]=-1.48645854536933e-003;
    __statist_i_h_wts[18,190]=-4.73102892026795e-003;
    __statist_i_h_wts[18,191]=8.92602323816815e-002;
    __statist_i_h_wts[18,192]=6.00746780221010e-002;
    __statist_i_h_wts[18,193]=1.30498475607179e-001;
    __statist_i_h_wts[18,194]=1.12764148219304e-001;
    __statist_i_h_wts[18,195]=-1.39903894334106e-001;
    __statist_i_h_wts[18,196]=-1.38694769649947e-001;
    __statist_i_h_wts[18,197]=-1.01609475154583e-001;
    __statist_i_h_wts[18,198]=-1.42779040220234e-001;
    __statist_i_h_wts[18,199]=-1.03943846306314e-001;
    __statist_i_h_wts[18,200]=-8.90044099022189e-002;
    __statist_i_h_wts[18,201]=-1.65504238924090e-001;
    __statist_i_h_wts[18,202]=-6.55170196175007e-002;
    __statist_i_h_wts[18,203]=-7.21421790915169e-002;
    __statist_i_h_wts[18,204]=-9.96339148367941e-002;
    __statist_i_h_wts[18,205]=-6.02734867208466e-002;
    __statist_i_h_wts[18,206]=5.27922500031160e-003;
    __statist_i_h_wts[18,207]=4.71945523603153e-002;
    __statist_i_h_wts[18,208]=1.39409456490412e-001;
    __statist_i_h_wts[18,209]=1.15027796632892e-001;
    __statist_i_h_wts[18,210]=-1.23673392912706e-001;
    __statist_i_h_wts[18,211]=-1.43367913823049e-001;
    __statist_i_h_wts[18,212]=-1.45461115441034e-001;
    __statist_i_h_wts[18,213]=-9.79349191614937e-002;
    __statist_i_h_wts[18,214]=-5.71471497084229e-002;
    __statist_i_h_wts[18,215]=-7.71151455564675e-002;
    __statist_i_h_wts[18,216]=-1.15004865270318e-001;
    __statist_i_h_wts[18,217]=-7.02659185557747e-002;
    __statist_i_h_wts[18,218]=-8.89863508296174e-002;
    __statist_i_h_wts[18,219]=-1.03328532321539e-001;
    __statist_i_h_wts[18,220]=-7.92323874712806e-002;
    __statist_i_h_wts[18,221]=-3.33551071893150e-002;
    __statist_i_h_wts[18,222]=1.30710389274982e-002;
    __statist_i_h_wts[18,223]=9.60325760400011e-002;
    __statist_i_h_wts[18,224]=7.38334512949294e-002;
    __statist_i_h_wts[18,225]=-1.29674903390052e-001;
    __statist_i_h_wts[18,226]=-7.50611664383777e-002;
    __statist_i_h_wts[18,227]=-1.36055527941610e-001;
    __statist_i_h_wts[18,228]=-7.52320845481042e-002;
    __statist_i_h_wts[18,229]=-2.31405426338317e-001;
    __statist_i_h_wts[18,230]=-5.68256700596363e-001;
    __statist_i_h_wts[18,231]=-4.03719132262934e-001;
    __statist_i_h_wts[18,232]=-8.23705649865403e-001;
    __statist_i_h_wts[18,233]=-2.11596491979931e-001;
    __statist_i_h_wts[18,234]=-9.44767614243338e-001;
    __statist_i_h_wts[18,235]=-6.44916319624490e-002;
    __statist_i_h_wts[18,236]=-7.46784455760529e-002;
    __statist_i_h_wts[18,237]=1.74747691260207e+000;
    __statist_i_h_wts[18,238]=5.61460800279143e-001;
    __statist_i_h_wts[18,239]=-3.69709584801507e-001;
    __statist_i_h_wts[18,240]=-2.88814039984911e-001;
    __statist_i_h_wts[18,241]=-8.10279581385375e-001;
    __statist_i_h_wts[18,242]=1.03713020232638e-001;
    __statist_i_h_wts[18,243]=-5.29613074225709e-003;
    __statist_i_h_wts[18,244]=-4.19257706879071e-002;
    __statist_i_h_wts[18,245]=2.25682052609764e-001;
    __statist_i_h_wts[18,246]=-1.94809911843672e-001;
    __statist_i_h_wts[18,247]=1.17045867010632e-001;
    __statist_i_h_wts[18,248]=2.28495933032052e-001;

    __statist_i_h_wts[19,0]=-2.51915805176856e-002;
    __statist_i_h_wts[19,1]=-4.58129657440622e-002;
    __statist_i_h_wts[19,2]=-1.75367342109696e-001;
    __statist_i_h_wts[19,3]=-2.08161630554106e-001;
    __statist_i_h_wts[19,4]=-2.09892872381134e-001;
    __statist_i_h_wts[19,5]=-1.28769829864826e-001;
    __statist_i_h_wts[19,6]=-1.69114927779130e-002;
    __statist_i_h_wts[19,7]=3.50143007808219e-002;
    __statist_i_h_wts[19,8]=1.06881866867917e-003;
    __statist_i_h_wts[19,9]=1.27835440837230e-002;
    __statist_i_h_wts[19,10]=-5.30766890350151e-002;
    __statist_i_h_wts[19,11]=2.85601329330421e-003;
    __statist_i_h_wts[19,12]=7.75642747577795e-002;
    __statist_i_h_wts[19,13]=5.41696671810926e-002;
    __statist_i_h_wts[19,14]=-5.09694177314978e-002;
    __statist_i_h_wts[19,15]=3.55311739471242e-002;
    __statist_i_h_wts[19,16]=-2.72738338796404e-002;
    __statist_i_h_wts[19,17]=-1.43821457276836e-001;
    __statist_i_h_wts[19,18]=-2.57416862390912e-001;
    __statist_i_h_wts[19,19]=-2.05186508874084e-001;
    __statist_i_h_wts[19,20]=-2.68549100554096e-002;
    __statist_i_h_wts[19,21]=6.20513150654921e-003;
    __statist_i_h_wts[19,22]=1.32795839183318e-001;
    __statist_i_h_wts[19,23]=1.22871938869495e-001;
    __statist_i_h_wts[19,24]=1.77672191681939e-001;
    __statist_i_h_wts[19,25]=9.92247613356230e-003;
    __statist_i_h_wts[19,26]=1.43179855391062e-002;
    __statist_i_h_wts[19,27]=5.68127808332031e-002;
    __statist_i_h_wts[19,28]=7.00731276183116e-002;
    __statist_i_h_wts[19,29]=-5.26862099786607e-002;
    __statist_i_h_wts[19,30]=-5.01658265325258e-002;
    __statist_i_h_wts[19,31]=-1.38450571619826e-001;
    __statist_i_h_wts[19,32]=-2.21260838216069e-001;
    __statist_i_h_wts[19,33]=-4.04412020569997e-001;
    __statist_i_h_wts[19,34]=-3.19877904383289e-001;
    __statist_i_h_wts[19,35]=-1.23384353818551e-001;
    __statist_i_h_wts[19,36]=-8.16460935800336e-002;
    __statist_i_h_wts[19,37]=5.78603253388209e-002;
    __statist_i_h_wts[19,38]=5.76567261737552e-002;
    __statist_i_h_wts[19,39]=8.96674269651571e-002;
    __statist_i_h_wts[19,40]=7.46374675443644e-002;
    __statist_i_h_wts[19,41]=6.37214645565012e-002;
    __statist_i_h_wts[19,42]=1.92704007069284e-002;
    __statist_i_h_wts[19,43]=8.64585644599061e-002;
    __statist_i_h_wts[19,44]=3.26587103935414e-002;
    __statist_i_h_wts[19,45]=-1.54579959380093e-001;
    __statist_i_h_wts[19,46]=-1.52357856612009e-001;
    __statist_i_h_wts[19,47]=-1.06965185882591e-001;
    __statist_i_h_wts[19,48]=-2.16258902469115e-001;
    __statist_i_h_wts[19,49]=-1.24189682108787e-002;
    __statist_i_h_wts[19,50]=-1.17105534741953e-002;
    __statist_i_h_wts[19,51]=6.48592489328858e-002;
    __statist_i_h_wts[19,52]=1.35024817193843e-001;
    __statist_i_h_wts[19,53]=1.77361265127482e-001;
    __statist_i_h_wts[19,54]=1.39300318631764e-001;
    __statist_i_h_wts[19,55]=1.72131409291420e-001;
    __statist_i_h_wts[19,56]=9.35642915111436e-002;
    __statist_i_h_wts[19,57]=1.26529961231780e-001;
    __statist_i_h_wts[19,58]=1.35538074642268e-001;
    __statist_i_h_wts[19,59]=1.19036816361703e-001;
    __statist_i_h_wts[19,60]=-1.34455055286092e-001;
    __statist_i_h_wts[19,61]=-1.00956417152502e-001;
    __statist_i_h_wts[19,62]=-8.81215360362800e-002;
    __statist_i_h_wts[19,63]=-1.12187937050652e-001;
    __statist_i_h_wts[19,64]=-1.02063663239356e-002;
    __statist_i_h_wts[19,65]=3.03199985377361e-002;
    __statist_i_h_wts[19,66]=1.12546473813463e-001;
    __statist_i_h_wts[19,67]=2.11780879172272e-001;
    __statist_i_h_wts[19,68]=2.96174867387533e-001;
    __statist_i_h_wts[19,69]=1.94076976420801e-001;
    __statist_i_h_wts[19,70]=2.22820899518567e-001;
    __statist_i_h_wts[19,71]=1.65287821842644e-001;
    __statist_i_h_wts[19,72]=1.58343140606338e-001;
    __statist_i_h_wts[19,73]=9.68145198200530e-002;
    __statist_i_h_wts[19,74]=1.15710870456556e-001;
    __statist_i_h_wts[19,75]=-1.69994734133916e-001;
    __statist_i_h_wts[19,76]=-1.73655019906814e-001;
    __statist_i_h_wts[19,77]=-1.91332068402414e-001;
    __statist_i_h_wts[19,78]=-1.97319106196548e-001;
    __statist_i_h_wts[19,79]=-1.25221475530328e-001;
    __statist_i_h_wts[19,80]=-9.56709399691093e-002;
    __statist_i_h_wts[19,81]=-7.04552324848719e-003;
    __statist_i_h_wts[19,82]=1.15274528571376e-001;
    __statist_i_h_wts[19,83]=1.66566612730378e-001;
    __statist_i_h_wts[19,84]=2.66059687394392e-001;
    __statist_i_h_wts[19,85]=3.08962969428631e-001;
    __statist_i_h_wts[19,86]=2.36554771161100e-001;
    __statist_i_h_wts[19,87]=2.05922468223932e-001;
    __statist_i_h_wts[19,88]=1.88939836435107e-001;
    __statist_i_h_wts[19,89]=1.44699522784075e-001;
    __statist_i_h_wts[19,90]=-1.64324753351616e-001;
    __statist_i_h_wts[19,91]=-1.52420741531217e-001;
    __statist_i_h_wts[19,92]=-1.48336737478337e-001;
    __statist_i_h_wts[19,93]=-1.22100426713964e-001;
    __statist_i_h_wts[19,94]=-5.13935466632705e-002;
    __statist_i_h_wts[19,95]=4.58131247594409e-002;
    __statist_i_h_wts[19,96]=-8.57485759588515e-002;
    __statist_i_h_wts[19,97]=3.03208642571854e-002;
    __statist_i_h_wts[19,98]=1.52531350599034e-001;
    __statist_i_h_wts[19,99]=2.18348671522378e-001;
    __statist_i_h_wts[19,100]=2.29689199902579e-001;
    __statist_i_h_wts[19,101]=2.17255926649175e-001;
    __statist_i_h_wts[19,102]=2.40294897525740e-001;
    __statist_i_h_wts[19,103]=2.12018395803218e-001;
    __statist_i_h_wts[19,104]=2.07864284661441e-001;
    __statist_i_h_wts[19,105]=-1.36102331748742e-001;
    __statist_i_h_wts[19,106]=-1.70992442639116e-001;
    __statist_i_h_wts[19,107]=-1.51185268049102e-001;
    __statist_i_h_wts[19,108]=-1.77995658830989e-001;
    __statist_i_h_wts[19,109]=-4.17232499066129e-002;
    __statist_i_h_wts[19,110]=2.11795981968944e-002;
    __statist_i_h_wts[19,111]=-1.13818122235669e-001;
    __statist_i_h_wts[19,112]=-5.12398459126434e-002;
    __statist_i_h_wts[19,113]=5.37881983919292e-002;
    __statist_i_h_wts[19,114]=1.26254706058302e-001;
    __statist_i_h_wts[19,115]=2.13625378680527e-001;
    __statist_i_h_wts[19,116]=1.88064621768296e-001;
    __statist_i_h_wts[19,117]=2.61082867641762e-001;
    __statist_i_h_wts[19,118]=1.64922429355275e-001;
    __statist_i_h_wts[19,119]=9.65459819796634e-002;
    __statist_i_h_wts[19,120]=-1.37077317827293e-001;
    __statist_i_h_wts[19,121]=-1.69152277272784e-001;
    __statist_i_h_wts[19,122]=-1.66465348153424e-001;
    __statist_i_h_wts[19,123]=-1.61127353718564e-001;
    __statist_i_h_wts[19,124]=-3.39146239050087e-003;
    __statist_i_h_wts[19,125]=4.71500844265832e-002;
    __statist_i_h_wts[19,126]=-2.36400154921443e-002;
    __statist_i_h_wts[19,127]=3.53222348221921e-002;
    __statist_i_h_wts[19,128]=1.41704259103248e-001;
    __statist_i_h_wts[19,129]=1.06722999363617e-001;
    __statist_i_h_wts[19,130]=1.11768250363616e-001;
    __statist_i_h_wts[19,131]=9.73531582502053e-002;
    __statist_i_h_wts[19,132]=1.45729587998103e-001;
    __statist_i_h_wts[19,133]=5.75309674318943e-002;
    __statist_i_h_wts[19,134]=4.73597238619062e-002;
    __statist_i_h_wts[19,135]=-8.56584049321086e-002;
    __statist_i_h_wts[19,136]=-1.17492075575792e-001;
    __statist_i_h_wts[19,137]=-1.14194394967729e-001;
    __statist_i_h_wts[19,138]=-1.02042252579544e-001;
    __statist_i_h_wts[19,139]=6.01901356669832e-003;
    __statist_i_h_wts[19,140]=-5.05116515675362e-002;
    __statist_i_h_wts[19,141]=-7.06511437032550e-002;
    __statist_i_h_wts[19,142]=7.51183556405161e-003;
    __statist_i_h_wts[19,143]=1.33319410556795e-001;
    __statist_i_h_wts[19,144]=1.07001812126217e-001;
    __statist_i_h_wts[19,145]=8.44410645271121e-002;
    __statist_i_h_wts[19,146]=8.65999493278238e-002;
    __statist_i_h_wts[19,147]=2.06308098731560e-001;
    __statist_i_h_wts[19,148]=2.37113794274019e-001;
    __statist_i_h_wts[19,149]=1.53610727087892e-001;
    __statist_i_h_wts[19,150]=-5.89624782051674e-002;
    __statist_i_h_wts[19,151]=-1.12869580105341e-001;
    __statist_i_h_wts[19,152]=-1.51988444112935e-001;
    __statist_i_h_wts[19,153]=-1.60274162836884e-001;
    __statist_i_h_wts[19,154]=-8.03872958438162e-002;
    __statist_i_h_wts[19,155]=-4.85706272427830e-002;
    __statist_i_h_wts[19,156]=-6.85375759904798e-002;
    __statist_i_h_wts[19,157]=3.68593669208878e-002;
    __statist_i_h_wts[19,158]=1.90147389064933e-001;
    __statist_i_h_wts[19,159]=2.33198281885425e-001;
    __statist_i_h_wts[19,160]=2.49543868427510e-001;
    __statist_i_h_wts[19,161]=2.78757673985947e-001;
    __statist_i_h_wts[19,162]=3.65317456156631e-001;
    __statist_i_h_wts[19,163]=3.25214666866871e-001;
    __statist_i_h_wts[19,164]=2.25469779066188e-001;
    __statist_i_h_wts[19,165]=-7.48609389678806e-002;
    __statist_i_h_wts[19,166]=-1.41014911982554e-001;
    __statist_i_h_wts[19,167]=-9.81717427683565e-002;
    __statist_i_h_wts[19,168]=-1.84987921097897e-001;
    __statist_i_h_wts[19,169]=-1.17348050175589e-001;
    __statist_i_h_wts[19,170]=-8.96605784258780e-002;
    __statist_i_h_wts[19,171]=-9.70913333121336e-002;
    __statist_i_h_wts[19,172]=-4.09118821137702e-002;
    __statist_i_h_wts[19,173]=4.51103876154041e-003;
    __statist_i_h_wts[19,174]=9.02522244779279e-002;
    __statist_i_h_wts[19,175]=1.64782833139969e-001;
    __statist_i_h_wts[19,176]=1.99317756806546e-001;
    __statist_i_h_wts[19,177]=2.36361346577753e-001;
    __statist_i_h_wts[19,178]=3.38351257405083e-001;
    __statist_i_h_wts[19,179]=1.96884412013018e-001;
    __statist_i_h_wts[19,180]=-7.95511041909641e-002;
    __statist_i_h_wts[19,181]=-8.26287727415361e-002;
    __statist_i_h_wts[19,182]=-5.56096674257286e-002;
    __statist_i_h_wts[19,183]=-1.20421177827085e-001;
    __statist_i_h_wts[19,184]=-1.46670249402479e-001;
    __statist_i_h_wts[19,185]=-1.71163409714966e-001;
    __statist_i_h_wts[19,186]=-5.04761919017859e-002;
    __statist_i_h_wts[19,187]=1.46788567697816e-002;
    __statist_i_h_wts[19,188]=1.42850526583002e-001;
    __statist_i_h_wts[19,189]=1.94764100431244e-001;
    __statist_i_h_wts[19,190]=2.54229618910868e-001;
    __statist_i_h_wts[19,191]=2.56999373932780e-001;
    __statist_i_h_wts[19,192]=2.46428977867186e-001;
    __statist_i_h_wts[19,193]=1.54931151143318e-001;
    __statist_i_h_wts[19,194]=2.74938334213052e-002;
    __statist_i_h_wts[19,195]=-1.22211190204911e-001;
    __statist_i_h_wts[19,196]=-1.20963310629430e-001;
    __statist_i_h_wts[19,197]=-1.38303421579163e-001;
    __statist_i_h_wts[19,198]=-1.74134656912213e-001;
    __statist_i_h_wts[19,199]=-1.98587946240015e-001;
    __statist_i_h_wts[19,200]=-2.00543129958765e-001;
    __statist_i_h_wts[19,201]=-1.10069263749744e-001;
    __statist_i_h_wts[19,202]=-2.05347170559961e-002;
    __statist_i_h_wts[19,203]=3.79715975931996e-002;
    __statist_i_h_wts[19,204]=5.05922930780971e-002;
    __statist_i_h_wts[19,205]=9.02979766017749e-002;
    __statist_i_h_wts[19,206]=1.18700551369966e-001;
    __statist_i_h_wts[19,207]=5.81601016840457e-002;
    __statist_i_h_wts[19,208]=9.71192847236913e-002;
    __statist_i_h_wts[19,209]=4.40173781144256e-002;
    __statist_i_h_wts[19,210]=-5.37459551412805e-002;
    __statist_i_h_wts[19,211]=-2.48196135852035e-002;
    __statist_i_h_wts[19,212]=-6.52350920407714e-002;
    __statist_i_h_wts[19,213]=-8.26562733611651e-002;
    __statist_i_h_wts[19,214]=-1.15802648929338e-001;
    __statist_i_h_wts[19,215]=-1.39508732901610e-001;
    __statist_i_h_wts[19,216]=-9.89130866079869e-002;
    __statist_i_h_wts[19,217]=-4.55372902895712e-002;
    __statist_i_h_wts[19,218]=-5.04749331754254e-003;
    __statist_i_h_wts[19,219]=3.45221737566461e-002;
    __statist_i_h_wts[19,220]=7.72149176674216e-002;
    __statist_i_h_wts[19,221]=9.04759114216080e-002;
    __statist_i_h_wts[19,222]=4.98136970909351e-002;
    __statist_i_h_wts[19,223]=3.99576080997850e-003;
    __statist_i_h_wts[19,224]=-7.73695675011919e-004;
    __statist_i_h_wts[19,225]=-2.23243783949184e-001;
    __statist_i_h_wts[19,226]=2.37628665363338e-002;
    __statist_i_h_wts[19,227]=-2.06091120227293e-001;
    __statist_i_h_wts[19,228]=-2.84801274917047e-002;
    __statist_i_h_wts[19,229]=-1.73114160263294e-001;
    __statist_i_h_wts[19,230]=-6.94089196666843e-002;
    __statist_i_h_wts[19,231]=-1.04410294744164e-002;
    __statist_i_h_wts[19,232]=-2.65242088139873e-001;
    __statist_i_h_wts[19,233]=-6.46225600590000e-003;
    __statist_i_h_wts[19,234]=7.28904887764334e-002;
    __statist_i_h_wts[19,235]=1.32122637444542e-001;
    __statist_i_h_wts[19,236]=4.03148608542319e-001;
    __statist_i_h_wts[19,237]=-5.07449422426920e-001;
    __statist_i_h_wts[19,238]=-1.84929028139614e-001;
    __statist_i_h_wts[19,239]=-1.91433337283050e-001;
    __statist_i_h_wts[19,240]=2.11392567151443e-001;
    __statist_i_h_wts[19,241]=-6.10763497399690e-003;
    __statist_i_h_wts[19,242]=-3.25998430192741e-005;
    __statist_i_h_wts[19,243]=-2.30192122759121e-001;
    __statist_i_h_wts[19,244]=4.52888694284130e-002;
    __statist_i_h_wts[19,245]=2.99923308092476e-001;
    __statist_i_h_wts[19,246]=8.41543222343810e-002;
    __statist_i_h_wts[19,247]=1.47984968330019e-001;
    __statist_i_h_wts[19,248]=-1.45756586650404e-001;

    __statist_i_h_wts[20,0]=3.81352514870611e-001;
    __statist_i_h_wts[20,1]=1.45428998098054e-001;
    __statist_i_h_wts[20,2]=6.11403758649516e-003;
    __statist_i_h_wts[20,3]=-2.05323659713740e-001;
    __statist_i_h_wts[20,4]=-1.31415792518026e-001;
    __statist_i_h_wts[20,5]=-9.50408192828692e-002;
    __statist_i_h_wts[20,6]=-2.02137926432025e-002;
    __statist_i_h_wts[20,7]=7.54245204510426e-002;
    __statist_i_h_wts[20,8]=6.65134421437679e-002;
    __statist_i_h_wts[20,9]=6.33836852010080e-004;
    __statist_i_h_wts[20,10]=7.84006012696440e-002;
    __statist_i_h_wts[20,11]=2.46655050758295e-001;
    __statist_i_h_wts[20,12]=3.17837112388661e-001;
    __statist_i_h_wts[20,13]=2.46592186635136e-002;
    __statist_i_h_wts[20,14]=-2.24890222146174e-001;
    __statist_i_h_wts[20,15]=4.27221640015689e-001;
    __statist_i_h_wts[20,16]=2.13774993493905e-001;
    __statist_i_h_wts[20,17]=1.57097877929141e-001;
    __statist_i_h_wts[20,18]=-8.31226938693496e-002;
    __statist_i_h_wts[20,19]=-7.14406366667369e-002;
    __statist_i_h_wts[20,20]=1.40025463321181e-002;
    __statist_i_h_wts[20,21]=-5.33016721907384e-002;
    __statist_i_h_wts[20,22]=-3.63170194751209e-002;
    __statist_i_h_wts[20,23]=-5.60194672766375e-002;
    __statist_i_h_wts[20,24]=-3.16773106498704e-002;
    __statist_i_h_wts[20,25]=-1.03002085493239e-001;
    __statist_i_h_wts[20,26]=-1.19250578979630e-001;
    __statist_i_h_wts[20,27]=-3.57257654655589e-004;
    __statist_i_h_wts[20,28]=1.49531297922037e-001;
    __statist_i_h_wts[20,29]=-2.53397250788845e-002;
    __statist_i_h_wts[20,30]=2.43992996707706e-001;
    __statist_i_h_wts[20,31]=-6.63915901463567e-002;
    __statist_i_h_wts[20,32]=3.33457032613094e-002;
    __statist_i_h_wts[20,33]=-3.47229500524746e-001;
    __statist_i_h_wts[20,34]=-1.83949103908434e-001;
    __statist_i_h_wts[20,35]=-1.11275100911188e-001;
    __statist_i_h_wts[20,36]=-2.80916960554292e-001;
    __statist_i_h_wts[20,37]=-5.88386038680455e-002;
    __statist_i_h_wts[20,38]=-9.89769311287293e-002;
    __statist_i_h_wts[20,39]=-8.13197882378995e-002;
    __statist_i_h_wts[20,40]=-1.37283643774842e-002;
    __statist_i_h_wts[20,41]=3.69579645357342e-003;
    __statist_i_h_wts[20,42]=-9.63767390206682e-002;
    __statist_i_h_wts[20,43]=1.71490922412121e-001;
    __statist_i_h_wts[20,44]=4.80073088701100e-002;
    __statist_i_h_wts[20,45]=-4.47871788845232e-002;
    __statist_i_h_wts[20,46]=-2.27556986461730e-001;
    __statist_i_h_wts[20,47]=3.80094328130782e-002;
    __statist_i_h_wts[20,48]=-3.32050850535577e-001;
    __statist_i_h_wts[20,49]=7.87143877830206e-003;
    __statist_i_h_wts[20,50]=-1.44233697237008e-001;
    __statist_i_h_wts[20,51]=-5.06444179519629e-002;
    __statist_i_h_wts[20,52]=-1.24237983962728e-001;
    __statist_i_h_wts[20,53]=-4.12327346911336e-002;
    __statist_i_h_wts[20,54]=-6.17243573932151e-002;
    __statist_i_h_wts[20,55]=3.06444942352873e-002;
    __statist_i_h_wts[20,56]=7.85417681356031e-002;
    __statist_i_h_wts[20,57]=1.98145079509731e-001;
    __statist_i_h_wts[20,58]=1.36620313386195e-001;
    __statist_i_h_wts[20,59]=7.29732977707036e-002;
    __statist_i_h_wts[20,60]=7.94957131894006e-002;
    __statist_i_h_wts[20,61]=-7.81266378632113e-003;
    __statist_i_h_wts[20,62]=1.00458445536819e-001;
    __statist_i_h_wts[20,63]=-6.37717887794392e-002;
    __statist_i_h_wts[20,64]=2.91272447335697e-002;
    __statist_i_h_wts[20,65]=-1.01171155852178e-001;
    __statist_i_h_wts[20,66]=8.16284293820530e-002;
    __statist_i_h_wts[20,67]=4.19190814057045e-002;
    __statist_i_h_wts[20,68]=1.53778982865545e-001;
    __statist_i_h_wts[20,69]=3.01001633893617e-002;
    __statist_i_h_wts[20,70]=1.46102402119050e-001;
    __statist_i_h_wts[20,71]=1.55649510892457e-001;
    __statist_i_h_wts[20,72]=1.88594441959161e-001;
    __statist_i_h_wts[20,73]=1.29073244304324e-002;
    __statist_i_h_wts[20,74]=5.54355069669484e-002;
    __statist_i_h_wts[20,75]=4.99844298232883e-004;
    __statist_i_h_wts[20,76]=-2.72597659024677e-002;
    __statist_i_h_wts[20,77]=5.23731173639086e-002;
    __statist_i_h_wts[20,78]=1.32878967046706e-001;
    __statist_i_h_wts[20,79]=2.01937842585064e-001;
    __statist_i_h_wts[20,80]=-1.08118204988833e-002;
    __statist_i_h_wts[20,81]=1.06763855051363e-001;
    __statist_i_h_wts[20,82]=9.68254700550574e-002;
    __statist_i_h_wts[20,83]=1.72666530829971e-001;
    __statist_i_h_wts[20,84]=1.35277381146814e-001;
    __statist_i_h_wts[20,85]=1.70321650116104e-001;
    __statist_i_h_wts[20,86]=2.17413969173509e-001;
    __statist_i_h_wts[20,87]=1.53150964691470e-001;
    __statist_i_h_wts[20,88]=1.08565780294715e-001;
    __statist_i_h_wts[20,89]=-1.76995953788631e-001;
    __statist_i_h_wts[20,90]=-5.46482119988915e-002;
    __statist_i_h_wts[20,91]=-1.36930722874530e-001;
    __statist_i_h_wts[20,92]=5.05895375808052e-002;
    __statist_i_h_wts[20,93]=1.03367366310712e-001;
    __statist_i_h_wts[20,94]=1.24485935757216e-001;
    __statist_i_h_wts[20,95]=3.13022355321152e-002;
    __statist_i_h_wts[20,96]=-5.21496511866001e-002;
    __statist_i_h_wts[20,97]=1.04865481800161e-001;
    __statist_i_h_wts[20,98]=9.36150907272515e-002;
    __statist_i_h_wts[20,99]=7.86305494422928e-002;
    __statist_i_h_wts[20,100]=1.31488065877165e-001;
    __statist_i_h_wts[20,101]=6.06581300331292e-002;
    __statist_i_h_wts[20,102]=1.21817300550717e-001;
    __statist_i_h_wts[20,103]=1.15529412657338e-001;
    __statist_i_h_wts[20,104]=-1.62721910088128e-002;
    __statist_i_h_wts[20,105]=-3.21901267726600e-002;
    __statist_i_h_wts[20,106]=-1.23510434015579e-001;
    __statist_i_h_wts[20,107]=-1.86158540020384e-002;
    __statist_i_h_wts[20,108]=-1.22758163875452e-001;
    __statist_i_h_wts[20,109]=-5.74182437319138e-002;
    __statist_i_h_wts[20,110]=-1.40889878035224e-001;
    __statist_i_h_wts[20,111]=-1.39691800404676e-001;
    __statist_i_h_wts[20,112]=1.31928317691505e-001;
    __statist_i_h_wts[20,113]=2.32410365562581e-002;
    __statist_i_h_wts[20,114]=9.41967478785689e-003;
    __statist_i_h_wts[20,115]=2.56183051275246e-001;
    __statist_i_h_wts[20,116]=1.53973160117768e-001;
    __statist_i_h_wts[20,117]=1.96542111431529e-001;
    __statist_i_h_wts[20,118]=1.99396874098880e-001;
    __statist_i_h_wts[20,119]=3.12079496929623e-002;
    __statist_i_h_wts[20,120]=-4.24262849797320e-002;
    __statist_i_h_wts[20,121]=-1.06235201030221e-001;
    __statist_i_h_wts[20,122]=-1.24012403930410e-001;
    __statist_i_h_wts[20,123]=-1.84819528648710e-001;
    __statist_i_h_wts[20,124]=-1.28877373074930e-001;
    __statist_i_h_wts[20,125]=-1.01255526163063e-001;
    __statist_i_h_wts[20,126]=-1.76092605621705e-001;
    __statist_i_h_wts[20,127]=1.95733174860562e-001;
    __statist_i_h_wts[20,128]=6.41305689045094e-002;
    __statist_i_h_wts[20,129]=-4.15035162471476e-002;
    __statist_i_h_wts[20,130]=5.97428838592806e-002;
    __statist_i_h_wts[20,131]=-7.87513720594641e-002;
    __statist_i_h_wts[20,132]=-1.67245062839797e-001;
    __statist_i_h_wts[20,133]=-2.31282726075469e-001;
    __statist_i_h_wts[20,134]=-1.73786985535709e-001;
    __statist_i_h_wts[20,135]=-1.76759514563789e-002;
    __statist_i_h_wts[20,136]=-8.27871256406506e-002;
    __statist_i_h_wts[20,137]=-7.53423131631710e-002;
    __statist_i_h_wts[20,138]=-1.34421542728508e-001;
    __statist_i_h_wts[20,139]=-3.58947494225304e-002;
    __statist_i_h_wts[20,140]=-2.08101343810499e-001;
    __statist_i_h_wts[20,141]=-2.87235933507544e-001;
    __statist_i_h_wts[20,142]=-5.74855165100368e-004;
    __statist_i_h_wts[20,143]=-9.09865916306987e-002;
    __statist_i_h_wts[20,144]=-1.12193756839575e-001;
    __statist_i_h_wts[20,145]=2.60305872286425e-002;
    __statist_i_h_wts[20,146]=-1.54208165719246e-001;
    __statist_i_h_wts[20,147]=-1.83996851861335e-001;
    __statist_i_h_wts[20,148]=-1.55693531374919e-001;
    __statist_i_h_wts[20,149]=-1.08272726351732e-001;
    __statist_i_h_wts[20,150]=6.07564352943775e-002;
    __statist_i_h_wts[20,151]=3.09374344345641e-003;
    __statist_i_h_wts[20,152]=-6.59257547851171e-002;
    __statist_i_h_wts[20,153]=1.08208512925606e-002;
    __statist_i_h_wts[20,154]=-6.15161815394523e-003;
    __statist_i_h_wts[20,155]=-1.29827994105152e-001;
    __statist_i_h_wts[20,156]=-1.54931697645888e-001;
    __statist_i_h_wts[20,157]=4.34786034167219e-002;
    __statist_i_h_wts[20,158]=-9.83155323005072e-002;
    __statist_i_h_wts[20,159]=-2.02151438196658e-002;
    __statist_i_h_wts[20,160]=2.36516503914102e-001;
    __statist_i_h_wts[20,161]=1.20228680474346e-001;
    __statist_i_h_wts[20,162]=2.97267966446844e-002;
    __statist_i_h_wts[20,163]=7.54010206493078e-002;
    __statist_i_h_wts[20,164]=2.05278837920567e-001;
    __statist_i_h_wts[20,165]=6.61929576089396e-002;
    __statist_i_h_wts[20,166]=3.41859175411815e-002;
    __statist_i_h_wts[20,167]=-2.06332598010727e-002;
    __statist_i_h_wts[20,168]=4.23445403027505e-002;
    __statist_i_h_wts[20,169]=-1.95962161319318e-002;
    __statist_i_h_wts[20,170]=-1.98792100777001e-002;
    __statist_i_h_wts[20,171]=-5.86399387981530e-002;
    __statist_i_h_wts[20,172]=5.01632444867561e-002;
    __statist_i_h_wts[20,173]=-1.46719134337767e-001;
    __statist_i_h_wts[20,174]=-2.32562367791531e-001;
    __statist_i_h_wts[20,175]=3.23180697600680e-002;
    __statist_i_h_wts[20,176]=1.88996401946404e-001;
    __statist_i_h_wts[20,177]=1.80306597351418e-001;
    __statist_i_h_wts[20,178]=1.66629216375099e-001;
    __statist_i_h_wts[20,179]=2.03968155928660e-001;
    __statist_i_h_wts[20,180]=8.74728517088331e-002;
    __statist_i_h_wts[20,181]=7.54980799059118e-002;
    __statist_i_h_wts[20,182]=1.85254185911395e-002;
    __statist_i_h_wts[20,183]=3.44373338021606e-002;
    __statist_i_h_wts[20,184]=-4.64694428495226e-002;
    __statist_i_h_wts[20,185]=-3.54153259151337e-002;
    __statist_i_h_wts[20,186]=-1.63405856770381e-002;
    __statist_i_h_wts[20,187]=8.15107584761363e-002;
    __statist_i_h_wts[20,188]=1.08166070006220e-002;
    __statist_i_h_wts[20,189]=-2.44175706602718e-002;
    __statist_i_h_wts[20,190]=1.81122405692922e-002;
    __statist_i_h_wts[20,191]=1.96327253234302e-001;
    __statist_i_h_wts[20,192]=1.21815092788955e-001;
    __statist_i_h_wts[20,193]=1.24941272427086e-002;
    __statist_i_h_wts[20,194]=-3.65437517044842e-002;
    __statist_i_h_wts[20,195]=7.14941170489791e-002;
    __statist_i_h_wts[20,196]=6.76783778818748e-002;
    __statist_i_h_wts[20,197]=-1.68663911958738e-003;
    __statist_i_h_wts[20,198]=8.16269258164574e-002;
    __statist_i_h_wts[20,199]=3.19641267236083e-002;
    __statist_i_h_wts[20,200]=5.33432156237710e-002;
    __statist_i_h_wts[20,201]=6.55408009569733e-002;
    __statist_i_h_wts[20,202]=1.80861409358448e-001;
    __statist_i_h_wts[20,203]=7.63825194191698e-002;
    __statist_i_h_wts[20,204]=-1.39158425317643e-002;
    __statist_i_h_wts[20,205]=-5.75857334491018e-002;
    __statist_i_h_wts[20,206]=2.85364562767914e-001;
    __statist_i_h_wts[20,207]=4.01541617456494e-002;
    __statist_i_h_wts[20,208]=-4.65355102773117e-002;
    __statist_i_h_wts[20,209]=3.38318360012733e-003;
    __statist_i_h_wts[20,210]=7.37205456184643e-002;
    __statist_i_h_wts[20,211]=1.14171801734223e-001;
    __statist_i_h_wts[20,212]=9.11060171465688e-002;
    __statist_i_h_wts[20,213]=1.57881008784541e-001;
    __statist_i_h_wts[20,214]=1.14772483063789e-001;
    __statist_i_h_wts[20,215]=8.45470896526961e-002;
    __statist_i_h_wts[20,216]=9.59826750617711e-002;
    __statist_i_h_wts[20,217]=1.96053517690323e-001;
    __statist_i_h_wts[20,218]=1.26032363174298e-001;
    __statist_i_h_wts[20,219]=3.67080330821135e-003;
    __statist_i_h_wts[20,220]=-4.25991704039814e-002;
    __statist_i_h_wts[20,221]=1.63545823239431e-001;
    __statist_i_h_wts[20,222]=-1.95979606498449e-002;
    __statist_i_h_wts[20,223]=-1.10759933099516e-001;
    __statist_i_h_wts[20,224]=2.84921577149310e-002;
    __statist_i_h_wts[20,225]=-1.09296141273032e-001;
    __statist_i_h_wts[20,226]=1.08619299677550e-001;
    __statist_i_h_wts[20,227]=-7.41100117678722e-002;
    __statist_i_h_wts[20,228]=-3.28495515181142e-002;
    __statist_i_h_wts[20,229]=4.40856516858250e-002;
    __statist_i_h_wts[20,230]=2.45704512643659e-001;
    __statist_i_h_wts[20,231]=2.21332504786714e-001;
    __statist_i_h_wts[20,232]=2.54712683806697e-001;
    __statist_i_h_wts[20,233]=2.73924848058639e-001;
    __statist_i_h_wts[20,234]=9.22021902898932e-001;
    __statist_i_h_wts[20,235]=2.97370481777911e-001;
    __statist_i_h_wts[20,236]=6.10095774246807e-001;
    __statist_i_h_wts[20,237]=-2.25817345297883e+000;
    __statist_i_h_wts[20,238]=-6.80556499059731e-001;
    __statist_i_h_wts[20,239]=1.45111119845057e-001;
    __statist_i_h_wts[20,240]=4.83932997934739e-001;
    __statist_i_h_wts[20,241]=6.37154507193692e-001;
    __statist_i_h_wts[20,242]=-1.53890967379226e-001;
    __statist_i_h_wts[20,243]=-7.77851837543279e-002;
    __statist_i_h_wts[20,244]=1.45717509002151e-001;
    __statist_i_h_wts[20,245]=3.85892208939261e-001;
    __statist_i_h_wts[20,246]=2.59816014070833e-001;
    __statist_i_h_wts[20,247]=-1.92318412494725e-001;
    __statist_i_h_wts[20,248]=-3.86691494700306e-001;

    __statist_i_h_wts[21,0]=5.20869186971128e-001;
    __statist_i_h_wts[21,1]=5.07384686855652e-001;
    __statist_i_h_wts[21,2]=4.19728157749988e-001;
    __statist_i_h_wts[21,3]=3.79250676428589e-001;
    __statist_i_h_wts[21,4]=3.17895318082600e-001;
    __statist_i_h_wts[21,5]=2.88358945264692e-001;
    __statist_i_h_wts[21,6]=2.23858174182793e-001;
    __statist_i_h_wts[21,7]=1.59037987785640e-001;
    __statist_i_h_wts[21,8]=7.75634668551401e-002;
    __statist_i_h_wts[21,9]=-4.96777571345780e-002;
    __statist_i_h_wts[21,10]=-7.10740326214400e-002;
    __statist_i_h_wts[21,11]=-8.75909354534798e-002;
    __statist_i_h_wts[21,12]=-7.33210019657462e-002;
    __statist_i_h_wts[21,13]=-1.28930564172697e-001;
    __statist_i_h_wts[21,14]=-1.79804838651878e-001;
    __statist_i_h_wts[21,15]=5.99383693752350e-001;
    __statist_i_h_wts[21,16]=5.83148494437269e-001;
    __statist_i_h_wts[21,17]=5.47487106688766e-001;
    __statist_i_h_wts[21,18]=4.78616647050247e-001;
    __statist_i_h_wts[21,19]=4.08461006260575e-001;
    __statist_i_h_wts[21,20]=4.09739622925572e-001;
    __statist_i_h_wts[21,21]=2.91969160511831e-001;
    __statist_i_h_wts[21,22]=2.05820018483491e-001;
    __statist_i_h_wts[21,23]=8.76560025004673e-002;
    __statist_i_h_wts[21,24]=-3.22311775629679e-002;
    __statist_i_h_wts[21,25]=-1.13664966608558e-001;
    __statist_i_h_wts[21,26]=-2.13937139916405e-001;
    __statist_i_h_wts[21,27]=-2.15505030994661e-001;
    __statist_i_h_wts[21,28]=-2.06438293263026e-001;
    __statist_i_h_wts[21,29]=-2.14657979824765e-001;
    __statist_i_h_wts[21,30]=5.76536050487306e-001;
    __statist_i_h_wts[21,31]=5.32366377820977e-001;
    __statist_i_h_wts[21,32]=5.09538972682909e-001;
    __statist_i_h_wts[21,33]=4.01761353702489e-001;
    __statist_i_h_wts[21,34]=3.47542749056179e-001;
    __statist_i_h_wts[21,35]=2.70938889763587e-001;
    __statist_i_h_wts[21,36]=1.38931870243430e-001;
    __statist_i_h_wts[21,37]=6.83952359211187e-002;
    __statist_i_h_wts[21,38]=-2.61548578168925e-002;
    __statist_i_h_wts[21,39]=-1.73962310396937e-001;
    __statist_i_h_wts[21,40]=-2.35380851498940e-001;
    __statist_i_h_wts[21,41]=-2.81656653882896e-001;
    __statist_i_h_wts[21,42]=-2.93780766791000e-001;
    __statist_i_h_wts[21,43]=-2.23772536184343e-001;
    __statist_i_h_wts[21,44]=-2.51607402480720e-001;
    __statist_i_h_wts[21,45]=4.76045051341534e-001;
    __statist_i_h_wts[21,46]=4.41073035936548e-001;
    __statist_i_h_wts[21,47]=4.53377577926131e-001;
    __statist_i_h_wts[21,48]=3.69652901027147e-001;
    __statist_i_h_wts[21,49]=3.04522799526770e-001;
    __statist_i_h_wts[21,50]=1.64498473440928e-001;
    __statist_i_h_wts[21,51]=4.27674668409681e-002;
    __statist_i_h_wts[21,52]=-6.83346380745338e-002;
    __statist_i_h_wts[21,53]=-1.76256415288300e-001;
    __statist_i_h_wts[21,54]=-3.15877151318093e-001;
    __statist_i_h_wts[21,55]=-3.43772833464378e-001;
    __statist_i_h_wts[21,56]=-3.95648260500663e-001;
    __statist_i_h_wts[21,57]=-3.30295709795002e-001;
    __statist_i_h_wts[21,58]=-3.63017253914549e-001;
    __statist_i_h_wts[21,59]=-3.10414430760347e-001;
    __statist_i_h_wts[21,60]=4.85677743714663e-001;
    __statist_i_h_wts[21,61]=4.40182860861857e-001;
    __statist_i_h_wts[21,62]=4.19982770488668e-001;
    __statist_i_h_wts[21,63]=3.77821553514144e-001;
    __statist_i_h_wts[21,64]=2.80738816868305e-001;
    __statist_i_h_wts[21,65]=2.28832901387893e-001;
    __statist_i_h_wts[21,66]=2.59441973788842e-002;
    __statist_i_h_wts[21,67]=-9.83551738348448e-002;
    __statist_i_h_wts[21,68]=-1.95946148855281e-001;
    __statist_i_h_wts[21,69]=-3.54674123151686e-001;
    __statist_i_h_wts[21,70]=-3.92307482201253e-001;
    __statist_i_h_wts[21,71]=-4.40601971345056e-001;
    __statist_i_h_wts[21,72]=-4.10924339487579e-001;
    __statist_i_h_wts[21,73]=-4.39672346943503e-001;
    __statist_i_h_wts[21,74]=-3.95312212621307e-001;
    __statist_i_h_wts[21,75]=4.39294218356479e-001;
    __statist_i_h_wts[21,76]=3.82259172338297e-001;
    __statist_i_h_wts[21,77]=4.01735839567904e-001;
    __statist_i_h_wts[21,78]=3.55204877264568e-001;
    __statist_i_h_wts[21,79]=2.73481337454197e-001;
    __statist_i_h_wts[21,80]=1.37679384752814e-001;
    __statist_i_h_wts[21,81]=-2.34176029912113e-002;
    __statist_i_h_wts[21,82]=-1.39083917279577e-001;
    __statist_i_h_wts[21,83]=-2.51549629356681e-001;
    __statist_i_h_wts[21,84]=-3.93389269081153e-001;
    __statist_i_h_wts[21,85]=-4.37711013960481e-001;
    __statist_i_h_wts[21,86]=-4.14903734781119e-001;
    __statist_i_h_wts[21,87]=-4.19983701079856e-001;
    __statist_i_h_wts[21,88]=-4.35251506217326e-001;
    __statist_i_h_wts[21,89]=-4.10980665695253e-001;
    __statist_i_h_wts[21,90]=4.27407561635681e-001;
    __statist_i_h_wts[21,91]=3.27509885509849e-001;
    __statist_i_h_wts[21,92]=3.30963183689955e-001;
    __statist_i_h_wts[21,93]=2.68176291179920e-001;
    __statist_i_h_wts[21,94]=2.12726221975821e-001;
    __statist_i_h_wts[21,95]=7.94875667701044e-002;
    __statist_i_h_wts[21,96]=-5.06924299239414e-002;
    __statist_i_h_wts[21,97]=-1.48773874761156e-001;
    __statist_i_h_wts[21,98]=-2.95932996592954e-001;
    __statist_i_h_wts[21,99]=-4.40215600146768e-001;
    __statist_i_h_wts[21,100]=-5.18802056080681e-001;
    __statist_i_h_wts[21,101]=-4.71855714132028e-001;
    __statist_i_h_wts[21,102]=-4.17526007827312e-001;
    __statist_i_h_wts[21,103]=-4.70945431651589e-001;
    __statist_i_h_wts[21,104]=-4.13127198658591e-001;
    __statist_i_h_wts[21,105]=4.19236458626757e-001;
    __statist_i_h_wts[21,106]=3.44544360636030e-001;
    __statist_i_h_wts[21,107]=3.46633542642042e-001;
    __statist_i_h_wts[21,108]=2.79932640068996e-001;
    __statist_i_h_wts[21,109]=2.28199186076166e-001;
    __statist_i_h_wts[21,110]=7.29143086839823e-002;
    __statist_i_h_wts[21,111]=-9.84869880734682e-002;
    __statist_i_h_wts[21,112]=-1.93746516341526e-001;
    __statist_i_h_wts[21,113]=-3.33162064679559e-001;
    __statist_i_h_wts[21,114]=-4.47926696135413e-001;
    __statist_i_h_wts[21,115]=-4.87800246253114e-001;
    __statist_i_h_wts[21,116]=-5.10857823169734e-001;
    __statist_i_h_wts[21,117]=-4.37098675901064e-001;
    __statist_i_h_wts[21,118]=-4.28481736806571e-001;
    __statist_i_h_wts[21,119]=-4.35074761918583e-001;
    __statist_i_h_wts[21,120]=4.04349965201676e-001;
    __statist_i_h_wts[21,121]=3.75888062887197e-001;
    __statist_i_h_wts[21,122]=3.34384695212665e-001;
    __statist_i_h_wts[21,123]=2.77723409751280e-001;
    __statist_i_h_wts[21,124]=2.13619121341241e-001;
    __statist_i_h_wts[21,125]=7.72181513156786e-002;
    __statist_i_h_wts[21,126]=-4.50875794636476e-002;
    __statist_i_h_wts[21,127]=-1.36846582539605e-001;
    __statist_i_h_wts[21,128]=-1.75109865977544e-001;
    __statist_i_h_wts[21,129]=-2.84806081662068e-001;
    __statist_i_h_wts[21,130]=-4.40358831639950e-001;
    __statist_i_h_wts[21,131]=-4.66547189474191e-001;
    __statist_i_h_wts[21,132]=-4.71436722378603e-001;
    __statist_i_h_wts[21,133]=-5.03780681236623e-001;
    __statist_i_h_wts[21,134]=-4.76460896019049e-001;
    __statist_i_h_wts[21,135]=3.17838823613187e-001;
    __statist_i_h_wts[21,136]=3.42286557459902e-001;
    __statist_i_h_wts[21,137]=3.38280543560276e-001;
    __statist_i_h_wts[21,138]=2.87431416882162e-001;
    __statist_i_h_wts[21,139]=2.20701538113995e-001;
    __statist_i_h_wts[21,140]=8.19342643047542e-002;
    __statist_i_h_wts[21,141]=-8.95553003537492e-003;
    __statist_i_h_wts[21,142]=-7.07237238838820e-002;
    __statist_i_h_wts[21,143]=-9.54513732779545e-002;
    __statist_i_h_wts[21,144]=-1.89247151173888e-001;
    __statist_i_h_wts[21,145]=-3.29481297824727e-001;
    __statist_i_h_wts[21,146]=-4.22845828304290e-001;
    __statist_i_h_wts[21,147]=-4.23894422782192e-001;
    __statist_i_h_wts[21,148]=-4.39367876893589e-001;
    __statist_i_h_wts[21,149]=-4.47110082832582e-001;
    __statist_i_h_wts[21,150]=3.51646741210360e-001;
    __statist_i_h_wts[21,151]=3.18236017117411e-001;
    __statist_i_h_wts[21,152]=2.95756916537429e-001;
    __statist_i_h_wts[21,153]=2.75039133637077e-001;
    __statist_i_h_wts[21,154]=1.60722021232113e-001;
    __statist_i_h_wts[21,155]=6.45920546896906e-002;
    __statist_i_h_wts[21,156]=-2.84420376205942e-002;
    __statist_i_h_wts[21,157]=-8.98772668108412e-002;
    __statist_i_h_wts[21,158]=-9.96399658593495e-002;
    __statist_i_h_wts[21,159]=-1.31283013948704e-001;
    __statist_i_h_wts[21,160]=-2.21229481193922e-001;
    __statist_i_h_wts[21,161]=-3.40890181978413e-001;
    __statist_i_h_wts[21,162]=-3.64196617416151e-001;
    __statist_i_h_wts[21,163]=-3.91235128306185e-001;
    __statist_i_h_wts[21,164]=-3.76565223930213e-001;
    __statist_i_h_wts[21,165]=2.67836268849376e-001;
    __statist_i_h_wts[21,166]=2.61609952076182e-001;
    __statist_i_h_wts[21,167]=2.48768606418962e-001;
    __statist_i_h_wts[21,168]=2.40865024532254e-001;
    __statist_i_h_wts[21,169]=1.62113760882784e-001;
    __statist_i_h_wts[21,170]=8.19488936106388e-002;
    __statist_i_h_wts[21,171]=6.27176888802827e-003;
    __statist_i_h_wts[21,172]=-5.71096597236515e-002;
    __statist_i_h_wts[21,173]=-1.15030012868462e-001;
    __statist_i_h_wts[21,174]=-1.64471792408031e-001;
    __statist_i_h_wts[21,175]=-2.32588386201449e-001;
    __statist_i_h_wts[21,176]=-3.28736006291998e-001;
    __statist_i_h_wts[21,177]=-3.54297057704506e-001;
    __statist_i_h_wts[21,178]=-3.46923005648654e-001;
    __statist_i_h_wts[21,179]=-3.66678881726117e-001;
    __statist_i_h_wts[21,180]=2.30474218326059e-001;
    __statist_i_h_wts[21,181]=2.62805025437883e-001;
    __statist_i_h_wts[21,182]=2.24863669355842e-001;
    __statist_i_h_wts[21,183]=2.04361560539879e-001;
    __statist_i_h_wts[21,184]=1.49174169270213e-001;
    __statist_i_h_wts[21,185]=7.01708916499948e-002;
    __statist_i_h_wts[21,186]=2.36532294779030e-002;
    __statist_i_h_wts[21,187]=-3.25463394163014e-002;
    __statist_i_h_wts[21,188]=-9.98508779061776e-002;
    __statist_i_h_wts[21,189]=-1.29457138042388e-001;
    __statist_i_h_wts[21,190]=-1.70673236468100e-001;
    __statist_i_h_wts[21,191]=-2.79008178221400e-001;
    __statist_i_h_wts[21,192]=-3.16963621861338e-001;
    __statist_i_h_wts[21,193]=-3.37087558314568e-001;
    __statist_i_h_wts[21,194]=-3.55036850480273e-001;
    __statist_i_h_wts[21,195]=2.06021865739752e-001;
    __statist_i_h_wts[21,196]=1.93191821332548e-001;
    __statist_i_h_wts[21,197]=1.78101364101105e-001;
    __statist_i_h_wts[21,198]=1.87235868652341e-001;
    __statist_i_h_wts[21,199]=1.26543698621783e-001;
    __statist_i_h_wts[21,200]=7.20142641302465e-002;
    __statist_i_h_wts[21,201]=2.56213424991115e-002;
    __statist_i_h_wts[21,202]=-1.09362994653848e-002;
    __statist_i_h_wts[21,203]=-6.27309342124524e-002;
    __statist_i_h_wts[21,204]=-9.99587677622986e-002;
    __statist_i_h_wts[21,205]=-1.36842480961112e-001;
    __statist_i_h_wts[21,206]=-2.46905277741021e-001;
    __statist_i_h_wts[21,207]=-2.74844428443966e-001;
    __statist_i_h_wts[21,208]=-2.97512442183665e-001;
    __statist_i_h_wts[21,209]=-2.82025206457231e-001;
    __statist_i_h_wts[21,210]=1.37039571929769e-001;
    __statist_i_h_wts[21,211]=1.58476886624491e-001;
    __statist_i_h_wts[21,212]=1.68008784874612e-001;
    __statist_i_h_wts[21,213]=1.42961300813380e-001;
    __statist_i_h_wts[21,214]=1.01635170709285e-001;
    __statist_i_h_wts[21,215]=6.09242084225018e-002;
    __statist_i_h_wts[21,216]=4.09782761235053e-002;
    __statist_i_h_wts[21,217]=2.95311408494998e-003;
    __statist_i_h_wts[21,218]=-6.82183015647460e-002;
    __statist_i_h_wts[21,219]=-1.07793139733408e-001;
    __statist_i_h_wts[21,220]=-1.27223913764822e-001;
    __statist_i_h_wts[21,221]=-2.00408105226173e-001;
    __statist_i_h_wts[21,222]=-2.37979129445699e-001;
    __statist_i_h_wts[21,223]=-2.61984754286087e-001;
    __statist_i_h_wts[21,224]=-2.30474492831260e-001;
    __statist_i_h_wts[21,225]=9.39481309689686e-002;
    __statist_i_h_wts[21,226]=-4.20012019524377e-001;
    __statist_i_h_wts[21,227]=1.21830820622518e-002;
    __statist_i_h_wts[21,228]=-4.73702186179532e-001;
    __statist_i_h_wts[21,229]=-7.22109437638640e-003;
    __statist_i_h_wts[21,230]=7.78464824297339e-001;
    __statist_i_h_wts[21,231]=2.67166803618773e-001;
    __statist_i_h_wts[21,232]=8.56700532416465e-001;
    __statist_i_h_wts[21,233]=3.34479450599372e-001;
    __statist_i_h_wts[21,234]=1.04912619452620e+000;
    __statist_i_h_wts[21,235]=-1.28702949158520e-002;
    __statist_i_h_wts[21,236]=-5.69716790597892e-001;
    __statist_i_h_wts[21,237]=-1.61781421266624e+000;
    __statist_i_h_wts[21,238]=-4.92596781447020e-001;
    __statist_i_h_wts[21,239]=7.31101706810465e-001;
    __statist_i_h_wts[21,240]=-8.30767006527037e-002;
    __statist_i_h_wts[21,241]=1.06371892747835e+000;
    __statist_i_h_wts[21,242]=-8.84089544926349e-002;
    __statist_i_h_wts[21,243]=5.60851612323147e-001;
    __statist_i_h_wts[21,244]=5.41888881982442e-002;
    __statist_i_h_wts[21,245]=-7.80095394966917e-001;
    __statist_i_h_wts[21,246]=9.55210605356600e-002;
    __statist_i_h_wts[21,247]=-7.62345952443557e-001;
    __statist_i_h_wts[21,248]=-1.89722327619984e-001;

    __statist_i_h_wts[22,0]=2.22149072848601e-001;
    __statist_i_h_wts[22,1]=1.98428386706439e-001;
    __statist_i_h_wts[22,2]=1.55081009554789e-001;
    __statist_i_h_wts[22,3]=1.75837291667932e-001;
    __statist_i_h_wts[22,4]=1.32097557290378e-001;
    __statist_i_h_wts[22,5]=1.19361033416690e-001;
    __statist_i_h_wts[22,6]=8.17457634074650e-002;
    __statist_i_h_wts[22,7]=7.29170022043101e-002;
    __statist_i_h_wts[22,8]=6.94143473821827e-002;
    __statist_i_h_wts[22,9]=2.64827328459715e-002;
    __statist_i_h_wts[22,10]=6.18530562459616e-002;
    __statist_i_h_wts[22,11]=4.05252344014809e-002;
    __statist_i_h_wts[22,12]=6.64492168865338e-002;
    __statist_i_h_wts[22,13]=5.97502261942648e-003;
    __statist_i_h_wts[22,14]=3.83947646087082e-004;
    __statist_i_h_wts[22,15]=2.22323226675146e-001;
    __statist_i_h_wts[22,16]=2.21795034396361e-001;
    __statist_i_h_wts[22,17]=1.87821312160221e-001;
    __statist_i_h_wts[22,18]=2.23092167954243e-001;
    __statist_i_h_wts[22,19]=1.66079982811658e-001;
    __statist_i_h_wts[22,20]=1.31128034325947e-001;
    __statist_i_h_wts[22,21]=9.86359255603586e-002;
    __statist_i_h_wts[22,22]=5.06691396931345e-002;
    __statist_i_h_wts[22,23]=5.08125547541819e-002;
    __statist_i_h_wts[22,24]=1.92285692550918e-002;
    __statist_i_h_wts[22,25]=3.58736434223322e-002;
    __statist_i_h_wts[22,26]=-2.30585180867725e-002;
    __statist_i_h_wts[22,27]=-3.18857755034983e-003;
    __statist_i_h_wts[22,28]=-3.57846508214605e-002;
    __statist_i_h_wts[22,29]=-2.98080796298679e-002;
    __statist_i_h_wts[22,30]=1.75817306016533e-001;
    __statist_i_h_wts[22,31]=1.88241232876452e-001;
    __statist_i_h_wts[22,32]=1.87752555949260e-001;
    __statist_i_h_wts[22,33]=1.87524811325311e-001;
    __statist_i_h_wts[22,34]=1.43541590904182e-001;
    __statist_i_h_wts[22,35]=1.05977246760763e-001;
    __statist_i_h_wts[22,36]=4.58538684081657e-002;
    __statist_i_h_wts[22,37]=-1.83559111723804e-002;
    __statist_i_h_wts[22,38]=-9.35984807390706e-003;
    __statist_i_h_wts[22,39]=-4.30004661044780e-002;
    __statist_i_h_wts[22,40]=-2.84023129083747e-002;
    __statist_i_h_wts[22,41]=-4.41316348816055e-002;
    __statist_i_h_wts[22,42]=-4.28058073340874e-002;
    __statist_i_h_wts[22,43]=-3.45093973973825e-002;
    __statist_i_h_wts[22,44]=-3.30772243113611e-002;
    __statist_i_h_wts[22,45]=1.93621588147891e-001;
    __statist_i_h_wts[22,46]=1.40479392042641e-001;
    __statist_i_h_wts[22,47]=1.54980225417525e-001;
    __statist_i_h_wts[22,48]=1.61259011377914e-001;
    __statist_i_h_wts[22,49]=1.38562695210500e-001;
    __statist_i_h_wts[22,50]=6.37228148238229e-002;
    __statist_i_h_wts[22,51]=4.65612225813479e-002;
    __statist_i_h_wts[22,52]=-3.74372906323090e-002;
    __statist_i_h_wts[22,53]=-6.72842370451788e-002;
    __statist_i_h_wts[22,54]=-9.69605979545976e-002;
    __statist_i_h_wts[22,55]=-7.02737358391243e-002;
    __statist_i_h_wts[22,56]=-7.65930666067707e-002;
    __statist_i_h_wts[22,57]=-3.96479396835466e-002;
    __statist_i_h_wts[22,58]=-7.15185519288414e-002;
    __statist_i_h_wts[22,59]=-4.17807187614061e-002;
    __statist_i_h_wts[22,60]=2.07774345487062e-001;
    __statist_i_h_wts[22,61]=1.69227067345827e-001;
    __statist_i_h_wts[22,62]=1.58437919930368e-001;
    __statist_i_h_wts[22,63]=1.50730225497793e-001;
    __statist_i_h_wts[22,64]=8.07542881990452e-002;
    __statist_i_h_wts[22,65]=5.71528441247212e-002;
    __statist_i_h_wts[22,66]=1.56434434775481e-002;
    __statist_i_h_wts[22,67]=-7.75885172295601e-002;
    __statist_i_h_wts[22,68]=-5.05448670998317e-002;
    __statist_i_h_wts[22,69]=-1.05829663009439e-001;
    __statist_i_h_wts[22,70]=-6.14882321659377e-002;
    __statist_i_h_wts[22,71]=-9.37001088073304e-002;
    __statist_i_h_wts[22,72]=-6.06309342148377e-002;
    __statist_i_h_wts[22,73]=-8.97981980060499e-002;
    __statist_i_h_wts[22,74]=-6.79800929936142e-002;
    __statist_i_h_wts[22,75]=1.64393386379938e-001;
    __statist_i_h_wts[22,76]=1.69933309971145e-001;
    __statist_i_h_wts[22,77]=1.71928578809031e-001;
    __statist_i_h_wts[22,78]=1.48567370353336e-001;
    __statist_i_h_wts[22,79]=1.10283096529938e-001;
    __statist_i_h_wts[22,80]=7.38911368578588e-002;
    __statist_i_h_wts[22,81]=4.99804961625064e-002;
    __statist_i_h_wts[22,82]=-2.81057473327786e-002;
    __statist_i_h_wts[22,83]=-8.51843493138520e-002;
    __statist_i_h_wts[22,84]=-1.47447928180924e-001;
    __statist_i_h_wts[22,85]=-1.47362874872390e-001;
    __statist_i_h_wts[22,86]=-1.15169124458483e-001;
    __statist_i_h_wts[22,87]=-1.21948522282271e-001;
    __statist_i_h_wts[22,88]=-1.24493044620667e-001;
    __statist_i_h_wts[22,89]=-9.97431962008295e-002;
    __statist_i_h_wts[22,90]=2.32060559760037e-001;
    __statist_i_h_wts[22,91]=1.68640219177891e-001;
    __statist_i_h_wts[22,92]=1.45294031106206e-001;
    __statist_i_h_wts[22,93]=9.28919651603269e-002;
    __statist_i_h_wts[22,94]=7.90715875730659e-002;
    __statist_i_h_wts[22,95]=3.08526284162723e-002;
    __statist_i_h_wts[22,96]=4.47881626963293e-002;
    __statist_i_h_wts[22,97]=-2.25711742804164e-002;
    __statist_i_h_wts[22,98]=-6.26816707550012e-002;
    __statist_i_h_wts[22,99]=-1.55619043751467e-001;
    __statist_i_h_wts[22,100]=-1.76303106980765e-001;
    __statist_i_h_wts[22,101]=-1.28316343360026e-001;
    __statist_i_h_wts[22,102]=-1.25765480135394e-001;
    __statist_i_h_wts[22,103]=-1.18439821254130e-001;
    __statist_i_h_wts[22,104]=-8.75226169685342e-002;
    __statist_i_h_wts[22,105]=2.40611346543722e-001;
    __statist_i_h_wts[22,106]=1.74498394306963e-001;
    __statist_i_h_wts[22,107]=1.42340084473198e-001;
    __statist_i_h_wts[22,108]=1.21662895334096e-001;
    __statist_i_h_wts[22,109]=8.28667395281533e-002;
    __statist_i_h_wts[22,110]=1.90971175255823e-002;
    __statist_i_h_wts[22,111]=2.95432480280394e-002;
    __statist_i_h_wts[22,112]=-2.48167774351063e-002;
    __statist_i_h_wts[22,113]=-7.20067343043174e-002;
    __statist_i_h_wts[22,114]=-1.37030371273017e-001;
    __statist_i_h_wts[22,115]=-1.34784673595692e-001;
    __statist_i_h_wts[22,116]=-9.72021082519323e-002;
    __statist_i_h_wts[22,117]=-9.48815999115302e-002;
    __statist_i_h_wts[22,118]=-6.60510447193359e-002;
    __statist_i_h_wts[22,119]=-6.95525548836634e-002;
    __statist_i_h_wts[22,120]=1.84455375459305e-001;
    __statist_i_h_wts[22,121]=1.76212473144426e-001;
    __statist_i_h_wts[22,122]=1.34687837725398e-001;
    __statist_i_h_wts[22,123]=6.12214124169188e-002;
    __statist_i_h_wts[22,124]=1.59133813922791e-002;
    __statist_i_h_wts[22,125]=5.22271923156463e-003;
    __statist_i_h_wts[22,126]=-1.36009425337722e-002;
    __statist_i_h_wts[22,127]=-3.57628150164072e-002;
    __statist_i_h_wts[22,128]=-1.91290440598319e-002;
    __statist_i_h_wts[22,129]=-1.11455201825922e-001;
    __statist_i_h_wts[22,130]=-1.49048705870336e-001;
    __statist_i_h_wts[22,131]=-1.26902212207457e-001;
    __statist_i_h_wts[22,132]=-1.12331514682447e-001;
    __statist_i_h_wts[22,133]=-1.13110993170483e-001;
    __statist_i_h_wts[22,134]=-7.75674315575674e-002;
    __statist_i_h_wts[22,135]=1.44127973636759e-001;
    __statist_i_h_wts[22,136]=1.24226052554292e-001;
    __statist_i_h_wts[22,137]=1.02635835249670e-001;
    __statist_i_h_wts[22,138]=5.73558221134751e-002;
    __statist_i_h_wts[22,139]=5.84796473692216e-002;
    __statist_i_h_wts[22,140]=-4.79031487309631e-003;
    __statist_i_h_wts[22,141]=2.10794538684442e-002;
    __statist_i_h_wts[22,142]=1.04715787840804e-002;
    __statist_i_h_wts[22,143]=1.30322966089353e-002;
    __statist_i_h_wts[22,144]=-5.19871183832042e-002;
    __statist_i_h_wts[22,145]=-9.65512377688031e-002;
    __statist_i_h_wts[22,146]=-1.13752677354180e-001;
    __statist_i_h_wts[22,147]=-9.83666023265581e-002;
    __statist_i_h_wts[22,148]=-9.89244529676511e-002;
    __statist_i_h_wts[22,149]=-7.29450778677639e-002;
    __statist_i_h_wts[22,150]=1.71818625557780e-001;
    __statist_i_h_wts[22,151]=1.47653162002789e-001;
    __statist_i_h_wts[22,152]=1.14448730720027e-001;
    __statist_i_h_wts[22,153]=1.29848899486839e-001;
    __statist_i_h_wts[22,154]=5.84243505948085e-002;
    __statist_i_h_wts[22,155]=6.94312437526436e-003;
    __statist_i_h_wts[22,156]=2.42116645391107e-002;
    __statist_i_h_wts[22,157]=5.54837361137230e-003;
    __statist_i_h_wts[22,158]=-5.84697665359904e-003;
    __statist_i_h_wts[22,159]=-4.55914443989017e-002;
    __statist_i_h_wts[22,160]=-8.25939187123968e-002;
    __statist_i_h_wts[22,161]=-1.01698716790491e-001;
    __statist_i_h_wts[22,162]=-1.10059876673493e-001;
    __statist_i_h_wts[22,163]=-7.75035407577394e-002;
    __statist_i_h_wts[22,164]=-5.25455426327446e-002;
    __statist_i_h_wts[22,165]=1.34575531393070e-001;
    __statist_i_h_wts[22,166]=1.02638502667538e-001;
    __statist_i_h_wts[22,167]=1.00014444672716e-001;
    __statist_i_h_wts[22,168]=1.04208628702993e-001;
    __statist_i_h_wts[22,169]=5.43566009870805e-002;
    __statist_i_h_wts[22,170]=1.04839722717893e-002;
    __statist_i_h_wts[22,171]=2.30953833440332e-002;
    __statist_i_h_wts[22,172]=-8.34793532750917e-003;
    __statist_i_h_wts[22,173]=-1.45340309909493e-002;
    __statist_i_h_wts[22,174]=-7.22277133977369e-002;
    __statist_i_h_wts[22,175]=-8.43648162109293e-002;
    __statist_i_h_wts[22,176]=-8.40885461379093e-002;
    __statist_i_h_wts[22,177]=-7.07867036774154e-002;
    __statist_i_h_wts[22,178]=-5.99749779921521e-002;
    __statist_i_h_wts[22,179]=-7.65119006386429e-002;
    __statist_i_h_wts[22,180]=1.20869436498611e-001;
    __statist_i_h_wts[22,181]=1.08420671372415e-001;
    __statist_i_h_wts[22,182]=8.29173224582348e-002;
    __statist_i_h_wts[22,183]=7.49005398019960e-002;
    __statist_i_h_wts[22,184]=4.60753923275799e-002;
    __statist_i_h_wts[22,185]=1.79183740807250e-002;
    __statist_i_h_wts[22,186]=2.10622807809417e-002;
    __statist_i_h_wts[22,187]=-1.15593205043063e-002;
    __statist_i_h_wts[22,188]=-3.76443781063319e-002;
    __statist_i_h_wts[22,189]=-4.59558235659734e-002;
    __statist_i_h_wts[22,190]=-4.40711328836852e-002;
    __statist_i_h_wts[22,191]=-7.92268448102594e-002;
    __statist_i_h_wts[22,192]=-6.97250359678785e-002;
    __statist_i_h_wts[22,193]=-1.02742279380331e-001;
    __statist_i_h_wts[22,194]=-9.24149997309529e-002;
    __statist_i_h_wts[22,195]=1.22678116748437e-001;
    __statist_i_h_wts[22,196]=1.07270603784544e-001;
    __statist_i_h_wts[22,197]=9.71994550444228e-002;
    __statist_i_h_wts[22,198]=1.10733869875145e-001;
    __statist_i_h_wts[22,199]=8.26697513522001e-002;
    __statist_i_h_wts[22,200]=6.74901178864032e-002;
    __statist_i_h_wts[22,201]=6.27706051112594e-002;
    __statist_i_h_wts[22,202]=2.71537699200183e-002;
    __statist_i_h_wts[22,203]=7.45166961003589e-003;
    __statist_i_h_wts[22,204]=1.19292059161015e-002;
    __statist_i_h_wts[22,205]=8.73769924814957e-003;
    __statist_i_h_wts[22,206]=-2.92959469147823e-002;
    __statist_i_h_wts[22,207]=-5.58442895671388e-002;
    __statist_i_h_wts[22,208]=-9.55190141405025e-002;
    __statist_i_h_wts[22,209]=-5.03031381242323e-002;
    __statist_i_h_wts[22,210]=1.00043692931386e-001;
    __statist_i_h_wts[22,211]=9.22220868618179e-002;
    __statist_i_h_wts[22,212]=1.22916414398781e-001;
    __statist_i_h_wts[22,213]=8.58904102210338e-002;
    __statist_i_h_wts[22,214]=7.29315172825707e-002;
    __statist_i_h_wts[22,215]=5.86694470534813e-002;
    __statist_i_h_wts[22,216]=6.16711781815234e-002;
    __statist_i_h_wts[22,217]=4.07705237075391e-002;
    __statist_i_h_wts[22,218]=2.85986449945070e-002;
    __statist_i_h_wts[22,219]=1.43925089420933e-003;
    __statist_i_h_wts[22,220]=2.47007963792323e-002;
    __statist_i_h_wts[22,221]=-4.05161265145609e-003;
    __statist_i_h_wts[22,222]=-4.09793469963574e-002;
    __statist_i_h_wts[22,223]=-6.18445108561862e-002;
    __statist_i_h_wts[22,224]=-4.68896650595612e-002;
    __statist_i_h_wts[22,225]=9.18886645347572e-002;
    __statist_i_h_wts[22,226]=-1.16360053634460e-001;
    __statist_i_h_wts[22,227]=6.73697961913486e-002;
    __statist_i_h_wts[22,228]=-1.27495917011979e-001;
    __statist_i_h_wts[22,229]=9.72214354082202e-002;
    __statist_i_h_wts[22,230]=4.37011500999332e-001;
    __statist_i_h_wts[22,231]=2.24448383762550e-001;
    __statist_i_h_wts[22,232]=5.44090648166003e-001;
    __statist_i_h_wts[22,233]=1.72246765494623e-001;
    __statist_i_h_wts[22,234]=6.74160703809081e-001;
    __statist_i_h_wts[22,235]=-4.99785791445821e-003;
    __statist_i_h_wts[22,236]=-1.87866109421023e-001;
    __statist_i_h_wts[22,237]=-1.02179380780071e+000;
    __statist_i_h_wts[22,238]=-3.13605645232554e-001;
    __statist_i_h_wts[22,239]=3.54015295518240e-001;
    __statist_i_h_wts[22,240]=1.71156172753597e-002;
    __statist_i_h_wts[22,241]=5.96076227975622e-001;
    __statist_i_h_wts[22,242]=-4.33155703932459e-002;
    __statist_i_h_wts[22,243]=2.18024708878853e-001;
    __statist_i_h_wts[22,244]=2.29630501252680e-002;
    __statist_i_h_wts[22,245]=-3.43278678383931e-001;
    __statist_i_h_wts[22,246]=1.09012187183130e-001;
    __statist_i_h_wts[22,247]=-3.03695197089748e-001;
    __statist_i_h_wts[22,248]=-8.79958292649164e-002;

    __statist_i_h_wts[23,0]=4.09509781612051e-002;
    __statist_i_h_wts[23,1]=-6.07643892828783e-002;
    __statist_i_h_wts[23,2]=-1.69477848522126e-001;
    __statist_i_h_wts[23,3]=-2.02656018313856e-001;
    __statist_i_h_wts[23,4]=-1.63381391197885e-001;
    __statist_i_h_wts[23,5]=-1.54727245027669e-001;
    __statist_i_h_wts[23,6]=-7.81387350167612e-002;
    __statist_i_h_wts[23,7]=1.69504763525997e-002;
    __statist_i_h_wts[23,8]=9.41392075631983e-003;
    __statist_i_h_wts[23,9]=3.53621606066203e-002;
    __statist_i_h_wts[23,10]=3.00146562783084e-003;
    __statist_i_h_wts[23,11]=3.18201699228116e-002;
    __statist_i_h_wts[23,12]=1.46692250482515e-001;
    __statist_i_h_wts[23,13]=9.30300887913982e-002;
    __statist_i_h_wts[23,14]=4.17824744395749e-002;
    __statist_i_h_wts[23,15]=2.76956944029075e-002;
    __statist_i_h_wts[23,16]=-1.05467853005319e-001;
    __statist_i_h_wts[23,17]=-2.16916962002327e-001;
    __statist_i_h_wts[23,18]=-3.14528780069186e-001;
    __statist_i_h_wts[23,19]=-2.26618665614000e-001;
    __statist_i_h_wts[23,20]=-1.17816406264397e-001;
    __statist_i_h_wts[23,21]=-6.41525816526633e-002;
    __statist_i_h_wts[23,22]=9.17618592518427e-002;
    __statist_i_h_wts[23,23]=8.63595770617603e-002;
    __statist_i_h_wts[23,24]=1.77132844245944e-001;
    __statist_i_h_wts[23,25]=4.98111672021225e-002;
    __statist_i_h_wts[23,26]=6.85406616376891e-002;
    __statist_i_h_wts[23,27]=1.63457597603556e-001;
    __statist_i_h_wts[23,28]=1.07600648940198e-001;
    __statist_i_h_wts[23,29]=3.45906705382193e-002;
    __statist_i_h_wts[23,30]=-4.55874901465060e-002;
    __statist_i_h_wts[23,31]=-1.86392906107000e-001;
    __statist_i_h_wts[23,32]=-2.55294079940363e-001;
    __statist_i_h_wts[23,33]=-4.24842933575265e-001;
    __statist_i_h_wts[23,34]=-2.81888790183132e-001;
    __statist_i_h_wts[23,35]=-1.61889483646306e-001;
    __statist_i_h_wts[23,36]=-1.48426120953909e-001;
    __statist_i_h_wts[23,37]=3.14795091044778e-002;
    __statist_i_h_wts[23,38]=3.51735940904758e-002;
    __statist_i_h_wts[23,39]=1.05954500326017e-001;
    __statist_i_h_wts[23,40]=9.82187319004244e-002;
    __statist_i_h_wts[23,41]=1.08148724791515e-001;
    __statist_i_h_wts[23,42]=1.18833490940100e-001;
    __statist_i_h_wts[23,43]=1.19212347379472e-001;
    __statist_i_h_wts[23,44]=6.31197477351247e-002;
    __statist_i_h_wts[23,45]=-1.22753059758371e-001;
    __statist_i_h_wts[23,46]=-1.94376683996595e-001;
    __statist_i_h_wts[23,47]=-1.87549496307102e-001;
    __statist_i_h_wts[23,48]=-3.09500794329646e-001;
    __statist_i_h_wts[23,49]=-7.53656381766855e-002;
    __statist_i_h_wts[23,50]=-5.75810099165418e-002;
    __statist_i_h_wts[23,51]=1.64083973298799e-002;
    __statist_i_h_wts[23,52]=7.03691495470522e-002;
    __statist_i_h_wts[23,53]=1.40755475664022e-001;
    __statist_i_h_wts[23,54]=1.43523752816544e-001;
    __statist_i_h_wts[23,55]=1.53669347174585e-001;
    __statist_i_h_wts[23,56]=9.43372989987143e-002;
    __statist_i_h_wts[23,57]=1.51027756844739e-001;
    __statist_i_h_wts[23,58]=1.62720883757454e-001;
    __statist_i_h_wts[23,59]=1.15568814221429e-001;
    __statist_i_h_wts[23,60]=-1.25021817955365e-001;
    __statist_i_h_wts[23,61]=-1.42907301775845e-001;
    __statist_i_h_wts[23,62]=-1.47482551818134e-001;
    __statist_i_h_wts[23,63]=-2.18671346520336e-001;
    __statist_i_h_wts[23,64]=-1.14916528484279e-001;
    __statist_i_h_wts[23,65]=-9.55075740586826e-002;
    __statist_i_h_wts[23,66]=6.87384353233986e-002;
    __statist_i_h_wts[23,67]=1.54419837673003e-001;
    __statist_i_h_wts[23,68]=2.45296386594524e-001;
    __statist_i_h_wts[23,69]=2.11772651271657e-001;
    __statist_i_h_wts[23,70]=2.25921880884333e-001;
    __statist_i_h_wts[23,71]=1.52965552833016e-001;
    __statist_i_h_wts[23,72]=2.01739958571940e-001;
    __statist_i_h_wts[23,73]=1.43450900293819e-001;
    __statist_i_h_wts[23,74]=1.03697848976629e-001;
    __statist_i_h_wts[23,75]=-1.97605278309134e-001;
    __statist_i_h_wts[23,76]=-1.85189473281363e-001;
    __statist_i_h_wts[23,77]=-1.90700543379940e-001;
    __statist_i_h_wts[23,78]=-1.97188269358973e-001;
    __statist_i_h_wts[23,79]=-1.33165831093581e-001;
    __statist_i_h_wts[23,80]=-1.76128149875094e-001;
    __statist_i_h_wts[23,81]=-1.61389218996415e-002;
    __statist_i_h_wts[23,82]=5.56045803360272e-002;
    __statist_i_h_wts[23,83]=1.52521261743716e-001;
    __statist_i_h_wts[23,84]=2.11471904634325e-001;
    __statist_i_h_wts[23,85]=2.29891136867186e-001;
    __statist_i_h_wts[23,86]=2.01841564636028e-001;
    __statist_i_h_wts[23,87]=2.24870968726202e-001;
    __statist_i_h_wts[23,88]=2.01044506589484e-001;
    __statist_i_h_wts[23,89]=1.20352963714237e-001;
    __statist_i_h_wts[23,90]=-2.04854091888098e-001;
    __statist_i_h_wts[23,91]=-2.04198503273938e-001;
    __statist_i_h_wts[23,92]=-2.06945289783122e-001;
    __statist_i_h_wts[23,93]=-1.88147705053203e-001;
    __statist_i_h_wts[23,94]=-1.31346151156994e-001;
    __statist_i_h_wts[23,95]=-8.81582903944937e-002;
    __statist_i_h_wts[23,96]=-1.83494883144534e-001;
    __statist_i_h_wts[23,97]=-9.01438643801158e-002;
    __statist_i_h_wts[23,98]=1.37324606140340e-001;
    __statist_i_h_wts[23,99]=1.83761075935599e-001;
    __statist_i_h_wts[23,100]=1.95865691719522e-001;
    __statist_i_h_wts[23,101]=1.60936511224601e-001;
    __statist_i_h_wts[23,102]=2.24515473136587e-001;
    __statist_i_h_wts[23,103]=2.03100110927893e-001;
    __statist_i_h_wts[23,104]=1.88748072266395e-001;
    __statist_i_h_wts[23,105]=-1.71961266235484e-001;
    __statist_i_h_wts[23,106]=-1.75619483620455e-001;
    __statist_i_h_wts[23,107]=-1.51771521069700e-001;
    __statist_i_h_wts[23,108]=-1.71738836287713e-001;
    __statist_i_h_wts[23,109]=-1.05058691445785e-001;
    __statist_i_h_wts[23,110]=-6.44015237822440e-002;
    __statist_i_h_wts[23,111]=-1.32544232896267e-001;
    __statist_i_h_wts[23,112]=-6.21865001329998e-002;
    __statist_i_h_wts[23,113]=1.06707933002418e-001;
    __statist_i_h_wts[23,114]=1.75901293549158e-001;
    __statist_i_h_wts[23,115]=2.56316539000718e-001;
    __statist_i_h_wts[23,116]=2.04814665971828e-001;
    __statist_i_h_wts[23,117]=2.70060067857704e-001;
    __statist_i_h_wts[23,118]=2.55427062371890e-001;
    __statist_i_h_wts[23,119]=1.84681064827692e-001;
    __statist_i_h_wts[23,120]=-1.62612671694024e-001;
    __statist_i_h_wts[23,121]=-1.63605929488375e-001;
    __statist_i_h_wts[23,122]=-1.63180835593670e-001;
    __statist_i_h_wts[23,123]=-1.21763075260875e-001;
    __statist_i_h_wts[23,124]=-3.74813525407497e-002;
    __statist_i_h_wts[23,125]=6.12569457448449e-003;
    __statist_i_h_wts[23,126]=9.15096652487850e-003;
    __statist_i_h_wts[23,127]=7.57584767437133e-002;
    __statist_i_h_wts[23,128]=1.57853222450987e-001;
    __statist_i_h_wts[23,129]=1.23397363584128e-001;
    __statist_i_h_wts[23,130]=1.84895324582059e-001;
    __statist_i_h_wts[23,131]=1.14678706818696e-001;
    __statist_i_h_wts[23,132]=1.57659064375664e-001;
    __statist_i_h_wts[23,133]=1.48751224596587e-001;
    __statist_i_h_wts[23,134]=1.34059372374253e-001;
    __statist_i_h_wts[23,135]=-1.13614640877933e-001;
    __statist_i_h_wts[23,136]=-1.23116877532334e-001;
    __statist_i_h_wts[23,137]=-1.20229868688785e-001;
    __statist_i_h_wts[23,138]=-8.35966870578682e-002;
    __statist_i_h_wts[23,139]=3.15605110893316e-002;
    __statist_i_h_wts[23,140]=-5.29807984021264e-002;
    __statist_i_h_wts[23,141]=-4.77902193686719e-002;
    __statist_i_h_wts[23,142]=1.41388678981754e-002;
    __statist_i_h_wts[23,143]=1.16626900857433e-001;
    __statist_i_h_wts[23,144]=8.61963785076882e-002;
    __statist_i_h_wts[23,145]=8.99584979615554e-002;
    __statist_i_h_wts[23,146]=2.99565020007386e-002;
    __statist_i_h_wts[23,147]=1.46691567285374e-001;
    __statist_i_h_wts[23,148]=2.62067000851647e-001;
    __statist_i_h_wts[23,149]=1.99617373039338e-001;
    __statist_i_h_wts[23,150]=-7.52096106996564e-002;
    __statist_i_h_wts[23,151]=-1.02593326931183e-001;
    __statist_i_h_wts[23,152]=-1.20169825217175e-001;
    __statist_i_h_wts[23,153]=-1.17138214452338e-001;
    __statist_i_h_wts[23,154]=-6.97747644333696e-002;
    __statist_i_h_wts[23,155]=-4.82461327913363e-002;
    __statist_i_h_wts[23,156]=-8.01255980390550e-002;
    __statist_i_h_wts[23,157]=2.21099115038765e-002;
    __statist_i_h_wts[23,158]=1.26031969868374e-001;
    __statist_i_h_wts[23,159]=1.48609978298598e-001;
    __statist_i_h_wts[23,160]=1.81882709924622e-001;
    __statist_i_h_wts[23,161]=1.90102290280329e-001;
    __statist_i_h_wts[23,162]=2.50970102184610e-001;
    __statist_i_h_wts[23,163]=3.25722364293796e-001;
    __statist_i_h_wts[23,164]=2.14542226849224e-001;
    __statist_i_h_wts[23,165]=-9.57911030317916e-002;
    __statist_i_h_wts[23,166]=-1.19372636344414e-001;
    __statist_i_h_wts[23,167]=-9.03980797665624e-002;
    __statist_i_h_wts[23,168]=-1.28846728680823e-001;
    __statist_i_h_wts[23,169]=-9.10453336002947e-002;
    __statist_i_h_wts[23,170]=-5.87944194657054e-002;
    __statist_i_h_wts[23,171]=-5.39051477530859e-002;
    __statist_i_h_wts[23,172]=-7.03270860642475e-003;
    __statist_i_h_wts[23,173]=1.72983671585371e-002;
    __statist_i_h_wts[23,174]=1.10697388555010e-001;
    __statist_i_h_wts[23,175]=1.70134269570760e-001;
    __statist_i_h_wts[23,176]=2.26319912876326e-001;
    __statist_i_h_wts[23,177]=2.48862439054120e-001;
    __statist_i_h_wts[23,178]=3.58991802399021e-001;
    __statist_i_h_wts[23,179]=2.04461606033575e-001;
    __statist_i_h_wts[23,180]=-8.62117548644550e-002;
    __statist_i_h_wts[23,181]=-7.70448846877745e-002;
    __statist_i_h_wts[23,182]=-5.96650022993393e-002;
    __statist_i_h_wts[23,183]=-7.55842083269205e-002;
    __statist_i_h_wts[23,184]=-1.04853082254353e-001;
    __statist_i_h_wts[23,185]=-1.04885306390593e-001;
    __statist_i_h_wts[23,186]=3.01412027291679e-002;
    __statist_i_h_wts[23,187]=6.44406778867936e-002;
    __statist_i_h_wts[23,188]=1.57353515392410e-001;
    __statist_i_h_wts[23,189]=1.96943352330437e-001;
    __statist_i_h_wts[23,190]=2.61721950544687e-001;
    __statist_i_h_wts[23,191]=2.29944228543475e-001;
    __statist_i_h_wts[23,192]=2.13687308703503e-001;
    __statist_i_h_wts[23,193]=1.74410668957208e-001;
    __statist_i_h_wts[23,194]=7.71677035411702e-002;
    __statist_i_h_wts[23,195]=-1.10162304031265e-001;
    __statist_i_h_wts[23,196]=-1.04017491918422e-001;
    __statist_i_h_wts[23,197]=-1.27570194562061e-001;
    __statist_i_h_wts[23,198]=-9.55606279450429e-002;
    __statist_i_h_wts[23,199]=-1.17056625784284e-001;
    __statist_i_h_wts[23,200]=-1.06307596285184e-001;
    __statist_i_h_wts[23,201]=2.00678383645573e-002;
    __statist_i_h_wts[23,202]=6.95855162435327e-002;
    __statist_i_h_wts[23,203]=1.15655388479273e-001;
    __statist_i_h_wts[23,204]=1.21368163852483e-001;
    __statist_i_h_wts[23,205]=1.64315353067813e-001;
    __statist_i_h_wts[23,206]=8.90010397373321e-002;
    __statist_i_h_wts[23,207]=4.71502069686297e-002;
    __statist_i_h_wts[23,208]=9.73884428414412e-002;
    __statist_i_h_wts[23,209]=4.33686037432488e-002;
    __statist_i_h_wts[23,210]=-4.79158947280637e-002;
    __statist_i_h_wts[23,211]=4.04013142220442e-003;
    __statist_i_h_wts[23,212]=-5.15947223542608e-002;
    __statist_i_h_wts[23,213]=-2.71302280055724e-002;
    __statist_i_h_wts[23,214]=-5.66883478388527e-002;
    __statist_i_h_wts[23,215]=-6.33179055492721e-002;
    __statist_i_h_wts[23,216]=1.03368019866494e-002;
    __statist_i_h_wts[23,217]=3.06940274424634e-002;
    __statist_i_h_wts[23,218]=3.23074998159899e-002;
    __statist_i_h_wts[23,219]=5.98429367328673e-002;
    __statist_i_h_wts[23,220]=9.74126002808759e-002;
    __statist_i_h_wts[23,221]=8.28681383310939e-002;
    __statist_i_h_wts[23,222]=5.33771003349064e-002;
    __statist_i_h_wts[23,223]=4.44108328660915e-002;
    __statist_i_h_wts[23,224]=5.06988409323530e-002;
    __statist_i_h_wts[23,225]=-1.80572256959660e-001;
    __statist_i_h_wts[23,226]=1.07062407930112e-001;
    __statist_i_h_wts[23,227]=-1.28079045584074e-001;
    __statist_i_h_wts[23,228]=3.79478204840489e-002;
    __statist_i_h_wts[23,229]=-6.03729256000311e-002;
    __statist_i_h_wts[23,230]=-3.22913531327910e-002;
    __statist_i_h_wts[23,231]=3.04933874796633e-002;
    __statist_i_h_wts[23,232]=-1.61683328927853e-001;
    __statist_i_h_wts[23,233]=-1.24464792102261e-002;
    __statist_i_h_wts[23,234]=1.13999377227205e-001;
    __statist_i_h_wts[23,235]=1.20160747695499e-001;
    __statist_i_h_wts[23,236]=3.58189823941924e-001;
    __statist_i_h_wts[23,237]=-4.90401875504737e-001;
    __statist_i_h_wts[23,238]=-1.56768724124704e-001;
    __statist_i_h_wts[23,239]=-1.84561424969692e-001;
    __statist_i_h_wts[23,240]=1.74381382768305e-001;
    __statist_i_h_wts[23,241]=-6.20102665683314e-003;
    __statist_i_h_wts[23,242]=2.65434892398964e-002;
    __statist_i_h_wts[23,243]=-1.63514544928750e-001;
    __statist_i_h_wts[23,244]=1.11621989936798e-001;
    __statist_i_h_wts[23,245]=3.55436387762887e-001;
    __statist_i_h_wts[23,246]=8.73297133022395e-002;
    __statist_i_h_wts[23,247]=1.65844924426531e-001;
    __statist_i_h_wts[23,248]=-9.76181956831097e-002;

    __statist_i_h_wts[24,0]=-1.93945953442703e-001;
    __statist_i_h_wts[24,1]=-1.49248629233873e-001;
    __statist_i_h_wts[24,2]=-1.50399967116737e-001;
    __statist_i_h_wts[24,3]=-1.10662335076648e-001;
    __statist_i_h_wts[24,4]=-7.80683719489593e-002;
    __statist_i_h_wts[24,5]=-3.57303971139031e-002;
    __statist_i_h_wts[24,6]=-1.62067223394403e-002;
    __statist_i_h_wts[24,7]=-3.21615585602311e-002;
    __statist_i_h_wts[24,8]=-2.48914578241826e-002;
    __statist_i_h_wts[24,9]=1.85884661443238e-002;
    __statist_i_h_wts[24,10]=-5.09789994215349e-002;
    __statist_i_h_wts[24,11]=-6.19040619810853e-002;
    __statist_i_h_wts[24,12]=-4.42363159361336e-002;
    __statist_i_h_wts[24,13]=4.02958469532953e-002;
    __statist_i_h_wts[24,14]=9.92706019885596e-002;
    __statist_i_h_wts[24,15]=-2.16667854458915e-001;
    __statist_i_h_wts[24,16]=-1.91391105896497e-001;
    __statist_i_h_wts[24,17]=-2.28515848567346e-001;
    __statist_i_h_wts[24,18]=-2.09167077361449e-001;
    __statist_i_h_wts[24,19]=-1.70257662269904e-001;
    __statist_i_h_wts[24,20]=-1.42779642645332e-001;
    __statist_i_h_wts[24,21]=-1.11445018051089e-001;
    __statist_i_h_wts[24,22]=-8.60325978882943e-002;
    __statist_i_h_wts[24,23]=-6.89193818516397e-002;
    __statist_i_h_wts[24,24]=5.47137946487284e-003;
    __statist_i_h_wts[24,25]=-3.29577728199518e-002;
    __statist_i_h_wts[24,26]=5.31350898424572e-002;
    __statist_i_h_wts[24,27]=5.54115038049986e-002;
    __statist_i_h_wts[24,28]=6.88890140481266e-002;
    __statist_i_h_wts[24,29]=1.20728564471415e-001;
    __statist_i_h_wts[24,30]=-1.69499522766134e-001;
    __statist_i_h_wts[24,31]=-1.26839960133445e-001;
    __statist_i_h_wts[24,32]=-2.55734482288290e-001;
    __statist_i_h_wts[24,33]=-1.64317508826590e-001;
    __statist_i_h_wts[24,34]=-1.42288180320897e-001;
    __statist_i_h_wts[24,35]=-9.41379593401800e-002;
    __statist_i_h_wts[24,36]=-2.83513075286595e-002;
    __statist_i_h_wts[24,37]=-2.78307443097248e-002;
    __statist_i_h_wts[24,38]=-1.59826807606455e-002;
    __statist_i_h_wts[24,39]=2.99332150438217e-002;
    __statist_i_h_wts[24,40]=4.35730851264250e-002;
    __statist_i_h_wts[24,41]=7.16264186455796e-002;
    __statist_i_h_wts[24,42]=8.02659032375246e-002;
    __statist_i_h_wts[24,43]=6.42138464986972e-002;
    __statist_i_h_wts[24,44]=9.97125640135716e-002;
    __statist_i_h_wts[24,45]=-1.57553077586173e-001;
    __statist_i_h_wts[24,46]=-7.51631205634447e-002;
    __statist_i_h_wts[24,47]=-1.48228535117175e-001;
    __statist_i_h_wts[24,48]=-1.11086085773878e-001;
    __statist_i_h_wts[24,49]=-9.58656032115115e-002;
    __statist_i_h_wts[24,50]=1.42043289184488e-002;
    __statist_i_h_wts[24,51]=1.76802326279019e-002;
    __statist_i_h_wts[24,52]=5.40675884385777e-002;
    __statist_i_h_wts[24,53]=3.19239289919261e-002;
    __statist_i_h_wts[24,54]=1.15476882106154e-001;
    __statist_i_h_wts[24,55]=7.47449759974215e-002;
    __statist_i_h_wts[24,56]=8.97055770489444e-002;
    __statist_i_h_wts[24,57]=1.76915429049807e-002;
    __statist_i_h_wts[24,58]=8.20549503824366e-002;
    __statist_i_h_wts[24,59]=5.61478914028993e-002;
    __statist_i_h_wts[24,60]=-2.11576523558405e-001;
    __statist_i_h_wts[24,61]=-1.63378352218808e-001;
    __statist_i_h_wts[24,62]=-1.68939496068606e-001;
    __statist_i_h_wts[24,63]=-1.24807914195490e-001;
    __statist_i_h_wts[24,64]=-7.80685900770221e-002;
    __statist_i_h_wts[24,65]=-2.09120062177604e-002;
    __statist_i_h_wts[24,66]=3.34488978565524e-002;
    __statist_i_h_wts[24,67]=3.57601111447895e-002;
    __statist_i_h_wts[24,68]=2.11152585701398e-002;
    __statist_i_h_wts[24,69]=1.51923074223842e-001;
    __statist_i_h_wts[24,70]=2.96280888999808e-002;
    __statist_i_h_wts[24,71]=9.17425607221679e-002;
    __statist_i_h_wts[24,72]=6.54337857409464e-002;
    __statist_i_h_wts[24,73]=1.13847753321611e-001;
    __statist_i_h_wts[24,74]=6.42990614516946e-002;
    __statist_i_h_wts[24,75]=-1.50132458382879e-001;
    __statist_i_h_wts[24,76]=-1.58250709050494e-001;
    __statist_i_h_wts[24,77]=-2.10447808369061e-001;
    __statist_i_h_wts[24,78]=-1.63328275274731e-001;
    __statist_i_h_wts[24,79]=-1.71286857765749e-001;
    __statist_i_h_wts[24,80]=-1.43809069390610e-001;
    __statist_i_h_wts[24,81]=-8.64063426030254e-002;
    __statist_i_h_wts[24,82]=-2.70751506003370e-003;
    __statist_i_h_wts[24,83]=8.66569561806786e-002;
    __statist_i_h_wts[24,84]=1.68700918887679e-001;
    __statist_i_h_wts[24,85]=1.26656897641216e-001;
    __statist_i_h_wts[24,86]=1.02430133778146e-001;
    __statist_i_h_wts[24,87]=1.05833785241476e-001;
    __statist_i_h_wts[24,88]=8.41362784581202e-002;
    __statist_i_h_wts[24,89]=7.56823968056755e-002;
    __statist_i_h_wts[24,90]=-1.58016117214638e-001;
    __statist_i_h_wts[24,91]=-8.00769741193253e-002;
    __statist_i_h_wts[24,92]=-1.45895776919666e-001;
    __statist_i_h_wts[24,93]=-8.07595850904224e-002;
    __statist_i_h_wts[24,94]=-4.69680881283827e-002;
    __statist_i_h_wts[24,95]=-6.11422951876792e-002;
    __statist_i_h_wts[24,96]=-6.96188933697140e-002;
    __statist_i_h_wts[24,97]=9.66807312764400e-004;
    __statist_i_h_wts[24,98]=7.83979456027537e-002;
    __statist_i_h_wts[24,99]=1.57549491208420e-001;
    __statist_i_h_wts[24,100]=1.72846548786012e-001;
    __statist_i_h_wts[24,101]=8.28019825262414e-002;
    __statist_i_h_wts[24,102]=9.01117994262327e-002;
    __statist_i_h_wts[24,103]=1.30782099920646e-001;
    __statist_i_h_wts[24,104]=6.92849803112615e-002;
    __statist_i_h_wts[24,105]=-2.00230103190209e-001;
    __statist_i_h_wts[24,106]=-1.46928539467156e-001;
    __statist_i_h_wts[24,107]=-1.51755066841977e-001;
    __statist_i_h_wts[24,108]=-8.90178899363837e-002;
    __statist_i_h_wts[24,109]=-8.12086481401668e-002;
    __statist_i_h_wts[24,110]=-3.40970312863467e-002;
    __statist_i_h_wts[24,111]=-3.20451063332985e-002;
    __statist_i_h_wts[24,112]=1.61136428377570e-002;
    __statist_i_h_wts[24,113]=1.18784833021366e-001;
    __statist_i_h_wts[24,114]=1.98065047287642e-001;
    __statist_i_h_wts[24,115]=1.66006197027819e-001;
    __statist_i_h_wts[24,116]=7.31176749566368e-002;
    __statist_i_h_wts[24,117]=9.19273433288820e-002;
    __statist_i_h_wts[24,118]=7.87281876594765e-002;
    __statist_i_h_wts[24,119]=7.67296250531876e-002;
    __statist_i_h_wts[24,120]=-1.41533762244001e-001;
    __statist_i_h_wts[24,121]=-1.47830419343828e-001;
    __statist_i_h_wts[24,122]=-1.37546239363212e-001;
    __statist_i_h_wts[24,123]=-7.25112762159794e-002;
    __statist_i_h_wts[24,124]=-5.91025850531904e-002;
    __statist_i_h_wts[24,125]=-6.60816361961242e-002;
    __statist_i_h_wts[24,126]=-5.73078001371658e-002;
    __statist_i_h_wts[24,127]=-3.68002341004596e-002;
    __statist_i_h_wts[24,128]=-3.08256068559467e-002;
    __statist_i_h_wts[24,129]=1.26296543079246e-001;
    __statist_i_h_wts[24,130]=1.21085855491330e-001;
    __statist_i_h_wts[24,131]=1.11184700941268e-001;
    __statist_i_h_wts[24,132]=1.02095041909115e-001;
    __statist_i_h_wts[24,133]=1.28772497292366e-001;
    __statist_i_h_wts[24,134]=8.42798119083399e-002;
    __statist_i_h_wts[24,135]=-1.22770588462342e-001;
    __statist_i_h_wts[24,136]=-8.91700479949810e-002;
    __statist_i_h_wts[24,137]=-1.01816905095990e-001;
    __statist_i_h_wts[24,138]=-6.12690946867781e-002;
    __statist_i_h_wts[24,139]=-6.12022310789218e-002;
    __statist_i_h_wts[24,140]=3.98490755615360e-002;
    __statist_i_h_wts[24,141]=1.38457945329453e-002;
    __statist_i_h_wts[24,142]=-3.11046158825813e-003;
    __statist_i_h_wts[24,143]=-2.06125986775584e-002;
    __statist_i_h_wts[24,144]=3.71124294422445e-002;
    __statist_i_h_wts[24,145]=5.01550215425609e-002;
    __statist_i_h_wts[24,146]=1.08142706671772e-001;
    __statist_i_h_wts[24,147]=1.32646726145769e-001;
    __statist_i_h_wts[24,148]=1.19188666570816e-001;
    __statist_i_h_wts[24,149]=8.39288071998091e-002;
    __statist_i_h_wts[24,150]=-1.60625355858600e-001;
    __statist_i_h_wts[24,151]=-1.25008797672225e-001;
    __statist_i_h_wts[24,152]=-6.56172215249549e-002;
    __statist_i_h_wts[24,153]=-7.94481187181473e-002;
    __statist_i_h_wts[24,154]=-2.47707659164435e-002;
    __statist_i_h_wts[24,155]=4.49010414424228e-002;
    __statist_i_h_wts[24,156]=3.51402007219199e-002;
    __statist_i_h_wts[24,157]=1.17539691603713e-002;
    __statist_i_h_wts[24,158]=-2.24401552224454e-003;
    __statist_i_h_wts[24,159]=2.41342272268197e-002;
    __statist_i_h_wts[24,160]=4.62572735666869e-002;
    __statist_i_h_wts[24,161]=8.91410665812957e-002;
    __statist_i_h_wts[24,162]=1.21854295573785e-001;
    __statist_i_h_wts[24,163]=8.09327062610757e-002;
    __statist_i_h_wts[24,164]=7.82869483735661e-002;
    __statist_i_h_wts[24,165]=-7.44928263370017e-002;
    __statist_i_h_wts[24,166]=-7.40827462476022e-002;
    __statist_i_h_wts[24,167]=-2.29151935429296e-002;
    __statist_i_h_wts[24,168]=-4.65371267090713e-002;
    __statist_i_h_wts[24,169]=-3.40843266442741e-003;
    __statist_i_h_wts[24,170]=1.16306641396638e-002;
    __statist_i_h_wts[24,171]=-3.29786788367428e-002;
    __statist_i_h_wts[24,172]=8.83430307388062e-003;
    __statist_i_h_wts[24,173]=2.34983660213607e-002;
    __statist_i_h_wts[24,174]=4.67687517169360e-002;
    __statist_i_h_wts[24,175]=5.77791160716436e-002;
    __statist_i_h_wts[24,176]=9.84683567156633e-002;
    __statist_i_h_wts[24,177]=8.87146092383051e-002;
    __statist_i_h_wts[24,178]=2.72082179516528e-002;
    __statist_i_h_wts[24,179]=8.09836426005592e-002;
    __statist_i_h_wts[24,180]=-9.43627709651107e-002;
    __statist_i_h_wts[24,181]=-9.11870984613311e-002;
    __statist_i_h_wts[24,182]=-3.53004002852521e-002;
    __statist_i_h_wts[24,183]=-2.40353053119566e-002;
    __statist_i_h_wts[24,184]=6.25920696750483e-003;
    __statist_i_h_wts[24,185]=1.88162489640619e-002;
    __statist_i_h_wts[24,186]=1.89144317652772e-002;
    __statist_i_h_wts[24,187]=3.81049885889802e-002;
    __statist_i_h_wts[24,188]=2.19337169620103e-002;
    __statist_i_h_wts[24,189]=8.24973654799191e-003;
    __statist_i_h_wts[24,190]=-7.86546895920020e-003;
    __statist_i_h_wts[24,191]=8.94130625045113e-002;
    __statist_i_h_wts[24,192]=1.04193584766958e-001;
    __statist_i_h_wts[24,193]=1.37414152885875e-001;
    __statist_i_h_wts[24,194]=1.34695723509082e-001;
    __statist_i_h_wts[24,195]=-9.78093741783093e-002;
    __statist_i_h_wts[24,196]=-1.03234433809147e-001;
    __statist_i_h_wts[24,197]=-5.29148318459734e-002;
    __statist_i_h_wts[24,198]=-9.62804214222479e-002;
    __statist_i_h_wts[24,199]=-7.99416131823693e-002;
    __statist_i_h_wts[24,200]=-6.64074601465738e-002;
    __statist_i_h_wts[24,201]=-9.10911260422918e-002;
    __statist_i_h_wts[24,202]=-4.85361258692229e-002;
    __statist_i_h_wts[24,203]=-3.00043765899044e-002;
    __statist_i_h_wts[24,204]=-5.82547487237304e-002;
    __statist_i_h_wts[24,205]=-2.42728684248933e-002;
    __statist_i_h_wts[24,206]=5.33884429862210e-002;
    __statist_i_h_wts[24,207]=9.38158988447115e-002;
    __statist_i_h_wts[24,208]=1.35768231035290e-001;
    __statist_i_h_wts[24,209]=1.23992146063103e-001;
    __statist_i_h_wts[24,210]=-7.45313215566431e-002;
    __statist_i_h_wts[24,211]=-9.33481621033351e-002;
    __statist_i_h_wts[24,212]=-9.57924710765847e-002;
    __statist_i_h_wts[24,213]=-1.04136032787819e-001;
    __statist_i_h_wts[24,214]=-7.06429216880323e-002;
    __statist_i_h_wts[24,215]=-7.13365861853542e-002;
    __statist_i_h_wts[24,216]=-8.44098536073938e-002;
    __statist_i_h_wts[24,217]=-4.86681917849611e-002;
    __statist_i_h_wts[24,218]=-4.17684544702800e-002;
    __statist_i_h_wts[24,219]=-5.51121808873253e-002;
    __statist_i_h_wts[24,220]=-3.19053171029157e-002;
    __statist_i_h_wts[24,221]=1.89356539021354e-002;
    __statist_i_h_wts[24,222]=5.49383205786667e-002;
    __statist_i_h_wts[24,223]=1.12716356262933e-001;
    __statist_i_h_wts[24,224]=1.04476278903656e-001;
    __statist_i_h_wts[24,225]=-7.53116091077182e-002;
    __statist_i_h_wts[24,226]=8.89087054782932e-002;
    __statist_i_h_wts[24,227]=-3.57412644939469e-002;
    __statist_i_h_wts[24,228]=1.62083338826865e-001;
    __statist_i_h_wts[24,229]=-8.52210296974634e-002;
    __statist_i_h_wts[24,230]=-5.22854216388123e-001;
    __statist_i_h_wts[24,231]=-2.70895178133347e-001;
    __statist_i_h_wts[24,232]=-6.74925590935407e-001;
    __statist_i_h_wts[24,233]=-2.30215010502788e-001;
    __statist_i_h_wts[24,234]=-8.40168653898706e-001;
    __statist_i_h_wts[24,235]=-7.08066901188530e-002;
    __statist_i_h_wts[24,236]=1.31934973853085e-001;
    __statist_i_h_wts[24,237]=1.44145957065573e+000;
    __statist_i_h_wts[24,238]=4.22018276005572e-001;
    __statist_i_h_wts[24,239]=-4.00102090496201e-001;
    __statist_i_h_wts[24,240]=-1.34160549666237e-001;
    __statist_i_h_wts[24,241]=-7.68329137188198e-001;
    __statist_i_h_wts[24,242]=8.66219437112147e-002;
    __statist_i_h_wts[24,243]=-1.94538749084744e-001;
    __statist_i_h_wts[24,244]=-3.22195501212777e-002;
    __statist_i_h_wts[24,245]=3.38129057922702e-001;
    __statist_i_h_wts[24,246]=-1.23926508926039e-001;
    __statist_i_h_wts[24,247]=2.58570934611659e-001;
    __statist_i_h_wts[24,248]=2.03398270877979e-001;

    double[,] __statist_h_o_wts = new double[2,25];

    __statist_h_o_wts[0,0]=-4.67174493920964e-001;
    __statist_h_o_wts[0,1]=-4.48264195126485e-001;
    __statist_h_o_wts[0,2]=3.51906957686324e-001;
    __statist_h_o_wts[0,3]=5.80964961706544e-001;
    __statist_h_o_wts[0,4]=-3.67670004790461e-001;
    __statist_h_o_wts[0,5]=-3.80625122891170e-001;
    __statist_h_o_wts[0,6]=-1.27826089802803e-002;
    __statist_h_o_wts[0,7]=-6.46209522529943e-001;
    __statist_h_o_wts[0,8]=-3.38675610312640e-001;
    __statist_h_o_wts[0,9]=-1.17800098260983e-001;
    __statist_h_o_wts[0,10]=1.25242309403928e-001;
    __statist_h_o_wts[0,11]=-5.62444651422688e-002;
    __statist_h_o_wts[0,12]=-1.27722311790776e+000;
    __statist_h_o_wts[0,13]=-1.37070439561938e-002;
    __statist_h_o_wts[0,14]=-7.60703520247228e-001;
    __statist_h_o_wts[0,15]=1.06677121753656e-001;
    __statist_h_o_wts[0,16]=1.49930550530025e-001;
    __statist_h_o_wts[0,17]=5.41653753447206e-002;
    __statist_h_o_wts[0,18]=-3.70297093226305e-001;
    __statist_h_o_wts[0,19]=3.14668841026531e-001;
    __statist_h_o_wts[0,20]=8.47295974762365e-001;
    __statist_h_o_wts[0,21]=2.55783730371917e-001;
    __statist_h_o_wts[0,22]=1.05386707116438e-001;
    __statist_h_o_wts[0,23]=5.37246062295675e-001;
    __statist_h_o_wts[0,24]=-1.74219041173559e-001;

    __statist_h_o_wts[1,0]=4.73571468414921e-001;
    __statist_h_o_wts[1,1]=4.72166553559067e-001;
    __statist_h_o_wts[1,2]=-3.89272691728886e-001;
    __statist_h_o_wts[1,3]=-5.99145895433177e-001;
    __statist_h_o_wts[1,4]=3.51647083632030e-001;
    __statist_h_o_wts[1,5]=3.82891441313093e-001;
    __statist_h_o_wts[1,6]=1.40437404715755e-002;
    __statist_h_o_wts[1,7]=6.06540428222105e-001;
    __statist_h_o_wts[1,8]=3.77470891282964e-001;
    __statist_h_o_wts[1,9]=1.58482428659235e-001;
    __statist_h_o_wts[1,10]=-9.50072403810056e-002;
    __statist_h_o_wts[1,11]=4.13112260136545e-002;
    __statist_h_o_wts[1,12]=1.25520070164662e+000;
    __statist_h_o_wts[1,13]=-2.05349771189870e-002;
    __statist_h_o_wts[1,14]=7.68262363902602e-001;
    __statist_h_o_wts[1,15]=-1.37633616037106e-001;
    __statist_h_o_wts[1,16]=-1.72751567863666e-001;
    __statist_h_o_wts[1,17]=-6.75545584419748e-002;
    __statist_h_o_wts[1,18]=3.82335475992931e-001;
    __statist_h_o_wts[1,19]=-2.97849778643914e-001;
    __statist_h_o_wts[1,20]=-8.71776058207930e-001;
    __statist_h_o_wts[1,21]=-2.24346172432992e-001;
    __statist_h_o_wts[1,22]=-5.72525954819163e-002;
    __statist_h_o_wts[1,23]=-5.45173557245559e-001;
    __statist_h_o_wts[1,24]=2.27074246238938e-001;

    double[] __statist_hidden_bias = new double[25];
    __statist_hidden_bias[0]=-4.25456764522435e-002;
    __statist_hidden_bias[1]=8.38004468441226e-002;
    __statist_hidden_bias[2]=8.38530593890889e-003;
    __statist_hidden_bias[3]=5.88382476042375e-002;
    __statist_hidden_bias[4]=-5.94597524952175e-002;
    __statist_hidden_bias[5]=-7.26379049996755e-002;
    __statist_hidden_bias[6]=-3.97961661460291e-002;
    __statist_hidden_bias[7]=-1.60366302423481e-001;
    __statist_hidden_bias[8]=-1.80770593807601e-001;
    __statist_hidden_bias[9]=6.65402128603217e-002;
    __statist_hidden_bias[10]=-1.09838897116309e-001;
    __statist_hidden_bias[11]=4.71911063608957e-002;
    __statist_hidden_bias[12]=-6.89012043026739e-002;
    __statist_hidden_bias[13]=-2.85835666767807e-002;
    __statist_hidden_bias[14]=-1.89397443854679e-001;
    __statist_hidden_bias[15]=2.34431588185850e-003;
    __statist_hidden_bias[16]=4.15021379714341e-003;
    __statist_hidden_bias[17]=3.32952873644903e-002;
    __statist_hidden_bias[18]=-1.60839897830844e-001;
    __statist_hidden_bias[19]=2.57272945105698e-002;
    __statist_hidden_bias[20]=1.58592739874000e-001;
    __statist_hidden_bias[21]=1.07073637590503e-003;
    __statist_hidden_bias[22]=7.97760951928362e-002;
    __statist_hidden_bias[23]=8.03527614071567e-002;
    __statist_hidden_bias[24]=-1.07135339441965e-001;

    double[] __statist_output_bias = new double[2];
    __statist_output_bias[0]=2.64005035410490e-001;
    __statist_output_bias[1]=-2.47001780116019e-001;

    double[] __statist_inputs = new double[249];

    double[] __statist_hidden = new double[25];

    double[] __statist_outputs = new double[2];
    __statist_outputs[0] = -1.0e+307;
    __statist_outputs[1] = -1.0e+307;

    __statist_inputs[0]=Var7;
    __statist_inputs[1]=Var8;
    __statist_inputs[2]=Var9;
    __statist_inputs[3]=Var10;
    __statist_inputs[4]=Var11;
    __statist_inputs[5]=Var12;
    __statist_inputs[6]=Var13;
    __statist_inputs[7]=Var14;
    __statist_inputs[8]=Var15;
    __statist_inputs[9]=Var16;
    __statist_inputs[10]=Var17;
    __statist_inputs[11]=Var18;
    __statist_inputs[12]=Var19;
    __statist_inputs[13]=Var20;
    __statist_inputs[14]=Var21;
    __statist_inputs[15]=Var22;
    __statist_inputs[16]=Var23;
    __statist_inputs[17]=Var24;
    __statist_inputs[18]=Var25;
    __statist_inputs[19]=Var26;
    __statist_inputs[20]=Var27;
    __statist_inputs[21]=Var28;
    __statist_inputs[22]=Var29;
    __statist_inputs[23]=Var30;
    __statist_inputs[24]=Var31;
    __statist_inputs[25]=Var32;
    __statist_inputs[26]=Var33;
    __statist_inputs[27]=Var34;
    __statist_inputs[28]=Var35;
    __statist_inputs[29]=Var36;
    __statist_inputs[30]=Var37;
    __statist_inputs[31]=Var38;
    __statist_inputs[32]=Var39;
    __statist_inputs[33]=Var40;
    __statist_inputs[34]=Var41;
    __statist_inputs[35]=Var42;
    __statist_inputs[36]=Var43;
    __statist_inputs[37]=Var44;
    __statist_inputs[38]=Var45;
    __statist_inputs[39]=Var46;
    __statist_inputs[40]=Var47;
    __statist_inputs[41]=Var48;
    __statist_inputs[42]=Var49;
    __statist_inputs[43]=Var50;
    __statist_inputs[44]=Var51;
    __statist_inputs[45]=Var52;
    __statist_inputs[46]=Var53;
    __statist_inputs[47]=Var54;
    __statist_inputs[48]=Var55;
    __statist_inputs[49]=Var56;
    __statist_inputs[50]=Var57;
    __statist_inputs[51]=Var58;
    __statist_inputs[52]=Var59;
    __statist_inputs[53]=Var60;
    __statist_inputs[54]=Var61;
    __statist_inputs[55]=Var62;
    __statist_inputs[56]=Var63;
    __statist_inputs[57]=Var64;
    __statist_inputs[58]=Var65;
    __statist_inputs[59]=Var66;
    __statist_inputs[60]=Var67;
    __statist_inputs[61]=Var68;
    __statist_inputs[62]=Var69;
    __statist_inputs[63]=Var70;
    __statist_inputs[64]=Var71;
    __statist_inputs[65]=Var72;
    __statist_inputs[66]=Var73;
    __statist_inputs[67]=Var74;
    __statist_inputs[68]=Var75;
    __statist_inputs[69]=Var76;
    __statist_inputs[70]=Var77;
    __statist_inputs[71]=Var78;
    __statist_inputs[72]=Var79;
    __statist_inputs[73]=Var80;
    __statist_inputs[74]=Var81;
    __statist_inputs[75]=Var82;
    __statist_inputs[76]=Var83;
    __statist_inputs[77]=Var84;
    __statist_inputs[78]=Var85;
    __statist_inputs[79]=Var86;
    __statist_inputs[80]=Var87;
    __statist_inputs[81]=Var88;
    __statist_inputs[82]=Var89;
    __statist_inputs[83]=Var90;
    __statist_inputs[84]=Var91;
    __statist_inputs[85]=Var92;
    __statist_inputs[86]=Var93;
    __statist_inputs[87]=Var94;
    __statist_inputs[88]=Var95;
    __statist_inputs[89]=Var96;
    __statist_inputs[90]=Var97;
    __statist_inputs[91]=Var98;
    __statist_inputs[92]=Var99;
    __statist_inputs[93]=Var100;
    __statist_inputs[94]=Var101;
    __statist_inputs[95]=Var102;
    __statist_inputs[96]=Var103;
    __statist_inputs[97]=Var104;
    __statist_inputs[98]=Var105;
    __statist_inputs[99]=Var106;
    __statist_inputs[100]=Var107;
    __statist_inputs[101]=Var108;
    __statist_inputs[102]=Var109;
    __statist_inputs[103]=Var110;
    __statist_inputs[104]=Var111;
    __statist_inputs[105]=Var112;
    __statist_inputs[106]=Var113;
    __statist_inputs[107]=Var114;
    __statist_inputs[108]=Var115;
    __statist_inputs[109]=Var116;
    __statist_inputs[110]=Var117;
    __statist_inputs[111]=Var118;
    __statist_inputs[112]=Var119;
    __statist_inputs[113]=Var120;
    __statist_inputs[114]=Var121;
    __statist_inputs[115]=Var122;
    __statist_inputs[116]=Var123;
    __statist_inputs[117]=Var124;
    __statist_inputs[118]=Var125;
    __statist_inputs[119]=Var126;
    __statist_inputs[120]=Var127;
    __statist_inputs[121]=Var128;
    __statist_inputs[122]=Var129;
    __statist_inputs[123]=Var130;
    __statist_inputs[124]=Var131;
    __statist_inputs[125]=Var132;
    __statist_inputs[126]=Var133;
    __statist_inputs[127]=Var134;
    __statist_inputs[128]=Var135;
    __statist_inputs[129]=Var136;
    __statist_inputs[130]=Var137;
    __statist_inputs[131]=Var138;
    __statist_inputs[132]=Var139;
    __statist_inputs[133]=Var140;
    __statist_inputs[134]=Var141;
    __statist_inputs[135]=Var142;
    __statist_inputs[136]=Var143;
    __statist_inputs[137]=Var144;
    __statist_inputs[138]=Var145;
    __statist_inputs[139]=Var146;
    __statist_inputs[140]=Var147;
    __statist_inputs[141]=Var148;
    __statist_inputs[142]=Var149;
    __statist_inputs[143]=Var150;
    __statist_inputs[144]=Var151;
    __statist_inputs[145]=Var152;
    __statist_inputs[146]=Var153;
    __statist_inputs[147]=Var154;
    __statist_inputs[148]=Var155;
    __statist_inputs[149]=Var156;
    __statist_inputs[150]=Var157;
    __statist_inputs[151]=Var158;
    __statist_inputs[152]=Var159;
    __statist_inputs[153]=Var160;
    __statist_inputs[154]=Var161;
    __statist_inputs[155]=Var162;
    __statist_inputs[156]=Var163;
    __statist_inputs[157]=Var164;
    __statist_inputs[158]=Var165;
    __statist_inputs[159]=Var166;
    __statist_inputs[160]=Var167;
    __statist_inputs[161]=Var168;
    __statist_inputs[162]=Var169;
    __statist_inputs[163]=Var170;
    __statist_inputs[164]=Var171;
    __statist_inputs[165]=Var172;
    __statist_inputs[166]=Var173;
    __statist_inputs[167]=Var174;
    __statist_inputs[168]=Var175;
    __statist_inputs[169]=Var176;
    __statist_inputs[170]=Var177;
    __statist_inputs[171]=Var178;
    __statist_inputs[172]=Var179;
    __statist_inputs[173]=Var180;
    __statist_inputs[174]=Var181;
    __statist_inputs[175]=Var182;
    __statist_inputs[176]=Var183;
    __statist_inputs[177]=Var184;
    __statist_inputs[178]=Var185;
    __statist_inputs[179]=Var186;
    __statist_inputs[180]=Var187;
    __statist_inputs[181]=Var188;
    __statist_inputs[182]=Var189;
    __statist_inputs[183]=Var190;
    __statist_inputs[184]=Var191;
    __statist_inputs[185]=Var192;
    __statist_inputs[186]=Var193;
    __statist_inputs[187]=Var194;
    __statist_inputs[188]=Var195;
    __statist_inputs[189]=Var196;
    __statist_inputs[190]=Var197;
    __statist_inputs[191]=Var198;
    __statist_inputs[192]=Var199;
    __statist_inputs[193]=Var200;
    __statist_inputs[194]=Var201;
    __statist_inputs[195]=Var202;
    __statist_inputs[196]=Var203;
    __statist_inputs[197]=Var204;
    __statist_inputs[198]=Var205;
    __statist_inputs[199]=Var206;
    __statist_inputs[200]=Var207;
    __statist_inputs[201]=Var208;
    __statist_inputs[202]=Var209;
    __statist_inputs[203]=Var210;
    __statist_inputs[204]=Var211;
    __statist_inputs[205]=Var212;
    __statist_inputs[206]=Var213;
    __statist_inputs[207]=Var214;
    __statist_inputs[208]=Var215;
    __statist_inputs[209]=Var216;
    __statist_inputs[210]=Var217;
    __statist_inputs[211]=Var218;
    __statist_inputs[212]=Var219;
    __statist_inputs[213]=Var220;
    __statist_inputs[214]=Var221;
    __statist_inputs[215]=Var222;
    __statist_inputs[216]=Var223;
    __statist_inputs[217]=Var224;
    __statist_inputs[218]=Var225;
    __statist_inputs[219]=Var226;
    __statist_inputs[220]=Var227;
    __statist_inputs[221]=Var228;
    __statist_inputs[222]=Var229;
    __statist_inputs[223]=Var230;
    __statist_inputs[224]=Var231;
    __statist_inputs[225]=Var232;
    __statist_inputs[226]=Var233;
    __statist_inputs[227]=Var234;
    __statist_inputs[228]=Var235;
    __statist_inputs[229]=Var236;
    __statist_inputs[230]=Var237;
    __statist_inputs[231]=Var238;
    __statist_inputs[232]=Var239;
    __statist_inputs[233]=Var240;
    __statist_inputs[234]=Var241;
    __statist_inputs[235]=Var242;
    __statist_inputs[236]=Var243;
    __statist_inputs[237]=Var245;
    __statist_inputs[238]=Var246;
    __statist_inputs[239]=Var247;
    __statist_inputs[240]=Var248;
    __statist_inputs[241]=Var249;
    __statist_inputs[242]=Var250;
    __statist_inputs[243]=Var251;
    __statist_inputs[244]=Var252;
    __statist_inputs[245]=Var253;
    __statist_inputs[246]=Var254;
    __statist_inputs[247]=Var255;
    __statist_inputs[248]=Var256;

    double __statist_delta=0;
    double __statist_maximum=1;
    double __statist_minimum=0;
    int __statist_ncont_inputs=249;

    /*scale continuous inputs*/
    for(int __statist_i=0;__statist_i < __statist_ncont_inputs;__statist_i++)
    {
     __statist_delta = (__statist_maximum-__statist_minimum)/(__statist_max_input[__statist_i]-__statist_min_input[__statist_i]);
     __statist_inputs[__statist_i] = __statist_minimum - __statist_delta*__statist_min_input[__statist_i]+ __statist_delta*__statist_inputs[__statist_i];
    }

    int __statist_ninputs=249;
    int __statist_nhidden=25;

    /*Compute feed forward signals from Input layer to hidden layer*/
    for(int __statist_row=0;__statist_row < __statist_nhidden;__statist_row++)
    {
      __statist_hidden[__statist_row]=0.0;
      for(int __statist_col=0;__statist_col < __statist_ninputs;__statist_col++)
      {
       __statist_hidden[__statist_row]= __statist_hidden[__statist_row] + (__statist_i_h_wts[__statist_row,__statist_col]*__statist_inputs[__statist_col]);
      }
     __statist_hidden[__statist_row]=__statist_hidden[__statist_row]+__statist_hidden_bias[__statist_row];
    }

    for(int __statist_row=0;__statist_row < __statist_nhidden;__statist_row++)
    {
      if(__statist_hidden[__statist_row]>100.0)
      {
       __statist_hidden[__statist_row] = 1.0;
      }
      else
      {
       if(__statist_hidden[__statist_row]<-100.0)
       {
        __statist_hidden[__statist_row] = -1.0;
       }
       else
       {
        __statist_hidden[__statist_row] = Math.Tanh(__statist_hidden[__statist_row]);
       }
      }
    }

    int __statist_noutputs=2;

    /*Compute feed forward signals from hidden layer to output layer*/
    for(int __statist_row2=0;__statist_row2 < __statist_noutputs;__statist_row2++)
    {
     __statist_outputs[__statist_row2]=0.0;
    for(int __statist_col2=0;__statist_col2 < __statist_nhidden;__statist_col2++)
      {
       __statist_outputs[__statist_row2]= __statist_outputs[__statist_row2] + (__statist_h_o_wts[__statist_row2,__statist_col2]*__statist_hidden[__statist_col2]);
      }
     __statist_outputs[__statist_row2]=__statist_outputs[__statist_row2]+__statist_output_bias[__statist_row2];
    }


    double __statist_sum=0.0;
    double __statist_maxIndex=0;
    for(int __statist_jj=0;__statist_jj < __statist_noutputs;__statist_jj++)
    {
     if(__statist_outputs[__statist_jj] > 200)
     {
      double __statist_max=__statist_outputs[1];
      __statist_maxIndex=0;
     for(int __statist_ii=0;__statist_ii < __statist_noutputs;__statist_ii++)
    {
      if(__statist_outputs[__statist_ii] > __statist_max)
      {
        __statist_max = __statist_outputs[__statist_ii];
        __statist_maxIndex = __statist_ii;
      }
     }

     for(int __statist_kk=0;__statist_kk < __statist_noutputs;__statist_kk++)
    {
      if(__statist_kk==__statist_maxIndex)
      {
        __statist_outputs[__statist_jj]=1.0;
      }
      else
      {
        __statist_outputs[__statist_kk]=0.0;
      }
     }
    }
    else
    {
     __statist_outputs[__statist_jj] = Math.Exp(__statist_outputs[__statist_jj]);
     __statist_sum = __statist_sum + __statist_outputs[__statist_jj];
    }
   }
     for(int __statist_ll=0;__statist_ll < __statist_noutputs;__statist_ll++)
    {
     if(__statist_sum != 0)
     {
      __statist_outputs[__statist_ll] = __statist_outputs[__statist_ll]/__statist_sum;
     }
    }

    int __statist_PredIndex=1;
    for(int __statist_ii=0;__statist_ii < __statist_noutputs;__statist_ii++)
    {
     if(__statist_ConfLevel < __statist_outputs[__statist_ii])
     {
      __statist_ConfLevel=__statist_outputs[__statist_ii];
      __statist_PredIndex=__statist_ii;
     }
    }

    __statist_PredCat = __statist_DCats[__statist_PredIndex];

      Console.WriteLine(" Predict24925285_правоed Category = " + __statist_PredCat);
      return new string[] { __statist_PredCat, __statist_ConfLevel.ToString() };

   }

   public static string[] Main (string[] args) {
     int argID = 0;
     double[] ContInputs = new double[249];
     int contID = 0;

     if (args.Length >= 249)
     {
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
       ContInputs[contID++] = Double.Parse(args[argID++]);
     }
     else
     {
       string Comment = "";
       string Comment1 = "**************************************************************************\n";
       Comment += Comment1;
       string Comment2 = "Please enter at least 249 command line parameters in the following order for \nthe program to Predict24925285_право.\n";
       Comment += Comment2;
       Comment += Comment1;
       string Comment3 = "Var7  Type - double (or) integer\n";
       Comment += Comment3;
       string Comment4 = "Var8  Type - double (or) integer\n";
       Comment += Comment4;
       string Comment5 = "Var9  Type - double (or) integer\n";
       Comment += Comment5;
       string Comment6 = "Var10  Type - double (or) integer\n";
       Comment += Comment6;
       string Comment7 = "Var11  Type - double (or) integer\n";
       Comment += Comment7;
       string Comment8 = "Var12  Type - double (or) integer\n";
       Comment += Comment8;
       string Comment9 = "Var13  Type - double (or) integer\n";
       Comment += Comment9;
       string Comment10 = "Var14  Type - double (or) integer\n";
       Comment += Comment10;
       string Comment11 = "Var15  Type - double (or) integer\n";
       Comment += Comment11;
       string Comment12 = "Var16  Type - double (or) integer\n";
       Comment += Comment12;
       string Comment13 = "Var17  Type - double (or) integer\n";
       Comment += Comment13;
       string Comment14 = "Var18  Type - double (or) integer\n";
       Comment += Comment14;
       string Comment15 = "Var19  Type - double (or) integer\n";
       Comment += Comment15;
       string Comment16 = "Var20  Type - double (or) integer\n";
       Comment += Comment16;
       string Comment17 = "Var21  Type - double (or) integer\n";
       Comment += Comment17;
       string Comment18 = "Var22  Type - double (or) integer\n";
       Comment += Comment18;
       string Comment19 = "Var23  Type - double (or) integer\n";
       Comment += Comment19;
       string Comment20 = "Var24  Type - double (or) integer\n";
       Comment += Comment20;
       string Comment21 = "Var25  Type - double (or) integer\n";
       Comment += Comment21;
       string Comment22 = "Var26  Type - double (or) integer\n";
       Comment += Comment22;
       string Comment23 = "Var27  Type - double (or) integer\n";
       Comment += Comment23;
       string Comment24 = "Var28  Type - double (or) integer\n";
       Comment += Comment24;
       string Comment25 = "Var29  Type - double (or) integer\n";
       Comment += Comment25;
       string Comment26 = "Var30  Type - double (or) integer\n";
       Comment += Comment26;
       string Comment27 = "Var31  Type - double (or) integer\n";
       Comment += Comment27;
       string Comment28 = "Var32  Type - double (or) integer\n";
       Comment += Comment28;
       string Comment29 = "Var33  Type - double (or) integer\n";
       Comment += Comment29;
       string Comment30 = "Var34  Type - double (or) integer\n";
       Comment += Comment30;
       string Comment31 = "Var35  Type - double (or) integer\n";
       Comment += Comment31;
       string Comment32 = "Var36  Type - double (or) integer\n";
       Comment += Comment32;
       string Comment33 = "Var37  Type - double (or) integer\n";
       Comment += Comment33;
       string Comment34 = "Var38  Type - double (or) integer\n";
       Comment += Comment34;
       string Comment35 = "Var39  Type - double (or) integer\n";
       Comment += Comment35;
       string Comment36 = "Var40  Type - double (or) integer\n";
       Comment += Comment36;
       string Comment37 = "Var41  Type - double (or) integer\n";
       Comment += Comment37;
       string Comment38 = "Var42  Type - double (or) integer\n";
       Comment += Comment38;
       string Comment39 = "Var43  Type - double (or) integer\n";
       Comment += Comment39;
       string Comment40 = "Var44  Type - double (or) integer\n";
       Comment += Comment40;
       string Comment41 = "Var45  Type - double (or) integer\n";
       Comment += Comment41;
       string Comment42 = "Var46  Type - double (or) integer\n";
       Comment += Comment42;
       string Comment43 = "Var47  Type - double (or) integer\n";
       Comment += Comment43;
       string Comment44 = "Var48  Type - double (or) integer\n";
       Comment += Comment44;
       string Comment45 = "Var49  Type - double (or) integer\n";
       Comment += Comment45;
       string Comment46 = "Var50  Type - double (or) integer\n";
       Comment += Comment46;
       string Comment47 = "Var51  Type - double (or) integer\n";
       Comment += Comment47;
       string Comment48 = "Var52  Type - double (or) integer\n";
       Comment += Comment48;
       string Comment49 = "Var53  Type - double (or) integer\n";
       Comment += Comment49;
       string Comment50 = "Var54  Type - double (or) integer\n";
       Comment += Comment50;
       string Comment51 = "Var55  Type - double (or) integer\n";
       Comment += Comment51;
       string Comment52 = "Var56  Type - double (or) integer\n";
       Comment += Comment52;
       string Comment53 = "Var57  Type - double (or) integer\n";
       Comment += Comment53;
       string Comment54 = "Var58  Type - double (or) integer\n";
       Comment += Comment54;
       string Comment55 = "Var59  Type - double (or) integer\n";
       Comment += Comment55;
       string Comment56 = "Var60  Type - double (or) integer\n";
       Comment += Comment56;
       string Comment57 = "Var61  Type - double (or) integer\n";
       Comment += Comment57;
       string Comment58 = "Var62  Type - double (or) integer\n";
       Comment += Comment58;
       string Comment59 = "Var63  Type - double (or) integer\n";
       Comment += Comment59;
       string Comment60 = "Var64  Type - double (or) integer\n";
       Comment += Comment60;
       string Comment61 = "Var65  Type - double (or) integer\n";
       Comment += Comment61;
       string Comment62 = "Var66  Type - double (or) integer\n";
       Comment += Comment62;
       string Comment63 = "Var67  Type - double (or) integer\n";
       Comment += Comment63;
       string Comment64 = "Var68  Type - double (or) integer\n";
       Comment += Comment64;
       string Comment65 = "Var69  Type - double (or) integer\n";
       Comment += Comment65;
       string Comment66 = "Var70  Type - double (or) integer\n";
       Comment += Comment66;
       string Comment67 = "Var71  Type - double (or) integer\n";
       Comment += Comment67;
       string Comment68 = "Var72  Type - double (or) integer\n";
       Comment += Comment68;
       string Comment69 = "Var73  Type - double (or) integer\n";
       Comment += Comment69;
       string Comment70 = "Var74  Type - double (or) integer\n";
       Comment += Comment70;
       string Comment71 = "Var75  Type - double (or) integer\n";
       Comment += Comment71;
       string Comment72 = "Var76  Type - double (or) integer\n";
       Comment += Comment72;
       string Comment73 = "Var77  Type - double (or) integer\n";
       Comment += Comment73;
       string Comment74 = "Var78  Type - double (or) integer\n";
       Comment += Comment74;
       string Comment75 = "Var79  Type - double (or) integer\n";
       Comment += Comment75;
       string Comment76 = "Var80  Type - double (or) integer\n";
       Comment += Comment76;
       string Comment77 = "Var81  Type - double (or) integer\n";
       Comment += Comment77;
       string Comment78 = "Var82  Type - double (or) integer\n";
       Comment += Comment78;
       string Comment79 = "Var83  Type - double (or) integer\n";
       Comment += Comment79;
       string Comment80 = "Var84  Type - double (or) integer\n";
       Comment += Comment80;
       string Comment81 = "Var85  Type - double (or) integer\n";
       Comment += Comment81;
       string Comment82 = "Var86  Type - double (or) integer\n";
       Comment += Comment82;
       string Comment83 = "Var87  Type - double (or) integer\n";
       Comment += Comment83;
       string Comment84 = "Var88  Type - double (or) integer\n";
       Comment += Comment84;
       string Comment85 = "Var89  Type - double (or) integer\n";
       Comment += Comment85;
       string Comment86 = "Var90  Type - double (or) integer\n";
       Comment += Comment86;
       string Comment87 = "Var91  Type - double (or) integer\n";
       Comment += Comment87;
       string Comment88 = "Var92  Type - double (or) integer\n";
       Comment += Comment88;
       string Comment89 = "Var93  Type - double (or) integer\n";
       Comment += Comment89;
       string Comment90 = "Var94  Type - double (or) integer\n";
       Comment += Comment90;
       string Comment91 = "Var95  Type - double (or) integer\n";
       Comment += Comment91;
       string Comment92 = "Var96  Type - double (or) integer\n";
       Comment += Comment92;
       string Comment93 = "Var97  Type - double (or) integer\n";
       Comment += Comment93;
       string Comment94 = "Var98  Type - double (or) integer\n";
       Comment += Comment94;
       string Comment95 = "Var99  Type - double (or) integer\n";
       Comment += Comment95;
       string Comment96 = "Var100  Type - double (or) integer\n";
       Comment += Comment96;
       string Comment97 = "Var101  Type - double (or) integer\n";
       Comment += Comment97;
       string Comment98 = "Var102  Type - double (or) integer\n";
       Comment += Comment98;
       string Comment99 = "Var103  Type - double (or) integer\n";
       Comment += Comment99;
       string Comment100 = "Var104  Type - double (or) integer\n";
       Comment += Comment100;
       string Comment101 = "Var105  Type - double (or) integer\n";
       Comment += Comment101;
       string Comment102 = "Var106  Type - double (or) integer\n";
       Comment += Comment102;
       string Comment103 = "Var107  Type - double (or) integer\n";
       Comment += Comment103;
       string Comment104 = "Var108  Type - double (or) integer\n";
       Comment += Comment104;
       string Comment105 = "Var109  Type - double (or) integer\n";
       Comment += Comment105;
       string Comment106 = "Var110  Type - double (or) integer\n";
       Comment += Comment106;
       string Comment107 = "Var111  Type - double (or) integer\n";
       Comment += Comment107;
       string Comment108 = "Var112  Type - double (or) integer\n";
       Comment += Comment108;
       string Comment109 = "Var113  Type - double (or) integer\n";
       Comment += Comment109;
       string Comment110 = "Var114  Type - double (or) integer\n";
       Comment += Comment110;
       string Comment111 = "Var115  Type - double (or) integer\n";
       Comment += Comment111;
       string Comment112 = "Var116  Type - double (or) integer\n";
       Comment += Comment112;
       string Comment113 = "Var117  Type - double (or) integer\n";
       Comment += Comment113;
       string Comment114 = "Var118  Type - double (or) integer\n";
       Comment += Comment114;
       string Comment115 = "Var119  Type - double (or) integer\n";
       Comment += Comment115;
       string Comment116 = "Var120  Type - double (or) integer\n";
       Comment += Comment116;
       string Comment117 = "Var121  Type - double (or) integer\n";
       Comment += Comment117;
       string Comment118 = "Var122  Type - double (or) integer\n";
       Comment += Comment118;
       string Comment119 = "Var123  Type - double (or) integer\n";
       Comment += Comment119;
       string Comment120 = "Var124  Type - double (or) integer\n";
       Comment += Comment120;
       string Comment121 = "Var125  Type - double (or) integer\n";
       Comment += Comment121;
       string Comment122 = "Var126  Type - double (or) integer\n";
       Comment += Comment122;
       string Comment123 = "Var127  Type - double (or) integer\n";
       Comment += Comment123;
       string Comment124 = "Var128  Type - double (or) integer\n";
       Comment += Comment124;
       string Comment125 = "Var129  Type - double (or) integer\n";
       Comment += Comment125;
       string Comment126 = "Var130  Type - double (or) integer\n";
       Comment += Comment126;
       string Comment127 = "Var131  Type - double (or) integer\n";
       Comment += Comment127;
       string Comment128 = "Var132  Type - double (or) integer\n";
       Comment += Comment128;
       string Comment129 = "Var133  Type - double (or) integer\n";
       Comment += Comment129;
       string Comment130 = "Var134  Type - double (or) integer\n";
       Comment += Comment130;
       string Comment131 = "Var135  Type - double (or) integer\n";
       Comment += Comment131;
       string Comment132 = "Var136  Type - double (or) integer\n";
       Comment += Comment132;
       string Comment133 = "Var137  Type - double (or) integer\n";
       Comment += Comment133;
       string Comment134 = "Var138  Type - double (or) integer\n";
       Comment += Comment134;
       string Comment135 = "Var139  Type - double (or) integer\n";
       Comment += Comment135;
       string Comment136 = "Var140  Type - double (or) integer\n";
       Comment += Comment136;
       string Comment137 = "Var141  Type - double (or) integer\n";
       Comment += Comment137;
       string Comment138 = "Var142  Type - double (or) integer\n";
       Comment += Comment138;
       string Comment139 = "Var143  Type - double (or) integer\n";
       Comment += Comment139;
       string Comment140 = "Var144  Type - double (or) integer\n";
       Comment += Comment140;
       string Comment141 = "Var145  Type - double (or) integer\n";
       Comment += Comment141;
       string Comment142 = "Var146  Type - double (or) integer\n";
       Comment += Comment142;
       string Comment143 = "Var147  Type - double (or) integer\n";
       Comment += Comment143;
       string Comment144 = "Var148  Type - double (or) integer\n";
       Comment += Comment144;
       string Comment145 = "Var149  Type - double (or) integer\n";
       Comment += Comment145;
       string Comment146 = "Var150  Type - double (or) integer\n";
       Comment += Comment146;
       string Comment147 = "Var151  Type - double (or) integer\n";
       Comment += Comment147;
       string Comment148 = "Var152  Type - double (or) integer\n";
       Comment += Comment148;
       string Comment149 = "Var153  Type - double (or) integer\n";
       Comment += Comment149;
       string Comment150 = "Var154  Type - double (or) integer\n";
       Comment += Comment150;
       string Comment151 = "Var155  Type - double (or) integer\n";
       Comment += Comment151;
       string Comment152 = "Var156  Type - double (or) integer\n";
       Comment += Comment152;
       string Comment153 = "Var157  Type - double (or) integer\n";
       Comment += Comment153;
       string Comment154 = "Var158  Type - double (or) integer\n";
       Comment += Comment154;
       string Comment155 = "Var159  Type - double (or) integer\n";
       Comment += Comment155;
       string Comment156 = "Var160  Type - double (or) integer\n";
       Comment += Comment156;
       string Comment157 = "Var161  Type - double (or) integer\n";
       Comment += Comment157;
       string Comment158 = "Var162  Type - double (or) integer\n";
       Comment += Comment158;
       string Comment159 = "Var163  Type - double (or) integer\n";
       Comment += Comment159;
       string Comment160 = "Var164  Type - double (or) integer\n";
       Comment += Comment160;
       string Comment161 = "Var165  Type - double (or) integer\n";
       Comment += Comment161;
       string Comment162 = "Var166  Type - double (or) integer\n";
       Comment += Comment162;
       string Comment163 = "Var167  Type - double (or) integer\n";
       Comment += Comment163;
       string Comment164 = "Var168  Type - double (or) integer\n";
       Comment += Comment164;
       string Comment165 = "Var169  Type - double (or) integer\n";
       Comment += Comment165;
       string Comment166 = "Var170  Type - double (or) integer\n";
       Comment += Comment166;
       string Comment167 = "Var171  Type - double (or) integer\n";
       Comment += Comment167;
       string Comment168 = "Var172  Type - double (or) integer\n";
       Comment += Comment168;
       string Comment169 = "Var173  Type - double (or) integer\n";
       Comment += Comment169;
       string Comment170 = "Var174  Type - double (or) integer\n";
       Comment += Comment170;
       string Comment171 = "Var175  Type - double (or) integer\n";
       Comment += Comment171;
       string Comment172 = "Var176  Type - double (or) integer\n";
       Comment += Comment172;
       string Comment173 = "Var177  Type - double (or) integer\n";
       Comment += Comment173;
       string Comment174 = "Var178  Type - double (or) integer\n";
       Comment += Comment174;
       string Comment175 = "Var179  Type - double (or) integer\n";
       Comment += Comment175;
       string Comment176 = "Var180  Type - double (or) integer\n";
       Comment += Comment176;
       string Comment177 = "Var181  Type - double (or) integer\n";
       Comment += Comment177;
       string Comment178 = "Var182  Type - double (or) integer\n";
       Comment += Comment178;
       string Comment179 = "Var183  Type - double (or) integer\n";
       Comment += Comment179;
       string Comment180 = "Var184  Type - double (or) integer\n";
       Comment += Comment180;
       string Comment181 = "Var185  Type - double (or) integer\n";
       Comment += Comment181;
       string Comment182 = "Var186  Type - double (or) integer\n";
       Comment += Comment182;
       string Comment183 = "Var187  Type - double (or) integer\n";
       Comment += Comment183;
       string Comment184 = "Var188  Type - double (or) integer\n";
       Comment += Comment184;
       string Comment185 = "Var189  Type - double (or) integer\n";
       Comment += Comment185;
       string Comment186 = "Var190  Type - double (or) integer\n";
       Comment += Comment186;
       string Comment187 = "Var191  Type - double (or) integer\n";
       Comment += Comment187;
       string Comment188 = "Var192  Type - double (or) integer\n";
       Comment += Comment188;
       string Comment189 = "Var193  Type - double (or) integer\n";
       Comment += Comment189;
       string Comment190 = "Var194  Type - double (or) integer\n";
       Comment += Comment190;
       string Comment191 = "Var195  Type - double (or) integer\n";
       Comment += Comment191;
       string Comment192 = "Var196  Type - double (or) integer\n";
       Comment += Comment192;
       string Comment193 = "Var197  Type - double (or) integer\n";
       Comment += Comment193;
       string Comment194 = "Var198  Type - double (or) integer\n";
       Comment += Comment194;
       string Comment195 = "Var199  Type - double (or) integer\n";
       Comment += Comment195;
       string Comment196 = "Var200  Type - double (or) integer\n";
       Comment += Comment196;
       string Comment197 = "Var201  Type - double (or) integer\n";
       Comment += Comment197;
       string Comment198 = "Var202  Type - double (or) integer\n";
       Comment += Comment198;
       string Comment199 = "Var203  Type - double (or) integer\n";
       Comment += Comment199;
       string Comment200 = "Var204  Type - double (or) integer\n";
       Comment += Comment200;
       string Comment201 = "Var205  Type - double (or) integer\n";
       Comment += Comment201;
       string Comment202 = "Var206  Type - double (or) integer\n";
       Comment += Comment202;
       string Comment203 = "Var207  Type - double (or) integer\n";
       Comment += Comment203;
       string Comment204 = "Var208  Type - double (or) integer\n";
       Comment += Comment204;
       string Comment205 = "Var209  Type - double (or) integer\n";
       Comment += Comment205;
       string Comment206 = "Var210  Type - double (or) integer\n";
       Comment += Comment206;
       string Comment207 = "Var211  Type - double (or) integer\n";
       Comment += Comment207;
       string Comment208 = "Var212  Type - double (or) integer\n";
       Comment += Comment208;
       string Comment209 = "Var213  Type - double (or) integer\n";
       Comment += Comment209;
       string Comment210 = "Var214  Type - double (or) integer\n";
       Comment += Comment210;
       string Comment211 = "Var215  Type - double (or) integer\n";
       Comment += Comment211;
       string Comment212 = "Var216  Type - double (or) integer\n";
       Comment += Comment212;
       string Comment213 = "Var217  Type - double (or) integer\n";
       Comment += Comment213;
       string Comment214 = "Var218  Type - double (or) integer\n";
       Comment += Comment214;
       string Comment215 = "Var219  Type - double (or) integer\n";
       Comment += Comment215;
       string Comment216 = "Var220  Type - double (or) integer\n";
       Comment += Comment216;
       string Comment217 = "Var221  Type - double (or) integer\n";
       Comment += Comment217;
       string Comment218 = "Var222  Type - double (or) integer\n";
       Comment += Comment218;
       string Comment219 = "Var223  Type - double (or) integer\n";
       Comment += Comment219;
       string Comment220 = "Var224  Type - double (or) integer\n";
       Comment += Comment220;
       string Comment221 = "Var225  Type - double (or) integer\n";
       Comment += Comment221;
       string Comment222 = "Var226  Type - double (or) integer\n";
       Comment += Comment222;
       string Comment223 = "Var227  Type - double (or) integer\n";
       Comment += Comment223;
       string Comment224 = "Var228  Type - double (or) integer\n";
       Comment += Comment224;
       string Comment225 = "Var229  Type - double (or) integer\n";
       Comment += Comment225;
       string Comment226 = "Var230  Type - double (or) integer\n";
       Comment += Comment226;
       string Comment227 = "Var231  Type - double (or) integer\n";
       Comment += Comment227;
       string Comment228 = "Var232  Type - double (or) integer\n";
       Comment += Comment228;
       string Comment229 = "Var233  Type - double (or) integer\n";
       Comment += Comment229;
       string Comment230 = "Var234  Type - double (or) integer\n";
       Comment += Comment230;
       string Comment231 = "Var235  Type - double (or) integer\n";
       Comment += Comment231;
       string Comment232 = "Var236  Type - double (or) integer\n";
       Comment += Comment232;
       string Comment233 = "Var237  Type - double (or) integer\n";
       Comment += Comment233;
       string Comment234 = "Var238  Type - double (or) integer\n";
       Comment += Comment234;
       string Comment235 = "Var239  Type - double (or) integer\n";
       Comment += Comment235;
       string Comment236 = "Var240  Type - double (or) integer\n";
       Comment += Comment236;
       string Comment237 = "Var241  Type - double (or) integer\n";
       Comment += Comment237;
       string Comment238 = "Var242  Type - double (or) integer\n";
       Comment += Comment238;
       string Comment239 = "Var243  Type - double (or) integer\n";
       Comment += Comment239;
       string Comment240 = "Var245  Type - double (or) integer\n";
       Comment += Comment240;
       string Comment241 = "Var246  Type - double (or) integer\n";
       Comment += Comment241;
       string Comment242 = "Var247  Type - double (or) integer\n";
       Comment += Comment242;
       string Comment243 = "Var248  Type - double (or) integer\n";
       Comment += Comment243;
       string Comment244 = "Var249  Type - double (or) integer\n";
       Comment += Comment244;
       string Comment245 = "Var250  Type - double (or) integer\n";
       Comment += Comment245;
       string Comment246 = "Var251  Type - double (or) integer\n";
       Comment += Comment246;
       string Comment247 = "Var252  Type - double (or) integer\n";
       Comment += Comment247;
       string Comment248 = "Var253  Type - double (or) integer\n";
       Comment += Comment248;
       string Comment249 = "Var254  Type - double (or) integer\n";
       Comment += Comment249;
       string Comment250 = "Var255  Type - double (or) integer\n";
       Comment += Comment250;
       string Comment251 = "Var256  Type - double (or) integer\n";
       Comment += Comment251;
       Comment += Comment1;
       System.Console.WriteLine(Comment);
       System.Environment.Exit(1);
     }
     return foo( ContInputs );
   }

}
