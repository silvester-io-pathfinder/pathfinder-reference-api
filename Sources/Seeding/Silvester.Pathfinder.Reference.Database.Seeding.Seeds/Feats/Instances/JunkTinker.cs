using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JunkTinker : Template
    {
        public static readonly Guid ID = Guid.Parse("43e40cd4-a0ad-421b-b42a-7073e3f7e768");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Junk Tinker",
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
            yield return new TextBlock { Id = Guid.Parse("94bf124c-2389-448c-b42f-fd49f631c01e"), Type = TextBlockType.Text, Text = $"You can make useful tools out of even twisted or rusted scraps. When using the Crafting skill to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)}, you can make level 0 items, including weapons but not armor, out of junk. This reduces the Price to one-quarter the usual amount but always results in a shoddy item. Shoddy items normally give a penalty, but you don't take this penalty when using shoddy items you made." };
            yield return new TextBlock { Id = Guid.Parse("7674e835-7d23-4e91-b628-8645f6c9f130"), Type = TextBlockType.Text, Text = $"You can also incorporate junk to save money while you {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} any item. This grants you a discount on the item as if you had spent 1 additional day working to reduce the cost, but the item is obviously made of junk. At the GM's discretion, this might affect the item's resale value depending on the buyer's tastes." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("38274b02-8d62-4123-a7d0-10d22ea8feb0"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
