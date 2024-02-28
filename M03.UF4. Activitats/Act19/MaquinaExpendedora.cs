using System;
/*Ens han demanat implementar un màquina expenedora de tiquets. Els tiquets tenen un preu. La màquina té un calaix que recull els imports dels tiquets.
El client va introduint diners i si prem el botó Treure tiquet se li expendrà el tiquet sempre que hagi introduït una quantitat igual o major que l'import. Aquest mètode ha d'imprimir el tiquet i retornar en un String la quantitat de bitllets i monedes mínimes per a aquesta devolució:
Per exemple, si el tiquet val 1,20  euros i l'usuari introdueix 5 euros, li ha de retornar 1 moneda de 2 euros, 1 moneda de 1 euros, 1 de 0,50 euros, 1 de 0,20 euros i 1 de 0,10 euros. A més ingressarà en el calaix l'import del tiquet.
Si no hi ha suficients diners en el calaix, el programa ha de dir Introdueixi l'import exacte.

Implementa la classe MaquinaExpendora en C#, així com la controladora que permeti instaciar els objectes i els unit testing per validar els mètodes de la classe.. Pensa en els constructors, setters i getters necessaris.
*/

namespace OOPEx
{
    public class MaquinaExpendedora
    {
        private double preuTiquet;
        private double calaix;

        public MaquinaExpendedora(double preuTiquet, double calaix)
        {
            SetPreuTiquet(preuTiquet);
            SetCalaix(calaix);
        }

        public double GetPreuTiquet()
        {
            return preuTiquet;
        }

        public void SetPreuTiquet(double preuTiquet)
        {
            this.preuTiquet = preuTiquet;
        }

        public double GetCalaix()
        {
            return calaix;
        }

        public void SetCalaix(double calaix)
        {
            this.calaix = calaix;
        }

        public string TreureTiquet()
        {
            if (this.GetCalaix() < preuTiquet)
            {
                return "Introdueixi l'import exacte";
            }
            else
            {
                double canvi = this.GetCalaix() - preuTiquet;
                double[] monedes = {2, 1, 0.5, 0.2, 0.1};
                int[] quantitat = {0, 0, 0, 0, 0};
                for (int i = 0; i < monedes.Length; i++)
                {
                    while (canvi >= monedes[i])
                    {
                        canvi -= monedes[i];
                        quantitat[i]++;
                    }
                }

                calaix += preuTiquet;
                return $"Canvi:\n  {quantitat[0]} monedes de 2 euros.\n  {quantitat[1]} monedes de 1 euros.\n  {quantitat[2]} monedes de 0,50 euros.\n  {quantitat[3]} monedes de 0,20 euros.\n  {quantitat[4]} monedes de 0,10 euros.";
            }
        }

    }
}
