using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//using RGiesecke.DllExport;

namespace FuzzyLogic_FIS
{



    [ComVisible(true)]
    
    public class Execute
    {
        //Fuzzification and Deffuzzification variables
        #region
        public LingVariable f1_f2 = new LingVariable("F1-F2", VarType.Input);
        public LingVariable f2_f3 = new LingVariable("F2-F3", VarType.Input);
        public LingVariable f3_f1 = new LingVariable("F3-F1", VarType.Input);
        public LingVariable cambio_f1 = new LingVariable("Cambio F1", VarType.Output);
        public LingVariable cambio_f2 = new LingVariable("Cambio F2", VarType.Output);
        public LingVariable cambio_f3 = new LingVariable("Cambio F3", VarType.Output);


        public List<FuzzySet> fuzset = new List<FuzzySet>();
        #endregion

        //Inference variables
        #region

        public FLC c;

        public List<RuleItem> ri_1 = new List<RuleItem>();
        public List<RuleItem> ri_2 = new List<RuleItem>();
        public List<RuleItem> ri_3 = new List<RuleItem>();
        public List<RuleItem> ri_4 = new List<RuleItem>();
        public List<RuleItem> ri_5 = new List<RuleItem>();
        public List<RuleItem> ri_6 = new List<RuleItem>();
        public List<RuleItem> ri_7 = new List<RuleItem>();
        public List<RuleItem> ri_8 = new List<RuleItem>();
        public List<RuleItem> ri_9 = new List<RuleItem>();
        public List<RuleItem> ri_10 = new List<RuleItem>();
        public List<RuleItem> ri_11 = new List<RuleItem>();
        public List<RuleItem> ri_12 = new List<RuleItem>();
        public List<RuleItem> ri_13 = new List<RuleItem>();
        public List<RuleItem> ri_14 = new List<RuleItem>();
        public List<RuleItem> ri_15 = new List<RuleItem>();
        public List<RuleItem> ri_16 = new List<RuleItem>();
        public List<RuleItem> ri_17 = new List<RuleItem>();
        public List<RuleItem> ri_18 = new List<RuleItem>();
        public List<RuleItem> ri_19 = new List<RuleItem>();
        public List<RuleItem> ri_20 = new List<RuleItem>();
        public List<RuleItem> ri_21 = new List<RuleItem>();
        public List<RuleItem> ri_22 = new List<RuleItem>();
        public List<RuleItem> ri_23 = new List<RuleItem>();
        public List<RuleItem> ri_24 = new List<RuleItem>();
        public List<RuleItem> ri_25 = new List<RuleItem>();
        public List<RuleItem> ri_26 = new List<RuleItem>();
        public List<RuleItem> ri_27 = new List<RuleItem>();

        public List<RuleItem> ro_1_f1 = new List<RuleItem>();
        public List<RuleItem> ro_1_f2 = new List<RuleItem>();
        public List<RuleItem> ro_1_f3 = new List<RuleItem>();

        public List<RuleItem> ro_2_f1 = new List<RuleItem>();
        public List<RuleItem> ro_2_f2 = new List<RuleItem>();
        public List<RuleItem> ro_2_f3 = new List<RuleItem>();

        public List<RuleItem> ro_3_f1 = new List<RuleItem>();
        public List<RuleItem> ro_3_f2 = new List<RuleItem>();
        public List<RuleItem> ro_3_f3 = new List<RuleItem>();

        public List<RuleItem> ro_4_f1 = new List<RuleItem>();
        public List<RuleItem> ro_4_f2 = new List<RuleItem>();
        public List<RuleItem> ro_4_f3 = new List<RuleItem>();

        public List<RuleItem> ro_5_f1 = new List<RuleItem>();
        public List<RuleItem> ro_5_f2 = new List<RuleItem>();
        public List<RuleItem> ro_5_f3 = new List<RuleItem>();

        public List<RuleItem> ro_6_f1 = new List<RuleItem>();
        public List<RuleItem> ro_6_f2 = new List<RuleItem>();
        public List<RuleItem> ro_6_f3 = new List<RuleItem>();

