using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SunderEnchantment : Template
    {
        public static readonly Guid ID = Guid.Parse("21d62c6b-26da-4d69-86a1-fdd4ac7bf511");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sunder Enchantment",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a5aad233-1a62-4f18-ab78-44ecf60d1707"), Type = TextBlockType.Text, Text = "You can focus your superstition to break the magic of an item, in addition to destroying freestanding spells and those active on creatures. When you (feat: Sunder a Spell | Sunder Spell), you can instead attempt to counteract either an unattended magic item or one of your target's magic items. If your counteract attempt succeeds, the item becomes a mundane item of its type for 10 minutes. If you target an artifact, an intelligent item, or a particularly powerful item, your counteract attempt automatically fails." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("2d892dc8-3619-468a-b6fc-9fd47054f69d"), Feats.Instances.SunderSpell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d74989b5-3b15-4e00-8827-3e356ec77d08"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
