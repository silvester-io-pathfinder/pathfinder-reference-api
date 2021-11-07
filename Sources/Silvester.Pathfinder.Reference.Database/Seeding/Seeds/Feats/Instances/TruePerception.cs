using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TruePerception : Template
    {
        public static readonly Guid ID = Guid.Parse("bbf873b6-15c8-4633-950a-65e7f278d98c");

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
            yield return new TextBlock { Id = Guid.Parse("ea4d38f1-7601-4f7b-8ec3-13c5a3d0c5f2"), Type = TextBlockType.Text, Text = "Your perceptive abilities and ability to process sensory information are so far beyond the pale that you notice minute discrepancies in all sorts of illusions and transmutations. You are constantly under the effects of a 6th-level (spell: true seeing) spell, using your Perception modifier for the counteract check." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("b90f999c-1f07-4818-aeea-b64cf6285165"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Perception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df5dbd38-cad1-4f65-8522-5a0b24f8f07e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
