using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Tables;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Innovations.Instances
{
    public class WeaponInnovation : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Innovation GetInnovation()
        {
            return new Innovation
            {
                Id = ID,
                Name = "Weapon Innovation",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Your innovation is an impossible-looking weapon augmented by numerous unusual mechanisms. It begins with the same statistics as a level 0 common simple or martial weapon of your choice, or another level 0 simple or martial weapon to which you have access. You can instead use the statistics of a 1st-level common simple or martial weapon of your choice, or another 1st-level simple or martial weapon to which you have access, but you must pay the monetary Price for the weapon. An innovation weapon can have fundamental and property runes added to it in the same way as an ordinary weapon. Because of the unique features of your innovation, everyone except you is untrained in it, even if they would normally be trained (or better) in simple or martial weapons. If you use the Overdrive action, you can choose to change the additional damage from Overdrive to fire damage." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Choose one initial weapon modification to apply to your innovation, either from the following or from other initial weapon modifications to which you have access. These modifications grant additional weapon traits, sometimes with extra abilities. A modification might give your weapon the versatile trait with a damage type that the weapon could already deal, either from its base damage type or from an existing versatile trait. In that case, if you select that modification, you can instead choose to give the weapon the versatile trait for a different damage type: bludgeoning, piercing, or slashing." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new GainAnyInnovationModificationEffect
            {
                Id = Guid.Parse(""),
                InnovationModificationTypeId = InnovationModificationTypes.Instances.Initial.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = 17
            };
        }
    }
}
