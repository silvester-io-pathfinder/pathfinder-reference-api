using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShadowMark : Template
    {
        public static readonly Guid ID = Guid.Parse("e4e7edf3-27cb-451a-a64b-83415f2048a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Mark",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e57759ac-79a2-4c9e-8442-290279de8bbd"), Type = TextBlockType.Text, Text = "You have learned special tricks that help you follow individuals without them noticing you. When you attempt a Stealth check to (action: Avoid Notice) while following a specific target, the target takes a -2 circumstance penalty to their Perception DC. If you have master proficiency in Stealth, the penalty is -3 or -4 if you’re legendary. If you start an encounter with the target while shadowing them, the target takes this penalty to their initiative roll and to their Perception DC to determine if they notice you, as normal for (action: Sneak)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("82855c7d-9231-4cfb-b38e-d0806e6feb65"), Proficiencies.Instances.Expert.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7451386c-c089-4869-9374-9164a46bd2d0"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}