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
        public static readonly Guid ID = Guid.Parse("28c588d1-dbd2-4a79-b208-3ba11d69569b");

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
            yield return new TextBlock { Id = Guid.Parse("cd5b8e10-5c9a-4496-af24-2f0002c9986c"), Type = TextBlockType.Text, Text = "The blood of a beast flows through your veins, granting you the ferocity and might of animals. Only creatures with the humanoid trait can take the beastkin versatile heritage. Choose a type of animal such as bat, eagle, shark, spider, tyrannosaurus, wasp, or wolf. This is the type of animal tied to your heritage and is known as your inherent animal. You gain the beast and beastkin traits, in addition to the traits from your ancestry. You gain the Change Shape ability. You can choose from beastkin feats and feats from your ancestry whenever you gain an ancestry feat." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.AddPrerequisites(Guid.Parse("666148bf-cc70-4691-9559-6cc3b949d2f4"), prerequisites => 
            {
                prerequisites.HaveSpecificTrait(Guid.Parse("0764f06e-3d7a-45ae-b95f-f4cd931c831a"), Traits.Instances.Humanoid.ID);
            });

            builder.GainSpecificTrait(Guid.Parse("62e543fc-42c8-4c83-b53d-6ce2888e0f72"), Traits.Instances.Beast.ID);
            builder.GainSpecificTrait(Guid.Parse("43a476e7-e7b2-474f-8f8b-aed4bf172cb5"), Traits.Instances.Beastkin.ID);
            builder.GainSpecificFeat(Guid.Parse("13528927-88ae-4db9-aebf-4af3ed091407"), Feats.Instances.ChangeShapeBeastkin.ID);

            builder.UnlockSpecificTraitAncestryFeats(Guid.Parse("5dc1e7ae-4a77-4c4a-b13c-eccc91633ad6"), Traits.Instances.Beastkin.ID);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e538fc8a-668c-458a-b6af-338affe6389d"),
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