        public List<RuleItem> ro_7_f1 = new List<RuleItem>();
        public List<RuleItem> ro_7_f2 = new List<RuleItem>();
        public List<RuleItem> ro_7_f3 = new List<RuleItem>();

        public List<RuleItem> ro_8_f1 = new List<RuleItem>();
        public List<RuleItem> ro_8_f2 = new List<RuleItem>();
        public List<RuleItem> ro_8_f3 = new List<RuleItem>();

        public List<RuleItem> ro_9_f1 = new List<RuleItem>();
        public List<RuleItem> ro_9_f2 = new List<RuleItem>();
        public List<RuleItem> ro_9_f3 = new List<RuleItem>();

        public List<RuleItem> ro_10_f1 = new List<RuleItem>();
        public List<RuleItem> ro_10_f2 = new List<RuleItem>();
        public List<RuleItem> ro_10_f3 = new List<RuleItem>();

        public List<RuleItem> ro_11_f1 = new List<RuleItem>();
        public List<RuleItem> ro_11_f2 = new List<RuleItem>();
        public List<RuleItem> ro_11_f3 = new List<RuleItem>();

        public List<RuleItem> ro_12_f1 = new List<RuleItem>();
        public List<RuleItem> ro_12_f2 = new List<RuleItem>();
        public List<RuleItem> ro_12_f3 = new List<RuleItem>();

        public List<RuleItem> ro_13_f1 = new List<RuleItem>();
        public List<RuleItem> ro_13_f2 = new List<RuleItem>();
        public List<RuleItem> ro_13_f3 = new List<RuleItem>();

        public List<RuleItem> ro_14_f1 = new List<RuleItem>();
        public List<RuleItem> ro_14_f2 = new List<RuleItem>();
        public List<RuleItem> ro_14_f3 = new List<RuleItem>();

        public List<RuleItem> ro_15_f1 = new List<RuleItem>();
        public List<RuleItem> ro_15_f2 = new List<RuleItem>();
        public List<RuleItem> ro_15_f3 = new List<RuleItem>();

        public List<RuleItem> ro_16_f1 = new List<RuleItem>();
        public List<RuleItem> ro_16_f2 = new List<RuleItem>();
        public List<RuleItem> ro_16_f3 = new List<RuleItem>();

        public List<RuleItem> ro_17_f1 = new List<RuleItem>();
        public List<RuleItem> ro_17_f2 = new List<RuleItem>();
        public List<RuleItem> ro_17_f3 = new List<RuleItem>();

        public List<RuleItem> ro_18_f1 = new List<RuleItem>();
        public List<RuleItem> ro_18_f2 = new List<RuleItem>();
        public List<RuleItem> ro_18_f3 = new List<RuleItem>();

        public List<RuleItem> ro_19_f1 = new List<RuleItem>();
        public List<RuleItem> ro_19_f2 = new List<RuleItem>();
        public List<RuleItem> ro_19_f3 = new List<RuleItem>();

        public List<RuleItem> ro_20_f1 = new List<RuleItem>();
        public List<RuleItem> ro_20_f2 = new List<RuleItem>();
        public List<RuleItem> ro_20_f3 = new List<RuleItem>();

        public List<RuleItem> ro_21_f1 = new List<RuleItem>();
        public List<RuleItem> ro_21_f2 = new List<RuleItem>();
        public List<RuleItem> ro_21_f3 = new List<RuleItem>();

        public List<RuleItem> ro_22_f1 = new List<RuleItem>();
        public List<RuleItem> ro_22_f2 = new List<RuleItem>();
        public List<RuleItem> ro_22_f3 = new List<RuleItem>();

        public List<RuleItem> ro_23_f1 = new List<RuleItem>();
        public List<RuleItem> ro_23_f2 = new List<RuleItem>();
        public List<RuleItem> ro_23_f3 = new List<RuleItem>();


