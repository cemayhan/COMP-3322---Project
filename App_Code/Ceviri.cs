using System;
using System.Linq;
using System.Web;
using System.IO;
using System.Net;

/// <summary>
/// This program is for translating words into English or vice versa.
/// </summary>
public class Ceviri
{
    public string Translate(string sourceText, string sourceLanguage, string targetLanguage)

    {
        
        string translation = string.Empty;

        try
        {
            // Download translation
            string url = string.Format("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
                                        sourceLanguage,
                                        targetLanguage,
                                        HttpUtility.UrlEncode(sourceText));
            string outputFile = Path.GetTempFileName();
            using (WebClient wc = new WebClient())
            {
                wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                wc.DownloadFile(url, outputFile);
            }

            // Get translated text
            if (File.Exists(outputFile))
            {

                // Get phrase collection
                string text = File.ReadAllText(outputFile);
                int index = text.IndexOf(string.Format(",,\"{0}\"", sourceLanguage));
                if (index == -1)
                {
                    // Translation of single word
                    int startQuote = text.IndexOf('\"');
                    if (startQuote != -1)
                    {
                        int endQuote = text.IndexOf('\"', startQuote + 1);
                        if (endQuote != -1)
                        {
                            translation = text.Substring(startQuote + 1, endQuote - startQuote - 1);
                        }
                    }
                }
                else
                {
                    // Translation of phrase
                    text = text.Substring(0, index);
                    text = text.Replace("],[", ",");
                    text = text.Replace("]", string.Empty);
                    text = text.Replace("[", string.Empty);
                    text = text.Replace("\",\"", "\"");

                    // Get translated phrases
                    string[] phrases = text.Split(new[] { '\"' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; (i < phrases.Count()); i += 2)
                    {
                        string translatedPhrase = phrases[i];
                        if (translatedPhrase.StartsWith(",,"))
                        {
                            i--;
                            continue;
                        }
                        translation += translatedPhrase + "  ";
                    }
                }

                // Fix up translation
                translation = translation.Trim();
                translation = translation.Replace(" ?", "?");
                translation = translation.Replace(" !", "!");
                translation = translation.Replace(" ,", ",");
                translation = translation.Replace(" .", ".");
                translation = translation.Replace(" ;", ";");

                // And translation speech URL
                string url2 = string.Format("https://translate.googleapis.com/translate_tts?ie=UTF-8&q={0}&tl={1}&total=1&idx=0&textlen={2}&client=gtx", HttpUtility.UrlEncode(translation), targetLanguage, translation.Length);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        
        return translation;
    }
}


