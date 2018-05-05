using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UpravljanjePGD.Models
{
	public class Inventar
	{
		[Required]
		public int Id { get; set; }

		[Required(ErrorMessage = "Vnesi naziv sredstva!")]
		[Display(Name = "Naziv sredstva")]
		[StringLength(200)]
		public string Name { get; set; }

		[Required(ErrorMessage = "Vnesi število!")]
		[Display(Name = "Število")]
		[StringLength(200)]
		public string Number { get; set; }

		[Required(ErrorMessage = "Vpiši nabavno vrednost!")]
		[Display(Name = "Nabavna vrednost")]
		[StringLength(200)]
		public string Value { get; set; }

		[Required(ErrorMessage = "Vpišite datum nabave!")]
		[Display(Name = "Datum nabave")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
		public DateTime DateReceived { get; set; }

		[Required(ErrorMessage = "Vpišite datum zadnjega pregleda!")]
		[Display(Name = "Datum pregleda")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
		public DateTime InspectionDate { get; set; }

		[Required(ErrorMessage = "Vpišite datum naslednjega prelgeda!")]
		[Display(Name = "Datum naslednjega pregleda")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
		public DateTime NextInspectionDate { get; set; }

		[Required(ErrorMessage = "Vnesite rok uporabnosti!")]
		[Display(Name = "Rok uporabnosti")]
		[StringLength(200)]
		public string Expiration { get; set; }

		[Required(ErrorMessage = "Vnesite stanje sredstva - opažene nepravilnosti?")]
		[Display(Name = "Stanje izdelka")]
		[StringLength(200)]
		public string State { get; set; }
	}
}