        public List<RuleItem> ro_24_f1 = new List<RuleItem>();
        public List<RuleItem> ro_24_f2 = new List<RuleItem>();
        public List<RuleItem> ro_24_f3 = new List<RuleItem>();


        public List<RuleItem> ro_25_f1 = new List<RuleItem>();
        public List<RuleItem> ro_25_f2 = new List<RuleItem>();
        public List<RuleItem> ro_25_f3 = new List<RuleItem>();


        public List<RuleItem> ro_26_f1 = new List<RuleItem>();
        public List<RuleItem> ro_26_f2 = new List<RuleItem>();
        public List<RuleItem> ro_26_f3 = new List<RuleItem>();

        public List<RuleItem> ro_27_f1 = new List<RuleItem>();
        public List<RuleItem> ro_27_f2 = new List<RuleItem>();
        public List<RuleItem> ro_27_f3 = new List<RuleItem>();

        public InferEngine engine;
        public InferEngine engine_f1;
        public InferEngine engine_f2;
        public InferEngine engine_f3;

        public List<FuzzySet> impli;

        public List<FuzzySet> impli_f1;
        public List<FuzzySet> impli_f2;
        public List<FuzzySet> impli_f3;

        public Config conf = new Config(ImpMethod.Prod, ConnMethod.Min);
        public double output1, output2, output3;
        #endregion

        double input1, input2, input3;



        public Execute(double input1, double input2, double input3)
        {
            this.input1 = input1;
            this.input2 = input2;
            this.input3 = input3;
        }

        //[DllExport("KBF", CallingConvention = CallingConvention.Cdecl)]
        public void KnowledgeBaseFuzzification(double input1, double input2, double input3)
        {
            f1_f2.setRange(-45, 45);
            f1_f2.addMF(new Trapmf("Neg", -45, -45, -20, 0));
            f1_f2.addMF(new Trimf("Z", -20, 0, 20));
            f1_f2.addMF(new Trapmf("Pos", 0, 20, 45, 45));

            f2_f3.setRange(-45, 45);
            f2_f3.addMF(new Trapmf("Neg", -45, -45, -20, 0));
            f2_f3.addMF(new Trimf("Z", -20, 0, 20));
            f2_f3.addMF(new Trapmf("Pos", 0, 20, 45, 45));

            f3_f1.setRange(-45, 45);
            f3_f1.addMF(new Trapmf("Neg", -45, -45, -20, 0));
            f3_f1.addMF(new Trimf("Z", -20, 0, 20));
            f3_f1.addMF(new Trapmf("Pos", 0, 20, 45, 45));

            cambio_f1.setRange(-10, 10);
            cambio_f1.addMF(new Trapmf("Neg", -10, -10, -6, 0));
            cambio_f1.addMF(new Trimf("Z", -6, 0, 6));
            cambio_f1.addMF(new Trapmf("Pos", 0, 6, 10, 10));

            cambio_f2.setRange(-10, 10);
            cambio_f2.addMF(new Trapmf("Neg", -10, -10, -6, 0));
            cambio_f2.addMF(new Trimf("Z", -6, 0, 6));
            cambio_f2.addMF(new Trapmf("Pos", 0, 6, 10, 10));

            cambio_f3.setRange(-10, 10);
            cambio_f3.addMF(new Trapmf("Neg", -10, -10, -6, 0));
            cambio_f3.addMF(new Trimf("Z", -6, 0, 6));
            cambio_f3.addMF(new Trapmf("Pos", 0, 6, 10, 10));

            c = new FLC(conf);

            FuzzySet s1 = new FuzzySet(c.Fuzzification(input1, f1_f2), f1_f2.Name);
            FuzzySet s2 = new FuzzySet(c.Fuzzification(input2, f2_f3), f2_f3.Name);
            FuzzySet s3 = new FuzzySet(c.Fuzzification(input3, f3_f1), f3_f1.Name);

            fuzset.Add(s1);
            fuzset.Add(s2);
            fuzset.Add(s3);

            //Console.WriteLine("\nFuzzification of inputs");

            /*for (int i = 0; i < fuzset.Count; i++)
            {
                Console.WriteLine(fuzset[i].Variable);

                for (int j = 0; j < fuzset[i].Set.Count; j++)
                {
                    Console.WriteLine(fuzset[i].Set[j].ToString());
                }
                Console.WriteLine();
            }*/
        }

