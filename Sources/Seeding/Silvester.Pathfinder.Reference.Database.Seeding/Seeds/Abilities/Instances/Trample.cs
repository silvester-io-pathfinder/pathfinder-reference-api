using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Abilities.Instances
{
    public class Trample : Template
    {
        public static readonly Guid ID = Guid.Parse("d1b80a3d-1b4e-4e8c-8870-30104e061b7b");

        protected override Ability GetAbility()
        {
            return new Ability
            {
                Id = ID,
                Name = "Trample",
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID
            };
        }

        protected override IEnumerable<TextBlock> GetEffects()
        {
            yield return new TextBlock { Id = Guid.Parse("158bb374-a871-4fa7-94c8-2060cf6832dc"), Text = "The monster Strides up to double its Speed and can move through the spaces of creatures of the listed size, Trampling each creature whose space it enters. The monster can attempt to Trample the same creature only once in a single use of Trample. The monster deals the damage of the listed Strike, but trampled creatures can attempt a basic Reflex save at the listed DC (no damage on a critical success, half damage on a success, double damage on a critical failure)." };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("68487b4a-ac58-46ee-be30-1709b9c52907"),
                SourceId = Sources.Instances.Bestiary.ID,
                Page = 344
            };
        }
    }
}
