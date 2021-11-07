using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Rage : Template
    {
        public static readonly Guid ID = Guid.Parse("a0755ff7-1071-470a-9e97-2b9261e44cf7");

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
            yield return new TextBlock { Id = Guid.Parse("1700559f-53d9-49ad-8a68-e2fd9010b5b4"), Type = TextBlockType.Text, Text = "You tap into your inner fury and begin raging. You gain a number of temporary Hit Points equal to your level plus your Constitution modifier. This frenzy lasts for 1 minute, until there are no enemies you can perceive, or until you fall unconscious, whichever comes first. You can’t voluntarily stop raging. While you are raging:" };
            yield return new TextBlock { Id = Guid.Parse("bd3a6185-b4ee-4e33-9e59-6cac2749389c"), Type = TextBlockType.Enumeration, Text = " : You deal 2 additional damage with melee weapons and unarmed attacks. This additional damage is halved if your weapon or unarmed attack is (trait: agile)." };
            yield return new TextBlock { Id = Guid.Parse("e97b1e50-b5dd-4316-9188-db12575edd8e"), Type = TextBlockType.Enumeration, Text = " : You take a -1 penalty to AC." };
            yield return new TextBlock { Id = Guid.Parse("32808912-cd4e-4d80-b930-f16a5426e646"), Type = TextBlockType.Enumeration, Text = " : You can’t use actions with the (trait: concentrate) trait unless they also have the (trait: rage) trait. You can (action: Seek) while raging." };
            yield return new TextBlock { Id = Guid.Parse("03f8c731-85bd-4e9d-bce6-224c90e287fc"), Type = TextBlockType.Text, Text = "After you stop raging, you lose any remaining temporary Hit Points from Rage, and you can’t Rage again for 1 minute." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c8d1f17f-1c00-4ea8-87af-2b48cb0b032e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
