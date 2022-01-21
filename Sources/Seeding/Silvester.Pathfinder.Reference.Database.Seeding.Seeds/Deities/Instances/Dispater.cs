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
    public class Dispater : Template
    {
        public static readonly Guid ID = Guid.Parse("845e1ceb-2c48-43b5-8a59-66dbdf43aef3");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Archdevils.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Dispater",
                Edicts = "Uphold absolute law, pursue perfection in your surroundings, speak with refinement.",
                Anathema = "Act above your station, neglect your defenses, betray a lover.",
                Title = "Iron Lord",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("455d0a8a-1283-4819-8b51-a1eb8162fcee"), Type = TextBlockType.Text, Text = "Hell's second layer is the Infernal City, Dis, and its ruler is the archdevil Dispater. The Iron Lord is the architect of the orderly perfection of Hell as a blueprint for the rest of the multiverse, responsible for Dis's own dark and startling perfection. He remains distant from the scheming and machinations of the other archdevils and the Material Plane, instead modeling calm and deliberate action combined with ruthless, merciless arrogance. As the most urbane of the archdevils, he attracts many followers among those who wish to see Hell's dark majesty spread across the universe." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("d599872a-faf6-414f-8253-a971624e713f"), Spells.Instances.Tether.ID);
            builder.GainSpecificSpell(Guid.Parse("fe3be48c-29a2-4da0-90b3-0dc17c876835"), Spells.Instances.Suggestion.ID);
            builder.GainSpecificSpell(Guid.Parse("27082090-428f-4ff3-9b70-e85f31ba72e2"), Spells.Instances.FleshToStone.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Mace.ID;
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
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Cities.ID;
            yield return Domains.Instances.Confidence.ID;
            yield return Domains.Instances.Duty.ID;
            yield return Domains.Instances.Tyranny.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("b50d7bb9-6fa8-4fc7-8407-427bd1d5a1e2"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
