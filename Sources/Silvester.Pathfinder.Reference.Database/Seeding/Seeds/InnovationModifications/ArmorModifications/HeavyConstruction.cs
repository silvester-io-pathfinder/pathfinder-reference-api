using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Entities;


using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.InnovationModifications.ArmorModifications
{
    public class HeavyConstruction : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override InnovationModification GetInnovationModification()
        {
            return new InnovationModification
            {
                Id = ID,
                Name = "Heavy Construction",
                Description = "You've expanded your innovation into a heavy bulwark, and your groundbreaking design ensures you don't take any of the drawbacks for such heavy defenses. Your innovation becomes heavy armor, and your proficiency in your innovation armor (but no other heavy armor) advances to be equal to your proficiency in medium armor. If your Strength score is at least 16, you remove the Speed penalty entirely instead of reducing it to –5 feet. The armor's adjusted statistics are: AC Bonus +5; Dex Cap +1; Check Penalty –2; Speed Penalty –10 feet; Strength 16; Bulk 3; Group composite; Armor Traits bulwark.",
                InnovationId = Innovations.Instances.Armor.ID,
                TypeId = InnovationModificationTypes.Instances.Breakthrough.ID
            };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.

        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 21
            };
        }
    }
}
