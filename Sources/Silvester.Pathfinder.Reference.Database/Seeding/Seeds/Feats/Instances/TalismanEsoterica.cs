using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TalismanEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("5d6fbc5d-5a4a-421e-808f-b77ab078a08a");

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
            yield return new TextBlock { Id = Guid.Parse("608293b8-edc0-4665-b837-c95b2da63930"), Type = TextBlockType.Text, Text = "You know how to assemble the supernatural objects in your esoterica into a number of temporary talismans. Each day during your daily preparations, you can make two talismans with an item level no higher than half your level. You must know each talisman’s formula. A talisman created this way is a temporary item and loses its magic the next time you make your daily preparations." };
            yield return new TextBlock { Id = Guid.Parse("23109648-526a-449d-ba86-34b5615faf67"), Type = TextBlockType.Text, Text = "You know the formulas for all common talismans in the Core Rulebook of your level or lower. You remember your talisman formulas through oral tradition or mnemonics, so you don’t need a formula book for them." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("32999b66-5386-457b-8c61-8f5b327b227b"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
