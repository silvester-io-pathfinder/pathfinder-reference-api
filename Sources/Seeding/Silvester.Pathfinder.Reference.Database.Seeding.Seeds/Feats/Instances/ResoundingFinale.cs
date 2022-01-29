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
    public class ResoundingFinale : Template
    {
        public static readonly Guid ID = Guid.Parse("44ac4799-43c2-4b20-984b-e12c5b4400d3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resounding Finale",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You or an ally benefiting from your composition spell would take sonic damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6c4f3046-d6bf-4915-9c56-c1933de9a3df"), Type = TextBlockType.Text, Text = $"You bring your performance to a sudden, dramatic finish, drowning out other sounds. Your composition spell ends immediately, and all allies that had been benefiting from the spell's effects gain sonic resistance against the triggering damage equal to twice the composition spell's level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("394c1fe5-acaf-44a2-8b51-09a123d16750"), Muses.Instances.Maestro.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("358a4184-8982-4b4e-afad-bb26171431ad"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("97fc82fb-a71f-47f4-803a-d09ad4b67c8e"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("e1cdfab1-f070-47f1-a96a-242eb19615fb"), Traits.Instances.Concentrate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e58c311f-2641-4e50-bd61-9a32b2fe9694"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
