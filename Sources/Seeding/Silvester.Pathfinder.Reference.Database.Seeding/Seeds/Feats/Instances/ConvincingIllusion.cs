using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConvincingIllusion : Template
    {
        public static readonly Guid ID = Guid.Parse("6ffc1236-7645-4747-b379-0dfae8423b42");

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
            yield return new TextBlock { Id = Guid.Parse("d159068d-1f3c-45f6-ab70-4ea50ceaf559"), Type = TextBlockType.Text, Text = "You use your deceptive skills to make your illusions seem even more real. Attempt a Deception check against the target's Perception DC. If you succeed, the target fails to disbelieve the illusion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("323423ca-065e-40a1-8f7b-77950de5bc53"), Proficiencies.Instances.Expert.ID, Skills.Instances.Deception.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df93db06-e59a-422b-8560-bda90bc27a1c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
