using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneShroud : Template
    {
        public static readonly Guid ID = Guid.Parse("c27392e5-5fbf-425d-8e73-2e10e92a0daa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Shroud",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per turn"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0d848b2b-55eb-48c8-b428-6ae361ca9482"), Type = TextBlockType.Text, Text = "Your spell has a powerful aftereffect, briefly granting you a certain spell depending on the spell you cast. You use (feat: Arcane Cascade) and are subject to an additional aftereffect spell depending on the school of your most recent spell. This aftereffect spell’s duration lasts until the end of your next turn or its normal duration, whichever is longer. Using Arcane Shroud again ends any existing spell you gained from Arcane Shroud." };
            yield return new TextBlock { Id = Guid.Parse("30d87f9d-5634-4ff0-815f-56d7ce132a32"), Type = TextBlockType.Enumeration, Text = " Abjuration: (spell: stoneskin)" };
            yield return new TextBlock { Id = Guid.Parse("d97743c4-5487-469d-a09d-ef8c191a501b"), Type = TextBlockType.Enumeration, Text = " Conjuration: (spell: blink)" };
            yield return new TextBlock { Id = Guid.Parse("0bd51bb8-c97b-4e48-91e6-8afe69057409"), Type = TextBlockType.Enumeration, Text = " Divination: (spell: see invisibility)" };
            yield return new TextBlock { Id = Guid.Parse("0a7152fa-0f61-48b3-819b-428087b25e9b"), Type = TextBlockType.Enumeration, Text = " Enchantment: (spell: heroism)" };
            yield return new TextBlock { Id = Guid.Parse("175cd794-18d0-47ec-b2b8-f1384a01f498"), Type = TextBlockType.Enumeration, Text = " Evocation: (spell: fire shield)" };
            yield return new TextBlock { Id = Guid.Parse("29e1eff9-bfe4-45a5-9046-3eb9caf483de"), Type = TextBlockType.Enumeration, Text = " Illusion: (spell: invisibility) (ends after a hostile action, as normal)" };
            yield return new TextBlock { Id = Guid.Parse("d8f5985d-a265-44bf-9c47-0e4f1a896e91"), Type = TextBlockType.Enumeration, Text = " Necromancy: (spell: false life)" };
            yield return new TextBlock { Id = Guid.Parse("1fb5b00c-cc17-4953-97d3-086c8cceb369"), Type = TextBlockType.Enumeration, Text = " Transmutation: (spell: fleet step)" };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("963febab-94a4-4df3-bf01-afd722a548f7"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveSpecificFeat(Guid.Parse("b5b6fa21-639f-4094-bdd2-11c03b34ff8c"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("00fe8a69-d53f-433f-af8e-705e94156878"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
