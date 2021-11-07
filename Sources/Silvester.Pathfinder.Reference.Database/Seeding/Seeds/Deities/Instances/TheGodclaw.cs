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
    public class TheGodclaw : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Pantheons.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "The Godclaw",
                Edicts = "Eliminate chaos at its root, be an exemplar of order (worthy of not one, but five), seek the universal laws that transcend individual faiths.",
                Anathema = "Rest when there is lawlessness to fight, believe you know or understand more than the pantheon.",
                
                AreasOfConcern = "Discipline, laws, order, strategy.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "The Hellknight Order of the Godclaw reveres a pantheon of five deities:IomedaeandToragare seen as Hellknights (concerned with offensive and defensive combat, respectively),Irorias the epitome of emotionless discipline,Abadaras a keeper of laws, andAsmodeusas a strategist king. Depictions of these deities as part of the Godclaw differ from traditional images, with the deities portrayed as stern, armored paragons of law. Though some members of the Order of the Godclaw dedicate themselves to individual gods, many take the whole pantheon as their patron, receiving spells despite their unorthodox (perhaps even heretical) beliefs." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.PhantomPain.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FireShield.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Dominate.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Morningstar.ID;
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
            yield return Skills.Instances.Society.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Perfection.ID;
            yield return Domains.Instances.Protection.ID;
            yield return Domains.Instances.Tyranny.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 93
            };
        }
    }
}
