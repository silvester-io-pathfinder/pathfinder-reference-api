using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HoldMark : Template
    {
        public static readonly Guid ID = Guid.Parse("5768e8ca-2add-4fee-a846-355d08726450");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Hold Mark",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("72a34373-ef96-46f5-8467-5e09b4b7c2ae"), Type = TextBlockType.Text, Text = "You bear scars or tattoos enhanced by the mark of your community&#39;s prowess. When you select this feat, choose one of the options below." };
            yield return new TextBlock { Id = Guid.Parse("71836a65-bb40-49b1-8134-6287b66f719c"), Type = TextBlockType.Text, Text = "When you critically hit using a weapon of the listed group, you apply the weapon&#39;s critical specialization effect. You gain a large brand or tattoo in the shape of the chosen emblem or a similar image (for example, the axe could be a bear or other symbol of ferocious strength, while the shield might be a turtle or another symbol associated with a strong defense) and gain the listed benefit." };
            yield return new TextBlock { Id = Guid.Parse("aaa800cf-3978-4907-b97d-be0bc309a01f"), Type = TextBlockType.Enumeration, Text = " Axe: axe or pick" };
            yield return new TextBlock { Id = Guid.Parse("6b23e6e0-7a9c-4521-9d60-9ef250d9a55b"), Type = TextBlockType.Enumeration, Text = " Shield: hammer or shield" };
            yield return new TextBlock { Id = Guid.Parse("0434abd8-631d-4b44-b362-60f56d39194d"), Type = TextBlockType.Enumeration, Text = " Torch: bomb or knife" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("aefd7d01-4768-4eb7-9189-8d8fc4306aac"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
