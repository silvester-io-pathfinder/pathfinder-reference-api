using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class KiBlast : Template
    {
        public static readonly Guid ID = Guid.Parse("d26450e9-0241-4647-a63a-b26bcb22dcb5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ki Blast",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("946bdbfc-586d-45cc-8f94-591c66b72ba1"), Type = TextBlockType.Text, Text = "You can unleash an impactful cone of force by channeling your ki. You gain the (spell: ki blast) ki spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveAnyKiSpells(Guid.Parse("d99f8dc1-3881-4c36-a447-431a1dc7879d"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9e0d7ac2-0bfd-43be-a105-46b6a8ab3e1b"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
