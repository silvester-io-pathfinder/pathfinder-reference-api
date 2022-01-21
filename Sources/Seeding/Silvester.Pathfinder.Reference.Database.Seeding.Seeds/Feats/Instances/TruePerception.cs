using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TruePerception : Template
    {
        public static readonly Guid ID = Guid.Parse("f999cad8-0476-4674-89d8-6c1060aed53d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "True Perception",
                Level = 19,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("027fce48-46db-4491-adfc-0ad2101370a3"), Type = TextBlockType.Text, Text = "Your perceptive abilities and ability to process sensory information are so far beyond the pale that you notice minute discrepancies in all sorts of illusions and transmutations. You are constantly under the effects of a 6th-level (spell: true seeing) spell, using your Perception modifier for the counteract check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d814b321-86f9-4a54-882e-640ea64d8956"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b50d9e7a-5cb0-425c-b851-47199badc7c9"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
