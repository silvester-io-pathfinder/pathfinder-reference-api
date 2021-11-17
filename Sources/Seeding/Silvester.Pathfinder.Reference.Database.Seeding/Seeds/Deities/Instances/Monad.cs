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
    public class Monad : Template
    {
        public static readonly Guid ID = Guid.Parse("3c95de5e-aa89-4fb1-b62d-93fa9a89dd14");

        protected override Deity GetDeity()
        {
            return new Deity
            {
                Id = ID,
                CategoryId = DeityCategories.Instances.MonitorDemigods.ID,
                AlignmentId = Alignments.Instances.TrueNeutral.ID,
                Name = "Monad",
                Edicts = "Ensure balance between opposing forces, mediate disagreements.",
                Anathema = "Allow your personal motivations to determine a major decision.",
                Title = "The Condition of All",
                AreasOfConcern = "Creation, the infinite, and truth.",
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            
            yield return new TextBlock { Id = Guid.Parse("77cc2199-2572-4072-a532-109b3b68c17d"), Type = TextBlockType.Text, Text = "All aeons come from, return to, are connected with, and are guided by the Monad. The Condition of All is not a deity in the traditional sense. It exists both within and outside the multiverse and has influence over the entirety of existence. Though generally content to allow the multiverse to run its course, the Monad directs its aeons to intervene when events deviate from their ineffable design. Mortal scholars often personify the Monad as the deity of creation, the infinite, and truth. Even so, few worship it, and the Monad pays very little attention to mortal petitioners. Instead, scholars study and plot aeons' actions, striving to discern the Monad's ultimate goal or to uncover universal truths they can exploit for their own purposes. Only a rare few mortals can master the asceticism necessary to connect with the Monad, gaining hidden knowledge and powers akin to those of other divine spellcasters." };
        }

        protected override void GetDevoteeEffect(BooleanEffectBuilder builder)
        {
            builder.GainSpecificSpell(Guid.Parse("cf0903ae-35ef-4846-a535-c92bd2e91134"), Spells.Instances.UnseenServant.ID);
            builder.GainSpecificSpell(Guid.Parse("76ed0118-b64e-4d37-a6a1-0bc18826c461"), Spells.Instances.SpectralHand.ID);
            builder.GainSpecificSpell(Guid.Parse("bb4df773-b010-449a-bb64-be16e5470594"), Spells.Instances.GaseousForm.ID);
        }

        protected override IEnumerable<Guid> GetDivineFonts()
        {
            yield return DivineFonts.Instances.Harm.ID;
            yield return DivineFonts.Instances.Heal.ID;
        }

        protected override IEnumerable<Guid> GetFavoredMeleeWeapons()
        {
            
            yield return MeleeWeapons.Instances.Fist.ID;
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
            yield return Skills.Instances.Occultism.ID;
        }

        protected override IEnumerable<Guid> GetDivineStats()
        {
            
            yield return Stats.Instances.Intelligence.ID;
            yield return Stats.Instances.Wisdom.ID;
        }

        protected override IEnumerable<Guid> GetDomains()
        {
            yield return Domains.Instances.Creation.ID;
            yield return Domains.Instances.Knowledge.ID;
            yield return Domains.Instances.Truth.ID;
            yield return Domains.Instances.Void.ID;
        }

        protected override IEnumerable<Guid> GetFollowerAlignments()
        {
            yield return Alignments.Instances.LawfulNeutral.ID;
            yield return Alignments.Instances.TrueNeutral.ID;
        }

        protected override SourcePage GetSourcePage() 
        {
            return new SourcePage
            {
                Id = Guid.Parse("6def99c9-98dc-453d-a6d1-b27d308554f0"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = 130
            };
        }
    }
}
