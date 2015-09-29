/**C# deployment code of Neural Networks Model**/

/**==========================================================================
Before running the C# deployment code please read the following.

 STATISTICA variable names will be exported as-is into the C# deployment script;
please verify the resulting script to ensure that the variable names follow the C#
naming conventions and modify the names if necessary.

==========================================================================**/

using System;


public class Predict24925286_лево
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
    __statist_DCats[1]= "4";

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

    __statist_i_h_wts[0,0]=2.11066201775903e-001;
    __statist_i_h_wts[0,1]=8.84595989622904e-002;
    __statist_i_h_wts[0,2]=2.57665112768687e-002;
    __statist_i_h_wts[0,3]=-5.40830882685330e-001;
    __statist_i_h_wts[0,4]=-1.45277139737437e-001;
    __statist_i_h_wts[0,5]=3.67962260789524e-001;
    __statist_i_h_wts[0,6]=-5.95467367298422e-001;
    __statist_i_h_wts[0,7]=9.10575354237540e-001;
    __statist_i_h_wts[0,8]=-1.79748139798248e-001;
    __statist_i_h_wts[0,9]=4.61689792301824e-001;
    __statist_i_h_wts[0,10]=-2.19704829163834e-001;
    __statist_i_h_wts[0,11]=4.05507018951678e-001;
    __statist_i_h_wts[0,12]=1.05754698606747e-001;
    __statist_i_h_wts[0,13]=-8.89960779317462e-001;
    __statist_i_h_wts[0,14]=-1.15106097085597e+000;
    __statist_i_h_wts[0,15]=3.90280929198957e-002;
    __statist_i_h_wts[0,16]=7.64581247198321e-001;
    __statist_i_h_wts[0,17]=-9.66373079229730e-002;
    __statist_i_h_wts[0,18]=3.33641265946850e-002;
    __statist_i_h_wts[0,19]=-2.90624677043469e-001;
    __statist_i_h_wts[0,20]=6.64385632416751e-001;
    __statist_i_h_wts[0,21]=-9.77966529031859e-002;
    __statist_i_h_wts[0,22]=4.84500748074969e-001;
    __statist_i_h_wts[0,23]=3.83230098076231e-001;
    __statist_i_h_wts[0,24]=2.99263265629652e-001;
    __statist_i_h_wts[0,25]=-3.21235131904709e-002;
    __statist_i_h_wts[0,26]=-4.96457103185639e-001;
    __statist_i_h_wts[0,27]=4.40070740543353e-001;
    __statist_i_h_wts[0,28]=4.02929648875448e-002;
    __statist_i_h_wts[0,29]=-1.12692393383399e-002;
    __statist_i_h_wts[0,30]=-2.13366830277808e-001;
    __statist_i_h_wts[0,31]=-4.33184929556936e-001;
    __statist_i_h_wts[0,32]=2.52246033934707e-001;
    __statist_i_h_wts[0,33]=6.00970761566667e-001;
    __statist_i_h_wts[0,34]=-6.67790583643930e-002;
    __statist_i_h_wts[0,35]=3.46247265719564e-001;
    __statist_i_h_wts[0,36]=-4.83035966033711e-001;
    __statist_i_h_wts[0,37]=4.42279307899692e-001;
    __statist_i_h_wts[0,38]=-5.92923254328488e-001;
    __statist_i_h_wts[0,39]=-2.47421036596853e-001;
    __statist_i_h_wts[0,40]=8.44802059544435e-003;
    __statist_i_h_wts[0,41]=1.72980790412437e-001;
    __statist_i_h_wts[0,42]=-6.27443610491732e-001;
    __statist_i_h_wts[0,43]=2.78451815730297e-001;
    __statist_i_h_wts[0,44]=-1.14022505156570e-001;
    __statist_i_h_wts[0,45]=1.27832144702154e-001;
    __statist_i_h_wts[0,46]=-2.66748970520332e-001;
    __statist_i_h_wts[0,47]=5.92703472537129e-001;
    __statist_i_h_wts[0,48]=-5.52014417609511e-001;
    __statist_i_h_wts[0,49]=-9.20008349343813e-003;
    __statist_i_h_wts[0,50]=-2.72857546066621e-001;
    __statist_i_h_wts[0,51]=-7.56838376397987e-001;
    __statist_i_h_wts[0,52]=-4.59196563421089e-001;
    __statist_i_h_wts[0,53]=-3.76774710960763e-001;
    __statist_i_h_wts[0,54]=-4.97360055730525e-001;
    __statist_i_h_wts[0,55]=-6.81299880511065e-002;
    __statist_i_h_wts[0,56]=2.32298189489340e-001;
    __statist_i_h_wts[0,57]=4.42763333541169e-002;
    __statist_i_h_wts[0,58]=1.08951489918353e-001;
    __statist_i_h_wts[0,59]=2.68579133138155e-001;
    __statist_i_h_wts[0,60]=5.59220957232177e-001;
    __statist_i_h_wts[0,61]=9.44069019842568e-002;
    __statist_i_h_wts[0,62]=4.83818747759756e-001;
    __statist_i_h_wts[0,63]=-6.54392145298340e-001;
    __statist_i_h_wts[0,64]=-2.45083714362190e-001;
    __statist_i_h_wts[0,65]=-1.41762508189477e-002;
    __statist_i_h_wts[0,66]=5.81463526661729e-001;
    __statist_i_h_wts[0,67]=-6.66546169238903e-002;
    __statist_i_h_wts[0,68]=5.96050278654381e-001;
    __statist_i_h_wts[0,69]=5.69694210965280e-001;
    __statist_i_h_wts[0,70]=-2.96715578841228e-002;
    __statist_i_h_wts[0,71]=-6.85243297768003e-002;
    __statist_i_h_wts[0,72]=3.55592089076901e-001;
    __statist_i_h_wts[0,73]=8.27666294194562e-001;
    __statist_i_h_wts[0,74]=4.48445177142566e-001;
    __statist_i_h_wts[0,75]=1.82653197224516e-001;
    __statist_i_h_wts[0,76]=-2.36465211356884e-001;
    __statist_i_h_wts[0,77]=-6.53027808948819e-001;
    __statist_i_h_wts[0,78]=2.09875296177099e-002;
    __statist_i_h_wts[0,79]=-8.15659450567937e-002;
    __statist_i_h_wts[0,80]=4.36190156992642e-001;
    __statist_i_h_wts[0,81]=1.44495764914352e-001;
    __statist_i_h_wts[0,82]=2.82925820888246e-002;
    __statist_i_h_wts[0,83]=1.96247630321157e-001;
    __statist_i_h_wts[0,84]=5.20496778827230e-001;
    __statist_i_h_wts[0,85]=-3.16051614962032e-001;
    __statist_i_h_wts[0,86]=-5.05489519481896e-001;
    __statist_i_h_wts[0,87]=4.61896768185031e-001;
    __statist_i_h_wts[0,88]=1.42238629087258e-002;
    __statist_i_h_wts[0,89]=-6.15341924424794e-001;
    __statist_i_h_wts[0,90]=-7.57736504421032e-002;
    __statist_i_h_wts[0,91]=-2.81296806928454e-001;
    __statist_i_h_wts[0,92]=4.61948539105120e-003;
    __statist_i_h_wts[0,93]=2.77521491570213e-001;
    __statist_i_h_wts[0,94]=1.70797603706409e-001;
    __statist_i_h_wts[0,95]=-1.40730457524719e-001;
    __statist_i_h_wts[0,96]=-4.52954311853552e-001;
    __statist_i_h_wts[0,97]=2.51275336805095e-001;
    __statist_i_h_wts[0,98]=1.18515833470845e-002;
    __statist_i_h_wts[0,99]=5.00212536076897e-001;
    __statist_i_h_wts[0,100]=2.20858517164065e-001;
    __statist_i_h_wts[0,101]=-5.63869599199547e-001;
    __statist_i_h_wts[0,102]=1.57027622562785e-001;
    __statist_i_h_wts[0,103]=-9.31640065510446e-002;
    __statist_i_h_wts[0,104]=4.10318982755715e-002;
    __statist_i_h_wts[0,105]=3.14742110011728e-001;
    __statist_i_h_wts[0,106]=1.68276346803948e-001;
    __statist_i_h_wts[0,107]=4.93283554678507e-001;
    __statist_i_h_wts[0,108]=-3.56679444997652e-001;
    __statist_i_h_wts[0,109]=1.82720840159013e-001;
    __statist_i_h_wts[0,110]=3.20151979586799e-001;
    __statist_i_h_wts[0,111]=-2.77846140896132e-001;
    __statist_i_h_wts[0,112]=2.09434678453338e-001;
    __statist_i_h_wts[0,113]=-1.54336648632962e-001;
    __statist_i_h_wts[0,114]=1.39444434641146e-001;
    __statist_i_h_wts[0,115]=4.13912271401200e-001;
    __statist_i_h_wts[0,116]=8.31342702336759e-001;
    __statist_i_h_wts[0,117]=5.98394436804318e-001;
    __statist_i_h_wts[0,118]=1.87833490140272e-001;
    __statist_i_h_wts[0,119]=1.07214749630476e-001;
    __statist_i_h_wts[0,120]=4.02582654283246e-002;
    __statist_i_h_wts[0,121]=6.39422127770219e-002;
    __statist_i_h_wts[0,122]=2.43887916220759e-001;
    __statist_i_h_wts[0,123]=-4.40249025882323e-001;
    __statist_i_h_wts[0,124]=2.27809599035760e-002;
    __statist_i_h_wts[0,125]=-2.40610679083381e-001;
    __statist_i_h_wts[0,126]=-2.22081453642145e-001;
    __statist_i_h_wts[0,127]=-3.29558044104755e-001;
    __statist_i_h_wts[0,128]=1.53621454159745e-001;
    __statist_i_h_wts[0,129]=5.18300182386243e-003;
    __statist_i_h_wts[0,130]=-1.28294650002798e+000;
    __statist_i_h_wts[0,131]=-1.45719057636167e-001;
    __statist_i_h_wts[0,132]=2.15955228524846e-001;
    __statist_i_h_wts[0,133]=-4.67486211239707e-001;
    __statist_i_h_wts[0,134]=-7.92681547051703e-001;
    __statist_i_h_wts[0,135]=-1.27599757955889e-001;
    __statist_i_h_wts[0,136]=1.64814983441953e-001;
    __statist_i_h_wts[0,137]=4.81398583877043e-001;
    __statist_i_h_wts[0,138]=4.18059544328736e-002;
    __statist_i_h_wts[0,139]=1.30361482639686e-001;
    __statist_i_h_wts[0,140]=-2.95944957901616e-001;
    __statist_i_h_wts[0,141]=-3.97440757808355e-001;
    __statist_i_h_wts[0,142]=-9.16021324261536e-001;
    __statist_i_h_wts[0,143]=-1.03769985949626e+000;
    __statist_i_h_wts[0,144]=1.06389950563439e-001;
    __statist_i_h_wts[0,145]=5.06335926714504e-001;
    __statist_i_h_wts[0,146]=1.77754813725969e-001;
    __statist_i_h_wts[0,147]=-1.85713071464392e-001;
    __statist_i_h_wts[0,148]=2.00732602787578e-001;
    __statist_i_h_wts[0,149]=-3.08445455088413e-001;
    __statist_i_h_wts[0,150]=-1.76482161535430e-001;
    __statist_i_h_wts[0,151]=-1.40713494107014e-001;
    __statist_i_h_wts[0,152]=1.90052238832045e-001;
    __statist_i_h_wts[0,153]=4.31440035938720e-001;
    __statist_i_h_wts[0,154]=1.21068634995132e-001;
    __statist_i_h_wts[0,155]=-4.17444115660973e-002;
    __statist_i_h_wts[0,156]=4.34561694313865e-001;
    __statist_i_h_wts[0,157]=1.93415695805271e-001;
    __statist_i_h_wts[0,158]=1.44922786724817e-001;
    __statist_i_h_wts[0,159]=6.56023677084597e-001;
    __statist_i_h_wts[0,160]=5.17993169165234e-001;
    __statist_i_h_wts[0,161]=7.21949514266999e-002;
    __statist_i_h_wts[0,162]=-2.84258584453725e-001;
    __statist_i_h_wts[0,163]=1.76776143576658e-001;
    __statist_i_h_wts[0,164]=3.98155993556264e-001;
    __statist_i_h_wts[0,165]=-6.90422013236394e-002;
    __statist_i_h_wts[0,166]=-7.32976966544531e-002;
    __statist_i_h_wts[0,167]=-2.00725880192117e-001;
    __statist_i_h_wts[0,168]=-1.14208471050816e-001;
    __statist_i_h_wts[0,169]=-2.39758970372352e-001;
    __statist_i_h_wts[0,170]=-2.68037362241655e-001;
    __statist_i_h_wts[0,171]=2.87731411932061e-001;
    __statist_i_h_wts[0,172]=1.95409670855435e-001;
    __statist_i_h_wts[0,173]=-7.64357997868300e-002;
    __statist_i_h_wts[0,174]=-1.27803769278791e-002;
    __statist_i_h_wts[0,175]=1.60225676401281e-001;
    __statist_i_h_wts[0,176]=4.00519340784142e-001;
    __statist_i_h_wts[0,177]=3.75415206683007e-001;
    __statist_i_h_wts[0,178]=1.88782615663305e-002;
    __statist_i_h_wts[0,179]=-3.07000760375017e-001;
    __statist_i_h_wts[0,180]=6.99789819098347e-001;
    __statist_i_h_wts[0,181]=2.77800307878865e-001;
    __statist_i_h_wts[0,182]=1.54239198318102e-001;
    __statist_i_h_wts[0,183]=-2.34869649606637e-002;
    __statist_i_h_wts[0,184]=-1.19831100726691e-001;
    __statist_i_h_wts[0,185]=2.01416585281987e-001;
    __statist_i_h_wts[0,186]=1.87912445082531e-001;
    __statist_i_h_wts[0,187]=1.81548481416543e-001;
    __statist_i_h_wts[0,188]=-1.77121992851421e-001;
    __statist_i_h_wts[0,189]=-1.84627092927563e-001;
    __statist_i_h_wts[0,190]=-3.56759193914850e-001;
    __statist_i_h_wts[0,191]=2.56110340554455e-001;
    __statist_i_h_wts[0,192]=-1.18434185573076e-001;
    __statist_i_h_wts[0,193]=9.68070207818389e-002;
    __statist_i_h_wts[0,194]=-4.33800474454596e-001;
    __statist_i_h_wts[0,195]=-4.78591117825940e-002;
    __statist_i_h_wts[0,196]=-5.23484745231194e-003;
    __statist_i_h_wts[0,197]=2.27573876055326e-001;
    __statist_i_h_wts[0,198]=1.61988512463760e-001;
    __statist_i_h_wts[0,199]=1.35066593186449e-001;
    __statist_i_h_wts[0,200]=5.29288083083543e-001;
    __statist_i_h_wts[0,201]=1.88765286985153e-001;
    __statist_i_h_wts[0,202]=3.93796234275250e-001;
    __statist_i_h_wts[0,203]=-1.28187044940234e-001;
    __statist_i_h_wts[0,204]=-7.64190663795381e-001;
    __statist_i_h_wts[0,205]=-6.42673668234289e-001;
    __statist_i_h_wts[0,206]=7.33317915718836e-001;
    __statist_i_h_wts[0,207]=2.68750135558327e-001;
    __statist_i_h_wts[0,208]=-1.20299831733364e-001;
    __statist_i_h_wts[0,209]=-3.04371768262020e-001;
    __statist_i_h_wts[0,210]=1.92231563625121e-001;
    __statist_i_h_wts[0,211]=2.42283760821636e-001;
    __statist_i_h_wts[0,212]=1.41398850404724e-001;
    __statist_i_h_wts[0,213]=-2.51183685293064e-001;
    __statist_i_h_wts[0,214]=-5.00458320192975e-001;
    __statist_i_h_wts[0,215]=-2.84710143905019e-001;
    __statist_i_h_wts[0,216]=-4.97043618778721e-001;
    __statist_i_h_wts[0,217]=1.38560095916155e-001;
    __statist_i_h_wts[0,218]=-8.51658299546779e-003;
    __statist_i_h_wts[0,219]=-4.22583385412828e-001;
    __statist_i_h_wts[0,220]=-1.73141253335182e-001;
    __statist_i_h_wts[0,221]=3.82948570465867e-001;
    __statist_i_h_wts[0,222]=4.50249759743156e-002;
    __statist_i_h_wts[0,223]=-4.31626430441533e-001;
    __statist_i_h_wts[0,224]=-1.80943149229607e-001;
    __statist_i_h_wts[0,225]=5.08212540923074e-001;
    __statist_i_h_wts[0,226]=5.66377064422899e-001;
    __statist_i_h_wts[0,227]=5.97066086492622e-002;
    __statist_i_h_wts[0,228]=8.46976130802953e-001;
    __statist_i_h_wts[0,229]=1.21581584370219e+000;
    __statist_i_h_wts[0,230]=-1.51608706183957e+000;
    __statist_i_h_wts[0,231]=1.97195669601957e-001;
    __statist_i_h_wts[0,232]=-3.28007283556033e+000;
    __statist_i_h_wts[0,233]=-9.26521300370152e-001;
    __statist_i_h_wts[0,234]=-1.26148282897831e+000;
    __statist_i_h_wts[0,235]=9.13365720938914e-001;
    __statist_i_h_wts[0,236]=6.15107728420758e+000;
    __statist_i_h_wts[0,237]=-1.45718706260005e+000;
    __statist_i_h_wts[0,238]=-6.90092363482594e-001;
    __statist_i_h_wts[0,239]=-1.55153332703560e-003;
    __statist_i_h_wts[0,240]=7.87744349463666e-001;
    __statist_i_h_wts[0,241]=-1.50913129161453e+000;
    __statist_i_h_wts[0,242]=-1.44642164390521e+000;
    __statist_i_h_wts[0,243]=-9.54416937061305e-001;
    __statist_i_h_wts[0,244]=1.31515785260751e+000;
    __statist_i_h_wts[0,245]=-2.47152511240516e-001;
    __statist_i_h_wts[0,246]=-7.18716657984368e-001;
    __statist_i_h_wts[0,247]=-1.08128423813156e+000;
    __statist_i_h_wts[0,248]=-8.23864801175481e-002;

    __statist_i_h_wts[1,0]=-9.00334413289351e-001;
    __statist_i_h_wts[1,1]=-9.06795965612971e-001;
    __statist_i_h_wts[1,2]=-8.28995623170537e-001;
    __statist_i_h_wts[1,3]=-6.44813559891103e-001;
    __statist_i_h_wts[1,4]=-4.74902900751326e-001;
    __statist_i_h_wts[1,5]=-3.24650932843953e-001;
    __statist_i_h_wts[1,6]=-1.15789605877741e-001;
    __statist_i_h_wts[1,7]=-7.80694901994168e-002;
    __statist_i_h_wts[1,8]=7.53230473304023e-002;
    __statist_i_h_wts[1,9]=1.84294227081085e-001;
    __statist_i_h_wts[1,10]=3.04066377268534e-001;
    __statist_i_h_wts[1,11]=3.01628192905790e-001;
    __statist_i_h_wts[1,12]=4.00494111641001e-001;
    __statist_i_h_wts[1,13]=4.40345335633889e-001;
    __statist_i_h_wts[1,14]=5.88185852050982e-001;
    __statist_i_h_wts[1,15]=-9.95862396376731e-001;
    __statist_i_h_wts[1,16]=-1.00875096930375e+000;
    __statist_i_h_wts[1,17]=-9.01816019835220e-001;
    __statist_i_h_wts[1,18]=-7.26955646956553e-001;
    __statist_i_h_wts[1,19]=-5.64677440556361e-001;
    __statist_i_h_wts[1,20]=-4.07689784436220e-001;
    __statist_i_h_wts[1,21]=-2.23647079373150e-001;
    __statist_i_h_wts[1,22]=-5.38830915748140e-002;
    __statist_i_h_wts[1,23]=1.02448770442550e-001;
    __statist_i_h_wts[1,24]=1.99476317744018e-001;
    __statist_i_h_wts[1,25]=2.73394968240725e-001;
    __statist_i_h_wts[1,26]=3.12777165187923e-001;
    __statist_i_h_wts[1,27]=4.00044958006580e-001;
    __statist_i_h_wts[1,28]=4.12384739386003e-001;
    __statist_i_h_wts[1,29]=5.36568005144653e-001;
    __statist_i_h_wts[1,30]=-1.31010548594411e+000;
    __statist_i_h_wts[1,31]=-1.20151174141738e+000;
    __statist_i_h_wts[1,32]=-1.06006383684445e+000;
    __statist_i_h_wts[1,33]=-8.84657029711022e-001;
    __statist_i_h_wts[1,34]=-7.21538548029844e-001;
    __statist_i_h_wts[1,35]=-5.20681850081931e-001;
    __statist_i_h_wts[1,36]=-3.04732969149250e-001;
    __statist_i_h_wts[1,37]=-1.14844450052641e-001;
    __statist_i_h_wts[1,38]=7.28772705800262e-002;
    __statist_i_h_wts[1,39]=2.47018505284510e-001;
    __statist_i_h_wts[1,40]=2.95209227783217e-001;
    __statist_i_h_wts[1,41]=3.12129469151492e-001;
    __statist_i_h_wts[1,42]=4.78193824861198e-001;
    __statist_i_h_wts[1,43]=4.84252316037665e-001;
    __statist_i_h_wts[1,44]=5.79526747181629e-001;
    __statist_i_h_wts[1,45]=-1.33848967030517e+000;
    __statist_i_h_wts[1,46]=-1.37711409961237e+000;
    __statist_i_h_wts[1,47]=-1.26065439766830e+000;
    __statist_i_h_wts[1,48]=-1.09962355470132e+000;
    __statist_i_h_wts[1,49]=-9.99371999859591e-001;
    __statist_i_h_wts[1,50]=-6.79475812100463e-001;
    __statist_i_h_wts[1,51]=-4.43513808744212e-001;
    __statist_i_h_wts[1,52]=-1.37215812503938e-001;
    __statist_i_h_wts[1,53]=1.19265367097447e-001;
    __statist_i_h_wts[1,54]=2.98017352881623e-001;
    __statist_i_h_wts[1,55]=4.32713139182112e-001;
    __statist_i_h_wts[1,56]=5.29818916582389e-001;
    __statist_i_h_wts[1,57]=5.97637368301870e-001;
    __statist_i_h_wts[1,58]=6.23725022712664e-001;
    __statist_i_h_wts[1,59]=6.03947356882530e-001;
    __statist_i_h_wts[1,60]=-1.30369574103989e+000;
    __statist_i_h_wts[1,61]=-1.30952671312801e+000;
    __statist_i_h_wts[1,62]=-1.18474833114674e+000;
    __statist_i_h_wts[1,63]=-1.07956961007895e+000;
    __statist_i_h_wts[1,64]=-1.03273641463569e+000;
    __statist_i_h_wts[1,65]=-7.76931959836562e-001;
    __statist_i_h_wts[1,66]=-4.89659390415480e-001;
    __statist_i_h_wts[1,67]=-8.72478316850585e-002;
    __statist_i_h_wts[1,68]=1.50727294350172e-001;
    __statist_i_h_wts[1,69]=3.57252244547682e-001;
    __statist_i_h_wts[1,70]=4.00033651040138e-001;
    __statist_i_h_wts[1,71]=4.81117099926018e-001;
    __statist_i_h_wts[1,72]=5.88174953632701e-001;
    __statist_i_h_wts[1,73]=6.06724996726746e-001;
    __statist_i_h_wts[1,74]=6.33835953556165e-001;
    __statist_i_h_wts[1,75]=-1.18613476683402e+000;
    __statist_i_h_wts[1,76]=-1.21614504984496e+000;
    __statist_i_h_wts[1,77]=-1.08172405818620e+000;
    __statist_i_h_wts[1,78]=-1.05987571794333e+000;
    __statist_i_h_wts[1,79]=-9.66511121608878e-001;
    __statist_i_h_wts[1,80]=-8.11796584402081e-001;
    __statist_i_h_wts[1,81]=-5.27941965172518e-001;
    __statist_i_h_wts[1,82]=-1.78771915704641e-001;
    __statist_i_h_wts[1,83]=8.67415078620097e-002;
    __statist_i_h_wts[1,84]=3.04527207193387e-001;
    __statist_i_h_wts[1,85]=3.27379204088748e-001;
    __statist_i_h_wts[1,86]=3.50326676366245e-001;
    __statist_i_h_wts[1,87]=4.55108931244391e-001;
    __statist_i_h_wts[1,88]=5.08839610252900e-001;
    __statist_i_h_wts[1,89]=5.91522286038059e-001;
    __statist_i_h_wts[1,90]=-1.20889981131969e+000;
    __statist_i_h_wts[1,91]=-1.17941814376452e+000;
    __statist_i_h_wts[1,92]=-1.07015403032128e+000;
    __statist_i_h_wts[1,93]=-1.01988632040961e+000;
    __statist_i_h_wts[1,94]=-8.87106122753061e-001;
    __statist_i_h_wts[1,95]=-6.64409911425942e-001;
    __statist_i_h_wts[1,96]=-4.09161116394185e-001;
    __statist_i_h_wts[1,97]=-1.76585181721589e-001;
    __statist_i_h_wts[1,98]=6.75726062166093e-002;
    __statist_i_h_wts[1,99]=2.85088157756741e-001;
    __statist_i_h_wts[1,100]=3.12354746073391e-001;
    __statist_i_h_wts[1,101]=3.70107484292147e-001;
    __statist_i_h_wts[1,102]=5.08530852503180e-001;
    __statist_i_h_wts[1,103]=5.57058607582678e-001;
    __statist_i_h_wts[1,104]=5.89344706540346e-001;
    __statist_i_h_wts[1,105]=-1.01298374990411e+000;
    __statist_i_h_wts[1,106]=-9.64761392128615e-001;
    __statist_i_h_wts[1,107]=-9.10947375869603e-001;
    __statist_i_h_wts[1,108]=-9.00872929657401e-001;
    __statist_i_h_wts[1,109]=-7.49031860100226e-001;
    __statist_i_h_wts[1,110]=-4.99110437815344e-001;
    __statist_i_h_wts[1,111]=-2.22449496479083e-001;
    __statist_i_h_wts[1,112]=-1.22272151434968e-001;
    __statist_i_h_wts[1,113]=1.77443501066236e-001;
    __statist_i_h_wts[1,114]=3.17776477556422e-001;
    __statist_i_h_wts[1,115]=3.15679708320892e-001;
    __statist_i_h_wts[1,116]=3.86633040946621e-001;
    __statist_i_h_wts[1,117]=5.01947838754075e-001;
    __statist_i_h_wts[1,118]=5.33201184616402e-001;
    __statist_i_h_wts[1,119]=5.25630145023530e-001;
    __statist_i_h_wts[1,120]=-8.85852313262945e-001;
    __statist_i_h_wts[1,121]=-8.16582530066432e-001;
    __statist_i_h_wts[1,122]=-8.03077918209386e-001;
    __statist_i_h_wts[1,123]=-6.94595639340654e-001;
    __statist_i_h_wts[1,124]=-5.26674605855422e-001;
    __statist_i_h_wts[1,125]=-3.33205158471077e-001;
    __statist_i_h_wts[1,126]=-1.77722715240194e-001;
    __statist_i_h_wts[1,127]=-6.40592382302435e-002;
    __statist_i_h_wts[1,128]=2.13276882479015e-001;
    __statist_i_h_wts[1,129]=3.22313919609784e-001;
    __statist_i_h_wts[1,130]=4.07835888462860e-001;
    __statist_i_h_wts[1,131]=4.30625728852128e-001;
    __statist_i_h_wts[1,132]=6.34226019939357e-001;
    __statist_i_h_wts[1,133]=6.28020277607422e-001;
    __statist_i_h_wts[1,134]=5.28828653711747e-001;
    __statist_i_h_wts[1,135]=-7.06692843010365e-001;
    __statist_i_h_wts[1,136]=-6.76601381730026e-001;
    __statist_i_h_wts[1,137]=-6.69112677327961e-001;
    __statist_i_h_wts[1,138]=-6.00509349216827e-001;
    __statist_i_h_wts[1,139]=-4.15365878240410e-001;
    __statist_i_h_wts[1,140]=-2.64843252301818e-001;
    __statist_i_h_wts[1,141]=-6.44389665927549e-002;
    __statist_i_h_wts[1,142]=5.64322802427590e-002;
    __statist_i_h_wts[1,143]=2.44330962186987e-001;
    __statist_i_h_wts[1,144]=3.57264213081079e-001;
    __statist_i_h_wts[1,145]=3.95583017696698e-001;
    __statist_i_h_wts[1,146]=4.52732217261819e-001;
    __statist_i_h_wts[1,147]=5.27926893264934e-001;
    __statist_i_h_wts[1,148]=5.18916605369859e-001;
    __statist_i_h_wts[1,149]=4.02948748075831e-001;
    __statist_i_h_wts[1,150]=-6.60064334208145e-001;
    __statist_i_h_wts[1,151]=-6.57234777525976e-001;
    __statist_i_h_wts[1,152]=-6.29238801506472e-001;
    __statist_i_h_wts[1,153]=-5.47945850650224e-001;
    __statist_i_h_wts[1,154]=-3.67635390132980e-001;
    __statist_i_h_wts[1,155]=-1.44070984074037e-001;
    __statist_i_h_wts[1,156]=5.43209247401381e-002;
    __statist_i_h_wts[1,157]=1.35667961879873e-001;
    __statist_i_h_wts[1,158]=2.49757942521922e-001;
    __statist_i_h_wts[1,159]=2.80858509726133e-001;
    __statist_i_h_wts[1,160]=3.86485777483024e-001;
    __statist_i_h_wts[1,161]=4.43798145223112e-001;
    __statist_i_h_wts[1,162]=5.61235613101708e-001;
    __statist_i_h_wts[1,163]=4.47955596542088e-001;
    __statist_i_h_wts[1,164]=2.81942458089372e-001;
    __statist_i_h_wts[1,165]=-3.51506521171028e-001;
    __statist_i_h_wts[1,166]=-4.16590863632626e-001;
    __statist_i_h_wts[1,167]=-4.00208096415867e-001;
    __statist_i_h_wts[1,168]=-2.48708734872555e-001;
    __statist_i_h_wts[1,169]=-1.50978000859272e-001;
    __statist_i_h_wts[1,170]=-1.46235260307898e-002;
    __statist_i_h_wts[1,171]=1.09966150806730e-001;
    __statist_i_h_wts[1,172]=1.49380375775908e-001;
    __statist_i_h_wts[1,173]=2.01455628621266e-001;
    __statist_i_h_wts[1,174]=2.52407878890056e-001;
    __statist_i_h_wts[1,175]=3.65731571741678e-001;
    __statist_i_h_wts[1,176]=4.40404288928918e-001;
    __statist_i_h_wts[1,177]=4.87084185165840e-001;
    __statist_i_h_wts[1,178]=5.01311054817741e-001;
    __statist_i_h_wts[1,179]=3.32128982714890e-001;
    __statist_i_h_wts[1,180]=-2.55228020835328e-001;
    __statist_i_h_wts[1,181]=-3.64736186679604e-001;
    __statist_i_h_wts[1,182]=-2.85765466308341e-001;
    __statist_i_h_wts[1,183]=-1.62794619184674e-001;
    __statist_i_h_wts[1,184]=-9.85840198533045e-002;
    __statist_i_h_wts[1,185]=-3.42338571018339e-002;
    __statist_i_h_wts[1,186]=1.54291806631175e-001;
    __statist_i_h_wts[1,187]=2.14180959080249e-001;
    __statist_i_h_wts[1,188]=2.96379870305503e-001;
    __statist_i_h_wts[1,189]=3.65222597000911e-001;
    __statist_i_h_wts[1,190]=4.34987276744027e-001;
    __statist_i_h_wts[1,191]=4.80636689859822e-001;
    __statist_i_h_wts[1,192]=5.65054931587795e-001;
    __statist_i_h_wts[1,193]=5.15430890672979e-001;
    __statist_i_h_wts[1,194]=4.38082481489560e-001;
    __statist_i_h_wts[1,195]=-1.57647570668621e-001;
    __statist_i_h_wts[1,196]=-1.96803352748497e-001;
    __statist_i_h_wts[1,197]=-1.59696628103350e-001;
    __statist_i_h_wts[1,198]=-6.08745707579663e-002;
    __statist_i_h_wts[1,199]=-5.98021714983712e-003;
    __statist_i_h_wts[1,200]=4.08688961693842e-003;
    __statist_i_h_wts[1,201]=1.78845147517448e-001;
    __statist_i_h_wts[1,202]=2.10757513105817e-001;
    __statist_i_h_wts[1,203]=2.46069101627831e-001;
    __statist_i_h_wts[1,204]=3.47117851765682e-001;
    __statist_i_h_wts[1,205]=4.10983252552833e-001;
    __statist_i_h_wts[1,206]=4.25618469645388e-001;
    __statist_i_h_wts[1,207]=5.01837336678214e-001;
    __statist_i_h_wts[1,208]=5.31967185105948e-001;
    __statist_i_h_wts[1,209]=4.17443001501080e-001;
    __statist_i_h_wts[1,210]=-5.70013733873523e-002;
    __statist_i_h_wts[1,211]=-8.16863068700306e-002;
    __statist_i_h_wts[1,212]=-1.13197554559838e-001;
    __statist_i_h_wts[1,213]=1.80099518272535e-002;
    __statist_i_h_wts[1,214]=6.98718817251324e-002;
    __statist_i_h_wts[1,215]=7.62683654187216e-002;
    __statist_i_h_wts[1,216]=1.27539540978632e-001;
    __statist_i_h_wts[1,217]=1.39534331010833e-001;
    __statist_i_h_wts[1,218]=1.94706870506312e-001;
    __statist_i_h_wts[1,219]=2.86660737719263e-001;
    __statist_i_h_wts[1,220]=3.09312095268034e-001;
    __statist_i_h_wts[1,221]=3.14410917761425e-001;
    __statist_i_h_wts[1,222]=4.04206080800615e-001;
    __statist_i_h_wts[1,223]=4.28010695174933e-001;
    __statist_i_h_wts[1,224]=3.63513219275619e-001;
    __statist_i_h_wts[1,225]=-1.48349763284942e-001;
    __statist_i_h_wts[1,226]=-9.44007121062104e-001;
    __statist_i_h_wts[1,227]=1.91443078907163e-002;
    __statist_i_h_wts[1,228]=-8.04637282270697e-001;
    __statist_i_h_wts[1,229]=1.66216551207587e-001;
    __statist_i_h_wts[1,230]=1.20704557580633e+000;
    __statist_i_h_wts[1,231]=3.76255998302037e-001;
    __statist_i_h_wts[1,232]=2.13727956646586e+000;
    __statist_i_h_wts[1,233]=6.47210853782616e-001;
    __statist_i_h_wts[1,234]=1.13802319225767e+000;
    __statist_i_h_wts[1,235]=-7.23899272374188e-001;
    __statist_i_h_wts[1,236]=-2.47524128671638e+000;
    __statist_i_h_wts[1,237]=-9.87683437516247e-001;
    __statist_i_h_wts[1,238]=-6.34214292249780e-002;
    __statist_i_h_wts[1,239]=1.03596901832338e+000;
    __statist_i_h_wts[1,240]=-5.10911646222089e-001;
    __statist_i_h_wts[1,241]=1.76563151228092e+000;
    __statist_i_h_wts[1,242]=2.86301893446346e-002;
    __statist_i_h_wts[1,243]=1.23586305798905e+000;
    __statist_i_h_wts[1,244]=-4.19471597488981e-001;
    __statist_i_h_wts[1,245]=-1.65163431883319e+000;
    __statist_i_h_wts[1,246]=8.74994093263315e-002;
    __statist_i_h_wts[1,247]=-1.11896066311084e+000;
    __statist_i_h_wts[1,248]=1.42250732778672e-001;

    __statist_i_h_wts[2,0]=5.59095021940668e-001;
    __statist_i_h_wts[2,1]=7.20681705106644e-001;
    __statist_i_h_wts[2,2]=7.20194403680586e-001;
    __statist_i_h_wts[2,3]=6.00027277666660e-001;
    __statist_i_h_wts[2,4]=3.82433799938704e-001;
    __statist_i_h_wts[2,5]=1.80576666753592e-001;
    __statist_i_h_wts[2,6]=4.18654183398248e-001;
    __statist_i_h_wts[2,7]=9.56957784650988e-002;
    __statist_i_h_wts[2,8]=-6.69130890717125e-002;
    __statist_i_h_wts[2,9]=-3.18629128378802e-001;
    __statist_i_h_wts[2,10]=-1.92053590699742e-001;
    __statist_i_h_wts[2,11]=-5.72718917490606e-001;
    __statist_i_h_wts[2,12]=-3.29640276363583e-001;
    __statist_i_h_wts[2,13]=-5.76426952833432e-001;
    __statist_i_h_wts[2,14]=-3.75204386367472e-001;
    __statist_i_h_wts[2,15]=4.91875149253172e-001;
    __statist_i_h_wts[2,16]=7.64415279981489e-001;
    __statist_i_h_wts[2,17]=7.27472424394701e-001;
    __statist_i_h_wts[2,18]=2.85272420057635e-001;
    __statist_i_h_wts[2,19]=1.93438949590858e-001;
    __statist_i_h_wts[2,20]=2.86379297167934e-002;
    __statist_i_h_wts[2,21]=4.15967984866960e-001;
    __statist_i_h_wts[2,22]=-9.14060066639200e-002;
    __statist_i_h_wts[2,23]=-2.37907173482942e-002;
    __statist_i_h_wts[2,24]=-1.26149007808961e-001;
    __statist_i_h_wts[2,25]=-5.65149446253613e-002;
    __statist_i_h_wts[2,26]=-5.23436298441548e-001;
    __statist_i_h_wts[2,27]=-2.08027131275134e-001;
    __statist_i_h_wts[2,28]=-5.10299783715435e-001;
    __statist_i_h_wts[2,29]=-4.96274025650212e-001;
    __statist_i_h_wts[2,30]=6.31816759540715e-001;
    __statist_i_h_wts[2,31]=6.26252622487786e-001;
    __statist_i_h_wts[2,32]=7.17479668990063e-001;
    __statist_i_h_wts[2,33]=3.79731876121817e-001;
    __statist_i_h_wts[2,34]=2.71995086811166e-001;
    __statist_i_h_wts[2,35]=4.91615333744941e-002;
    __statist_i_h_wts[2,36]=3.42617677500597e-001;
    __statist_i_h_wts[2,37]=8.56076262878941e-002;
    __statist_i_h_wts[2,38]=1.86152583944159e-001;
    __statist_i_h_wts[2,39]=1.17143557884894e-001;
    __statist_i_h_wts[2,40]=1.55909119978615e-001;
    __statist_i_h_wts[2,41]=-4.43980584032876e-001;
    __statist_i_h_wts[2,42]=-2.22316645363167e-001;
    __statist_i_h_wts[2,43]=-4.58021580339611e-001;
    __statist_i_h_wts[2,44]=-2.25134199424549e-001;
    __statist_i_h_wts[2,45]=1.16280772834433e+000;
    __statist_i_h_wts[2,46]=8.92389990477346e-001;
    __statist_i_h_wts[2,47]=1.05335107481437e+000;
    __statist_i_h_wts[2,48]=6.68388631024239e-001;
    __statist_i_h_wts[2,49]=5.65182228059423e-001;
    __statist_i_h_wts[2,50]=3.98362841294671e-001;
    __statist_i_h_wts[2,51]=2.78654316481019e-001;
    __statist_i_h_wts[2,52]=-7.02662425024557e-002;
    __statist_i_h_wts[2,53]=7.09370903073187e-002;
    __statist_i_h_wts[2,54]=2.18646063896462e-002;
    __statist_i_h_wts[2,55]=-2.71470903235829e-001;
    __statist_i_h_wts[2,56]=-4.81776699197993e-001;
    __statist_i_h_wts[2,57]=-8.24439613367901e-002;
    __statist_i_h_wts[2,58]=-5.57625768099640e-001;
    __statist_i_h_wts[2,59]=-4.42216873582374e-001;
    __statist_i_h_wts[2,60]=9.78868673093835e-001;
    __statist_i_h_wts[2,61]=1.06089403668538e+000;
    __statist_i_h_wts[2,62]=1.05182519100408e+000;
    __statist_i_h_wts[2,63]=8.25088368131679e-001;
    __statist_i_h_wts[2,64]=6.93959455002510e-001;
    __statist_i_h_wts[2,65]=3.77123745360559e-001;
    __statist_i_h_wts[2,66]=4.71817238176627e-001;
    __statist_i_h_wts[2,67]=-8.40211205748275e-003;
    __statist_i_h_wts[2,68]=-3.03494522337895e-002;
    __statist_i_h_wts[2,69]=2.33180053306877e-002;
    __statist_i_h_wts[2,70]=-1.22784037584924e-001;
    __statist_i_h_wts[2,71]=-4.10613487924686e-001;
    __statist_i_h_wts[2,72]=2.15672992296425e-002;
    __statist_i_h_wts[2,73]=-5.00356041480103e-001;
    __statist_i_h_wts[2,74]=-3.78812800784537e-001;
    __statist_i_h_wts[2,75]=8.75735561394812e-001;
    __statist_i_h_wts[2,76]=1.03080331415756e+000;
    __statist_i_h_wts[2,77]=6.65905277148019e-001;
    __statist_i_h_wts[2,78]=7.00598650105018e-001;
    __statist_i_h_wts[2,79]=5.23715104510627e-001;
    __statist_i_h_wts[2,80]=2.97968554152310e-001;
    __statist_i_h_wts[2,81]=-2.92279499460647e-001;
    __statist_i_h_wts[2,82]=1.37937982655287e-001;
    __statist_i_h_wts[2,83]=-3.40832569373847e-001;
    __statist_i_h_wts[2,84]=9.31271977371556e-003;
    __statist_i_h_wts[2,85]=-3.02391567936127e-001;
    __statist_i_h_wts[2,86]=-4.46226734424094e-001;
    __statist_i_h_wts[2,87]=-1.81419203903561e-001;
    __statist_i_h_wts[2,88]=-4.56602366614449e-001;
    __statist_i_h_wts[2,89]=-3.85163349602882e-001;
    __statist_i_h_wts[2,90]=7.35520380484853e-001;
    __statist_i_h_wts[2,91]=6.63497866591529e-001;
    __statist_i_h_wts[2,92]=7.38957309682576e-001;
    __statist_i_h_wts[2,93]=5.99176164852023e-001;
    __statist_i_h_wts[2,94]=3.07526384371392e-001;
    __statist_i_h_wts[2,95]=1.07778703048107e-001;
    __statist_i_h_wts[2,96]=-5.42934105311600e-002;
    __statist_i_h_wts[2,97]=4.96190534347361e-001;
    __statist_i_h_wts[2,98]=-3.28878647295583e-001;
    __statist_i_h_wts[2,99]=1.85890703359591e-001;
    __statist_i_h_wts[2,100]=-2.49976471820216e-001;
    __statist_i_h_wts[2,101]=-3.90463276600762e-001;
    __statist_i_h_wts[2,102]=-1.00726941608949e-001;
    __statist_i_h_wts[2,103]=-5.08905730821333e-001;
    __statist_i_h_wts[2,104]=-2.78837992433874e-001;
    __statist_i_h_wts[2,105]=2.97292531578281e-001;
    __statist_i_h_wts[2,106]=6.35540563719471e-001;
    __statist_i_h_wts[2,107]=5.68178005575781e-001;
    __statist_i_h_wts[2,108]=3.77058381175289e-001;
    __statist_i_h_wts[2,109]=5.33287819768794e-001;
    __statist_i_h_wts[2,110]=1.78271710466400e-001;
    __statist_i_h_wts[2,111]=3.37066543223638e-001;
    __statist_i_h_wts[2,112]=2.09260448947558e-001;
    __statist_i_h_wts[2,113]=-2.14738524857329e-001;
    __statist_i_h_wts[2,114]=-1.07446313850011e-001;
    __statist_i_h_wts[2,115]=-3.12701431371894e-001;
    __statist_i_h_wts[2,116]=-8.73657196601812e-002;
    __statist_i_h_wts[2,117]=-5.32789516981535e-002;
    __statist_i_h_wts[2,118]=-3.74628678402678e-001;
    __statist_i_h_wts[2,119]=-3.39858989285168e-001;
    __statist_i_h_wts[2,120]=3.38848511106411e-001;
    __statist_i_h_wts[2,121]=7.17167515380544e-001;
    __statist_i_h_wts[2,122]=4.13637879264225e-001;
    __statist_i_h_wts[2,123]=6.59284523411902e-001;
    __statist_i_h_wts[2,124]=5.24560817680338e-001;
    __statist_i_h_wts[2,125]=4.43743276480962e-001;
    __statist_i_h_wts[2,126]=-7.95015107026036e-003;
    __statist_i_h_wts[2,127]=-3.00811043162783e-001;
    __statist_i_h_wts[2,128]=-1.85101352650670e-001;
    __statist_i_h_wts[2,129]=-1.57164490170276e-001;
    __statist_i_h_wts[2,130]=-6.47320749171277e-001;
    __statist_i_h_wts[2,131]=-2.78011678461644e-001;
    __statist_i_h_wts[2,132]=-4.72538757883975e-002;
    __statist_i_h_wts[2,133]=-3.02825501857818e-001;
    __statist_i_h_wts[2,134]=-2.99424133448780e-001;
    __statist_i_h_wts[2,135]=3.40361508347079e-001;
    __statist_i_h_wts[2,136]=4.80780899041316e-001;
    __statist_i_h_wts[2,137]=3.15389637573689e-001;
    __statist_i_h_wts[2,138]=4.59671996227404e-001;
    __statist_i_h_wts[2,139]=3.74254300903253e-001;
    __statist_i_h_wts[2,140]=2.87337573609173e-001;
    __statist_i_h_wts[2,141]=-9.86377677811749e-002;
    __statist_i_h_wts[2,142]=-2.51037180763153e-002;
    __statist_i_h_wts[2,143]=-1.63997978404299e-001;
    __statist_i_h_wts[2,144]=3.56134656591212e-001;
    __statist_i_h_wts[2,145]=-1.85824221335595e-001;
    __statist_i_h_wts[2,146]=1.32072051244497e-001;
    __statist_i_h_wts[2,147]=-2.11764809860746e-002;
    __statist_i_h_wts[2,148]=-1.76526798185698e-001;
    __statist_i_h_wts[2,149]=-3.06384181105754e-001;
    __statist_i_h_wts[2,150]=2.67718723204710e-001;
    __statist_i_h_wts[2,151]=3.90303692112886e-001;
    __statist_i_h_wts[2,152]=3.38476639877624e-001;
    __statist_i_h_wts[2,153]=2.13160858004364e-001;
    __statist_i_h_wts[2,154]=3.67627795517588e-001;
    __statist_i_h_wts[2,155]=-3.94516633354019e-002;
    __statist_i_h_wts[2,156]=-2.13938127670615e-001;
    __statist_i_h_wts[2,157]=-1.92659801917535e-001;
    __statist_i_h_wts[2,158]=-5.62226658455002e-002;
    __statist_i_h_wts[2,159]=1.58738727692393e-001;
    __statist_i_h_wts[2,160]=-2.80491193180036e-001;
    __statist_i_h_wts[2,161]=-2.18774975577370e-001;
    __statist_i_h_wts[2,162]=-3.38709033930796e-001;
    __statist_i_h_wts[2,163]=-5.60054973099152e-001;
    __statist_i_h_wts[2,164]=-5.40716300030015e-001;
    __statist_i_h_wts[2,165]=1.83065284088346e-001;
    __statist_i_h_wts[2,166]=1.59667038041693e-001;
    __statist_i_h_wts[2,167]=1.29945947801770e-001;
    __statist_i_h_wts[2,168]=3.38291689440638e-001;
    __statist_i_h_wts[2,169]=2.99757235029772e-001;
    __statist_i_h_wts[2,170]=4.66439516525539e-001;
    __statist_i_h_wts[2,171]=1.48631678548993e-001;
    __statist_i_h_wts[2,172]=-1.08877792557860e-001;
    __statist_i_h_wts[2,173]=-1.11661545335320e-001;
    __statist_i_h_wts[2,174]=5.57973187416027e-003;
    __statist_i_h_wts[2,175]=-1.74772738652464e-001;
    __statist_i_h_wts[2,176]=-1.58703022285147e-001;
    __statist_i_h_wts[2,177]=-4.09170187731375e-001;
    __statist_i_h_wts[2,178]=-4.66855090968985e-001;
    __statist_i_h_wts[2,179]=-5.42854244932708e-001;
    __statist_i_h_wts[2,180]=1.92297660518686e-001;
    __statist_i_h_wts[2,181]=1.77971480305826e-001;
    __statist_i_h_wts[2,182]=2.41458610344886e-001;
    __statist_i_h_wts[2,183]=4.39047191810059e-001;
    __statist_i_h_wts[2,184]=4.96020086318120e-001;
    __statist_i_h_wts[2,185]=1.42186493109295e-001;
    __statist_i_h_wts[2,186]=1.75787673699255e-001;
    __statist_i_h_wts[2,187]=5.98903878018368e-002;
    __statist_i_h_wts[2,188]=2.86982415870462e-002;
    __statist_i_h_wts[2,189]=-6.28967726827341e-002;
    __statist_i_h_wts[2,190]=-1.12591789660306e-001;
    __statist_i_h_wts[2,191]=-1.68639223991212e-001;
    __statist_i_h_wts[2,192]=-2.37597692042875e-001;
    __statist_i_h_wts[2,193]=-4.18197150148610e-001;
    __statist_i_h_wts[2,194]=-4.76283587970793e-001;
    __statist_i_h_wts[2,195]=1.50077998906219e-001;
    __statist_i_h_wts[2,196]=1.42127834500197e-001;
    __statist_i_h_wts[2,197]=1.19768803636769e-001;
    __statist_i_h_wts[2,198]=9.46605245979542e-002;
    __statist_i_h_wts[2,199]=1.98366533408825e-001;
    __statist_i_h_wts[2,200]=1.67689247285771e-001;
    __statist_i_h_wts[2,201]=9.59118553246806e-002;
    __statist_i_h_wts[2,202]=-2.62145077164294e-002;
    __statist_i_h_wts[2,203]=-1.25162239597826e-001;
    __statist_i_h_wts[2,204]=-2.29825682785605e-001;
    __statist_i_h_wts[2,205]=-4.06696740440190e-001;
    __statist_i_h_wts[2,206]=-3.74857553839506e-001;
    __statist_i_h_wts[2,207]=-5.09815800194307e-001;
    __statist_i_h_wts[2,208]=-6.44321470550612e-001;
    __statist_i_h_wts[2,209]=-5.99995835068875e-001;
    __statist_i_h_wts[2,210]=-3.07213402689296e-001;
    __statist_i_h_wts[2,211]=-2.04827849571245e-001;
    __statist_i_h_wts[2,212]=-3.49289282885957e-001;
    __statist_i_h_wts[2,213]=-3.25156505908901e-001;
    __statist_i_h_wts[2,214]=-2.25057621843491e-001;
    __statist_i_h_wts[2,215]=-3.93474511110905e-002;
    __statist_i_h_wts[2,216]=-1.72715500314769e-001;
    __statist_i_h_wts[2,217]=-1.72110682679006e-001;
    __statist_i_h_wts[2,218]=1.93676656393935e-001;
    __statist_i_h_wts[2,219]=-1.31752709323882e-001;
    __statist_i_h_wts[2,220]=-2.92642394631966e-001;
    __statist_i_h_wts[2,221]=-2.93693995848818e-001;
    __statist_i_h_wts[2,222]=-4.59966676972886e-001;
    __statist_i_h_wts[2,223]=-5.90905587122809e-001;
    __statist_i_h_wts[2,224]=-5.05779758125210e-001;
    __statist_i_h_wts[2,225]=2.61612654988642e-001;
    __statist_i_h_wts[2,226]=1.21698022075902e+000;
    __statist_i_h_wts[2,227]=4.27635035494010e-001;
    __statist_i_h_wts[2,228]=9.42442988039155e-001;
    __statist_i_h_wts[2,229]=7.16366969253657e-001;
    __statist_i_h_wts[2,230]=-1.01561875766948e+000;
    __statist_i_h_wts[2,231]=4.41730037844657e-001;
    __statist_i_h_wts[2,232]=-2.07619257431033e+000;
    __statist_i_h_wts[2,233]=-9.55479998147283e-001;
    __statist_i_h_wts[2,234]=-4.69832980939812e-001;
    __statist_i_h_wts[2,235]=5.07253574745447e-001;
    __statist_i_h_wts[2,236]=3.26431414547996e+000;
    __statist_i_h_wts[2,237]=-1.96205944410134e-001;
    __statist_i_h_wts[2,238]=-4.82563519000786e-001;
    __statist_i_h_wts[2,239]=-5.16110150819004e-001;
    __statist_i_h_wts[2,240]=5.92901434557280e-001;
    __statist_i_h_wts[2,241]=-1.30314590162540e+000;
    __statist_i_h_wts[2,242]=-7.73422497009371e-001;
    __statist_i_h_wts[2,243]=-7.04715917386482e-001;
    __statist_i_h_wts[2,244]=7.26711175552935e-003;
    __statist_i_h_wts[2,245]=1.12689072468562e+000;
    __statist_i_h_wts[2,246]=2.19508164252905e-001;
    __statist_i_h_wts[2,247]=4.02812492178352e-001;
    __statist_i_h_wts[2,248]=-4.68258196003859e-001;

    __statist_i_h_wts[3,0]=1.47940482511745e+000;
    __statist_i_h_wts[3,1]=1.59565217610291e+000;
    __statist_i_h_wts[3,2]=1.43599218215881e+000;
    __statist_i_h_wts[3,3]=1.17665544416039e+000;
    __statist_i_h_wts[3,4]=9.33026310118750e-001;
    __statist_i_h_wts[3,5]=6.71768975158724e-001;
    __statist_i_h_wts[3,6]=3.99777850782194e-001;
    __statist_i_h_wts[3,7]=2.99052761675460e-001;
    __statist_i_h_wts[3,8]=1.22385745224328e-001;
    __statist_i_h_wts[3,9]=8.98512199865562e-002;
    __statist_i_h_wts[3,10]=-1.05233383296038e-005;
    __statist_i_h_wts[3,11]=-8.04787681602643e-002;
    __statist_i_h_wts[3,12]=-1.51384503973889e-001;
    __statist_i_h_wts[3,13]=-3.43953090381437e-001;
    __statist_i_h_wts[3,14]=-5.34600078779995e-001;
    __statist_i_h_wts[3,15]=1.40043340191450e+000;
    __statist_i_h_wts[3,16]=1.60804949751620e+000;
    __statist_i_h_wts[3,17]=1.49008783097512e+000;
    __statist_i_h_wts[3,18]=1.08411960735406e+000;
    __statist_i_h_wts[3,19]=9.54940082359941e-001;
    __statist_i_h_wts[3,20]=6.92082037178697e-001;
    __statist_i_h_wts[3,21]=4.92201023898396e-001;
    __statist_i_h_wts[3,22]=1.82770128176902e-001;
    __statist_i_h_wts[3,23]=1.26638639438182e-001;
    __statist_i_h_wts[3,24]=1.23006313881318e-002;
    __statist_i_h_wts[3,25]=9.41887507651948e-002;
    __statist_i_h_wts[3,26]=-4.66341336955501e-002;
    __statist_i_h_wts[3,27]=-1.28405200007589e-001;
    __statist_i_h_wts[3,28]=-3.31001972009302e-001;
    __statist_i_h_wts[3,29]=-5.05607208435183e-001;
    __statist_i_h_wts[3,30]=1.55210053554251e+000;
    __statist_i_h_wts[3,31]=1.38298190949088e+000;
    __statist_i_h_wts[3,32]=1.28219304840093e+000;
    __statist_i_h_wts[3,33]=9.06149559338250e-001;
    __statist_i_h_wts[3,34]=6.87568267309163e-001;
    __statist_i_h_wts[3,35]=4.37555163111196e-001;
    __statist_i_h_wts[3,36]=3.53006779159207e-001;
    __statist_i_h_wts[3,37]=4.76986854942933e-002;
    __statist_i_h_wts[3,38]=-3.85452430588342e-002;
    __statist_i_h_wts[3,39]=-1.77117344527918e-001;
    __statist_i_h_wts[3,40]=-2.73522984487371e-002;
    __statist_i_h_wts[3,41]=-7.62427087120384e-002;
    __statist_i_h_wts[3,42]=-3.00486482722678e-001;
    __statist_i_h_wts[3,43]=-4.01900136736178e-001;
    __statist_i_h_wts[3,44]=-4.52195993976308e-001;
    __statist_i_h_wts[3,45]=1.56467143596533e+000;
    __statist_i_h_wts[3,46]=1.54472359293227e+000;
    __statist_i_h_wts[3,47]=1.45140954285185e+000;
    __statist_i_h_wts[3,48]=1.08856735296894e+000;
    __statist_i_h_wts[3,49]=1.11839903337940e+000;
    __statist_i_h_wts[3,50]=6.69228509756455e-001;
    __statist_i_h_wts[3,51]=5.43605291296289e-001;
    __statist_i_h_wts[3,52]=1.24501602700316e-001;
    __statist_i_h_wts[3,53]=-1.85296465724794e-001;
    __statist_i_h_wts[3,54]=-2.48151793384249e-001;
    __statist_i_h_wts[3,55]=-1.61199025085015e-001;
    __statist_i_h_wts[3,56]=-2.95151270440317e-001;
    __statist_i_h_wts[3,57]=-2.80596198422332e-001;
    __statist_i_h_wts[3,58]=-4.60821848422701e-001;
    __statist_i_h_wts[3,59]=-4.34297129141397e-001;
    __statist_i_h_wts[3,60]=1.30036637405311e+000;
    __statist_i_h_wts[3,61]=1.21478316752886e+000;
    __statist_i_h_wts[3,62]=1.07278307577953e+000;
    __statist_i_h_wts[3,63]=9.16540936106515e-001;
    __statist_i_h_wts[3,64]=8.62736918779640e-001;
    __statist_i_h_wts[3,65]=4.15999516636428e-001;
    __statist_i_h_wts[3,66]=4.52269483506506e-001;
    __statist_i_h_wts[3,67]=-5.29260979867743e-002;
    __statist_i_h_wts[3,68]=-2.16134500319380e-001;
    __statist_i_h_wts[3,69]=-3.79639016453779e-001;
    __statist_i_h_wts[3,70]=-1.24357079391055e-001;
    __statist_i_h_wts[3,71]=-2.79652396840834e-001;
    __statist_i_h_wts[3,72]=-2.43740859421149e-001;
    __statist_i_h_wts[3,73]=-4.37496354830295e-001;
    __statist_i_h_wts[3,74]=-4.05899989277266e-001;
    __statist_i_h_wts[3,75]=9.22292883350355e-001;
    __statist_i_h_wts[3,76]=1.00076092821666e+000;
    __statist_i_h_wts[3,77]=8.71478359461024e-001;
    __statist_i_h_wts[3,78]=8.16689461037319e-001;
    __statist_i_h_wts[3,79]=7.03623774611957e-001;
    __statist_i_h_wts[3,80]=5.57269996131431e-001;
    __statist_i_h_wts[3,81]=4.43950644849153e-001;
    __statist_i_h_wts[3,82]=6.43080354189134e-002;
    __statist_i_h_wts[3,83]=-2.02960906754543e-001;
    __statist_i_h_wts[3,84]=-4.39258118416373e-001;
    __statist_i_h_wts[3,85]=-4.49349465497185e-001;
    __statist_i_h_wts[3,86]=-2.66008369521167e-001;
    __statist_i_h_wts[3,87]=-2.41814155965058e-001;
    __statist_i_h_wts[3,88]=-3.92247643784257e-001;
    __statist_i_h_wts[3,89]=-3.84414060754524e-001;
    __statist_i_h_wts[3,90]=1.04805371399695e+000;
    __statist_i_h_wts[3,91]=1.07737621601785e+000;
    __statist_i_h_wts[3,92]=1.10553175632454e+000;
    __statist_i_h_wts[3,93]=1.01218854025151e+000;
    __statist_i_h_wts[3,94]=6.87064428156239e-001;
    __statist_i_h_wts[3,95]=3.75856139368775e-001;
    __statist_i_h_wts[3,96]=3.81836196290563e-001;
    __statist_i_h_wts[3,97]=2.05541215355203e-001;
    __statist_i_h_wts[3,98]=-2.36160218619285e-001;
    __statist_i_h_wts[3,99]=-2.40507648727439e-001;
    __statist_i_h_wts[3,100]=-4.46710974471221e-001;
    __statist_i_h_wts[3,101]=-2.46996702094809e-001;
    __statist_i_h_wts[3,102]=-3.25797042625912e-001;
    __statist_i_h_wts[3,103]=-4.87116071418984e-001;
    __statist_i_h_wts[3,104]=-4.28489313838816e-001;
    __statist_i_h_wts[3,105]=7.21245598278398e-001;
    __statist_i_h_wts[3,106]=8.61800608104383e-001;
    __statist_i_h_wts[3,107]=7.77481435167256e-001;
    __statist_i_h_wts[3,108]=7.79939684097387e-001;
    __statist_i_h_wts[3,109]=5.33421078108362e-001;
    __statist_i_h_wts[3,110]=2.37507997242800e-001;
    __statist_i_h_wts[3,111]=3.19271990236862e-001;
    __statist_i_h_wts[3,112]=1.96911589800116e-001;
    __statist_i_h_wts[3,113]=-2.38525172841482e-001;
    __statist_i_h_wts[3,114]=-1.63650525886892e-001;
    __statist_i_h_wts[3,115]=-1.63289764620913e-001;
    __statist_i_h_wts[3,116]=-8.20906064424673e-002;
    __statist_i_h_wts[3,117]=-2.66687710366395e-001;
    __statist_i_h_wts[3,118]=-4.30854747296209e-001;
    __statist_i_h_wts[3,119]=-3.99934375479215e-001;
    __statist_i_h_wts[3,120]=6.16499288900600e-001;
    __statist_i_h_wts[3,121]=7.20675081378421e-001;
    __statist_i_h_wts[3,122]=5.76368887835129e-001;
    __statist_i_h_wts[3,123]=4.89724773169560e-001;
    __statist_i_h_wts[3,124]=2.00413648240158e-001;
    __statist_i_h_wts[3,125]=1.39178823364943e-001;
    __statist_i_h_wts[3,126]=1.84151238402523e-001;
    __statist_i_h_wts[3,127]=4.00500292892340e-002;
    __statist_i_h_wts[3,128]=-1.73898227470307e-001;
    __statist_i_h_wts[3,129]=-2.63450511775825e-001;
    __statist_i_h_wts[3,130]=-4.57929685334988e-001;
    __statist_i_h_wts[3,131]=-3.10219341105320e-001;
    __statist_i_h_wts[3,132]=-4.58602886748236e-001;
    __statist_i_h_wts[3,133]=-5.41933475408325e-001;
    __statist_i_h_wts[3,134]=-4.44169944629590e-001;
    __statist_i_h_wts[3,135]=8.34830266599464e-001;
    __statist_i_h_wts[3,136]=6.79460476669635e-001;
    __statist_i_h_wts[3,137]=6.71692773449283e-001;
    __statist_i_h_wts[3,138]=5.75426656743331e-001;
    __statist_i_h_wts[3,139]=1.35178129360112e-001;
    __statist_i_h_wts[3,140]=8.75368599810896e-002;
    __statist_i_h_wts[3,141]=1.13466100619565e-001;
    __statist_i_h_wts[3,142]=-2.02429874134513e-002;
    __statist_i_h_wts[3,143]=-8.38231106833008e-002;
    __statist_i_h_wts[3,144]=-1.33013337071250e-001;
    __statist_i_h_wts[3,145]=-4.49949646522708e-001;
    __statist_i_h_wts[3,146]=-2.32743103939268e-001;
    __statist_i_h_wts[3,147]=-3.69576331562006e-001;
    __statist_i_h_wts[3,148]=-4.26491107676444e-001;
    __statist_i_h_wts[3,149]=-3.39167653949995e-001;
    __statist_i_h_wts[3,150]=8.69755686569058e-001;
    __statist_i_h_wts[3,151]=8.53494296410734e-001;
    __statist_i_h_wts[3,152]=7.81784610086218e-001;
    __statist_i_h_wts[3,153]=6.97029548454489e-001;
    __statist_i_h_wts[3,154]=3.10574577979245e-001;
    __statist_i_h_wts[3,155]=1.62881960562345e-001;
    __statist_i_h_wts[3,156]=3.30745036045685e-001;
    __statist_i_h_wts[3,157]=2.13531789428349e-001;
    __statist_i_h_wts[3,158]=-1.30064379304911e-002;
    __statist_i_h_wts[3,159]=-1.47941951720403e-002;
    __statist_i_h_wts[3,160]=-4.10999378704825e-001;
    __statist_i_h_wts[3,161]=-3.95662272675059e-001;
    __statist_i_h_wts[3,162]=-5.37786781158815e-001;
    __statist_i_h_wts[3,163]=-4.27610651235381e-001;
    __statist_i_h_wts[3,164]=-2.78103669360461e-001;
    __statist_i_h_wts[3,165]=7.06607752456991e-001;
    __statist_i_h_wts[3,166]=6.68093185393263e-001;
    __statist_i_h_wts[3,167]=6.79269524245148e-001;
    __statist_i_h_wts[3,168]=5.21945484321842e-001;
    __statist_i_h_wts[3,169]=2.81667526125996e-001;
    __statist_i_h_wts[3,170]=1.05665586581672e-001;
    __statist_i_h_wts[3,171]=6.29721278628694e-002;
    __statist_i_h_wts[3,172]=6.28960452283590e-002;
    __statist_i_h_wts[3,173]=-1.19572498199733e-001;
    __statist_i_h_wts[3,174]=-1.65245201303238e-001;
    __statist_i_h_wts[3,175]=-3.85662377365635e-001;
    __statist_i_h_wts[3,176]=-4.25336365840388e-001;
    __statist_i_h_wts[3,177]=-4.33391145566551e-001;
    __statist_i_h_wts[3,178]=-4.52287543182986e-001;
    __statist_i_h_wts[3,179]=-3.53840125778013e-001;
    __statist_i_h_wts[3,180]=5.94022598374142e-001;
    __statist_i_h_wts[3,181]=5.74485652801830e-001;
    __statist_i_h_wts[3,182]=5.21870466101119e-001;
    __statist_i_h_wts[3,183]=3.96626324779159e-001;
    __statist_i_h_wts[3,184]=3.56801508338169e-001;
    __statist_i_h_wts[3,185]=1.42188581028116e-001;
    __statist_i_h_wts[3,186]=3.27010267372998e-002;
    __statist_i_h_wts[3,187]=-1.62404734851126e-002;
    __statist_i_h_wts[3,188]=-2.06536788346373e-001;
    __statist_i_h_wts[3,189]=-2.35002300620318e-001;
    __statist_i_h_wts[3,190]=-3.81744271487747e-001;
    __statist_i_h_wts[3,191]=-4.14290571016479e-001;
    __statist_i_h_wts[3,192]=-4.12228525084586e-001;
    __statist_i_h_wts[3,193]=-4.71202896914124e-001;
    __statist_i_h_wts[3,194]=-4.41715136078946e-001;
    __statist_i_h_wts[3,195]=4.41347104632938e-001;
    __statist_i_h_wts[3,196]=3.59990383840690e-001;
    __statist_i_h_wts[3,197]=3.95185935825759e-001;
    __statist_i_h_wts[3,198]=1.52741373681392e-001;
    __statist_i_h_wts[3,199]=1.66085997195902e-001;
    __statist_i_h_wts[3,200]=1.74409307180027e-001;
    __statist_i_h_wts[3,201]=-4.44715328204719e-002;
    __statist_i_h_wts[3,202]=-1.15088954668493e-001;
    __statist_i_h_wts[3,203]=-2.52353379646131e-001;
    __statist_i_h_wts[3,204]=-2.77679836364125e-001;
    __statist_i_h_wts[3,205]=-3.47828733229816e-001;
    __statist_i_h_wts[3,206]=-3.28519995328515e-001;
    __statist_i_h_wts[3,207]=-4.33220306866984e-001;
    __statist_i_h_wts[3,208]=-5.21713071846242e-001;
    __statist_i_h_wts[3,209]=-4.67450136342724e-001;
    __statist_i_h_wts[3,210]=1.20486472508289e-001;
    __statist_i_h_wts[3,211]=9.56880568232312e-002;
    __statist_i_h_wts[3,212]=1.58666394216030e-001;
    __statist_i_h_wts[3,213]=-1.37723567133813e-001;
    __statist_i_h_wts[3,214]=-7.61012391114723e-002;
    __statist_i_h_wts[3,215]=-5.09379466093666e-002;
    __statist_i_h_wts[3,216]=1.03974168508306e-003;
    __statist_i_h_wts[3,217]=2.51759664833363e-002;
    __statist_i_h_wts[3,218]=-8.77019982574909e-003;
    __statist_i_h_wts[3,219]=-8.45839560997797e-002;
    __statist_i_h_wts[3,220]=-5.56452583022074e-002;
    __statist_i_h_wts[3,221]=-1.74507840217689e-001;
    __statist_i_h_wts[3,222]=-3.20822008047748e-001;
    __statist_i_h_wts[3,223]=-4.25547583333678e-001;
    __statist_i_h_wts[3,224]=-3.86957981933388e-001;
    __statist_i_h_wts[3,225]=4.22172605140130e-001;
    __statist_i_h_wts[3,226]=1.69933294761862e+000;
    __statist_i_h_wts[3,227]=3.42163018126188e-001;
    __statist_i_h_wts[3,228]=1.32435354196952e+000;
    __statist_i_h_wts[3,229]=6.19366373923817e-002;
    __statist_i_h_wts[3,230]=-1.60522786525299e+000;
    __statist_i_h_wts[3,231]=-2.51267162405499e-001;
    __statist_i_h_wts[3,232]=-3.21141070206774e+000;
    __statist_i_h_wts[3,233]=-9.78087207940079e-001;
    __statist_i_h_wts[3,234]=-1.25171220342558e+000;
    __statist_i_h_wts[3,235]=1.12862062759126e+000;
    __statist_i_h_wts[3,236]=4.40116672824772e+000;
    __statist_i_h_wts[3,237]=6.21050755411849e-001;
    __statist_i_h_wts[3,238]=-1.82352108314876e-001;
    __statist_i_h_wts[3,239]=-1.19607357519880e+000;
    __statist_i_h_wts[3,240]=9.35305606273024e-001;
    __statist_i_h_wts[3,241]=-2.76557312494468e+000;
    __statist_i_h_wts[3,242]=-2.63722691790545e-001;
    __statist_i_h_wts[3,243]=-1.53829271968660e+000;
    __statist_i_h_wts[3,244]=4.93654676001986e-001;
    __statist_i_h_wts[3,245]=2.53047171719045e+000;
    __statist_i_h_wts[3,246]=4.48219817552886e-002;
    __statist_i_h_wts[3,247]=1.21612732440762e+000;
    __statist_i_h_wts[3,248]=-3.00111560591341e-001;

    __statist_i_h_wts[4,0]=-1.25965915806225e+000;
    __statist_i_h_wts[4,1]=-7.47419482388154e-001;
    __statist_i_h_wts[4,2]=-4.56868092561671e-001;
    __statist_i_h_wts[4,3]=-3.91086863714275e-001;
    __statist_i_h_wts[4,4]=-2.42618162374034e-001;
    __statist_i_h_wts[4,5]=-3.21900023042110e-001;
    __statist_i_h_wts[4,6]=-8.60997701672946e-002;
    __statist_i_h_wts[4,7]=5.70943232757333e-002;
    __statist_i_h_wts[4,8]=-8.41030455310994e-002;
    __statist_i_h_wts[4,9]=-1.66701556984478e-001;
    __statist_i_h_wts[4,10]=3.20210458667596e-001;
    __statist_i_h_wts[4,11]=-1.98490770725667e-001;
    __statist_i_h_wts[4,12]=5.22862843506329e-001;
    __statist_i_h_wts[4,13]=4.62318788348269e-001;
    __statist_i_h_wts[4,14]=8.40095760269560e-001;
    __statist_i_h_wts[4,15]=-1.54356747097995e+000;
    __statist_i_h_wts[4,16]=-9.53291012997369e-001;
    __statist_i_h_wts[4,17]=-6.62265702586612e-001;
    __statist_i_h_wts[4,18]=-6.27341062676036e-001;
    __statist_i_h_wts[4,19]=-4.77107352832049e-001;
    __statist_i_h_wts[4,20]=-4.86825076959405e-001;
    __statist_i_h_wts[4,21]=-3.14408299535988e-001;
    __statist_i_h_wts[4,22]=-1.94667834859436e-001;
    __statist_i_h_wts[4,23]=-2.22823657684171e-001;
    __statist_i_h_wts[4,24]=2.95824542729373e-004;
    __statist_i_h_wts[4,25]=2.11165925064818e-001;
    __statist_i_h_wts[4,26]=-1.80090742834391e-001;
    __statist_i_h_wts[4,27]=6.19143269621418e-001;
    __statist_i_h_wts[4,28]=4.65760997750384e-001;
    __statist_i_h_wts[4,29]=6.08184011425345e-001;
    __statist_i_h_wts[4,30]=-2.10388458543192e+000;
    __statist_i_h_wts[4,31]=-1.36622155906103e+000;
    __statist_i_h_wts[4,32]=-8.48689556910217e-001;
    __statist_i_h_wts[4,33]=-8.80049839430374e-001;
    __statist_i_h_wts[4,34]=-6.17321828191465e-001;
    __statist_i_h_wts[4,35]=-6.00455698612944e-001;
    __statist_i_h_wts[4,36]=-4.74069612455982e-001;
    __statist_i_h_wts[4,37]=1.27461403919147e-001;
    __statist_i_h_wts[4,38]=2.81303736504787e-001;
    __statist_i_h_wts[4,39]=5.95333341507406e-001;
    __statist_i_h_wts[4,40]=7.24369184236341e-001;
    __statist_i_h_wts[4,41]=-1.07913535701018e-001;
    __statist_i_h_wts[4,42]=6.08770486139092e-001;
    __statist_i_h_wts[4,43]=4.67038290036954e-001;
    __statist_i_h_wts[4,44]=8.20074980091525e-001;
    __statist_i_h_wts[4,45]=-1.58338882992868e+000;
    __statist_i_h_wts[4,46]=-1.00931468447561e+000;
    __statist_i_h_wts[4,47]=-9.06775969735945e-001;
    __statist_i_h_wts[4,48]=-1.06121758949798e+000;
    __statist_i_h_wts[4,49]=-8.41492258667358e-001;
    __statist_i_h_wts[4,50]=-5.96997915846597e-001;
    __statist_i_h_wts[4,51]=-9.56100993574305e-001;
    __statist_i_h_wts[4,52]=-4.54910300897245e-001;
    __statist_i_h_wts[4,53]=-2.13697879096425e-001;
    __statist_i_h_wts[4,54]=8.34301994246620e-002;
    __statist_i_h_wts[4,55]=4.21175466716758e-001;
    __statist_i_h_wts[4,56]=2.81073811425826e-002;
    __statist_i_h_wts[4,57]=6.47854026729146e-001;
    __statist_i_h_wts[4,58]=7.93954452625225e-001;
    __statist_i_h_wts[4,59]=1.11654217295261e+000;
    __statist_i_h_wts[4,60]=-1.54206808971298e+000;
    __statist_i_h_wts[4,61]=-8.63922114961334e-001;
    __statist_i_h_wts[4,62]=-7.70285148590106e-001;
    __statist_i_h_wts[4,63]=-8.34995006075383e-001;
    __statist_i_h_wts[4,64]=-7.97409898244699e-001;
    __statist_i_h_wts[4,65]=-8.14602169052337e-001;
    __statist_i_h_wts[4,66]=-9.69872452388825e-001;
    __statist_i_h_wts[4,67]=-3.82600594446783e-001;
    __statist_i_h_wts[4,68]=-1.56333908158587e-001;
    __statist_i_h_wts[4,69]=2.80093179771883e-001;
    __statist_i_h_wts[4,70]=5.37873353796128e-001;
    __statist_i_h_wts[4,71]=-1.77178396478661e-003;
    __statist_i_h_wts[4,72]=7.52632363896806e-001;
    __statist_i_h_wts[4,73]=8.91851834911361e-001;
    __statist_i_h_wts[4,74]=1.17613520223452e+000;
    __statist_i_h_wts[4,75]=-1.46594353062268e+000;
    __statist_i_h_wts[4,76]=-1.04808156313237e+000;
    __statist_i_h_wts[4,77]=-1.08981702729757e+000;
    __statist_i_h_wts[4,78]=-1.08405555082091e+000;
    __statist_i_h_wts[4,79]=-1.11603007103693e+000;
    __statist_i_h_wts[4,80]=-8.76693639143319e-001;
    __statist_i_h_wts[4,81]=-1.29526108533581e+000;
    __statist_i_h_wts[4,82]=-6.78800857911830e-002;
    __statist_i_h_wts[4,83]=-1.72741237608178e-001;
    __statist_i_h_wts[4,84]=3.62308723104387e-001;
    __statist_i_h_wts[4,85]=3.23951658772359e-001;
    __statist_i_h_wts[4,86]=1.10496413358153e-001;
    __statist_i_h_wts[4,87]=6.11739398443057e-001;
    __statist_i_h_wts[4,88]=5.72047160317346e-001;
    __statist_i_h_wts[4,89]=9.15325270311483e-001;
    __statist_i_h_wts[4,90]=-1.93865286644399e+000;
    __statist_i_h_wts[4,91]=-1.35225359193730e+000;
    __statist_i_h_wts[4,92]=-1.23098416066690e+000;
    __statist_i_h_wts[4,93]=-1.29798522168181e+000;
    __statist_i_h_wts[4,94]=-1.22543078630389e+000;
    __statist_i_h_wts[4,95]=-8.55719139841526e-001;
    __statist_i_h_wts[4,96]=-7.75215036311930e-001;
    __statist_i_h_wts[4,97]=1.94759045777050e-001;
    __statist_i_h_wts[4,98]=-4.13650853365092e-002;
    __statist_i_h_wts[4,99]=4.18551280925979e-001;
    __statist_i_h_wts[4,100]=2.16659684488913e-001;
    __statist_i_h_wts[4,101]=1.05530874195836e-001;
    __statist_i_h_wts[4,102]=5.76385063961281e-001;
    __statist_i_h_wts[4,103]=4.40027128980187e-001;
    __statist_i_h_wts[4,104]=7.99007196132042e-001;
    __statist_i_h_wts[4,105]=-1.64849403691596e+000;
    __statist_i_h_wts[4,106]=-8.94364369608583e-001;
    __statist_i_h_wts[4,107]=-9.29635354451004e-001;
    __statist_i_h_wts[4,108]=-9.23634309116517e-001;
    __statist_i_h_wts[4,109]=-3.52333607098494e-001;
    __statist_i_h_wts[4,110]=-3.86418115516948e-001;
    __statist_i_h_wts[4,111]=7.54646125442644e-002;
    __statist_i_h_wts[4,112]=1.86098392558266e-001;
    __statist_i_h_wts[4,113]=2.57210795068179e-001;
    __statist_i_h_wts[4,114]=7.56184525940979e-002;
    __statist_i_h_wts[4,115]=3.43415224088978e-001;
    __statist_i_h_wts[4,116]=4.32208582186551e-001;
    __statist_i_h_wts[4,117]=5.20166887109551e-001;
    __statist_i_h_wts[4,118]=3.55869961607852e-001;
    __statist_i_h_wts[4,119]=6.22331764811020e-001;
    __statist_i_h_wts[4,120]=-1.22381855375884e+000;
    __statist_i_h_wts[4,121]=-7.20546019682774e-001;
    __statist_i_h_wts[4,122]=-7.99109721637321e-001;
    __statist_i_h_wts[4,123]=-5.75292484772410e-001;
    __statist_i_h_wts[4,124]=-3.56516903587442e-001;
    __statist_i_h_wts[4,125]=3.50898970943631e-002;
    __statist_i_h_wts[4,126]=-1.99891941343552e-001;
    __statist_i_h_wts[4,127]=-1.09262406673870e-001;
    __statist_i_h_wts[4,128]=4.02017210420651e-001;
    __statist_i_h_wts[4,129]=2.87258477571149e-001;
    __statist_i_h_wts[4,130]=8.26773473145739e-002;
    __statist_i_h_wts[4,131]=2.23626471795408e-001;
    __statist_i_h_wts[4,132]=7.91333845846271e-001;
    __statist_i_h_wts[4,133]=6.34274671980483e-001;
    __statist_i_h_wts[4,134]=6.34997377575160e-001;
    __statist_i_h_wts[4,135]=-8.73771390241450e-001;
    __statist_i_h_wts[4,136]=-8.41853401002830e-001;
    __statist_i_h_wts[4,137]=-9.58151224224368e-001;
    __statist_i_h_wts[4,138]=-9.21777504718686e-001;
    __statist_i_h_wts[4,139]=-3.36935513285000e-001;
    __statist_i_h_wts[4,140]=-3.46365669505690e-001;
    __statist_i_h_wts[4,141]=-1.13330030906313e-001;
    __statist_i_h_wts[4,142]=1.64222801887065e-001;
    __statist_i_h_wts[4,143]=2.65099349956949e-001;
    __statist_i_h_wts[4,144]=7.41833527388516e-001;
    __statist_i_h_wts[4,145]=6.95146679817418e-001;
    __statist_i_h_wts[4,146]=7.50207780358386e-001;
    __statist_i_h_wts[4,147]=6.87779351028317e-001;
    __statist_i_h_wts[4,148]=6.51455625157868e-001;
    __statist_i_h_wts[4,149]=3.42495812918122e-001;
    __statist_i_h_wts[4,150]=-7.81402840199241e-001;
    __statist_i_h_wts[4,151]=-7.89906092676000e-001;
    __statist_i_h_wts[4,152]=-8.61694545841024e-001;
    __statist_i_h_wts[4,153]=-8.90065251404842e-001;
    __statist_i_h_wts[4,154]=-3.12624245339732e-001;
    __statist_i_h_wts[4,155]=-5.90063509660583e-001;
    __statist_i_h_wts[4,156]=-5.25554573835291e-001;
    __statist_i_h_wts[4,157]=6.98342615338680e-002;
    __statist_i_h_wts[4,158]=1.54895362440247e-001;
    __statist_i_h_wts[4,159]=9.06313078625312e-002;
    __statist_i_h_wts[4,160]=1.52905149557099e-001;
    __statist_i_h_wts[4,161]=3.61770661642071e-001;
    __statist_i_h_wts[4,162]=4.04045416648422e-001;
    __statist_i_h_wts[4,163]=4.23175186865377e-001;
    __statist_i_h_wts[4,164]=6.98334099499960e-002;
    __statist_i_h_wts[4,165]=7.17773715395950e-002;
    __statist_i_h_wts[4,166]=-3.79125538318638e-001;
    __statist_i_h_wts[4,167]=-5.14402204128692e-001;
    __statist_i_h_wts[4,168]=-1.53858737726438e-001;
    __statist_i_h_wts[4,169]=-9.18529998377709e-003;
    __statist_i_h_wts[4,170]=-1.88865464691529e-002;
    __statist_i_h_wts[4,171]=-3.02467752009345e-001;
    __statist_i_h_wts[4,172]=-1.06593180028372e-001;
    __statist_i_h_wts[4,173]=-1.91060714370512e-001;
    __statist_i_h_wts[4,174]=3.54478342080387e-002;
    __statist_i_h_wts[4,175]=2.47731763864370e-001;
    __statist_i_h_wts[4,176]=3.98104830971768e-001;
    __statist_i_h_wts[4,177]=4.21073855311273e-001;
    __statist_i_h_wts[4,178]=5.78197324082196e-001;
    __statist_i_h_wts[4,179]=1.63570831192680e-001;
    __statist_i_h_wts[4,180]=-4.78653860987844e-002;
    __statist_i_h_wts[4,181]=-4.75489208963457e-001;
    __statist_i_h_wts[4,182]=-4.16851485894890e-001;
    __statist_i_h_wts[4,183]=-1.09518480260100e-001;
    __statist_i_h_wts[4,184]=2.04556224762110e-001;
    __statist_i_h_wts[4,185]=-2.17208549986015e-001;
    __statist_i_h_wts[4,186]=6.17481898396224e-002;
    __statist_i_h_wts[4,187]=4.46017129469934e-001;
    __statist_i_h_wts[4,188]=3.32122309300496e-001;
    __statist_i_h_wts[4,189]=4.60203809568182e-001;
    __statist_i_h_wts[4,190]=6.54703285076910e-001;
    __statist_i_h_wts[4,191]=8.08735096470325e-001;
    __statist_i_h_wts[4,192]=9.10210797955287e-001;
    __statist_i_h_wts[4,193]=6.75526895479175e-001;
    __statist_i_h_wts[4,194]=3.86365761322860e-001;
    __statist_i_h_wts[4,195]=1.01138852752117e-001;
    __statist_i_h_wts[4,196]=-2.70623309097223e-001;
    __statist_i_h_wts[4,197]=-3.41584604852481e-001;
    __statist_i_h_wts[4,198]=-2.31268179971700e-001;
    __statist_i_h_wts[4,199]=5.33286285767979e-002;
    __statist_i_h_wts[4,200]=-5.00685071714570e-003;
    __statist_i_h_wts[4,201]=2.44345089303909e-001;
    __statist_i_h_wts[4,202]=4.16728802450179e-001;
    __statist_i_h_wts[4,203]=2.19137036628715e-001;
    __statist_i_h_wts[4,204]=3.87976506546404e-001;
    __statist_i_h_wts[4,205]=4.45099839601269e-001;
    __statist_i_h_wts[4,206]=4.96653801734760e-001;
    __statist_i_h_wts[4,207]=5.63960295521493e-001;
    __statist_i_h_wts[4,208]=4.77605786087901e-001;
    __statist_i_h_wts[4,209]=2.60224093514469e-001;
    __statist_i_h_wts[4,210]=-2.52651691821951e-001;
    __statist_i_h_wts[4,211]=-3.47734890874408e-001;
    __statist_i_h_wts[4,212]=-6.08765394308834e-001;
    __statist_i_h_wts[4,213]=-2.94885259671365e-001;
    __statist_i_h_wts[4,214]=-1.49729977909110e-001;
    __statist_i_h_wts[4,215]=4.16472366557413e-002;
    __statist_i_h_wts[4,216]=1.61546310527806e-001;
    __statist_i_h_wts[4,217]=1.31564822829490e-001;
    __statist_i_h_wts[4,218]=5.15147257708914e-001;
    __statist_i_h_wts[4,219]=5.21779734672087e-001;
    __statist_i_h_wts[4,220]=4.91374001563556e-001;
    __statist_i_h_wts[4,221]=5.84861067675296e-001;
    __statist_i_h_wts[4,222]=6.25518642765211e-001;
    __statist_i_h_wts[4,223]=4.36607774932297e-001;
    __statist_i_h_wts[4,224]=4.03563685746798e-001;
    __statist_i_h_wts[4,225]=1.08620752340917e-001;
    __statist_i_h_wts[4,226]=-1.01171716810971e+000;
    __statist_i_h_wts[4,227]=3.70529951078006e-001;
    __statist_i_h_wts[4,228]=-2.54896485220828e-001;
    __statist_i_h_wts[4,229]=7.76780318575210e-001;
    __statist_i_h_wts[4,230]=1.47778123053942e+000;
    __statist_i_h_wts[4,231]=1.02933414465984e+000;
    __statist_i_h_wts[4,232]=1.71834296874015e+000;
    __statist_i_h_wts[4,233]=1.09929001683215e-001;
    __statist_i_h_wts[4,234]=1.62499540619869e+000;
    __statist_i_h_wts[4,235]=-4.26024614459568e-001;
    __statist_i_h_wts[4,236]=-8.75868377757685e-001;
    __statist_i_h_wts[4,237]=-1.97142380908145e+000;
    __statist_i_h_wts[4,238]=-9.37669250720254e-001;
    __statist_i_h_wts[4,239]=1.02521344040292e+000;
    __statist_i_h_wts[4,240]=-2.10992039794506e-001;
    __statist_i_h_wts[4,241]=1.27860831108347e+000;
    __statist_i_h_wts[4,242]=-7.01451437034402e-001;
    __statist_i_h_wts[4,243]=1.30350440987825e+000;
    __statist_i_h_wts[4,244]=-8.06641425222394e-001;
    __statist_i_h_wts[4,245]=-1.30681542805572e+000;
    __statist_i_h_wts[4,246]=4.24092780572478e-001;
    __statist_i_h_wts[4,247]=-1.53836648293218e+000;
    __statist_i_h_wts[4,248]=-1.51034401860727e-001;

    __statist_i_h_wts[5,0]=-5.99496891625878e-001;
    __statist_i_h_wts[5,1]=-6.01601624035986e-001;
    __statist_i_h_wts[5,2]=-5.71899330968081e-001;
    __statist_i_h_wts[5,3]=-3.26777196494852e-001;
    __statist_i_h_wts[5,4]=-1.81034156557087e-001;
    __statist_i_h_wts[5,5]=-5.74946210019223e-002;
    __statist_i_h_wts[5,6]=-3.74391565399698e-002;
    __statist_i_h_wts[5,7]=4.38040837621675e-002;
    __statist_i_h_wts[5,8]=1.54346719274975e-001;
    __statist_i_h_wts[5,9]=2.69391448425013e-001;
    __statist_i_h_wts[5,10]=3.11105597101672e-001;
    __statist_i_h_wts[5,11]=3.70407099788918e-001;
    __statist_i_h_wts[5,12]=4.16924873781015e-001;
    __statist_i_h_wts[5,13]=4.85629150978279e-001;
    __statist_i_h_wts[5,14]=5.90690430190973e-001;
    __statist_i_h_wts[5,15]=-6.43828492408055e-001;
    __statist_i_h_wts[5,16]=-6.65809105588257e-001;
    __statist_i_h_wts[5,17]=-7.22366286362083e-001;
    __statist_i_h_wts[5,18]=-4.13689672662171e-001;
    __statist_i_h_wts[5,19]=-3.13742253479755e-001;
    __statist_i_h_wts[5,20]=-2.60288939584037e-001;
    __statist_i_h_wts[5,21]=-2.28662676255150e-001;
    __statist_i_h_wts[5,22]=-5.51359082707729e-002;
    __statist_i_h_wts[5,23]=1.26346171355005e-002;
    __statist_i_h_wts[5,24]=1.12734056159812e-001;
    __statist_i_h_wts[5,25]=1.81959103172853e-001;
    __statist_i_h_wts[5,26]=2.66560123468127e-001;
    __statist_i_h_wts[5,27]=3.13763595488380e-001;
    __statist_i_h_wts[5,28]=4.33016111993221e-001;
    __statist_i_h_wts[5,29]=5.71244630744306e-001;
    __statist_i_h_wts[5,30]=-8.24736238997080e-001;
    __statist_i_h_wts[5,31]=-6.88708486832667e-001;
    __statist_i_h_wts[5,32]=-7.50660889948738e-001;
    __statist_i_h_wts[5,33]=-4.72565208902100e-001;
    __statist_i_h_wts[5,34]=-3.63300294012371e-001;
    __statist_i_h_wts[5,35]=-2.83509780382009e-001;
    __statist_i_h_wts[5,36]=-2.43544975065368e-001;
    __statist_i_h_wts[5,37]=-9.84692465665632e-002;
    __statist_i_h_wts[5,38]=-2.66355837328621e-002;
    __statist_i_h_wts[5,39]=8.14200960792900e-002;
    __statist_i_h_wts[5,40]=8.79419295531868e-002;
    __statist_i_h_wts[5,41]=2.25377247502895e-001;
    __statist_i_h_wts[5,42]=3.59866354286078e-001;
    __statist_i_h_wts[5,43]=4.49416796750961e-001;
    __statist_i_h_wts[5,44]=4.93916646940352e-001;
    __statist_i_h_wts[5,45]=-9.35211653014677e-001;
    __statist_i_h_wts[5,46]=-8.41697074803728e-001;
    __statist_i_h_wts[5,47]=-8.56011758591271e-001;
    __statist_i_h_wts[5,48]=-5.68961271244067e-001;
    __statist_i_h_wts[5,49]=-5.38336489753609e-001;
    __statist_i_h_wts[5,50]=-3.78443197886836e-001;
    __statist_i_h_wts[5,51]=-2.15067385675457e-001;
    __statist_i_h_wts[5,52]=5.23071183535706e-003;
    __statist_i_h_wts[5,53]=-7.76299222000294e-004;
    __statist_i_h_wts[5,54]=1.22329062658494e-001;
    __statist_i_h_wts[5,55]=2.79749036454255e-001;
    __statist_i_h_wts[5,56]=4.40976222904928e-001;
    __statist_i_h_wts[5,57]=4.17900016353822e-001;
    __statist_i_h_wts[5,58]=5.63864622660817e-001;
    __statist_i_h_wts[5,59]=5.19268149291770e-001;
    __statist_i_h_wts[5,60]=-8.50908006531394e-001;
    __statist_i_h_wts[5,61]=-7.79301449910842e-001;
    __statist_i_h_wts[5,62]=-8.20399165804642e-001;
    __statist_i_h_wts[5,63]=-6.64454650117841e-001;
    __statist_i_h_wts[5,64]=-6.60320033552946e-001;
    __statist_i_h_wts[5,65]=-4.87499499950926e-001;
    __statist_i_h_wts[5,66]=-3.07046178205520e-001;
    __statist_i_h_wts[5,67]=-1.53163889556089e-003;
    __statist_i_h_wts[5,68]=7.15476942914873e-002;
    __statist_i_h_wts[5,69]=1.70599718291951e-001;
    __statist_i_h_wts[5,70]=1.62932056583156e-001;
    __statist_i_h_wts[5,71]=3.35488828056675e-001;
    __statist_i_h_wts[5,72]=3.45183011362397e-001;
    __statist_i_h_wts[5,73]=5.44363975418196e-001;
    __statist_i_h_wts[5,74]=5.11503327658191e-001;
    __statist_i_h_wts[5,75]=-6.99794212281034e-001;
    __statist_i_h_wts[5,76]=-6.68021191724505e-001;
    __statist_i_h_wts[5,77]=-6.37712640734498e-001;
    __statist_i_h_wts[5,78]=-6.03247955849196e-001;
    __statist_i_h_wts[5,79]=-5.77180365110504e-001;
    __statist_i_h_wts[5,80]=-5.25766085248139e-001;
    __statist_i_h_wts[5,81]=-2.86860478191677e-001;
    __statist_i_h_wts[5,82]=-8.32578243438826e-002;
    __statist_i_h_wts[5,83]=8.61299284884211e-002;
    __statist_i_h_wts[5,84]=7.31949779876778e-002;
    __statist_i_h_wts[5,85]=6.65116904077733e-002;
    __statist_i_h_wts[5,86]=1.12420717168890e-001;
    __statist_i_h_wts[5,87]=1.38132222697326e-001;
    __statist_i_h_wts[5,88]=3.48303151953944e-001;
    __statist_i_h_wts[5,89]=3.94897413311058e-001;
    __statist_i_h_wts[5,90]=-7.37140943070663e-001;
    __statist_i_h_wts[5,91]=-5.99084296785751e-001;
    __statist_i_h_wts[5,92]=-6.12654440263421e-001;
    __statist_i_h_wts[5,93]=-5.72086355063103e-001;
    __statist_i_h_wts[5,94]=-4.88903002986169e-001;
    __statist_i_h_wts[5,95]=-4.61338348400471e-001;
    __statist_i_h_wts[5,96]=-3.34554299325765e-001;
    __statist_i_h_wts[5,97]=-2.28530691850044e-001;
    __statist_i_h_wts[5,98]=-1.98769529690907e-002;
    __statist_i_h_wts[5,99]=-8.14195702575033e-002;
    __statist_i_h_wts[5,100]=-3.11962961950951e-002;
    __statist_i_h_wts[5,101]=5.77635075376459e-002;
    __statist_i_h_wts[5,102]=8.32254529592797e-002;
    __statist_i_h_wts[5,103]=3.29291855914064e-001;
    __statist_i_h_wts[5,104]=3.57918969932604e-001;
    __statist_i_h_wts[5,105]=-5.76413706030772e-001;
    __statist_i_h_wts[5,106]=-4.94641753117887e-001;
    __statist_i_h_wts[5,107]=-4.68558302663141e-001;
    __statist_i_h_wts[5,108]=-3.81332199255042e-001;
    __statist_i_h_wts[5,109]=-3.90329900191478e-001;
    __statist_i_h_wts[5,110]=-2.74419924914416e-001;
    __statist_i_h_wts[5,111]=-1.63800574494618e-001;
    __statist_i_h_wts[5,112]=-2.04059982172737e-001;
    __statist_i_h_wts[5,113]=-3.36445993659973e-002;
    __statist_i_h_wts[5,114]=-6.04947070197199e-002;
    __statist_i_h_wts[5,115]=-5.13151890478998e-002;
    __statist_i_h_wts[5,116]=-9.44270435971773e-002;
    __statist_i_h_wts[5,117]=3.11299382093428e-002;
    __statist_i_h_wts[5,118]=2.44404460276755e-001;
    __statist_i_h_wts[5,119]=3.07224433751125e-001;
    __statist_i_h_wts[5,120]=-5.05062412680349e-001;
    __statist_i_h_wts[5,121]=-4.45596231549908e-001;
    __statist_i_h_wts[5,122]=-4.05986467621136e-001;
    __statist_i_h_wts[5,123]=-2.58368618601799e-001;
    __statist_i_h_wts[5,124]=-2.23166504439829e-001;
    __statist_i_h_wts[5,125]=-1.71042324637967e-001;
    __statist_i_h_wts[5,126]=-1.97221865271904e-002;
    __statist_i_h_wts[5,127]=-1.40165600232686e-002;
    __statist_i_h_wts[5,128]=2.39790432776652e-002;
    __statist_i_h_wts[5,129]=8.10165453262362e-002;
    __statist_i_h_wts[5,130]=1.38398214525416e-001;
    __statist_i_h_wts[5,131]=8.70077037637357e-002;
    __statist_i_h_wts[5,132]=1.76048705908257e-001;
    __statist_i_h_wts[5,133]=3.65368342525290e-001;
    __statist_i_h_wts[5,134]=3.28759200908223e-001;
    __statist_i_h_wts[5,135]=-4.79997378888172e-001;
    __statist_i_h_wts[5,136]=-3.69015961875613e-001;
    __statist_i_h_wts[5,137]=-3.60072527937675e-001;
    __statist_i_h_wts[5,138]=-3.04749049400821e-001;
    __statist_i_h_wts[5,139]=-2.26007564015488e-001;
    __statist_i_h_wts[5,140]=-1.55129116131194e-001;
    __statist_i_h_wts[5,141]=-1.11236487685157e-003;
    __statist_i_h_wts[5,142]=-2.51090256467102e-002;
    __statist_i_h_wts[5,143]=5.24084440521778e-002;
    __statist_i_h_wts[5,144]=4.16167838056335e-002;
    __statist_i_h_wts[5,145]=9.68879926529134e-002;
    __statist_i_h_wts[5,146]=5.30576338611786e-002;
    __statist_i_h_wts[5,147]=1.45521681572893e-001;
    __statist_i_h_wts[5,148]=2.62738840094285e-001;
    __statist_i_h_wts[5,149]=2.84292037647277e-001;
    __statist_i_h_wts[5,150]=-4.59427784980122e-001;
    __statist_i_h_wts[5,151]=-4.05687632608626e-001;
    __statist_i_h_wts[5,152]=-3.54831089606560e-001;
    __statist_i_h_wts[5,153]=-2.92160898077627e-001;
    __statist_i_h_wts[5,154]=-1.94851104452587e-001;
    __statist_i_h_wts[5,155]=-1.09684838606296e-002;
    __statist_i_h_wts[5,156]=1.22054243553662e-001;
    __statist_i_h_wts[5,157]=1.03740845692360e-001;
    __statist_i_h_wts[5,158]=5.95536506488906e-002;
    __statist_i_h_wts[5,159]=6.01541340219405e-002;
    __statist_i_h_wts[5,160]=1.83541627465382e-001;
    __statist_i_h_wts[5,161]=1.85596129991859e-001;
    __statist_i_h_wts[5,162]=3.01690149640061e-001;
    __statist_i_h_wts[5,163]=2.78474455012301e-001;
    __statist_i_h_wts[5,164]=2.14602539600601e-001;
    __statist_i_h_wts[5,165]=-2.33133536502517e-001;
    __statist_i_h_wts[5,166]=-2.78437627888280e-001;
    __statist_i_h_wts[5,167]=-2.49132834516691e-001;
    __statist_i_h_wts[5,168]=-1.46306070806767e-001;
    __statist_i_h_wts[5,169]=-4.05704498159804e-002;
    __statist_i_h_wts[5,170]=1.17033458995764e-001;
    __statist_i_h_wts[5,171]=2.42809433456755e-001;
    __statist_i_h_wts[5,172]=1.81198735517539e-001;
    __statist_i_h_wts[5,173]=1.53002149263914e-001;
    __statist_i_h_wts[5,174]=1.92507598475883e-001;
    __statist_i_h_wts[5,175]=2.59536739090432e-001;
    __statist_i_h_wts[5,176]=2.91656491080969e-001;
    __statist_i_h_wts[5,177]=3.57249136110058e-001;
    __statist_i_h_wts[5,178]=3.78290394918375e-001;
    __statist_i_h_wts[5,179]=3.30617651317555e-001;
    __statist_i_h_wts[5,180]=-1.71294747626968e-001;
    __statist_i_h_wts[5,181]=-2.15000950923236e-001;
    __statist_i_h_wts[5,182]=-1.90085683956522e-001;
    __statist_i_h_wts[5,183]=-7.86068647363979e-002;
    __statist_i_h_wts[5,184]=-4.84252426686539e-002;
    __statist_i_h_wts[5,185]=9.41870851040154e-002;
    __statist_i_h_wts[5,186]=2.72643195804232e-001;
    __statist_i_h_wts[5,187]=2.66240415567055e-001;
    __statist_i_h_wts[5,188]=2.38855932461157e-001;
    __statist_i_h_wts[5,189]=3.10498807556741e-001;
    __statist_i_h_wts[5,190]=3.67276637222600e-001;
    __statist_i_h_wts[5,191]=4.27370219266297e-001;
    __statist_i_h_wts[5,192]=4.61041120707092e-001;
    __statist_i_h_wts[5,193]=5.26240865855135e-001;
    __statist_i_h_wts[5,194]=4.86463215430343e-001;
    __statist_i_h_wts[5,195]=-7.99306368388780e-002;
    __statist_i_h_wts[5,196]=-9.03027647856916e-002;
    __statist_i_h_wts[5,197]=-9.35264850762410e-002;
    __statist_i_h_wts[5,198]=7.31020932839812e-003;
    __statist_i_h_wts[5,199]=1.16162474763048e-003;
    __statist_i_h_wts[5,200]=7.02646401812672e-002;
    __statist_i_h_wts[5,201]=2.60105488788430e-001;
    __statist_i_h_wts[5,202]=2.82560330774731e-001;
    __statist_i_h_wts[5,203]=2.61242819152856e-001;
    __statist_i_h_wts[5,204]=3.67694925213711e-001;
    __statist_i_h_wts[5,205]=4.57176901592548e-001;
    __statist_i_h_wts[5,206]=4.16613781502295e-001;
    __statist_i_h_wts[5,207]=5.81531034477165e-001;
    __statist_i_h_wts[5,208]=6.57897241053465e-001;
    __statist_i_h_wts[5,209]=5.60541860209870e-001;
    __statist_i_h_wts[5,210]=8.60737547870852e-002;
    __statist_i_h_wts[5,211]=1.69599488046340e-002;
    __statist_i_h_wts[5,212]=7.83549430508934e-003;
    __statist_i_h_wts[5,213]=1.62940881865776e-001;
    __statist_i_h_wts[5,214]=1.70258131042354e-001;
    __statist_i_h_wts[5,215]=2.21054069818743e-001;
    __statist_i_h_wts[5,216]=3.27151827889177e-001;
    __statist_i_h_wts[5,217]=2.89908873861810e-001;
    __statist_i_h_wts[5,218]=2.65892979104876e-001;
    __statist_i_h_wts[5,219]=3.77343871470324e-001;
    __statist_i_h_wts[5,220]=3.99094968290388e-001;
    __statist_i_h_wts[5,221]=3.88216007422460e-001;
    __statist_i_h_wts[5,222]=5.49401583878374e-001;
    __statist_i_h_wts[5,223]=6.36470366536676e-001;
    __statist_i_h_wts[5,224]=5.40085332113152e-001;
    __statist_i_h_wts[5,225]=-1.17571415168437e-001;
    __statist_i_h_wts[5,226]=-1.01381259734492e+000;
    __statist_i_h_wts[5,227]=-9.45545457185602e-002;
    __statist_i_h_wts[5,228]=-8.84284215521302e-001;
    __statist_i_h_wts[5,229]=-9.49871720564520e-002;
    __statist_i_h_wts[5,230]=1.36588785242573e+000;
    __statist_i_h_wts[5,231]=3.02338914492540e-001;
    __statist_i_h_wts[5,232]=2.47810224038499e+000;
    __statist_i_h_wts[5,233]=7.74154570553056e-001;
    __statist_i_h_wts[5,234]=9.73590303695909e-001;
    __statist_i_h_wts[5,235]=-6.83086313989926e-001;
    __statist_i_h_wts[5,236]=-2.96233105316841e+000;
    __statist_i_h_wts[5,237]=-5.89613409465263e-001;
    __statist_i_h_wts[5,238]=1.61448395041438e-001;
    __statist_i_h_wts[5,239]=1.06516171964465e+000;
    __statist_i_h_wts[5,240]=-6.17737317379025e-001;
    __statist_i_h_wts[5,241]=1.85955083269133e+000;
    __statist_i_h_wts[5,242]=2.11198051814977e-001;
    __statist_i_h_wts[5,243]=1.21242603937166e+000;
    __statist_i_h_wts[5,244]=-2.54363469045185e-001;
    __statist_i_h_wts[5,245]=-1.60141136731717e+000;
    __statist_i_h_wts[5,246]=1.92820204757909e-001;
    __statist_i_h_wts[5,247]=-8.58766408926321e-001;
    __statist_i_h_wts[5,248]=2.70793032105629e-001;

    __statist_i_h_wts[6,0]=-4.30955490443330e-001;
    __statist_i_h_wts[6,1]=-4.10551755580150e-001;
    __statist_i_h_wts[6,2]=-2.40551971157283e-001;
    __statist_i_h_wts[6,3]=-2.29421330418006e-001;
    __statist_i_h_wts[6,4]=-2.21914177961487e-001;
    __statist_i_h_wts[6,5]=-1.91216655646330e-001;
    __statist_i_h_wts[6,6]=-8.15367765898082e-002;
    __statist_i_h_wts[6,7]=-1.35230253521655e-001;
    __statist_i_h_wts[6,8]=-5.68962403485844e-002;
    __statist_i_h_wts[6,9]=9.85822847648749e-003;
    __statist_i_h_wts[6,10]=3.55035710174429e-002;
    __statist_i_h_wts[6,11]=6.17027710906626e-002;
    __statist_i_h_wts[6,12]=1.95359863204813e-001;
    __statist_i_h_wts[6,13]=2.40675316498807e-001;
    __statist_i_h_wts[6,14]=1.58960332413462e-001;
    __statist_i_h_wts[6,15]=-3.56116189216215e-001;
    __statist_i_h_wts[6,16]=-3.03485843091970e-001;
    __statist_i_h_wts[6,17]=-2.42761110738985e-001;
    __statist_i_h_wts[6,18]=-2.19049679828974e-001;
    __statist_i_h_wts[6,19]=-1.88583129524349e-001;
    __statist_i_h_wts[6,20]=-1.48330973661749e-001;
    __statist_i_h_wts[6,21]=-1.54519274143256e-001;
    __statist_i_h_wts[6,22]=-1.61369936869040e-001;
    __statist_i_h_wts[6,23]=-1.16654414149452e-001;
    __statist_i_h_wts[6,24]=1.06172106312596e-002;
    __statist_i_h_wts[6,25]=8.53894250991777e-003;
    __statist_i_h_wts[6,26]=-1.63415193154962e-002;
    __statist_i_h_wts[6,27]=1.14426826226737e-001;
    __statist_i_h_wts[6,28]=2.00260303408815e-001;
    __statist_i_h_wts[6,29]=1.51243520613293e-001;
    __statist_i_h_wts[6,30]=-4.39399885912000e-001;
    __statist_i_h_wts[6,31]=-3.38755164877305e-001;
    __statist_i_h_wts[6,32]=-2.37349470998716e-001;
    __statist_i_h_wts[6,33]=-2.94923407796258e-001;
    __statist_i_h_wts[6,34]=-2.97266796687177e-001;
    __statist_i_h_wts[6,35]=-1.75700827647806e-001;
    __statist_i_h_wts[6,36]=-1.64454623755184e-001;
    __statist_i_h_wts[6,37]=-1.36709633513356e-001;
    __statist_i_h_wts[6,38]=-8.81747197073647e-002;
    __statist_i_h_wts[6,39]=9.58635786296592e-002;
    __statist_i_h_wts[6,40]=-1.14863274055975e-002;
    __statist_i_h_wts[6,41]=2.73178902559580e-002;
    __statist_i_h_wts[6,42]=9.97288187723941e-002;
    __statist_i_h_wts[6,43]=2.72318175800230e-001;
    __statist_i_h_wts[6,44]=2.89233759307966e-001;
    __statist_i_h_wts[6,45]=-3.93487132527797e-001;
    __statist_i_h_wts[6,46]=-3.92061530544222e-001;
    __statist_i_h_wts[6,47]=-5.09885518074798e-001;
    __statist_i_h_wts[6,48]=-4.99736309319724e-001;
    __statist_i_h_wts[6,49]=-5.13384367940384e-001;
    __statist_i_h_wts[6,50]=-4.89543710502532e-001;
    __statist_i_h_wts[6,51]=-3.92091681507069e-001;
    __statist_i_h_wts[6,52]=-2.39146651082789e-001;
    __statist_i_h_wts[6,53]=-3.71433870698689e-002;
    __statist_i_h_wts[6,54]=2.06570892558686e-002;
    __statist_i_h_wts[6,55]=3.57162065353033e-002;
    __statist_i_h_wts[6,56]=1.59305191717773e-001;
    __statist_i_h_wts[6,57]=2.26770843133305e-001;
    __statist_i_h_wts[6,58]=2.55522805133969e-001;
    __statist_i_h_wts[6,59]=2.72153221990991e-001;
    __statist_i_h_wts[6,60]=-2.78914352419585e-001;
    __statist_i_h_wts[6,61]=-2.89596985377529e-001;
    __statist_i_h_wts[6,62]=-4.14674413772512e-001;
    __statist_i_h_wts[6,63]=-4.55175035231069e-001;
    __statist_i_h_wts[6,64]=-5.57143408773726e-001;
    __statist_i_h_wts[6,65]=-5.21933459051170e-001;
    __statist_i_h_wts[6,66]=-3.74132330639996e-001;
    __statist_i_h_wts[6,67]=-1.56581816172350e-001;
    __statist_i_h_wts[6,68]=5.03594164142278e-002;
    __statist_i_h_wts[6,69]=7.62061558946788e-002;
    __statist_i_h_wts[6,70]=1.29426223101197e-001;
    __statist_i_h_wts[6,71]=2.80178255340797e-001;
    __statist_i_h_wts[6,72]=3.36173622970219e-001;
    __statist_i_h_wts[6,73]=2.78115287854673e-001;
    __statist_i_h_wts[6,74]=3.65420974992708e-001;
    __statist_i_h_wts[6,75]=-2.42050638108191e-001;
    __statist_i_h_wts[6,76]=-2.18621207808999e-001;
    __statist_i_h_wts[6,77]=-3.37693494947469e-001;
    __statist_i_h_wts[6,78]=-3.25917106864608e-001;
    __statist_i_h_wts[6,79]=-3.18327229861646e-001;
    __statist_i_h_wts[6,80]=-3.06023556930208e-001;
    __statist_i_h_wts[6,81]=-2.13902729767094e-001;
    __statist_i_h_wts[6,82]=-1.13075263600162e-001;
    __statist_i_h_wts[6,83]=-4.97939690270757e-002;
    __statist_i_h_wts[6,84]=1.94728559658443e-001;
    __statist_i_h_wts[6,85]=1.25995391319940e-001;
    __statist_i_h_wts[6,86]=1.86806476895785e-001;
    __statist_i_h_wts[6,87]=2.32694009950868e-001;
    __statist_i_h_wts[6,88]=3.81557032924143e-001;
    __statist_i_h_wts[6,89]=4.96719437706058e-001;
    __statist_i_h_wts[6,90]=-3.40060131406295e-001;
    __statist_i_h_wts[6,91]=-2.98760843328444e-001;
    __statist_i_h_wts[6,92]=-3.69996274743405e-001;
    __statist_i_h_wts[6,93]=-3.88109810876709e-001;
    __statist_i_h_wts[6,94]=-2.05431541452637e-001;
    __statist_i_h_wts[6,95]=-2.10401941690374e-001;
    __statist_i_h_wts[6,96]=-2.05258866168818e-001;
    __statist_i_h_wts[6,97]=-1.95851842635604e-001;
    __statist_i_h_wts[6,98]=1.64987214867805e-001;
    __statist_i_h_wts[6,99]=2.30654318026093e-001;
    __statist_i_h_wts[6,100]=1.90043456881583e-001;
    __statist_i_h_wts[6,101]=2.00629394454183e-001;
    __statist_i_h_wts[6,102]=2.20278018443005e-001;
    __statist_i_h_wts[6,103]=1.97120337609646e-001;
    __statist_i_h_wts[6,104]=3.28351941634407e-001;
    __statist_i_h_wts[6,105]=-2.00075735393117e-001;
    __statist_i_h_wts[6,106]=-2.23535330757118e-001;
    __statist_i_h_wts[6,107]=-2.41359098085359e-001;
    __statist_i_h_wts[6,108]=-2.99531192649430e-001;
    __statist_i_h_wts[6,109]=-2.27381257867425e-001;
    __statist_i_h_wts[6,110]=-1.45600875160805e-001;
    __statist_i_h_wts[6,111]=-2.07455246771244e-001;
    __statist_i_h_wts[6,112]=-7.59497518475060e-002;
    __statist_i_h_wts[6,113]=2.20208451445026e-001;
    __statist_i_h_wts[6,114]=2.11607450688225e-001;
    __statist_i_h_wts[6,115]=2.70047727156735e-001;
    __statist_i_h_wts[6,116]=2.57107224822457e-001;
    __statist_i_h_wts[6,117]=2.82400498795968e-001;
    __statist_i_h_wts[6,118]=1.89167171566872e-001;
    __statist_i_h_wts[6,119]=2.13037193212192e-001;
    __statist_i_h_wts[6,120]=-2.96274508884029e-001;
    __statist_i_h_wts[6,121]=-3.32541073682271e-001;
    __statist_i_h_wts[6,122]=-2.70791970835295e-001;
    __statist_i_h_wts[6,123]=-2.51495658591418e-001;
    __statist_i_h_wts[6,124]=-1.85636894973903e-001;
    __statist_i_h_wts[6,125]=-1.71933671982303e-002;
    __statist_i_h_wts[6,126]=4.22217426421605e-002;
    __statist_i_h_wts[6,127]=1.06404187927335e-001;
    __statist_i_h_wts[6,128]=2.68732293671337e-001;
    __statist_i_h_wts[6,129]=1.62892528427245e-001;
    __statist_i_h_wts[6,130]=1.89170486581812e-001;
    __statist_i_h_wts[6,131]=1.79527901877238e-001;
    __statist_i_h_wts[6,132]=2.74237197532815e-001;
    __statist_i_h_wts[6,133]=2.55244534146482e-001;
    __statist_i_h_wts[6,134]=2.55858636169117e-001;
    __statist_i_h_wts[6,135]=-1.94917068137148e-001;
    __statist_i_h_wts[6,136]=-2.68892677073230e-001;
    __statist_i_h_wts[6,137]=-3.10240760680447e-001;
    __statist_i_h_wts[6,138]=-2.51635296727581e-001;
    __statist_i_h_wts[6,139]=-1.97504183566745e-001;
    __statist_i_h_wts[6,140]=-2.15653901205347e-001;
    __statist_i_h_wts[6,141]=-8.60884880744352e-002;
    __statist_i_h_wts[6,142]=3.34503708255379e-002;
    __statist_i_h_wts[6,143]=1.46022894534162e-001;
    __statist_i_h_wts[6,144]=1.11350913836879e-001;
    __statist_i_h_wts[6,145]=1.75079551519939e-001;
    __statist_i_h_wts[6,146]=1.57895703139205e-001;
    __statist_i_h_wts[6,147]=1.95142185696186e-001;
    __statist_i_h_wts[6,148]=2.63009740172104e-001;
    __statist_i_h_wts[6,149]=2.58781737243991e-001;
    __statist_i_h_wts[6,150]=-2.06117333174910e-001;
    __statist_i_h_wts[6,151]=-3.01346271246084e-001;
    __statist_i_h_wts[6,152]=-2.58735140344776e-001;
    __statist_i_h_wts[6,153]=-2.13379754985820e-001;
    __statist_i_h_wts[6,154]=-2.14475320870377e-001;
    __statist_i_h_wts[6,155]=-1.99078385047061e-001;
    __statist_i_h_wts[6,156]=-1.99479059102770e-003;
    __statist_i_h_wts[6,157]=4.64394597785085e-002;
    __statist_i_h_wts[6,158]=1.27556844841579e-001;
    __statist_i_h_wts[6,159]=4.76742127007423e-002;
    __statist_i_h_wts[6,160]=2.05599320745144e-001;
    __statist_i_h_wts[6,161]=1.79826158081867e-001;
    __statist_i_h_wts[6,162]=2.84794422302959e-001;
    __statist_i_h_wts[6,163]=1.65440563799735e-001;
    __statist_i_h_wts[6,164]=1.27588503193893e-001;
    __statist_i_h_wts[6,165]=-8.74604106868529e-002;
    __statist_i_h_wts[6,166]=-2.01304008671514e-001;
    __statist_i_h_wts[6,167]=-2.20374101995505e-001;
    __statist_i_h_wts[6,168]=-2.00551207073137e-001;
    __statist_i_h_wts[6,169]=-2.34100617059120e-001;
    __statist_i_h_wts[6,170]=-1.88980015702479e-001;
    __statist_i_h_wts[6,171]=-3.48547122561351e-002;
    __statist_i_h_wts[6,172]=4.19180360756138e-002;
    __statist_i_h_wts[6,173]=-2.09242119483714e-002;
    __statist_i_h_wts[6,174]=-2.67804556428347e-002;
    __statist_i_h_wts[6,175]=1.37876957721607e-001;
    __statist_i_h_wts[6,176]=1.75291526340795e-001;
    __statist_i_h_wts[6,177]=2.16367026343673e-001;
    __statist_i_h_wts[6,178]=2.74505200732527e-001;
    __statist_i_h_wts[6,179]=1.81256755937088e-001;
    __statist_i_h_wts[6,180]=-2.92559005171901e-002;
    __statist_i_h_wts[6,181]=-9.55137700098084e-002;
    __statist_i_h_wts[6,182]=-6.16861283712395e-002;
    __statist_i_h_wts[6,183]=4.53670270234755e-002;
    __statist_i_h_wts[6,184]=1.86205383100324e-002;
    __statist_i_h_wts[6,185]=5.06961219883856e-003;
    __statist_i_h_wts[6,186]=1.73900706429639e-001;
    __statist_i_h_wts[6,187]=1.28773947845172e-001;
    __statist_i_h_wts[6,188]=1.64022328392011e-001;
    __statist_i_h_wts[6,189]=1.04401048634718e-001;
    __statist_i_h_wts[6,190]=2.00637691831672e-001;
    __statist_i_h_wts[6,191]=2.45917857487761e-001;
    __statist_i_h_wts[6,192]=2.57135267503941e-001;
    __statist_i_h_wts[6,193]=2.56677741963932e-001;
    __statist_i_h_wts[6,194]=2.02675000490691e-001;
    __statist_i_h_wts[6,195]=-7.49056649544338e-002;
    __statist_i_h_wts[6,196]=-1.35278007817322e-001;
    __statist_i_h_wts[6,197]=-1.09511975424107e-001;
    __statist_i_h_wts[6,198]=-1.44491855417652e-004;
    __statist_i_h_wts[6,199]=7.22604052037754e-002;
    __statist_i_h_wts[6,200]=1.11462395903131e-001;
    __statist_i_h_wts[6,201]=2.62812156785923e-001;
    __statist_i_h_wts[6,202]=2.25216791550564e-001;
    __statist_i_h_wts[6,203]=2.09734582526681e-001;
    __statist_i_h_wts[6,204]=1.93122658977654e-001;
    __statist_i_h_wts[6,205]=2.37895400122333e-001;
    __statist_i_h_wts[6,206]=2.24465402282675e-001;
    __statist_i_h_wts[6,207]=2.36003537564534e-001;
    __statist_i_h_wts[6,208]=2.28123084174008e-001;
    __statist_i_h_wts[6,209]=1.92013522967289e-001;
    __statist_i_h_wts[6,210]=4.26788714616252e-002;
    __statist_i_h_wts[6,211]=-2.97070071016897e-002;
    __statist_i_h_wts[6,212]=-1.54677222487413e-002;
    __statist_i_h_wts[6,213]=4.74031847946136e-002;
    __statist_i_h_wts[6,214]=1.18905638229958e-001;
    __statist_i_h_wts[6,215]=1.67110109497879e-001;
    __statist_i_h_wts[6,216]=2.14597745982181e-001;
    __statist_i_h_wts[6,217]=1.62910407051363e-001;
    __statist_i_h_wts[6,218]=2.28525647069680e-001;
    __statist_i_h_wts[6,219]=1.97589238992213e-001;
    __statist_i_h_wts[6,220]=2.23013510965769e-001;
    __statist_i_h_wts[6,221]=2.04772964205684e-001;
    __statist_i_h_wts[6,222]=2.25289756008830e-001;
    __statist_i_h_wts[6,223]=2.15371011180690e-001;
    __statist_i_h_wts[6,224]=2.10181478722223e-001;
    __statist_i_h_wts[6,225]=3.61463734348405e-002;
    __statist_i_h_wts[6,226]=-2.64912133015123e-001;
    __statist_i_h_wts[6,227]=9.14526521910686e-002;
    __statist_i_h_wts[6,228]=-2.53672107120686e-001;
    __statist_i_h_wts[6,229]=1.59036384329184e-001;
    __statist_i_h_wts[6,230]=6.43453163384593e-001;
    __statist_i_h_wts[6,231]=2.12932674443019e-001;
    __statist_i_h_wts[6,232]=8.69638900549911e-001;
    __statist_i_h_wts[6,233]=2.45542940601582e-001;
    __statist_i_h_wts[6,234]=4.28600531451735e-001;
    __statist_i_h_wts[6,235]=-1.47974075973608e-001;
    __statist_i_h_wts[6,236]=-8.30297169488115e-001;
    __statist_i_h_wts[6,237]=-5.91963385694357e-001;
    __statist_i_h_wts[6,238]=3.91268511225695e-003;
    __statist_i_h_wts[6,239]=5.91292345308269e-001;
    __statist_i_h_wts[6,240]=-1.39155725535134e-001;
    __statist_i_h_wts[6,241]=6.72620319858833e-001;
    __statist_i_h_wts[6,242]=-1.24357021565481e-001;
    __statist_i_h_wts[6,243]=6.13447588506080e-001;
    __statist_i_h_wts[6,244]=-2.37836651619417e-001;
    __statist_i_h_wts[6,245]=-7.16403401343897e-001;
    __statist_i_h_wts[6,246]=1.25796880391589e-001;
    __statist_i_h_wts[6,247]=-5.30614529510136e-001;
    __statist_i_h_wts[6,248]=5.17348511232878e-002;

    __statist_i_h_wts[7,0]=2.14862106325494e-001;
    __statist_i_h_wts[7,1]=1.94226611121811e-001;
    __statist_i_h_wts[7,2]=1.45350773212886e-001;
    __statist_i_h_wts[7,3]=6.78028979282637e-002;
    __statist_i_h_wts[7,4]=4.18415925809005e-002;
    __statist_i_h_wts[7,5]=3.37142533018925e-002;
    __statist_i_h_wts[7,6]=2.05519664575593e-002;
    __statist_i_h_wts[7,7]=-1.48495330583834e-002;
    __statist_i_h_wts[7,8]=-7.28504188926976e-002;
    __statist_i_h_wts[7,9]=-9.50506227264949e-002;
    __statist_i_h_wts[7,10]=-1.32766107072862e-001;
    __statist_i_h_wts[7,11]=-1.66340268910795e-001;
    __statist_i_h_wts[7,12]=-1.67938962608580e-001;
    __statist_i_h_wts[7,13]=-2.41848388849038e-001;
    __statist_i_h_wts[7,14]=-2.76776215562375e-001;
    __statist_i_h_wts[7,15]=2.54160662567281e-001;
    __statist_i_h_wts[7,16]=2.60043761384870e-001;
    __statist_i_h_wts[7,17]=1.81704321184520e-001;
    __statist_i_h_wts[7,18]=7.44432436367099e-002;
    __statist_i_h_wts[7,19]=1.21241902945327e-001;
    __statist_i_h_wts[7,20]=1.59942817806147e-001;
    __statist_i_h_wts[7,21]=1.03835913304821e-001;
    __statist_i_h_wts[7,22]=4.70695341957335e-002;
    __statist_i_h_wts[7,23]=-2.16285572127851e-003;
    __statist_i_h_wts[7,24]=-4.90760358103197e-002;
    __statist_i_h_wts[7,25]=-9.79195969377939e-002;
    __statist_i_h_wts[7,26]=-9.76258717958626e-002;
    __statist_i_h_wts[7,27]=-8.44628601649343e-002;
    __statist_i_h_wts[7,28]=-1.90787450208632e-001;
    __statist_i_h_wts[7,29]=-2.43599305026536e-001;
    __statist_i_h_wts[7,30]=3.22913909444877e-001;
    __statist_i_h_wts[7,31]=2.69609280857997e-001;
    __statist_i_h_wts[7,32]=2.34837702205633e-001;
    __statist_i_h_wts[7,33]=1.44893772232452e-001;
    __statist_i_h_wts[7,34]=1.18944537990941e-001;
    __statist_i_h_wts[7,35]=1.18115385028212e-001;
    __statist_i_h_wts[7,36]=2.60279094373838e-002;
    __statist_i_h_wts[7,37]=-1.07230355419640e-002;
    __statist_i_h_wts[7,38]=-9.28677799207489e-002;
    __statist_i_h_wts[7,39]=-1.10314663505189e-001;
    __statist_i_h_wts[7,40]=-1.32173719128501e-001;
    __statist_i_h_wts[7,41]=-1.01441333616660e-001;
    __statist_i_h_wts[7,42]=-1.65285487889414e-001;
    __statist_i_h_wts[7,43]=-1.82256391373773e-001;
    __statist_i_h_wts[7,44]=-2.13759572670082e-001;
    __statist_i_h_wts[7,45]=3.10957745291415e-001;
    __statist_i_h_wts[7,46]=3.01742493557171e-001;
    __statist_i_h_wts[7,47]=2.78826861403871e-001;
    __statist_i_h_wts[7,48]=1.83172984336127e-001;
    __statist_i_h_wts[7,49]=1.88955319679597e-001;
    __statist_i_h_wts[7,50]=1.62808204633245e-001;
    __statist_i_h_wts[7,51]=8.98366460292685e-002;
    __statist_i_h_wts[7,52]=4.37735555751576e-003;
    __statist_i_h_wts[7,53]=-3.05841527436005e-002;
    __statist_i_h_wts[7,54]=-1.34290824364318e-001;
    __statist_i_h_wts[7,55]=-1.82093440478994e-001;
    __statist_i_h_wts[7,56]=-2.11265914786514e-001;
    __statist_i_h_wts[7,57]=-1.67563693920093e-001;
    __statist_i_h_wts[7,58]=-2.06371451504843e-001;
    __statist_i_h_wts[7,59]=-1.58610525174215e-001;
    __statist_i_h_wts[7,60]=2.36702970758292e-001;
    __statist_i_h_wts[7,61]=2.54309676094271e-001;
    __statist_i_h_wts[7,62]=2.41611741353601e-001;
    __statist_i_h_wts[7,63]=1.38229407336255e-001;
    __statist_i_h_wts[7,64]=1.58144787935937e-001;
    __statist_i_h_wts[7,65]=1.80866229458389e-001;
    __statist_i_h_wts[7,66]=1.27166779941642e-001;
    __statist_i_h_wts[7,67]=4.05087296670090e-003;
    __statist_i_h_wts[7,68]=-3.43241015132223e-002;
    __statist_i_h_wts[7,69]=-1.44884481190234e-001;
    __statist_i_h_wts[7,70]=-1.58754556774157e-001;
    __statist_i_h_wts[7,71]=-2.02718860082763e-001;
    __statist_i_h_wts[7,72]=-1.42403908931028e-001;
    __statist_i_h_wts[7,73]=-2.01008683686801e-001;
    __statist_i_h_wts[7,74]=-1.59171949139823e-001;
    __statist_i_h_wts[7,75]=2.74213930456921e-001;
    __statist_i_h_wts[7,76]=2.65363946221017e-001;
    __statist_i_h_wts[7,77]=2.68505327457691e-001;
    __statist_i_h_wts[7,78]=2.40030313892803e-001;
    __statist_i_h_wts[7,79]=2.15825365476743e-001;
    __statist_i_h_wts[7,80]=1.97482929301916e-001;
    __statist_i_h_wts[7,81]=1.14217353136413e-001;
    __statist_i_h_wts[7,82]=3.56814840483186e-002;
    __statist_i_h_wts[7,83]=-2.17244827711994e-002;
    __statist_i_h_wts[7,84]=-6.36763882015645e-002;
    __statist_i_h_wts[7,85]=-1.13321336223441e-001;
    __statist_i_h_wts[7,86]=-8.45666971069988e-002;
    __statist_i_h_wts[7,87]=-1.35486276578646e-001;
    __statist_i_h_wts[7,88]=-1.14432477597374e-001;
    __statist_i_h_wts[7,89]=-1.03001914678612e-001;
    __statist_i_h_wts[7,90]=3.02195867633115e-001;
    __statist_i_h_wts[7,91]=2.83802934350501e-001;
    __statist_i_h_wts[7,92]=3.13264866847628e-001;
    __statist_i_h_wts[7,93]=2.82327740345461e-001;
    __statist_i_h_wts[7,94]=1.98772163209722e-001;
    __statist_i_h_wts[7,95]=1.85297694704402e-001;
    __statist_i_h_wts[7,96]=9.65691492223260e-002;
    __statist_i_h_wts[7,97]=5.71909676208121e-002;
    __statist_i_h_wts[7,98]=-3.38350242263108e-002;
    __statist_i_h_wts[7,99]=-6.51973546228652e-002;
    __statist_i_h_wts[7,100]=-8.27122039705920e-002;
    __statist_i_h_wts[7,101]=-1.10699451853533e-001;
    __statist_i_h_wts[7,102]=-1.50032316890797e-001;
    __statist_i_h_wts[7,103]=-1.45821904203810e-001;
    __statist_i_h_wts[7,104]=-9.36662456638063e-002;
    __statist_i_h_wts[7,105]=2.71934218023198e-001;
    __statist_i_h_wts[7,106]=2.97176494550960e-001;
    __statist_i_h_wts[7,107]=3.21794379306603e-001;
    __statist_i_h_wts[7,108]=2.85995684092615e-001;
    __statist_i_h_wts[7,109]=2.56510181694967e-001;
    __statist_i_h_wts[7,110]=1.73866722602313e-001;
    __statist_i_h_wts[7,111]=5.94810322539946e-002;
    __statist_i_h_wts[7,112]=2.77044209016699e-002;
    __statist_i_h_wts[7,113]=-3.99231203494854e-002;
    __statist_i_h_wts[7,114]=-9.18363198147062e-002;
    __statist_i_h_wts[7,115]=-4.69221501977145e-002;
    __statist_i_h_wts[7,116]=-1.29008524962085e-001;
    __statist_i_h_wts[7,117]=-1.00430230391468e-001;
    __statist_i_h_wts[7,118]=-1.43281685450798e-001;
    __statist_i_h_wts[7,119]=-1.27955920175779e-001;
    __statist_i_h_wts[7,120]=2.05439194667703e-001;
    __statist_i_h_wts[7,121]=2.17823929999086e-001;
    __statist_i_h_wts[7,122]=2.21039244614237e-001;
    __statist_i_h_wts[7,123]=1.63562073318973e-001;
    __statist_i_h_wts[7,124]=2.66717857428661e-001;
    __statist_i_h_wts[7,125]=1.75009707266181e-001;
    __statist_i_h_wts[7,126]=1.41019902719293e-001;
    __statist_i_h_wts[7,127]=6.62715615093234e-002;
    __statist_i_h_wts[7,128]=-3.22640203980887e-002;
    __statist_i_h_wts[7,129]=-1.10571756367543e-001;
    __statist_i_h_wts[7,130]=-8.17711240927069e-002;
    __statist_i_h_wts[7,131]=-1.83782982096877e-001;
    __statist_i_h_wts[7,132]=-1.77667607683253e-001;
    __statist_i_h_wts[7,133]=-1.82651437767168e-001;
    __statist_i_h_wts[7,134]=-1.48152474008674e-001;
    __statist_i_h_wts[7,135]=2.39061102646233e-001;
    __statist_i_h_wts[7,136]=2.13940533716515e-001;
    __statist_i_h_wts[7,137]=2.48278984832826e-001;
    __statist_i_h_wts[7,138]=1.75052917368268e-001;
    __statist_i_h_wts[7,139]=2.78970831848922e-001;
    __statist_i_h_wts[7,140]=1.20890041480287e-001;
    __statist_i_h_wts[7,141]=1.05107618172533e-001;
    __statist_i_h_wts[7,142]=4.90398353270125e-002;
    __statist_i_h_wts[7,143]=-5.04444198649174e-002;
    __statist_i_h_wts[7,144]=-1.19400576455985e-001;
    __statist_i_h_wts[7,145]=-1.16025675593848e-001;
    __statist_i_h_wts[7,146]=-2.03680684656128e-001;
    __statist_i_h_wts[7,147]=-1.52850551834171e-001;
    __statist_i_h_wts[7,148]=-1.53159106589763e-001;
    __statist_i_h_wts[7,149]=-1.28254142083555e-001;
    __statist_i_h_wts[7,150]=1.87033692582133e-001;
    __statist_i_h_wts[7,151]=2.11893202796618e-001;
    __statist_i_h_wts[7,152]=2.33396528574612e-001;
    __statist_i_h_wts[7,153]=1.47359479694674e-001;
    __statist_i_h_wts[7,154]=1.38032928717441e-002;
    __statist_i_h_wts[7,155]=-2.04510558234489e-002;
    __statist_i_h_wts[7,156]=-1.56163369450442e-001;
    __statist_i_h_wts[7,157]=-2.00352259340864e-001;
    __statist_i_h_wts[7,158]=-1.36824183735676e-001;
    __statist_i_h_wts[7,159]=-1.62354139092617e-001;
    __statist_i_h_wts[7,160]=-1.41085998806602e-001;
    __statist_i_h_wts[7,161]=-2.04017139624343e-001;
    __statist_i_h_wts[7,162]=-1.77334481895924e-001;
    __statist_i_h_wts[7,163]=-1.35264122391408e-001;
    __statist_i_h_wts[7,164]=-7.18578183851966e-002;
    __statist_i_h_wts[7,165]=-2.12747115664894e-004;
    __statist_i_h_wts[7,166]=1.05141455819836e-001;
    __statist_i_h_wts[7,167]=1.47058530586909e-001;
    __statist_i_h_wts[7,168]=1.11193460068424e-001;
    __statist_i_h_wts[7,169]=6.64147974546744e-002;
    __statist_i_h_wts[7,170]=-2.20854016701046e-002;
    __statist_i_h_wts[7,171]=-1.88120311539984e-001;
    __statist_i_h_wts[7,172]=-2.04393479718198e-001;
    __statist_i_h_wts[7,173]=-1.52290528154076e-001;
    __statist_i_h_wts[7,174]=-1.92095198512488e-001;
    __statist_i_h_wts[7,175]=-1.42069277523646e-001;
    __statist_i_h_wts[7,176]=-1.63483970885361e-001;
    __statist_i_h_wts[7,177]=-1.14659505151648e-001;
    __statist_i_h_wts[7,178]=-1.14987733873226e-001;
    __statist_i_h_wts[7,179]=-9.65775573166210e-002;
    __statist_i_h_wts[7,180]=2.68524675822903e-003;
    __statist_i_h_wts[7,181]=5.35287931071873e-002;
    __statist_i_h_wts[7,182]=1.11906737326735e-001;
    __statist_i_h_wts[7,183]=6.21470792716015e-002;
    __statist_i_h_wts[7,184]=8.24387025787110e-002;
    __statist_i_h_wts[7,185]=-3.56968971089058e-002;
    __statist_i_h_wts[7,186]=-7.58775658996910e-002;
    __statist_i_h_wts[7,187]=-1.27822943917928e-001;
    __statist_i_h_wts[7,188]=-1.43560094168342e-001;
    __statist_i_h_wts[7,189]=-1.56434792178530e-001;
    __statist_i_h_wts[7,190]=-1.36154160943217e-001;
    __statist_i_h_wts[7,191]=-2.08559570246685e-001;
    __statist_i_h_wts[7,192]=-1.25032782412514e-001;
    __statist_i_h_wts[7,193]=-1.84270262456496e-001;
    __statist_i_h_wts[7,194]=-1.87766194250755e-001;
    __statist_i_h_wts[7,195]=-5.24355484082364e-002;
    __statist_i_h_wts[7,196]=-2.03926259795886e-002;
    __statist_i_h_wts[7,197]=1.76283855667902e-003;
    __statist_i_h_wts[7,198]=-1.02214376603488e-002;
    __statist_i_h_wts[7,199]=-2.29669431675774e-002;
    __statist_i_h_wts[7,200]=-7.64102803988919e-003;
    __statist_i_h_wts[7,201]=-7.92784412821207e-002;
    __statist_i_h_wts[7,202]=-1.17022579865803e-001;
    __statist_i_h_wts[7,203]=-1.18600844067941e-001;
    __statist_i_h_wts[7,204]=-1.56448347670653e-001;
    __statist_i_h_wts[7,205]=-1.24081313042588e-001;
    __statist_i_h_wts[7,206]=-1.82983781667112e-001;
    __statist_i_h_wts[7,207]=-1.87606922867508e-001;
    __statist_i_h_wts[7,208]=-2.02611816835903e-001;
    __statist_i_h_wts[7,209]=-1.77467831433307e-001;
    __statist_i_h_wts[7,210]=-2.21930095209906e-002;
    __statist_i_h_wts[7,211]=-3.04755105264226e-002;
    __statist_i_h_wts[7,212]=-3.66979371234399e-002;
    __statist_i_h_wts[7,213]=-7.22111399294770e-002;
    __statist_i_h_wts[7,214]=-8.60787520273190e-002;
    __statist_i_h_wts[7,215]=-6.72422390897035e-002;
    __statist_i_h_wts[7,216]=-1.38725376816174e-001;
    __statist_i_h_wts[7,217]=-1.67530325777478e-001;
    __statist_i_h_wts[7,218]=-1.27562696400499e-001;
    __statist_i_h_wts[7,219]=-2.04207897779638e-001;
    __statist_i_h_wts[7,220]=-1.57252745058774e-001;
    __statist_i_h_wts[7,221]=-1.39908167913153e-001;
    __statist_i_h_wts[7,222]=-1.49621923613347e-001;
    __statist_i_h_wts[7,223]=-1.81047789765009e-001;
    __statist_i_h_wts[7,224]=-1.48898358460925e-001;
    __statist_i_h_wts[7,225]=3.13420677204344e-002;
    __statist_i_h_wts[7,226]=2.01340643816723e-001;
    __statist_i_h_wts[7,227]=-3.61261267376369e-002;
    __statist_i_h_wts[7,228]=1.82304290098295e-001;
    __statist_i_h_wts[7,229]=-4.34791654243534e-002;
    __statist_i_h_wts[7,230]=-4.70515712557218e-001;
    __statist_i_h_wts[7,231]=-1.12236689421007e-001;
    __statist_i_h_wts[7,232]=-7.48312443601267e-001;
    __statist_i_h_wts[7,233]=-2.35164794539144e-001;
    __statist_i_h_wts[7,234]=-3.19427923933697e-001;
    __statist_i_h_wts[7,235]=2.18621755909167e-001;
    __statist_i_h_wts[7,236]=8.88123617534942e-001;
    __statist_i_h_wts[7,237]=2.07452049421992e-001;
    __statist_i_h_wts[7,238]=3.91249698232290e-002;
    __statist_i_h_wts[7,239]=-2.89881328295106e-001;
    __statist_i_h_wts[7,240]=2.06899655848936e-001;
    __statist_i_h_wts[7,241]=-6.03395503845323e-001;
    __statist_i_h_wts[7,242]=-3.79355522773889e-002;
    __statist_i_h_wts[7,243]=-4.03878029651942e-001;
    __statist_i_h_wts[7,244]=1.44027401191255e-001;
    __statist_i_h_wts[7,245]=4.39359171658991e-001;
    __statist_i_h_wts[7,246]=-6.32481730965291e-002;
    __statist_i_h_wts[7,247]=3.30229224640456e-001;
    __statist_i_h_wts[7,248]=-4.29545159824625e-002;

    __statist_i_h_wts[8,0]=6.72884060257950e-001;
    __statist_i_h_wts[8,1]=4.26051753481005e-001;
    __statist_i_h_wts[8,2]=3.63732334504717e-001;
    __statist_i_h_wts[8,3]=2.66612852543492e-002;
    __statist_i_h_wts[8,4]=5.68659813760040e-002;
    __statist_i_h_wts[8,5]=2.16439058597340e-001;
    __statist_i_h_wts[8,6]=2.21931566848677e-004;
    __statist_i_h_wts[8,7]=1.54926863306696e-001;
    __statist_i_h_wts[8,8]=7.37518986359554e-002;
    __statist_i_h_wts[8,9]=1.58786137258561e-001;
    __statist_i_h_wts[8,10]=-1.47539343747175e-001;
    __statist_i_h_wts[8,11]=1.24120153476197e-001;
    __statist_i_h_wts[8,12]=-1.14710056241474e-001;
    __statist_i_h_wts[8,13]=-8.88588427240416e-002;
    __statist_i_h_wts[8,14]=-7.24698605903794e-002;
    __statist_i_h_wts[8,15]=6.77747214383806e-001;
    __statist_i_h_wts[8,16]=3.88045332051038e-001;
    __statist_i_h_wts[8,17]=1.32724631744364e-001;
    __statist_i_h_wts[8,18]=3.62892264239305e-002;
    __statist_i_h_wts[8,19]=1.16211062754307e-001;
    __statist_i_h_wts[8,20]=1.24526394251655e-001;
    __statist_i_h_wts[8,21]=-1.01599158523318e-001;
    __statist_i_h_wts[8,22]=5.78596771996064e-002;
    __statist_i_h_wts[8,23]=-1.63282217252904e-001;
    __statist_i_h_wts[8,24]=-4.07511163232660e-002;
    __statist_i_h_wts[8,25]=-2.23561499667073e-001;
    __statist_i_h_wts[8,26]=2.45480233980903e-001;
    __statist_i_h_wts[8,27]=-5.34275156711947e-002;
    __statist_i_h_wts[8,28]=-4.78473776561131e-002;
    __statist_i_h_wts[8,29]=-1.76751341758856e-003;
    __statist_i_h_wts[8,30]=6.50012293792886e-001;
    __statist_i_h_wts[8,31]=4.93317386846933e-001;
    __statist_i_h_wts[8,32]=6.72220593571048e-002;
    __statist_i_h_wts[8,33]=2.83054646223985e-002;
    __statist_i_h_wts[8,34]=-6.35059664206950e-003;
    __statist_i_h_wts[8,35]=1.85146292134925e-002;
    __statist_i_h_wts[8,36]=-2.32541344686745e-001;
    __statist_i_h_wts[8,37]=-1.39460472819932e-001;
    __statist_i_h_wts[8,38]=-2.75304735435375e-001;
    __statist_i_h_wts[8,39]=-2.16967539190659e-001;
    __statist_i_h_wts[8,40]=-2.45201676232853e-001;
    __statist_i_h_wts[8,41]=-4.03480074265994e-002;
    __statist_i_h_wts[8,42]=-2.54160114716585e-002;
    __statist_i_h_wts[8,43]=-1.70454926675587e-001;
    __statist_i_h_wts[8,44]=-1.96821607116150e-001;
    __statist_i_h_wts[8,45]=1.76245976694442e-001;
    __statist_i_h_wts[8,46]=4.24083490154267e-001;
    __statist_i_h_wts[8,47]=8.95807665772872e-002;
    __statist_i_h_wts[8,48]=8.01695513425540e-002;
    __statist_i_h_wts[8,49]=8.87270806082370e-002;
    __statist_i_h_wts[8,50]=7.57710103391224e-002;
    __statist_i_h_wts[8,51]=-3.02592036856548e-001;
    __statist_i_h_wts[8,52]=-2.22579126148865e-001;
    __statist_i_h_wts[8,53]=-2.72574502119465e-002;
    __statist_i_h_wts[8,54]=-5.13753675042708e-002;
    __statist_i_h_wts[8,55]=-1.53679633757550e-001;
    __statist_i_h_wts[8,56]=-2.23661142606100e-001;
    __statist_i_h_wts[8,57]=-3.26190214647067e-001;
    __statist_i_h_wts[8,58]=-3.69857507192704e-001;
    __statist_i_h_wts[8,59]=-2.14990640286530e-001;
    __statist_i_h_wts[8,60]=7.22763391103904e-002;
    __statist_i_h_wts[8,61]=3.41028054078760e-001;
    __statist_i_h_wts[8,62]=2.19775138810080e-001;
    __statist_i_h_wts[8,63]=2.63215775256579e-001;
    __statist_i_h_wts[8,64]=4.44135073957068e-001;
    __statist_i_h_wts[8,65]=5.60786145242956e-001;
    __statist_i_h_wts[8,66]=-4.40258318119405e-002;
    __statist_i_h_wts[8,67]=7.61667753000812e-002;
    __statist_i_h_wts[8,68]=-1.36702959765649e-001;
    __statist_i_h_wts[8,69]=-4.84892620830910e-002;
    __statist_i_h_wts[8,70]=-2.67242015135524e-001;
    __statist_i_h_wts[8,71]=-2.20471543575885e-001;
    __statist_i_h_wts[8,72]=-3.33720210124483e-001;
    __statist_i_h_wts[8,73]=-3.81686147014985e-001;
    __statist_i_h_wts[8,74]=-4.84528973302356e-001;
    __statist_i_h_wts[8,75]=1.43822589731201e-001;
    __statist_i_h_wts[8,76]=2.39092673240022e-002;
    __statist_i_h_wts[8,77]=1.35219382082832e-001;
    __statist_i_h_wts[8,78]=8.72928304203879e-002;
    __statist_i_h_wts[8,79]=1.34662866753810e-001;
    __statist_i_h_wts[8,80]=-1.11046586599265e-001;
    __statist_i_h_wts[8,81]=-1.09569247891309e-001;
    __statist_i_h_wts[8,82]=-2.34158081324690e-001;
    __statist_i_h_wts[8,83]=-1.32211725981819e-001;
    __statist_i_h_wts[8,84]=-1.83018101070076e-001;
    __statist_i_h_wts[8,85]=-2.28053273914005e-002;
    __statist_i_h_wts[8,86]=6.12459003933603e-002;
    __statist_i_h_wts[8,87]=2.98488876693007e-002;
    __statist_i_h_wts[8,88]=-2.09856547947947e-001;
    __statist_i_h_wts[8,89]=-2.31250152167915e-001;
    __statist_i_h_wts[8,90]=-4.84556684575843e-002;
    __statist_i_h_wts[8,91]=1.87913040919164e-001;
    __statist_i_h_wts[8,92]=-4.69144979893216e-002;
    __statist_i_h_wts[8,93]=2.01605804663764e-001;
    __statist_i_h_wts[8,94]=2.74015632027515e-001;
    __statist_i_h_wts[8,95]=3.19807596567202e-002;
    __statist_i_h_wts[8,96]=-3.56725529986344e-002;
    __statist_i_h_wts[8,97]=-2.51904121081157e-001;
    __statist_i_h_wts[8,98]=9.43996160568695e-002;
    __statist_i_h_wts[8,99]=-3.32394282432940e-001;
    __statist_i_h_wts[8,100]=4.61848395362873e-002;
    __statist_i_h_wts[8,101]=5.29669972802112e-002;
    __statist_i_h_wts[8,102]=5.12536387016598e-002;
    __statist_i_h_wts[8,103]=-4.30852023059781e-002;
    __statist_i_h_wts[8,104]=-1.73778739453610e-001;
    __statist_i_h_wts[8,105]=-8.65550018147640e-002;
    __statist_i_h_wts[8,106]=2.94369154759377e-003;
    __statist_i_h_wts[8,107]=-3.51454039426557e-002;
    __statist_i_h_wts[8,108]=2.79069467482418e-002;
    __statist_i_h_wts[8,109]=-3.24595046316010e-002;
    __statist_i_h_wts[8,110]=2.69231639179349e-002;
    __statist_i_h_wts[8,111]=-3.11094317968027e-001;
    __statist_i_h_wts[8,112]=-1.09816556851655e-001;
    __statist_i_h_wts[8,113]=7.32778719895639e-002;
    __statist_i_h_wts[8,114]=-1.08150642692382e-001;
    __statist_i_h_wts[8,115]=-1.80974025676452e-002;
    __statist_i_h_wts[8,116]=-3.28505947687190e-001;
    __statist_i_h_wts[8,117]=-7.33671756075414e-002;
    __statist_i_h_wts[8,118]=-8.40058779974527e-003;
    __statist_i_h_wts[8,119]=-5.57561240717062e-002;
    __statist_i_h_wts[8,120]=-2.95707746553966e-001;
    __statist_i_h_wts[8,121]=-1.78894651850586e-001;
    __statist_i_h_wts[8,122]=7.93869804678110e-004;
    __statist_i_h_wts[8,123]=1.08475752421453e-002;
    __statist_i_h_wts[8,124]=1.29612966779216e-001;
    __statist_i_h_wts[8,125]=3.82309692108289e-002;
    __statist_i_h_wts[8,126]=-1.35913639302751e-001;
    __statist_i_h_wts[8,127]=3.29787347200435e-001;
    __statist_i_h_wts[8,128]=2.08351038864557e-001;
    __statist_i_h_wts[8,129]=1.47992526371406e-001;
    __statist_i_h_wts[8,130]=2.01326170716647e-001;
    __statist_i_h_wts[8,131]=-1.69919879475772e-001;
    __statist_i_h_wts[8,132]=-1.39709763408463e-001;
    __statist_i_h_wts[8,133]=-4.31602714064062e-002;
    __statist_i_h_wts[8,134]=-7.93273870082424e-002;
    __statist_i_h_wts[8,135]=3.63152251831635e-002;
    __statist_i_h_wts[8,136]=1.03491906271193e-001;
    __statist_i_h_wts[8,137]=1.77776791816990e-001;
    __statist_i_h_wts[8,138]=1.46291566282141e-001;
    __statist_i_h_wts[8,139]=3.06417321352288e-001;
    __statist_i_h_wts[8,140]=3.69101439946329e-001;
    __statist_i_h_wts[8,141]=2.69104417619382e-001;
    __statist_i_h_wts[8,142]=1.71874192292441e-001;
    __statist_i_h_wts[8,143]=1.38404119376728e-001;
    __statist_i_h_wts[8,144]=-5.44524793897859e-002;
    __statist_i_h_wts[8,145]=1.25081609106997e-001;
    __statist_i_h_wts[8,146]=-2.16687722753800e-001;
    __statist_i_h_wts[8,147]=-1.08246871809726e-002;
    __statist_i_h_wts[8,148]=-2.40307216734053e-002;
    __statist_i_h_wts[8,149]=-1.63826066918796e-002;
    __statist_i_h_wts[8,150]=5.05361492041005e-002;
    __statist_i_h_wts[8,151]=3.87602435066995e-002;
    __statist_i_h_wts[8,152]=5.73491828098385e-002;
    __statist_i_h_wts[8,153]=4.49599916525437e-002;
    __statist_i_h_wts[8,154]=8.33110529292797e-002;
    __statist_i_h_wts[8,155]=2.00451897932661e-001;
    __statist_i_h_wts[8,156]=1.29213829577438e-001;
    __statist_i_h_wts[8,157]=9.85773238060094e-002;
    __statist_i_h_wts[8,158]=-1.66997620435336e-001;
    __statist_i_h_wts[8,159]=-2.12687182861564e-001;
    __statist_i_h_wts[8,160]=-1.38761622785044e-001;
    __statist_i_h_wts[8,161]=-1.63534215322956e-001;
    __statist_i_h_wts[8,162]=-1.23341387399307e-001;
    __statist_i_h_wts[8,163]=1.35086671411190e-001;
    __statist_i_h_wts[8,164]=1.41139910714818e-001;
    __statist_i_h_wts[8,165]=1.32461846522200e-001;
    __statist_i_h_wts[8,166]=2.45917823485199e-001;
    __statist_i_h_wts[8,167]=2.10270465881164e-001;
    __statist_i_h_wts[8,168]=-9.13108219713826e-002;
    __statist_i_h_wts[8,169]=1.01286843450757e-001;
    __statist_i_h_wts[8,170]=4.06268367610547e-002;
    __statist_i_h_wts[8,171]=1.07362895380915e-003;
    __statist_i_h_wts[8,172]=1.10941049189322e-001;
    __statist_i_h_wts[8,173]=8.84069122005153e-002;
    __statist_i_h_wts[8,174]=9.05943385419123e-002;
    __statist_i_h_wts[8,175]=6.00715193887855e-002;
    __statist_i_h_wts[8,176]=-1.69259764958095e-002;
    __statist_i_h_wts[8,177]=-9.12080655869540e-002;
    __statist_i_h_wts[8,178]=-6.09722414236666e-002;
    __statist_i_h_wts[8,179]=1.12244441285988e-001;
    __statist_i_h_wts[8,180]=1.14791631642277e-001;
    __statist_i_h_wts[8,181]=1.84100862264010e-001;
    __statist_i_h_wts[8,182]=1.82660786710180e-001;
    __statist_i_h_wts[8,183]=-8.80346345338043e-002;
    __statist_i_h_wts[8,184]=-7.61214671503783e-002;
    __statist_i_h_wts[8,185]=1.11312721129402e-001;
    __statist_i_h_wts[8,186]=1.06252520701725e-001;
    __statist_i_h_wts[8,187]=1.26279036102498e-001;
    __statist_i_h_wts[8,188]=-3.44207874118010e-002;
    __statist_i_h_wts[8,189]=3.27175187454301e-002;
    __statist_i_h_wts[8,190]=2.82424406476287e-004;
    __statist_i_h_wts[8,191]=-1.67885171486430e-002;
    __statist_i_h_wts[8,192]=-1.87055123478278e-001;
    __statist_i_h_wts[8,193]=-8.29805930357467e-002;
    __statist_i_h_wts[8,194]=-2.25295793724121e-002;
    __statist_i_h_wts[8,195]=9.63317643608254e-002;
    __statist_i_h_wts[8,196]=9.41139817075789e-002;
    __statist_i_h_wts[8,197]=1.82750998718634e-002;
    __statist_i_h_wts[8,198]=-8.48569841090766e-002;
    __statist_i_h_wts[8,199]=-1.21505300884505e-001;
    __statist_i_h_wts[8,200]=-1.49081912078606e-001;
    __statist_i_h_wts[8,201]=-1.76689369579592e-001;
    __statist_i_h_wts[8,202]=-8.30693802816802e-002;
    __statist_i_h_wts[8,203]=-1.27852935983131e-001;
    __statist_i_h_wts[8,204]=-1.19082469378358e-001;
    __statist_i_h_wts[8,205]=-1.15081054526649e-001;
    __statist_i_h_wts[8,206]=-1.48175206504721e-002;
    __statist_i_h_wts[8,207]=-2.57245082669955e-002;
    __statist_i_h_wts[8,208]=5.31009570466683e-002;
    __statist_i_h_wts[8,209]=5.76325574990845e-002;
    __statist_i_h_wts[8,210]=2.46268255536111e-001;
    __statist_i_h_wts[8,211]=2.22862055482652e-001;
    __statist_i_h_wts[8,212]=2.19693302725151e-001;
    __statist_i_h_wts[8,213]=1.41366724525688e-001;
    __statist_i_h_wts[8,214]=2.99351602482020e-002;
    __statist_i_h_wts[8,215]=-1.00697444993815e-001;
    __statist_i_h_wts[8,216]=-1.44266435708344e-001;
    __statist_i_h_wts[8,217]=-1.36962811128466e-001;
    __statist_i_h_wts[8,218]=-3.95467347403387e-001;
    __statist_i_h_wts[8,219]=-1.65737439086668e-001;
    __statist_i_h_wts[8,220]=-1.33626717504329e-001;
    __statist_i_h_wts[8,221]=-8.83022564430402e-002;
    __statist_i_h_wts[8,222]=-3.36595983132669e-002;
    __statist_i_h_wts[8,223]=1.03627453670831e-001;
    __statist_i_h_wts[8,224]=1.41848604238669e-002;
    __statist_i_h_wts[8,225]=-5.31011487516285e-002;
    __statist_i_h_wts[8,226]=1.80762360501942e-001;
    __statist_i_h_wts[8,227]=-8.47917180826857e-002;
    __statist_i_h_wts[8,228]=-1.43252083108991e-001;
    __statist_i_h_wts[8,229]=-1.03540248071098e-001;
    __statist_i_h_wts[8,230]=-2.93359736346885e-001;
    __statist_i_h_wts[8,231]=-3.59437846611809e-001;
    __statist_i_h_wts[8,232]=-2.24662506774243e-001;
    __statist_i_h_wts[8,233]=1.39155004921618e-001;
    __statist_i_h_wts[8,234]=-2.93030726944370e-001;
    __statist_i_h_wts[8,235]=-3.06654793367355e-001;
    __statist_i_h_wts[8,236]=-5.96217335554380e-001;
    __statist_i_h_wts[8,237]=9.57249868214229e-001;
    __statist_i_h_wts[8,238]=2.92212653667688e-001;
    __statist_i_h_wts[8,239]=-6.71799853050910e-001;
    __statist_i_h_wts[8,240]=1.18555302560876e-001;
    __statist_i_h_wts[8,241]=5.63589278341078e-002;
    __statist_i_h_wts[8,242]=5.16124220207015e-001;
    __statist_i_h_wts[8,243]=-4.82304233934443e-001;
    __statist_i_h_wts[8,244]=1.35864702745335e-001;
    __statist_i_h_wts[8,245]=8.55947919040286e-002;
    __statist_i_h_wts[8,246]=-2.90791121091595e-001;
    __statist_i_h_wts[8,247]=5.93266342042033e-001;
    __statist_i_h_wts[8,248]=1.42077640040506e-001;

    __statist_i_h_wts[9,0]=-3.44411495798921e-001;
    __statist_i_h_wts[9,1]=-3.03958418552123e-001;
    __statist_i_h_wts[9,2]=-2.79432325112516e-001;
    __statist_i_h_wts[9,3]=-2.15962694707063e-001;
    __statist_i_h_wts[9,4]=-1.92580166072460e-001;
    __statist_i_h_wts[9,5]=-1.90156627131374e-001;
    __statist_i_h_wts[9,6]=3.80525781063382e-002;
    __statist_i_h_wts[9,7]=2.93866195977070e-002;
    __statist_i_h_wts[9,8]=9.01522648313771e-002;
    __statist_i_h_wts[9,9]=8.19656181365562e-002;
    __statist_i_h_wts[9,10]=2.13826235674456e-001;
    __statist_i_h_wts[9,11]=1.48296678041484e-001;
    __statist_i_h_wts[9,12]=2.79276314339337e-001;
    __statist_i_h_wts[9,13]=2.90015716392586e-001;
    __statist_i_h_wts[9,14]=3.17255801718130e-001;
    __statist_i_h_wts[9,15]=-3.58912333128569e-001;
    __statist_i_h_wts[9,16]=-2.63130473963269e-001;
    __statist_i_h_wts[9,17]=-1.81695802177104e-001;
    __statist_i_h_wts[9,18]=-2.37063560202191e-001;
    __statist_i_h_wts[9,19]=-1.74215631852170e-001;
    __statist_i_h_wts[9,20]=-1.46757705565598e-001;
    __statist_i_h_wts[9,21]=3.14080887845674e-002;
    __statist_i_h_wts[9,22]=2.65164533141838e-002;
    __statist_i_h_wts[9,23]=9.12857549742845e-002;
    __statist_i_h_wts[9,24]=1.47012114016159e-001;
    __statist_i_h_wts[9,25]=1.60836169373999e-001;
    __statist_i_h_wts[9,26]=5.07119032236415e-002;
    __statist_i_h_wts[9,27]=2.08660114056820e-001;
    __statist_i_h_wts[9,28]=2.82009330889609e-001;
    __statist_i_h_wts[9,29]=2.92806812293356e-001;
    __statist_i_h_wts[9,30]=-5.31446110650262e-001;
    __statist_i_h_wts[9,31]=-4.40994639427523e-001;
    __statist_i_h_wts[9,32]=-2.42578914935853e-001;
    __statist_i_h_wts[9,33]=-3.12742406845466e-001;
    __statist_i_h_wts[9,34]=-2.54797836216219e-001;
    __statist_i_h_wts[9,35]=-2.23543061895743e-001;
    __statist_i_h_wts[9,36]=-5.49696580106195e-002;
    __statist_i_h_wts[9,37]=2.44169545895909e-002;
    __statist_i_h_wts[9,38]=1.30228443967428e-001;
    __statist_i_h_wts[9,39]=1.55160032049689e-001;
    __statist_i_h_wts[9,40]=1.82195788572912e-001;
    __statist_i_h_wts[9,41]=6.42317164576550e-002;
    __statist_i_h_wts[9,42]=2.15396587928436e-001;
    __statist_i_h_wts[9,43]=3.46677590688557e-001;
    __statist_i_h_wts[9,44]=4.24938494389743e-001;
    __statist_i_h_wts[9,45]=-4.86864208543807e-001;
    __statist_i_h_wts[9,46]=-5.62670314181576e-001;
    __statist_i_h_wts[9,47]=-3.45733898683753e-001;
    __statist_i_h_wts[9,48]=-4.11795287196002e-001;
    __statist_i_h_wts[9,49]=-4.07606391703643e-001;
    __statist_i_h_wts[9,50]=-3.00504643465851e-001;
    __statist_i_h_wts[9,51]=-2.80872235524535e-002;
    __statist_i_h_wts[9,52]=4.46657790279245e-002;
    __statist_i_h_wts[9,53]=7.13604344966073e-002;
    __statist_i_h_wts[9,54]=5.35445295335035e-002;
    __statist_i_h_wts[9,55]=2.83261249905737e-002;
    __statist_i_h_wts[9,56]=9.83743963178439e-002;
    __statist_i_h_wts[9,57]=2.82389442303129e-001;
    __statist_i_h_wts[9,58]=3.73332484376336e-001;
    __statist_i_h_wts[9,59]=3.28285923706588e-001;
    __statist_i_h_wts[9,60]=-4.95505029698256e-001;
    __statist_i_h_wts[9,61]=-5.14963205407975e-001;
    __statist_i_h_wts[9,62]=-3.83957112464482e-001;
    __statist_i_h_wts[9,63]=-3.56561587714348e-001;
    __statist_i_h_wts[9,64]=-4.54182247045998e-001;
    __statist_i_h_wts[9,65]=-4.00394265610031e-001;
    __statist_i_h_wts[9,66]=-9.33719916615578e-002;
    __statist_i_h_wts[9,67]=4.12874461177681e-002;
    __statist_i_h_wts[9,68]=1.70496879466598e-001;
    __statist_i_h_wts[9,69]=1.21395372519062e-001;
    __statist_i_h_wts[9,70]=5.21508681789116e-002;
    __statist_i_h_wts[9,71]=6.73481194839084e-002;
    __statist_i_h_wts[9,72]=2.83696629108028e-001;
    __statist_i_h_wts[9,73]=3.49862083665563e-001;
    __statist_i_h_wts[9,74]=3.82130130891018e-001;
    __statist_i_h_wts[9,75]=-4.95060110818690e-001;
    __statist_i_h_wts[9,76]=-4.47912548331810e-001;
    __statist_i_h_wts[9,77]=-4.29630644913083e-001;
    __statist_i_h_wts[9,78]=-3.13548266307966e-001;
    __statist_i_h_wts[9,79]=-3.38356844908085e-001;
    __statist_i_h_wts[9,80]=-1.92736775728363e-001;
    __statist_i_h_wts[9,81]=-1.67363427008183e-001;
    __statist_i_h_wts[9,82]=-3.43896827099835e-002;
    __statist_i_h_wts[9,83]=1.73908594857420e-002;
    __statist_i_h_wts[9,84]=2.23726806724931e-001;
    __statist_i_h_wts[9,85]=1.44078612741648e-001;
    __statist_i_h_wts[9,86]=1.34898263951781e-001;
    __statist_i_h_wts[9,87]=2.27882579357518e-001;
    __statist_i_h_wts[9,88]=2.80003467281813e-001;
    __statist_i_h_wts[9,89]=3.02058207064647e-001;
    __statist_i_h_wts[9,90]=-5.84561026288039e-001;
    __statist_i_h_wts[9,91]=-5.68541028799289e-001;
    __statist_i_h_wts[9,92]=-4.23077277577084e-001;
    __statist_i_h_wts[9,93]=-4.89743424814931e-001;
    __statist_i_h_wts[9,94]=-4.76815886670657e-001;
    __statist_i_h_wts[9,95]=-2.80817519713168e-001;
    __statist_i_h_wts[9,96]=-2.99287022697837e-001;
    __statist_i_h_wts[9,97]=-1.36223691458594e-001;
    __statist_i_h_wts[9,98]=2.19723642056506e-002;
    __statist_i_h_wts[9,99]=2.38647261345968e-001;
    __statist_i_h_wts[9,100]=1.13790644798181e-001;
    __statist_i_h_wts[9,101]=1.38241139235546e-001;
    __statist_i_h_wts[9,102]=2.79537909126331e-001;
    __statist_i_h_wts[9,103]=2.12563640558957e-001;
    __statist_i_h_wts[9,104]=2.71984553679464e-001;
    __statist_i_h_wts[9,105]=-3.59338944135981e-001;
    __statist_i_h_wts[9,106]=-2.58473025745553e-001;
    __statist_i_h_wts[9,107]=-2.69106250479388e-001;
    __statist_i_h_wts[9,108]=-4.18108904772351e-001;
    __statist_i_h_wts[9,109]=-3.50106095880239e-001;
    __statist_i_h_wts[9,110]=-2.69544429775180e-001;
    __statist_i_h_wts[9,111]=-2.15618856286786e-001;
    __statist_i_h_wts[9,112]=-2.55748415351317e-001;
    __statist_i_h_wts[9,113]=5.20022802909632e-002;
    __statist_i_h_wts[9,114]=1.48462835664486e-001;
    __statist_i_h_wts[9,115]=1.08284705251874e-001;
    __statist_i_h_wts[9,116]=1.60205773467421e-001;
    __statist_i_h_wts[9,117]=2.52727214155289e-001;
    __statist_i_h_wts[9,118]=1.94761259415090e-001;
    __statist_i_h_wts[9,119]=1.83962803808395e-001;
    __statist_i_h_wts[9,120]=-2.73681533280051e-001;
    __statist_i_h_wts[9,121]=-2.47966823643407e-001;
    __statist_i_h_wts[9,122]=-4.48017253112499e-001;
    __statist_i_h_wts[9,123]=-3.06488158191750e-001;
    __statist_i_h_wts[9,124]=-1.86665284553146e-001;
    __statist_i_h_wts[9,125]=-9.64629345007580e-002;
    __statist_i_h_wts[9,126]=-1.44029678174555e-001;
    __statist_i_h_wts[9,127]=-2.48993216100406e-001;
    __statist_i_h_wts[9,128]=1.31729005855985e-001;
    __statist_i_h_wts[9,129]=9.51958200609703e-002;
    __statist_i_h_wts[9,130]=3.96707969042460e-002;
    __statist_i_h_wts[9,131]=1.45992818872656e-001;
    __statist_i_h_wts[9,132]=3.17836103945366e-001;
    __statist_i_h_wts[9,133]=2.63955753447935e-001;
    __statist_i_h_wts[9,134]=2.39271579128119e-001;
    __statist_i_h_wts[9,135]=-2.75943317343211e-001;
    __statist_i_h_wts[9,136]=-3.60946610030304e-001;
    __statist_i_h_wts[9,137]=-4.06083161625968e-001;
    __statist_i_h_wts[9,138]=-3.11890586199198e-001;
    __statist_i_h_wts[9,139]=-2.21576148280265e-001;
    __statist_i_h_wts[9,140]=-2.11277062002442e-001;
    __statist_i_h_wts[9,141]=-1.47406400182205e-001;
    __statist_i_h_wts[9,142]=-1.15758308196423e-001;
    __statist_i_h_wts[9,143]=1.32991865608805e-001;
    __statist_i_h_wts[9,144]=2.18725908689580e-001;
    __statist_i_h_wts[9,145]=1.18767183007235e-001;
    __statist_i_h_wts[9,146]=2.08127440529192e-001;
    __statist_i_h_wts[9,147]=2.12788158295628e-001;
    __statist_i_h_wts[9,148]=2.02339141688334e-001;
    __statist_i_h_wts[9,149]=1.37409345686357e-001;
    __statist_i_h_wts[9,150]=-2.95046196243035e-001;
    __statist_i_h_wts[9,151]=-3.73219235137564e-001;
    __statist_i_h_wts[9,152]=-3.64142587197832e-001;
    __statist_i_h_wts[9,153]=-3.19082990123789e-001;
    __statist_i_h_wts[9,154]=-2.46308225757874e-001;
    __statist_i_h_wts[9,155]=-2.56915576829334e-001;
    __statist_i_h_wts[9,156]=-1.83618552913302e-001;
    __statist_i_h_wts[9,157]=-1.19416788449228e-001;
    __statist_i_h_wts[9,158]=7.09761567013492e-002;
    __statist_i_h_wts[9,159]=1.04151531465277e-001;
    __statist_i_h_wts[9,160]=1.34248779013790e-001;
    __statist_i_h_wts[9,161]=1.85796825094276e-001;
    __statist_i_h_wts[9,162]=2.42900028585667e-001;
    __statist_i_h_wts[9,163]=8.08417574801861e-002;
    __statist_i_h_wts[9,164]=2.30553228195265e-002;
    __statist_i_h_wts[9,165]=-1.26759821295967e-001;
    __statist_i_h_wts[9,166]=-2.37157357863119e-001;
    __statist_i_h_wts[9,167]=-2.40093446178732e-001;
    __statist_i_h_wts[9,168]=-1.44719768034109e-001;
    __statist_i_h_wts[9,169]=-1.81897835287937e-001;
    __statist_i_h_wts[9,170]=-1.26054663279765e-001;
    __statist_i_h_wts[9,171]=-1.31589059747957e-001;
    __statist_i_h_wts[9,172]=-1.18890463554917e-001;
    __statist_i_h_wts[9,173]=-3.74377131442380e-002;
    __statist_i_h_wts[9,174]=1.30760407544862e-002;
    __statist_i_h_wts[9,175]=1.31736914663969e-001;
    __statist_i_h_wts[9,176]=1.56277717636076e-001;
    __statist_i_h_wts[9,177]=1.47362022472752e-001;
    __statist_i_h_wts[9,178]=1.63871671248861e-001;
    __statist_i_h_wts[9,179]=7.03757465701310e-002;
    __statist_i_h_wts[9,180]=-6.13142567163373e-002;
    __statist_i_h_wts[9,181]=-1.94035499202688e-001;
    __statist_i_h_wts[9,182]=-1.58164263277216e-001;
    __statist_i_h_wts[9,183]=-5.75707669650164e-002;
    __statist_i_h_wts[9,184]=5.44660738978688e-004;
    __statist_i_h_wts[9,185]=-6.02478566178240e-002;
    __statist_i_h_wts[9,186]=-1.89936152911324e-003;
    __statist_i_h_wts[9,187]=1.01478391378886e-001;
    __statist_i_h_wts[9,188]=1.51506514114020e-001;
    __statist_i_h_wts[9,189]=1.15706452034253e-001;
    __statist_i_h_wts[9,190]=2.13003533437231e-001;
    __statist_i_h_wts[9,191]=1.73163944441174e-001;
    __statist_i_h_wts[9,192]=2.21067498657530e-001;
    __statist_i_h_wts[9,193]=1.97103873689004e-001;
    __statist_i_h_wts[9,194]=1.41384933914985e-001;
    __statist_i_h_wts[9,195]=8.78472657238215e-003;
    __statist_i_h_wts[9,196]=-1.44817744487828e-001;
    __statist_i_h_wts[9,197]=-1.00658581994576e-001;
    __statist_i_h_wts[9,198]=-4.96447329292424e-002;
    __statist_i_h_wts[9,199]=-4.07718031984230e-002;
    __statist_i_h_wts[9,200]=-2.66149697092576e-002;
    __statist_i_h_wts[9,201]=5.50307331601350e-002;
    __statist_i_h_wts[9,202]=1.15500460651848e-001;
    __statist_i_h_wts[9,203]=9.43610147226891e-002;
    __statist_i_h_wts[9,204]=1.35133736207104e-001;
    __statist_i_h_wts[9,205]=1.77000178063323e-001;
    __statist_i_h_wts[9,206]=1.15990540885467e-001;
    __statist_i_h_wts[9,207]=1.35042264553088e-001;
    __statist_i_h_wts[9,208]=1.13220684223621e-001;
    __statist_i_h_wts[9,209]=8.19410935271751e-002;
    __statist_i_h_wts[9,210]=6.37286718037207e-003;
    __statist_i_h_wts[9,211]=-8.54072497931950e-002;
    __statist_i_h_wts[9,212]=-7.50966424118961e-002;
    __statist_i_h_wts[9,213]=3.74364237329236e-002;
    __statist_i_h_wts[9,214]=5.57481356121724e-002;
    __statist_i_h_wts[9,215]=1.23388795370826e-001;
    __statist_i_h_wts[9,216]=9.97223651590466e-002;
    __statist_i_h_wts[9,217]=5.68886920278878e-002;
    __statist_i_h_wts[9,218]=1.66958886654164e-001;
    __statist_i_h_wts[9,219]=1.89640661085538e-001;
    __statist_i_h_wts[9,220]=1.75917475122233e-001;
    __statist_i_h_wts[9,221]=1.22747163926047e-001;
    __statist_i_h_wts[9,222]=1.20487522499356e-001;
    __statist_i_h_wts[9,223]=1.08026046519867e-001;
    __statist_i_h_wts[9,224]=1.23154593720797e-001;
    __statist_i_h_wts[9,225]=-1.58587803606821e-001;
    __statist_i_h_wts[9,226]=-1.23968287869363e-001;
    __statist_i_h_wts[9,227]=-1.29856426589286e-001;
    __statist_i_h_wts[9,228]=-1.85777070300214e-001;
    __statist_i_h_wts[9,229]=6.44532936174710e-002;
    __statist_i_h_wts[9,230]=3.60394952502653e-001;
    __statist_i_h_wts[9,231]=2.91533666728950e-001;
    __statist_i_h_wts[9,232]=5.68309989400963e-001;
    __statist_i_h_wts[9,233]=1.42322346109264e-001;
    __statist_i_h_wts[9,234]=3.82288540657067e-001;
    __statist_i_h_wts[9,235]=-1.49578451198943e-001;
    __statist_i_h_wts[9,236]=-4.04457738505842e-001;
    __statist_i_h_wts[9,237]=-5.31099794558149e-001;
    __statist_i_h_wts[9,238]=-8.15409469900797e-002;
    __statist_i_h_wts[9,239]=3.00135070939267e-001;
    __statist_i_h_wts[9,240]=-4.79181239968080e-002;
    __statist_i_h_wts[9,241]=4.74460802505257e-001;
    __statist_i_h_wts[9,242]=-4.37298658717135e-002;
    __statist_i_h_wts[9,243]=5.79312422225689e-001;
    __statist_i_h_wts[9,244]=-2.05003289831211e-001;
    __statist_i_h_wts[9,245]=-4.34355152658294e-001;
    __statist_i_h_wts[9,246]=-1.35302496525209e-002;
    __statist_i_h_wts[9,247]=-5.36869089499983e-001;
    __statist_i_h_wts[9,248]=-7.99092355316943e-002;

    __statist_i_h_wts[10,0]=-6.41511795227241e-001;
    __statist_i_h_wts[10,1]=-1.83388080676670e-001;
    __statist_i_h_wts[10,2]=2.67276501430620e-002;
    __statist_i_h_wts[10,3]=-3.43894949881993e-001;
    __statist_i_h_wts[10,4]=-1.64678747046019e-001;
    __statist_i_h_wts[10,5]=3.97508553716579e-001;
    __statist_i_h_wts[10,6]=-2.18490200793240e-002;
    __statist_i_h_wts[10,7]=-1.56717639206509e-001;
    __statist_i_h_wts[10,8]=3.77324390987067e-001;
    __statist_i_h_wts[10,9]=-4.89741753018037e-002;
    __statist_i_h_wts[10,10]=5.54372353511626e-001;
    __statist_i_h_wts[10,11]=-1.18647203197434e-001;
    __statist_i_h_wts[10,12]=-2.57166735168847e-001;
    __statist_i_h_wts[10,13]=-1.32445873479023e-001;
    __statist_i_h_wts[10,14]=3.92833085907279e-001;
    __statist_i_h_wts[10,15]=-6.62397488633669e-001;
    __statist_i_h_wts[10,16]=-8.88851948984057e-001;
    __statist_i_h_wts[10,17]=8.01960747850262e-002;
    __statist_i_h_wts[10,18]=3.96749868512528e-001;
    __statist_i_h_wts[10,19]=5.34786668523979e-001;
    __statist_i_h_wts[10,20]=-1.36913077077573e-001;
    __statist_i_h_wts[10,21]=-7.32913893999503e-002;
    __statist_i_h_wts[10,22]=1.69614149880017e-001;
    __statist_i_h_wts[10,23]=-6.24932734138313e-001;
    __statist_i_h_wts[10,24]=-6.00396021920309e-001;
    __statist_i_h_wts[10,25]=-5.15004548146654e-002;
    __statist_i_h_wts[10,26]=6.11907576879729e-001;
    __statist_i_h_wts[10,27]=-4.53455022605779e-001;
    __statist_i_h_wts[10,28]=-4.81189946524473e-001;
    __statist_i_h_wts[10,29]=3.06273995853754e-001;
    __statist_i_h_wts[10,30]=2.09104047750390e-001;
    __statist_i_h_wts[10,31]=9.20764891982436e-002;
    __statist_i_h_wts[10,32]=-7.47644093939108e-002;
    __statist_i_h_wts[10,33]=1.40602897273316e-001;
    __statist_i_h_wts[10,34]=1.58513211586946e-001;
    __statist_i_h_wts[10,35]=-2.34870466583006e-001;
    __statist_i_h_wts[10,36]=1.44567086079108e-001;
    __statist_i_h_wts[10,37]=3.99813552679023e-001;
    __statist_i_h_wts[10,38]=1.62044886692279e-001;
    __statist_i_h_wts[10,39]=-1.62804656451190e-002;
    __statist_i_h_wts[10,40]=-3.03003361875074e-001;
    __statist_i_h_wts[10,41]=-6.16693965959574e-001;
    __statist_i_h_wts[10,42]=8.80306210645540e-001;
    __statist_i_h_wts[10,43]=-6.90463408388488e-001;
    __statist_i_h_wts[10,44]=-7.13824318750940e-001;
    __statist_i_h_wts[10,45]=-3.47341004452618e-001;
    __statist_i_h_wts[10,46]=4.40785105731548e-001;
    __statist_i_h_wts[10,47]=-4.11572645501511e-001;
    __statist_i_h_wts[10,48]=3.81072312008080e-001;
    __statist_i_h_wts[10,49]=-5.79803869155020e-001;
    __statist_i_h_wts[10,50]=1.09775277308336e-001;
    __statist_i_h_wts[10,51]=-4.55644844162764e-001;
    __statist_i_h_wts[10,52]=-6.24913150774471e-001;
    __statist_i_h_wts[10,53]=-2.30289615109346e-001;
    __statist_i_h_wts[10,54]=1.96379271994221e-001;
    __statist_i_h_wts[10,55]=9.79936887035198e-002;
    __statist_i_h_wts[10,56]=-1.92531158397042e-001;
    __statist_i_h_wts[10,57]=4.85126119926898e-001;
    __statist_i_h_wts[10,58]=-3.35446357937786e-001;
    __statist_i_h_wts[10,59]=2.36932551393927e-002;
    __statist_i_h_wts[10,60]=-4.04454198954630e-001;
    __statist_i_h_wts[10,61]=-1.40677023653971e-001;
    __statist_i_h_wts[10,62]=-4.03266480897816e-001;
    __statist_i_h_wts[10,63]=3.80625372807332e-001;
    __statist_i_h_wts[10,64]=-3.02850677424089e-001;
    __statist_i_h_wts[10,65]=6.96166217626108e-001;
    __statist_i_h_wts[10,66]=7.55874890750698e-003;
    __statist_i_h_wts[10,67]=5.32778745881502e-001;
    __statist_i_h_wts[10,68]=-1.25832289710064e-001;
    __statist_i_h_wts[10,69]=5.35670612588693e-001;
    __statist_i_h_wts[10,70]=3.39840955234886e-002;
    __statist_i_h_wts[10,71]=1.43472055121073e-001;
    __statist_i_h_wts[10,72]=1.82061392044211e-002;
    __statist_i_h_wts[10,73]=3.96043943744981e-001;
    __statist_i_h_wts[10,74]=4.77351183960384e-001;
    __statist_i_h_wts[10,75]=2.80961189329008e-001;
    __statist_i_h_wts[10,76]=-2.65302426594948e-001;
    __statist_i_h_wts[10,77]=6.96954910826726e-001;
    __statist_i_h_wts[10,78]=-1.46682446284432e-001;
    __statist_i_h_wts[10,79]=-1.31478848262880e-001;
    __statist_i_h_wts[10,80]=-3.00973740550376e-001;
    __statist_i_h_wts[10,81]=-7.52170748963252e-001;
    __statist_i_h_wts[10,82]=3.03659605771100e-001;
    __statist_i_h_wts[10,83]=-1.98341130551499e-003;
    __statist_i_h_wts[10,84]=-1.14426176436759e-001;
    __statist_i_h_wts[10,85]=-3.08964726577995e-002;
    __statist_i_h_wts[10,86]=-3.46303567424846e-001;
    __statist_i_h_wts[10,87]=-1.92351751137766e-001;
    __statist_i_h_wts[10,88]=2.62502154002791e-002;
    __statist_i_h_wts[10,89]=1.27797955191731e+000;
    __statist_i_h_wts[10,90]=-4.38817913806495e-001;
    __statist_i_h_wts[10,91]=2.03201097493688e-001;
    __statist_i_h_wts[10,92]=-1.87837214129604e-001;
    __statist_i_h_wts[10,93]=-1.48299613464801e-001;
    __statist_i_h_wts[10,94]=2.89992527241883e-001;
    __statist_i_h_wts[10,95]=-3.98597699295399e-001;
    __statist_i_h_wts[10,96]=6.32513809408036e-001;
    __statist_i_h_wts[10,97]=-4.25012309814486e-002;
    __statist_i_h_wts[10,98]=2.88808528469320e-001;
    __statist_i_h_wts[10,99]=-1.42310363681033e-001;
    __statist_i_h_wts[10,100]=3.46598120283152e-001;
    __statist_i_h_wts[10,101]=-9.51845397149698e-002;
    __statist_i_h_wts[10,102]=-4.31095730538317e-001;
    __statist_i_h_wts[10,103]=1.05707958519658e-001;
    __statist_i_h_wts[10,104]=1.14208880899709e-002;
    __statist_i_h_wts[10,105]=6.79064929433718e-002;
    __statist_i_h_wts[10,106]=3.00671466978968e-001;
    __statist_i_h_wts[10,107]=-1.73269872545848e-001;
    __statist_i_h_wts[10,108]=1.77830787153999e-001;
    __statist_i_h_wts[10,109]=4.75415265474589e-001;
    __statist_i_h_wts[10,110]=4.73477485056349e-002;
    __statist_i_h_wts[10,111]=-1.52140678458623e-002;
    __statist_i_h_wts[10,112]=-5.29615195528331e-001;
    __statist_i_h_wts[10,113]=1.36956882545762e-001;
    __statist_i_h_wts[10,114]=-3.98375894389483e-003;
    __statist_i_h_wts[10,115]=7.93141421452380e-002;
    __statist_i_h_wts[10,116]=-3.18732312149952e-001;
    __statist_i_h_wts[10,117]=2.50761716998277e-001;
    __statist_i_h_wts[10,118]=2.94495872375453e-001;
    __statist_i_h_wts[10,119]=-1.73452024069102e-001;
    __statist_i_h_wts[10,120]=3.84109184115740e-001;
    __statist_i_h_wts[10,121]=-3.75421746412540e-001;
    __statist_i_h_wts[10,122]=-6.75586338343924e-002;
    __statist_i_h_wts[10,123]=2.35075290333873e-001;
    __statist_i_h_wts[10,124]=-1.69240678309820e-001;
    __statist_i_h_wts[10,125]=-6.46594663933525e-002;
    __statist_i_h_wts[10,126]=-1.90809000449600e-001;
    __statist_i_h_wts[10,127]=-5.91183200943664e-001;
    __statist_i_h_wts[10,128]=-3.61588863571712e-001;
    __statist_i_h_wts[10,129]=6.31397156124827e-001;
    __statist_i_h_wts[10,130]=1.75097993683301e-001;
    __statist_i_h_wts[10,131]=-9.41931761716469e-001;
    __statist_i_h_wts[10,132]=-5.74674126895872e-002;
    __statist_i_h_wts[10,133]=1.81494880615910e-001;
    __statist_i_h_wts[10,134]=1.20112532272634e-001;
    __statist_i_h_wts[10,135]=-4.94536859130361e-002;
    __statist_i_h_wts[10,136]=1.21036924201198e-001;
    __statist_i_h_wts[10,137]=-2.90578637450146e-002;
    __statist_i_h_wts[10,138]=1.89190726896503e-001;
    __statist_i_h_wts[10,139]=-1.87322390061269e-001;
    __statist_i_h_wts[10,140]=3.27149984624984e-001;
    __statist_i_h_wts[10,141]=2.17737946583804e-001;
    __statist_i_h_wts[10,142]=2.82102822675296e-001;
    __statist_i_h_wts[10,143]=5.72025469120599e-001;
    __statist_i_h_wts[10,144]=-1.99309800448627e-001;
    __statist_i_h_wts[10,145]=-5.51889755689091e-002;
    __statist_i_h_wts[10,146]=3.98838606628562e-001;
    __statist_i_h_wts[10,147]=3.95430706169820e-001;
    __statist_i_h_wts[10,148]=-5.65515304062657e-001;
    __statist_i_h_wts[10,149]=6.92942586468699e-002;
    __statist_i_h_wts[10,150]=1.90305647699061e-001;
    __statist_i_h_wts[10,151]=1.13803589944611e-002;
    __statist_i_h_wts[10,152]=-4.88572328728722e-002;
    __statist_i_h_wts[10,153]=-2.95947233646787e-001;
    __statist_i_h_wts[10,154]=2.39658803729655e-002;
    __statist_i_h_wts[10,155]=1.32262365356307e-001;
    __statist_i_h_wts[10,156]=-4.75342400333509e-002;
    __statist_i_h_wts[10,157]=-6.98694691616266e-002;
    __statist_i_h_wts[10,158]=-1.19867479401556e-001;
    __statist_i_h_wts[10,159]=-7.20006565055944e-001;
    __statist_i_h_wts[10,160]=-2.97345056129015e-001;
    __statist_i_h_wts[10,161]=7.07295830665048e-001;
    __statist_i_h_wts[10,162]=6.27909282814381e-001;
    __statist_i_h_wts[10,163]=-2.32933778519269e-001;
    __statist_i_h_wts[10,164]=-2.19310087154942e-001;
    __statist_i_h_wts[10,165]=-2.53225769190560e-001;
    __statist_i_h_wts[10,166]=7.76729205161606e-002;
    __statist_i_h_wts[10,167]=1.32179943226550e-001;
    __statist_i_h_wts[10,168]=-6.28997198130649e-001;
    __statist_i_h_wts[10,169]=-1.56481091024142e-001;
    __statist_i_h_wts[10,170]=2.57960040924291e-003;
    __statist_i_h_wts[10,171]=2.73309095434230e-001;
    __statist_i_h_wts[10,172]=-3.55911764085797e-001;
    __statist_i_h_wts[10,173]=-1.00380960625314e-001;
    __statist_i_h_wts[10,174]=4.06294258682430e-001;
    __statist_i_h_wts[10,175]=1.14799081128301e-002;
    __statist_i_h_wts[10,176]=5.32926255646445e-002;
    __statist_i_h_wts[10,177]=1.18187628187762e-001;
    __statist_i_h_wts[10,178]=-5.04270232012501e-001;
    __statist_i_h_wts[10,179]=2.44723858060381e-001;
    __statist_i_h_wts[10,180]=-6.15351451103010e-001;
    __statist_i_h_wts[10,181]=1.48007856381077e-001;
    __statist_i_h_wts[10,182]=-2.14991354783317e-002;
    __statist_i_h_wts[10,183]=-2.07485720238291e-001;
    __statist_i_h_wts[10,184]=1.56873858657394e-001;
    __statist_i_h_wts[10,185]=3.86773479722931e-002;
    __statist_i_h_wts[10,186]=2.19831857039652e-001;
    __statist_i_h_wts[10,187]=-1.94471321314104e-002;
    __statist_i_h_wts[10,188]=-2.35650128664441e-001;
    __statist_i_h_wts[10,189]=-1.29602061117363e-001;
    __statist_i_h_wts[10,190]=3.61810960427651e-001;
    __statist_i_h_wts[10,191]=-5.76746655140893e-001;
    __statist_i_h_wts[10,192]=-4.33568733472205e-001;
    __statist_i_h_wts[10,193]=6.44513797255484e-002;
    __statist_i_h_wts[10,194]=4.59195827508392e-002;
    __statist_i_h_wts[10,195]=4.84577577430832e-001;
    __statist_i_h_wts[10,196]=4.18369435907477e-001;
    __statist_i_h_wts[10,197]=-1.83597989663941e-001;
    __statist_i_h_wts[10,198]=-1.56690818959543e-001;
    __statist_i_h_wts[10,199]=-2.31295781749919e-001;
    __statist_i_h_wts[10,200]=-5.39435069461310e-001;
    __statist_i_h_wts[10,201]=5.70139327497427e-001;
    __statist_i_h_wts[10,202]=-1.66410471315778e-001;
    __statist_i_h_wts[10,203]=1.97608906900320e-001;
    __statist_i_h_wts[10,204]=-7.79381944613034e-002;
    __statist_i_h_wts[10,205]=8.79629341262455e-002;
    __statist_i_h_wts[10,206]=-2.75945080472534e-001;
    __statist_i_h_wts[10,207]=4.36364042877727e-002;
    __statist_i_h_wts[10,208]=2.20405616372945e-001;
    __statist_i_h_wts[10,209]=3.34984933094001e-001;
    __statist_i_h_wts[10,210]=1.55605645797127e-001;
    __statist_i_h_wts[10,211]=-3.46939909044516e-001;
    __statist_i_h_wts[10,212]=-2.87286288061732e-001;
    __statist_i_h_wts[10,213]=5.49895256694092e-001;
    __statist_i_h_wts[10,214]=6.83669353342572e-002;
    __statist_i_h_wts[10,215]=-1.12810425019834e-001;
    __statist_i_h_wts[10,216]=9.31131386219300e-002;
    __statist_i_h_wts[10,217]=-5.87348521545110e-001;
    __statist_i_h_wts[10,218]=-7.32440986922235e-002;
    __statist_i_h_wts[10,219]=5.89803294314043e-001;
    __statist_i_h_wts[10,220]=3.99806548624830e-002;
    __statist_i_h_wts[10,221]=-3.33999494061506e-001;
    __statist_i_h_wts[10,222]=1.87793682153403e-001;
    __statist_i_h_wts[10,223]=1.27954036577078e+000;
    __statist_i_h_wts[10,224]=3.28951929338247e-001;
    __statist_i_h_wts[10,225]=3.64485576682716e-001;
    __statist_i_h_wts[10,226]=7.40235686272943e-001;
    __statist_i_h_wts[10,227]=-8.32087057648175e-002;
    __statist_i_h_wts[10,228]=1.27527593152678e-001;
    __statist_i_h_wts[10,229]=-3.59044475543761e-001;
    __statist_i_h_wts[10,230]=-9.58771714218437e-001;
    __statist_i_h_wts[10,231]=-2.03238949416727e+000;
    __statist_i_h_wts[10,232]=1.45975294457530e+000;
    __statist_i_h_wts[10,233]=8.15433228105392e-001;
    __statist_i_h_wts[10,234]=1.69828568075282e+000;
    __statist_i_h_wts[10,235]=-1.19294623706858e+000;
    __statist_i_h_wts[10,236]=-4.33332347719573e+000;
    __statist_i_h_wts[10,237]=3.30795971166406e+000;
    __statist_i_h_wts[10,238]=3.51053555882108e-001;
    __statist_i_h_wts[10,239]=-1.79587210590327e-001;
    __statist_i_h_wts[10,240]=-2.82560167209400e-001;
    __statist_i_h_wts[10,241]=1.01789336767991e+000;
    __statist_i_h_wts[10,242]=6.82922415686298e-001;
    __statist_i_h_wts[10,243]=2.14135426574545e-001;
    __statist_i_h_wts[10,244]=-3.73231466125877e-001;
    __statist_i_h_wts[10,245]=-9.18985974079108e-002;
    __statist_i_h_wts[10,246]=8.81072980268595e-001;
    __statist_i_h_wts[10,247]=3.79235680415083e-001;
    __statist_i_h_wts[10,248]=-4.14064509006401e-002;

    __statist_i_h_wts[11,0]=-6.15111636943185e-001;
    __statist_i_h_wts[11,1]=-6.50038658864560e-001;
    __statist_i_h_wts[11,2]=-6.35433286794571e-001;
    __statist_i_h_wts[11,3]=-4.69093012621935e-001;
    __statist_i_h_wts[11,4]=-3.34634037620630e-001;
    __statist_i_h_wts[11,5]=-1.93604910373313e-001;
    __statist_i_h_wts[11,6]=-1.11397716444282e-001;
    __statist_i_h_wts[11,7]=-4.51773915578706e-002;
    __statist_i_h_wts[11,8]=6.80836325251268e-002;
    __statist_i_h_wts[11,9]=1.23221707370475e-001;
    __statist_i_h_wts[11,10]=2.01578246431627e-001;
    __statist_i_h_wts[11,11]=2.17385846223426e-001;
    __statist_i_h_wts[11,12]=2.55197453625120e-001;
    __statist_i_h_wts[11,13]=3.40582111416420e-001;
    __statist_i_h_wts[11,14]=5.28387515191458e-001;
    __statist_i_h_wts[11,15]=-6.84179408695247e-001;
    __statist_i_h_wts[11,16]=-7.50256081399016e-001;
    __statist_i_h_wts[11,17]=-7.01108984249265e-001;
    __statist_i_h_wts[11,18]=-5.12309145739304e-001;
    __statist_i_h_wts[11,19]=-4.14157432960583e-001;
    __statist_i_h_wts[11,20]=-3.01155842484434e-001;
    __statist_i_h_wts[11,21]=-2.11426074857548e-001;
    __statist_i_h_wts[11,22]=-6.79401743943512e-002;
    __statist_i_h_wts[11,23]=1.70824623345970e-002;
    __statist_i_h_wts[11,24]=1.23158686462805e-001;
    __statist_i_h_wts[11,25]=1.46126232643505e-001;
    __statist_i_h_wts[11,26]=2.44158467920568e-001;
    __statist_i_h_wts[11,27]=2.37227757732319e-001;
    __statist_i_h_wts[11,28]=3.28268755624937e-001;
    __statist_i_h_wts[11,29]=5.16317004607093e-001;
    __statist_i_h_wts[11,30]=-8.29505821530814e-001;
    __statist_i_h_wts[11,31]=-7.68433133173205e-001;
    __statist_i_h_wts[11,32]=-7.51227543445707e-001;
    __statist_i_h_wts[11,33]=-5.60904606673563e-001;
    __statist_i_h_wts[11,34]=-4.50933739652236e-001;
    __statist_i_h_wts[11,35]=-3.06627247396800e-001;
    __statist_i_h_wts[11,36]=-1.89829719272346e-001;
    __statist_i_h_wts[11,37]=-9.05362105989174e-002;
    __statist_i_h_wts[11,38]=-2.89454562861348e-002;
    __statist_i_h_wts[11,39]=9.48507990274857e-002;
    __statist_i_h_wts[11,40]=1.28735665921185e-001;
    __statist_i_h_wts[11,41]=2.06683406288921e-001;
    __statist_i_h_wts[11,42]=3.37454493517763e-001;
    __statist_i_h_wts[11,43]=3.47490372582607e-001;
    __statist_i_h_wts[11,44]=4.25692343621430e-001;
    __statist_i_h_wts[11,45]=-8.98327040407862e-001;
    __statist_i_h_wts[11,46]=-8.48753273413969e-001;
    __statist_i_h_wts[11,47]=-8.80876926495255e-001;
    __statist_i_h_wts[11,48]=-7.07454972833836e-001;
    __statist_i_h_wts[11,49]=-6.51953549177466e-001;
    __statist_i_h_wts[11,50]=-4.08580441829771e-001;
    __statist_i_h_wts[11,51]=-4.04942867731359e-001;
    __statist_i_h_wts[11,52]=-2.11781341896905e-001;
    __statist_i_h_wts[11,53]=-6.40038335419893e-002;
    __statist_i_h_wts[11,54]=1.38979410190854e-001;
    __statist_i_h_wts[11,55]=2.63013397541027e-001;
    __statist_i_h_wts[11,56]=3.28450523892743e-001;
    __statist_i_h_wts[11,57]=3.46558789146509e-001;
    __statist_i_h_wts[11,58]=4.37472824079625e-001;
    __statist_i_h_wts[11,59]=4.66013214529175e-001;
    __statist_i_h_wts[11,60]=-8.69427424210759e-001;
    __statist_i_h_wts[11,61]=-8.33720322491863e-001;
    __statist_i_h_wts[11,62]=-8.20060298056142e-001;
    __statist_i_h_wts[11,63]=-7.27479141824726e-001;
    __statist_i_h_wts[11,64]=-6.61280630993360e-001;
    __statist_i_h_wts[11,65]=-4.70399748538534e-001;
    __statist_i_h_wts[11,66]=-4.08646668227125e-001;
    __statist_i_h_wts[11,67]=-1.61460253333987e-001;
    __statist_i_h_wts[11,68]=-5.33507660100596e-002;
    __statist_i_h_wts[11,69]=1.95998057673695e-001;
    __statist_i_h_wts[11,70]=2.01386747022181e-001;
    __statist_i_h_wts[11,71]=2.62264211891636e-001;
    __statist_i_h_wts[11,72]=2.83877630400668e-001;
    __statist_i_h_wts[11,73]=4.33653808873337e-001;
    __statist_i_h_wts[11,74]=3.96419565498060e-001;
    __statist_i_h_wts[11,75]=-7.14152763319432e-001;
    __statist_i_h_wts[11,76]=-7.03134043171029e-001;
    __statist_i_h_wts[11,77]=-6.00388288312058e-001;
    __statist_i_h_wts[11,78]=-7.19192892505445e-001;
    __statist_i_h_wts[11,79]=-6.41184975180191e-001;
    __statist_i_h_wts[11,80]=-6.05811153452313e-001;
    __statist_i_h_wts[11,81]=-3.73670266330717e-001;
    __statist_i_h_wts[11,82]=-1.75784357122532e-001;
    __statist_i_h_wts[11,83]=2.79251061023659e-002;
    __statist_i_h_wts[11,84]=1.30461098357150e-001;
    __statist_i_h_wts[11,85]=1.51760862572895e-001;
    __statist_i_h_wts[11,86]=1.52363625856554e-001;
    __statist_i_h_wts[11,87]=2.20160071593542e-001;
    __statist_i_h_wts[11,88]=3.21623218465826e-001;
    __statist_i_h_wts[11,89]=3.59264736398991e-001;
    __statist_i_h_wts[11,90]=-7.44002039103471e-001;
    __statist_i_h_wts[11,91]=-6.81826480462967e-001;
    __statist_i_h_wts[11,92]=-6.78587728599755e-001;
    __statist_i_h_wts[11,93]=-6.94511450979187e-001;
    __statist_i_h_wts[11,94]=-5.45907256919971e-001;
    __statist_i_h_wts[11,95]=-4.47409003189135e-001;
    __statist_i_h_wts[11,96]=-2.20624331534034e-001;
    __statist_i_h_wts[11,97]=-1.39474471849554e-001;
    __statist_i_h_wts[11,98]=-3.77554725997700e-002;
    __statist_i_h_wts[11,99]=6.88671665506056e-002;
    __statist_i_h_wts[11,100]=1.09396708125280e-001;
    __statist_i_h_wts[11,101]=1.28852802641971e-001;
    __statist_i_h_wts[11,102]=2.01216806067368e-001;
    __statist_i_h_wts[11,103]=3.98550484460604e-001;
    __statist_i_h_wts[11,104]=3.81718434878341e-001;
    __statist_i_h_wts[11,105]=-6.63365906939354e-001;
    __statist_i_h_wts[11,106]=-6.57040713904956e-001;
    __statist_i_h_wts[11,107]=-6.12487182999545e-001;
    __statist_i_h_wts[11,108]=-5.34371512247544e-001;
    __statist_i_h_wts[11,109]=-4.13587814325894e-001;
    __statist_i_h_wts[11,110]=-3.09243995726154e-001;
    __statist_i_h_wts[11,111]=-4.69768164351561e-002;
    __statist_i_h_wts[11,112]=-3.84665591865899e-002;
    __statist_i_h_wts[11,113]=2.86675002062734e-002;
    __statist_i_h_wts[11,114]=1.03299224913150e-001;
    __statist_i_h_wts[11,115]=1.25004662882468e-001;
    __statist_i_h_wts[11,116]=9.23263884221079e-002;
    __statist_i_h_wts[11,117]=1.99210137897688e-001;
    __statist_i_h_wts[11,118]=3.71642786562981e-001;
    __statist_i_h_wts[11,119]=3.73669885007954e-001;
    __statist_i_h_wts[11,120]=-4.85476940698228e-001;
    __statist_i_h_wts[11,121]=-4.14992512521032e-001;
    __statist_i_h_wts[11,122]=-3.71138855822318e-001;
    __statist_i_h_wts[11,123]=-3.21872074011724e-001;
    __statist_i_h_wts[11,124]=-2.66972932423877e-001;
    __statist_i_h_wts[11,125]=-1.91891516442691e-001;
    __statist_i_h_wts[11,126]=-6.04128865929316e-002;
    __statist_i_h_wts[11,127]=2.22090341411826e-002;
    __statist_i_h_wts[11,128]=-1.47850978840527e-002;
    __statist_i_h_wts[11,129]=1.55806118140490e-001;
    __statist_i_h_wts[11,130]=2.97099050147905e-001;
    __statist_i_h_wts[11,131]=2.23672364990643e-001;
    __statist_i_h_wts[11,132]=3.38303386610609e-001;
    __statist_i_h_wts[11,133]=4.66691562658148e-001;
    __statist_i_h_wts[11,134]=3.96123819716743e-001;
    __statist_i_h_wts[11,135]=-3.75898950479604e-001;
    __statist_i_h_wts[11,136]=-3.35591624374802e-001;
    __statist_i_h_wts[11,137]=-3.37542275279669e-001;
    __statist_i_h_wts[11,138]=-2.75668282749593e-001;
    __statist_i_h_wts[11,139]=-1.91510738408032e-001;
    __statist_i_h_wts[11,140]=-1.12177065189427e-001;
    __statist_i_h_wts[11,141]=3.11390433274741e-002;
    __statist_i_h_wts[11,142]=6.74585185652420e-002;
    __statist_i_h_wts[11,143]=1.00904292940677e-001;
    __statist_i_h_wts[11,144]=1.71333783862919e-001;
    __statist_i_h_wts[11,145]=2.50276858557960e-001;
    __statist_i_h_wts[11,146]=2.41623042418307e-001;
    __statist_i_h_wts[11,147]=3.39216423322464e-001;
    __statist_i_h_wts[11,148]=3.82869732285257e-001;
    __statist_i_h_wts[11,149]=3.20256272210165e-001;
    __statist_i_h_wts[11,150]=-3.54846442040824e-001;
    __statist_i_h_wts[11,151]=-3.29458895207770e-001;
    __statist_i_h_wts[11,152]=-2.84621825697308e-001;
    __statist_i_h_wts[11,153]=-2.61618348954587e-001;
    __statist_i_h_wts[11,154]=-1.05981973280593e-001;
    __statist_i_h_wts[11,155]=6.07816595568404e-002;
    __statist_i_h_wts[11,156]=1.83923923980031e-001;
    __statist_i_h_wts[11,157]=1.90025644417293e-001;
    __statist_i_h_wts[11,158]=1.54114498111196e-001;
    __statist_i_h_wts[11,159]=1.80365404236939e-001;
    __statist_i_h_wts[11,160]=2.61918192094970e-001;
    __statist_i_h_wts[11,161]=2.93989135785468e-001;
    __statist_i_h_wts[11,162]=3.90741103201172e-001;
    __statist_i_h_wts[11,163]=3.76027410960906e-001;
    __statist_i_h_wts[11,164]=2.58531392376336e-001;
    __statist_i_h_wts[11,165]=-1.34499176695843e-001;
    __statist_i_h_wts[11,166]=-1.65849226296075e-001;
    __statist_i_h_wts[11,167]=-1.44773773319190e-001;
    __statist_i_h_wts[11,168]=-3.47183829246659e-002;
    __statist_i_h_wts[11,169]=7.88535500922789e-002;
    __statist_i_h_wts[11,170]=1.46429018865510e-001;
    __statist_i_h_wts[11,171]=2.45532623438042e-001;
    __statist_i_h_wts[11,172]=2.28900311896850e-001;
    __statist_i_h_wts[11,173]=1.90901456211823e-001;
    __statist_i_h_wts[11,174]=2.36687587151777e-001;
    __statist_i_h_wts[11,175]=2.90228692746602e-001;
    __statist_i_h_wts[11,176]=3.25292185992012e-001;
    __statist_i_h_wts[11,177]=3.86410287730641e-001;
    __statist_i_h_wts[11,178]=4.03210685059644e-001;
    __statist_i_h_wts[11,179]=3.12535366813382e-001;
    __statist_i_h_wts[11,180]=-1.10873113584683e-001;
    __statist_i_h_wts[11,181]=-1.32352395630226e-001;
    __statist_i_h_wts[11,182]=-7.58062859715162e-002;
    __statist_i_h_wts[11,183]=-4.14908734051383e-002;
    __statist_i_h_wts[11,184]=-5.45277464279558e-003;
    __statist_i_h_wts[11,185]=6.51108210833577e-002;
    __statist_i_h_wts[11,186]=2.47544703504378e-001;
    __statist_i_h_wts[11,187]=2.29262740032594e-001;
    __statist_i_h_wts[11,188]=2.20272012590886e-001;
    __statist_i_h_wts[11,189]=3.18606435087905e-001;
    __statist_i_h_wts[11,190]=3.45117908060467e-001;
    __statist_i_h_wts[11,191]=3.96523300256502e-001;
    __statist_i_h_wts[11,192]=4.49823249331927e-001;
    __statist_i_h_wts[11,193]=4.66990739817757e-001;
    __statist_i_h_wts[11,194]=4.38975797374410e-001;
    __statist_i_h_wts[11,195]=-3.73547242978755e-002;
    __statist_i_h_wts[11,196]=-2.09367401418121e-002;
    __statist_i_h_wts[11,197]=-2.07251986705927e-002;
    __statist_i_h_wts[11,198]=5.58628389086029e-002;
    __statist_i_h_wts[11,199]=9.79906986840790e-002;
    __statist_i_h_wts[11,200]=8.03626960577931e-002;
    __statist_i_h_wts[11,201]=2.32787056075125e-001;
    __statist_i_h_wts[11,202]=1.98329557776294e-001;
    __statist_i_h_wts[11,203]=2.05541562601372e-001;
    __statist_i_h_wts[11,204]=2.90723811605618e-001;
    __statist_i_h_wts[11,205]=3.72745120922704e-001;
    __statist_i_h_wts[11,206]=3.77006435681872e-001;
    __statist_i_h_wts[11,207]=5.21403894305092e-001;
    __statist_i_h_wts[11,208]=5.69841751001385e-001;
    __statist_i_h_wts[11,209]=4.65322663586133e-001;
    __statist_i_h_wts[11,210]=2.92518439221897e-002;
    __statist_i_h_wts[11,211]=2.37761224581605e-002;
    __statist_i_h_wts[11,212]=-1.09116911397570e-002;
    __statist_i_h_wts[11,213]=1.01166440108330e-001;
    __statist_i_h_wts[11,214]=1.27617495670908e-001;
    __statist_i_h_wts[11,215]=1.24404736588377e-001;
    __statist_i_h_wts[11,216]=1.79693267954602e-001;
    __statist_i_h_wts[11,217]=1.96894442525234e-001;
    __statist_i_h_wts[11,218]=1.42080109113146e-001;
    __statist_i_h_wts[11,219]=2.47000041090755e-001;
    __statist_i_h_wts[11,220]=2.82155008928016e-001;
    __statist_i_h_wts[11,221]=3.08332184005042e-001;
    __statist_i_h_wts[11,222]=4.40365068603052e-001;
    __statist_i_h_wts[11,223]=5.16702808094734e-001;
    __statist_i_h_wts[11,224]=4.33236135586338e-001;
    __statist_i_h_wts[11,225]=4.78679994611145e-002;
    __statist_i_h_wts[11,226]=-8.63354628777119e-001;
    __statist_i_h_wts[11,227]=1.38172729896880e-001;
    __statist_i_h_wts[11,228]=-6.89982859620736e-001;
    __statist_i_h_wts[11,229]=1.89781275313684e-001;
    __statist_i_h_wts[11,230]=1.12259498260309e+000;
    __statist_i_h_wts[11,231]=2.68319813956293e-001;
    __statist_i_h_wts[11,232]=2.05404489343957e+000;
    __statist_i_h_wts[11,233]=5.77875120372865e-001;
    __statist_i_h_wts[11,234]=9.77105071174457e-001;
    __statist_i_h_wts[11,235]=-6.02019811541995e-001;
    __statist_i_h_wts[11,236]=-2.43506614393732e+000;
    __statist_i_h_wts[11,237]=-6.61651901391932e-001;
    __statist_i_h_wts[11,238]=1.57130865753138e-002;
    __statist_i_h_wts[11,239]=8.89238601734141e-001;
    __statist_i_h_wts[11,240]=-5.80428057689022e-001;
    __statist_i_h_wts[11,241]=1.64836717604197e+000;
    __statist_i_h_wts[11,242]=1.05168650592808e-001;
    __statist_i_h_wts[11,243]=1.05037118164637e+000;
    __statist_i_h_wts[11,244]=-2.66463094148045e-001;
    __statist_i_h_wts[11,245]=-1.42579626955405e+000;
    __statist_i_h_wts[11,246]=1.26756188118426e-001;
    __statist_i_h_wts[11,247]=-8.90129803086134e-001;
    __statist_i_h_wts[11,248]=2.27714678612278e-001;

    __statist_i_h_wts[12,0]=-1.89107961059077e-001;
    __statist_i_h_wts[12,1]=-1.34112750259696e-001;
    __statist_i_h_wts[12,2]=2.08790856361545e-002;
    __statist_i_h_wts[12,3]=2.66365538149250e-002;
    __statist_i_h_wts[12,4]=-1.05136797759896e-002;
    __statist_i_h_wts[12,5]=-3.75256853453191e-001;
    __statist_i_h_wts[12,6]=-1.15929609887767e-002;
    __statist_i_h_wts[12,7]=-4.45764066464979e-002;
    __statist_i_h_wts[12,8]=-2.39377715633817e-001;
    __statist_i_h_wts[12,9]=-1.62113429612861e-001;
    __statist_i_h_wts[12,10]=-6.60640272835957e-002;
    __statist_i_h_wts[12,11]=-1.09854325732759e-001;
    __statist_i_h_wts[12,12]=2.49590325988461e-001;
    __statist_i_h_wts[12,13]=-4.02632671607660e-002;
    __statist_i_h_wts[12,14]=-1.43057452605294e-001;
    __statist_i_h_wts[12,15]=-2.74688018324899e-001;
    __statist_i_h_wts[12,16]=-1.22748030083257e-002;
    __statist_i_h_wts[12,17]=-7.27642261074535e-002;
    __statist_i_h_wts[12,18]=-7.21877569574930e-002;
    __statist_i_h_wts[12,19]=-1.31607356134135e-001;
    __statist_i_h_wts[12,20]=-1.50389290897345e-001;
    __statist_i_h_wts[12,21]=1.30543366044341e-002;
    __statist_i_h_wts[12,22]=8.67170852257129e-003;
    __statist_i_h_wts[12,23]=2.83468273024296e-002;
    __statist_i_h_wts[12,24]=-2.80599401798958e-002;
    __statist_i_h_wts[12,25]=1.09811683829570e-001;
    __statist_i_h_wts[12,26]=-2.56807849112039e-001;
    __statist_i_h_wts[12,27]=2.20245131425590e-001;
    __statist_i_h_wts[12,28]=-6.03730035297453e-004;
    __statist_i_h_wts[12,29]=-1.03838412747027e-001;
    __statist_i_h_wts[12,30]=-2.94837488047809e-001;
    __statist_i_h_wts[12,31]=-2.62910985442551e-001;
    __statist_i_h_wts[12,32]=9.60030552295608e-003;
    __statist_i_h_wts[12,33]=4.10713938874617e-002;
    __statist_i_h_wts[12,34]=2.16856532735398e-002;
    __statist_i_h_wts[12,35]=-6.10799019412332e-002;
    __statist_i_h_wts[12,36]=-1.42161968672462e-001;
    __statist_i_h_wts[12,37]=3.07946227380962e-002;
    __statist_i_h_wts[12,38]=4.59180011183899e-002;
    __statist_i_h_wts[12,39]=6.42917074986712e-002;
    __statist_i_h_wts[12,40]=1.15922532347471e-002;
    __statist_i_h_wts[12,41]=1.92655030328951e-001;
    __statist_i_h_wts[12,42]=5.36181255532522e-002;
    __statist_i_h_wts[12,43]=2.12006768524759e-001;
    __statist_i_h_wts[12,44]=3.79238135128688e-001;
    __statist_i_h_wts[12,45]=4.52693747919643e-002;
    __statist_i_h_wts[12,46]=-1.39551650769032e-001;
    __statist_i_h_wts[12,47]=-4.71744947413985e-002;
    __statist_i_h_wts[12,48]=-1.54492297876500e-001;
    __statist_i_h_wts[12,49]=9.24142579191287e-002;
    __statist_i_h_wts[12,50]=-2.65377766403640e-001;
    __statist_i_h_wts[12,51]=1.20077804229328e-001;
    __statist_i_h_wts[12,52]=1.58672332367509e-001;
    __statist_i_h_wts[12,53]=2.43364467807611e-001;
    __statist_i_h_wts[12,54]=-7.05357782693514e-002;
    __statist_i_h_wts[12,55]=-6.56743256379106e-002;
    __statist_i_h_wts[12,56]=-2.73390277643262e-002;
    __statist_i_h_wts[12,57]=-8.40556753094793e-002;
    __statist_i_h_wts[12,58]=8.29185392669428e-002;
    __statist_i_h_wts[12,59]=6.64120556603668e-002;
    __statist_i_h_wts[12,60]=4.31565786010522e-002;
    __statist_i_h_wts[12,61]=-1.74240166758090e-001;
    __statist_i_h_wts[12,62]=-1.69221679727091e-001;
    __statist_i_h_wts[12,63]=-2.07563031329653e-001;
    __statist_i_h_wts[12,64]=-1.04558968653178e-001;
    __statist_i_h_wts[12,65]=-4.19264892710945e-001;
    __statist_i_h_wts[12,66]=5.86242911426466e-002;
    __statist_i_h_wts[12,67]=-1.71889579813483e-001;
    __statist_i_h_wts[12,68]=2.33521850142173e-001;
    __statist_i_h_wts[12,69]=-9.96325261200478e-002;
    __statist_i_h_wts[12,70]=-3.35261053588208e-002;
    __statist_i_h_wts[12,71]=-7.68072268767057e-002;
    __statist_i_h_wts[12,72]=-3.02570550425016e-002;
    __statist_i_h_wts[12,73]=-4.07098920437885e-002;
    __statist_i_h_wts[12,74]=1.29352116191234e-001;
    __statist_i_h_wts[12,75]=3.54523701651481e-001;
    __statist_i_h_wts[12,76]=2.57977454195084e-001;
    __statist_i_h_wts[12,77]=-1.29129573052978e-001;
    __statist_i_h_wts[12,78]=2.18342574802895e-001;
    __statist_i_h_wts[12,79]=1.29679327190944e-001;
    __statist_i_h_wts[12,80]=3.32020088417278e-001;
    __statist_i_h_wts[12,81]=3.03727479269534e-001;
    __statist_i_h_wts[12,82]=4.57797919859513e-002;
    __statist_i_h_wts[12,83]=2.87817784869986e-001;
    __statist_i_h_wts[12,84]=1.21651669494744e-001;
    __statist_i_h_wts[12,85]=-1.74122255166965e-001;
    __statist_i_h_wts[12,86]=-1.58481458233369e-001;
    __statist_i_h_wts[12,87]=-1.36916858938991e-001;
    __statist_i_h_wts[12,88]=-5.74122818493772e-002;
    __statist_i_h_wts[12,89]=-8.55873697127564e-002;
    __statist_i_h_wts[12,90]=3.47360677164264e-001;
    __statist_i_h_wts[12,91]=4.77923683463235e-002;
    __statist_i_h_wts[12,92]=4.62265139561436e-002;
    __statist_i_h_wts[12,93]=2.32839126219397e-001;
    __statist_i_h_wts[12,94]=1.15491411382537e-002;
    __statist_i_h_wts[12,95]=2.43228814789794e-001;
    __statist_i_h_wts[12,96]=7.99438877373083e-002;
    __statist_i_h_wts[12,97]=4.22775138831352e-003;
    __statist_i_h_wts[12,98]=1.22404339250720e-001;
    __statist_i_h_wts[12,99]=6.75936331911787e-002;
    __statist_i_h_wts[12,100]=-3.93000077618524e-001;
    __statist_i_h_wts[12,101]=-3.18812794266560e-001;
    __statist_i_h_wts[12,102]=-7.55869326220411e-002;
    __statist_i_h_wts[12,103]=-3.55330116081297e-002;
    __statist_i_h_wts[12,104]=4.26214173119698e-002;
    __statist_i_h_wts[12,105]=8.21808000701712e-002;
    __statist_i_h_wts[12,106]=3.66831654540531e-003;
    __statist_i_h_wts[12,107]=1.19293234826965e-001;
    __statist_i_h_wts[12,108]=1.32359359171694e-002;
    __statist_i_h_wts[12,109]=-2.18703483228578e-001;
    __statist_i_h_wts[12,110]=-2.13100697777191e-001;
    __statist_i_h_wts[12,111]=-7.25365267413111e-002;
    __statist_i_h_wts[12,112]=-2.56845657419930e-001;
    __statist_i_h_wts[12,113]=1.75592050095801e-002;
    __statist_i_h_wts[12,114]=-1.56667019000569e-001;
    __statist_i_h_wts[12,115]=-1.73301832796597e-001;
    __statist_i_h_wts[12,116]=9.87503343753350e-003;
    __statist_i_h_wts[12,117]=-7.39956622101419e-002;
    __statist_i_h_wts[12,118]=-2.64102827205915e-002;
    __statist_i_h_wts[12,119]=-7.27827842717795e-002;
    __statist_i_h_wts[12,120]=-6.95238623450869e-002;
    __statist_i_h_wts[12,121]=4.63751336052678e-002;
    __statist_i_h_wts[12,122]=1.88719595607763e-002;
    __statist_i_h_wts[12,123]=-1.27038952794066e-001;
    __statist_i_h_wts[12,124]=-1.52130122959660e-002;
    __statist_i_h_wts[12,125]=7.53609951523638e-002;
    __statist_i_h_wts[12,126]=1.75695494074206e-001;
    __statist_i_h_wts[12,127]=5.83658088670006e-003;
    __statist_i_h_wts[12,128]=4.20365355234780e-001;
    __statist_i_h_wts[12,129]=-4.12306409590042e-002;
    __statist_i_h_wts[12,130]=-1.92720340249990e-001;
    __statist_i_h_wts[12,131]=-1.37115999106305e-001;
    __statist_i_h_wts[12,132]=-1.80405681763943e-002;
    __statist_i_h_wts[12,133]=5.24807345317037e-002;
    __statist_i_h_wts[12,134]=-1.06807145389022e-003;
    __statist_i_h_wts[12,135]=1.39306583366652e-001;
    __statist_i_h_wts[12,136]=-1.21658470038569e-001;
    __statist_i_h_wts[12,137]=-1.29841766986701e-001;
    __statist_i_h_wts[12,138]=-5.30212727443794e-003;
    __statist_i_h_wts[12,139]=1.49838185482848e-001;
    __statist_i_h_wts[12,140]=7.39285624693179e-002;
    __statist_i_h_wts[12,141]=1.93924809192025e-001;
    __statist_i_h_wts[12,142]=1.53446837650247e-001;
    __statist_i_h_wts[12,143]=1.80541566085917e-001;
    __statist_i_h_wts[12,144]=1.14682054239877e-001;
    __statist_i_h_wts[12,145]=-6.80712113479146e-002;
    __statist_i_h_wts[12,146]=-2.14828387093755e-001;
    __statist_i_h_wts[12,147]=-1.01968101434435e-001;
    __statist_i_h_wts[12,148]=2.35168819093741e-001;
    __statist_i_h_wts[12,149]=1.10122142528529e-001;
    __statist_i_h_wts[12,150]=-4.19591589666210e-002;
    __statist_i_h_wts[12,151]=-1.52837168374814e-001;
    __statist_i_h_wts[12,152]=-1.02320286913826e-001;
    __statist_i_h_wts[12,153]=1.18012227973497e-001;
    __statist_i_h_wts[12,154]=5.15439472111541e-002;
    __statist_i_h_wts[12,155]=1.89735722025678e-002;
    __statist_i_h_wts[12,156]=1.35373675493515e-001;
    __statist_i_h_wts[12,157]=-4.85935824740135e-002;
    __statist_i_h_wts[12,158]=5.20520069842570e-002;
    __statist_i_h_wts[12,159]=-6.21046485593957e-003;
    __statist_i_h_wts[12,160]=1.25858082952851e-002;
    __statist_i_h_wts[12,161]=-1.57268064543980e-001;
    __statist_i_h_wts[12,162]=-2.88618990509413e-002;
    __statist_i_h_wts[12,163]=1.72387032668132e-001;
    __statist_i_h_wts[12,164]=2.76118747616178e-001;
    __statist_i_h_wts[12,165]=-1.26964154982858e-002;
    __statist_i_h_wts[12,166]=-4.90212859125221e-002;
    __statist_i_h_wts[12,167]=3.99060334673354e-002;
    __statist_i_h_wts[12,168]=2.29586021721711e-001;
    __statist_i_h_wts[12,169]=1.98493221409602e-001;
    __statist_i_h_wts[12,170]=1.09856213786398e-001;
    __statist_i_h_wts[12,171]=8.49084390500580e-002;
    __statist_i_h_wts[12,172]=7.90619342115091e-002;
    __statist_i_h_wts[12,173]=-1.09140043496846e-001;
    __statist_i_h_wts[12,174]=-2.28251043316749e-001;
    __statist_i_h_wts[12,175]=-1.93568580136970e-001;
    __statist_i_h_wts[12,176]=-3.36897880605819e-001;
    __statist_i_h_wts[12,177]=-9.58411931363931e-004;
    __statist_i_h_wts[12,178]=2.44543885649341e-001;
    __statist_i_h_wts[12,179]=1.01886751353467e-001;
    __statist_i_h_wts[12,180]=1.22466082146038e-002;
    __statist_i_h_wts[12,181]=-1.46567793685348e-001;
    __statist_i_h_wts[12,182]=-1.49191469784790e-001;
    __statist_i_h_wts[12,183]=2.94698511784323e-002;
    __statist_i_h_wts[12,184]=-2.53232023738418e-002;
    __statist_i_h_wts[12,185]=6.08252272245226e-002;
    __statist_i_h_wts[12,186]=1.02366832079559e-001;
    __statist_i_h_wts[12,187]=3.88129146292571e-003;
    __statist_i_h_wts[12,188]=-1.67406502253455e-002;
    __statist_i_h_wts[12,189]=-1.12624644670958e-001;
    __statist_i_h_wts[12,190]=-2.16051162026969e-001;
    __statist_i_h_wts[12,191]=-2.21540166830658e-001;
    __statist_i_h_wts[12,192]=1.28991374451734e-001;
    __statist_i_h_wts[12,193]=2.09327246479566e-001;
    __statist_i_h_wts[12,194]=1.55364162666319e-001;
    __statist_i_h_wts[12,195]=-2.27222771977054e-001;
    __statist_i_h_wts[12,196]=-2.62509510079682e-001;
    __statist_i_h_wts[12,197]=-2.19897177967664e-001;
    __statist_i_h_wts[12,198]=-9.96975535690198e-003;
    __statist_i_h_wts[12,199]=3.28506362957634e-002;
    __statist_i_h_wts[12,200]=7.17634419936255e-002;
    __statist_i_h_wts[12,201]=-1.61193481021846e-001;
    __statist_i_h_wts[12,202]=-8.99575386091504e-003;
    __statist_i_h_wts[12,203]=-7.05301903119378e-002;
    __statist_i_h_wts[12,204]=-9.87246660656712e-002;
    __statist_i_h_wts[12,205]=-2.72979164007097e-002;
    __statist_i_h_wts[12,206]=3.19472839856507e-002;
    __statist_i_h_wts[12,207]=1.17647626659998e-001;
    __statist_i_h_wts[12,208]=1.18360597499057e-001;
    __statist_i_h_wts[12,209]=-1.07985122309606e-002;
    __statist_i_h_wts[12,210]=-1.47473583760317e-001;
    __statist_i_h_wts[12,211]=-1.58521355933996e-001;
    __statist_i_h_wts[12,212]=-1.05921219414498e-001;
    __statist_i_h_wts[12,213]=-3.16624508889603e-002;
    __statist_i_h_wts[12,214]=-4.21540816599696e-002;
    __statist_i_h_wts[12,215]=-3.09294020771420e-003;
    __statist_i_h_wts[12,216]=4.69669362186455e-002;
    __statist_i_h_wts[12,217]=1.57708805606117e-001;
    __statist_i_h_wts[12,218]=3.14069070800348e-002;
    __statist_i_h_wts[12,219]=-8.98250659264594e-002;
    __statist_i_h_wts[12,220]=8.67285045211331e-002;
    __statist_i_h_wts[12,221]=2.61457830784238e-002;
    __statist_i_h_wts[12,222]=9.94359238494608e-002;
    __statist_i_h_wts[12,223]=-6.74029493759865e-002;
    __statist_i_h_wts[12,224]=-3.12217659343759e-002;
    __statist_i_h_wts[12,225]=-2.81433120958782e-001;
    __statist_i_h_wts[12,226]=-2.34230614215873e-001;
    __statist_i_h_wts[12,227]=-2.75194743167286e-002;
    __statist_i_h_wts[12,228]=-1.90429441922183e-001;
    __statist_i_h_wts[12,229]=1.36706847310067e-001;
    __statist_i_h_wts[12,230]=1.59471999558925e-001;
    __statist_i_h_wts[12,231]=3.56582536713140e-001;
    __statist_i_h_wts[12,232]=3.04006677359652e-001;
    __statist_i_h_wts[12,233]=8.81495367223596e-002;
    __statist_i_h_wts[12,234]=-2.33079466384715e-001;
    __statist_i_h_wts[12,235]=4.88186161475952e-001;
    __statist_i_h_wts[12,236]=8.31775064544132e-001;
    __statist_i_h_wts[12,237]=-5.57494233636315e-001;
    __statist_i_h_wts[12,238]=-1.64372111454695e-001;
    __statist_i_h_wts[12,239]=6.00627513364146e-001;
    __statist_i_h_wts[12,240]=3.45559634092280e-001;
    __statist_i_h_wts[12,241]=-5.51301368350579e-001;
    __statist_i_h_wts[12,242]=-2.88849116442093e-001;
    __statist_i_h_wts[12,243]=1.11906972069571e-001;
    __statist_i_h_wts[12,244]=-2.21742169890044e-001;
    __statist_i_h_wts[12,245]=2.20181882105919e-001;
    __statist_i_h_wts[12,246]=2.84224365783623e-001;
    __statist_i_h_wts[12,247]=3.46437579711249e-002;
    __statist_i_h_wts[12,248]=2.75850591141628e-001;

    __statist_i_h_wts[13,0]=5.11194053703945e-001;
    __statist_i_h_wts[13,1]=4.63390193771703e-001;
    __statist_i_h_wts[13,2]=4.43654197122043e-001;
    __statist_i_h_wts[13,3]=3.34030885450717e-001;
    __statist_i_h_wts[13,4]=2.75570028449383e-001;
    __statist_i_h_wts[13,5]=2.26813580902747e-001;
    __statist_i_h_wts[13,6]=-2.32212775142257e-002;
    __statist_i_h_wts[13,7]=-3.39279291511643e-002;
    __statist_i_h_wts[13,8]=-9.09925851138098e-002;
    __statist_i_h_wts[13,9]=-1.21984592860623e-001;
    __statist_i_h_wts[13,10]=-2.26671044091220e-001;
    __statist_i_h_wts[13,11]=-1.73292647928575e-001;
    __statist_i_h_wts[13,12]=-2.64399511185834e-001;
    __statist_i_h_wts[13,13]=-2.21942434383002e-001;
    __statist_i_h_wts[13,14]=-3.10377793445435e-001;
    __statist_i_h_wts[13,15]=5.22421354623676e-001;
    __statist_i_h_wts[13,16]=4.64849294867049e-001;
    __statist_i_h_wts[13,17]=3.94345099724117e-001;
    __statist_i_h_wts[13,18]=3.43876411180439e-001;
    __statist_i_h_wts[13,19]=2.75958499634040e-001;
    __statist_i_h_wts[13,20]=1.80730397965883e-001;
    __statist_i_h_wts[13,21]=-5.85112670927885e-003;
    __statist_i_h_wts[13,22]=-9.89503659692564e-003;
    __statist_i_h_wts[13,23]=-6.58895026270246e-002;
    __statist_i_h_wts[13,24]=-1.11498149712617e-001;
    __statist_i_h_wts[13,25]=-1.20528820816085e-001;
    __statist_i_h_wts[13,26]=-1.33434782760521e-001;
    __statist_i_h_wts[13,27]=-2.38202338897393e-001;
    __statist_i_h_wts[13,28]=-1.93936988940723e-001;
    __statist_i_h_wts[13,29]=-2.62203151162820e-001;
    __statist_i_h_wts[13,30]=7.83145336737471e-001;
    __statist_i_h_wts[13,31]=6.96612608355621e-001;
    __statist_i_h_wts[13,32]=5.23432644476024e-001;
    __statist_i_h_wts[13,33]=4.91811087397212e-001;
    __statist_i_h_wts[13,34]=4.47555770418083e-001;
    __statist_i_h_wts[13,35]=3.66494358472468e-001;
    __statist_i_h_wts[13,36]=2.00130159373285e-001;
    __statist_i_h_wts[13,37]=5.94859843453957e-002;
    __statist_i_h_wts[13,38]=-6.05332766512970e-002;
    __statist_i_h_wts[13,39]=-9.24244163461454e-002;
    __statist_i_h_wts[13,40]=-9.92036002799188e-002;
    __statist_i_h_wts[13,41]=-9.67664460374731e-002;
    __statist_i_h_wts[13,42]=-2.96765013473081e-001;
    __statist_i_h_wts[13,43]=-3.12223508320126e-001;
    __statist_i_h_wts[13,44]=-3.58923789909739e-001;
    __statist_i_h_wts[13,45]=7.24532509501394e-001;
    __statist_i_h_wts[13,46]=8.66745005766827e-001;
    __statist_i_h_wts[13,47]=6.04530492984255e-001;
    __statist_i_h_wts[13,48]=6.13950839819451e-001;
    __statist_i_h_wts[13,49]=6.46312480697196e-001;
    __statist_i_h_wts[13,50]=4.54808535341946e-001;
    __statist_i_h_wts[13,51]=7.84484460516976e-002;
    __statist_i_h_wts[13,52]=2.83126424251397e-002;
    __statist_i_h_wts[13,53]=-5.16525735595990e-002;
    __statist_i_h_wts[13,54]=-2.55133187314533e-002;
    __statist_i_h_wts[13,55]=-5.72321551159704e-002;
    __statist_i_h_wts[13,56]=-1.70167402648772e-001;
    __statist_i_h_wts[13,57]=-3.82003338316866e-001;
    __statist_i_h_wts[13,58]=-3.02782322735837e-001;
    __statist_i_h_wts[13,59]=-3.27298764704272e-001;
    __statist_i_h_wts[13,60]=7.03407987608593e-001;
    __statist_i_h_wts[13,61]=7.74883628129211e-001;
    __statist_i_h_wts[13,62]=5.81863704058381e-001;
    __statist_i_h_wts[13,63]=5.13805978468725e-001;
    __statist_i_h_wts[13,64]=6.33114125937655e-001;
    __statist_i_h_wts[13,65]=5.86924490050512e-001;
    __statist_i_h_wts[13,66]=1.26281919878247e-001;
    __statist_i_h_wts[13,67]=-9.95194570340323e-003;
    __statist_i_h_wts[13,68]=-1.42311788691391e-001;
    __statist_i_h_wts[13,69]=-6.71042135694604e-002;
    __statist_i_h_wts[13,70]=-5.37052018127865e-002;
    __statist_i_h_wts[13,71]=-1.35036441592745e-001;
    __statist_i_h_wts[13,72]=-3.43517458824451e-001;
    __statist_i_h_wts[13,73]=-2.84287511969460e-001;
    __statist_i_h_wts[13,74]=-3.47703662864307e-001;
    __statist_i_h_wts[13,75]=6.74550626294403e-001;
    __statist_i_h_wts[13,76]=7.28988215896068e-001;
    __statist_i_h_wts[13,77]=6.35668009938262e-001;
    __statist_i_h_wts[13,78]=4.65797344683046e-001;
    __statist_i_h_wts[13,79]=5.52736614898969e-001;
    __statist_i_h_wts[13,80]=4.45581668752831e-001;
    __statist_i_h_wts[13,81]=3.76790464688043e-001;
    __statist_i_h_wts[13,82]=1.70360190712859e-001;
    __statist_i_h_wts[13,83]=1.25771612727752e-001;
    __statist_i_h_wts[13,84]=-3.30410167159626e-002;
    __statist_i_h_wts[13,85]=-8.32781672137839e-002;
    __statist_i_h_wts[13,86]=-1.74310138757566e-001;
    __statist_i_h_wts[13,87]=-2.71175041876200e-001;
    __statist_i_h_wts[13,88]=-2.75179768864991e-001;
    __statist_i_h_wts[13,89]=-3.11583063340557e-001;
    __statist_i_h_wts[13,90]=6.92707343104821e-001;
    __statist_i_h_wts[13,91]=6.73188139352355e-001;
    __statist_i_h_wts[13,92]=4.78754992536472e-001;
    __statist_i_h_wts[13,93]=4.98250823910223e-001;
    __statist_i_h_wts[13,94]=5.93662870250120e-001;
    __statist_i_h_wts[13,95]=3.98075255061644e-001;
    __statist_i_h_wts[13,96]=4.04861828746717e-001;
    __statist_i_h_wts[13,97]=1.80875251336232e-001;
    __statist_i_h_wts[13,98]=9.64153662727413e-003;
    __statist_i_h_wts[13,99]=-1.65593006827274e-001;
    __statist_i_h_wts[13,100]=-1.20998687423824e-001;
    __statist_i_h_wts[13,101]=-2.30064304623438e-001;
    __statist_i_h_wts[13,102]=-4.23464680309346e-001;
    __statist_i_h_wts[13,103]=-3.11467398164275e-001;
    __statist_i_h_wts[13,104]=-3.61493100494892e-001;
    __statist_i_h_wts[13,105]=4.17697563790247e-001;
    __statist_i_h_wts[13,106]=2.75086614097499e-001;
    __statist_i_h_wts[13,107]=2.35784114084489e-001;
    __statist_i_h_wts[13,108]=5.21876882830600e-001;
    __statist_i_h_wts[13,109]=4.45266489132566e-001;
    __statist_i_h_wts[13,110]=3.73845213584533e-001;
    __statist_i_h_wts[13,111]=2.73813333046884e-001;
    __statist_i_h_wts[13,112]=3.45523138344967e-001;
    __statist_i_h_wts[13,113]=-5.37908641070185e-002;
    __statist_i_h_wts[13,114]=-1.51577289067950e-001;
    __statist_i_h_wts[13,115]=-1.24506166450729e-001;
    __statist_i_h_wts[13,116]=-2.34329641191040e-001;
    __statist_i_h_wts[13,117]=-3.99125603856029e-001;
    __statist_i_h_wts[13,118]=-2.83690850131329e-001;
    __statist_i_h_wts[13,119]=-2.78605039595042e-001;
    __statist_i_h_wts[13,120]=3.30690921296552e-001;
    __statist_i_h_wts[13,121]=2.40688396652104e-001;
    __statist_i_h_wts[13,122]=4.68688232809734e-001;
    __statist_i_h_wts[13,123]=3.06989449678100e-001;
    __statist_i_h_wts[13,124]=9.21111797492347e-002;
    __statist_i_h_wts[13,125]=5.32282375727556e-002;
    __statist_i_h_wts[13,126]=1.11656633199921e-001;
    __statist_i_h_wts[13,127]=1.85402769502304e-001;
    __statist_i_h_wts[13,128]=-3.06800463962046e-001;
    __statist_i_h_wts[13,129]=-2.74337742760648e-001;
    __statist_i_h_wts[13,130]=-1.65644538005226e-001;
    __statist_i_h_wts[13,131]=-2.17924034661820e-001;
    __statist_i_h_wts[13,132]=-4.78833916463970e-001;
    __statist_i_h_wts[13,133]=-3.67461124237134e-001;
    __statist_i_h_wts[13,134]=-3.20527029971690e-001;
    __statist_i_h_wts[13,135]=3.65738732774884e-001;
    __statist_i_h_wts[13,136]=3.48273695909449e-001;
    __statist_i_h_wts[13,137]=4.00140961183597e-001;
    __statist_i_h_wts[13,138]=2.32319881836613e-001;
    __statist_i_h_wts[13,139]=6.90054427111181e-002;
    __statist_i_h_wts[13,140]=8.62423758267067e-002;
    __statist_i_h_wts[13,141]=-1.18403229305356e-002;
    __statist_i_h_wts[13,142]=1.65566058759049e-002;
    __statist_i_h_wts[13,143]=-2.76667123208068e-001;
    __statist_i_h_wts[13,144]=-3.92331426017936e-001;
    __statist_i_h_wts[13,145]=-2.13865739761836e-001;
    __statist_i_h_wts[13,146]=-2.57644327432395e-001;
    __statist_i_h_wts[13,147]=-3.89312420916155e-001;
    __statist_i_h_wts[13,148]=-3.31830595948638e-001;
    __statist_i_h_wts[13,149]=-2.30390901503924e-001;
    __statist_i_h_wts[13,150]=3.68043783437988e-001;
    __statist_i_h_wts[13,151]=3.69079125911525e-001;
    __statist_i_h_wts[13,152]=3.97735494826928e-001;
    __statist_i_h_wts[13,153]=2.77936820911347e-001;
    __statist_i_h_wts[13,154]=1.63601833209755e-001;
    __statist_i_h_wts[13,155]=1.20502182626522e-001;
    __statist_i_h_wts[13,156]=5.04570771818902e-002;
    __statist_i_h_wts[13,157]=4.43544516914292e-002;
    __statist_i_h_wts[13,158]=-1.72236897788984e-001;
    __statist_i_h_wts[13,159]=-1.79846168915866e-001;
    __statist_i_h_wts[13,160]=-1.24073422115626e-001;
    __statist_i_h_wts[13,161]=-2.23372958233553e-001;
    __statist_i_h_wts[13,162]=-3.80003220363459e-001;
    __statist_i_h_wts[13,163]=-2.08359663219732e-001;
    __statist_i_h_wts[13,164]=-8.81596656451322e-002;
    __statist_i_h_wts[13,165]=1.38122285725914e-001;
    __statist_i_h_wts[13,166]=2.57568945864703e-001;
    __statist_i_h_wts[13,167]=2.72761932723377e-001;
    __statist_i_h_wts[13,168]=1.09977366872444e-001;
    __statist_i_h_wts[13,169]=9.02129685902595e-002;
    __statist_i_h_wts[13,170]=6.35458529688958e-003;
    __statist_i_h_wts[13,171]=-1.23147472817545e-003;
    __statist_i_h_wts[13,172]=-6.70596033180584e-003;
    __statist_i_h_wts[13,173]=-1.08990912316500e-001;
    __statist_i_h_wts[13,174]=-1.67017322415303e-001;
    __statist_i_h_wts[13,175]=-2.17202571154826e-001;
    __statist_i_h_wts[13,176]=-2.40938715814245e-001;
    __statist_i_h_wts[13,177]=-2.48557593837628e-001;
    __statist_i_h_wts[13,178]=-2.57058167635848e-001;
    __statist_i_h_wts[13,179]=-1.43918814597904e-001;
    __statist_i_h_wts[13,180]=1.45892001124447e-001;
    __statist_i_h_wts[13,181]=2.37875659096118e-001;
    __statist_i_h_wts[13,182]=2.27416130594188e-001;
    __statist_i_h_wts[13,183]=9.44229055242265e-002;
    __statist_i_h_wts[13,184]=3.26941703725093e-003;
    __statist_i_h_wts[13,185]=4.64209918584382e-002;
    __statist_i_h_wts[13,186]=-7.31201490314072e-002;
    __statist_i_h_wts[13,187]=-1.84986633639980e-001;
    __statist_i_h_wts[13,188]=-2.74169721951582e-001;
    __statist_i_h_wts[13,189]=-2.56859128853753e-001;
    __statist_i_h_wts[13,190]=-3.30653717096984e-001;
    __statist_i_h_wts[13,191]=-3.18839997811542e-001;
    __statist_i_h_wts[13,192]=-3.63126296451077e-001;
    __statist_i_h_wts[13,193]=-3.60756517014015e-001;
    __statist_i_h_wts[13,194]=-2.70090449782629e-001;
    __statist_i_h_wts[13,195]=2.82227017024471e-002;
    __statist_i_h_wts[13,196]=1.23075779637252e-001;
    __statist_i_h_wts[13,197]=1.19663272959520e-001;
    __statist_i_h_wts[13,198]=8.33742964124851e-002;
    __statist_i_h_wts[13,199]=4.95709246213083e-002;
    __statist_i_h_wts[13,200]=4.78147767176792e-002;
    __statist_i_h_wts[13,201]=-6.10044535561747e-002;
    __statist_i_h_wts[13,202]=-1.90576739403892e-001;
    __statist_i_h_wts[13,203]=-1.80079302201510e-001;
    __statist_i_h_wts[13,204]=-2.21070858530254e-001;
    __statist_i_h_wts[13,205]=-2.82660436275478e-001;
    __statist_i_h_wts[13,206]=-2.72274221323093e-001;
    __statist_i_h_wts[13,207]=-2.70590914091461e-001;
    __statist_i_h_wts[13,208]=-2.56385572271071e-001;
    __statist_i_h_wts[13,209]=-2.34299539037801e-001;
    __statist_i_h_wts[13,210]=-5.97611787971314e-003;
    __statist_i_h_wts[13,211]=6.94697110197265e-002;
    __statist_i_h_wts[13,212]=5.70258640862521e-002;
    __statist_i_h_wts[13,213]=-3.11490578956584e-003;
    __statist_i_h_wts[13,214]=-3.33995115150799e-002;
    __statist_i_h_wts[13,215]=-8.26566031769158e-002;
    __statist_i_h_wts[13,216]=-1.18004500207009e-001;
    __statist_i_h_wts[13,217]=-1.16748897845189e-001;
    __statist_i_h_wts[13,218]=-2.09877211697947e-001;
    __statist_i_h_wts[13,219]=-2.39464316945829e-001;
    __statist_i_h_wts[13,220]=-2.46466690923988e-001;
    __statist_i_h_wts[13,221]=-2.26891410635116e-001;
    __statist_i_h_wts[13,222]=-2.27608843687008e-001;
    __statist_i_h_wts[13,223]=-2.45628722994128e-001;
    __statist_i_h_wts[13,224]=-2.46497001527296e-001;
    __statist_i_h_wts[13,225]=2.75243456546505e-001;
    __statist_i_h_wts[13,226]=2.42707973860140e-001;
    __statist_i_h_wts[13,227]=1.86415967389606e-001;
    __statist_i_h_wts[13,228]=3.49006495579370e-001;
    __statist_i_h_wts[13,229]=2.12898350658565e-002;
    __statist_i_h_wts[13,230]=-5.68405922790674e-001;
    __statist_i_h_wts[13,231]=-3.54926811944026e-001;
    __statist_i_h_wts[13,232]=-1.07131440966041e+000;
    __statist_i_h_wts[13,233]=-3.14271818262325e-001;
    __statist_i_h_wts[13,234]=-5.62116268851640e-001;
    __statist_i_h_wts[13,235]=2.94329260137504e-001;
    __statist_i_h_wts[13,236]=9.77173048859828e-001;
    __statist_i_h_wts[13,237]=5.78371357966969e-001;
    __statist_i_h_wts[13,238]=8.67972748419512e-003;
    __statist_i_h_wts[13,239]=-5.71588162648549e-001;
    __statist_i_h_wts[13,240]=3.75609210560074e-002;
    __statist_i_h_wts[13,241]=-8.59627268444838e-001;
    __statist_i_h_wts[13,242]=4.20434396407520e-002;
    __statist_i_h_wts[13,243]=-7.87064298483872e-001;
    __statist_i_h_wts[13,244]=3.28413476970828e-001;
    __statist_i_h_wts[13,245]=8.40702389059936e-001;
    __statist_i_h_wts[13,246]=-1.20152579498710e-002;
    __statist_i_h_wts[13,247]=7.18787542386008e-001;
    __statist_i_h_wts[13,248]=2.41483433307183e-001;

    __statist_i_h_wts[14,0]=5.79450463528785e-001;
    __statist_i_h_wts[14,1]=7.14252654579921e-001;
    __statist_i_h_wts[14,2]=7.53205450507431e-001;
    __statist_i_h_wts[14,3]=5.40807999920625e-001;
    __statist_i_h_wts[14,4]=3.27459088277081e-001;
    __statist_i_h_wts[14,5]=1.33942134878840e-001;
    __statist_i_h_wts[14,6]=3.08636115160801e-001;
    __statist_i_h_wts[14,7]=6.77387164381224e-002;
    __statist_i_h_wts[14,8]=-8.92735911355387e-002;
    __statist_i_h_wts[14,9]=-2.36715975141546e-001;
    __statist_i_h_wts[14,10]=-3.23016667038429e-002;
    __statist_i_h_wts[14,11]=-3.32076074893524e-001;
    __statist_i_h_wts[14,12]=-2.73748948677045e-001;
    __statist_i_h_wts[14,13]=-5.51800745220646e-001;
    __statist_i_h_wts[14,14]=-5.15251861686848e-001;
    __statist_i_h_wts[14,15]=4.29544742332830e-001;
    __statist_i_h_wts[14,16]=7.51960961542940e-001;
    __statist_i_h_wts[14,17]=8.00330258227682e-001;
    __statist_i_h_wts[14,18]=2.15784776733046e-001;
    __statist_i_h_wts[14,19]=1.16135287420893e-001;
    __statist_i_h_wts[14,20]=6.21559057917339e-002;
    __statist_i_h_wts[14,21]=3.20978981227104e-001;
    __statist_i_h_wts[14,22]=-8.13119145192432e-002;
    __statist_i_h_wts[14,23]=-6.83055101626368e-003;
    __statist_i_h_wts[14,24]=-1.65420905536739e-001;
    __statist_i_h_wts[14,25]=3.89786327504782e-002;
    __statist_i_h_wts[14,26]=-3.08248547621803e-001;
    __statist_i_h_wts[14,27]=-2.05611482331387e-001;
    __statist_i_h_wts[14,28]=-5.34644903769622e-001;
    __statist_i_h_wts[14,29]=-5.99494452833994e-001;
    __statist_i_h_wts[14,30]=4.46822104820961e-001;
    __statist_i_h_wts[14,31]=4.29603327501930e-001;
    __statist_i_h_wts[14,32]=6.61204263866973e-001;
    __statist_i_h_wts[14,33]=2.78543801267524e-001;
    __statist_i_h_wts[14,34]=8.86322319394552e-002;
    __statist_i_h_wts[14,35]=-9.16700261971339e-002;
    __statist_i_h_wts[14,36]=9.48046783069709e-002;
    __statist_i_h_wts[14,37]=-3.05572369706307e-002;
    __statist_i_h_wts[14,38]=8.73578862355034e-002;
    __statist_i_h_wts[14,39]=-4.01063428035128e-002;
    __statist_i_h_wts[14,40]=1.97218023936699e-001;
    __statist_i_h_wts[14,41]=-2.12738166700163e-001;
    __statist_i_h_wts[14,42]=-1.99210153189705e-001;
    __statist_i_h_wts[14,43]=-3.95440658183738e-001;
    __statist_i_h_wts[14,44]=-3.12989754440411e-001;
    __statist_i_h_wts[14,45]=1.06962139095502e+000;
    __statist_i_h_wts[14,46]=5.97447262459889e-001;
    __statist_i_h_wts[14,47]=9.86803011460170e-001;
    __statist_i_h_wts[14,48]=5.24241762936784e-001;
    __statist_i_h_wts[14,49]=2.84958738453572e-001;
    __statist_i_h_wts[14,50]=1.78811817141893e-001;
    __statist_i_h_wts[14,51]=3.56549219444784e-001;
    __statist_i_h_wts[14,52]=4.37550387222071e-002;
    __statist_i_h_wts[14,53]=1.97274929908915e-001;
    __statist_i_h_wts[14,54]=-8.39043338901035e-003;
    __statist_i_h_wts[14,55]=-7.92455286497353e-002;
    __statist_i_h_wts[14,56]=-2.82062361381610e-001;
    __statist_i_h_wts[14,57]=-3.64198943665818e-002;
    __statist_i_h_wts[14,58]=-4.95718625754502e-001;
    __statist_i_h_wts[14,59]=-4.93656915021017e-001;
    __statist_i_h_wts[14,60]=8.03192782578991e-001;
    __statist_i_h_wts[14,61]=5.50084933916019e-001;
    __statist_i_h_wts[14,62]=8.29820029784035e-001;
    __statist_i_h_wts[14,63]=6.31458974114200e-001;
    __statist_i_h_wts[14,64]=2.65875973538789e-001;
    __statist_i_h_wts[14,65]=3.76520796241942e-003;
    __statist_i_h_wts[14,66]=5.32425982070525e-001;
    __statist_i_h_wts[14,67]=1.26125031059231e-001;
    __statist_i_h_wts[14,68]=6.44002417524628e-002;
    __statist_i_h_wts[14,69]=-1.54129795024484e-001;
    __statist_i_h_wts[14,70]=2.42326225745616e-003;
    __statist_i_h_wts[14,71]=-3.09482103491503e-001;
    __statist_i_h_wts[14,72]=-3.59972564343071e-002;
    __statist_i_h_wts[14,73]=-5.42591095424124e-001;
    __statist_i_h_wts[14,74]=-4.33245566817579e-001;
    __statist_i_h_wts[14,75]=6.49960751697280e-001;
    __statist_i_h_wts[14,76]=4.63504028465999e-001;
    __statist_i_h_wts[14,77]=3.94739891249993e-001;
    __statist_i_h_wts[14,78]=6.29125956284315e-001;
    __statist_i_h_wts[14,79]=2.84995128389910e-001;
    __statist_i_h_wts[14,80]=3.39725871004570e-001;
    __statist_i_h_wts[14,81]=-4.77045869681629e-002;
    __statist_i_h_wts[14,82]=2.38366047987135e-001;
    __statist_i_h_wts[14,83]=-3.08814251485958e-001;
    __statist_i_h_wts[14,84]=-9.77847405878684e-002;
    __statist_i_h_wts[14,85]=-1.07212168047989e-001;
    __statist_i_h_wts[14,86]=-2.01387192443180e-001;
    __statist_i_h_wts[14,87]=-1.21271365360152e-001;
    __statist_i_h_wts[14,88]=-3.88950131236244e-001;
    __statist_i_h_wts[14,89]=-3.43406453268173e-001;
    __statist_i_h_wts[14,90]=7.26944542939784e-001;
    __statist_i_h_wts[14,91]=4.46900894841055e-001;
    __statist_i_h_wts[14,92]=6.06443000378175e-001;
    __statist_i_h_wts[14,93]=6.11354645459063e-001;
    __statist_i_h_wts[14,94]=8.99012638510638e-002;
    __statist_i_h_wts[14,95]=1.81891943005745e-001;
    __statist_i_h_wts[14,96]=-4.17461692904560e-002;
    __statist_i_h_wts[14,97]=3.90836754176910e-001;
    __statist_i_h_wts[14,98]=-4.20715429416102e-001;
    __statist_i_h_wts[14,99]=3.26861148221549e-002;
    __statist_i_h_wts[14,100]=-5.31007928682401e-002;
    __statist_i_h_wts[14,101]=-2.04203591773208e-001;
    __statist_i_h_wts[14,102]=-3.05588146936927e-005;
    __statist_i_h_wts[14,103]=-4.05724128123828e-001;
    __statist_i_h_wts[14,104]=-2.39863879898021e-001;
    __statist_i_h_wts[14,105]=4.74767737413656e-001;
    __statist_i_h_wts[14,106]=6.82284893105970e-001;
    __statist_i_h_wts[14,107]=6.04164707769719e-001;
    __statist_i_h_wts[14,108]=2.86690818010578e-001;
    __statist_i_h_wts[14,109]=2.65693286880332e-001;
    __statist_i_h_wts[14,110]=-1.47971197413747e-002;
    __statist_i_h_wts[14,111]=-2.45538953177474e-002;
    __statist_i_h_wts[14,112]=-3.31867460246478e-002;
    __statist_i_h_wts[14,113]=-2.58349568102876e-001;
    __statist_i_h_wts[14,114]=-7.23848148308621e-002;
    __statist_i_h_wts[14,115]=-1.42214185651240e-001;
    __statist_i_h_wts[14,116]=9.35203979731797e-002;
    __statist_i_h_wts[14,117]=1.76751179646616e-002;
    __statist_i_h_wts[14,118]=-3.33830059970522e-001;
    __statist_i_h_wts[14,119]=-2.88551899887755e-001;
    __statist_i_h_wts[14,120]=4.77016417829328e-001;
    __statist_i_h_wts[14,121]=6.77972048598343e-001;
    __statist_i_h_wts[14,122]=4.57338331797484e-001;
    __statist_i_h_wts[14,123]=5.65558491065785e-001;
    __statist_i_h_wts[14,124]=4.77367180305513e-001;
    __statist_i_h_wts[14,125]=4.02560465123400e-001;
    __statist_i_h_wts[14,126]=1.33724547936059e-002;
    __statist_i_h_wts[14,127]=-2.07297918621547e-001;
    __statist_i_h_wts[14,128]=2.44352729349709e-002;
    __statist_i_h_wts[14,129]=2.91632336822152e-003;
    __statist_i_h_wts[14,130]=-4.12277369715729e-001;
    __statist_i_h_wts[14,131]=-7.93718658056129e-002;
    __statist_i_h_wts[14,132]=-1.54501977830184e-002;
    __statist_i_h_wts[14,133]=-3.01562190669698e-001;
    __statist_i_h_wts[14,134]=-2.50737663337552e-001;
    __statist_i_h_wts[14,135]=3.84906335007179e-001;
    __statist_i_h_wts[14,136]=4.89491943046269e-001;
    __statist_i_h_wts[14,137]=3.87789423640433e-001;
    __statist_i_h_wts[14,138]=4.75348868268357e-001;
    __statist_i_h_wts[14,139]=3.74827204232025e-001;
    __statist_i_h_wts[14,140]=2.96041703771399e-001;
    __statist_i_h_wts[14,141]=-7.86503615001360e-002;
    __statist_i_h_wts[14,142]=-1.36467128378270e-001;
    __statist_i_h_wts[14,143]=-1.49178913461142e-001;
    __statist_i_h_wts[14,144]=2.13655649800147e-001;
    __statist_i_h_wts[14,145]=-2.71013612596094e-001;
    __statist_i_h_wts[14,146]=1.29172659068100e-002;
    __statist_i_h_wts[14,147]=-6.15593758522767e-002;
    __statist_i_h_wts[14,148]=-1.89544499579462e-001;
    __statist_i_h_wts[14,149]=-2.61965441139287e-001;
    __statist_i_h_wts[14,150]=3.15779287707834e-001;
    __statist_i_h_wts[14,151]=4.01620321181202e-001;
    __statist_i_h_wts[14,152]=2.68467868896811e-001;
    __statist_i_h_wts[14,153]=2.26725943845870e-001;
    __statist_i_h_wts[14,154]=2.99522349083205e-001;
    __statist_i_h_wts[14,155]=-8.77605990617339e-002;
    __statist_i_h_wts[14,156]=-2.01722184869966e-001;
    __statist_i_h_wts[14,157]=-2.71225293110145e-001;
    __statist_i_h_wts[14,158]=-8.49193263697247e-002;
    __statist_i_h_wts[14,159]=6.18873801704741e-003;
    __statist_i_h_wts[14,160]=-3.25666011347059e-001;
    __statist_i_h_wts[14,161]=-2.28976764559380e-001;
    __statist_i_h_wts[14,162]=-2.72032268194253e-001;
    __statist_i_h_wts[14,163]=-4.22605548431294e-001;
    __statist_i_h_wts[14,164]=-3.70852966433655e-001;
    __statist_i_h_wts[14,165]=2.42409513628099e-001;
    __statist_i_h_wts[14,166]=1.60195251829243e-001;
    __statist_i_h_wts[14,167]=1.42768089118461e-001;
    __statist_i_h_wts[14,168]=2.97843067168169e-001;
    __statist_i_h_wts[14,169]=2.44363265888690e-001;
    __statist_i_h_wts[14,170]=1.88863441741272e-001;
    __statist_i_h_wts[14,171]=5.18356832881648e-005;
    __statist_i_h_wts[14,172]=-1.39830955596232e-001;
    __statist_i_h_wts[14,173]=-7.13651493223845e-002;
    __statist_i_h_wts[14,174]=-6.25060944414561e-002;
    __statist_i_h_wts[14,175]=-2.18574252742710e-001;
    __statist_i_h_wts[14,176]=-1.96010150262104e-001;
    __statist_i_h_wts[14,177]=-3.44003699909767e-001;
    __statist_i_h_wts[14,178]=-3.25684565454477e-001;
    __statist_i_h_wts[14,179]=-3.85387701117306e-001;
    __statist_i_h_wts[14,180]=1.22631087717734e-001;
    __statist_i_h_wts[14,181]=1.49260030954363e-001;
    __statist_i_h_wts[14,182]=1.27751125095675e-001;
    __statist_i_h_wts[14,183]=2.88158657035289e-001;
    __statist_i_h_wts[14,184]=3.47814450929428e-001;
    __statist_i_h_wts[14,185]=-6.44202236206298e-003;
    __statist_i_h_wts[14,186]=-4.66702603596132e-002;
    __statist_i_h_wts[14,187]=-7.98136434214016e-002;
    __statist_i_h_wts[14,188]=-2.08744125148665e-002;
    __statist_i_h_wts[14,189]=-1.41368211991763e-001;
    __statist_i_h_wts[14,190]=-1.67301530604516e-001;
    __statist_i_h_wts[14,191]=-2.38767561341269e-001;
    __statist_i_h_wts[14,192]=-2.51667723915289e-001;
    __statist_i_h_wts[14,193]=-3.32315853131356e-001;
    __statist_i_h_wts[14,194]=-3.59807031293103e-001;
    __statist_i_h_wts[14,195]=9.68462019714254e-002;
    __statist_i_h_wts[14,196]=7.22667272196883e-002;
    __statist_i_h_wts[14,197]=6.68118016507439e-002;
    __statist_i_h_wts[14,198]=2.46974042053068e-002;
    __statist_i_h_wts[14,199]=1.09049695264554e-001;
    __statist_i_h_wts[14,200]=2.97494452594349e-002;
    __statist_i_h_wts[14,201]=-3.23041670363475e-002;
    __statist_i_h_wts[14,202]=-4.08986440574139e-002;
    __statist_i_h_wts[14,203]=-1.06819445426938e-001;
    __statist_i_h_wts[14,204]=-2.39423954516624e-001;
    __statist_i_h_wts[14,205]=-3.48262225170445e-001;
    __statist_i_h_wts[14,206]=-3.22004974100106e-001;
    __statist_i_h_wts[14,207]=-4.45588777645885e-001;
    __statist_i_h_wts[14,208]=-4.82975007211647e-001;
    __statist_i_h_wts[14,209]=-4.36161130163273e-001;
    __statist_i_h_wts[14,210]=-2.70483091312753e-001;
    __statist_i_h_wts[14,211]=-1.56889413656991e-001;
    __statist_i_h_wts[14,212]=-2.37541712662023e-001;
    __statist_i_h_wts[14,213]=-2.34817668153005e-001;
    __statist_i_h_wts[14,214]=-2.09103179240382e-001;
    __statist_i_h_wts[14,215]=-1.05125051376681e-001;
    __statist_i_h_wts[14,216]=-1.51440815647579e-001;
    __statist_i_h_wts[14,217]=-1.60848617600023e-001;
    __statist_i_h_wts[14,218]=9.36457638953873e-002;
    __statist_i_h_wts[14,219]=-1.24451629420879e-001;
    __statist_i_h_wts[14,220]=-2.56258974434746e-001;
    __statist_i_h_wts[14,221]=-2.29864246699449e-001;
    __statist_i_h_wts[14,222]=-4.03415274375141e-001;
    __statist_i_h_wts[14,223]=-4.43159233446603e-001;
    __statist_i_h_wts[14,224]=-3.45213531142236e-001;
    __statist_i_h_wts[14,225]=1.45505945418294e-001;
    __statist_i_h_wts[14,226]=1.33760553428671e+000;
    __statist_i_h_wts[14,227]=3.82363886229727e-001;
    __statist_i_h_wts[14,228]=1.13832773219813e+000;
    __statist_i_h_wts[14,229]=5.88908482389886e-001;
    __statist_i_h_wts[14,230]=-9.10484668936077e-001;
    __statist_i_h_wts[14,231]=4.42724812072519e-001;
    __statist_i_h_wts[14,232]=-2.01806185314219e+000;
    __statist_i_h_wts[14,233]=-8.21806096153260e-001;
    __statist_i_h_wts[14,234]=-6.46265118132167e-001;
    __statist_i_h_wts[14,235]=5.26204502363675e-001;
    __statist_i_h_wts[14,236]=3.10951927495493e+000;
    __statist_i_h_wts[14,237]=-2.22172883335598e-002;
    __statist_i_h_wts[14,238]=-3.25628770052825e-001;
    __statist_i_h_wts[14,239]=-5.98055307103978e-001;
    __statist_i_h_wts[14,240]=8.23431933394790e-001;
    __statist_i_h_wts[14,241]=-1.47104846961951e+000;
    __statist_i_h_wts[14,242]=-4.04973874749297e-001;
    __statist_i_h_wts[14,243]=-8.65678976560534e-001;
    __statist_i_h_wts[14,244]=-1.66303278795715e-001;
    __statist_i_h_wts[14,245]=1.05883094678720e+000;
    __statist_i_h_wts[14,246]=-1.61843266925879e-001;
    __statist_i_h_wts[14,247]=6.04749866948635e-001;
    __statist_i_h_wts[14,248]=-7.71813423673845e-001;

    __statist_i_h_wts[15,0]=1.55620035595936e-001;
    __statist_i_h_wts[15,1]=-2.64350236910767e-001;
    __statist_i_h_wts[15,2]=-5.51778364569689e-001;
    __statist_i_h_wts[15,3]=-1.39631278637940e-001;
    __statist_i_h_wts[15,4]=-4.01045139785877e-001;
    __statist_i_h_wts[15,5]=-5.80450443496863e-001;
    __statist_i_h_wts[15,6]=5.36844476174731e-002;
    __statist_i_h_wts[15,7]=7.43475060925403e-002;
    __statist_i_h_wts[15,8]=5.97027112365710e-002;
    __statist_i_h_wts[15,9]=1.11658219675079e-001;
    __statist_i_h_wts[15,10]=7.08276264053750e-003;
    __statist_i_h_wts[15,11]=-3.08270960946226e-001;
    __statist_i_h_wts[15,12]=4.19256878344149e-002;
    __statist_i_h_wts[15,13]=-1.38327446137222e-001;
    __statist_i_h_wts[15,14]=-3.26379265291553e-001;
    __statist_i_h_wts[15,15]=3.29668220158377e-001;
    __statist_i_h_wts[15,16]=9.47364733070744e-002;
    __statist_i_h_wts[15,17]=-2.62769707924444e-001;
    __statist_i_h_wts[15,18]=-2.84156665823720e-001;
    __statist_i_h_wts[15,19]=-5.49982695901901e-001;
    __statist_i_h_wts[15,20]=-4.44521802228522e-001;
    __statist_i_h_wts[15,21]=1.84920810114117e-001;
    __statist_i_h_wts[15,22]=-1.80419101115636e-001;
    __statist_i_h_wts[15,23]=1.74287049028914e-001;
    __statist_i_h_wts[15,24]=4.15890207534391e-001;
    __statist_i_h_wts[15,25]=2.88029358795776e-001;
    __statist_i_h_wts[15,26]=-2.44356346319100e-002;
    __statist_i_h_wts[15,27]=6.40600827029076e-002;
    __statist_i_h_wts[15,28]=-2.85085264174801e-001;
    __statist_i_h_wts[15,29]=-3.98222322174934e-001;
    __statist_i_h_wts[15,30]=4.56433973959292e-001;
    __statist_i_h_wts[15,31]=2.26270750793065e-001;
    __statist_i_h_wts[15,32]=3.58904729132905e-002;
    __statist_i_h_wts[15,33]=-1.35724021289130e-001;
    __statist_i_h_wts[15,34]=-3.92538633231626e-001;
    __statist_i_h_wts[15,35]=-4.31275427929242e-001;
    __statist_i_h_wts[15,36]=-3.69435769617259e-001;
    __statist_i_h_wts[15,37]=-2.99099284354605e-001;
    __statist_i_h_wts[15,38]=-2.85925822950039e-001;
    __statist_i_h_wts[15,39]=-3.96498866500493e-001;
    __statist_i_h_wts[15,40]=1.59651348614149e-002;
    __statist_i_h_wts[15,41]=-1.42987529985858e-001;
    __statist_i_h_wts[15,42]=-2.75862910014390e-001;
    __statist_i_h_wts[15,43]=-3.24626145154678e-001;
    __statist_i_h_wts[15,44]=-1.07489453260723e-001;
    __statist_i_h_wts[15,45]=-1.56202749471445e-001;
    __statist_i_h_wts[15,46]=1.36126706845331e-001;
    __statist_i_h_wts[15,47]=2.23847021210819e-001;
    __statist_i_h_wts[15,48]=1.24264415605480e-001;
    __statist_i_h_wts[15,49]=3.25817572469375e-001;
    __statist_i_h_wts[15,50]=-1.91028303775402e-001;
    __statist_i_h_wts[15,51]=-7.61775268391350e-002;
    __statist_i_h_wts[15,52]=-2.70142061766849e-001;
    __statist_i_h_wts[15,53]=8.68336652184380e-002;
    __statist_i_h_wts[15,54]=-5.08038743021682e-001;
    __statist_i_h_wts[15,55]=5.56093196506435e-002;
    __statist_i_h_wts[15,56]=2.92368421284964e-001;
    __statist_i_h_wts[15,57]=1.79980482682006e-001;
    __statist_i_h_wts[15,58]=1.79514598474651e-001;
    __statist_i_h_wts[15,59]=2.51763600335456e-001;
    __statist_i_h_wts[15,60]=1.97907978259174e-001;
    __statist_i_h_wts[15,61]=-3.26770474477088e-001;
    __statist_i_h_wts[15,62]=-4.85213661922835e-001;
    __statist_i_h_wts[15,63]=-2.53236463666539e-001;
    __statist_i_h_wts[15,64]=-2.66712358138343e-002;
    __statist_i_h_wts[15,65]=-4.10261787214162e-001;
    __statist_i_h_wts[15,66]=1.00163341493007e-001;
    __statist_i_h_wts[15,67]=7.89697707619854e-002;
    __statist_i_h_wts[15,68]=5.13924130603169e-002;
    __statist_i_h_wts[15,69]=-2.14805672918459e-001;
    __statist_i_h_wts[15,70]=1.64958437960688e-001;
    __statist_i_h_wts[15,71]=1.54441177081470e-001;
    __statist_i_h_wts[15,72]=2.71575517092869e-001;
    __statist_i_h_wts[15,73]=3.31428915160776e-001;
    __statist_i_h_wts[15,74]=5.08932391554176e-001;
    __statist_i_h_wts[15,75]=-1.64137084628495e-002;
    __statist_i_h_wts[15,76]=-4.12462679667917e-001;
    __statist_i_h_wts[15,77]=-6.29785519382170e-001;
    __statist_i_h_wts[15,78]=-2.77345451644687e-001;
    __statist_i_h_wts[15,79]=-3.40021098315952e-001;
    __statist_i_h_wts[15,80]=3.48894746864606e-002;
    __statist_i_h_wts[15,81]=1.04329862260775e-001;
    __statist_i_h_wts[15,82]=2.11860417459070e-001;
    __statist_i_h_wts[15,83]=4.38504663227016e-002;
    __statist_i_h_wts[15,84]=-6.47690267383921e-001;
    __statist_i_h_wts[15,85]=-3.46242245705125e-001;
    __statist_i_h_wts[15,86]=-5.65684367583663e-001;
    __statist_i_h_wts[15,87]=-4.00937729864208e-001;
    __statist_i_h_wts[15,88]=-9.82382369391711e-002;
    __statist_i_h_wts[15,89]=1.68708064272979e-001;
    __statist_i_h_wts[15,90]=3.83106463000414e-001;
    __statist_i_h_wts[15,91]=-4.08270359606355e-002;
    __statist_i_h_wts[15,92]=-2.78891005753014e-001;
    __statist_i_h_wts[15,93]=6.14230184061855e-002;
    __statist_i_h_wts[15,94]=-8.96321605603054e-002;
    __statist_i_h_wts[15,95]=-3.19681802584817e-001;
    __statist_i_h_wts[15,96]=-7.66466085139558e-001;
    __statist_i_h_wts[15,97]=-2.85525373970784e-001;
    __statist_i_h_wts[15,98]=2.02152580449127e-001;
    __statist_i_h_wts[15,99]=-7.51335031162591e-002;
    __statist_i_h_wts[15,100]=-3.47587501298670e-001;
    __statist_i_h_wts[15,101]=-2.16818602431782e-001;
    __statist_i_h_wts[15,102]=5.10131962448687e-002;
    __statist_i_h_wts[15,103]=-1.26732003857025e-001;
    __statist_i_h_wts[15,104]=9.99343832228568e-002;
    __statist_i_h_wts[15,105]=-4.47247566602701e-002;
    __statist_i_h_wts[15,106]=7.41109827600961e-002;
    __statist_i_h_wts[15,107]=-3.91853179534555e-001;
    __statist_i_h_wts[15,108]=-2.04745457043159e-001;
    __statist_i_h_wts[15,109]=-1.93694434942057e-001;
    __statist_i_h_wts[15,110]=-4.77652473706334e-001;
    __statist_i_h_wts[15,111]=-6.37926475296030e-001;
    __statist_i_h_wts[15,112]=-5.45176356918662e-001;
    __statist_i_h_wts[15,113]=2.58911774507756e-001;
    __statist_i_h_wts[15,114]=6.94710861124369e-003;
    __statist_i_h_wts[15,115]=4.47015608544688e-001;
    __statist_i_h_wts[15,116]=5.29333633298697e-001;
    __statist_i_h_wts[15,117]=2.58050798258602e-001;
    __statist_i_h_wts[15,118]=1.60031340127339e-001;
    __statist_i_h_wts[15,119]=1.33102115489527e-001;
    __statist_i_h_wts[15,120]=-2.63232961234456e-001;
    __statist_i_h_wts[15,121]=-4.53869674553295e-001;
    __statist_i_h_wts[15,122]=-1.66047570134872e-001;
    __statist_i_h_wts[15,123]=-7.41141946209041e-001;
    __statist_i_h_wts[15,124]=-2.25903420524326e-001;
    __statist_i_h_wts[15,125]=-2.01321805475116e-001;
    __statist_i_h_wts[15,126]=-5.31826270853796e-001;
    __statist_i_h_wts[15,127]=-5.08586071773399e-001;
    __statist_i_h_wts[15,128]=3.77677256841817e-001;
    __statist_i_h_wts[15,129]=-4.26012868023006e-001;
    __statist_i_h_wts[15,130]=4.34536476056809e-001;
    __statist_i_h_wts[15,131]=2.22969581685267e-001;
    __statist_i_h_wts[15,132]=2.39935305253916e-001;
    __statist_i_h_wts[15,133]=9.40423204475337e-002;
    __statist_i_h_wts[15,134]=9.30358943408063e-002;
    __statist_i_h_wts[15,135]=1.75338644884186e-001;
    __statist_i_h_wts[15,136]=6.23973474314849e-002;
    __statist_i_h_wts[15,137]=-2.69919286732672e-001;
    __statist_i_h_wts[15,138]=-4.27842046435049e-002;
    __statist_i_h_wts[15,139]=9.21624135382440e-002;
    __statist_i_h_wts[15,140]=-3.15555752494629e-001;
    __statist_i_h_wts[15,141]=-5.18187702330278e-001;
    __statist_i_h_wts[15,142]=3.74209785733948e-002;
    __statist_i_h_wts[15,143]=3.74521851604610e-001;
    __statist_i_h_wts[15,144]=3.34489182978936e-001;
    __statist_i_h_wts[15,145]=1.39221524623050e-001;
    __statist_i_h_wts[15,146]=2.60589092270538e-001;
    __statist_i_h_wts[15,147]=2.08749668373588e-001;
    __statist_i_h_wts[15,148]=9.46888618396616e-002;
    __statist_i_h_wts[15,149]=2.61839242215600e-002;
    __statist_i_h_wts[15,150]=9.95888183036150e-002;
    __statist_i_h_wts[15,151]=1.65582028218020e-001;
    __statist_i_h_wts[15,152]=1.87219888420009e-001;
    __statist_i_h_wts[15,153]=5.36390293996406e-001;
    __statist_i_h_wts[15,154]=8.31616153973927e-002;
    __statist_i_h_wts[15,155]=-6.42037144807647e-002;
    __statist_i_h_wts[15,156]=-1.12712104319576e-001;
    __statist_i_h_wts[15,157]=1.70068886310894e-001;
    __statist_i_h_wts[15,158]=3.21446814549279e-001;
    __statist_i_h_wts[15,159]=4.36948912688582e-001;
    __statist_i_h_wts[15,160]=-1.20195708927699e-001;
    __statist_i_h_wts[15,161]=-5.10070336672026e-002;
    __statist_i_h_wts[15,162]=-2.55092460902164e-002;
    __statist_i_h_wts[15,163]=-6.02956206262659e-002;
    __statist_i_h_wts[15,164]=-4.47533458214074e-002;
    __statist_i_h_wts[15,165]=-2.21986883581963e-001;
    __statist_i_h_wts[15,166]=2.78657271832139e-001;
    __statist_i_h_wts[15,167]=3.81966471153184e-001;
    __statist_i_h_wts[15,168]=-2.16804111088161e-001;
    __statist_i_h_wts[15,169]=-4.27559903790423e-001;
    __statist_i_h_wts[15,170]=-4.17033235743565e-001;
    __statist_i_h_wts[15,171]=-2.73421011291343e-001;
    __statist_i_h_wts[15,172]=1.94388597574527e-001;
    __statist_i_h_wts[15,173]=2.47201066364331e-001;
    __statist_i_h_wts[15,174]=-1.38832419691134e-002;
    __statist_i_h_wts[15,175]=-2.74777158433121e-001;
    __statist_i_h_wts[15,176]=-5.00563138988429e-001;
    __statist_i_h_wts[15,177]=9.74619608728588e-002;
    __statist_i_h_wts[15,178]=2.49627493591568e-002;
    __statist_i_h_wts[15,179]=-7.73211310634607e-002;
    __statist_i_h_wts[15,180]=3.95753307354991e-001;
    __statist_i_h_wts[15,181]=5.97187973894302e-001;
    __statist_i_h_wts[15,182]=-2.40536250282860e-001;
    __statist_i_h_wts[15,183]=-6.14000198002766e-001;
    __statist_i_h_wts[15,184]=-3.88108879882122e-001;
    __statist_i_h_wts[15,185]=1.83411504481884e-001;
    __statist_i_h_wts[15,186]=1.14605260289464e-001;
    __statist_i_h_wts[15,187]=3.25419858040928e-002;
    __statist_i_h_wts[15,188]=7.49913803830237e-002;
    __statist_i_h_wts[15,189]=1.23872014859600e-001;
    __statist_i_h_wts[15,190]=-2.09840635427753e-001;
    __statist_i_h_wts[15,191]=-5.63418260983107e-001;
    __statist_i_h_wts[15,192]=8.20964082178569e-002;
    __statist_i_h_wts[15,193]=-8.23073810988172e-002;
    __statist_i_h_wts[15,194]=-4.54630334005067e-002;
    __statist_i_h_wts[15,195]=8.53883826357122e-003;
    __statist_i_h_wts[15,196]=1.87829751189220e-001;
    __statist_i_h_wts[15,197]=-1.34404983549924e-001;
    __statist_i_h_wts[15,198]=-2.47309553711513e-001;
    __statist_i_h_wts[15,199]=-1.08023133901395e-002;
    __statist_i_h_wts[15,200]=-6.10200433315175e-002;
    __statist_i_h_wts[15,201]=-2.95536421572688e-001;
    __statist_i_h_wts[15,202]=5.45057733223050e-002;
    __statist_i_h_wts[15,203]=-2.95208459039650e-001;
    __statist_i_h_wts[15,204]=-2.24748595521486e-002;
    __statist_i_h_wts[15,205]=-4.16254252687699e-001;
    __statist_i_h_wts[15,206]=-2.06701924581153e-001;
    __statist_i_h_wts[15,207]=1.01848287980028e-002;
    __statist_i_h_wts[15,208]=-1.59074239300369e-001;
    __statist_i_h_wts[15,209]=-4.21142506602837e-001;
    __statist_i_h_wts[15,210]=-2.46926542134976e-002;
    __statist_i_h_wts[15,211]=1.96365062900549e-001;
    __statist_i_h_wts[15,212]=3.04894080002772e-001;
    __statist_i_h_wts[15,213]=-2.66463567267428e-001;
    __statist_i_h_wts[15,214]=-2.92410240126866e-001;
    __statist_i_h_wts[15,215]=-4.91854254145532e-001;
    __statist_i_h_wts[15,216]=-5.77637023146656e-002;
    __statist_i_h_wts[15,217]=3.83816536084260e-001;
    __statist_i_h_wts[15,218]=1.31270177708147e-001;
    __statist_i_h_wts[15,219]=3.51997333568860e-001;
    __statist_i_h_wts[15,220]=2.09000831723722e-001;
    __statist_i_h_wts[15,221]=-1.33952067584626e-001;
    __statist_i_h_wts[15,222]=6.93349648127846e-002;
    __statist_i_h_wts[15,223]=-1.38841456807366e-001;
    __statist_i_h_wts[15,224]=-4.48127321741631e-001;
    __statist_i_h_wts[15,225]=2.98413724910793e-001;
    __statist_i_h_wts[15,226]=2.97410120961072e-003;
    __statist_i_h_wts[15,227]=6.18435171442306e-002;
    __statist_i_h_wts[15,228]=-7.55264283357832e-002;
    __statist_i_h_wts[15,229]=-7.95406790075847e-002;
    __statist_i_h_wts[15,230]=-2.39354926686795e-001;
    __statist_i_h_wts[15,231]=-2.97241607344639e-002;
    __statist_i_h_wts[15,232]=-1.34751548632900e+000;
    __statist_i_h_wts[15,233]=-2.17062995757520e-001;
    __statist_i_h_wts[15,234]=6.27473827456933e-002;
    __statist_i_h_wts[15,235]=6.67056572480659e-001;
    __statist_i_h_wts[15,236]=3.14986929063767e+000;
    __statist_i_h_wts[15,237]=-1.35806726482142e+000;
    __statist_i_h_wts[15,238]=-8.15715558518577e-001;
    __statist_i_h_wts[15,239]=-4.89642974132996e-001;
    __statist_i_h_wts[15,240]=2.31737605147151e-001;
    __statist_i_h_wts[15,241]=-9.05470405167982e-001;
    __statist_i_h_wts[15,242]=-4.51436695525990e-001;
    __statist_i_h_wts[15,243]=-3.61786096722340e-001;
    __statist_i_h_wts[15,244]=3.26919211109739e-001;
    __statist_i_h_wts[15,245]=5.65355449038180e-001;
    __statist_i_h_wts[15,246]=1.13510806275490e+000;
    __statist_i_h_wts[15,247]=1.93619150071655e-001;
    __statist_i_h_wts[15,248]=6.78873009786603e-002;

    __statist_i_h_wts[16,0]=2.98915107603717e-001;
    __statist_i_h_wts[16,1]=2.76857333186894e-001;
    __statist_i_h_wts[16,2]=2.57248665764901e-001;
    __statist_i_h_wts[16,3]=1.22665024829867e-001;
    __statist_i_h_wts[16,4]=3.90133042257025e-002;
    __statist_i_h_wts[16,5]=-6.54681876463701e-002;
    __statist_i_h_wts[16,6]=-3.61293238576465e-002;
    __statist_i_h_wts[16,7]=-3.72464821897167e-002;
    __statist_i_h_wts[16,8]=-2.89319646355617e-001;
    __statist_i_h_wts[16,9]=-3.08876503902520e-001;
    __statist_i_h_wts[16,10]=-2.62035053602610e-001;
    __statist_i_h_wts[16,11]=-4.90832975161199e-001;
    __statist_i_h_wts[16,12]=-3.73790766517043e-001;
    __statist_i_h_wts[16,13]=-5.44020266349869e-001;
    __statist_i_h_wts[16,14]=-6.88310196804002e-001;
    __statist_i_h_wts[16,15]=3.47907346066600e-001;
    __statist_i_h_wts[16,16]=3.54812488091592e-001;
    __statist_i_h_wts[16,17]=3.46268180923480e-001;
    __statist_i_h_wts[16,18]=1.78169570405730e-001;
    __statist_i_h_wts[16,19]=1.13673019439028e-001;
    __statist_i_h_wts[16,20]=1.59306904216714e-002;
    __statist_i_h_wts[16,21]=8.61357401280824e-002;
    __statist_i_h_wts[16,22]=7.19606196785380e-002;
    __statist_i_h_wts[16,23]=-7.20143207923981e-002;
    __statist_i_h_wts[16,24]=-9.46863136392052e-002;
    __statist_i_h_wts[16,25]=-8.26788659820571e-002;
    __statist_i_h_wts[16,26]=-2.77162868601897e-001;
    __statist_i_h_wts[16,27]=-2.16106177082001e-001;
    __statist_i_h_wts[16,28]=-4.26094987080430e-001;
    __statist_i_h_wts[16,29]=-5.41600515643681e-001;
    __statist_i_h_wts[16,30]=4.81997810129473e-001;
    __statist_i_h_wts[16,31]=4.00032113573317e-001;
    __statist_i_h_wts[16,32]=4.08195936934628e-001;
    __statist_i_h_wts[16,33]=2.21402936423217e-001;
    __statist_i_h_wts[16,34]=2.10583245586119e-001;
    __statist_i_h_wts[16,35]=1.66505095660956e-001;
    __statist_i_h_wts[16,36]=1.97515856313961e-001;
    __statist_i_h_wts[16,37]=1.49359871173286e-001;
    __statist_i_h_wts[16,38]=9.68605018611202e-002;
    __statist_i_h_wts[16,39]=2.86047910803661e-002;
    __statist_i_h_wts[16,40]=4.28536939277853e-003;
    __statist_i_h_wts[16,41]=-2.10218859527291e-001;
    __statist_i_h_wts[16,42]=-1.75568410844654e-001;
    __statist_i_h_wts[16,43]=-3.53974634221604e-001;
    __statist_i_h_wts[16,44]=-4.31492498937283e-001;
    __statist_i_h_wts[16,45]=5.15940971199147e-001;
    __statist_i_h_wts[16,46]=4.36872817020238e-001;
    __statist_i_h_wts[16,47]=4.06554373502600e-001;
    __statist_i_h_wts[16,48]=3.03074966437777e-001;
    __statist_i_h_wts[16,49]=3.15777991331766e-001;
    __statist_i_h_wts[16,50]=3.12411965111863e-001;
    __statist_i_h_wts[16,51]=2.05344411361378e-001;
    __statist_i_h_wts[16,52]=1.12434311985565e-001;
    __statist_i_h_wts[16,53]=3.12612223083479e-002;
    __statist_i_h_wts[16,54]=-9.01774792409440e-002;
    __statist_i_h_wts[16,55]=-1.91232158220879e-001;
    __statist_i_h_wts[16,56]=-3.56523825340011e-001;
    __statist_i_h_wts[16,57]=-2.89215137383081e-001;
    __statist_i_h_wts[16,58]=-3.56967486417801e-001;
    __statist_i_h_wts[16,59]=-4.20663378401652e-001;
    __statist_i_h_wts[16,60]=4.79224607890151e-001;
    __statist_i_h_wts[16,61]=4.05696420502270e-001;
    __statist_i_h_wts[16,62]=3.82641065545000e-001;
    __statist_i_h_wts[16,63]=3.10350380285708e-001;
    __statist_i_h_wts[16,64]=3.07280429380925e-001;
    __statist_i_h_wts[16,65]=3.05515533150389e-001;
    __statist_i_h_wts[16,66]=2.08861723642385e-001;
    __statist_i_h_wts[16,67]=-5.24149723905421e-002;
    __statist_i_h_wts[16,68]=2.02168326393970e-002;
    __statist_i_h_wts[16,69]=-9.76826346488731e-002;
    __statist_i_h_wts[16,70]=-2.75010492491887e-001;
    __statist_i_h_wts[16,71]=-3.90312243349716e-001;
    __statist_i_h_wts[16,72]=-4.09309723059639e-001;
    __statist_i_h_wts[16,73]=-4.58106047914544e-001;
    __statist_i_h_wts[16,74]=-4.49554519993042e-001;
    __statist_i_h_wts[16,75]=4.18090745153187e-001;
    __statist_i_h_wts[16,76]=4.29519005252507e-001;
    __statist_i_h_wts[16,77]=3.66914857208624e-001;
    __statist_i_h_wts[16,78]=3.69337866285268e-001;
    __statist_i_h_wts[16,79]=3.61292240933320e-001;
    __statist_i_h_wts[16,80]=3.32410518970060e-001;
    __statist_i_h_wts[16,81]=1.68015556971271e-001;
    __statist_i_h_wts[16,82]=5.74918837795878e-002;
    __statist_i_h_wts[16,83]=9.02195464601656e-002;
    __statist_i_h_wts[16,84]=3.02705140416379e-002;
    __statist_i_h_wts[16,85]=-1.53825696098631e-001;
    __statist_i_h_wts[16,86]=-3.15944317320238e-001;
    __statist_i_h_wts[16,87]=-3.93247440176765e-001;
    __statist_i_h_wts[16,88]=-4.74088170793669e-001;
    __statist_i_h_wts[16,89]=-3.68980541865845e-001;
    __statist_i_h_wts[16,90]=4.73090579227202e-001;
    __statist_i_h_wts[16,91]=4.26399966557854e-001;
    __statist_i_h_wts[16,92]=4.07575751547685e-001;
    __statist_i_h_wts[16,93]=3.96948819529366e-001;
    __statist_i_h_wts[16,94]=3.97643752193423e-001;
    __statist_i_h_wts[16,95]=3.36981717445571e-001;
    __statist_i_h_wts[16,96]=1.23781838011379e-001;
    __statist_i_h_wts[16,97]=-6.55020755955607e-003;
    __statist_i_h_wts[16,98]=5.80285813361896e-002;
    __statist_i_h_wts[16,99]=-3.01849652359462e-002;
    __statist_i_h_wts[16,100]=-4.94756077596438e-002;
    __statist_i_h_wts[16,101]=-1.09657541152316e-001;
    __statist_i_h_wts[16,102]=-3.27888634316435e-001;
    __statist_i_h_wts[16,103]=-3.62843533120990e-001;
    __statist_i_h_wts[16,104]=-5.28937936376828e-001;
    __statist_i_h_wts[16,105]=4.39936211907248e-001;
    __statist_i_h_wts[16,106]=4.44371203922882e-001;
    __statist_i_h_wts[16,107]=4.11829757717882e-001;
    __statist_i_h_wts[16,108]=3.88583140067568e-001;
    __statist_i_h_wts[16,109]=3.21602032550181e-001;
    __statist_i_h_wts[16,110]=2.03828302625559e-001;
    __statist_i_h_wts[16,111]=-4.15253233186742e-002;
    __statist_i_h_wts[16,112]=-1.75312063971242e-001;
    __statist_i_h_wts[16,113]=-2.14678619452083e-001;
    __statist_i_h_wts[16,114]=-2.00671645089915e-001;
    __statist_i_h_wts[16,115]=-1.58493818309284e-001;
    __statist_i_h_wts[16,116]=-1.52509630812148e-001;
    __statist_i_h_wts[16,117]=-3.86073491481120e-001;
    __statist_i_h_wts[16,118]=-4.43594873100175e-001;
    __statist_i_h_wts[16,119]=-5.98829844473202e-001;
    __statist_i_h_wts[16,120]=3.64028709159749e-001;
    __statist_i_h_wts[16,121]=2.96164314803627e-001;
    __statist_i_h_wts[16,122]=3.03287968638482e-001;
    __statist_i_h_wts[16,123]=2.76198834202381e-001;
    __statist_i_h_wts[16,124]=2.22824328205559e-001;
    __statist_i_h_wts[16,125]=5.19336409390663e-002;
    __statist_i_h_wts[16,126]=-9.55775134592473e-002;
    __statist_i_h_wts[16,127]=-3.21498411296039e-001;
    __statist_i_h_wts[16,128]=-1.82297183050356e-001;
    __statist_i_h_wts[16,129]=-2.61353151398064e-001;
    __statist_i_h_wts[16,130]=-3.24084910900433e-001;
    __statist_i_h_wts[16,131]=-2.85231563245074e-001;
    __statist_i_h_wts[16,132]=-4.25170554661719e-001;
    __statist_i_h_wts[16,133]=-4.06789520982240e-001;
    __statist_i_h_wts[16,134]=-5.32656183294825e-001;
    __statist_i_h_wts[16,135]=2.84764768173787e-001;
    __statist_i_h_wts[16,136]=1.80684909032130e-001;
    __statist_i_h_wts[16,137]=2.27784448663291e-001;
    __statist_i_h_wts[16,138]=2.43126872124558e-001;
    __statist_i_h_wts[16,139]=1.54255738826136e-001;
    __statist_i_h_wts[16,140]=7.12338580922557e-002;
    __statist_i_h_wts[16,141]=-8.77403140285417e-002;
    __statist_i_h_wts[16,142]=-2.67039082159469e-001;
    __statist_i_h_wts[16,143]=-1.90682193885990e-001;
    __statist_i_h_wts[16,144]=-2.89778469088401e-001;
    __statist_i_h_wts[16,145]=-3.32792697043749e-001;
    __statist_i_h_wts[16,146]=-3.40661088820800e-001;
    __statist_i_h_wts[16,147]=-4.53951554183466e-001;
    __statist_i_h_wts[16,148]=-4.05513044451702e-001;
    __statist_i_h_wts[16,149]=-6.11889944122913e-001;
    __statist_i_h_wts[16,150]=2.72246826249449e-001;
    __statist_i_h_wts[16,151]=2.08541409965693e-001;
    __statist_i_h_wts[16,152]=2.23361982034383e-001;
    __statist_i_h_wts[16,153]=1.39386132699219e-001;
    __statist_i_h_wts[16,154]=2.38508182251784e-002;
    __statist_i_h_wts[16,155]=-8.58067189162332e-002;
    __statist_i_h_wts[16,156]=-2.35711580658991e-001;
    __statist_i_h_wts[16,157]=-3.14531733632930e-001;
    __statist_i_h_wts[16,158]=-1.81379489742119e-001;
    __statist_i_h_wts[16,159]=-2.59875297456322e-001;
    __statist_i_h_wts[16,160]=-2.52382239662136e-001;
    __statist_i_h_wts[16,161]=-2.28193214898417e-001;
    __statist_i_h_wts[16,162]=-4.05256538544398e-001;
    __statist_i_h_wts[16,163]=-3.62611913498591e-001;
    __statist_i_h_wts[16,164]=-5.47553628770746e-001;
    __statist_i_h_wts[16,165]=8.87663852085779e-002;
    __statist_i_h_wts[16,166]=5.13925014255707e-002;
    __statist_i_h_wts[16,167]=1.13856796202878e-001;
    __statist_i_h_wts[16,168]=-4.12679212576704e-002;
    __statist_i_h_wts[16,169]=-8.24530259469482e-002;
    __statist_i_h_wts[16,170]=-2.09307063898947e-001;
    __statist_i_h_wts[16,171]=-3.11472900920551e-001;
    __statist_i_h_wts[16,172]=-2.46194976161657e-001;
    __statist_i_h_wts[16,173]=-8.09180769390905e-002;
    __statist_i_h_wts[16,174]=-6.34492728783351e-002;
    __statist_i_h_wts[16,175]=-2.89576920389285e-002;
    __statist_i_h_wts[16,176]=-3.10375496864715e-001;
    __statist_i_h_wts[16,177]=-4.34455571597617e-001;
    __statist_i_h_wts[16,178]=-3.36161501846689e-001;
    __statist_i_h_wts[16,179]=-4.92182457591057e-001;
    __statist_i_h_wts[16,180]=3.64381524145100e-002;
    __statist_i_h_wts[16,181]=5.99856111391096e-003;
    __statist_i_h_wts[16,182]=3.45760711693373e-002;
    __statist_i_h_wts[16,183]=-8.83725973076436e-002;
    __statist_i_h_wts[16,184]=-3.65255413585741e-002;
    __statist_i_h_wts[16,185]=-1.99257370336525e-001;
    __statist_i_h_wts[16,186]=-2.80850430743225e-001;
    __statist_i_h_wts[16,187]=-2.37477511317909e-001;
    __statist_i_h_wts[16,188]=-1.73021760625495e-001;
    __statist_i_h_wts[16,189]=-1.95131562314492e-001;
    __statist_i_h_wts[16,190]=-2.12622446490743e-001;
    __statist_i_h_wts[16,191]=-5.33887080452447e-001;
    __statist_i_h_wts[16,192]=-6.88365282295469e-001;
    __statist_i_h_wts[16,193]=-6.96042011480694e-001;
    __statist_i_h_wts[16,194]=-7.84026914316690e-001;
    __statist_i_h_wts[16,195]=-8.69010321397389e-002;
    __statist_i_h_wts[16,196]=-1.42150098337653e-001;
    __statist_i_h_wts[16,197]=-1.53001114049119e-001;
    __statist_i_h_wts[16,198]=-2.02942010296828e-001;
    __statist_i_h_wts[16,199]=-2.44135618249590e-001;
    __statist_i_h_wts[16,200]=-2.84205040109257e-001;
    __statist_i_h_wts[16,201]=-3.34467615705756e-001;
    __statist_i_h_wts[16,202]=-2.69503685823099e-001;
    __statist_i_h_wts[16,203]=-2.81786265969466e-001;
    __statist_i_h_wts[16,204]=-2.30919127202501e-001;
    __statist_i_h_wts[16,205]=-2.76281180068812e-001;
    __statist_i_h_wts[16,206]=-6.05308280926787e-001;
    __statist_i_h_wts[16,207]=-7.12777482631970e-001;
    __statist_i_h_wts[16,208]=-7.20842441896737e-001;
    __statist_i_h_wts[16,209]=-7.67061846857445e-001;
    __statist_i_h_wts[16,210]=-1.63445530334786e-001;
    __statist_i_h_wts[16,211]=-2.10937327032635e-001;
    __statist_i_h_wts[16,212]=-1.89097899593507e-001;
    __statist_i_h_wts[16,213]=-2.58959714222433e-001;
    __statist_i_h_wts[16,214]=-3.03535829010349e-001;
    __statist_i_h_wts[16,215]=-3.41181628921869e-001;
    __statist_i_h_wts[16,216]=-3.67062344444192e-001;
    __statist_i_h_wts[16,217]=-2.70978360995823e-001;
    __statist_i_h_wts[16,218]=-1.85478889575455e-001;
    __statist_i_h_wts[16,219]=-1.42338463367835e-001;
    __statist_i_h_wts[16,220]=-1.59045725292684e-001;
    __statist_i_h_wts[16,221]=-3.90672928282316e-001;
    __statist_i_h_wts[16,222]=-4.79240091430657e-001;
    __statist_i_h_wts[16,223]=-5.59100322530376e-001;
    __statist_i_h_wts[16,224]=-6.74937515121078e-001;
    __statist_i_h_wts[16,225]=1.47585780531238e-001;
    __statist_i_h_wts[16,226]=5.23901016561185e-001;
    __statist_i_h_wts[16,227]=2.24043324628799e-002;
    __statist_i_h_wts[16,228]=3.45496309355554e-001;
    __statist_i_h_wts[16,229]=-7.28697767268075e-002;
    __statist_i_h_wts[16,230]=-7.37092052363697e-001;
    __statist_i_h_wts[16,231]=-2.10631326559349e-001;
    __statist_i_h_wts[16,232]=-1.16827669520323e+000;
    __statist_i_h_wts[16,233]=-4.03400989846112e-001;
    __statist_i_h_wts[16,234]=-6.18932977230355e-001;
    __statist_i_h_wts[16,235]=3.19795416036210e-001;
    __statist_i_h_wts[16,236]=1.24752869110639e+000;
    __statist_i_h_wts[16,237]=4.20926344529678e-001;
    __statist_i_h_wts[16,238]=-2.05941893966921e-001;
    __statist_i_h_wts[16,239]=-4.93296153085414e-001;
    __statist_i_h_wts[16,240]=1.49354095526234e-001;
    __statist_i_h_wts[16,241]=-9.32617227167644e-001;
    __statist_i_h_wts[16,242]=-9.42483733201388e-002;
    __statist_i_h_wts[16,243]=-6.08906890311694e-001;
    __statist_i_h_wts[16,244]=7.53335239105031e-002;
    __statist_i_h_wts[16,245]=6.93367593313486e-001;
    __statist_i_h_wts[16,246]=-1.10702773697027e-001;
    __statist_i_h_wts[16,247]=3.01173416068437e-001;
    __statist_i_h_wts[16,248]=-2.93148546366934e-001;

    __statist_i_h_wts[17,0]=-4.55953664571044e-001;
    __statist_i_h_wts[17,1]=-3.62278989455667e-001;
    __statist_i_h_wts[17,2]=-5.95079182952328e-001;
    __statist_i_h_wts[17,3]=-2.05616209309295e-001;
    __statist_i_h_wts[17,4]=-2.88261913092585e-001;
    __statist_i_h_wts[17,5]=4.10212505934827e-001;
    __statist_i_h_wts[17,6]=1.42374420247840e-001;
    __statist_i_h_wts[17,7]=1.75458433733976e-002;
    __statist_i_h_wts[17,8]=4.96762644737980e-001;
    __statist_i_h_wts[17,9]=4.83472653475212e-001;
    __statist_i_h_wts[17,10]=4.31772117859685e-001;
    __statist_i_h_wts[17,11]=3.27511546576840e-001;
    __statist_i_h_wts[17,12]=2.28364861075400e-001;
    __statist_i_h_wts[17,13]=4.34240708776921e-001;
    __statist_i_h_wts[17,14]=8.74508860310003e-001;
    __statist_i_h_wts[17,15]=-1.13608529856630e+000;
    __statist_i_h_wts[17,16]=-1.06574095205482e+000;
    __statist_i_h_wts[17,17]=-1.11663540255651e+000;
    __statist_i_h_wts[17,18]=-7.27748878604526e-001;
    __statist_i_h_wts[17,19]=-1.30407608240788e+000;
    __statist_i_h_wts[17,20]=-7.43981123071425e-001;
    __statist_i_h_wts[17,21]=-2.03062383176011e-001;
    __statist_i_h_wts[17,22]=-1.63343624389185e-001;
    __statist_i_h_wts[17,23]=-1.18512536966435e-001;
    __statist_i_h_wts[17,24]=2.26674136732258e-001;
    __statist_i_h_wts[17,25]=-1.21962073909298e-002;
    __statist_i_h_wts[17,26]=-8.73060623823541e-002;
    __statist_i_h_wts[17,27]=2.41813655159241e-001;
    __statist_i_h_wts[17,28]=6.77699697836018e-001;
    __statist_i_h_wts[17,29]=1.25937156309716e+000;
    __statist_i_h_wts[17,30]=-1.29945167014346e+000;
    __statist_i_h_wts[17,31]=-9.86654765954634e-001;
    __statist_i_h_wts[17,32]=-1.12173122606190e+000;
    __statist_i_h_wts[17,33]=-6.81764263542980e-001;
    __statist_i_h_wts[17,34]=-8.89069937514941e-001;
    __statist_i_h_wts[17,35]=-1.85881161951987e-001;
    __statist_i_h_wts[17,36]=4.89807787731305e-001;
    __statist_i_h_wts[17,37]=3.61501023710578e-001;
    __statist_i_h_wts[17,38]=6.44475257645603e-001;
    __statist_i_h_wts[17,39]=7.61665210596205e-001;
    __statist_i_h_wts[17,40]=4.35008942438887e-001;
    __statist_i_h_wts[17,41]=-1.83099241643633e-001;
    __statist_i_h_wts[17,42]=4.79209048244427e-001;
    __statist_i_h_wts[17,43]=4.71320089280830e-001;
    __statist_i_h_wts[17,44]=5.80336303543710e-001;
    __statist_i_h_wts[17,45]=-1.02340887277820e+000;
    __statist_i_h_wts[17,46]=-9.62806236469652e-001;
    __statist_i_h_wts[17,47]=-9.93192292337762e-001;
    __statist_i_h_wts[17,48]=-6.66730807629281e-001;
    __statist_i_h_wts[17,49]=-1.00457401656172e+000;
    __statist_i_h_wts[17,50]=-3.44120863517490e-001;
    __statist_i_h_wts[17,51]=-1.17259440835486e-001;
    __statist_i_h_wts[17,52]=4.49759588226523e-001;
    __statist_i_h_wts[17,53]=4.82500437060738e-001;
    __statist_i_h_wts[17,54]=1.28332714137723e+000;
    __statist_i_h_wts[17,55]=1.01233722085382e+000;
    __statist_i_h_wts[17,56]=2.83285913046827e-001;
    __statist_i_h_wts[17,57]=8.15416265335426e-001;
    __statist_i_h_wts[17,58]=7.71293225056559e-001;
    __statist_i_h_wts[17,59]=6.06339753803966e-001;
    __statist_i_h_wts[17,60]=-8.44846668324615e-001;
    __statist_i_h_wts[17,61]=-1.02658925057862e+000;
    __statist_i_h_wts[17,62]=-1.10317096230497e+000;
    __statist_i_h_wts[17,63]=-8.95339756197550e-001;
    __statist_i_h_wts[17,64]=-1.46156698622071e+000;
    __statist_i_h_wts[17,65]=-8.81212090146033e-001;
    __statist_i_h_wts[17,66]=-6.96787171760621e-002;
    __statist_i_h_wts[17,67]=4.56250482904334e-001;
    __statist_i_h_wts[17,68]=6.53587620234403e-001;
    __statist_i_h_wts[17,69]=1.32630024953384e+000;
    __statist_i_h_wts[17,70]=8.06634250024165e-001;
    __statist_i_h_wts[17,71]=-2.89760449975471e-002;
    __statist_i_h_wts[17,72]=5.82924950336867e-001;
    __statist_i_h_wts[17,73]=9.37187414599902e-001;
    __statist_i_h_wts[17,74]=9.04639884209563e-001;
    __statist_i_h_wts[17,75]=-9.62371621074434e-001;
    __statist_i_h_wts[17,76]=-1.13965734727504e+000;
    __statist_i_h_wts[17,77]=-6.53477646920296e-001;
    __statist_i_h_wts[17,78]=-8.23555306082257e-001;
    __statist_i_h_wts[17,79]=-7.95011577965035e-001;
    __statist_i_h_wts[17,80]=-2.91565951350034e-001;
    __statist_i_h_wts[17,81]=5.17814690245014e-001;
    __statist_i_h_wts[17,82]=8.43239985286449e-001;
    __statist_i_h_wts[17,83]=1.11642549161422e+000;
    __statist_i_h_wts[17,84]=8.10324116105660e-001;
    __statist_i_h_wts[17,85]=5.93224485643453e-001;
    __statist_i_h_wts[17,86]=-4.97458842820026e-001;
    __statist_i_h_wts[17,87]=2.09948816459759e-001;
    __statist_i_h_wts[17,88]=-1.40740817806045e-001;
    __statist_i_h_wts[17,89]=-7.24354584388348e-002;
    __statist_i_h_wts[17,90]=-1.09090681710587e+000;
    __statist_i_h_wts[17,91]=-9.79609609601810e-001;
    __statist_i_h_wts[17,92]=-4.98563601779393e-001;
    __statist_i_h_wts[17,93]=-5.31607029357593e-001;
    __statist_i_h_wts[17,94]=-8.18797607096224e-001;
    __statist_i_h_wts[17,95]=-4.74904096136797e-001;
    __statist_i_h_wts[17,96]=1.01951809894772e-001;
    __statist_i_h_wts[17,97]=4.67462508744162e-001;
    __statist_i_h_wts[17,98]=4.07866870617643e-001;
    __statist_i_h_wts[17,99]=2.88514134449475e-001;
    __statist_i_h_wts[17,100]=4.01216568500963e-001;
    __statist_i_h_wts[17,101]=-3.83506512145632e-001;
    __statist_i_h_wts[17,102]=-1.68105702075762e-001;
    __statist_i_h_wts[17,103]=3.74694048045961e-002;
    __statist_i_h_wts[17,104]=2.47990300422659e-001;
    __statist_i_h_wts[17,105]=-9.64224938971559e-001;
    __statist_i_h_wts[17,106]=-8.78536640436113e-001;
    __statist_i_h_wts[17,107]=-7.88168959438162e-001;
    __statist_i_h_wts[17,108]=-5.83610054384901e-001;
    __statist_i_h_wts[17,109]=-1.01944632868852e+000;
    __statist_i_h_wts[17,110]=-5.05121935878299e-001;
    __statist_i_h_wts[17,111]=3.55735107842740e-001;
    __statist_i_h_wts[17,112]=6.20671401019672e-001;
    __statist_i_h_wts[17,113]=3.25590953110847e-001;
    __statist_i_h_wts[17,114]=6.54623186142170e-001;
    __statist_i_h_wts[17,115]=2.16510044724244e-001;
    __statist_i_h_wts[17,116]=-1.51659574410660e-001;
    __statist_i_h_wts[17,117]=2.08998655789699e-001;
    __statist_i_h_wts[17,118]=4.37633904097900e-001;
    __statist_i_h_wts[17,119]=9.43136482410680e-001;
    __statist_i_h_wts[17,120]=-7.17928719425658e-001;
    __statist_i_h_wts[17,121]=-4.49933979974083e-001;
    __statist_i_h_wts[17,122]=-3.31820284315357e-001;
    __statist_i_h_wts[17,123]=-3.92979486794368e-001;
    __statist_i_h_wts[17,124]=-4.98329364304784e-001;
    __statist_i_h_wts[17,125]=-7.76197845549651e-002;
    __statist_i_h_wts[17,126]=2.10867086526886e-001;
    __statist_i_h_wts[17,127]=6.13870073193510e-001;
    __statist_i_h_wts[17,128]=3.06662473460809e-001;
    __statist_i_h_wts[17,129]=9.01916902874562e-001;
    __statist_i_h_wts[17,130]=5.20166806837971e-001;
    __statist_i_h_wts[17,131]=6.64903235460004e-001;
    __statist_i_h_wts[17,132]=8.56243033140275e-001;
    __statist_i_h_wts[17,133]=6.87792931487839e-001;
    __statist_i_h_wts[17,134]=9.85980522894910e-001;
    __statist_i_h_wts[17,135]=-8.31464669670180e-001;
    __statist_i_h_wts[17,136]=-6.13999255958227e-001;
    __statist_i_h_wts[17,137]=-7.13268491752924e-001;
    __statist_i_h_wts[17,138]=-5.80263887416250e-001;
    __statist_i_h_wts[17,139]=-8.71025347686832e-001;
    __statist_i_h_wts[17,140]=5.89188004875823e-002;
    __statist_i_h_wts[17,141]=2.04244190605117e-001;
    __statist_i_h_wts[17,142]=6.51448837014308e-001;
    __statist_i_h_wts[17,143]=5.19058257241027e-001;
    __statist_i_h_wts[17,144]=7.69529918488860e-001;
    __statist_i_h_wts[17,145]=1.45621416155847e-001;
    __statist_i_h_wts[17,146]=7.28831791843150e-001;
    __statist_i_h_wts[17,147]=3.60067490406920e-001;
    __statist_i_h_wts[17,148]=5.37757790854472e-001;
    __statist_i_h_wts[17,149]=9.20410691525113e-001;
    __statist_i_h_wts[17,150]=-1.01018673021789e+000;
    __statist_i_h_wts[17,151]=-7.02552578761375e-001;
    __statist_i_h_wts[17,152]=-8.85268669495600e-001;
    __statist_i_h_wts[17,153]=-1.46389712393402e+000;
    __statist_i_h_wts[17,154]=-8.40556463810658e-001;
    __statist_i_h_wts[17,155]=1.01190160597575e-001;
    __statist_i_h_wts[17,156]=2.49416229747114e-001;
    __statist_i_h_wts[17,157]=2.19066377197011e-001;
    __statist_i_h_wts[17,158]=1.78115088115602e-001;
    __statist_i_h_wts[17,159]=3.47236608560780e-001;
    __statist_i_h_wts[17,160]=-2.23318007102992e-002;
    __statist_i_h_wts[17,161]=4.52372328619109e-001;
    __statist_i_h_wts[17,162]=2.48167183996972e-001;
    __statist_i_h_wts[17,163]=3.65525712644121e-001;
    __statist_i_h_wts[17,164]=6.17777843551455e-001;
    __statist_i_h_wts[17,165]=-3.60196468660259e-001;
    __statist_i_h_wts[17,166]=-1.10058853476383e-001;
    __statist_i_h_wts[17,167]=-4.41386043290723e-001;
    __statist_i_h_wts[17,168]=-1.02936696975519e+000;
    __statist_i_h_wts[17,169]=-4.46664392069347e-001;
    __statist_i_h_wts[17,170]=1.46560647976981e-001;
    __statist_i_h_wts[17,171]=3.04410058749508e-001;
    __statist_i_h_wts[17,172]=1.42716672609045e-001;
    __statist_i_h_wts[17,173]=4.57051386273965e-001;
    __statist_i_h_wts[17,174]=3.58039369084673e-001;
    __statist_i_h_wts[17,175]=3.06358786853725e-001;
    __statist_i_h_wts[17,176]=4.89611831838205e-001;
    __statist_i_h_wts[17,177]=4.77394030715309e-001;
    __statist_i_h_wts[17,178]=4.72149276151566e-001;
    __statist_i_h_wts[17,179]=7.28642876168169e-001;
    __statist_i_h_wts[17,180]=-3.87161708769672e-001;
    __statist_i_h_wts[17,181]=-2.51205497557944e-001;
    __statist_i_h_wts[17,182]=-2.87379084430072e-001;
    __statist_i_h_wts[17,183]=-7.54108888981952e-001;
    __statist_i_h_wts[17,184]=-6.68210360965698e-001;
    __statist_i_h_wts[17,185]=7.31812257286044e-002;
    __statist_i_h_wts[17,186]=2.65784356708790e-001;
    __statist_i_h_wts[17,187]=2.46084761186942e-001;
    __statist_i_h_wts[17,188]=5.63818993363362e-001;
    __statist_i_h_wts[17,189]=3.38869094321206e-001;
    __statist_i_h_wts[17,190]=2.63608539856613e-001;
    __statist_i_h_wts[17,191]=5.23379191388346e-001;
    __statist_i_h_wts[17,192]=7.62304873289019e-001;
    __statist_i_h_wts[17,193]=1.09280364826809e+000;
    __statist_i_h_wts[17,194]=1.35577834533930e+000;
    __statist_i_h_wts[17,195]=-8.04744045251724e-002;
    __statist_i_h_wts[17,196]=9.72845549131705e-002;
    __statist_i_h_wts[17,197]=-4.41202560567409e-003;
    __statist_i_h_wts[17,198]=-4.20719529513552e-001;
    __statist_i_h_wts[17,199]=-2.69965778906813e-001;
    __statist_i_h_wts[17,200]=-5.11868638232552e-002;
    __statist_i_h_wts[17,201]=1.36181339711793e-001;
    __statist_i_h_wts[17,202]=1.01222191158161e-001;
    __statist_i_h_wts[17,203]=3.80392454412534e-001;
    __statist_i_h_wts[17,204]=4.82015133010767e-001;
    __statist_i_h_wts[17,205]=5.67549301694181e-001;
    __statist_i_h_wts[17,206]=7.91497450296542e-001;
    __statist_i_h_wts[17,207]=1.28077017747702e+000;
    __statist_i_h_wts[17,208]=1.47421899744362e+000;
    __statist_i_h_wts[17,209]=1.25948808444731e+000;
    __statist_i_h_wts[17,210]=-7.42139989769424e-002;
    __statist_i_h_wts[17,211]=-4.02609389425778e-002;
    __statist_i_h_wts[17,212]=-2.12482122509230e-001;
    __statist_i_h_wts[17,213]=-4.06025376195188e-001;
    __statist_i_h_wts[17,214]=-1.01250667374993e-001;
    __statist_i_h_wts[17,215]=2.33411193296447e-001;
    __statist_i_h_wts[17,216]=3.98682305233303e-001;
    __statist_i_h_wts[17,217]=3.26957986112968e-001;
    __statist_i_h_wts[17,218]=4.39216959587596e-001;
    __statist_i_h_wts[17,219]=4.21317897332131e-001;
    __statist_i_h_wts[17,220]=3.18654731916310e-001;
    __statist_i_h_wts[17,221]=4.04099291503774e-001;
    __statist_i_h_wts[17,222]=8.59693939145494e-001;
    __statist_i_h_wts[17,223]=1.13781865604238e+000;
    __statist_i_h_wts[17,224]=1.01714433921198e+000;
    __statist_i_h_wts[17,225]=-5.17443306203052e-002;
    __statist_i_h_wts[17,226]=-3.42718663470954e-001;
    __statist_i_h_wts[17,227]=-1.56630098139200e-001;
    __statist_i_h_wts[17,228]=2.97432256451949e-001;
    __statist_i_h_wts[17,229]=1.92469209737085e-001;
    __statist_i_h_wts[17,230]=1.79791011356563e+000;
    __statist_i_h_wts[17,231]=1.03759434626193e+000;
    __statist_i_h_wts[17,232]=3.54651210432157e+000;
    __statist_i_h_wts[17,233]=1.15648117188502e+000;
    __statist_i_h_wts[17,234]=1.43730100864657e+000;
    __statist_i_h_wts[17,235]=-1.39883397847921e+000;
    __statist_i_h_wts[17,236]=-4.68411330828961e+000;
    __statist_i_h_wts[17,237]=-3.76093192397912e-001;
    __statist_i_h_wts[17,238]=-6.40495828296504e-001;
    __statist_i_h_wts[17,239]=-9.97643220684166e-003;
    __statist_i_h_wts[17,240]=-8.37947653149593e-001;
    __statist_i_h_wts[17,241]=2.55110060079368e+000;
    __statist_i_h_wts[17,242]=1.57582728341138e+000;
    __statist_i_h_wts[17,243]=9.91706714247821e-001;
    __statist_i_h_wts[17,244]=-5.74795289286140e-001;
    __statist_i_h_wts[17,245]=-1.40547488332647e+000;
    __statist_i_h_wts[17,246]=-1.67583331390002e-001;
    __statist_i_h_wts[17,247]=-2.64305878087073e-001;
    __statist_i_h_wts[17,248]=-3.93796710980612e-001;

    __statist_i_h_wts[18,0]=-2.62970333331553e-002;
    __statist_i_h_wts[18,1]=-3.91678248965646e-001;
    __statist_i_h_wts[18,2]=-7.86068726769601e-001;
    __statist_i_h_wts[18,3]=-5.48720970621568e-001;
    __statist_i_h_wts[18,4]=-3.64899395289342e-001;
    __statist_i_h_wts[18,5]=-2.39126815535478e-001;
    __statist_i_h_wts[18,6]=-2.91500779097046e-001;
    __statist_i_h_wts[18,7]=-8.91852505103401e-004;
    __statist_i_h_wts[18,8]=5.69902332302807e-002;
    __statist_i_h_wts[18,9]=-1.52791853493765e-002;
    __statist_i_h_wts[18,10]=1.25385144311221e-001;
    __statist_i_h_wts[18,11]=-5.74046366831629e-003;
    __statist_i_h_wts[18,12]=-1.43603237196661e-001;
    __statist_i_h_wts[18,13]=-1.52138262343608e-001;
    __statist_i_h_wts[18,14]=4.27474053769389e-001;
    __statist_i_h_wts[18,15]=-2.32318066326421e-002;
    __statist_i_h_wts[18,16]=-3.87059324585473e-001;
    __statist_i_h_wts[18,17]=-7.21384582985952e-001;
    __statist_i_h_wts[18,18]=-2.92874136952325e-001;
    __statist_i_h_wts[18,19]=-3.68889716595790e-001;
    __statist_i_h_wts[18,20]=-2.32373782044654e-001;
    __statist_i_h_wts[18,21]=-1.57488051968805e-001;
    __statist_i_h_wts[18,22]=9.58002262280141e-002;
    __statist_i_h_wts[18,23]=2.11109223901737e-001;
    __statist_i_h_wts[18,24]=9.29281875890553e-002;
    __statist_i_h_wts[18,25]=1.39477313536417e-001;
    __statist_i_h_wts[18,26]=2.91522631901661e-001;
    __statist_i_h_wts[18,27]=2.82425426679614e-002;
    __statist_i_h_wts[18,28]=-3.37221347379789e-002;
    __statist_i_h_wts[18,29]=5.21712586734347e-001;
    __statist_i_h_wts[18,30]=1.54966548051472e-001;
    __statist_i_h_wts[18,31]=-5.13581238237600e-002;
    __statist_i_h_wts[18,32]=-6.21993608817443e-001;
    __statist_i_h_wts[18,33]=-1.24876645208377e-001;
    __statist_i_h_wts[18,34]=-1.44501594685080e-001;
    __statist_i_h_wts[18,35]=-1.52297922717019e-001;
    __statist_i_h_wts[18,36]=-2.61983029142863e-002;
    __statist_i_h_wts[18,37]=-2.89686893696846e-002;
    __statist_i_h_wts[18,38]=-1.57792687431691e-002;
    __statist_i_h_wts[18,39]=-8.53666849721310e-002;
    __statist_i_h_wts[18,40]=2.21464037230437e-001;
    __statist_i_h_wts[18,41]=1.99672958204772e-001;
    __statist_i_h_wts[18,42]=8.92342076364341e-002;
    __statist_i_h_wts[18,43]=-4.97925653460487e-002;
    __statist_i_h_wts[18,44]=1.91688986404821e-001;
    __statist_i_h_wts[18,45]=-2.18558284027906e-001;
    __statist_i_h_wts[18,46]=-2.25056013670927e-001;
    __statist_i_h_wts[18,47]=-5.11485214969157e-001;
    __statist_i_h_wts[18,48]=-1.73314527584519e-001;
    __statist_i_h_wts[18,49]=-3.74765360918813e-002;
    __statist_i_h_wts[18,50]=3.31850717434049e-001;
    __statist_i_h_wts[18,51]=1.76543235736931e-001;
    __statist_i_h_wts[18,52]=1.02229573557729e-001;
    __statist_i_h_wts[18,53]=4.40223299179012e-003;
    __statist_i_h_wts[18,54]=4.01543043836017e-001;
    __statist_i_h_wts[18,55]=5.22852255387279e-001;
    __statist_i_h_wts[18,56]=2.82254780760779e-001;
    __statist_i_h_wts[18,57]=7.95754037213553e-002;
    __statist_i_h_wts[18,58]=3.79880477320352e-001;
    __statist_i_h_wts[18,59]=6.29852907181948e-001;
    __statist_i_h_wts[18,60]=-4.57286595550752e-001;
    __statist_i_h_wts[18,61]=-7.52770064084698e-001;
    __statist_i_h_wts[18,62]=-8.45630227538978e-001;
    __statist_i_h_wts[18,63]=-7.13429978822966e-001;
    __statist_i_h_wts[18,64]=-6.07899238504104e-002;
    __statist_i_h_wts[18,65]=2.63209162415392e-001;
    __statist_i_h_wts[18,66]=4.80978046502553e-002;
    __statist_i_h_wts[18,67]=6.76295712942457e-002;
    __statist_i_h_wts[18,68]=-3.18351919506662e-001;
    __statist_i_h_wts[18,69]=3.53405896823629e-001;
    __statist_i_h_wts[18,70]=2.97263170380153e-001;
    __statist_i_h_wts[18,71]=1.42880304042074e-001;
    __statist_i_h_wts[18,72]=-2.28838217539593e-001;
    __statist_i_h_wts[18,73]=2.26548859099827e-001;
    __statist_i_h_wts[18,74]=3.29011201670257e-002;
    __statist_i_h_wts[18,75]=-2.03801771769575e-001;
    __statist_i_h_wts[18,76]=-3.60622182899691e-001;
    __statist_i_h_wts[18,77]=2.44174428495579e-002;
    __statist_i_h_wts[18,78]=-4.49484934940888e-001;
    __statist_i_h_wts[18,79]=-1.77252219437685e-003;
    __statist_i_h_wts[18,80]=-1.91388292380862e-001;
    __statist_i_h_wts[18,81]=-5.32036147378422e-002;
    __statist_i_h_wts[18,82]=1.95531233286851e-002;
    __statist_i_h_wts[18,83]=4.88872026633837e-002;
    __statist_i_h_wts[18,84]=3.81552564278332e-002;
    __statist_i_h_wts[18,85]=2.92512592525475e-001;
    __statist_i_h_wts[18,86]=4.83170930657903e-001;
    __statist_i_h_wts[18,87]=3.74547998625847e-001;
    __statist_i_h_wts[18,88]=1.77795362609223e-001;
    __statist_i_h_wts[18,89]=8.18043600758139e-002;
    __statist_i_h_wts[18,90]=-1.86670311131874e-001;
    __statist_i_h_wts[18,91]=-1.92906588118098e-001;
    __statist_i_h_wts[18,92]=-2.10568541177922e-001;
    __statist_i_h_wts[18,93]=-3.15353843273199e-001;
    __statist_i_h_wts[18,94]=-1.86751465523336e-001;
    __statist_i_h_wts[18,95]=-1.71431801144332e-001;
    __statist_i_h_wts[18,96]=2.77734550907544e-001;
    __statist_i_h_wts[18,97]=2.84989023180858e-002;
    __statist_i_h_wts[18,98]=-3.40889309379176e-001;
    __statist_i_h_wts[18,99]=-3.24195151587952e-002;
    __statist_i_h_wts[18,100]=2.45039382665555e-001;
    __statist_i_h_wts[18,101]=1.12462126721392e-001;
    __statist_i_h_wts[18,102]=-1.71512033796012e-001;
    __statist_i_h_wts[18,103]=2.24105897093788e-001;
    __statist_i_h_wts[18,104]=3.82880377281866e-002;
    __statist_i_h_wts[18,105]=-5.67791931410540e-001;
    __statist_i_h_wts[18,106]=-5.08719026921080e-001;
    __statist_i_h_wts[18,107]=-6.11646427639432e-001;
    __statist_i_h_wts[18,108]=-3.14455654286961e-001;
    __statist_i_h_wts[18,109]=-2.90376304132033e-001;
    __statist_i_h_wts[18,110]=-4.45574456138628e-001;
    __statist_i_h_wts[18,111]=2.82073745121228e-001;
    __statist_i_h_wts[18,112]=1.09058303082380e-001;
    __statist_i_h_wts[18,113]=-2.13006838022772e-001;
    __statist_i_h_wts[18,114]=1.07715555628332e-002;
    __statist_i_h_wts[18,115]=7.30847139242538e-003;
    __statist_i_h_wts[18,116]=2.61150713057455e-004;
    __statist_i_h_wts[18,117]=-2.37026892376669e-001;
    __statist_i_h_wts[18,118]=1.64826133233861e-001;
    __statist_i_h_wts[18,119]=2.31388359954729e-001;
    __statist_i_h_wts[18,120]=-3.23139626996705e-001;
    __statist_i_h_wts[18,121]=-2.53046294544245e-001;
    __statist_i_h_wts[18,122]=9.36655031838700e-003;
    __statist_i_h_wts[18,123]=-3.82766869369180e-002;
    __statist_i_h_wts[18,124]=-2.03730793583547e-001;
    __statist_i_h_wts[18,125]=-1.91997539270316e-001;
    __statist_i_h_wts[18,126]=-8.35089251492044e-002;
    __statist_i_h_wts[18,127]=3.53079542859588e-002;
    __statist_i_h_wts[18,128]=-4.19173635040108e-001;
    __statist_i_h_wts[18,129]=1.27189685979815e-001;
    __statist_i_h_wts[18,130]=1.99085991883232e-001;
    __statist_i_h_wts[18,131]=2.42814127970581e-001;
    __statist_i_h_wts[18,132]=-3.15727421684608e-002;
    __statist_i_h_wts[18,133]=2.78113901083388e-001;
    __statist_i_h_wts[18,134]=1.88480811293637e-001;
    __statist_i_h_wts[18,135]=-6.15768549139228e-001;
    __statist_i_h_wts[18,136]=-3.97901802758679e-001;
    __statist_i_h_wts[18,137]=-1.34746048907632e-001;
    __statist_i_h_wts[18,138]=-1.44076037787171e-001;
    __statist_i_h_wts[18,139]=-3.92204796900637e-001;
    __statist_i_h_wts[18,140]=1.96101060697621e-001;
    __statist_i_h_wts[18,141]=8.74256143893894e-002;
    __statist_i_h_wts[18,142]=9.17486274530189e-002;
    __statist_i_h_wts[18,143]=1.83863414545340e-002;
    __statist_i_h_wts[18,144]=1.96178755454980e-001;
    __statist_i_h_wts[18,145]=3.65376829604554e-002;
    __statist_i_h_wts[18,146]=2.49271976334203e-001;
    __statist_i_h_wts[18,147]=2.02435889062364e-001;
    __statist_i_h_wts[18,148]=2.81844930956529e-001;
    __statist_i_h_wts[18,149]=1.90613043500852e-001;
    __statist_i_h_wts[18,150]=-5.58292535085307e-001;
    __statist_i_h_wts[18,151]=-3.95588919298293e-001;
    __statist_i_h_wts[18,152]=-3.25948508842032e-001;
    __statist_i_h_wts[18,153]=-1.73842955528636e-001;
    __statist_i_h_wts[18,154]=-8.89425947226457e-002;
    __statist_i_h_wts[18,155]=1.39389665626230e-001;
    __statist_i_h_wts[18,156]=1.86364810434891e-001;
    __statist_i_h_wts[18,157]=1.60879957870124e-001;
    __statist_i_h_wts[18,158]=-1.00028319717384e-001;
    __statist_i_h_wts[18,159]=3.11654645368449e-001;
    __statist_i_h_wts[18,160]=-9.08810334469868e-003;
    __statist_i_h_wts[18,161]=1.54917951084405e-001;
    __statist_i_h_wts[18,162]=1.11629464315281e-001;
    __statist_i_h_wts[18,163]=4.10249877394669e-001;
    __statist_i_h_wts[18,164]=2.38027371182232e-001;
    __statist_i_h_wts[18,165]=-8.69624015307956e-002;
    __statist_i_h_wts[18,166]=6.68732615794504e-002;
    __statist_i_h_wts[18,167]=2.00401269699502e-001;
    __statist_i_h_wts[18,168]=2.03520496349008e-001;
    __statist_i_h_wts[18,169]=2.99467051883007e-001;
    __statist_i_h_wts[18,170]=3.09206046386555e-001;
    __statist_i_h_wts[18,171]=2.94006989457751e-001;
    __statist_i_h_wts[18,172]=2.63875748622582e-001;
    __statist_i_h_wts[18,173]=3.16862097353341e-001;
    __statist_i_h_wts[18,174]=3.71838031683183e-001;
    __statist_i_h_wts[18,175]=2.74167459360615e-001;
    __statist_i_h_wts[18,176]=2.27269902242333e-001;
    __statist_i_h_wts[18,177]=3.01733084935927e-001;
    __statist_i_h_wts[18,178]=3.30786556635066e-001;
    __statist_i_h_wts[18,179]=3.72964458127635e-001;
    __statist_i_h_wts[18,180]=-1.71539003375478e-001;
    __statist_i_h_wts[18,181]=-1.51449456345734e-001;
    __statist_i_h_wts[18,182]=-1.31677392916293e-001;
    __statist_i_h_wts[18,183]=-4.67396576857031e-002;
    __statist_i_h_wts[18,184]=3.15143911388868e-002;
    __statist_i_h_wts[18,185]=3.99223989429916e-003;
    __statist_i_h_wts[18,186]=-3.42034906222174e-001;
    __statist_i_h_wts[18,187]=-2.07384453260650e-002;
    __statist_i_h_wts[18,188]=-9.14319231202723e-002;
    __statist_i_h_wts[18,189]=1.56871718195344e-002;
    __statist_i_h_wts[18,190]=-1.12330477551923e-001;
    __statist_i_h_wts[18,191]=2.46072369907306e-002;
    __statist_i_h_wts[18,192]=6.99004723344610e-002;
    __statist_i_h_wts[18,193]=2.49574870304894e-001;
    __statist_i_h_wts[18,194]=2.87498279315396e-001;
    __statist_i_h_wts[18,195]=8.22894022388616e-002;
    __statist_i_h_wts[18,196]=1.70088584069055e-001;
    __statist_i_h_wts[18,197]=1.46509860019689e-001;
    __statist_i_h_wts[18,198]=1.02915882311934e-001;
    __statist_i_h_wts[18,199]=5.14372588236606e-002;
    __statist_i_h_wts[18,200]=-1.03146028012283e-001;
    __statist_i_h_wts[18,201]=-2.28715621793228e-001;
    __statist_i_h_wts[18,202]=-1.79097508233436e-002;
    __statist_i_h_wts[18,203]=-6.78562752194626e-002;
    __statist_i_h_wts[18,204]=1.15999414104174e-001;
    __statist_i_h_wts[18,205]=1.31857482638357e-001;
    __statist_i_h_wts[18,206]=1.97004896906094e-001;
    __statist_i_h_wts[18,207]=2.71232498294443e-001;
    __statist_i_h_wts[18,208]=3.52465647344385e-001;
    __statist_i_h_wts[18,209]=1.86506890148105e-001;
    __statist_i_h_wts[18,210]=-2.46228397109434e-001;
    __statist_i_h_wts[18,211]=-1.18961960603685e-001;
    __statist_i_h_wts[18,212]=-1.81011618157793e-001;
    __statist_i_h_wts[18,213]=1.26400833056888e-001;
    __statist_i_h_wts[18,214]=1.08139097071981e-001;
    __statist_i_h_wts[18,215]=1.04134100820234e-001;
    __statist_i_h_wts[18,216]=1.44603303884038e-002;
    __statist_i_h_wts[18,217]=1.37590779585903e-001;
    __statist_i_h_wts[18,218]=-8.84528940937385e-002;
    __statist_i_h_wts[18,219]=3.78719253527854e-002;
    __statist_i_h_wts[18,220]=2.71690900174551e-004;
    __statist_i_h_wts[18,221]=-7.21418988011527e-002;
    __statist_i_h_wts[18,222]=6.96364568474607e-002;
    __statist_i_h_wts[18,223]=2.46721241447579e-001;
    __statist_i_h_wts[18,224]=9.50027943933661e-002;
    __statist_i_h_wts[18,225]=3.42876889495174e-002;
    __statist_i_h_wts[18,226]=-5.44326059991769e-001;
    __statist_i_h_wts[18,227]=2.74868843502938e-001;
    __statist_i_h_wts[18,228]=-4.03971164549607e-001;
    __statist_i_h_wts[18,229]=1.95782612249270e-001;
    __statist_i_h_wts[18,230]=3.84013573772206e-001;
    __statist_i_h_wts[18,231]=-2.81887862212955e-001;
    __statist_i_h_wts[18,232]=9.22659049433399e-001;
    __statist_i_h_wts[18,233]=1.53754671633225e-001;
    __statist_i_h_wts[18,234]=3.82570311398744e-001;
    __statist_i_h_wts[18,235]=-7.38722948076860e-001;
    __statist_i_h_wts[18,236]=-1.85583084337166e+000;
    __statist_i_h_wts[18,237]=5.39622980727388e-001;
    __statist_i_h_wts[18,238]=1.61199229671386e-001;
    __statist_i_h_wts[18,239]=-3.31158348214502e-001;
    __statist_i_h_wts[18,240]=-6.46537573171251e-001;
    __statist_i_h_wts[18,241]=1.02905111961078e+000;
    __statist_i_h_wts[18,242]=1.93304972217217e-001;
    __statist_i_h_wts[18,243]=4.09410060454492e-001;
    __statist_i_h_wts[18,244]=8.28589093591912e-002;
    __statist_i_h_wts[18,245]=-3.62981723694476e-001;
    __statist_i_h_wts[18,246]=1.33409906920655e-001;
    __statist_i_h_wts[18,247]=-1.20784629458645e-001;
    __statist_i_h_wts[18,248]=5.86094755910212e-001;

    __statist_i_h_wts[19,0]=-4.32208332009444e-002;
    __statist_i_h_wts[19,1]=-2.14837555764671e-001;
    __statist_i_h_wts[19,2]=3.74550134283093e-001;
    __statist_i_h_wts[19,3]=-1.24487054149270e-001;
    __statist_i_h_wts[19,4]=8.39491827678041e-002;
    __statist_i_h_wts[19,5]=-1.75897127568985e-001;
    __statist_i_h_wts[19,6]=-7.24405328759210e-002;
    __statist_i_h_wts[19,7]=4.02655130005471e-001;
    __statist_i_h_wts[19,8]=-2.39274219242407e-001;
    __statist_i_h_wts[19,9]=4.46982999052046e-001;
    __statist_i_h_wts[19,10]=3.62560797504487e-002;
    __statist_i_h_wts[19,11]=1.65968547009438e-001;
    __statist_i_h_wts[19,12]=-9.27319675101782e-002;
    __statist_i_h_wts[19,13]=-8.01478699301030e-001;
    __statist_i_h_wts[19,14]=-8.38282858948234e-001;
    __statist_i_h_wts[19,15]=-8.18834438118004e-002;
    __statist_i_h_wts[19,16]=-4.04208605259680e-002;
    __statist_i_h_wts[19,17]=-6.51183490259984e-002;
    __statist_i_h_wts[19,18]=-5.08244642524485e-001;
    __statist_i_h_wts[19,19]=1.85353930935343e-001;
    __statist_i_h_wts[19,20]=4.45615955074281e-001;
    __statist_i_h_wts[19,21]=1.96432239566466e-001;
    __statist_i_h_wts[19,22]=7.37927295873391e-001;
    __statist_i_h_wts[19,23]=3.98364594906481e-001;
    __statist_i_h_wts[19,24]=8.27991815006917e-001;
    __statist_i_h_wts[19,25]=3.03308086216750e-001;
    __statist_i_h_wts[19,26]=4.23019221346738e-001;
    __statist_i_h_wts[19,27]=2.33050583086333e-001;
    __statist_i_h_wts[19,28]=-4.89549107753703e-001;
    __statist_i_h_wts[19,29]=-8.81932186597885e-001;
    __statist_i_h_wts[19,30]=-5.31193897965859e-002;
    __statist_i_h_wts[19,31]=-4.81392717928121e-001;
    __statist_i_h_wts[19,32]=-1.75741828757351e-001;
    __statist_i_h_wts[19,33]=-5.13548262468893e-001;
    __statist_i_h_wts[19,34]=-2.96635572252029e-001;
    __statist_i_h_wts[19,35]=1.13548925001552e-001;
    __statist_i_h_wts[19,36]=-9.56572605932309e-002;
    __statist_i_h_wts[19,37]=3.07553171721113e-001;
    __statist_i_h_wts[19,38]=-3.46688339174634e-002;
    __statist_i_h_wts[19,39]=5.14690992103829e-001;
    __statist_i_h_wts[19,40]=3.38759807183295e-002;
    __statist_i_h_wts[19,41]=4.05823124515608e-001;
    __statist_i_h_wts[19,42]=1.15812842460197e-001;
    __statist_i_h_wts[19,43]=1.59349668573066e-001;
    __statist_i_h_wts[19,44]=-1.04578040002261e-001;
    __statist_i_h_wts[19,45]=-3.29594982691015e-001;
    __statist_i_h_wts[19,46]=-5.47907905516248e-001;
    __statist_i_h_wts[19,47]=-3.22037421385647e-001;
    __statist_i_h_wts[19,48]=-5.32929846844640e-001;
    __statist_i_h_wts[19,49]=-2.92804435889957e-001;
    __statist_i_h_wts[19,50]=3.40064094162615e-002;
    __statist_i_h_wts[19,51]=3.45116291677404e-001;
    __statist_i_h_wts[19,52]=2.74614469092257e-001;
    __statist_i_h_wts[19,53]=5.09517984494658e-001;
    __statist_i_h_wts[19,54]=1.47097184373701e-001;
    __statist_i_h_wts[19,55]=-1.07980795710647e-001;
    __statist_i_h_wts[19,56]=3.59415030833913e-001;
    __statist_i_h_wts[19,57]=1.69252826304995e-001;
    __statist_i_h_wts[19,58]=-3.07630804051264e-001;
    __statist_i_h_wts[19,59]=4.00414837606769e-001;
    __statist_i_h_wts[19,60]=-7.19404042756691e-001;
    __statist_i_h_wts[19,61]=-1.01731137606138e+000;
    __statist_i_h_wts[19,62]=-6.86752154926640e-001;
    __statist_i_h_wts[19,63]=-7.73230519802733e-001;
    __statist_i_h_wts[19,64]=-3.74939025048069e-001;
    __statist_i_h_wts[19,65]=3.83792786111851e-001;
    __statist_i_h_wts[19,66]=-1.89471714440503e-001;
    __statist_i_h_wts[19,67]=-2.45693418014060e-001;
    __statist_i_h_wts[19,68]=6.43755726152540e-002;
    __statist_i_h_wts[19,69]=-4.20661192510555e-001;
    __statist_i_h_wts[19,70]=-2.78180071858067e-002;
    __statist_i_h_wts[19,71]=5.52752544616357e-001;
    __statist_i_h_wts[19,72]=3.12242507625912e-001;
    __statist_i_h_wts[19,73]=-2.26487528531012e-001;
    __statist_i_h_wts[19,74]=5.33012537619776e-001;
    __statist_i_h_wts[19,75]=-8.17371608200668e-001;
    __statist_i_h_wts[19,76]=-9.77680670096189e-001;
    __statist_i_h_wts[19,77]=-9.75740829530211e-001;
    __statist_i_h_wts[19,78]=-1.01691450616298e+000;
    __statist_i_h_wts[19,79]=-1.10008492327822e+000;
    __statist_i_h_wts[19,80]=-5.44525187974134e-002;
    __statist_i_h_wts[19,81]=-4.54637869282570e-001;
    __statist_i_h_wts[19,82]=-2.08150138450847e-001;
    __statist_i_h_wts[19,83]=-1.74464603897939e-001;
    __statist_i_h_wts[19,84]=-2.45322422250511e-001;
    __statist_i_h_wts[19,85]=7.68478886347766e-002;
    __statist_i_h_wts[19,86]=7.23805151832466e-001;
    __statist_i_h_wts[19,87]=9.28495108561128e-002;
    __statist_i_h_wts[19,88]=3.57578601154890e-001;
    __statist_i_h_wts[19,89]=8.75947850207770e-001;
    __statist_i_h_wts[19,90]=-5.05375087987351e-001;
    __statist_i_h_wts[19,91]=-6.48230231229957e-001;
    __statist_i_h_wts[19,92]=-8.19618488681434e-001;
    __statist_i_h_wts[19,93]=-7.97316811698310e-001;
    __statist_i_h_wts[19,94]=-4.92859885186714e-001;
    __statist_i_h_wts[19,95]=2.26067563576262e-001;
    __statist_i_h_wts[19,96]=1.32024965141907e-001;
    __statist_i_h_wts[19,97]=5.17076688819364e-001;
    __statist_i_h_wts[19,98]=2.43736583035156e-001;
    __statist_i_h_wts[19,99]=2.18290221902143e-001;
    __statist_i_h_wts[19,100]=5.22598988109650e-001;
    __statist_i_h_wts[19,101]=4.50615888993059e-001;
    __statist_i_h_wts[19,102]=2.11175852661622e-001;
    __statist_i_h_wts[19,103]=2.88570419328369e-001;
    __statist_i_h_wts[19,104]=9.47156983535276e-001;
    __statist_i_h_wts[19,105]=-4.81098684894825e-001;
    __statist_i_h_wts[19,106]=-8.20949317947078e-001;
    __statist_i_h_wts[19,107]=-3.58071402126273e-001;
    __statist_i_h_wts[19,108]=-6.82548756417308e-001;
    __statist_i_h_wts[19,109]=-5.96171260907041e-001;
    __statist_i_h_wts[19,110]=-1.78337264674564e-001;
    __statist_i_h_wts[19,111]=-3.30706365229076e-001;
    __statist_i_h_wts[19,112]=-6.78826807166174e-001;
    __statist_i_h_wts[19,113]=-7.04947473145186e-001;
    __statist_i_h_wts[19,114]=-7.52944200609048e-001;
    __statist_i_h_wts[19,115]=3.17040086109164e-001;
    __statist_i_h_wts[19,116]=8.47605980546057e-001;
    __statist_i_h_wts[19,117]=3.88915064210245e-001;
    __statist_i_h_wts[19,118]=4.58488174748990e-002;
    __statist_i_h_wts[19,119]=-9.26750795219476e-002;
    __statist_i_h_wts[19,120]=-7.85229446382660e-001;
    __statist_i_h_wts[19,121]=-9.47911640387281e-001;
    __statist_i_h_wts[19,122]=-8.45866919705514e-001;
    __statist_i_h_wts[19,123]=-8.02647889672320e-001;
    __statist_i_h_wts[19,124]=-5.10467610439938e-001;
    __statist_i_h_wts[19,125]=2.41214204107789e-001;
    __statist_i_h_wts[19,126]=6.12705159597535e-001;
    __statist_i_h_wts[19,127]=4.96757290344481e-001;
    __statist_i_h_wts[19,128]=5.34875648284066e-001;
    __statist_i_h_wts[19,129]=-9.78857050178141e-002;
    __statist_i_h_wts[19,130]=1.99195577810325e-001;
    __statist_i_h_wts[19,131]=2.22625691605735e-001;
    __statist_i_h_wts[19,132]=3.53807153076468e-001;
    __statist_i_h_wts[19,133]=7.83537481893306e-002;
    __statist_i_h_wts[19,134]=2.31034682449981e-001;
    __statist_i_h_wts[19,135]=-1.76806978656967e-001;
    __statist_i_h_wts[19,136]=-2.96988643725034e-001;
    __statist_i_h_wts[19,137]=-2.61074296734066e-001;
    __statist_i_h_wts[19,138]=-4.49603748600111e-001;
    __statist_i_h_wts[19,139]=7.83280130623835e-002;
    __statist_i_h_wts[19,140]=6.73627443677583e-002;
    __statist_i_h_wts[19,141]=2.71541854913151e-001;
    __statist_i_h_wts[19,142]=5.70164620168094e-001;
    __statist_i_h_wts[19,143]=5.12106598141233e-001;
    __statist_i_h_wts[19,144]=2.54441028677952e-001;
    __statist_i_h_wts[19,145]=6.04990806157605e-001;
    __statist_i_h_wts[19,146]=4.31583919825697e-001;
    __statist_i_h_wts[19,147]=4.60427955886359e-001;
    __statist_i_h_wts[19,148]=7.04677186800734e-001;
    __statist_i_h_wts[19,149]=3.56109781628976e-001;
    __statist_i_h_wts[19,150]=2.12939672418322e-001;
    __statist_i_h_wts[19,151]=-3.50077370766826e-001;
    __statist_i_h_wts[19,152]=-3.35688154815534e-001;
    __statist_i_h_wts[19,153]=4.14488516265886e-002;
    __statist_i_h_wts[19,154]=-5.55126151778382e-001;
    __statist_i_h_wts[19,155]=-5.63406007191831e-001;
    __statist_i_h_wts[19,156]=4.25250975879871e-001;
    __statist_i_h_wts[19,157]=8.21920143741094e-001;
    __statist_i_h_wts[19,158]=1.22757028842434e+000;
    __statist_i_h_wts[19,159]=7.70058207642731e-001;
    __statist_i_h_wts[19,160]=6.51283258411862e-001;
    __statist_i_h_wts[19,161]=3.30439704124208e-001;
    __statist_i_h_wts[19,162]=5.05067566191734e-001;
    __statist_i_h_wts[19,163]=5.43237180723188e-001;
    __statist_i_h_wts[19,164]=-2.21291073623653e-001;
    __statist_i_h_wts[19,165]=-2.48816033518960e-001;
    __statist_i_h_wts[19,166]=-7.40590413634095e-001;
    __statist_i_h_wts[19,167]=-5.36194382069176e-001;
    __statist_i_h_wts[19,168]=-1.36067444947522e-001;
    __statist_i_h_wts[19,169]=-4.55058467498551e-001;
    __statist_i_h_wts[19,170]=-7.73579601118458e-001;
    __statist_i_h_wts[19,171]=7.31930549033498e-002;
    __statist_i_h_wts[19,172]=2.67105306797732e-001;
    __statist_i_h_wts[19,173]=2.12076037414885e-001;
    __statist_i_h_wts[19,174]=4.85500452705454e-003;
    __statist_i_h_wts[19,175]=1.22524718427401e-002;
    __statist_i_h_wts[19,176]=-1.90342247127039e-001;
    __statist_i_h_wts[19,177]=2.43602250008296e-001;
    __statist_i_h_wts[19,178]=6.36137746911750e-001;
    __statist_i_h_wts[19,179]=-2.92234545966263e-001;
    __statist_i_h_wts[19,180]=6.05374531368373e-001;
    __statist_i_h_wts[19,181]=3.89142396067829e-002;
    __statist_i_h_wts[19,182]=5.21178179854425e-001;
    __statist_i_h_wts[19,183]=5.13990823646456e-001;
    __statist_i_h_wts[19,184]=3.37300607927598e-001;
    __statist_i_h_wts[19,185]=-2.08951092679126e-001;
    __statist_i_h_wts[19,186]=-2.92745242763888e-001;
    __statist_i_h_wts[19,187]=-8.23350933092135e-002;
    __statist_i_h_wts[19,188]=9.16914358579870e-002;
    __statist_i_h_wts[19,189]=4.43619382167135e-001;
    __statist_i_h_wts[19,190]=3.26931074996164e-001;
    __statist_i_h_wts[19,191]=2.29644292862734e-001;
    __statist_i_h_wts[19,192]=6.24747231308293e-001;
    __statist_i_h_wts[19,193]=6.59939223030224e-001;
    __statist_i_h_wts[19,194]=5.83896784329363e-002;
    __statist_i_h_wts[19,195]=4.41157496875761e-001;
    __statist_i_h_wts[19,196]=-9.42175124784434e-002;
    __statist_i_h_wts[19,197]=1.52852113563806e-001;
    __statist_i_h_wts[19,198]=5.48272804560889e-001;
    __statist_i_h_wts[19,199]=2.02149612841945e-001;
    __statist_i_h_wts[19,200]=6.35728110569790e-002;
    __statist_i_h_wts[19,201]=-1.00970733889242e-002;
    __statist_i_h_wts[19,202]=-1.75381199055361e-001;
    __statist_i_h_wts[19,203]=-2.80301003669223e-002;
    __statist_i_h_wts[19,204]=3.95307939426664e-001;
    __statist_i_h_wts[19,205]=4.34342612779352e-001;
    __statist_i_h_wts[19,206]=4.45400638570780e-001;
    __statist_i_h_wts[19,207]=7.40554750227459e-002;
    __statist_i_h_wts[19,208]=2.99111308254478e-001;
    __statist_i_h_wts[19,209]=-1.19307818325268e-001;
    __statist_i_h_wts[19,210]=5.71233079865127e-001;
    __statist_i_h_wts[19,211]=3.13322004932437e-002;
    __statist_i_h_wts[19,212]=3.68955996756813e-001;
    __statist_i_h_wts[19,213]=4.25143101694530e-001;
    __statist_i_h_wts[19,214]=1.14578208999447e-002;
    __statist_i_h_wts[19,215]=-1.65203860061540e-001;
    __statist_i_h_wts[19,216]=-4.41235262578286e-001;
    __statist_i_h_wts[19,217]=-5.14305951842931e-001;
    __statist_i_h_wts[19,218]=-6.05047878767427e-001;
    __statist_i_h_wts[19,219]=-3.71352201265382e-002;
    __statist_i_h_wts[19,220]=2.90835004104616e-001;
    __statist_i_h_wts[19,221]=4.88981667587796e-001;
    __statist_i_h_wts[19,222]=1.94273227168964e-001;
    __statist_i_h_wts[19,223]=1.36455248570056e-001;
    __statist_i_h_wts[19,224]=2.61952921811886e-001;
    __statist_i_h_wts[19,225]=-1.44889819272447e-001;
    __statist_i_h_wts[19,226]=7.58869767883767e-001;
    __statist_i_h_wts[19,227]=4.82831068916702e-001;
    __statist_i_h_wts[19,228]=2.31471425896922e-001;
    __statist_i_h_wts[19,229]=5.91768263819779e-001;
    __statist_i_h_wts[19,230]=-9.39415913135804e-001;
    __statist_i_h_wts[19,231]=-8.33681582278625e-001;
    __statist_i_h_wts[19,232]=-1.68287760891971e+000;
    __statist_i_h_wts[19,233]=-3.03320997639038e-001;
    __statist_i_h_wts[19,234]=-4.99673305713649e-001;
    __statist_i_h_wts[19,235]=8.79662423610486e-001;
    __statist_i_h_wts[19,236]=3.29345330793373e+000;
    __statist_i_h_wts[19,237]=-7.46138549874027e-001;
    __statist_i_h_wts[19,238]=5.37349054495280e-002;
    __statist_i_h_wts[19,239]=8.16967244286721e-001;
    __statist_i_h_wts[19,240]=1.00463334541641e+000;
    __statist_i_h_wts[19,241]=-1.51292372741169e+000;
    __statist_i_h_wts[19,242]=-1.39154396097376e+000;
    __statist_i_h_wts[19,243]=-3.14358321259304e-001;
    __statist_i_h_wts[19,244]=1.56211779690515e-002;
    __statist_i_h_wts[19,245]=9.57668489639705e-001;
    __statist_i_h_wts[19,246]=5.43702334653897e-002;
    __statist_i_h_wts[19,247]=-4.16129171754443e-001;
    __statist_i_h_wts[19,248]=2.70353658550504e-001;

    __statist_i_h_wts[20,0]=-4.67394363662434e-001;
    __statist_i_h_wts[20,1]=-3.84387473377347e-001;
    __statist_i_h_wts[20,2]=-3.65927929528880e-001;
    __statist_i_h_wts[20,3]=-2.17623264824342e-001;
    __statist_i_h_wts[20,4]=-1.71117161184435e-001;
    __statist_i_h_wts[20,5]=-1.73327473334391e-001;
    __statist_i_h_wts[20,6]=-8.08682052637486e-002;
    __statist_i_h_wts[20,7]=-3.16623540027750e-002;
    __statist_i_h_wts[20,8]=7.48726409283199e-002;
    __statist_i_h_wts[20,9]=5.21750260423588e-002;
    __statist_i_h_wts[20,10]=2.41240746162346e-001;
    __statist_i_h_wts[20,11]=1.57714196570766e-001;
    __statist_i_h_wts[20,12]=1.82318613803043e-001;
    __statist_i_h_wts[20,13]=2.61644934880700e-001;
    __statist_i_h_wts[20,14]=3.10736434390187e-001;
    __statist_i_h_wts[20,15]=-5.08368287073523e-001;
    __statist_i_h_wts[20,16]=-4.01221424148796e-001;
    __statist_i_h_wts[20,17]=-4.11659731566635e-001;
    __statist_i_h_wts[20,18]=-2.97926271455116e-001;
    __statist_i_h_wts[20,19]=-2.47717873921904e-001;
    __statist_i_h_wts[20,20]=-2.33149800058439e-001;
    __statist_i_h_wts[20,21]=-9.30795057217986e-002;
    __statist_i_h_wts[20,22]=-4.71683401616261e-002;
    __statist_i_h_wts[20,23]=1.09106650344774e-001;
    __statist_i_h_wts[20,24]=1.34121738247666e-001;
    __statist_i_h_wts[20,25]=2.72977542554464e-001;
    __statist_i_h_wts[20,26]=1.49366499044556e-001;
    __statist_i_h_wts[20,27]=1.93279918648423e-001;
    __statist_i_h_wts[20,28]=2.50624965803725e-001;
    __statist_i_h_wts[20,29]=2.89836013254794e-001;
    __statist_i_h_wts[20,30]=-4.48336844069925e-001;
    __statist_i_h_wts[20,31]=-3.96245499398395e-001;
    __statist_i_h_wts[20,32]=-3.96116113091610e-001;
    __statist_i_h_wts[20,33]=-2.74811917474954e-001;
    __statist_i_h_wts[20,34]=-1.85436475316797e-001;
    __statist_i_h_wts[20,35]=-1.97682372718514e-001;
    __statist_i_h_wts[20,36]=-2.22673946205888e-002;
    __statist_i_h_wts[20,37]=3.53049579213262e-002;
    __statist_i_h_wts[20,38]=1.07785587958227e-001;
    __statist_i_h_wts[20,39]=1.85237170933724e-001;
    __statist_i_h_wts[20,40]=2.49520598177024e-001;
    __statist_i_h_wts[20,41]=2.46431343194178e-001;
    __statist_i_h_wts[20,42]=2.52941725991066e-001;
    __statist_i_h_wts[20,43]=3.08512398717811e-001;
    __statist_i_h_wts[20,44]=3.22327611474587e-001;
    __statist_i_h_wts[20,45]=-3.78892808015823e-001;
    __statist_i_h_wts[20,46]=-3.82281810844262e-001;
    __statist_i_h_wts[20,47]=-4.05301896143230e-001;
    __statist_i_h_wts[20,48]=-3.08990827912879e-001;
    __statist_i_h_wts[20,49]=-1.80869394309016e-001;
    __statist_i_h_wts[20,50]=-1.50914559511114e-001;
    __statist_i_h_wts[20,51]=-7.79281774873024e-002;
    __statist_i_h_wts[20,52]=-2.39260500724252e-002;
    __statist_i_h_wts[20,53]=1.25007965332197e-002;
    __statist_i_h_wts[20,54]=8.93483289219927e-002;
    __statist_i_h_wts[20,55]=1.60168249603404e-001;
    __statist_i_h_wts[20,56]=2.12670810549796e-001;
    __statist_i_h_wts[20,57]=1.97446347114526e-001;
    __statist_i_h_wts[20,58]=3.14360158000535e-001;
    __statist_i_h_wts[20,59]=2.79551954724677e-001;
    __statist_i_h_wts[20,60]=-3.62936766149430e-001;
    __statist_i_h_wts[20,61]=-3.87291140533542e-001;
    __statist_i_h_wts[20,62]=-4.15067796529051e-001;
    __statist_i_h_wts[20,63]=-4.09197685256261e-001;
    __statist_i_h_wts[20,64]=-2.75460516442652e-001;
    __statist_i_h_wts[20,65]=-2.81844439131643e-001;
    __statist_i_h_wts[20,66]=-1.61441443440147e-001;
    __statist_i_h_wts[20,67]=-1.35150946723993e-001;
    __statist_i_h_wts[20,68]=-4.10472104157458e-002;
    __statist_i_h_wts[20,69]=6.10360620063396e-002;
    __statist_i_h_wts[20,70]=1.41176563301871e-001;
    __statist_i_h_wts[20,71]=1.94663972459063e-001;
    __statist_i_h_wts[20,72]=1.96463802972830e-001;
    __statist_i_h_wts[20,73]=2.78519048550023e-001;
    __statist_i_h_wts[20,74]=2.60468967652897e-001;
    __statist_i_h_wts[20,75]=-3.48408865164974e-001;
    __statist_i_h_wts[20,76]=-3.10823537574030e-001;
    __statist_i_h_wts[20,77]=-3.86216933710431e-001;
    __statist_i_h_wts[20,78]=-4.83784055394608e-001;
    __statist_i_h_wts[20,79]=-3.50005290380047e-001;
    __statist_i_h_wts[20,80]=-2.94048397966615e-001;
    __statist_i_h_wts[20,81]=-2.01113306884831e-001;
    __statist_i_h_wts[20,82]=-9.15263814098768e-002;
    __statist_i_h_wts[20,83]=-1.13878331032013e-002;
    __statist_i_h_wts[20,84]=-1.73021966536104e-005;
    __statist_i_h_wts[20,85]=3.40094073475869e-002;
    __statist_i_h_wts[20,86]=1.08334527426872e-001;
    __statist_i_h_wts[20,87]=1.41360415514776e-001;
    __statist_i_h_wts[20,88]=2.03602913896417e-001;
    __statist_i_h_wts[20,89]=2.04890578643541e-001;
    __statist_i_h_wts[20,90]=-2.39919727684594e-001;
    __statist_i_h_wts[20,91]=-3.07355214919185e-001;
    __statist_i_h_wts[20,92]=-3.81230475967885e-001;
    __statist_i_h_wts[20,93]=-4.75742566038759e-001;
    __statist_i_h_wts[20,94]=-3.52781556832339e-001;
    __statist_i_h_wts[20,95]=-2.33423615271924e-001;
    __statist_i_h_wts[20,96]=-1.44602120978710e-001;
    __statist_i_h_wts[20,97]=-3.12635057681014e-002;
    __statist_i_h_wts[20,98]=-9.59129502430422e-002;
    __statist_i_h_wts[20,99]=1.61150634719549e-002;
    __statist_i_h_wts[20,100]=3.24850168454735e-002;
    __statist_i_h_wts[20,101]=1.07108418758172e-001;
    __statist_i_h_wts[20,102]=1.13774987807301e-001;
    __statist_i_h_wts[20,103]=1.70058607694625e-001;
    __statist_i_h_wts[20,104]=1.80385424317069e-001;
    __statist_i_h_wts[20,105]=-3.07799575946849e-001;
    __statist_i_h_wts[20,106]=-3.58880184134013e-001;
    __statist_i_h_wts[20,107]=-3.78071797616098e-001;
    __statist_i_h_wts[20,108]=-3.66295346588518e-001;
    __statist_i_h_wts[20,109]=-2.92626392213551e-001;
    __statist_i_h_wts[20,110]=-2.30950928314690e-001;
    __statist_i_h_wts[20,111]=1.64254389707683e-003;
    __statist_i_h_wts[20,112]=7.80305581179211e-003;
    __statist_i_h_wts[20,113]=-9.20585576211899e-002;
    __statist_i_h_wts[20,114]=-5.90772907285214e-002;
    __statist_i_h_wts[20,115]=9.62042393487316e-003;
    __statist_i_h_wts[20,116]=1.25501144955262e-001;
    __statist_i_h_wts[20,117]=5.07128601757292e-003;
    __statist_i_h_wts[20,118]=1.27329086004045e-001;
    __statist_i_h_wts[20,119]=1.38563581467984e-001;
    __statist_i_h_wts[20,120]=-1.41502044739216e-001;
    __statist_i_h_wts[20,121]=-1.78591719034488e-001;
    __statist_i_h_wts[20,122]=-2.41471662383975e-001;
    __statist_i_h_wts[20,123]=-2.27889342698554e-001;
    __statist_i_h_wts[20,124]=-2.28882464271379e-001;
    __statist_i_h_wts[20,125]=-1.88825898107718e-001;
    __statist_i_h_wts[20,126]=-3.27572709178367e-002;
    __statist_i_h_wts[20,127]=-5.40861229469327e-002;
    __statist_i_h_wts[20,128]=-4.71403420580285e-002;
    __statist_i_h_wts[20,129]=1.05757615456189e-002;
    __statist_i_h_wts[20,130]=3.90251973851190e-002;
    __statist_i_h_wts[20,131]=1.25469394149517e-001;
    __statist_i_h_wts[20,132]=9.65752011410590e-002;
    __statist_i_h_wts[20,133]=1.61997611743104e-001;
    __statist_i_h_wts[20,134]=1.45205522934471e-001;
    __statist_i_h_wts[20,135]=-3.02643310636012e-001;
    __statist_i_h_wts[20,136]=-3.12459916547803e-001;
    __statist_i_h_wts[20,137]=-3.54383675894063e-001;
    __statist_i_h_wts[20,138]=-2.58008171771194e-001;
    __statist_i_h_wts[20,139]=-3.02304463274323e-001;
    __statist_i_h_wts[20,140]=-2.38112923712368e-001;
    __statist_i_h_wts[20,141]=-1.79025595376126e-001;
    __statist_i_h_wts[20,142]=-5.16272384940861e-002;
    __statist_i_h_wts[20,143]=6.10070533416276e-003;
    __statist_i_h_wts[20,144]=1.06781072393024e-001;
    __statist_i_h_wts[20,145]=3.77952941423369e-002;
    __statist_i_h_wts[20,146]=1.44760094290444e-001;
    __statist_i_h_wts[20,147]=7.59412990361882e-002;
    __statist_i_h_wts[20,148]=1.15801422112478e-001;
    __statist_i_h_wts[20,149]=8.51310946703025e-002;
    __statist_i_h_wts[20,150]=-2.42570267659325e-001;
    __statist_i_h_wts[20,151]=-2.50480200192070e-001;
    __statist_i_h_wts[20,152]=-2.60920384995406e-001;
    __statist_i_h_wts[20,153]=-2.12569326719461e-001;
    __statist_i_h_wts[20,154]=-1.31665686826020e-001;
    __statist_i_h_wts[20,155]=-1.19224884549263e-001;
    __statist_i_h_wts[20,156]=-2.13498202031295e-002;
    __statist_i_h_wts[20,157]=4.21214554774480e-002;
    __statist_i_h_wts[20,158]=9.69916184290962e-002;
    __statist_i_h_wts[20,159]=1.64944049272315e-001;
    __statist_i_h_wts[20,160]=1.42547703834111e-001;
    __statist_i_h_wts[20,161]=1.49214935324059e-001;
    __statist_i_h_wts[20,162]=1.19108499872366e-001;
    __statist_i_h_wts[20,163]=7.27749735398481e-002;
    __statist_i_h_wts[20,164]=3.11055766603897e-002;
    __statist_i_h_wts[20,165]=-1.48938142923660e-001;
    __statist_i_h_wts[20,166]=-2.11316364255300e-001;
    __statist_i_h_wts[20,167]=-2.08381164729093e-001;
    __statist_i_h_wts[20,168]=-5.95447890673657e-002;
    __statist_i_h_wts[20,169]=-4.82002659588491e-002;
    __statist_i_h_wts[20,170]=2.94947469146548e-002;
    __statist_i_h_wts[20,171]=5.34813332395203e-002;
    __statist_i_h_wts[20,172]=2.10468102142575e-002;
    __statist_i_h_wts[20,173]=6.79055800501428e-002;
    __statist_i_h_wts[20,174]=1.01834928476210e-001;
    __statist_i_h_wts[20,175]=1.29048308200085e-001;
    __statist_i_h_wts[20,176]=1.60852304328218e-001;
    __statist_i_h_wts[20,177]=1.36967023278641e-001;
    __statist_i_h_wts[20,178]=1.33941023818370e-001;
    __statist_i_h_wts[20,179]=6.84546494693667e-002;
    __statist_i_h_wts[20,180]=-1.69697627387490e-001;
    __statist_i_h_wts[20,181]=-2.66943870067286e-001;
    __statist_i_h_wts[20,182]=-2.42182146705591e-001;
    __statist_i_h_wts[20,183]=-1.21354398317418e-001;
    __statist_i_h_wts[20,184]=-8.52819193775017e-002;
    __statist_i_h_wts[20,185]=-9.10043119614737e-002;
    __statist_i_h_wts[20,186]=-2.80144685038758e-002;
    __statist_i_h_wts[20,187]=2.74927003787538e-002;
    __statist_i_h_wts[20,188]=8.74122162546293e-002;
    __statist_i_h_wts[20,189]=1.12994314712550e-001;
    __statist_i_h_wts[20,190]=1.24543059233048e-001;
    __statist_i_h_wts[20,191]=1.44066429278047e-001;
    __statist_i_h_wts[20,192]=2.12544035880644e-001;
    __statist_i_h_wts[20,193]=1.40168240673859e-001;
    __statist_i_h_wts[20,194]=1.04158029935274e-001;
    __statist_i_h_wts[20,195]=-1.24190955998143e-001;
    __statist_i_h_wts[20,196]=-1.50895865116490e-001;
    __statist_i_h_wts[20,197]=-1.26110043655928e-001;
    __statist_i_h_wts[20,198]=-8.81593346242593e-002;
    __statist_i_h_wts[20,199]=-4.74952633549110e-002;
    __statist_i_h_wts[20,200]=-4.05024397352589e-002;
    __statist_i_h_wts[20,201]=2.36315506266280e-002;
    __statist_i_h_wts[20,202]=7.32183441159463e-002;
    __statist_i_h_wts[20,203]=5.61043745799723e-002;
    __statist_i_h_wts[20,204]=1.02727217222688e-001;
    __statist_i_h_wts[20,205]=1.21618913817318e-001;
    __statist_i_h_wts[20,206]=1.28410418435344e-001;
    __statist_i_h_wts[20,207]=1.17126944517649e-001;
    __statist_i_h_wts[20,208]=9.85247622208073e-002;
    __statist_i_h_wts[20,209]=7.53333751254270e-002;
    __statist_i_h_wts[20,210]=-9.13625843081332e-002;
    __statist_i_h_wts[20,211]=-8.61609194778748e-002;
    __statist_i_h_wts[20,212]=-1.14479696332523e-001;
    __statist_i_h_wts[20,213]=-5.48313823913077e-002;
    __statist_i_h_wts[20,214]=5.20374923920822e-003;
    __statist_i_h_wts[20,215]=5.04062052703768e-002;
    __statist_i_h_wts[20,216]=6.11588700072118e-002;
    __statist_i_h_wts[20,217]=7.65806892597119e-002;
    __statist_i_h_wts[20,218]=1.57240143792927e-001;
    __statist_i_h_wts[20,219]=1.30027915296592e-001;
    __statist_i_h_wts[20,220]=1.25978981107442e-001;
    __statist_i_h_wts[20,221]=1.14175591933616e-001;
    __statist_i_h_wts[20,222]=1.24313865032361e-001;
    __statist_i_h_wts[20,223]=9.38392047929596e-002;
    __statist_i_h_wts[20,224]=9.55731669832068e-002;
    __statist_i_h_wts[20,225]=-4.05572902709735e-003;
    __statist_i_h_wts[20,226]=-1.84140776064532e-001;
    __statist_i_h_wts[20,227]=3.50811752309262e-002;
    __statist_i_h_wts[20,228]=-3.24132412851101e-002;
    __statist_i_h_wts[20,229]=1.03241365978336e-001;
    __statist_i_h_wts[20,230]=2.37018343583072e-001;
    __statist_i_h_wts[20,231]=1.77874775965829e-001;
    __statist_i_h_wts[20,232]=5.03979386918530e-001;
    __statist_i_h_wts[20,233]=1.29780816498843e-001;
    __statist_i_h_wts[20,234]=3.20087356987762e-001;
    __statist_i_h_wts[20,235]=-1.45147220882502e-001;
    __statist_i_h_wts[20,236]=-3.28735773174570e-001;
    __statist_i_h_wts[20,237]=-3.45197454580233e-001;
    __statist_i_h_wts[20,238]=-6.61209606620726e-002;
    __statist_i_h_wts[20,239]=3.40682172195196e-001;
    __statist_i_h_wts[20,240]=-1.09941911975454e-001;
    __statist_i_h_wts[20,241]=2.50264977226609e-001;
    __statist_i_h_wts[20,242]=-2.42067744963693e-002;
    __statist_i_h_wts[20,243]=2.58456266702416e-001;
    __statist_i_h_wts[20,244]=-1.68336571137927e-001;
    __statist_i_h_wts[20,245]=-2.52587346930528e-001;
    __statist_i_h_wts[20,246]=6.20213356829053e-002;
    __statist_i_h_wts[20,247]=-1.93295783653841e-001;
    __statist_i_h_wts[20,248]=-3.85474902014175e-002;

    __statist_i_h_wts[21,0]=8.75603779491408e-001;
    __statist_i_h_wts[21,1]=8.51442509640478e-001;
    __statist_i_h_wts[21,2]=8.23193009116278e-001;
    __statist_i_h_wts[21,3]=5.96377868229521e-001;
    __statist_i_h_wts[21,4]=4.45608136260938e-001;
    __statist_i_h_wts[21,5]=3.14507268064391e-001;
    __statist_i_h_wts[21,6]=1.29950695672547e-001;
    __statist_i_h_wts[21,7]=8.47877464824837e-002;
    __statist_i_h_wts[21,8]=-4.99189074828957e-002;
    __statist_i_h_wts[21,9]=-1.20014632291011e-001;
    __statist_i_h_wts[21,10]=-2.42391215773929e-001;
    __statist_i_h_wts[21,11]=-2.23994586126264e-001;
    __statist_i_h_wts[21,12]=-2.93209105838189e-001;
    __statist_i_h_wts[21,13]=-3.77347602457627e-001;
    __statist_i_h_wts[21,14]=-5.44154569243948e-001;
    __statist_i_h_wts[21,15]=9.52946321993034e-001;
    __statist_i_h_wts[21,16]=9.48203127647788e-001;
    __statist_i_h_wts[21,17]=8.65029091934246e-001;
    __statist_i_h_wts[21,18]=6.59125746364115e-001;
    __statist_i_h_wts[21,19]=5.28089416765479e-001;
    __statist_i_h_wts[21,20]=3.93982875571146e-001;
    __statist_i_h_wts[21,21]=2.17785409689591e-001;
    __statist_i_h_wts[21,22]=8.06112774795147e-002;
    __statist_i_h_wts[21,23]=-5.70775328827166e-002;
    __statist_i_h_wts[21,24]=-1.46690111031361e-001;
    __statist_i_h_wts[21,25]=-2.16689870631891e-001;
    __statist_i_h_wts[21,26]=-2.14275716788615e-001;
    __statist_i_h_wts[21,27]=-2.89544235995097e-001;
    __statist_i_h_wts[21,28]=-3.57855293363183e-001;
    __statist_i_h_wts[21,29]=-5.05455930826629e-001;
    __statist_i_h_wts[21,30]=1.14992120297982e+000;
    __statist_i_h_wts[21,31]=1.02630097960874e+000;
    __statist_i_h_wts[21,32]=9.32454663054419e-001;
    __statist_i_h_wts[21,33]=7.68757402512389e-001;
    __statist_i_h_wts[21,34]=6.19405076049618e-001;
    __statist_i_h_wts[21,35]=4.68619040864610e-001;
    __statist_i_h_wts[21,36]=2.89178710586032e-001;
    __statist_i_h_wts[21,37]=8.30354699825927e-002;
    __statist_i_h_wts[21,38]=-4.41813592435435e-002;
    __statist_i_h_wts[21,39]=-1.80579645919719e-001;
    __statist_i_h_wts[21,40]=-2.03598144599490e-001;
    __statist_i_h_wts[21,41]=-2.08249688473072e-001;
    __statist_i_h_wts[21,42]=-3.52708166962570e-001;
    __statist_i_h_wts[21,43]=-4.06430919204898e-001;
    __statist_i_h_wts[21,44]=-5.25623808720436e-001;
    __statist_i_h_wts[21,45]=1.16148883764191e+000;
    __statist_i_h_wts[21,46]=1.12447644456113e+000;
    __statist_i_h_wts[21,47]=1.05695886428744e+000;
    __statist_i_h_wts[21,48]=8.70278876944872e-001;
    __statist_i_h_wts[21,49]=8.13120288650842e-001;
    __statist_i_h_wts[21,50]=5.43980365895729e-001;
    __statist_i_h_wts[21,51]=3.79871278735884e-001;
    __statist_i_h_wts[21,52]=1.31948010114713e-001;
    __statist_i_h_wts[21,53]=-5.80506430898852e-002;
    __statist_i_h_wts[21,54]=-2.14030229625758e-001;
    __statist_i_h_wts[21,55]=-3.36891343700306e-001;
    __statist_i_h_wts[21,56]=-3.76328845197032e-001;
    __statist_i_h_wts[21,57]=-4.35656435477302e-001;
    __statist_i_h_wts[21,58]=-5.08701363990301e-001;
    __statist_i_h_wts[21,59]=-5.20622101442341e-001;
    __statist_i_h_wts[21,60]=1.12791750556981e+000;
    __statist_i_h_wts[21,61]=1.10594285291381e+000;
    __statist_i_h_wts[21,62]=1.01809666974201e+000;
    __statist_i_h_wts[21,63]=9.04470596836973e-001;
    __statist_i_h_wts[21,64]=8.64137661187444e-001;
    __statist_i_h_wts[21,65]=6.51798414663495e-001;
    __statist_i_h_wts[21,66]=4.14590035707753e-001;
    __statist_i_h_wts[21,67]=6.97623904536605e-002;
    __statist_i_h_wts[21,68]=-8.60697577233525e-002;
    __statist_i_h_wts[21,69]=-2.94251438349336e-001;
    __statist_i_h_wts[21,70]=-3.04072703871861e-001;
    __statist_i_h_wts[21,71]=-3.43711569945692e-001;
    __statist_i_h_wts[21,72]=-4.12837286386581e-001;
    __statist_i_h_wts[21,73]=-5.00650646203605e-001;
    __statist_i_h_wts[21,74]=-5.02576190927671e-001;
    __statist_i_h_wts[21,75]=1.01981303507829e+000;
    __statist_i_h_wts[21,76]=1.02162762038248e+000;
    __statist_i_h_wts[21,77]=9.43049373045447e-001;
    __statist_i_h_wts[21,78]=9.72209923492179e-001;
    __statist_i_h_wts[21,79]=8.66611555399659e-001;
    __statist_i_h_wts[21,80]=7.10309005253212e-001;
    __statist_i_h_wts[21,81]=4.50660478375928e-001;
    __statist_i_h_wts[21,82]=1.35522178632500e-001;
    __statist_i_h_wts[21,83]=-9.84050764057141e-002;
    __statist_i_h_wts[21,84]=-2.30242973109985e-001;
    __statist_i_h_wts[21,85]=-2.41407425558304e-001;
    __statist_i_h_wts[21,86]=-2.39912590150312e-001;
    __statist_i_h_wts[21,87]=-3.15027490620467e-001;
    __statist_i_h_wts[21,88]=-4.06504875866759e-001;
    __statist_i_h_wts[21,89]=-4.58459774591146e-001;
    __statist_i_h_wts[21,90]=1.07527066566771e+000;
    __statist_i_h_wts[21,91]=1.01840732276035e+000;
    __statist_i_h_wts[21,92]=9.53337832155421e-001;
    __statist_i_h_wts[21,93]=9.34016827695242e-001;
    __statist_i_h_wts[21,94]=8.05211575093060e-001;
    __statist_i_h_wts[21,95]=5.66241724130790e-001;
    __statist_i_h_wts[21,96]=3.53030639734845e-001;
    __statist_i_h_wts[21,97]=1.30497121962347e-001;
    __statist_i_h_wts[21,98]=-6.33556736146821e-003;
    __statist_i_h_wts[21,99]=-1.94745371814800e-001;
    __statist_i_h_wts[21,100]=-1.99784725411768e-001;
    __statist_i_h_wts[21,101]=-2.33939454749630e-001;
    __statist_i_h_wts[21,102]=-3.39009155469348e-001;
    __statist_i_h_wts[21,103]=-4.24924647803406e-001;
    __statist_i_h_wts[21,104]=-4.57190660641020e-001;
    __statist_i_h_wts[21,105]=8.77105682203669e-001;
    __statist_i_h_wts[21,106]=8.47210323149031e-001;
    __statist_i_h_wts[21,107]=7.91670875849296e-001;
    __statist_i_h_wts[21,108]=7.39823818290604e-001;
    __statist_i_h_wts[21,109]=6.01800491041691e-001;
    __statist_i_h_wts[21,110]=4.37588453111180e-001;
    __statist_i_h_wts[21,111]=1.39051279634713e-001;
    __statist_i_h_wts[21,112]=1.09360546324046e-001;
    __statist_i_h_wts[21,113]=-9.78592536559794e-002;
    __statist_i_h_wts[21,114]=-1.97649736783510e-001;
    __statist_i_h_wts[21,115]=-1.93067728699779e-001;
    __statist_i_h_wts[21,116]=-2.46769701649048e-001;
    __statist_i_h_wts[21,117]=-3.38017657609006e-001;
    __statist_i_h_wts[21,118]=-3.88552783554751e-001;
    __statist_i_h_wts[21,119]=-4.16283527086367e-001;
    __statist_i_h_wts[21,120]=7.16053250645385e-001;
    __statist_i_h_wts[21,121]=6.38389209321433e-001;
    __statist_i_h_wts[21,122]=6.53892779011228e-001;
    __statist_i_h_wts[21,123]=5.52475690426734e-001;
    __statist_i_h_wts[21,124]=4.14825855482108e-001;
    __statist_i_h_wts[21,125]=2.98942734819621e-001;
    __statist_i_h_wts[21,126]=1.09052185407827e-001;
    __statist_i_h_wts[21,127]=4.66815858800950e-002;
    __statist_i_h_wts[21,128]=-1.27322114414770e-001;
    __statist_i_h_wts[21,129]=-2.57251483192925e-001;
    __statist_i_h_wts[21,130]=-3.11186053859943e-001;
    __statist_i_h_wts[21,131]=-3.44199997085092e-001;
    __statist_i_h_wts[21,132]=-4.98070330998356e-001;
    __statist_i_h_wts[21,133]=-4.96030728306995e-001;
    __statist_i_h_wts[21,134]=-4.17559028886322e-001;
    __statist_i_h_wts[21,135]=6.37703549525106e-001;
    __statist_i_h_wts[21,136]=6.12018164415137e-001;
    __statist_i_h_wts[21,137]=6.26264646285659e-001;
    __statist_i_h_wts[21,138]=5.33860142958255e-001;
    __statist_i_h_wts[21,139]=3.90959624051392e-001;
    __statist_i_h_wts[21,140]=2.62366948762571e-001;
    __statist_i_h_wts[21,141]=7.33522869457943e-002;
    __statist_i_h_wts[21,142]=-3.02375779554413e-002;
    __statist_i_h_wts[21,143]=-1.76275763700003e-001;
    __statist_i_h_wts[21,144]=-2.89764309527087e-001;
    __statist_i_h_wts[21,145]=-2.95322750827912e-001;
    __statist_i_h_wts[21,146]=-3.38708554744694e-001;
    __statist_i_h_wts[21,147]=-4.19861814524757e-001;
    __statist_i_h_wts[21,148]=-4.17949532484313e-001;
    __statist_i_h_wts[21,149]=-3.15344625938467e-001;
    __statist_i_h_wts[21,150]=6.16250531644298e-001;
    __statist_i_h_wts[21,151]=6.03673292631702e-001;
    __statist_i_h_wts[21,152]=5.71341984850080e-001;
    __statist_i_h_wts[21,153]=5.19585148288501e-001;
    __statist_i_h_wts[21,154]=3.30279394876201e-001;
    __statist_i_h_wts[21,155]=1.56930868673397e-001;
    __statist_i_h_wts[21,156]=-2.96086768932943e-002;
    __statist_i_h_wts[21,157]=-7.96964122673436e-002;
    __statist_i_h_wts[21,158]=-1.42421634152841e-001;
    __statist_i_h_wts[21,159]=-1.99883962420206e-001;
    __statist_i_h_wts[21,160]=-3.05468404825446e-001;
    __statist_i_h_wts[21,161]=-3.62640349833572e-001;
    __statist_i_h_wts[21,162]=-4.75845922413095e-001;
    __statist_i_h_wts[21,163]=-3.52456788982376e-001;
    __statist_i_h_wts[21,164]=-2.06993191916375e-001;
    __statist_i_h_wts[21,165]=3.17390035388999e-001;
    __statist_i_h_wts[21,166]=4.04398515137184e-001;
    __statist_i_h_wts[21,167]=3.79554447421498e-001;
    __statist_i_h_wts[21,168]=2.07582927021682e-001;
    __statist_i_h_wts[21,169]=1.06963800979615e-001;
    __statist_i_h_wts[21,170]=-3.65469064031373e-002;
    __statist_i_h_wts[21,171]=-1.53799198408809e-001;
    __statist_i_h_wts[21,172]=-1.12465959500554e-001;
    __statist_i_h_wts[21,173]=-1.32105599316241e-001;
    __statist_i_h_wts[21,174]=-1.88532142775974e-001;
    __statist_i_h_wts[21,175]=-2.82288813412132e-001;
    __statist_i_h_wts[21,176]=-3.47715752805116e-001;
    __statist_i_h_wts[21,177]=-4.09587674549207e-001;
    __statist_i_h_wts[21,178]=-4.25949380973114e-001;
    __statist_i_h_wts[21,179]=-2.89550281417985e-001;
    __statist_i_h_wts[21,180]=2.55789544602749e-001;
    __statist_i_h_wts[21,181]=3.40233713735817e-001;
    __statist_i_h_wts[21,182]=2.58461574674072e-001;
    __statist_i_h_wts[21,183]=1.19032731671276e-001;
    __statist_i_h_wts[21,184]=7.30935949378669e-002;
    __statist_i_h_wts[21,185]=2.52863513395951e-002;
    __statist_i_h_wts[21,186]=-1.40789570206491e-001;
    __statist_i_h_wts[21,187]=-1.46894342530100e-001;
    __statist_i_h_wts[21,188]=-2.29993421734037e-001;
    __statist_i_h_wts[21,189]=-2.87916094900674e-001;
    __statist_i_h_wts[21,190]=-3.52299688738248e-001;
    __statist_i_h_wts[21,191]=-3.78069039030367e-001;
    __statist_i_h_wts[21,192]=-4.91588638491692e-001;
    __statist_i_h_wts[21,193]=-4.69260539979068e-001;
    __statist_i_h_wts[21,194]=-4.11105089265628e-001;
    __statist_i_h_wts[21,195]=1.68235225373838e-001;
    __statist_i_h_wts[21,196]=1.75646985466556e-001;
    __statist_i_h_wts[21,197]=1.61559311230291e-001;
    __statist_i_h_wts[21,198]=5.87223696312229e-002;
    __statist_i_h_wts[21,199]=9.29277792455436e-003;
    __statist_i_h_wts[21,200]=1.74551201600688e-002;
    __statist_i_h_wts[21,201]=-1.19760799922954e-001;
    __statist_i_h_wts[21,202]=-1.48413798841847e-001;
    __statist_i_h_wts[21,203]=-1.65180333424266e-001;
    __statist_i_h_wts[21,204]=-2.56004397998739e-001;
    __statist_i_h_wts[21,205]=-3.45157144099537e-001;
    __statist_i_h_wts[21,206]=-3.52696531663986e-001;
    __statist_i_h_wts[21,207]=-4.60342156669500e-001;
    __statist_i_h_wts[21,208]=-4.95649773846241e-001;
    __statist_i_h_wts[21,209]=-3.88400840668222e-001;
    __statist_i_h_wts[21,210]=7.28179947802736e-002;
    __statist_i_h_wts[21,211]=9.06635456650137e-002;
    __statist_i_h_wts[21,212]=1.30933109381064e-001;
    __statist_i_h_wts[21,213]=-5.14003945773963e-003;
    __statist_i_h_wts[21,214]=-5.14279523312739e-002;
    __statist_i_h_wts[21,215]=-5.92532994798685e-002;
    __statist_i_h_wts[21,216]=-9.15379452256276e-002;
    __statist_i_h_wts[21,217]=-1.01262996727326e-001;
    __statist_i_h_wts[21,218]=-1.47662843817397e-001;
    __statist_i_h_wts[21,219]=-2.03525166197126e-001;
    __statist_i_h_wts[21,220]=-2.45321868687822e-001;
    __statist_i_h_wts[21,221]=-2.46345007874259e-001;
    __statist_i_h_wts[21,222]=-3.67272150612593e-001;
    __statist_i_h_wts[21,223]=-4.22744069697146e-001;
    __statist_i_h_wts[21,224]=-3.60065133946622e-001;
    __statist_i_h_wts[21,225]=1.03056009980566e-001;
    __statist_i_h_wts[21,226]=9.59787089757494e-001;
    __statist_i_h_wts[21,227]=-2.38227353971043e-002;
    __statist_i_h_wts[21,228]=7.84586515572671e-001;
    __statist_i_h_wts[21,229]=-1.68610030306379e-001;
    __statist_i_h_wts[21,230]=-1.19089348917528e+000;
    __statist_i_h_wts[21,231]=-3.48986350732299e-001;
    __statist_i_h_wts[21,232]=-2.15622046351334e+000;
    __statist_i_h_wts[21,233]=-6.28543584792946e-001;
    __statist_i_h_wts[21,234]=-1.05778641731128e+000;
    __statist_i_h_wts[21,235]=6.79094949586279e-001;
    __statist_i_h_wts[21,236]=2.48902481628677e+000;
    __statist_i_h_wts[21,237]=9.32196735096611e-001;
    __statist_i_h_wts[21,238]=5.40534989326874e-002;
    __statist_i_h_wts[21,239]=-1.01678624285887e+000;
    __statist_i_h_wts[21,240]=5.28316675721699e-001;
    __statist_i_h_wts[21,241]=-1.68209351717189e+000;
    __statist_i_h_wts[21,242]=-6.56573789522428e-002;
    __statist_i_h_wts[21,243]=-1.15108787384559e+000;
    __statist_i_h_wts[21,244]=4.20169390519427e-001;
    __statist_i_h_wts[21,245]=1.56292771481887e+000;
    __statist_i_h_wts[21,246]=-6.50490974885642e-002;
    __statist_i_h_wts[21,247]=1.06022229931784e+000;
    __statist_i_h_wts[21,248]=-1.29415356550320e-001;

    __statist_i_h_wts[22,0]=4.60719690813057e-001;
    __statist_i_h_wts[22,1]=5.30200763802651e-001;
    __statist_i_h_wts[22,2]=5.14538311283528e-001;
    __statist_i_h_wts[22,3]=4.20879434777866e-001;
    __statist_i_h_wts[22,4]=2.96584745203656e-001;
    __statist_i_h_wts[22,5]=1.36803571289335e-001;
    __statist_i_h_wts[22,6]=8.90839989671349e-002;
    __statist_i_h_wts[22,7]=-1.08716457224286e-003;
    __statist_i_h_wts[22,8]=-1.29168870460205e-001;
    __statist_i_h_wts[22,9]=-2.71435059011465e-001;
    __statist_i_h_wts[22,10]=-2.03500652951502e-001;
    __statist_i_h_wts[22,11]=-2.91527590959325e-001;
    __statist_i_h_wts[22,12]=-2.77008677497992e-001;
    __statist_i_h_wts[22,13]=-2.85986917864166e-001;
    __statist_i_h_wts[22,14]=-3.09426817378049e-001;
    __statist_i_h_wts[22,15]=4.89556169489971e-001;
    __statist_i_h_wts[22,16]=5.92077749788388e-001;
    __statist_i_h_wts[22,17]=5.64103190049272e-001;
    __statist_i_h_wts[22,18]=3.28199635226375e-001;
    __statist_i_h_wts[22,19]=2.56251102496894e-001;
    __statist_i_h_wts[22,20]=1.08022413546262e-001;
    __statist_i_h_wts[22,21]=7.96176966405815e-002;
    __statist_i_h_wts[22,22]=-9.28930364020679e-002;
    __statist_i_h_wts[22,23]=-1.40275109851842e-001;
    __statist_i_h_wts[22,24]=-2.23999327850041e-001;
    __statist_i_h_wts[22,25]=-2.05693599287961e-001;
    __statist_i_h_wts[22,26]=-3.65634516222433e-001;
    __statist_i_h_wts[22,27]=-2.86724594154216e-001;
    __statist_i_h_wts[22,28]=-2.65840898986561e-001;
    __statist_i_h_wts[22,29]=-3.15072699318182e-001;
    __statist_i_h_wts[22,30]=6.81434718005968e-001;
    __statist_i_h_wts[22,31]=6.53721157506648e-001;
    __statist_i_h_wts[22,32]=6.45478776940440e-001;
    __statist_i_h_wts[22,33]=4.67045088141896e-001;
    __statist_i_h_wts[22,34]=3.49012115027261e-001;
    __statist_i_h_wts[22,35]=1.94925401396037e-001;
    __statist_i_h_wts[22,36]=1.49625796724228e-001;
    __statist_i_h_wts[22,37]=1.49559119617969e-002;
    __statist_i_h_wts[22,38]=-3.19546757419392e-002;
    __statist_i_h_wts[22,39]=-1.47994582734639e-001;
    __statist_i_h_wts[22,40]=-1.62402313147281e-001;
    __statist_i_h_wts[22,41]=-3.00896349654655e-001;
    __statist_i_h_wts[22,42]=-3.41663461746919e-001;
    __statist_i_h_wts[22,43]=-2.94458804036180e-001;
    __statist_i_h_wts[22,44]=-2.70844333439248e-001;
    __statist_i_h_wts[22,45]=8.38375164559231e-001;
    __statist_i_h_wts[22,46]=8.57850949699192e-001;
    __statist_i_h_wts[22,47]=8.32983123761746e-001;
    __statist_i_h_wts[22,48]=6.29622943121469e-001;
    __statist_i_h_wts[22,49]=5.55086508132355e-001;
    __statist_i_h_wts[22,50]=3.96984833716662e-001;
    __statist_i_h_wts[22,51]=2.01192949267242e-001;
    __statist_i_h_wts[22,52]=1.80688328302777e-002;
    __statist_i_h_wts[22,53]=-9.25803622510527e-002;
    __statist_i_h_wts[22,54]=-1.74462384832498e-001;
    __statist_i_h_wts[22,55]=-3.44787216505876e-001;
    __statist_i_h_wts[22,56]=-5.40150599316863e-001;
    __statist_i_h_wts[22,57]=-4.24014466110173e-001;
    __statist_i_h_wts[22,58]=-3.68874109951280e-001;
    __statist_i_h_wts[22,59]=-3.09713890132230e-001;
    __statist_i_h_wts[22,60]=7.85556349976927e-001;
    __statist_i_h_wts[22,61]=8.44599909474415e-001;
    __statist_i_h_wts[22,62]=8.32137726886509e-001;
    __statist_i_h_wts[22,63]=6.74539572860150e-001;
    __statist_i_h_wts[22,64]=6.08875833765480e-001;
    __statist_i_h_wts[22,65]=4.55630817029391e-001;
    __statist_i_h_wts[22,66]=2.64230035849393e-001;
    __statist_i_h_wts[22,67]=-4.65114364129350e-002;
    __statist_i_h_wts[22,68]=-1.62811653881375e-001;
    __statist_i_h_wts[22,69]=-2.20476200083145e-001;
    __statist_i_h_wts[22,70]=-2.64772476940192e-001;
    __statist_i_h_wts[22,71]=-4.77645081192052e-001;
    __statist_i_h_wts[22,72]=-3.69360238714109e-001;
    __statist_i_h_wts[22,73]=-3.44605924012739e-001;
    __statist_i_h_wts[22,74]=-3.18911731999339e-001;
    __statist_i_h_wts[22,75]=7.12454852367711e-001;
    __statist_i_h_wts[22,76]=8.24099286825496e-001;
    __statist_i_h_wts[22,77]=6.67033956584228e-001;
    __statist_i_h_wts[22,78]=5.69230632381535e-001;
    __statist_i_h_wts[22,79]=5.37212155848466e-001;
    __statist_i_h_wts[22,80]=6.21409079594221e-001;
    __statist_i_h_wts[22,81]=2.61351702865601e-001;
    __statist_i_h_wts[22,82]=1.33407899789224e-001;
    __statist_i_h_wts[22,83]=-7.92921710509007e-002;
    __statist_i_h_wts[22,84]=-1.08592525703642e-001;
    __statist_i_h_wts[22,85]=-2.02865649086444e-001;
    __statist_i_h_wts[22,86]=-3.17788832872464e-001;
    __statist_i_h_wts[22,87]=-2.97074092336789e-001;
    __statist_i_h_wts[22,88]=-3.31302395746507e-001;
    __statist_i_h_wts[22,89]=-3.47299637486866e-001;
    __statist_i_h_wts[22,90]=7.23827568395873e-001;
    __statist_i_h_wts[22,91]=7.50355660338422e-001;
    __statist_i_h_wts[22,92]=7.35240354044645e-001;
    __statist_i_h_wts[22,93]=5.89525285682401e-001;
    __statist_i_h_wts[22,94]=4.83139144801795e-001;
    __statist_i_h_wts[22,95]=5.76293140850055e-001;
    __statist_i_h_wts[22,96]=3.47747686871099e-001;
    __statist_i_h_wts[22,97]=2.68547146176428e-001;
    __statist_i_h_wts[22,98]=-6.06684299670077e-002;
    __statist_i_h_wts[22,99]=-4.53819305961657e-002;
    __statist_i_h_wts[22,100]=-1.78737413139322e-001;
    __statist_i_h_wts[22,101]=-3.21201252718088e-001;
    __statist_i_h_wts[22,102]=-3.46803369271685e-001;
    __statist_i_h_wts[22,103]=-3.97208222592887e-001;
    __statist_i_h_wts[22,104]=-3.55402722928976e-001;
    __statist_i_h_wts[22,105]=5.96738010700120e-001;
    __statist_i_h_wts[22,106]=7.34674271028285e-001;
    __statist_i_h_wts[22,107]=6.89250126717451e-001;
    __statist_i_h_wts[22,108]=6.50483168976180e-001;
    __statist_i_h_wts[22,109]=6.04100791898952e-001;
    __statist_i_h_wts[22,110]=4.99713042567430e-001;
    __statist_i_h_wts[22,111]=3.24118497818482e-001;
    __statist_i_h_wts[22,112]=2.01246153264797e-001;
    __statist_i_h_wts[22,113]=-8.82764363198553e-002;
    __statist_i_h_wts[22,114]=-1.30840038822732e-001;
    __statist_i_h_wts[22,115]=-2.16995956144443e-001;
    __statist_i_h_wts[22,116]=-2.84864692732456e-001;
    __statist_i_h_wts[22,117]=-3.68411805543659e-001;
    __statist_i_h_wts[22,118]=-3.78944157817050e-001;
    __statist_i_h_wts[22,119]=-3.24011929790756e-001;
    __statist_i_h_wts[22,120]=6.58450690721083e-001;
    __statist_i_h_wts[22,121]=7.40054406830543e-001;
    __statist_i_h_wts[22,122]=6.27531694727439e-001;
    __statist_i_h_wts[22,123]=5.76911005927631e-001;
    __statist_i_h_wts[22,124]=4.39206180150787e-001;
    __statist_i_h_wts[22,125]=4.01029747783425e-001;
    __statist_i_h_wts[22,126]=1.89810528559165e-001;
    __statist_i_h_wts[22,127]=9.10649107268422e-003;
    __statist_i_h_wts[22,128]=-1.21696689118222e-001;
    __statist_i_h_wts[22,129]=-1.73475676500111e-001;
    __statist_i_h_wts[22,130]=-3.04435748900537e-001;
    __statist_i_h_wts[22,131]=-3.01547679815077e-001;
    __statist_i_h_wts[22,132]=-4.12979184649887e-001;
    __statist_i_h_wts[22,133]=-4.00080702532933e-001;
    __statist_i_h_wts[22,134]=-3.37987596895702e-001;
    __statist_i_h_wts[22,135]=5.30858410031592e-001;
    __statist_i_h_wts[22,136]=5.48108998250738e-001;
    __statist_i_h_wts[22,137]=5.26993813458412e-001;
    __statist_i_h_wts[22,138]=4.98774519741770e-001;
    __statist_i_h_wts[22,139]=3.74121188333801e-001;
    __statist_i_h_wts[22,140]=2.50046597978230e-001;
    __statist_i_h_wts[22,141]=9.80872204012989e-002;
    __statist_i_h_wts[22,142]=5.22162811764728e-002;
    __statist_i_h_wts[22,143]=-1.10387718944989e-001;
    __statist_i_h_wts[22,144]=-2.16936626395784e-002;
    __statist_i_h_wts[22,145]=-1.73550603498677e-001;
    __statist_i_h_wts[22,146]=-1.91552425480199e-001;
    __statist_i_h_wts[22,147]=-3.45604187612859e-001;
    __statist_i_h_wts[22,148]=-3.14760417320970e-001;
    __statist_i_h_wts[22,149]=-2.94862463606095e-001;
    __statist_i_h_wts[22,150]=4.76550791147499e-001;
    __statist_i_h_wts[22,151]=5.13696873951663e-001;
    __statist_i_h_wts[22,152]=4.67995511439054e-001;
    __statist_i_h_wts[22,153]=3.87545484023192e-001;
    __statist_i_h_wts[22,154]=3.28343753324249e-001;
    __statist_i_h_wts[22,155]=9.21726070608953e-002;
    __statist_i_h_wts[22,156]=-3.16873920726201e-002;
    __statist_i_h_wts[22,157]=-3.06065911272793e-002;
    __statist_i_h_wts[22,158]=-1.13428836067121e-001;
    __statist_i_h_wts[22,159]=-8.75653721400583e-002;
    __statist_i_h_wts[22,160]=-2.11113859912759e-001;
    __statist_i_h_wts[22,161]=-2.58285490958500e-001;
    __statist_i_h_wts[22,162]=-4.13668034436139e-001;
    __statist_i_h_wts[22,163]=-3.61755894708438e-001;
    __statist_i_h_wts[22,164]=-2.86241071279701e-001;
    __statist_i_h_wts[22,165]=3.18229148106413e-001;
    __statist_i_h_wts[22,166]=3.23243212554593e-001;
    __statist_i_h_wts[22,167]=3.07304559595746e-001;
    __statist_i_h_wts[22,168]=3.14029750376524e-001;
    __statist_i_h_wts[22,169]=2.07535806361409e-001;
    __statist_i_h_wts[22,170]=1.16382372114978e-001;
    __statist_i_h_wts[22,171]=-3.04468186427625e-002;
    __statist_i_h_wts[22,172]=-9.06088321333224e-002;
    __statist_i_h_wts[22,173]=-1.59553559777489e-001;
    __statist_i_h_wts[22,174]=-1.47460021914537e-001;
    __statist_i_h_wts[22,175]=-1.89610286279200e-001;
    __statist_i_h_wts[22,176]=-2.39972686677447e-001;
    __statist_i_h_wts[22,177]=-3.61133913577632e-001;
    __statist_i_h_wts[22,178]=-3.45070099821555e-001;
    __statist_i_h_wts[22,179]=-3.07596202860762e-001;
    __statist_i_h_wts[22,180]=2.14825543932124e-001;
    __statist_i_h_wts[22,181]=2.07247912157476e-001;
    __statist_i_h_wts[22,182]=1.93442215020967e-001;
    __statist_i_h_wts[22,183]=2.02620211776992e-001;
    __statist_i_h_wts[22,184]=2.14685199825012e-001;
    __statist_i_h_wts[22,185]=7.28934067496540e-002;
    __statist_i_h_wts[22,186]=-3.53732940052452e-002;
    __statist_i_h_wts[22,187]=-6.26807121979393e-002;
    __statist_i_h_wts[22,188]=-1.53601659570667e-001;
    __statist_i_h_wts[22,189]=-2.11582175837435e-001;
    __statist_i_h_wts[22,190]=-2.13856461420486e-001;
    __statist_i_h_wts[22,191]=-2.61156645610587e-001;
    __statist_i_h_wts[22,192]=-3.14926736283723e-001;
    __statist_i_h_wts[22,193]=-3.48843798831193e-001;
    __statist_i_h_wts[22,194]=-3.42572813895752e-001;
    __statist_i_h_wts[22,195]=1.46461349593465e-001;
    __statist_i_h_wts[22,196]=1.06511995991087e-001;
    __statist_i_h_wts[22,197]=1.21957462666626e-001;
    __statist_i_h_wts[22,198]=5.63497946708605e-002;
    __statist_i_h_wts[22,199]=6.33912219760764e-002;
    __statist_i_h_wts[22,200]=5.59562849442970e-002;
    __statist_i_h_wts[22,201]=-2.39380675379828e-002;
    __statist_i_h_wts[22,202]=-6.53610512788160e-002;
    __statist_i_h_wts[22,203]=-1.33496439095512e-001;
    __statist_i_h_wts[22,204]=-2.06597625046557e-001;
    __statist_i_h_wts[22,205]=-2.70351876473258e-001;
    __statist_i_h_wts[22,206]=-2.79143654214354e-001;
    __statist_i_h_wts[22,207]=-3.66710693316973e-001;
    __statist_i_h_wts[22,208]=-4.09312031493729e-001;
    __statist_i_h_wts[22,209]=-3.57175404873546e-001;
    __statist_i_h_wts[22,210]=7.38202942835329e-003;
    __statist_i_h_wts[22,211]=2.47819334412257e-002;
    __statist_i_h_wts[22,212]=6.28586648572596e-003;
    __statist_i_h_wts[22,213]=-5.91547060022965e-002;
    __statist_i_h_wts[22,214]=-5.90317629195676e-002;
    __statist_i_h_wts[22,215]=-7.61039162166555e-003;
    __statist_i_h_wts[22,216]=-6.37060147879499e-002;
    __statist_i_h_wts[22,217]=-7.33803628955401e-002;
    __statist_i_h_wts[22,218]=-3.41572286962235e-002;
    __statist_i_h_wts[22,219]=-1.05174419732127e-001;
    __statist_i_h_wts[22,220]=-1.84956112582114e-001;
    __statist_i_h_wts[22,221]=-2.05894115651894e-001;
    __statist_i_h_wts[22,222]=-3.11817961662005e-001;
    __statist_i_h_wts[22,223]=-3.50858393207580e-001;
    __statist_i_h_wts[22,224]=-2.94748729251288e-001;
    __statist_i_h_wts[22,225]=7.68919081046600e-002;
    __statist_i_h_wts[22,226]=6.97370887784338e-001;
    __statist_i_h_wts[22,227]=1.82401097905791e-002;
    __statist_i_h_wts[22,228]=5.74830161743507e-001;
    __statist_i_h_wts[22,229]=9.18917692126230e-002;
    __statist_i_h_wts[22,230]=-8.91541881080349e-001;
    __statist_i_h_wts[22,231]=4.80128660679617e-002;
    __statist_i_h_wts[22,232]=-1.56249904037567e+000;
    __statist_i_h_wts[22,233]=-5.50194700845013e-001;
    __statist_i_h_wts[22,234]=-6.82109271846036e-001;
    __statist_i_h_wts[22,235]=4.91429232876025e-001;
    __statist_i_h_wts[22,236]=2.09644491012362e+000;
    __statist_i_h_wts[22,237]=4.05844156687108e-001;
    __statist_i_h_wts[22,238]=-1.53092319085751e-001;
    __statist_i_h_wts[22,239]=-6.78343799151754e-001;
    __statist_i_h_wts[22,240]=3.90053511490415e-001;
    __statist_i_h_wts[22,241]=-1.32039454124792e+000;
    __statist_i_h_wts[22,242]=-1.87765001699547e-001;
    __statist_i_h_wts[22,243]=-8.81875949818126e-001;
    __statist_i_h_wts[22,244]=1.81377611517157e-001;
    __statist_i_h_wts[22,245]=1.18835268315157e+000;
    __statist_i_h_wts[22,246]=-3.70240422430927e-003;
    __statist_i_h_wts[22,247]=7.19551064442875e-001;
    __statist_i_h_wts[22,248]=-1.95530656852079e-001;

    __statist_i_h_wts[23,0]=3.04158302268043e-001;
    __statist_i_h_wts[23,1]=1.75516393562605e-001;
    __statist_i_h_wts[23,2]=2.15041964998117e-001;
    __statist_i_h_wts[23,3]=5.74602670838579e-002;
    __statist_i_h_wts[23,4]=9.32194978124986e-002;
    __statist_i_h_wts[23,5]=1.46360034569262e-001;
    __statist_i_h_wts[23,6]=1.83846367571154e-001;
    __statist_i_h_wts[23,7]=1.89883912175624e-001;
    __statist_i_h_wts[23,8]=3.49087454807423e-001;
    __statist_i_h_wts[23,9]=2.83224951831158e-001;
    __statist_i_h_wts[23,10]=6.01925522361246e-002;
    __statist_i_h_wts[23,11]=2.82530887430969e-001;
    __statist_i_h_wts[23,12]=-8.93661434287719e-002;
    __statist_i_h_wts[23,13]=1.51470852922864e-001;
    __statist_i_h_wts[23,14]=-1.09938371561858e-001;
    __statist_i_h_wts[23,15]=2.67360423726419e-001;
    __statist_i_h_wts[23,16]=1.96774391787189e-001;
    __statist_i_h_wts[23,17]=2.95193618560036e-001;
    __statist_i_h_wts[23,18]=1.45184351812437e-001;
    __statist_i_h_wts[23,19]=4.24932484978385e-002;
    __statist_i_h_wts[23,20]=1.21695361553664e-001;
    __statist_i_h_wts[23,21]=4.79215919201815e-002;
    __statist_i_h_wts[23,22]=-1.45231443971795e-001;
    __statist_i_h_wts[23,23]=1.71603783515514e-002;
    __statist_i_h_wts[23,24]=-2.06499909513081e-001;
    __statist_i_h_wts[23,25]=-1.54037208579740e-001;
    __statist_i_h_wts[23,26]=7.95649400877794e-002;
    __statist_i_h_wts[23,27]=-4.92342533347413e-002;
    __statist_i_h_wts[23,28]=-4.80440639586793e-002;
    __statist_i_h_wts[23,29]=-2.94527794800056e-001;
    __statist_i_h_wts[23,30]=1.65433773626950e-001;
    __statist_i_h_wts[23,31]=6.34019125414663e-002;
    __statist_i_h_wts[23,32]=1.95579351620999e-001;
    __statist_i_h_wts[23,33]=1.31247491531414e-001;
    __statist_i_h_wts[23,34]=-3.82498475865129e-002;
    __statist_i_h_wts[23,35]=-5.24161275754489e-002;
    __statist_i_h_wts[23,36]=-1.05970352580322e-001;
    __statist_i_h_wts[23,37]=-1.43580547390776e-001;
    __statist_i_h_wts[23,38]=-3.24244301421037e-001;
    __statist_i_h_wts[23,39]=-4.07998547833674e-001;
    __statist_i_h_wts[23,40]=-3.83024738037758e-001;
    __statist_i_h_wts[23,41]=-1.16764827938297e-001;
    __statist_i_h_wts[23,42]=-4.04540301153005e-001;
    __statist_i_h_wts[23,43]=-3.33023428102596e-001;
    __statist_i_h_wts[23,44]=-4.68094405732888e-001;
    __statist_i_h_wts[23,45]=1.27744610712989e-001;
    __statist_i_h_wts[23,46]=1.84467589700525e-001;
    __statist_i_h_wts[23,47]=3.94713790341782e-001;
    __statist_i_h_wts[23,48]=1.33406124939654e-001;
    __statist_i_h_wts[23,49]=2.13319098860395e-001;
    __statist_i_h_wts[23,50]=-1.26778062650279e-001;
    __statist_i_h_wts[23,51]=8.33859295595342e-004;
    __statist_i_h_wts[23,52]=1.66407064314253e-001;
    __statist_i_h_wts[23,53]=-2.14194066172606e-001;
    __statist_i_h_wts[23,54]=-1.54374381508102e-001;
    __statist_i_h_wts[23,55]=-1.22886432926618e-001;
    __statist_i_h_wts[23,56]=-1.49148102581071e-001;
    __statist_i_h_wts[23,57]=-1.17842570301121e-001;
    __statist_i_h_wts[23,58]=-1.00824639304957e-001;
    __statist_i_h_wts[23,59]=-2.87844970377769e-001;
    __statist_i_h_wts[23,60]=5.18637545482548e-002;
    __statist_i_h_wts[23,61]=1.54011222282826e-001;
    __statist_i_h_wts[23,62]=2.99123536208306e-001;
    __statist_i_h_wts[23,63]=1.51075231112506e-001;
    __statist_i_h_wts[23,64]=3.78475233109727e-001;
    __statist_i_h_wts[23,65]=7.43422187636301e-002;
    __statist_i_h_wts[23,66]=1.97698110046396e-001;
    __statist_i_h_wts[23,67]=4.14346358427095e-001;
    __statist_i_h_wts[23,68]=-9.71075478182067e-003;
    __statist_i_h_wts[23,69]=1.81601431365292e-002;
    __statist_i_h_wts[23,70]=1.94207782191101e-001;
    __statist_i_h_wts[23,71]=2.06942472653960e-002;
    __statist_i_h_wts[23,72]=7.55972960606374e-003;
    __statist_i_h_wts[23,73]=-8.32784785021132e-002;
    __statist_i_h_wts[23,74]=-4.05847007017373e-001;
    __statist_i_h_wts[23,75]=3.44473559136052e-002;
    __statist_i_h_wts[23,76]=1.80821208068414e-002;
    __statist_i_h_wts[23,77]=1.65217384195502e-001;
    __statist_i_h_wts[23,78]=2.80682277727449e-001;
    __statist_i_h_wts[23,79]=3.72154430504305e-001;
    __statist_i_h_wts[23,80]=2.57582995359967e-001;
    __statist_i_h_wts[23,81]=2.90442507813297e-001;
    __statist_i_h_wts[23,82]=2.04306790508240e-001;
    __statist_i_h_wts[23,83]=-3.15103676874719e-001;
    __statist_i_h_wts[23,84]=-2.92082621913868e-001;
    __statist_i_h_wts[23,85]=-1.08532494217139e-001;
    __statist_i_h_wts[23,86]=-4.41543984233547e-002;
    __statist_i_h_wts[23,87]=7.68381206208382e-002;
    __statist_i_h_wts[23,88]=-1.92114446537317e-001;
    __statist_i_h_wts[23,89]=-7.27521354456590e-001;
    __statist_i_h_wts[23,90]=4.43221665056714e-002;
    __statist_i_h_wts[23,91]=1.80795303788868e-003;
    __statist_i_h_wts[23,92]=1.93884201803449e-001;
    __statist_i_h_wts[23,93]=3.22764222362585e-001;
    __statist_i_h_wts[23,94]=1.36758478680895e-001;
    __statist_i_h_wts[23,95]=-3.54418567586859e-002;
    __statist_i_h_wts[23,96]=-9.76054163996376e-002;
    __statist_i_h_wts[23,97]=5.57089234975154e-002;
    __statist_i_h_wts[23,98]=-7.62714489331428e-002;
    __statist_i_h_wts[23,99]=-6.36428247007160e-002;
    __statist_i_h_wts[23,100]=-1.66942404984083e-001;
    __statist_i_h_wts[23,101]=-1.84096776494633e-001;
    __statist_i_h_wts[23,102]=-1.50897757361074e-001;
    __statist_i_h_wts[23,103]=-4.04464665855053e-001;
    __statist_i_h_wts[23,104]=-5.19069336679986e-001;
    __statist_i_h_wts[23,105]=-7.09227075194928e-002;
    __statist_i_h_wts[23,106]=-1.28907012052019e-001;
    __statist_i_h_wts[23,107]=3.99667279454424e-002;
    __statist_i_h_wts[23,108]=6.76592255493828e-002;
    __statist_i_h_wts[23,109]=1.21172828114436e-001;
    __statist_i_h_wts[23,110]=4.35392101397735e-002;
    __statist_i_h_wts[23,111]=-9.08914321594073e-002;
    __statist_i_h_wts[23,112]=3.47171524176742e-001;
    __statist_i_h_wts[23,113]=2.70038019466859e-001;
    __statist_i_h_wts[23,114]=2.00462735011955e-001;
    __statist_i_h_wts[23,115]=-7.64498787109343e-003;
    __statist_i_h_wts[23,116]=-2.84105288588937e-001;
    __statist_i_h_wts[23,117]=-2.42714611624279e-001;
    __statist_i_h_wts[23,118]=-3.04844688282552e-001;
    __statist_i_h_wts[23,119]=-3.57507172903282e-001;
    __statist_i_h_wts[23,120]=-1.51989411100122e-001;
    __statist_i_h_wts[23,121]=1.15164176487503e-001;
    __statist_i_h_wts[23,122]=2.09135132395914e-001;
    __statist_i_h_wts[23,123]=4.05426329473107e-002;
    __statist_i_h_wts[23,124]=1.13748532358547e-001;
    __statist_i_h_wts[23,125]=7.78355920412934e-003;
    __statist_i_h_wts[23,126]=-1.98801347903753e-001;
    __statist_i_h_wts[23,127]=3.41400988551520e-001;
    __statist_i_h_wts[23,128]=-3.03497319545088e-002;
    __statist_i_h_wts[23,129]=5.73351254810232e-002;
    __statist_i_h_wts[23,130]=2.46326716111313e-001;
    __statist_i_h_wts[23,131]=-1.07551163762170e-001;
    __statist_i_h_wts[23,132]=-4.24248294688077e-001;
    __statist_i_h_wts[23,133]=-6.58149222305156e-001;
    __statist_i_h_wts[23,134]=-6.42315335137420e-001;
    __statist_i_h_wts[23,135]=-9.96304061739255e-002;
    __statist_i_h_wts[23,136]=1.64673103392276e-001;
    __statist_i_h_wts[23,137]=2.73259211938779e-001;
    __statist_i_h_wts[23,138]=1.05759255146588e-001;
    __statist_i_h_wts[23,139]=5.79371952874229e-002;
    __statist_i_h_wts[23,140]=6.16402068798984e-002;
    __statist_i_h_wts[23,141]=-3.15592152579002e-001;
    __statist_i_h_wts[23,142]=-1.25012786636189e-001;
    __statist_i_h_wts[23,143]=-2.00833679494897e-001;
    __statist_i_h_wts[23,144]=1.47897779609637e-001;
    __statist_i_h_wts[23,145]=3.59066487349984e-001;
    __statist_i_h_wts[23,146]=5.16677677053868e-002;
    __statist_i_h_wts[23,147]=-2.02227583559945e-001;
    __statist_i_h_wts[23,148]=-4.81928214805762e-001;
    __statist_i_h_wts[23,149]=-4.42489824214631e-001;
    __statist_i_h_wts[23,150]=-9.47165496795190e-002;
    __statist_i_h_wts[23,151]=1.82082849792082e-001;
    __statist_i_h_wts[23,152]=1.71317582058550e-001;
    __statist_i_h_wts[23,153]=1.01599745480849e-001;
    __statist_i_h_wts[23,154]=1.50127029267475e-001;
    __statist_i_h_wts[23,155]=4.71771975027717e-002;
    __statist_i_h_wts[23,156]=-2.45153501487249e-001;
    __statist_i_h_wts[23,157]=-1.43112496727838e-001;
    __statist_i_h_wts[23,158]=-1.78968310245247e-001;
    __statist_i_h_wts[23,159]=1.99474461136979e-001;
    __statist_i_h_wts[23,160]=1.04541161768377e-001;
    __statist_i_h_wts[23,161]=-1.67661737122210e-001;
    __statist_i_h_wts[23,162]=-3.77152345701211e-001;
    __statist_i_h_wts[23,163]=-3.29193243696264e-001;
    __statist_i_h_wts[23,164]=-2.11117129333123e-001;
    __statist_i_h_wts[23,165]=-1.14677690004438e-001;
    __statist_i_h_wts[23,166]=2.50421081543942e-001;
    __statist_i_h_wts[23,167]=1.07997201260924e-001;
    __statist_i_h_wts[23,168]=-2.70756400887559e-002;
    __statist_i_h_wts[23,169]=6.39581278415346e-002;
    __statist_i_h_wts[23,170]=1.09098409407822e-001;
    __statist_i_h_wts[23,171]=-2.24664965594586e-001;
    __statist_i_h_wts[23,172]=-2.01478286364819e-001;
    __statist_i_h_wts[23,173]=-2.24807607222824e-001;
    __statist_i_h_wts[23,174]=-3.48829506062948e-001;
    __statist_i_h_wts[23,175]=-4.31346482331974e-001;
    __statist_i_h_wts[23,176]=-2.04612009227967e-001;
    __statist_i_h_wts[23,177]=-3.37675863221688e-001;
    __statist_i_h_wts[23,178]=-6.14023193919455e-001;
    __statist_i_h_wts[23,179]=-5.84654362416641e-001;
    __statist_i_h_wts[23,180]=-1.26813708881833e-001;
    __statist_i_h_wts[23,181]=2.39355807284242e-001;
    __statist_i_h_wts[23,182]=1.26506549118190e-001;
    __statist_i_h_wts[23,183]=5.87209630651485e-003;
    __statist_i_h_wts[23,184]=-1.60007687920858e-001;
    __statist_i_h_wts[23,185]=-3.96178364641067e-002;
    __statist_i_h_wts[23,186]=-2.46869531735036e-001;
    __statist_i_h_wts[23,187]=-2.89428717711482e-001;
    __statist_i_h_wts[23,188]=-1.42875287593152e-001;
    __statist_i_h_wts[23,189]=-2.35465833364416e-001;
    __statist_i_h_wts[23,190]=-4.28845052032915e-001;
    __statist_i_h_wts[23,191]=-1.01302894587092e-001;
    __statist_i_h_wts[23,192]=-2.14977420340334e-001;
    __statist_i_h_wts[23,193]=-3.25876781933280e-001;
    __statist_i_h_wts[23,194]=-2.20047987097881e-001;
    __statist_i_h_wts[23,195]=-9.83478146470079e-002;
    __statist_i_h_wts[23,196]=2.06820018942415e-001;
    __statist_i_h_wts[23,197]=2.06659325374091e-001;
    __statist_i_h_wts[23,198]=-1.75512793723466e-003;
    __statist_i_h_wts[23,199]=-6.06741414707756e-002;
    __statist_i_h_wts[23,200]=-1.72173720354134e-002;
    __statist_i_h_wts[23,201]=-2.66767104962468e-001;
    __statist_i_h_wts[23,202]=-1.25854195788069e-001;
    __statist_i_h_wts[23,203]=-5.70116571978808e-002;
    __statist_i_h_wts[23,204]=-3.18842328528975e-001;
    __statist_i_h_wts[23,205]=-2.99694420047334e-001;
    __statist_i_h_wts[23,206]=1.91468480064766e-001;
    __statist_i_h_wts[23,207]=1.35475936428563e-001;
    __statist_i_h_wts[23,208]=-2.04124777913001e-001;
    __statist_i_h_wts[23,209]=-2.86409173893148e-002;
    __statist_i_h_wts[23,210]=-1.35326462574216e-001;
    __statist_i_h_wts[23,211]=2.22653887644554e-001;
    __statist_i_h_wts[23,212]=1.34009042789942e-001;
    __statist_i_h_wts[23,213]=-1.22207405684863e-001;
    __statist_i_h_wts[23,214]=-1.27219350730580e-001;
    __statist_i_h_wts[23,215]=-1.10071680525670e-001;
    __statist_i_h_wts[23,216]=-1.44999549320917e-001;
    __statist_i_h_wts[23,217]=-2.56416922998982e-002;
    __statist_i_h_wts[23,218]=-1.62508067819795e-001;
    __statist_i_h_wts[23,219]=-4.32972641003220e-001;
    __statist_i_h_wts[23,220]=-5.02180401909818e-001;
    __statist_i_h_wts[23,221]=-1.58234302699125e-001;
    __statist_i_h_wts[23,222]=-2.18737932758944e-001;
    __statist_i_h_wts[23,223]=-5.35463062551128e-001;
    __statist_i_h_wts[23,224]=-2.62757419848353e-001;
    __statist_i_h_wts[23,225]=-3.43496282603946e-001;
    __statist_i_h_wts[23,226]=-1.28985315323425e-001;
    __statist_i_h_wts[23,227]=-4.42982925196997e-001;
    __statist_i_h_wts[23,228]=-8.35764342579570e-002;
    __statist_i_h_wts[23,229]=8.45721245983534e-003;
    __statist_i_h_wts[23,230]=-3.51795509016000e-001;
    __statist_i_h_wts[23,231]=-2.58535715973053e-001;
    __statist_i_h_wts[23,232]=-1.17843935917288e+000;
    __statist_i_h_wts[23,233]=-3.09370760750743e-001;
    __statist_i_h_wts[23,234]=-3.85977083155250e-001;
    __statist_i_h_wts[23,235]=2.85317195180217e-001;
    __statist_i_h_wts[23,236]=1.44850027913979e+000;
    __statist_i_h_wts[23,237]=-3.04540404275206e-001;
    __statist_i_h_wts[23,238]=4.98800146238860e-001;
    __statist_i_h_wts[23,239]=-7.21392427736141e-001;
    __statist_i_h_wts[23,240]=7.44925937068289e-002;
    __statist_i_h_wts[23,241]=-9.12019650620204e-001;
    __statist_i_h_wts[23,242]=-4.41108528016103e-001;
    __statist_i_h_wts[23,243]=-7.48884017279270e-001;
    __statist_i_h_wts[23,244]=5.93626991132213e-001;
    __statist_i_h_wts[23,245]=7.78942960612319e-001;
    __statist_i_h_wts[23,246]=9.75652228616191e-002;
    __statist_i_h_wts[23,247]=5.25076320913510e-001;
    __statist_i_h_wts[23,248]=4.15541290292689e-001;

    __statist_i_h_wts[24,0]=2.78659673570488e-001;
    __statist_i_h_wts[24,1]=6.21815350750638e-001;
    __statist_i_h_wts[24,2]=6.10178384502004e-001;
    __statist_i_h_wts[24,3]=5.68739995065048e-001;
    __statist_i_h_wts[24,4]=3.69960793363069e-001;
    __statist_i_h_wts[24,5]=1.23845708754299e-001;
    __statist_i_h_wts[24,6]=3.45258368156365e-001;
    __statist_i_h_wts[24,7]=-3.08783146339869e-002;
    __statist_i_h_wts[24,8]=-1.69751387695087e-001;
    __statist_i_h_wts[24,9]=-5.09235752449399e-001;
    __statist_i_h_wts[24,10]=1.61224066418408e-001;
    __statist_i_h_wts[24,11]=-2.33961284617901e-001;
    __statist_i_h_wts[24,12]=-2.16891614813946e-001;
    __statist_i_h_wts[24,13]=-4.35542470137835e-001;
    __statist_i_h_wts[24,14]=-4.16279931511713e-001;
    __statist_i_h_wts[24,15]=1.13568362970588e-001;
    __statist_i_h_wts[24,16]=6.07902789204589e-001;
    __statist_i_h_wts[24,17]=6.85536631976533e-001;
    __statist_i_h_wts[24,18]=4.67910353619546e-001;
    __statist_i_h_wts[24,19]=3.71992800047074e-001;
    __statist_i_h_wts[24,20]=1.93383829362925e-001;
    __statist_i_h_wts[24,21]=5.61227217125381e-001;
    __statist_i_h_wts[24,22]=3.12418250895071e-002;
    __statist_i_h_wts[24,23]=5.84108439816447e-002;
    __statist_i_h_wts[24,24]=-2.16668149535031e-001;
    __statist_i_h_wts[24,25]=1.98576006114560e-001;
    __statist_i_h_wts[24,26]=-4.11767985475772e-001;
    __statist_i_h_wts[24,27]=-3.49806063120786e-001;
    __statist_i_h_wts[24,28]=-4.53112878182016e-001;
    __statist_i_h_wts[24,29]=-5.26671841557637e-001;
    __statist_i_h_wts[24,30]=6.05453079403509e-001;
    __statist_i_h_wts[24,31]=6.28975044917818e-001;
    __statist_i_h_wts[24,32]=8.11194852680231e-001;
    __statist_i_h_wts[24,33]=6.02737710434930e-001;
    __statist_i_h_wts[24,34]=1.51676228897937e-001;
    __statist_i_h_wts[24,35]=-9.28189755505306e-002;
    __statist_i_h_wts[24,36]=5.89746604654947e-001;
    __statist_i_h_wts[24,37]=1.49267853793991e-001;
    __statist_i_h_wts[24,38]=-5.47677773211717e-002;
    __statist_i_h_wts[24,39]=-1.82918889751646e-001;
    __statist_i_h_wts[24,40]=2.89723376584899e-001;
    __statist_i_h_wts[24,41]=-1.11508562493765e-001;
    __statist_i_h_wts[24,42]=-3.64146623382609e-001;
    __statist_i_h_wts[24,43]=-4.24419106316589e-001;
    __statist_i_h_wts[24,44]=-2.75460715898459e-001;
    __statist_i_h_wts[24,45]=8.91654206192407e-001;
    __statist_i_h_wts[24,46]=6.62115475099415e-001;
    __statist_i_h_wts[24,47]=1.01944185401582e+000;
    __statist_i_h_wts[24,48]=7.64774489519220e-001;
    __statist_i_h_wts[24,49]=3.41748567604697e-001;
    __statist_i_h_wts[24,50]=1.46293227403811e-001;
    __statist_i_h_wts[24,51]=7.28729020861664e-001;
    __statist_i_h_wts[24,52]=9.05949443017472e-002;
    __statist_i_h_wts[24,53]=-1.35370568376756e-001;
    __statist_i_h_wts[24,54]=8.08824149362512e-002;
    __statist_i_h_wts[24,55]=2.12675070471081e-002;
    __statist_i_h_wts[24,56]=-3.68001116152184e-001;
    __statist_i_h_wts[24,57]=-1.54291369770520e-001;
    __statist_i_h_wts[24,58]=-3.27811312499757e-001;
    __statist_i_h_wts[24,59]=-1.59785549062941e-001;
    __statist_i_h_wts[24,60]=6.63440097900812e-001;
    __statist_i_h_wts[24,61]=3.30293703839437e-001;
    __statist_i_h_wts[24,62]=5.98825678412407e-001;
    __statist_i_h_wts[24,63]=5.58891155031195e-001;
    __statist_i_h_wts[24,64]=2.92314355561315e-001;
    __statist_i_h_wts[24,65]=-5.24441863191972e-002;
    __statist_i_h_wts[24,66]=5.53462250478600e-001;
    __statist_i_h_wts[24,67]=-1.92160983687541e-001;
    __statist_i_h_wts[24,68]=-4.24716285860912e-001;
    __statist_i_h_wts[24,69]=-2.08468153702452e-001;
    __statist_i_h_wts[24,70]=2.61549357997701e-001;
    __statist_i_h_wts[24,71]=-1.98281536506320e-001;
    __statist_i_h_wts[24,72]=-5.37409326928206e-002;
    __statist_i_h_wts[24,73]=-2.32959171218558e-001;
    __statist_i_h_wts[24,74]=-2.65603399146167e-002;
    __statist_i_h_wts[24,75]=7.43200965242373e-001;
    __statist_i_h_wts[24,76]=5.69786006395973e-001;
    __statist_i_h_wts[24,77]=4.27170308715962e-001;
    __statist_i_h_wts[24,78]=2.55398968975419e-001;
    __statist_i_h_wts[24,79]=1.49165996760445e-001;
    __statist_i_h_wts[24,80]=5.73518570090661e-001;
    __statist_i_h_wts[24,81]=-5.30843495451106e-003;
    __statist_i_h_wts[24,82]=-2.28357016494019e-001;
    __statist_i_h_wts[24,83]=-6.59180503875383e-001;
    __statist_i_h_wts[24,84]=-4.04297942111202e-001;
    __statist_i_h_wts[24,85]=-2.33088079371138e-001;
    __statist_i_h_wts[24,86]=-2.95004864168106e-001;
    __statist_i_h_wts[24,87]=-2.16194706853410e-001;
    __statist_i_h_wts[24,88]=-3.24089286298135e-001;
    __statist_i_h_wts[24,89]=-2.08256981419981e-001;
    __statist_i_h_wts[24,90]=1.04207109146629e+000;
    __statist_i_h_wts[24,91]=6.29586254328160e-001;
    __statist_i_h_wts[24,92]=8.30850642930157e-001;
    __statist_i_h_wts[24,93]=4.83863963298744e-001;
    __statist_i_h_wts[24,94]=3.46095389886748e-002;
    __statist_i_h_wts[24,95]=5.10304689683499e-001;
    __statist_i_h_wts[24,96]=3.74560929876929e-001;
    __statist_i_h_wts[24,97]=3.75341893433094e-001;
    __statist_i_h_wts[24,98]=-5.10894006052071e-001;
    __statist_i_h_wts[24,99]=-8.80051143421204e-002;
    __statist_i_h_wts[24,100]=-2.29586274961717e-001;
    __statist_i_h_wts[24,101]=-3.44360073424431e-001;
    __statist_i_h_wts[24,102]=-5.29370083475435e-001;
    __statist_i_h_wts[24,103]=-7.36587061520097e-001;
    __statist_i_h_wts[24,104]=-3.11648075962263e-001;
    __statist_i_h_wts[24,105]=6.74901749221422e-001;
    __statist_i_h_wts[24,106]=5.17525791984495e-001;
    __statist_i_h_wts[24,107]=4.45785541903084e-001;
    __statist_i_h_wts[24,108]=5.24824101953757e-001;
    __statist_i_h_wts[24,109]=2.82611484853499e-001;
    __statist_i_h_wts[24,110]=3.53584529787872e-001;
    __statist_i_h_wts[24,111]=6.84121541515529e-001;
    __statist_i_h_wts[24,112]=2.94326682392058e-001;
    __statist_i_h_wts[24,113]=-1.77757295191224e-001;
    __statist_i_h_wts[24,114]=-2.00700036285011e-001;
    __statist_i_h_wts[24,115]=-2.61833923380120e-001;
    __statist_i_h_wts[24,116]=8.01593835695345e-002;
    __statist_i_h_wts[24,117]=-4.41256764349903e-001;
    __statist_i_h_wts[24,118]=-5.66432805049761e-001;
    __statist_i_h_wts[24,119]=-3.41202183965685e-001;
    __statist_i_h_wts[24,120]=1.18057801654503e+000;
    __statist_i_h_wts[24,121]=6.33629971077478e-001;
    __statist_i_h_wts[24,122]=4.03691043509694e-001;
    __statist_i_h_wts[24,123]=4.83318112140928e-001;
    __statist_i_h_wts[24,124]=1.02649295575668e-001;
    __statist_i_h_wts[24,125]=3.73021758634826e-001;
    __statist_i_h_wts[24,126]=3.14584667557926e-001;
    __statist_i_h_wts[24,127]=-3.38804212053082e-001;
    __statist_i_h_wts[24,128]=-3.72651429399260e-001;
    __statist_i_h_wts[24,129]=-4.84382821851408e-001;
    __statist_i_h_wts[24,130]=-4.59182866308830e-001;
    __statist_i_h_wts[24,131]=-1.62736886961176e-001;
    __statist_i_h_wts[24,132]=-4.08493432144177e-001;
    __statist_i_h_wts[24,133]=-5.30638993959947e-001;
    __statist_i_h_wts[24,134]=-3.81418310620258e-001;
    __statist_i_h_wts[24,135]=8.99377926940855e-001;
    __statist_i_h_wts[24,136]=4.72366808617810e-001;
    __statist_i_h_wts[24,137]=4.20650385054189e-001;
    __statist_i_h_wts[24,138]=5.51078840656726e-001;
    __statist_i_h_wts[24,139]=1.08680870431268e-001;
    __statist_i_h_wts[24,140]=2.03687443470399e-001;
    __statist_i_h_wts[24,141]=-3.88816774700333e-002;
    __statist_i_h_wts[24,142]=9.47631913271603e-002;
    __statist_i_h_wts[24,143]=-7.96653797561678e-002;
    __statist_i_h_wts[24,144]=2.96155408923937e-001;
    __statist_i_h_wts[24,145]=-1.52510127824333e-001;
    __statist_i_h_wts[24,146]=1.72006856799497e-001;
    __statist_i_h_wts[24,147]=-4.07344251969565e-001;
    __statist_i_h_wts[24,148]=-3.58725609897046e-001;
    __statist_i_h_wts[24,149]=-2.46629583912198e-001;
    __statist_i_h_wts[24,150]=8.01343236842665e-001;
    __statist_i_h_wts[24,151]=4.76199167426568e-001;
    __statist_i_h_wts[24,152]=2.81048969387746e-001;
    __statist_i_h_wts[24,153]=4.18689464946472e-001;
    __statist_i_h_wts[24,154]=2.29481903196243e-001;
    __statist_i_h_wts[24,155]=-1.06163187774861e-001;
    __statist_i_h_wts[24,156]=1.60279738423706e-003;
    __statist_i_h_wts[24,157]=1.35214514791959e-001;
    __statist_i_h_wts[24,158]=-3.45341766214504e-002;
    __statist_i_h_wts[24,159]=3.06183571194615e-001;
    __statist_i_h_wts[24,160]=1.35321563085789e-001;
    __statist_i_h_wts[24,161]=-5.77048821053697e-002;
    __statist_i_h_wts[24,162]=-5.62928519513192e-001;
    __statist_i_h_wts[24,163]=-5.38292511136764e-001;
    __statist_i_h_wts[24,164]=-2.50494442860281e-001;
    __statist_i_h_wts[24,165]=7.43293804114844e-001;
    __statist_i_h_wts[24,166]=4.05770774456990e-001;
    __statist_i_h_wts[24,167]=4.44774667276597e-001;
    __statist_i_h_wts[24,168]=5.11670855027710e-001;
    __statist_i_h_wts[24,169]=1.21748390443007e-001;
    __statist_i_h_wts[24,170]=1.57971441775261e-001;
    __statist_i_h_wts[24,171]=-1.02224417897273e-001;
    __statist_i_h_wts[24,172]=-2.90966762786592e-001;
    __statist_i_h_wts[24,173]=-2.58038181742907e-001;
    __statist_i_h_wts[24,174]=8.16789790846498e-002;
    __statist_i_h_wts[24,175]=-1.67059282748670e-003;
    __statist_i_h_wts[24,176]=-2.23875498820113e-001;
    __statist_i_h_wts[24,177]=-3.98142233556502e-001;
    __statist_i_h_wts[24,178]=-2.17309739767846e-001;
    __statist_i_h_wts[24,179]=-2.85181279072885e-001;
    __statist_i_h_wts[24,180]=3.64190984537517e-001;
    __statist_i_h_wts[24,181]=2.05311145371661e-001;
    __statist_i_h_wts[24,182]=1.81236421557937e-001;
    __statist_i_h_wts[24,183]=2.41095514006374e-001;
    __statist_i_h_wts[24,184]=1.49874754371558e-001;
    __statist_i_h_wts[24,185]=-1.83743760748498e-001;
    __statist_i_h_wts[24,186]=-4.73712079183013e-001;
    __statist_i_h_wts[24,187]=-4.06585752866362e-001;
    __statist_i_h_wts[24,188]=-1.11319894764967e-001;
    __statist_i_h_wts[24,189]=5.79450528920262e-002;
    __statist_i_h_wts[24,190]=-7.92436661369670e-002;
    __statist_i_h_wts[24,191]=-3.34762147172085e-001;
    __statist_i_h_wts[24,192]=-1.13688653351179e-001;
    __statist_i_h_wts[24,193]=-1.78665204933042e-001;
    __statist_i_h_wts[24,194]=-2.69771024275094e-001;
    __statist_i_h_wts[24,195]=3.39253597554627e-001;
    __statist_i_h_wts[24,196]=1.84233595124794e-001;
    __statist_i_h_wts[24,197]=2.94109879199927e-001;
    __statist_i_h_wts[24,198]=1.81472109474957e-001;
    __statist_i_h_wts[24,199]=5.24919210600731e-002;
    __statist_i_h_wts[24,200]=-1.86037514991309e-001;
    __statist_i_h_wts[24,201]=-3.52693257126230e-001;
    __statist_i_h_wts[24,202]=-3.18166309478479e-001;
    __statist_i_h_wts[24,203]=-2.09080332008354e-001;
    __statist_i_h_wts[24,204]=-4.47073319366116e-002;
    __statist_i_h_wts[24,205]=-1.82293064179395e-001;
    __statist_i_h_wts[24,206]=-2.24201081353491e-001;
    __statist_i_h_wts[24,207]=-4.03369615655483e-001;
    __statist_i_h_wts[24,208]=-4.41244210049522e-001;
    __statist_i_h_wts[24,209]=-3.51401104537097e-001;
    __statist_i_h_wts[24,210]=-6.33869407709292e-002;
    __statist_i_h_wts[24,211]=2.63399153137889e-002;
    __statist_i_h_wts[24,212]=-6.67396145776922e-003;
    __statist_i_h_wts[24,213]=-1.20747169343557e-001;
    __statist_i_h_wts[24,214]=-1.98231874975571e-001;
    __statist_i_h_wts[24,215]=-2.15878283344344e-001;
    __statist_i_h_wts[24,216]=-2.91165421959269e-001;
    __statist_i_h_wts[24,217]=-2.84106083970418e-001;
    __statist_i_h_wts[24,218]=1.46668082365109e-002;
    __statist_i_h_wts[24,219]=-7.20431830339934e-002;
    __statist_i_h_wts[24,220]=-2.19509950242483e-001;
    __statist_i_h_wts[24,221]=-2.67925998838938e-001;
    __statist_i_h_wts[24,222]=-5.15022855926387e-001;
    __statist_i_h_wts[24,223]=-6.20678343210239e-001;
    __statist_i_h_wts[24,224]=-3.71618904713749e-001;
    __statist_i_h_wts[24,225]=2.60181372673693e-001;
    __statist_i_h_wts[24,226]=9.26005407999135e-001;
    __statist_i_h_wts[24,227]=8.76430775049099e-002;
    __statist_i_h_wts[24,228]=9.62670539832112e-001;
    __statist_i_h_wts[24,229]=9.97565604646020e-001;
    __statist_i_h_wts[24,230]=-1.13918497505364e+000;
    __statist_i_h_wts[24,231]=3.93846741925799e-001;
    __statist_i_h_wts[24,232]=-1.97133586307169e+000;
    __statist_i_h_wts[24,233]=-8.96471038063479e-001;
    __statist_i_h_wts[24,234]=-6.50819056309752e-001;
    __statist_i_h_wts[24,235]=7.50331780911877e-001;
    __statist_i_h_wts[24,236]=3.83360330605614e+000;
    __statist_i_h_wts[24,237]=-2.80021121819588e-001;
    __statist_i_h_wts[24,238]=-6.21804301025991e-001;
    __statist_i_h_wts[24,239]=-2.85270775534872e-001;
    __statist_i_h_wts[24,240]=6.61029003019452e-001;
    __statist_i_h_wts[24,241]=-2.02687061094835e+000;
    __statist_i_h_wts[24,242]=-7.53441059140758e-001;
    __statist_i_h_wts[24,243]=-1.04838130057762e+000;
    __statist_i_h_wts[24,244]=-8.30055639798690e-002;
    __statist_i_h_wts[24,245]=1.60765996206791e+000;
    __statist_i_h_wts[24,246]=1.33723787704738e-001;
    __statist_i_h_wts[24,247]=6.15056708029201e-001;
    __statist_i_h_wts[24,248]=-3.95994730907432e-001;

    double[,] __statist_h_o_wts = new double[2,25];

    __statist_h_o_wts[0,0]=-2.97615931784138e+000;
    __statist_h_o_wts[0,1]=-7.39568258088276e-002;
    __statist_h_o_wts[0,2]=-1.40868306336986e+000;
    __statist_h_o_wts[0,3]=-3.81041599551502e-001;
    __statist_h_o_wts[0,4]=-1.97823308880298e+000;
    __statist_h_o_wts[0,5]=-3.48494866876649e-001;
    __statist_h_o_wts[0,6]=-6.07074514595664e-001;
    __statist_h_o_wts[0,7]=-5.19971424472098e-001;
    __statist_h_o_wts[0,8]=4.84302657280598e-001;
    __statist_h_o_wts[0,9]=-5.61461464552263e-001;
    __statist_h_o_wts[0,10]=1.30312642465646e+000;
    __statist_h_o_wts[0,11]=4.37667162526019e-001;
    __statist_h_o_wts[0,12]=-8.41867506438361e-001;
    __statist_h_o_wts[0,13]=8.95625452338698e-001;
    __statist_h_o_wts[0,14]=-9.69841826572395e-001;
    __statist_h_o_wts[0,15]=-1.84880086658517e+000;
    __statist_h_o_wts[0,16]=7.77910346107429e-001;
    __statist_h_o_wts[0,17]=6.87361368829519e-001;
    __statist_h_o_wts[0,18]=1.18932223990190e+000;
    __statist_h_o_wts[0,19]=-1.38727443240253e+000;
    __statist_h_o_wts[0,20]=-3.61860045963617e-001;
    __statist_h_o_wts[0,21]=2.13818719006135e-001;
    __statist_h_o_wts[0,22]=-2.96491539013623e-001;
    __statist_h_o_wts[0,23]=-1.11123731531657e+000;
    __statist_h_o_wts[0,24]=-1.21751494186981e+000;

    __statist_h_o_wts[1,0]=2.96626602114837e+000;
    __statist_h_o_wts[1,1]=8.39403158162225e-002;
    __statist_h_o_wts[1,2]=1.43628516129863e+000;
    __statist_h_o_wts[1,3]=3.57199186694308e-001;
    __statist_h_o_wts[1,4]=1.99025594329123e+000;
    __statist_h_o_wts[1,5]=4.06265015327809e-001;
    __statist_h_o_wts[1,6]=6.31009874886921e-001;
    __statist_h_o_wts[1,7]=5.07312703202173e-001;
    __statist_h_o_wts[1,8]=-4.34582366214970e-001;
    __statist_h_o_wts[1,9]=5.39517438151223e-001;
    __statist_h_o_wts[1,10]=-1.29953630507380e+000;
    __statist_h_o_wts[1,11]=-4.59478236281395e-001;
    __statist_h_o_wts[1,12]=8.59356039711731e-001;
    __statist_h_o_wts[1,13]=-9.11883481634046e-001;
    __statist_h_o_wts[1,14]=9.49698165023139e-001;
    __statist_h_o_wts[1,15]=1.86247565658145e+000;
    __statist_h_o_wts[1,16]=-7.97174955126083e-001;
    __statist_h_o_wts[1,17]=-7.53938604706560e-001;
    __statist_h_o_wts[1,18]=-1.22726549144164e+000;
    __statist_h_o_wts[1,19]=1.39807904402487e+000;
    __statist_h_o_wts[1,20]=3.32729808044988e-001;
    __statist_h_o_wts[1,21]=-2.45560692332621e-001;
    __statist_h_o_wts[1,22]=2.78253725043608e-001;
    __statist_h_o_wts[1,23]=1.09673995028183e+000;
    __statist_h_o_wts[1,24]=1.24843549840950e+000;

    double[] __statist_hidden_bias = new double[25];
    __statist_hidden_bias[0]=-6.34570385725316e-001;
    __statist_hidden_bias[1]=-1.18896063202231e-002;
    __statist_hidden_bias[2]=-2.46236682960803e-001;
    __statist_hidden_bias[3]=3.61416249986648e-002;
    __statist_hidden_bias[4]=1.24970669105118e-001;
    __statist_hidden_bias[5]=1.96364011246972e-001;
    __statist_hidden_bias[6]=8.97618170952654e-002;
    __statist_hidden_bias[7]=-8.39458101449653e-002;
    __statist_hidden_bias[8]=1.80189611995057e-001;
    __statist_hidden_bias[9]=-1.39688235144017e-002;
    __statist_hidden_bias[10]=8.29885391838937e-001;
    __statist_hidden_bias[11]=9.01405534539498e-002;
    __statist_hidden_bias[12]=-6.30042613770203e-002;
    __statist_hidden_bias[13]=-7.00098379845038e-002;
    __statist_hidden_bias[14]=-1.58287633366975e-001;
    __statist_hidden_bias[15]=-1.37437219517495e-001;
    __statist_hidden_bias[16]=-2.27606657638479e-001;
    __statist_hidden_bias[17]=5.82898879404825e-001;
    __statist_hidden_bias[18]=5.36094887704393e-002;
    __statist_hidden_bias[19]=-3.15687355218521e-001;
    __statist_hidden_bias[20]=-1.64571642896448e-002;
    __statist_hidden_bias[21]=3.09390624231207e-002;
    __statist_hidden_bias[22]=-2.87346555138226e-002;
    __statist_hidden_bias[23]=-3.26031491443644e-001;
    __statist_hidden_bias[24]=-1.37259841208392e-001;

    double[] __statist_output_bias = new double[2];
    __statist_output_bias[0]=6.39136462930081e-001;
    __statist_output_bias[1]=-6.40804928506706e-001;

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

      Console.WriteLine(" Predict24925286_левоed Category = " + __statist_PredCat);
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
       string Comment2 = "Please enter at least 249 command line parameters in the following order for \nthe program to Predict24925286_лево.\n";
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
