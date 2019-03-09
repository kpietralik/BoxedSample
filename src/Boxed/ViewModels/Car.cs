namespace Boxed.ViewModels
{
    using Boxed.ViewModelSchemaFilters;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>
    /// A make and model of car.
    /// </summary>
    [SwaggerSchemaFilter(typeof(CarSchemaFilter))]
    public class Car
    {
        /// <summary>
        /// The cars unique identifier.
        /// </summary>
        public int CarId { get; set; }

        /// <summary>
        /// The number of cylinders in the cars engine.
        /// </summary>
        public int Cylinders { get; set; }

        /// <summary>
        /// The make of the car.
        /// </summary>
        public string Make { get; set; }

        /// <summary>
        /// The model of the car.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// The URL used to retrieve the resource conforming to REST'ful JSON http://restfuljson.org/.
        /// </summary>
        public string Url { get; set; }
    }
}
