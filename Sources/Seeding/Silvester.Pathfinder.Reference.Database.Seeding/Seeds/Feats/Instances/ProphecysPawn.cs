using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ProphecysPawn : Template
    {
        public static readonly Guid ID = Guid.Parse("8084ae07-90db-48eb-a396-155901a98300");

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
            yield return new TextBlock { Id = Guid.Parse("d054d207-3795-44be-8279-db94d34abc1a"), Type = TextBlockType.Text, Text = "You twist the prophecy in your favor, which will have consequences later. Reroll the failed check. You must use the result of the second roll." };
            yield return new TextBlock { Id = Guid.Parse("dd621c9a-bab6-4a07-acf7-ce10b8e15e64"), Type = TextBlockType.Text, Text = "For 24 hours afterward, the GM can force you to reroll a successful saving throw, attack roll, or skill check as fate balances the scale. This is a (trait: misfortune) effect. You can't use prophecy's pawn again until the GM uses this option or 24 hours pass, whichever comes first." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("64073c02-0f93-4008-8d68-78cf48ab8654"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
