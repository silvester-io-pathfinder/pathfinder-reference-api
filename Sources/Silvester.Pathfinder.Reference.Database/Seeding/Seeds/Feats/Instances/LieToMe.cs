using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LieToMe : Template
    {
        public static readonly Guid ID = Guid.Parse("d83c54d7-f193-4d7c-982a-b010e7487d81");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lie to Me",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("59472c40-e80b-4631-9b50-393c0b44cbba"), Type = TextBlockType.Text, Text = "You can use Deception to weave traps to trip up anyone trying to deceive you. If you can engage in conversation with someone trying to (action: Lie) to you, use your Deception DC if it is higher than your Perception DC to determine whether they succeed. This doesn’t apply if you don’t have a back-and-forth dialogue, such as when someone attempts to (action: Lie) during a long speech." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("d25bf4fc-daa4-4b4a-95ca-b88f26c6e3b6"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2bfac030-6ad9-40b3-99b3-991c54b8c5bb"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
