using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Official.Database.Extensions;
using Silvester.Pathfinder.Official.Database.Models;
using Silvester.Pathfinder.Official.Database.Utilities.Tables;
using Silvester.Pathfinder.Official.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Official.Database.Seeding.Seeds.Mysteries

{
    public abstract class Template : EntityTemplate<Mystery>
    {
        protected override Mystery GetEntity(ModelBuilder builder)
        {
            Mystery mystery = GetMystery();

            builder.AddSourcePage(mystery, GetSourcePage(), e => e.SourcePage);
            builder.AddTextBlocks(mystery, GetDetailBlocks(), (c) => c.Details);
            builder.AddTextBlocks(mystery, GetBenefitBlocks(), (e) => e.MysteryBenefits);
            builder.HasJoinData<Mystery, Domain>(mystery, GetDomains());

            SeedCurse(builder, mystery);

            return mystery;
        }

        private void SeedCurse(ModelBuilder builder, Mystery mystery)
        {
            MysteryCurse curse = GetCurse();

            builder.AddSourcePage(curse, curse.SourcePage, e => e.SourcePage);
            curse.SourcePage = null!;

            if (curse.Table != null)
            {
                builder.AddTable(curse, curse.Table);
            }
            curse.Table = null;

            curse.MysteryId = mystery.Id;
            foreach (MysteryCursePotency potency in curse.Potencies)
            {
                potency.MysteryCurseId = curse.Id;
                builder.AddTextBlocks(potency, potency.Details, (e) => e.Details);
                potency.Details = new TextBlock[0];


                builder.AddData(potency);
            }

            builder.AddTextBlocks(curse, curse.Details, (e) => e.Details);
            curse.Details = new TextBlock[0];

            curse.Potencies = new MysteryCursePotency[0];
            builder.AddData(curse);
        }

        protected abstract IEnumerable<TextBlock> GetBenefitBlocks();
        protected abstract IEnumerable<Guid> GetDomains();
        protected abstract MysteryCurse GetCurse();
        protected abstract Mystery GetMystery();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
    }
}
