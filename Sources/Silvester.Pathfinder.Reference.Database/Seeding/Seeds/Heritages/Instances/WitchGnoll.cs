using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class WitchGnoll : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Witch Gnoll"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse(""), Type = TextBlockType.Text, Text = "You're a shaggy, dark-furred gnoll capable of making some truly uncanny sounds. You can cast the ghost sound cantrip as an occult innate spell at will. A cantrip is heightened to a spell level equal to half your level rounded up. In addition, you gain a +1 circumstance bonus to checks to Impersonate and Create a Diversion when using only your voice." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.GainSpecificInnateSpell(Guid.Parse(""), Spells.Instances.GhostSound.ID, MagicTraditions.Instances.Occult.ID);
            builder.GainSpecificSkillActionCircumstanceBonus(Guid.Parse(""), SkillActions.Instances.Impersonate.ID, bonus: 1, addendum: "When only using your voice."); 
            builder.GainSpecificSkillActionCircumstanceBonus(Guid.Parse(""), SkillActions.Instances.CreateADiversion.ID, bonus: 1, addendum: "When only using your voice."); 
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse(""),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 112
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Gnoll.ID;
        }
    }
}
