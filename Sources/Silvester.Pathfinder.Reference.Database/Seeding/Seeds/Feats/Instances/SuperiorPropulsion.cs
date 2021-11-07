using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SuperiorPropulsion : Template
    {
        public static readonly Guid ID = Guid.Parse("b5dab28e-d185-46a2-a1e0-ac5b94edb227");

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
            yield return new TextBlock { Id = Guid.Parse("3ebd9a7a-c451-4e57-bb8c-749669fcc476"), Type = TextBlockType.Text, Text = "By experimenting with the effects of momentum gained from your signature vehicle’s movement, you have learned to get more from propulsion than just speed when the pilot pushes the vehicle to its limit. Each time the pilot Drives your signature vehicle as a 2- or 3-action activity and succeeds at the Piloting check, the vehicle produces an additional effect, depending on its method of propulsion. If your signature vehicle has more than one propulsion method, the pilot can select which benefit to gain each time they succeed at the Piloting check to Drive the vehicle as a 2- or 3-action activity." };
            yield return new TextBlock { Id = Guid.Parse("4211517b-5fde-4a00-84a1-55795d615a2e"), Type = TextBlockType.Text, Text = "~ Alchemical: The caustic runoff from the alchemical engines is now weaponized. Creatures adjacent to your signature vehicle when it begins its movement take acid damage equal to your level." };
            yield return new TextBlock { Id = Guid.Parse("56370b61-a403-4595-a35b-e12d179eaf83"), Type = TextBlockType.Text, Text = "~ Clockwork: More resilient gears allow the vehicle to remain functional, even when damaged. If your signature vehicle is broken, it does not need to make the flat check to avoid losing operating time." };
            yield return new TextBlock { Id = Guid.Parse("ca702771-bbca-4dda-99d8-b4886748ed3a"), Type = TextBlockType.Text, Text = "~ Magical: The residual magic from your signature vehicle interferes with hostile spells. Pilots, crew, and passengers of the vehicle gain a +1 circumstance bonus to saving throws against spells until the start of the pilot’s next turn." };
            yield return new TextBlock { Id = Guid.Parse("b3fd1bfc-c735-466c-b063-195c55c525e4"), Type = TextBlockType.Text, Text = "~ Pulled: You have eased the amount of effort needed for those pulling your signature vehicle to move it. The vehicle gains a +10 circumstance bonus to its Speed." };
            yield return new TextBlock { Id = Guid.Parse("41f1fe71-b9b4-43e9-8b9c-b04654d58861"), Type = TextBlockType.Text, Text = "~ Rowed: Reinforced ports protect the rowers below decks from harm. Rowers of your signature vehicle who are below decks have greater cover from attacks from outside the vehicle and are not damaged when the vehicle takes collision damage." };
            yield return new TextBlock { Id = Guid.Parse("d8edca35-6291-4347-b2f9-71e5528b357a"), Type = TextBlockType.Text, Text = "~ Steam: The outlet of steam forms a cloud around the vehicle as it moves. For the duration of its movement, your signature vehicle is concealed." };
            yield return new TextBlock { Id = Guid.Parse("0c42d6e9-19d2-417b-9cbe-bcff17b8ffe6"), Type = TextBlockType.Text, Text = "~ Wind: The draft of the wind helps the vehicle turn. During this movement, your signature vehicle can turn normally, rather than needing to move in a straight line as normal for a 2- or 3-action Drive." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b89a844e-60a1-4b7e-a831-ac64172e1a09"), Feats.Instances.VehicleMechanicDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dc0cab25-f7ed-46f8-86b0-cdfb97fd68a6"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
