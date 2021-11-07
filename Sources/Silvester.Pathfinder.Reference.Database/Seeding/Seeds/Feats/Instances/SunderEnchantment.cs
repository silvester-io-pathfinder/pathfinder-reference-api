using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SunderEnchantment : Template
    {
        public static readonly Guid ID = Guid.Parse("97e5f1f6-2656-4f34-b81d-03b13a7919ae");

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
            yield return new TextBlock { Id = Guid.Parse("8197c19a-66df-4bad-82de-49876f19fada"), Type = TextBlockType.Text, Text = "You can focus your superstition to break the magic of an item, in addition to destroying freestanding spells and those active on creatures. When you (feat: Sunder a Spell | Sunder Spell), you can instead attempt to counteract either an unattended magic item or one of your target’s magic items. If your counteract attempt succeeds, the item becomes a mundane item of its type for 10 minutes. If you target an artifact, an intelligent item, or a particularly powerful item, your counteract attempt automatically fails." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("94937a01-cd0f-49b2-8333-6249e5377455"), Feats.Instances.SunderSpell.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a0d7c744-bf29-4e44-bb82-5fe68fe510b8"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
