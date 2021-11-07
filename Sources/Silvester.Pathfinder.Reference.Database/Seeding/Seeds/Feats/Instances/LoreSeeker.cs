using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LoreSeeker : Template
    {
        public static readonly Guid ID = Guid.Parse("370f9f49-cd63-4542-ab62-4af680aa1e0d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lore Seeker",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("34d77ed0-ad34-4633-b514-855fb2b82c7d"), Type = TextBlockType.Text, Text = "You see what others don’t, and you’ve developed magical tricks to find hidden truth. You can cast (spell: comprehend language), (spell: restore senses), and (spell: see invisibility) as innate spells, each once per day. If you could already cast spells, these spells are of the same tradition. Otherwise, they are arcane spells, you use Intelligence as your spellcasting ability, and you become trained in spell attack rolls and spell DCs for arcane spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("33fee80f-5657-4ec6-a156-00b2025cd12a"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4af44a46-d181-492c-90a6-0e67011b30dc"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
