using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HoldMark : Template
    {
        public static readonly Guid ID = Guid.Parse("383db577-60d5-4441-932c-87e9c083aa95");

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
            yield return new TextBlock { Id = Guid.Parse("bdc0080f-c023-4887-9cd8-6d61142bf86d"), Type = TextBlockType.Text, Text = "You bear scars or tattoos enhanced by the mark of your community's prowess. When you select this feat, choose one of the options below." };
            yield return new TextBlock { Id = Guid.Parse("7f014910-157d-4c01-8c34-485bc7e1bb23"), Type = TextBlockType.Text, Text = "When you critically hit using a weapon of the listed group, you apply the weapon's critical specialization effect. You gain a large brand or tattoo in the shape of the chosen emblem or a similar image (for example, the axe could be a bear or other symbol of ferocious strength, while the shield might be a turtle or another symbol associated with a strong defense) and gain the listed benefit." };
            yield return new TextBlock { Id = Guid.Parse("96e079b3-f2e0-4b3e-98e0-20c838a03d24"), Type = TextBlockType.Enumeration, Text = " Axe: axe or pick" };
            yield return new TextBlock { Id = Guid.Parse("256356da-accc-4f86-94c7-22116bb7ac14"), Type = TextBlockType.Enumeration, Text = " Shield: hammer or shield" };
            yield return new TextBlock { Id = Guid.Parse("829cfcd0-4ac2-4957-9edd-638ce20542c4"), Type = TextBlockType.Enumeration, Text = " Torch: bomb or knife" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5c48eef-26f2-4754-a05a-797cdbc20eac"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
