using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Foxfire : Template
    {
        public static readonly Guid ID = Guid.Parse("4331b3c7-107f-4284-93ad-6911602b614f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Foxfire",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "If you are a frozen wind kitsune, your foxfire deals cold damage instead of electricity or fire.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c1a6699-9e72-48b9-96a8-74ca04e4053d"), Type = TextBlockType.Text, Text = "A crack of your tail sparks wisps of blue energy. Choose either electricity or fire when you gain this feat. You gain a foxfire ranged unarmed attack with a maximum range of 20 feet. The attack deals 1d4 damage of the chosen type (no ability modifier is added to the damage roll). Your foxfire attack is in the sling weapon group. Like other unarmed attacks, you can improve this attack with (item: handwraps of mighty blows)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("88197459-6d73-4bac-aeb8-d8b8aced16dd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
