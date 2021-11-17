using Microsoft.EntityFrameworkCore;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Extensions;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Mysteries

{
    public abstract class Template : EntityTemplate<Mystery>
    {
        protected override Mystery GetEntity(ISeedBuilder builder)
        {
            Mystery mystery = GetMystery();

            builder.AddSourcePage(mystery, GetSourcePage(), e => e.SourcePageId);
            builder.AddTextBlocks(mystery, GetDetailBlocks(), (c) => c.Details);
            builder.AddTextBlocks(mystery, GetBenefitBlocks(), (e) => e.MysteryBenefits);
            builder.AddEffect(mystery, GetEffects, e => e.EffectId);
            builder.AddJoinData<Mystery, Domain>(mystery, GetDomains());

            SeedCurse(builder, mystery);

            return mystery;
        }


        private void SeedCurse(ISeedBuilder builder, Mystery mystery)
        {
            MysteryCurse curse = GetCurse();
            builder.AddTextBlocks(curse, curse.Details, (e) => e.Details); 
            builder.AddSourcePage(curse, curse.SourcePage, e => e.SourcePageId);
            builder.AddTable(curse, curse.Table);

            foreach (MysteryCursePotency potency in curse.Potencies)
            {
                builder.AddTextBlocks(potency, potency.Details, (e) => e.Details);
                
                potency.Details = new List<TextBlock>();
                potency.MysteryCurseId = curse.Id;

                builder.AddData(potency);
            }

            curse.Details = new List<TextBlock>();
            curse.Potencies = new List<MysteryCursePotency>();
            curse.SourcePage = null!;
            curse.TableId = curse.Table?.Id;
            curse.Table = null;
            curse.MysteryId = mystery.Id;
            mystery.MysteryCurseId = curse.Id;

            builder.AddData(curse);
        }

        protected abstract Mystery GetMystery();
        protected abstract MysteryCurse GetCurse();
        protected abstract SourcePage GetSourcePage();
        protected abstract IEnumerable<TextBlock> GetBenefitBlocks();
        protected abstract IEnumerable<TextBlock> GetDetailBlocks();
        protected abstract IEnumerable<Guid> GetDomains();
        protected abstract void GetEffects(BooleanEffectBuilder builder);
    }
}
