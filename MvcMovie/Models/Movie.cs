using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
	public class Movie
	{
		public int ID { get; set; }

		[Display(Name = "Titulo")]
		[StringLength(60, MinimumLength = 3)]
		public string Title { get; set; }

		[Display(Name = "Fecha de Lanzamiento")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
		public DateTime ReleaseDate { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
		[Required]
		[StringLength(30)]
		[Display(Name = "Genero")]
		public string Genre { get; set; }

		[Range(1, 100)]
		[DataType(DataType.Currency)]
		[Display(Name = "Precio")]
		public decimal Price { get; set; }

		[RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
		[StringLength(5)]
		[Display(Name = "Calificacion")]
		public string Rating { get; set; }
	}

	public class MovieDBContext : DbContext
	{
		public DbSet<Movie> Movies { get; set; }
	}
}