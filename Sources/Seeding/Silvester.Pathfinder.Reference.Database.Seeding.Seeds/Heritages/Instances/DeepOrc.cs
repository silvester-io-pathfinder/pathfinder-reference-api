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
        public static readonly Guid ID = Guid.Parse("213e1d6e-13e0-449d-ae33-8d38c566791b");

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
            yield return new TextBlock { Id = Guid.Parse("0fcc0e18-2eea-46c7-a32b-44b280e40bc1"), Type = TextBlockType.Text, Text = "Your calloused hands and red eyes speak to a life spent in the deep darkness of mountain caverns, where you learned to battle on rocky cliffs and survive with minimal resources. You gain the Terrain Expertise skill feat for underground terrain and the Combat Climber skill feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificFeat(Guid.Parse("a2957f57-8086-447d-b5dd-41e1719cc7d9"), Feats.Instances.TerrainExpertise.ID, restrictions: "The chosen terrain mst be 'underground'.");
            builder.GainSpecificFeat(Guid.Parse("113d71c6-d4ff-4027-865f-022e2c2909d1"), Feats.Instances.CombatClimber.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2fbd98e7-2b60-4dc7-b9d9-e702f80e95c2"),
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
