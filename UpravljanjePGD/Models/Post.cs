using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UpravljanjePGD.Models
{
	public class Post
	{
		[Required]
		public int Id { get; set; }

		[Required(ErrorMessage = "Vnesi naslov!")]
		[Display(Name = "Naslov")]
		[StringLength(200)]
		public string Title { get; set; }

		[Required(ErrorMessage = "Vpišite željeno besedilo!")]
		[Display(Name ="Vsebina")]
		[DataType(DataType.MultilineText)]
		public string Body { get; set; }

		[Required(ErrorMessage = "Vpišite datum!")]
		[Display(Name = "Datum")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]

		public DateTime Date { get; set; }

	}
}