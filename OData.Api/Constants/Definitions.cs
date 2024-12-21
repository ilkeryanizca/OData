namespace OData.Api.Constants
{
    public static class Definitions
    {
        public static readonly (int MinDegree, int MaxDegree, string Summary)[] TemperatureRanges =
        [
            (-20, -15, "Extremely Freezing"),
            (-14, -10, "Freezing"),
            (-9, -5, "Very Cold"),
            (-4, 0, "Cold"),
            (1, 5, "Chilly"),
            (6, 10, "Cool"),
            (11, 15, "Mild"),
            (16, 20, "Warm"),
            (21, 25, "Balmy"),
            (26, 30, "Hot"),
            (31, 35, "Very Hot"),
            (36, 40, "Sweltering"),
            (41, 45, "Scorching"),
            (46, 50, "Extremely Hot"),
            (51, 55, "Blazing")
        ];
    }
}
