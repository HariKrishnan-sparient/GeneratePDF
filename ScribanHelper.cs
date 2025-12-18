using Scriban;

namespace GeneratePDF
{
    public static class ScribanHelper
    {
        public static string RenderTemplate(object model, string templatePath)
        {
            var templateText = File.ReadAllText(templatePath);
            var template = Template.Parse(templateText);
            return template.Render(model, member => member.Name);
        }
    }
}
