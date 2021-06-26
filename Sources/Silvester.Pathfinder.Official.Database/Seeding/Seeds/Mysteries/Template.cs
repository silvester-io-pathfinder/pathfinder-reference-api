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

            builder.AddSourcePage(mystery, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(mystery, GetDetailBlocks(), (c) => c.Details);
            builder.AddTextBlocks(mystery, GetBenefitBlocks(), (e) => e.MysteryBenefits);
            builder.HasJoinData<Mystery, Domain>(mystery, GetDomains());


            SeedCurse(builder, mystery);

            return mystery;
        }

        private void SeedCurse(ModelBuilder builder, Mystery mystery)
        {
            MysteryCurse curse = GetCurse();
            builder.AddTextBlocks(curse, curse.Details, (e) => e.Details); 
            builder.AddSourcePage(curse, curse.SourcePage, e => e.SourcePageId);
            builder.AddTable(curse, curse.Table);

            foreach (MysteryCursePotency potency in curse.Potencies)
            {
                builder.AddTextBlocks(potency, potency.Details, (e) => e.Details);
                
                potency.Details = new TextBlock[0];
                potency.MysteryCurseId = curse.Id;

                builder.AddData(potency);
            }

            curse.Details = new TextBlock[0];
            curse.Potencies = new MysteryCursePotency[0];
            curse.SourcePage = null!;
            curse.TableId = curse.Table?.Id;
            curse.Table = null;
            curse.MysteryId = mystery.Id;
            mystery.MysteryCurseId = curse.Id;

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
