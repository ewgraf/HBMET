/**C# deployment code of Neural Networks Model**/

/**==========================================================================
Before running the C# deployment code please read the following.

 STATISTICA variable names will be exported as-is into the C# deployment script;
please verify the resulting script to ensure that the variable names follow the C#
naming conventions and modify the names if necessary.

==========================================================================**/

using System;


public class Predict24925287_низ
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
    __statist_DCats[1]= "3";

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

    __statist_i_h_wts[0,0]=-7.73814062988760e-003;
    __statist_i_h_wts[0,1]=-1.21525488609426e-002;
    __statist_i_h_wts[0,2]=-1.34061906178902e-002;
    __statist_i_h_wts[0,3]=-2.16203558973766e-002;
    __statist_i_h_wts[0,4]=-1.55219332575061e-002;
    __statist_i_h_wts[0,5]=-2.42544058530085e-002;
    __statist_i_h_wts[0,6]=-2.12997237248473e-002;
    __statist_i_h_wts[0,7]=-1.00606074697583e-002;
    __statist_i_h_wts[0,8]=-1.74183961215028e-002;
    __statist_i_h_wts[0,9]=-1.58919442351351e-002;
    __statist_i_h_wts[0,10]=-3.59952924171457e-003;
    __statist_i_h_wts[0,11]=-4.02401958530598e-003;
    __statist_i_h_wts[0,12]=6.64126455807321e-003;
    __statist_i_h_wts[0,13]=9.65516924557539e-003;
    __statist_i_h_wts[0,14]=1.93881685509210e-002;
    __statist_i_h_wts[0,15]=-2.80848778445626e-003;
    __statist_i_h_wts[0,16]=-2.36099535992932e-003;
    __statist_i_h_wts[0,17]=-2.30424077837819e-002;
    __statist_i_h_wts[0,18]=-2.80945182824929e-002;
    __statist_i_h_wts[0,19]=-8.44561942449797e-003;
    __statist_i_h_wts[0,20]=-2.16162102041080e-002;
    __statist_i_h_wts[0,21]=-3.02559149412620e-002;
    __statist_i_h_wts[0,22]=-2.88089163247440e-002;
    __statist_i_h_wts[0,23]=-1.97205975713967e-002;
    __statist_i_h_wts[0,24]=9.92496698764377e-004;
    __statist_i_h_wts[0,25]=-3.52238372279315e-003;
    __statist_i_h_wts[0,26]=1.10081876106594e-003;
    __statist_i_h_wts[0,27]=5.14378197146687e-003;
    __statist_i_h_wts[0,28]=1.82223714154625e-003;
    __statist_i_h_wts[0,29]=2.04967390611132e-002;
    __statist_i_h_wts[0,30]=-2.23667529355702e-002;
    __statist_i_h_wts[0,31]=-3.25189734082391e-002;
    __statist_i_h_wts[0,32]=-3.01991680190981e-002;
    __statist_i_h_wts[0,33]=-3.02210108859835e-002;
    __statist_i_h_wts[0,34]=-2.96008946797266e-002;
    __statist_i_h_wts[0,35]=-3.17679255306450e-002;
    __statist_i_h_wts[0,36]=-2.93365860934360e-002;
    __statist_i_h_wts[0,37]=-1.62965598412457e-002;
    __statist_i_h_wts[0,38]=-2.44741052256123e-002;
    __statist_i_h_wts[0,39]=-8.62035431079413e-003;
    __statist_i_h_wts[0,40]=-8.76569606951216e-003;
    __statist_i_h_wts[0,41]=-7.10086387833609e-003;
    __statist_i_h_wts[0,42]=-1.65313494890648e-002;
    __statist_i_h_wts[0,43]=8.31829265388604e-004;
    __statist_i_h_wts[0,44]=1.44792066104217e-002;
    __statist_i_h_wts[0,45]=-1.02209744376843e-002;
    __statist_i_h_wts[0,46]=-3.18537473183502e-002;
    __statist_i_h_wts[0,47]=-3.47165198306635e-002;
    __statist_i_h_wts[0,48]=-3.87128776043829e-002;
    __statist_i_h_wts[0,49]=-2.99030956613609e-002;
    __statist_i_h_wts[0,50]=-3.34655687901212e-002;
    __statist_i_h_wts[0,51]=-2.25211267116881e-002;
    __statist_i_h_wts[0,52]=-1.94789606489292e-002;
    __statist_i_h_wts[0,53]=-1.98955696702166e-002;
    __statist_i_h_wts[0,54]=-1.73962595782607e-002;
    __statist_i_h_wts[0,55]=-1.11611523765422e-002;
    __statist_i_h_wts[0,56]=-5.95733123333789e-003;
    __statist_i_h_wts[0,57]=-1.35805381127516e-003;
    __statist_i_h_wts[0,58]=-6.13322547482394e-003;
    __statist_i_h_wts[0,59]=1.61279113270910e-002;
    __statist_i_h_wts[0,60]=-1.40440732093368e-002;
    __statist_i_h_wts[0,61]=-1.45334513405261e-002;
    __statist_i_h_wts[0,62]=-2.17889310791974e-002;
    __statist_i_h_wts[0,63]=-3.28614141656109e-002;
    __statist_i_h_wts[0,64]=-3.03433523290709e-002;
    __statist_i_h_wts[0,65]=-1.80177418720339e-002;
    __statist_i_h_wts[0,66]=-3.15279876962867e-002;
    __statist_i_h_wts[0,67]=-2.52700078207536e-002;
    __statist_i_h_wts[0,68]=-3.14755632390260e-002;
    __statist_i_h_wts[0,69]=-3.62541316742748e-002;
    __statist_i_h_wts[0,70]=-2.31894902922272e-002;
    __statist_i_h_wts[0,71]=-1.21564666263335e-002;
    __statist_i_h_wts[0,72]=-1.09794374189647e-002;
    __statist_i_h_wts[0,73]=3.64847421480962e-003;
    __statist_i_h_wts[0,74]=1.38907815871712e-002;
    __statist_i_h_wts[0,75]=-3.51556113525422e-003;
    __statist_i_h_wts[0,76]=-1.07649765252386e-002;
    __statist_i_h_wts[0,77]=-2.41657746536849e-002;
    __statist_i_h_wts[0,78]=-3.28357717772126e-002;
    __statist_i_h_wts[0,79]=-2.73494041513866e-002;
    __statist_i_h_wts[0,80]=-2.13322627941417e-002;
    __statist_i_h_wts[0,81]=-2.60833665685475e-002;
    __statist_i_h_wts[0,82]=-2.88467890503575e-002;
    __statist_i_h_wts[0,83]=-3.60049169466613e-002;
    __statist_i_h_wts[0,84]=-2.44963237339653e-002;
    __statist_i_h_wts[0,85]=-1.80024675862464e-002;
    __statist_i_h_wts[0,86]=-1.79841896212795e-002;
    __statist_i_h_wts[0,87]=-8.06929972099863e-003;
    __statist_i_h_wts[0,88]=1.38279732836760e-002;
    __statist_i_h_wts[0,89]=2.13312548684374e-002;
    __statist_i_h_wts[0,90]=7.80630016842037e-002;
    __statist_i_h_wts[0,91]=4.81407815840297e-002;
    __statist_i_h_wts[0,92]=3.53699729922563e-002;
    __statist_i_h_wts[0,93]=2.44899433859779e-002;
    __statist_i_h_wts[0,94]=5.59336398463041e-002;
    __statist_i_h_wts[0,95]=5.50071841984910e-002;
    __statist_i_h_wts[0,96]=6.32441067304320e-002;
    __statist_i_h_wts[0,97]=4.75540966954192e-002;
    __statist_i_h_wts[0,98]=2.48582359960624e-002;
    __statist_i_h_wts[0,99]=3.98345382370894e-002;
    __statist_i_h_wts[0,100]=1.59489504890734e-002;
    __statist_i_h_wts[0,101]=1.27816834597780e-002;
    __statist_i_h_wts[0,102]=6.08525226812507e-002;
    __statist_i_h_wts[0,103]=3.96292877875266e-002;
    __statist_i_h_wts[0,104]=4.69073417445400e-002;
    __statist_i_h_wts[0,105]=6.72753477234811e-002;
    __statist_i_h_wts[0,106]=4.94521007893508e-002;
    __statist_i_h_wts[0,107]=3.26828577026048e-002;
    __statist_i_h_wts[0,108]=2.61968670121653e-002;
    __statist_i_h_wts[0,109]=5.10065831656979e-002;
    __statist_i_h_wts[0,110]=4.19686822450849e-002;
    __statist_i_h_wts[0,111]=5.06436813871279e-002;
    __statist_i_h_wts[0,112]=6.44746629935955e-002;
    __statist_i_h_wts[0,113]=3.75376066722144e-002;
    __statist_i_h_wts[0,114]=2.96562843408747e-002;
    __statist_i_h_wts[0,115]=2.71928173535218e-002;
    __statist_i_h_wts[0,116]=3.94929391220994e-002;
    __statist_i_h_wts[0,117]=6.37500773235271e-002;
    __statist_i_h_wts[0,118]=4.44974702317305e-002;
    __statist_i_h_wts[0,119]=5.16017840938608e-002;
    __statist_i_h_wts[0,120]=7.31886226099803e-002;
    __statist_i_h_wts[0,121]=4.92776328057857e-002;
    __statist_i_h_wts[0,122]=5.05108012912774e-002;
    __statist_i_h_wts[0,123]=3.70014396849982e-002;
    __statist_i_h_wts[0,124]=5.25769203061776e-002;
    __statist_i_h_wts[0,125]=4.49482763849861e-002;
    __statist_i_h_wts[0,126]=5.98864611132365e-002;
    __statist_i_h_wts[0,127]=5.97877001581072e-002;
    __statist_i_h_wts[0,128]=5.57025645509895e-002;
    __statist_i_h_wts[0,129]=5.64815149460542e-002;
    __statist_i_h_wts[0,130]=5.14948108372956e-002;
    __statist_i_h_wts[0,131]=2.94654531668157e-002;
    __statist_i_h_wts[0,132]=3.30128347680018e-002;
    __statist_i_h_wts[0,133]=4.20781771624257e-002;
    __statist_i_h_wts[0,134]=6.68297953349106e-002;
    __statist_i_h_wts[0,135]=7.01798762344828e-002;
    __statist_i_h_wts[0,136]=3.45200417459680e-002;
    __statist_i_h_wts[0,137]=6.94946576254180e-002;
    __statist_i_h_wts[0,138]=6.19783259365624e-002;
    __statist_i_h_wts[0,139]=6.73433917939643e-002;
    __statist_i_h_wts[0,140]=6.05252523161700e-002;
    __statist_i_h_wts[0,141]=8.19865069985279e-002;
    __statist_i_h_wts[0,142]=6.01401562951457e-002;
    __statist_i_h_wts[0,143]=7.10659297398272e-002;
    __statist_i_h_wts[0,144]=5.99117074237001e-002;
    __statist_i_h_wts[0,145]=5.79266165129573e-002;
    __statist_i_h_wts[0,146]=1.35121382092244e-002;
    __statist_i_h_wts[0,147]=2.33289884496711e-002;
    __statist_i_h_wts[0,148]=3.93866146697073e-002;
    __statist_i_h_wts[0,149]=7.59316711823987e-002;
    __statist_i_h_wts[0,150]=6.84716624200607e-002;
    __statist_i_h_wts[0,151]=3.11922932718702e-002;
    __statist_i_h_wts[0,152]=5.86157085979063e-002;
    __statist_i_h_wts[0,153]=6.25242369534731e-002;
    __statist_i_h_wts[0,154]=6.08650496336078e-002;
    __statist_i_h_wts[0,155]=3.86653934235067e-002;
    __statist_i_h_wts[0,156]=5.30763790522241e-002;
    __statist_i_h_wts[0,157]=3.33944803371733e-002;
    __statist_i_h_wts[0,158]=4.40218048047464e-002;
    __statist_i_h_wts[0,159]=4.37384166375785e-002;
    __statist_i_h_wts[0,160]=5.04888980253527e-002;
    __statist_i_h_wts[0,161]=3.51869259112508e-002;
    __statist_i_h_wts[0,162]=5.19857817046511e-002;
    __statist_i_h_wts[0,163]=4.84938211080334e-002;
    __statist_i_h_wts[0,164]=8.51889932338141e-002;
    __statist_i_h_wts[0,165]=5.74484840781000e-002;
    __statist_i_h_wts[0,166]=3.51415791784808e-002;
    __statist_i_h_wts[0,167]=5.91070699428275e-002;
    __statist_i_h_wts[0,168]=6.98030695232874e-002;
    __statist_i_h_wts[0,169]=6.97086440428760e-002;
    __statist_i_h_wts[0,170]=7.29497436139850e-002;
    __statist_i_h_wts[0,171]=3.89926303506582e-002;
    __statist_i_h_wts[0,172]=7.04576544451424e-002;
    __statist_i_h_wts[0,173]=8.04610898356660e-002;
    __statist_i_h_wts[0,174]=7.58810093053814e-002;
    __statist_i_h_wts[0,175]=6.85627579349577e-002;
    __statist_i_h_wts[0,176]=6.82021458791581e-002;
    __statist_i_h_wts[0,177]=5.81402304585375e-002;
    __statist_i_h_wts[0,178]=3.96638643629893e-002;
    __statist_i_h_wts[0,179]=7.86741989922140e-002;
    __statist_i_h_wts[0,180]=6.28645915910506e-002;
    __statist_i_h_wts[0,181]=3.88496546648994e-002;
    __statist_i_h_wts[0,182]=3.26821034941844e-002;
    __statist_i_h_wts[0,183]=4.54447859327688e-002;
    __statist_i_h_wts[0,184]=5.55809956203855e-002;
    __statist_i_h_wts[0,185]=7.17870260980603e-002;
    __statist_i_h_wts[0,186]=4.55472833864985e-002;
    __statist_i_h_wts[0,187]=7.60799177642143e-002;
    __statist_i_h_wts[0,188]=6.68301315075426e-002;
    __statist_i_h_wts[0,189]=6.66093648074698e-002;
    __statist_i_h_wts[0,190]=5.12154332511239e-002;
    __statist_i_h_wts[0,191]=6.55123915073638e-002;
    __statist_i_h_wts[0,192]=6.49411577493294e-002;
    __statist_i_h_wts[0,193]=4.35341051747164e-002;
    __statist_i_h_wts[0,194]=7.03941373750826e-002;
    __statist_i_h_wts[0,195]=6.66036063397890e-002;
    __statist_i_h_wts[0,196]=3.30649656480157e-002;
    __statist_i_h_wts[0,197]=5.97015626535770e-002;
    __statist_i_h_wts[0,198]=5.38410797520674e-002;
    __statist_i_h_wts[0,199]=5.82323142181809e-002;
    __statist_i_h_wts[0,200]=6.14568163749959e-002;
    __statist_i_h_wts[0,201]=2.89838083758405e-002;
    __statist_i_h_wts[0,202]=1.83459842093783e-002;
    __statist_i_h_wts[0,203]=3.61324789101868e-002;
    __statist_i_h_wts[0,204]=3.28530508585826e-002;
    __statist_i_h_wts[0,205]=2.95567671694302e-002;
    __statist_i_h_wts[0,206]=6.78473459669617e-002;
    __statist_i_h_wts[0,207]=8.04731819120632e-002;
    __statist_i_h_wts[0,208]=3.30861661422862e-002;
    __statist_i_h_wts[0,209]=8.94535782729352e-002;
    __statist_i_h_wts[0,210]=9.89549352176571e-002;
    __statist_i_h_wts[0,211]=6.60290939735486e-002;
    __statist_i_h_wts[0,212]=8.53662312272640e-002;
    __statist_i_h_wts[0,213]=9.18373592423413e-002;
    __statist_i_h_wts[0,214]=8.16849798237032e-002;
    __statist_i_h_wts[0,215]=7.30676161404352e-002;
    __statist_i_h_wts[0,216]=4.93591562245092e-002;
    __statist_i_h_wts[0,217]=5.23377581296579e-002;
    __statist_i_h_wts[0,218]=4.54569582705147e-002;
    __statist_i_h_wts[0,219]=5.62357301962529e-002;
    __statist_i_h_wts[0,220]=5.07212858894676e-002;
    __statist_i_h_wts[0,221]=7.22527515315873e-002;
    __statist_i_h_wts[0,222]=7.81180621885160e-002;
    __statist_i_h_wts[0,223]=6.18389634330123e-002;
    __statist_i_h_wts[0,224]=7.86827746961273e-002;
    __statist_i_h_wts[0,225]=3.44833181548992e-002;
    __statist_i_h_wts[0,226]=1.74119786822050e-002;
    __statist_i_h_wts[0,227]=1.94377550977794e-002;
    __statist_i_h_wts[0,228]=-1.29299365129046e-002;
    __statist_i_h_wts[0,229]=2.25520808742102e-002;
    __statist_i_h_wts[0,230]=2.97243583544886e-002;
    __statist_i_h_wts[0,231]=2.81818498368189e-004;
    __statist_i_h_wts[0,232]=7.58834937749774e-002;
    __statist_i_h_wts[0,233]=1.08082753607209e-002;
    __statist_i_h_wts[0,234]=2.97790213050742e-002;
    __statist_i_h_wts[0,235]=-3.05673020445545e-003;
    __statist_i_h_wts[0,236]=-2.80838908307523e-002;
    __statist_i_h_wts[0,237]=-1.26299543638312e-002;
    __statist_i_h_wts[0,238]=-3.99361832313159e-003;
    __statist_i_h_wts[0,239]=5.08410997598516e-002;
    __statist_i_h_wts[0,240]=8.32236205368153e-003;
    __statist_i_h_wts[0,241]=5.99668351628899e-002;
    __statist_i_h_wts[0,242]=1.99468940897357e-002;
    __statist_i_h_wts[0,243]=4.23544261169659e-002;
    __statist_i_h_wts[0,244]=1.68567820021390e-002;
    __statist_i_h_wts[0,245]=-2.87802914098243e-002;
    __statist_i_h_wts[0,246]=2.64446169673337e-002;
    __statist_i_h_wts[0,247]=-2.19992488229856e-002;
    __statist_i_h_wts[0,248]=2.76091686778707e-002;

    __statist_i_h_wts[1,0]=3.84196924386548e-001;
    __statist_i_h_wts[1,1]=7.81763299635290e-002;
    __statist_i_h_wts[1,2]=5.29073368114056e-001;
    __statist_i_h_wts[1,3]=3.33620263523581e-001;
    __statist_i_h_wts[1,4]=3.55848856168431e-002;
    __statist_i_h_wts[1,5]=8.98374361984598e-003;
    __statist_i_h_wts[1,6]=-5.67006503109354e-001;
    __statist_i_h_wts[1,7]=-1.63074352130042e-001;
    __statist_i_h_wts[1,8]=-9.08137318670526e-002;
    __statist_i_h_wts[1,9]=-7.26735411068286e-001;
    __statist_i_h_wts[1,10]=-4.93986114302221e-001;
    __statist_i_h_wts[1,11]=-3.29429856240771e-001;
    __statist_i_h_wts[1,12]=8.33648428916671e-003;
    __statist_i_h_wts[1,13]=2.06343967481422e-001;
    __statist_i_h_wts[1,14]=7.71002868119124e-001;
    __statist_i_h_wts[1,15]=-8.49685887806832e-002;
    __statist_i_h_wts[1,16]=-2.06170555661622e-001;
    __statist_i_h_wts[1,17]=-6.51277010262049e-002;
    __statist_i_h_wts[1,18]=-3.54216466851998e-002;
    __statist_i_h_wts[1,19]=2.49062014828192e-001;
    __statist_i_h_wts[1,20]=-2.10517151312552e-001;
    __statist_i_h_wts[1,21]=-2.10142194054082e-001;
    __statist_i_h_wts[1,22]=-7.34408559397494e-002;
    __statist_i_h_wts[1,23]=2.75652343156754e-001;
    __statist_i_h_wts[1,24]=1.59612976150326e-001;
    __statist_i_h_wts[1,25]=-1.05306207179199e-001;
    __statist_i_h_wts[1,26]=-2.17850470845543e-001;
    __statist_i_h_wts[1,27]=-6.56292242798314e-001;
    __statist_i_h_wts[1,28]=-6.50451557442211e-001;
    __statist_i_h_wts[1,29]=-3.50808192786639e-002;
    __statist_i_h_wts[1,30]=-9.96109717267958e-002;
    __statist_i_h_wts[1,31]=-2.54750112453733e-001;
    __statist_i_h_wts[1,32]=-1.08733875381011e-001;
    __statist_i_h_wts[1,33]=-5.76095399687848e-001;
    __statist_i_h_wts[1,34]=1.37102319337624e-001;
    __statist_i_h_wts[1,35]=-3.37411622866851e-001;
    __statist_i_h_wts[1,36]=-3.08502775491854e-001;
    __statist_i_h_wts[1,37]=-2.42422064266931e-001;
    __statist_i_h_wts[1,38]=3.51279585644660e-001;
    __statist_i_h_wts[1,39]=-4.55861571195140e-002;
    __statist_i_h_wts[1,40]=2.07779407600736e-001;
    __statist_i_h_wts[1,41]=-1.32831471027348e-001;
    __statist_i_h_wts[1,42]=1.22428123524853e-001;
    __statist_i_h_wts[1,43]=-7.24571505399601e-001;
    __statist_i_h_wts[1,44]=-1.65479302863278e-001;
    __statist_i_h_wts[1,45]=6.51754881962630e-002;
    __statist_i_h_wts[1,46]=-2.11326743031014e-001;
    __statist_i_h_wts[1,47]=-1.90196002145198e-001;
    __statist_i_h_wts[1,48]=-5.74997496011861e-001;
    __statist_i_h_wts[1,49]=-6.89638623020283e-001;
    __statist_i_h_wts[1,50]=-6.55159037219746e-001;
    __statist_i_h_wts[1,51]=-5.38555315413842e-001;
    __statist_i_h_wts[1,52]=-5.50675112021353e-001;
    __statist_i_h_wts[1,53]=-6.62060007475374e-001;
    __statist_i_h_wts[1,54]=-9.97294415246163e-001;
    __statist_i_h_wts[1,55]=-7.99224649761944e-001;
    __statist_i_h_wts[1,56]=-2.98498510921968e-001;
    __statist_i_h_wts[1,57]=-7.34890436140684e-002;
    __statist_i_h_wts[1,58]=-1.14428544627294e-001;
    __statist_i_h_wts[1,59]=-3.18865326542996e-001;
    __statist_i_h_wts[1,60]=-3.03338942082899e-001;
    __statist_i_h_wts[1,61]=-1.16894079186750e-001;
    __statist_i_h_wts[1,62]=-2.02273035314900e-001;
    __statist_i_h_wts[1,63]=-3.78756526419671e-001;
    __statist_i_h_wts[1,64]=-1.11313077970879e-001;
    __statist_i_h_wts[1,65]=-2.58919654073366e-001;
    __statist_i_h_wts[1,66]=-1.79013202838272e-001;
    __statist_i_h_wts[1,67]=-1.56489938272162e-001;
    __statist_i_h_wts[1,68]=4.69915753153272e-002;
    __statist_i_h_wts[1,69]=-2.48529618526548e-001;
    __statist_i_h_wts[1,70]=-5.86669522372513e-001;
    __statist_i_h_wts[1,71]=2.86362765952486e-001;
    __statist_i_h_wts[1,72]=-3.74063535062402e-001;
    __statist_i_h_wts[1,73]=-4.77584335800949e-001;
    __statist_i_h_wts[1,74]=-4.55625865066982e-002;
    __statist_i_h_wts[1,75]=-3.98958413553866e-001;
    __statist_i_h_wts[1,76]=-3.62258704387744e-001;
    __statist_i_h_wts[1,77]=-9.11561469302058e-001;
    __statist_i_h_wts[1,78]=-5.99315642878532e-001;
    __statist_i_h_wts[1,79]=-1.93322339415085e-001;
    __statist_i_h_wts[1,80]=-1.20751585049209e-001;
    __statist_i_h_wts[1,81]=2.66854088146422e-001;
    __statist_i_h_wts[1,82]=3.37853580076314e-001;
    __statist_i_h_wts[1,83]=3.60381891517805e-001;
    __statist_i_h_wts[1,84]=3.06774731142859e-001;
    __statist_i_h_wts[1,85]=-2.72391001710389e-001;
    __statist_i_h_wts[1,86]=2.50970006918311e-001;
    __statist_i_h_wts[1,87]=-5.93754951214890e-001;
    __statist_i_h_wts[1,88]=-6.87746268171866e-001;
    __statist_i_h_wts[1,89]=-1.03155392042465e-001;
    __statist_i_h_wts[1,90]=3.66259021713715e-002;
    __statist_i_h_wts[1,91]=-4.98624279411505e-002;
    __statist_i_h_wts[1,92]=-5.53547599236312e-001;
    __statist_i_h_wts[1,93]=-6.71532096793170e-002;
    __statist_i_h_wts[1,94]=1.31921414665071e-001;
    __statist_i_h_wts[1,95]=2.62219292835234e-001;
    __statist_i_h_wts[1,96]=-4.12767301619072e-001;
    __statist_i_h_wts[1,97]=-1.06215620631947e-001;
    __statist_i_h_wts[1,98]=6.11106663443106e-001;
    __statist_i_h_wts[1,99]=5.63816757253320e-001;
    __statist_i_h_wts[1,100]=-2.77023798999395e-001;
    __statist_i_h_wts[1,101]=1.29167420190803e-001;
    __statist_i_h_wts[1,102]=-1.21484216925813e-001;
    __statist_i_h_wts[1,103]=-2.08077522509268e-001;
    __statist_i_h_wts[1,104]=-1.97161476960836e-001;
    __statist_i_h_wts[1,105]=-2.27146538069603e-001;
    __statist_i_h_wts[1,106]=6.52095073732768e-002;
    __statist_i_h_wts[1,107]=-1.91630071937250e-001;
    __statist_i_h_wts[1,108]=1.63690114794530e-002;
    __statist_i_h_wts[1,109]=-3.16432701395054e-002;
    __statist_i_h_wts[1,110]=1.01941664120771e-002;
    __statist_i_h_wts[1,111]=-2.85987922766512e-001;
    __statist_i_h_wts[1,112]=-8.31818782284107e-001;
    __statist_i_h_wts[1,113]=-5.85068065955484e-002;
    __statist_i_h_wts[1,114]=2.15667209443462e-001;
    __statist_i_h_wts[1,115]=-1.18873060129407e-001;
    __statist_i_h_wts[1,116]=-2.20983617789928e-001;
    __statist_i_h_wts[1,117]=5.46052344166646e-001;
    __statist_i_h_wts[1,118]=4.20055615088795e-001;
    __statist_i_h_wts[1,119]=1.96530536131678e-001;
    __statist_i_h_wts[1,120]=2.40416710589544e-001;
    __statist_i_h_wts[1,121]=3.68599999082991e-001;
    __statist_i_h_wts[1,122]=6.91023397381024e-001;
    __statist_i_h_wts[1,123]=2.14295981655637e-001;
    __statist_i_h_wts[1,124]=2.71964193956173e-001;
    __statist_i_h_wts[1,125]=4.97930855348752e-001;
    __statist_i_h_wts[1,126]=2.75901612437615e-001;
    __statist_i_h_wts[1,127]=-1.01449287924711e+000;
    __statist_i_h_wts[1,128]=-3.29281709523427e-001;
    __statist_i_h_wts[1,129]=2.81901047855234e-001;
    __statist_i_h_wts[1,130]=1.68553721944440e-001;
    __statist_i_h_wts[1,131]=-4.07572399555866e-002;
    __statist_i_h_wts[1,132]=7.15795886674666e-001;
    __statist_i_h_wts[1,133]=2.52094136644358e-001;
    __statist_i_h_wts[1,134]=8.61291532425737e-001;
    __statist_i_h_wts[1,135]=2.91218241887368e-001;
    __statist_i_h_wts[1,136]=9.96700351300341e-002;
    __statist_i_h_wts[1,137]=-1.89010998027876e-002;
    __statist_i_h_wts[1,138]=-1.04568845085911e-001;
    __statist_i_h_wts[1,139]=3.34688822497578e-001;
    __statist_i_h_wts[1,140]=5.37437507721066e-001;
    __statist_i_h_wts[1,141]=6.50300660802551e-001;
    __statist_i_h_wts[1,142]=-4.82687883053522e-001;
    __statist_i_h_wts[1,143]=-1.74244838890201e-002;
    __statist_i_h_wts[1,144]=2.63958680889453e-001;
    __statist_i_h_wts[1,145]=-3.05486581448334e-002;
    __statist_i_h_wts[1,146]=-3.40001470874866e-001;
    __statist_i_h_wts[1,147]=-4.23244310172816e-001;
    __statist_i_h_wts[1,148]=-3.22505549282840e-001;
    __statist_i_h_wts[1,149]=-4.67684539539929e-002;
    __statist_i_h_wts[1,150]=4.95547945084798e-001;
    __statist_i_h_wts[1,151]=4.38391710111449e-001;
    __statist_i_h_wts[1,152]=3.28089748813311e-001;
    __statist_i_h_wts[1,153]=4.73693984495381e-001;
    __statist_i_h_wts[1,154]=2.90168851050728e-001;
    __statist_i_h_wts[1,155]=3.43971147289241e-002;
    __statist_i_h_wts[1,156]=2.79515550330485e-001;
    __statist_i_h_wts[1,157]=3.01213319042370e-001;
    __statist_i_h_wts[1,158]=-3.54831922437593e-001;
    __statist_i_h_wts[1,159]=1.96799703940453e-001;
    __statist_i_h_wts[1,160]=5.51025108158486e-002;
    __statist_i_h_wts[1,161]=4.12575768051610e-002;
    __statist_i_h_wts[1,162]=-8.07307201733662e-001;
    __statist_i_h_wts[1,163]=-2.26594000920518e-001;
    __statist_i_h_wts[1,164]=4.70516076378104e-002;
    __statist_i_h_wts[1,165]=-2.70394289393983e-001;
    __statist_i_h_wts[1,166]=-4.64898213537219e-001;
    __statist_i_h_wts[1,167]=-4.56526878004341e-001;
    __statist_i_h_wts[1,168]=1.11705373922602e-001;
    __statist_i_h_wts[1,169]=4.66291757071178e-001;
    __statist_i_h_wts[1,170]=-1.47089717874895e-001;
    __statist_i_h_wts[1,171]=9.17515921453859e-002;
    __statist_i_h_wts[1,172]=-6.59902241679136e-002;
    __statist_i_h_wts[1,173]=-7.40885696183954e-002;
    __statist_i_h_wts[1,174]=4.32877875170155e-002;
    __statist_i_h_wts[1,175]=5.04979450196152e-001;
    __statist_i_h_wts[1,176]=1.96853993421670e-001;
    __statist_i_h_wts[1,177]=-2.12426901485688e-001;
    __statist_i_h_wts[1,178]=3.57622050784825e-001;
    __statist_i_h_wts[1,179]=5.38827748861904e-001;
    __statist_i_h_wts[1,180]=1.23272595230879e-001;
    __statist_i_h_wts[1,181]=-2.84680053565016e-001;
    __statist_i_h_wts[1,182]=-5.28570609275530e-001;
    __statist_i_h_wts[1,183]=3.45672877816226e-002;
    __statist_i_h_wts[1,184]=1.08113522675065e-001;
    __statist_i_h_wts[1,185]=-2.54878229243455e-001;
    __statist_i_h_wts[1,186]=3.28003690819983e-001;
    __statist_i_h_wts[1,187]=4.37023768888406e-001;
    __statist_i_h_wts[1,188]=8.64342305500729e-002;
    __statist_i_h_wts[1,189]=2.38093360389191e-001;
    __statist_i_h_wts[1,190]=8.28891143052692e-002;
    __statist_i_h_wts[1,191]=1.22202893685614e-001;
    __statist_i_h_wts[1,192]=9.36321253755364e-003;
    __statist_i_h_wts[1,193]=3.36577796448694e-001;
    __statist_i_h_wts[1,194]=5.94994379049530e-001;
    __statist_i_h_wts[1,195]=2.60619308404143e-001;
    __statist_i_h_wts[1,196]=2.54158301555590e-001;
    __statist_i_h_wts[1,197]=1.22326022429636e-001;
    __statist_i_h_wts[1,198]=-2.21255028418502e-001;
    __statist_i_h_wts[1,199]=-3.68397891786285e-002;
    __statist_i_h_wts[1,200]=-4.80483776598314e-001;
    __statist_i_h_wts[1,201]=1.69527133919735e-002;
    __statist_i_h_wts[1,202]=4.25858628002036e-001;
    __statist_i_h_wts[1,203]=3.36916540074664e-001;
    __statist_i_h_wts[1,204]=2.75208313058371e-001;
    __statist_i_h_wts[1,205]=-8.86917872231538e-002;
    __statist_i_h_wts[1,206]=-4.21098009306354e-001;
    __statist_i_h_wts[1,207]=-3.38091358096901e-001;
    __statist_i_h_wts[1,208]=1.82034554631072e-001;
    __statist_i_h_wts[1,209]=1.28489968202134e-001;
    __statist_i_h_wts[1,210]=4.58796356292100e-001;
    __statist_i_h_wts[1,211]=4.04112389343081e-001;
    __statist_i_h_wts[1,212]=3.86120989051038e-001;
    __statist_i_h_wts[1,213]=2.97954311869890e-001;
    __statist_i_h_wts[1,214]=1.85330880300426e-001;
    __statist_i_h_wts[1,215]=-1.63227007502302e-001;
    __statist_i_h_wts[1,216]=-3.06120963220804e-001;
    __statist_i_h_wts[1,217]=-1.38143072669291e-001;
    __statist_i_h_wts[1,218]=-1.93633787518662e-001;
    __statist_i_h_wts[1,219]=-1.97946162227716e-001;
    __statist_i_h_wts[1,220]=2.70675052275907e-001;
    __statist_i_h_wts[1,221]=-3.97730978928311e-002;
    __statist_i_h_wts[1,222]=9.01317674501669e-002;
    __statist_i_h_wts[1,223]=7.32604359077965e-001;
    __statist_i_h_wts[1,224]=5.04745006514656e-001;
    __statist_i_h_wts[1,225]=-3.74926233029218e-002;
    __statist_i_h_wts[1,226]=-6.43447017119196e-001;
    __statist_i_h_wts[1,227]=5.18421555165837e-001;
    __statist_i_h_wts[1,228]=-4.75480440048439e-001;
    __statist_i_h_wts[1,229]=-6.79220988157771e-001;
    __statist_i_h_wts[1,230]=4.39928691768904e-001;
    __statist_i_h_wts[1,231]=-4.37155985293969e-001;
    __statist_i_h_wts[1,232]=2.62596594527686e-001;
    __statist_i_h_wts[1,233]=-2.96512982231763e-001;
    __statist_i_h_wts[1,234]=-2.26578361012743e-001;
    __statist_i_h_wts[1,235]=-1.37084435904154e-001;
    __statist_i_h_wts[1,236]=-8.67911905724438e-001;
    __statist_i_h_wts[1,237]=-1.26738707744571e+000;
    __statist_i_h_wts[1,238]=2.25389976074236e-001;
    __statist_i_h_wts[1,239]=8.26150347902338e-001;
    __statist_i_h_wts[1,240]=2.85536587695667e-001;
    __statist_i_h_wts[1,241]=3.87598754605391e+000;
    __statist_i_h_wts[1,242]=-1.23884829423948e-001;
    __statist_i_h_wts[1,243]=6.92246963802349e-001;
    __statist_i_h_wts[1,244]=3.12057828635042e-001;
    __statist_i_h_wts[1,245]=-9.90195052477746e-001;
    __statist_i_h_wts[1,246]=6.80308115931889e-001;
    __statist_i_h_wts[1,247]=5.78955909527348e-002;
    __statist_i_h_wts[1,248]=9.74524984269980e-001;

    __statist_i_h_wts[2,0]=-6.77472821538963e-002;
    __statist_i_h_wts[2,1]=2.10286764577474e-002;
    __statist_i_h_wts[2,2]=1.51116801083284e-001;
    __statist_i_h_wts[2,3]=1.75675774486263e-001;
    __statist_i_h_wts[2,4]=2.11866443917086e-001;
    __statist_i_h_wts[2,5]=2.71086914593639e-001;
    __statist_i_h_wts[2,6]=2.23172377060670e-001;
    __statist_i_h_wts[2,7]=2.18047298889776e-001;
    __statist_i_h_wts[2,8]=1.56984688004536e-001;
    __statist_i_h_wts[2,9]=4.89948700261321e-002;
    __statist_i_h_wts[2,10]=3.06903055596718e-002;
    __statist_i_h_wts[2,11]=1.00436410586293e-001;
    __statist_i_h_wts[2,12]=1.36553705378066e-001;
    __statist_i_h_wts[2,13]=-1.13485897366727e-002;
    __statist_i_h_wts[2,14]=4.90311875114744e-002;
    __statist_i_h_wts[2,15]=-1.24075752397658e-001;
    __statist_i_h_wts[2,16]=-4.16613729383098e-002;
    __statist_i_h_wts[2,17]=1.73944654624834e-001;
    __statist_i_h_wts[2,18]=1.57439524461860e-001;
    __statist_i_h_wts[2,19]=2.07954423829722e-001;
    __statist_i_h_wts[2,20]=2.83068991934045e-001;
    __statist_i_h_wts[2,21]=2.41621986513269e-001;
    __statist_i_h_wts[2,22]=1.51387442845026e-001;
    __statist_i_h_wts[2,23]=1.22024041901659e-001;
    __statist_i_h_wts[2,24]=2.01914399313247e-002;
    __statist_i_h_wts[2,25]=4.52992556866261e-002;
    __statist_i_h_wts[2,26]=4.42315313296618e-002;
    __statist_i_h_wts[2,27]=7.01372507825260e-002;
    __statist_i_h_wts[2,28]=-8.55542626542580e-002;
    __statist_i_h_wts[2,29]=5.78132744046468e-002;
    __statist_i_h_wts[2,30]=-1.01021779540977e-001;
    __statist_i_h_wts[2,31]=-6.98146501522218e-002;
    __statist_i_h_wts[2,32]=9.49152707817177e-002;
    __statist_i_h_wts[2,33]=5.70443607894602e-002;
    __statist_i_h_wts[2,34]=8.34517241576629e-002;
    __statist_i_h_wts[2,35]=2.52007698229201e-001;
    __statist_i_h_wts[2,36]=1.67684780447954e-001;
    __statist_i_h_wts[2,37]=1.34326478358058e-001;
    __statist_i_h_wts[2,38]=1.92356791049940e-001;
    __statist_i_h_wts[2,39]=7.71382706914724e-002;
    __statist_i_h_wts[2,40]=1.80635955232468e-001;
    __statist_i_h_wts[2,41]=1.24793120969461e-001;
    __statist_i_h_wts[2,42]=1.91294135235712e-001;
    __statist_i_h_wts[2,43]=-4.48227456341228e-002;
    __statist_i_h_wts[2,44]=1.35473881626427e-001;
    __statist_i_h_wts[2,45]=-1.21870152449072e-002;
    __statist_i_h_wts[2,46]=-1.96018198918127e-002;
    __statist_i_h_wts[2,47]=1.35070762414195e-001;
    __statist_i_h_wts[2,48]=1.08281993075389e-001;
    __statist_i_h_wts[2,49]=1.69952657475747e-001;
    __statist_i_h_wts[2,50]=2.13787707710468e-001;
    __statist_i_h_wts[2,51]=1.91690915506359e-001;
    __statist_i_h_wts[2,52]=1.23224726798683e-001;
    __statist_i_h_wts[2,53]=1.22535089736544e-001;
    __statist_i_h_wts[2,54]=1.63478334181281e-002;
    __statist_i_h_wts[2,55]=7.25291159865045e-002;
    __statist_i_h_wts[2,56]=1.22978227020008e-001;
    __statist_i_h_wts[2,57]=1.32883097964218e-001;
    __statist_i_h_wts[2,58]=-6.04979096511322e-003;
    __statist_i_h_wts[2,59]=3.86558535400796e-002;
    __statist_i_h_wts[2,60]=2.31544028141788e-002;
    __statist_i_h_wts[2,61]=5.35404940667907e-002;
    __statist_i_h_wts[2,62]=2.00904440895165e-001;
    __statist_i_h_wts[2,63]=1.93100325711075e-001;
    __statist_i_h_wts[2,64]=2.47472603559930e-001;
    __statist_i_h_wts[2,65]=3.24200816866022e-001;
    __statist_i_h_wts[2,66]=3.42733852880005e-001;
    __statist_i_h_wts[2,67]=1.93257684979614e-001;
    __statist_i_h_wts[2,68]=2.18111645913155e-001;
    __statist_i_h_wts[2,69]=9.01832631134868e-002;
    __statist_i_h_wts[2,70]=2.36748899458283e-002;
    __statist_i_h_wts[2,71]=3.14175412310439e-002;
    __statist_i_h_wts[2,72]=-6.69586489072027e-002;
    __statist_i_h_wts[2,73]=-1.13438696050940e-001;
    __statist_i_h_wts[2,74]=-4.63961020824267e-002;
    __statist_i_h_wts[2,75]=3.40298252993494e-003;
    __statist_i_h_wts[2,76]=2.35755103066364e-002;
    __statist_i_h_wts[2,77]=6.99888016346361e-002;
    __statist_i_h_wts[2,78]=1.38680638396254e-001;
    __statist_i_h_wts[2,79]=1.88371863301237e-001;
    __statist_i_h_wts[2,80]=1.73405887375713e-001;
    __statist_i_h_wts[2,81]=2.20336529180598e-001;
    __statist_i_h_wts[2,82]=6.65673972832876e-002;
    __statist_i_h_wts[2,83]=1.39801108673726e-001;
    __statist_i_h_wts[2,84]=3.46024788845960e-002;
    __statist_i_h_wts[2,85]=2.76682279313984e-002;
    __statist_i_h_wts[2,86]=6.08866828849226e-002;
    __statist_i_h_wts[2,87]=-1.02776264349015e-001;
    __statist_i_h_wts[2,88]=-1.33158584432463e-001;
    __statist_i_h_wts[2,89]=-1.11636586122372e-003;
    __statist_i_h_wts[2,90]=4.19970999733291e-002;
    __statist_i_h_wts[2,91]=1.49224997854333e-002;
    __statist_i_h_wts[2,92]=-8.88953335645063e-002;
    __statist_i_h_wts[2,93]=6.94950082195298e-002;
    __statist_i_h_wts[2,94]=5.68577408553731e-002;
    __statist_i_h_wts[2,95]=-2.34291414529493e-003;
    __statist_i_h_wts[2,96]=7.07709648292061e-002;
    __statist_i_h_wts[2,97]=-5.20109454300081e-002;
    __statist_i_h_wts[2,98]=2.79623232634510e-002;
    __statist_i_h_wts[2,99]=-4.19837148476328e-002;
    __statist_i_h_wts[2,100]=-2.30451522923253e-002;
    __statist_i_h_wts[2,101]=-4.69278290467818e-002;
    __statist_i_h_wts[2,102]=-1.21783436170501e-001;
    __statist_i_h_wts[2,103]=-1.13236001228379e-001;
    __statist_i_h_wts[2,104]=-3.26580612259321e-003;
    __statist_i_h_wts[2,105]=-9.87426933963574e-002;
    __statist_i_h_wts[2,106]=-3.24914048814319e-002;
    __statist_i_h_wts[2,107]=-6.34027682132731e-002;
    __statist_i_h_wts[2,108]=1.07039645282597e-001;
    __statist_i_h_wts[2,109]=1.83352623392360e-001;
    __statist_i_h_wts[2,110]=4.79985478024414e-002;
    __statist_i_h_wts[2,111]=1.27214975543218e-001;
    __statist_i_h_wts[2,112]=2.85510804604822e-002;
    __statist_i_h_wts[2,113]=-3.04169454644490e-002;
    __statist_i_h_wts[2,114]=3.94873107763027e-002;
    __statist_i_h_wts[2,115]=-8.45739495837329e-002;
    __statist_i_h_wts[2,116]=-7.92312752097823e-002;
    __statist_i_h_wts[2,117]=-8.64529506491349e-002;
    __statist_i_h_wts[2,118]=-7.01169745080166e-003;
    __statist_i_h_wts[2,119]=1.97449067178237e-003;
    __statist_i_h_wts[2,120]=6.92297291754628e-002;
    __statist_i_h_wts[2,121]=8.19563611708608e-002;
    __statist_i_h_wts[2,122]=-3.49709867336494e-003;
    __statist_i_h_wts[2,123]=1.12645890145380e-002;
    __statist_i_h_wts[2,124]=2.60483265189685e-002;
    __statist_i_h_wts[2,125]=8.17038602009173e-002;
    __statist_i_h_wts[2,126]=8.74738012925776e-002;
    __statist_i_h_wts[2,127]=-8.97082620090248e-002;
    __statist_i_h_wts[2,128]=-9.30754844986567e-002;
    __statist_i_h_wts[2,129]=-3.84655380910074e-002;
    __statist_i_h_wts[2,130]=1.63568556279926e-002;
    __statist_i_h_wts[2,131]=7.87275970432520e-002;
    __statist_i_h_wts[2,132]=4.76017855860939e-002;
    __statist_i_h_wts[2,133]=2.00634865920105e-002;
    __statist_i_h_wts[2,134]=1.16443164697461e-001;
    __statist_i_h_wts[2,135]=-3.28286383505731e-002;
    __statist_i_h_wts[2,136]=2.21454501147678e-002;
    __statist_i_h_wts[2,137]=-6.69522457748354e-002;
    __statist_i_h_wts[2,138]=1.59609958346721e-002;
    __statist_i_h_wts[2,139]=-2.23441091255321e-002;
    __statist_i_h_wts[2,140]=1.08796203633599e-001;
    __statist_i_h_wts[2,141]=1.30546946340811e-001;
    __statist_i_h_wts[2,142]=-1.09196431166394e-001;
    __statist_i_h_wts[2,143]=-4.06710124218136e-002;
    __statist_i_h_wts[2,144]=-2.28429922634151e-002;
    __statist_i_h_wts[2,145]=-1.28719882000014e-001;
    __statist_i_h_wts[2,146]=-6.70848078603723e-002;
    __statist_i_h_wts[2,147]=-1.64073097620018e-001;
    __statist_i_h_wts[2,148]=-1.86073497792333e-001;
    __statist_i_h_wts[2,149]=-8.69236488337128e-002;
    __statist_i_h_wts[2,150]=-1.63675836076680e-001;
    __statist_i_h_wts[2,151]=-1.05034515218984e-001;
    __statist_i_h_wts[2,152]=-1.71579526584260e-001;
    __statist_i_h_wts[2,153]=2.76986693711272e-002;
    __statist_i_h_wts[2,154]=-8.26478126259013e-002;
    __statist_i_h_wts[2,155]=7.34771769018859e-004;
    __statist_i_h_wts[2,156]=-3.43396563956472e-002;
    __statist_i_h_wts[2,157]=-1.09138906746023e-001;
    __statist_i_h_wts[2,158]=-1.87744828866858e-001;
    __statist_i_h_wts[2,159]=-9.22672575852537e-002;
    __statist_i_h_wts[2,160]=-1.19228822932370e-001;
    __statist_i_h_wts[2,161]=4.04692150055383e-002;
    __statist_i_h_wts[2,162]=-1.56410899642714e-001;
    __statist_i_h_wts[2,163]=-4.07815956970969e-002;
    __statist_i_h_wts[2,164]=2.80190183979918e-002;
    __statist_i_h_wts[2,165]=-1.16920128636403e-001;
    __statist_i_h_wts[2,166]=-1.04438153050690e-001;
    __statist_i_h_wts[2,167]=-1.82590078211556e-001;
    __statist_i_h_wts[2,168]=-4.34094700677425e-002;
    __statist_i_h_wts[2,169]=-2.11444385083452e-002;
    __statist_i_h_wts[2,170]=2.22938197411576e-002;
    __statist_i_h_wts[2,171]=2.21442914206372e-002;
    __statist_i_h_wts[2,172]=-7.27774772251790e-002;
    __statist_i_h_wts[2,173]=-1.11018807270778e-001;
    __statist_i_h_wts[2,174]=-1.19539991962090e-001;
    __statist_i_h_wts[2,175]=-7.84977135623916e-002;
    __statist_i_h_wts[2,176]=-7.46521823643299e-002;
    __statist_i_h_wts[2,177]=-2.04654646211553e-001;
    __statist_i_h_wts[2,178]=-7.46825865091869e-002;
    __statist_i_h_wts[2,179]=-6.64245008667745e-002;
    __statist_i_h_wts[2,180]=2.09433067282729e-002;
    __statist_i_h_wts[2,181]=2.87027184088745e-003;
    __statist_i_h_wts[2,182]=-4.91474938585080e-002;
    __statist_i_h_wts[2,183]=9.38509537379304e-002;
    __statist_i_h_wts[2,184]=4.85353045748937e-002;
    __statist_i_h_wts[2,185]=8.40364866896826e-002;
    __statist_i_h_wts[2,186]=1.20922829241544e-001;
    __statist_i_h_wts[2,187]=8.70220603002243e-002;
    __statist_i_h_wts[2,188]=-2.61434664345561e-002;
    __statist_i_h_wts[2,189]=1.28079719838034e-002;
    __statist_i_h_wts[2,190]=3.36422996682268e-002;
    __statist_i_h_wts[2,191]=1.20773010700713e-002;
    __statist_i_h_wts[2,192]=-8.34163170110273e-002;
    __statist_i_h_wts[2,193]=2.26778080065564e-002;
    __statist_i_h_wts[2,194]=6.64284564396960e-002;
    __statist_i_h_wts[2,195]=2.39472997834400e-002;
    __statist_i_h_wts[2,196]=5.95566350015331e-002;
    __statist_i_h_wts[2,197]=8.64523265166722e-003;
    __statist_i_h_wts[2,198]=1.34464302880405e-002;
    __statist_i_h_wts[2,199]=-1.35402351664266e-002;
    __statist_i_h_wts[2,200]=-3.63925690085216e-002;
    __statist_i_h_wts[2,201]=5.03342834802098e-002;
    __statist_i_h_wts[2,202]=1.43351626958292e-001;
    __statist_i_h_wts[2,203]=1.03749086392843e-001;
    __statist_i_h_wts[2,204]=9.51202625559866e-002;
    __statist_i_h_wts[2,205]=8.09219831815210e-002;
    __statist_i_h_wts[2,206]=2.80490445616324e-002;
    __statist_i_h_wts[2,207]=7.28520774047957e-003;
    __statist_i_h_wts[2,208]=1.08141210240462e-001;
    __statist_i_h_wts[2,209]=7.55983422180072e-002;
    __statist_i_h_wts[2,210]=5.22925063253017e-002;
    __statist_i_h_wts[2,211]=7.97867071154473e-002;
    __statist_i_h_wts[2,212]=2.36681064516508e-002;
    __statist_i_h_wts[2,213]=-9.08990862132973e-004;
    __statist_i_h_wts[2,214]=-5.38514037788381e-003;
    __statist_i_h_wts[2,215]=8.39063181816706e-003;
    __statist_i_h_wts[2,216]=6.09563848207889e-002;
    __statist_i_h_wts[2,217]=1.31653406424303e-001;
    __statist_i_h_wts[2,218]=8.19503678838172e-002;
    __statist_i_h_wts[2,219]=9.47211471466589e-003;
    __statist_i_h_wts[2,220]=-4.60655247137853e-002;
    __statist_i_h_wts[2,221]=-3.33285783227105e-002;
    __statist_i_h_wts[2,222]=-5.57095236788532e-002;
    __statist_i_h_wts[2,223]=1.28025941269710e-001;
    __statist_i_h_wts[2,224]=9.04950847766756e-002;
    __statist_i_h_wts[2,225]=3.80628280422868e-002;
    __statist_i_h_wts[2,226]=-6.60298405664540e-001;
    __statist_i_h_wts[2,227]=7.25294798539560e-002;
    __statist_i_h_wts[2,228]=-5.69157049136533e-001;
    __statist_i_h_wts[2,229]=8.36350603627161e-002;
    __statist_i_h_wts[2,230]=9.06746672330563e-001;
    __statist_i_h_wts[2,231]=2.42717789921973e-002;
    __statist_i_h_wts[2,232]=6.55135443162693e-001;
    __statist_i_h_wts[2,233]=3.23988675091996e-001;
    __statist_i_h_wts[2,234]=1.05069729611570e+000;
    __statist_i_h_wts[2,235]=-4.04058993652447e-001;
    __statist_i_h_wts[2,236]=-1.17485125163277e+000;
    __statist_i_h_wts[2,237]=-1.39428177873232e+000;
    __statist_i_h_wts[2,238]=-3.61548896367348e-001;
    __statist_i_h_wts[2,239]=5.07417450940819e-001;
    __statist_i_h_wts[2,240]=-4.24528510912014e-001;
    __statist_i_h_wts[2,241]=3.38921632930204e+000;
    __statist_i_h_wts[2,242]=-9.06441580318763e-002;
    __statist_i_h_wts[2,243]=7.07213892251032e-001;
    __statist_i_h_wts[2,244]=1.44576073063140e-001;
    __statist_i_h_wts[2,245]=-1.63739235341519e+000;
    __statist_i_h_wts[2,246]=8.72882234850359e-001;
    __statist_i_h_wts[2,247]=-6.15651282954206e-001;
    __statist_i_h_wts[2,248]=3.59282466135395e-001;

    __statist_i_h_wts[3,0]=-1.72748812024367e-001;
    __statist_i_h_wts[3,1]=-2.63569329814255e-001;
    __statist_i_h_wts[3,2]=-2.38243993904092e-002;
    __statist_i_h_wts[3,3]=-1.79480518540466e-001;
    __statist_i_h_wts[3,4]=-1.41743924136460e-001;
    __statist_i_h_wts[3,5]=-1.82040105859481e-001;
    __statist_i_h_wts[3,6]=-1.45525864758024e-001;
    __statist_i_h_wts[3,7]=2.74315820608356e-002;
    __statist_i_h_wts[3,8]=9.25990098457150e-002;
    __statist_i_h_wts[3,9]=3.36986028827028e-002;
    __statist_i_h_wts[3,10]=6.07492885878587e-003;
    __statist_i_h_wts[3,11]=-4.07831765263773e-001;
    __statist_i_h_wts[3,12]=-3.13529015481173e-001;
    __statist_i_h_wts[3,13]=-2.11855414748207e-001;
    __statist_i_h_wts[3,14]=2.35452711836708e-001;
    __statist_i_h_wts[3,15]=-3.73257027705557e-001;
    __statist_i_h_wts[3,16]=-2.98731883675144e-001;
    __statist_i_h_wts[3,17]=2.30135924762361e-001;
    __statist_i_h_wts[3,18]=2.06856169717759e-001;
    __statist_i_h_wts[3,19]=2.31235228050163e-001;
    __statist_i_h_wts[3,20]=1.21369413297617e-001;
    __statist_i_h_wts[3,21]=2.92230195268160e-002;
    __statist_i_h_wts[3,22]=-7.18525322581559e-002;
    __statist_i_h_wts[3,23]=-1.76393059373507e-002;
    __statist_i_h_wts[3,24]=8.04999765088180e-002;
    __statist_i_h_wts[3,25]=1.02901049835222e-001;
    __statist_i_h_wts[3,26]=-1.51970811244407e-001;
    __statist_i_h_wts[3,27]=-1.87947499691961e-001;
    __statist_i_h_wts[3,28]=-9.48135257091733e-002;
    __statist_i_h_wts[3,29]=2.21074999559173e-001;
    __statist_i_h_wts[3,30]=-1.63854008626237e-001;
    __statist_i_h_wts[3,31]=-1.60433701721702e-001;
    __statist_i_h_wts[3,32]=4.79618058441895e-001;
    __statist_i_h_wts[3,33]=-2.44363467373264e-001;
    __statist_i_h_wts[3,34]=2.60209094468890e-002;
    __statist_i_h_wts[3,35]=-7.17443618253346e-002;
    __statist_i_h_wts[3,36]=1.11265449137956e-001;
    __statist_i_h_wts[3,37]=4.69560802950343e-002;
    __statist_i_h_wts[3,38]=2.87610297297800e-001;
    __statist_i_h_wts[3,39]=-1.50996896184062e-001;
    __statist_i_h_wts[3,40]=6.08657932096236e-001;
    __statist_i_h_wts[3,41]=7.42118675455410e-002;
    __statist_i_h_wts[3,42]=3.43738174313378e-001;
    __statist_i_h_wts[3,43]=-1.34686819415840e-001;
    __statist_i_h_wts[3,44]=1.55622442829182e-001;
    __statist_i_h_wts[3,45]=6.31844620518589e-001;
    __statist_i_h_wts[3,46]=9.52596256735960e-002;
    __statist_i_h_wts[3,47]=-1.63818435820163e-002;
    __statist_i_h_wts[3,48]=3.65222229521443e-002;
    __statist_i_h_wts[3,49]=-1.80671987912359e-002;
    __statist_i_h_wts[3,50]=1.46944791380674e-001;
    __statist_i_h_wts[3,51]=-8.46132963425765e-002;
    __statist_i_h_wts[3,52]=-2.94577311530154e-001;
    __statist_i_h_wts[3,53]=-4.02152712640708e-001;
    __statist_i_h_wts[3,54]=-2.27822435981740e-001;
    __statist_i_h_wts[3,55]=2.60116461411390e-001;
    __statist_i_h_wts[3,56]=-2.63980576138385e-001;
    __statist_i_h_wts[3,57]=-7.02478850806803e-002;
    __statist_i_h_wts[3,58]=1.39691731218316e-001;
    __statist_i_h_wts[3,59]=-3.35754886543383e-001;
    __statist_i_h_wts[3,60]=1.64353811955706e-001;
    __statist_i_h_wts[3,61]=-5.33006569802013e-002;
    __statist_i_h_wts[3,62]=1.34276499764166e-001;
    __statist_i_h_wts[3,63]=1.20929250472536e-001;
    __statist_i_h_wts[3,64]=1.84774795723387e-002;
    __statist_i_h_wts[3,65]=-7.63469941970921e-002;
    __statist_i_h_wts[3,66]=4.07255178555971e-001;
    __statist_i_h_wts[3,67]=-2.79396117833307e-001;
    __statist_i_h_wts[3,68]=-4.11479187257390e-002;
    __statist_i_h_wts[3,69]=-9.12086343787795e-002;
    __statist_i_h_wts[3,70]=5.39057983925601e-002;
    __statist_i_h_wts[3,71]=-2.65737722348429e-001;
    __statist_i_h_wts[3,72]=-2.67578704057142e-001;
    __statist_i_h_wts[3,73]=2.56107323817739e-001;
    __statist_i_h_wts[3,74]=3.73411617223013e-001;
    __statist_i_h_wts[3,75]=-5.11491545825311e-002;
    __statist_i_h_wts[3,76]=-8.56056612194791e-002;
    __statist_i_h_wts[3,77]=-7.35676460780310e-002;
    __statist_i_h_wts[3,78]=5.37283321133762e-002;
    __statist_i_h_wts[3,79]=-3.02635093905556e-001;
    __statist_i_h_wts[3,80]=-1.06268463720219e-001;
    __statist_i_h_wts[3,81]=2.71207190678825e-001;
    __statist_i_h_wts[3,82]=2.11414404135255e-001;
    __statist_i_h_wts[3,83]=1.68421196930733e-001;
    __statist_i_h_wts[3,84]=-4.05838936604815e-001;
    __statist_i_h_wts[3,85]=-7.65564310567318e-002;
    __statist_i_h_wts[3,86]=-3.58786421292550e-001;
    __statist_i_h_wts[3,87]=-2.96061475886448e-001;
    __statist_i_h_wts[3,88]=1.16904078843812e-001;
    __statist_i_h_wts[3,89]=1.74827047598982e-001;
    __statist_i_h_wts[3,90]=-2.07526580629854e-001;
    __statist_i_h_wts[3,91]=-2.22647648313283e-001;
    __statist_i_h_wts[3,92]=-7.12073595241450e-001;
    __statist_i_h_wts[3,93]=-2.13615944576258e-001;
    __statist_i_h_wts[3,94]=-4.65480000922236e-001;
    __statist_i_h_wts[3,95]=-1.66746373412265e-001;
    __statist_i_h_wts[3,96]=-1.51264194656738e-001;
    __statist_i_h_wts[3,97]=2.31846713005205e-001;
    __statist_i_h_wts[3,98]=3.56341631332425e-001;
    __statist_i_h_wts[3,99]=-4.53495704048268e-001;
    __statist_i_h_wts[3,100]=3.10830714203153e-001;
    __statist_i_h_wts[3,101]=-1.83694305927265e-001;
    __statist_i_h_wts[3,102]=-2.43308966519099e-001;
    __statist_i_h_wts[3,103]=4.25955505882853e-001;
    __statist_i_h_wts[3,104]=1.92008778350309e-001;
    __statist_i_h_wts[3,105]=-2.59639757606553e-001;
    __statist_i_h_wts[3,106]=1.02375152323281e-002;
    __statist_i_h_wts[3,107]=-3.37066394942177e-001;
    __statist_i_h_wts[3,108]=6.54766509840931e-002;
    __statist_i_h_wts[3,109]=4.10390230481760e-001;
    __statist_i_h_wts[3,110]=-4.83674010979750e-001;
    __statist_i_h_wts[3,111]=1.40257077481835e-001;
    __statist_i_h_wts[3,112]=4.16870941971089e-001;
    __statist_i_h_wts[3,113]=-4.40944601204852e-001;
    __statist_i_h_wts[3,114]=-2.38148666736444e-001;
    __statist_i_h_wts[3,115]=-1.76515250716754e-001;
    __statist_i_h_wts[3,116]=-9.09079312959612e-001;
    __statist_i_h_wts[3,117]=-2.76972097183923e-001;
    __statist_i_h_wts[3,118]=5.39518859514889e-001;
    __statist_i_h_wts[3,119]=-9.00919630585025e-002;
    __statist_i_h_wts[3,120]=2.36132270792494e-001;
    __statist_i_h_wts[3,121]=1.79224044313374e-003;
    __statist_i_h_wts[3,122]=-1.33878413095040e-001;
    __statist_i_h_wts[3,123]=-4.76375654061140e-001;
    __statist_i_h_wts[3,124]=-4.48824950484319e-001;
    __statist_i_h_wts[3,125]=4.95318879585422e-002;
    __statist_i_h_wts[3,126]=-9.97393130469292e-002;
    __statist_i_h_wts[3,127]=-9.10712010274394e-002;
    __statist_i_h_wts[3,128]=-4.17558232200519e-001;
    __statist_i_h_wts[3,129]=-3.64736365736421e-001;
    __statist_i_h_wts[3,130]=7.13515157916419e-002;
    __statist_i_h_wts[3,131]=-1.43435760118788e-001;
    __statist_i_h_wts[3,132]=3.16546061934212e-001;
    __statist_i_h_wts[3,133]=1.75194796346067e-002;
    __statist_i_h_wts[3,134]=2.99328844050678e-001;
    __statist_i_h_wts[3,135]=1.02655045440886e-001;
    __statist_i_h_wts[3,136]=-1.00588040807183e-001;
    __statist_i_h_wts[3,137]=-5.33667774291303e-001;
    __statist_i_h_wts[3,138]=-4.43062064795321e-001;
    __statist_i_h_wts[3,139]=-2.66609596692556e-001;
    __statist_i_h_wts[3,140]=2.81492157110873e-001;
    __statist_i_h_wts[3,141]=5.24777889610991e-001;
    __statist_i_h_wts[3,142]=-4.41197545945696e-001;
    __statist_i_h_wts[3,143]=-5.49471170462000e-001;
    __statist_i_h_wts[3,144]=-5.17802060170317e-001;
    __statist_i_h_wts[3,145]=-2.07936955806263e-001;
    __statist_i_h_wts[3,146]=5.46960500053921e-002;
    __statist_i_h_wts[3,147]=1.65699446512252e-001;
    __statist_i_h_wts[3,148]=-9.07107314956384e-002;
    __statist_i_h_wts[3,149]=-6.14472718949945e-002;
    __statist_i_h_wts[3,150]=-8.70215678394466e-002;
    __statist_i_h_wts[3,151]=2.40892929784187e-001;
    __statist_i_h_wts[3,152]=-1.22016623985990e-001;
    __statist_i_h_wts[3,153]=3.63226020079640e-001;
    __statist_i_h_wts[3,154]=3.02555770885026e-001;
    __statist_i_h_wts[3,155]=3.19885923115161e-001;
    __statist_i_h_wts[3,156]=3.43015823982880e-002;
    __statist_i_h_wts[3,157]=-2.01494701052920e-002;
    __statist_i_h_wts[3,158]=-2.43989244339129e-001;
    __statist_i_h_wts[3,159]=-4.10782901653291e-002;
    __statist_i_h_wts[3,160]=-2.26343026022741e-001;
    __statist_i_h_wts[3,161]=6.86904638183992e-001;
    __statist_i_h_wts[3,162]=1.30257237291082e-002;
    __statist_i_h_wts[3,163]=1.49923031839045e-001;
    __statist_i_h_wts[3,164]=1.41726534015876e-001;
    __statist_i_h_wts[3,165]=-7.37550473439118e-002;
    __statist_i_h_wts[3,166]=1.75109351200305e-001;
    __statist_i_h_wts[3,167]=-7.73465861436592e-002;
    __statist_i_h_wts[3,168]=-4.20406176510941e-002;
    __statist_i_h_wts[3,169]=2.40699483655698e-001;
    __statist_i_h_wts[3,170]=1.27801234883988e-001;
    __statist_i_h_wts[3,171]=5.69851182248067e-002;
    __statist_i_h_wts[3,172]=-4.16532548689441e-001;
    __statist_i_h_wts[3,173]=1.51772626874135e-001;
    __statist_i_h_wts[3,174]=-3.48084745854818e-002;
    __statist_i_h_wts[3,175]=1.99581175799466e-001;
    __statist_i_h_wts[3,176]=3.06667549299055e-001;
    __statist_i_h_wts[3,177]=7.26643179761298e-002;
    __statist_i_h_wts[3,178]=-1.00484933101486e-001;
    __statist_i_h_wts[3,179]=-5.24597696305723e-001;
    __statist_i_h_wts[3,180]=3.22366797969569e-001;
    __statist_i_h_wts[3,181]=-1.32820594233354e-001;
    __statist_i_h_wts[3,182]=-5.21745616650330e-001;
    __statist_i_h_wts[3,183]=1.63027921840433e-001;
    __statist_i_h_wts[3,184]=2.49784101950701e-001;
    __statist_i_h_wts[3,185]=3.29264308449081e-001;
    __statist_i_h_wts[3,186]=-2.13931459262398e-001;
    __statist_i_h_wts[3,187]=-4.10495168618313e-001;
    __statist_i_h_wts[3,188]=9.72452036947245e-003;
    __statist_i_h_wts[3,189]=2.04672325253578e-001;
    __statist_i_h_wts[3,190]=1.20304519204439e-001;
    __statist_i_h_wts[3,191]=1.00940098775273e-001;
    __statist_i_h_wts[3,192]=2.36801538144016e-001;
    __statist_i_h_wts[3,193]=-3.36537550632540e-001;
    __statist_i_h_wts[3,194]=-3.02644518095936e-001;
    __statist_i_h_wts[3,195]=4.64369199075285e-001;
    __statist_i_h_wts[3,196]=5.53547439335114e-001;
    __statist_i_h_wts[3,197]=3.37558769561531e-002;
    __statist_i_h_wts[3,198]=-8.31555912633495e-002;
    __statist_i_h_wts[3,199]=5.15359664129261e-001;
    __statist_i_h_wts[3,200]=9.00089484646475e-002;
    __statist_i_h_wts[3,201]=-1.57510020437018e-001;
    __statist_i_h_wts[3,202]=-1.87133574177885e-001;
    __statist_i_h_wts[3,203]=2.05715238197893e-001;
    __statist_i_h_wts[3,204]=1.93162062083162e-001;
    __statist_i_h_wts[3,205]=6.07331781926527e-002;
    __statist_i_h_wts[3,206]=1.19415677327196e-002;
    __statist_i_h_wts[3,207]=2.22528460206560e-001;
    __statist_i_h_wts[3,208]=1.54868540793523e-001;
    __statist_i_h_wts[3,209]=-1.90711654781621e-001;
    __statist_i_h_wts[3,210]=2.37175624402558e-001;
    __statist_i_h_wts[3,211]=4.79363554574123e-001;
    __statist_i_h_wts[3,212]=2.51174191050976e-001;
    __statist_i_h_wts[3,213]=-5.65871464590851e-003;
    __statist_i_h_wts[3,214]=1.42422093695820e-001;
    __statist_i_h_wts[3,215]=7.68102737427666e-002;
    __statist_i_h_wts[3,216]=1.56759466528152e-003;
    __statist_i_h_wts[3,217]=7.98623687984201e-002;
    __statist_i_h_wts[3,218]=2.41580569485559e-001;
    __statist_i_h_wts[3,219]=-1.87790647325614e-001;
    __statist_i_h_wts[3,220]=-2.60816201902449e-001;
    __statist_i_h_wts[3,221]=-1.29327177334800e-001;
    __statist_i_h_wts[3,222]=-4.80801591335826e-003;
    __statist_i_h_wts[3,223]=4.90571986922232e-001;
    __statist_i_h_wts[3,224]=9.29098064909903e-003;
    __statist_i_h_wts[3,225]=-4.86185840999704e-001;
    __statist_i_h_wts[3,226]=-4.44913297134697e-001;
    __statist_i_h_wts[3,227]=-4.39763129398195e-001;
    __statist_i_h_wts[3,228]=-9.69778717465583e-002;
    __statist_i_h_wts[3,229]=1.22434392897423e-001;
    __statist_i_h_wts[3,230]=8.79007784339297e-001;
    __statist_i_h_wts[3,231]=-2.73071404901784e-002;
    __statist_i_h_wts[3,232]=-1.17815228324569e+000;
    __statist_i_h_wts[3,233]=-3.42789233199695e-001;
    __statist_i_h_wts[3,234]=-2.29045078694956e-001;
    __statist_i_h_wts[3,235]=-6.96073711288064e-001;
    __statist_i_h_wts[3,236]=-5.77057025168857e-001;
    __statist_i_h_wts[3,237]=-1.32361097083593e+000;
    __statist_i_h_wts[3,238]=-4.43012817198317e-001;
    __statist_i_h_wts[3,239]=4.52321447650442e-001;
    __statist_i_h_wts[3,240]=9.34825732748739e-001;
    __statist_i_h_wts[3,241]=3.88058442740376e+000;
    __statist_i_h_wts[3,242]=3.73565863650512e-001;
    __statist_i_h_wts[3,243]=6.56556859494173e-001;
    __statist_i_h_wts[3,244]=-5.92954661272268e-002;
    __statist_i_h_wts[3,245]=-1.39655546398822e-001;
    __statist_i_h_wts[3,246]=5.33297689725783e-001;
    __statist_i_h_wts[3,247]=1.64758095973011e-001;
    __statist_i_h_wts[3,248]=1.19176483570047e-001;

    __statist_i_h_wts[4,0]=2.12046356401929e-001;
    __statist_i_h_wts[4,1]=-1.73099605610243e-001;
    __statist_i_h_wts[4,2]=3.55227895954813e-001;
    __statist_i_h_wts[4,3]=-1.03356241846722e-002;
    __statist_i_h_wts[4,4]=-1.37068146577058e-002;
    __statist_i_h_wts[4,5]=-2.89914968252153e-001;
    __statist_i_h_wts[4,6]=-6.28228822297654e-001;
    __statist_i_h_wts[4,7]=3.02695499437854e-001;
    __statist_i_h_wts[4,8]=-2.46640072118878e-001;
    __statist_i_h_wts[4,9]=-2.19796646315818e-001;
    __statist_i_h_wts[4,10]=-8.51592189653553e-002;
    __statist_i_h_wts[4,11]=-7.05353866213964e-001;
    __statist_i_h_wts[4,12]=2.76236837429123e-001;
    __statist_i_h_wts[4,13]=1.45051226517466e-001;
    __statist_i_h_wts[4,14]=3.48110171322178e-001;
    __statist_i_h_wts[4,15]=-1.03811189824323e+000;
    __statist_i_h_wts[4,16]=-6.06635403845645e-001;
    __statist_i_h_wts[4,17]=-7.44682016425002e-002;
    __statist_i_h_wts[4,18]=2.87367297359698e-001;
    __statist_i_h_wts[4,19]=-1.29382250059883e-001;
    __statist_i_h_wts[4,20]=-3.93143786940296e-001;
    __statist_i_h_wts[4,21]=-5.27666945073825e-001;
    __statist_i_h_wts[4,22]=-3.52350409367544e-001;
    __statist_i_h_wts[4,23]=-9.06663370503959e-001;
    __statist_i_h_wts[4,24]=-1.82155993544237e-001;
    __statist_i_h_wts[4,25]=2.39734906063317e-002;
    __statist_i_h_wts[4,26]=2.28796683990915e-001;
    __statist_i_h_wts[4,27]=3.39426166718819e-001;
    __statist_i_h_wts[4,28]=-1.55181643529938e-001;
    __statist_i_h_wts[4,29]=-1.73451895072977e-001;
    __statist_i_h_wts[4,30]=-2.68819053545476e-001;
    __statist_i_h_wts[4,31]=-3.27982067879284e-001;
    __statist_i_h_wts[4,32]=5.42602134109840e-001;
    __statist_i_h_wts[4,33]=-2.15113490448431e-002;
    __statist_i_h_wts[4,34]=-5.10267096131754e-001;
    __statist_i_h_wts[4,35]=-8.73614862522878e-001;
    __statist_i_h_wts[4,36]=4.08243268403885e-001;
    __statist_i_h_wts[4,37]=4.22047005166308e-001;
    __statist_i_h_wts[4,38]=6.52659882154050e-001;
    __statist_i_h_wts[4,39]=-2.54424546220486e-001;
    __statist_i_h_wts[4,40]=3.54145318780627e-001;
    __statist_i_h_wts[4,41]=2.17903338244129e-001;
    __statist_i_h_wts[4,42]=1.36728436125316e+000;
    __statist_i_h_wts[4,43]=-1.33643828538582e+000;
    __statist_i_h_wts[4,44]=-3.07126506214171e-001;
    __statist_i_h_wts[4,45]=4.82886488573987e-001;
    __statist_i_h_wts[4,46]=1.43335110933957e-001;
    __statist_i_h_wts[4,47]=-6.89011004186008e-001;
    __statist_i_h_wts[4,48]=6.14609189744418e-002;
    __statist_i_h_wts[4,49]=-8.34901412110761e-001;
    __statist_i_h_wts[4,50]=1.27915094754452e-001;
    __statist_i_h_wts[4,51]=5.24732077408268e-001;
    __statist_i_h_wts[4,52]=2.30264715067912e-001;
    __statist_i_h_wts[4,53]=-1.75434540354775e-001;
    __statist_i_h_wts[4,54]=-2.37962505751179e-001;
    __statist_i_h_wts[4,55]=-2.85492143387124e-002;
    __statist_i_h_wts[4,56]=-7.31449855281692e-001;
    __statist_i_h_wts[4,57]=3.28207993841775e-001;
    __statist_i_h_wts[4,58]=-1.23158494550626e-001;
    __statist_i_h_wts[4,59]=-3.77368010098853e-001;
    __statist_i_h_wts[4,60]=-4.08937831413886e-001;
    __statist_i_h_wts[4,61]=2.31329953038001e-001;
    __statist_i_h_wts[4,62]=-3.98678963622808e-001;
    __statist_i_h_wts[4,63]=-4.41053037810249e-001;
    __statist_i_h_wts[4,64]=-2.21268263129818e-001;
    __statist_i_h_wts[4,65]=2.27145845420380e-001;
    __statist_i_h_wts[4,66]=3.28805040689145e-001;
    __statist_i_h_wts[4,67]=-2.64548041689286e-001;
    __statist_i_h_wts[4,68]=5.26436524661119e-001;
    __statist_i_h_wts[4,69]=-2.78189760967290e-001;
    __statist_i_h_wts[4,70]=-3.09943766958399e-002;
    __statist_i_h_wts[4,71]=2.18219227606732e-001;
    __statist_i_h_wts[4,72]=-6.99007207251923e-001;
    __statist_i_h_wts[4,73]=-4.47599838805945e-001;
    __statist_i_h_wts[4,74]=4.73381814239135e-001;
    __statist_i_h_wts[4,75]=-1.95767375946895e-001;
    __statist_i_h_wts[4,76]=3.61027947577048e-001;
    __statist_i_h_wts[4,77]=4.31441259739581e-001;
    __statist_i_h_wts[4,78]=-6.04374951820612e-001;
    __statist_i_h_wts[4,79]=-8.84714190580167e-002;
    __statist_i_h_wts[4,80]=1.44048501434610e-001;
    __statist_i_h_wts[4,81]=6.74043949081728e-001;
    __statist_i_h_wts[4,82]=-4.08444457849560e-001;
    __statist_i_h_wts[4,83]=1.56139985987058e-001;
    __statist_i_h_wts[4,84]=-1.49062174979792e-001;
    __statist_i_h_wts[4,85]=-2.07259052545845e-001;
    __statist_i_h_wts[4,86]=5.79275777440937e-001;
    __statist_i_h_wts[4,87]=-6.90296622000040e-002;
    __statist_i_h_wts[4,88]=-1.86556484842674e-001;
    __statist_i_h_wts[4,89]=7.33912524715833e-001;
    __statist_i_h_wts[4,90]=1.52953500995292e-001;
    __statist_i_h_wts[4,91]=-1.86219897712834e-001;
    __statist_i_h_wts[4,92]=-5.15287212000913e-001;
    __statist_i_h_wts[4,93]=7.47123774627108e-001;
    __statist_i_h_wts[4,94]=6.87954660990417e-001;
    __statist_i_h_wts[4,95]=-6.57272765200896e-001;
    __statist_i_h_wts[4,96]=-3.65901679302489e-001;
    __statist_i_h_wts[4,97]=-1.55076782533175e-003;
    __statist_i_h_wts[4,98]=-2.20055106388425e-001;
    __statist_i_h_wts[4,99]=2.86613380258285e-002;
    __statist_i_h_wts[4,100]=5.68105976416933e-001;
    __statist_i_h_wts[4,101]=-5.07884203387250e-001;
    __statist_i_h_wts[4,102]=1.64335656833261e-001;
    __statist_i_h_wts[4,103]=4.83770886809924e-001;
    __statist_i_h_wts[4,104]=-2.11071537325482e-002;
    __statist_i_h_wts[4,105]=3.47577715771069e-002;
    __statist_i_h_wts[4,106]=-3.18696132409956e-001;
    __statist_i_h_wts[4,107]=2.72354610294902e-001;
    __statist_i_h_wts[4,108]=8.61426079397528e-001;
    __statist_i_h_wts[4,109]=1.38513378527252e+000;
    __statist_i_h_wts[4,110]=-1.05503022291183e+000;
    __statist_i_h_wts[4,111]=2.82942847631986e-001;
    __statist_i_h_wts[4,112]=9.10297501759975e-001;
    __statist_i_h_wts[4,113]=-1.47953469429208e-001;
    __statist_i_h_wts[4,114]=3.49507290327522e-001;
    __statist_i_h_wts[4,115]=3.83199332385365e-002;
    __statist_i_h_wts[4,116]=-1.28431492205226e+000;
    __statist_i_h_wts[4,117]=-2.08319333979215e-001;
    __statist_i_h_wts[4,118]=1.14838622012101e-001;
    __statist_i_h_wts[4,119]=-9.89889701914655e-001;
    __statist_i_h_wts[4,120]=1.86857166797459e-001;
    __statist_i_h_wts[4,121]=-5.91376560746344e-001;
    __statist_i_h_wts[4,122]=7.70043422838558e-001;
    __statist_i_h_wts[4,123]=-9.29507826137693e-001;
    __statist_i_h_wts[4,124]=-5.45375722437882e-001;
    __statist_i_h_wts[4,125]=1.11688757366381e+000;
    __statist_i_h_wts[4,126]=-3.66150474024863e-001;
    __statist_i_h_wts[4,127]=-4.70787930200177e-001;
    __statist_i_h_wts[4,128]=-7.47254982135035e-001;
    __statist_i_h_wts[4,129]=-7.78042458377035e-001;
    __statist_i_h_wts[4,130]=-1.85246370220037e-001;
    __statist_i_h_wts[4,131]=-1.50924430906545e-001;
    __statist_i_h_wts[4,132]=1.89733259858159e+000;
    __statist_i_h_wts[4,133]=-1.08597775552297e-001;
    __statist_i_h_wts[4,134]=1.38441614363165e-001;
    __statist_i_h_wts[4,135]=2.02493077259961e-001;
    __statist_i_h_wts[4,136]=-5.45236401718707e-001;
    __statist_i_h_wts[4,137]=-5.02921784724192e-001;
    __statist_i_h_wts[4,138]=-1.65863096529653e-001;
    __statist_i_h_wts[4,139]=-9.18712339466340e-001;
    __statist_i_h_wts[4,140]=9.09749754842927e-001;
    __statist_i_h_wts[4,141]=3.30428911839906e-001;
    __statist_i_h_wts[4,142]=-3.94595063771878e-001;
    __statist_i_h_wts[4,143]=9.12441402842973e-001;
    __statist_i_h_wts[4,144]=7.53270205457433e-001;
    __statist_i_h_wts[4,145]=1.15097977450424e-001;
    __statist_i_h_wts[4,146]=-3.17463880667152e-001;
    __statist_i_h_wts[4,147]=2.36434716876556e-001;
    __statist_i_h_wts[4,148]=-3.26638098959160e-002;
    __statist_i_h_wts[4,149]=1.99611529122047e-001;
    __statist_i_h_wts[4,150]=3.54153216439770e-001;
    __statist_i_h_wts[4,151]=4.10706735162058e-001;
    __statist_i_h_wts[4,152]=-1.94574100041546e-001;
    __statist_i_h_wts[4,153]=6.23635225580804e-001;
    __statist_i_h_wts[4,154]=-4.49481166713712e-001;
    __statist_i_h_wts[4,155]=-1.76244222206447e-001;
    __statist_i_h_wts[4,156]=-4.57944357188779e-001;
    __statist_i_h_wts[4,157]=3.86939841313758e-001;
    __statist_i_h_wts[4,158]=-3.52698020003016e-001;
    __statist_i_h_wts[4,159]=6.30077351907632e-001;
    __statist_i_h_wts[4,160]=-7.38525441612512e-001;
    __statist_i_h_wts[4,161]=9.06872620731259e-001;
    __statist_i_h_wts[4,162]=-1.38607415265334e+000;
    __statist_i_h_wts[4,163]=-3.26311713276027e-001;
    __statist_i_h_wts[4,164]=5.36036553540675e-002;
    __statist_i_h_wts[4,165]=2.41519552827524e-001;
    __statist_i_h_wts[4,166]=2.38936497115957e-001;
    __statist_i_h_wts[4,167]=-2.94973500334423e-002;
    __statist_i_h_wts[4,168]=-8.79279593072076e-001;
    __statist_i_h_wts[4,169]=3.88530769454688e-002;
    __statist_i_h_wts[4,170]=4.96621762263659e-002;
    __statist_i_h_wts[4,171]=6.00527418036666e-001;
    __statist_i_h_wts[4,172]=-3.48270959334832e-001;
    __statist_i_h_wts[4,173]=-2.91637118143052e-001;
    __statist_i_h_wts[4,174]=-2.19890650473634e-001;
    __statist_i_h_wts[4,175]=1.73359889029601e-001;
    __statist_i_h_wts[4,176]=-8.44213933579299e-002;
    __statist_i_h_wts[4,177]=-5.29859078884368e-001;
    __statist_i_h_wts[4,178]=4.46165760841357e-001;
    __statist_i_h_wts[4,179]=5.64341066594360e-001;
    __statist_i_h_wts[4,180]=5.47887476752783e-001;
    __statist_i_h_wts[4,181]=-5.01789997202123e-001;
    __statist_i_h_wts[4,182]=-4.29616297657420e-001;
    __statist_i_h_wts[4,183]=1.24816163281953e+000;
    __statist_i_h_wts[4,184]=2.07150762070340e-001;
    __statist_i_h_wts[4,185]=4.35298001384408e-001;
    __statist_i_h_wts[4,186]=3.58361818649051e-001;
    __statist_i_h_wts[4,187]=-1.80900750159941e-001;
    __statist_i_h_wts[4,188]=-2.75573238570861e-001;
    __statist_i_h_wts[4,189]=8.24918463659302e-001;
    __statist_i_h_wts[4,190]=-6.07396854477593e-001;
    __statist_i_h_wts[4,191]=-2.47085072349323e-001;
    __statist_i_h_wts[4,192]=3.04270876514612e-001;
    __statist_i_h_wts[4,193]=-5.66161951690394e-001;
    __statist_i_h_wts[4,194]=2.45734841645021e-001;
    __statist_i_h_wts[4,195]=7.98405857164103e-002;
    __statist_i_h_wts[4,196]=4.38372804227982e-002;
    __statist_i_h_wts[4,197]=-3.98291878907256e-001;
    __statist_i_h_wts[4,198]=-7.28259666119053e-001;
    __statist_i_h_wts[4,199]=5.26068470653354e-001;
    __statist_i_h_wts[4,200]=-1.05603733070024e+000;
    __statist_i_h_wts[4,201]=7.19836795770315e-002;
    __statist_i_h_wts[4,202]=-2.38453058234960e-001;
    __statist_i_h_wts[4,203]=-6.93301815463549e-002;
    __statist_i_h_wts[4,204]=7.24248022466975e-001;
    __statist_i_h_wts[4,205]=1.27208864408630e-001;
    __statist_i_h_wts[4,206]=-1.34296129487869e-001;
    __statist_i_h_wts[4,207]=-4.92766022470666e-001;
    __statist_i_h_wts[4,208]=2.26823926309616e-001;
    __statist_i_h_wts[4,209]=-1.19443599492084e-001;
    __statist_i_h_wts[4,210]=1.90745935751021e-001;
    __statist_i_h_wts[4,211]=2.46068017596915e-001;
    __statist_i_h_wts[4,212]=1.06063269194246e-001;
    __statist_i_h_wts[4,213]=-6.20390614236831e-002;
    __statist_i_h_wts[4,214]=3.88836646396128e-001;
    __statist_i_h_wts[4,215]=-6.79049682888088e-001;
    __statist_i_h_wts[4,216]=5.09358589949316e-003;
    __statist_i_h_wts[4,217]=3.44172428714320e-001;
    __statist_i_h_wts[4,218]=5.57090048668315e-001;
    __statist_i_h_wts[4,219]=-2.21016051849880e-001;
    __statist_i_h_wts[4,220]=1.38382583010263e-001;
    __statist_i_h_wts[4,221]=5.05370685576385e-001;
    __statist_i_h_wts[4,222]=3.99564727755851e-001;
    __statist_i_h_wts[4,223]=1.09071189348981e+000;
    __statist_i_h_wts[4,224]=3.60390673447216e-001;
    __statist_i_h_wts[4,225]=4.84998787283084e-001;
    __statist_i_h_wts[4,226]=1.58697039654684e-001;
    __statist_i_h_wts[4,227]=3.74048888462756e-001;
    __statist_i_h_wts[4,228]=-8.84788804448407e-001;
    __statist_i_h_wts[4,229]=-3.51845015259793e-001;
    __statist_i_h_wts[4,230]=-4.34569009632593e-001;
    __statist_i_h_wts[4,231]=-4.32336099443813e-001;
    __statist_i_h_wts[4,232]=-1.73068494751481e+000;
    __statist_i_h_wts[4,233]=-1.61450648116189e+000;
    __statist_i_h_wts[4,234]=-1.35741978678649e+000;
    __statist_i_h_wts[4,235]=-3.24075003662724e-001;
    __statist_i_h_wts[4,236]=-1.46469260709230e+000;
    __statist_i_h_wts[4,237]=-2.71094612167865e+000;
    __statist_i_h_wts[4,238]=-1.47212364970040e-001;
    __statist_i_h_wts[4,239]=3.17716489080626e-004;
    __statist_i_h_wts[4,240]=1.13101817453864e+000;
    __statist_i_h_wts[4,241]=6.80009515343303e+000;
    __statist_i_h_wts[4,242]=1.23446346611139e+000;
    __statist_i_h_wts[4,243]=1.19553957515379e+000;
    __statist_i_h_wts[4,244]=-3.37490386197223e-001;
    __statist_i_h_wts[4,245]=8.04261840838855e-001;
    __statist_i_h_wts[4,246]=2.54739256425685e+000;
    __statist_i_h_wts[4,247]=1.67206415846785e+000;
    __statist_i_h_wts[4,248]=-9.96321369918110e-003;

    __statist_i_h_wts[5,0]=4.60209790940983e-001;
    __statist_i_h_wts[5,1]=3.31151781760976e-001;
    __statist_i_h_wts[5,2]=5.89390533881832e-001;
    __statist_i_h_wts[5,3]=-2.64765241428024e-002;
    __statist_i_h_wts[5,4]=-4.95930429257344e-001;
    __statist_i_h_wts[5,5]=-2.87061863366980e-001;
    __statist_i_h_wts[5,6]=-2.17379802492231e-001;
    __statist_i_h_wts[5,7]=-4.27508632313381e-001;
    __statist_i_h_wts[5,8]=1.78207460410888e-001;
    __statist_i_h_wts[5,9]=-2.09525081003131e-001;
    __statist_i_h_wts[5,10]=-1.52815251250820e-001;
    __statist_i_h_wts[5,11]=2.43239529821477e-001;
    __statist_i_h_wts[5,12]=2.03715071992294e-001;
    __statist_i_h_wts[5,13]=-9.22001904813706e-002;
    __statist_i_h_wts[5,14]=-2.09011527103787e-001;
    __statist_i_h_wts[5,15]=7.08444942733025e-002;
    __statist_i_h_wts[5,16]=3.03068806386500e-001;
    __statist_i_h_wts[5,17]=6.34015533267189e-001;
    __statist_i_h_wts[5,18]=4.60152942333281e-001;
    __statist_i_h_wts[5,19]=1.17737469584610e-001;
    __statist_i_h_wts[5,20]=1.13467373351402e-001;
    __statist_i_h_wts[5,21]=1.19806190506102e-001;
    __statist_i_h_wts[5,22]=-2.44653409764803e-001;
    __statist_i_h_wts[5,23]=6.82788160121065e-002;
    __statist_i_h_wts[5,24]=-3.72946063017039e-001;
    __statist_i_h_wts[5,25]=2.80384310908930e-002;
    __statist_i_h_wts[5,26]=-2.01820827523552e-001;
    __statist_i_h_wts[5,27]=-2.67545831828316e-001;
    __statist_i_h_wts[5,28]=-1.96909230497440e-001;
    __statist_i_h_wts[5,29]=-5.23174790307117e-001;
    __statist_i_h_wts[5,30]=-1.74350551669485e-001;
    __statist_i_h_wts[5,31]=1.99848213759342e-001;
    __statist_i_h_wts[5,32]=7.06081828970842e-001;
    __statist_i_h_wts[5,33]=-4.28229766754655e-001;
    __statist_i_h_wts[5,34]=-1.57099572790926e-002;
    __statist_i_h_wts[5,35]=-2.38578508724921e-001;
    __statist_i_h_wts[5,36]=3.52820634231273e-001;
    __statist_i_h_wts[5,37]=-4.50742805070623e-001;
    __statist_i_h_wts[5,38]=1.05053069933021e+000;
    __statist_i_h_wts[5,39]=-7.47425794463488e-001;
    __statist_i_h_wts[5,40]=9.26831311786205e-002;
    __statist_i_h_wts[5,41]=-1.02107519552316e-001;
    __statist_i_h_wts[5,42]=-4.75694738988199e-002;
    __statist_i_h_wts[5,43]=-1.28130969863024e-001;
    __statist_i_h_wts[5,44]=-3.92873632815331e-001;
    __statist_i_h_wts[5,45]=3.69007580073643e-001;
    __statist_i_h_wts[5,46]=2.55972018681009e-001;
    __statist_i_h_wts[5,47]=-2.24514521834368e-002;
    __statist_i_h_wts[5,48]=-3.96865753912909e-001;
    __statist_i_h_wts[5,49]=3.69804685568705e-001;
    __statist_i_h_wts[5,50]=-6.80313623544767e-002;
    __statist_i_h_wts[5,51]=-4.56551924865435e-001;
    __statist_i_h_wts[5,52]=6.17916252126700e-001;
    __statist_i_h_wts[5,53]=6.02283766568985e-001;
    __statist_i_h_wts[5,54]=4.34237204247804e-002;
    __statist_i_h_wts[5,55]=1.99733551455881e-001;
    __statist_i_h_wts[5,56]=-4.07235411123296e-002;
    __statist_i_h_wts[5,57]=1.24165632141745e-001;
    __statist_i_h_wts[5,58]=3.98899970923339e-001;
    __statist_i_h_wts[5,59]=-4.24787149185553e-001;
    __statist_i_h_wts[5,60]=4.87688207299000e-001;
    __statist_i_h_wts[5,61]=-5.81216571716811e-002;
    __statist_i_h_wts[5,62]=7.49662387527197e-001;
    __statist_i_h_wts[5,63]=2.23531154229635e-001;
    __statist_i_h_wts[5,64]=-1.16944641124133e-001;
    __statist_i_h_wts[5,65]=1.00636315354888e-002;
    __statist_i_h_wts[5,66]=-2.50716433686542e-001;
    __statist_i_h_wts[5,67]=2.17197231557718e-002;
    __statist_i_h_wts[5,68]=8.11585470818960e-002;
    __statist_i_h_wts[5,69]=-1.53539219151680e-001;
    __statist_i_h_wts[5,70]=1.03681689738826e-001;
    __statist_i_h_wts[5,71]=2.60546512950604e-002;
    __statist_i_h_wts[5,72]=-5.08142541755749e-001;
    __statist_i_h_wts[5,73]=2.73930198039467e-001;
    __statist_i_h_wts[5,74]=4.08123698449665e-001;
    __statist_i_h_wts[5,75]=4.64318201937717e-001;
    __statist_i_h_wts[5,76]=2.25425999655973e-001;
    __statist_i_h_wts[5,77]=5.22847061086617e-001;
    __statist_i_h_wts[5,78]=2.70259565655208e-001;
    __statist_i_h_wts[5,79]=1.25653881171615e-001;
    __statist_i_h_wts[5,80]=-3.16567478213237e-001;
    __statist_i_h_wts[5,81]=2.70546349802146e-001;
    __statist_i_h_wts[5,82]=-5.01422606709162e-001;
    __statist_i_h_wts[5,83]=-3.53522515905221e-001;
    __statist_i_h_wts[5,84]=-8.67146417064973e-001;
    __statist_i_h_wts[5,85]=-4.96530371014172e-001;
    __statist_i_h_wts[5,86]=-1.03323382926095e-001;
    __statist_i_h_wts[5,87]=2.29169818151992e-001;
    __statist_i_h_wts[5,88]=-7.31496383900207e-002;
    __statist_i_h_wts[5,89]=-4.39081050400700e-001;
    __statist_i_h_wts[5,90]=3.43555645244235e-001;
    __statist_i_h_wts[5,91]=2.78144688125034e-001;
    __statist_i_h_wts[5,92]=-7.22140732454660e-001;
    __statist_i_h_wts[5,93]=2.17409992467707e-002;
    __statist_i_h_wts[5,94]=-4.80226152110157e-001;
    __statist_i_h_wts[5,95]=-4.49866237667339e-002;
    __statist_i_h_wts[5,96]=3.49391182545609e-001;
    __statist_i_h_wts[5,97]=-1.60295246676011e-002;
    __statist_i_h_wts[5,98]=4.04253905481918e-001;
    __statist_i_h_wts[5,99]=2.53928754579064e-001;
    __statist_i_h_wts[5,100]=-1.63815425639586e-003;
    __statist_i_h_wts[5,101]=-2.54282833675118e-001;
    __statist_i_h_wts[5,102]=-3.92981410180116e-001;
    __statist_i_h_wts[5,103]=2.94522417244092e-001;
    __statist_i_h_wts[5,104]=2.61967416270252e-002;
    __statist_i_h_wts[5,105]=-1.47831388167053e-001;
    __statist_i_h_wts[5,106]=-2.90599676737719e-001;
    __statist_i_h_wts[5,107]=-7.65829157549470e-001;
    __statist_i_h_wts[5,108]=-1.41380928117447e-001;
    __statist_i_h_wts[5,109]=2.97088984234574e-001;
    __statist_i_h_wts[5,110]=-3.62214791376011e-001;
    __statist_i_h_wts[5,111]=-2.27521471027889e-001;
    __statist_i_h_wts[5,112]=2.26924981925897e-001;
    __statist_i_h_wts[5,113]=-6.56173762102953e-001;
    __statist_i_h_wts[5,114]=9.37903307025953e-001;
    __statist_i_h_wts[5,115]=3.52992556823734e-002;
    __statist_i_h_wts[5,116]=-1.05874241148229e+000;
    __statist_i_h_wts[5,117]=1.83341060413824e-001;
    __statist_i_h_wts[5,118]=7.18643829348644e-001;
    __statist_i_h_wts[5,119]=-1.26117779735807e-001;
    __statist_i_h_wts[5,120]=5.09000648130741e-001;
    __statist_i_h_wts[5,121]=4.41023952561012e-001;
    __statist_i_h_wts[5,122]=5.97144110785929e-002;
    __statist_i_h_wts[5,123]=-3.91072659697673e-001;
    __statist_i_h_wts[5,124]=-2.66136314382785e-001;
    __statist_i_h_wts[5,125]=1.38164888029322e-001;
    __statist_i_h_wts[5,126]=-1.48843908748504e-001;
    __statist_i_h_wts[5,127]=-3.99754281458254e-001;
    __statist_i_h_wts[5,128]=-2.53246743921925e-002;
    __statist_i_h_wts[5,129]=8.16753557980057e-001;
    __statist_i_h_wts[5,130]=6.29777214330415e-001;
    __statist_i_h_wts[5,131]=2.75439164519766e-001;
    __statist_i_h_wts[5,132]=-1.12795081064974e-003;
    __statist_i_h_wts[5,133]=-9.76888352925352e-001;
    __statist_i_h_wts[5,134]=5.43932990999556e-003;
    __statist_i_h_wts[5,135]=-1.15111532783091e-001;
    __statist_i_h_wts[5,136]=5.36497017566576e-001;
    __statist_i_h_wts[5,137]=3.99608419200327e-002;
    __statist_i_h_wts[5,138]=2.18644797689303e-002;
    __statist_i_h_wts[5,139]=9.33190992679018e-002;
    __statist_i_h_wts[5,140]=-4.60110724727482e-001;
    __statist_i_h_wts[5,141]=6.24093656010921e-001;
    __statist_i_h_wts[5,142]=-3.76842900258304e-001;
    __statist_i_h_wts[5,143]=-1.30618350450634e-001;
    __statist_i_h_wts[5,144]=5.05368954347412e-001;
    __statist_i_h_wts[5,145]=-1.70880163381335e-001;
    __statist_i_h_wts[5,146]=3.57259966914784e-001;
    __statist_i_h_wts[5,147]=-1.44481880571926e-001;
    __statist_i_h_wts[5,148]=-5.76361077671993e-001;
    __statist_i_h_wts[5,149]=2.00794110394608e-001;
    __statist_i_h_wts[5,150]=-6.82414579525045e-001;
    __statist_i_h_wts[5,151]=2.22450850409150e-001;
    __statist_i_h_wts[5,152]=-4.20297191254379e-003;
    __statist_i_h_wts[5,153]=9.96115131449441e-001;
    __statist_i_h_wts[5,154]=7.87312535647027e-002;
    __statist_i_h_wts[5,155]=-5.85168919267229e-001;
    __statist_i_h_wts[5,156]=-3.83909744295889e-003;
    __statist_i_h_wts[5,157]=3.09845715650646e-001;
    __statist_i_h_wts[5,158]=-3.38787564243811e-001;
    __statist_i_h_wts[5,159]=-1.51045421892019e-001;
    __statist_i_h_wts[5,160]=1.44734013512668e-001;
    __statist_i_h_wts[5,161]=1.54264674217919e+000;
    __statist_i_h_wts[5,162]=-5.12894311876599e-002;
    __statist_i_h_wts[5,163]=-1.55822851237760e-001;
    __statist_i_h_wts[5,164]=8.52727370488584e-001;
    __statist_i_h_wts[5,165]=-2.69019705840131e-001;
    __statist_i_h_wts[5,166]=3.89952070011128e-001;
    __statist_i_h_wts[5,167]=-2.06177289813522e-001;
    __statist_i_h_wts[5,168]=-3.11092552565343e-001;
    __statist_i_h_wts[5,169]=-6.81809825458558e-001;
    __statist_i_h_wts[5,170]=-8.58780182972325e-001;
    __statist_i_h_wts[5,171]=-6.89634186643003e-002;
    __statist_i_h_wts[5,172]=-2.81417865685453e-001;
    __statist_i_h_wts[5,173]=5.05541340855097e-001;
    __statist_i_h_wts[5,174]=2.26186197057159e-001;
    __statist_i_h_wts[5,175]=6.03525445791472e-001;
    __statist_i_h_wts[5,176]=2.53506901642012e-001;
    __statist_i_h_wts[5,177]=-2.79844983795449e-001;
    __statist_i_h_wts[5,178]=-3.97016757478553e-001;
    __statist_i_h_wts[5,179]=-5.06414915212914e-001;
    __statist_i_h_wts[5,180]=-1.50706142495441e-001;
    __statist_i_h_wts[5,181]=1.25284249922589e-001;
    __statist_i_h_wts[5,182]=-2.74104645998418e-001;
    __statist_i_h_wts[5,183]=3.62708210421785e-001;
    __statist_i_h_wts[5,184]=4.57780727698059e-002;
    __statist_i_h_wts[5,185]=1.48310384112618e-001;
    __statist_i_h_wts[5,186]=-4.17867287598457e-001;
    __statist_i_h_wts[5,187]=-3.13136425967532e-001;
    __statist_i_h_wts[5,188]=7.26494638967736e-002;
    __statist_i_h_wts[5,189]=2.97164107975796e-002;
    __statist_i_h_wts[5,190]=2.08594066438878e-001;
    __statist_i_h_wts[5,191]=9.70359178716602e-002;
    __statist_i_h_wts[5,192]=-3.68135365810939e-001;
    __statist_i_h_wts[5,193]=-6.34588366458003e-001;
    __statist_i_h_wts[5,194]=-1.22886461556935e-001;
    __statist_i_h_wts[5,195]=-4.96716773879055e-001;
    __statist_i_h_wts[5,196]=1.21647588661832e-001;
    __statist_i_h_wts[5,197]=-8.08319209096393e-002;
    __statist_i_h_wts[5,198]=-2.84193958524742e-001;
    __statist_i_h_wts[5,199]=-3.15222432662867e-002;
    __statist_i_h_wts[5,200]=-1.94157357343659e-001;
    __statist_i_h_wts[5,201]=-1.14644153859910e-001;
    __statist_i_h_wts[5,202]=5.21149113101129e-001;
    __statist_i_h_wts[5,203]=9.19729862254435e-001;
    __statist_i_h_wts[5,204]=6.01137788275433e-001;
    __statist_i_h_wts[5,205]=6.59713661733047e-002;
    __statist_i_h_wts[5,206]=1.04187622680296e-001;
    __statist_i_h_wts[5,207]=3.11811827122470e-001;
    __statist_i_h_wts[5,208]=3.28596303803633e-001;
    __statist_i_h_wts[5,209]=2.44106737775289e-001;
    __statist_i_h_wts[5,210]=-4.37203912274843e-001;
    __statist_i_h_wts[5,211]=1.85746150673814e-001;
    __statist_i_h_wts[5,212]=-1.44143792973330e-001;
    __statist_i_h_wts[5,213]=-2.93064986358711e-001;
    __statist_i_h_wts[5,214]=7.73193787471687e-002;
    __statist_i_h_wts[5,215]=9.96252328505851e-002;
    __statist_i_h_wts[5,216]=-4.62499979146586e-001;
    __statist_i_h_wts[5,217]=4.53661875907306e-001;
    __statist_i_h_wts[5,218]=1.46513179312833e-001;
    __statist_i_h_wts[5,219]=-5.27091921278535e-001;
    __statist_i_h_wts[5,220]=-7.45567004887426e-001;
    __statist_i_h_wts[5,221]=-2.72388738960416e-001;
    __statist_i_h_wts[5,222]=-3.24112262055474e-001;
    __statist_i_h_wts[5,223]=1.10847976848751e+000;
    __statist_i_h_wts[5,224]=7.43388106985405e-001;
    __statist_i_h_wts[5,225]=-7.63717683678764e-001;
    __statist_i_h_wts[5,226]=1.10876341357563e+000;
    __statist_i_h_wts[5,227]=4.43046240350727e-001;
    __statist_i_h_wts[5,228]=5.89868439785106e-001;
    __statist_i_h_wts[5,229]=1.87852596518665e-001;
    __statist_i_h_wts[5,230]=-2.70768351563893e-001;
    __statist_i_h_wts[5,231]=1.54477799547520e-001;
    __statist_i_h_wts[5,232]=-1.25555512303199e+000;
    __statist_i_h_wts[5,233]=-5.65675589929316e-001;
    __statist_i_h_wts[5,234]=-8.26086800672147e-001;
    __statist_i_h_wts[5,235]=3.03681871741457e-002;
    __statist_i_h_wts[5,236]=-3.42929424156222e-001;
    __statist_i_h_wts[5,237]=-1.24896162060808e+000;
    __statist_i_h_wts[5,238]=-4.47112379971681e-001;
    __statist_i_h_wts[5,239]=1.41986627226718e-001;
    __statist_i_h_wts[5,240]=1.38913195886221e+000;
    __statist_i_h_wts[5,241]=3.82506298554213e+000;
    __statist_i_h_wts[5,242]=6.46572005781205e-001;
    __statist_i_h_wts[5,243]=3.76214635023797e-001;
    __statist_i_h_wts[5,244]=5.30940817219629e-001;
    __statist_i_h_wts[5,245]=1.48564325968980e+000;
    __statist_i_h_wts[5,246]=1.16214045115396e+000;
    __statist_i_h_wts[5,247]=5.06383020328272e-001;
    __statist_i_h_wts[5,248]=-4.50647232306857e-001;

    __statist_i_h_wts[6,0]=5.69745245763612e-001;
    __statist_i_h_wts[6,1]=5.45702235507190e-001;
    __statist_i_h_wts[6,2]=4.71347234958135e-001;
    __statist_i_h_wts[6,3]=3.79707747462279e-001;
    __statist_i_h_wts[6,4]=3.28350373196167e-001;
    __statist_i_h_wts[6,5]=1.98180254723457e-001;
    __statist_i_h_wts[6,6]=2.61957071214614e-001;
    __statist_i_h_wts[6,7]=2.50885432401926e-001;
    __statist_i_h_wts[6,8]=2.47033910229865e-001;
    __statist_i_h_wts[6,9]=4.81199549989715e-001;
    __statist_i_h_wts[6,10]=4.35295937311646e-001;
    __statist_i_h_wts[6,11]=3.62524342654945e-001;
    __statist_i_h_wts[6,12]=3.30107713610274e-001;
    __statist_i_h_wts[6,13]=4.50170009104870e-001;
    __statist_i_h_wts[6,14]=3.45506595735686e-001;
    __statist_i_h_wts[6,15]=6.22929173014569e-001;
    __statist_i_h_wts[6,16]=5.51002934571624e-001;
    __statist_i_h_wts[6,17]=4.63319230656150e-001;
    __statist_i_h_wts[6,18]=3.46354883167104e-001;
    __statist_i_h_wts[6,19]=2.86414638548862e-001;
    __statist_i_h_wts[6,20]=1.43159464639139e-001;
    __statist_i_h_wts[6,21]=2.04544614916172e-001;
    __statist_i_h_wts[6,22]=2.47680881460635e-001;
    __statist_i_h_wts[6,23]=2.84586521243551e-001;
    __statist_i_h_wts[6,24]=4.71191422955758e-001;
    __statist_i_h_wts[6,25]=4.23845544108062e-001;
    __statist_i_h_wts[6,26]=4.29379389079967e-001;
    __statist_i_h_wts[6,27]=3.91079978941805e-001;
    __statist_i_h_wts[6,28]=5.30510900572316e-001;
    __statist_i_h_wts[6,29]=3.74019321834854e-001;
    __statist_i_h_wts[6,30]=6.41009602413870e-001;
    __statist_i_h_wts[6,31]=6.48560810289095e-001;
    __statist_i_h_wts[6,32]=5.60841477314332e-001;
    __statist_i_h_wts[6,33]=5.11164314042709e-001;
    __statist_i_h_wts[6,34]=4.67907705448582e-001;
    __statist_i_h_wts[6,35]=2.13672015396269e-001;
    __statist_i_h_wts[6,36]=2.98831301707940e-001;
    __statist_i_h_wts[6,37]=2.46320925823404e-001;
    __statist_i_h_wts[6,38]=2.41844029434099e-001;
    __statist_i_h_wts[6,39]=4.60739339764575e-001;
    __statist_i_h_wts[6,40]=3.22287112361463e-001;
    __statist_i_h_wts[6,41]=3.42276421363294e-001;
    __statist_i_h_wts[6,42]=3.12764454330037e-001;
    __statist_i_h_wts[6,43]=4.88166130513529e-001;
    __statist_i_h_wts[6,44]=3.70614778699052e-001;
    __statist_i_h_wts[6,45]=7.01857967984175e-001;
    __statist_i_h_wts[6,46]=7.96182890948841e-001;
    __statist_i_h_wts[6,47]=7.14622290756232e-001;
    __statist_i_h_wts[6,48]=6.61316836274766e-001;
    __statist_i_h_wts[6,49]=6.27161063671873e-001;
    __statist_i_h_wts[6,50]=4.37631798189880e-001;
    __statist_i_h_wts[6,51]=3.76103390600992e-001;
    __statist_i_h_wts[6,52]=4.10936535707948e-001;
    __statist_i_h_wts[6,53]=4.13071621125498e-001;
    __statist_i_h_wts[6,54]=6.53949910824550e-001;
    __statist_i_h_wts[6,55]=5.43294244921724e-001;
    __statist_i_h_wts[6,56]=4.38739592101221e-001;
    __statist_i_h_wts[6,57]=4.35777071960183e-001;
    __statist_i_h_wts[6,58]=4.70125459508478e-001;
    __statist_i_h_wts[6,59]=4.08919085610396e-001;
    __statist_i_h_wts[6,60]=5.78328536196344e-001;
    __statist_i_h_wts[6,61]=6.03327500976339e-001;
    __statist_i_h_wts[6,62]=5.13801389524986e-001;
    __statist_i_h_wts[6,63]=5.30489469130661e-001;
    __statist_i_h_wts[6,64]=4.74880253614764e-001;
    __statist_i_h_wts[6,65]=2.92967126619118e-001;
    __statist_i_h_wts[6,66]=2.00793865848570e-001;
    __statist_i_h_wts[6,67]=2.90818795152309e-001;
    __statist_i_h_wts[6,68]=2.70955226314622e-001;
    __statist_i_h_wts[6,69]=5.67594785632285e-001;
    __statist_i_h_wts[6,70]=6.48357898284624e-001;
    __statist_i_h_wts[6,71]=5.29276481066180e-001;
    __statist_i_h_wts[6,72]=5.38115458221116e-001;
    __statist_i_h_wts[6,73]=4.81319805266946e-001;
    __statist_i_h_wts[6,74]=3.73052725191780e-001;
    __statist_i_h_wts[6,75]=4.39279963624578e-001;
    __statist_i_h_wts[6,76]=4.30130069345609e-001;
    __statist_i_h_wts[6,77]=4.17477338591943e-001;
    __statist_i_h_wts[6,78]=4.31253224553645e-001;
    __statist_i_h_wts[6,79]=3.66719102050808e-001;
    __statist_i_h_wts[6,80]=3.60365298779143e-001;
    __statist_i_h_wts[6,81]=2.07129870436956e-001;
    __statist_i_h_wts[6,82]=3.18306814594986e-001;
    __statist_i_h_wts[6,83]=2.49183667267883e-001;
    __statist_i_h_wts[6,84]=4.83008961844205e-001;
    __statist_i_h_wts[6,85]=5.46174598804264e-001;
    __statist_i_h_wts[6,86]=4.37132284144479e-001;
    __statist_i_h_wts[6,87]=5.29238415541982e-001;
    __statist_i_h_wts[6,88]=4.68417091389186e-001;
    __statist_i_h_wts[6,89]=3.08538795644568e-001;
    __statist_i_h_wts[6,90]=3.43272442502277e-001;
    __statist_i_h_wts[6,91]=3.84367018118531e-001;
    __statist_i_h_wts[6,92]=5.97461439770566e-001;
    __statist_i_h_wts[6,93]=5.06291342368320e-001;
    __statist_i_h_wts[6,94]=4.48620576174240e-001;
    __statist_i_h_wts[6,95]=4.37210000254690e-001;
    __statist_i_h_wts[6,96]=3.28379387863309e-001;
    __statist_i_h_wts[6,97]=4.08271647378621e-001;
    __statist_i_h_wts[6,98]=2.47004797845088e-001;
    __statist_i_h_wts[6,99]=4.81519123742995e-001;
    __statist_i_h_wts[6,100]=5.12448314939840e-001;
    __statist_i_h_wts[6,101]=4.07490178883766e-001;
    __statist_i_h_wts[6,102]=4.11046032231664e-001;
    __statist_i_h_wts[6,103]=3.24233122487609e-001;
    __statist_i_h_wts[6,104]=2.88768318347292e-001;
    __statist_i_h_wts[6,105]=4.04563243463019e-001;
    __statist_i_h_wts[6,106]=3.54686160013588e-001;
    __statist_i_h_wts[6,107]=4.11734098115942e-001;
    __statist_i_h_wts[6,108]=3.23578609066441e-001;
    __statist_i_h_wts[6,109]=2.28413359920081e-001;
    __statist_i_h_wts[6,110]=2.60129338381793e-001;
    __statist_i_h_wts[6,111]=1.81088290416213e-001;
    __statist_i_h_wts[6,112]=2.68870439769666e-001;
    __statist_i_h_wts[6,113]=2.15415438283207e-001;
    __statist_i_h_wts[6,114]=2.85281300314387e-001;
    __statist_i_h_wts[6,115]=4.61573150188109e-001;
    __statist_i_h_wts[6,116]=3.56855026544449e-001;
    __statist_i_h_wts[6,117]=2.96091228493564e-001;
    __statist_i_h_wts[6,118]=1.55649465871806e-001;
    __statist_i_h_wts[6,119]=2.28033122725643e-001;
    __statist_i_h_wts[6,120]=1.92284716898071e-001;
    __statist_i_h_wts[6,121]=1.13697092583357e-001;
    __statist_i_h_wts[6,122]=1.91555499706873e-001;
    __statist_i_h_wts[6,123]=2.29447824846334e-001;
    __statist_i_h_wts[6,124]=2.45759307255120e-001;
    __statist_i_h_wts[6,125]=1.57014842742885e-001;
    __statist_i_h_wts[6,126]=1.41964256355659e-001;
    __statist_i_h_wts[6,127]=3.18458843374654e-001;
    __statist_i_h_wts[6,128]=3.19115471126291e-001;
    __statist_i_h_wts[6,129]=3.05859479201793e-001;
    __statist_i_h_wts[6,130]=3.29464242924334e-001;
    __statist_i_h_wts[6,131]=2.37439936172916e-001;
    __statist_i_h_wts[6,132]=1.54342958258115e-001;
    __statist_i_h_wts[6,133]=1.67111630227799e-001;
    __statist_i_h_wts[6,134]=1.04505830713304e-001;
    __statist_i_h_wts[6,135]=2.93720101259294e-001;
    __statist_i_h_wts[6,136]=1.11517793111742e-001;
    __statist_i_h_wts[6,137]=2.07382446215427e-001;
    __statist_i_h_wts[6,138]=1.29630997637212e-001;
    __statist_i_h_wts[6,139]=2.02609595941969e-001;
    __statist_i_h_wts[6,140]=3.20389550671117e-002;
    __statist_i_h_wts[6,141]=-2.12443110652645e-002;
    __statist_i_h_wts[6,142]=2.30879773726732e-001;
    __statist_i_h_wts[6,143]=1.88727746697288e-001;
    __statist_i_h_wts[6,144]=1.82178690558648e-001;
    __statist_i_h_wts[6,145]=3.36602972612632e-001;
    __statist_i_h_wts[6,146]=3.08487040820676e-001;
    __statist_i_h_wts[6,147]=3.59591633418103e-001;
    __statist_i_h_wts[6,148]=3.62847928574250e-001;
    __statist_i_h_wts[6,149]=3.22017387052399e-001;
    __statist_i_h_wts[6,150]=4.20728673601283e-001;
    __statist_i_h_wts[6,151]=2.80114198393961e-001;
    __statist_i_h_wts[6,152]=3.27228076316123e-001;
    __statist_i_h_wts[6,153]=1.04833115142063e-001;
    __statist_i_h_wts[6,154]=1.95846664208369e-001;
    __statist_i_h_wts[6,155]=4.57398853535478e-002;
    __statist_i_h_wts[6,156]=6.52702429667209e-002;
    __statist_i_h_wts[6,157]=1.16229513567023e-001;
    __statist_i_h_wts[6,158]=2.58639176013221e-001;
    __statist_i_h_wts[6,159]=1.86438078098645e-001;
    __statist_i_h_wts[6,160]=2.08805981084221e-001;
    __statist_i_h_wts[6,161]=1.26364052285911e-001;
    __statist_i_h_wts[6,162]=2.85851545459825e-001;
    __statist_i_h_wts[6,163]=1.72301547236253e-001;
    __statist_i_h_wts[6,164]=1.76097981294639e-001;
    __statist_i_h_wts[6,165]=4.14840381978529e-001;
    __statist_i_h_wts[6,166]=3.71990820451052e-001;
    __statist_i_h_wts[6,167]=4.07027442203815e-001;
    __statist_i_h_wts[6,168]=2.35541835713022e-001;
    __statist_i_h_wts[6,169]=1.60832870293946e-001;
    __statist_i_h_wts[6,170]=6.41918617182666e-002;
    __statist_i_h_wts[6,171]=1.24831268477934e-002;
    __statist_i_h_wts[6,172]=1.12005891835361e-001;
    __statist_i_h_wts[6,173]=1.36801599308830e-001;
    __statist_i_h_wts[6,174]=1.77566270730621e-001;
    __statist_i_h_wts[6,175]=1.47982252216758e-001;
    __statist_i_h_wts[6,176]=1.23295748424047e-001;
    __statist_i_h_wts[6,177]=2.76132582008825e-001;
    __statist_i_h_wts[6,178]=1.75956616264611e-001;
    __statist_i_h_wts[6,179]=2.24265246672038e-001;
    __statist_i_h_wts[6,180]=2.34278204888208e-001;
    __statist_i_h_wts[6,181]=2.17979783685416e-001;
    __statist_i_h_wts[6,182]=2.44855854785355e-001;
    __statist_i_h_wts[6,183]=5.67700637946510e-002;
    __statist_i_h_wts[6,184]=7.05392243750682e-002;
    __statist_i_h_wts[6,185]=3.90723775695606e-002;
    __statist_i_h_wts[6,186]=-6.57959745943573e-002;
    __statist_i_h_wts[6,187]=-6.25909051665569e-002;
    __statist_i_h_wts[6,188]=4.13184181824935e-002;
    __statist_i_h_wts[6,189]=3.68568403197680e-002;
    __statist_i_h_wts[6,190]=2.83419481377532e-002;
    __statist_i_h_wts[6,191]=5.24374023196202e-002;
    __statist_i_h_wts[6,192]=1.19008919337656e-001;
    __statist_i_h_wts[6,193]=4.98166244973467e-002;
    __statist_i_h_wts[6,194]=7.64369117656948e-002;
    __statist_i_h_wts[6,195]=1.90560932274774e-001;
    __statist_i_h_wts[6,196]=1.53954810881011e-001;
    __statist_i_h_wts[6,197]=1.80341953582148e-001;
    __statist_i_h_wts[6,198]=1.41770228434451e-001;
    __statist_i_h_wts[6,199]=1.31044220182252e-001;
    __statist_i_h_wts[6,200]=1.61678618726889e-001;
    __statist_i_h_wts[6,201]=2.66054156442792e-002;
    __statist_i_h_wts[6,202]=-7.22884878097081e-002;
    __statist_i_h_wts[6,203]=-2.27720461513927e-002;
    __statist_i_h_wts[6,204]=4.04261707312363e-003;
    __statist_i_h_wts[6,205]=9.66849952126869e-003;
    __statist_i_h_wts[6,206]=3.93495355621616e-002;
    __statist_i_h_wts[6,207]=7.76938412498742e-002;
    __statist_i_h_wts[6,208]=8.82258098308643e-003;
    __statist_i_h_wts[6,209]=9.73893646035376e-002;
    __statist_i_h_wts[6,210]=1.53822646725848e-001;
    __statist_i_h_wts[6,211]=1.11782081670510e-001;
    __statist_i_h_wts[6,212]=1.38278661940705e-001;
    __statist_i_h_wts[6,213]=1.14011281432699e-001;
    __statist_i_h_wts[6,214]=9.99946420427413e-002;
    __statist_i_h_wts[6,215]=6.61472972200885e-002;
    __statist_i_h_wts[6,216]=6.36269700419774e-002;
    __statist_i_h_wts[6,217]=-5.86450404619707e-002;
    __statist_i_h_wts[6,218]=1.13090478473521e-002;
    __statist_i_h_wts[6,219]=1.18937173696710e-001;
    __statist_i_h_wts[6,220]=1.32707582752286e-001;
    __statist_i_h_wts[6,221]=1.15968568786369e-001;
    __statist_i_h_wts[6,222]=1.47955854726571e-001;
    __statist_i_h_wts[6,223]=3.19807076686987e-002;
    __statist_i_h_wts[6,224]=7.41336597791619e-002;
    __statist_i_h_wts[6,225]=1.03495175738770e-001;
    __statist_i_h_wts[6,226]=1.31917461682699e+000;
    __statist_i_h_wts[6,227]=9.60784208250275e-002;
    __statist_i_h_wts[6,228]=1.23346805504271e+000;
    __statist_i_h_wts[6,229]=8.59073000765536e-002;
    __statist_i_h_wts[6,230]=-1.53303938171680e+000;
    __statist_i_h_wts[6,231]=-2.29606233302671e-001;
    __statist_i_h_wts[6,232]=-1.41309664854165e+000;
    __statist_i_h_wts[6,233]=-6.33852941454410e-001;
    __statist_i_h_wts[6,234]=-1.81437838562158e+000;
    __statist_i_h_wts[6,235]=7.58209559681311e-001;
    __statist_i_h_wts[6,236]=2.15057426038792e+000;
    __statist_i_h_wts[6,237]=2.46734449401144e+000;
    __statist_i_h_wts[6,238]=8.23655730852884e-001;
    __statist_i_h_wts[6,239]=-1.37787345873612e+000;
    __statist_i_h_wts[6,240]=5.76196933817373e-001;
    __statist_i_h_wts[6,241]=-4.04600358807534e+000;
    __statist_i_h_wts[6,242]=-5.19446278637506e-002;
    __statist_i_h_wts[6,243]=-1.53967018512976e+000;
    __statist_i_h_wts[6,244]=1.76074407768919e-001;
    __statist_i_h_wts[6,245]=2.77843854313272e+000;
    __statist_i_h_wts[6,246]=-6.70891759507122e-001;
    __statist_i_h_wts[6,247]=1.74136081699835e+000;
    __statist_i_h_wts[6,248]=-1.18285880793516e-001;

    __statist_i_h_wts[7,0]=1.76075688774072e-001;
    __statist_i_h_wts[7,1]=1.67624530560628e-001;
    __statist_i_h_wts[7,2]=1.41856248499719e-001;
    __statist_i_h_wts[7,3]=2.25576895629277e-001;
    __statist_i_h_wts[7,4]=2.57792437624440e-001;
    __statist_i_h_wts[7,5]=3.11906462065509e-001;
    __statist_i_h_wts[7,6]=2.96090849551888e-001;
    __statist_i_h_wts[7,7]=2.74494970512044e-001;
    __statist_i_h_wts[7,8]=2.50770375143215e-001;
    __statist_i_h_wts[7,9]=2.20890123445970e-001;
    __statist_i_h_wts[7,10]=1.75952206461698e-001;
    __statist_i_h_wts[7,11]=1.78024935054153e-001;
    __statist_i_h_wts[7,12]=1.53042304517592e-001;
    __statist_i_h_wts[7,13]=1.57077535785907e-001;
    __statist_i_h_wts[7,14]=1.77089639272493e-001;
    __statist_i_h_wts[7,15]=2.02634238356717e-001;
    __statist_i_h_wts[7,16]=1.80379882659270e-001;
    __statist_i_h_wts[7,17]=1.46603951214343e-001;
    __statist_i_h_wts[7,18]=2.36669389136089e-001;
    __statist_i_h_wts[7,19]=2.62348728438431e-001;
    __statist_i_h_wts[7,20]=2.94667899205210e-001;
    __statist_i_h_wts[7,21]=2.84095350623935e-001;
    __statist_i_h_wts[7,22]=2.97170723057914e-001;
    __statist_i_h_wts[7,23]=2.65880803236377e-001;
    __statist_i_h_wts[7,24]=2.40937372511281e-001;
    __statist_i_h_wts[7,25]=1.35475572129835e-001;
    __statist_i_h_wts[7,26]=1.35771776881913e-001;
    __statist_i_h_wts[7,27]=1.01302054419151e-001;
    __statist_i_h_wts[7,28]=1.44306078848551e-001;
    __statist_i_h_wts[7,29]=1.73782479167435e-001;
    __statist_i_h_wts[7,30]=5.96554059286475e-002;
    __statist_i_h_wts[7,31]=6.35117846614762e-002;
    __statist_i_h_wts[7,32]=5.12340560935432e-002;
    __statist_i_h_wts[7,33]=1.33340627177626e-001;
    __statist_i_h_wts[7,34]=1.98015749214986e-001;
    __statist_i_h_wts[7,35]=2.23295812114974e-001;
    __statist_i_h_wts[7,36]=2.21708108758846e-001;
    __statist_i_h_wts[7,37]=2.55236267551087e-001;
    __statist_i_h_wts[7,38]=1.75951714942918e-001;
    __statist_i_h_wts[7,39]=1.71019284638636e-001;
    __statist_i_h_wts[7,40]=6.20481726224294e-002;
    __statist_i_h_wts[7,41]=7.34540949876071e-002;
    __statist_i_h_wts[7,42]=4.24040668465836e-002;
    __statist_i_h_wts[7,43]=1.20056747096414e-001;
    __statist_i_h_wts[7,44]=1.05748676577573e-001;
    __statist_i_h_wts[7,45]=-9.24046056899057e-002;
    __statist_i_h_wts[7,46]=-1.30842111652532e-001;
    __statist_i_h_wts[7,47]=-1.54327225324352e-001;
    __statist_i_h_wts[7,48]=-6.24424810087778e-002;
    __statist_i_h_wts[7,49]=-6.83402124002915e-003;
    __statist_i_h_wts[7,50]=5.36069174035121e-002;
    __statist_i_h_wts[7,51]=1.13558973897218e-001;
    __statist_i_h_wts[7,52]=1.33273306199388e-001;
    __statist_i_h_wts[7,53]=9.19589658336825e-002;
    __statist_i_h_wts[7,54]=5.27708133721359e-002;
    __statist_i_h_wts[7,55]=-2.38896668913973e-002;
    __statist_i_h_wts[7,56]=-1.14163367788964e-002;
    __statist_i_h_wts[7,57]=-2.55704517706701e-002;
    __statist_i_h_wts[7,58]=3.19885358570056e-002;
    __statist_i_h_wts[7,59]=5.67670978446778e-002;
    __statist_i_h_wts[7,60]=-9.02970441495186e-002;
    __statist_i_h_wts[7,61]=-1.27284966630643e-001;
    __statist_i_h_wts[7,62]=-1.19405489584280e-001;
    __statist_i_h_wts[7,63]=-7.78451641912740e-002;
    __statist_i_h_wts[7,64]=-6.71113238772345e-002;
    __statist_i_h_wts[7,65]=-2.20964283817906e-002;
    __statist_i_h_wts[7,66]=-4.65309215651289e-002;
    __statist_i_h_wts[7,67]=2.09645135362848e-002;
    __statist_i_h_wts[7,68]=3.27908034798556e-003;
    __statist_i_h_wts[7,69]=-2.33373878732296e-002;
    __statist_i_h_wts[7,70]=-7.80522898402630e-002;
    __statist_i_h_wts[7,71]=-4.69861267804970e-002;
    __statist_i_h_wts[7,72]=-2.65926340967312e-002;
    __statist_i_h_wts[7,73]=2.71560122172933e-002;
    __statist_i_h_wts[7,74]=6.32189587245939e-002;
    __statist_i_h_wts[7,75]=-2.03523362549293e-002;
    __statist_i_h_wts[7,76]=-5.50401016341048e-002;
    __statist_i_h_wts[7,77]=-4.64611926544557e-002;
    __statist_i_h_wts[7,78]=-7.08333806979936e-002;
    __statist_i_h_wts[7,79]=-7.42249718124898e-002;
    __statist_i_h_wts[7,80]=-4.04105737940047e-002;
    __statist_i_h_wts[7,81]=-5.12830358633453e-002;
    __statist_i_h_wts[7,82]=-5.83212616658954e-003;
    __statist_i_h_wts[7,83]=-1.12004567361774e-002;
    __statist_i_h_wts[7,84]=-3.07218751290393e-002;
    __statist_i_h_wts[7,85]=-9.90270779431865e-002;
    __statist_i_h_wts[7,86]=-8.92076178085939e-002;
    __statist_i_h_wts[7,87]=-6.97783750275490e-002;
    __statist_i_h_wts[7,88]=4.16453326375686e-003;
    __statist_i_h_wts[7,89]=2.43248482550888e-002;
    __statist_i_h_wts[7,90]=-3.15895851956859e-003;
    __statist_i_h_wts[7,91]=-5.79997586224714e-002;
    __statist_i_h_wts[7,92]=-6.80459600092699e-002;
    __statist_i_h_wts[7,93]=-1.52970929828398e-001;
    __statist_i_h_wts[7,94]=-7.07235603829549e-002;
    __statist_i_h_wts[7,95]=1.66023260151690e-002;
    __statist_i_h_wts[7,96]=1.25211991550148e-002;
    __statist_i_h_wts[7,97]=2.37630382124105e-002;
    __statist_i_h_wts[7,98]=4.90632065595827e-002;
    __statist_i_h_wts[7,99]=-5.04142025223821e-002;
    __statist_i_h_wts[7,100]=-6.21760979763421e-002;
    __statist_i_h_wts[7,101]=1.60237246039236e-002;
    __statist_i_h_wts[7,102]=5.82378509018374e-002;
    __statist_i_h_wts[7,103]=6.52003619416822e-002;
    __statist_i_h_wts[7,104]=9.86317992649669e-002;
    __statist_i_h_wts[7,105]=-2.19909202087440e-002;
    __statist_i_h_wts[7,106]=-9.72305565655118e-002;
    __statist_i_h_wts[7,107]=-9.90899617184373e-002;
    __statist_i_h_wts[7,108]=-2.19933929030128e-001;
    __statist_i_h_wts[7,109]=-1.71334256309394e-001;
    __statist_i_h_wts[7,110]=-6.88138402626807e-002;
    __statist_i_h_wts[7,111]=-5.82620476638294e-002;
    __statist_i_h_wts[7,112]=-3.46183867351415e-002;
    __statist_i_h_wts[7,113]=6.08210097591436e-002;
    __statist_i_h_wts[7,114]=-1.47479405385717e-002;
    __statist_i_h_wts[7,115]=3.20787251370031e-002;
    __statist_i_h_wts[7,116]=6.59232392234868e-002;
    __statist_i_h_wts[7,117]=1.04622290581859e-001;
    __statist_i_h_wts[7,118]=9.81665874800237e-002;
    __statist_i_h_wts[7,119]=1.23819130696362e-001;
    __statist_i_h_wts[7,120]=-2.85125276381274e-003;
    __statist_i_h_wts[7,121]=4.94853231601834e-002;
    __statist_i_h_wts[7,122]=4.00596044251206e-002;
    __statist_i_h_wts[7,123]=1.83367137360680e-002;
    __statist_i_h_wts[7,124]=3.12117109109510e-002;
    __statist_i_h_wts[7,125]=2.67809157630838e-002;
    __statist_i_h_wts[7,126]=3.57815466731708e-002;
    __statist_i_h_wts[7,127]=1.07871410117163e-001;
    __statist_i_h_wts[7,128]=7.26449479803008e-002;
    __statist_i_h_wts[7,129]=4.83650222761122e-002;
    __statist_i_h_wts[7,130]=-3.06613186824964e-002;
    __statist_i_h_wts[7,131]=2.35318416477541e-002;
    __statist_i_h_wts[7,132]=3.61999877649152e-002;
    __statist_i_h_wts[7,133]=1.28048367104570e-001;
    __statist_i_h_wts[7,134]=8.52663109289513e-002;
    __statist_i_h_wts[7,135]=2.31048760331826e-002;
    __statist_i_h_wts[7,136]=5.71752803877148e-002;
    __statist_i_h_wts[7,137]=6.89589768872943e-002;
    __statist_i_h_wts[7,138]=3.30662940377773e-002;
    __statist_i_h_wts[7,139]=5.61170128124077e-002;
    __statist_i_h_wts[7,140]=8.68765552974472e-003;
    __statist_i_h_wts[7,141]=1.04389513058910e-001;
    __statist_i_h_wts[7,142]=1.70945366044661e-001;
    __statist_i_h_wts[7,143]=1.38934976599906e-001;
    __statist_i_h_wts[7,144]=6.00539548688454e-002;
    __statist_i_h_wts[7,145]=1.40016012361272e-002;
    __statist_i_h_wts[7,146]=2.41390757703943e-002;
    __statist_i_h_wts[7,147]=1.23235421708920e-001;
    __statist_i_h_wts[7,148]=1.66921672618634e-001;
    __statist_i_h_wts[7,149]=1.27343795815201e-001;
    __statist_i_h_wts[7,150]=4.53350574566799e-002;
    __statist_i_h_wts[7,151]=-1.37989662358286e-002;
    __statist_i_h_wts[7,152]=1.02959600927867e-002;
    __statist_i_h_wts[7,153]=-3.93302295948236e-002;
    __statist_i_h_wts[7,154]=2.58203959616351e-002;
    __statist_i_h_wts[7,155]=6.51600365106554e-002;
    __statist_i_h_wts[7,156]=1.17835871193565e-001;
    __statist_i_h_wts[7,157]=1.59203917372003e-001;
    __statist_i_h_wts[7,158]=1.30517749637400e-001;
    __statist_i_h_wts[7,159]=2.59351313477736e-002;
    __statist_i_h_wts[7,160]=3.22665088857502e-002;
    __statist_i_h_wts[7,161]=-5.88474628555347e-002;
    __statist_i_h_wts[7,162]=5.81185272573479e-002;
    __statist_i_h_wts[7,163]=1.05192707091588e-001;
    __statist_i_h_wts[7,164]=9.87234758031210e-002;
    __statist_i_h_wts[7,165]=9.38522221753786e-002;
    __statist_i_h_wts[7,166]=5.89848532047223e-002;
    __statist_i_h_wts[7,167]=1.07355169061775e-001;
    __statist_i_h_wts[7,168]=5.22958367496746e-002;
    __statist_i_h_wts[7,169]=8.00952597879821e-002;
    __statist_i_h_wts[7,170]=1.04437206616536e-001;
    __statist_i_h_wts[7,171]=9.09389180061441e-002;
    __statist_i_h_wts[7,172]=1.57140664948734e-001;
    __statist_i_h_wts[7,173]=1.42859589746959e-001;
    __statist_i_h_wts[7,174]=1.23156310734755e-001;
    __statist_i_h_wts[7,175]=9.53351543563638e-002;
    __statist_i_h_wts[7,176]=2.31273451588257e-002;
    __statist_i_h_wts[7,177]=4.61619653861254e-002;
    __statist_i_h_wts[7,178]=6.56413454207751e-002;
    __statist_i_h_wts[7,179]=5.47136260699527e-002;
    __statist_i_h_wts[7,180]=8.79714998344753e-002;
    __statist_i_h_wts[7,181]=6.49478808076213e-002;
    __statist_i_h_wts[7,182]=8.90422734328948e-002;
    __statist_i_h_wts[7,183]=3.74257426676899e-002;
    __statist_i_h_wts[7,184]=7.92885808687266e-002;
    __statist_i_h_wts[7,185]=6.54807346758999e-002;
    __statist_i_h_wts[7,186]=1.04755762934567e-001;
    __statist_i_h_wts[7,187]=1.81523238486335e-001;
    __statist_i_h_wts[7,188]=1.30387795918200e-001;
    __statist_i_h_wts[7,189]=6.68451935818411e-002;
    __statist_i_h_wts[7,190]=6.89349668708791e-002;
    __statist_i_h_wts[7,191]=4.06110223464446e-002;
    __statist_i_h_wts[7,192]=6.32246493227418e-002;
    __statist_i_h_wts[7,193]=7.72104106522255e-002;
    __statist_i_h_wts[7,194]=5.95535055900006e-002;
    __statist_i_h_wts[7,195]=1.13985003626997e-001;
    __statist_i_h_wts[7,196]=5.31692117549488e-002;
    __statist_i_h_wts[7,197]=1.12731145163611e-001;
    __statist_i_h_wts[7,198]=1.06458691637505e-001;
    __statist_i_h_wts[7,199]=9.49245905328478e-002;
    __statist_i_h_wts[7,200]=1.30811831459310e-001;
    __statist_i_h_wts[7,201]=1.17724504123052e-001;
    __statist_i_h_wts[7,202]=1.17421528183755e-001;
    __statist_i_h_wts[7,203]=5.91129597666013e-002;
    __statist_i_h_wts[7,204]=3.65012683679893e-002;
    __statist_i_h_wts[7,205]=4.32353816619920e-002;
    __statist_i_h_wts[7,206]=3.43013391268651e-002;
    __statist_i_h_wts[7,207]=3.62585701892411e-002;
    __statist_i_h_wts[7,208]=4.79826212145666e-002;
    __statist_i_h_wts[7,209]=8.24253796168650e-002;
    __statist_i_h_wts[7,210]=1.85542105253596e-001;
    __statist_i_h_wts[7,211]=1.04797273749244e-001;
    __statist_i_h_wts[7,212]=1.66738197239609e-001;
    __statist_i_h_wts[7,213]=2.06064936825323e-001;
    __statist_i_h_wts[7,214]=1.77093523620598e-001;
    __statist_i_h_wts[7,215]=1.86201336879372e-001;
    __statist_i_h_wts[7,216]=1.76509555084131e-001;
    __statist_i_h_wts[7,217]=1.59917923340933e-001;
    __statist_i_h_wts[7,218]=1.07880939403246e-001;
    __statist_i_h_wts[7,219]=1.21160821022819e-001;
    __statist_i_h_wts[7,220]=1.12094053341500e-001;
    __statist_i_h_wts[7,221]=7.37950066739981e-002;
    __statist_i_h_wts[7,222]=7.64347237240810e-002;
    __statist_i_h_wts[7,223]=6.67091956737309e-002;
    __statist_i_h_wts[7,224]=7.11770431146833e-002;
    __statist_i_h_wts[7,225]=-1.34720262437211e-003;
    __statist_i_h_wts[7,226]=-2.77975522025464e-001;
    __statist_i_h_wts[7,227]=-4.08598713888519e-002;
    __statist_i_h_wts[7,228]=-3.27718944310999e-001;
    __statist_i_h_wts[7,229]=-2.83326220828543e-002;
    __statist_i_h_wts[7,230]=5.13446212290419e-001;
    __statist_i_h_wts[7,231]=3.56954543212199e-001;
    __statist_i_h_wts[7,232]=6.66096400022305e-001;
    __statist_i_h_wts[7,233]=3.58830571854555e-001;
    __statist_i_h_wts[7,234]=5.93902050409746e-001;
    __statist_i_h_wts[7,235]=-1.08812146006531e-001;
    __statist_i_h_wts[7,236]=-4.22112504750034e-001;
    __statist_i_h_wts[7,237]=-4.47175721984166e-001;
    __statist_i_h_wts[7,238]=-1.28035804349687e-001;
    __statist_i_h_wts[7,239]=6.16055787606005e-001;
    __statist_i_h_wts[7,240]=2.95513356877658e-002;
    __statist_i_h_wts[7,241]=-9.67688682628815e-002;
    __statist_i_h_wts[7,242]=2.09488745871680e-001;
    __statist_i_h_wts[7,243]=5.57014456725557e-001;
    __statist_i_h_wts[7,244]=-1.44487669458180e-001;
    __statist_i_h_wts[7,245]=-3.41183168886812e-001;
    __statist_i_h_wts[7,246]=-2.92333839491418e-001;
    __statist_i_h_wts[7,247]=-5.71749802743994e-001;
    __statist_i_h_wts[7,248]=-1.82037972737201e-001;

    __statist_i_h_wts[8,0]=-5.52125780758251e-003;
    __statist_i_h_wts[8,1]=-6.28934428712303e-002;
    __statist_i_h_wts[8,2]=-9.35543032477456e-002;
    __statist_i_h_wts[8,3]=-1.96192400282695e-002;
    __statist_i_h_wts[8,4]=2.54209742630749e-002;
    __statist_i_h_wts[8,5]=6.80070361403439e-002;
    __statist_i_h_wts[8,6]=-1.52944423124401e-002;
    __statist_i_h_wts[8,7]=-3.16594490784053e-002;
    __statist_i_h_wts[8,8]=-1.10388099884357e-001;
    __statist_i_h_wts[8,9]=-9.83697098182699e-002;
    __statist_i_h_wts[8,10]=-1.16790593003781e-001;
    __statist_i_h_wts[8,11]=-1.16157940106585e-001;
    __statist_i_h_wts[8,12]=8.03919179664434e-002;
    __statist_i_h_wts[8,13]=1.03238613405516e-001;
    __statist_i_h_wts[8,14]=-3.59006831079843e-002;
    __statist_i_h_wts[8,15]=-1.98724609894154e-001;
    __statist_i_h_wts[8,16]=-2.31345917247476e-001;
    __statist_i_h_wts[8,17]=-2.68477341207828e-001;
    __statist_i_h_wts[8,18]=-1.52610138557599e-001;
    __statist_i_h_wts[8,19]=-1.60317983243142e-001;
    __statist_i_h_wts[8,20]=-1.56494933796687e-001;
    __statist_i_h_wts[8,21]=-1.46534235328681e-001;
    __statist_i_h_wts[8,22]=-6.59849451254291e-002;
    __statist_i_h_wts[8,23]=-1.70489936015810e-001;
    __statist_i_h_wts[8,24]=-2.52356686468120e-001;
    __statist_i_h_wts[8,25]=-2.77349234463286e-001;
    __statist_i_h_wts[8,26]=-2.14752049173650e-001;
    __statist_i_h_wts[8,27]=-5.00660925395373e-002;
    __statist_i_h_wts[8,28]=7.91808488362758e-002;
    __statist_i_h_wts[8,29]=-6.02965230688389e-002;
    __statist_i_h_wts[8,30]=-1.97475174936811e-001;
    __statist_i_h_wts[8,31]=-1.58300521843576e-001;
    __statist_i_h_wts[8,32]=-2.53893077047799e-001;
    __statist_i_h_wts[8,33]=-1.44546147339051e-001;
    __statist_i_h_wts[8,34]=-1.42556295420851e-001;
    __statist_i_h_wts[8,35]=-1.19091901412071e-001;
    __statist_i_h_wts[8,36]=-1.15789984720400e-001;
    __statist_i_h_wts[8,37]=-7.98681514500944e-002;
    __statist_i_h_wts[8,38]=-1.61415203038970e-001;
    __statist_i_h_wts[8,39]=-1.03954926351430e-001;
    __statist_i_h_wts[8,40]=-2.03683270252006e-001;
    __statist_i_h_wts[8,41]=-1.80808071042279e-001;
    __statist_i_h_wts[8,42]=-5.79321083223513e-003;
    __statist_i_h_wts[8,43]=5.32224350779216e-002;
    __statist_i_h_wts[8,44]=1.86043981592242e-002;
    __statist_i_h_wts[8,45]=-1.88171053025965e-001;
    __statist_i_h_wts[8,46]=-6.11040243547948e-002;
    __statist_i_h_wts[8,47]=-3.65080786062198e-002;
    __statist_i_h_wts[8,48]=-5.39476578453190e-002;
    __statist_i_h_wts[8,49]=-1.88837970837071e-001;
    __statist_i_h_wts[8,50]=-1.06164050120361e-001;
    __statist_i_h_wts[8,51]=-2.15846951147692e-002;
    __statist_i_h_wts[8,52]=7.95508068932453e-003;
    __statist_i_h_wts[8,53]=-1.03765010593718e-001;
    __statist_i_h_wts[8,54]=-1.51247561546219e-001;
    __statist_i_h_wts[8,55]=-1.87669569423189e-001;
    __statist_i_h_wts[8,56]=-1.32408945253881e-001;
    __statist_i_h_wts[8,57]=-2.67836052542566e-003;
    __statist_i_h_wts[8,58]=2.94125083665712e-002;
    __statist_i_h_wts[8,59]=1.51270522123470e-002;
    __statist_i_h_wts[8,60]=-1.82238305666542e-001;
    __statist_i_h_wts[8,61]=-5.36472047119523e-002;
    __statist_i_h_wts[8,62]=-6.46736916153521e-002;
    __statist_i_h_wts[8,63]=-9.52371003804144e-002;
    __statist_i_h_wts[8,64]=-9.07492421771140e-002;
    __statist_i_h_wts[8,65]=1.90857462463864e-002;
    __statist_i_h_wts[8,66]=4.53932454522453e-002;
    __statist_i_h_wts[8,67]=7.04585757515780e-002;
    __statist_i_h_wts[8,68]=2.85610868399051e-002;
    __statist_i_h_wts[8,69]=-3.65153491528006e-002;
    __statist_i_h_wts[8,70]=-1.84063075355280e-001;
    __statist_i_h_wts[8,71]=-2.08597233309108e-001;
    __statist_i_h_wts[8,72]=2.96067420382142e-002;
    __statist_i_h_wts[8,73]=-9.63090808240058e-003;
    __statist_i_h_wts[8,74]=-9.21958725788949e-002;
    __statist_i_h_wts[8,75]=-1.85832838365385e-001;
    __statist_i_h_wts[8,76]=-1.36547437974631e-001;
    __statist_i_h_wts[8,77]=-1.36416885758994e-001;
    __statist_i_h_wts[8,78]=-1.34559710594636e-001;
    __statist_i_h_wts[8,79]=-5.33016439867004e-002;
    __statist_i_h_wts[8,80]=-3.55275262504870e-002;
    __statist_i_h_wts[8,81]=-1.81967453947782e-002;
    __statist_i_h_wts[8,82]=-7.73837153441881e-002;
    __statist_i_h_wts[8,83]=-1.13020033145175e-001;
    __statist_i_h_wts[8,84]=-1.48433621320794e-001;
    __statist_i_h_wts[8,85]=-3.28292117353544e-001;
    __statist_i_h_wts[8,86]=-1.56741753111730e-001;
    __statist_i_h_wts[8,87]=-1.15742386774852e-006;
    __statist_i_h_wts[8,88]=3.65101363750643e-003;
    __statist_i_h_wts[8,89]=8.17033431526320e-002;
    __statist_i_h_wts[8,90]=-1.20921814195365e-001;
    __statist_i_h_wts[8,91]=-1.13088692869729e-001;
    __statist_i_h_wts[8,92]=-3.49973819024458e-002;
    __statist_i_h_wts[8,93]=2.05659699651596e-002;
    __statist_i_h_wts[8,94]=8.17585102022188e-002;
    __statist_i_h_wts[8,95]=-1.86269113165517e-001;
    __statist_i_h_wts[8,96]=-4.76156572361864e-002;
    __statist_i_h_wts[8,97]=-2.07067883975142e-002;
    __statist_i_h_wts[8,98]=-2.55690698588926e-001;
    __statist_i_h_wts[8,99]=-1.85167985425059e-001;
    __statist_i_h_wts[8,100]=-3.48762630905206e-001;
    __statist_i_h_wts[8,101]=-3.68321006340096e-001;
    __statist_i_h_wts[8,102]=-7.18379915179966e-002;
    __statist_i_h_wts[8,103]=-4.03562674967121e-002;
    __statist_i_h_wts[8,104]=3.45832959956234e-003;
    __statist_i_h_wts[8,105]=5.48842660884948e-002;
    __statist_i_h_wts[8,106]=-4.51781071142757e-002;
    __statist_i_h_wts[8,107]=6.88259844542524e-002;
    __statist_i_h_wts[8,108]=2.79868835359339e-001;
    __statist_i_h_wts[8,109]=1.02312932092798e-001;
    __statist_i_h_wts[8,110]=2.01482185786214e-002;
    __statist_i_h_wts[8,111]=1.46345950512650e-001;
    __statist_i_h_wts[8,112]=-4.82800943940830e-002;
    __statist_i_h_wts[8,113]=-1.06333402748638e-002;
    __statist_i_h_wts[8,114]=-2.20644060010003e-001;
    __statist_i_h_wts[8,115]=-2.61250681211700e-001;
    __statist_i_h_wts[8,116]=-1.93960461350075e-001;
    __statist_i_h_wts[8,117]=-1.07856071825266e-001;
    __statist_i_h_wts[8,118]=-3.53292633030901e-002;
    __statist_i_h_wts[8,119]=3.74409360966251e-002;
    __statist_i_h_wts[8,120]=-5.12062527706093e-003;
    __statist_i_h_wts[8,121]=-1.08673663256330e-001;
    __statist_i_h_wts[8,122]=-1.31843691543244e-001;
    __statist_i_h_wts[8,123]=-5.08295409094488e-002;
    __statist_i_h_wts[8,124]=-8.80168916838708e-002;
    __statist_i_h_wts[8,125]=-6.40547844366357e-002;
    __statist_i_h_wts[8,126]=-1.61553736896201e-002;
    __statist_i_h_wts[8,127]=-1.41978575702510e-001;
    __statist_i_h_wts[8,128]=1.14020836187454e-001;
    __statist_i_h_wts[8,129]=1.80496439652985e-002;
    __statist_i_h_wts[8,130]=-8.07021640733109e-002;
    __statist_i_h_wts[8,131]=-1.18469733277051e-001;
    __statist_i_h_wts[8,132]=4.39724060174773e-002;
    __statist_i_h_wts[8,133]=9.67291477318061e-002;
    __statist_i_h_wts[8,134]=2.65747248474463e-002;
    __statist_i_h_wts[8,135]=-1.19072649957884e-001;
    __statist_i_h_wts[8,136]=-1.07499380652506e-001;
    __statist_i_h_wts[8,137]=-1.43817691025243e-001;
    __statist_i_h_wts[8,138]=-7.90471556976806e-002;
    __statist_i_h_wts[8,139]=-4.26109753235381e-002;
    __statist_i_h_wts[8,140]=8.75941519842311e-002;
    __statist_i_h_wts[8,141]=3.81051912914434e-002;
    __statist_i_h_wts[8,142]=2.88460501188156e-002;
    __statist_i_h_wts[8,143]=1.14915447116686e-001;
    __statist_i_h_wts[8,144]=1.09850629688074e-001;
    __statist_i_h_wts[8,145]=7.89146738976841e-002;
    __statist_i_h_wts[8,146]=-3.65809290643798e-002;
    __statist_i_h_wts[8,147]=-9.12103150072976e-002;
    __statist_i_h_wts[8,148]=6.94292020429475e-002;
    __statist_i_h_wts[8,149]=3.49378796183220e-002;
    __statist_i_h_wts[8,150]=1.67948825982717e-001;
    __statist_i_h_wts[8,151]=1.64893128265918e-001;
    __statist_i_h_wts[8,152]=1.03906784927625e-001;
    __statist_i_h_wts[8,153]=-7.55872701505105e-002;
    __statist_i_h_wts[8,154]=-2.50500627923175e-002;
    __statist_i_h_wts[8,155]=4.26087319881825e-002;
    __statist_i_h_wts[8,156]=-9.12980377401691e-002;
    __statist_i_h_wts[8,157]=-1.12560505426788e-001;
    __statist_i_h_wts[8,158]=1.93549999326042e-001;
    __statist_i_h_wts[8,159]=1.86670647132185e-001;
    __statist_i_h_wts[8,160]=3.26866822094103e-002;
    __statist_i_h_wts[8,161]=-1.87306505380910e-001;
    __statist_i_h_wts[8,162]=-7.99915694693466e-002;
    __statist_i_h_wts[8,163]=-1.34567225618476e-001;
    __statist_i_h_wts[8,164]=-1.96761716908553e-001;
    __statist_i_h_wts[8,165]=4.05246748561959e-002;
    __statist_i_h_wts[8,166]=3.84121181690948e-002;
    __statist_i_h_wts[8,167]=6.95208617500222e-002;
    __statist_i_h_wts[8,168]=1.06031653483132e-001;
    __statist_i_h_wts[8,169]=9.10007477258701e-002;
    __statist_i_h_wts[8,170]=1.21229005641979e-001;
    __statist_i_h_wts[8,171]=3.89636283945719e-002;
    __statist_i_h_wts[8,172]=-1.35005688191229e-002;
    __statist_i_h_wts[8,173]=6.76821405766655e-003;
    __statist_i_h_wts[8,174]=-2.54073936723497e-002;
    __statist_i_h_wts[8,175]=-2.25678534407176e-002;
    __statist_i_h_wts[8,176]=2.59937299235907e-002;
    __statist_i_h_wts[8,177]=-2.12632447832599e-002;
    __statist_i_h_wts[8,178]=9.20927649364058e-002;
    __statist_i_h_wts[8,179]=1.11400749337478e-001;
    __statist_i_h_wts[8,180]=3.41163798177579e-002;
    __statist_i_h_wts[8,181]=4.94857105180113e-002;
    __statist_i_h_wts[8,182]=5.67046664039168e-002;
    __statist_i_h_wts[8,183]=3.59063482111863e-002;
    __statist_i_h_wts[8,184]=4.81278203748487e-002;
    __statist_i_h_wts[8,185]=7.84883198951848e-002;
    __statist_i_h_wts[8,186]=7.93384944161259e-002;
    __statist_i_h_wts[8,187]=3.67246966387857e-002;
    __statist_i_h_wts[8,188]=1.52884147460066e-002;
    __statist_i_h_wts[8,189]=1.53701715553582e-002;
    __statist_i_h_wts[8,190]=1.58491778425925e-002;
    __statist_i_h_wts[8,191]=1.10773477438177e-002;
    __statist_i_h_wts[8,192]=8.52859010085072e-002;
    __statist_i_h_wts[8,193]=1.32862324351175e-001;
    __statist_i_h_wts[8,194]=1.16537462116408e-001;
    __statist_i_h_wts[8,195]=1.04343261172662e-002;
    __statist_i_h_wts[8,196]=1.16377003419590e-002;
    __statist_i_h_wts[8,197]=8.88005611867012e-003;
    __statist_i_h_wts[8,198]=-2.49165316029655e-002;
    __statist_i_h_wts[8,199]=1.11548774509713e-002;
    __statist_i_h_wts[8,200]=2.51285390435188e-002;
    __statist_i_h_wts[8,201]=4.74385861108019e-002;
    __statist_i_h_wts[8,202]=3.16076812352110e-002;
    __statist_i_h_wts[8,203]=-3.22532020668660e-002;
    __statist_i_h_wts[8,204]=-3.27802372784720e-002;
    __statist_i_h_wts[8,205]=-1.87919592796746e-002;
    __statist_i_h_wts[8,206]=-4.04167997773960e-002;
    __statist_i_h_wts[8,207]=-7.90651999282520e-002;
    __statist_i_h_wts[8,208]=1.74114074183440e-002;
    __statist_i_h_wts[8,209]=-2.05626521801829e-002;
    __statist_i_h_wts[8,210]=-2.91503773218891e-002;
    __statist_i_h_wts[8,211]=-2.45444042331489e-003;
    __statist_i_h_wts[8,212]=-2.91746132250927e-002;
    __statist_i_h_wts[8,213]=-8.51045457242276e-002;
    __statist_i_h_wts[8,214]=-4.51782728465632e-002;
    __statist_i_h_wts[8,215]=-4.41079420395846e-002;
    __statist_i_h_wts[8,216]=-2.32506143678572e-002;
    __statist_i_h_wts[8,217]=-8.64026871980758e-002;
    __statist_i_h_wts[8,218]=-8.82738334462294e-002;
    __statist_i_h_wts[8,219]=-5.62219497154763e-002;
    __statist_i_h_wts[8,220]=-3.93194612940628e-002;
    __statist_i_h_wts[8,221]=-2.17320392917980e-002;
    __statist_i_h_wts[8,222]=3.25954820367006e-002;
    __statist_i_h_wts[8,223]=7.38068370100573e-002;
    __statist_i_h_wts[8,224]=5.57957037618445e-002;
    __statist_i_h_wts[8,225]=1.48933234094660e-002;
    __statist_i_h_wts[8,226]=-2.62145444566809e-001;
    __statist_i_h_wts[8,227]=-1.03439930159477e-001;
    __statist_i_h_wts[8,228]=-2.68128956846062e-001;
    __statist_i_h_wts[8,229]=-6.24964081327383e-002;
    __statist_i_h_wts[8,230]=3.04257640235484e-001;
    __statist_i_h_wts[8,231]=3.84713363887891e-002;
    __statist_i_h_wts[8,232]=3.34875043896298e-001;
    __statist_i_h_wts[8,233]=1.34584799962437e-001;
    __statist_i_h_wts[8,234]=1.89738828739492e-001;
    __statist_i_h_wts[8,235]=-1.26758810744235e-001;
    __statist_i_h_wts[8,236]=-3.02524973367969e-001;
    __statist_i_h_wts[8,237]=-2.40634687758895e-001;
    __statist_i_h_wts[8,238]=-1.09533291218330e-001;
    __statist_i_h_wts[8,239]=1.80822059245808e-001;
    __statist_i_h_wts[8,240]=-1.24798865095299e-003;
    __statist_i_h_wts[8,241]=1.36682627547003e-001;
    __statist_i_h_wts[8,242]=3.41885626760483e-002;
    __statist_i_h_wts[8,243]=1.97670189673539e-001;
    __statist_i_h_wts[8,244]=-4.57289345226619e-002;
    __statist_i_h_wts[8,245]=-3.28800285117749e-001;
    __statist_i_h_wts[8,246]=-7.26161253198064e-002;
    __statist_i_h_wts[8,247]=-2.19613904383599e-001;
    __statist_i_h_wts[8,248]=-5.15128375034391e-002;

    __statist_i_h_wts[9,0]=4.50710578304390e-001;
    __statist_i_h_wts[9,1]=4.46163141073001e-001;
    __statist_i_h_wts[9,2]=4.08511629883666e-001;
    __statist_i_h_wts[9,3]=4.13300150037349e-001;
    __statist_i_h_wts[9,4]=4.57689132202827e-001;
    __statist_i_h_wts[9,5]=4.37665499107792e-001;
    __statist_i_h_wts[9,6]=5.68981300171213e-001;
    __statist_i_h_wts[9,7]=6.00739336774152e-001;
    __statist_i_h_wts[9,8]=5.39174572432184e-001;
    __statist_i_h_wts[9,9]=7.04931539258097e-001;
    __statist_i_h_wts[9,10]=5.56715521309923e-001;
    __statist_i_h_wts[9,11]=3.56149784462680e-001;
    __statist_i_h_wts[9,12]=1.82844311038921e-001;
    __statist_i_h_wts[9,13]=3.01940631700706e-001;
    __statist_i_h_wts[9,14]=1.46529158330657e-001;
    __statist_i_h_wts[9,15]=5.57790508986724e-001;
    __statist_i_h_wts[9,16]=5.17943791306934e-001;
    __statist_i_h_wts[9,17]=3.05081739443104e-001;
    __statist_i_h_wts[9,18]=3.44305978100265e-001;
    __statist_i_h_wts[9,19]=3.24481780773762e-001;
    __statist_i_h_wts[9,20]=2.83172087676701e-001;
    __statist_i_h_wts[9,21]=3.06386622987580e-001;
    __statist_i_h_wts[9,22]=4.93332854443665e-001;
    __statist_i_h_wts[9,23]=4.20865524489506e-001;
    __statist_i_h_wts[9,24]=6.17095138440237e-001;
    __statist_i_h_wts[9,25]=5.85127225106092e-001;
    __statist_i_h_wts[9,26]=4.16535524268248e-001;
    __statist_i_h_wts[9,27]=2.19651762626108e-001;
    __statist_i_h_wts[9,28]=3.87773285963625e-001;
    __statist_i_h_wts[9,29]=1.96606914983690e-001;
    __statist_i_h_wts[9,30]=2.61556874515270e-001;
    __statist_i_h_wts[9,31]=2.24341080888644e-001;
    __statist_i_h_wts[9,32]=1.10605202028220e-001;
    __statist_i_h_wts[9,33]=2.31165556358545e-001;
    __statist_i_h_wts[9,34]=2.11070696708497e-001;
    __statist_i_h_wts[9,35]=4.17281705119351e-002;
    __statist_i_h_wts[9,36]=1.22911498817006e-001;
    __statist_i_h_wts[9,37]=2.97112696174732e-001;
    __statist_i_h_wts[9,38]=1.32666597921636e-001;
    __statist_i_h_wts[9,39]=3.41370407722997e-001;
    __statist_i_h_wts[9,40]=2.15534442435188e-001;
    __statist_i_h_wts[9,41]=1.00932681959645e-001;
    __statist_i_h_wts[9,42]=-9.72891463545015e-002;
    __statist_i_h_wts[9,43]=2.34269045825885e-001;
    __statist_i_h_wts[9,44]=9.09271066396932e-002;
    __statist_i_h_wts[9,45]=7.79811618003003e-002;
    __statist_i_h_wts[9,46]=3.11843653487109e-003;
    __statist_i_h_wts[9,47]=-2.89159062994419e-001;
    __statist_i_h_wts[9,48]=-1.49881221649775e-001;
    __statist_i_h_wts[9,49]=-4.71743370399571e-002;
    __statist_i_h_wts[9,50]=-2.37518090609207e-001;
    __statist_i_h_wts[9,51]=-2.24853172324539e-001;
    __statist_i_h_wts[9,52]=-3.11315305263060e-002;
    __statist_i_h_wts[9,53]=8.32492428000025e-002;
    __statist_i_h_wts[9,54]=2.21443820464446e-001;
    __statist_i_h_wts[9,55]=2.31708515485382e-001;
    __statist_i_h_wts[9,56]=9.18089094338093e-003;
    __statist_i_h_wts[9,57]=-1.53134631110947e-001;
    __statist_i_h_wts[9,58]=-8.36588294509024e-002;
    __statist_i_h_wts[9,59]=-7.38253335301098e-002;
    __statist_i_h_wts[9,60]=-1.30371639876471e-001;
    __statist_i_h_wts[9,61]=9.84364671120031e-002;
    __statist_i_h_wts[9,62]=-1.54876938281213e-001;
    __statist_i_h_wts[9,63]=1.67931993818963e-003;
    __statist_i_h_wts[9,64]=-1.28168034860616e-001;
    __statist_i_h_wts[9,65]=-3.16416804183245e-001;
    __statist_i_h_wts[9,66]=-3.52164736120516e-001;
    __statist_i_h_wts[9,67]=3.20856090039727e-001;
    __statist_i_h_wts[9,68]=-5.92722486574161e-002;
    __statist_i_h_wts[9,69]=1.63758255913907e-001;
    __statist_i_h_wts[9,70]=6.58323266060303e-001;
    __statist_i_h_wts[9,71]=4.64470637616972e-001;
    __statist_i_h_wts[9,72]=-1.33522753113873e-001;
    __statist_i_h_wts[9,73]=-1.98286188410883e-001;
    __statist_i_h_wts[9,74]=-1.99194118647800e-001;
    __statist_i_h_wts[9,75]=-2.89533322352080e-002;
    __statist_i_h_wts[9,76]=2.35856524641747e-001;
    __statist_i_h_wts[9,77]=4.39421792547446e-001;
    __statist_i_h_wts[9,78]=2.44811230218761e-001;
    __statist_i_h_wts[9,79]=8.47991308380221e-002;
    __statist_i_h_wts[9,80]=4.78688069473363e-003;
    __statist_i_h_wts[9,81]=-1.60677610364769e-001;
    __statist_i_h_wts[9,82]=6.47562482589535e-001;
    __statist_i_h_wts[9,83]=4.33835551663124e-001;
    __statist_i_h_wts[9,84]=4.21908003902826e-001;
    __statist_i_h_wts[9,85]=7.29876241368961e-001;
    __statist_i_h_wts[9,86]=5.26951707805454e-001;
    __statist_i_h_wts[9,87]=-2.86046997245990e-001;
    __statist_i_h_wts[9,88]=-2.63527182040932e-001;
    __statist_i_h_wts[9,89]=-3.49861884755456e-001;
    __statist_i_h_wts[9,90]=4.94371059096476e-001;
    __statist_i_h_wts[9,91]=6.87927260946376e-001;
    __statist_i_h_wts[9,92]=8.40053221487106e-001;
    __statist_i_h_wts[9,93]=9.46776625542624e-001;
    __statist_i_h_wts[9,94]=9.47343884935372e-002;
    __statist_i_h_wts[9,95]=1.27247326976469e-001;
    __statist_i_h_wts[9,96]=9.23061390388991e-002;
    __statist_i_h_wts[9,97]=4.78633469294271e-001;
    __statist_i_h_wts[9,98]=1.98417217523116e-003;
    __statist_i_h_wts[9,99]=2.31951585670385e-001;
    __statist_i_h_wts[9,100]=2.17956650164994e-001;
    __statist_i_h_wts[9,101]=8.72368557256022e-001;
    __statist_i_h_wts[9,102]=-1.64403901851447e-002;
    __statist_i_h_wts[9,103]=8.27134992491129e-003;
    __statist_i_h_wts[9,104]=2.66215193099448e-001;
    __statist_i_h_wts[9,105]=3.94918844734622e-001;
    __statist_i_h_wts[9,106]=3.19448544457327e-001;
    __statist_i_h_wts[9,107]=1.87865840941113e-001;
    __statist_i_h_wts[9,108]=9.21645342901752e-002;
    __statist_i_h_wts[9,109]=-2.56222826198512e-001;
    __statist_i_h_wts[9,110]=-3.00643419066680e-001;
    __statist_i_h_wts[9,111]=-3.65694950179255e-001;
    __statist_i_h_wts[9,112]=5.27155532072918e-002;
    __statist_i_h_wts[9,113]=-1.63023464891650e-001;
    __statist_i_h_wts[9,114]=4.10811586329877e-001;
    __statist_i_h_wts[9,115]=8.03727178752279e-001;
    __statist_i_h_wts[9,116]=8.99175897230664e-001;
    __statist_i_h_wts[9,117]=-4.01332733573373e-001;
    __statist_i_h_wts[9,118]=-6.01975807428377e-001;
    __statist_i_h_wts[9,119]=1.49187702871944e-001;
    __statist_i_h_wts[9,120]=-1.00047394603915e-003;
    __statist_i_h_wts[9,121]=1.92082439722560e-001;
    __statist_i_h_wts[9,122]=-2.13526347456305e-001;
    __statist_i_h_wts[9,123]=2.46558271885403e-001;
    __statist_i_h_wts[9,124]=4.43098303722029e-001;
    __statist_i_h_wts[9,125]=3.92035381254098e-001;
    __statist_i_h_wts[9,126]=1.57448241366970e-001;
    __statist_i_h_wts[9,127]=4.66854402759776e-001;
    __statist_i_h_wts[9,128]=-9.38607388122903e-002;
    __statist_i_h_wts[9,129]=1.24500249242595e-001;
    __statist_i_h_wts[9,130]=3.57397829351260e-001;
    __statist_i_h_wts[9,131]=3.81681039004586e-001;
    __statist_i_h_wts[9,132]=-3.62995328807036e-001;
    __statist_i_h_wts[9,133]=-3.13655361790911e-002;
    __statist_i_h_wts[9,134]=-4.57261176054470e-001;
    __statist_i_h_wts[9,135]=1.36113085867835e-001;
    __statist_i_h_wts[9,136]=-7.27288797839448e-002;
    __statist_i_h_wts[9,137]=-3.49541409063319e-001;
    __statist_i_h_wts[9,138]=5.47892085793630e-002;
    __statist_i_h_wts[9,139]=2.78135371816925e-001;
    __statist_i_h_wts[9,140]=-2.04832666027163e-001;
    __statist_i_h_wts[9,141]=-2.18722302798636e-001;
    __statist_i_h_wts[9,142]=7.40457720209797e-001;
    __statist_i_h_wts[9,143]=3.25540810775387e-001;
    __statist_i_h_wts[9,144]=1.80012551822407e-001;
    __statist_i_h_wts[9,145]=3.59761119829112e-001;
    __statist_i_h_wts[9,146]=5.39375071623098e-001;
    __statist_i_h_wts[9,147]=2.19332446205015e-001;
    __statist_i_h_wts[9,148]=-8.24391993128920e-003;
    __statist_i_h_wts[9,149]=-3.35704995846773e-001;
    __statist_i_h_wts[9,150]=1.07310075660984e-001;
    __statist_i_h_wts[9,151]=-1.21368959996530e-001;
    __statist_i_h_wts[9,152]=-3.52110405227829e-001;
    __statist_i_h_wts[9,153]=7.13951709960412e-002;
    __statist_i_h_wts[9,154]=-6.15207350431939e-002;
    __statist_i_h_wts[9,155]=-3.03265054133829e-001;
    __statist_i_h_wts[9,156]=-2.19744637893008e-002;
    __statist_i_h_wts[9,157]=5.97415337642732e-001;
    __statist_i_h_wts[9,158]=3.01169408896039e-001;
    __statist_i_h_wts[9,159]=-3.15044265802039e-001;
    __statist_i_h_wts[9,160]=-3.51018450048479e-001;
    __statist_i_h_wts[9,161]=-2.17954255951279e-001;
    __statist_i_h_wts[9,162]=-8.68599935076035e-002;
    __statist_i_h_wts[9,163]=-3.32450971527054e-001;
    __statist_i_h_wts[9,164]=-4.66439284711724e-001;
    __statist_i_h_wts[9,165]=2.10990308560497e-001;
    __statist_i_h_wts[9,166]=1.45271401074480e-001;
    __statist_i_h_wts[9,167]=-6.76333393387212e-002;
    __statist_i_h_wts[9,168]=-2.00294807622427e-002;
    __statist_i_h_wts[9,169]=-1.58196579490668e-001;
    __statist_i_h_wts[9,170]=-5.17759729264601e-001;
    __statist_i_h_wts[9,171]=-7.92918959123236e-001;
    __statist_i_h_wts[9,172]=2.88555816306989e-001;
    __statist_i_h_wts[9,173]=-3.88699435788803e-002;
    __statist_i_h_wts[9,174]=-1.71468842364094e-002;
    __statist_i_h_wts[9,175]=-1.87903905834267e-001;
    __statist_i_h_wts[9,176]=-1.22517179710849e-001;
    __statist_i_h_wts[9,177]=-4.21617080529848e-001;
    __statist_i_h_wts[9,178]=-5.42653541686052e-001;
    __statist_i_h_wts[9,179]=-5.20397426458769e-001;
    __statist_i_h_wts[9,180]=-9.86205048303645e-001;
    __statist_i_h_wts[9,181]=-5.64238937591425e-002;
    __statist_i_h_wts[9,182]=-2.03968602088780e-001;
    __statist_i_h_wts[9,183]=-9.04043835840358e-001;
    __statist_i_h_wts[9,184]=-8.34618925373275e-001;
    __statist_i_h_wts[9,185]=-8.85416019736743e-001;
    __statist_i_h_wts[9,186]=-1.04246676136765e+000;
    __statist_i_h_wts[9,187]=8.73691910315039e-002;
    __statist_i_h_wts[9,188]=-3.74620797577179e-001;
    __statist_i_h_wts[9,189]=-6.53905773365560e-001;
    __statist_i_h_wts[9,190]=-8.48650207613895e-001;
    __statist_i_h_wts[9,191]=-2.75990574162180e-001;
    __statist_i_h_wts[9,192]=-3.10406518985535e-002;
    __statist_i_h_wts[9,193]=-5.75998536245059e-002;
    __statist_i_h_wts[9,194]=-3.39171692293739e-001;
    __statist_i_h_wts[9,195]=-1.13592211338062e+000;
    __statist_i_h_wts[9,196]=-6.20379980951644e-001;
    __statist_i_h_wts[9,197]=-2.16428439008779e-001;
    __statist_i_h_wts[9,198]=-5.06894679346839e-001;
    __statist_i_h_wts[9,199]=-5.88777360666721e-001;
    __statist_i_h_wts[9,200]=-5.13256715566045e-001;
    __statist_i_h_wts[9,201]=-3.88856459766781e-001;
    __statist_i_h_wts[9,202]=-7.23214943051807e-002;
    __statist_i_h_wts[9,203]=-7.80973995132170e-001;
    __statist_i_h_wts[9,204]=-9.55341180767354e-001;
    __statist_i_h_wts[9,205]=-1.12247240501000e+000;
    __statist_i_h_wts[9,206]=-7.44472115727412e-001;
    __statist_i_h_wts[9,207]=-7.22853911334428e-001;
    __statist_i_h_wts[9,208]=-6.99481508875844e-001;
    __statist_i_h_wts[9,209]=-5.94326763766644e-001;
    __statist_i_h_wts[9,210]=-6.43062055701340e-001;
    __statist_i_h_wts[9,211]=-4.50406161734292e-001;
    __statist_i_h_wts[9,212]=-1.97702140098396e-001;
    __statist_i_h_wts[9,213]=-4.06953494570854e-001;
    __statist_i_h_wts[9,214]=-2.35995973577046e-001;
    __statist_i_h_wts[9,215]=-3.05723265586445e-001;
    __statist_i_h_wts[9,216]=-7.67962359993390e-001;
    __statist_i_h_wts[9,217]=-5.42737873989492e-001;
    __statist_i_h_wts[9,218]=-1.01033315379708e+000;
    __statist_i_h_wts[9,219]=-3.36244975658232e-001;
    __statist_i_h_wts[9,220]=-2.08947257033096e-001;
    __statist_i_h_wts[9,221]=3.04579528414204e-003;
    __statist_i_h_wts[9,222]=-1.68944345517739e-001;
    __statist_i_h_wts[9,223]=-5.13561464745657e-001;
    __statist_i_h_wts[9,224]=-4.11552683224712e-001;
    __statist_i_h_wts[9,225]=4.73662390747961e-001;
    __statist_i_h_wts[9,226]=1.29074493864401e+000;
    __statist_i_h_wts[9,227]=8.01495824005275e-003;
    __statist_i_h_wts[9,228]=1.02858603316493e+000;
    __statist_i_h_wts[9,229]=3.47132884642034e-001;
    __statist_i_h_wts[9,230]=-6.46210641149266e-001;
    __statist_i_h_wts[9,231]=4.06441530608178e-001;
    __statist_i_h_wts[9,232]=-2.16606340498372e-001;
    __statist_i_h_wts[9,233]=-1.07273103941240e+000;
    __statist_i_h_wts[9,234]=-1.04287262510203e+000;
    __statist_i_h_wts[9,235]=6.52045984251702e-001;
    __statist_i_h_wts[9,236]=1.53583489069538e+000;
    __statist_i_h_wts[9,237]=1.42849445613517e+000;
    __statist_i_h_wts[9,238]=5.62119463880540e-001;
    __statist_i_h_wts[9,239]=-1.07786212161550e+000;
    __statist_i_h_wts[9,240]=2.97167304409810e-001;
    __statist_i_h_wts[9,241]=-5.80643219425400e+000;
    __statist_i_h_wts[9,242]=-3.66835399281090e-003;
    __statist_i_h_wts[9,243]=-1.97172309650562e+000;
    __statist_i_h_wts[9,244]=-5.70001142716608e-001;
    __statist_i_h_wts[9,245]=1.99655739831115e+000;
    __statist_i_h_wts[9,246]=-9.04499173681624e-001;
    __statist_i_h_wts[9,247]=8.37862965207034e-001;
    __statist_i_h_wts[9,248]=-6.12186996811298e-002;

    __statist_i_h_wts[10,0]=5.13008619967639e-002;
    __statist_i_h_wts[10,1]=6.50721587652216e-002;
    __statist_i_h_wts[10,2]=-8.47420691241545e-002;
    __statist_i_h_wts[10,3]=-1.03708795160070e-001;
    __statist_i_h_wts[10,4]=-8.96527593826509e-002;
    __statist_i_h_wts[10,5]=-1.35846827300861e-001;
    __statist_i_h_wts[10,6]=-1.13355879445601e-001;
    __statist_i_h_wts[10,7]=-6.04138901436754e-002;
    __statist_i_h_wts[10,8]=-2.58759618100849e-001;
    __statist_i_h_wts[10,9]=-2.93751609631934e-001;
    __statist_i_h_wts[10,10]=-8.93736146656381e-002;
    __statist_i_h_wts[10,11]=-1.31022802086748e-001;
    __statist_i_h_wts[10,12]=2.53866642281628e-002;
    __statist_i_h_wts[10,13]=2.83245497941082e-002;
    __statist_i_h_wts[10,14]=-2.43173121891177e-001;
    __statist_i_h_wts[10,15]=3.26207004149374e-002;
    __statist_i_h_wts[10,16]=-9.52626446534054e-003;
    __statist_i_h_wts[10,17]=-1.53280943138500e-001;
    __statist_i_h_wts[10,18]=-1.63349222314108e-002;
    __statist_i_h_wts[10,19]=1.48381144576597e-002;
    __statist_i_h_wts[10,20]=1.81840776975884e-002;
    __statist_i_h_wts[10,21]=-2.74184596962485e-002;
    __statist_i_h_wts[10,22]=1.54392103107887e-001;
    __statist_i_h_wts[10,23]=-1.32872555718439e-001;
    __statist_i_h_wts[10,24]=-2.07778159550856e-001;
    __statist_i_h_wts[10,25]=3.71737576077985e-002;
    __statist_i_h_wts[10,26]=3.15078688164406e-002;
    __statist_i_h_wts[10,27]=1.83580626903285e-001;
    __statist_i_h_wts[10,28]=1.03525852291592e-001;
    __statist_i_h_wts[10,29]=-1.34172815601455e-001;
    __statist_i_h_wts[10,30]=3.26130837560786e-002;
    __statist_i_h_wts[10,31]=1.99001849918172e-002;
    __statist_i_h_wts[10,32]=-2.20933173484841e-001;
    __statist_i_h_wts[10,33]=1.77223152637952e-003;
    __statist_i_h_wts[10,34]=6.30485200617703e-002;
    __statist_i_h_wts[10,35]=5.42728592063904e-002;
    __statist_i_h_wts[10,36]=1.10460094405458e-001;
    __statist_i_h_wts[10,37]=2.00255643022588e-001;
    __statist_i_h_wts[10,38]=-1.53370945208257e-002;
    __statist_i_h_wts[10,39]=9.93232657137744e-002;
    __statist_i_h_wts[10,40]=-1.43235704823987e-002;
    __statist_i_h_wts[10,41]=-3.84450535251199e-002;
    __statist_i_h_wts[10,42]=-8.15502108491608e-002;
    __statist_i_h_wts[10,43]=7.52148171417314e-003;
    __statist_i_h_wts[10,44]=1.69770791303179e-002;
    __statist_i_h_wts[10,45]=3.14587037709487e-002;
    __statist_i_h_wts[10,46]=1.00523989856851e-001;
    __statist_i_h_wts[10,47]=1.53544231348067e-001;
    __statist_i_h_wts[10,48]=-6.73572179695204e-002;
    __statist_i_h_wts[10,49]=3.55044098940303e-002;
    __statist_i_h_wts[10,50]=-7.36699996265738e-002;
    __statist_i_h_wts[10,51]=4.95629423269463e-002;
    __statist_i_h_wts[10,52]=6.47872926858875e-002;
    __statist_i_h_wts[10,53]=3.80216654369427e-002;
    __statist_i_h_wts[10,54]=-1.27572099782242e-001;
    __statist_i_h_wts[10,55]=-1.20959403049966e-001;
    __statist_i_h_wts[10,56]=-1.53579593463101e-001;
    __statist_i_h_wts[10,57]=-1.47278638047615e-001;
    __statist_i_h_wts[10,58]=-1.30455576672180e-001;
    __statist_i_h_wts[10,59]=7.91151765988049e-002;
    __statist_i_h_wts[10,60]=5.58317043642359e-002;
    __statist_i_h_wts[10,61]=1.00234898470667e-001;
    __statist_i_h_wts[10,62]=-1.78526092855584e-002;
    __statist_i_h_wts[10,63]=-2.42118717185315e-001;
    __statist_i_h_wts[10,64]=-4.43248974076830e-002;
    __statist_i_h_wts[10,65]=-1.03589249666545e-001;
    __statist_i_h_wts[10,66]=9.19051519269030e-003;
    __statist_i_h_wts[10,67]=1.49137829962976e-001;
    __statist_i_h_wts[10,68]=-1.33904705931278e-002;
    __statist_i_h_wts[10,69]=-2.02132532594057e-001;
    __statist_i_h_wts[10,70]=-1.30396651152945e-002;
    __statist_i_h_wts[10,71]=-4.34453357134585e-002;
    __statist_i_h_wts[10,72]=-9.09876266145300e-002;
    __statist_i_h_wts[10,73]=-1.91516087919159e-001;
    __statist_i_h_wts[10,74]=-1.47285757425315e-001;
    __statist_i_h_wts[10,75]=2.04821416877762e-001;
    __statist_i_h_wts[10,76]=2.52068230511971e-001;
    __statist_i_h_wts[10,77]=1.52698067150059e-001;
    __statist_i_h_wts[10,78]=7.93590927029172e-002;
    __statist_i_h_wts[10,79]=1.62492466616078e-001;
    __statist_i_h_wts[10,80]=-2.30675362085040e-001;
    __statist_i_h_wts[10,81]=-8.61661767060232e-002;
    __statist_i_h_wts[10,82]=-6.92027771503871e-002;
    __statist_i_h_wts[10,83]=-2.22550825161333e-001;
    __statist_i_h_wts[10,84]=-7.72380384004975e-002;
    __statist_i_h_wts[10,85]=8.28103315702636e-002;
    __statist_i_h_wts[10,86]=1.21375471868637e-001;
    __statist_i_h_wts[10,87]=2.77861258778732e-001;
    __statist_i_h_wts[10,88]=2.94171153562511e-002;
    __statist_i_h_wts[10,89]=6.54921654219007e-002;
    __statist_i_h_wts[10,90]=1.54849930223533e-001;
    __statist_i_h_wts[10,91]=1.25296238420727e-001;
    __statist_i_h_wts[10,92]=2.45678960430416e-001;
    __statist_i_h_wts[10,93]=9.97453683211370e-003;
    __statist_i_h_wts[10,94]=1.59001438816237e-001;
    __statist_i_h_wts[10,95]=-2.21358302731012e-001;
    __statist_i_h_wts[10,96]=-4.15381826348005e-002;
    __statist_i_h_wts[10,97]=-1.65896786524389e-002;
    __statist_i_h_wts[10,98]=-9.87674129682769e-002;
    __statist_i_h_wts[10,99]=9.45941315796334e-002;
    __statist_i_h_wts[10,100]=8.13073572563996e-002;
    __statist_i_h_wts[10,101]=-7.69719427348257e-002;
    __statist_i_h_wts[10,102]=2.33421350227393e-001;
    __statist_i_h_wts[10,103]=-3.95943326491323e-002;
    __statist_i_h_wts[10,104]=-5.16460095819391e-002;
    __statist_i_h_wts[10,105]=2.20383920539748e-001;
    __statist_i_h_wts[10,106]=1.08654936007019e-002;
    __statist_i_h_wts[10,107]=7.43220382756229e-002;
    __statist_i_h_wts[10,108]=-1.39284727035445e-002;
    __statist_i_h_wts[10,109]=-8.88369648110691e-002;
    __statist_i_h_wts[10,110]=-8.73351773251031e-002;
    __statist_i_h_wts[10,111]=-5.74560197033629e-002;
    __statist_i_h_wts[10,112]=-6.74353142703664e-002;
    __statist_i_h_wts[10,113]=1.18008435483083e-001;
    __statist_i_h_wts[10,114]=9.51210397757567e-002;
    __statist_i_h_wts[10,115]=2.50523689071959e-001;
    __statist_i_h_wts[10,116]=3.04729067565198e-001;
    __statist_i_h_wts[10,117]=2.56009819200507e-001;
    __statist_i_h_wts[10,118]=-4.36661683201583e-002;
    __statist_i_h_wts[10,119]=4.02445270734319e-002;
    __statist_i_h_wts[10,120]=1.38444681331731e-001;
    __statist_i_h_wts[10,121]=2.36475702294551e-002;
    __statist_i_h_wts[10,122]=-2.71929295862041e-002;
    __statist_i_h_wts[10,123]=-1.37389753733444e-001;
    __statist_i_h_wts[10,124]=-1.77147562242919e-001;
    __statist_i_h_wts[10,125]=-2.54584564866573e-001;
    __statist_i_h_wts[10,126]=-2.89355860881263e-001;
    __statist_i_h_wts[10,127]=-2.60678364197138e-001;
    __statist_i_h_wts[10,128]=1.33361318971458e-001;
    __statist_i_h_wts[10,129]=1.10404807174552e-001;
    __statist_i_h_wts[10,130]=5.79283994232193e-002;
    __statist_i_h_wts[10,131]=-1.71080702844216e-002;
    __statist_i_h_wts[10,132]=1.43054534160943e-001;
    __statist_i_h_wts[10,133]=1.84338823185558e-002;
    __statist_i_h_wts[10,134]=-5.05154277056083e-002;
    __statist_i_h_wts[10,135]=2.59277272625796e-001;
    __statist_i_h_wts[10,136]=6.88584197185549e-002;
    __statist_i_h_wts[10,137]=1.09517232829619e-001;
    __statist_i_h_wts[10,138]=-1.38895891221956e-001;
    __statist_i_h_wts[10,139]=-1.83561476451986e-001;
    __statist_i_h_wts[10,140]=-1.40492561581388e-001;
    __statist_i_h_wts[10,141]=-1.08588849877229e-001;
    __statist_i_h_wts[10,142]=4.98428374950164e-002;
    __statist_i_h_wts[10,143]=3.91994098806436e-001;
    __statist_i_h_wts[10,144]=3.35108356733150e-001;
    __statist_i_h_wts[10,145]=1.68279672750806e-001;
    __statist_i_h_wts[10,146]=2.93769300491428e-002;
    __statist_i_h_wts[10,147]=1.30655303129729e-001;
    __statist_i_h_wts[10,148]=5.38690521887973e-002;
    __statist_i_h_wts[10,149]=2.60301450171290e-002;
    __statist_i_h_wts[10,150]=3.41256094688256e-001;
    __statist_i_h_wts[10,151]=1.10595929054585e-001;
    __statist_i_h_wts[10,152]=1.63587376168813e-001;
    __statist_i_h_wts[10,153]=-1.86543236333611e-001;
    __statist_i_h_wts[10,154]=-2.23700426465353e-001;
    __statist_i_h_wts[10,155]=-5.04068904120700e-002;
    __statist_i_h_wts[10,156]=-1.08740844714354e-001;
    __statist_i_h_wts[10,157]=-1.28881089273123e-001;
    __statist_i_h_wts[10,158]=2.65581312148705e-001;
    __statist_i_h_wts[10,159]=2.01396914223546e-001;
    __statist_i_h_wts[10,160]=-2.35115785925377e-002;
    __statist_i_h_wts[10,161]=-2.70016460639998e-001;
    __statist_i_h_wts[10,162]=5.97465154728041e-002;
    __statist_i_h_wts[10,163]=-1.14891379140671e-001;
    __statist_i_h_wts[10,164]=-2.21427937843540e-001;
    __statist_i_h_wts[10,165]=1.85002633686105e-001;
    __statist_i_h_wts[10,166]=-4.37301152637368e-002;
    __statist_i_h_wts[10,167]=4.04205912541026e-002;
    __statist_i_h_wts[10,168]=3.72366976588867e-003;
    __statist_i_h_wts[10,169]=-1.36570962940879e-001;
    __statist_i_h_wts[10,170]=-2.64861646653808e-002;
    __statist_i_h_wts[10,171]=-9.41541097433414e-002;
    __statist_i_h_wts[10,172]=-1.13975583837873e-001;
    __statist_i_h_wts[10,173]=-6.37126790601164e-002;
    __statist_i_h_wts[10,174]=-1.31759699152397e-002;
    __statist_i_h_wts[10,175]=-1.02214996848793e-001;
    __statist_i_h_wts[10,176]=5.34386613092610e-002;
    __statist_i_h_wts[10,177]=3.18914484618410e-002;
    __statist_i_h_wts[10,178]=-1.81610917227308e-002;
    __statist_i_h_wts[10,179]=8.66792384268522e-002;
    __statist_i_h_wts[10,180]=6.15384920161924e-002;
    __statist_i_h_wts[10,181]=-4.19200716227260e-002;
    __statist_i_h_wts[10,182]=3.45393649365596e-003;
    __statist_i_h_wts[10,183]=-2.01999194233519e-001;
    __statist_i_h_wts[10,184]=-8.41829438457657e-002;
    __statist_i_h_wts[10,185]=-1.98976335950406e-002;
    __statist_i_h_wts[10,186]=5.73460023501352e-004;
    __statist_i_h_wts[10,187]=-9.04653613548125e-003;
    __statist_i_h_wts[10,188]=-7.52325505958302e-003;
    __statist_i_h_wts[10,189]=-8.36748404105325e-002;
    __statist_i_h_wts[10,190]=-1.09241730650789e-001;
    __statist_i_h_wts[10,191]=3.28732906644813e-002;
    __statist_i_h_wts[10,192]=-4.07192080669784e-003;
    __statist_i_h_wts[10,193]=-2.30264824905768e-002;
    __statist_i_h_wts[10,194]=5.70452542698739e-002;
    __statist_i_h_wts[10,195]=1.06083354681280e-001;
    __statist_i_h_wts[10,196]=-8.86631902920918e-002;
    __statist_i_h_wts[10,197]=7.46094052350172e-003;
    __statist_i_h_wts[10,198]=-1.00639854838719e-002;
    __statist_i_h_wts[10,199]=-4.28818585110174e-002;
    __statist_i_h_wts[10,200]=8.41322491782329e-002;
    __statist_i_h_wts[10,201]=5.90581893473842e-002;
    __statist_i_h_wts[10,202]=3.84449896574354e-002;
    __statist_i_h_wts[10,203]=-1.15917670710237e-001;
    __statist_i_h_wts[10,204]=-5.44200978653806e-002;
    __statist_i_h_wts[10,205]=-1.05724332011124e-001;
    __statist_i_h_wts[10,206]=-2.13824918031992e-002;
    __statist_i_h_wts[10,207]=-1.22557917237620e-001;
    __statist_i_h_wts[10,208]=-1.35134592643135e-001;
    __statist_i_h_wts[10,209]=-1.95397197773495e-002;
    __statist_i_h_wts[10,210]=1.26961051566273e-001;
    __statist_i_h_wts[10,211]=3.20160228788109e-003;
    __statist_i_h_wts[10,212]=3.35951647418540e-002;
    __statist_i_h_wts[10,213]=-6.43381481888513e-002;
    __statist_i_h_wts[10,214]=-1.00115486601740e-001;
    __statist_i_h_wts[10,215]=-5.37007266676732e-002;
    __statist_i_h_wts[10,216]=-5.53016847244926e-002;
    __statist_i_h_wts[10,217]=-1.65607988443334e-001;
    __statist_i_h_wts[10,218]=-1.99695186939137e-001;
    __statist_i_h_wts[10,219]=2.19293549635901e-002;
    __statist_i_h_wts[10,220]=-4.44094895653506e-002;
    __statist_i_h_wts[10,221]=3.46597066571318e-002;
    __statist_i_h_wts[10,222]=2.23640018032985e-002;
    __statist_i_h_wts[10,223]=-8.95178746630392e-002;
    __statist_i_h_wts[10,224]=4.20610799539589e-002;
    __statist_i_h_wts[10,225]=3.31717165195449e-001;
    __statist_i_h_wts[10,226]=1.32476738161295e-001;
    __statist_i_h_wts[10,227]=1.79154450994953e-001;
    __statist_i_h_wts[10,228]=-7.83717209445212e-002;
    __statist_i_h_wts[10,229]=1.51471727164461e-001;
    __statist_i_h_wts[10,230]=9.94033910417800e-002;
    __statist_i_h_wts[10,231]=3.98731038816373e-002;
    __statist_i_h_wts[10,232]=2.61651438283828e-001;
    __statist_i_h_wts[10,233]=8.67373637526789e-002;
    __statist_i_h_wts[10,234]=1.80628592628397e-001;
    __statist_i_h_wts[10,235]=-4.01384980366053e-002;
    __statist_i_h_wts[10,236]=1.49487155807340e-001;
    __statist_i_h_wts[10,237]=-7.59282131234739e-002;
    __statist_i_h_wts[10,238]=-1.60931775479914e-001;
    __statist_i_h_wts[10,239]=2.58937898696578e-002;
    __statist_i_h_wts[10,240]=-2.82880875968126e-002;
    __statist_i_h_wts[10,241]=-2.85013918196748e-001;
    __statist_i_h_wts[10,242]=8.86983904068094e-002;
    __statist_i_h_wts[10,243]=-1.88822711050660e-001;
    __statist_i_h_wts[10,244]=1.83782855768219e-001;
    __statist_i_h_wts[10,245]=-1.71494633082489e-001;
    __statist_i_h_wts[10,246]=5.41508773127185e-002;
    __statist_i_h_wts[10,247]=-3.02516373374313e-002;
    __statist_i_h_wts[10,248]=-1.40434845463491e-001;

    __statist_i_h_wts[11,0]=-3.69610284119478e-001;
    __statist_i_h_wts[11,1]=-1.43011853446633e-001;
    __statist_i_h_wts[11,2]=1.87003974297007e-001;
    __statist_i_h_wts[11,3]=5.08726830120015e-002;
    __statist_i_h_wts[11,4]=-3.72763002713925e-002;
    __statist_i_h_wts[11,5]=-1.46962008689562e-001;
    __statist_i_h_wts[11,6]=-2.94274667686803e-001;
    __statist_i_h_wts[11,7]=2.23267404210268e-002;
    __statist_i_h_wts[11,8]=8.58453000877906e-002;
    __statist_i_h_wts[11,9]=-5.11372269699147e-001;
    __statist_i_h_wts[11,10]=-3.29171737059758e-001;
    __statist_i_h_wts[11,11]=5.74893956929868e-001;
    __statist_i_h_wts[11,12]=-1.27057744298782e-002;
    __statist_i_h_wts[11,13]=-3.65560360187155e-001;
    __statist_i_h_wts[11,14]=-1.98684757473219e-001;
    __statist_i_h_wts[11,15]=-5.53126268651469e-001;
    __statist_i_h_wts[11,16]=-2.44196736993380e-001;
    __statist_i_h_wts[11,17]=1.01644103271943e-001;
    __statist_i_h_wts[11,18]=-5.65671735419422e-002;
    __statist_i_h_wts[11,19]=1.71421661852236e-001;
    __statist_i_h_wts[11,20]=2.80275098583925e-001;
    __statist_i_h_wts[11,21]=-8.59859485850943e-002;
    __statist_i_h_wts[11,22]=1.11421418050713e-001;
    __statist_i_h_wts[11,23]=1.37676401514560e-001;
    __statist_i_h_wts[11,24]=-2.69175007033477e-001;
    __statist_i_h_wts[11,25]=-4.97177608548069e-002;
    __statist_i_h_wts[11,26]=4.37817344353713e-001;
    __statist_i_h_wts[11,27]=-6.23842046207715e-002;
    __statist_i_h_wts[11,28]=-1.80891603888050e-001;
    __statist_i_h_wts[11,29]=-1.53532033642639e-001;
    __statist_i_h_wts[11,30]=-3.47024121484009e-001;
    __statist_i_h_wts[11,31]=-6.91300968799658e-001;
    __statist_i_h_wts[11,32]=1.02969751262545e-001;
    __statist_i_h_wts[11,33]=-1.00529285048194e-002;
    __statist_i_h_wts[11,34]=2.66643699471310e-002;
    __statist_i_h_wts[11,35]=2.17868028348679e-001;
    __statist_i_h_wts[11,36]=-6.62719019271621e-002;
    __statist_i_h_wts[11,37]=-1.98149074939834e-001;
    __statist_i_h_wts[11,38]=2.51731340747597e-001;
    __statist_i_h_wts[11,39]=-5.68341452596650e-001;
    __statist_i_h_wts[11,40]=1.47765599312937e-001;
    __statist_i_h_wts[11,41]=4.69801130275959e-001;
    __statist_i_h_wts[11,42]=-1.13948801297911e-001;
    __statist_i_h_wts[11,43]=-1.94965074090567e-001;
    __statist_i_h_wts[11,44]=-2.24960635136666e-001;
    __statist_i_h_wts[11,45]=-5.58072898645119e-001;
    __statist_i_h_wts[11,46]=-6.91779160973522e-001;
    __statist_i_h_wts[11,47]=-3.57333483415194e-001;
    __statist_i_h_wts[11,48]=-4.55249655491854e-001;
    __statist_i_h_wts[11,49]=-2.60886741324738e-001;
    __statist_i_h_wts[11,50]=4.02397167708369e-002;
    __statist_i_h_wts[11,51]=-3.81968182920423e-001;
    __statist_i_h_wts[11,52]=-4.43923462453023e-001;
    __statist_i_h_wts[11,53]=1.49159484181570e-001;
    __statist_i_h_wts[11,54]=-4.83889310008688e-001;
    __statist_i_h_wts[11,55]=-1.98067168824234e-001;
    __statist_i_h_wts[11,56]=-4.97372281708549e-002;
    __statist_i_h_wts[11,57]=-5.32369110456343e-001;
    __statist_i_h_wts[11,58]=-1.32249107175938e-001;
    __statist_i_h_wts[11,59]=-4.90604395727756e-001;
    __statist_i_h_wts[11,60]=-4.46536574198095e-001;
    __statist_i_h_wts[11,61]=-7.33549930946900e-001;
    __statist_i_h_wts[11,62]=-3.08281924728986e-002;
    __statist_i_h_wts[11,63]=-2.19334843103417e-001;
    __statist_i_h_wts[11,64]=-1.04856037405581e-001;
    __statist_i_h_wts[11,65]=2.68242725492437e-001;
    __statist_i_h_wts[11,66]=-1.64972856110039e-001;
    __statist_i_h_wts[11,67]=-2.71337018545598e-001;
    __statist_i_h_wts[11,68]=-3.02852465271820e-002;
    __statist_i_h_wts[11,69]=-6.15689389971971e-001;
    __statist_i_h_wts[11,70]=-5.03812982719032e-001;
    __statist_i_h_wts[11,71]=2.15014555387133e-001;
    __statist_i_h_wts[11,72]=-3.54435464119824e-001;
    __statist_i_h_wts[11,73]=2.37188759052912e-001;
    __statist_i_h_wts[11,74]=1.93537231642873e-001;
    __statist_i_h_wts[11,75]=7.06219990615830e-002;
    __statist_i_h_wts[11,76]=1.33167874594700e-001;
    __statist_i_h_wts[11,77]=4.04516277230382e-001;
    __statist_i_h_wts[11,78]=2.93882357028515e-001;
    __statist_i_h_wts[11,79]=2.29867315025351e-001;
    __statist_i_h_wts[11,80]=2.60981492391005e-001;
    __statist_i_h_wts[11,81]=1.00641933254974e-002;
    __statist_i_h_wts[11,82]=-2.74439781945629e-002;
    __statist_i_h_wts[11,83]=1.74885270470959e-001;
    __statist_i_h_wts[11,84]=-1.09443002041293e-001;
    __statist_i_h_wts[11,85]=3.34525870773728e-002;
    __statist_i_h_wts[11,86]=2.20098307692907e-001;
    __statist_i_h_wts[11,87]=-1.84470308240589e-001;
    __statist_i_h_wts[11,88]=3.15325146637682e-001;
    __statist_i_h_wts[11,89]=3.78053339532895e-001;
    __statist_i_h_wts[11,90]=-4.32071681632105e-002;
    __statist_i_h_wts[11,91]=-1.64209620349069e-001;
    __statist_i_h_wts[11,92]=-2.74253584196964e-001;
    __statist_i_h_wts[11,93]=-2.38001747124854e-001;
    __statist_i_h_wts[11,94]=-2.46461702536438e-001;
    __statist_i_h_wts[11,95]=1.69820761229726e-001;
    __statist_i_h_wts[11,96]=-3.84863575800035e-001;
    __statist_i_h_wts[11,97]=-2.02132571895099e-001;
    __statist_i_h_wts[11,98]=4.35408267262456e-001;
    __statist_i_h_wts[11,99]=-2.11174917650061e-001;
    __statist_i_h_wts[11,100]=-1.99546882296218e-001;
    __statist_i_h_wts[11,101]=2.24978696262569e-001;
    __statist_i_h_wts[11,102]=-3.09679252358375e-001;
    __statist_i_h_wts[11,103]=2.80090885614681e-001;
    __statist_i_h_wts[11,104]=2.18617445379514e-001;
    __statist_i_h_wts[11,105]=-6.70469005637651e-001;
    __statist_i_h_wts[11,106]=-3.48317573274624e-001;
    __statist_i_h_wts[11,107]=-3.91827794091255e-001;
    __statist_i_h_wts[11,108]=-3.65061455669783e-001;
    __statist_i_h_wts[11,109]=-6.79858865621780e-002;
    __statist_i_h_wts[11,110]=3.23708353616179e-001;
    __statist_i_h_wts[11,111]=-3.68472139520017e-001;
    __statist_i_h_wts[11,112]=-7.64393531804735e-002;
    __statist_i_h_wts[11,113]=-9.73433842778230e-003;
    __statist_i_h_wts[11,114]=-9.19844071660049e-003;
    __statist_i_h_wts[11,115]=-2.00977617321901e-001;
    __statist_i_h_wts[11,116]=-3.37251602503369e-001;
    __statist_i_h_wts[11,117]=-5.48856989553279e-001;
    __statist_i_h_wts[11,118]=9.90637657229613e-003;
    __statist_i_h_wts[11,119]=-2.21848442681857e-001;
    __statist_i_h_wts[11,120]=5.56754114730411e-002;
    __statist_i_h_wts[11,121]=4.31161798207149e-001;
    __statist_i_h_wts[11,122]=1.64034350132890e-001;
    __statist_i_h_wts[11,123]=-2.10115698417053e-001;
    __statist_i_h_wts[11,124]=-4.75644442382698e-002;
    __statist_i_h_wts[11,125]=2.82454879956445e-001;
    __statist_i_h_wts[11,126]=-6.65352234148762e-002;
    __statist_i_h_wts[11,127]=-4.96230905343010e-001;
    __statist_i_h_wts[11,128]=-2.01274335901544e-001;
    __statist_i_h_wts[11,129]=6.74199688112319e-002;
    __statist_i_h_wts[11,130]=-4.09299812668394e-001;
    __statist_i_h_wts[11,131]=-3.07205398688575e-001;
    __statist_i_h_wts[11,132]=-4.21491680717993e-001;
    __statist_i_h_wts[11,133]=9.74504656900204e-002;
    __statist_i_h_wts[11,134]=1.40649282952982e-001;
    __statist_i_h_wts[11,135]=-9.77935825379766e-002;
    __statist_i_h_wts[11,136]=3.13013107601696e-001;
    __statist_i_h_wts[11,137]=-4.39391069438940e-002;
    __statist_i_h_wts[11,138]=-2.45508756337336e-001;
    __statist_i_h_wts[11,139]=-3.16712617219474e-001;
    __statist_i_h_wts[11,140]=-3.83213653031822e-001;
    __statist_i_h_wts[11,141]=5.71745123270044e-002;
    __statist_i_h_wts[11,142]=-2.42711529173244e-001;
    __statist_i_h_wts[11,143]=2.89326312312595e-001;
    __statist_i_h_wts[11,144]=3.63130240514687e-001;
    __statist_i_h_wts[11,145]=-9.17673850763174e-002;
    __statist_i_h_wts[11,146]=-3.34267421008691e-002;
    __statist_i_h_wts[11,147]=1.22467939980952e-001;
    __statist_i_h_wts[11,148]=3.17724752342671e-001;
    __statist_i_h_wts[11,149]=6.04574266816546e-002;
    __statist_i_h_wts[11,150]=-4.10178779524443e-001;
    __statist_i_h_wts[11,151]=7.32585105832641e-002;
    __statist_i_h_wts[11,152]=-2.22040421883973e-001;
    __statist_i_h_wts[11,153]=1.88765459037683e-001;
    __statist_i_h_wts[11,154]=-4.39906501363576e-002;
    __statist_i_h_wts[11,155]=-2.24004931636092e-001;
    __statist_i_h_wts[11,156]=-2.54598994510166e-002;
    __statist_i_h_wts[11,157]=1.57803106443878e-001;
    __statist_i_h_wts[11,158]=-3.49968280183210e-001;
    __statist_i_h_wts[11,159]=-1.46002744801060e-001;
    __statist_i_h_wts[11,160]=7.70990040948968e-002;
    __statist_i_h_wts[11,161]=2.15365818665355e-001;
    __statist_i_h_wts[11,162]=-3.52374120366321e-001;
    __statist_i_h_wts[11,163]=2.68658837682100e-001;
    __statist_i_h_wts[11,164]=1.43380044008278e-001;
    __statist_i_h_wts[11,165]=-4.63326428733656e-001;
    __statist_i_h_wts[11,166]=-2.91925866987055e-001;
    __statist_i_h_wts[11,167]=-6.76791849604332e-001;
    __statist_i_h_wts[11,168]=-4.04555250380549e-001;
    __statist_i_h_wts[11,169]=-1.06701490210044e-001;
    __statist_i_h_wts[11,170]=7.45632089812842e-002;
    __statist_i_h_wts[11,171]=3.40671560230542e-001;
    __statist_i_h_wts[11,172]=-2.68171450813638e-001;
    __statist_i_h_wts[11,173]=-2.69962258547515e-001;
    __statist_i_h_wts[11,174]=-7.27076145973576e-002;
    __statist_i_h_wts[11,175]=2.26627725759776e-001;
    __statist_i_h_wts[11,176]=3.92942477030536e-002;
    __statist_i_h_wts[11,177]=-9.73699729930885e-002;
    __statist_i_h_wts[11,178]=-1.05982606698083e-002;
    __statist_i_h_wts[11,179]=-2.88556944826867e-001;
    __statist_i_h_wts[11,180]=-2.67972223958719e-002;
    __statist_i_h_wts[11,181]=-9.74302975274615e-002;
    __statist_i_h_wts[11,182]=-8.73953333191002e-002;
    __statist_i_h_wts[11,183]=4.44272142668899e-001;
    __statist_i_h_wts[11,184]=9.77064384138960e-002;
    __statist_i_h_wts[11,185]=-2.74628404927230e-002;
    __statist_i_h_wts[11,186]=4.45091826225499e-001;
    __statist_i_h_wts[11,187]=1.79824196608610e-001;
    __statist_i_h_wts[11,188]=-3.04107431977680e-001;
    __statist_i_h_wts[11,189]=-1.88898436667683e-001;
    __statist_i_h_wts[11,190]=1.26606993823835e-001;
    __statist_i_h_wts[11,191]=5.39055388932712e-002;
    __statist_i_h_wts[11,192]=-3.46030511093981e-001;
    __statist_i_h_wts[11,193]=-2.50081922079617e-001;
    __statist_i_h_wts[11,194]=-4.70170601416675e-001;
    __statist_i_h_wts[11,195]=1.39521300486794e-001;
    __statist_i_h_wts[11,196]=3.01541896727667e-001;
    __statist_i_h_wts[11,197]=4.10683044661423e-001;
    __statist_i_h_wts[11,198]=4.01763867653577e-001;
    __statist_i_h_wts[11,199]=2.17894683192636e-001;
    __statist_i_h_wts[11,200]=1.77340982978730e-001;
    __statist_i_h_wts[11,201]=6.47180066049901e-001;
    __statist_i_h_wts[11,202]=5.60308548571550e-001;
    __statist_i_h_wts[11,203]=3.75849317314147e-002;
    __statist_i_h_wts[11,204]=-7.02670247021155e-002;
    __statist_i_h_wts[11,205]=-1.14095373234800e-001;
    __statist_i_h_wts[11,206]=-2.34223035985388e-001;
    __statist_i_h_wts[11,207]=-9.94717862539001e-002;
    __statist_i_h_wts[11,208]=1.48963917851019e-002;
    __statist_i_h_wts[11,209]=-2.21032902125985e-001;
    __statist_i_h_wts[11,210]=3.17518990347870e-001;
    __statist_i_h_wts[11,211]=3.87358520517279e-001;
    __statist_i_h_wts[11,212]=2.15868884244990e-001;
    __statist_i_h_wts[11,213]=3.16444196721350e-001;
    __statist_i_h_wts[11,214]=-2.81055194233405e-003;
    __statist_i_h_wts[11,215]=-3.27919983633918e-002;
    __statist_i_h_wts[11,216]=5.32394210873172e-002;
    __statist_i_h_wts[11,217]=4.07363111332542e-001;
    __statist_i_h_wts[11,218]=9.66079967518405e-002;
    __statist_i_h_wts[11,219]=-2.84047056830694e-001;
    __statist_i_h_wts[11,220]=-3.02952497247499e-001;
    __statist_i_h_wts[11,221]=-2.57077402816100e-001;
    __statist_i_h_wts[11,222]=-3.02148332459917e-001;
    __statist_i_h_wts[11,223]=1.04765462436417e-001;
    __statist_i_h_wts[11,224]=-2.06388283443155e-002;
    __statist_i_h_wts[11,225]=7.50808606356185e-002;
    __statist_i_h_wts[11,226]=-8.98496905406042e-001;
    __statist_i_h_wts[11,227]=4.42050882046637e-001;
    __statist_i_h_wts[11,228]=-7.81188616328541e-001;
    __statist_i_h_wts[11,229]=2.56902265166431e-001;
    __statist_i_h_wts[11,230]=9.61096864960158e-001;
    __statist_i_h_wts[11,231]=1.10567188469196e-001;
    __statist_i_h_wts[11,232]=6.97325340208266e-001;
    __statist_i_h_wts[11,233]=1.04527353245191e-001;
    __statist_i_h_wts[11,234]=1.62934589389965e+000;
    __statist_i_h_wts[11,235]=-4.64532841556742e-001;
    __statist_i_h_wts[11,236]=-1.56300178915849e+000;
    __statist_i_h_wts[11,237]=-2.37758371135555e+000;
    __statist_i_h_wts[11,238]=-4.85701369315407e-001;
    __statist_i_h_wts[11,239]=1.22082924300069e+000;
    __statist_i_h_wts[11,240]=-6.53760562113324e-001;
    __statist_i_h_wts[11,241]=4.47179457546804e+000;
    __statist_i_h_wts[11,242]=6.71250538303379e-001;
    __statist_i_h_wts[11,243]=1.70497047146065e+000;
    __statist_i_h_wts[11,244]=-1.73803277826472e-001;
    __statist_i_h_wts[11,245]=-2.40317159420465e+000;
    __statist_i_h_wts[11,246]=3.38399677767060e-001;
    __statist_i_h_wts[11,247]=-1.34467206010607e+000;
    __statist_i_h_wts[11,248]=-1.04682638651352e-001;

    __statist_i_h_wts[12,0]=4.15793550033216e-001;
    __statist_i_h_wts[12,1]=4.07516176673627e-001;
    __statist_i_h_wts[12,2]=2.49602934409682e-001;
    __statist_i_h_wts[12,3]=2.85769347764317e-001;
    __statist_i_h_wts[12,4]=2.15799133274605e-001;
    __statist_i_h_wts[12,5]=2.07132256497970e-001;
    __statist_i_h_wts[12,6]=2.89591785907874e-001;
    __statist_i_h_wts[12,7]=2.90605162739139e-001;
    __statist_i_h_wts[12,8]=2.90481822145557e-001;
    __statist_i_h_wts[12,9]=5.19471308166280e-001;
    __statist_i_h_wts[12,10]=3.74573772962610e-001;
    __statist_i_h_wts[12,11]=8.52735861143042e-002;
    __statist_i_h_wts[12,12]=1.08817145664476e-001;
    __statist_i_h_wts[12,13]=3.25621829322431e-001;
    __statist_i_h_wts[12,14]=6.30649446805196e-002;
    __statist_i_h_wts[12,15]=3.86520453273706e-001;
    __statist_i_h_wts[12,16]=3.17240572409758e-001;
    __statist_i_h_wts[12,17]=9.28695948277972e-002;
    __statist_i_h_wts[12,18]=1.41182586453160e-001;
    __statist_i_h_wts[12,19]=1.30846086466740e-002;
    __statist_i_h_wts[12,20]=-7.11849318561011e-003;
    __statist_i_h_wts[12,21]=1.78855899486973e-001;
    __statist_i_h_wts[12,22]=3.27519014585448e-001;
    __statist_i_h_wts[12,23]=4.22080818132461e-001;
    __statist_i_h_wts[12,24]=5.46546167804929e-001;
    __statist_i_h_wts[12,25]=2.96858843364602e-001;
    __statist_i_h_wts[12,26]=2.28653854782978e-001;
    __statist_i_h_wts[12,27]=2.12033207264837e-001;
    __statist_i_h_wts[12,28]=3.34225604753938e-001;
    __statist_i_h_wts[12,29]=7.93372662716137e-002;
    __statist_i_h_wts[12,30]=2.88430473159956e-001;
    __statist_i_h_wts[12,31]=4.27296005770753e-001;
    __statist_i_h_wts[12,32]=1.75745754212796e-001;
    __statist_i_h_wts[12,33]=2.49098166400062e-001;
    __statist_i_h_wts[12,34]=1.27859129277323e-001;
    __statist_i_h_wts[12,35]=-7.75667670076792e-002;
    __statist_i_h_wts[12,36]=1.61188874505337e-001;
    __statist_i_h_wts[12,37]=1.68781934821410e-001;
    __statist_i_h_wts[12,38]=1.50358254138205e-001;
    __statist_i_h_wts[12,39]=4.26705563498144e-001;
    __statist_i_h_wts[12,40]=1.05159846890467e-001;
    __statist_i_h_wts[12,41]=4.14681901531135e-002;
    __statist_i_h_wts[12,42]=1.21696650652809e-001;
    __statist_i_h_wts[12,43]=3.76780163207917e-001;
    __statist_i_h_wts[12,44]=5.17546940106058e-002;
    __statist_i_h_wts[12,45]=2.02764037950721e-001;
    __statist_i_h_wts[12,46]=5.29987398031736e-001;
    __statist_i_h_wts[12,47]=3.75766266040962e-001;
    __statist_i_h_wts[12,48]=4.70361755624045e-001;
    __statist_i_h_wts[12,49]=2.83951765645946e-001;
    __statist_i_h_wts[12,50]=1.51952407698049e-001;
    __statist_i_h_wts[12,51]=2.04680666943882e-001;
    __statist_i_h_wts[12,52]=2.72208425296327e-001;
    __statist_i_h_wts[12,53]=3.47751876805752e-001;
    __statist_i_h_wts[12,54]=5.19782817259291e-001;
    __statist_i_h_wts[12,55]=2.63377491371452e-001;
    __statist_i_h_wts[12,56]=1.34453795115852e-001;
    __statist_i_h_wts[12,57]=1.30871639034529e-001;
    __statist_i_h_wts[12,58]=2.45461354384628e-001;
    __statist_i_h_wts[12,59]=1.16423574543322e-001;
    __statist_i_h_wts[12,60]=2.31608923868980e-002;
    __statist_i_h_wts[12,61]=2.11755910664561e-001;
    __statist_i_h_wts[12,62]=-9.53529900763351e-003;
    __statist_i_h_wts[12,63]=9.33219362721644e-002;
    __statist_i_h_wts[12,64]=1.29639404246250e-001;
    __statist_i_h_wts[12,65]=-4.06851632296915e-002;
    __statist_i_h_wts[12,66]=8.80896418486873e-002;
    __statist_i_h_wts[12,67]=2.33290997064982e-001;
    __statist_i_h_wts[12,68]=1.99823079793124e-001;
    __statist_i_h_wts[12,69]=4.44770468078434e-001;
    __statist_i_h_wts[12,70]=3.64134330899286e-001;
    __statist_i_h_wts[12,71]=4.00575901572957e-002;
    __statist_i_h_wts[12,72]=1.74355159328511e-001;
    __statist_i_h_wts[12,73]=1.23996891280410e-001;
    __statist_i_h_wts[12,74]=-6.81240828171222e-002;
    __statist_i_h_wts[12,75]=6.82409671946828e-002;
    __statist_i_h_wts[12,76]=1.01382845094997e-001;
    __statist_i_h_wts[12,77]=-1.98308377207033e-002;
    __statist_i_h_wts[12,78]=3.65825266795346e-002;
    __statist_i_h_wts[12,79]=-3.23640564332523e-002;
    __statist_i_h_wts[12,80]=1.67821730896817e-001;
    __statist_i_h_wts[12,81]=1.25592930707902e-001;
    __statist_i_h_wts[12,82]=2.32632436162101e-001;
    __statist_i_h_wts[12,83]=2.96227001247736e-002;
    __statist_i_h_wts[12,84]=2.73313164253977e-001;
    __statist_i_h_wts[12,85]=1.94625512868385e-001;
    __statist_i_h_wts[12,86]=1.90564011480887e-002;
    __statist_i_h_wts[12,87]=2.99627231544583e-001;
    __statist_i_h_wts[12,88]=2.41004192931435e-001;
    __statist_i_h_wts[12,89]=-9.17478027412054e-002;
    __statist_i_h_wts[12,90]=-7.05862064878605e-002;
    __statist_i_h_wts[12,91]=8.78943192607081e-002;
    __statist_i_h_wts[12,92]=2.79123972852480e-001;
    __statist_i_h_wts[12,93]=1.59560362938040e-001;
    __statist_i_h_wts[12,94]=1.37086045029363e-001;
    __statist_i_h_wts[12,95]=1.33810410133345e-001;
    __statist_i_h_wts[12,96]=7.38844781124834e-002;
    __statist_i_h_wts[12,97]=4.12562758831647e-002;
    __statist_i_h_wts[12,98]=-1.70102084736328e-001;
    __statist_i_h_wts[12,99]=1.01841430854831e-001;
    __statist_i_h_wts[12,100]=5.85886512190942e-003;
    __statist_i_h_wts[12,101]=-2.04257673101501e-001;
    __statist_i_h_wts[12,102]=6.67035363460375e-002;
    __statist_i_h_wts[12,103]=-2.42183846680421e-003;
    __statist_i_h_wts[12,104]=-1.82001682609007e-001;
    __statist_i_h_wts[12,105]=2.37470180504093e-001;
    __statist_i_h_wts[12,106]=2.16975907785766e-001;
    __statist_i_h_wts[12,107]=3.32448888573385e-001;
    __statist_i_h_wts[12,108]=2.36181006810700e-001;
    __statist_i_h_wts[12,109]=1.01114030703510e-002;
    __statist_i_h_wts[12,110]=6.91246006195120e-002;
    __statist_i_h_wts[12,111]=1.52435799331932e-002;
    __statist_i_h_wts[12,112]=-5.14789229257105e-002;
    __statist_i_h_wts[12,113]=-4.21084404348075e-002;
    __statist_i_h_wts[12,114]=-1.32230052175660e-001;
    __statist_i_h_wts[12,115]=7.31583188584357e-002;
    __statist_i_h_wts[12,116]=-6.29363042182575e-002;
    __statist_i_h_wts[12,117]=3.43915910338361e-002;
    __statist_i_h_wts[12,118]=-7.73214795361897e-002;
    __statist_i_h_wts[12,119]=-1.12745679851996e-001;
    __statist_i_h_wts[12,120]=-1.12207773772898e-001;
    __statist_i_h_wts[12,121]=-1.56759238671264e-001;
    __statist_i_h_wts[12,122]=2.46624333730305e-002;
    __statist_i_h_wts[12,123]=9.24028845178995e-002;
    __statist_i_h_wts[12,124]=9.53305946655417e-003;
    __statist_i_h_wts[12,125]=-1.31979828469467e-001;
    __statist_i_h_wts[12,126]=-1.26687541116733e-001;
    __statist_i_h_wts[12,127]=-7.36595358867795e-002;
    __statist_i_h_wts[12,128]=1.27296108746888e-001;
    __statist_i_h_wts[12,129]=-4.25064912175927e-002;
    __statist_i_h_wts[12,130]=-5.98254175542431e-002;
    __statist_i_h_wts[12,131]=-1.94143327425007e-001;
    __statist_i_h_wts[12,132]=-1.04984220682655e-001;
    __statist_i_h_wts[12,133]=-1.60435165807636e-001;
    __statist_i_h_wts[12,134]=-2.86701453582977e-001;
    __statist_i_h_wts[12,135]=5.22654169113120e-002;
    __statist_i_h_wts[12,136]=-1.29580869999493e-001;
    __statist_i_h_wts[12,137]=7.58294849972633e-002;
    __statist_i_h_wts[12,138]=4.36597170265977e-002;
    __statist_i_h_wts[12,139]=8.04390686729183e-002;
    __statist_i_h_wts[12,140]=-8.65741763297701e-002;
    __statist_i_h_wts[12,141]=-1.64009247813167e-001;
    __statist_i_h_wts[12,142]=6.10322213696430e-002;
    __statist_i_h_wts[12,143]=6.70362867482355e-002;
    __statist_i_h_wts[12,144]=-1.17598563961611e-002;
    __statist_i_h_wts[12,145]=1.20905889977759e-001;
    __statist_i_h_wts[12,146]=-1.22797122294690e-001;
    __statist_i_h_wts[12,147]=-1.68059798855512e-002;
    __statist_i_h_wts[12,148]=9.68640398260905e-002;
    __statist_i_h_wts[12,149]=6.81205519705069e-002;
    __statist_i_h_wts[12,150]=3.61229533860851e-001;
    __statist_i_h_wts[12,151]=2.33890494583749e-001;
    __statist_i_h_wts[12,152]=3.55739217815483e-001;
    __statist_i_h_wts[12,153]=5.32247145555031e-002;
    __statist_i_h_wts[12,154]=1.18237271758806e-001;
    __statist_i_h_wts[12,155]=4.31192706396198e-002;
    __statist_i_h_wts[12,156]=9.04258976557996e-002;
    __statist_i_h_wts[12,157]=6.69479963206260e-002;
    __statist_i_h_wts[12,158]=2.88159555585137e-001;
    __statist_i_h_wts[12,159]=1.63888592829022e-001;
    __statist_i_h_wts[12,160]=7.86977153445887e-002;
    __statist_i_h_wts[12,161]=-3.63460834330293e-001;
    __statist_i_h_wts[12,162]=-5.11568963780441e-002;
    __statist_i_h_wts[12,163]=-1.44400460187425e-001;
    __statist_i_h_wts[12,164]=-1.94991831578599e-001;
    __statist_i_h_wts[12,165]=3.08246342063156e-001;
    __statist_i_h_wts[12,166]=2.79644560690227e-001;
    __statist_i_h_wts[12,167]=3.70659286190381e-001;
    __statist_i_h_wts[12,168]=2.07998373701018e-001;
    __statist_i_h_wts[12,169]=1.37371774328568e-001;
    __statist_i_h_wts[12,170]=5.75597898586256e-002;
    __statist_i_h_wts[12,171]=-1.95706259794993e-002;
    __statist_i_h_wts[12,172]=-2.91762151864992e-002;
    __statist_i_h_wts[12,173]=6.10503633271944e-002;
    __statist_i_h_wts[12,174]=2.74947517457890e-002;
    __statist_i_h_wts[12,175]=-1.93504610643199e-002;
    __statist_i_h_wts[12,176]=6.72467794531495e-002;
    __statist_i_h_wts[12,177]=2.70685834127201e-001;
    __statist_i_h_wts[12,178]=1.42112827439874e-001;
    __statist_i_h_wts[12,179]=2.16448450580090e-001;
    __statist_i_h_wts[12,180]=9.59665130250215e-002;
    __statist_i_h_wts[12,181]=9.35942997602799e-002;
    __statist_i_h_wts[12,182]=1.77322716095748e-001;
    __statist_i_h_wts[12,183]=-7.61287295167867e-002;
    __statist_i_h_wts[12,184]=2.73481256421349e-002;
    __statist_i_h_wts[12,185]=3.10154863011252e-002;
    __statist_i_h_wts[12,186]=-8.05019984904056e-002;
    __statist_i_h_wts[12,187]=-1.83091667909390e-001;
    __statist_i_h_wts[12,188]=1.47512906621374e-002;
    __statist_i_h_wts[12,189]=-2.30775734011753e-002;
    __statist_i_h_wts[12,190]=-4.33148206609114e-002;
    __statist_i_h_wts[12,191]=-6.35865290650597e-002;
    __statist_i_h_wts[12,192]=9.91551435747500e-002;
    __statist_i_h_wts[12,193]=-2.22268673670952e-004;
    __statist_i_h_wts[12,194]=-3.65950311625949e-003;
    __statist_i_h_wts[12,195]=6.50947577566205e-002;
    __statist_i_h_wts[12,196]=2.62625448557694e-002;
    __statist_i_h_wts[12,197]=8.49650849283400e-002;
    __statist_i_h_wts[12,198]=4.63077248780424e-002;
    __statist_i_h_wts[12,199]=9.29908244332287e-002;
    __statist_i_h_wts[12,200]=1.62241411327857e-001;
    __statist_i_h_wts[12,201]=3.13190068070502e-002;
    __statist_i_h_wts[12,202]=-1.13679757048289e-001;
    __statist_i_h_wts[12,203]=-1.83873048987633e-002;
    __statist_i_h_wts[12,204]=-1.24576119674945e-002;
    __statist_i_h_wts[12,205]=5.06821541054696e-002;
    __statist_i_h_wts[12,206]=3.39149161200726e-002;
    __statist_i_h_wts[12,207]=5.22932463457863e-002;
    __statist_i_h_wts[12,208]=-1.25447758142164e-001;
    __statist_i_h_wts[12,209]=-4.56299369250287e-002;
    __statist_i_h_wts[12,210]=3.25453858670039e-002;
    __statist_i_h_wts[12,211]=2.98515135178097e-003;
    __statist_i_h_wts[12,212]=4.19427639114736e-002;
    __statist_i_h_wts[12,213]=-4.86807712862400e-002;
    __statist_i_h_wts[12,214]=-1.98873308328259e-003;
    __statist_i_h_wts[12,215]=-4.14233659079649e-002;
    __statist_i_h_wts[12,216]=-3.62231876526772e-002;
    __statist_i_h_wts[12,217]=-2.47770679037128e-001;
    __statist_i_h_wts[12,218]=-9.57969616224311e-002;
    __statist_i_h_wts[12,219]=5.23798524520906e-002;
    __statist_i_h_wts[12,220]=8.75962225561879e-002;
    __statist_i_h_wts[12,221]=4.44118410696314e-002;
    __statist_i_h_wts[12,222]=1.56259653067096e-001;
    __statist_i_h_wts[12,223]=-1.37133971298150e-001;
    __statist_i_h_wts[12,224]=-8.90199515952763e-002;
    __statist_i_h_wts[12,225]=-7.71883677241677e-002;
    __statist_i_h_wts[12,226]=9.19618814255951e-001;
    __statist_i_h_wts[12,227]=-2.42979408248174e-001;
    __statist_i_h_wts[12,228]=8.18684836519063e-001;
    __statist_i_h_wts[12,229]=-1.59417825936192e-001;
    __statist_i_h_wts[12,230]=-1.11442586390268e+000;
    __statist_i_h_wts[12,231]=1.54450779112592e-001;
    __statist_i_h_wts[12,232]=-8.86442100133116e-001;
    __statist_i_h_wts[12,233]=-2.66235870090520e-001;
    __statist_i_h_wts[12,234]=-1.44808933682173e+000;
    __statist_i_h_wts[12,235]=5.61221654470079e-001;
    __statist_i_h_wts[12,236]=1.72370200170133e+000;
    __statist_i_h_wts[12,237]=2.12841090993122e+000;
    __statist_i_h_wts[12,238]=8.34109679180976e-001;
    __statist_i_h_wts[12,239]=-9.36719914308856e-001;
    __statist_i_h_wts[12,240]=5.56791270606104e-001;
    __statist_i_h_wts[12,241]=-4.52669619642427e+000;
    __statist_i_h_wts[12,242]=-1.80959419782414e-001;
    __statist_i_h_wts[12,243]=-9.40422606033621e-001;
    __statist_i_h_wts[12,244]=6.26451775092596e-002;
    __statist_i_h_wts[12,245]=2.50955444772850e+000;
    __statist_i_h_wts[12,246]=-1.22202709494082e+000;
    __statist_i_h_wts[12,247]=1.11638114655058e+000;
    __statist_i_h_wts[12,248]=-2.82473612241712e-001;

    __statist_i_h_wts[13,0]=-3.95190274496088e-002;
    __statist_i_h_wts[13,1]=3.58890218515519e-001;
    __statist_i_h_wts[13,2]=-3.21346491232680e-002;
    __statist_i_h_wts[13,3]=-1.28318568122849e-001;
    __statist_i_h_wts[13,4]=-5.64482222497910e-001;
    __statist_i_h_wts[13,5]=-1.53351741073657e-001;
    __statist_i_h_wts[13,6]=1.10547883654821e-001;
    __statist_i_h_wts[13,7]=-4.72331679763252e-001;
    __statist_i_h_wts[13,8]=-4.04744024116132e-001;
    __statist_i_h_wts[13,9]=4.79010292183563e-002;
    __statist_i_h_wts[13,10]=4.70860950668399e-001;
    __statist_i_h_wts[13,11]=2.16655058032478e-001;
    __statist_i_h_wts[13,12]=1.03514578085801e-001;
    __statist_i_h_wts[13,13]=-4.67019569163451e-002;
    __statist_i_h_wts[13,14]=-4.74568612320668e-001;
    __statist_i_h_wts[13,15]=-2.98296784762521e-002;
    __statist_i_h_wts[13,16]=2.56615806933780e-001;
    __statist_i_h_wts[13,17]=-2.03354406556939e-001;
    __statist_i_h_wts[13,18]=-2.90211960345652e-001;
    __statist_i_h_wts[13,19]=-9.98925233757354e-001;
    __statist_i_h_wts[13,20]=-7.28022419271049e-001;
    __statist_i_h_wts[13,21]=-6.87625937039082e-001;
    __statist_i_h_wts[13,22]=-2.82335142164656e-001;
    __statist_i_h_wts[13,23]=3.85450190028123e-002;
    __statist_i_h_wts[13,24]=1.61203970072394e-001;
    __statist_i_h_wts[13,25]=3.32958441995657e-001;
    __statist_i_h_wts[13,26]=3.36236538524492e-001;
    __statist_i_h_wts[13,27]=2.51118424799673e-001;
    __statist_i_h_wts[13,28]=1.02441444201647e-001;
    __statist_i_h_wts[13,29]=-4.44339329035599e-001;
    __statist_i_h_wts[13,30]=3.59615605408788e-001;
    __statist_i_h_wts[13,31]=7.05131436511235e-001;
    __statist_i_h_wts[13,32]=-2.94601770843624e-002;
    __statist_i_h_wts[13,33]=2.01707339296777e-001;
    __statist_i_h_wts[13,34]=-9.72580290746851e-001;
    __statist_i_h_wts[13,35]=-5.78839497380234e-001;
    __statist_i_h_wts[13,36]=-8.02623569203339e-001;
    __statist_i_h_wts[13,37]=-2.37715179526363e-001;
    __statist_i_h_wts[13,38]=-7.26268243620821e-001;
    __statist_i_h_wts[13,39]=2.62522759386639e-001;
    __statist_i_h_wts[13,40]=-2.74841786824362e-001;
    __statist_i_h_wts[13,41]=2.38441120713858e-001;
    __statist_i_h_wts[13,42]=-1.34714732173993e-001;
    __statist_i_h_wts[13,43]=3.60706302028915e-001;
    __statist_i_h_wts[13,44]=-4.11164734379277e-001;
    __statist_i_h_wts[13,45]=2.00646710695898e-001;
    __statist_i_h_wts[13,46]=1.03560443449007e+000;
    __statist_i_h_wts[13,47]=8.16939578611172e-001;
    __statist_i_h_wts[13,48]=4.83624265572253e-001;
    __statist_i_h_wts[13,49]=-2.63389782790843e-001;
    __statist_i_h_wts[13,50]=-2.42519594792364e-001;
    __statist_i_h_wts[13,51]=3.49490044719711e-001;
    __statist_i_h_wts[13,52]=-1.22532109072946e-001;
    __statist_i_h_wts[13,53]=3.39064080055382e-002;
    __statist_i_h_wts[13,54]=-3.98920723846274e-001;
    __statist_i_h_wts[13,55]=-4.22007951097726e-001;
    __statist_i_h_wts[13,56]=1.50153240442032e-001;
    __statist_i_h_wts[13,57]=-2.56782438325222e-001;
    __statist_i_h_wts[13,58]=-5.27591804854350e-001;
    __statist_i_h_wts[13,59]=2.20712278458273e-001;
    __statist_i_h_wts[13,60]=7.30152111370935e-002;
    __statist_i_h_wts[13,61]=6.78868978553150e-001;
    __statist_i_h_wts[13,62]=-3.41332483544877e-001;
    __statist_i_h_wts[13,63]=-2.47328915992646e-001;
    __statist_i_h_wts[13,64]=-2.40071304858044e-001;
    __statist_i_h_wts[13,65]=-9.04574685848457e-002;
    __statist_i_h_wts[13,66]=2.22123655125694e-002;
    __statist_i_h_wts[13,67]=-8.27608269814909e-002;
    __statist_i_h_wts[13,68]=-6.84736592660765e-003;
    __statist_i_h_wts[13,69]=-4.16809014432938e-001;
    __statist_i_h_wts[13,70]=-5.66446799610489e-001;
    __statist_i_h_wts[13,71]=3.13038842597642e-001;
    __statist_i_h_wts[13,72]=5.28492532681685e-001;
    __statist_i_h_wts[13,73]=-4.01676168509460e-001;
    __statist_i_h_wts[13,74]=-5.08225873440298e-001;
    __statist_i_h_wts[13,75]=-2.90819743222387e-001;
    __statist_i_h_wts[13,76]=-6.00138723937415e-002;
    __statist_i_h_wts[13,77]=-4.16055315879081e-001;
    __statist_i_h_wts[13,78]=1.33788034242538e-001;
    __statist_i_h_wts[13,79]=5.31207556023004e-001;
    __statist_i_h_wts[13,80]=-1.65463894447325e-001;
    __statist_i_h_wts[13,81]=-1.49347401036120e-002;
    __statist_i_h_wts[13,82]=-5.49790326880007e-002;
    __statist_i_h_wts[13,83]=1.96088446223922e-001;
    __statist_i_h_wts[13,84]=3.65154940027975e-001;
    __statist_i_h_wts[13,85]=-3.35467193554103e-002;
    __statist_i_h_wts[13,86]=-2.35639764306262e-003;
    __statist_i_h_wts[13,87]=8.90639478889104e-002;
    __statist_i_h_wts[13,88]=1.63007669366735e-001;
    __statist_i_h_wts[13,89]=-2.76429729086343e-001;
    __statist_i_h_wts[13,90]=1.47866377466288e-002;
    __statist_i_h_wts[13,91]=5.40241113077337e-001;
    __statist_i_h_wts[13,92]=5.98683499526051e-001;
    __statist_i_h_wts[13,93]=5.34257611966112e-001;
    __statist_i_h_wts[13,94]=8.84503939904991e-001;
    __statist_i_h_wts[13,95]=-5.32360092031830e-001;
    __statist_i_h_wts[13,96]=-1.92556464735039e-002;
    __statist_i_h_wts[13,97]=-4.37276028816637e-001;
    __statist_i_h_wts[13,98]=-5.74821376658444e-001;
    __statist_i_h_wts[13,99]=2.23052339313110e-001;
    __statist_i_h_wts[13,100]=-1.74319729681086e-001;
    __statist_i_h_wts[13,101]=-2.60109786491466e-001;
    __statist_i_h_wts[13,102]=-4.25248102404646e-001;
    __statist_i_h_wts[13,103]=-3.60749581019159e-001;
    __statist_i_h_wts[13,104]=-5.43125284923083e-001;
    __statist_i_h_wts[13,105]=1.11062160804487e-001;
    __statist_i_h_wts[13,106]=5.19632446859834e-001;
    __statist_i_h_wts[13,107]=3.37236201969950e-002;
    __statist_i_h_wts[13,108]=2.02701669339509e-001;
    __statist_i_h_wts[13,109]=-4.01574319057199e-001;
    __statist_i_h_wts[13,110]=-3.45205389540352e-001;
    __statist_i_h_wts[13,111]=3.77290796355008e-002;
    __statist_i_h_wts[13,112]=-8.02096032727568e-001;
    __statist_i_h_wts[13,113]=-1.58465573829524e-001;
    __statist_i_h_wts[13,114]=-3.12878309046815e-001;
    __statist_i_h_wts[13,115]=1.15560696623314e-002;
    __statist_i_h_wts[13,116]=8.05297698114402e-001;
    __statist_i_h_wts[13,117]=4.96128042110760e-002;
    __statist_i_h_wts[13,118]=-2.43297951079432e-001;
    __statist_i_h_wts[13,119]=2.00122574256644e-001;
    __statist_i_h_wts[13,120]=-1.01334138569230e+000;
    __statist_i_h_wts[13,121]=-3.97136293512801e-001;
    __statist_i_h_wts[13,122]=7.70617368751253e-002;
    __statist_i_h_wts[13,123]=3.65161163338629e-001;
    __statist_i_h_wts[13,124]=7.97027633700054e-002;
    __statist_i_h_wts[13,125]=-2.00585043321316e-001;
    __statist_i_h_wts[13,126]=-3.22087071603771e-001;
    __statist_i_h_wts[13,127]=-9.05101298221128e-001;
    __statist_i_h_wts[13,128]=-1.45105496192476e-001;
    __statist_i_h_wts[13,129]=-3.80783814631726e-001;
    __statist_i_h_wts[13,130]=1.39887081782282e-001;
    __statist_i_h_wts[13,131]=1.68485131983050e-001;
    __statist_i_h_wts[13,132]=-4.63048346179307e-001;
    __statist_i_h_wts[13,133]=2.97510837573854e-002;
    __statist_i_h_wts[13,134]=-7.27877729326588e-001;
    __statist_i_h_wts[13,135]=-5.45397491563052e-001;
    __statist_i_h_wts[13,136]=-4.69578064495156e-001;
    __statist_i_h_wts[13,137]=-7.35646343706269e-002;
    __statist_i_h_wts[13,138]=-4.78801436823046e-002;
    __statist_i_h_wts[13,139]=-4.42435147130364e-002;
    __statist_i_h_wts[13,140]=2.15886420789599e-001;
    __statist_i_h_wts[13,141]=-6.83097754320160e-001;
    __statist_i_h_wts[13,142]=-3.91685327325344e-001;
    __statist_i_h_wts[13,143]=-5.23144437696434e-002;
    __statist_i_h_wts[13,144]=-2.64869186705156e-001;
    __statist_i_h_wts[13,145]=-1.08270148037267e-001;
    __statist_i_h_wts[13,146]=-1.02092121577680e-002;
    __statist_i_h_wts[13,147]=-4.53534714239378e-001;
    __statist_i_h_wts[13,148]=6.72248375377503e-001;
    __statist_i_h_wts[13,149]=3.18298824673559e-001;
    __statist_i_h_wts[13,150]=-3.18176278170114e-001;
    __statist_i_h_wts[13,151]=-6.90399772573027e-002;
    __statist_i_h_wts[13,152]=7.77672911058915e-003;
    __statist_i_h_wts[13,153]=-5.90038350690962e-001;
    __statist_i_h_wts[13,154]=-2.68451164196913e-001;
    __statist_i_h_wts[13,155]=-2.50817938885161e-001;
    __statist_i_h_wts[13,156]=3.64280780428380e-001;
    __statist_i_h_wts[13,157]=-9.59428250766352e-002;
    __statist_i_h_wts[13,158]=2.22676020464024e-001;
    __statist_i_h_wts[13,159]=1.14215762052446e-001;
    __statist_i_h_wts[13,160]=2.91005890333227e-001;
    __statist_i_h_wts[13,161]=-7.29512823294288e-001;
    __statist_i_h_wts[13,162]=3.77058399842089e-002;
    __statist_i_h_wts[13,163]=2.21619979153292e-001;
    __statist_i_h_wts[13,164]=9.86009927103562e-002;
    __statist_i_h_wts[13,165]=-1.93905321772003e-001;
    __statist_i_h_wts[13,166]=-1.28596921073069e-001;
    __statist_i_h_wts[13,167]=-6.13636386611755e-002;
    __statist_i_h_wts[13,168]=7.43919225344062e-002;
    __statist_i_h_wts[13,169]=1.21124678367158e-001;
    __statist_i_h_wts[13,170]=3.51451774277358e-003;
    __statist_i_h_wts[13,171]=4.02571342867049e-001;
    __statist_i_h_wts[13,172]=4.30940824180872e-001;
    __statist_i_h_wts[13,173]=-9.67536022196704e-002;
    __statist_i_h_wts[13,174]=-3.92711653982605e-001;
    __statist_i_h_wts[13,175]=-3.80915594511281e-001;
    __statist_i_h_wts[13,176]=-6.18373175072092e-002;
    __statist_i_h_wts[13,177]=-2.27857568355238e-002;
    __statist_i_h_wts[13,178]=6.31763204176363e-001;
    __statist_i_h_wts[13,179]=8.92115992166464e-001;
    __statist_i_h_wts[13,180]=-1.74422732111336e-001;
    __statist_i_h_wts[13,181]=-5.16572635371321e-002;
    __statist_i_h_wts[13,182]=1.39679296872137e-001;
    __statist_i_h_wts[13,183]=-3.26746081990636e-001;
    __statist_i_h_wts[13,184]=2.03333958580450e-001;
    __statist_i_h_wts[13,185]=-1.54508981863935e-001;
    __statist_i_h_wts[13,186]=-1.43533362244330e-001;
    __statist_i_h_wts[13,187]=3.98785685212926e-002;
    __statist_i_h_wts[13,188]=2.86080806435775e-001;
    __statist_i_h_wts[13,189]=-1.42353233810347e-001;
    __statist_i_h_wts[13,190]=-1.97656544104130e-001;
    __statist_i_h_wts[13,191]=-6.69429895014140e-002;
    __statist_i_h_wts[13,192]=-4.35748572071047e-001;
    __statist_i_h_wts[13,193]=4.20069230812514e-001;
    __statist_i_h_wts[13,194]=4.98302337818676e-001;
    __statist_i_h_wts[13,195]=3.12412545965960e-001;
    __statist_i_h_wts[13,196]=3.71076846407401e-001;
    __statist_i_h_wts[13,197]=3.15128736205380e-001;
    __statist_i_h_wts[13,198]=-1.21121814442756e-002;
    __statist_i_h_wts[13,199]=-1.55444067943754e-001;
    __statist_i_h_wts[13,200]=-4.91917183292741e-002;
    __statist_i_h_wts[13,201]=-2.23465435713637e-001;
    __statist_i_h_wts[13,202]=-2.91393126631430e-001;
    __statist_i_h_wts[13,203]=-2.89512917038489e-001;
    __statist_i_h_wts[13,204]=-9.61309222215719e-004;
    __statist_i_h_wts[13,205]=4.15696872571117e-001;
    __statist_i_h_wts[13,206]=5.41076598483684e-001;
    __statist_i_h_wts[13,207]=1.52999252047453e-001;
    __statist_i_h_wts[13,208]=1.24545294804424e-001;
    __statist_i_h_wts[13,209]=2.10022304691612e-001;
    __statist_i_h_wts[13,210]=4.75305258729713e-001;
    __statist_i_h_wts[13,211]=4.91946188817765e-001;
    __statist_i_h_wts[13,212]=3.90716215330822e-001;
    __statist_i_h_wts[13,213]=-4.54708661040479e-004;
    __statist_i_h_wts[13,214]=-8.56652544801636e-002;
    __statist_i_h_wts[13,215]=-3.72823033747219e-003;
    __statist_i_h_wts[13,216]=-1.43466232850218e-001;
    __statist_i_h_wts[13,217]=-3.61771955989966e-001;
    __statist_i_h_wts[13,218]=1.41598547372709e-001;
    __statist_i_h_wts[13,219]=7.23012150141719e-001;
    __statist_i_h_wts[13,220]=7.44192846561296e-001;
    __statist_i_h_wts[13,221]=8.32305577571529e-001;
    __statist_i_h_wts[13,222]=6.42981340391957e-001;
    __statist_i_h_wts[13,223]=-3.88079163645334e-001;
    __statist_i_h_wts[13,224]=-1.62611026287966e-001;
    __statist_i_h_wts[13,225]=2.35463467081165e-001;
    __statist_i_h_wts[13,226]=-3.56950416409976e-001;
    __statist_i_h_wts[13,227]=3.68807762769876e-001;
    __statist_i_h_wts[13,228]=-4.50513002005300e-001;
    __statist_i_h_wts[13,229]=-3.57066936638029e-001;
    __statist_i_h_wts[13,230]=4.81907451037980e-001;
    __statist_i_h_wts[13,231]=2.18844287928467e-001;
    __statist_i_h_wts[13,232]=1.02935361286505e+000;
    __statist_i_h_wts[13,233]=3.90636295592400e-001;
    __statist_i_h_wts[13,234]=2.56145042392297e-001;
    __statist_i_h_wts[13,235]=9.46652763155717e-001;
    __statist_i_h_wts[13,236]=7.55809778141390e-001;
    __statist_i_h_wts[13,237]=1.08722224390672e+000;
    __statist_i_h_wts[13,238]=3.76280036304982e-001;
    __statist_i_h_wts[13,239]=4.93380750257344e-001;
    __statist_i_h_wts[13,240]=-8.92428948370429e-001;
    __statist_i_h_wts[13,241]=-2.69508324310119e+000;
    __statist_i_h_wts[13,242]=-8.68857150076059e-001;
    __statist_i_h_wts[13,243]=-1.85212744654380e-001;
    __statist_i_h_wts[13,244]=9.50594792777522e-001;
    __statist_i_h_wts[13,245]=-7.25384968386072e-001;
    __statist_i_h_wts[13,246]=-1.03881644422922e+000;
    __statist_i_h_wts[13,247]=-1.34451396031428e+000;
    __statist_i_h_wts[13,248]=2.69068016685520e-001;

    __statist_i_h_wts[14,0]=7.93797796979761e-003;
    __statist_i_h_wts[14,1]=-3.81752292580501e-001;
    __statist_i_h_wts[14,2]=-5.33288698481810e-002;
    __statist_i_h_wts[14,3]=-3.04962676581485e-001;
    __statist_i_h_wts[14,4]=-4.26438437046319e-001;
    __statist_i_h_wts[14,5]=-3.99779545785481e-001;
    __statist_i_h_wts[14,6]=-3.96501744811707e-001;
    __statist_i_h_wts[14,7]=-5.19595014470570e-001;
    __statist_i_h_wts[14,8]=-2.74785812159566e-002;
    __statist_i_h_wts[14,9]=-2.03309714470259e-001;
    __statist_i_h_wts[14,10]=-1.89338783128104e-001;
    __statist_i_h_wts[14,11]=-2.33051959395229e-001;
    __statist_i_h_wts[14,12]=2.84039441800702e-002;
    __statist_i_h_wts[14,13]=-2.63867259835970e-001;
    __statist_i_h_wts[14,14]=-5.17453192646432e-002;
    __statist_i_h_wts[14,15]=-2.19611065822530e-002;
    __statist_i_h_wts[14,16]=-3.55066674978566e-001;
    __statist_i_h_wts[14,17]=5.91145777528531e-002;
    __statist_i_h_wts[14,18]=-2.05206397332333e-001;
    __statist_i_h_wts[14,19]=-1.60961848403476e-001;
    __statist_i_h_wts[14,20]=-2.63090238121996e-001;
    __statist_i_h_wts[14,21]=-1.78799591293260e-001;
    __statist_i_h_wts[14,22]=-2.97660118047490e-001;
    __statist_i_h_wts[14,23]=6.69931397776587e-002;
    __statist_i_h_wts[14,24]=-1.21916734043311e-001;
    __statist_i_h_wts[14,25]=-1.09434487404853e-001;
    __statist_i_h_wts[14,26]=-1.75109388019661e-001;
    __statist_i_h_wts[14,27]=4.84094557633219e-002;
    __statist_i_h_wts[14,28]=-2.59809576926157e-001;
    __statist_i_h_wts[14,29]=-1.54120238705360e-002;
    __statist_i_h_wts[14,30]=3.74223830107314e-001;
    __statist_i_h_wts[14,31]=8.50080681813806e-002;
    __statist_i_h_wts[14,32]=3.10216534381684e-001;
    __statist_i_h_wts[14,33]=3.81726976786997e-002;
    __statist_i_h_wts[14,34]=-4.99625596524416e-002;
    __statist_i_h_wts[14,35]=-1.81903151099394e-001;
    __statist_i_h_wts[14,36]=-2.33517111758386e-002;
    __statist_i_h_wts[14,37]=-1.60658809076678e-001;
    __statist_i_h_wts[14,38]=1.56814949759902e-001;
    __statist_i_h_wts[14,39]=2.00759731311514e-002;
    __statist_i_h_wts[14,40]=1.79097738816009e-001;
    __statist_i_h_wts[14,41]=-3.78365401988998e-002;
    __statist_i_h_wts[14,42]=2.58963073220778e-001;
    __statist_i_h_wts[14,43]=-2.23969616871404e-001;
    __statist_i_h_wts[14,44]=2.03252505542403e-001;
    __statist_i_h_wts[14,45]=4.78988550453882e-001;
    __statist_i_h_wts[14,46]=6.34395517176796e-001;
    __statist_i_h_wts[14,47]=8.83208497004096e-001;
    __statist_i_h_wts[14,48]=4.30187294427301e-001;
    __statist_i_h_wts[14,49]=3.66647301127055e-001;
    __statist_i_h_wts[14,50]=5.64461916526775e-002;
    __statist_i_h_wts[14,51]=1.90387262147608e-001;
    __statist_i_h_wts[14,52]=3.25791067730824e-001;
    __statist_i_h_wts[14,53]=-6.17395640242279e-002;
    __statist_i_h_wts[14,54]=-1.78448657594072e-001;
    __statist_i_h_wts[14,55]=1.94942409686825e-001;
    __statist_i_h_wts[14,56]=1.01780744067118e-001;
    __statist_i_h_wts[14,57]=4.04781278136116e-001;
    __statist_i_h_wts[14,58]=6.20062677132110e-002;
    __statist_i_h_wts[14,59]=1.56859193828894e-001;
    __statist_i_h_wts[14,60]=3.01983766692782e-001;
    __statist_i_h_wts[14,61]=6.88086976671711e-002;
    __statist_i_h_wts[14,62]=1.54773633446090e-001;
    __statist_i_h_wts[14,63]=-3.99085891483578e-002;
    __statist_i_h_wts[14,64]=-1.22308930226404e-001;
    __statist_i_h_wts[14,65]=-1.12800563804504e-001;
    __statist_i_h_wts[14,66]=1.04582142414172e-001;
    __statist_i_h_wts[14,67]=-1.01838252450111e-001;
    __statist_i_h_wts[14,68]=3.65773758755444e-001;
    __statist_i_h_wts[14,69]=5.17073078778301e-001;
    __statist_i_h_wts[14,70]=3.09882418587054e-001;
    __statist_i_h_wts[14,71]=2.99855468346145e-001;
    __statist_i_h_wts[14,72]=3.75198468789357e-001;
    __statist_i_h_wts[14,73]=9.70824157255153e-002;
    __statist_i_h_wts[14,74]=-6.84256262553463e-002;
    __statist_i_h_wts[14,75]=5.63963677294007e-002;
    __statist_i_h_wts[14,76]=4.62718167439023e-002;
    __statist_i_h_wts[14,77]=2.64518543848388e-002;
    __statist_i_h_wts[14,78]=2.59552456038737e-001;
    __statist_i_h_wts[14,79]=3.86780641674833e-001;
    __statist_i_h_wts[14,80]=3.49210776839483e-001;
    __statist_i_h_wts[14,81]=4.54011973110243e-001;
    __statist_i_h_wts[14,82]=1.68110895470991e-001;
    __statist_i_h_wts[14,83]=4.09436045894836e-001;
    __statist_i_h_wts[14,84]=2.22908152406706e-001;
    __statist_i_h_wts[14,85]=-2.11520644367399e-002;
    __statist_i_h_wts[14,86]=1.22034736202447e-001;
    __statist_i_h_wts[14,87]=6.12113990783784e-002;
    __statist_i_h_wts[14,88]=1.17190438477895e-001;
    __statist_i_h_wts[14,89]=1.69954972297826e-001;
    __statist_i_h_wts[14,90]=1.53667968677290e-001;
    __statist_i_h_wts[14,91]=2.72550873630006e-002;
    __statist_i_h_wts[14,92]=-1.69575088432292e-001;
    __statist_i_h_wts[14,93]=6.53595942251905e-002;
    __statist_i_h_wts[14,94]=2.88354711508821e-001;
    __statist_i_h_wts[14,95]=2.62529488394172e-002;
    __statist_i_h_wts[14,96]=1.38179030267046e-001;
    __statist_i_h_wts[14,97]=4.52466575810921e-002;
    __statist_i_h_wts[14,98]=4.69424225597002e-001;
    __statist_i_h_wts[14,99]=3.36046579534807e-001;
    __statist_i_h_wts[14,100]=1.97266056842088e-001;
    __statist_i_h_wts[14,101]=-5.09584067279311e-002;
    __statist_i_h_wts[14,102]=-1.84984727322967e-001;
    __statist_i_h_wts[14,103]=-3.18997201797734e-002;
    __statist_i_h_wts[14,104]=6.72985210841743e-003;
    __statist_i_h_wts[14,105]=2.73688360679875e-001;
    __statist_i_h_wts[14,106]=2.88555706896063e-001;
    __statist_i_h_wts[14,107]=1.75080874226782e-001;
    __statist_i_h_wts[14,108]=3.00937104624996e-001;
    __statist_i_h_wts[14,109]=3.40680325017305e-001;
    __statist_i_h_wts[14,110]=-1.18897898443209e-002;
    __statist_i_h_wts[14,111]=2.42127790082460e-001;
    __statist_i_h_wts[14,112]=2.38515469506846e-001;
    __statist_i_h_wts[14,113]=4.83318267323922e-001;
    __statist_i_h_wts[14,114]=1.00481073456230e-001;
    __statist_i_h_wts[14,115]=-1.82794870343872e-001;
    __statist_i_h_wts[14,116]=-1.39561702875518e-001;
    __statist_i_h_wts[14,117]=5.78154485137695e-002;
    __statist_i_h_wts[14,118]=2.33423357761796e-001;
    __statist_i_h_wts[14,119]=-2.30810756613680e-002;
    __statist_i_h_wts[14,120]=-3.77549276548999e-002;
    __statist_i_h_wts[14,121]=-2.48863617990801e-001;
    __statist_i_h_wts[14,122]=2.03143660230402e-001;
    __statist_i_h_wts[14,123]=-1.11469697975858e-002;
    __statist_i_h_wts[14,124]=-3.56126162362259e-001;
    __statist_i_h_wts[14,125]=-1.86748960189754e-001;
    __statist_i_h_wts[14,126]=3.64175066711731e-001;
    __statist_i_h_wts[14,127]=1.14544985371330e-001;
    __statist_i_h_wts[14,128]=4.45615661155577e-001;
    __statist_i_h_wts[14,129]=1.44056613887187e-001;
    __statist_i_h_wts[14,130]=1.36535052626412e-001;
    __statist_i_h_wts[14,131]=2.06130536114280e-001;
    __statist_i_h_wts[14,132]=3.18240064956614e-001;
    __statist_i_h_wts[14,133]=1.21239358752741e-001;
    __statist_i_h_wts[14,134]=3.40515999319344e-001;
    __statist_i_h_wts[14,135]=-1.73758437919274e-001;
    __statist_i_h_wts[14,136]=-6.38311350995739e-002;
    __statist_i_h_wts[14,137]=2.01273058643840e-001;
    __statist_i_h_wts[14,138]=-4.04310472417670e-002;
    __statist_i_h_wts[14,139]=-5.51025005837968e-001;
    __statist_i_h_wts[14,140]=-5.28990391114853e-002;
    __statist_i_h_wts[14,141]=2.56414274526710e-001;
    __statist_i_h_wts[14,142]=-1.83535324043540e-001;
    __statist_i_h_wts[14,143]=2.63671983489841e-001;
    __statist_i_h_wts[14,144]=5.36197486170103e-002;
    __statist_i_h_wts[14,145]=-4.59021017531193e-002;
    __statist_i_h_wts[14,146]=-1.26424473484531e-001;
    __statist_i_h_wts[14,147]=-2.61177747335743e-001;
    __statist_i_h_wts[14,148]=4.27729005517051e-004;
    __statist_i_h_wts[14,149]=2.53851673306381e-001;
    __statist_i_h_wts[14,150]=1.26579834349952e-002;
    __statist_i_h_wts[14,151]=2.36413993648123e-002;
    __statist_i_h_wts[14,152]=3.49734963056100e-002;
    __statist_i_h_wts[14,153]=-1.83626303591816e-001;
    __statist_i_h_wts[14,154]=-4.06694238895989e-001;
    __statist_i_h_wts[14,155]=-1.66421460437436e-001;
    __statist_i_h_wts[14,156]=-1.53416161022654e-001;
    __statist_i_h_wts[14,157]=-2.08563128582547e-001;
    __statist_i_h_wts[14,158]=1.10329638075799e-001;
    __statist_i_h_wts[14,159]=7.24753831453143e-002;
    __statist_i_h_wts[14,160]=1.35350742740219e-002;
    __statist_i_h_wts[14,161]=2.58302031905398e-002;
    __statist_i_h_wts[14,162]=-2.25464910868610e-001;
    __statist_i_h_wts[14,163]=3.30654906088728e-002;
    __statist_i_h_wts[14,164]=2.51060964610900e-001;
    __statist_i_h_wts[14,165]=-2.06455858325372e-001;
    __statist_i_h_wts[14,166]=-5.19443366168782e-002;
    __statist_i_h_wts[14,167]=-9.23029620312367e-002;
    __statist_i_h_wts[14,168]=-2.59324138653130e-001;
    __statist_i_h_wts[14,169]=-2.42244730935442e-001;
    __statist_i_h_wts[14,170]=-7.10866403237218e-002;
    __statist_i_h_wts[14,171]=2.74080547556561e-001;
    __statist_i_h_wts[14,172]=-2.33562788450172e-001;
    __statist_i_h_wts[14,173]=6.08881486630371e-002;
    __statist_i_h_wts[14,174]=-2.58648930784876e-001;
    __statist_i_h_wts[14,175]=-6.26993463431260e-002;
    __statist_i_h_wts[14,176]=-8.77339929789814e-003;
    __statist_i_h_wts[14,177]=8.99873630395671e-002;
    __statist_i_h_wts[14,178]=1.54114822989881e-001;
    __statist_i_h_wts[14,179]=1.67131787450766e-001;
    __statist_i_h_wts[14,180]=-4.62709150305227e-002;
    __statist_i_h_wts[14,181]=-4.02251470472246e-001;
    __statist_i_h_wts[14,182]=-2.87151268764724e-001;
    __statist_i_h_wts[14,183]=2.59503834036894e-002;
    __statist_i_h_wts[14,184]=1.13526987633119e-002;
    __statist_i_h_wts[14,185]=1.94340396635983e-001;
    __statist_i_h_wts[14,186]=4.13962217574015e-002;
    __statist_i_h_wts[14,187]=-5.72564733874120e-001;
    __statist_i_h_wts[14,188]=-5.79795520453040e-002;
    __statist_i_h_wts[14,189]=-9.13928308162419e-002;
    __statist_i_h_wts[14,190]=9.34012953464411e-002;
    __statist_i_h_wts[14,191]=-1.66816609834670e-001;
    __statist_i_h_wts[14,192]=-2.66856090141137e-001;
    __statist_i_h_wts[14,193]=-1.51087871145482e-001;
    __statist_i_h_wts[14,194]=8.22868726057029e-002;
    __statist_i_h_wts[14,195]=-3.32271396638289e-002;
    __statist_i_h_wts[14,196]=-2.59503475141357e-001;
    __statist_i_h_wts[14,197]=-2.94354597826878e-001;
    __statist_i_h_wts[14,198]=-3.39488768938319e-001;
    __statist_i_h_wts[14,199]=-4.21754941593895e-002;
    __statist_i_h_wts[14,200]=-1.40642140520947e-001;
    __statist_i_h_wts[14,201]=-5.68493869599715e-001;
    __statist_i_h_wts[14,202]=-7.31983122528389e-001;
    __statist_i_h_wts[14,203]=-6.04359619145461e-002;
    __statist_i_h_wts[14,204]=-1.28378723902115e-001;
    __statist_i_h_wts[14,205]=-1.91660873816028e-002;
    __statist_i_h_wts[14,206]=-1.45309023192888e-001;
    __statist_i_h_wts[14,207]=-1.07171326822915e-001;
    __statist_i_h_wts[14,208]=1.11513194734218e-001;
    __statist_i_h_wts[14,209]=2.00583565692506e-001;
    __statist_i_h_wts[14,210]=-1.25533189775439e-001;
    __statist_i_h_wts[14,211]=-2.29538452745560e-001;
    __statist_i_h_wts[14,212]=-3.36826220019757e-001;
    __statist_i_h_wts[14,213]=-5.24391749139291e-001;
    __statist_i_h_wts[14,214]=-4.96031462208281e-001;
    __statist_i_h_wts[14,215]=-5.54993327512190e-001;
    __statist_i_h_wts[14,216]=-3.93821978222867e-001;
    __statist_i_h_wts[14,217]=-4.53292525413139e-001;
    __statist_i_h_wts[14,218]=-8.26296469828131e-002;
    __statist_i_h_wts[14,219]=-5.25795742205397e-001;
    __statist_i_h_wts[14,220]=-4.61108988130096e-001;
    __statist_i_h_wts[14,221]=-4.83752420137308e-001;
    __statist_i_h_wts[14,222]=-3.78003321006776e-001;
    __statist_i_h_wts[14,223]=-1.07367382340866e-002;
    __statist_i_h_wts[14,224]=4.97463027710169e-002;
    __statist_i_h_wts[14,225]=6.49517728294574e-002;
    __statist_i_h_wts[14,226]=5.23695603858346e-001;
    __statist_i_h_wts[14,227]=-9.47522732114164e-002;
    __statist_i_h_wts[14,228]=5.62268281789910e-002;
    __statist_i_h_wts[14,229]=-2.63182066245841e-001;
    __statist_i_h_wts[14,230]=-8.01941925351592e-001;
    __statist_i_h_wts[14,231]=-4.64328182180081e-001;
    __statist_i_h_wts[14,232]=-1.19356745043598e+000;
    __statist_i_h_wts[14,233]=2.47450940527576e-003;
    __statist_i_h_wts[14,234]=-7.66579373963162e-001;
    __statist_i_h_wts[14,235]=9.47203648312760e-002;
    __statist_i_h_wts[14,236]=4.55067338866469e-001;
    __statist_i_h_wts[14,237]=2.94295791658318e-001;
    __statist_i_h_wts[14,238]=-3.40689053087459e-001;
    __statist_i_h_wts[14,239]=-2.99919950216119e-001;
    __statist_i_h_wts[14,240]=3.95151797310612e-001;
    __statist_i_h_wts[14,241]=1.71438450941947e+000;
    __statist_i_h_wts[14,242]=1.23443550372427e-001;
    __statist_i_h_wts[14,243]=-4.53194410657350e-001;
    __statist_i_h_wts[14,244]=6.79425136430461e-001;
    __statist_i_h_wts[14,245]=6.12858779288928e-001;
    __statist_i_h_wts[14,246]=9.64124026735010e-001;
    __statist_i_h_wts[14,247]=8.93596689037708e-001;
    __statist_i_h_wts[14,248]=7.02945816015031e-002;

    __statist_i_h_wts[15,0]=-7.95266395789527e-002;
    __statist_i_h_wts[15,1]=4.06865685579166e-002;
    __statist_i_h_wts[15,2]=1.61437408851901e-001;
    __statist_i_h_wts[15,3]=1.36515794508318e-001;
    __statist_i_h_wts[15,4]=9.91342142963724e-002;
    __statist_i_h_wts[15,5]=1.35334249452984e-001;
    __statist_i_h_wts[15,6]=-6.29606247915689e-002;
    __statist_i_h_wts[15,7]=-2.61440508576897e-004;
    __statist_i_h_wts[15,8]=-2.52049221248388e-002;
    __statist_i_h_wts[15,9]=-3.23831751353146e-001;
    __statist_i_h_wts[15,10]=-2.41239704188884e-001;
    __statist_i_h_wts[15,11]=-1.50016842427628e-001;
    __statist_i_h_wts[15,12]=-2.15874720763614e-001;
    __statist_i_h_wts[15,13]=-3.10507415132571e-001;
    __statist_i_h_wts[15,14]=-1.81608838352770e-001;
    __statist_i_h_wts[15,15]=-3.41035570562832e-001;
    __statist_i_h_wts[15,16]=-1.08204111453335e-001;
    __statist_i_h_wts[15,17]=1.63041520252895e-002;
    __statist_i_h_wts[15,18]=-1.93458266970868e-002;
    __statist_i_h_wts[15,19]=2.56647132848447e-002;
    __statist_i_h_wts[15,20]=7.23736890052973e-002;
    __statist_i_h_wts[15,21]=-1.45252885312077e-001;
    __statist_i_h_wts[15,22]=-2.51433044355087e-001;
    __statist_i_h_wts[15,23]=-2.75149155108272e-001;
    __statist_i_h_wts[15,24]=-4.28417759776411e-001;
    __statist_i_h_wts[15,25]=-2.69447835844258e-001;
    __statist_i_h_wts[15,26]=-1.79035742174791e-001;
    __statist_i_h_wts[15,27]=-2.46376266756155e-001;
    __statist_i_h_wts[15,28]=-3.79183739185520e-001;
    __statist_i_h_wts[15,29]=-1.99078885504821e-001;
    __statist_i_h_wts[15,30]=-2.55558669156688e-001;
    __statist_i_h_wts[15,31]=-2.39637893261815e-001;
    __statist_i_h_wts[15,32]=-1.66342505610865e-001;
    __statist_i_h_wts[15,33]=-1.68386205230573e-001;
    __statist_i_h_wts[15,34]=-1.18458662515431e-001;
    __statist_i_h_wts[15,35]=6.15310398672449e-002;
    __statist_i_h_wts[15,36]=-7.20323842104024e-002;
    __statist_i_h_wts[15,37]=-6.57275290954815e-002;
    __statist_i_h_wts[15,38]=1.21304005560305e-001;
    __statist_i_h_wts[15,39]=-1.44048296747402e-001;
    __statist_i_h_wts[15,40]=8.18629682869688e-002;
    __statist_i_h_wts[15,41]=4.65641567520187e-002;
    __statist_i_h_wts[15,42]=-2.66296277145719e-002;
    __statist_i_h_wts[15,43]=-3.15360099232825e-001;
    __statist_i_h_wts[15,44]=-5.46930703094483e-002;
    __statist_i_h_wts[15,45]=-2.35969427314887e-001;
    __statist_i_h_wts[15,46]=-2.69918880924318e-001;
    __statist_i_h_wts[15,47]=-2.42977354586367e-001;
    __statist_i_h_wts[15,48]=-2.98631678582794e-001;
    __statist_i_h_wts[15,49]=-2.05643289247588e-001;
    __statist_i_h_wts[15,50]=-4.02448246656190e-002;
    __statist_i_h_wts[15,51]=-3.87073945902642e-002;
    __statist_i_h_wts[15,52]=-1.74758387905566e-001;
    __statist_i_h_wts[15,53]=-9.47303212904044e-002;
    __statist_i_h_wts[15,54]=-3.63099586228824e-001;
    __statist_i_h_wts[15,55]=-2.24899453213599e-001;
    __statist_i_h_wts[15,56]=-2.11832165828544e-001;
    __statist_i_h_wts[15,57]=-2.50785563780975e-001;
    __statist_i_h_wts[15,58]=-2.30518261618341e-001;
    __statist_i_h_wts[15,59]=-6.93725409468620e-002;
    __statist_i_h_wts[15,60]=-1.15788164457643e-001;
    __statist_i_h_wts[15,61]=-2.85790691943626e-002;
    __statist_i_h_wts[15,62]=2.84477492951690e-002;
    __statist_i_h_wts[15,63]=-6.70241370283485e-002;
    __statist_i_h_wts[15,64]=-8.72500862486505e-003;
    __statist_i_h_wts[15,65]=1.39019641282009e-001;
    __statist_i_h_wts[15,66]=3.25071399649918e-001;
    __statist_i_h_wts[15,67]=-1.27827898242916e-003;
    __statist_i_h_wts[15,68]=9.03583179838281e-002;
    __statist_i_h_wts[15,69]=-3.12558266828772e-001;
    __statist_i_h_wts[15,70]=-3.66298001531540e-001;
    __statist_i_h_wts[15,71]=-3.20065353337653e-001;
    __statist_i_h_wts[15,72]=-4.27530325473195e-001;
    __statist_i_h_wts[15,73]=-2.59720192329414e-001;
    __statist_i_h_wts[15,74]=-4.04949653016494e-002;
    __statist_i_h_wts[15,75]=-2.88083725007082e-002;
    __statist_i_h_wts[15,76]=9.45436208418850e-002;
    __statist_i_h_wts[15,77]=-5.91128879488818e-002;
    __statist_i_h_wts[15,78]=4.61621113558136e-002;
    __statist_i_h_wts[15,79]=1.39767264624174e-001;
    __statist_i_h_wts[15,80]=5.52311806320173e-002;
    __statist_i_h_wts[15,81]=2.12656124603651e-001;
    __statist_i_h_wts[15,82]=-1.53665136484563e-001;
    __statist_i_h_wts[15,83]=-2.14898700280944e-002;
    __statist_i_h_wts[15,84]=-1.92770898325377e-001;
    __statist_i_h_wts[15,85]=-2.17447289750612e-001;
    __statist_i_h_wts[15,86]=-4.43573121812645e-002;
    __statist_i_h_wts[15,87]=-1.58348469734232e-001;
    __statist_i_h_wts[15,88]=-2.11718479956837e-001;
    __statist_i_h_wts[15,89]=1.37993031692577e-001;
    __statist_i_h_wts[15,90]=-1.18674997634831e-002;
    __statist_i_h_wts[15,91]=-1.28656288795365e-002;
    __statist_i_h_wts[15,92]=-4.92888893901085e-001;
    __statist_i_h_wts[15,93]=-2.17620502801712e-001;
    __statist_i_h_wts[15,94]=-1.73334065539073e-001;
    __statist_i_h_wts[15,95]=-3.02092271101638e-001;
    __statist_i_h_wts[15,96]=-9.56571022970341e-002;
    __statist_i_h_wts[15,97]=-2.35394597892589e-001;
    __statist_i_h_wts[15,98]=-7.21078880279288e-002;
    __statist_i_h_wts[15,99]=-2.22751193284277e-001;
    __statist_i_h_wts[15,100]=-1.85230709653630e-001;
    __statist_i_h_wts[15,101]=-1.22266774964340e-001;
    __statist_i_h_wts[15,102]=-1.28851601162997e-001;
    __statist_i_h_wts[15,103]=-8.89840342082761e-002;
    __statist_i_h_wts[15,104]=2.42642515791718e-002;
    __statist_i_h_wts[15,105]=-2.05174578039006e-001;
    __statist_i_h_wts[15,106]=-1.55506151230350e-001;
    __statist_i_h_wts[15,107]=-2.55081978658954e-001;
    __statist_i_h_wts[15,108]=1.05386840270910e-001;
    __statist_i_h_wts[15,109]=2.46231792336837e-001;
    __statist_i_h_wts[15,110]=-8.55900064295206e-003;
    __statist_i_h_wts[15,111]=2.41006592931376e-001;
    __statist_i_h_wts[15,112]=3.65879146793583e-002;
    __statist_i_h_wts[15,113]=9.50057414565001e-002;
    __statist_i_h_wts[15,114]=2.94073397581108e-002;
    __statist_i_h_wts[15,115]=-3.38441527704625e-001;
    __statist_i_h_wts[15,116]=-1.54235522557130e-001;
    __statist_i_h_wts[15,117]=-1.85016007551530e-001;
    __statist_i_h_wts[15,118]=1.21204097044450e-001;
    __statist_i_h_wts[15,119]=7.51235191513066e-002;
    __statist_i_h_wts[15,120]=2.07987746457031e-001;
    __statist_i_h_wts[15,121]=8.23534953640954e-002;
    __statist_i_h_wts[15,122]=-1.36690322471174e-001;
    __statist_i_h_wts[15,123]=-1.47607466843833e-001;
    __statist_i_h_wts[15,124]=-1.20151291753882e-001;
    __statist_i_h_wts[15,125]=4.13459994849951e-002;
    __statist_i_h_wts[15,126]=1.50626814827930e-001;
    __statist_i_h_wts[15,127]=-3.19885486045992e-001;
    __statist_i_h_wts[15,128]=-1.06181584546502e-001;
    __statist_i_h_wts[15,129]=-6.09054038308780e-002;
    __statist_i_h_wts[15,130]=-8.08788936242680e-002;
    __statist_i_h_wts[15,131]=2.50261726766544e-001;
    __statist_i_h_wts[15,132]=1.95660671027937e-001;
    __statist_i_h_wts[15,133]=5.34422408175474e-002;
    __statist_i_h_wts[15,134]=2.79253087523574e-001;
    __statist_i_h_wts[15,135]=4.41356624853448e-002;
    __statist_i_h_wts[15,136]=5.23435062663571e-002;
    __statist_i_h_wts[15,137]=-3.01656959984652e-001;
    __statist_i_h_wts[15,138]=-9.66893313497278e-002;
    __statist_i_h_wts[15,139]=-2.20949518080593e-001;
    __statist_i_h_wts[15,140]=5.19941671176867e-002;
    __statist_i_h_wts[15,141]=1.97372362315264e-001;
    __statist_i_h_wts[15,142]=-3.96777555600619e-001;
    __statist_i_h_wts[15,143]=-2.79781777976214e-001;
    __statist_i_h_wts[15,144]=2.90428750435347e-003;
    __statist_i_h_wts[15,145]=-9.92611229226221e-002;
    __statist_i_h_wts[15,146]=1.15020979856224e-002;
    __statist_i_h_wts[15,147]=-2.37045415506244e-001;
    __statist_i_h_wts[15,148]=-2.21570100450686e-001;
    __statist_i_h_wts[15,149]=-5.24479743116084e-002;
    __statist_i_h_wts[15,150]=-1.33082727702426e-001;
    __statist_i_h_wts[15,151]=-9.65262411235314e-002;
    __statist_i_h_wts[15,152]=-3.86935730567623e-001;
    __statist_i_h_wts[15,153]=-3.03454985248493e-002;
    __statist_i_h_wts[15,154]=-2.50411479968275e-001;
    __statist_i_h_wts[15,155]=-1.69312380547179e-002;
    __statist_i_h_wts[15,156]=-2.23004627979081e-001;
    __statist_i_h_wts[15,157]=-4.80551973515334e-001;
    __statist_i_h_wts[15,158]=-4.27402528165292e-001;
    __statist_i_h_wts[15,159]=6.01323954757119e-002;
    __statist_i_h_wts[15,160]=-2.32434879965954e-002;
    __statist_i_h_wts[15,161]=2.05240926747580e-001;
    __statist_i_h_wts[15,162]=-2.71648248121313e-001;
    __statist_i_h_wts[15,163]=-1.67490354592833e-001;
    __statist_i_h_wts[15,164]=-4.34655226526632e-002;
    __statist_i_h_wts[15,165]=-2.02693182254990e-001;
    __statist_i_h_wts[15,166]=-2.81712224647340e-001;
    __statist_i_h_wts[15,167]=-5.07650568987478e-001;
    __statist_i_h_wts[15,168]=-3.37888233007869e-001;
    __statist_i_h_wts[15,169]=-2.52250834720955e-001;
    __statist_i_h_wts[15,170]=-1.60526822087341e-001;
    __statist_i_h_wts[15,171]=-9.40858081792662e-002;
    __statist_i_h_wts[15,172]=-4.42620105779884e-001;
    __statist_i_h_wts[15,173]=-3.45754474432893e-001;
    __statist_i_h_wts[15,174]=-1.00953759477370e-001;
    __statist_i_h_wts[15,175]=-3.36000974354485e-002;
    __statist_i_h_wts[15,176]=-6.41366366527612e-002;
    __statist_i_h_wts[15,177]=-3.00483364720949e-001;
    __statist_i_h_wts[15,178]=-9.71921914417896e-002;
    __statist_i_h_wts[15,179]=-1.94866213072295e-002;
    __statist_i_h_wts[15,180]=5.80939074019222e-002;
    __statist_i_h_wts[15,181]=-6.37775920254122e-002;
    __statist_i_h_wts[15,182]=-2.06268328548083e-001;
    __statist_i_h_wts[15,183]=-6.96319281663568e-002;
    __statist_i_h_wts[15,184]=-8.85919277530829e-002;
    __statist_i_h_wts[15,185]=-3.66089555735248e-002;
    __statist_i_h_wts[15,186]=2.84962141891352e-003;
    __statist_i_h_wts[15,187]=-1.80111036427411e-001;
    __statist_i_h_wts[15,188]=-2.04343198071907e-001;
    __statist_i_h_wts[15,189]=1.44353282039854e-001;
    __statist_i_h_wts[15,190]=1.41612845011360e-001;
    __statist_i_h_wts[15,191]=9.01981266231393e-002;
    __statist_i_h_wts[15,192]=-9.30061814778828e-002;
    __statist_i_h_wts[15,193]=1.09946501510689e-002;
    __statist_i_h_wts[15,194]=1.41753147591829e-001;
    __statist_i_h_wts[15,195]=4.82335750959992e-002;
    __statist_i_h_wts[15,196]=-1.33658483339083e-002;
    __statist_i_h_wts[15,197]=-2.34133572789096e-001;
    __statist_i_h_wts[15,198]=-3.88593210272481e-001;
    __statist_i_h_wts[15,199]=-3.67861219188906e-001;
    __statist_i_h_wts[15,200]=-4.43669759605097e-001;
    __statist_i_h_wts[15,201]=-3.27155658126411e-001;
    __statist_i_h_wts[15,202]=-1.66850340406417e-001;
    __statist_i_h_wts[15,203]=-1.46411469956409e-001;
    __statist_i_h_wts[15,204]=9.34669838940645e-002;
    __statist_i_h_wts[15,205]=1.30377777973503e-001;
    __statist_i_h_wts[15,206]=3.35136893937549e-002;
    __statist_i_h_wts[15,207]=-9.39842753113303e-002;
    __statist_i_h_wts[15,208]=1.01535496360321e-001;
    __statist_i_h_wts[15,209]=4.95682515131999e-002;
    __statist_i_h_wts[15,210]=1.18280895997974e-001;
    __statist_i_h_wts[15,211]=9.48567864326406e-002;
    __statist_i_h_wts[15,212]=-9.33185244519213e-002;
    __statist_i_h_wts[15,213]=-3.58881040526239e-001;
    __statist_i_h_wts[15,214]=-4.82793906912311e-001;
    __statist_i_h_wts[15,215]=-4.11773761513774e-001;
    __statist_i_h_wts[15,216]=-3.86803822030929e-001;
    __statist_i_h_wts[15,217]=-2.58595690839371e-001;
    __statist_i_h_wts[15,218]=-1.37160907002260e-001;
    __statist_i_h_wts[15,219]=-2.28929367668173e-002;
    __statist_i_h_wts[15,220]=-2.51924849970139e-003;
    __statist_i_h_wts[15,221]=2.20115720067095e-002;
    __statist_i_h_wts[15,222]=-2.53866188789226e-002;
    __statist_i_h_wts[15,223]=2.62260919425001e-001;
    __statist_i_h_wts[15,224]=1.77559784466172e-001;
    __statist_i_h_wts[15,225]=4.53076806022014e-001;
    __statist_i_h_wts[15,226]=-5.74280066221629e-001;
    __statist_i_h_wts[15,227]=6.04233102188350e-001;
    __statist_i_h_wts[15,228]=-5.38575042046693e-001;
    __statist_i_h_wts[15,229]=2.16581173731860e-001;
    __statist_i_h_wts[15,230]=4.99472124694168e-001;
    __statist_i_h_wts[15,231]=-7.70382733912966e-001;
    __statist_i_h_wts[15,232]=2.37920358334058e-001;
    __statist_i_h_wts[15,233]=-1.98856316578762e-001;
    __statist_i_h_wts[15,234]=8.60121817568933e-001;
    __statist_i_h_wts[15,235]=-4.29377279852353e-001;
    __statist_i_h_wts[15,236]=-1.05502145429937e+000;
    __statist_i_h_wts[15,237]=-1.69032876841467e+000;
    __statist_i_h_wts[15,238]=-4.95468352263082e-001;
    __statist_i_h_wts[15,239]=4.72243895710715e-001;
    __statist_i_h_wts[15,240]=-4.63143450734948e-001;
    __statist_i_h_wts[15,241]=4.59431256637891e+000;
    __statist_i_h_wts[15,242]=-7.57714321035651e-002;
    __statist_i_h_wts[15,243]=8.54081338662328e-001;
    __statist_i_h_wts[15,244]=3.17804536829576e-001;
    __statist_i_h_wts[15,245]=-2.21789959853409e+000;
    __statist_i_h_wts[15,246]=1.64180465878789e+000;
    __statist_i_h_wts[15,247]=-7.83138324043544e-001;
    __statist_i_h_wts[15,248]=5.75559339513407e-001;

    __statist_i_h_wts[16,0]=9.09965334886598e-002;
    __statist_i_h_wts[16,1]=2.02752942992767e-001;
    __statist_i_h_wts[16,2]=2.63670588389918e-001;
    __statist_i_h_wts[16,3]=3.06299615127046e-001;
    __statist_i_h_wts[16,4]=4.20617994296070e-001;
    __statist_i_h_wts[16,5]=3.52492343419164e-001;
    __statist_i_h_wts[16,6]=2.43246181973910e-001;
    __statist_i_h_wts[16,7]=2.34224020410727e-001;
    __statist_i_h_wts[16,8]=1.66903091318608e-001;
    __statist_i_h_wts[16,9]=-5.76120061464215e-002;
    __statist_i_h_wts[16,10]=-5.23072450995582e-002;
    __statist_i_h_wts[16,11]=8.22763542312683e-002;
    __statist_i_h_wts[16,12]=3.26583816107819e-002;
    __statist_i_h_wts[16,13]=3.16257189643981e-002;
    __statist_i_h_wts[16,14]=1.46821660673413e-001;
    __statist_i_h_wts[16,15]=1.64815777777744e-001;
    __statist_i_h_wts[16,16]=2.78047442856709e-001;
    __statist_i_h_wts[16,17]=1.71149566738945e-001;
    __statist_i_h_wts[16,18]=2.36197391647598e-001;
    __statist_i_h_wts[16,19]=3.35750019530625e-001;
    __statist_i_h_wts[16,20]=2.47546054821899e-001;
    __statist_i_h_wts[16,21]=1.57296066548185e-001;
    __statist_i_h_wts[16,22]=2.27638740624812e-001;
    __statist_i_h_wts[16,23]=1.74033273007394e-001;
    __statist_i_h_wts[16,24]=3.26524862012241e-003;
    __statist_i_h_wts[16,25]=-6.53458631476159e-002;
    __statist_i_h_wts[16,26]=-7.31867594981320e-002;
    __statist_i_h_wts[16,27]=-1.49580894896241e-001;
    __statist_i_h_wts[16,28]=-6.23879023011409e-002;
    __statist_i_h_wts[16,29]=6.06126960118835e-002;
    __statist_i_h_wts[16,30]=-1.36264708828455e-001;
    __statist_i_h_wts[16,31]=-8.37105006196776e-002;
    __statist_i_h_wts[16,32]=-1.50764244501147e-001;
    __statist_i_h_wts[16,33]=-9.35651516434612e-002;
    __statist_i_h_wts[16,34]=1.81808497455897e-001;
    __statist_i_h_wts[16,35]=9.95954677513604e-002;
    __statist_i_h_wts[16,36]=-1.02190577119371e-001;
    __statist_i_h_wts[16,37]=4.07128518812442e-002;
    __statist_i_h_wts[16,38]=3.01555573085201e-002;
    __statist_i_h_wts[16,39]=-1.37534155501771e-001;
    __statist_i_h_wts[16,40]=-2.26092680120941e-001;
    __statist_i_h_wts[16,41]=-1.97998117095638e-001;
    __statist_i_h_wts[16,42]=-2.14837030481790e-001;
    __statist_i_h_wts[16,43]=-7.98113063077583e-002;
    __statist_i_h_wts[16,44]=-4.24915127002972e-002;
    __statist_i_h_wts[16,45]=-3.97152808702089e-001;
    __statist_i_h_wts[16,46]=-5.32947911777717e-001;
    __statist_i_h_wts[16,47]=-5.95075902019197e-001;
    __statist_i_h_wts[16,48]=-4.46960632032452e-001;
    __statist_i_h_wts[16,49]=-2.08168689525946e-001;
    __statist_i_h_wts[16,50]=-2.42615504817195e-001;
    __statist_i_h_wts[16,51]=-2.72091774858250e-001;
    __statist_i_h_wts[16,52]=-2.25132284381716e-001;
    __statist_i_h_wts[16,53]=-9.90559732583964e-002;
    __statist_i_h_wts[16,54]=-2.99183863680822e-001;
    __statist_i_h_wts[16,55]=-3.90951482539274e-001;
    __statist_i_h_wts[16,56]=-2.50227816974466e-001;
    __statist_i_h_wts[16,57]=-1.94573136907943e-001;
    __statist_i_h_wts[16,58]=-9.05163812025317e-002;
    __statist_i_h_wts[16,59]=-2.49699556497486e-002;
    __statist_i_h_wts[16,60]=-2.76523583761853e-001;
    __statist_i_h_wts[16,61]=-3.02024629816948e-001;
    __statist_i_h_wts[16,62]=-3.79082092904433e-001;
    __statist_i_h_wts[16,63]=-3.61030647063155e-001;
    __statist_i_h_wts[16,64]=-2.35045005274963e-001;
    __statist_i_h_wts[16,65]=-2.41862800799372e-001;
    __statist_i_h_wts[16,66]=-4.48810607918868e-001;
    __statist_i_h_wts[16,67]=-9.18011135319364e-002;
    __statist_i_h_wts[16,68]=-1.10302127366756e-001;
    __statist_i_h_wts[16,69]=-3.34927039784910e-001;
    __statist_i_h_wts[16,70]=-3.06785579921681e-001;
    __statist_i_h_wts[16,71]=-9.24759082860546e-002;
    __statist_i_h_wts[16,72]=-1.96911517576933e-001;
    __statist_i_h_wts[16,73]=-1.17267791538365e-001;
    __statist_i_h_wts[16,74]=-1.40726109583689e-002;
    __statist_i_h_wts[16,75]=-1.64972789719186e-001;
    __statist_i_h_wts[16,76]=-1.69680664556445e-001;
    __statist_i_h_wts[16,77]=-1.50654113791097e-001;
    __statist_i_h_wts[16,78]=-2.69930901368913e-001;
    __statist_i_h_wts[16,79]=-1.31831644067632e-001;
    __statist_i_h_wts[16,80]=-2.10772124907516e-001;
    __statist_i_h_wts[16,81]=-4.67837784205729e-001;
    __statist_i_h_wts[16,82]=-9.51825642774196e-002;
    __statist_i_h_wts[16,83]=-5.21497970968430e-003;
    __statist_i_h_wts[16,84]=-1.28535483442416e-001;
    __statist_i_h_wts[16,85]=-2.44851810746062e-001;
    __statist_i_h_wts[16,86]=-1.49958892549436e-001;
    __statist_i_h_wts[16,87]=-4.15134068637479e-001;
    __statist_i_h_wts[16,88]=-2.24055652123505e-001;
    __statist_i_h_wts[16,89]=-1.70584150897069e-001;
    __statist_i_h_wts[16,90]=2.10550882766406e-001;
    __statist_i_h_wts[16,91]=8.44281421062082e-002;
    __statist_i_h_wts[16,92]=1.54092859428619e-002;
    __statist_i_h_wts[16,93]=-6.84936336675371e-003;
    __statist_i_h_wts[16,94]=-2.01665432223830e-001;
    __statist_i_h_wts[16,95]=-2.13616513079506e-001;
    __statist_i_h_wts[16,96]=-2.11191396962512e-001;
    __statist_i_h_wts[16,97]=-1.12164887738137e-001;
    __statist_i_h_wts[16,98]=-6.62102524469635e-002;
    __statist_i_h_wts[16,99]=-1.60016213012476e-001;
    __statist_i_h_wts[16,100]=-3.97224286701137e-001;
    __statist_i_h_wts[16,101]=4.83543497496728e-002;
    __statist_i_h_wts[16,102]=-9.65613658691389e-002;
    __statist_i_h_wts[16,103]=-3.18586469529481e-002;
    __statist_i_h_wts[16,104]=7.06860061438568e-002;
    __statist_i_h_wts[16,105]=-3.12264349926223e-002;
    __statist_i_h_wts[16,106]=-2.83121356652184e-001;
    __statist_i_h_wts[16,107]=-1.61248686649854e-001;
    __statist_i_h_wts[16,108]=-1.99027101366932e-001;
    __statist_i_h_wts[16,109]=-3.43203205267021e-001;
    __statist_i_h_wts[16,110]=-1.97535076897636e-001;
    __statist_i_h_wts[16,111]=-3.09046789983881e-001;
    __statist_i_h_wts[16,112]=-3.09368656772936e-001;
    __statist_i_h_wts[16,113]=-2.17476799075385e-001;
    __statist_i_h_wts[16,114]=2.83038628914697e-002;
    __statist_i_h_wts[16,115]=1.47647613718467e-001;
    __statist_i_h_wts[16,116]=2.21319125521824e-001;
    __statist_i_h_wts[16,117]=-1.22072538464809e-001;
    __statist_i_h_wts[16,118]=-2.08811445884701e-001;
    __statist_i_h_wts[16,119]=5.71500402255589e-002;
    __statist_i_h_wts[16,120]=-1.93919858193537e-002;
    __statist_i_h_wts[16,121]=-5.32448453870781e-002;
    __statist_i_h_wts[16,122]=-2.50350852437834e-001;
    __statist_i_h_wts[16,123]=-1.42619695857987e-002;
    __statist_i_h_wts[16,124]=4.70953589411297e-001;
    __statist_i_h_wts[16,125]=2.22983162771925e-001;
    __statist_i_h_wts[16,126]=-1.36214744669777e-001;
    __statist_i_h_wts[16,127]=-2.00404062619700e-001;
    __statist_i_h_wts[16,128]=-4.14681716784513e-001;
    __statist_i_h_wts[16,129]=-1.37116096417493e-001;
    __statist_i_h_wts[16,130]=1.15527181456347e-002;
    __statist_i_h_wts[16,131]=5.34025399455064e-002;
    __statist_i_h_wts[16,132]=-4.48594848418721e-002;
    __statist_i_h_wts[16,133]=1.92764324559300e-001;
    __statist_i_h_wts[16,134]=1.04042568814106e-001;
    __statist_i_h_wts[16,135]=3.08791937966512e-001;
    __statist_i_h_wts[16,136]=1.35703363876495e-001;
    __statist_i_h_wts[16,137]=-6.91061347131477e-002;
    __statist_i_h_wts[16,138]=8.06528351448257e-002;
    __statist_i_h_wts[16,139]=5.37618383801338e-001;
    __statist_i_h_wts[16,140]=2.08622738975588e-001;
    __statist_i_h_wts[16,141]=9.69955464947972e-002;
    __statist_i_h_wts[16,142]=1.07115459084699e-001;
    __statist_i_h_wts[16,143]=7.59025903483948e-002;
    __statist_i_h_wts[16,144]=7.12391012338627e-002;
    __statist_i_h_wts[16,145]=9.64943920518648e-002;
    __statist_i_h_wts[16,146]=2.19896617282685e-001;
    __statist_i_h_wts[16,147]=2.35151641785332e-001;
    __statist_i_h_wts[16,148]=6.03654236248812e-002;
    __statist_i_h_wts[16,149]=-3.29629561576849e-002;
    __statist_i_h_wts[16,150]=1.24461801560672e-001;
    __statist_i_h_wts[16,151]=-5.76077134913159e-002;
    __statist_i_h_wts[16,152]=-8.17316328909334e-002;
    __statist_i_h_wts[16,153]=2.01543889230097e-001;
    __statist_i_h_wts[16,154]=3.68739722789929e-001;
    __statist_i_h_wts[16,155]=4.83087038748294e-001;
    __statist_i_h_wts[16,156]=3.71326545028853e-001;
    __statist_i_h_wts[16,157]=3.61598796767559e-001;
    __statist_i_h_wts[16,158]=1.02259378592127e-002;
    __statist_i_h_wts[16,159]=-3.63986533685257e-002;
    __statist_i_h_wts[16,160]=-1.80065902842292e-002;
    __statist_i_h_wts[16,161]=7.72692386705050e-002;
    __statist_i_h_wts[16,162]=1.46199854034197e-001;
    __statist_i_h_wts[16,163]=6.24590803583934e-002;
    __statist_i_h_wts[16,164]=-8.54768792263314e-003;
    __statist_i_h_wts[16,165]=2.13411706613264e-001;
    __statist_i_h_wts[16,166]=-5.78746731392512e-003;
    __statist_i_h_wts[16,167]=1.96916306028372e-001;
    __statist_i_h_wts[16,168]=2.34585687914994e-001;
    __statist_i_h_wts[16,169]=5.62270512807674e-001;
    __statist_i_h_wts[16,170]=4.87270555518701e-001;
    __statist_i_h_wts[16,171]=6.29910485281510e-002;
    __statist_i_h_wts[16,172]=3.78487250454145e-001;
    __statist_i_h_wts[16,173]=9.85935360563513e-002;
    __statist_i_h_wts[16,174]=4.36066545452551e-001;
    __statist_i_h_wts[16,175]=2.88047962858547e-001;
    __statist_i_h_wts[16,176]=4.01928311342070e-001;
    __statist_i_h_wts[16,177]=1.20357895560781e-001;
    __statist_i_h_wts[16,178]=2.85370616343257e-001;
    __statist_i_h_wts[16,179]=3.32616470569640e-001;
    __statist_i_h_wts[16,180]=-2.03660942053514e-001;
    __statist_i_h_wts[16,181]=3.30576073571806e-002;
    __statist_i_h_wts[16,182]=2.43547375499419e-001;
    __statist_i_h_wts[16,183]=-1.44259690292253e-001;
    __statist_i_h_wts[16,184]=-6.91591621497670e-002;
    __statist_i_h_wts[16,185]=-7.48396982528642e-002;
    __statist_i_h_wts[16,186]=1.99004749960448e-001;
    __statist_i_h_wts[16,187]=6.69760838294542e-001;
    __statist_i_h_wts[16,188]=1.63438594731642e-001;
    __statist_i_h_wts[16,189]=3.12423525850066e-001;
    __statist_i_h_wts[16,190]=1.06728894979659e-001;
    __statist_i_h_wts[16,191]=4.53508731884155e-001;
    __statist_i_h_wts[16,192]=4.17386936587604e-001;
    __statist_i_h_wts[16,193]=3.98026313204841e-001;
    __statist_i_h_wts[16,194]=2.84793492815602e-001;
    __statist_i_h_wts[16,195]=-1.70075768312570e-001;
    __statist_i_h_wts[16,196]=-3.32900907540357e-002;
    __statist_i_h_wts[16,197]=3.50659480957004e-001;
    __statist_i_h_wts[16,198]=1.73378779484296e-001;
    __statist_i_h_wts[16,199]=-1.45795030721351e-001;
    __statist_i_h_wts[16,200]=-7.97032517414019e-002;
    __statist_i_h_wts[16,201]=2.65781028695234e-001;
    __statist_i_h_wts[16,202]=4.04866275135868e-001;
    __statist_i_h_wts[16,203]=-2.26649335868054e-001;
    __statist_i_h_wts[16,204]=-1.36743884836416e-001;
    __statist_i_h_wts[16,205]=-1.53307086890747e-001;
    __statist_i_h_wts[16,206]=4.28991855757997e-002;
    __statist_i_h_wts[16,207]=2.50621185880627e-002;
    __statist_i_h_wts[16,208]=8.97752636145152e-002;
    __statist_i_h_wts[16,209]=6.03239763009326e-002;
    __statist_i_h_wts[16,210]=1.52752842746271e-001;
    __statist_i_h_wts[16,211]=1.03103736849944e-001;
    __statist_i_h_wts[16,212]=4.24720036022304e-001;
    __statist_i_h_wts[16,213]=7.87334166973875e-002;
    __statist_i_h_wts[16,214]=3.78756524646580e-002;
    __statist_i_h_wts[16,215]=8.33441664881510e-002;
    __statist_i_h_wts[16,216]=-2.07190323247019e-001;
    __statist_i_h_wts[16,217]=-1.08162975033921e-003;
    __statist_i_h_wts[16,218]=-3.81829947548425e-001;
    __statist_i_h_wts[16,219]=8.80122080933901e-002;
    __statist_i_h_wts[16,220]=2.57050313983117e-001;
    __statist_i_h_wts[16,221]=5.08829199356992e-001;
    __statist_i_h_wts[16,222]=3.75895775395370e-001;
    __statist_i_h_wts[16,223]=1.81350788726981e-001;
    __statist_i_h_wts[16,224]=1.74167868808598e-001;
    __statist_i_h_wts[16,225]=2.45803275903295e-001;
    __statist_i_h_wts[16,226]=-5.83244331733033e-001;
    __statist_i_h_wts[16,227]=2.10594293497426e-001;
    __statist_i_h_wts[16,228]=-9.35905937572529e-002;
    __statist_i_h_wts[16,229]=3.55446367707980e-001;
    __statist_i_h_wts[16,230]=1.13433561546972e+000;
    __statist_i_h_wts[16,231]=4.89885801919844e-001;
    __statist_i_h_wts[16,232]=1.16776220638244e+000;
    __statist_i_h_wts[16,233]=1.45974708395991e-002;
    __statist_i_h_wts[16,234]=1.12154706959887e+000;
    __statist_i_h_wts[16,235]=-2.51100719875352e-001;
    __statist_i_h_wts[16,236]=-6.00083932704888e-001;
    __statist_i_h_wts[16,237]=-9.82055628974715e-001;
    __statist_i_h_wts[16,238]=-1.51058894510598e-001;
    __statist_i_h_wts[16,239]=8.58196214634277e-001;
    __statist_i_h_wts[16,240]=-2.35944985549822e-001;
    __statist_i_h_wts[16,241]=2.73983498862908e-002;
    __statist_i_h_wts[16,242]=1.94868414505284e-001;
    __statist_i_h_wts[16,243]=2.35379271915512e-003;
    __statist_i_h_wts[16,244]=-3.25339042677527e-001;
    __statist_i_h_wts[16,245]=-1.23443066962103e+000;
    __statist_i_h_wts[16,246]=2.15438590804841e-001;
    __statist_i_h_wts[16,247]=-4.31711694144279e-001;
    __statist_i_h_wts[16,248]=4.39461702835810e-001;

    __statist_i_h_wts[17,0]=1.37715157013201e-001;
    __statist_i_h_wts[17,1]=-3.42594180629282e-002;
    __statist_i_h_wts[17,2]=-7.95262502499546e-002;
    __statist_i_h_wts[17,3]=8.16365815552062e-002;
    __statist_i_h_wts[17,4]=1.48970030419027e-001;
    __statist_i_h_wts[17,5]=1.96827024425787e-001;
    __statist_i_h_wts[17,6]=2.02002312800524e-001;
    __statist_i_h_wts[17,7]=2.12274231273578e-001;
    __statist_i_h_wts[17,8]=-1.76366910262417e-001;
    __statist_i_h_wts[17,9]=5.24349221995864e-002;
    __statist_i_h_wts[17,10]=1.75870747904683e-001;
    __statist_i_h_wts[17,11]=-1.53415677605404e-001;
    __statist_i_h_wts[17,12]=2.84780323892251e-002;
    __statist_i_h_wts[17,13]=1.88158976698293e-001;
    __statist_i_h_wts[17,14]=-2.13755592339692e-001;
    __statist_i_h_wts[17,15]=-1.20245269786861e-001;
    __statist_i_h_wts[17,16]=-3.33793150372372e-001;
    __statist_i_h_wts[17,17]=-4.51809492734315e-001;
    __statist_i_h_wts[17,18]=-2.01761682556223e-001;
    __statist_i_h_wts[17,19]=-2.94858055042161e-001;
    __statist_i_h_wts[17,20]=-3.63435395305234e-001;
    __statist_i_h_wts[17,21]=-1.80553105603826e-001;
    __statist_i_h_wts[17,22]=9.41517451706287e-002;
    __statist_i_h_wts[17,23]=-2.87322109260472e-001;
    __statist_i_h_wts[17,24]=-3.32538456394127e-001;
    __statist_i_h_wts[17,25]=-1.15510131520462e-001;
    __statist_i_h_wts[17,26]=-1.63489948018134e-001;
    __statist_i_h_wts[17,27]=-7.76741997777754e-002;
    __statist_i_h_wts[17,28]=8.04896941200542e-002;
    __statist_i_h_wts[17,29]=-2.27812397793728e-001;
    __statist_i_h_wts[17,30]=-4.90695755743301e-002;
    __statist_i_h_wts[17,31]=-3.95573482874128e-002;
    __statist_i_h_wts[17,32]=-5.06122343665012e-001;
    __statist_i_h_wts[17,33]=-1.38768582017120e-001;
    __statist_i_h_wts[17,34]=-2.65202474495012e-001;
    __statist_i_h_wts[17,35]=-3.11926156087682e-001;
    __statist_i_h_wts[17,36]=-1.85552330139601e-001;
    __statist_i_h_wts[17,37]=-2.21514545498500e-002;
    __statist_i_h_wts[17,38]=-3.82699043667751e-001;
    __statist_i_h_wts[17,39]=5.36851517679401e-002;
    __statist_i_h_wts[17,40]=-9.44905315830095e-002;
    __statist_i_h_wts[17,41]=-1.14992303207088e-001;
    __statist_i_h_wts[17,42]=-5.92381261149074e-002;
    __statist_i_h_wts[17,43]=6.60208279473534e-002;
    __statist_i_h_wts[17,44]=-3.10975282644486e-002;
    __statist_i_h_wts[17,45]=-5.10264965638919e-002;
    __statist_i_h_wts[17,46]=2.59770309140849e-001;
    __statist_i_h_wts[17,47]=1.55397605055245e-001;
    __statist_i_h_wts[17,48]=5.19158711208471e-002;
    __statist_i_h_wts[17,49]=-4.33775532775218e-001;
    __statist_i_h_wts[17,50]=-2.94609882393676e-001;
    __statist_i_h_wts[17,51]=4.24932472312776e-002;
    __statist_i_h_wts[17,52]=2.07628741010486e-001;
    __statist_i_h_wts[17,53]=-2.41170686014599e-002;
    __statist_i_h_wts[17,54]=-4.96940304487944e-002;
    __statist_i_h_wts[17,55]=7.58870144972146e-002;
    __statist_i_h_wts[17,56]=1.65736257659923e-001;
    __statist_i_h_wts[17,57]=1.08588666456713e-001;
    __statist_i_h_wts[17,58]=2.17048204384602e-001;
    __statist_i_h_wts[17,59]=3.53777907928398e-001;
    __statist_i_h_wts[17,60]=-9.68636395986648e-002;
    __statist_i_h_wts[17,61]=3.06279488447721e-001;
    __statist_i_h_wts[17,62]=-3.47469738818345e-002;
    __statist_i_h_wts[17,63]=-1.59325665633786e-001;
    __statist_i_h_wts[17,64]=-1.11224257093597e-001;
    __statist_i_h_wts[17,65]=-7.86778222219455e-003;
    __statist_i_h_wts[17,66]=1.09622791440675e-001;
    __statist_i_h_wts[17,67]=3.28436922948278e-001;
    __statist_i_h_wts[17,68]=3.92017318521064e-001;
    __statist_i_h_wts[17,69]=2.80567927008659e-001;
    __statist_i_h_wts[17,70]=-4.46343934814618e-002;
    __statist_i_h_wts[17,71]=-1.43178531165653e-001;
    __statist_i_h_wts[17,72]=2.01521068564222e-001;
    __statist_i_h_wts[17,73]=4.80721895098611e-002;
    __statist_i_h_wts[17,74]=-1.37127890400102e-001;
    __statist_i_h_wts[17,75]=-2.04088355375133e-001;
    __statist_i_h_wts[17,76]=-2.08774914880107e-002;
    __statist_i_h_wts[17,77]=-1.53231365663992e-001;
    __statist_i_h_wts[17,78]=-4.00252275040698e-001;
    __statist_i_h_wts[17,79]=-9.49108751228862e-002;
    __statist_i_h_wts[17,80]=-2.43375523864136e-001;
    __statist_i_h_wts[17,81]=9.58959002152961e-002;
    __statist_i_h_wts[17,82]=7.07681198169819e-002;
    __statist_i_h_wts[17,83]=1.29814956408294e-001;
    __statist_i_h_wts[17,84]=5.63730363283455e-002;
    __statist_i_h_wts[17,85]=-3.98460981925148e-001;
    __statist_i_h_wts[17,86]=6.73556847653245e-003;
    __statist_i_h_wts[17,87]=2.47931973304226e-001;
    __statist_i_h_wts[17,88]=5.74372290079869e-002;
    __statist_i_h_wts[17,89]=2.68675971995383e-001;
    __statist_i_h_wts[17,90]=-4.31371498364325e-001;
    __statist_i_h_wts[17,91]=-3.27425303605689e-001;
    __statist_i_h_wts[17,92]=-2.48324923685206e-002;
    __statist_i_h_wts[17,93]=-3.02187982502043e-001;
    __statist_i_h_wts[17,94]=4.99446305330034e-002;
    __statist_i_h_wts[17,95]=-5.51075155222994e-001;
    __statist_i_h_wts[17,96]=-1.64046890614559e-001;
    __statist_i_h_wts[17,97]=-1.12691870259492e-001;
    __statist_i_h_wts[17,98]=-2.21937342960582e-001;
    __statist_i_h_wts[17,99]=8.83835004257893e-002;
    __statist_i_h_wts[17,100]=-4.12992040539786e-001;
    __statist_i_h_wts[17,101]=-4.57863289101962e-001;
    __statist_i_h_wts[17,102]=1.07285051136520e-001;
    __statist_i_h_wts[17,103]=-9.32247857488970e-002;
    __statist_i_h_wts[17,104]=2.97217069974532e-002;
    __statist_i_h_wts[17,105]=1.06070967982079e-001;
    __statist_i_h_wts[17,106]=-3.69885056899875e-002;
    __statist_i_h_wts[17,107]=3.19103027839292e-001;
    __statist_i_h_wts[17,108]=4.57749301935812e-001;
    __statist_i_h_wts[17,109]=1.99153493964264e-001;
    __statist_i_h_wts[17,110]=3.07022238595302e-001;
    __statist_i_h_wts[17,111]=4.33212853715908e-001;
    __statist_i_h_wts[17,112]=-1.98305288897877e-001;
    __statist_i_h_wts[17,113]=2.34123741576497e-001;
    __statist_i_h_wts[17,114]=-1.08658291843997e-001;
    __statist_i_h_wts[17,115]=-3.39805059520945e-001;
    __statist_i_h_wts[17,116]=-1.50587808436849e-001;
    __statist_i_h_wts[17,117]=8.07674416335472e-002;
    __statist_i_h_wts[17,118]=-7.64036166923405e-002;
    __statist_i_h_wts[17,119]=1.21684456227408e-001;
    __statist_i_h_wts[17,120]=-2.12855989324206e-002;
    __statist_i_h_wts[17,121]=-1.38392089633625e-001;
    __statist_i_h_wts[17,122]=-9.37370706315983e-002;
    __statist_i_h_wts[17,123]=-5.37529137329316e-002;
    __statist_i_h_wts[17,124]=-3.03533775416349e-001;
    __statist_i_h_wts[17,125]=-1.89010192874176e-001;
    __statist_i_h_wts[17,126]=-7.24624795660596e-002;
    __statist_i_h_wts[17,127]=-3.51749180598838e-001;
    __statist_i_h_wts[17,128]=2.70295881617886e-001;
    __statist_i_h_wts[17,129]=3.08616070751393e-003;
    __statist_i_h_wts[17,130]=-1.40983729270347e-001;
    __statist_i_h_wts[17,131]=-1.45238626480808e-001;
    __statist_i_h_wts[17,132]=2.80907690615815e-001;
    __statist_i_h_wts[17,133]=2.37239924974504e-001;
    __statist_i_h_wts[17,134]=7.36884452477618e-002;
    __statist_i_h_wts[17,135]=-2.95126721959152e-001;
    __statist_i_h_wts[17,136]=-2.17377881174173e-001;
    __statist_i_h_wts[17,137]=-6.40459341395881e-002;
    __statist_i_h_wts[17,138]=-3.20130024103334e-002;
    __statist_i_h_wts[17,139]=-9.14765870519153e-002;
    __statist_i_h_wts[17,140]=2.19673773618388e-001;
    __statist_i_h_wts[17,141]=-1.44313179505095e-001;
    __statist_i_h_wts[17,142]=-2.99510312138455e-002;
    __statist_i_h_wts[17,143]=5.19591053145700e-002;
    __statist_i_h_wts[17,144]=1.34935848774605e-001;
    __statist_i_h_wts[17,145]=1.53262081773039e-001;
    __statist_i_h_wts[17,146]=-3.10876642348680e-002;
    __statist_i_h_wts[17,147]=-8.88946796906938e-002;
    __statist_i_h_wts[17,148]=9.47859833785076e-002;
    __statist_i_h_wts[17,149]=8.45701230134734e-002;
    __statist_i_h_wts[17,150]=2.68006989970699e-001;
    __statist_i_h_wts[17,151]=3.07342854005557e-001;
    __statist_i_h_wts[17,152]=3.08442090594443e-001;
    __statist_i_h_wts[17,153]=-1.73350982946662e-001;
    __statist_i_h_wts[17,154]=-8.18954254071132e-003;
    __statist_i_h_wts[17,155]=1.93390995497128e-001;
    __statist_i_h_wts[17,156]=-2.09200089179433e-001;
    __statist_i_h_wts[17,157]=-1.99133706565335e-001;
    __statist_i_h_wts[17,158]=4.23951541618490e-001;
    __statist_i_h_wts[17,159]=3.24730468403537e-001;
    __statist_i_h_wts[17,160]=8.36760123902222e-003;
    __statist_i_h_wts[17,161]=-5.49223567204568e-001;
    __statist_i_h_wts[17,162]=-1.08273969851984e-001;
    __statist_i_h_wts[17,163]=-3.97310755238773e-001;
    __statist_i_h_wts[17,164]=-6.19208997045494e-001;
    __statist_i_h_wts[17,165]=-1.75534304889492e-002;
    __statist_i_h_wts[17,166]=-7.04066243256071e-002;
    __statist_i_h_wts[17,167]=2.18381867177658e-002;
    __statist_i_h_wts[17,168]=7.72872727274339e-002;
    __statist_i_h_wts[17,169]=1.14591671990093e-001;
    __statist_i_h_wts[17,170]=2.16410671716628e-001;
    __statist_i_h_wts[17,171]=-2.97859284541065e-002;
    __statist_i_h_wts[17,172]=-3.27922778035708e-002;
    __statist_i_h_wts[17,173]=-3.05266643725352e-002;
    __statist_i_h_wts[17,174]=-1.98888371472318e-001;
    __statist_i_h_wts[17,175]=-2.05286573139816e-001;
    __statist_i_h_wts[17,176]=1.08952961012395e-001;
    __statist_i_h_wts[17,177]=1.94529511852597e-001;
    __statist_i_h_wts[17,178]=2.27568318732659e-001;
    __statist_i_h_wts[17,179]=2.53216977525929e-001;
    __statist_i_h_wts[17,180]=2.32961139086489e-002;
    __statist_i_h_wts[17,181]=2.50525915977643e-002;
    __statist_i_h_wts[17,182]=4.41763578747777e-002;
    __statist_i_h_wts[17,183]=-7.79550699990993e-002;
    __statist_i_h_wts[17,184]=5.48162474098151e-002;
    __statist_i_h_wts[17,185]=1.00668403938244e-001;
    __statist_i_h_wts[17,186]=4.69767526379481e-002;
    __statist_i_h_wts[17,187]=4.59148516599457e-003;
    __statist_i_h_wts[17,188]=-4.03314966593525e-003;
    __statist_i_h_wts[17,189]=-6.47291004490088e-002;
    __statist_i_h_wts[17,190]=-8.39768754945696e-002;
    __statist_i_h_wts[17,191]=-4.81767158499885e-002;
    __statist_i_h_wts[17,192]=1.74618081609533e-001;
    __statist_i_h_wts[17,193]=1.46557917075177e-001;
    __statist_i_h_wts[17,194]=1.66481154619960e-001;
    __statist_i_h_wts[17,195]=8.89397978028608e-002;
    __statist_i_h_wts[17,196]=8.62796344099126e-002;
    __statist_i_h_wts[17,197]=6.97016965278826e-002;
    __statist_i_h_wts[17,198]=-2.90767152567122e-003;
    __statist_i_h_wts[17,199]=2.95482946476011e-002;
    __statist_i_h_wts[17,200]=1.34988997341907e-001;
    __statist_i_h_wts[17,201]=1.00960196257092e-001;
    __statist_i_h_wts[17,202]=4.73339708396898e-002;
    __statist_i_h_wts[17,203]=-7.78608843031271e-002;
    __statist_i_h_wts[17,204]=-8.41659790628483e-002;
    __statist_i_h_wts[17,205]=-3.14859274137306e-002;
    __statist_i_h_wts[17,206]=-6.85146913451365e-002;
    __statist_i_h_wts[17,207]=-2.28751036171657e-001;
    __statist_i_h_wts[17,208]=-1.61848721641098e-001;
    __statist_i_h_wts[17,209]=-1.65517809391169e-001;
    __statist_i_h_wts[17,210]=-2.05237371259079e-002;
    __statist_i_h_wts[17,211]=2.35111181047289e-002;
    __statist_i_h_wts[17,212]=-3.48827924631496e-002;
    __statist_i_h_wts[17,213]=-1.22775812140177e-001;
    __statist_i_h_wts[17,214]=-4.05782424695028e-002;
    __statist_i_h_wts[17,215]=-2.25007624488270e-002;
    __statist_i_h_wts[17,216]=4.48461318900496e-002;
    __statist_i_h_wts[17,217]=-1.73864162058080e-001;
    __statist_i_h_wts[17,218]=-1.66689600481834e-001;
    __statist_i_h_wts[17,219]=-3.04221553154953e-002;
    __statist_i_h_wts[17,220]=-1.16441410930137e-002;
    __statist_i_h_wts[17,221]=-3.02708740078847e-002;
    __statist_i_h_wts[17,222]=1.00482652856259e-001;
    __statist_i_h_wts[17,223]=5.56134725165794e-003;
    __statist_i_h_wts[17,224]=-2.02776718735065e-003;
    __statist_i_h_wts[17,225]=1.38727262318320e-001;
    __statist_i_h_wts[17,226]=-2.24541545714227e-001;
    __statist_i_h_wts[17,227]=-1.81280076098062e-001;
    __statist_i_h_wts[17,228]=-2.96983386979844e-001;
    __statist_i_h_wts[17,229]=-8.13128426410556e-002;
    __statist_i_h_wts[17,230]=1.56043074724887e-001;
    __statist_i_h_wts[17,231]=-2.82878728841904e-002;
    __statist_i_h_wts[17,232]=4.30809960166372e-001;
    __statist_i_h_wts[17,233]=4.64028202945496e-001;
    __statist_i_h_wts[17,234]=6.58149310230407e-002;
    __statist_i_h_wts[17,235]=-3.70889405949334e-001;
    __statist_i_h_wts[17,236]=-2.04070400080023e-001;
    __statist_i_h_wts[17,237]=2.10984377171560e-001;
    __statist_i_h_wts[17,238]=5.12290802882396e-003;
    __statist_i_h_wts[17,239]=-1.97236225732409e-001;
    __statist_i_h_wts[17,240]=2.25519652613786e-001;
    __statist_i_h_wts[17,241]=-6.44358643054027e-001;
    __statist_i_h_wts[17,242]=-1.75293680914166e-002;
    __statist_i_h_wts[17,243]=-1.17789604114574e-001;
    __statist_i_h_wts[17,244]=-9.27300741576855e-002;
    __statist_i_h_wts[17,245]=-2.84482725269717e-001;
    __statist_i_h_wts[17,246]=-9.40597535589842e-002;
    __statist_i_h_wts[17,247]=5.18209893564342e-002;
    __statist_i_h_wts[17,248]=-9.78451083853962e-002;

    __statist_i_h_wts[18,0]=4.56041912968745e-003;
    __statist_i_h_wts[18,1]=2.71059548170435e-002;
    __statist_i_h_wts[18,2]=3.27847497932143e-002;
    __statist_i_h_wts[18,3]=9.78831602034261e-003;
    __statist_i_h_wts[18,4]=4.40464853916274e-003;
    __statist_i_h_wts[18,5]=-4.70481304980134e-003;
    __statist_i_h_wts[18,6]=2.35479650464707e-002;
    __statist_i_h_wts[18,7]=2.10386025699317e-002;
    __statist_i_h_wts[18,8]=1.84283474743186e-002;
    __statist_i_h_wts[18,9]=2.34477171224446e-002;
    __statist_i_h_wts[18,10]=2.48061247900020e-002;
    __statist_i_h_wts[18,11]=-1.67297278357874e-002;
    __statist_i_h_wts[18,12]=-5.88174456368936e-003;
    __statist_i_h_wts[18,13]=-1.70494113484170e-002;
    __statist_i_h_wts[18,14]=-3.20876205235670e-002;
    __statist_i_h_wts[18,15]=1.95208071315291e-002;
    __statist_i_h_wts[18,16]=1.92830631607975e-002;
    __statist_i_h_wts[18,17]=1.47821394577535e-002;
    __statist_i_h_wts[18,18]=1.41022137252206e-002;
    __statist_i_h_wts[18,19]=1.01351273689822e-002;
    __statist_i_h_wts[18,20]=4.94694387268209e-003;
    __statist_i_h_wts[18,21]=3.27873098011321e-002;
    __statist_i_h_wts[18,22]=2.10111976166328e-002;
    __statist_i_h_wts[18,23]=3.14144193889274e-002;
    __statist_i_h_wts[18,24]=2.76257766913177e-002;
    __statist_i_h_wts[18,25]=3.46346001771673e-002;
    __statist_i_h_wts[18,26]=9.35306611958621e-003;
    __statist_i_h_wts[18,27]=-6.56621297767425e-003;
    __statist_i_h_wts[18,28]=-9.50567138483756e-003;
    __statist_i_h_wts[18,29]=-2.61328247531663e-002;
    __statist_i_h_wts[18,30]=2.88001002757262e-002;
    __statist_i_h_wts[18,31]=2.03417398479350e-002;
    __statist_i_h_wts[18,32]=1.99867705146501e-002;
    __statist_i_h_wts[18,33]=2.03171533082491e-002;
    __statist_i_h_wts[18,34]=2.56538364509475e-002;
    __statist_i_h_wts[18,35]=2.11639400337033e-002;
    __statist_i_h_wts[18,36]=3.83956942423414e-002;
    __statist_i_h_wts[18,37]=3.01787310431003e-002;
    __statist_i_h_wts[18,38]=2.23316270756311e-002;
    __statist_i_h_wts[18,39]=2.51634018427198e-002;
    __statist_i_h_wts[18,40]=2.12193709418016e-002;
    __statist_i_h_wts[18,41]=-2.93639106389452e-003;
    __statist_i_h_wts[18,42]=7.80321684913842e-003;
    __statist_i_h_wts[18,43]=-1.21885047310840e-002;
    __statist_i_h_wts[18,44]=-3.43590263749307e-002;
    __statist_i_h_wts[18,45]=3.59342282968269e-002;
    __statist_i_h_wts[18,46]=3.51343460917012e-002;
    __statist_i_h_wts[18,47]=3.66036658605454e-002;
    __statist_i_h_wts[18,48]=4.02370968170897e-002;
    __statist_i_h_wts[18,49]=3.67546498219262e-002;
    __statist_i_h_wts[18,50]=2.67726827953215e-002;
    __statist_i_h_wts[18,51]=2.91039418428857e-002;
    __statist_i_h_wts[18,52]=3.49892254335082e-002;
    __statist_i_h_wts[18,53]=2.91524745871175e-002;
    __statist_i_h_wts[18,54]=3.88135579224408e-002;
    __statist_i_h_wts[18,55]=2.64125334444454e-002;
    __statist_i_h_wts[18,56]=9.35797616771631e-003;
    __statist_i_h_wts[18,57]=5.05355518646319e-003;
    __statist_i_h_wts[18,58]=-1.40214640426975e-003;
    __statist_i_h_wts[18,59]=-3.71088797627301e-002;
    __statist_i_h_wts[18,60]=1.38456854309913e-002;
    __statist_i_h_wts[18,61]=1.20222958613866e-002;
    __statist_i_h_wts[18,62]=1.44332563318437e-002;
    __statist_i_h_wts[18,63]=2.51229230446798e-002;
    __statist_i_h_wts[18,64]=1.84877087992729e-002;
    __statist_i_h_wts[18,65]=5.93608400415705e-003;
    __statist_i_h_wts[18,66]=3.29016463485538e-003;
    __statist_i_h_wts[18,67]=1.33444288929179e-002;
    __statist_i_h_wts[18,68]=1.84539197394095e-002;
    __statist_i_h_wts[18,69]=2.52686375337735e-002;
    __statist_i_h_wts[18,70]=3.90392202454038e-002;
    __statist_i_h_wts[18,71]=1.67799485425763e-002;
    __statist_i_h_wts[18,72]=1.94190099509418e-002;
    __statist_i_h_wts[18,73]=-1.07054704987253e-002;
    __statist_i_h_wts[18,74]=-1.66554392375065e-002;
    __statist_i_h_wts[18,75]=-7.49312694496967e-003;
    __statist_i_h_wts[18,76]=-1.91000029910052e-003;
    __statist_i_h_wts[18,77]=-5.35343750473817e-003;
    __statist_i_h_wts[18,78]=4.96034510905724e-003;
    __statist_i_h_wts[18,79]=-1.49642264155256e-003;
    __statist_i_h_wts[18,80]=2.77395856530968e-003;
    __statist_i_h_wts[18,81]=2.02867169033211e-003;
    __statist_i_h_wts[18,82]=5.33054547137159e-003;
    __statist_i_h_wts[18,83]=-8.87481825662432e-003;
    __statist_i_h_wts[18,84]=1.30264228948518e-002;
    __statist_i_h_wts[18,85]=2.53943391802237e-002;
    __statist_i_h_wts[18,86]=1.24897076722225e-003;
    __statist_i_h_wts[18,87]=9.87701950643794e-003;
    __statist_i_h_wts[18,88]=-1.22403252265727e-002;
    __statist_i_h_wts[18,89]=-4.41610062539515e-002;
    __statist_i_h_wts[18,90]=-1.74953289639455e-002;
    __statist_i_h_wts[18,91]=-2.65624827766756e-002;
    __statist_i_h_wts[18,92]=9.09703295983552e-004;
    __statist_i_h_wts[18,93]=-4.33513608137661e-003;
    __statist_i_h_wts[18,94]=-8.84998128501268e-003;
    __statist_i_h_wts[18,95]=-2.97303676241794e-003;
    __statist_i_h_wts[18,96]=-3.50501456822803e-003;
    __statist_i_h_wts[18,97]=2.58435590297089e-003;
    __statist_i_h_wts[18,98]=1.76521773131755e-004;
    __statist_i_h_wts[18,99]=2.55891050747975e-002;
    __statist_i_h_wts[18,100]=2.06957332626013e-002;
    __statist_i_h_wts[18,101]=4.38714092556864e-003;
    __statist_i_h_wts[18,102]=1.60872588326469e-003;
    __statist_i_h_wts[18,103]=-2.58083872699391e-002;
    __statist_i_h_wts[18,104]=-3.44574956910737e-002;
    __statist_i_h_wts[18,105]=-2.91370541554301e-002;
    __statist_i_h_wts[18,106]=-3.25873102970185e-002;
    __statist_i_h_wts[18,107]=-3.84033536661923e-002;
    __statist_i_h_wts[18,108]=-3.57953373847535e-002;
    __statist_i_h_wts[18,109]=-4.28523572013643e-002;
    __statist_i_h_wts[18,110]=-3.60532837374603e-002;
    __statist_i_h_wts[18,111]=-4.14335075495138e-002;
    __statist_i_h_wts[18,112]=-3.74427481762741e-002;
    __statist_i_h_wts[18,113]=-2.16487875336237e-002;
    __statist_i_h_wts[18,114]=-1.87367580281748e-002;
    __statist_i_h_wts[18,115]=-3.97807146952608e-003;
    __statist_i_h_wts[18,116]=-1.66929396071318e-002;
    __statist_i_h_wts[18,117]=-2.70695754565589e-002;
    __statist_i_h_wts[18,118]=-4.32539177482323e-002;
    __statist_i_h_wts[18,119]=-5.89173181660931e-002;
    __statist_i_h_wts[18,120]=-6.57862977114350e-002;
    __statist_i_h_wts[18,121]=-7.28972028088904e-002;
    __statist_i_h_wts[18,122]=-6.74760575619758e-002;
    __statist_i_h_wts[18,123]=-5.31666738915188e-002;
    __statist_i_h_wts[18,124]=-6.87322198692408e-002;
    __statist_i_h_wts[18,125]=-5.82656771607632e-002;
    __statist_i_h_wts[18,126]=-6.45535513631211e-002;
    __statist_i_h_wts[18,127]=-5.81471370092969e-002;
    __statist_i_h_wts[18,128]=-4.69727132362104e-002;
    __statist_i_h_wts[18,129]=-4.39021486178618e-002;
    __statist_i_h_wts[18,130]=-5.11894257740089e-002;
    __statist_i_h_wts[18,131]=-3.47935294037382e-002;
    __statist_i_h_wts[18,132]=-3.65767642113137e-002;
    __statist_i_h_wts[18,133]=-5.41767365799941e-002;
    __statist_i_h_wts[18,134]=-5.44029560292438e-002;
    __statist_i_h_wts[18,135]=-5.08245067309859e-002;
    __statist_i_h_wts[18,136]=-7.89174348635138e-002;
    __statist_i_h_wts[18,137]=-7.69772794565315e-002;
    __statist_i_h_wts[18,138]=-6.60460834471810e-002;
    __statist_i_h_wts[18,139]=-8.00662750658215e-002;
    __statist_i_h_wts[18,140]=-8.24620384319542e-002;
    __statist_i_h_wts[18,141]=-8.24334726816251e-002;
    __statist_i_h_wts[18,142]=-7.19179484555593e-002;
    __statist_i_h_wts[18,143]=-8.07391453211871e-002;
    __statist_i_h_wts[18,144]=-7.89565548302685e-002;
    __statist_i_h_wts[18,145]=-5.22594145795062e-002;
    __statist_i_h_wts[18,146]=-3.36944340609648e-002;
    __statist_i_h_wts[18,147]=-3.16376785572802e-002;
    __statist_i_h_wts[18,148]=-5.60207712244009e-002;
    __statist_i_h_wts[18,149]=-4.71955050807221e-002;
    __statist_i_h_wts[18,150]=-5.10885764778109e-002;
    __statist_i_h_wts[18,151]=-7.97787525930004e-002;
    __statist_i_h_wts[18,152]=-6.33720653198003e-002;
    __statist_i_h_wts[18,153]=-8.44310205984798e-002;
    __statist_i_h_wts[18,154]=-9.14793046721600e-002;
    __statist_i_h_wts[18,155]=-9.19317174949062e-002;
    __statist_i_h_wts[18,156]=-8.83548793474077e-002;
    __statist_i_h_wts[18,157]=-8.84221150773552e-002;
    __statist_i_h_wts[18,158]=-6.36806414935648e-002;
    __statist_i_h_wts[18,159]=-6.65086230567204e-002;
    __statist_i_h_wts[18,160]=-5.59745976602384e-002;
    __statist_i_h_wts[18,161]=-6.45815958830690e-002;
    __statist_i_h_wts[18,162]=-5.79319913860193e-002;
    __statist_i_h_wts[18,163]=-7.96769468578638e-002;
    __statist_i_h_wts[18,164]=-6.75181635379319e-002;
    __statist_i_h_wts[18,165]=-7.76192123187209e-002;
    __statist_i_h_wts[18,166]=-7.93883942552990e-002;
    __statist_i_h_wts[18,167]=-7.28677739734556e-002;
    __statist_i_h_wts[18,168]=-8.74315314509613e-002;
    __statist_i_h_wts[18,169]=-1.02888380969438e-001;
    __statist_i_h_wts[18,170]=-1.19095298168243e-001;
    __statist_i_h_wts[18,171]=-1.13217837406691e-001;
    __statist_i_h_wts[18,172]=-1.01438411625177e-001;
    __statist_i_h_wts[18,173]=-9.65751407660650e-002;
    __statist_i_h_wts[18,174]=-9.05623189888610e-002;
    __statist_i_h_wts[18,175]=-8.85842587989917e-002;
    __statist_i_h_wts[18,176]=-7.15249141942789e-002;
    __statist_i_h_wts[18,177]=-8.01825837207138e-002;
    __statist_i_h_wts[18,178]=-7.96501597235437e-002;
    __statist_i_h_wts[18,179]=-7.34904681920015e-002;
    __statist_i_h_wts[18,180]=-1.00633592773666e-001;
    __statist_i_h_wts[18,181]=-9.60225218510811e-002;
    __statist_i_h_wts[18,182]=-8.94137336241615e-002;
    __statist_i_h_wts[18,183]=-1.11583000869653e-001;
    __statist_i_h_wts[18,184]=-1.14835520389326e-001;
    __statist_i_h_wts[18,185]=-1.13335211190097e-001;
    __statist_i_h_wts[18,186]=-1.25608942843571e-001;
    __statist_i_h_wts[18,187]=-1.21815096084310e-001;
    __statist_i_h_wts[18,188]=-8.97073632052158e-002;
    __statist_i_h_wts[18,189]=-1.03429471074462e-001;
    __statist_i_h_wts[18,190]=-1.04130910573326e-001;
    __statist_i_h_wts[18,191]=-9.22944149341899e-002;
    __statist_i_h_wts[18,192]=-8.86457770040665e-002;
    __statist_i_h_wts[18,193]=-1.00782545632600e-001;
    __statist_i_h_wts[18,194]=-9.81940537427700e-002;
    __statist_i_h_wts[18,195]=-9.67163091418154e-002;
    __statist_i_h_wts[18,196]=-1.05836061014378e-001;
    __statist_i_h_wts[18,197]=-8.21236612842677e-002;
    __statist_i_h_wts[18,198]=-9.84215118824757e-002;
    __statist_i_h_wts[18,199]=-1.10970894405692e-001;
    __statist_i_h_wts[18,200]=-8.93064671332065e-002;
    __statist_i_h_wts[18,201]=-1.15043421055914e-001;
    __statist_i_h_wts[18,202]=-1.27684933908030e-001;
    __statist_i_h_wts[18,203]=-1.18995980709720e-001;
    __statist_i_h_wts[18,204]=-1.14998718549532e-001;
    __statist_i_h_wts[18,205]=-1.19867988269536e-001;
    __statist_i_h_wts[18,206]=-9.44374607478109e-002;
    __statist_i_h_wts[18,207]=-9.73661361743794e-002;
    __statist_i_h_wts[18,208]=-9.93177971360310e-002;
    __statist_i_h_wts[18,209]=-9.58731659431973e-002;
    __statist_i_h_wts[18,210]=-8.58744160017638e-002;
    __statist_i_h_wts[18,211]=-1.00941387939707e-001;
    __statist_i_h_wts[18,212]=-9.64589257579156e-002;
    __statist_i_h_wts[18,213]=-8.87391463230017e-002;
    __statist_i_h_wts[18,214]=-1.06176540563331e-001;
    __statist_i_h_wts[18,215]=-9.20100006306454e-002;
    __statist_i_h_wts[18,216]=-1.05902463274864e-001;
    __statist_i_h_wts[18,217]=-1.18873451640576e-001;
    __statist_i_h_wts[18,218]=-1.21551968731948e-001;
    __statist_i_h_wts[18,219]=-1.04032365057597e-001;
    __statist_i_h_wts[18,220]=-9.74353105659418e-002;
    __statist_i_h_wts[18,221]=-9.22523973978903e-002;
    __statist_i_h_wts[18,222]=-8.44505887728859e-002;
    __statist_i_h_wts[18,223]=-1.09618313662870e-001;
    __statist_i_h_wts[18,224]=-9.70584506368436e-002;
    __statist_i_h_wts[18,225]=6.68088297095179e-003;
    __statist_i_h_wts[18,226]=8.83781773181223e-002;
    __statist_i_h_wts[18,227]=-8.24206569117126e-003;
    __statist_i_h_wts[18,228]=8.37854945962983e-002;
    __statist_i_h_wts[18,229]=-1.91061279185987e-002;
    __statist_i_h_wts[18,230]=-1.29108083519495e-001;
    __statist_i_h_wts[18,231]=-2.49957496105887e-002;
    __statist_i_h_wts[18,232]=-1.29060372746921e-001;
    __statist_i_h_wts[18,233]=-5.93308685426354e-002;
    __statist_i_h_wts[18,234]=-1.55566298946088e-001;
    __statist_i_h_wts[18,235]=3.44917045473260e-002;
    __statist_i_h_wts[18,236]=1.34652971376355e-001;
    __statist_i_h_wts[18,237]=1.57031204952315e-001;
    __statist_i_h_wts[18,238]=2.39260950897514e-002;
    __statist_i_h_wts[18,239]=-1.30002764353486e-001;
    __statist_i_h_wts[18,240]=2.71912557392453e-002;
    __statist_i_h_wts[18,241]=-3.21384130228862e-001;
    __statist_i_h_wts[18,242]=-1.32861370921157e-002;
    __statist_i_h_wts[18,243]=-1.53145935759315e-001;
    __statist_i_h_wts[18,244]=-1.12442494418427e-002;
    __statist_i_h_wts[18,245]=1.73279367031823e-001;
    __statist_i_h_wts[18,246]=-8.87644377931973e-002;
    __statist_i_h_wts[18,247]=1.13570525443804e-001;
    __statist_i_h_wts[18,248]=-6.22428384735161e-002;

    __statist_i_h_wts[19,0]=-9.50198736023170e-001;
    __statist_i_h_wts[19,1]=-9.50698207115891e-001;
    __statist_i_h_wts[19,2]=-8.81434106170008e-001;
    __statist_i_h_wts[19,3]=-8.59620924870122e-001;
    __statist_i_h_wts[19,4]=-7.50310870528781e-001;
    __statist_i_h_wts[19,5]=-6.03579943312537e-001;
    __statist_i_h_wts[19,6]=-7.07533422143602e-001;
    __statist_i_h_wts[19,7]=-5.61800278885996e-001;
    __statist_i_h_wts[19,8]=-4.32142515855975e-001;
    __statist_i_h_wts[19,9]=-7.24267781441460e-001;
    __statist_i_h_wts[19,10]=-6.62911448687121e-001;
    __statist_i_h_wts[19,11]=-4.70790752339710e-001;
    __statist_i_h_wts[19,12]=-2.59513361515886e-001;
    __statist_i_h_wts[19,13]=-2.79042567100782e-001;
    __statist_i_h_wts[19,14]=-6.17766821076857e-002;
    __statist_i_h_wts[19,15]=-1.05906356948509e+000;
    __statist_i_h_wts[19,16]=-1.01998218497312e+000;
    __statist_i_h_wts[19,17]=-9.34861270435166e-001;
    __statist_i_h_wts[19,18]=-8.69302647388875e-001;
    __statist_i_h_wts[19,19]=-8.28025970831434e-001;
    __statist_i_h_wts[19,20]=-5.87377700597075e-001;
    __statist_i_h_wts[19,21]=-8.32301364844941e-001;
    __statist_i_h_wts[19,22]=-6.93729255179996e-001;
    __statist_i_h_wts[19,23]=-7.34826815144786e-001;
    __statist_i_h_wts[19,24]=-1.05362015503571e+000;
    __statist_i_h_wts[19,25]=-9.61729433382281e-001;
    __statist_i_h_wts[19,26]=-7.25366470342949e-001;
    __statist_i_h_wts[19,27]=-6.01127991129785e-001;
    __statist_i_h_wts[19,28]=-5.17373574147756e-001;
    __statist_i_h_wts[19,29]=-1.40469973010691e-001;
    __statist_i_h_wts[19,30]=-9.42890086364352e-001;
    __statist_i_h_wts[19,31]=-9.89305426705750e-001;
    __statist_i_h_wts[19,32]=-9.42530838994996e-001;
    __statist_i_h_wts[19,33]=-9.58785761097682e-001;
    __statist_i_h_wts[19,34]=-1.08716464686116e+000;
    __statist_i_h_wts[19,35]=-7.35530376784877e-001;
    __statist_i_h_wts[19,36]=-1.08300416165431e+000;
    __statist_i_h_wts[19,37]=-8.20063371437735e-001;
    __statist_i_h_wts[19,38]=-8.10287489157019e-001;
    __statist_i_h_wts[19,39]=-1.16799409475410e+000;
    __statist_i_h_wts[19,40]=-8.40879433405167e-001;
    __statist_i_h_wts[19,41]=-6.07290995765657e-001;
    __statist_i_h_wts[19,42]=-4.82246735866305e-001;
    __statist_i_h_wts[19,43]=-4.46120576887964e-001;
    __statist_i_h_wts[19,44]=-1.73242781927815e-001;
    __statist_i_h_wts[19,45]=-9.55526913423736e-001;
    __statist_i_h_wts[19,46]=-1.06536434063026e+000;
    __statist_i_h_wts[19,47]=-9.88488732281974e-001;
    __statist_i_h_wts[19,48]=-1.12259614964687e+000;
    __statist_i_h_wts[19,49]=-1.10940005582162e+000;
    __statist_i_h_wts[19,50]=-8.71727352749795e-001;
    __statist_i_h_wts[19,51]=-8.20793568657837e-001;
    __statist_i_h_wts[19,52]=-8.72851413549013e-001;
    __statist_i_h_wts[19,53]=-7.22675359738622e-001;
    __statist_i_h_wts[19,54]=-1.09881696801709e+000;
    __statist_i_h_wts[19,55]=-8.48176958150547e-001;
    __statist_i_h_wts[19,56]=-3.93625226122360e-001;
    __statist_i_h_wts[19,57]=-2.70455350951501e-001;
    __statist_i_h_wts[19,58]=-1.12400842454406e-001;
    __statist_i_h_wts[19,59]=5.46390575151579e-002;
    __statist_i_h_wts[19,60]=-7.34416172482845e-001;
    __statist_i_h_wts[19,61]=-7.32307441793467e-001;
    __statist_i_h_wts[19,62]=-7.10449951509537e-001;
    __statist_i_h_wts[19,63]=-7.03774364132038e-001;
    __statist_i_h_wts[19,64]=-6.09724520744453e-001;
    __statist_i_h_wts[19,65]=-3.40025070292454e-001;
    __statist_i_h_wts[19,66]=-3.37775311401855e-001;
    __statist_i_h_wts[19,67]=-4.63797045323701e-001;
    __statist_i_h_wts[19,68]=-4.16624398707338e-001;
    __statist_i_h_wts[19,69]=-8.74408978962090e-001;
    __statist_i_h_wts[19,70]=-1.02009676971738e+000;
    __statist_i_h_wts[19,71]=-6.69701299038809e-001;
    __statist_i_h_wts[19,72]=-5.50620556352745e-001;
    __statist_i_h_wts[19,73]=-1.32956436006363e-001;
    __statist_i_h_wts[19,74]=3.84734364498747e-002;
    __statist_i_h_wts[19,75]=-4.71007452362400e-001;
    __statist_i_h_wts[19,76]=-5.12714703415221e-001;
    __statist_i_h_wts[19,77]=-4.97543949222389e-001;
    __statist_i_h_wts[19,78]=-5.66398243411735e-001;
    __statist_i_h_wts[19,79]=-4.54380248181603e-001;
    __statist_i_h_wts[19,80]=-4.56743672162159e-001;
    __statist_i_h_wts[19,81]=-3.13674482947064e-001;
    __statist_i_h_wts[19,82]=-4.16687282766966e-001;
    __statist_i_h_wts[19,83]=-3.34801715371126e-001;
    __statist_i_h_wts[19,84]=-7.19728690697866e-001;
    __statist_i_h_wts[19,85]=-7.45566942529281e-001;
    __statist_i_h_wts[19,86]=-6.11432659472105e-001;
    __statist_i_h_wts[19,87]=-5.85003581861311e-001;
    __statist_i_h_wts[19,88]=-1.33874161143898e-001;
    __statist_i_h_wts[19,89]=9.80899899176372e-002;
    __statist_i_h_wts[19,90]=-2.12649406966931e-001;
    __statist_i_h_wts[19,91]=-2.85193414734991e-001;
    __statist_i_h_wts[19,92]=-5.77523467923212e-001;
    __statist_i_h_wts[19,93]=-4.26668824816680e-001;
    __statist_i_h_wts[19,94]=-3.70837141291742e-001;
    __statist_i_h_wts[19,95]=-3.63536576673583e-001;
    __statist_i_h_wts[19,96]=-1.84041059292577e-001;
    __statist_i_h_wts[19,97]=-2.80904545870123e-001;
    __statist_i_h_wts[19,98]=-1.69181286945302e-001;
    __statist_i_h_wts[19,99]=-5.50679569148635e-001;
    __statist_i_h_wts[19,100]=-4.93363284470133e-001;
    __statist_i_h_wts[19,101]=-4.07026400778749e-001;
    __statist_i_h_wts[19,102]=-4.56380963515725e-001;
    __statist_i_h_wts[19,103]=7.34324379537567e-002;
    __statist_i_h_wts[19,104]=2.06832033779877e-001;
    __statist_i_h_wts[19,105]=-3.18419038637048e-002;
    __statist_i_h_wts[19,106]=-4.80603228703392e-002;
    __statist_i_h_wts[19,107]=-5.18435387095726e-002;
    __statist_i_h_wts[19,108]=1.45650121945520e-001;
    __statist_i_h_wts[19,109]=2.42103939991693e-001;
    __statist_i_h_wts[19,110]=1.24010760683055e-001;
    __statist_i_h_wts[19,111]=2.28517856126968e-001;
    __statist_i_h_wts[19,112]=3.28034159273947e-002;
    __statist_i_h_wts[19,113]=2.75380059364249e-002;
    __statist_i_h_wts[19,114]=-1.25111523909095e-001;
    __statist_i_h_wts[19,115]=-2.97648158239149e-001;
    __statist_i_h_wts[19,116]=-2.04546238412855e-001;
    __statist_i_h_wts[19,117]=-2.59051579937393e-001;
    __statist_i_h_wts[19,118]=3.63494032512510e-001;
    __statist_i_h_wts[19,119]=3.02474926662111e-001;
    __statist_i_h_wts[19,120]=4.01712598550438e-001;
    __statist_i_h_wts[19,121]=3.79740914544129e-001;
    __statist_i_h_wts[19,122]=1.88662801969902e-001;
    __statist_i_h_wts[19,123]=2.63004133941073e-001;
    __statist_i_h_wts[19,124]=2.48172021615483e-001;
    __statist_i_h_wts[19,125]=3.36617551159637e-001;
    __statist_i_h_wts[19,126]=2.42631740726918e-001;
    __statist_i_h_wts[19,127]=2.32674356390409e-001;
    __statist_i_h_wts[19,128]=1.35227959914189e-001;
    __statist_i_h_wts[19,129]=-1.37657359319147e-001;
    __statist_i_h_wts[19,130]=-3.98995759239892e-003;
    __statist_i_h_wts[19,131]=2.60089657844119e-002;
    __statist_i_h_wts[19,132]=-9.57795175478160e-002;
    __statist_i_h_wts[19,133]=3.17510194613674e-001;
    __statist_i_h_wts[19,134]=3.53219199223429e-001;
    __statist_i_h_wts[19,135]=2.99791398764339e-001;
    __statist_i_h_wts[19,136]=5.36161212047507e-001;
    __statist_i_h_wts[19,137]=3.73663120017954e-001;
    __statist_i_h_wts[19,138]=5.52036836944767e-001;
    __statist_i_h_wts[19,139]=4.37905300889213e-001;
    __statist_i_h_wts[19,140]=7.68497989302329e-001;
    __statist_i_h_wts[19,141]=5.63504425424640e-001;
    __statist_i_h_wts[19,142]=4.51851999827903e-001;
    __statist_i_h_wts[19,143]=3.81461624000503e-001;
    __statist_i_h_wts[19,144]=1.41882657860866e-001;
    __statist_i_h_wts[19,145]=1.46548484001543e-003;
    __statist_i_h_wts[19,146]=-6.10327256354843e-003;
    __statist_i_h_wts[19,147]=-1.59531795036275e-001;
    __statist_i_h_wts[19,148]=1.28284664366728e-001;
    __statist_i_h_wts[19,149]=1.52992830375828e-001;
    __statist_i_h_wts[19,150]=6.65585874197498e-002;
    __statist_i_h_wts[19,151]=2.08882209676654e-001;
    __statist_i_h_wts[19,152]=1.13259427556612e-001;
    __statist_i_h_wts[19,153]=4.83180784152146e-001;
    __statist_i_h_wts[19,154]=5.49925572424653e-001;
    __statist_i_h_wts[19,155]=8.01676905883319e-001;
    __statist_i_h_wts[19,156]=6.12100603519372e-001;
    __statist_i_h_wts[19,157]=5.43320964662343e-001;
    __statist_i_h_wts[19,158]=1.93040507208067e-001;
    __statist_i_h_wts[19,159]=1.39853780263996e-001;
    __statist_i_h_wts[19,160]=2.45865694646775e-001;
    __statist_i_h_wts[19,161]=2.39043398568566e-001;
    __statist_i_h_wts[19,162]=1.50603721338098e-001;
    __statist_i_h_wts[19,163]=3.77710973928393e-001;
    __statist_i_h_wts[19,164]=3.44550630869345e-001;
    __statist_i_h_wts[19,165]=2.38692682254327e-001;
    __statist_i_h_wts[19,166]=4.45685085309105e-001;
    __statist_i_h_wts[19,167]=3.89563992653534e-001;
    __statist_i_h_wts[19,168]=5.17018958075776e-001;
    __statist_i_h_wts[19,169]=6.85429047508819e-001;
    __statist_i_h_wts[19,170]=8.23838865560261e-001;
    __statist_i_h_wts[19,171]=7.58761506524886e-001;
    __statist_i_h_wts[19,172]=7.75222854588473e-001;
    __statist_i_h_wts[19,173]=5.55404146786820e-001;
    __statist_i_h_wts[19,174]=3.77215623027155e-001;
    __statist_i_h_wts[19,175]=3.28135575988453e-001;
    __statist_i_h_wts[19,176]=3.07711324512297e-001;
    __statist_i_h_wts[19,177]=2.35602051349669e-001;
    __statist_i_h_wts[19,178]=4.80996911007398e-001;
    __statist_i_h_wts[19,179]=3.01197591469475e-001;
    __statist_i_h_wts[19,180]=6.06284573675831e-001;
    __statist_i_h_wts[19,181]=6.08694757952135e-001;
    __statist_i_h_wts[19,182]=5.52925139853154e-001;
    __statist_i_h_wts[19,183]=7.52775431056789e-001;
    __statist_i_h_wts[19,184]=7.25524065385983e-001;
    __statist_i_h_wts[19,185]=8.39919292903090e-001;
    __statist_i_h_wts[19,186]=9.16637792973797e-001;
    __statist_i_h_wts[19,187]=9.75185210208015e-001;
    __statist_i_h_wts[19,188]=6.76134688336702e-001;
    __statist_i_h_wts[19,189]=5.70744141015202e-001;
    __statist_i_h_wts[19,190]=4.96276975906951e-001;
    __statist_i_h_wts[19,191]=4.10901512855502e-001;
    __statist_i_h_wts[19,192]=3.39678417362614e-001;
    __statist_i_h_wts[19,193]=5.54163010552996e-001;
    __statist_i_h_wts[19,194]=4.72685433624383e-001;
    __statist_i_h_wts[19,195]=4.88180284521131e-001;
    __statist_i_h_wts[19,196]=6.13742480971266e-001;
    __statist_i_h_wts[19,197]=4.96527887976171e-001;
    __statist_i_h_wts[19,198]=5.78536511702822e-001;
    __statist_i_h_wts[19,199]=5.99635693775826e-001;
    __statist_i_h_wts[19,200]=5.60016982665110e-001;
    __statist_i_h_wts[19,201]=6.67833394226094e-001;
    __statist_i_h_wts[19,202]=8.51776602894018e-001;
    __statist_i_h_wts[19,203]=6.88094665360637e-001;
    __statist_i_h_wts[19,204]=6.21569415477564e-001;
    __statist_i_h_wts[19,205]=6.08607241966963e-001;
    __statist_i_h_wts[19,206]=4.19055196390389e-001;
    __statist_i_h_wts[19,207]=4.03713068201175e-001;
    __statist_i_h_wts[19,208]=5.38009587253529e-001;
    __statist_i_h_wts[19,209]=3.98360048901932e-001;
    __statist_i_h_wts[19,210]=4.71820324665803e-001;
    __statist_i_h_wts[19,211]=5.53524291838407e-001;
    __statist_i_h_wts[19,212]=5.51723866420470e-001;
    __statist_i_h_wts[19,213]=5.95373136338474e-001;
    __statist_i_h_wts[19,214]=6.29909512099611e-001;
    __statist_i_h_wts[19,215]=6.80207582764052e-001;
    __statist_i_h_wts[19,216]=6.62668577809155e-001;
    __statist_i_h_wts[19,217]=7.86295144685859e-001;
    __statist_i_h_wts[19,218]=5.59848238333426e-001;
    __statist_i_h_wts[19,219]=3.96133200385220e-001;
    __statist_i_h_wts[19,220]=3.75126349845388e-001;
    __statist_i_h_wts[19,221]=3.46456482406353e-001;
    __statist_i_h_wts[19,222]=3.33717585937812e-001;
    __statist_i_h_wts[19,223]=5.33860175376123e-001;
    __statist_i_h_wts[19,224]=4.76160491546909e-001;
    __statist_i_h_wts[19,225]=1.48751178509917e-002;
    __statist_i_h_wts[19,226]=-1.41454649413178e+000;
    __statist_i_h_wts[19,227]=1.29730379450213e-001;
    __statist_i_h_wts[19,228]=-1.32707394388250e+000;
    __statist_i_h_wts[19,229]=8.08113239215964e-002;
    __statist_i_h_wts[19,230]=1.96212847957994e+000;
    __statist_i_h_wts[19,231]=1.90630562647113e-001;
    __statist_i_h_wts[19,232]=1.90289361479573e+000;
    __statist_i_h_wts[19,233]=8.54255585062897e-001;
    __statist_i_h_wts[19,234]=2.28830669461365e+000;
    __statist_i_h_wts[19,235]=-5.71633341045311e-001;
    __statist_i_h_wts[19,236]=-2.46264788173719e+000;
    __statist_i_h_wts[19,237]=-2.76444026111618e+000;
    __statist_i_h_wts[19,238]=-7.46119956008673e-001;
    __statist_i_h_wts[19,239]=1.59611731630540e+000;
    __statist_i_h_wts[19,240]=-8.26888048063631e-001;
    __statist_i_h_wts[19,241]=5.58186260495704e+000;
    __statist_i_h_wts[19,242]=6.07860467379640e-002;
    __statist_i_h_wts[19,243]=2.16607936944259e+000;
    __statist_i_h_wts[19,244]=2.28751624943320e-001;
    __statist_i_h_wts[19,245]=-3.48231751162083e+000;
    __statist_i_h_wts[19,246]=1.38618499759766e+000;
    __statist_i_h_wts[19,247]=-2.12090005249803e+000;
    __statist_i_h_wts[19,248]=5.66250422397122e-001;

    __statist_i_h_wts[20,0]=-1.60659359000507e-001;
    __statist_i_h_wts[20,1]=-1.16602831290011e-001;
    __statist_i_h_wts[20,2]=-5.26733748921086e-002;
    __statist_i_h_wts[20,3]=3.07003258213970e-002;
    __statist_i_h_wts[20,4]=7.27672462473190e-002;
    __statist_i_h_wts[20,5]=7.67758341525623e-002;
    __statist_i_h_wts[20,6]=-3.29465844807451e-002;
    __statist_i_h_wts[20,7]=-4.18806212766325e-002;
    __statist_i_h_wts[20,8]=6.04469593328807e-002;
    __statist_i_h_wts[20,9]=-1.27950848314934e-001;
    __statist_i_h_wts[20,10]=-1.30205200055704e-001;
    __statist_i_h_wts[20,11]=1.93374959530856e-002;
    __statist_i_h_wts[20,12]=2.31815526526582e-002;
    __statist_i_h_wts[20,13]=-2.06110168417008e-001;
    __statist_i_h_wts[20,14]=-1.42258422476999e-001;
    __statist_i_h_wts[20,15]=-1.45482413317489e-001;
    __statist_i_h_wts[20,16]=-3.32032420587303e-002;
    __statist_i_h_wts[20,17]=5.29267570227939e-002;
    __statist_i_h_wts[20,18]=1.30155443644830e-001;
    __statist_i_h_wts[20,19]=1.94672057926006e-001;
    __statist_i_h_wts[20,20]=3.01937512945609e-001;
    __statist_i_h_wts[20,21]=2.61985596279544e-001;
    __statist_i_h_wts[20,22]=1.50817699515090e-001;
    __statist_i_h_wts[20,23]=1.56411598688475e-001;
    __statist_i_h_wts[20,24]=4.03096591457974e-002;
    __statist_i_h_wts[20,25]=8.70401581103348e-002;
    __statist_i_h_wts[20,26]=-6.46144315050636e-003;
    __statist_i_h_wts[20,27]=-1.46305661220302e-002;
    __statist_i_h_wts[20,28]=-2.27328857474821e-001;
    __statist_i_h_wts[20,29]=-9.30888307378234e-002;
    __statist_i_h_wts[20,30]=-1.05726384334377e-001;
    __statist_i_h_wts[20,31]=-9.72825401710469e-002;
    __statist_i_h_wts[20,32]=-4.13361458455333e-002;
    __statist_i_h_wts[20,33]=2.27741803022268e-002;
    __statist_i_h_wts[20,34]=7.65779986692898e-002;
    __statist_i_h_wts[20,35]=2.76362046389258e-001;
    __statist_i_h_wts[20,36]=1.70407602526835e-001;
    __statist_i_h_wts[20,37]=1.32904986342522e-001;
    __statist_i_h_wts[20,38]=2.07522328734729e-001;
    __statist_i_h_wts[20,39]=3.49031385653055e-002;
    __statist_i_h_wts[20,40]=1.68018132178100e-001;
    __statist_i_h_wts[20,41]=6.16177744182439e-002;
    __statist_i_h_wts[20,42]=6.39005486689827e-002;
    __statist_i_h_wts[20,43]=-1.61185520147587e-001;
    __statist_i_h_wts[20,44]=-8.49973639153737e-002;
    __statist_i_h_wts[20,45]=-3.03223791596626e-001;
    __statist_i_h_wts[20,46]=-3.82469182743608e-001;
    __statist_i_h_wts[20,47]=-3.29501453525728e-001;
    __statist_i_h_wts[20,48]=-2.82992565376683e-001;
    __statist_i_h_wts[20,49]=-2.37882723063414e-001;
    __statist_i_h_wts[20,50]=-8.87985189588665e-002;
    __statist_i_h_wts[20,51]=-1.06377189767278e-001;
    __statist_i_h_wts[20,52]=-1.27367916642911e-001;
    __statist_i_h_wts[20,53]=-5.37754193157243e-002;
    __statist_i_h_wts[20,54]=-2.34259511049989e-001;
    __statist_i_h_wts[20,55]=-1.57288089734338e-001;
    __statist_i_h_wts[20,56]=-1.37522958681688e-001;
    __statist_i_h_wts[20,57]=-1.28588974358470e-001;
    __statist_i_h_wts[20,58]=-1.63787632087646e-001;
    __statist_i_h_wts[20,59]=-1.40103337597180e-001;
    __statist_i_h_wts[20,60]=-2.26747064045584e-001;
    __statist_i_h_wts[20,61]=-2.46445337420212e-001;
    __statist_i_h_wts[20,62]=-1.74452206513446e-001;
    __statist_i_h_wts[20,63]=-1.57042840189604e-001;
    __statist_i_h_wts[20,64]=-1.16441825884175e-001;
    __statist_i_h_wts[20,65]=2.38725552219725e-002;
    __statist_i_h_wts[20,66]=1.34242382137823e-001;
    __statist_i_h_wts[20,67]=2.40093222272164e-002;
    __statist_i_h_wts[20,68]=1.23669785493491e-001;
    __statist_i_h_wts[20,69]=-1.25038065816518e-001;
    __statist_i_h_wts[20,70]=-2.61299884305020e-001;
    __statist_i_h_wts[20,71]=-1.98325001595641e-001;
    __statist_i_h_wts[20,72]=-2.40135883139977e-001;
    __statist_i_h_wts[20,73]=-1.83331930048745e-001;
    __statist_i_h_wts[20,74]=-9.32851157907250e-002;
    __statist_i_h_wts[20,75]=-8.46253197524719e-002;
    __statist_i_h_wts[20,76]=-8.60817793699717e-002;
    __statist_i_h_wts[20,77]=-6.73762633413070e-002;
    __statist_i_h_wts[20,78]=-6.84500553467243e-002;
    __statist_i_h_wts[20,79]=-3.83772393446258e-002;
    __statist_i_h_wts[20,80]=-1.20522411161375e-002;
    __statist_i_h_wts[20,81]=1.07513973216500e-001;
    __statist_i_h_wts[20,82]=2.51496614810027e-002;
    __statist_i_h_wts[20,83]=9.70145521903141e-002;
    __statist_i_h_wts[20,84]=-9.79283544433087e-002;
    __statist_i_h_wts[20,85]=-2.37802721633438e-001;
    __statist_i_h_wts[20,86]=-7.13693959884152e-002;
    __statist_i_h_wts[20,87]=-1.84718129635981e-001;
    __statist_i_h_wts[20,88]=-2.59905121530764e-001;
    __statist_i_h_wts[20,89]=-8.66666199904612e-002;
    __statist_i_h_wts[20,90]=-9.76201970830736e-002;
    __statist_i_h_wts[20,91]=-1.08588018690735e-001;
    __statist_i_h_wts[20,92]=-3.81802430935014e-001;
    __statist_i_h_wts[20,93]=-2.97684359918249e-001;
    __statist_i_h_wts[20,94]=-2.38828761019487e-001;
    __statist_i_h_wts[20,95]=-2.56450573075091e-001;
    __statist_i_h_wts[20,96]=-1.61077754092763e-001;
    __statist_i_h_wts[20,97]=-2.13009284075215e-001;
    __statist_i_h_wts[20,98]=-5.11582522994201e-002;
    __statist_i_h_wts[20,99]=-2.26001389112989e-001;
    __statist_i_h_wts[20,100]=-2.60964268571518e-001;
    __statist_i_h_wts[20,101]=-6.89051587850939e-002;
    __statist_i_h_wts[20,102]=-2.28397137516512e-001;
    __statist_i_h_wts[20,103]=-2.16460577212182e-001;
    __statist_i_h_wts[20,104]=-1.93318170234171e-001;
    __statist_i_h_wts[20,105]=-2.18559194910957e-001;
    __statist_i_h_wts[20,106]=-1.88722202894024e-001;
    __statist_i_h_wts[20,107]=-2.79707821017111e-001;
    __statist_i_h_wts[20,108]=-1.54926884732232e-001;
    __statist_i_h_wts[20,109]=-7.42492441100746e-002;
    __statist_i_h_wts[20,110]=-1.14500176490405e-001;
    __statist_i_h_wts[20,111]=-4.68416629349922e-002;
    __statist_i_h_wts[20,112]=-5.54305605836319e-002;
    __statist_i_h_wts[20,113]=-1.41990428611918e-002;
    __statist_i_h_wts[20,114]=-5.28262295863603e-002;
    __statist_i_h_wts[20,115]=-2.18283555877320e-001;
    __statist_i_h_wts[20,116]=-1.47166741851957e-001;
    __statist_i_h_wts[20,117]=-1.79758076086849e-001;
    __statist_i_h_wts[20,118]=-1.10021724293923e-001;
    __statist_i_h_wts[20,119]=-1.74711939344071e-001;
    __statist_i_h_wts[20,120]=-1.10825061651132e-001;
    __statist_i_h_wts[20,121]=-5.53520053963427e-002;
    __statist_i_h_wts[20,122]=4.22542096822044e-003;
    __statist_i_h_wts[20,123]=-7.36724326687803e-002;
    __statist_i_h_wts[20,124]=-1.55956500039430e-001;
    __statist_i_h_wts[20,125]=-1.15877001472446e-001;
    __statist_i_h_wts[20,126]=2.06931054800471e-004;
    __statist_i_h_wts[20,127]=-2.22977187346055e-001;
    __statist_i_h_wts[20,128]=-1.68465250077577e-001;
    __statist_i_h_wts[20,129]=-1.38487165912885e-001;
    __statist_i_h_wts[20,130]=-1.63668274465780e-001;
    __statist_i_h_wts[20,131]=-5.95534045437365e-002;
    __statist_i_h_wts[20,132]=-1.46909236805676e-002;
    __statist_i_h_wts[20,133]=-7.22985819544004e-002;
    __statist_i_h_wts[20,134]=-9.52055119006662e-002;
    __statist_i_h_wts[20,135]=-2.23387221556876e-001;
    __statist_i_h_wts[20,136]=-8.55507738033593e-002;
    __statist_i_h_wts[20,137]=-9.12877910379281e-002;
    __statist_i_h_wts[20,138]=-2.82521547929442e-002;
    __statist_i_h_wts[20,139]=-1.36832098728191e-001;
    __statist_i_h_wts[20,140]=-1.21356331168317e-001;
    __statist_i_h_wts[20,141]=4.23539413744046e-002;
    __statist_i_h_wts[20,142]=-1.77124961994314e-001;
    __statist_i_h_wts[20,143]=-9.25734081720220e-002;
    __statist_i_h_wts[20,144]=-4.05129020214291e-002;
    __statist_i_h_wts[20,145]=-1.91957663874555e-001;
    __statist_i_h_wts[20,146]=-1.66472034532840e-001;
    __statist_i_h_wts[20,147]=-2.19457656442831e-001;
    __statist_i_h_wts[20,148]=-2.56043131962319e-001;
    __statist_i_h_wts[20,149]=-3.12994088028026e-001;
    __statist_i_h_wts[20,150]=-4.55134918261647e-001;
    __statist_i_h_wts[20,151]=-3.30260290838435e-001;
    __statist_i_h_wts[20,152]=-3.07254844401918e-001;
    __statist_i_h_wts[20,153]=-1.08598698758982e-001;
    __statist_i_h_wts[20,154]=-2.05064885186955e-001;
    __statist_i_h_wts[20,155]=-1.06991830290518e-001;
    __statist_i_h_wts[20,156]=-7.88974312631363e-002;
    __statist_i_h_wts[20,157]=-7.76970816199507e-002;
    __statist_i_h_wts[20,158]=-3.54315199170571e-001;
    __statist_i_h_wts[20,159]=-2.50148374044123e-001;
    __statist_i_h_wts[20,160]=-3.15013601605954e-001;
    __statist_i_h_wts[20,161]=-1.92423822753688e-001;
    __statist_i_h_wts[20,162]=-2.59519343265350e-001;
    __statist_i_h_wts[20,163]=1.43251763899631e-002;
    __statist_i_h_wts[20,164]=-3.79043136243630e-002;
    __statist_i_h_wts[20,165]=-4.41082844629126e-001;
    __statist_i_h_wts[20,166]=-3.42864374656199e-001;
    __statist_i_h_wts[20,167]=-4.20522829318976e-001;
    __statist_i_h_wts[20,168]=-3.06011568921791e-001;
    __statist_i_h_wts[20,169]=-2.69270812854076e-001;
    __statist_i_h_wts[20,170]=-1.64833458640307e-001;
    __statist_i_h_wts[20,171]=1.11387478715126e-002;
    __statist_i_h_wts[20,172]=-1.24415277007902e-001;
    __statist_i_h_wts[20,173]=-1.14864758451993e-001;
    __statist_i_h_wts[20,174]=-8.84195767988124e-002;
    __statist_i_h_wts[20,175]=-6.94270498641794e-002;
    __statist_i_h_wts[20,176]=-1.17091189365815e-001;
    __statist_i_h_wts[20,177]=3.32308062706600e-002;
    __statist_i_h_wts[20,178]=1.24228881087281e-001;
    __statist_i_h_wts[20,179]=-4.13469934596047e-002;
    __statist_i_h_wts[20,180]=-2.17437180886961e-001;
    __statist_i_h_wts[20,181]=-1.67125539549369e-001;
    __statist_i_h_wts[20,182]=-2.05590310168202e-001;
    __statist_i_h_wts[20,183]=-4.48416297746608e-002;
    __statist_i_h_wts[20,184]=-1.00045274532200e-001;
    __statist_i_h_wts[20,185]=-1.45443944275145e-001;
    __statist_i_h_wts[20,186]=5.61206838901890e-002;
    __statist_i_h_wts[20,187]=5.51537252481510e-002;
    __statist_i_h_wts[20,188]=-7.76923324427115e-002;
    __statist_i_h_wts[20,189]=-4.81064594810948e-002;
    __statist_i_h_wts[20,190]=-1.04935714789524e-002;
    __statist_i_h_wts[20,191]=-7.23445674899135e-002;
    __statist_i_h_wts[20,192]=-9.48785917453034e-002;
    __statist_i_h_wts[20,193]=-3.43719682722833e-002;
    __statist_i_h_wts[20,194]=-8.87680021784882e-002;
    __statist_i_h_wts[20,195]=-1.98852872014596e-001;
    __statist_i_h_wts[20,196]=-1.00312152219424e-001;
    __statist_i_h_wts[20,197]=-1.24693480279725e-001;
    __statist_i_h_wts[20,198]=-7.05385418049673e-002;
    __statist_i_h_wts[20,199]=-1.12956615977318e-001;
    __statist_i_h_wts[20,200]=-1.71175128924501e-001;
    __statist_i_h_wts[20,201]=5.59835261628530e-002;
    __statist_i_h_wts[20,202]=1.75246057717183e-001;
    __statist_i_h_wts[20,203]=1.54358176679063e-001;
    __statist_i_h_wts[20,204]=1.56639828229846e-001;
    __statist_i_h_wts[20,205]=1.53518165915561e-001;
    __statist_i_h_wts[20,206]=5.05394488443598e-003;
    __statist_i_h_wts[20,207]=-1.77005499970661e-002;
    __statist_i_h_wts[20,208]=5.91405864691341e-002;
    __statist_i_h_wts[20,209]=-1.13253717615770e-001;
    __statist_i_h_wts[20,210]=-2.15152529903241e-001;
    __statist_i_h_wts[20,211]=-1.07292183127682e-001;
    __statist_i_h_wts[20,212]=-2.07345844053409e-001;
    __statist_i_h_wts[20,213]=-1.24229594956502e-001;
    __statist_i_h_wts[20,214]=-1.20728044842435e-001;
    __statist_i_h_wts[20,215]=-8.49545949531196e-002;
    __statist_i_h_wts[20,216]=5.83340580908271e-002;
    __statist_i_h_wts[20,217]=1.76231321460275e-001;
    __statist_i_h_wts[20,218]=1.25647985882704e-001;
    __statist_i_h_wts[20,219]=-1.11124449934020e-002;
    __statist_i_h_wts[20,220]=-5.53553871713212e-002;
    __statist_i_h_wts[20,221]=-1.01571202249517e-001;
    __statist_i_h_wts[20,222]=-1.44749595091919e-001;
    __statist_i_h_wts[20,223]=-3.70739004698261e-002;
    __statist_i_h_wts[20,224]=-7.22017500047945e-002;
    __statist_i_h_wts[20,225]=6.75698188124146e-002;
    __statist_i_h_wts[20,226]=-1.03970098034639e+000;
    __statist_i_h_wts[20,227]=1.59212949722649e-001;
    __statist_i_h_wts[20,228]=-9.68141628117425e-001;
    __statist_i_h_wts[20,229]=1.24684857670322e-001;
    __statist_i_h_wts[20,230]=1.23618331876381e+000;
    __statist_i_h_wts[20,231]=5.77181161276190e-002;
    __statist_i_h_wts[20,232]=1.21919730649527e+000;
    __statist_i_h_wts[20,233]=4.91559186893584e-001;
    __statist_i_h_wts[20,234]=1.51615904607485e+000;
    __statist_i_h_wts[20,235]=-6.71590588992896e-001;
    __statist_i_h_wts[20,236]=-1.78153792533179e+000;
    __statist_i_h_wts[20,237]=-2.04246041702476e+000;
    __statist_i_h_wts[20,238]=-4.98918872457249e-001;
    __statist_i_h_wts[20,239]=1.19102230595328e+000;
    __statist_i_h_wts[20,240]=-5.17659927930811e-001;
    __statist_i_h_wts[20,241]=3.59558910355913e+000;
    __statist_i_h_wts[20,242]=-4.38792001617820e-002;
    __statist_i_h_wts[20,243]=1.36366602162924e+000;
    __statist_i_h_wts[20,244]=-1.60173383085942e-001;
    __statist_i_h_wts[20,245]=-2.36021554287575e+000;
    __statist_i_h_wts[20,246]=7.27760486078772e-001;
    __statist_i_h_wts[20,247]=-1.43250112603885e+000;
    __statist_i_h_wts[20,248]=1.04412689194562e-001;

    __statist_i_h_wts[21,0]=-4.92673306121348e-001;
    __statist_i_h_wts[21,1]=-5.23633000933845e-002;
    __statist_i_h_wts[21,2]=-2.62374084597906e-002;
    __statist_i_h_wts[21,3]=-2.01079160805856e-001;
    __statist_i_h_wts[21,4]=-2.18233773166502e-001;
    __statist_i_h_wts[21,5]=4.64992532628458e-001;
    __statist_i_h_wts[21,6]=5.72852784159016e-001;
    __statist_i_h_wts[21,7]=5.15330273856904e-002;
    __statist_i_h_wts[21,8]=2.57989193209308e-001;
    __statist_i_h_wts[21,9]=1.20476880252670e-001;
    __statist_i_h_wts[21,10]=1.47012706556368e-001;
    __statist_i_h_wts[21,11]=5.47214560700361e-001;
    __statist_i_h_wts[21,12]=3.83102478330095e-001;
    __statist_i_h_wts[21,13]=7.03436673736759e-002;
    __statist_i_h_wts[21,14]=-2.51554996972713e-001;
    __statist_i_h_wts[21,15]=-4.00899954553656e-001;
    __statist_i_h_wts[21,16]=7.88591809906829e-002;
    __statist_i_h_wts[21,17]=2.67770307416095e-001;
    __statist_i_h_wts[21,18]=-3.60120736707878e-001;
    __statist_i_h_wts[21,19]=-2.08764795223559e-002;
    __statist_i_h_wts[21,20]=2.99011607965892e-001;
    __statist_i_h_wts[21,21]=4.43365745040602e-001;
    __statist_i_h_wts[21,22]=-3.22971072048516e-001;
    __statist_i_h_wts[21,23]=8.67562584901583e-002;
    __statist_i_h_wts[21,24]=-3.66022394237781e-002;
    __statist_i_h_wts[21,25]=-2.22594601866040e-001;
    __statist_i_h_wts[21,26]=-1.85500446080713e-001;
    __statist_i_h_wts[21,27]=-2.67697487022516e-001;
    __statist_i_h_wts[21,28]=-2.94396895401071e-001;
    __statist_i_h_wts[21,29]=-1.44279898612259e-001;
    __statist_i_h_wts[21,30]=-2.75767971925691e-001;
    __statist_i_h_wts[21,31]=1.15700204690786e-002;
    __statist_i_h_wts[21,32]=-3.07149535717851e-001;
    __statist_i_h_wts[21,33]=-6.27000383990966e-001;
    __statist_i_h_wts[21,34]=1.30601710581859e-001;
    __statist_i_h_wts[21,35]=-1.61800754414507e-001;
    __statist_i_h_wts[21,36]=3.22085913274574e-001;
    __statist_i_h_wts[21,37]=-1.10358528649254e-001;
    __statist_i_h_wts[21,38]=-2.54556208092961e-001;
    __statist_i_h_wts[21,39]=-4.71452215986058e-001;
    __statist_i_h_wts[21,40]=-1.38665937529306e-001;
    __statist_i_h_wts[21,41]=-5.06362866862456e-001;
    __statist_i_h_wts[21,42]=2.75871935202519e-001;
    __statist_i_h_wts[21,43]=2.47900389120636e-001;
    __statist_i_h_wts[21,44]=1.53835840494188e-001;
    __statist_i_h_wts[21,45]=1.26366101023738e-002;
    __statist_i_h_wts[21,46]=2.58436305601258e-001;
    __statist_i_h_wts[21,47]=7.55030911850126e-002;
    __statist_i_h_wts[21,48]=3.90826008386620e-001;
    __statist_i_h_wts[21,49]=4.83975056667113e-001;
    __statist_i_h_wts[21,50]=-3.33232043931238e-001;
    __statist_i_h_wts[21,51]=1.97755217247267e-001;
    __statist_i_h_wts[21,52]=2.69882762662104e-001;
    __statist_i_h_wts[21,53]=-6.58138038306662e-001;
    __statist_i_h_wts[21,54]=-5.28158366825263e-001;
    __statist_i_h_wts[21,55]=-2.60265764013215e-001;
    __statist_i_h_wts[21,56]=2.98489736797771e-001;
    __statist_i_h_wts[21,57]=4.50864714848847e-001;
    __statist_i_h_wts[21,58]=5.52281061786764e-001;
    __statist_i_h_wts[21,59]=4.81754737124916e-001;
    __statist_i_h_wts[21,60]=-3.28953403883797e-001;
    __statist_i_h_wts[21,61]=2.90066806243819e-001;
    __statist_i_h_wts[21,62]=-6.64435505068219e-001;
    __statist_i_h_wts[21,63]=2.78105776184534e-001;
    __statist_i_h_wts[21,64]=3.55416211309313e-001;
    __statist_i_h_wts[21,65]=-7.24221393906707e-002;
    __statist_i_h_wts[21,66]=-1.80900159228663e-002;
    __statist_i_h_wts[21,67]=2.75647698576396e-002;
    __statist_i_h_wts[21,68]=5.88300826371481e-002;
    __statist_i_h_wts[21,69]=9.97958238841824e-001;
    __statist_i_h_wts[21,70]=4.26291147811030e-001;
    __statist_i_h_wts[21,71]=-9.44418484865832e-002;
    __statist_i_h_wts[21,72]=-4.37828413111816e-001;
    __statist_i_h_wts[21,73]=-4.81848737678497e-001;
    __statist_i_h_wts[21,74]=-2.53361018089091e-002;
    __statist_i_h_wts[21,75]=-3.58302657581217e-001;
    __statist_i_h_wts[21,76]=8.56757987237292e-003;
    __statist_i_h_wts[21,77]=-1.86327307859869e-001;
    __statist_i_h_wts[21,78]=-6.10476766280717e-003;
    __statist_i_h_wts[21,79]=4.24635023638417e-001;
    __statist_i_h_wts[21,80]=-1.79643018110487e-001;
    __statist_i_h_wts[21,81]=4.11102132952552e-002;
    __statist_i_h_wts[21,82]=-2.65403377979170e-001;
    __statist_i_h_wts[21,83]=2.32622331330115e-001;
    __statist_i_h_wts[21,84]=-4.35374017094089e-001;
    __statist_i_h_wts[21,85]=9.37720572989705e-002;
    __statist_i_h_wts[21,86]=5.76503808005713e-001;
    __statist_i_h_wts[21,87]=-2.39333657971815e-001;
    __statist_i_h_wts[21,88]=-5.20946682333674e-001;
    __statist_i_h_wts[21,89]=7.21941676853432e-002;
    __statist_i_h_wts[21,90]=1.16675965669302e-001;
    __statist_i_h_wts[21,91]=1.06791836985678e-001;
    __statist_i_h_wts[21,92]=-3.89769262829547e-005;
    __statist_i_h_wts[21,93]=1.50690699240877e-001;
    __statist_i_h_wts[21,94]=-5.67703719400583e-002;
    __statist_i_h_wts[21,95]=-3.21465246732874e-001;
    __statist_i_h_wts[21,96]=-1.84292664590869e-001;
    __statist_i_h_wts[21,97]=-3.27763643666752e-001;
    __statist_i_h_wts[21,98]=1.92780969973315e-001;
    __statist_i_h_wts[21,99]=-4.65187902909652e-001;
    __statist_i_h_wts[21,100]=8.81532754914430e-002;
    __statist_i_h_wts[21,101]=4.05167322923522e-001;
    __statist_i_h_wts[21,102]=-2.99026721767408e-001;
    __statist_i_h_wts[21,103]=-8.18196573415422e-001;
    __statist_i_h_wts[21,104]=-1.18715223432335e-001;
    __statist_i_h_wts[21,105]=-4.12270653823422e-001;
    __statist_i_h_wts[21,106]=4.57218411922118e-001;
    __statist_i_h_wts[21,107]=1.35355648310314e-001;
    __statist_i_h_wts[21,108]=4.66189824606392e-001;
    __statist_i_h_wts[21,109]=6.00873237294080e-001;
    __statist_i_h_wts[21,110]=-2.22642992643648e-001;
    __statist_i_h_wts[21,111]=2.15196360859818e-001;
    __statist_i_h_wts[21,112]=-1.98201339610452e-002;
    __statist_i_h_wts[21,113]=-4.01492490180997e-001;
    __statist_i_h_wts[21,114]=-1.27760490796700e-001;
    __statist_i_h_wts[21,115]=3.03307067483831e-001;
    __statist_i_h_wts[21,116]=1.19605855834012e-001;
    __statist_i_h_wts[21,117]=4.36738144614084e-002;
    __statist_i_h_wts[21,118]=-2.16295718376464e-001;
    __statist_i_h_wts[21,119]=-1.61686527264496e-001;
    __statist_i_h_wts[21,120]=5.10285474899226e-002;
    __statist_i_h_wts[21,121]=3.73104785494239e-001;
    __statist_i_h_wts[21,122]=1.12863948335692e-001;
    __statist_i_h_wts[21,123]=-2.46502205026924e-001;
    __statist_i_h_wts[21,124]=-6.01206578370039e-001;
    __statist_i_h_wts[21,125]=-2.04648862467267e-001;
    __statist_i_h_wts[21,126]=1.28080711650094e-001;
    __statist_i_h_wts[21,127]=-4.58291584953108e-001;
    __statist_i_h_wts[21,128]=-4.66373418687036e-002;
    __statist_i_h_wts[21,129]=-3.65622930425869e-001;
    __statist_i_h_wts[21,130]=6.60665578278854e-001;
    __statist_i_h_wts[21,131]=7.14808371614103e-001;
    __statist_i_h_wts[21,132]=3.48035068403448e-001;
    __statist_i_h_wts[21,133]=-2.89821913658256e-001;
    __statist_i_h_wts[21,134]=2.52008570376964e-001;
    __statist_i_h_wts[21,135]=8.68079134081899e-002;
    __statist_i_h_wts[21,136]=-2.60806572371811e-001;
    __statist_i_h_wts[21,137]=-2.16565442470073e-001;
    __statist_i_h_wts[21,138]=-9.33042226919645e-002;
    __statist_i_h_wts[21,139]=-4.46982807337182e-001;
    __statist_i_h_wts[21,140]=1.08409875058733e-001;
    __statist_i_h_wts[21,141]=9.82373252356259e-002;
    __statist_i_h_wts[21,142]=-8.83228991860089e-001;
    __statist_i_h_wts[21,143]=1.95092198726275e-001;
    __statist_i_h_wts[21,144]=-3.31707501419106e-001;
    __statist_i_h_wts[21,145]=-2.03293328258406e-001;
    __statist_i_h_wts[21,146]=3.06495598456481e-001;
    __statist_i_h_wts[21,147]=1.86388074780197e-002;
    __statist_i_h_wts[21,148]=-4.05094912383002e-001;
    __statist_i_h_wts[21,149]=-4.20056149930098e-001;
    __statist_i_h_wts[21,150]=2.93691766690882e-001;
    __statist_i_h_wts[21,151]=-2.47854055163214e-002;
    __statist_i_h_wts[21,152]=-1.18235703107391e-001;
    __statist_i_h_wts[21,153]=4.41513660801644e-001;
    __statist_i_h_wts[21,154]=5.25085732090435e-002;
    __statist_i_h_wts[21,155]=1.99394928704114e-001;
    __statist_i_h_wts[21,156]=6.22208031581838e-002;
    __statist_i_h_wts[21,157]=-3.74232320944607e-001;
    __statist_i_h_wts[21,158]=-2.24627182307693e-002;
    __statist_i_h_wts[21,159]=-3.97012316143506e-001;
    __statist_i_h_wts[21,160]=-2.92155588660889e-001;
    __statist_i_h_wts[21,161]=4.11383748651922e-001;
    __statist_i_h_wts[21,162]=9.27687175980633e-003;
    __statist_i_h_wts[21,163]=4.92060311930878e-001;
    __statist_i_h_wts[21,164]=4.83968080801738e-001;
    __statist_i_h_wts[21,165]=3.31997176036133e-002;
    __statist_i_h_wts[21,166]=-1.45225270009357e-001;
    __statist_i_h_wts[21,167]=-2.42994222598641e-001;
    __statist_i_h_wts[21,168]=4.82829947367255e-001;
    __statist_i_h_wts[21,169]=2.98135475482567e-001;
    __statist_i_h_wts[21,170]=1.45643832510626e-001;
    __statist_i_h_wts[21,171]=3.34693806455131e-002;
    __statist_i_h_wts[21,172]=1.67423004297440e-001;
    __statist_i_h_wts[21,173]=2.18306987828199e-001;
    __statist_i_h_wts[21,174]=-5.09216636826490e-001;
    __statist_i_h_wts[21,175]=2.23538307306623e-001;
    __statist_i_h_wts[21,176]=-7.19477340187169e-002;
    __statist_i_h_wts[21,177]=-2.94755186052875e-001;
    __statist_i_h_wts[21,178]=2.10285276950695e-001;
    __statist_i_h_wts[21,179]=-1.40590445004390e-001;
    __statist_i_h_wts[21,180]=1.83702922019490e-001;
    __statist_i_h_wts[21,181]=-2.05101298038480e-001;
    __statist_i_h_wts[21,182]=-5.46527625068430e-001;
    __statist_i_h_wts[21,183]=3.60503737654506e-001;
    __statist_i_h_wts[21,184]=-1.86461882985121e-001;
    __statist_i_h_wts[21,185]=7.90116537455676e-002;
    __statist_i_h_wts[21,186]=6.69351086804422e-003;
    __statist_i_h_wts[21,187]=1.62241388523617e-001;
    __statist_i_h_wts[21,188]=2.21824133599597e-001;
    __statist_i_h_wts[21,189]=-2.55077225535985e-001;
    __statist_i_h_wts[21,190]=2.61409382137502e-001;
    __statist_i_h_wts[21,191]=-6.70228996306388e-002;
    __statist_i_h_wts[21,192]=-8.27930561979137e-002;
    __statist_i_h_wts[21,193]=1.82461008888559e-001;
    __statist_i_h_wts[21,194]=-1.98333911961690e-002;
    __statist_i_h_wts[21,195]=2.90392059159973e-001;
    __statist_i_h_wts[21,196]=1.06977438357093e-001;
    __statist_i_h_wts[21,197]=3.87090761656501e-002;
    __statist_i_h_wts[21,198]=2.57946497959045e-001;
    __statist_i_h_wts[21,199]=2.10283412722431e-001;
    __statist_i_h_wts[21,200]=-1.87659086066234e-001;
    __statist_i_h_wts[21,201]=-2.09474839189418e-001;
    __statist_i_h_wts[21,202]=1.93926153494484e-001;
    __statist_i_h_wts[21,203]=6.71999284960376e-001;
    __statist_i_h_wts[21,204]=-6.56663080643322e-002;
    __statist_i_h_wts[21,205]=1.04909257850851e-001;
    __statist_i_h_wts[21,206]=-1.32528005970744e-001;
    __statist_i_h_wts[21,207]=-1.97177978411892e-001;
    __statist_i_h_wts[21,208]=-1.74228607328063e-002;
    __statist_i_h_wts[21,209]=-2.60538713497116e-001;
    __statist_i_h_wts[21,210]=5.35565383514203e-002;
    __statist_i_h_wts[21,211]=2.55487736349001e-002;
    __statist_i_h_wts[21,212]=-1.91706404111748e-001;
    __statist_i_h_wts[21,213]=-7.92423710782500e-002;
    __statist_i_h_wts[21,214]=1.35053091643558e-001;
    __statist_i_h_wts[21,215]=1.22407908584323e-001;
    __statist_i_h_wts[21,216]=-4.34429605864140e-002;
    __statist_i_h_wts[21,217]=1.14266606869608e-001;
    __statist_i_h_wts[21,218]=2.35443999734750e-001;
    __statist_i_h_wts[21,219]=-5.35725392454512e-001;
    __statist_i_h_wts[21,220]=-2.20227508534023e-001;
    __statist_i_h_wts[21,221]=-2.40236948538802e-002;
    __statist_i_h_wts[21,222]=-7.61144123105800e-002;
    __statist_i_h_wts[21,223]=3.22584295780858e-001;
    __statist_i_h_wts[21,224]=2.81214695463290e-002;
    __statist_i_h_wts[21,225]=2.15195989173023e-001;
    __statist_i_h_wts[21,226]=-6.38524919646854e-001;
    __statist_i_h_wts[21,227]=1.78670410429122e-001;
    __statist_i_h_wts[21,228]=-2.81841388158504e-001;
    __statist_i_h_wts[21,229]=8.74521261243586e-002;
    __statist_i_h_wts[21,230]=2.37511074105109e-001;
    __statist_i_h_wts[21,231]=-9.70104911416404e-002;
    __statist_i_h_wts[21,232]=1.03082009956267e+000;
    __statist_i_h_wts[21,233]=2.77527622627225e-001;
    __statist_i_h_wts[21,234]=1.52958196795192e+000;
    __statist_i_h_wts[21,235]=-9.26478888715442e-001;
    __statist_i_h_wts[21,236]=-3.05684200777688e+000;
    __statist_i_h_wts[21,237]=-2.20669044957836e+000;
    __statist_i_h_wts[21,238]=-1.04478179960244e+000;
    __statist_i_h_wts[21,239]=-5.80418423059136e-002;
    __statist_i_h_wts[21,240]=-6.35153275029105e-002;
    __statist_i_h_wts[21,241]=7.38344855987499e+000;
    __statist_i_h_wts[21,242]=-2.52145266330351e-001;
    __statist_i_h_wts[21,243]=2.43809641394953e-001;
    __statist_i_h_wts[21,244]=4.44131661574345e-001;
    __statist_i_h_wts[21,245]=-5.16958826175494e-001;
    __statist_i_h_wts[21,246]=2.23417035128510e+000;
    __statist_i_h_wts[21,247]=3.97465585717808e-001;
    __statist_i_h_wts[21,248]=1.01708045307472e+000;

    __statist_i_h_wts[22,0]=-1.99721363578318e-001;
    __statist_i_h_wts[22,1]=4.75201873820193e-002;
    __statist_i_h_wts[22,2]=-3.08039692049607e-002;
    __statist_i_h_wts[22,3]=2.70867756602269e-001;
    __statist_i_h_wts[22,4]=8.08509565268685e-002;
    __statist_i_h_wts[22,5]=2.68425092521508e-001;
    __statist_i_h_wts[22,6]=2.81322326459300e-001;
    __statist_i_h_wts[22,7]=1.63035345750654e-002;
    __statist_i_h_wts[22,8]=-3.55461244751547e-001;
    __statist_i_h_wts[22,9]=3.14207730350181e-002;
    __statist_i_h_wts[22,10]=-2.03845667202167e-001;
    __statist_i_h_wts[22,11]=-3.60654287497451e-001;
    __statist_i_h_wts[22,12]=7.07939172066750e-002;
    __statist_i_h_wts[22,13]=2.13524038409826e-001;
    __statist_i_h_wts[22,14]=-8.99729670453247e-001;
    __statist_i_h_wts[22,15]=-3.18500150714178e-001;
    __statist_i_h_wts[22,16]=-5.50784327387166e-002;
    __statist_i_h_wts[22,17]=-1.56712776881722e-001;
    __statist_i_h_wts[22,18]=2.94568844917236e-001;
    __statist_i_h_wts[22,19]=-1.82885190166213e-001;
    __statist_i_h_wts[22,20]=-1.97532730753736e-001;
    __statist_i_h_wts[22,21]=-1.08937462043016e-001;
    __statist_i_h_wts[22,22]=2.38784395045669e-001;
    __statist_i_h_wts[22,23]=-3.79604424974853e-001;
    __statist_i_h_wts[22,24]=-2.42710442815754e-001;
    __statist_i_h_wts[22,25]=-3.14252936444082e-001;
    __statist_i_h_wts[22,26]=-2.90436703603528e-001;
    __statist_i_h_wts[22,27]=3.44676983129125e-002;
    __statist_i_h_wts[22,28]=1.19399911835646e-001;
    __statist_i_h_wts[22,29]=-8.16340004698353e-001;
    __statist_i_h_wts[22,30]=-4.90451422122193e-001;
    __statist_i_h_wts[22,31]=-1.57756120553591e-001;
    __statist_i_h_wts[22,32]=-4.55283372491728e-001;
    __statist_i_h_wts[22,33]=-1.00169930371934e-001;
    __statist_i_h_wts[22,34]=-5.11887337211963e-001;
    __statist_i_h_wts[22,35]=-5.21324949210501e-001;
    __statist_i_h_wts[22,36]=-1.60198872194803e-001;
    __statist_i_h_wts[22,37]=-2.72237876157941e-001;
    __statist_i_h_wts[22,38]=-5.30376213552234e-001;
    __statist_i_h_wts[22,39]=6.05188173492396e-003;
    __statist_i_h_wts[22,40]=-4.08675472662585e-001;
    __statist_i_h_wts[22,41]=-3.27431952127786e-001;
    __statist_i_h_wts[22,42]=5.05786445171948e-002;
    __statist_i_h_wts[22,43]=1.85651151979429e-001;
    __statist_i_h_wts[22,44]=-7.87636204382303e-002;
    __statist_i_h_wts[22,45]=-1.27146009962149e-001;
    __statist_i_h_wts[22,46]=3.42562699724753e-001;
    __statist_i_h_wts[22,47]=2.01521004420317e-001;
    __statist_i_h_wts[22,48]=2.48714032176223e-001;
    __statist_i_h_wts[22,49]=6.52546564481414e-002;
    __statist_i_h_wts[22,50]=-4.18555998058665e-002;
    __statist_i_h_wts[22,51]=4.48447937165952e-001;
    __statist_i_h_wts[22,52]=2.76506108673373e-001;
    __statist_i_h_wts[22,53]=2.54606486322547e-001;
    __statist_i_h_wts[22,54]=5.24019573799952e-003;
    __statist_i_h_wts[22,55]=-1.74903105567446e-001;
    __statist_i_h_wts[22,56]=-2.30672089090327e-001;
    __statist_i_h_wts[22,57]=-5.31213164435791e-003;
    __statist_i_h_wts[22,58]=-6.56529348545131e-002;
    __statist_i_h_wts[22,59]=3.84486676827621e-001;
    __statist_i_h_wts[22,60]=-4.85393970817069e-002;
    __statist_i_h_wts[22,61]=4.84564021395957e-001;
    __statist_i_h_wts[22,62]=-2.30480079072611e-002;
    __statist_i_h_wts[22,63]=9.51021753846153e-002;
    __statist_i_h_wts[22,64]=-1.12950943542032e-001;
    __statist_i_h_wts[22,65]=-2.41268122953455e-001;
    __statist_i_h_wts[22,66]=7.47307362283017e-002;
    __statist_i_h_wts[22,67]=5.20655971286323e-001;
    __statist_i_h_wts[22,68]=5.17373392786490e-001;
    __statist_i_h_wts[22,69]=-2.15688454905943e-001;
    __statist_i_h_wts[22,70]=-2.78743192437023e-001;
    __statist_i_h_wts[22,71]=-2.41042059309113e-001;
    __statist_i_h_wts[22,72]=1.50160595741128e-003;
    __statist_i_h_wts[22,73]=-2.55413962890147e-001;
    __statist_i_h_wts[22,74]=1.22853755763017e-003;
    __statist_i_h_wts[22,75]=-2.24879545412407e-002;
    __statist_i_h_wts[22,76]=8.96529234772979e-002;
    __statist_i_h_wts[22,77]=-1.32827246500269e-001;
    __statist_i_h_wts[22,78]=-1.69195085486356e-001;
    __statist_i_h_wts[22,79]=-3.87257132484951e-001;
    __statist_i_h_wts[22,80]=-6.67666791583404e-003;
    __statist_i_h_wts[22,81]=6.16711734386391e-001;
    __statist_i_h_wts[22,82]=2.75622344317518e-001;
    __statist_i_h_wts[22,83]=-1.22792628440669e-001;
    __statist_i_h_wts[22,84]=-6.59970583374547e-002;
    __statist_i_h_wts[22,85]=2.70549267217988e-002;
    __statist_i_h_wts[22,86]=1.36169185388127e-001;
    __statist_i_h_wts[22,87]=4.52831059486441e-001;
    __statist_i_h_wts[22,88]=1.67248664398962e-001;
    __statist_i_h_wts[22,89]=5.27960921265983e-001;
    __statist_i_h_wts[22,90]=-5.25058947537795e-001;
    __statist_i_h_wts[22,91]=-4.79774063575762e-001;
    __statist_i_h_wts[22,92]=-1.39509243384743e-001;
    __statist_i_h_wts[22,93]=-1.31070503102868e-001;
    __statist_i_h_wts[22,94]=-1.95760428106063e-002;
    __statist_i_h_wts[22,95]=-4.45149100849918e-001;
    __statist_i_h_wts[22,96]=1.27455764921354e-001;
    __statist_i_h_wts[22,97]=-2.45796521702877e-001;
    __statist_i_h_wts[22,98]=-2.83683150345685e-001;
    __statist_i_h_wts[22,99]=2.92443483345847e-001;
    __statist_i_h_wts[22,100]=1.62345198961630e-002;
    __statist_i_h_wts[22,101]=-5.24675743844306e-001;
    __statist_i_h_wts[22,102]=-2.01348596215581e-001;
    __statist_i_h_wts[22,103]=-4.64598063142012e-001;
    __statist_i_h_wts[22,104]=-1.17244868573531e-001;
    __statist_i_h_wts[22,105]=-2.36495128248884e-001;
    __statist_i_h_wts[22,106]=-3.59153710096796e-001;
    __statist_i_h_wts[22,107]=-9.57849892521421e-002;
    __statist_i_h_wts[22,108]=4.54175716565366e-001;
    __statist_i_h_wts[22,109]=-1.22589751896106e-001;
    __statist_i_h_wts[22,110]=2.25095092066407e-001;
    __statist_i_h_wts[22,111]=4.67601457031633e-001;
    __statist_i_h_wts[22,112]=-3.00740388148036e-001;
    __statist_i_h_wts[22,113]=5.02588389294913e-001;
    __statist_i_h_wts[22,114]=-1.48100668246056e-001;
    __statist_i_h_wts[22,115]=-3.07483248255272e-001;
    __statist_i_h_wts[22,116]=-1.21262027097396e-001;
    __statist_i_h_wts[22,117]=-8.16422738989371e-002;
    __statist_i_h_wts[22,118]=-5.75130113685745e-001;
    __statist_i_h_wts[22,119]=-4.96442726469573e-002;
    __statist_i_h_wts[22,120]=-2.56898917737707e-001;
    __statist_i_h_wts[22,121]=-3.18316764658513e-001;
    __statist_i_h_wts[22,122]=-1.01291549312791e-001;
    __statist_i_h_wts[22,123]=8.67997037375109e-002;
    __statist_i_h_wts[22,124]=-3.74927922053415e-001;
    __statist_i_h_wts[22,125]=-4.73914313853243e-002;
    __statist_i_h_wts[22,126]=-3.29988027149563e-001;
    __statist_i_h_wts[22,127]=-6.31496081434003e-001;
    __statist_i_h_wts[22,128]=3.85936892887169e-001;
    __statist_i_h_wts[22,129]=-6.48635239858609e-002;
    __statist_i_h_wts[22,130]=-1.85555004834357e-001;
    __statist_i_h_wts[22,131]=-2.98595642285025e-001;
    __statist_i_h_wts[22,132]=8.89366705405192e-002;
    __statist_i_h_wts[22,133]=-1.35349733638843e-001;
    __statist_i_h_wts[22,134]=-4.19030811260931e-001;
    __statist_i_h_wts[22,135]=-4.97848887981101e-001;
    __statist_i_h_wts[22,136]=-4.28522733050131e-001;
    __statist_i_h_wts[22,137]=-1.61135755837667e-001;
    __statist_i_h_wts[22,138]=2.48179100171576e-002;
    __statist_i_h_wts[22,139]=5.20404834570398e-002;
    __statist_i_h_wts[22,140]=1.28692030065360e-001;
    __statist_i_h_wts[22,141]=-5.73636033894514e-001;
    __statist_i_h_wts[22,142]=-1.04692500071205e-001;
    __statist_i_h_wts[22,143]=7.00700532112678e-002;
    __statist_i_h_wts[22,144]=6.13942780056284e-002;
    __statist_i_h_wts[22,145]=3.27122827720957e-001;
    __statist_i_h_wts[22,146]=5.39833001661777e-001;
    __statist_i_h_wts[22,147]=9.30551917226694e-002;
    __statist_i_h_wts[22,148]=3.24403407923006e-001;
    __statist_i_h_wts[22,149]=5.59526556829639e-001;
    __statist_i_h_wts[22,150]=2.62779964898961e-001;
    __statist_i_h_wts[22,151]=2.95616936644605e-001;
    __statist_i_h_wts[22,152]=3.66046085422635e-001;
    __statist_i_h_wts[22,153]=7.72395389432770e-003;
    __statist_i_h_wts[22,154]=1.52333789418807e-001;
    __statist_i_h_wts[22,155]=2.64161033242013e-001;
    __statist_i_h_wts[22,156]=-6.70501572293938e-002;
    __statist_i_h_wts[22,157]=2.32417423631442e-001;
    __statist_i_h_wts[22,158]=3.74529375691492e-001;
    __statist_i_h_wts[22,159]=-1.97370341408510e-001;
    __statist_i_h_wts[22,160]=-1.55748027073251e-001;
    __statist_i_h_wts[22,161]=-4.31816682838890e-001;
    __statist_i_h_wts[22,162]=-3.20564190599225e-001;
    __statist_i_h_wts[22,163]=-3.48264010085672e-001;
    __statist_i_h_wts[22,164]=-4.94289036114564e-001;
    __statist_i_h_wts[22,165]=-4.49650047781955e-002;
    __statist_i_h_wts[22,166]=-1.97185543964691e-001;
    __statist_i_h_wts[22,167]=-1.00504403102621e-001;
    __statist_i_h_wts[22,168]=-4.33961572986697e-002;
    __statist_i_h_wts[22,169]=6.75681715070750e-002;
    __statist_i_h_wts[22,170]=1.78783816413383e-001;
    __statist_i_h_wts[22,171]=-8.22973757112142e-003;
    __statist_i_h_wts[22,172]=2.21597917173425e-001;
    __statist_i_h_wts[22,173]=2.17613077696269e-002;
    __statist_i_h_wts[22,174]=-4.88911617608301e-001;
    __statist_i_h_wts[22,175]=-3.78806573365094e-001;
    __statist_i_h_wts[22,176]=1.93246594351075e-001;
    __statist_i_h_wts[22,177]=1.46427601603594e-001;
    __statist_i_h_wts[22,178]=8.16737190017978e-002;
    __statist_i_h_wts[22,179]=3.88149739416616e-001;
    __statist_i_h_wts[22,180]=-8.65712300355679e-003;
    __statist_i_h_wts[22,181]=-1.16015156974543e-001;
    __statist_i_h_wts[22,182]=-5.35916903256937e-002;
    __statist_i_h_wts[22,183]=-2.07014714754821e-001;
    __statist_i_h_wts[22,184]=-1.21137843672292e-002;
    __statist_i_h_wts[22,185]=5.30319783000069e-002;
    __statist_i_h_wts[22,186]=5.43812226361632e-003;
    __statist_i_h_wts[22,187]=2.14148381444500e-001;
    __statist_i_h_wts[22,188]=2.78151326411302e-001;
    __statist_i_h_wts[22,189]=-1.05634720099210e-001;
    __statist_i_h_wts[22,190]=1.92611848866655e-001;
    __statist_i_h_wts[22,191]=4.51153065243493e-002;
    __statist_i_h_wts[22,192]=-1.67471471691939e-001;
    __statist_i_h_wts[22,193]=-2.41416918817642e-001;
    __statist_i_h_wts[22,194]=-2.89981869859929e-001;
    __statist_i_h_wts[22,195]=1.53391333835064e-001;
    __statist_i_h_wts[22,196]=1.75774162582012e-001;
    __statist_i_h_wts[22,197]=1.62694383704767e-001;
    __statist_i_h_wts[22,198]=9.70750991841560e-002;
    __statist_i_h_wts[22,199]=1.22014593048483e-001;
    __statist_i_h_wts[22,200]=2.65716129266248e-001;
    __statist_i_h_wts[22,201]=2.43428509443260e-001;
    __statist_i_h_wts[22,202]=2.14708392644548e-001;
    __statist_i_h_wts[22,203]=1.25692382520948e-001;
    __statist_i_h_wts[22,204]=9.48590824833384e-002;
    __statist_i_h_wts[22,205]=4.56637834803330e-001;
    __statist_i_h_wts[22,206]=3.41674923764905e-001;
    __statist_i_h_wts[22,207]=-2.12492788977905e-001;
    __statist_i_h_wts[22,208]=-2.78296891057195e-001;
    __statist_i_h_wts[22,209]=-2.92180499663797e-001;
    __statist_i_h_wts[22,210]=1.30222674015615e-001;
    __statist_i_h_wts[22,211]=1.87498925735516e-001;
    __statist_i_h_wts[22,212]=1.95756064189752e-001;
    __statist_i_h_wts[22,213]=4.52812956433049e-002;
    __statist_i_h_wts[22,214]=1.34085382909556e-001;
    __statist_i_h_wts[22,215]=1.51207687187430e-001;
    __statist_i_h_wts[22,216]=1.89883866455936e-001;
    __statist_i_h_wts[22,217]=8.54858546607937e-002;
    __statist_i_h_wts[22,218]=2.44034944012267e-001;
    __statist_i_h_wts[22,219]=2.92618430078785e-001;
    __statist_i_h_wts[22,220]=3.35713447084392e-001;
    __statist_i_h_wts[22,221]=1.15284984830864e-001;
    __statist_i_h_wts[22,222]=-2.12435823609397e-003;
    __statist_i_h_wts[22,223]=-3.48414327220839e-001;
    __statist_i_h_wts[22,224]=-3.52402441352879e-001;
    __statist_i_h_wts[22,225]=4.03863017956447e-001;
    __statist_i_h_wts[22,226]=2.13038100710457e-001;
    __statist_i_h_wts[22,227]=-1.08725329291293e-001;
    __statist_i_h_wts[22,228]=-9.42504553261927e-002;
    __statist_i_h_wts[22,229]=1.09246988514012e-001;
    __statist_i_h_wts[22,230]=2.14321126912761e-001;
    __statist_i_h_wts[22,231]=3.78533809673220e-001;
    __statist_i_h_wts[22,232]=8.20913979804225e-001;
    __statist_i_h_wts[22,233]=4.46196798986821e-001;
    __statist_i_h_wts[22,234]=5.23948932426953e-001;
    __statist_i_h_wts[22,235]=-5.57496158271546e-001;
    __statist_i_h_wts[22,236]=-1.18708312880268e-001;
    __statist_i_h_wts[22,237]=1.22145522112712e-001;
    __statist_i_h_wts[22,238]=1.16365884308533e-001;
    __statist_i_h_wts[22,239]=-9.63029370973375e-002;
    __statist_i_h_wts[22,240]=-2.66423272591272e-001;
    __statist_i_h_wts[22,241]=-1.08520701274457e+000;
    __statist_i_h_wts[22,242]=-1.30978935794851e-001;
    __statist_i_h_wts[22,243]=1.46613745190152e-002;
    __statist_i_h_wts[22,244]=4.62229575294811e-001;
    __statist_i_h_wts[22,245]=-5.31621374866889e-001;
    __statist_i_h_wts[22,246]=1.77500451571022e-001;
    __statist_i_h_wts[22,247]=-2.22160529323925e-001;
    __statist_i_h_wts[22,248]=2.69823644398908e-001;

    __statist_i_h_wts[23,0]=3.83689304819150e-001;
    __statist_i_h_wts[23,1]=4.65494643095297e-001;
    __statist_i_h_wts[23,2]=4.98181318878952e-001;
    __statist_i_h_wts[23,3]=4.80243604169582e-001;
    __statist_i_h_wts[23,4]=4.79585230037279e-001;
    __statist_i_h_wts[23,5]=4.43298200219176e-001;
    __statist_i_h_wts[23,6]=4.62860152842089e-001;
    __statist_i_h_wts[23,7]=4.57527349437215e-001;
    __statist_i_h_wts[23,8]=4.45783085502392e-001;
    __statist_i_h_wts[23,9]=4.88898728601287e-001;
    __statist_i_h_wts[23,10]=3.99159410274817e-001;
    __statist_i_h_wts[23,11]=3.03774799162818e-001;
    __statist_i_h_wts[23,12]=1.91062918634027e-001;
    __statist_i_h_wts[23,13]=1.97315327072928e-001;
    __statist_i_h_wts[23,14]=7.20409306422190e-002;
    __statist_i_h_wts[23,15]=3.87645856404157e-001;
    __statist_i_h_wts[23,16]=4.77487714215905e-001;
    __statist_i_h_wts[23,17]=5.35779297729096e-001;
    __statist_i_h_wts[23,18]=4.89033072143165e-001;
    __statist_i_h_wts[23,19]=5.12684193897820e-001;
    __statist_i_h_wts[23,20]=4.65288665826388e-001;
    __statist_i_h_wts[23,21]=4.91880602115089e-001;
    __statist_i_h_wts[23,22]=4.51140802948835e-001;
    __statist_i_h_wts[23,23]=4.78478763170903e-001;
    __statist_i_h_wts[23,24]=5.03656866856652e-001;
    __statist_i_h_wts[23,25]=4.63298945381132e-001;
    __statist_i_h_wts[23,26]=3.67962433938181e-001;
    __statist_i_h_wts[23,27]=2.90415722712584e-001;
    __statist_i_h_wts[23,28]=2.48177764569679e-001;
    __statist_i_h_wts[23,29]=1.13895918389053e-001;
    __statist_i_h_wts[23,30]=4.72857363618673e-001;
    __statist_i_h_wts[23,31]=5.64870164498465e-001;
    __statist_i_h_wts[23,32]=6.03901772904570e-001;
    __statist_i_h_wts[23,33]=5.84734979205207e-001;
    __statist_i_h_wts[23,34]=5.94359120490077e-001;
    __statist_i_h_wts[23,35]=5.02862892365556e-001;
    __statist_i_h_wts[23,36]=5.41296467781253e-001;
    __statist_i_h_wts[23,37]=4.43256243042906e-001;
    __statist_i_h_wts[23,38]=4.39721959295520e-001;
    __statist_i_h_wts[23,39]=4.72188086230208e-001;
    __statist_i_h_wts[23,40]=4.29737128613873e-001;
    __statist_i_h_wts[23,41]=3.27316221752870e-001;
    __statist_i_h_wts[23,42]=2.66200375050833e-001;
    __statist_i_h_wts[23,43]=2.43739046142609e-001;
    __statist_i_h_wts[23,44]=1.41539543027482e-001;
    __statist_i_h_wts[23,45]=3.66697192554414e-001;
    __statist_i_h_wts[23,46]=5.13116094064566e-001;
    __statist_i_h_wts[23,47]=5.46607029928899e-001;
    __statist_i_h_wts[23,48]=5.19252068921039e-001;
    __statist_i_h_wts[23,49]=5.30430002838349e-001;
    __statist_i_h_wts[23,50]=5.11090635098868e-001;
    __statist_i_h_wts[23,51]=4.78810609217185e-001;
    __statist_i_h_wts[23,52]=4.91800363104292e-001;
    __statist_i_h_wts[23,53]=4.36190615494632e-001;
    __statist_i_h_wts[23,54]=4.83186380202409e-001;
    __statist_i_h_wts[23,55]=4.19647950058727e-001;
    __statist_i_h_wts[23,56]=3.58016491818775e-001;
    __statist_i_h_wts[23,57]=2.64740738361268e-001;
    __statist_i_h_wts[23,58]=2.59254836024765e-001;
    __statist_i_h_wts[23,59]=1.16514680999702e-001;
    __statist_i_h_wts[23,60]=2.27869927857387e-001;
    __statist_i_h_wts[23,61]=3.16103206193303e-001;
    __statist_i_h_wts[23,62]=3.36245044231664e-001;
    __statist_i_h_wts[23,63]=3.69912621340790e-001;
    __statist_i_h_wts[23,64]=3.58724475001459e-001;
    __statist_i_h_wts[23,65]=2.71400661160299e-001;
    __statist_i_h_wts[23,66]=3.82071794208075e-001;
    __statist_i_h_wts[23,67]=3.39266906368471e-001;
    __statist_i_h_wts[23,68]=3.52140140644853e-001;
    __statist_i_h_wts[23,69]=4.23230452185633e-001;
    __statist_i_h_wts[23,70]=4.12319593940700e-001;
    __statist_i_h_wts[23,71]=3.09900091430504e-001;
    __statist_i_h_wts[23,72]=2.86940070618141e-001;
    __statist_i_h_wts[23,73]=2.19660334082326e-001;
    __statist_i_h_wts[23,74]=1.26983961918796e-001;
    __statist_i_h_wts[23,75]=2.52617570287603e-002;
    __statist_i_h_wts[23,76]=1.04613497970346e-001;
    __statist_i_h_wts[23,77]=4.92355999661349e-002;
    __statist_i_h_wts[23,78]=1.29313720796335e-001;
    __statist_i_h_wts[23,79]=1.42986506730671e-001;
    __statist_i_h_wts[23,80]=1.69810869880152e-001;
    __statist_i_h_wts[23,81]=2.27464605611875e-001;
    __statist_i_h_wts[23,82]=1.85951085080811e-001;
    __statist_i_h_wts[23,83]=1.47357553809112e-001;
    __statist_i_h_wts[23,84]=2.34243806412011e-001;
    __statist_i_h_wts[23,85]=2.18908536361830e-001;
    __statist_i_h_wts[23,86]=1.68941933985868e-001;
    __statist_i_h_wts[23,87]=2.27173926320634e-001;
    __statist_i_h_wts[23,88]=1.07627696112124e-001;
    __statist_i_h_wts[23,89]=2.70157426438079e-002;
    __statist_i_h_wts[23,90]=-1.14050480791003e-001;
    __statist_i_h_wts[23,91]=-6.57077129395801e-002;
    __statist_i_h_wts[23,92]=-2.04155504318092e-002;
    __statist_i_h_wts[23,93]=5.85878617552484e-002;
    __statist_i_h_wts[23,94]=1.87236224033027e-002;
    __statist_i_h_wts[23,95]=-3.54771099564805e-002;
    __statist_i_h_wts[23,96]=5.73121947893457e-002;
    __statist_i_h_wts[23,97]=-2.24978167138872e-002;
    __statist_i_h_wts[23,98]=-9.01453001943912e-002;
    __statist_i_h_wts[23,99]=4.86856142852919e-002;
    __statist_i_h_wts[23,100]=5.30249229089396e-002;
    __statist_i_h_wts[23,101]=3.21351892229260e-003;
    __statist_i_h_wts[23,102]=8.32962695254482e-002;
    __statist_i_h_wts[23,103]=3.77725491835838e-002;
    __statist_i_h_wts[23,104]=-9.14529211245074e-003;
    __statist_i_h_wts[23,105]=-2.16349934770318e-001;
    __statist_i_h_wts[23,106]=-2.53764307596980e-001;
    __statist_i_h_wts[23,107]=-2.52898231898896e-001;
    __statist_i_h_wts[23,108]=-2.61992096476583e-001;
    __statist_i_h_wts[23,109]=-2.28166293116131e-001;
    __statist_i_h_wts[23,110]=-2.21665460516188e-001;
    __statist_i_h_wts[23,111]=-9.54690529845338e-002;
    __statist_i_h_wts[23,112]=-1.55767910359022e-001;
    __statist_i_h_wts[23,113]=-1.62597335160982e-001;
    __statist_i_h_wts[23,114]=-8.81043751652727e-002;
    __statist_i_h_wts[23,115]=-5.20442780443415e-002;
    __statist_i_h_wts[23,116]=-1.05607573056320e-001;
    __statist_i_h_wts[23,117]=-2.85284263253185e-003;
    __statist_i_h_wts[23,118]=-7.88640280640524e-002;
    __statist_i_h_wts[23,119]=-6.19981686288040e-002;
    __statist_i_h_wts[23,120]=-3.86019789944761e-001;
    __statist_i_h_wts[23,121]=-4.73972066839608e-001;
    __statist_i_h_wts[23,122]=-4.30522204118611e-001;
    __statist_i_h_wts[23,123]=-4.55849042841687e-001;
    __statist_i_h_wts[23,124]=-4.34161878792706e-001;
    __statist_i_h_wts[23,125]=-3.38931400591564e-001;
    __statist_i_h_wts[23,126]=-2.70528188820313e-001;
    __statist_i_h_wts[23,127]=-2.93786315628191e-001;
    __statist_i_h_wts[23,128]=-2.69976590512495e-001;
    __statist_i_h_wts[23,129]=-2.62171292122258e-001;
    __statist_i_h_wts[23,130]=-1.30544147020185e-001;
    __statist_i_h_wts[23,131]=-1.82603980664070e-001;
    __statist_i_h_wts[23,132]=-1.85587864785071e-001;
    __statist_i_h_wts[23,133]=-2.07496466993895e-001;
    __statist_i_h_wts[23,134]=-1.43969223576325e-001;
    __statist_i_h_wts[23,135]=-3.57168949933480e-001;
    __statist_i_h_wts[23,136]=-5.23093687247039e-001;
    __statist_i_h_wts[23,137]=-4.64011723384060e-001;
    __statist_i_h_wts[23,138]=-4.58954539737954e-001;
    __statist_i_h_wts[23,139]=-4.17715712099601e-001;
    __statist_i_h_wts[23,140]=-4.09909093458797e-001;
    __statist_i_h_wts[23,141]=-4.11586926716357e-001;
    __statist_i_h_wts[23,142]=-4.41983791822766e-001;
    __statist_i_h_wts[23,143]=-3.93703039364104e-001;
    __statist_i_h_wts[23,144]=-3.47572773811708e-001;
    __statist_i_h_wts[23,145]=-1.92638223234103e-001;
    __statist_i_h_wts[23,146]=-1.82535705600746e-001;
    __statist_i_h_wts[23,147]=-1.48465293740048e-001;
    __statist_i_h_wts[23,148]=-1.78177928816041e-001;
    __statist_i_h_wts[23,149]=-4.93114908982985e-002;
    __statist_i_h_wts[23,150]=-2.92635635119344e-001;
    __statist_i_h_wts[23,151]=-5.09958635588462e-001;
    __statist_i_h_wts[23,152]=-4.53848477474233e-001;
    __statist_i_h_wts[23,153]=-5.41674325407979e-001;
    __statist_i_h_wts[23,154]=-4.66171694539050e-001;
    __statist_i_h_wts[23,155]=-4.29395395020557e-001;
    __statist_i_h_wts[23,156]=-4.46953799791940e-001;
    __statist_i_h_wts[23,157]=-4.27807567068407e-001;
    __statist_i_h_wts[23,158]=-3.57620237968520e-001;
    __statist_i_h_wts[23,159]=-3.62558216976129e-001;
    __statist_i_h_wts[23,160]=-2.58034534266044e-001;
    __statist_i_h_wts[23,161]=-2.68896344101349e-001;
    __statist_i_h_wts[23,162]=-2.47870597883516e-001;
    __statist_i_h_wts[23,163]=-2.93020007264696e-001;
    __statist_i_h_wts[23,164]=-1.54997049029509e-001;
    __statist_i_h_wts[23,165]=-3.39734729394163e-001;
    __statist_i_h_wts[23,166]=-4.78149773345842e-001;
    __statist_i_h_wts[23,167]=-4.52128051488641e-001;
    __statist_i_h_wts[23,168]=-5.71792482494124e-001;
    __statist_i_h_wts[23,169]=-5.12127865490933e-001;
    __statist_i_h_wts[23,170]=-4.15572496945509e-001;
    __statist_i_h_wts[23,171]=-4.45195338460862e-001;
    __statist_i_h_wts[23,172]=-4.59913660873252e-001;
    __statist_i_h_wts[23,173]=-3.57940537058901e-001;
    __statist_i_h_wts[23,174]=-3.76088580867509e-001;
    __statist_i_h_wts[23,175]=-3.92149723986615e-001;
    __statist_i_h_wts[23,176]=-3.46891884633161e-001;
    __statist_i_h_wts[23,177]=-2.64090913574483e-001;
    __statist_i_h_wts[23,178]=-3.17475670067367e-001;
    __statist_i_h_wts[23,179]=-1.53760078882052e-001;
    __statist_i_h_wts[23,180]=-3.55941386135250e-001;
    __statist_i_h_wts[23,181]=-4.83255579653313e-001;
    __statist_i_h_wts[23,182]=-5.31676859352041e-001;
    __statist_i_h_wts[23,183]=-5.61914057357215e-001;
    __statist_i_h_wts[23,184]=-5.28291245953153e-001;
    __statist_i_h_wts[23,185]=-4.32220013324007e-001;
    __statist_i_h_wts[23,186]=-4.93518077388055e-001;
    __statist_i_h_wts[23,187]=-5.04272873630720e-001;
    __statist_i_h_wts[23,188]=-3.88065895986868e-001;
    __statist_i_h_wts[23,189]=-3.90459589406438e-001;
    __statist_i_h_wts[23,190]=-4.32217930271814e-001;
    __statist_i_h_wts[23,191]=-4.09309529315244e-001;
    __statist_i_h_wts[23,192]=-3.30805178877389e-001;
    __statist_i_h_wts[23,193]=-4.05407129728017e-001;
    __statist_i_h_wts[23,194]=-2.93066725134170e-001;
    __statist_i_h_wts[23,195]=-3.25124881460626e-001;
    __statist_i_h_wts[23,196]=-4.03281568884471e-001;
    __statist_i_h_wts[23,197]=-4.12291597946737e-001;
    __statist_i_h_wts[23,198]=-4.33379058061729e-001;
    __statist_i_h_wts[23,199]=-3.72657962609509e-001;
    __statist_i_h_wts[23,200]=-4.36402083756359e-001;
    __statist_i_h_wts[23,201]=-4.39823459792632e-001;
    __statist_i_h_wts[23,202]=-4.58500505717777e-001;
    __statist_i_h_wts[23,203]=-3.45412794718956e-001;
    __statist_i_h_wts[23,204]=-3.66817539801271e-001;
    __statist_i_h_wts[23,205]=-3.04802598788969e-001;
    __statist_i_h_wts[23,206]=-2.57692564970656e-001;
    __statist_i_h_wts[23,207]=-2.29661503267986e-001;
    __statist_i_h_wts[23,208]=-2.96305029427041e-001;
    __statist_i_h_wts[23,209]=-1.69667444574423e-001;
    __statist_i_h_wts[23,210]=-2.84648695735061e-001;
    __statist_i_h_wts[23,211]=-3.62336352733088e-001;
    __statist_i_h_wts[23,212]=-4.18559224419905e-001;
    __statist_i_h_wts[23,213]=-4.15853508580121e-001;
    __statist_i_h_wts[23,214]=-4.48276002848576e-001;
    __statist_i_h_wts[23,215]=-5.05713851756600e-001;
    __statist_i_h_wts[23,216]=-4.65932290377811e-001;
    __statist_i_h_wts[23,217]=-4.91562347133032e-001;
    __statist_i_h_wts[23,218]=-4.02905490639523e-001;
    __statist_i_h_wts[23,219]=-3.28269580462365e-001;
    __statist_i_h_wts[23,220]=-2.50105102363626e-001;
    __statist_i_h_wts[23,221]=-2.11263373284307e-001;
    __statist_i_h_wts[23,222]=-1.89474824761503e-001;
    __statist_i_h_wts[23,223]=-2.44855412108413e-001;
    __statist_i_h_wts[23,224]=-1.97337789587667e-001;
    __statist_i_h_wts[23,225]=2.85815752239851e-002;
    __statist_i_h_wts[23,226]=5.90111491681547e-001;
    __statist_i_h_wts[23,227]=6.25262162580501e-002;
    __statist_i_h_wts[23,228]=5.14287200666159e-001;
    __statist_i_h_wts[23,229]=6.26750846166201e-002;
    __statist_i_h_wts[23,230]=-6.93866577205980e-001;
    __statist_i_h_wts[23,231]=-1.97272102592916e-001;
    __statist_i_h_wts[23,232]=-8.11647814258184e-001;
    __statist_i_h_wts[23,233]=-4.02196810053149e-001;
    __statist_i_h_wts[23,234]=-8.69900030642138e-001;
    __statist_i_h_wts[23,235]=8.42490981973614e-002;
    __statist_i_h_wts[23,236]=8.78318779159490e-001;
    __statist_i_h_wts[23,237]=8.88918051299841e-001;
    __statist_i_h_wts[23,238]=1.97315981448888e-001;
    __statist_i_h_wts[23,239]=-7.61770746207459e-001;
    __statist_i_h_wts[23,240]=2.02888306752267e-001;
    __statist_i_h_wts[23,241]=-1.45246311494060e+000;
    __statist_i_h_wts[23,242]=-8.19301597840174e-002;
    __statist_i_h_wts[23,243]=-7.60072298006510e-001;
    __statist_i_h_wts[23,244]=-1.45479537543315e-002;
    __statist_i_h_wts[23,245]=1.01234401627347e+000;
    __statist_i_h_wts[23,246]=-2.24308769693492e-001;
    __statist_i_h_wts[23,247]=6.92330689111181e-001;
    __statist_i_h_wts[23,248]=-4.34593521041415e-002;

    __statist_i_h_wts[24,0]=-2.32229199719922e-002;
    __statist_i_h_wts[24,1]=-8.62111320011688e-003;
    __statist_i_h_wts[24,2]=-1.53104361082308e-002;
    __statist_i_h_wts[24,3]=-2.71398382599479e-002;
    __statist_i_h_wts[24,4]=-1.00485379896160e-002;
    __statist_i_h_wts[24,5]=-3.84746307713655e-003;
    __statist_i_h_wts[24,6]=-3.03024617880634e-002;
    __statist_i_h_wts[24,7]=-5.49016073120757e-002;
    __statist_i_h_wts[24,8]=8.33964062000904e-002;
    __statist_i_h_wts[24,9]=3.62051396697276e-002;
    __statist_i_h_wts[24,10]=2.83703792168712e-002;
    __statist_i_h_wts[24,11]=4.19561680094491e-002;
    __statist_i_h_wts[24,12]=-4.36291112423064e-002;
    __statist_i_h_wts[24,13]=-7.95155040113394e-002;
    __statist_i_h_wts[24,14]=2.53839938446254e-001;
    __statist_i_h_wts[24,15]=1.17793878049955e-001;
    __statist_i_h_wts[24,16]=1.21737889495079e-001;
    __statist_i_h_wts[24,17]=1.35791811153132e-001;
    __statist_i_h_wts[24,18]=1.55212380822597e-002;
    __statist_i_h_wts[24,19]=1.22403725580348e-001;
    __statist_i_h_wts[24,20]=1.12635258803950e-001;
    __statist_i_h_wts[24,21]=9.24321592181848e-002;
    __statist_i_h_wts[24,22]=-7.77729418371480e-002;
    __statist_i_h_wts[24,23]=9.53652440852746e-002;
    __statist_i_h_wts[24,24]=1.26697428680362e-001;
    __statist_i_h_wts[24,25]=6.57876306734726e-002;
    __statist_i_h_wts[24,26]=4.58170944961498e-002;
    __statist_i_h_wts[24,27]=-2.10043885149473e-002;
    __statist_i_h_wts[24,28]=-4.81078702638568e-002;
    __statist_i_h_wts[24,29]=2.21416062694540e-001;
    __statist_i_h_wts[24,30]=8.99212861329593e-002;
    __statist_i_h_wts[24,31]=8.03114928732380e-002;
    __statist_i_h_wts[24,32]=2.12808187324129e-001;
    __statist_i_h_wts[24,33]=3.56641837989894e-002;
    __statist_i_h_wts[24,34]=1.76117704654715e-001;
    __statist_i_h_wts[24,35]=1.11742777742165e-001;
    __statist_i_h_wts[24,36]=4.63424751081861e-002;
    __statist_i_h_wts[24,37]=-1.20902390210304e-002;
    __statist_i_h_wts[24,38]=2.67403933800948e-002;
    __statist_i_h_wts[24,39]=-7.66200536399043e-002;
    __statist_i_h_wts[24,40]=7.85260382758695e-002;
    __statist_i_h_wts[24,41]=9.57560290390821e-002;
    __statist_i_h_wts[24,42]=6.16638302960251e-002;
    __statist_i_h_wts[24,43]=-3.31699807985216e-004;
    __statist_i_h_wts[24,44]=-1.85917555773645e-002;
    __statist_i_h_wts[24,45]=1.18276623845952e-001;
    __statist_i_h_wts[24,46]=-5.64052652866950e-002;
    __statist_i_h_wts[24,47]=-1.03179330303140e-001;
    __statist_i_h_wts[24,48]=1.87419098197871e-002;
    __statist_i_h_wts[24,49]=1.32677113882991e-001;
    __statist_i_h_wts[24,50]=1.26847915556070e-001;
    __statist_i_h_wts[24,51]=-5.73617150240410e-002;
    __statist_i_h_wts[24,52]=-4.67524530767548e-002;
    __statist_i_h_wts[24,53]=-1.06845801855221e-001;
    __statist_i_h_wts[24,54]=9.80454700097293e-002;
    __statist_i_h_wts[24,55]=1.43510791842630e-001;
    __statist_i_h_wts[24,56]=1.55487174282939e-001;
    __statist_i_h_wts[24,57]=1.17466530265718e-001;
    __statist_i_h_wts[24,58]=7.47850582407219e-002;
    __statist_i_h_wts[24,59]=-7.70320902368521e-002;
    __statist_i_h_wts[24,60]=1.74695667369961e-001;
    __statist_i_h_wts[24,61]=-7.43227951964134e-003;
    __statist_i_h_wts[24,62]=1.32937864787430e-001;
    __statist_i_h_wts[24,63]=1.75403046603328e-001;
    __statist_i_h_wts[24,64]=8.77007415497621e-002;
    __statist_i_h_wts[24,65]=1.03372648007543e-001;
    __statist_i_h_wts[24,66]=-5.41782107515504e-002;
    __statist_i_h_wts[24,67]=-1.19207087562257e-001;
    __statist_i_h_wts[24,68]=-1.26670622761821e-001;
    __statist_i_h_wts[24,69]=1.09206657577074e-001;
    __statist_i_h_wts[24,70]=9.90734580404963e-002;
    __statist_i_h_wts[24,71]=1.36198009732114e-001;
    __statist_i_h_wts[24,72]=1.34431635049042e-001;
    __statist_i_h_wts[24,73]=1.86906030622307e-001;
    __statist_i_h_wts[24,74]=1.97289644691278e-001;
    __statist_i_h_wts[24,75]=1.09374596269657e-001;
    __statist_i_h_wts[24,76]=-2.02582273814336e-004;
    __statist_i_h_wts[24,77]=1.01568282545452e-001;
    __statist_i_h_wts[24,78]=2.58166043628914e-002;
    __statist_i_h_wts[24,79]=-5.05070881236915e-002;
    __statist_i_h_wts[24,80]=3.12506542935664e-002;
    __statist_i_h_wts[24,81]=-7.61128541990448e-002;
    __statist_i_h_wts[24,82]=5.22608888025050e-002;
    __statist_i_h_wts[24,83]=1.33585052782770e-001;
    __statist_i_h_wts[24,84]=4.65195336897101e-002;
    __statist_i_h_wts[24,85]=9.78462687584185e-002;
    __statist_i_h_wts[24,86]=-7.64790376809460e-002;
    __statist_i_h_wts[24,87]=-1.87906697422238e-001;
    __statist_i_h_wts[24,88]=1.39868083442944e-002;
    __statist_i_h_wts[24,89]=-9.31021147631451e-002;
    __statist_i_h_wts[24,90]=1.63896845921841e-001;
    __statist_i_h_wts[24,91]=1.50459587744524e-001;
    __statist_i_h_wts[24,92]=1.16835738578868e-002;
    __statist_i_h_wts[24,93]=-1.77097079844032e-002;
    __statist_i_h_wts[24,94]=-1.31211911030549e-001;
    __statist_i_h_wts[24,95]=2.10702551456244e-001;
    __statist_i_h_wts[24,96]=7.95534288664732e-002;
    __statist_i_h_wts[24,97]=1.43753343244722e-002;
    __statist_i_h_wts[24,98]=1.85023088277862e-001;
    __statist_i_h_wts[24,99]=-7.96498255799313e-002;
    __statist_i_h_wts[24,100]=5.40490637777610e-002;
    __statist_i_h_wts[24,101]=1.61079086431852e-001;
    __statist_i_h_wts[24,102]=-6.27234651560483e-002;
    __statist_i_h_wts[24,103]=1.39599400827954e-001;
    __statist_i_h_wts[24,104]=8.75015565514122e-002;
    __statist_i_h_wts[24,105]=-4.46138013503076e-002;
    __statist_i_h_wts[24,106]=7.36926511882139e-002;
    __statist_i_h_wts[24,107]=-2.57565639001776e-002;
    __statist_i_h_wts[24,108]=-2.16418140282945e-001;
    __statist_i_h_wts[24,109]=-3.09677536784332e-002;
    __statist_i_h_wts[24,110]=-3.50404882748498e-002;
    __statist_i_h_wts[24,111]=-6.09054235559147e-002;
    __statist_i_h_wts[24,112]=8.62001155859200e-002;
    __statist_i_h_wts[24,113]=-6.17082815545961e-002;
    __statist_i_h_wts[24,114]=9.02925137656189e-002;
    __statist_i_h_wts[24,115]=4.97925749231969e-002;
    __statist_i_h_wts[24,116]=-3.89312938863604e-002;
    __statist_i_h_wts[24,117]=1.61832138038869e-002;
    __statist_i_h_wts[24,118]=1.17460880805873e-001;
    __statist_i_h_wts[24,119]=-3.15740484470861e-002;
    __statist_i_h_wts[24,120]=-8.06174696905285e-002;
    __statist_i_h_wts[24,121]=4.20271598538223e-002;
    __statist_i_h_wts[24,122]=-1.12222016661870e-002;
    __statist_i_h_wts[24,123]=3.95276703888819e-003;
    __statist_i_h_wts[24,124]=1.31121129277222e-001;
    __statist_i_h_wts[24,125]=1.12282220668061e-001;
    __statist_i_h_wts[24,126]=1.05148107763254e-001;
    __statist_i_h_wts[24,127]=1.69575253885689e-001;
    __statist_i_h_wts[24,128]=-1.76129709910766e-001;
    __statist_i_h_wts[24,129]=-1.07661889611825e-001;
    __statist_i_h_wts[24,130]=-1.48728765426037e-002;
    __statist_i_h_wts[24,131]=-1.37897922853890e-002;
    __statist_i_h_wts[24,132]=-1.71231697842245e-001;
    __statist_i_h_wts[24,133]=-7.05399662141138e-002;
    __statist_i_h_wts[24,134]=1.69619162879225e-002;
    __statist_i_h_wts[24,135]=1.25199421396722e-002;
    __statist_i_h_wts[24,136]=4.59525605497052e-002;
    __statist_i_h_wts[24,137]=-2.39268669302541e-002;
    __statist_i_h_wts[24,138]=-3.35854573219678e-003;
    __statist_i_h_wts[24,139]=1.04303458871945e-002;
    __statist_i_h_wts[24,140]=-1.35721874134418e-002;
    __statist_i_h_wts[24,141]=7.04190139224822e-002;
    __statist_i_h_wts[24,142]=-3.96782333863566e-002;
    __statist_i_h_wts[24,143]=-1.76055189608214e-001;
    __statist_i_h_wts[24,144]=-2.04902176519254e-001;
    __statist_i_h_wts[24,145]=-1.79578708702240e-001;
    __statist_i_h_wts[24,146]=-5.09607051997111e-002;
    __statist_i_h_wts[24,147]=-9.85663468239891e-003;
    __statist_i_h_wts[24,148]=-1.05912534236482e-001;
    __statist_i_h_wts[24,149]=-1.11878410016959e-001;
    __statist_i_h_wts[24,150]=-2.29333816688312e-001;
    __statist_i_h_wts[24,151]=-1.86799205558202e-001;
    __statist_i_h_wts[24,152]=-1.84378390412234e-001;
    __statist_i_h_wts[24,153]=1.76395219868166e-002;
    __statist_i_h_wts[24,154]=9.69092215502861e-004;
    __statist_i_h_wts[24,155]=-3.82777211437969e-002;
    __statist_i_h_wts[24,156]=1.17319313105359e-001;
    __statist_i_h_wts[24,157]=4.75759500470130e-002;
    __statist_i_h_wts[24,158]=-2.69379799108051e-001;
    __statist_i_h_wts[24,159]=-1.98302277704743e-001;
    __statist_i_h_wts[24,160]=-6.49283387379999e-002;
    __statist_i_h_wts[24,161]=2.18218436844066e-001;
    __statist_i_h_wts[24,162]=8.16015961387512e-002;
    __statist_i_h_wts[24,163]=1.92925495602505e-001;
    __statist_i_h_wts[24,164]=2.63162926742582e-001;
    __statist_i_h_wts[24,165]=-2.91722136525345e-002;
    __statist_i_h_wts[24,166]=1.65744849160532e-002;
    __statist_i_h_wts[24,167]=-1.98484253886892e-002;
    __statist_i_h_wts[24,168]=-1.19696023041178e-002;
    __statist_i_h_wts[24,169]=-9.31580746024125e-003;
    __statist_i_h_wts[24,170]=-4.78072257960415e-002;
    __statist_i_h_wts[24,171]=-1.43875444599225e-002;
    __statist_i_h_wts[24,172]=-2.46719471284549e-002;
    __statist_i_h_wts[24,173]=-6.41100287215304e-002;
    __statist_i_h_wts[24,174]=-3.62019775505130e-002;
    __statist_i_h_wts[24,175]=-6.75305243232446e-003;
    __statist_i_h_wts[24,176]=-1.24320995135048e-001;
    __statist_i_h_wts[24,177]=-1.38913378090422e-001;
    __statist_i_h_wts[24,178]=-1.47695021091563e-001;
    __statist_i_h_wts[24,179]=-1.87620554872671e-001;
    __statist_i_h_wts[24,180]=-6.84706543309147e-003;
    __statist_i_h_wts[24,181]=-2.03297311313095e-002;
    __statist_i_h_wts[24,182]=-1.62807842855674e-002;
    __statist_i_h_wts[24,183]=2.76363142959434e-002;
    __statist_i_h_wts[24,184]=-1.63199885928314e-002;
    __statist_i_h_wts[24,185]=-2.76937563135953e-002;
    __statist_i_h_wts[24,186]=-1.41422906746887e-002;
    __statist_i_h_wts[24,187]=5.66036047349476e-003;
    __statist_i_h_wts[24,188]=-6.72672824179411e-002;
    __statist_i_h_wts[24,189]=-3.30790686640870e-002;
    __statist_i_h_wts[24,190]=-3.66871783235955e-002;
    __statist_i_h_wts[24,191]=-4.18241720703826e-002;
    __statist_i_h_wts[24,192]=-7.54889708298034e-002;
    __statist_i_h_wts[24,193]=-5.83765719093922e-002;
    __statist_i_h_wts[24,194]=-4.94321994978904e-002;
    __statist_i_h_wts[24,195]=4.53933304574162e-004;
    __statist_i_h_wts[24,196]=-7.27099103011143e-003;
    __statist_i_h_wts[24,197]=1.36047845713873e-004;
    __statist_i_h_wts[24,198]=1.63973390776617e-002;
    __statist_i_h_wts[24,199]=-3.20973643167820e-003;
    __statist_i_h_wts[24,200]=-2.38605586353011e-002;
    __statist_i_h_wts[24,201]=-4.08421558144545e-002;
    __statist_i_h_wts[24,202]=-1.37772341590464e-002;
    __statist_i_h_wts[24,203]=-3.47958651443193e-003;
    __statist_i_h_wts[24,204]=-1.61070289070616e-002;
    __statist_i_h_wts[24,205]=-3.79266250488471e-002;
    __statist_i_h_wts[24,206]=-2.89738343939992e-002;
    __statist_i_h_wts[24,207]=2.88889093865476e-002;
    __statist_i_h_wts[24,208]=7.53658748281835e-002;
    __statist_i_h_wts[24,209]=6.72816454720884e-002;
    __statist_i_h_wts[24,210]=3.88643693639253e-002;
    __statist_i_h_wts[24,211]=1.99835766284748e-002;
    __statist_i_h_wts[24,212]=5.23726894925202e-002;
    __statist_i_h_wts[24,213]=9.90172094183710e-002;
    __statist_i_h_wts[24,214]=6.51183339149093e-002;
    __statist_i_h_wts[24,215]=3.07784394381935e-002;
    __statist_i_h_wts[24,216]=2.59092860560436e-002;
    __statist_i_h_wts[24,217]=9.03115999256993e-002;
    __statist_i_h_wts[24,218]=3.64004054554579e-002;
    __statist_i_h_wts[24,219]=-3.27116859853920e-002;
    __statist_i_h_wts[24,220]=-4.13201153711872e-002;
    __statist_i_h_wts[24,221]=-3.90137113865906e-002;
    __statist_i_h_wts[24,222]=-4.66150155479979e-002;
    __statist_i_h_wts[24,223]=8.88659436065193e-002;
    __statist_i_h_wts[24,224]=9.14144914084321e-002;
    __statist_i_h_wts[24,225]=-7.82947681134470e-002;
    __statist_i_h_wts[24,226]=3.20913239054786e-002;
    __statist_i_h_wts[24,227]=6.84265108111135e-002;
    __statist_i_h_wts[24,228]=1.88275462732693e-001;
    __statist_i_h_wts[24,229]=3.97215361008109e-002;
    __statist_i_h_wts[24,230]=-1.21740478096780e-001;
    __statist_i_h_wts[24,231]=-1.06530140309543e-001;
    __statist_i_h_wts[24,232]=-2.14451019913455e-001;
    __statist_i_h_wts[24,233]=-2.17793141082881e-001;
    __statist_i_h_wts[24,234]=-9.63144769629882e-002;
    __statist_i_h_wts[24,235]=2.86640107489231e-001;
    __statist_i_h_wts[24,236]=7.31405041986731e-002;
    __statist_i_h_wts[24,237]=8.88749498645279e-002;
    __statist_i_h_wts[24,238]=1.65647199379789e-001;
    __statist_i_h_wts[24,239]=8.24174915988328e-002;
    __statist_i_h_wts[24,240]=-2.20515496185139e-002;
    __statist_i_h_wts[24,241]=1.64727573409626e-001;
    __statist_i_h_wts[24,242]=-8.07905338652868e-002;
    __statist_i_h_wts[24,243]=-1.11840056170898e-001;
    __statist_i_h_wts[24,244]=1.11110760557988e-001;
    __statist_i_h_wts[24,245]=1.61869622143468e-001;
    __statist_i_h_wts[24,246]=2.96146645228784e-002;
    __statist_i_h_wts[24,247]=1.40524842989369e-001;
    __statist_i_h_wts[24,248]=1.18789128092706e-001;

    double[,] __statist_h_o_wts = new double[2,25];

    __statist_h_o_wts[0,0]=5.78779305767557e-001;
    __statist_h_o_wts[0,1]=-1.00530166350194e+000;
    __statist_h_o_wts[0,2]=-2.80217806191262e-001;
    __statist_h_o_wts[0,3]=-5.84302480550206e-001;
    __statist_h_o_wts[0,4]=-1.60918906559917e+000;
    __statist_h_o_wts[0,5]=-1.35028372302999e+000;
    __statist_h_o_wts[0,6]=1.13694134987409e+000;
    __statist_h_o_wts[0,7]=1.29224370579660e+000;
    __statist_h_o_wts[0,8]=4.61890125671357e-001;
    __statist_h_o_wts[0,9]=9.94432246276153e-001;
    __statist_h_o_wts[0,10]=2.20588109656464e-001;
    __statist_h_o_wts[0,11]=-9.29027309052869e-001;
    __statist_h_o_wts[0,12]=5.28347549640488e-001;
    __statist_h_o_wts[0,13]=1.00487886055182e+000;
    __statist_h_o_wts[0,14]=-6.38156672700560e-001;
    __statist_h_o_wts[0,15]=4.32059390946954e-001;
    __statist_h_o_wts[0,16]=7.10301490133014e-001;
    __statist_h_o_wts[0,17]=1.15641055155813e+000;
    __statist_h_o_wts[0,18]=-5.30839732668164e-001;
    __statist_h_o_wts[0,19]=5.06658463967225e-001;
    __statist_h_o_wts[0,20]=-1.50344557707141e+000;
    __statist_h_o_wts[0,21]=-2.94409465475001e+000;
    __statist_h_o_wts[0,22]=1.24427229164417e+000;
    __statist_h_o_wts[0,23]=-2.30705426184000e-001;
    __statist_h_o_wts[0,24]=-3.67635128358495e-002;

    __statist_h_o_wts[1,0]=-5.90130442195741e-001;
    __statist_h_o_wts[1,1]=1.03328538960775e+000;
    __statist_h_o_wts[1,2]=2.78231019900089e-001;
    __statist_h_o_wts[1,3]=5.54433861869195e-001;
    __statist_h_o_wts[1,4]=1.67437350680060e+000;
    __statist_h_o_wts[1,5]=1.35124327171144e+000;
    __statist_h_o_wts[1,6]=-1.10799069100960e+000;
    __statist_h_o_wts[1,7]=-1.27588886818726e+000;
    __statist_h_o_wts[1,8]=-4.80608892702801e-001;
    __statist_h_o_wts[1,9]=-9.38966877555484e-001;
    __statist_h_o_wts[1,10]=-2.91397628133713e-001;
    __statist_h_o_wts[1,11]=9.30197117499975e-001;
    __statist_h_o_wts[1,12]=-4.99627561593164e-001;
    __statist_h_o_wts[1,13]=-1.00192445334561e+000;
    __statist_h_o_wts[1,14]=6.33575145508600e-001;
    __statist_h_o_wts[1,15]=-3.89556664893893e-001;
    __statist_h_o_wts[1,16]=-6.62515076400628e-001;
    __statist_h_o_wts[1,17]=-1.16550632965469e+000;
    __statist_h_o_wts[1,18]=5.31427087329357e-001;
    __statist_h_o_wts[1,19]=-4.42394174508237e-001;
    __statist_h_o_wts[1,20]=1.54897918712629e+000;
    __statist_h_o_wts[1,21]=2.91483494080125e+000;
    __statist_h_o_wts[1,22]=-1.28267493719219e+000;
    __statist_h_o_wts[1,23]=2.46118337265745e-001;
    __statist_h_o_wts[1,24]=6.14444404169379e-002;

    double[] __statist_hidden_bias = new double[25];
    __statist_hidden_bias[0]=4.90388688609127e-002;
    __statist_hidden_bias[1]=-2.16155983421345e-001;
    __statist_hidden_bias[2]=-8.87256375027892e-002;
    __statist_hidden_bias[3]=-7.56240916105686e-001;
    __statist_hidden_bias[4]=-2.50327972104318e+000;
    __statist_hidden_bias[5]=-1.13717608000993e+000;
    __statist_hidden_bias[6]=3.99081630038868e-001;
    __statist_hidden_bias[7]=2.23661252702625e-001;
    __statist_hidden_bias[8]=6.02785050951269e-003;
    __statist_hidden_bias[9]=2.32026891174741e-001;
    __statist_hidden_bias[10]=1.67867000769482e-001;
    __statist_hidden_bias[11]=-3.11642032292045e-001;
    __statist_hidden_bias[12]=3.21621956271758e-001;
    __statist_hidden_bias[13]=9.59473587326394e-001;
    __statist_hidden_bias[14]=-3.65848875937797e-001;
    __statist_hidden_bias[15]=-2.55337239555856e-001;
    __statist_hidden_bias[16]=2.38651536621822e-001;
    __statist_hidden_bias[17]=1.33720290939662e-001;
    __statist_hidden_bias[18]=-5.89506875101009e-002;
    __statist_hidden_bias[19]=7.02385513166681e-002;
    __statist_hidden_bias[20]=-1.97333505885916e-001;
    __statist_hidden_bias[21]=-6.78086269154612e-001;
    __statist_hidden_bias[22]=3.08364789814545e-001;
    __statist_hidden_bias[23]=-1.40004722527254e-001;
    __statist_hidden_bias[24]=-6.50364524935631e-002;

    double[] __statist_output_bias = new double[2];
    __statist_output_bias[0]=8.63065197774858e-001;
    __statist_output_bias[1]=-8.68683713907424e-001;

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

      Console.WriteLine(" Predict24925287_низed Category = " + __statist_PredCat);
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
       string Comment2 = "Please enter at least 249 command line parameters in the following order for \nthe program to Predict24925287_низ.\n";
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
