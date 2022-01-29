using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GearGnash : Template
    {
        public static readonly Guid ID = Guid.Parse("7c13e266-81e5-4259-a318-acd6c0ad7012");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gear Gnash",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d450502c-63e1-4e3a-a081-51501e4ab78f"), Type = TextBlockType.Text, Text = $"Snares you create have complicated inner workings that are quite difficult to disable. Creatures attempting to {ToMarkdownLink<Models.Entities.SkillAction>("Disable your snares", SkillActions.Instances.DisableADevice.ID)} that use gears must succeed at an additional Thievery check in order to disable the snare. On a failed check, while the snare doesn't fully trigger, the grinding mechanisms deal bludgeoning damage to the creature equal to half your level. The snare still triggers on a critical failure, as normal." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("400fda71-3d32-4b46-91fa-fd46e6ee9a06"), Feats.Instances.TrapsmithDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("f1be4e71-6dac-42f0-8b2b-543040f88f64"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f556f657-51fa-47d9-b20f-1b6b05094ce3"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("8ff04c29-dbf1-44b6-b2cc-6b4bc80efb38"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("861a11e0-203a-4f71-a91b-e51386b5941b"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
