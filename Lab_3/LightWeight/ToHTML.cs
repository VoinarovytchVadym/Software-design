
using Composer;
using Composer.Nodes;

namespace LightWeight;

 public class ToHTML
    {
        public  static string GetTextFromFile(string path)
        {

            if (!File.Exists(path))
            {
                Console.WriteLine($"Файл '{path}' не знайдено.");
                return string.Empty;
            }
            try
            {
                return File.ReadAllText(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка зчитування файлу: {ex.Message}");
                return string.Empty;
            }

        }
        
        public static Composer.Nodes.LightElementNode WithoutLightWeight(string text)
        {

            string[] rows = string.IsNullOrWhiteSpace(text) ? [] : text.Split('\n');

            var div = new Composer.Nodes.LightElementNode("div", "block", "normal",
                [],
                []);

            div.Childes.Add(new Composer.Nodes.LightElementNode("h1", "block", "normal",
                [],
                [new LightTextNode($"{rows[0].Trim()} \n")]));

            for (int i = 1; i < rows.Length; i++)
            {
                string row = rows[i].TrimEnd();
                LightNode node;

                if (string.IsNullOrWhiteSpace(row))
                {
                    node = new Composer.Nodes.LightElementNode("p", "block", "normal", 
                        [], 
                        [new LightTextNode("<br>\n")]);
                }
                else if (char.IsWhiteSpace(row[0]))
                {
                    node = new Composer.Nodes.LightElementNode("blockquote", "block", "normal",
                        [],
                        [new LightTextNode($" {row}\n")]);
                }
                else if (row.Length < 20)
                {
                    node = new Composer.Nodes.LightElementNode("h2", "block", "normal",
                        [],
                        [new LightTextNode($" {row}\n")]);
                }
                else
                {
                    node = new Composer.Nodes.LightElementNode("p", "block", "normal",
                        [],
                        [new LightTextNode($"{row}\n")]);
                }

                div.Childes.Add(node);
            }

            return div;
        }
        
        public static LightElementNode ConvertToHTML(string text)
        {
            string[] lines = string.IsNullOrWhiteSpace(text) ? [] : text.Split('\n');
            var rootNode = LightElementNode.GetElementNode("div", "block", "normal",
                [],
                []);

            rootNode.Childes.Add(LightElementNode.GetElementNode("h1", "block", "normal",
                [],
                [new LightTextNode($"{lines[0].Trim()} \n")]));

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i].TrimEnd();
                LightNode node;

                if (string.IsNullOrWhiteSpace(line))
                {
                    node = LightElementNode.GetElementNode("p", "block", "normal",
                        [],
                        [new LightTextNode("<br>  \n")]);
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    node = LightElementNode.GetElementNode("blockquote", "block", "normal",
                        [],
                        [new LightTextNode($" {line} \n")]);
                }
                else if (line.Length < 20)
                {
                    node = LightElementNode.GetElementNode("h2", "block", "normal",
                        [],
                        [new LightTextNode($" {line} \n")]);
                }
                else
                {
                    node = LightElementNode.GetElementNode("p", "block", "normal",
                        [],
                        [new LightTextNode($"{line} \n")]);
                }

                rootNode.Childes.Add(node);
            }

            return rootNode;
        }
    }