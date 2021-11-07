using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class Beastkin : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Rare.ID, 
                Name = "Beastkin"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The blood of a beast flows through your veins, granting you the ferocity and might of animals. Only creatures with the humanoid trait can take the beastkin versatile heritage. Choose a type of animal such as bat, eagle, shark, spider, tyrannosaurus, wasp, or wolf. This is the type of animal tied to your heritage and is known as your inherent animal. You gain the beast and beastkin traits, in addition to the traits from your ancestry. You gain the Change Shape ability. You can choose from beastkin feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddPrerequisites(Guid.Parse(""), prerequisites => 
            {
                prerequisites.HaveSpecificTrait(Guid.Parse(""), Traits.Instances.Humanoid.ID);
            });

            builder.GainSpecificTrait(Guid.Parse(""), Traits.Instances.Beast.ID);
            builder.GainSpecificTrait(Guid.Parse(""), Traits.Instances.Beastkin.ID);
            builder.GainSpecificFeat(Guid.Parse(""), Feats.Instances.ChangeShapeBeastkin.ID);

            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse(""), Traits.Instances.Beastkin.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.AncestryGuide.ID,
                Page = 79
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
