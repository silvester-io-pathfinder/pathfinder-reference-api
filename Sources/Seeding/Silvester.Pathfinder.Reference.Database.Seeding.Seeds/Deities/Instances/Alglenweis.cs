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
    public class Alglenweis : Template
    {
        public static readonly Guid ID = Guid.Parse("7a751b72-867e-4986-bfe1-4bccd1c8839f");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.SarkorianGods.ID,
                AlignmentId = Alignments.Instances.ChaoticGood.ID,
                Name = "Alglenweis",
                Edicts = "Strive to perfect an art or craft, protect the monuments of your people, stir others into action.",
                Anathema = "Destroy an artistic creation without providing something in its place, refuse to act if called upon.",
                Title = "Princess of the Rime",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("a8d78f0d-5623-4f3d-be88-d1f7fc6a747b"), Spells.Instances.Agitate.ID);
            builder.GainSpecificSpell(Guid.Parse("8bcd0faf-f279-4d49-bbd8-1628b021edef"), Spells.Instances.Creation.ID);
            builder.GainSpecificSpell(Guid.Parse("0e9b12b9-ca42-47cb-aacd-520e4c2aaa22"), Spells.Instances.ConeOfCold.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.WarFlail.ID;
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
            yield return Skills.Instances.Nature.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Cold.ID;
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Soul.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.ChaoticNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("d09028c6-307c-43fd-a5bd-aa522062b804"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 132
            };
        }
    }
}
