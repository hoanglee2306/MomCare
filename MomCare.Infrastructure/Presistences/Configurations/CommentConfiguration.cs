﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MomCare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomCare.Infrastructure.Presistences.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<CommentEntity>
    {
        public void Configure(EntityTypeBuilder<CommentEntity> builder)
        {
            builder.ToTable("Comment");
            builder.HasKey(c => c.Id);
        }
    }
}
