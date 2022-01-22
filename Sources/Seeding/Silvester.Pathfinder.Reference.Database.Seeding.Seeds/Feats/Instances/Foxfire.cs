using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Foxfire : Template
    {
        public static readonly Guid ID = Guid.Parse("7448ea72-b60a-4173-b727-6c4d925e49f7");

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
            yield return new TextBlock { Id = Guid.Parse("2e5e23b1-c052-4b1a-b191-3cf615add840"), Type = TextBlockType.Text, Text = $"A crack of your tail sparks wisps of blue energy. Choose either electricity or fire when you gain this feat. You gain a foxfire ranged unarmed attack with a maximum range of 20 feet. The attack deals 1d4 damage of the chosen type (no ability modifier is added to the damage roll). Your foxfire attack is in the sling weapon group. Like other unarmed attacks, you can improve this attack with {ToMarkdownLink<Models.Items.Instances.WornItem>("handwraps of mighty blows", Items.WornItems.Instances.HandwrapsOfMightyBlows.ID)}." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38cc42b8-27b4-44ce-8bc4-ff2d129a5bcd"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
