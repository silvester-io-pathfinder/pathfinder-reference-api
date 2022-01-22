using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HealingGrace : Template
    {
        public static readonly Guid ID = Guid.Parse("1f351172-a3b0-4b2a-ad72-b633c0301575");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Healing Grace",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("86c6b833-fded-4dd1-94ec-40aba9e83dbf"), Type = TextBlockType.Text, Text = $"You gain fast healing equal to half your level. You can cast {ToMarkdownLink<Models.Entities.Spell>("heal", Spells.Instances.Heal.ID)} once as an innate spell with a level equal to half your level rounded up." };
            yield return new TextBlock { Id = Guid.Parse("10bf55eb-b262-486b-8041-8a568ab93921"), Type = TextBlockType.Text, Text = $"__Corruption Flaw__ Reduce all healing you would receive or grant with a spell by half your level." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("75cf7e88-59c6-47f6-9f08-a0026de63655"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
