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
    public class Valmallos : Template
    {
        public static readonly Guid ID = Guid.Parse("c09d8345-58e2-468e-8e2f-1ef4f7bf36e2");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.MonitorDemigods.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Valmallos",
                Edicts = "Complicate magical techniques, refine arcane fundamentals, teach arcane apprentices to treat magic responsibly.",
                Anathema = "Grant magic to those who cannot use it responsibly, cause a magical disaster, ignore magical misconduct.",
                Title = "The Answering Rite",
                AreasOfConcern = "Ceremonies, magic, and preparation.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("4712f175-bbe7-4db7-86a5-7be25ada0f4e"), Type = TextBlockType.Text, Text = "The Answering Rite is the primordial inevitable of ceremonies, magic, and preparation. Valmallos takes the form of a mechanical giant, his chest open to expose a glowing heart, with scrolls swirling about him like serpents. Valmallos understands all the laws of magic, and sends his agents against those who have acquired magical ability that they have neither earned nor have the discipline to control. Many scholars of magic believe Valmallos is at least partly responsible for the complex material, somatic, and verbal components necessary to perform magic. His followers are spellcasters who seek perfection in the performance and effects of their magic. Though willing to teach magic to others, they cloak their techniques in layers of ritual to weed out those who lack the patience to handle magic properly." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("b9cdfbf6-cd60-4c20-b79d-22a0c898463d"), Spells.Instances.MageArmor.ID);
            builder.GainSpecificSpell(Guid.Parse("80824c96-2c20-4740-8700-9d84ca17ce61"), Spells.Instances.Feeblemind.ID);
            builder.GainSpecificSpell(Guid.Parse("cec0020e-241f-409e-a5a9-a42422392dc4"), Spells.Instances.Contingency.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Kukri.ID;
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
            yield return Skills.Instances.Arcana.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Fate.ID;
            yield return Domains.Instances.Glyph.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Magic.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulGood.ID;
            yield return Alignments.Instances.LawfulNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("4bc0bf3d-9fc5-440e-b584-37ab8ea1baee"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
