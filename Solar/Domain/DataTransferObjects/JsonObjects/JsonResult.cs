using System.Collections.ObjectModel;

namespace Solar.Domain.DataTransferObjects.JsonObjects
{
    public class JsonResult<T>
    {
        public Collection<T> Bodies { get; set; }
    }
}
