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
    public class DeepOrc : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Deep Orc"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your calloused hands and red eyes speak to a life spent in the deep darkness of mountain caverns, where you learned to battle on rocky cliffs and survive with minimal resources. You gain the Terrain Expertise skill feat for underground terrain and the Combat Climber skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.TerrainExpertise.ID, restrictions: "The chosen terrain mst be 'underground'.");
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.CombatClimber.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = 18
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Orc.ID;
        }
    }
}
