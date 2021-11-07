using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CautiousDelver : Template
    {
        public static readonly Guid ID = Guid.Parse("2491d2cb-11d0-441d-a360-8098e6e58eb2");

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
            yield return new TextBlock { Id = Guid.Parse("d5a78ab1-6c41-4f70-9861-255ae774e69e"), Type = TextBlockType.Text, Text = "You&#39;ve studied the many ways that ancient architects and spellcasters protected their possessions, such as by implementing deadly traps and curses, and learned some magic to counteract them. You can cast (spell: dispel magic), (spell: knock), and (spell: resist energy) as innate spells, each once per day. If you can already cast spells, these spells are of the same tradition. Otherwise, they&#39;re arcane spells, you use Intelligence as your spellcasting ability, and you become trained in spell attack rolls and spell DCs for arcane spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6698d32c-c042-4227-80cb-f5b61d69c7f4"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a9a3570d-ce19-4437-ba02-6b534a469e18"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
