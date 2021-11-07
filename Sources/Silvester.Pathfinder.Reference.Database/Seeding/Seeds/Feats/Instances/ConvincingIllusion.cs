using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConvincingIllusion : Template
    {
        public static readonly Guid ID = Guid.Parse("6acb46c0-bbfb-4b72-8128-330ef9a71072");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Convincing Illusion",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature succeeded, but didn't critically succeed, at a Perception check or Will save to disbelieve an illusion from a spell that you cast.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("baefe7be-b65e-4c1a-b24a-f521c2bd32c3"), Type = TextBlockType.Text, Text = "You use your deceptive skills to make your illusions seem even more real. Attempt a Deception check against the target’s Perception DC. If you succeed, the target fails to disbelieve the illusion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2d69c19e-e5e3-4c03-b667-5fc41d50343e"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1372142b-9933-4cec-b29a-90dcab1b1ae2"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
