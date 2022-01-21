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
    public class Barbatos : Template
    {
        public static readonly Guid ID = Guid.Parse("b0053586-2ec3-4975-b2d6-73fb3028e4be");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.Archdevils.ID,
                AlignmentId = Alignments.Instances.LawfulEvil.ID,
                Name = "Barbatos",
                Edicts = "Veil your motives, make dangerous deals, offer incomplete and ruinous knowledge.",
                Anathema = "Hide any plot against your masters, close or interfere with portals to Hell.",
                Title = "The Bearded Lord",
                
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("8d2dafd9-7259-4b38-8af9-b7667a450432"), Type = TextBlockType.Text, Text = "Barbatos is the youngest of the archdevils, and in fact is not truly a devil at all. His true nature remains unknown and perpetually cloaked, but when he appeared at Hell's gates bearing the souls of an entire mortal world and transformed them into Hell's first legion of barbazus as an offering, the Prince of Darkness saw fit to grant Barbatos rulership over Hell's first layer, Avernus. As Hell's doorwarden, Barbatos oversees the spaces between worlds, and his followers are those who tread such interstitial paths and hold no qualms about the ethics of their journeys." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("eed4904a-7dd3-4250-bdcc-6523a5dece2d"), Spells.Instances.MagicFang.ID);
            builder.GainSpecificSpell(Guid.Parse("70403fc3-1371-4df9-a8c1-fed7181fb79d"), Spells.Instances.Paralyze.ID);
            builder.GainSpecificSpell(Guid.Parse("e0462d21-5704-420e-a5fe-2eaa86dba1ab"), Spells.Instances.Clairvoyance.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.Staff.ID;
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
            
            yield return Stats.Instances.Constitution.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Magic.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Travel.ID;
            yield return Domains.Instances.Tyranny.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("bf48b3c2-a54d-4f49-8687-731261d23e57"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 124
            };
        }
    }
}
