using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TalismanEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("a85800b5-90db-4f85-a7f6-42c45b36fa18");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Talisman Esoterica",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0180953f-5de1-4ba2-bdb9-6bda36aabecb"), Type = TextBlockType.Text, Text = "You know how to assemble the supernatural objects in your esoterica into a number of temporary talismans. Each day during your daily preparations, you can make two talismans with an item level no higher than half your level. You must know each talisman’s formula. A talisman created this way is a temporary item and loses its magic the next time you make your daily preparations." };
            yield return new TextBlock { Id = Guid.Parse("966d3f5a-9688-48e3-852a-ff791f136a48"), Type = TextBlockType.Text, Text = "You know the formulas for all common talismans in the Core Rulebook of your level or lower. You remember your talisman formulas through oral tradition or mnemonics, so you don’t need a formula book for them." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b0ba58c9-ef43-48f4-b4b4-471abd556297"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
