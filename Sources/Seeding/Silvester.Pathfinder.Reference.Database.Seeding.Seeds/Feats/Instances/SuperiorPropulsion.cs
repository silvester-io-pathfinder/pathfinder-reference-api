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
    public class SuperiorPropulsion : Template
    {
        public static readonly Guid ID = Guid.Parse("5c65a773-cbbc-42b1-b42b-9d1196203fae");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Superior Propulsion",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("62b36407-8148-42cb-9c55-cab9ea0a12a1"), Type = TextBlockType.Text, Text = $"By experimenting with the effects of momentum gained from your signature vehicle's movement, you have learned to get more from propulsion than just speed when the pilot pushes the vehicle to its limit. Each time the pilot Drives your signature vehicle as a 2- or 3-action activity and succeeds at the Piloting check, the vehicle produces an additional effect, depending on its method of propulsion. If your signature vehicle has more than one propulsion method, the pilot can select which benefit to gain each time they succeed at the Piloting check to Drive the vehicle as a 2- or 3-action activity." };
            yield return new TextBlock { Id = Guid.Parse("cde0985b-ceec-4d25-a4ca-d0394bd2a7f1"), Type = TextBlockType.Text, Text = $"~ Alchemical: The caustic runoff from the alchemical engines is now weaponized. Creatures adjacent to your signature vehicle when it begins its movement take acid damage equal to your level." };
            yield return new TextBlock { Id = Guid.Parse("230a0835-4aca-459b-91af-e3bf773433f2"), Type = TextBlockType.Text, Text = $"~ Clockwork: More resilient gears allow the vehicle to remain functional, even when damaged. If your signature vehicle is broken, it does not need to make the flat check to avoid losing operating time." };
            yield return new TextBlock { Id = Guid.Parse("26111876-8bfb-4b54-8caf-afe29563b4c8"), Type = TextBlockType.Text, Text = $"~ Magical: The residual magic from your signature vehicle interferes with hostile spells. Pilots, crew, and passengers of the vehicle gain a +1 circumstance bonus to saving throws against spells until the start of the pilot's next turn." };
            yield return new TextBlock { Id = Guid.Parse("a052e0fd-575a-44f1-b18d-4eab1edd5d77"), Type = TextBlockType.Text, Text = $"~ Pulled: You have eased the amount of effort needed for those pulling your signature vehicle to move it. The vehicle gains a +10 circumstance bonus to its Speed." };
            yield return new TextBlock { Id = Guid.Parse("dd15f4fe-a44d-485a-adde-22acdcce765d"), Type = TextBlockType.Text, Text = $"~ Rowed: Reinforced ports protect the rowers below decks from harm. Rowers of your signature vehicle who are below decks have greater cover from attacks from outside the vehicle and are not damaged when the vehicle takes collision damage." };
            yield return new TextBlock { Id = Guid.Parse("78f813b3-2169-44f6-893f-4a497131c895"), Type = TextBlockType.Text, Text = $"~ Steam: The outlet of steam forms a cloud around the vehicle as it moves. For the duration of its movement, your signature vehicle is concealed." };
            yield return new TextBlock { Id = Guid.Parse("4052f3a0-6c45-4207-a9ba-e7b1930ca0b1"), Type = TextBlockType.Text, Text = $"~ Wind: The draft of the wind helps the vehicle turn. During this movement, your signature vehicle can turn normally, rather than needing to move in a straight line as normal for a 2- or 3-action Drive." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b591e884-9a2c-4e3b-aa0f-bd23247ba7a2"), Feats.Instances.VehicleMechanicDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("9353796d-c9b6-4680-b312-77a2f21c143f"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0b33d419-3d79-49fb-bd01-2cc05147a0b2"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
