using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProphecysPawn : Template
    {
        public static readonly Guid ID = Guid.Parse("b8666457-2c8f-48dc-a21a-08b760540090");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Prophecy's Pawn",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You fail a saving throw, attack roll, or skill check.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41e51bee-682f-4770-af9b-742837979e26"), Type = TextBlockType.Text, Text = "You twist the prophecy in your favor, which will have consequences later. Reroll the failed check. You must use the result of the second roll." };
            yield return new TextBlock { Id = Guid.Parse("3b158a91-932b-489a-8ec5-16fc4dfb90d4"), Type = TextBlockType.Text, Text = "For 24 hours afterward, the GM can force you to reroll a successful saving throw, attack roll, or skill check as fate balances the scale. This is a (trait: misfortune) effect. You can’t use prophecy’s pawn again until the GM uses this option or 24 hours pass, whichever comes first." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2105c65b-29c4-4afb-a4e4-7ddcbf5a364f"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
