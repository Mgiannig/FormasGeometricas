using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{

    public class Word
    {
        public static string GetWord(string WordKey, string CurrentLanguage)
        {
            try
            {
                Idioma word = new Idioma();

                if (word != null)
                {
                    string idioma;
                    switch (CurrentLanguage.ToUpper())
                    {

                        case "EN":
                            idioma = word.Ingles;
                            break;
                        case "SP":
                            idioma = word.Español;
                            break;
                        case "AL":
                            idioma = word.Aleman;
                            break;
                        case "FR":
                            idioma = word.Frances;
                            break;

                        default:
                            return WordKey;
                    }
                    return idioma;
                }
                else
                {
                    //word = new DTO.Word();
                    //word.Key = WordKey;
                    //word.SP = WordKey;
                    //word.WordId = Guid.NewGuid();
                    //word.EN = WordKey;
                    //Business.Generic.Save<DTO.Word>(word);
                    return WordKey;
                }
            }
            catch (Exception)
            {
                return WordKey;
            }
        }
    }

}