        //[DllExport("Inference", CallingConvention = CallingConvention.Cdecl)]
        public void Inference()
        {
            ri_1.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Neg"), new RuleItem("F2-F3", "Neg"), new RuleItem("F3-F1", "Neg") });
            ro_1_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_1_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_1_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_2.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Neg"), new RuleItem("F2-F3", "Neg"), new RuleItem("F3-F1", "Z") });
            ro_2_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_2_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_2_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") }); //OR

            ri_3.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Neg"), new RuleItem("F2-F3", "Neg"), new RuleItem("F3-F1", "Pos") });
            ro_3_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_3_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_3_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });


            ri_4.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Neg"), new RuleItem("F2-F3", "Z"), new RuleItem("F3-F1", "Neg") });
            ro_4_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_4_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_4_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") });


            ri_5.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Neg"), new RuleItem("F2-F3", "Z"), new RuleItem("F3-F1", "Z") }); //or
            ro_5_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_5_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_5_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") });

            ri_6.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Neg"), new RuleItem("F2-F3", "Z"), new RuleItem("F3-F1", "Pos") }); //or
            ro_6_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_6_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_6_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_7.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Neg"), new RuleItem("F2-F3", "Pos"), new RuleItem("F3-F1", "Neg") });
            ro_7_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_7_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_7_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_8.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Neg"), new RuleItem("F2-F3", "Pos"), new RuleItem("F3-F1", "Z") }); //or
            ro_8_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_8_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_8_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") });

            ri_9.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Neg"), new RuleItem("F2-F3", "Pos"), new RuleItem("F3-F1", "Pos") }); //or
            ro_9_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_9_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_9_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Z") });

            ri_10.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Z"), new RuleItem("F2-F3", "Neg"), new RuleItem("F3-F1", "Neg") }); //or
            ro_10_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_10_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Pos") });
            ro_10_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_11.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Z"), new RuleItem("F2-F3", "Neg"), new RuleItem("F3-F1", "Z") }); //or
            ro_11_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_11_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Z") });
            ro_11_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_12.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Z"), new RuleItem("F2-F3", "Neg"), new RuleItem("F3-F1", "Pos") }); //or
            ro_12_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_12_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_12_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_13.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Z"), new RuleItem("F2-F3", "Z"), new RuleItem("F3-F1", "Neg") }); //or
            ro_13_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_13_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Pos") });
            ro_13_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") });

            ri_14.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Z"), new RuleItem("F2-F3", "Z"), new RuleItem("F3-F1", "Z") });
            ro_14_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Z") });
            ro_14_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Z") });
            ro_14_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Z") });

            ri_15.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Z"), new RuleItem("F2-F3", "Z"), new RuleItem("F3-F1", "Pos") }); //or
            ro_15_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_15_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_15_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_16.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Z"), new RuleItem("F2-F3", "Pos"), new RuleItem("F3-F1", "Neg") }); //or
            ro_16_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_16_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_16_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") });

            ri_17.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Z"), new RuleItem("F2-F3", "Pos"), new RuleItem("F3-F1", "Z") }); //or
            ro_17_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_17_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_17_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_18.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Z"), new RuleItem("F2-F3", "Pos"), new RuleItem("F3-F1", "Pos") }); //or
            ro_18_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_18_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_18_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") });

            ri_19.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Pos"), new RuleItem("F2-F3", "Neg"), new RuleItem("F3-F1", "Neg") });
            ro_19_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_19_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Pos") });
            ro_19_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") });

