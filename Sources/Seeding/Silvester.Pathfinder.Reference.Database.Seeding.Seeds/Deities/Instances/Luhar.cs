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
    public class Luhar : Template
    {
        public static readonly Guid ID = Guid.Parse("022a510c-7c45-4226-b41b-19a2e728de05");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.OldSunGods.ID,
                AlignmentId = Alignments.Instances.LawfulNeutral.ID,
                Name = "Luhar",
                Edicts = "Learn about the night and prepare yourself to face its creatures and dangers, always make time for sleeping and dreams, ensure others never go to sleep scared.",
                Anathema = "Stay up all night without any breaks for sleeping or dreaming, attack a person or creature while they sleep, leave a badly wounded opponent alive and suffering.",
                Title = "The Setting Sun",
                AreasOfConcern = "Death, dreams, and destiny.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("212cc7a2-fca1-4183-afa0-4833310b7e5c"), Type = TextBlockType.Text, Text = "The Lioness Goddess of death, dreams, and destiny. She is most commonly depicted as a lioness with the head of a human woman, dark skinned with bright eyes." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("3a646677-7e74-4ecf-9200-055a9650dff4"), Spells.Instances.Sleep.ID);
            builder.GainSpecificSpell(Guid.Parse("d76970e6-f349-4935-ad94-8d5cfbf49401"), Spells.Instances.InvisibilitySphere.ID);
            builder.GainSpecificSpell(Guid.Parse("078bb022-d34e-4ba4-97bf-b6e27963b939"), Spells.Instances.ShadowWalk.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return Items.MeleeWeapons.Instances.SpikedChain.ID;
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
            yield return Skills.Instances.Stealth.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Dexterity.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Cities.ID;
            yield return Domains.Instances.Darkness.ID;
            yield return Domains.Instances.Dreams.ID;
            yield return Domains.Instances.Sun.ID;
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
                Id = Guid.Parse("99a36fd4-e8ee-43e1-af6d-e929379ef0c3"),
                SourceId = Sources.Instances.Legends.ID,
                Page = 100
            };
        }
    }
}