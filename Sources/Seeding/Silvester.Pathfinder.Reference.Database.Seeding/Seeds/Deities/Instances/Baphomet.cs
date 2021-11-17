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
    public class Baphomet : Template
    {
        public static readonly Guid ID = Guid.Parse("294d1150-8443-44cc-8ad8-a31e859011ec");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.DemonLords.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Baphomet",
                Edicts = "Confuse paths and roads, outwit your foes instead of overpowering them, pace labyrinths.",
                Anathema = "Kill something that cannot significantly harm you, bargain with.",
                Title = "Lord of the Labyrinth",
                AreasOfConcern = "Beasts, labyrinths, and minotaurs.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("b8a72dfe-a311-4ca4-a00d-dd0fe1eded10"), Type = TextBlockType.Text, Text = "Baphomet, Lord of the Labyrinth, is the demon lord of beasts, labyrinths, and minotaurs. Baphomet was originally a consort ofLamashtuwho achieved demon lord status after escaping from imprisonment in a labyrinth constructed byAsmodeus. Baphomet appears as an enormous emaciated minotaur with feathered wings and a goat-like head that bears three horns, as well as a blazing pentagram branded into his forehead. Baphomet's cults are among the most prolific in Golarion—human-dominated secret societies devoted to the demon lord are present in many cities and may have members ensconced in positions of political power, while most minotaurs prefer his patronage to that of Lamashtu." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("13ce859d-e9de-48ac-92d7-8aaf4a073f70"), Spells.Instances.SummonAnimal.ID);
            builder.GainSpecificSpell(Guid.Parse("105f0e40-f46d-42c1-833a-6b199b3ab1b3"), Spells.Instances.Enlarge.ID);
            builder.GainSpecificSpell(Guid.Parse("c1cad71b-f47c-4364-a54f-fd8c8508b44e"), Spells.Instances.Maze.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Glaive.ID;
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
            yield return Skills.Instances.Survival.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Indulgence.ID;
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Secrecy.ID;
            yield return Domains.Instances.Zeal.ID;
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
                Id = Guid.Parse("5c43196a-b667-4158-a761-3d6aec2c9de1"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
