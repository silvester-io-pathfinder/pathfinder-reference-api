using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealMount : Template
    {
        public static readonly Guid ID = Guid.Parse("46558491-987f-492a-a587-57874ef93a72");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Heal Mount",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b5c6a53d-8830-45b5-b8df-76d38d02d27d"), Type = TextBlockType.Text, Text = "Your devotion to your mount manifests as a surge of positive energy. When you cast (spell: lay on hands) on your mount, you can restore 10 Hit Points, plus 10 for each heightened level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("a94f7a01-2a50-4693-98cc-6ce1c53d2762"), DivineAllies.Instances.Steed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f9ad450d-6c45-49c3-a4bd-9df0f798593d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
