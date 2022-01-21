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
        public static readonly Guid ID = Guid.Parse("417c1c51-dd26-410f-b330-3b0d61caf3c7");

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
            
            yield return new TextBlock { Id = Guid.Parse("e93da891-8325-48c3-9825-88e0bb61d53e"), Type = TextBlockType.Text, Text = "The Hellknight Order of the Godclaw reveres a pantheon of five deities:IomedaeandToragare seen as Hellknights (concerned with offensive and defensive combat, respectively),Irorias the epitome of emotionless discipline,Abadaras a keeper of laws, andAsmodeusas a strategist king. Depictions of these deities as part of the Godclaw differ from traditional images, with the deities portrayed as stern, armored paragons of law. Though some members of the Order of the Godclaw dedicate themselves to individual gods, many take the whole pantheon as their patron, receiving spells despite their unorthodox (perhaps even heretical) beliefs." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("28f61bd0-80c7-4067-936d-d047e8493996"), Spells.Instances.PhantomPain.ID);
            builder.GainSpecificSpell(Guid.Parse("8f79f8c8-1907-4c3d-8a69-5caf3aa61390"), Spells.Instances.FireShield.ID);
            builder.GainSpecificSpell(Guid.Parse("c66e2215-c67a-469e-979c-4b4fd28eb6e6"), Spells.Instances.Dominate.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Morningstar.ID;
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
                Id = Guid.Parse("e837845c-8e42-473b-a887-05547906a0fe"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 93
            };
        }
    }
}
