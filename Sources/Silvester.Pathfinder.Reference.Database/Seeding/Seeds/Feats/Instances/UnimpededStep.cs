using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnimpededStep : Template
    {
        public static readonly Guid ID = Guid.Parse("a905932a-2c94-49bb-a9d1-315f94082b18");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unimpeded Step",
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
            yield return new TextBlock { Id = Guid.Parse("aa9a6c2e-60ab-437c-8353-7db5eff6097d"), Type = TextBlockType.Text, Text = "With a burst of divine liberation, your ally’s movement from your (feat: Liberating Step) is unaffected by difficult terrain, greater difficult terrain, narrow surfaces, and uneven ground." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificCause(Guid.Parse("34657499-0a39-4b88-aac5-1f512fe34416"), Causes.Instances.Liberator.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d5e0b6e6-0612-4d32-8daf-6645cf97803e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
