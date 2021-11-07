using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OneInchPunch : Template
    {
        public static readonly Guid ID = Guid.Parse("bcb77ad1-887f-4da3-bd80-21f5ae112fe3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "One-Inch Punch",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("5eee1884-fa61-43b2-9623-890e7f9ac441"), Type = TextBlockType.Text, Text = "You put all your force into a single mighty, carefully controlled blow. Make an unarmed (action: Strike). If you spend two actions and this (action: Strike) hits, you deal an extra die of weapon damage. You can instead spend 3 actions to perform an even more powerful attack, dealing a second additional die of weapon damage on a hit." };
            yield return new TextBlock { Id = Guid.Parse("eb65eb09-0445-4ba1-9d90-cdfe10d75517"), Type = TextBlockType.Text, Text = "If you’re at least 10th level, the number of additional dice you add from this feat doubles, for a total of 2 additional dice if you spend 2 actions or 4 additional dice if you spend 3 actions. If you’re at least 18th level, the number of additional dice you add from this feat triples, for a total of 3 additional dice if you spend 2 actions or 6 additional dice if you spend 3 actions." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificClassFeature(Guid.Parse("1f2161bb-603b-4d94-be21-48cd3c21856d"), ClassFeatures.Monks.ExpertStrikes.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aa82245c-2939-47e3-9771-271a30196b81"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
