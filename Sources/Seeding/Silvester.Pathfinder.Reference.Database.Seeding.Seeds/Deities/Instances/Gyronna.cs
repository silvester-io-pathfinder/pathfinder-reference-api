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
    public class Gyronna : Template
    {
        public static readonly Guid ID = Guid.Parse("a001b4a8-7464-40d5-ac8a-942b7f412766");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.ChaoticEvil.ID,
                Name = "Gyronna",
                Edicts = "Expose hypocrisy (real or imagined) in others, make other creatures miserable, demand bribes to spare creatures from your torments.",
                Anathema = "Allow others to slight you without retaliation, seek the approval of society, forgive those who have wronged you.",
                Title = "The Angry Hag",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield break;
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("6da2f930-ebfb-4474-8368-8299fad69e91"), Spells.Instances.IllOmen.ID);
            builder.GainSpecificSpell(Guid.Parse("2fb2035b-927d-4bbd-b25f-0e6aa597f7af"), Spells.Instances.Paranoia.ID);
            builder.GainSpecificSpell(Guid.Parse("1bf6d0a2-e05a-460a-861f-26402104c548"), Spells.Instances.Feeblemind.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
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
            yield return Skills.Instances.Intimidation.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Wisdom.ID;
            yield return Stats.Instances.Charisma.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Ambition.ID;
            yield return Domains.Instances.Nightmares.ID;
            yield return Domains.Instances.Pain.ID;
            yield return Domains.Instances.Zeal.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralEvil.ID;
            yield return Alignments.Instances.ChaoticEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("581e0946-d1e2-4adb-a56a-710971f771a2"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}