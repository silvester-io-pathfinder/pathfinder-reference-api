using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Multitalented : Template
    {
        public static readonly Guid ID = Guid.Parse("3420e443-6a23-49a5-b515-b166900f41d7");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Multitalented",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b2ed2909-075b-4f88-87b5-e791a45bce1c"), Type = TextBlockType.Text, Text = "You’ve learned to split your focus between multiple classes with ease. You gain a 2nd-level multiclass dedication feat, even if you normally couldn’t take another dedication feat until you take more feats from your current archetype." };
            yield return new TextBlock { Id = Guid.Parse("713c018a-32ce-40b6-8123-7a0d664eb519"), Type = TextBlockType.Text, Text = "If you’re a half-elf, you don’t need to meet the feat’s ability score prerequisites." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4f1e82d7-fbd9-4fb7-a9bc-54b14d6dfbe5"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
