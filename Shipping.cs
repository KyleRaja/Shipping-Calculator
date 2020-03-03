using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
My Shipping Calculator calculates the shipping cost based on weight or number of items.
Has a standard, express, and one day delivery option.
Calculates Surcharge of shipment.
About and Exit feature.

 */


namespace proj_06_KR_V1._0.zip
{
    class Shipping
    {
        private int item;
        private int ship;
        private int define;
        private double weight;
        private double answer;
        private bool surCharge;


        public Shipping() // Default constructor. Turn all values to zero               
        {
            ship = 0;
            define = 0;
            surCharge = false;
            item = 0;
            weight = 0;
        }


        public Shipping(int m, int c, double w, bool e)  // Parameterized constructor.
        {                                                // The parameters are width, height, and width of the box
            surCharge = e;
            ship = m;
            define = c;
            weight = w;            
        }


        public Shipping(int m, int c, int i, bool e) // Parameterized constructor                                                      
        {                                            // Parameters are width height and width of the box
            surCharge = e;
            ship = m;
            define = c;
            item = i;
            
        }


        public double CalcShipping() // CalcShipping method 
                                     // Calculates: Standard, Express, and One-Day 
        {                            // This method returns an integer, and calculates volume

            // Declare variables and constants for weight, item, and surcharge.
            double give;

            const double EXP_ITEM_COST = 4.00;
            const double ONEDAY_CHARGE = 8.00;
            const double ONEDAY_WEIGHT_COST = 3.00;
            const double ONEDAY_ITEM_COST = 5.50;
            
            
                                  
            const double STD_CHARGE = 2.50;
            const double STD_WEIGHT_COST = 1.45;
            const double STD_ITEM_COST = 3.00;
            const double EXP_CHARGE = 5.00;
            const double EXP_WEIGHT_COST = 2.50;


            if (ship == 0)
            {
                if (surCharge)
                {
                   give = STD_CHARGE;

                }
                else
                {
                    give = 0;
                }
                if (define == 0)
                {
                    answer = weight * STD_WEIGHT_COST + give;
                }
                else
                {
                    answer = item * STD_ITEM_COST + give;
                }

            }
            else if (ship == 1)
            {
                if (surCharge)
                {
                    give = EXP_CHARGE;

                }
                else
                {
                    give = 0;
                }
                if (define == 0)
                {
                    answer = weight * EXP_WEIGHT_COST + give;

                }
                else
                {
                    answer = item * EXP_ITEM_COST + give;
                }


            }
            else
            {
                if (surCharge)
                {
                    give = ONEDAY_CHARGE;
                }
                else
                {
                    give = 0;
                }
                if (define == 0)
                {
                    answer = weight * ONEDAY_WEIGHT_COST + give;
                }
                else
                {
                    answer = item * ONEDAY_ITEM_COST + give;
                }
            }

            return answer;
        }

    }
}
