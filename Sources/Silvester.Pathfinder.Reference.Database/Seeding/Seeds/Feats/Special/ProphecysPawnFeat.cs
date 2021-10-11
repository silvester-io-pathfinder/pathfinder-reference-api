using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Special
{
    public class ProphecysPawnFeat : Template
    {
        public static readonly Guid ID = Guid.Parse("14906483-ca1a-4a46-aabb-dc8ba3f6ecfe");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prophecy's Pawn",
                Level = 1,
                Trigger = "You fail a saving throw, attack roll, or skill check.",
                ActionTypeId = ActionTypes.Instances.FreeAction.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ff4ce854-cef4-40bf-be88-7c49d77c1145"), Type = TextBlockType.Text, Text = "You twist the prophecy in your favor, which will have consequences later. Reroll the failed check. You must use the result of the second roll. For 24 hours afterward, the GM can force you to reroll a successful saving throw, attack roll, or skill check as fate balances the scale." };
            yield return new TextBlock { Id = Guid.Parse("bc3834f0-e879-44fc-9306-ed6bf357ec5d"), Type = TextBlockType.Text, Text = "This is a misfortune effect. You can't use prophecy's pawn again until the GM uses this option or 24 hours pass, whichever comes first." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield return Traits.Instances.Abjuration.ID;
            yield return Traits.Instances.Divine.ID;
            yield return Traits.Instances.Fortune.ID;
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5324ae47-aed5-4463-9e32-c4b9eb356e72"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 30
            };
        }
    }
}
