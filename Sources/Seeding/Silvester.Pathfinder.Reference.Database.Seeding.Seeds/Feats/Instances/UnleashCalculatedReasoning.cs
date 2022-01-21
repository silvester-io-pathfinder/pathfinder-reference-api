using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashCalculatedReasoning : Template
    {
        public static readonly Guid ID = Guid.Parse("f06bd8b7-96a9-4d56-944f-9e82b3595d5c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Calculated Reasoning",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("1f943499-8c79-4fc3-a9b8-c1265f110965"), Type = TextBlockType.Text, Text = "Your mind overflows with the calculated confidence that all results should be exactly what you've determined them to be." };
            yield return new TextBlock { Id = Guid.Parse("4b957140-70df-4062-b5d5-b2190107bebd"), Type = TextBlockType.Text, Text = "~ Benefit: While this psyche is Unleashed, when you would roll damage for a spell, you can instead choose to deal half the spell's maximum damage instead of rolling. (This is the full damage and is still halved on a half damage result, doubled on a double damage result, and so on.)" };
            yield return new TextBlock { Id = Guid.Parse("46803115-1ecc-4284-9d19-76811132efad"), Type = TextBlockType.Text, Text = "~ Drawback: Unlike other psyches, Unleash Calculated Reasoning has no drawback. You've taken everything into account and canceled all of the drawbacks out." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05c81190-bcf2-4a4d-8a16-7e9aec67b578"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
