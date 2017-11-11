using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoteleria
{
    class Conversion
    {
        double kilogAgramo, kilogAhectog, kilogAdecag, kilogAdecig, kilogAcentig, kiloAmilig, kilogAlibra, kilogAonza, kilogAton;
        double gramoAkilog, gramoAhectog, gramoAdecag, gramoAdecig, gramoAcentig, gramoAmilig, gramoAlibra, gramoAonza, gramoAton;
        double hectogAgramo, hectogAkilog, hectogAdecag, hectogAdecig, hectogAcentig, hectogAmilig, hectogAlibra, hectogAonza, hectogAton;
        double decagAgramo, decagAkilog, decagAhectog, decagAdecig, decagAcentig, decagAmilig, decagAlibra, decagAonza, decagAton;
        double decigAgramo, decigAkilog, decigAhectog, decigAdecag, decigAcentig, decigAmilig, decigAlibra, decigAonza, decigAton;
        double miligAgramo, miligAkilog, miligAhectog, miligAdecag, miligAcentig, miligAdecig, miligAlibra, miligAonza, miligAton;
        double centigAgramo, centigAkilog, centigAhectog, centigAdecag, centigAmilig, centigAdecig, centigAlibra, centigAonza, centigAton;
        double libraAgramo, libraAkilog, libraAhectog, libraAdecag, libraAmilig, libraAdecig, libraAcentig, libraAonza, libraAton;
        double onzaAgramo, onzaAkilog, onzaAhectog, onzaAdecag, onzaAmilig, onzaAdecig, onzaAcentig, onzaAlibra, onzaAton;
        double tonAgramo, tonAkilog, tonAhectog, tonAdecag, tonAmilig, tonAdecig, tonAcentig, tonAlibra, tonAonza;
        double mililAlitro, mililAhectol, mililAdecal, mililAkilol, mililAdecil, mililAcentil, mililAgalon;
        double hectolAlitro, hectolAmilil, hectolAdecal, hectolAkilol, hectolAdecil, hectolAcentil, hectolAgalon;
        double decalAlitro, decalAmilil, decalAhectol, decalAkilol, decalAdecil, decalAcentil, decalAgalon;
        double kilolAlitro, kilolAmilil, kilolAhectol, kilolAdecal, kilolAdecil, kilolAcentil, kilolAgalon;
        double litroAkilol, litroAmilil, litroAhectol, litroAdecal, litroAdecil, litroAcentil, litroAgalon;
        double centilAkilol, centilAmilil, centilAhectol, centilAdecal, centilAdecil, centilAlitro, centilAgalon;
        double galonAkilol, galonAmilil, galonAhectol, galonAdecal, galonAdecil, galonAlitro, galonAcentil;

        //Intenté poner el return en cada case, pero me da error en el metodo.
        //Ya no me da error en el metodo cuando pongo el return donde está ahorita, pero no manda lo que
        //debe mandar :(

        public double convertir(double cantidadBodega, string tipomedidaBodega, double cantidadDetalle, string tipomedidaDetalle)
        {
            double respuesta=0;
            switch (tipomedidaDetalle)
            {
                case "Kilogramo":
                    if (tipomedidaBodega == "Gramo") { kilogAgramo = cantidadDetalle * 1000; respuesta = kilogAgramo; }
                    else if (tipomedidaBodega == "Hectogramo") { kilogAhectog = cantidadDetalle * 10; respuesta = kilogAhectog; }
                    else if (tipomedidaBodega == "Hectogramo") { kilogAhectog = cantidadDetalle * 10; respuesta = kilogAhectog; }
                    else if (tipomedidaBodega == "Decagramo") { kilogAdecag = cantidadDetalle * 100; respuesta = kilogAdecag; }
                    else if (tipomedidaBodega == "Decigramo") { kilogAdecig = cantidadDetalle * 10000; respuesta = kilogAdecig; }
                    else if (tipomedidaBodega == "Centigramo") { kilogAcentig = cantidadDetalle * 100000; respuesta = kilogAcentig; }
                    else if (tipomedidaBodega == "Miligramo") { kiloAmilig = cantidadDetalle * 1000000; respuesta = kiloAmilig; }
                    else if (tipomedidaBodega == "Onza") { kilogAonza = cantidadDetalle * 35.274; respuesta = kilogAonza; }
                    else if (tipomedidaBodega == "Libra") { kilogAlibra = cantidadDetalle * 2.20462; respuesta = kilogAlibra; }
                    else respuesta = cantidadDetalle;
                    break;

                case "Gramo":
                        if (tipomedidaBodega == "Kilogramo") { gramoAkilog = cantidadDetalle * 0.001; respuesta = gramoAkilog; }
                        else if (tipomedidaBodega == "Hectogramo") { gramoAhectog = cantidadDetalle * 0.01; respuesta = gramoAhectog; }
                        else if (tipomedidaBodega == "Decagramo") { gramoAdecag = cantidadDetalle * 0.1; respuesta = gramoAdecag; }
                        else if (tipomedidaBodega == "Decigramo") { gramoAdecig = cantidadDetalle * 10; respuesta = gramoAdecig; }
                        else if (tipomedidaBodega == "Centigramo") { gramoAcentig = cantidadDetalle * 100; respuesta = gramoAcentig; } 
                        else if (tipomedidaBodega == "Miligramo") { gramoAmilig = cantidadDetalle * 1000; respuesta = gramoAmilig; }
                        else if (tipomedidaBodega == "Onza") { gramoAonza = cantidadDetalle * 0.035274; respuesta = gramoAonza; }
                        else if (tipomedidaBodega == "Libra") { gramoAlibra = cantidadDetalle * 0.00220462; respuesta = gramoAlibra; }
                        else if (tipomedidaBodega == "Tonelada") { gramoAton = cantidadDetalle * 0.000001; respuesta = gramoAton; }
                        else respuesta = cantidadDetalle;
                        break;

                    case "Hectogramo":
                        if (tipomedidaBodega == "Kilogramo") { hectogAkilog = cantidadDetalle * 0.1; respuesta = hectogAkilog; }
                        else if (tipomedidaBodega == "Gramo") { hectogAgramo = cantidadDetalle * 100; respuesta = hectogAgramo; }
                        else if (tipomedidaBodega == "Decagramo") { hectogAdecag = cantidadDetalle * 10; respuesta = hectogAdecag; }
                        else if (tipomedidaBodega == "Decigramo") { hectogAdecig = cantidadDetalle * 1000; respuesta = hectogAdecig; }
                        else if (tipomedidaBodega == "Centigramo") { hectogAcentig = cantidadDetalle * 0.0001; respuesta = hectogAcentig; }
                        else if (tipomedidaBodega == "Miligramo") { hectogAmilig = cantidadDetalle * 100000; respuesta = hectogAmilig; }
                        else if (tipomedidaBodega == "Onza") { hectogAonza = cantidadDetalle * 3.5274; respuesta = hectogAonza; }
                        else if (tipomedidaBodega == "Libra") { hectogAlibra = cantidadDetalle * 0.220462; respuesta = hectogAlibra; }
                        else if (tipomedidaBodega == "Tonelada") { hectogAton = cantidadDetalle * 0.0001; respuesta = hectogAton; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Decagramo":
                        if (tipomedidaBodega == "Kilogramo") { decagAkilog = cantidadDetalle * 0.01; respuesta = decagAkilog; }
                        else if (tipomedidaBodega == "Gramo") { decagAgramo = cantidadDetalle * 10; respuesta = decagAgramo; }
                        else if (tipomedidaBodega == "Hectogramo") { decagAhectog = cantidadDetalle * 0.1; respuesta = decagAhectog; }
                        else if (tipomedidaBodega == "Decigramo") { decagAdecig = cantidadDetalle * 100; respuesta = decagAdecig; }
                        else if (tipomedidaBodega == "Centigramo") { decagAcentig = cantidadDetalle * 0.001; respuesta = decagAcentig; }
                        else if (tipomedidaBodega == "Miligramo") { decagAmilig = cantidadDetalle * 10000; respuesta = decagAmilig; }
                        else if (tipomedidaBodega == "Onza") { decagAonza = cantidadDetalle * 0.35274; respuesta = decagAonza; }
                        else if (tipomedidaBodega == "Libra") { decagAlibra = cantidadDetalle * 0.0220462; respuesta = decagAlibra; }
                        else if (tipomedidaBodega == "Tonelada") { decagAton = cantidadDetalle * 0.00001; respuesta = decagAton; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Decigramo":
                        if (tipomedidaBodega == "Kilogramo") { decigAkilog = cantidadDetalle * 0.00001; respuesta = decigAkilog; }
                        else if (tipomedidaBodega == "Gramo") { decigAgramo = cantidadDetalle * 0.1; respuesta = decigAgramo; }
                        else if (tipomedidaBodega == "Hectogramo") { decigAhectog = cantidadDetalle * 0.001; respuesta = decigAhectog; }
                        else if (tipomedidaBodega == "Decagramo") { decigAdecag = cantidadDetalle * 0.01; respuesta = decigAdecag; }
                        else if (tipomedidaBodega == "Centigramo") { decigAcentig = cantidadDetalle * 10; respuesta = decigAcentig; }
                        else if (tipomedidaBodega == "Miligramo") { decigAmilig = cantidadDetalle * 100; respuesta = decigAmilig; }
                        else if (tipomedidaBodega == "Onza") { decigAonza = cantidadDetalle * 0.0035274; respuesta = decigAonza; }
                        else if (tipomedidaBodega == "Libra") { decigAlibra = cantidadDetalle * 0.000220462; respuesta = decigAlibra; }
                        else if (tipomedidaBodega == "Tonelada") { decigAton = cantidadDetalle * 0.0000001; respuesta = decigAton; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Miligramo":
                        if (tipomedidaBodega == "Kilogramo") { miligAkilog = cantidadDetalle * 0.000001; respuesta = miligAkilog; }
                        else if (tipomedidaBodega == "Gramo") { miligAgramo = cantidadDetalle * 0.001; respuesta = miligAgramo; }
                        else if (tipomedidaBodega == "Hectogramo") { miligAhectog = cantidadDetalle * 0.00001; respuesta = miligAhectog; }
                        else if (tipomedidaBodega == "Decagramo") { miligAdecag = cantidadDetalle * 0.0001; respuesta = miligAdecag; }
                        else if (tipomedidaBodega == "Centigramo") { miligAcentig = cantidadDetalle * 0.1; respuesta = miligAcentig; }
                        else if (tipomedidaBodega == "Decigramo") {  miligAdecig = cantidadDetalle * 0.01; respuesta = miligAdecig; }
                        else if (tipomedidaBodega == "Onza") { miligAonza = cantidadDetalle * 0.000035274; respuesta = miligAonza; }
                        else if (tipomedidaBodega == "Libra") { miligAlibra = cantidadDetalle * 0.00000220462; respuesta = miligAlibra; }
                        else if (tipomedidaBodega == "Tonelada") { miligAton = cantidadDetalle * 0.000000001; respuesta = miligAton; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Centigramo":
                        if (tipomedidaBodega == "Kilogramo") { centigAkilog = cantidadDetalle * 0.00001; respuesta = centigAkilog; }
                        else if (tipomedidaBodega == "Gramo") { centigAgramo = cantidadDetalle * 0.01; respuesta = centigAgramo; }
                        else if (tipomedidaBodega == "Hectogramo") { centigAhectog = cantidadDetalle * 10000; respuesta = centigAhectog; }
                        else if (tipomedidaBodega == "Decagramo") { centigAdecag = cantidadDetalle * 1000; respuesta = centigAdecag; }
                        else if (tipomedidaBodega == "Miligramo") { centigAmilig = cantidadDetalle * 10; respuesta = centigAmilig; }
                        else if (tipomedidaBodega == "Decigramo") { centigAdecig = cantidadDetalle * 0.1; respuesta = centigAdecig; }
                        else if (tipomedidaBodega == "Onza") { centigAonza = cantidadDetalle * 0.00035274; respuesta = centigAonza; }
                        else if (tipomedidaBodega == "Libra") { centigAlibra = cantidadDetalle * 0.0000220462; respuesta = centigAlibra; }
                        else if (tipomedidaBodega == "Tonelada") { centigAton = cantidadDetalle * 0.00000001; respuesta = centigAton; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Libra":
                        if (tipomedidaBodega == "Kilogramo") { libraAkilog = cantidadDetalle * 0.453592; respuesta = centigAkilog; }
                        else if (tipomedidaBodega == "Gramo") { libraAgramo = cantidadDetalle * 453.592; respuesta = centigAgramo; }
                        else if (tipomedidaBodega == "Hectogramo") { libraAhectog = cantidadDetalle * 4.53592; respuesta = centigAhectog; }
                        else if (tipomedidaBodega == "Decagramo") { libraAdecag = cantidadDetalle * 45.3592; respuesta = centigAdecag; }
                        else if (tipomedidaBodega == "Miligramo") { libraAmilig = cantidadDetalle * 453592; respuesta = centigAmilig; }
                        else if (tipomedidaBodega == "Decigramo") { libraAdecig = cantidadDetalle * 4535.92; respuesta = centigAdecig; }
                        else if (tipomedidaBodega == "Onza") { libraAonza = cantidadDetalle * 16; respuesta = centigAonza; }
                        else if (tipomedidaBodega == "Centigramo") { libraAcentig = cantidadDetalle * 45359.2; respuesta = centigAlibra; }
                        else if (tipomedidaBodega == "Tonelada") { libraAton = cantidadDetalle * 0.000453592; respuesta = centigAton; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Onza":
                        if (tipomedidaBodega == "Kilogramo") { onzaAkilog = cantidadDetalle * 0.0283495; respuesta = onzaAkilog; }
                        else if (tipomedidaBodega == "Gramo") { onzaAgramo = cantidadDetalle * 28.3495; respuesta = onzaAgramo; }
                        else if (tipomedidaBodega == "Hectogramo") { onzaAhectog = cantidadDetalle * 0.283495; respuesta = onzaAhectog; }
                        else if (tipomedidaBodega == "Decagramo") { onzaAdecag = cantidadDetalle * 2.83495; respuesta = onzaAdecag; }
                        else if (tipomedidaBodega == "Miligramo") { onzaAmilig = cantidadDetalle * 28349.5; respuesta = onzaAmilig; }
                        else if (tipomedidaBodega == "Decigramo") { onzaAdecig = cantidadDetalle * 283.495; respuesta = onzaAdecig; }
                        else if (tipomedidaBodega == "Libra") { onzaAlibra = cantidadDetalle * 0.0625; respuesta = onzaAlibra; }
                        else if (tipomedidaBodega == "Centigramo") { onzaAcentig = cantidadDetalle * 2834.95; respuesta = onzaAcentig; }
                        else if (tipomedidaBodega == "Tonelada") { onzaAton = cantidadDetalle * 0.0000283495; respuesta = onzaAton; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Tonelada":
                        if (tipomedidaBodega == "Kilogramo") { tonAkilog = cantidadDetalle * 1000; respuesta = tonAkilog; }
                        else if (tipomedidaBodega == "Gramo") { tonAgramo = cantidadDetalle * 1000000; respuesta = tonAgramo; }
                        else if (tipomedidaBodega == "Hectogramo") { tonAhectog = cantidadDetalle * 10000; respuesta = tonAhectog; }
                        else if (tipomedidaBodega == "Decagramo") { tonAdecag = cantidadDetalle * 100000; respuesta = tonAdecag; }
                        else if (tipomedidaBodega == "Miligramo") { tonAmilig = cantidadDetalle * 1000000000; respuesta = tonAmilig; }
                        else if (tipomedidaBodega == "Decigramo") { tonAdecig = cantidadDetalle * 10000000; respuesta = tonAdecig; }
                        else if (tipomedidaBodega == "Libra") { tonAlibra = cantidadDetalle * 2204.62; respuesta = tonAlibra; }
                        else if (tipomedidaBodega == "Centigramo") { tonAcentig = cantidadDetalle * 100000000; respuesta = tonAcentig; }
                        else if (tipomedidaBodega == "Onza") { tonAonza = cantidadDetalle * 35274; respuesta = onzaAton; }
                        else respuesta = cantidadDetalle;
                        break;
                    //LIQUIDOS
                    case "Mililitro":
                        if (tipomedidaBodega == "Litro") { mililAlitro = cantidadDetalle * 0.001; respuesta = mililAlitro; }
                        else if (tipomedidaBodega == "Hectolitro") { mililAhectol = cantidadDetalle * 0.00001; respuesta = mililAhectol; }
                        else if (tipomedidaBodega == "Decalitro") { mililAdecal = cantidadDetalle * 0.0001; respuesta = mililAdecal; }
                        else if (tipomedidaBodega == "Kilolitro") { mililAkilol = cantidadDetalle * 0.000001; respuesta = mililAkilol; }
                        else if (tipomedidaBodega == "Decilitro") { mililAdecil = cantidadDetalle * 0.01; respuesta = mililAdecil; }
                        else if (tipomedidaBodega == "Centilitro") { mililAcentil = cantidadDetalle * 0.1; respuesta = mililAcentil; }
                        else if (tipomedidaBodega == "Galon") { mililAgalon = cantidadDetalle * 0.000264172; respuesta = mililAgalon; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Hectolitro":
                        if (tipomedidaBodega == "Litro") { hectolAlitro = cantidadDetalle * 100; respuesta = hectolAlitro; }
                        else if (tipomedidaBodega == "Mililitro") { hectolAmilil = cantidadDetalle * 100000; respuesta = hectolAmilil; }
                        else if (tipomedidaBodega == "Decalitro") { hectolAdecal = cantidadDetalle * 10; respuesta = hectolAdecal; }
                        else if (tipomedidaBodega == "Kilolitro") { hectolAkilol = cantidadDetalle * 0.1; respuesta = hectolAkilol; }
                        else if (tipomedidaBodega == "Decilitro") { hectolAdecil = cantidadDetalle * 1000; respuesta = hectolAdecil; }
                        else if (tipomedidaBodega == "Centilitro") { hectolAcentil = cantidadDetalle * 10000; respuesta = hectolAcentil; }
                        else if (tipomedidaBodega == "Galon") { hectolAgalon = cantidadDetalle * 26.4172; respuesta = hectolAgalon; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Decalitro":
                        if (tipomedidaBodega == "Litro") { decalAlitro = cantidadDetalle * 10; respuesta = decalAlitro; }
                        else if (tipomedidaBodega == "Mililitro") { decalAmilil = cantidadDetalle * 10000; respuesta = decalAmilil; }
                        else if (tipomedidaBodega == "Hectolitro") { decalAhectol = cantidadDetalle * 0.1; respuesta = decalAhectol; }
                        else if (tipomedidaBodega == "Kilolitro") { decalAkilol = cantidadDetalle * 0.01; respuesta = decalAkilol; }
                        else if (tipomedidaBodega == "Decilitro") { decalAdecil = cantidadDetalle * 100; respuesta = decalAdecil; }
                        else if (tipomedidaBodega == "Centilitro") { decalAcentil = cantidadDetalle * 1000; respuesta = decalAcentil; }
                        else if (tipomedidaBodega == "Galon") { decalAgalon = cantidadDetalle * 2.64172; respuesta = decalAgalon; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Kilolitro":
                        if (tipomedidaBodega == "Litro") { kilolAlitro = cantidadDetalle * 1000; respuesta = kilolAlitro; }
                        else if (tipomedidaBodega == "Mililitro") { kilolAmilil = cantidadDetalle * 1000000; respuesta = kilolAmilil; }
                        else if (tipomedidaBodega == "Hectolitro") { kilolAhectol = cantidadDetalle * 10; respuesta = kilolAhectol; }
                        else if (tipomedidaBodega == "Decalitro") { kilolAdecal = cantidadDetalle * 100; respuesta = kilolAdecal; }
                        else if (tipomedidaBodega == "Decilitro") { kilolAdecil = cantidadDetalle * 10000; respuesta = kilolAdecil; }
                        else if (tipomedidaBodega == "Centilitro") { kilolAcentil = cantidadDetalle * 100000; respuesta = kilolAcentil; }
                        else if (tipomedidaBodega == "Galon") { kilolAgalon = cantidadDetalle * 264.172; respuesta = kilolAgalon; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Litro":
                        if (tipomedidaBodega == "Kilolitro") { litroAkilol = cantidadDetalle * 0.001; respuesta = litroAkilol; }
                        else if (tipomedidaBodega == "Mililitro") { litroAmilil = cantidadDetalle * 1000; respuesta = litroAmilil; }
                        else if (tipomedidaBodega == "Hectolitro") { litroAhectol = cantidadDetalle * 0.01; respuesta = litroAhectol; }
                        else if (tipomedidaBodega == "Decalitro") { litroAdecal = cantidadDetalle * 0.1; respuesta = litroAdecal; }
                        else if (tipomedidaBodega == "Decilitro") { litroAdecil = cantidadDetalle * 10; respuesta = litroAdecil; }
                        else if (tipomedidaBodega == "Centilitro") { litroAcentil = cantidadDetalle * 100; respuesta = litroAcentil; }
                        else if (tipomedidaBodega == "Galon") { litroAgalon = cantidadDetalle * 0.264172; respuesta = litroAgalon; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Centilitro":
                        if (tipomedidaBodega == "Kilolitro") { centilAkilol = cantidadDetalle * 0.00001; respuesta = centilAkilol; }
                        else if (tipomedidaBodega == "Mililitro") { centilAmilil = cantidadDetalle * 10; respuesta = centilAmilil; }
                        else if (tipomedidaBodega == "Hectolitro") { centilAhectol = cantidadDetalle * 0.0001; respuesta = centilAhectol; }
                        else if (tipomedidaBodega == "Decalitro") { centilAdecal = cantidadDetalle * 0.001; respuesta = centilAdecal; }
                        else if (tipomedidaBodega == "Decilitro") { centilAdecil = cantidadDetalle * 0.1; respuesta = centilAdecil; }
                        else if (tipomedidaBodega == "Litro") { centilAlitro = cantidadDetalle * 0.01; respuesta = centilAlitro; }
                        else if (tipomedidaBodega == "Galon") { centilAgalon = cantidadDetalle * 0.00264172; respuesta = centilAgalon; }
                        else respuesta = cantidadDetalle;
                        break;
                    case "Galones":
                        if (tipomedidaBodega == "Kilolitro") { galonAkilol = cantidadDetalle * 0.00378541; respuesta = galonAkilol; }
                        else if (tipomedidaBodega == "Mililitro") { galonAmilil = cantidadDetalle * 3785.41; respuesta = galonAmilil; }
                        else if (tipomedidaBodega == "Hectolitro") { galonAhectol = cantidadDetalle * 0.0378541; respuesta = galonAhectol; }
                        else if (tipomedidaBodega == "Decalitro") { galonAdecal = cantidadDetalle * 0.378541; respuesta = galonAdecal; }
                        else if (tipomedidaBodega == "Decilitro") { galonAdecil = cantidadDetalle * 37.8541; respuesta = galonAdecil; }
                        else if (tipomedidaBodega == "Litro") { galonAlitro = cantidadDetalle * 3.78541; respuesta = galonAlitro; }
                        else if (tipomedidaBodega == "Centilitro") { galonAcentil = cantidadDetalle * 378.541; respuesta = galonAcentil; }
                        else respuesta = cantidadDetalle;
                        break;
            }
            return respuesta; //respuesta es una variable de prueba, está en la parte de Kilogramos
        }
    }
}
