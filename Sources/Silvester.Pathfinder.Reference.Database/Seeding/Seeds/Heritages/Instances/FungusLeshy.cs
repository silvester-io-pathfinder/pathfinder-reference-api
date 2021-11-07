using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class FungusLeshy : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Fungus Leshy"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your body was made from fungi that grows in the shade of caves and trees, and you are at home in dark caverns and warrens. You gain darkvision. You lose the plant trait and gain the fungus trait." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSense(Guid.Parse(""), Senses.Instances.Darkvision.ID, SenseAccuracies.Instances.Precise.ID);
            builder.LoseSpecificTrait(Guid.Parse(""), Traits.Instances.Plant.ID);
            builder.GainSpecificTrait(Guid.Parse(""), Traits.Instances.Fungus.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.CharacterGuide.ID,
                Page = 53
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Leshy.ID;
        }
    }
}
