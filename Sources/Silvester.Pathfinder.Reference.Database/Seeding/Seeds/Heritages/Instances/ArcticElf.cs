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
    public class ArcticElf : Template
    {
        public static readonly Guid ID = Guid.Parse("62d5db67-945b-4cea-971f-9a2fa5038f2d");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Arctic Elf"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You dwell deep in the frozen north and have gained incredible resilience against cold environments, granting you cold resistance equal to half your level (minimum 1). You treat environmental cold effects as if they were one step less extreme (incredible cold becomes extreme, extreme cold becomes severe, and so on)." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifyTemperature(Guid.Parse(""), Temperature.Heat, ModifierType.Subtract, 1);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 39
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Elf.ID;
        }
    }
}
