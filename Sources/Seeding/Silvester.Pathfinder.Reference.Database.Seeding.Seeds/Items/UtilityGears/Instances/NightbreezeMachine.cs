using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.InlineActions;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using Silvester.Pathfinder.Reference.Database.Models.Items.Instances;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Items;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Items.AdventuringGears.Instances
{
    public class NightbreezeMachine : Template
    {
        public static readonly Guid ID = Guid.Parse("8af13c43-e574-46e1-b057-ee736e75dbac");

        protected override AdventuringGear GetAdventuringGear()
        {
            return new AdventuringGear
            {
                Id = ID,
                Name = "Nightbreeze Machine",
            };
        }
        
        protected override void GetDetails(ITextBlockBuilder builder)
        {
            builder.Text(Guid.Parse("552a1e75-dc4f-45b8-be94-1e2c662fc235"), "The nightbreeze machine can turn a scorching hot room into a comfortable one with just the pull of a lever. Its outer shell is a brass cube half as tall as the average human that houses a series of flat metal �blades� in a circular arrangement. When placed on a flat surface, a creature within reach can Interact to flip the lever, turning the machine on. When the machine is active, the blades begin to spin rapidly, setting the air in the room into motion, which cools off the room�s inhabitants. A front-mounted metal grate prevents anyone from coming into accidental contact with the spinning blades without impeding airflow.");
            builder.Text(Guid.Parse("eaa1d06d-4c74-4be2-adfc-4e0cf8b4eb95"), "The nightbreeze machine was recently commissioned by Malduoni, Keeper of the First Law, leader of the nation of Rahadoum. He tasked the country�s brightest inventors with creating devices that would, in his words, �Ensure that no mortal need fear death from the desert heat.� This machine was the first creation to come out of this consolidated engineering effort, but it won�t be the last.");
            builder.Text(Guid.Parse("e0412558-7928-4c48-a844-401ef467e4b8"), "A nightbreeze machine can affect an enclosed area of no more than 50 feet by 50 feet and has negligible effect when used in a larger enclosed area or outside. While active, it reduces the effects of severe heat by one step to mild heat, and reduces extreme heat to severe heat (Core Rulebook page 518). A nightbreeze machine isn�t powerful enough to reduce the effects of incredible heat, though fortunately such heat isn�t found naturally in the deserts of Rahadoum. A nightbreeze machine runs for 8 hours, after which it must be wound in a process that takes 10 minutes to complete. The 8 hours of activity don�t have to be consecutive.");
        }

        protected override void GetTraits(ITraitBindingBuilder<BaseItemTraitBinding, BaseItem> builder)
        {
            builder.Add(Guid.Parse("dbce228c-bc66-4f86-b21f-a1549abd05ff"), Traits.Instances.Uncommon.ID);
            builder.Add(Guid.Parse("f3ebe0af-d4bd-4942-abf2-354e742c5562"), Traits.Instances.Air.ID);
            builder.Add(Guid.Parse("0aafade2-b54d-41f4-bb6b-04e74aec9e57"), Traits.Instances.Clockwork.ID);
        }

        protected override IEnumerable<AdventuringGearVariant> GetAdventuringGearVariants()
        {
            yield return new AdventuringGearVariant
            {
                Id = Guid.Parse("7b640f17-408c-43a5-9443-82bc2a975249"),
                Name = "Nightbreeze Machine",
                Level = 5,
                Price = 12500,
                BulkId = Bulks.Instances.FourBulk.ID,
                RarityId = Rarities.Instances.Uncommon.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf901f55-4c38-4799-a8d1-19bb54a14c8c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 88
            };
        }
    }
}
