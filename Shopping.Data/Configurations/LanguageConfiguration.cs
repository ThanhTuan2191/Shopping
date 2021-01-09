﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Shopping.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping.Data.Configurations
{
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Languages");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired().IsUnicode(false).HasMaxLength(5);

            builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        }
    }
}
