using Silvester.Pathfinder.Reference.Database.Models.Prerequisites;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Deities.Instances
{
    public class TheLanternKing : Template
    {
        public static readonly Guid ID = Guid.Parse("d15c5ed7-7543-49d8-b47e-7a141aa38f9e");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Eldest.ID,
                AlignmentId = Alignments.Instances.ChaoticNeutral.ID,
                Name = "The Lantern King",
                Edicts = "Play pranks, seek new jokes, leave lit lanterns in unusual places.",
                Anathema = "Be completely honest, ruin or explain a good joke.",
                Title = "The Laughing Lie",
                AreasOfConcern = "Laughter, mischief, and transformation.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("8dc1bb06-13b6-4ce5-ba19-0b60333eaf88"), Type = TextBlockType.Text, Text = "Although the Lantern King most often appears as a floating ball of light surrounded by runes that form a delicate crown, the Eldest of laughter, mischief, and transformation has taken on a dizzying array of figures. He often adopts alternate shapes to play pranks, and even other Eldest are not immune to his mischievous scheming. Although he insists his pranks are intended only to incite levity and bring down imperious snobs, the chaos he creates in the name of good-natured fun is, to his targets, embarrassing at best and sometimes outright lethal. The Lantern King wanders the First World more than other Eldest, and he can be encountered in crowded markets and lonely byways alike. He is frequently accompanied by the Witchmarket, a traveling caravan of entertainers and merchants that serves as his court." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("f0f10f64-5a7c-496a-a8db-ca4ad54eead3"), Spells.Instances.IllusoryDisguise.ID);
            builder.GainSpecificSpell(Guid.Parse("9102a4f8-3225-47e7-a32b-0171d85d3346"), Spells.Instances.HideousLaughter.ID);
            builder.GainSpecificSpell(Guid.Parse("efd95ec4-c6b9-4749-ab5c-b12da7f98ebe"), Spells.Instances.BalefulPolymorph.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Dagger.ID;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredUnarmedWeapons()
        {
            yield break;
        }

        protected override DivineIntercession? GetDivineIntercession()
        {
            return null;
        }

        protected override IEnumerable<Guid> GetDivineSkills()
        {
            yield return Skills.Instances.Deception.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Change.ID;
            yield return Domains.Instances.Delirium.ID;
            yield return Domains.Instances.Passion.ID;
            yield return Domains.Instances.Trickery.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.ChaoticNeutral.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("87cc9e88-a30e-482b-b2b8-f94ab227e681"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 126
            };
        }
    }
}
