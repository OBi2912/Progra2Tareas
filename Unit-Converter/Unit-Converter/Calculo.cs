using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
namespace Unit_Converter
{
    public class Calculo
    {
        public String calculoMedida(int PosicionDe, int PosicionA, double DatoDbl)
        {
            //Se declaran variables
            //Se declara variable dedicada a manejar cantidades con muchos decimales recibiendo
            //como dato el valor ingresado por el usuario
            double Dato = DatoDbl;
            //Se declara variable dedicada a almacenar cantidades largas por default a la hora de convertir
            //double constante;
            //Se declara variable dedicada a almacenar el resultado obtenido de la conversion
            double conversion = 0;
            //Si las posiciones de ambos combos es la misma
            //(dando a entender que es el mismo tipo de longitud)
            if (PosicionDe == PosicionA)
            {
                //Se coloca el mismo dato colocado en el editText
                conversion = Dato;
            }
            else
            {
                //Si no verifica que tipo de longitud sera la base de conversion
                switch (PosicionDe)
                {
                    case 0: //Kilometro
                        switch (PosicionA)
                        {
                            case 1:// A metro
                                conversion = Dato * 1000;// Dato.multiply(double.valueOf(1000), MathContext.DECIMAL32);
                                break;
                            case 2:// A centimetro
                                conversion = Dato * 100000;//.multiply(double.valueOf(100000), MathContext.DECIMAL32);
                                break;
                            case 3: //A Milimetro
                                conversion = Dato * 1000000;//.multiply(double.valueOf(1000000), MathContext.DECIMAL32);
                                break;
                            case 4://A Micrometro
                                conversion = Dato * 1000000000;//.multiply(double.valueOf(1000000000), MathContext.DECIMAL32);
                                break;
                            case 5://A nanometro
                                //constante = new double("1000000000000");
                                conversion = Dato * 1000000000000;//.multiply(constante, MathContext.DECIMAL32);
                                break;
                            case 6://A milla
                                conversion = Dato / 1.609;//.divide(double.valueOf(1.609), MathContext.DECIMAL32);
                                break;
                            case 7://A Yarda
                                conversion = Dato * 1093.613;//.multiply(double.valueOf(1093.613), MathContext.DECIMAL32);
                                break;
                            case 8://A pie
                                conversion = Dato * 3280.84;//.multiply(double.valueOf(3280.84), MathContext.DECIMAL32);
                                break;
                            case 9://A pulgada
                                conversion = Dato * 39370.079;//.multiply(double.valueOf(39370.079), MathContext.DECIMAL32);
                                break;
                            case 10://A Milla nautica
                                conversion = Dato / 1.852;//.divide(double.valueOf(1.852), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                    case 1: //Metro
                        switch (PosicionA)
                        {
                            case 0:// A Kilometro
                                conversion = Dato / 1000;//.divide(double.valueOf(1000), MathContext.DECIMAL32);
                                break;
                            case 2:// A centimetro
                                conversion = Dato * 100;//.multiply(double.valueOf(100), MathContext.DECIMAL32);
                                break;
                            case 3: //A Milimetro
                                conversion = Dato * 1000;//.multiply(double.valueOf(1000), MathContext.DECIMAL32);
                                break;
                            case 4://A Micrometro
                                conversion = Dato * 1000000;//.multiply(double.valueOf(1000000), MathContext.DECIMAL32);
                                break;
                            case 5://A nanometro
                                //constante = new double("1000000000");
                                conversion = Dato * 1000000000;//.multiply(constante, MathContext.DECIMAL32);
                                break;
                            case 6://A milla
                                conversion = Dato / 1609.344;//.divide(double.valueOf(1609.344), MathContext.DECIMAL32);
                                break;
                            case 7://A Yarda
                                conversion = Dato * 1094;//.multiply(double.valueOf(1094), MathContext.DECIMAL32);
                                break;
                            case 8://A pie
                                conversion = Dato * 3.281;//.multiply(double.valueOf(3.281), MathContext.DECIMAL32);
                                break;
                            case 9://A pulgada
                                conversion = Dato * 39.37;//.multiply(double.valueOf(39.37), MathContext.DECIMAL32);
                                break;
                            case 10://A Milla nautica
                                conversion = Dato / 1852;//.divide(double.valueOf(1852), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                    case 2: //Centimetro
                        switch (PosicionA)
                        {
                            case 0:// A Kilometro
                                conversion = Dato / 100000;//.divide(double.valueOf(100000), MathContext.DECIMAL32);
                                break;
                            case 1:// A metro
                                conversion = Dato / 100;//.divide(double.valueOf(100), MathContext.DECIMAL32);
                                break;
                            case 3: //A Milimetro
                                conversion = Dato * 10;//.multiply(double.valueOf(10), MathContext.DECIMAL32);
                                break;
                            case 4://A Micrometro
                                conversion = Dato * 10000;//.multiply(double.valueOf(10000), MathContext.DECIMAL32);
                                break;
                            case 5://A nanometro
                                conversion = Dato * 10000000;//.multiply(double.valueOf(10000000), MathContext.DECIMAL32);
                                break;
                            case 6://A milla
                                conversion = Dato / 160934.4;//.divide(double.valueOf(160934.4), MathContext.DECIMAL32);
                                break;
                            case 7://A Yarda
                                conversion = Dato / 91.44;//.divide(double.valueOf(91.44), MathContext.DECIMAL32);
                                break;
                            case 8://A pie
                                conversion = Dato / 30.48;//.divide(double.valueOf(30.48), MathContext.DECIMAL32);
                                break;
                            case 9://A pulgada
                                conversion = Dato / 2.54;//.divide(double.valueOf(2.54), MathContext.DECIMAL32);
                                break;
                            case 10://A Milla nautica
                                conversion = Dato / 185200;//.divide(double.valueOf(185200), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                    case 3: //Milimetro
                        switch (PosicionA)
                        {
                            case 0:// A Kilometro
                                conversion = Dato / 1000000;//.divide(double.valueOf(1000000), MathContext.DECIMAL32);
                                break;
                            case 1:// A metro
                                conversion = Dato / 1000;//.divide(double.valueOf(1000), MathContext.DECIMAL32);
                                break;
                            case 2: //A centimetro
                                conversion = Dato / 10;//.divide(double.valueOf(10), MathContext.DECIMAL32);
                                break;
                            case 4://A Micrometro
                                conversion = Dato * 1000;//.multiply(double.valueOf(1000), MathContext.DECIMAL32);
                                break;
                            case 5://A nanometro
                                conversion = Dato * 1000000;//.multiply(double.valueOf(1000000), MathContext.DECIMAL32);
                                break;
                            case 6://A milla
                                conversion = Dato / 1.609000000;//.divide(double.valueOf(1.609000000), MathContext.DECIMAL32);
                                break;
                            case 7://A Yarda
                                conversion = Dato / 914.4;//.divide(double.valueOf(914.4), MathContext.DECIMAL32);
                                break;
                            case 8://A pie
                                conversion = Dato / 304.8;//.divide(double.valueOf(304.8), MathContext.DECIMAL32);
                                break;
                            case 9://A pulgada
                                conversion = Dato / 25.4;//.divide(double.valueOf(25.4), MathContext.DECIMAL32);
                                break;
                            case 10://A Milla nautica
                                conversion = Dato / 1.852000000;//.divide(double.valueOf(1.852000000), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                    case 4: //Micrometro
                        switch (PosicionA)
                        {
                            case 0:// A Kilometro
                                conversion = Dato / 1000000000;//.divide(double.valueOf(1000000000), MathContext.DECIMAL32);
                                break;
                            case 1:// A metro
                                conversion = Dato / 1000000;//.divide(double.valueOf(1000000), MathContext.DECIMAL32);
                                break;
                            case 2: //A centimetro
                                conversion = Dato / 10000;//.divide(double.valueOf(10000), MathContext.DECIMAL32);
                                break;
                            case 3://A Milimetro
                                conversion = Dato / 1000;//.divide(double.valueOf(1000), MathContext.DECIMAL32);
                                break;
                            case 5://A nanometro
                                conversion = Dato * 1000;//.multiply(double.valueOf(1000), MathContext.DECIMAL32);
                                break;
                            case 6://A milla
                                conversion = Dato / 1.609000000000;//.divide(double.valueOf(1.609000000000), MathContext.DECIMAL32);
                                break;
                            case 7://A Yarda
                                conversion = Dato / 914400;//.divide(double.valueOf(914400), MathContext.DECIMAL32);
                                break;
                            case 8://A pie
                                conversion = Dato / 304800;//.divide(double.valueOf(304800), MathContext.DECIMAL32);
                                break;
                            case 9://A pulgada
                                conversion = Dato / 25400;//.divide(double.valueOf(25400), MathContext.DECIMAL32);
                                break;
                            case 10://A Milla nautica
                                conversion = Dato / 1.852000000000;//.divide(double.valueOf(1.852000000000), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                    case 5: //Nanometro
                        switch (PosicionA)
                        {
                            case 0:// A Kilometro
                                //constante = new double("1000000000000");
                                conversion = Dato / 1000000000000;//.divide(constante, MathContext.DECIMAL32);
                                break;
                            case 1:// A metro
                                conversion = Dato / 1000000000;//.divide(double.valueOf(1000000000), MathContext.DECIMAL32);
                                break;
                            case 2: //A centimetro
                                conversion = Dato / 10000000;//.divide(double.valueOf(10000000), MathContext.DECIMAL32);
                                break;
                            case 3://A Milimetro
                                conversion = Dato / 1000000;//.divide(double.valueOf(1000000), MathContext.DECIMAL32);
                                break;
                            case 4://A micrometro
                                conversion = Dato / 1000;//.divide(double.valueOf(1000), MathContext.DECIMAL32);
                                break;
                            case 6://A milla
                                conversion = Dato / 1.609000000000000;//.divide(double.valueOf(1.609000000000000), MathContext.DECIMAL32);
                                break;
                            case 7://A Yarda
                                conversion = Dato / 9.14400000000;//.divide(double.valueOf(9.14400000000), MathContext.DECIMAL32);
                                break;
                            case 8://A pie
                                conversion = Dato / 3.04800000000;//.divide(double.valueOf(3.04800000000), MathContext.DECIMAL32);
                                break;
                            case 9://A pulgada
                                conversion = Dato / 2.540000000;//.divide(double.valueOf(2.540000000), MathContext.DECIMAL32);
                                break;
                            case 10://A Milla nautica
                                conversion = Dato / 1.852000000000000;//.divide(double.valueOf(1.852000000000000), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                    case 6: //Milla
                        switch (PosicionA)
                        {
                            case 0:// A Kilometro
                                conversion = Dato * 1.609;//.multiply(double.valueOf(1.609), MathContext.DECIMAL32);
                                break;
                            case 1:// A metro
                                conversion = Dato * 1609.344;//.multiply(double.valueOf(1609.344), MathContext.DECIMAL32);
                                break;
                            case 2: //A centimetro
                                conversion = Dato * 160934.4;//.multiply(double.valueOf(160934.4), MathContext.DECIMAL32);
                                break;
                            case 3://A Milimetro
                                conversion = Dato * 1.609000000;//.multiply(double.valueOf(1.609000000), MathContext.DECIMAL32);
                                break;
                            case 4://A Micrometro
                                conversion = Dato * 1.609000000000;//.multiply(double.valueOf(1.609000000000), MathContext.DECIMAL32);
                                break;
                            case 5://A nanometro
                                conversion = Dato * 1.609000000000000;//.multiply(double.valueOf(1.609000000000000), MathContext.DECIMAL32);
                                break;
                            case 7://A Yarda
                                conversion = Dato * 1760;//.multiply(double.valueOf(1760), MathContext.DECIMAL32);
                                break;
                            case 8://A pie
                                conversion = Dato * 5280;//.multiply(double.valueOf(5280), MathContext.DECIMAL32);
                                break;
                            case 9://A pulgada
                                conversion = Dato * 63360;//.multiply(double.valueOf(63360), MathContext.DECIMAL32);
                                break;
                            case 10://A Milla nautica
                                conversion = Dato / 1.151;//.divide(double.valueOf(1.151), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                    case 7: //Yarda
                        switch (PosicionA)
                        {
                            case 0:// A Kilometro
                                conversion = Dato / 1093.613;//.divide(double.valueOf(1093.613), MathContext.DECIMAL32);
                                break;
                            case 1:// A metro
                                conversion = Dato / 1.094;//.divide(double.valueOf(1.094), MathContext.DECIMAL32);
                                break;
                            case 2: //A centimetro
                                conversion = Dato * 91.44;//.multiply(double.valueOf(91.44), MathContext.DECIMAL32);
                                break;
                            case 3://A Milimetro
                                conversion = Dato * 914.4;//.multiply(double.valueOf(914.4), MathContext.DECIMAL32);
                                break;
                            case 4://A Micrometro
                                conversion = Dato * 914400;//.multiply(double.valueOf(914400), MathContext.DECIMAL32);
                                break;
                            case 5://A Nanometro
                                conversion = Dato * 9.14400000000;//.multiply(double.valueOf(9.14400000000), MathContext.DECIMAL32);
                                break;
                            case 6://A Milla
                                conversion = Dato / 1760;//.divide(double.valueOf(1760), MathContext.DECIMAL32);
                                break;
                            case 8://A pie
                                conversion = Dato * 3;//.multiply(double.valueOf(3), MathContext.DECIMAL32);
                                break;
                            case 9://A pulgada
                                conversion = Dato * 36;//.multiply(double.valueOf(36), MathContext.DECIMAL32);
                                break;
                            case 10://A Milla nautica
                                conversion = Dato / 2025.372;//.divide(double.valueOf(2025.372), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                    case 8: //Pie
                        switch (PosicionA)
                        {
                            case 0:// A Kilometro
                                conversion = Dato / 2025.372;//.divide(double.valueOf(2025.372), MathContext.DECIMAL32);
                                break;
                            case 1:// A metro
                                conversion = Dato / 3.281;//.divide(double.valueOf(3.281), MathContext.DECIMAL32);
                                break;
                            case 2: //A centimetro
                                conversion = Dato * 30.48;//.multiply(double.valueOf(30.48), MathContext.DECIMAL32);
                                break;
                            case 3://A Milimetro
                                conversion = Dato * 304.8;//.multiply(double.valueOf(304.8), MathContext.DECIMAL32);
                                break;
                            case 4://A Micrometro
                                conversion = Dato * 304800;//.multiply(double.valueOf(304800), MathContext.DECIMAL32);
                                break;
                            case 5://A Nanometro
                                conversion = Dato * 3.04800000000;//.multiply(double.valueOf(3.04800000000), MathContext.DECIMAL32);
                                break;
                            case 6://A Milla
                                conversion = Dato / 5280;//.divide(double.valueOf(5280), MathContext.DECIMAL32);
                                break;
                            case 7://A Yarda
                                conversion = Dato / 3;//.divide(double.valueOf(3), MathContext.DECIMAL32);
                                break;
                            case 9://A pulgada
                                conversion = Dato * 12;//.multiply(double.valueOf(12), MathContext.DECIMAL32);
                                break;
                            case 10://A Milla nautica
                                conversion = Dato / 6076.115;//.divide(double.valueOf(6076.115), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                    case 9: //Pulgada
                        switch (PosicionA)
                        {
                            case 0:// A Kilometro
                                conversion = Dato / 39370.079;//.divide(double.valueOf(39370.079), MathContext.DECIMAL32);
                                break;
                            case 1:// A metro
                                conversion = Dato / 39.37;//.divide(double.valueOf(39.37), MathContext.DECIMAL32);
                                break;
                            case 2: //A centimetro
                                conversion = Dato * 2.54;//.multiply(double.valueOf(2.54), MathContext.DECIMAL32);
                                break;
                            case 3://A Milimetro
                                conversion = Dato * 25.4;//.multiply(double.valueOf(25.4), MathContext.DECIMAL32);
                                break;
                            case 4://A Micrometro
                                conversion = Dato * 25400;//.multiply(double.valueOf(25400), MathContext.DECIMAL32);
                                break;
                            case 5://A nanometro
                                conversion = Dato * 2.540000000;//.multiply(double.valueOf(2.540000000), MathContext.DECIMAL32);
                                break;
                            case 6://A Milla
                                conversion = Dato / 63360;//.divide(double.valueOf(63360), MathContext.DECIMAL32);
                                break;
                            case 7://A Yarda
                                conversion = Dato / 36;//.divide(double.valueOf(36), MathContext.DECIMAL32);
                                break;
                            case 8://A pie
                                conversion = Dato / 12;//.divide(double.valueOf(12), MathContext.DECIMAL32);
                                break;
                            case 10://A Milla nautica
                                conversion = Dato / 72913.386;//.divide(double.valueOf(72913.386), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                    case 10: //Milla nautica
                        switch (PosicionA)
                        {
                            case 0:// A Kilometro
                                conversion = Dato * 1.852;//.multiply(double.valueOf(1.852), MathContext.DECIMAL32);
                                break;
                            case 1:// A metro
                                conversion = Dato * 1852;//.multiply(double.valueOf(1852), MathContext.DECIMAL32);
                                break;
                            case 2: //A centimetro
                                conversion = Dato * 185200;//.multiply(double.valueOf(185200), MathContext.DECIMAL32);
                                break;
                            case 3://A Milimetro
                                conversion = Dato * 1.852000000;//.multiply(double.valueOf(1.852000000), MathContext.DECIMAL32);
                                break;
                            case 4://A Micrometro
                                conversion = Dato * 1.852000000000;//.multiply(double.valueOf(1.852000000000), MathContext.DECIMAL32);
                                break;
                            case 5://A Nanometro
                                conversion = Dato / 1.852000000000000;//.divide(double.valueOf(1.852000000000000), MathContext.DECIMAL32);
                                break;
                            case 6://A Milla
                                conversion = Dato * 1.151;//.multiply(double.valueOf(1.151), MathContext.DECIMAL32);
                                break;
                            case 7://A Yarda
                                conversion = Dato * 2025.372;//.multiply(double.valueOf(2025.372), MathContext.DECIMAL32);
                                break;
                            case 8://A pie
                                conversion = Dato * 6076.115;//.multiply(double.valueOf(6076.115), MathContext.DECIMAL32);
                                break;
                            case 9://A pulgada
                                conversion = Dato * 72913.386;//.multiply(double.valueOf(72913.386), MathContext.DECIMAL32);
                                break;
                        }
                        break;
                }
            }
            //Regresa transformado a texto el valor obtenido de la conversion
            return conversion.ToString();
        }
    }
}