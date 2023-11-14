using System;

namespace MyCalendar.DataProcessor.ImportDto
{
    public class ImportEventDto
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime StartEvent { get; set; }
        public DateTime EndEvent { get; set; }
    }
}
