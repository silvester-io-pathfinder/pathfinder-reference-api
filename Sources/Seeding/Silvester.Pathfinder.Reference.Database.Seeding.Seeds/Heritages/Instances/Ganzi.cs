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
    public class Ganzi : Template
    {
        public static readonly Guid ID = Guid.Parse("90300a6c-a67c-4749-9e91-b9b759d20086");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Uncommon.ID, 
                Name = "Ganzi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("2ca13416-9f31-43f7-b559-601f23a51e6c"), Type = TextBlockType.Text, Text = "Your blood is touched by primal chaos. You gain the ganzi trait in addition to the traits from your ancestry. You gain resistance to a single damage type equal to half your level; at the beginning of each day, determine randomly whether this resistance applies to acid, electricity, or sonic damage. You also gain a +1 circumstance bonus to saving throws against effects that would cause you to gain the controlled condition. You can choose from ganzi feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificTrait(Guid.Parse("a97079e7-fdea-4c1b-b962-a895a64977d1"), Traits.Instances.Ganzi.ID);
            //TODO: Add resistance effect.
            //TODO: Add the +1 to controlled condition.
            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("e207ced6-ecaa-46c4-a200-c08cb7d441e3"), Traits.Instances.Ganzi.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("7e82bbb4-2284-49f7-8162-991ddeae59d5"),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 96
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
