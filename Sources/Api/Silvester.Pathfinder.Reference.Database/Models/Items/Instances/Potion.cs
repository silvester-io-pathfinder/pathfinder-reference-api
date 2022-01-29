﻿using NpgsqlTypes;
using Silvester.Pathfinder.Reference.Database.Models.Items.Abstractions;
using Silvester.Pathfinder.Reference.Database.Seeding;
using System;
using System.Linq.Expressions;

namespace Silvester.Pathfinder.Reference.Database.Models.Items.Instances
{
    public class Potion : BaseItem
    {

    }

    public class PotionVariant : BaseItemVariant, IUsed, ISearchableEntity
    {
        public int Price { get; set; }
        public int Level { get; set; }
        public string Usage { get; set; } = default!;
        public string Hands { get; set; } = default!;

        public NpgsqlTsVector SearchVector { get; set; } = default!;
    }

    public class PotionVariantConfigurator : EntityConfigurator<PotionVariant>
	{
		public PotionVariantConfigurator()
		{
			ConfigureEntitySearch<PotionVariant>(e => new {e.Name, e.Usage});
		}
	}
}