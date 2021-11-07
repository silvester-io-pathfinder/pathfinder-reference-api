using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ReactiveDismissal : Template
    {
        public static readonly Guid ID = Guid.Parse("fcc643f1-4adb-4255-a5c3-4a69f8196097");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Reactive Dismissal",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your eidolon would take damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("194aed27-bc54-4baa-82f9-a4f9c95009d6"), Type = TextBlockType.Text, Text = "You abruptly dismiss your eidolon to reduce the damage it takes, though this makes summoning it again more difficult. Reduce the triggering damage to your eidolon by double your level, and your eidolon unmanifests. You can’t (action: Manifest your Eidolon | Manifest Eidolon) again until after the end of your next turn." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78a9ebd9-6bd8-440f-b56e-17eb0c344cd4"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
