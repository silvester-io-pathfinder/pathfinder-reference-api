using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MirrorShield : Template
    {
        public static readonly Guid ID = Guid.Parse("b8f4551b-fe57-4a8b-9787-b540ab3684de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mirror Shield",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An opponent casting a spell that targets you critically fails a spell attack roll against your AC.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("530c91cf-aa21-4173-b320-27eb99afb2c9"), Type = TextBlockType.Text, Text = "You reflect the spell back against the triggering opponent. Make a ranged attack against the triggering creature using your highest proficiency with a ranged weapon. If you can cast spells, you can make a spell attack roll instead. If you succeed, your opponent takes the effects of a successful spell attack roll for their own spell (or the effects of a critical success if your attack roll was a critical success)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e307e3f5-ec1b-47fc-87e4-59208f110932"), Feats.Instances.BastionDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c4f75754-690f-44a6-928a-b10a72250f6a"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
