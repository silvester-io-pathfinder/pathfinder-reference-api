using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LuckyKeepsake : Template
    {
        public static readonly Guid ID = Guid.Parse("7aded26a-1097-48c2-a5b2-035727dcc1b1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lucky Keepsake",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f9fd7f90-0649-486d-8689-59e99c72465e"), Type = TextBlockType.Text, Text = "You have a keepsake that grants you luck. You gain a +1 circumstance bonus to saves against spells and magical effects at all times, not just when you use (action: Leshy Superstition). If you lose the keepsake, you lose the bonus until you designate a new keepsake, typically over the course of a week." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("089edadf-51eb-4b5b-8ee6-c1742d490646"), Feats.Instances.LeshySuperstition.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a6cdde29-21a8-4e37-944a-a8dbac71c20e"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
