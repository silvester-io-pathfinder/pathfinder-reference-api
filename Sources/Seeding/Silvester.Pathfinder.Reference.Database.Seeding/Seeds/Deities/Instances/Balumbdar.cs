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
    public class Balumbdar : Template
    {
        public static readonly Guid ID = Guid.Parse("66cd5e41-8a0d-4be9-b7ca-815526c6b0ed");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OtherGods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Balumbdar",
                Edicts = "Grow as large as you can, shelter those smaller and weaker than you, tend large animals and megafauna.",
                Anathema = "Accidentally injure others with your size, topple a massive natural monument, use magic to assume a form smaller than you are.",
                Title = "The World-Shaker",
                AreasOfConcern = "Great size, megafauna, strength.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("c45cc4f3-296a-409c-84ec-91ad95c26bef"), Type = TextBlockType.Text, Text = "Balumbdar, or He Who Is Massive, is the god of all huge things in the world that tower over smaller things. Creatures of great size, such as elephants and dinosaurs, are sacred to him, as are natural features that dominate the landscape like mountains and massive trees. Balumbdar is also a god of strength, but of might born of great size rather than training or skill. Balumbdar is considered brutish and dim-witted by most other gods, but the fact that he towers over them in any interaction means he always commands respect. When he bothers to manifest at all, it is as a startlingly large man with slabs of muscle and equally thick rolls of fat. He sometimes instead appears as a city-sized animal or as imposing clouds, heavy with rain and low to the ground." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("f145608e-1dfb-4bf5-9170-71a47155458a"), Spells.Instances.AntHaul.ID);
            builder.GainSpecificSpell(Guid.Parse("1110c8ab-76ec-43f9-a296-6467ed726d0a"), Spells.Instances.Enlarge.ID);
            builder.GainSpecificSpell(Guid.Parse("d82fa73c-fde8-4ddb-a00a-81094a3ee043"), Spells.Instances.DinosaurForm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Greatclub.ID;
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
            yield return Skills.Instances.Athletics.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Strength.ID;
            yield return Stats.Instances.Constitution.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Might.ID;
            yield return Domains.Instances.Nature.ID;
            yield return Domains.Instances.Perfection.ID;
            yield return Domains.Instances.Protection.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.NeutralGood.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
            yield return Alignments.Instances.NeutralEvil.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("11bf0f18-c785-4843-9b09-583d0923f822"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 134
            };
        }
    }
}
