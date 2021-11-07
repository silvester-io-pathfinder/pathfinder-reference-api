using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BadgerRage : Template
    {
        public static readonly Guid ID = Guid.Parse("3f3b94cb-d348-4f6d-a800-59d1a2d51a8b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Badger Rage",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c59f4feb-1b62-49b0-8e17-9163ce5d184c"), Type = TextBlockType.Text, Text = "The badger enters a state of pure rage that lasts for 1 minute, until there are no enemies it can perceive, or until it falls unconscious, whichever comes first. It can’t voluntarily stop raging. While raging, the badger is affected in the following ways." };
            yield return new TextBlock { Id = Guid.Parse("4df8cba1-38da-4dfb-906b-4c5f49e4d7ce"), Type = TextBlockType.Enumeration, Text = " : It deals 4 additional damage with its jaws attack and 2 additional damage with its claw attack." };
            yield return new TextBlock { Id = Guid.Parse("3c577e2c-627a-49cd-89f2-18792c113cbc"), Type = TextBlockType.Enumeration, Text = " : It takes a -1 penalty to AC." };
            yield return new TextBlock { Id = Guid.Parse("a1c3c292-1e27-41a9-91e2-06228b114909"), Type = TextBlockType.Enumeration, Text = " : It can’t use actions that have the (trait: concentrate) trait unless they also have the (trait: rage) trait. Though, the animal companion can (action: Seek) even while raging." };
            yield return new TextBlock { Id = Guid.Parse("d2d6cd94-b9d9-4e3c-a6a8-2440548a0c24"), Type = TextBlockType.Text, Text = "After it has stopped raging, it can’t use Badger Rage again for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("062982e7-307d-468c-a3f9-38bfbb134091"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
