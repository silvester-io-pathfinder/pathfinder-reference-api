using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Rage : Template
    {
        public static readonly Guid ID = Guid.Parse("34f24acf-1d43-419f-a4b7-6f4e009d9ed4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Rage",
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
            yield return new TextBlock { Id = Guid.Parse("b474e996-6bcd-492b-a910-22cac1a0ead7"), Type = TextBlockType.Text, Text = "You tap into your inner fury and begin raging. You gain a number of temporary Hit Points equal to your level plus your Constitution modifier. This frenzy lasts for 1 minute, until there are no enemies you can perceive, or until you fall unconscious, whichever comes first. You can’t voluntarily stop raging. While you are raging:" };
            yield return new TextBlock { Id = Guid.Parse("fb1feb22-8556-44c2-8660-0781e782f7a0"), Type = TextBlockType.Enumeration, Text = " : You deal 2 additional damage with melee weapons and unarmed attacks. This additional damage is halved if your weapon or unarmed attack is (trait: agile)." };
            yield return new TextBlock { Id = Guid.Parse("bc39f86c-61c7-413f-ad47-7d4eea534512"), Type = TextBlockType.Enumeration, Text = " : You take a -1 penalty to AC." };
            yield return new TextBlock { Id = Guid.Parse("c1d8d36f-23c2-4645-bfdf-a556a2e92598"), Type = TextBlockType.Enumeration, Text = " : You can’t use actions with the (trait: concentrate) trait unless they also have the (trait: rage) trait. You can (action: Seek) while raging." };
            yield return new TextBlock { Id = Guid.Parse("40ed190d-aee6-47e4-8526-8e45da6805a9"), Type = TextBlockType.Text, Text = "After you stop raging, you lose any remaining temporary Hit Points from Rage, and you can’t Rage again for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f30dd9f7-bceb-4a47-b3fe-f9669137c2d7"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
