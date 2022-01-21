using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class FrozenWindKitsune : Template
    {
        public static readonly Guid ID = Guid.Parse("4121850f-636a-4c99-9479-d5127d68c330");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Frozen Wind Kitsune"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("334480dd-e3c8-4b3f-8157-5530b33d6550"), Type = TextBlockType.Text, Text = "Your ancestors crossed the Crown of the World or resided on snowy peaks. You gain cold resistance equal to half your level (minimum 1). You treat environmental cold effects as if they were one step less extreme (incredible cold becomes extreme, extreme cold becomes severe, and so on). Your alternate form is a common Medium humanoid ancestry prevalent where you grew up (typically human), called a tailless form." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificDamageResistance(Guid.Parse("1d4eddc3-3a28-4eb1-a2d6-4210351ae319"), DamageTypes.Instances.Cold.ID, ModifierInput.Level, ModifierType.Divide, modifier: 2, minimum: 1);
            builder.ModifyTemperature(Guid.Parse("65398e70-62c0-481e-a155-7b7951cd9c34"), Temperature.Cold, ModifierType.Subtract, modifier: 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1f243284-c763-4c84-995b-523485f18f0b"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 123
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Kitsune.ID;
        }
    }
}
