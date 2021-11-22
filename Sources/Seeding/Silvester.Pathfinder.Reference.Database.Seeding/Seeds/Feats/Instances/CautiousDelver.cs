using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CautiousDelver : Template
    {
        public static readonly Guid ID = Guid.Parse("ef552e57-9399-47c0-900e-d6e8aadce6e1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cautious Delver",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e1b82619-c9a5-4739-b9fd-82cf5704749c"), Type = TextBlockType.Text, Text = "You've studied the many ways that ancient architects and spellcasters protected their possessions, such as by implementing deadly traps and curses, and learned some magic to counteract them. You can cast (spell: dispel magic), (spell: knock), and (spell: resist energy) as innate spells, each once per day. If you can already cast spells, these spells are of the same tradition. Otherwise, they're arcane spells, you use Intelligence as your spellcasting ability, and you become trained in spell attack rolls and spell DCs for arcane spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7643e2fc-a1cd-4826-af23-f12e4b7afef5"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0ebee062-5fb7-462d-8ed2-4ee65fa39f33"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
