using AS.AdvertisementApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS.AdvertisementApp.DataAccess.Configurations
{
	public class GenderConfiguration : IEntityTypeConfiguration<Gender>
	{
		public void Configure(EntityTypeBuilder<Gender> builder)
		{
			builder.Property(x => x.Definition).HasMaxLength(300).IsRequired();
			builder.HasData(new Gender[]
				{
					new Gender()
					{
						Definition="Man",
						Id=1,
					},
					new Gender()
					{
						Definition="Woman",
						Id=2
					}
				});
		}
	}
}
