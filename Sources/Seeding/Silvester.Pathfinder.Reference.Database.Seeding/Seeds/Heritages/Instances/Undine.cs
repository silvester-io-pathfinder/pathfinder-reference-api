using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Undine : Template
    {
        public static readonly Guid ID = Guid.Parse("2882ca92-bd0a-43c2-8658-965c1b99830d");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                Name = "Undine"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("572889c0-c8bb-43e0-98e4-8bf6416f1c8e"), Type = TextBlockType.Text, Text = "A water elemental ancestor influences your bloodline. You gain the undine trait, in addition to the traits from your ancestry. You gain a swim Speed of 10 feet and the amphibious trait. Like all creatures with the amphibious trait, you can breathe both water and air. You can choose from undine feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("e40ea4aa-8f48-4062-baac-f5a55fd601af"), Traits.Instances.Undine.ID);
            builder.GainSpecificTrait(Guid.Parse("51d40936-adf6-4fe8-9433-8d2f1b98999f"), Traits.Instances.Amphibious.ID);
            builder.GainSpecificSpeed(Guid.Parse("e96a3b5e-e138-40e5-9467-8d28ea273127"), MovementMethod.Swimming, speed: 10);
            builder.Manual(Guid.Parse("09ef0a37-c5d4-488b-9e84-77c37f401da7"), "You can breathe both water and air.");
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("79dfbdc1-8fe7-41a4-ac75-6a042349b14f"), Traits.Instances.Undine.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e95efed-1442-4f92-8015-6f167ad0fb12"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 118
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Catfolk.ID;
            yield return Gnome.ID;
            yield return Goblin.ID;
            yield return Human.ID;
            yield return Tengu.ID;
            yield return Orc.ID;
            yield return Dwarf.ID;
            yield return Kobold.ID;
            yield return Ratfolk.ID;
            yield return Elf.ID;
            yield return Halfling.ID;
        }
    }
}
