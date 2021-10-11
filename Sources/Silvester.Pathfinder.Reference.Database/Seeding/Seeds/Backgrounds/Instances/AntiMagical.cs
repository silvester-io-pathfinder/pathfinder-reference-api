using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Models.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Bindings.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Backgrounds.Instances
{
    public class AntiMagical : Template
    {
        public static readonly Guid ID = Guid.Parse("ca70ec76-9123-4a40-b1db-05b4ad069815");

        protected override Background GetBackground()
        {
            return new Background
            {
                Id = ID, 
                Name = "Anti-Magical",
                RarityId = Rarities.Instances.Rare.ID
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("7f66d889-9439-462f-b9b4-7869812e17c9"), Type = TextBlockType.Text, Text = "Magic has never worked quite right around you. Perhaps you have become a magic-user in spite of that, or perhaps you use your unique ability to fight magic-users." };
        }

        protected override IEnumerable<Effect> GetEffects()
        {
            yield return new RestrictedAbilityBoostEffect
            {
                Id = Guid.Parse("f3d69cf7-0c06-4248-ae59-dfc788ef5dd1"),
                RequiredStats = new StatEffectBinding[]
                {
                    new StatEffectBinding{Id = Guid.Parse("e20970ec-8af9-43ad-ba85-7b0d26cd7978"), StatId = Stats.Instances.Constitution.ID },
                    new StatEffectBinding{Id = Guid.Parse("f1582e8f-9256-4210-8083-8f413785fc8f"), StatId = Stats.Instances.Wisdom.ID }
                }
            };

            yield return new FreeAbilityBoostEffect
            {
                Id = Guid.Parse("7a702d21-a1fa-48ed-9d70-2b8ed579fccb")
            };

            yield return new FreeLoreEffect
            {
                Id = Guid.Parse("6c217be8-d462-423e-9e5d-454d8b473b8d"),
                ProficiencyId = Proficiencies.Instances.Trained.ID,
                Restrictions = "The Lore skill you choose can't be about a magical subject (as determined by the GM if it's unclear)."
            };

            yield return new TraitEffect
            {
                Id = Guid.Parse("ec478f01-29d8-4cf4-bd6c-022ca39cb741"),
                TraitId = Traits.Instances.AntiMagical.ID
            };
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("89db3e88-d359-4ddd-835c-24d9da58607c"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = 30
            };
        }
    }
}
