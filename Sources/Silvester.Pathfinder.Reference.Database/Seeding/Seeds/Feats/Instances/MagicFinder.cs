using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicFinder : Template
    {
        public static readonly Guid ID = Guid.Parse("b40623ed-b249-4df7-a3a5-562b14f230e4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magic Finder",
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
            yield return new TextBlock { Id = Guid.Parse("8da43fc7-a43a-45d1-ac86-1856474d75c2"), Type = TextBlockType.Text, Text = "You&#39;ve learned a few tricks to ensure you find every last magic item and interesting magical effect during your missions. You can cast (spell: detect magic) and (spell: read aura) as innate spells at will. You can also cast (spell: locate) as an innate spell once per day, but only to locate magic items, not specific mundane objects or types of objects. If you could already cast spells, these spells are of the same tradition. Otherwise, they&#39;re arcane spells, you use Intelligence as your spellcasting ability, and you become trained in spell attack rolls and spell DCs for arcane spells." };
            yield return new TextBlock { Id = Guid.Parse("ab30e610-cf4e-4f11-a7ec-9ea74518d3cf"), Type = TextBlockType.Text, Text = "When you cast (spell: detect magic) or (spell: read aura) from this feat on an item or creature under the effect of a (spell: magic aura) spell or interact with an item under the effect of an (spell: item facade) spell, you gain a +2 circumstance bonus on your check to disbelieve the illusion." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e26e90c7-fbc7-48ae-8a3e-3ec41f605685"), Feats.Instances.ScrollmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7ba60511-1aa6-4cc6-9356-8f8aed0cc886"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
