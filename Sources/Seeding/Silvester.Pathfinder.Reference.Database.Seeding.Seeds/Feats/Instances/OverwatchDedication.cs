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
    public class OverwatchDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("403bc1c6-3e7e-4917-85b2-3b2f527bd978");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overwatch Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until after you have gained at least two other feats from the overwatch archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("af2a5e18-ce5e-4d22-9b0c-f4f74d8fdc40"), Type = TextBlockType.Text, Text = $"You have an innate knack for tactical observation, and you've innovated to apply that knack in a variety of ways that allow you to assist your allies. With the help of enhanced visual gear (such as a specially modified telescope, goggled visor, or binoculars), you're keenly aware of the movement of combatants on the battlefield. You quickly and efficiently disperse that information to your nearby allies so they can use it to direct their own observations and reactions to danger." };
            yield return new TextBlock { Id = Guid.Parse("7c40a30d-3edf-4855-8ed2-c4f0a1ebcf55"), Type = TextBlockType.Text, Text = $"You're surrounded by an overwatch field aura in a 30-foot emanation. Your overwatch field aura grants you increased perception and allows you to call out warnings to your allies within the aura to point out threats. This aura has the {ToMarkdownLink<Models.Entities.Trait>("auditory", Traits.Instances.Auditory.ID)} and {ToMarkdownLink<Models.Entities.Trait>("visual", Traits.Instances.Visual.ID)} traits. You and allies within your overwatch field receive a +2 circumstance bonus when using Perception for Initiative checks." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("5047e039-4d88-41e2-bf74-8e5afb987955"), Proficiencies.Instances.Expert.ID, Skills.Instances.Perception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Dedication.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6326147d-de51-454a-88dc-47a2518fce45"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
