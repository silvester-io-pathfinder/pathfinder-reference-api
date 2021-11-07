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
    public class Ylimancha : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.EmpyrealLords.ID,
                AlignmentId = Alignments.Instances.NeutralGood.ID,
                Name = "Ylimancha",
                Edicts = "Teach sustainable fishing, swim in saltwater, ﬂy.",
                Anathema = "Imprison birds or clip their wings, poison coastal waters, overﬁsh, aid Pazuzu or his minions.",
                Title = "Harborwing",
                AreasOfConcern = "Coastal waters, fishers, and flying creatures.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Ylimancha gazes out over the world's coastlines, presiding over coastal waters, fishers, and flying creatures. Also known as Harborwing, she believes in harmony between the seas, the skies, and the beings of the land. Sustenance and resources can be taken from the sea by those on shore, but not so much that the balance is upset. The sea may sometimes encroach on the land, but breakwaters can be built to keep communities on land dry and safe. Ylimancha likewise loves all creatures that fly, though the demon lordPazuzualso claims dominion over them, bringing the two into endless conflict and causing her to mourn deeply each creature he converts to his worship." };
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "Harborwing most often appears as a very large seagull, pure white in color with the head of a Varisian woman with short, dark hair. She sometimes instead appears as a human woman with the head of an osprey. In this form she wears robes that sway like the waves of the sea, their blue folds foaming white at the edges, and she carries a teak longbow strung with gold. When she speaks, her voice carries the sound of the crashing waves. Followers of Ylimancha include fishers, sailors, merfolk, those who make their living on or in the sea, and flying creatures." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FeatherFall.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.FeetToFins.ID);
            builder.GainSpecificSpell(Guid.Parse(""), Spells.Instances.Fly.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            yield break;
        }

        protected override IEnumerable<Guid> GetFavoredRangedWeapons()
        {
            
            yield return RangedWeapons.Instances.Longbow.ID;
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
            yield return Skills.Instances.Acrobatics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Air.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Travel.ID;
            yield return Domains.Instances.Water.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.ChaoticGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 128
            };
        }
    }
}
