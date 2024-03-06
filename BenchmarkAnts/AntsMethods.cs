using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchmarkAnts
{
    public class AntsMethods
    {
         int antsCounter = 0;
        public int CountAntsBefore(string carnage)
        {
            int intactAnt = carnage.Split(new string[] { "ant" }, StringSplitOptions.None).Length - 1;
            int heads = carnage.Split(new char[] { 'a' }).Length - 1;
            int bodies = carnage.Split(new char[] { 'b' }).Length - 1;
            int otherParts = carnage.Length - intactAnt * 3 - heads - bodies;

            int deadAntsFromHeads = Math.Max(heads - intactAnt, 0);

            int deadAntsFromBodyParts = Math.Min(Math.Max(otherParts - deadAntsFromHeads, 0), bodies);

            return deadAntsFromHeads + deadAntsFromBodyParts;


        }

        public  int CountAntsAfter(string Ants)
        {
            bool head = false;
            bool body = false;
            bool tail = false;


            for (int i = 0; i < Ants.Length; i++)
            {
                // Confirm if the string is valid
                if (Ants[i] != 'a' && Ants[i] != 'n' && Ants[i] != 't' && Ants[i] != '.') return 0;
                // Skip all the dots
                if (Ants[i] == '.') continue;

                // If we find a living ant, we skip it
                if (Ants.Length > i + 2 && Ants[i] == 'a' && Ants[i + 1] == 'n' && Ants[i + 2] == 't')
                {
                    i += 2;
                    continue;
                }

                //Verify Every Part of the Ants
                switch (Ants[i])
                {
                    case 'a':
                        head = VerifyPart(head);
                        break;
                    case 'n':
                        body = VerifyPart(body);
                        break;
                    case 't':
                        tail = VerifyPart(tail);
                        break;

                }

                //In case that is a whole body of ants, add 1 to the counter
                if (head && body && tail)
                {
                    antsCounter++;

                    head = false;
                    body = false;
                    tail = false;
                }


            }

            //In case that a part of the ant is found, add 1 to the counter
            if (head || body || tail)
            {
                antsCounter++;
            }

            return antsCounter;
        }

        private  bool VerifyPart(bool part)
        {
            if (part)
            {
                antsCounter++;
            }
            else
            {
                part = true;
            }

            return part;
        }
    }
}
