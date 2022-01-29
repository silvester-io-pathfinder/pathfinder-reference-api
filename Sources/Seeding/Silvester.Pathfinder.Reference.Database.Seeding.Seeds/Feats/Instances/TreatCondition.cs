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
    public class TreatCondition : Template
    {
        public static readonly Guid ID = Guid.Parse("8ef65c8d-86e7-4033-ae35-5dbab68b4e29");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Treat Condition",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ad0c777d-72c0-4742-8ea0-561e3f631d8b"), Type = TextBlockType.Text, Text = $"You treat an adjacent creature in an attempt to reduce the clumsy, enfeebled, or sickened condition. If a creature has multiple conditions from this list, choose one. Attempt a counteract check against the condition, using your Medicine modifier as your counteract modifier and the condition's source to determine the DC. You can't treat a condition that came from an artifact or effect above 20th level unless you have {ToMarkdownLink<Models.Entities.Feat>("Legendary Medic", Feats.Instances.LegendaryMedic.ID)}; even if you do, the counteract DC increases by 10. Treating a Condition that is continually applied under certain circumstances (for instance, the enfeebled condition a good character gains from carrying an {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("unholy", Items.WeaponPropertyRunes.Instances.Unholy.ID)} weapon) has no effect as long as the circumstances continue." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("656a03dd-437e-455d-ae5f-18eaf3fe21a2"), Feats.Instances.MedicDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c97933c1-6165-46cb-b228-7e033609f397"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("ebccb45d-2755-4dc6-83ce-baece79c1a97"), Traits.Instances.Healing.ID);
            builder.Add(Guid.Parse("ba4eebd3-44d4-4224-9184-a3a9a4da727f"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("563217cb-2d66-4471-9740-6275c711a459"), Traits.Instances.Skill.ID);

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("1929ad81-2051-461d-a6c2-a64326907688"),
                CriticalSuccess = "Reduce the condition value by 2.",
                Success = "Reduce the condition value by 1.",
                
                CriticalFailure = "Increase the condition value by 1.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e14f19c2-89b5-4275-93c4-357e5aa03de3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
