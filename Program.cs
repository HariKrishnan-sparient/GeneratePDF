using GeneratePDF;
using GeneratePDF.Models;
using System.Text.Json;


var projectRoot = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
var requestJson = File.ReadAllText(Path.Combine(projectRoot, "RequestData", "PropertyRequest.json"));
var requestData = JsonSerializer.Deserialize<PropertyReportDto>(requestJson);
var pdfFolderPath = Path.Combine(projectRoot, "PDF");
string templatePathScriban = Path.Combine(projectRoot, "Template", "PropertyReport_Tem.html");
var pdfFilePath = Path.Combine(pdfFolderPath, $"PropertyReport_{DateTime.Now:yyyyMMddHHmmssfff}.pdf");

string renderedHtml = ScribanHelper.RenderTemplate(requestData, templatePathScriban);

var renderer = new IronPdf.ChromePdfRenderer();

var pdf = renderer.RenderHtmlAsPdf(renderedHtml);
pdf.SaveAs(pdfFilePath);

Console.WriteLine("PDF generated successfully."); 