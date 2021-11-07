using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BattleMedicine : Template
    {
        public static readonly Guid ID = Guid.Parse("b2a21bca-7a54-4600-ae9f-cf835f953995");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Battle Medicine",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8af39a16-7868-43f3-a3df-f0aaf9a52c07"), Type = TextBlockType.Text, Text = "You can patch up yourself or an adjacent ally, even in combat. Attempt a Medicine check with the same DC as for (action: Treat Wounds), and restore a corresponding amount of Hit Points; this does not remove the wounded condition. As with (action: Treat Wounds), you can attempt checks against higher DCs if you have the minimum proficiency rank. The target is then temporarily immune to your Battle Medicine for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("337eb166-e8fb-43b8-920b-a5837f87cf6a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e29377d1-baeb-4d60-8262-fb3bbc5184ea"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
