using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SummonFiendishKin : Template
    {
        public static readonly Guid ID = Guid.Parse("e886a2bf-4a99-49cd-b0b3-280452b7b256");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Summon Fiendish Kin",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d26dd330-eebb-4c00-8142-fb9b6af36b20"), Type = TextBlockType.Text, Text = $"You have a deep connection to the fiendish realms, allowing you to summon a fiend matching your own lineage. Once per day, you can cast {ToMarkdownLink<Models.Entities.Spell>("summon fiend", Spells.Instances.SummonFiend.ID)} as a 5th-level divine innate spell. The fiend you summon must match your own lineage." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("0ef5d393-89d2-44de-97b0-fc1b0e87ccdc"), Heritages.Instances.Tiefling.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7fe96fa9-8313-456e-baca-c8dd01ef9c31"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