            ri_20.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Pos"), new RuleItem("F2-F3", "Neg"), new RuleItem("F3-F1", "Z") });
            ro_20_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_20_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Pos") });
            ro_20_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_21.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Pos"), new RuleItem("F2-F3", "Neg"), new RuleItem("F3-F1", "Pos") });
            ro_21_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_21_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Pos") });
            ro_21_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_22.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Pos"), new RuleItem("F2-F3", "Z"), new RuleItem("F3-F1", "Neg") }); //or
            ro_22_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_22_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Pos") });
            ro_22_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_23.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Pos"), new RuleItem("F2-F3", "Z"), new RuleItem("F3-F1", "Z") }); //or
            ro_23_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_23_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Pos") });
            ro_23_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") });

            ri_24.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Pos"), new RuleItem("F2-F3", "Z"), new RuleItem("F3-F1", "Pos") }); //or
            ro_24_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Pos") });
            ro_24_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_24_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });

            ri_25.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Pos"), new RuleItem("F2-F3", "Pos"), new RuleItem("F3-F1", "Neg") });
            ro_25_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_25_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_25_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") });

            ri_26.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Pos"), new RuleItem("F2-F3", "Pos"), new RuleItem("F3-F1", "Z") });
            ro_26_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_26_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Neg") });
            ro_26_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Pos") });

            ri_27.AddRange(new RuleItem[3] { new RuleItem("F1-F2", "Pos"), new RuleItem("F2-F3", "Pos"), new RuleItem("F3-F1", "Pos") });
            ro_27_f1.AddRange(new RuleItem[1] { new RuleItem("DF1", "Neg") });
            ro_27_f2.AddRange(new RuleItem[1] { new RuleItem("DF2", "Pos") });
            ro_27_f3.AddRange(new RuleItem[1] { new RuleItem("DF3", "Neg") });



            List<Rule> rules = new List<Rule>();
            List<Rule> rules_f1 = new List<Rule>();
            List<Rule> rules_f2 = new List<Rule>();
            List<Rule> rules_f3 = new List<Rule>();

            #region addrules

            rules_f1.Add(new Rule(ri_1, ro_1_f1, Connector.And));
            rules_f2.Add(new Rule(ri_1, ro_1_f2, Connector.And));
            rules_f3.Add(new Rule(ri_1, ro_1_f3, Connector.And));

            rules_f1.Add(new Rule(ri_2, ro_2_f1, Connector.And));
            rules_f2.Add(new Rule(ri_2, ro_2_f2, Connector.And));
            rules_f3.Add(new Rule(ri_2, ro_2_f3, Connector.And));

            rules_f1.Add(new Rule(ri_3, ro_3_f1, Connector.And));
            rules_f2.Add(new Rule(ri_3, ro_3_f2, Connector.And));
            rules_f3.Add(new Rule(ri_3, ro_3_f3, Connector.And));

            rules_f1.Add(new Rule(ri_4, ro_4_f1, Connector.And));
            rules_f2.Add(new Rule(ri_4, ro_4_f2, Connector.And));
            rules_f3.Add(new Rule(ri_4, ro_4_f3, Connector.And));

            rules_f1.Add(new Rule(ri_5, ro_5_f1, Connector.And));
            rules_f2.Add(new Rule(ri_5, ro_5_f2, Connector.And));
            rules_f3.Add(new Rule(ri_5, ro_5_f3, Connector.And));

            rules_f1.Add(new Rule(ri_6, ro_6_f1, Connector.And));
            rules_f2.Add(new Rule(ri_6, ro_6_f2, Connector.And));
            rules_f3.Add(new Rule(ri_6, ro_6_f3, Connector.And));

            rules_f1.Add(new Rule(ri_7, ro_7_f1, Connector.And));
            rules_f2.Add(new Rule(ri_7, ro_7_f2, Connector.And));
            rules_f3.Add(new Rule(ri_7, ro_7_f3, Connector.And));

            rules_f1.Add(new Rule(ri_8, ro_8_f1, Connector.And));
            rules_f2.Add(new Rule(ri_8, ro_8_f2, Connector.And));
            rules_f3.Add(new Rule(ri_8, ro_8_f3, Connector.And));

            rules_f1.Add(new Rule(ri_9, ro_9_f1, Connector.And));
            rules_f2.Add(new Rule(ri_9, ro_9_f2, Connector.And));
            rules_f3.Add(new Rule(ri_9, ro_9_f3, Connector.And));

            rules_f1.Add(new Rule(ri_10, ro_10_f1, Connector.And));
            rules_f2.Add(new Rule(ri_10, ro_10_f2, Connector.And));
            rules_f3.Add(new Rule(ri_10, ro_10_f3, Connector.And));

            rules_f1.Add(new Rule(ri_11, ro_11_f1, Connector.And));
            rules_f2.Add(new Rule(ri_11, ro_11_f2, Connector.And));
            rules_f3.Add(new Rule(ri_11, ro_11_f3, Connector.And));

            rules_f1.Add(new Rule(ri_12, ro_12_f1, Connector.And));
            rules_f2.Add(new Rule(ri_12, ro_12_f2, Connector.And));
            rules_f3.Add(new Rule(ri_12, ro_12_f3, Connector.And));

            rules_f1.Add(new Rule(ri_13, ro_13_f1, Connector.And));
            rules_f2.Add(new Rule(ri_13, ro_13_f2, Connector.And));
            rules_f3.Add(new Rule(ri_13, ro_13_f3, Connector.And));

            rules_f1.Add(new Rule(ri_14, ro_14_f1, Connector.And));
            rules_f2.Add(new Rule(ri_14, ro_14_f2, Connector.And));
            rules_f3.Add(new Rule(ri_14, ro_14_f3, Connector.And));

            rules_f1.Add(new Rule(ri_15, ro_15_f1, Connector.And));
            rules_f2.Add(new Rule(ri_15, ro_15_f2, Connector.And));
            rules_f3.Add(new Rule(ri_15, ro_15_f3, Connector.And));

            rules_f1.Add(new Rule(ri_16, ro_16_f1, Connector.And));
            rules_f2.Add(new Rule(ri_16, ro_16_f2, Connector.And));
            rules_f3.Add(new Rule(ri_16, ro_16_f3, Connector.And));

            rules_f1.Add(new Rule(ri_17, ro_17_f1, Connector.And));
            rules_f2.Add(new Rule(ri_17, ro_17_f2, Connector.And));
            rules_f3.Add(new Rule(ri_17, ro_17_f3, Connector.And));

            rules_f1.Add(new Rule(ri_18, ro_18_f1, Connector.And));
            rules_f2.Add(new Rule(ri_18, ro_18_f2, Connector.And));
            rules_f3.Add(new Rule(ri_18, ro_18_f3, Connector.And));

            rules_f1.Add(new Rule(ri_19, ro_19_f1, Connector.And));
            rules_f2.Add(new Rule(ri_19, ro_19_f2, Connector.And));
            rules_f3.Add(new Rule(ri_19, ro_19_f3, Connector.And));

            rules_f1.Add(new Rule(ri_20, ro_20_f1, Connector.And));
            rules_f2.Add(new Rule(ri_20, ro_20_f2, Connector.And));
            rules_f3.Add(new Rule(ri_20, ro_20_f3, Connector.And));

            rules_f1.Add(new Rule(ri_21, ro_21_f1, Connector.And));
            rules_f2.Add(new Rule(ri_21, ro_21_f2, Connector.And));
            rules_f3.Add(new Rule(ri_21, ro_21_f3, Connector.And));

            rules_f1.Add(new Rule(ri_22, ro_22_f1, Connector.And));
            rules_f2.Add(new Rule(ri_22, ro_22_f2, Connector.And));
            rules_f3.Add(new Rule(ri_22, ro_22_f3, Connector.And));

            rules_f1.Add(new Rule(ri_23, ro_23_f1, Connector.And));
            rules_f2.Add(new Rule(ri_23, ro_23_f2, Connector.And));
            rules_f3.Add(new Rule(ri_23, ro_23_f3, Connector.And));

            rules_f1.Add(new Rule(ri_24, ro_24_f1, Connector.And));
            rules_f2.Add(new Rule(ri_24, ro_24_f2, Connector.And));
            rules_f3.Add(new Rule(ri_24, ro_24_f3, Connector.And));

            rules_f1.Add(new Rule(ri_25, ro_25_f1, Connector.And));
            rules_f2.Add(new Rule(ri_25, ro_25_f2, Connector.And));
            rules_f3.Add(new Rule(ri_25, ro_25_f3, Connector.And));

            rules_f1.Add(new Rule(ri_26, ro_26_f1, Connector.And));
            rules_f2.Add(new Rule(ri_26, ro_26_f2, Connector.And));
            rules_f3.Add(new Rule(ri_26, ro_26_f3, Connector.And));

            rules_f1.Add(new Rule(ri_27, ro_27_f1, Connector.And));
            rules_f2.Add(new Rule(ri_27, ro_27_f2, Connector.And));
            rules_f3.Add(new Rule(ri_27, ro_27_f3, Connector.And));

            #endregion

            engine = new InferEngine(conf, rules, fuzset);
            engine_f1 = new InferEngine(conf, rules_f1, fuzset);
            engine_f2 = new InferEngine(conf, rules_f2, fuzset);
            engine_f3 = new InferEngine(conf, rules_f3, fuzset);

            impli_f1 = engine_f1.evaluateRules();
            impli_f2 = engine_f2.evaluateRules();
            impli_f3 = engine_f3.evaluateRules();


            //Console.WriteLine("\nRule Evaluation for Output 1:");

            /*for (int i = 0; i < engine_f1.FiredRules.Count; i++)
            {
                Console.WriteLine("Rule: " + engine_f1.FiredRules[i].ToString());
            }

            for (int i = 0; i < impli_f1.Count; i++)
            {
                Console.WriteLine(impli_f1[i].Variable);

                for (int j = 0; j < impli_f1[i].Set.Count; j++)
                {
                    Console.WriteLine(impli_f1[i].Set[j].ToString());
                }

                Console.WriteLine();
            }



            Console.WriteLine("\nRule Evaluation for Output 2:");

            for (int i = 0; i < engine_f2.FiredRules.Count; i++)
            {
                Console.WriteLine("Rule: " + engine_f2.FiredRules[i].ToString());
            }

            for (int i = 0; i < impli_f2.Count; i++)
            {
                Console.WriteLine(impli_f2[i].Variable);

                for (int j = 0; j < impli_f2[i].Set.Count; j++)
                {
                    Console.WriteLine(impli_f2[i].Set[j].ToString());
                }

                Console.WriteLine();
            }



            Console.WriteLine("\nRule Evaluation for Output 3:");

            for (int i = 0; i < engine_f3.FiredRules.Count; i++)
            {
                Console.WriteLine("Rule: " + engine_f3.FiredRules[i].ToString());
            }

            for (int i = 0; i < impli_f3.Count; i++)
            {
                Console.WriteLine(impli_f3[i].Variable);

                for (int j = 0; j < impli_f3[i].Set.Count; j++)
                {
                    Console.WriteLine(impli_f3[i].Set[j].ToString());
                }

                Console.WriteLine();
            }*/


        }

        //[DllExport("Deffuzz", CallingConvention = CallingConvention.Cdecl)]
        public double [] Deffuzzification()
        {
            double [] output_array = new double[3];

            //Console.WriteLine("\nFuzzy Outputs after rules evaluation");

            output1 = c.DeFuzzification(impli_f1, cambio_f1);
            output2 = c.DeFuzzification(impli_f2, cambio_f2);
            output3 = c.DeFuzzification(impli_f3, cambio_f3);

            output_array[0] = output1;
            output_array[1] = output2;
            output_array[2] = output3;

           // Console.WriteLine("Change in Phase A: " + output1);
           // Console.WriteLine("Change in Phase B: " + output2);
           //  Console.WriteLine("Change in Phase C: " + output3);

            return output_array;

        }
    }


   

}
