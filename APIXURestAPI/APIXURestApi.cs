using System.Collections.Generic;
using System.Threading.Tasks;

using Newtonsoft.Json;
using RestSharp;

namespace APIXURestClient
{
    public class APIXURestApi(string city)
    {
        private string Resource { get; set; }
        private string Key { get; set; }

        //Open your template file.
        Workbook wb = new Workbook("e:\\test2\\Book1.xlsx");
        //Get the first worksheet.
        Worksheet worksheet = wb.Worksheets[0];
        //Get the cells collection.
        Cells cells = worksheet.Cells;

        //Define the list.
        List<string> myList = new List<string>();
        //Get the AA column index. (Since "Status" is always @ AA column.
        int col = CellsHelper.ColumnNameToIndex("AA");

        //Get the last row index in AA column.
        int last_row = worksheet.Cells.GetLastDataRow(col);

        //Loop through the first column while start collecting values from row 2
        //to save each value to List
        for (int i = 2; i <= last_row; i++)
        {
            myList.Add(cells[i, col].Value.ToString());
        } 

        public APIXURestApi(string ApiKey, string Res)
        {
            Resource = Res;
            Key = ApiKey;
        }

        public APIXURestApi(string ApiKey)
        {
            Resource = "https://api.open-meteo.com/;
            Key = ApiKey;
        }

foreach(var item in myList)
{
    if (city == item)
    {
        public async Task<APIXUCurrentWeather> GetCurrentWeatherAsync(double lat, double lon)
        {
            var restClient = new RestClient(Resource);
            var request = new RestRequest
            {
                Resource = "v1/current.json?key=" + Key + "&q=" + lat + "&r=" + lon,
                Method = Method.GET
            };

            var restResponse = await restClient.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<APIXUCurrentWeather>(restResponse.Content);
        }
    }
}      
    }
}